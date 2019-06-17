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
        // postorder + dfs + hashtable + serializationString
        // tc:O(n^2); sc:O(n^2): key of hashtable is a string, take O(sizeof(key)) time => could be O(n) for this step
        if(root == null) {
            return new List<TreeNode>();
        }
        Dictionary<string, int> serialDict = new Dictionary<string, int>();
        IList<TreeNode> res = new List<TreeNode>();
        Serialize(root, serialDict, res);
        return res;
    }
    
    private string Serialize(TreeNode node, Dictionary<string, int> serialDict, IList<TreeNode> res) {
        if(node == null) {
            return String.Empty;
        }
        string ser = node.val.ToString() + ',' + Serialize(node.left, serialDict, res) + ',' + Serialize(node.right, serialDict, res); // postorder
        serialDict[ser] = serialDict.ContainsKey(ser) ? ++serialDict[ser] : 1;
        if(serialDict[ser] == 2) {
            res.Add(node);
        }
        return ser;
    }
}