#Pillamos la imagen base
FROM mysql:latest

#Creamos las variables de entornos para establecer los valores de la base de datos
ENV MYSQL_ROOT_PASSWORD=1234
ENV MYSQL_DATABASE=proyecto
ENV MYSQL_USER=proyecto
ENV MYSQL_PASSWORD=proyecto



#Exponemos el servicio en el puerto
EXPOSE 3306

#Arrancamos la base de datos
CMD [ "mysqld" ]