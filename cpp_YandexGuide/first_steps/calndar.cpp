#include <iostream>

void prnt_all_days(int first_wk_day, int max_day);

int main(){

    int n, k;
    std::cin >> n >> k;

    prnt_all_days(n, k);

    return 0;
}

void prnt_all_days(int first_wk_day, int max_day){
    bool frst_wk = true;
    int day_of_mn = 1;
    while(true){
        bool out = false;

        // New week
        std::cout << " ";
        for(int day = 1; day < 8; day++){

            if( ( frst_wk ) && ( day == first_wk_day ) ){
                // Maybe special function
                std::cout << day_of_mn << " ";
                day_of_mn++;
                frst_wk = false;
            }else if( !frst_wk ){
                std::cout << day_of_mn << " ";
                day_of_mn++;
            }else if( frst_wk ){
                std::cout << "  ";
            }

            if(day_of_mn > max_day){
                out = true;
                break;
            }
        }
        std::cout << "\n"; 

        if(out){ break; }
    }
}