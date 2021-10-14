# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def postorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        # iteration + stack
        # tc:O(n); sc:O(h)
        if not root:
            return []
        
        res = []
        stack = []
        lastVisited = None
        
        while root or stack:
            while root:  # put root and its left children into stack
                stack.append(root)
                root = root.left
            
            node = stack[-1]  # corresponding to stack.peek()
            
            if node.right and node.right != lastVisited: # node.right has never been visited
                root = node.right
                
            else: # either node.right == null or node.right has been visited
                res.append(node.val)
                stack.pop()
                lastVisited = node # mark the current popped one as lastVisited
            
        return res