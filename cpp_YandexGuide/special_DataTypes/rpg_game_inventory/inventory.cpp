#include "inventory.h"
#include <iostream>

// Реализация функций
void displayItem(const Item& item) {
    std::cout << "Name: " << item.name << std::endl;
    // ... остальной код
}

void addItemToInventory(std::vector<Item>& inventory, const Item& newItem) {
    inventory.push_back(newItem);
}
