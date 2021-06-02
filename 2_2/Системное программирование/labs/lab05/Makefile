out: main.o libtable.a
	g++ -o labS main.o -L. -lworld
main.o: main.cpp
	g++ -c $^
libtable.a: logic.o
	ar cr libworld.a logic.o
logic.o: logic.cpp
	g++ -fPIC -c $^
clean:
	rm -f *.o out *.a