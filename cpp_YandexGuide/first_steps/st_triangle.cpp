#include <algorithm>
#include <iostream>
#include <cmath>

bool prn_anser(double a, double b, double c);

int main(){

    int res = 0;
    double a, b, c;

    double arr[3];
    for(int i = 0; i < 3; i++){
        std::cin >> arr[i]; 
    }

    int n = sizeof(arr) / sizeof(arr[0]);
    std::sort(arr, arr + n);

    a = arr[2];
    b = arr[1];
    c = arr[0];

    prn_anser(a, b, c);

    return 0;
}

bool prn_anser(double a, double b, double c){
    bool res = false;

    if( (a*a) == (b*b + c*c)){
        res = true;
        std::cout << "YES\n";
    }else{
        std::cout << "UNDEFINED\n";
    }

    return res;
}