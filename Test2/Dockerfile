FROM gcc as build-environment

RUN git clone https://github.com/klange/nyancat

WORKDIR nyancat/src/ 

RUN make

FROM ubuntu as runtime

COPY  --from=build-environment /nyancat/src /usr/bin

ENTRYPOINT ["/usr/bin/nyancat","-t"]