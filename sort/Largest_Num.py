from typing import List


class Solution:

    class Pair_nums():

        def __init__(self, ln: int, lst_num: List[int]):
            
            self.lst_num = lst_num
            self.ln = ln

        def __repr__(self):
            return f"Pair_nums({self.ln}, {self.lst_num})"

        def __str__(self):
            return ''.join(map(str, self.lst_num))
    
        # Методы сравнения для сортировки
        def __lt__(self, other):
            """Меньше (<) - для сортировки от большего к меньшему"""
            # Сравниваем по цифрам слева направо
            for i in range(min(self.ln, other.ln)):
                if self.lst_num[i] != other.lst_num[i]:
                    return self.lst_num[i] > other.lst_num[i]  # Большая цифра идет первой
            
            # Если первые цифры одинаковы, меньшее число идет первым
            if self.ln == other.ln:
                return False  # числа равны
            elif self.ln < other.ln:
                return True   # меньшее число идет первым
            else:
                return False
        
        def __gt__(self, other):
            """Больше (>)"""
            return other < self
        
        def __eq__(self, other):
            """Равно (==)"""
            return self.ln == other.ln and self.lst_num == other.lst_num
        
        def __le__(self, other):
            """Меньше или равно (<=)"""
            return self < other or self == other
        
        def __ge__(self, other):
            """Больше или равно (>=)"""
            return self > other or self == other
        
        def __ne__(self, other):
            """Не равно (!=)"""
            return not self == other

    def largestNumber(self, nums: List[int]) -> str:
        res = ""
        
        return res
    
    def tests_function(arr: List[int]) -> bool:
        # Проверяем конкретные случаи
        nums_arr = [Pair_nums(i, i) for i in arr]
        test_cases = [
            (nums_arr(1, [9]), nums_arr(1, [7])),  # 9 перед 7 ✓
            (nums_arr(2, [9, 2]), nums_arr(2, [9, 1])),  # 92 перед 91 ✓
            (nums_arr(3, [9, 9, 9]), nums_arr(5, [9, 9, 9, 9, 1])),  # 999 перед 99991 ✓
        ]

        for a, b in test_cases:
            print(f"{a} < {b}: {a < b}")  # Должно быть True для всех случаев


    def ln_of_int(n: int) -> int:
        res = 0

        return res

if __name__ == "__main__":

    prog_res = Solution()
