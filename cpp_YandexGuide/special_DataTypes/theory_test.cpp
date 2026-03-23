#include <iostream>

// My own types
enum class Color {
    White,
    Red,
    Orange,
    Blue,
};

//Functions


int main(){

    //Colors
    Color color1 = Color::Red;
    Color color2 = Color::Blue;

    int value = static_cast<int>(color2);  // 3
    Color color3 = static_cast<Color>(2);  // Color::Orange

    return 0;
}

// Enum usage of classes
