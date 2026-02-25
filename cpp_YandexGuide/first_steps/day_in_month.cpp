#include <iostream>

int month_check(int month, int year);
bool check_of_year(int y);

int main(){

    int month, year;
    std::cin >> month >> year;

    std::cout << month_check(month, year) << "\n";

    return 0;
}

int month_check(int month, int year){
    int res = 31;

    bool is_vsc = check_of_year(year);
    if(month == 2 && is_vsc){
        res = 29;
    }else if (month == 2){ res = 28; }
    else if ( (month < 7) && (month % 2 == 0)){ res = 30; }
    else if ( (month > 7) && (month % 2 == 1)){ res = 30; }

    return res;
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

