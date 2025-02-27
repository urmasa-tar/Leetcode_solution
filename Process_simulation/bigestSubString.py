
# Bad calc time
class Solution:

    def longestPalindrome(self, s: str) -> str:
        
        res = s[0]

        for ind in range(len(s)):
            j = len(s) - 1      # Correct range !
            for j in range(len(s) - 1, ind, -1):
                if(s[ind] == s[j]):     
                    if(self.check_sub_str(s, ind, j)):
                        res = self.bigger_str(res, s[ind : j + 1]) # How to get sub str !
                else:
                    continue
        return res
    
    def check_sub_str(self, s: str, start: int, end: int) -> bool:
        res = True
        j = 0
        for i in range(start, end):
            if(i == end - j):
                break
            elif(s[i] == s[end - j]):
                j += 1
            else:
                res = False

        return res

    def bigger_str(self, s1: str, s2: str):
        res = s1
        if(len(s2) > len(s1)):
            res = s2
        return res

if __name__ == '__main__':

    calc = Solution()

    # st_test = input()
    st_test = 'erertrere'
    print(calc.longestPalindrome(st_test))