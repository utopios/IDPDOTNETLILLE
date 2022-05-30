FROM ubuntu

RUN apt-get update

RUN DEBIAN_FRONTEND=noninteractive apt-get install -y nginx 


COPY . /var/www/html/.

EXPOSE 80

CMD ["nginx", "-g", "daemon off;"]

# Sur votre terminal, à chaque push sur git, vous pouvez relancer : docker build --no-cache -t mohamed1780/new-image-html-demo .