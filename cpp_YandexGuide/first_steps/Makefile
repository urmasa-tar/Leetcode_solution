
mainRun : main.o
	g++ main.o -o mainRun

main.o : main.cpp
	g++ -c main.cpp -o main.o

clean :
	rm -rf *.o

run : mainRun
	./mainRun

parPrt : par_print.cpp
	g++ par_print.cpp -o parPrt.o

quen_step: quen_step.cpp
	g++ quen_step.cpp -o quen_step.o

check_trn: st_triangle.cpp
	g++ st_triangle.cpp -o trn.o

year_check: vsc_year.cpp
	g++ vsc_year.cpp -o check_year.o

day_in_month_check: day_in_month.cpp
	g++ day_in_month.cpp -o day_in_month.o