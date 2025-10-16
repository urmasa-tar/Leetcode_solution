import sys
from typing import List

class Solution:

    alphabet_pin = {
        1: 'a', 2: 'b', 3: 'c', 4: 'd', 5: 'e', 
        6: 'f', 7: 'g', 8: 'h', 9: 'i', 10: 'j',
        11: 'k', 12: 'l', 13: 'm', 14: 'n', 15: 'o',
        16: 'p', 17: 'q', 18: 'r', 19: 's', 20: 't',
        21: 'u', 22: 'v', 23: 'w', 24: 'x', 25: 'y', 26: 'z'
    }

    def main(self):
        
        num_bind = int(input())
        arr_bind = input().split()
        
        # print(arr_bind)
        file_ln = int(input())
        arr_of_file_str = [] 
        for i in range(file_ln):
            str_file = input().split()
            arr_of_file_str.append(str_file)
        
        # print(arr_of_file_str)
        # print(type(arr_of_file_str))

        print(self.pars_file(num_bind, file_ln, arr_bind, arr_of_file_str))

    def pars_file(self, patterns_ln: int, file_ln: int, patterns: List[str], arr_of_file_str: List[List[str]]) -> str:

        dict_pins = self.dict_creation(patterns, patterns_ln)
        #print(type(dict_pins))
        res = ""

        for str_file in arr_of_file_str:
            for word in str_file:
                if(word in dict_pins.items()):
                    res += " " + dict_pins[word]
                else:
                    res += " " + word

        return res

    def dict_creation(self, pin_words: List[str], count_st: int) -> dict:
        res = {}
        if(count_st > 4):
            for word in range(4, count_st):
                res[pin_words[word]] = self.number_to_alpha(word - 3)
        return res

    def number_to_alpha(self, num):
        """Переводит число в 26-ричную систему с буквами a-z"""
        result = ""
        while num > 0:
            num -= 1  # потому что у нас 1-based система (1='a', а не 0='a')
            remainder = num % 26
            result = chr(97 + remainder) + result  # 97 - код буквы 'a'
            num = num // 26
        return result if result else "a"

if __name__ == '__main__':
    prog = Solution()
    prog.main()