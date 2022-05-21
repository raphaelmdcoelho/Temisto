#!/bin/bash

if [ ! -e /db-started ]
then
	sleep $TIMEOUT
	for f in `ls ./scripts/*.sql`; do
		echo $f
		/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P "Sqlserver2021*" -i $f
	done && touch /db-started
else
	echo "Database already setup... starting database"
fi
