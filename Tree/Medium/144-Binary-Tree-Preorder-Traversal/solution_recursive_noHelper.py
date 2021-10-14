# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

# version 2: no adding a helper method
class Solution:
    def preorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        # recursive
        # tc:O(n); sc:O(h)
        
        if not root:
            return []
        
        res = [root.val]
        
        left = self.preorderTraversal(root.left)
        right = self.preorderTraversal(root.right)
        
        res.extend(left)
        res.extend(right)
        
        return res
        