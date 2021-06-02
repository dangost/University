out: main.o libtable.so
	g++ -o output2 main.o -L. -ltable -Wl,-rpath,.
main.o: main.cpp
	g++ -c $^
libtable.so: logic.o
	g++ -shared -o $@ $^
logic.o: logic.cpp
	g++ -fPIC -c $^
clean:
	rm -f *.o output2
