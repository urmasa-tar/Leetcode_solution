class Solution:
    def removeKdigits(num, k):
        stack = []
        
        for digit in num:
            # Удаляем из стека цифры, которые больше текущей (пока есть k)
            while k > 0 and stack and stack[-1] > digit:
                stack.pop()
                k -= 1
            stack.append(digit)
        
        # Если остались удаления - убираем с конца
        if k > 0:
            stack = stack[:-k]
        
        # Удаляем ведущие нули и формируем результат
        result = ''.join(stack).lstrip('0')
        
        return result if result else "0"