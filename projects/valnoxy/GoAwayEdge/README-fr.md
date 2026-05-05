<div align="center">

  <!-- LOGO DU PROJET -->
  <br />
    <a href="https://goawayedge.com">
      <img src="https://dl.exploitox.de/goawayedge/gh-banner-goawayedge.png" alt="Bannière GoAwayEdge">
    </a>
  <br />

  [![Version][version-shield]][version-url]
  [![Compteur de téléchargements][downloads-shield]][downloads-url]
  [![Licence][license-shield]][license-url]
  [![Weblate][weblate-shield]][weblate-url]
</div>

[version-shield]: https://img.shields.io/github/v/release/valnoxy/GoAwayEdge?color=9565F6
[version-url]: https://github.com/valnoxy/GoAwayEdge/releases

[weblate-shield]: http://translate.valnoxy.dev/widget/goawayedge/svg-badge.svg
[weblate-url]: https://translate.valnoxy.dev/engage/goawayedge/

[downloads-shield]: https://img.shields.io/github/downloads/valnoxy/GoAwayEdge/total.svg?color=431D93
[downloads-url]: https://github.com/valnoxy/GoAwayEdge/releases

[license-shield]: https://img.shields.io/github/license/valnoxy/GoAwayEdge?color=9565F6
[license-url]: https://img.shields.io/github/license/valnoxy/GoAwayEdge

<div align="center">
  <h3 align="center">GoAwayEdge</h3>
  <p align="center">
    <p>Vous n'aimez pas Microsoft Edge ? Moi non plus. Redirigez toutes les requêtes Edge vers votre navigateur préféré !</p>
    <a href="https://github.com/valnoxy/GoAwayEdge/releases">Télécharger maintenant</a>
    ·
    <a href="https://github.com/valnoxy/GoAwayEdge/issues">Signaler un bug</a>
    ·
    <a href="https://github.com/valnoxy/GoAwayEdge/discussions/">Discussions</a>
    ·
    <a href="https://translate.valnoxy.dev/engage/goawayedge/">Aidez-moi à traduire</a>
    <br />
    <br />
    🎉 La version 2.0.1 est sortie. Consultez les notes de version
    <a href="https://github.com/valnoxy/GoAwayEdge/releases">ici</a>.
    <br />
    <br />
  </p>
</div>

---

> [!NOTE]
> Cette application modifiera le système. Je ne serai pas responsable des dommages que vous pourriez causer en essayant d’utiliser cette application.

# 🚀Introduction
GoAwayEdge est conçu pour ceux qui, comme moi, ne sont pas fans de Microsoft Edge ou Windows Copilot. Si vous êtes constamment dérangé par l’apparition inattendue d’Edge, ne vous inquiétez pas ! Cette astucieuse utilité redirige tous les appels liés à Edge vers votre navigateur préféré, assurant une expérience de navigation fluide.

Voici quelques points clés à propos de GoAwayEdge :

- Objectif : Le but principal de GoAwayEdge est d’intercepter toute demande ou action qui déclencherait normalement Microsoft Edge et de les rediriger vers votre navigateur favori.
- Fonctionnement : GoAwayEdge empêche le lancement du processus Edge en s’accrochant via les Image File Execution Options. Il lit ensuite les arguments, les analyse et les redirige vers votre navigateur par défaut.
- Compatibilité : Il fonctionne sur les systèmes Windows 10 / 11 et offre une solution simple pour ceux qui veulent éviter Edge complètement.

N’hésitez pas à explorer le code, contribuer, ou simplement profiter d’une expérience de navigation sans rencontres inattendues avec Edge ! 🚀

