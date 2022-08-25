FROM node as build
WORKDIR /app
COPY . .
RUN npm install 
EXPOSE 3000
# RUN npm run build
ENTRYPOINT [ "npm", "start" ] 
# FROM httpd:2.4
# # RUN apt-get update && apt-get upgrade -y
# # RUN apt-get install apache2 -y
# COPY --from=build /app/build /usr/local/apache2/htdocs/
