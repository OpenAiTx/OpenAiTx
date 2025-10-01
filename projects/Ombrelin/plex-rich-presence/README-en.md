> [!WARNING]  
>  **Status of the project**  
> This project is in maintenance-only mode. As I'm not a PLEX user anymore, I won't be working on new features for this project.  
> However, I will still review and integrate contributions, feel free to send a PR if you want to develop a specific feature.  

# Plex Rich Presence  

Plex Rich Presence is a multiplatform .NET 6 GUI App that allows you to display your current PLEX session in your Discord Rich presence status.  

<img src="https://github.com/Ombrelin/plex-rich-presence/blob/master/src/PlexRichPresence.UI.Avalonia/Assets/plex-rich-presence.png?raw=true" width="250" height="250">  

New features from version 2.1 :  

- Display media thumbnails dynamically on rich presence  

New features from version 2.0 :   

- Supports non-admin users  
- Supports choosing a server  
- CLI version  
- PLEX SSO Login  

## Release Version  

Releases for windows and linux can be found [here](https://github.com/Ombrelin/plex-rich-presence/releases/latest)  

## Screenshots  

![screenshots](https://raw.githubusercontent.com/Ombrelin/plex-rich-presence/master/screenshots/login.png)  

![screenshots](https://raw.githubusercontent.com/Ombrelin/plex-rich-presence/master/screenshots/server.png)  

![screenshots](https://raw.githubusercontent.com/Ombrelin/plex-rich-presence/master/screenshots/activity.png)  

## Build & Run form sources  

Requires .NET 8+ SDK

```
cd src/PlexRichPresence.UI.Avalonia
dotnet run
```

## Libraries used

- AvaloniaUI
- .NET MVVM Toolkit
- Microsoft DI
- Moq
- PlexApi
- Discord RPC .NET
- FluentAssertions

## Special Thanks

[@GrandKhan] for the logo

Thanks to [Discord](https://discord.com/) and [PLEX Media Server](https://plex.tv)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-01

---