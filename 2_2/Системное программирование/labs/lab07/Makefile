PROGRAM_NAME=lab 
$(PROGRAM_NAME): main.o logic.o read.o output.o
	g++ $^ -o $@ -lpthread
main.o: main.cpp
	g++ -c $^ -lpthread
output.o: output.cpp
	g++ -c $^ 
read.o: read.cpp
	g++ -c $^ 
logic.o: logic.cpp
	g++ -c $^ -lpthread
clean:
	rm -f *o $(PROGRAM_NAME) *.txt