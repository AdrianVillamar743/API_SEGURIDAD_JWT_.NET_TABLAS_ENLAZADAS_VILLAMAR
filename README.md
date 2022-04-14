# API_SEGURIDAD_JWT_.NET_TABLAS_ENLAZADAS_VILLAMAR
 Api desarrollada en .net mediante el uso de tokens para acceso al crud de dos tablas enlazadas.
API .net JWT Villamar
En esta ocasión crearemos un api con jwt para validar la seguridad de un login mediante el uso de .net y SQL server.

Utilizaremos el servidor de base de datos SQL Server, y visual studio.

Los pasos del 1 al 24 son los mismos de el siguiente link
https://github.com/AdrianVillamar743/API_JWT_VILLAMAR_LOGIN_REGISTRO

25.- Dentro de la bd en la que estemos trabajando procederemos a crear dos tablas relacionadas.

26.- Las halaremos a nuestra api mediante el comando de 



Scaffold-DbContext "Data source=LAPTOP-M2BTP9V4; Initial Catalog=Bibliotecas; user id=adrian password=villamar;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

27.- Eliminaremos las tablas de asp y nos quedaremos solo con las de la relacion

28.- Moveremos el nuevo context a Data

29.- Referenciaremos parte de la interfaz y el constructor quedando nuestro nuevo data Context de la siguiente forma

 public partial class VILLAMAR_ASEGUContext : IdentityDbContext<ApplicationUser>
    {
        public VILLAMAR_ASEGUContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public VILLAMAR_ASEGUContext(DbContextOptions<VILLAMAR_ASEGUContext> options)
            : base(options)
        {
        }

30.- Modificaremos borrando las tablas de asp

31.- Crearemos una nueva migración forzada y en caso de existir borrar las tablas ya creadas y migrar

32.- Actualizar la bd

33.- Trabajar en los controladores de las tablas relacionadas
Bajo el esquema del siguiente link

https://github.com/AdrianVillamar743/API_.NET_VILLAMAR

34.- Blindar los controladores como en el paso 24
