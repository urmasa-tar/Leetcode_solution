import sys


def main():
    
    n, m = map(int, input().split())

    print(sum_of_ways(n,m))

def sum_of_ways(n, m):

    pos_x = 0
    pos_y = 0

    return rec_from_point() + rec_from_point()

def rec_from_point() -> int:
    res = 0

    return res

def is_in_board(n, m, y, x) -> bool:
    return (( y <= (n - 1)) and (x <= (m - 1)))

if __name__ == '__main__':
    main()