#include <iostream>

int main(){

    return 0;
}

int month_check(){
    int res = 0;

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

