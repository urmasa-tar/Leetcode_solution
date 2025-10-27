class Solution:
    def countAndSay(self, n: int) -> str:

        res = "1"

        if( n > 1):
            res = ""
            n_to_str = str(n)
            for cycle in range(n):
                n_to_str = self.str_update(n_to_str)
        else:
            res = "1"

        return res

    def str_update(self, str_last: str) -> str:

        res = ""
        count_sr = -1
        past_chr = 'c'

        for ch in str_last:
            if ch == past_chr:
                count_sr += 1
            elif past_chr != 'c':
                res += str(count_sr)
                res += past_chr
                count_sr = 1
                past_chr = ch
            else:
                count_sr = 1
                past_chr = ch

        return res

if __name__ == "__main__":

    prog = Solution()