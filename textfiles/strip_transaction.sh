#!/bin/sh

echo -e "\nStripping incompatible statements for Postgres. Please wait.\n"

/usr/bin/sleep 5

/usr/bin/cat ./textfiles/transaction.txt | /usr/bin/grep -v "TIMESTAMP" | /usr/bin/grep -v "DELIMITER" | /usr/bin/grep -v "SET @@" | /usr/bin/grep -v "\/\*\!\.*c.*" | /usr/bin/grep -v "# " | /usr/bin/sed 's/\/\*\!\*\/\;/;/g' | /usr/bin/sed 's/`//g' | /usr/bin/sed 's/use/\\c/g' | /usr/bin/sed 's/ENGINE.*//g' | /usr/bin/sed 's/engine.*//g' > ./textfiles/transactioninput.txt
