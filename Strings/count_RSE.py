from typing import List

class Solution:
    
    def countAndSay(self, n: int) -> str:
        if n == 1:
            return "1"
        
        # Получаем предыдущую последовательность
        prev = self.countAndSay(n - 1)
        result = []
        count = 1
        
        # Обрабатываем предыдущую последовательность
        for i in range(1, len(prev)):
            if prev[i] == prev[i - 1]:
                count += 1
            else:
                result.append(str(count))
                result.append(prev[i - 1])
                count = 1
        
        # Добавляем последнюю группу символов
        result.append(str(count))
        result.append(prev[-1])
        
        return ''.join(result)
    
    # Вспомогательный метод для преобразования числа в массив цифр (если нужен для других целей)
    def int_to_arr(self, num: int) -> List[int]:
        res_arr = []
        
        while num > 0:
            res_arr.append(num % 10)
            num = num // 10  # Целочисленное деление!
        
        res_arr.reverse()  # reverse() изменяет список на месте, не возвращает новый
        return res_arr

if __name__ == "__main__":
    prog = Solution()
    
    # Тестируем для небольших значений
    for i in range(1, 10):
        print(f"countAndSay({i}) = '{prog.countAndSay(i)}'")