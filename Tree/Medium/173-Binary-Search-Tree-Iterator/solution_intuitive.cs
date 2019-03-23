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
    // total tc:O(n); sc:O(n)

    public BSTIterator(TreeNode root) {
        if(root == null) {
            return;
        }
        Stack<TreeNode> stack = new Stack<TreeNode>();        
        TreeNode cur = root;
        while(stack.Count > 0 || cur != null) {
            while(cur != null) {
                stack.Push(cur);
                cur = cur.left;
            }
            TreeNode node = stack.Pop();
            queue.Enqueue(node);
            if(node.right != null) {
                cur = node.right;
            }
        }
        
    }
    
    /** @return the next smallest number */
    public int Next() {
        if(queue.Count == 0) {
            throw new Exception("Cannot fetch next from a empty tree");
        }
        return queue.Dequeue().val;
    }
    
    /** @return whether we have a next smallest number */
    public bool HasNext() {
        return queue.Count > 0;
    }
    
    private Queue<TreeNode> queue = new Queue<TreeNode>();
    
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */