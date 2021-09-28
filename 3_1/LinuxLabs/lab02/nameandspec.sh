#!/bin/sh

gdialog --inputbox "What is your name?" 5 20 2> user.txt

gdialog --inputbox "What is your profession?" 5 20 2>> user.txt

cat user.txt

sleep 1
exit 0