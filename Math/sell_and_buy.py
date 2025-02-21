from typing import List


class Solution:

    def __rec_solution__(self, prices: List[int], index: int, stock = 0) -> int:
        res = 0
        if(index == len(prices) - 1):
            if( stock > 0):
                res += prices[index]
        elif(stock == 0):
            res = max(self.__rec_solution__(prices, index + 1, stock + 1) - prices[index],
                            self.__rec_solution__(prices, index + 1, stock))
        else:
            res = max(self.__rec_solution__(prices, index + 1, stock - 1) + prices[index],
                            self.__rec_solution__(prices, index + 1, stock))
        return res
            # res on_hand

    def maxProfit(self, prices: List[int]) -> int:
        # calc from end with recurtion
        res = 0
        res = max(res, self.__rec_solution__(prices, 0))
        return res

if __name__ == "__main__":

    calc = Solution()
    test_arr = [int(i) for i in input().split()]
    print(calc.maxProfit(test_arr))
