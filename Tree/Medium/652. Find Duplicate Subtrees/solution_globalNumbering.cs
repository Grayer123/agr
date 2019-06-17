/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<TreeNode> FindDuplicateSubtrees(TreeNode root) {
        // postorder + dfs + hashtable + global value numbering
        // tc:O(n); sc:O(n)
        if(root == null) {
            return new List<TreeNode>();
        }
        Dictionary<string, int> nodeNumbering = new Dictionary<string, int>();
        Dictionary<int, int> numberingCount = new Dictionary<int, int>();
        IList<TreeNode> res = new List<TreeNode>();
        int globalCount = 1;
        lookup(root, nodeNumbering, numberingCount, ref globalCount, res);
        return res;
    }
    
    private int lookup(TreeNode node, Dictionary<string, int> nodeNumbering, Dictionary<int, int> numberingCount, ref int globalCount, IList<TreeNode> res) {
        if(node == null) {
            return 0;
        }
        int left = lookup(node.left, nodeNumbering, numberingCount, ref globalCount, res);
        int right = lookup(node.right, nodeNumbering, numberingCount, ref globalCount, res);
        string serial = node.val.ToString() + ',' + left.ToString() + ',' + right.ToString(); // postorder
        if(!nodeNumbering.ContainsKey(serial)) {
            nodeNumbering[serial] = globalCount;
            globalCount++;
        }
        numberingCount[nodeNumbering[serial]] = numberingCount.ContainsKey(nodeNumbering[serial]) ? ++numberingCount[nodeNumbering[serial]] : 1;
        if(numberingCount[nodeNumbering[serial]] == 2) {
            res.Add(node);
        }
        return nodeNumbering[serial];
    }
}