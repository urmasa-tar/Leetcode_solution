from typing import List


class ValidTester:
    
    def __init__(self):
        
        self.dict_to_Str = {
            1:"1",
            2:"2",
            3:"3",
            4:"4",
            5:"5",
            6:"6",
            7:"7",
            8:"8",
            9:"9"
        }
        
        self.dict_to_Num = self.reverse_dict(self.dict_to_Str)
        self.dict_to_Num["."] = 0

    def reverse_dict(self, base_dc: dict) -> dict:
        res = {}
        for key, val in base_dc.items():
            res[val] = key
        return res    
    
    def isValidSudoku(self, board: List[List[str]]) -> bool:
        res = False
        
        res = self.rec_Cycle(0, 0, board)

        return res
    
    def rec_Cycle(self, st: int, col: int, board: List[List[str]]) -> bool:
        res = False
        
        if(self.dict_to_Num[board[st][col]] == 0):
            for i in range(1, 10):
                board[st][col] = self.dict_to_Str[i]
            if(col == 8) and (st == 8):
                res = True
            elif(col == 8):
                res = self.rec_Cycle(st + 1, 0, board)
            else:
                res = self.rec_Cycle(st, col + 1, board)
        else:
            if(col == 8) and (st == 8):
                res = True
            elif(col == 8):
                res = self.rec_Cycle(st + 1, 0, board)
            else:
                res = self.rec_Cycle(st, col + 1, board)
        
        
        return res
    
    def checkCorr(self, st: int, col: int, board: List[List[str]]) -> bool:
        res = True
        # in one row
        for i_col in range(9):
            if(i_col == col):
                continue
            else:
                if(board[st][col] == board[st][i_col]):
                    res = False
                    break
        # in one col
        for i_row in range(9):
            if(i_row == st):
                continue
            else:
                if(board[st][col] == board[i_row][col]):
                    res = False
                    break
        return res
    
if __name__ == "__main__":
    
    solution = ValidTester()
    
    # Test for some parts
    
    
    
    