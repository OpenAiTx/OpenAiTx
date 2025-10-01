> [!ATTENTION]  
>  **Statut du projet**  
> Ce projet est en mode maintenance uniquement. Comme je ne suis plus utilisateur de PLEX, je ne travaillerai pas sur de nouvelles fonctionnalités pour ce projet.  
> Cependant, je continuerai à revoir et intégrer les contributions, n’hésitez pas à envoyer une PR si vous souhaitez développer une fonctionnalité spécifique.  

# Plex Rich Presence  

Plex Rich Presence est une application multiplateforme .NET 6 avec interface graphique qui vous permet d’afficher votre session PLEX actuelle dans votre statut Rich Presence Discord.  

<img src="https://github.com/Ombrelin/plex-rich-presence/blob/master/src/PlexRichPresence.UI.Avalonia/Assets/plex-rich-presence.png?raw=true" width="250" height="250">  

Nouvelles fonctionnalités depuis la version 2.1 :  

- Affichage dynamique des vignettes des médias dans la rich presence  

Nouvelles fonctionnalités depuis la version 2.0 :  

- Support des utilisateurs non administrateurs  
- Possibilité de choisir un serveur  
- Version CLI  
- Connexion PLEX SSO  

## Version de sortie  

Les versions pour Windows et Linux sont disponibles [ici](https://github.com/Ombrelin/plex-rich-presence/releases/latest)  

## Captures d’écran  

![screenshots](https://raw.githubusercontent.com/Ombrelin/plex-rich-presence/master/screenshots/login.png)  

![screenshots](https://raw.githubusercontent.com/Ombrelin/plex-rich-presence/master/screenshots/server.png)  

![screenshots](https://raw.githubusercontent.com/Ombrelin/plex-rich-presence/master/screenshots/activity.png)  

## Compilation et exécution depuis les sources  

Nécessite le SDK .NET 8+

```
cd src/PlexRichPresence.UI.Avalonia
dotnet run
```

## Bibliothèques utilisées

- AvaloniaUI
- .NET MVVM Toolkit
- Microsoft DI
- Moq
- PlexApi
- Discord RPC .NET
- FluentAssertions

## Remerciements spéciaux

[@GrandKhan] pour le logo

Merci à [Discord](https://discord.com/) et [PLEX Media Server](https://plex.tv)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-01

---