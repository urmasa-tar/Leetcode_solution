import sys
from typing import List


def main():
    
    n, m = map(int, input().split())

    matrix = []
    for i in range(n):
        matrix.append([int(j) for j in input().split()])

    print(sum_in_point(matrix, n, m))

def sum_in_point(matrix: List[List[int]], n_rows, m_columns) -> int:

    sum_point = [[0 for i in range(m_columns)] for j in range(n_rows)]

    for row in range(n_rows):
        for column in range(m_columns):
            if(row == 0):
                if(column == 0):
                   sum_point[row][column] = matrix[row][column]
                else:
                   sum_point[row][column] = sum_point[row][column - 1] + matrix[row][column]
            elif(column == 0):
                sum_point[row][column] = sum_point[row - 1][column] + matrix[row][column]
            else:
                sum_point[row][column] = min(sum_point[row - 1][column], sum_point[row][column - 1]) + matrix[row][column]

    return (sum_point[n_rows - 1][m_columns - 1])

if __name__ == '__main__':
    main()