class Solution:

    def removeDuplicateLetters(self, s: str) -> str:
        # Последнее вхождение каждого символа
        last_occurrence = {}
        for i, char in enumerate(s):
            last_occurrence[char] = i
        
        stack = []
        seen = set()  # Для отслеживания символов в стеке
        
        for i, char in enumerate(s):
            # Если символ уже в стеке, пропускаем
            if char in seen:
                continue
            
            # Пока стек не пуст, текущий символ меньше вершины стека,
            # и вершина стека встретится позже - извлекаем из стека
            while stack and char < stack[-1] and last_occurrence[stack[-1]] > i:
                removed = stack.pop()
                seen.remove(removed)
            
            # Добавляем текущий символ в стек
            stack.append(char)
            seen.add(char)
        
        return ''.join(stack)
    
if __name__ == "__main__":

    prog = Solution()
