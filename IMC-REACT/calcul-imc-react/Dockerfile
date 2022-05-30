# FROM node:16

# WORKDIR /app

# COPY . .

# RUN npm install 

# EXPOSE 3000

# # ENTRYPOINT ["npm", "start"] 
# CMD ["npm", "start"] 

#Dockerfile with multi-staging images
#stage 1
FROM node:16 as build
WORKDIR /app
COPY . .
RUN npm install
RUN npm run build

#stage 2
FROM ubuntu
RUN apt-get update
RUN DEBIAN_FRONTEND=noninteractive apt-get install -y nginx 
COPY --from=build /app/build/. /var/www/html/.
EXPOSE 80
CMD ["nginx", "-g", "daemon off;"]