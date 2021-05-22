all: lab

lab: main.o funcs.o
	g++ main.o funcs.o -o lab

main.o: main.cpp
	g++ -c main.cpp

factorial.o: funcs.cpp
	g++ -c funcs.cpp

clean:
	rm -rf *.o lab