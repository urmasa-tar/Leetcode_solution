class Solution:
    
    arr_to_del = ["/", "", " ", "."]
    
    def __init__(self):
        pass
    
    def simplifyPath(self, path: str) -> str:
        res = ""
        priv = []
        for st in self.arr_of_Paths(path):
            if st == ".." and res != "":
                res = res - priv[len(priv) - 1]
                res = res - "/"
                priv.pop()
            else:
                priv.append(st)
                res =  res + "/"
                res = res + st
                
        return res
    
    def arr_of_Paths(self, current_Path: str) -> list[str]:
        
        res = []
        
        res = list(filter(lambda item: item not in self.arr_to_del, current_Path.split("/")))
        
        return res
    
if __name__ == "__main__":
    
    to_Calc = Solution()
    print(to_Calc.simplifyPath("/home/../slt/."))