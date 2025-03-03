class Solution:

    dictRom = {'I':1, 'V':5, 'X':10, 'L':50, 'C':100, 'D':500, 'M':1000}

    def __init__(self):
        self.dictInt = {value: key for key, value in self.dictRom.items()}

    def intToRoman(self, num: int) -> str:
        res_s = ""
        mx_posible = self.__calc_mx_Rom__()
        
        return res_s
    
    def __calc_mx_Rom__(self) -> int:
        res = [itm * 3 for itm in self.dictInt.keys()]
        return sum(res)