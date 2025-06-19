# .NET Aspire

[![Tests](https://github.com/dotnet/aspire/actions/workflows/tests.yml/badge.svg?branch=main&event=push)](https://github.com/dotnet/aspire/actions/workflows/tests.yml)
[![Build Status](https://dev.azure.com/dnceng-public/public/_apis/build/status%2Fdotnet%2Faspire%2Fdotnet.aspire?branchName=main)](https://dev.azure.com/dnceng-public/public/_build/latest?definitionId=274&branchName=main)
[![Help Wanted](https://img.shields.io/github/issues/dotnet/aspire/help%20wanted?style=flat&color=%24EC820&label=help%20wanted)](https://github.com/dotnet/aspire/labels/help%20wanted)
[![Good First Issue](https://img.shields.io/github/issues/dotnet/aspire/good%20first%20issue?style=flat&color=%24EC820&label=good%20first%20issue)](https://github.com/dotnet/aspire/labels/good%20first%20issue)
[![Discord](https://img.shields.io/discord/732297728826277939?style=flat&logo=discord&logoColor=white&label=Join%20our%20Discord&labelColor=512bd4&color=cyan)](https://discord.com/invite/h87kDAHQgJ)

## ¿Qué es .NET Aspire?

.NET Aspire es un stack de opinión, listo para la nube, para construir aplicaciones distribuidas observables y listas para producción. .NET Aspire se entrega a través de una colección de paquetes NuGet que abordan preocupaciones específicas de aplicaciones nativas de la nube. Las aplicaciones nativas de la nube suelen estar compuestas por piezas pequeñas e interconectadas o microservicios en lugar de una única base de código monolítica. Generalmente, las aplicaciones nativas de la nube consumen una gran cantidad de servicios, como bases de datos, mensajería y almacenamiento en caché.

.NET Aspire ayuda con:

[Orquestación](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#orchestration): .NET Aspire proporciona características para ejecutar y conectar aplicaciones multiproyecto y sus dependencias.

[Integraciones](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#net-aspire-integrations): Las integraciones de .NET Aspire son paquetes NuGet para servicios comúnmente usados, como Redis o Postgres, con interfaces estandarizadas que aseguran que se conecten de manera consistente y sin problemas con tu aplicación.

[Herramientas](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#project-templates-and-tooling): .NET Aspire viene con plantillas de proyectos y experiencias de herramientas para Visual Studio y la CLI de dotnet, que te ayudan a crear e interactuar con aplicaciones .NET Aspire.

Para obtener más información, lee la [visión general y documentación completa de .NET Aspire](https://learn.microsoft.com/dotnet/aspire/). Hay ejemplos disponibles en el [repositorio de ejemplos de .NET Aspire](https://github.com/dotnet/aspire-samples). Puedes encontrar el [ejemplo de eShop aquí](https://github.com/dotnet/eshop) y la [versión para Azure aquí](https://github.com/Azure-Samples/eShopOnAzure).

## ¿Qué contiene este repositorio?

El host de aplicaciones .NET Aspire, el panel de control, la infraestructura de descubrimiento de servicios y todas las integraciones de .NET Aspire. También contiene las plantillas de proyectos.

## Usar las compilaciones diarias más recientes

Sigue las instrucciones en [docs/using-latest-daily.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/using-latest-daily.md) para comenzar a usar .NET Aspire con la última compilación diaria.

## ¿Cómo puedo contribuir?

¡Agradecemos las contribuciones! Muchas personas en todo el mundo han ayudado a mejorar .NET.

Sigue las instrucciones en [docs/contributing.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/contributing.md) para trabajar con el código en el repositorio.

## Reportar problemas y errores de seguridad

Los problemas y errores de seguridad deben ser reportados de forma privada, por correo electrónico, al Centro de Respuesta de Seguridad de Microsoft (MSRC) <secure@microsoft.com>. Deberías recibir una respuesta en un plazo de 24 horas. Si por alguna razón no la recibes, por favor sigue contactando por correo electrónico para asegurar que recibimos tu mensaje original. Más información, incluyendo la clave PGP del MSRC, se puede encontrar en el [Security TechCenter](https://www.microsoft.com/msrc/faqs-report-an-issue). También puedes encontrar estas instrucciones en el [documento de seguridad](https://raw.githubusercontent.com/dotnet/aspire/main/SECURITY.md) de este repositorio.

Consulta también la información sobre el [Programa de recompensas por errores de Microsoft .NET Core y ASP.NET Core](https://www.microsoft.com/msrc/bounty-dot-net-core).

### Nota sobre los contenedores utilizados por los recursos e integraciones de cliente de .NET Aspire

El equipo de .NET no puede evaluar los contenedores de terceros subyacentes para los que tenemos soporte de API sobre su idoneidad para requisitos específicos de clientes.

Debes evaluar los contenedores que elijas componer y automatizar con Aspire para asegurarte de que cumplen con tus requisitos, los de tu empleador o los de tu gobierno en cuanto a seguridad y protección, así como regulaciones criptográficas y cualquier otro estándar regulatorio o corporativo que pueda aplicarse a tu uso del contenedor.

## .NET Foundation

.NET Aspire es un proyecto de la [.NET Foundation](https://www.dotnetfoundation.org/projects).

Hay muchos proyectos relacionados con .NET en GitHub.

* [Repositorio principal de .NET](https://github.com/Microsoft/dotnet) - enlaces a cientos de proyectos .NET, de Microsoft y la comunidad.
* [Página principal de ASP.NET Core](https://docs.microsoft.com/aspnet/core) - el mejor lugar para empezar a aprender sobre ASP.NET Core.

Este proyecto ha adoptado el código de conducta definido por el [Contributor Covenant](https://contributor-covenant.org) para aclarar el comportamiento esperado en nuestra comunidad. Para más información, consulta el [Código de Conducta de la .NET Foundation](https://www.dotnetfoundation.org/code-of-conduct).

## Licencia

El código en este repositorio está licenciado bajo la licencia [MIT](https://raw.githubusercontent.com/dotnet/aspire/main/LICENSE.TXT).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---