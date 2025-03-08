class Solution:

    def __init__(self):
        pass

    def convert(self, s: str, numRows: int) -> str:
        res = ""
        strs_arr = ["" for i in range(numRows)]
        pos_s = 0
        stat = True
        for ch in s:
            strs_arr[pos_s] += ch
            if(numRows == 1):
                continue
            elif(stat):
                if(pos_s == numRows - 1):
                    stat = False
                    pos_s -= 1
                else:
                    pos_s += 1
            else:
                if(pos_s == 0):
                    stat = True
                    pos_s += 1
                else:
                    pos_s -= 1

        for i in range(numRows):
            res += strs_arr[i]
        return res
    

if __name__ == "__main__":

    calc = Solution()
    s = "PAYPALISHIRING"
    print(calc.convert(s, 3))