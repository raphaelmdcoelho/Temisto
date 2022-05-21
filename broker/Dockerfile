FROM rabbitmq:3-management

ENV RABBITMQ_DEFAULT_USER=user
ENV RABBITMQ_DEFAULT_PASS=password

COPY init.sh .
RUN chmod +x /init.sh

EXPOSE 5672
EXPOSE 15672

COPY definitions.json /etc/rabbitmq/definitions.json
COPY rabbitmq.conf /etc/rabbitmq/rabbitmq.conf

CMD ["/init.sh"]
