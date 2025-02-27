

class Solution:

    def longestPalindrome(self, s: str) -> str:
        
        res = s[0]

        if(len(s) <= 1):
            res = s
        else:
          for i in range(len(s) - 1):
            odd = self.expand_from_center(res, i, i)
            even = self.expand_from_center(res, i, i + 1)

            if len(odd) > len(res):
                res = odd
            if len(even) > len(res):
                res = even  

        return res
    
    def expand_from_center(self, s: str, left: int, right: int):
            while left >= 0 and right < len(s) and s[left] == s[right]:
                left -= 1
                right += 1
            return s[left + 1:right]

if __name__ == '__main__':

    calc = Solution()

    s = input()

    print(calc.longestPalindrome(s))