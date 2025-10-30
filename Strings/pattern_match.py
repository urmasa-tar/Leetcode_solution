class Solution:

    def isMatch(self, s: str, p: str) -> bool:
        
        res = self.rec_check_pattern(s, 0, p, 0)

        return res

    def rec_check_pattern(self, current_str: str, ind_str: int, pattern_str: str, ind_pat: int) -> bool:

        res = False
        # switch case for 0 - False (1 - equal or 1 - ?) 2 - *
        if((len(current_str) =< ind_str) or (len(pattern_str) =< ind_pat)):
            pass
        else:
            check_state = self.is_equal_part(current_str, ind_str, pattern_str, ind_pat)
            if(check_state == 1):
                if((len(current_str) == ind_str + 1) and (len(pattern_str) == ind_pat + 1)):
                    res = True
                else:
                    res = self.rec_check_pattern(current_str, ind_str + 1, pattern_str, ind_pat + 1)
            elif(check_state == 2):
                if((len(current_str) == ind_str + 1) and ( ind_pat + 1 == len(pattern_str))):
                    res = True
                elif(): # check for pattern like a***** for str like ab******
                    pass
                else: # another situations
                    pass

        return res
    
    def is_equal_part(self, str_sym: str, sym_str: int, pattern_sym: str, check_pat: int) -> int:

        res = 0

        if((str_sym[sym_str] == pattern_sym[check_pat]) or(pattern_sym[check_pat] == '?')):
            res = 1
        elif(pattern_sym[check_pat] == "*"):
            res = 2

        return res

    def star_line_check(pattern: str, from_ind: int) -> bool:
        res = True
    
        return res

if __name__ == "__main__":

    prog_test = Solution()