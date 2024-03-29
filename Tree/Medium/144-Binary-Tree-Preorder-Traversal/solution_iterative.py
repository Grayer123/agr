# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

# version 2: no adding a helper method
class Solution:
    def preorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        # iteration + stack
        # tc:O(n); sc:O(h)
        
        if not root:
            return []
        
        res = []
        stack = [root]
        
        while stack:
            node = stack.pop()
            res.append(node.val)
            
            # since stack is FILO, so put in right first, and it would be popped last
            if node.right:
                stack.append(node.right)
                
            if node.left:
                stack.append(node.left)
            
        return res
        