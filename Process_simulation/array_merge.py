import sys
from typing import Optional

class ListNode:
    def __init__(self, val=0, next=None):
         self.val = val
         self.next = next

class Solution:
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        res = None

        cur_list1 = list1
        cur_list2 = list2       

        while(True):
            if(cur_list1 == None):
                if(cur_list2 == None):
                    break
                else:
                    if(res == None):
                        res = cur_list2
                        continue
                    res.next (cur_list2)
                    cur_list2 = cur_list2.next
            elif(cur_list2 == None):
                if(cur_list1 == None):
                    break
                else:
                    res.append(cur_list1)
                    cur_list1 = cur_list1.next
            else:
                if(cur_list1.val <= cur_list2.val):
                    res.append(cur_list1)
                    cur_list1 = cur_list1.next
                else:
                    res.append(cur_list2)
                    cur_list2 = cur_list2.next

        return res

def main():

    main_cl = Solution()
    # print(main_cl.mergeTwoLists())
if __name__ == "__main__":
    main()