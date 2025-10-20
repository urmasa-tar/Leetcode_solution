class Solution:
    def longestPalindrome(self, s: str) -> str:
        if len(s) <= 1:
            return s
        
        # Преобразуем строку для обработки четных/нечетных палиндромов
        T = "#" + "#".join(s) + "#"
        n = len(T)
        P = [0] * n  # Длины палиндромов для каждой позиции
        center = right = 0
        max_len = 0
        max_center = 0
        
        for i in range(n):
            # Используем симметрию для инициализации
            if i < right:
                mirror = 2 * center - i
                P[i] = min(right - i, P[mirror])
            
            # Пытаемся расширить палиндром
            a = i + (1 + P[i])
            b = i - (1 + P[i])
            while a < n and b >= 0 and T[a] == T[b]:
                P[i] += 1
                a += 1
                b -= 1
            
            # Обновляем центр и правую границу
            if i + P[i] > right:
                center = i
                right = i + P[i]
            
            # Обновляем максимальный палиндром
            if P[i] > max_len:
                max_len = P[i]
                max_center = i
        
        # Восстанавливаем исходную подстроку
        start = (max_center - max_len) // 2
        return s[start:start + max_len]

if __name__ == "__main__":

    prog = Solution()