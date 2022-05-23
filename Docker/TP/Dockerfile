FROM ubuntu

MAINTAINER dirane (mohamed@utopios.net)

RUN apt-get update

RUN DEBIAN_FRONTEND=noninteractive apt-get install -y nginx git

RUN rm -Rf /var/www/html/*

RUN git clone https://gitlab.com/mohamedutopios/app-html-demo.git /var/www/html/

EXPOSE 80

CMD ["nginx", "-g", "daemon off;"]