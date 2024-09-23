
# Proyecto de Base de Datos con Entity Framework Core y MySQL/MariaDB

## Configuraci�n de la Base de Datos con Docker

1. **Crear un Contenedor de MySQL/MariaDB**:
   - Abre tu terminal y ejecuta el siguiente comando para crear y ejecutar un contenedor de MySQL:
```bash
	 docker run --name mysql-database -e MYSQL_ROOT_PASSWORD=123456 -e MYSQL_DATABASE=database -p 3306:3306 -d mysql:latest
```
   - O ejecuta el siguiente comando para crear y ejecutar un contenedor de MariaDB:
```bash
	 docker run --name mariadb-database -e MYSQL_ROOT_PASSWORD=123456 -e MYSQL_DATABASE=database -p 3306:3306 -d mariadb:latest
```

2. **Conectar la Aplicaci�n a la Base de Datos**:
   - Abre el archivo `appsettings.json` y modifica la cadena de conexi�n para que coincida con la configuraci�n de tu contenedor de MySQL/MariaDB:
```json
{
  "ConnectionStrings": {
	"DefaultConnection": "server=localhost;port=3306;database=database;user=root;password=123456;"
  }
}
```

3. **Aplicar las Migraciones**:
   - En la terminal, navega a la carpeta del proyecto y ejecuta:
`dotnet ef database update`
   - Esto aplicar� las migraciones y crear� las tablas en tu base de datos.

Tambi�n puedes utilizar el comando `Add-Migration` para crear una nueva migraci�n.

## Ejecutar la Aplicaci�n

4. **Compilar y Ejecutar**:
   - En Visual Studio, selecciona `Build > Build Solution` para compilar el proyecto.
   - Luego, selecciona `Debug > Start Debugging` o presiona `F5` para ejecutar la aplicaci�n.


## Ejecutar la Aplicaci�n

5. **Ejecutar la Aplicaci�n**:
   - Abre el proyecto en Visual Studio y ejecuta la aplicaci�n.

## Adicional

6. **Dump**
	-En caso de unicamente necesitar alimentar la DB con informaci�n de manera rapida y facil ejecutar el dump que tiene por nombre: 			
	 storedb-202409222300.sql
	-Asegurarse de que el proyecto tiene la estructuramostrada acontinuacion
	![structure](src/structure.png)