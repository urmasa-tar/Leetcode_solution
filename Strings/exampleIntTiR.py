class Solution:
    def intToRoman(self, num: int) -> str:
        d0 = {
            0: "",
            1: "I",
            2: "II",
            3: "III",
            4: "IV",
            5: "V",
            6: "VI",
            7: "VII",
            8: "VIII",
            9: "IX",
        }
        d3 = {
            1: "M", 
            2: "MM", 
            3: "MMM", 
            0: ""}
        d2 = {
            1: "C",
            2: "CC",
            3: "CCC",
            4: "CD",
            5: "D",
            6: "DC",
            7: "DCC",
            8: "DCCC",
            9: "CM",
            0: "",
        }
        d1 = {
            1: "X",
            2: "XX",
            3: "XXX",
            4: "XL",
            5: "L",
            6: "LX",
            7: "LXX",
            8: "LXXX",
            9: "XC",
            0: "",
        }
        num = str(10000 + num)
        return d3[int(num[1])] + d2[int(num[2])] + d1[int(num[3])] + d0[int(num[4])]