/**
 * Definition of ParentTreeNode:
 * class ParentTreeNode {
 * public:
 *     int val;
 *     ParentTreeNode *parent, *left, *right;
 * }
 */


class Solution {
public:
    /*
     * @param root: The root of the tree
     * @param A: node in the tree
     * @param B: node in the tree
     * @return: The lowest common ancestor of A and B
     */
    ParentTreeNode * lowestCommonAncestorII(ParentTreeNode * root, ParentTreeNode * A, ParentTreeNode * B) {
        // divide and conquer
        // tc:O(n); sc:O(n)
        if(root == nullptr) {
            return root;
        }
        auto ancestorsA = getAncestors(A);
        auto ancestorsB = getAncestors(B);
        int indexA = ancestorsA.size() - 1, indexB = ancestorsB.size() - 1; // from last node => root => must be the common ancestor
        ParentTreeNode* res = nullptr;
        while(indexA >= 0 && indexB >= 0) { 
            if(ancestorsA[indexA] != ancestorsB[indexB]) {
                break;
            }
            res = ancestorsA[indexA]; // since ancestorsA[indexA] == ancestorsB[indexB], so either one works
            indexA--;
            indexB--;
        }
        return res;
    }

private:
    vector<ParentTreeNode*> getAncestors(ParentTreeNode * node) {
        vector<ParentTreeNode*> ancestors;
        while(node) {
            ancestors.push_back(node);
            node = node->parent;
        }
        return ancestors;
    }
};