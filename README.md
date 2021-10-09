Título del Proyecto
Servicio Web Tuya

Pre-requisitos
Se realizan instalaciones de los siguientes packages:

* Microsoft.EntityFrameworkCore.Tools: Permite realizar tareas relacionadas con EF.
* Microsoft.EntityFrameworkCore.SqlServer: Permite realizar tareas relacionadas con EF.
* System.Net.Http: Se usa para ralizar consumo de la API.
* Newtonsoft.Json: Se usa para enviar data, serializar y deseralizar data
* Install-Package System.Net.Http.Formatting.Extension -Version 5.2.3: Se instala para realizar envio Post a la api con JsonMediaTypeFormatter

Ejecución:

La base de datos (DBTuya) es creada una vez se ejecute el proyecto por medio de DataContext, este crea 4 registros simulando los productos, 
una vez se inicia el proyecto la API realiza la consulta de esos productos que se ven reflejados en la pantalla Factura.

Pantallas:
1. Factura: Obtiene la información por medio de la API y realiza la sumatoria de los producto, luego de ingresar y realizar el calculo con la data que obtiene la API,
   el formulacio cuenta con un boton (Realizar Pago), que enviará a crear la información a la API, generando pedidos nuevos.

2. Pedidos: En esta pantalla se ven reflejados los nuevos pedidos que se crean una vez sean facturados desde la pantalla Factura.

Nota: en el archivo appsettigs.json se cre objeto PathAPI con la ruta del localHost para consumo de API, cambiar de ser necesario.
