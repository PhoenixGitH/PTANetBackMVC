# Prueba Alicunde

## Descripción del Proyecto

La aplicación consume una API externa, almacena los datos en una base de datos y los expone a través de una RESTAPI con Swagger y Docker.

## Tecnologías utilizadas

- .NET - C#
- SQL Server
- MVC

## Configuración y Ejecución del Proyecto

### Requisitos Previos

- [.NET SDK](https://dotnet.microsoft.com/download) instalado en tu máquina.
- [Docker](https://www.docker.com/get-started) instalado y corriendo, con una instancia de SQL Server configurada.

### Gestión de Secretos

Los datos sensibles del proyecto estan almacenados en una variable de entorno, aun asi se ha dejado implementada la posibilidad de utilizar los datos de manera local.

En dicha variable de entorno es necesario modificar la cadena de conexión colocando la IP correspondiente al host de la base de datos.

#### Descarga y ejecución del proyecto

1. Clona este repositorio.
2. Modificar el archivo Dockerfile para encontrar la variable de entorno `DB_CONNECTION_STRING` y poner su valor de ip correspondiente.
3. Tener Docker Desktop corriendo en la máquina host.
3. Tener los servicios de SQL Server corriendo y un usuario y contraseña correspondientes a los de Dockerfile de lo contrario modificarlos tambien.
3. Compila y ejecuta la aplicación usando las herramientas de tu IDE o el comando `dotnet run Docker` para utilizar el perfil Docker creado.

## Técnicas empleadas

- **Patrones SW:** La API utiliza la vista por defecto de Swagger, pero se ha utilizado el MVC como patron de desarrollo.
- **Excepciones:** Se han utilizado bloques de codigo `try-catch` repetitivos por desconocimiento del patron MONAD.
- **Documentación:** La API está documentada utilizando Swagger.
- **Pruebas:** No se han hecho pruebas unitarias, pero al ejecutar el codigo se puede observar como todos los endpoints funcionan y la base de datos se actualiza correctamente.


