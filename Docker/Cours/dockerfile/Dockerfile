FROM ubuntu
MAINTAINER mohamed (mohamed@utopios.net)
RUN apt-get update -y
RUN apt-get install -y nginx
ADD html5up-dimension/ /var/www/html/
EXPOSE 80
CMD ["nginx", "-g", "daemon off;"]