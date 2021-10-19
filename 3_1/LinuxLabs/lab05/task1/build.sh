#!/bin/sh

g++ -o server server.cpp -pthread &&\

g++ -o client client.cpp -pthread  &&\

./server &&\
./client
