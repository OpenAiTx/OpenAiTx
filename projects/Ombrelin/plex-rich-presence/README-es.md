> [!ADVERTENCIA]  
>  **Estado del proyecto**
> Este proyecto está solo en modo de mantenimiento. Como ya no soy usuario de PLEX, no trabajaré en nuevas funciones para este proyecto.
> Sin embargo, seguiré revisando e integrando contribuciones, siéntete libre de enviar un PR si deseas desarrollar una función específica.

# Plex Rich Presence

Plex Rich Presence es una aplicación GUI multiplataforma .NET 6 que te permite mostrar tu sesión actual de PLEX en tu estado de Discord Rich Presence.

<img src="https://github.com/Ombrelin/plex-rich-presence/blob/master/src/PlexRichPresence.UI.Avalonia/Assets/plex-rich-presence.png?raw=true" width="250" height="250">

Nuevas funciones desde la versión 2.1 :

- Mostrar miniaturas de medios dinámicamente en rich presence

Nuevas funciones desde la versión 2.0 : 

- Soporte para usuarios no administradores
- Soporte para elegir un servidor
- Versión CLI
- Inicio de sesión PLEX SSO

## Versión de lanzamiento

Las versiones para Windows y Linux se pueden encontrar [aquí](https://github.com/Ombrelin/plex-rich-presence/releases/latest)

## Capturas de pantalla

![screenshots](https://raw.githubusercontent.com/Ombrelin/plex-rich-presence/master/screenshots/login.png)

![screenshots](https://raw.githubusercontent.com/Ombrelin/plex-rich-presence/master/screenshots/server.png)

![screenshots](https://raw.githubusercontent.com/Ombrelin/plex-rich-presence/master/screenshots/activity.png)

## Construir y ejecutar desde fuentes

Requiere SDK .NET 8+

```
cd src/PlexRichPresence.UI.Avalonia
dotnet run
```

## Bibliotecas utilizadas

- AvaloniaUI
- .NET MVVM Toolkit
- Microsoft DI
- Moq
- PlexApi
- Discord RPC .NET
- FluentAssertions

## Agradecimientos especiales

[@GrandKhan] por el logo

Gracias a [Discord](https://discord.com/) y [PLEX Media Server](https://plex.tv)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-01

---