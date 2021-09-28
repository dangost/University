#!/bin/sh

gdialog --title "Select" --yesno "Are you a man"? 9 18

case "$?" in
    0) gdialog --inputbox "Good day, boy. What is your name?" 5 20 2> _1.txt
        Q_N=$(cat _1.txt)
        echo "Hi, $Q_N"
        rm _1.txt;;
    1) gdialog --infobox "Good day, Girl" 5, 20;;
    *) gdialog --infobox "Good Day", 5, 20;;

esac
sleep 1
exit 0