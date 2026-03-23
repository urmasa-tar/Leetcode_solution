#ifndef INVENTORY_H
#define INVENTORY_H

#include <string>
#include <vector>

enum class ItemType{
    Weapon,
    Armor,
    Heal_poison,
    Resuorce,
    Quest_item
};

enum class WeaponType {
    Sword,
    Bow,
    Staff,
    Axe,
    not_Weapon
};

struct Item
{
    std::string name;
    ItemType type_of;
    int value;
    WeaponType subType;
};

void displayItem(const Item& item);
void addItemToInventory(std::vector<Item>& inventory, const Item& newItem);

#endif