#include <iostream>

// Объявления функций (прототипы)
bool one_cord(int x_1, int y_1, int x_2, int y_2);
bool same_diagonal(int x_1, int y_1, int x_2, int y_2);
void out_res(int res);

int main(){
    int res = 0;

    int q_x, q_y, aim_x, aim_y;

    std::cin >> q_x;
    std::cin >> q_y;
    std::cin >> aim_x;
    std::cin >> aim_y;

    res = one_cord(q_x, q_y, aim_x, aim_y) || same_diagonal(q_x, q_y, aim_x, aim_y);

    // std::cout << res << '\n';
    out_res(res);

    return res;
}

bool one_cord(int x_1, int y_1, int x_2, int y_2){
    bool res = false;

    if (x_1 == x_2 || y_1 == y_2){ res = true; }

    return res;
}

bool same_diagonal(int x_1, int y_1, int x_2, int y_2){
    bool res = false;
    
    if( (x_1 - y_1) == (x_2 - y_2)){ res = true; }

    return res;
}

void out_res(int res){
    if (res == 0){
        std::cout << "NO\n";
    }else{
        std::cout << "YES\n";
    }
}