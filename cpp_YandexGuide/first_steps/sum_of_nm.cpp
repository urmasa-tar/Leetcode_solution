#include <iostream>


int main(){
    int num_or, res = 0;
    std::cin >> num_or;

    while (num_or > 0)
    {
        res += num_or % 10;
        num_or /= 10;
    }
    
    std::cout << res;
    
    return 0;
}

