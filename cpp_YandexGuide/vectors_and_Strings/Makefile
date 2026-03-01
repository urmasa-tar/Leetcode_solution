mainRun : main.o
	g++ main.o -o mainRun

main.o : main.cpp
	g++ -c main.cpp -o main.o

clean :
	rm -rf *.o

run : mainRun
	./mainRun