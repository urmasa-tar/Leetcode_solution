using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddListNumbers
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode res = new ListNode();
            ListNode step = res;
            while (true)
            {
                step.val = 0;
                if (l1.next == null && l2.next == null)
                {
                    break;
                }
                else if (l1.next == null)
                {
                    step = addOne(step, l2.val);
                    l2 = l2.next;
                }
                else if (l2.next == null)
                {
                    step = addOne(step, l1.val);
                    l1 = l1.next;
                }
                else
                {
                    step = isSum(step, l1.val, l2.val);
                    l1 = l1.next;
                    l2 = l2.next;
                }
            }
            return res;
        }

        private ListNode addOne(ListNode current, int add)
        {
            ListNode res = current;
            res.val = add;

            return res.next;
        }

        private ListNode isSum(ListNode current, int s1, int s2)
        {
            ListNode res = current;
            res.val = s1 + s2;

            return res.next;
        }

    }
}
