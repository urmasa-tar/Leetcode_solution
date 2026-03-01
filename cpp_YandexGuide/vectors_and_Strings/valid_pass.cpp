#include <iostream>
#include <string>

bool is_valid(std::string pass);
short type_check(int num_in_char);

int main(){
    
    std::string pass_word;
    // std::cout << "Enter password: ";
    std::cin >> pass_word;

    if(is_valid(pass_word)){
        std::cout << "YES\n";
    }else{
        std::cout << "NO\n";
    }

    return 0;
}

bool is_valid(std::string pass){
    bool res = true;

    // Types: [0] uppercase, [1] lowercase, [2] digits, [3] other special chars
    bool uniq_arr[4] = {false, false, false, false};
    int size_pass = pass.size(); 
    int uniq_calc = 0;
    
    // Check length requirement (between 8 and 14 inclusive)
    if(size_pass < 8 || size_pass > 14){ 
        std::cout << "Failed: Length must be 8-14 characters\n";
        res = false; 
    }
    else{
        // Check each character
        for(char btn : pass){
            int num_copy = btn;
            // Check if character is in allowed range
            if ( !( num_copy >= 33 && num_copy <= 126)){
                std::cout << "Failed: Character '" << btn << "' not in allowed range\n";
                res = false;
                break;
            }else{
                uniq_arr[type_check(num_copy)] = true;
            }
        }

        // Count how many types are present
        for( bool type_present : uniq_arr ){ 
            if(type_present){ 
                uniq_calc += 1; 
            } 
        }
        
        // Check type requirement
        if(uniq_calc < 3){ 
            std::cout << "Failed: Need at least 3 character types, only have " << uniq_calc << "\n";
            res = false; 
        }
    }   

    return res;
}

short type_check(int num_in_char){
    short res = 3;  // Default to "other" type

    if(num_in_char >= 65 && num_in_char <= 90){ // Uppercase letter
        res = 0;
    }else if(num_in_char >= 97 && num_in_char <= 122){ // Lowercase letter
        res = 1;
    }else if(num_in_char >= 48 && num_in_char <= 57){ // Digit
        res = 2;
    }else { 
        res = 3;  // Special character
    }

    return res;
}