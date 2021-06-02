PROGRAM_NAME=lab9_ind

$(PROGRAM_NAME): main.o logic.o fileUtils.o
	gcc $^ -o $@
main.o: main.c 
	gcc -c $^
logic.o: logic.c
	gcc -c $^
fileUtils.o: fileUtils.c
	gcc -c $^
clean:
	rm -f *o $(PROGRAM_NAME)


