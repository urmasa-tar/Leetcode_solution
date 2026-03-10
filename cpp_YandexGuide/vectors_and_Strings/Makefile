mainRun : main.o
	g++ main.o -o mainRun

main.o : main.cpp
	g++ -c main.cpp -o main.o

clean :
	rm -rf *.o

run : mainRun
	./mainRun

is_valid: valid_pass.cpp
	g++ -c valid_pass.cpp -o valid.o

validRun : valid.o
	g++ valid.o -o validRun

run_valid: validRun
	./validRun

str_sort.o : str_sort.cpp
	g++ -c str_sort.cpp -o str_sort.o

strSortRun : str_sort.o
	g++ str_sort.o -o strSortRun