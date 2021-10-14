# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

# version 1: nested method
class Solution:
    def preorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        # recursive
        # tc:O(n); sc:O(h)
        res = []
        
        def traverse(node: TreeNode):
            if node is None:
                return
            
            nonlocal res
            res.append(node.val)
            
            traverse(node.left)
            traverse(node.right)
            
        traverse(root)
        
        return res
