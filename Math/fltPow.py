class Solution:
    def myPow(self, x: float, n: int) -> float:
        res = 0
        if(n > 0):
            res = 1
            for i in range(n):
                res *= x
            
        elif(n < 0):
            res = 1
            for i in range(n * -1):
                res /= x
        else:
            res = 1

        return res