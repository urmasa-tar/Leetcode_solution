import sys


def main():
    
    n, m = map(int, input().split())

    print(sum_of_ways(n,m))

def sum_of_ways(n, m):

    pos_x = 0
    pos_y = 0

    return rec_from_point(pos_y + 2, pos_x + 1, n, m) + rec_from_point(pos_y + 1, pos_x + 2, n, m)

def rec_from_point(y: int, x: int, n: int, m: int) -> int:
    res = 0
    if(is_in_board(n, m, y, x) and ((y != (n - 1)) and x != (m - 1))):
        res += rec_from_point(y + 2, x + 1, n, m) + rec_from_point(y + 1, x + 2, n, m)
    elif((y == (n - 1)) and (x == (m - 1))): res += 1
    return res

def is_in_board(n, m, y, x) -> bool:
    return (( y <= (n - 1)) and (x <= (m - 1)))

if __name__ == '__main__':
    main()