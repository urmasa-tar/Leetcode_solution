#include <iostream>
#include <string>
#include <vector>

void prt_vec();
void criation_by_Init_List(int num);
int capacity_Chang_Show(int cycle_n = 1);  // Keep default here
// Some common options in work with vectors and strings
int main(){

    // Example of out and creation
    prt_vec();
    // Another method of creation
    criation_by_Init_List(0);

    // Capacity vs Size demonstration for vector
    capacity_Chang_Show(3);  // Show 3 cycles of growth

    return 0;
}

// Creation and print for vector
void prt_vec(){

    int n = 5;
    std::vector<int> data = {1, 2, 3, 4, 5};
    for(int elem : data){
        std::cout << elem << " ";
    }   
    std::cout << "\n";

}

void criation_by_Init_List(int num){

    std::vector<std::string> v1;  // пустой вектор строк
    std::vector<std::string> v2(5);  // вектор из пяти пустых строк
    std::vector<std::string> v3(5, "hello");  // вектор из пяти строк "hello"

    std::cout << "Vector v3 contents:\n";
    for(const std::string& elem_st : v3){  // Use const reference to avoid copying
        std::cout << elem_st << "\n";
    }
    std::cout << "\n";

}

int capacity_Chang_Show(int cycle_n){  // Removed default value from here
    std::vector<int> data = {1, 2};
    
    std::cout << "Starting vector: size = " << data.size() 
              << ", capacity = " << data.capacity() << "\n\n";
    std::cout << "Adding elements and watching capacity grow:\n";
    std::cout << "Step\tSize\tCapacity\tCapacity Change\n";
    std::cout << "----\t----\t--------\t----------------\n";
    
    int step = 1;
    int prev_capacity = data.capacity();
    
    for(int cycle = 0; cycle < cycle_n; cycle++){
        for(int i = 0; i < 3; i++){  // Add 3 elements in each cycle
            data.push_back(step + 2);  // Adding 3, then 4, then 5, etc.
            
            std::cout << step << "\t" << data.size() << "\t" << data.capacity() << "\t";
            
            if(data.capacity() > prev_capacity){
                std::cout << "INCREASED by " << (data.capacity() - prev_capacity);
                prev_capacity = data.capacity();
            } else {
                std::cout << "no change";
            }
            std::cout << "\n";
            
            step++;
        }
    }
    
    std::cout << "\nFinal vector contents: ";
    for(int val : data){
        std::cout << val << " ";
    }
    std::cout << "\n\n";

    return 0;
}