FROM gcc as build-environment

RUN git clone https://github.com/klange/nyancat

WORKDIR nyancat/src/

RUN make

