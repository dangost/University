#!/bin/sh

touch f1

echo "dollar 2,5" > f1
echo "euro 3" >> f1
echo "rub 100RUB == 3.2" >> f1

while true
do
    gdialog --inputbox "Input currency:\n Dollar\n Euro\n Rub\n Exit" 5 20 2> cur.txt

    z=$(cat cur.txt)
    echo $z

    if [ "$z" = "dollar" ]
    then
    echo "dollar 2.5"

    elif [ "$z" = "euro" ]
    then
    echo "euro 3"

    elif [ "$z" = "rub" ]
    then
    echo "rub 100RUB == 3.2"

    elif [ "$z" = "exit" ]
    then
    exit 0

    else
    echo "we don't know for $z"
    fi

    rm cur.txt
done


rm f1
