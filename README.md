Título del Proyecto
ServicioWebTuya

Pre-requisitos
Se realizan instalaciones de los siguientes packages:

NUGET
* Microsoft.EntityFrameworkCore.Tools: Permite realizar tareas relacionadas con EF.
* Microsoft.EntityFrameworkCore.SqlServer: Permite realizar tareas relacionadas con EF.
* Install-Package System.Net.Http.Formatting.Extension -Version 5.2.3: Se instala para realizar envio Post a la api con JsonMediaTypeFormatter
* Swashbuckle.AspNetCore: Para documentar API.

LIBRERIAS
* System.Net.Http: Se usa para ralizar consumo de la API.
* Newtonsoft.Json: Se usa para enviar data, serializar y deseralizar data
* System.Collections.Generic: Uso para colecciones genericas
* System.Linq: Uso para realizar consultas rapidas de facil manejo entre la data
* WebAplication.WebCliente.Data: Permite la comunicación con el reporsitorio
* Microsoft.Extensions.DependencyInjection: Inyección de dependencia, para evitar el acoplamiento entre las clases.
* Microsoft.OpenApi.Models: Para documentar API.

Ejecución:

La base de datos (DBTuya) es creada una vez se ejecute el proyecto por medio de DataContext, este crea 4 registros simulando los productos, 
una vez se inicia el proyecto la API realiza la consulta de esos productos que se ven reflejados en la pantalla Factura.

Pantallas:
1. Factura: Obtiene la información por medio de la API y realiza la sumatoria de los producto, luego de ingresar y realizar el calculo con la data que obtiene la API,
   el formulacio cuenta con un boton (Realizar Pago), que enviará a crear la información a la API, generando pedidos nuevos.

2. Pedidos: En esta pantalla se ven reflejados los nuevos pedidos que se crean una vez sean facturados desde la pantalla Factura.

Nota: en el archivo appsettigs.json se cre objeto PathAPI con la ruta del localHost para consumo de API, cambiar de ser necesario.

Documentación API 

* agregar en URL /swagger y este abrira la documentacín necesaria de la API
Ejemplo con mi maquina: https://localhost:44362/swagger/index.html


NOTA: NO LOGRE REALIZAR EL DOCKER, ME PRESENTARON FALLAS CON EL WSL2.

