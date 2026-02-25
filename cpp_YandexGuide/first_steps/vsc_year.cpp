#include <iostream>

bool check_of_year(int y);

int main(){

    int year;
    std::cin >> year;

    if( check_of_year(year) ){
        std::cout << "YES\n";
    }else { std::cout << "NO\n"; }

    return 0;
}

bool check_of_year(int y){
    bool res = false;
    if( y % 400 == 0 ){
        res = true;
    }else if ( (y % 4 == 0)  && (y % 100 != 0)){
        res = true;
    }
    return res;
}