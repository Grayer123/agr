/**
 * Definition of TreeNode:
 * class TreeNode {
 * public:
 *     int val;
 *     TreeNode *left, *right;
 *     TreeNode(int val) {
 *         this->val = val;
 *         this->left = this->right = NULL;
 *     }
 * }
 */

class ResultType {
public:
    bool pExists, qExists;
    TreeNode* lca;
    ResultType(bool p, bool q, TreeNode* l) {
        this->pExists = p;
        this->qExists = q;
        this->lca = l;
    }
};

class Solution {
public:
    /*
     * @param root: The root of the binary tree.
     * @param A: A TreeNode
     * @param B: A TreeNode
     * @return: Return the LCA of the two nodes.
     */
    TreeNode * lowestCommonAncestor3(TreeNode * root, TreeNode * p, TreeNode * q) {
        // divide and conquer
        // tc:O(n^2); sc:O(h)
        // p and q could be not in the tree
        if(!root) { // corner case
            return root;
        }
        return FindLCA(root, p, q).lca;
    }
    
private:
    ResultType FindLCA(TreeNode* root, TreeNode* p, TreeNode* q) {
        if(!root) {
            return ResultType(false, false, nullptr);
        }
        ResultType left = FindLCA(root->left, p, q);
        ResultType right = FindLCA(root->right, p, q);
        if(left.lca) {
            return left;
        }
        if(right.lca) {
            return right;
        }
        bool pExist = left.pExists || right.pExists || root == p;
        bool qExists = left.qExists || right.qExists || root == q;
        if(pExist && qExists) {
            return ResultType(true, true, root);
        }
        return ResultType(pExist, qExists, nullptr);  
    }
};