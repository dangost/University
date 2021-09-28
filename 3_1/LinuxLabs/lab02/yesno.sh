#!/bin/sh

gdialog --title "Select" --yesno "Are you student"? 9 18

case "$?" in
    0) gdialog --title "Select" --yesno "Are you studing in BNTU"? 9 18;
        case "$?" in
            0) gdialog --infobox "Welcome!" 5, 20;;
            1) gdialog --infobox "Goodbuy", 5, 20;;
        esac;;
    1) gdialog --infobox "Goodbuy" 5 20;;
esac
sleep 1
exit 0