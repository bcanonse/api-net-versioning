# Proyecto de Web API en .NET con Versionamiento

## Descripción

Este proyecto es una Web API desarrollada en .NET que implementa el versionamiento de API. El versionamiento permite a los desarrolladores gestionar cambios en la API sin interrumpir a los usuarios existentes. Este enfoque es crucial para mantener la compatibilidad y proporcionar una transición suave cuando se introducen nuevas características o se realizan modificaciones.

## Requisitos

* ([.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)) 
* [Visual Studio Code](https://code.visualstudio.com/download)
* Conocimientos básicos de C# y desarrollo de API REST


### ¿Por qué versionar una API Web?

El versionado de una API Web es crucial por varias razones:

* Compatibilidad: Permite que diferentes versiones de clientes y aplicaciones accedan a la API sin problemas.
* Evolución: Facilita la introducción de cambios en la API sin romper la funcionalidad existente.
* Deprecación: Permite marcar versiones específicas de la API como obsoletas antes de eliminarlas.
* Pruebas: Simplifica las pruebas de diferentes versiones de la API de forma independiente.

*Enfoques de Versionado Comunes:*

Existen dos enfoques principales para versionar una API Web en .NET:

#### 1. Versionado en la Ruta:

- Ejemplo: ``/api/v1/productos`` para la versión 1, ``/api/v2/productos`` para la versión 2.
- Ventajas: Simple, intuitivo para los desarrolladores.
- Desventajas: Puede afectar negativamente la estética de la URL, no es ideal para muchas versiones.

#### 2. Versionado en el Encabezado:

- Ejemplo: Encabezado ``Accept-Version: 1.0`` para la versión 1.
- Ventajas: Limpio en las URLs, soporta un gran número de versiones.
- Desventajas: Requiere que los clientes especifiquen el encabezado de la versión.



## Conclusión:

El versionado es una práctica esencial para desarrollar APIs Web robustas y escalables en .NET. Al utilizar las técnicas y herramientas adecuadas, puedes asegurarte de que tu API sea compatible con diferentes versiones de clientes y aplicaciones, facilitando su evolución y mantenimiento a largo plazo.