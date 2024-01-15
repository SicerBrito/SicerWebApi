
---
<div style="background-image: url(https://media3.giphy.com/media/wwg1suUiTbCY8H8vIA/giphy.gif?cid=ecf05e47hfu84pmh8vk2mo5wohm7vxo4hcx1gu3ye1664zcy&ep=v1_gifs_search&rid=giphy.gif&ct=g); display: flex; justify-content: center;">

# Sicer Andres Brito Gutierrez 🧑‍💻 Proyecto WebApi Campuslands <img src="https://api.nuget.org/v3-flatcontainer/microsoft.entityframeworkcore/8.0.0-preview.6.23329.4/icon" alt="img" style="width: 38px;">
</div>


<div style="display: flex; justify-content: center;">

## Proyecto WebApi Campuslands hecho por [Sicer Brito 🧑‍💻](https://github.com/SicerBrito)
</div>





# Índice 📖
En esta ocasión voy a realizar un proyecto personal junto con su documentacion con el objetivo de mejorar mis habilidades en .Net

- [Documentación](#documentación) 📄
    - [Estructura del Proyecto](#estructura-del-proyecto) 🏗️
    - [Terminal](#terminal) ⚙️
        - [Estructura Base](#estructura-base) 🚧
        - [Referencias](#referencias) 🔗
    - [Gestión de Datos](#gestión-de-datos) 📇
        - [Instalacion de Paquetes](#instalacion-de-paquetes) ⏬
            - [Dominio](#dominio) 📂
            - [Persistencia](#persistencia) 📂
            - [Seguridad](#seguridad) 📂 
            - [WebApi](#webapi) 📂
        - [Migraciones](#migraciones) ✈️
            - [Crear](#crear) 🔧
            - [Actualizar](#actualizar) 🔧
        - [Visualización de posibles errores](#visualización-de-posibles-errores) ⁉️


---
# Documentación
Proyecto WebApi Campuslands con la estructura que tiene [Solvo](https://solvoglobal.com/)  
Mi objetivo con este proyecto es centrarme en el aprendizaje y el desarrollo constante de mis habilidades. Además de eso, también tengo otras metas en mente para asegurarme de que mi contribución sea lo más efectiva posible 📄  

## Estructura del Proyecto
Estas son las carpertas de configuracion las cuales vamos a utilizar para nuestros proyectos
 - 📂 En Dominio  
        Aqui se crean las tablas que representan la BD y van a estar ubicadas las carpetas de Entidades e Interfaces.

 - 📂 En Persistencia  
        Aqui se crea la instancia de conexion a la BD y van a estar ubicadas las carpetas de Data, Configuracion, Archivo context y Migraciones.

 - 📂 En Aplicacion  
        Aqui se crea la inyeccion de dependecia para la comunicacion con el WebApi y van a estar ubicadas las carpetas de Unidad de trabajo y Repositorios.
        
 - 📂 En WebApi  
        Aqui se crean clases encargadas de recibir peticiones de los clientes y van a estar ubicadas las carpetas de Controladores, helpers, Dtos, Profile, Contenedor de dependecias(program.cs) y Extenciones.

 - 📂 En Seguridad  
        Aqui se crean clases encargadas de la configuración de los archivos JWT(JSON Web Tokens) para la seguridad de nuestro proyecto. Esta parte no es obligatoria ya que se puede hacer directamente desde WebApi y por razones de eficiencia y contruccion es una mejor forma de hacerlo sin esta carpeta.

---

   <img src="./Img/Relaciones.png" alt="Relaciones" style="width: 3000px;">

---





## Terminal

 - ### Estructura Base
    
    ---
    - Instala la herramienta "dotnet-ef" globalmente para trabajar con Entity Framework Core. 🚧🔧
        ```
        dotnet tool install --global dotnet-ef 
        ```

    
    ---
    - Lista las herramientas globales instaladas en .NET 🚧🔧
        ```
        dotnet tool list -g
        ```

    ---
    - En caso de no estar desactualizado se puede actualizar mediante este comando 🚧🔧
        ```
        dotnet tool update --global dotnet-ef
        ```
    ---
    - Crea una nueva solución de .NET  
    Una solución (.sln) se refiere a un archivo que actúa como un contenedor para organizar y administrar proyectos relacionados en un entorno de desarrollo de .NET 🚧🔧
        ```
        dotnet new sln
        ```

    ---
    - Crea un nuevo proyecto de biblioteca de clases utilizando .NET Core y lo guarda en la carpeta "Dominio". Las bibliotecas de clases son conjuntos de código reutilizable que pueden ser referenciados y utilizados en otros proyectos .NET Core. En este caso, el nombre "Dominio" sugiere que esta biblioteca podría contener clases y lógica relacionada con el dominio central de la aplicación, como modelos y reglas de negocio 🚧🔧
        ```
        dotnet new classlib -o Dominio
        ```

    ---
    - Crea un nuevo proyecto de biblioteca de clases utilizando .NET Core y lo guarda en la carpeta "Persistencia". Las bibliotecas de clases son conjuntos de código reutilizable que pueden ser referenciados y utilizados en otros proyectos .NET Core. En este caso, el nombre "Persistencia" sugiere que esta biblioteca podría contener clases y lógica relacionada con el acceso y la manipulación de datos, como el uso de bases de datos y almacenamiento persistente. 🚧🔧
        ```
        dotnet new classlib -o Persistencia
        ```
    ---
    - Crea un nuevo proyecto de biblioteca de clases utilizando .NET Core y lo guarda en la carpeta "Aplicacion". Las bibliotecas de clases son conjuntos de código reutilizable que pueden ser referenciados y utilizados en otros proyectos .NET Core. En este caso, el nombre "Aplicacion" sugiere que esta biblioteca podría contener clases y lógica relacionada con la capa de aplicación, como la implementación de casos de uso y la interacción con la interfaz de usuario. 🚧🔧
        ```
        dotnet new classlib -o Aplicacion
        ```

    ---
    - Crea un nuevo proyecto de biblioteca de clases utilizando .NET Core y lo guarda en la carpeta "Seguridad". Las bibliotecas de clases son conjuntos de código reutilizable que pueden ser referenciados y utilizados en otros proyectos .NET Core. En este caso, el nombre "Seguridad". 🚧🔧
        ```
        dotnet new classlib -o Seguridad
        ```

    ---
    - Crea un nuevo proyecto de API web utilizando .NET Core y lo guarda en la carpeta "WebApi". Este comando establece las bases para crear una API utilizando el framework .NET Core, que puede ser utilizada para exponer servicios a través de HTTP. 🚧🔧
        ```
        dotnet new webapi -o WebApi
        ```

    ---
    - Agrega el proyecto ubicado en la carpeta "Dominio" al archivo de solución actual de .NET Core. Esto permite incluir el proyecto "Dominio" dentro de la solución y facilita la gestión de múltiples proyectos en un mismo contexto de desarrollo. Es útil cuando se tiene una solución que consta de varios proyectos y se quiere mantener todo organizado en una estructura de solución. 🚧🔧
        ```
        dotnet sln add Dominio/
        ```

    ---
    - Agrega el proyecto ubicado en la carpeta "Persistencia" al archivo de solución actual de .NET Core. Esto permite incluir el proyecto "Persistencia" dentro de la solución y facilita la gestión de múltiples proyectos en un mismo contexto de desarrollo. Es útil cuando se tiene una solución que consta de varios proyectos y se quiere mantener todo organizado en una estructura de solución. 🚧🔧
        ```
        dotnet sln add Persistencia/
        ```

    ---
    - Agrega el proyecto ubicado en la carpeta "Aplicacion" al archivo de solución actual de .NET Core. Esto permite incluir el proyecto "Aplicacion" dentro de la solución y facilita la gestión de múltiples proyectos en un mismo contexto de desarrollo. Es útil cuando se tiene una solución que consta de varios proyectos y se quiere mantener todo organizado en una estructura de solución. 🚧🔧
        ```
        dotnet sln add Aplicacion/
        ```

    ---
    - Agrega el proyecto ubicado en la carpeta "Seguridad" al archivo de solución actual de .NET Core. Esto permite incluir el proyecto "Seguridad" dentro de la solución y facilita la gestión de múltiples proyectos en un mismo contexto de desarrollo. Es útil cuando se tiene una solución que consta de varios proyectos y se quiere mantener todo organizado en una estructura de solución. 🚧🔧
        ```
        dotnet sln add Seguridad/
        ```

    ---
    - Agrega el proyecto ubicado en la carpeta "WebApi" al archivo de solución actual de .NET Core. Esto permite incluir el proyecto "WebApi" dentro de la solución y facilita la gestión de múltiples proyectos en un mismo contexto de desarrollo. Es útil cuando se tiene una solución que consta de varios proyectos y se quiere mantener todo organizado en una estructura de solución. 🚧🔧
        ```
        dotnet sln add WebApi/
        ```
    ---

---

 - ### Referencias

    - Agrega una referencia al proyecto "Dominio" desde el proyecto "Aplicacion". Al hacer esto, el proyecto "Aplicacion" podrá acceder y utilizar las clases y funcionalidades proporcionadas por el proyecto "Dominio". Esto es útil cuando se tiene una estructura de capas en la que el proyecto de aplicación depende de lógica y modelos definidos en el proyecto de dominio y tambien agrega una referencia al proyecto "Persistencia" desde el proyecto "Aplicacion". Al hacer esto, el proyecto "Aplicacion" podrá acceder y utilizar las clases y funcionalidades proporcionadas por el proyecto "Persistencia". Esto es útil cuando se tiene una estructura de capas en la que el proyecto de aplicación necesita interactuar con la capa de persistencia, por ejemplo, para realizar operaciones de acceso a base de datos. 🔗🔧
        ```
        cd Aplicacion/
        ```
        ```
        dotnet add reference ../Dominio/
        ```
        ```
        dotnet add reference ../Persistencia/
        ```
    
    ---
    - Agrega una referencia al proyecto "Aplicacion" desde el proyecto "WebApi". Al hacer esto, el proyecto "WebApi" podrá acceder y utilizar las clases y funcionalidades proporcionadas por el proyecto "Aplicacion". Esto es útil cuando se tiene una estructura de capas en la que el proyecto de la API necesita interactuar con la capa de aplicación para exponer funcionalidades a través de la interfaz de la API y tambien agrega una referencia al proyecto "Seguridad" desde el proyecto "WebApi". Al hacer esto, el proyecto "WebApi" podrá acceder y utilizar las clases y funcionalidades proporcionadas por el proyecto "Seguridad". Esto es útil cuando se tiene una estructura de capas en la que el proyecto de la API necesita interactuar con la capa de aplicación para exponer funcionalidades a través de la interfaz de la API. 🔗🔧
        ```
        cd WebApi/
        ```
        ```
        dotnet add reference ../Aplicacion/
        ```
        ```
        dotnet add reference ../Seguridad/
        ```
    ---

    - Agrega una referencia al proyecto "Dominio" desde el proyecto "Persistencia". Al hacer esto, el proyecto "Persistencia" podrá acceder y utilizar las clases y funcionalidades proporcionadas por el proyecto "Dominio". Esto es útil cuando se tiene una estructura de capas en la que el proyecto de persistencia necesita acceder a los modelos y reglas de negocio definidos en el proyecto de dominio. 🔗🔧
        ```
        cd Persistencia/
        ```
        ```
        dotnet add reference ../Dominio/
        ```
    ---


    - Agrega una referencia al proyecto "Aplicacion" desde el proyecto "Seguridad". Al hacer esto, el proyecto "Seguridad" podrá acceder y utilizar las clases y funcionalidades proporcionadas por el proyecto "Aplicacion". Esto es útil cuando se tiene una estructura de capas en la que el proyecto de persistencia necesita acceder a los modelos y reglas de negocio definidos en el proyecto de dominio. 🔗🔧
        ```
        cd Seguridad/
        ```
        ```
        dotnet add reference ../Aplicacion/
        ```
    ---

---
<img src="https://1.bp.blogspot.com/-epbYlUPl2-c/Xh6loHanlbI/AAAAAAAACpI/Ift8Ukv9AbQVIHl2aKTLMjr-LA25WN8lwCLcBGAsYHQ/s1600/ASP.NET%2BCore.jpg" alt="https://1.bp.blogspot.com/-epbYlUPl2-c/Xh6loHanlbI/AAAAAAAACpI/Ift8Ukv9AbQVIHl2aKTLMjr-LA25WN8lwCLcBGAsYHQ/s1600/ASP.NET%2BCore.jpg" style="width: 3000px;">

---


## Gestión de Datos

- ### Instalacion de Paquetes

    - ### Dominio

        ---
        - Agrega el paquete "Microsoft.EntityFrameworkCore" con la versión 8.0.1 al proyecto actual. Entity Framework Core es una biblioteca popular para el acceso a bases de datos en proyectos .NET Core, y esta instrucción instalará la versión específica 8.0.1 de dicha biblioteca en el proyecto. Esto permitirá al proyecto utilizar Entity Framework Core para interactuar con bases de datos. 📂🔧
            ```
           dotnet add package Microsoft.EntityFrameworkCore --version 8.0.1
            ```
            ---

        - Agrega el paquete "MediatR.Extensions.Microsoft.DependencyInjection" con la versión 11.1.0 al proyecto actual. MediatR es una biblioteca que implementa el patrón Mediator para la comunicación entre componentes en aplicaciones .NET, y este paquete proporciona integración con la inyección de dependencias de Microsoft. 📂🔧
            ```
            dotnet add package MediatR.Extensions.Microsoft.DependencyInjection --version 11.1.0
            ```
            ---

        - Agrega el paquete "FluentValidation.AspNetCore" con la versión 11.3.0 al proyecto actual. FluentValidation es una biblioteca que permite realizar validaciones en modelos de forma sencilla y declarativa, y este paquete proporciona integración con ASP.NET Core. 📂🔧
            ```
            dotnet add package FluentValidation.AspNetCore --version 11.3.0
            ```
            ---

        - Agrega el paquete "itext7.pdfhtml" con la versión 5.0.2 al proyecto actual. Este paquete pertenece a iText 7, una biblioteca utilizada para trabajar con archivos PDF en aplicaciones .NET. En particular, "itext7.pdfhtml" es una extensión de iText 7 que permite convertir documentos HTML a PDF. 📂🔧
            ```
            dotnet add package itext7.pdfhtml --version 5.0.2
            ```
            ---


    - ### Persistencia 
        ---
        - Agrega el paquete "Microsoft.EntityFrameworkCore" con la versión 8.0.1 al proyecto actual. Entity Framework Core es una biblioteca popular para el acceso a bases de datos en proyectos .NET Core, y esta instrucción instalará la versión específica 8.0.1 de dicha biblioteca en el proyecto. Esto permitirá al proyecto utilizar Entity Framework Core para interactuar con bases de datos. 📂🔧
            ```
            dotnet add package Microsoft.EntityFrameworkCore --version 8.0.1
            ```
            ---

        - Agrega el paquete "Pomelo.EntityFrameworkCore.MySql" con la versión 7.0.0 al proyecto actual. Este paquete proporciona soporte para MySQL en Entity Framework Core y es una opción popular para interactuar con bases de datos MySQL en proyectos .NET Core. 📂🔧
            ```
            dotnet add package Pomelo.EntityFrameworkCore.MySql --version 7.0.0
            ```
            ---

        - Agrega el paquete "Dapper" con la versión 2.1.28 al proyecto actual. Dapper es una biblioteca que facilita el acceso y la manipulación de bases de datos en aplicaciones .NET mediante consultas SQL. Proporciona una forma sencilla y eficiente de mapear resultados de consultas a objetos. 📂🔧
            ```
            dotnet add package Dapper --version 2.1.28
            ```
            ---

    - ### Seguridad 
        ---
        - Agrega el paquete "System.IdentityModel.Tokens.Jwt" con la versión 7.2.0 al proyecto actual. Este paquete proporciona funcionalidades relacionadas con la generación y validación de tokens JWT (JSON Web Tokens), que son comunes en implementaciones de autenticación y autorización en aplicaciones web y servicios. 📂🔧
            ```
            dotnet add package System.IdentityModel.Tokens.Jwt --version 7.2.0
            ```
            ---

    - ### WebApi 
        ---
        - Agrega el paquete "AspNetCoreRateLimit" con la versión 5.0.0 al proyecto actual. Este paquete proporciona funcionalidad para la limitación de velocidad (rate limiting) en aplicaciones ASP.NET Core. Es útil para controlar el tráfico de entrada y evitar abusos o excesivas solicitudes de clientes. 📂🔧
            ```
            dotnet add package AspNetCoreRateLimit --version 5.0.0 
            ```
            ---

        - Agrega el paquete "AutoMapper.Extensions.Microsoft.DependencyInjection" con la versión 12.0.1 al proyecto actual. Este paquete proporciona extensiones para el framework AutoMapper que permiten una fácil integración con la inyección de dependencias de Microsoft. 📂🔧
            ```
            dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.1  
            ```
            ---

        - Agrega el paquete "Microsoft.AspNetCore.Mvc.Versioning" con la versión 5.1.0 al proyecto actual. Este paquete proporciona funcionalidades para la versión de API en aplicaciones ASP.NET Core, lo que te permite administrar y controlar las versiones de tus API de manera efectiva. 📂🔧
            ```
            dotnet add package Microsoft.AspNetCore.Mvc.Versioning --version 5.1.0 
            ```
            ---

        - Agrega el paquete "Microsoft.AspNetCore.OpenApi" con la versión 8.0.1 al proyecto actual. Proporciona API para anotar puntos finales del controlador de ruta en ASP.NET Core con anotaciones OpenAPI. 📂🔧
            ```
            dotnet add package Microsoft.AspNetCore.OpenApi --version 8.0.1
            ```
            ---

        - Agrega el paquete "Microsoft.EntityFrameworkCore.Design" con la versión 8.0.1 al proyecto actual. Este paquete proporciona herramientas de diseño para Entity Framework Core, que son útiles para trabajar con bases de datos y realizar migraciones en proyectos .NET Core. 📂🔧
            ```
            dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.1
            ```
           
            ---

        - Agrega el paquete "Microsoft.AspNetCore.Authentication.JwtBearer" con la versión 8.0.1 al proyecto actual. Este paquete proporciona funcionalidad para la autenticación basada en tokens JWT (JSON Web Tokens) en aplicaciones ASP.NET Core. 📂🔧
            ```
            dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 8.0.1
            ```
           
            ---

        - Agrega el paquete "Swashbuckle.AspNetCore" con la versión 6.5.0 al proyecto actual. Swashbuckle.AspNetCore es una biblioteca que permite generar automáticamente una documentación interactiva (Swagger UI) para tu API ASP.NET Core, lo que facilita la exploración y prueba de los endpoints de la API. 📂🔧
            ```
            dotnet add package Swashbuckle.AspNetCore --version 6.5.0  
            ```
            ---

        - Agrega el paquete "Serilog.AspNetCore" con la versión 8.0.0 al proyecto actual. Este paquete proporciona . 📂🔧
            ```
            dotnet add package Serilog.AspNetCore --version 8.0.0
            ```
           
            ---

        - Agrega el paquete "Swashbuckle.AspNetCore.Swagger" con la versión 6.5.0 al proyecto actual. Este paquete proporciona . 📂🔧
            ```
            dotnet add package Swashbuckle.AspNetCore.Swagger --version 6.5.0
            ```
           
            ---



<img src="https://cdn.icon-icons.com/icons2/2699/PNG/512/nuget_logo_icon_170908.png" alt="https://cdn.icon-icons.com/icons2/2699/PNG/512/nuget_logo_icon_170908.png" style="width: 3000px;">


- ### Migraciones    
    Se deben utilizar estos comandos para poder aplicar las migraciones y que los cambios se guarden en la base de datos ✈️🔧

    - ### Crear  
        - Este comando genera una migración inicial llamada "InitialCreate" utilizando Entity Framework Core. Las migraciones permiten mantener sincronizada la estructura de la base de datos con los cambios en el modelo de datos en proyectos .NET Core ✈️🔧
            ```
            dotnet ef migrations add InitialCreate --project ./Persistencia/ --startup-project ./ApiIncidencias/ --output-dir ./Data/Migrations/  
            ```
            
        ---

    - ### Actualizar
        - Este comando aplica las migraciones pendientes en la base de datos, lo que implica actualizar la estructura de la base de datos para que coincida con el estado actual del modelo de datos en los proyectos .NET Core involucrados. ✈️🔧
            ```
            dotnet ef database update --project ./Persistencia/ --startup-project ./ApiIncidencias/  
            ```
            
        ---

- ### Visualización de posibles errores  
    Este comando se utiliza para construir (compilar) los proyectos en sus respectivos directorios, una ventaja que posee este comando es que nos permite ver que errores podemos tener a la hora de complilar 🏗️

    - Compila el proyecto ubicado en el directorio actual. Esto significa que el código fuente del proyecto se compilará en ensamblados ejecutables, bibliotecas u otros tipos de archivos de salida según la configuración del proyecto. 🏗️
        ```
        dotnet build   
        ```

    ---
        

    **Ejemplos:**
    
    - Compila el proyecto ubicado en la carpeta "Infrastructure". Esto significa que el código fuente del proyecto se compilará en ensamblados ejecutables, bibliotecas o archivos de salida según la configuración del proyecto. 🏗️
        ```
        dotnet build ./Infrastructure/
        ```
            
        ---
    - Compila el proyecto ubicado en la carpeta "API". Esto significa que el código fuente del proyecto se compilará en ensamblados ejecutables, bibliotecas o archivos de salida según la configuración del proyecto. 🏗️
        ```
        dotnet build ./API/
        ```
            
     --- 
---

   <img src="https://media.discordapp.net/attachments/1115646463020634142/1134480692575731812/Presentacion_de_marca_personal_Acuarela_Elegante_y_minimalista_Azul_y_rosa.png?width=1173&height=660" alt="img" style="width: 3000px;">



