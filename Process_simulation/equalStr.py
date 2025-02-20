class Solution:
    def fullJustify(self, words: List[str], maxWidth: int) -> List[str]:

        res = []
        str_i = 0
        current_n = 0
        for word in words:
            
            if (len(res) == 0):
                res.append([word])
                current_n += len(word)
            elif(len(word) + current_n + len() > maxWidth):
                res[str_i] = 
            else:

            
        return res
    
    def recalc_str() -> str:

        return 