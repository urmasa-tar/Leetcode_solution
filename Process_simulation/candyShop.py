from typing import List

class Solution:

    def candy(self, ratings: List[int]) -> int:
        
        res = 0
        index_list = self.ind_of_sorted_arr()
        candy_count = [0 for i in range(len(ratings))]
        for index in index_list:
            
            need_c = self.min_by_neibor()

        return res

    def min_by_neibor(self, index, arr, arr_count) -> int:

        if(index == 0):
            #
        elif(index == len(arr)):
            #
        else:
            #

        return None

    def ind_of_sorted_arr(self, arr: List[int]) -> List[int]:

        indexed_list = [(value, index) for index, value in enumerate(arr)]
        sorted_indexed_list = sorted(indexed_list, key=lambda x: x[0])
        index_res = [index for value, index in sorted_indexed_list]

        return index_res

def main():
    
    Solution.candy()

if __name__ == "__main__":
    main()