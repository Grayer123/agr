# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def inorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        # iteration + stack
        # tc:O(n); sc:O(h)
        if not root:
            return []
        
        res = []
        stack = []
        
        while root or stack:
            while root:
                stack.append(root)
                root = root.left
                
            node = stack.pop()
            res.append(node.val)
            
            if node.right:
                root = node.right
            
        return res
