# PruebaFixBack

1.
  Abrir proyecto en visual studio 
2.
 se debe configurar la cadena de conexion a base de datos en el archivo
 appsettings.json que se encuentra en la carpeta del proyecto : services/pruebaFIXApi

3.
 abrir la consola de administrador de paquetes y ejecutar el comando update-database
 
4.
 este applicativo se puede probar directamente desde swager o con los siguientes endpoints:

  añadir solicitud = https://localhost:44392/api/Recuest/post
  actualizar solisitud = https://localhost:44392/api/Recuest/Update
  eliminar solisitud = https://localhost:44392/api/Recuest/Delete/{id}
  obtener solicitud por id = https://localhost:44392/api/Recuest/Get/{id}
  obtener todas las solicitudes = https://localhost:44392/api/Recuest/GetAll
