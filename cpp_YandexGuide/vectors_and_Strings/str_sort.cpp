#include <iostream>
#include <string>
#include <array>
#include <vector>

std::vector<std::string> read_arr_fnc();
void out_of_vecst(const std::vector<std::string>& st_for_out);


int main(){

    std::vector<std::string> arr_ofst = read_arr_fnc(); 

    out_of_vecst(arr_ofst);

    return 0;
}

std::vector<std::string> read_arr_fnc(){
    std::vector<std::string> res;

    std::string line;
    while (std::getline(std::cin, line)) {
        // Обработка строки
        res.push_back(line);
    }

    return res;
}

void out_of_vecst(const std::vector<std::string>& st_for_out) { for (size_t i = 0; i < st_for_out.size(); i++) { std::cout << st_for_out[i] << std::endl; } }