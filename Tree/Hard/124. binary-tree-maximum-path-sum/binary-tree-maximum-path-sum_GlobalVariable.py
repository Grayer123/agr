# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

# Version 1: Global Variable
class Solution:
    # initiate maxSum as the MinValue of int
    def __init__(self):
        self.maxSum = float('-inf')
    
    def maxPathSum(self, root: Optional[TreeNode]) -> int:
        self.getMaxOnOneSide(root)
        return self.maxSum
    
    def getMaxOnOneSide(self, node):            
        if not node:
            return 0

        # nonlocal maxSum
        # value < 0 would not contribute to the max path
        left = max(self.getMaxOnOneSide(node.left), 0)
        right = max(self.getMaxOnOneSide(node.right), 0)

        # start a new path with current node as the root (highest node)
        priceNewPath = node.val + left + right;
        self.maxSum = max(self.maxSum, priceNewPath)

        # for recursion: return the max gain if continue the same path from bottom to top
        return node.val + max(left, right)