class Solution:
    
    arr_to_del = ["/", "", " ", "."]
    
    def __init__(self):
        pass
    
    def simplifyPath(self, path: str) -> str:
        res = ""
        priv = []
        for st in self.arr_of_Paths(path):
            if st == ".." and res != "":
                res = self.last_Substr(res, priv[len(priv) - 1])
                res = self.last_Substr(res, "/")
                priv.pop()
            else:
                priv.append(st)
                res =  res + "/"
                res = res + st
                
        return res
    
    def arr_of_Paths(self, current_Path: str) -> list[str]:
        res = []
        res = list(filter(lambda item: item not in self.arr_to_del, current_Path.split("/")))
        # print(res)
        return res
    
    def last_Substr(self, st: str, sub: str) -> str:
        res = ""
        index = st.rfind(sub)
        if index != -1 and len(sub) != 1:
            res = st[:index] + st[index + len(sub) - 1]
        elif len(sub) == 1:
            res = st[:index]
        return res
    
if __name__ == "__main__":
    
    to_Calc = Solution()
    print(to_Calc.simplifyPath("/home/../slt/."))