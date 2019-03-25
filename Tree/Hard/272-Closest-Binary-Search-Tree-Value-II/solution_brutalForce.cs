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
    public IList<int> ClosestKValues(TreeNode root, double target, int k) {
        // inorder traversal
        // tc:O(n + k); sc:O(n)
        if(root == null || k <= 0) { // corner case
            return new List<int>();
        }
        List<int> list = new List<int>();
        InorderTraversal(root, list);  // in-order traversal to get the sorted sequence 
        int index = BinarySearch(list, target); // binary search to find the index of closest elem to target
        IList<int> res = new List<int>();
        res.Add(list[index]);
        int left = index - 1, right = index + 1; // two pointers to extend to k elems
        while(res.Count < k && (left >= 0 || right < list.Count)) {
            if(left < 0 || right < list.Count && Math.Abs(target - list[left]) > Math.Abs(list[right] - target)) {
                res.Add(list[right]);
                right++;
            }
            else if(right == list.Count || left >= 0 && Math.Abs(target - list[left]) <= Math.Abs(list[right] - target)) {
                res.Add(list[left]);
                left--;
            }
        }
        return res;
    }
    
    private void InorderTraversal(TreeNode root, List<int> list) { // inorder traversal
        if(root == null) {
            return;
        }
        InorderTraversal(root.left, list);
        list.Add(root.val);
        InorderTraversal(root.right, list);
    }
    
    private int BinarySearch(List<int> list, double target) { // binary search
        int left = 0, right = list.Count - 1;
        while(left < right) {
            int mid = left + (right - left) / 2;
            if(list[mid] == target) {
                return mid;
            }
            else if(list[mid] < target) {
                left = mid + 1;
            }
            else {
                right = mid;
            }
        }
        if(left == 0) {
            return left;
        }
        return Math.Abs(target - list[left - 1]) < Math.Abs(target - list[left]) ? left - 1 : left;
    }
}