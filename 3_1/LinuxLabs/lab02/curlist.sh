#!/bin/sh

touch f1

echo "dollar 2,5" > f1
echo "euro 3" >> f1
echo "rub 100RUB == 3.2" >> f1
while true
do
    gdialog --menu "Choose currency" 15 30 4 1 "Dollar" 2 "Euro" 3 "Rub" 4 "Exit" 2>cur.txt

    z=$(cat cur.txt)

    if [ "$z" = "1" ]
    then
    echo "dollar 2.5"

    elif [ "$z" = "2" ]
    then
    echo "euro 3"

    elif [ "$z" = "3" ]
    then
    echo "rub 100RUB == 3.2"

    elif [ "$z" = "4" ]
    then
    rm f1
    rm cur.txt
    echo exit..
    sleep 1
    exit 0

    else
    echo "we don't know for $z"
    fi
done
