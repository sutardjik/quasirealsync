#!/bin/sh

echo -e "\nStripping incompatible statements for Postgres. Please wait.\n"

/usr/bin/sleep 5

/usr/bin/cat ./textfiles/dump.txt | /usr/bin/sed "s/`/usr/bin/cat ./textfiles/dump.txt | /usr/bin/grep 'UNIQUE KEY' | /usr/bin/cut -d " " -f5`//g" | /usr/bin/sed 's/UNIQUE KEY/UNIQUE/g' | /usr/bin/sed 's/`//g' | /usr/bin/sed 's/USE/\\c/g' | /usr/bin/sed 's/int(11)/int/g' | /usr/bin/sed 's/) ENGINE=.*/);/g' | /usr/bin/sed 's/) engine=.*/);/g' | /usr/bin/grep -v "LOCK" | /usr/bin/grep -v "UNLOCK" > ./textfiles/dumpinput.txt

