out: main.o libtable.so
	g++ -o lab main.o -L. -ltable -Wl,-rpath,.
main.o: main.cpp
	g++ -c $^
libtable.so: logic.o
	g++ -shared -o $@ $^
logic.o: logic.cpp
	g++ -fPIC -c $^
clean:
	rm -f *.o out *.so