# 🤸 Méthodes d’installation
## 💿 1. Installation par défaut
1. Téléchargez la dernière version depuis [GitHub](https://github.com/valnoxy/GoAwayEdge/releases).
2. Lancez l’application.
3. Acceptez la licence.
4. Personnalisez GoAwayEdge à votre convenance.
5. Terminé !

## 📦 2. Gestionnaire de paquets
| Gestionnaire de paquets  | Commande                             |
| ------------------------ | ----------------------------------- |
| winget                   | `winget install Exploitox.GoAwayEdge`<br/>Vous pouvez aussi préconfigurer GoAwayEdge avec `--custom` : `winget install goawayedge --custom "-e:DuckDuckGo"` |                        

## 🤫 3. Installation silencieuse
Vous pouvez installer GoAwayEdge silencieusement en passant les arguments suivants :

| Option                   | Description                                                                                                                  |
| ------------------------ | ------------------------------------------------------------------------------------------------------------------------------ |
| `-s`                     | Installation silencieuse                                                                                                        |
| `-e:<Engine>`            | Spécifier le moteur de recherche : `Google` (par défaut), `Bing`, `DuckDuckGo`, `Yahoo`, `Yandex`, `Ecosia`, `Ask`, `Qwant`, `Perplexity` |
| `-a:<AI Service>`        | Spécifier le service IA : `Default`, `Copilot`, `ChatGPT`, `Gemini`, `GitHub_Copilot`, `Grok`                                    |
| `-w:<Weather Service>`   | Spécifier le service météo : `Default`, `WeatherCom`, `AccuWeather`                                                             |
| `--search-url:<Url>`     | URL personnalisée pour la requête de recherche (ex : `https://google.com/search?q=`)                                            |
| `--ai-url:<Url>`         | Site web IA personnalisé (ex : `https://chatgpt.com`)                                                                           |
| `--weather-url:<Url>`    | URL personnalisée pour la requête météo (ex : `https://my-weather.com/{country-code}/{latitude},{longitude}`)                   |

<b>Exemple</b> :

```bat
GoAwayEdge.exe -s -e:DuckDuckGo
```

# 🗑️ Supprimer GoAwayEdge
Vous pouvez désinstaller GoAwayEdge comme toute autre application. Alternativement, vous pouvez aussi procéder ainsi : 
1. Téléchargez la dernière version depuis [GitHub](https://github.com/valnoxy/GoAwayEdge/releases).
2. Lancez l’application.
3. Cliquez sur ```Désinstaller```.
4. Terminé !

Vous pouvez également désinstaller GoAwayEdge silencieusement en utilisant l’argument suivant :
```bat
GoAwayEdge.exe -u
```

# 🖼️ Captures d'écran
<img src="https://dl.exploitox.de/goawayedge/GoAwayEdge_Screenshot2.png" alt="Configuration GoAwayEdge" width=650>
<img src="https://dl.exploitox.de/goawayedge/GoAwayEdge_Screenshot3_Bar.png" alt="Remplacement de Copilot" width=300>

# 🙏 Bibliothèques
Ce projet utilise les bibliothèques suivantes :
- [ManagedShell](https://github.com/cairoshell/ManagedShell)
- [Microsoft.Toolkit.Uwp.Notification](https://github.com/CommunityToolkit/WindowsCommunityToolkit)
- [TaskScheduler](https://github.com/dahall/taskscheduler)
- [WPF-UI](https://github.com/lepoco/wpfui)


# 🧾 Licence
GoAwayEdge est sous licence [MIT](https://github.com/valnoxy/GoAwayEdge/blob/main/LICENSE). Vous êtes donc libre d'utiliser et de modifier l'application. Je ne serai pas responsable de tout résultat. Agissez à vos risques et périls.

<hr>
<h6 align="center">© 2018 - 2026 valnoxy. Tous droits réservés. 
<br>
Par Jonas Günner &lt;jonas@exploitox.de&gt;</h6>
<p align="center">
	<a href="https://github.com/valnoxy/GoAwayEdge/blob/main/LICENSE"><img src="https://img.shields.io/static/v1.svg?style=for-the-badge&label=Licence&message=MIT&logoColor=d9e0ee&colorA=363a4f&colorB=b7bdf8"/></a>
</p


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-05

---