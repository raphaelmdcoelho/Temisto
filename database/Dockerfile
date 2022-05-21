FROM mcr.microsoft.com/mssql/server

USER root

WORKDIR /

ENV SA_PASSWORD="Sqlserver2021*" ACCEPT_EULA="Y"

COPY . .

RUN chmod 777 startup.sh && chmod 777 runscripts.sh

EXPOSE 1433

ENTRYPOINT ["/startup.sh"]
