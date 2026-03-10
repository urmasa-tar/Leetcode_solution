#include <iostream>
#include <string>
#include <map>
#include <algorithm>

std::string update_sym(std::string original_word);
std::string remove_dupl(std::string st_with_num);
std::string ln_erase(std::string current);

std::map <char, int> sound_ec = {
    {'a', 0},
    {'b', 1},
    {'c', 2},
    {'d', 3},
    {'e', 0},
    {'f', 1},
    {'g', 2},
    {'h', 0},
    {'i', 0},
    {'j', 2},
    {'k', 2},
    {'l', 4},
    {'m', 5},
    {'n', 5},
    {'o', 0},
    {'p', 1},
    {'q', 2},
    {'r', 6},
    {'s', 2},
    {'t', 3},
    {'u', 0},
    {'v', 1},
    {'w', 0},
    {'x', 2},
    {'y', 0},
    {'z', 2}
};

int main() {
    std::string inp_st;
    std::cin >> inp_st;
    
    // Сохраняем первую букву
    std::string result;
    if (!inp_st.empty()) {
        result = inp_st.substr(0, 1);  // Первая буква сохраняется
        std::string rest = inp_st.substr(1);  // Остальная часть
        
        rest = update_sym(rest);
        rest = remove_dupl(rest);
        result += rest;
        result = ln_erase(result);
    }
    
    std::cout << result << std::endl;
    return 0;
}

std::string update_sym(std::string original_word) {
    std::string res;
    
    // Используем size_t вместо int для сравнения с length()
    for (size_t sym = 0; sym < original_word.length(); sym++) {
        char c = original_word[sym];
        // Пропускаем удаляемые буквы (a, e, h, i, o, u, w, y)
        if (c == 'a' || c == 'e' || c == 'h' || c == 'i' || c == 'o' || c == 'u' || c == 'w' || c == 'y') {
            continue;
        }
        res += std::to_string(sound_ec[c]);  // Преобразуем int в строку
    }
    
    return res;
}

std::string remove_dupl(std::string st_with_num) {
    std::string res;
    
    if (st_with_num.empty()) {
        return res;
    }
    
    // Используем size_t вместо int
    size_t point = 0;
    char pv_c = st_with_num[0];  // Инициализируем первым символом
    res += pv_c;
    point = 1;
    
    while (point < st_with_num.length()) {
        if (st_with_num[point] != pv_c) {
            pv_c = st_with_num[point];
            res += pv_c;
        }
        point++;
    }
    
    return res;
}

std::string ln_erase(std::string current) {
    std::string res;
    
    if (current.length() > 4) {
        res = current.substr(0, 4);  // Берем первые 4 символа
    }
    else if (current.length() < 4) {
        res = current;
        while (res.length() < 4) { 
            res += '0'; 
        }
    }
    else { 
        res = current; 
    }
    
    return res;
}