/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class BSTIterator {
        // in-order traversal
        // total tc:O(n); sc:O(h)
    public BSTIterator(TreeNode root) {
        if(root == null) {
            return;
        }
        AddLeftNode(root);
    }
    
    /** @return the next smallest number */
    public int Next() {
        // fetch next takes O(1) + right node not null => add its all left children to stack
        if(stack.Count == 0) {
            throw new Exception("Cannot fetch next from a empty tree.");
        }
        TreeNode node = stack.Pop();
        if(node.right != null) {
            AddLeftNode(node.right);
        }
        return node.val;
    }
    
    /** @return whether we have a next smallest number */
    public bool HasNext() {
        // tc:O(1)
        return stack.Count > 0;
    }
    
    private Stack<TreeNode> stack = new Stack<TreeNode>();
    
    private void AddLeftNode(TreeNode node) {
        while(node != null) {
            stack.Push(node);
            node = node.left;
        }
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */