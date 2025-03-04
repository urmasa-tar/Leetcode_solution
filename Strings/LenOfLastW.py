class Solution:
    def lengthOfLastWord(self, s: str) -> int:
        res = 0

        to_arr = s.replace('  ', ' ').split()
        res = self.__repl_Space__(to_arr[-1])

        return res
    
    def __repl_Space__(self, s: str) -> str:
        res = s.replace(' ', '')

        return res

