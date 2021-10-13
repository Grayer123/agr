# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

# Version 2: Nested Def and nonlocal
class Solution:
    def maxPathSum(self, root: Optional[TreeNode]) -> int:
        def getMaxOnOneSide(node):            
            if not node:
                return 0
            
            nonlocal maxSum
            # value < 0 would not contribute to the max path
            left = max(getMaxOnOneSide(node.left), 0)
            right = max(getMaxOnOneSide(node.right), 0)
            
            # start a new path with current node as the root (highest node)
            priceNewPath = node.val + left + right
            maxSum = max(maxSum, priceNewPath)
            
            # for recursion: return the max gain if continue the same path from bottom to top
            return node.val + max(left, right)
        
        maxSum = float('-inf')
        getMaxOnOneSide(root)
        return maxSum