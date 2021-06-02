# all: lab

lab: main.o funcs.o task1.o
	g++ main.o funcs.o task1.o -o lab

main.o: main.cpp
	g++ -c main.cpp

funcs.o: funcs.cpp
	g++ -c funcs.cpp

task1.o: task1.cpp
	g++ -c task1.cpp

clean:
	rm -rf *.o lab