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