import sys
from typing import List


def main():
    
    n, k = map(int, input().split())
    arr = [int(i) for i in input().split()]
    if( k > n):
        print(-1)
    else:
        actual_mid = mean_in_subarr(arr, 0, k)
        mx_mid = actual_mid
        i = 0
        j = k - 1
        while( j < n - 1):
            i += 1
            j += 1
            actual_mid += arr[j]/k - arr[i - 1]/k
            if(mx_mid < actual_mid):
                mx_mid = actual_mid
        print(mx_mid)

def mean_in_subarr(arr: List[int], a: int, b: int) -> float: 
    res = 0.0
    count = 0
    for i in range(a, b):
        count += 1
        res += arr[i]
    return res/count

if __name__ == '__main__':
    main()