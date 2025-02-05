from typing import List

class Solution:

    def candy(self, ratings: List[int]) -> int:
        
        res = 0
        index_list = self.ind_of_sorted_arr(ratings)
        candy_count = [0 for i in range(len(ratings))]
        for index in index_list:
            
            need_c = self.min_by_neibor(index, ratings, candy_count)
            candy_count[index] = need_c
            res += need_c

        return res

    def min_by_neibor(self, index, arr_rat, arr_count) -> int:
        res = 1
        if(index != 0):
            #
            if(arr_rat[index - 1] < arr_rat[index] ):
                res = arr_count[index - 1] + 1
        if(index != len(arr_rat) - 1):
            #
            if(arr_rat[index] > arr_rat[index + 1]):
                res = max(res, arr_count[index + 1] + 1)
        return res

    def ind_of_sorted_arr(self, arr: List[int]) -> List[int]:
        indexed_list = [(value, index) for index, value in enumerate(arr)]
        sorted_indexed_list = sorted(indexed_list, key=lambda x: x[0])
        index_res = [index for value, index in sorted_indexed_list]
        return index_res

def main():
    
    Solution.candy()

if __name__ == "__main__":
    main()