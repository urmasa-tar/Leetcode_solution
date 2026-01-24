TARGET = MyProject

MyProject: main.o my_lib.o
	gcc main.o my_lib.o -o MyProject

main.o : main.c
	gcc -c main.c -o main.o

my_lib.o : my_lib.c
	gcc -c my_lib.c -o my_lib.o

format:
	clang-format -i *.c

clean:
	rm *.o MyProject