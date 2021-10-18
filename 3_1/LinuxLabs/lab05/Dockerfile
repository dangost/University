FROM ubuntu:latest

WORKDIR /app
COPY . /app/

RUN apt update && \
    apt install -y g++

CMD ["./build.sh"]
