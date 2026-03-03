#include <iostream>
#include <string>
#include <map>
#include <algorithm>

std::string update_sym(std::string original_word);


std::map <char, int> sound_ec = {
    {'a', '0'},
    {'b', '1'},
    {'c', '2'},
    {'d', '3'},
    {'e', '0'},
    {'f', '1'},
    {'g', '2'},
    {'h', '0'},
    {'i', '0'},
    {'j', '2'},
    {'k', '2'},
    {'l', '4'},
    {'m', '5'},
    {'n', '5'},
    {'o', '0'},
    {'p', '1'},
    {'q', '2'},
    {'r', '6'},
    {'s', '2'},
    {'t', '3'},
    {'u', '0'},
    {'v', '1'},
    {'w', '0'},
    {'x', '2'},
    {'y', '0'},
    {'z', '2'}
};

int main(){

    std::string inp_st;
    
    std::cin >> inp_st;
    inp_st = remove_dupl(update_sym(inp_st));

    return 0;
}

std::string update_sym(std::string original_word){
    std::string res;

    for( int sym = 1; sym < original_word.length(); sym++){ res += sound_ec[original_word[sym]]; }
    res.erase(std::remove(res.begin(), res.end(), '0'), res.end());

    return res;
}

std::string remove_dupl(std::string st_with_num){

    std::string res;
    int point = 0;
    char pv_c = '-';

    while(true){

        if(point > st_with_num.length()){ break; }
        else{
            if(st_with_num[point] != pv_c){
                pv_c = st_with_num[point];
                res += pv_c;
                point += 1;
            }else{
                point += 1;
            }
        }

    }

    return res;

}

