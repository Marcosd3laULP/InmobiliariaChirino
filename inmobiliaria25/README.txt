PROYECTO TRABAJADO POR:
SOSA CHIRINO MARCOS ANTONIO DNI:46807958
COMPAÑERO 2

ESPECIFICACIONES:
Este proyecto esta desarrollado con .net 9.0. No creo que haya mucho por decir...

En la parte de la BASE DE DATOS:
utilice MYSQLWORKBENCH para la creación y gestion de la base de datos.
¡EN EL ARCHIVO "appsettings.json" DEBE DE INGRESAR UN USUARIO Y UNA CONTRASEÑA!
No encontre la manera de evadir la contraseña en el Workbench... 

Instalé herramientas del "Entity Framework Core, para poder llevar a cabo la conexión entre el proyecto y la
base de datos. Por eso, en caso de que no las posea, abra una terminal dentro de la carpeta del proyecto Y
ejecute estos comandos:

*-------------------------------------------------------------------------------------*
dotnet tool install --global dotnet-ef

dotnet add package Pomelo.EntityFrameworkCore.MySql
dotnet add package Microsoft.EntityFrameworkCore.Design
*-------------------------------------------------------------------------------------*

Despues, asegurese de que esten bien configurados los archivos "program.cs" y "appsettings.json". Por ultimo,
para que se le genere automaticamente la BD, ejecute este comando:

*-------------------------------------------------------------------------------------*
dotnet ef database update
*-------------------------------------------------------------------------------------*

Con esto, automaticamente .Net, abra creado una nueva base de datos junto a las tablas correspondientes. OJO,
solo crea la base de datos y la estructura, pero no carga los datos...

El usuario y contraseña que estan en el archivo son de tipo "general" para poder trabajar en el proyecto 
en distintas computadoras.

De todos modos, para evitar posibles futuros conflictos con la BD, ejecute este script:
*-------------------------------------------------------------------------------------*

CREATE DATABASE IF NOT EXISTS inmobiliaria;

CREATE USER IF NOT EXISTS 'inmo'@'localhost' IDENTIFIED BY 'clave123';

GRANT ALL PRIVILEGES ON inmobiliaria.* TO 'inmo'@'localhost';

FLUSH PRIVILEGES;

*-------------------------------------------------------------------------------------*

Eso es todo por ahora...