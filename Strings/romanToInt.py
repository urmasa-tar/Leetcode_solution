class Solution:

    def romanToInt(self, s: str) -> int:
        dictRom = {'I':1, 'V':5, 'X':10, 'L':50, 'C':100, 'D':500, 'M':1000, '-':10000}
        res = 0
        priv_res = -1
        prev_ch = '-'
        for ch in s:
            num = dictRom[ch]
            if(priv_res == -1):
                priv_res = num
                res += priv_res
            elif(priv_res == 0):
                priv_res = num
                res += num
            else:
                if(dictRom[prev_ch] < num):
                    res += num - (2 * priv_res)
                elif(dictRom[prev_ch] == num):
                    res += num
                    priv_res += num
                else:
                    res += num
                    priv_res = num

            prev_ch = ch

        return res

if __name__ == "__main__":
    calc_obj = Solution()
    test_str = "MCMXCIV"
    print(Solution.romanToInt('', test_str))
    # print(type(test_str))