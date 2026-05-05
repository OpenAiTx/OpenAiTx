<div align="center">

  <!-- PROJECT LOGO -->
  <br />
    <a href="https://goawayedge.com">
      <img src="https://dl.exploitox.de/goawayedge/gh-banner-goawayedge.png" alt="GoAwayEdge Banner">
    </a>
  <br />

  [![Version][version-shield]][version-url]
  [![Download Counter][downloads-shield]][downloads-url]
  [![License][license-shield]][license-url]
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
    <p>Don't like Microsoft Edge? Me neither. Redirect all Edge calls to your favorite browser!</p>
    <a href="https://github.com/valnoxy/GoAwayEdge/releases">Download now</a>
    ·
    <a href="https://github.com/valnoxy/GoAwayEdge/issues">Report Bug</a>
    ·
    <a href="https://github.com/valnoxy/GoAwayEdge/discussions/">Discussions</a>
    ·
    <a href="https://translate.valnoxy.dev/engage/goawayedge/">Help me translate</a>
    <br />
    <br />
    🎉 Version 2.0.1 is out. Check out the release notes
    <a href="https://github.com/valnoxy/GoAwayEdge/releases">here</a>.
    <br />
    <br />
  </p>
</div>

---

> [!NOTE]
> This application will modify the system. I won't be responsible for any damage you've done yourself trying to use this application.

# 🚀Introduction
GoAwayEdge is designed for those who, like me, aren’t fans of Microsoft Edge or Windows Copilot. If you find yourself constantly annoyed by Edge popping up unexpectedly, fear not! This clever utility redirects all Edge-related calls to your preferred browser, ensuring a seamless browsing experience.

Here are some key points about GoAwayEdge:

- Purpose: The primary purpose of GoAwayEdge is to intercept any requests or actions that would normally trigger Microsoft Edge and reroute them to your favorite browser instead.
- How It Works: GoAwayEdge interrupts the Edge process from launching by hooking via Image File Execution Options. It then reads the arguments, parses them and redirects them to your default browser.
- Compatibility: It works on Windows 10 / 11 systems and provides a simple solution for those who want to avoid Edge altogether.

Feel free to explore the code, contribute, or simply enjoy a browser experience free from unexpected Edge encounters! 🚀

# 🤸 Installation methods
## 💿 1. Default Installation
1. Download the latest version from [GitHub](https://github.com/valnoxy/GoAwayEdge/releases).
2. Start the application.
3. Accept the license.
4. Customize GoAwayEdge as you like.
5. Done!

## 📦 2. Package Manager
| Package Manager          | Command                               |
| ------------------------ | ------------------------------------- |
| winget                   | `winget install Exploitox.GoAwayEdge`<br>You can also pre-configure GoAwayEdge with `--custom`: `winget install goawayedge --custom "-e:DuckDuckGo"` |                        

## 🤫 3. Silent Installation
You can install GoAwayEdge silently by parsing the following arguments:

| Switch                   | Description                                                                                                                    |
| ------------------------ | ------------------------------------------------------------------------------------------------------------------------------ |
| `-s`                     | Silent installation                                                                                                            |
| `-e:<Engine>`            | Specify the Search Engine: `Google` (default), `Bing`, `DuckDuckGo`, `Yahoo`, `Yandex`, `Ecosia`, `Ask`, `Qwant`, `Perplexity` |
| `-a:<AI Service>`        | Specify the AI Service: `Default`, `Copilot`, `ChatGPT`, `Gemini`, `GitHub_Copilot`, `Grok`                                    |
| `-w:<Weather Service>`   | Specify the Weather Service: `Default`, `WeatherCom`, `AccuWeather`                                                            |
| `--search-url:<Url>`     | Custom search query url (ex: `https://google.com/search?q=`)                                                                   |
| `--ai-url:<Url>`         | Custom AI website (ex: `https://chatgpt.com`)                                                                                  |
| `--weather-url:<Url>`    | Custom weather query url (ex: `https://my-weather.com/{country-code}/{latitude},{longitude}`)                                  |

<b>Example</b>:

```bat
GoAwayEdge.exe -s -e:DuckDuckGo
```

# 🗑️ Remove GoAwayEdge
You can uninstall GoAwayEdge just like any other application. Alternatively, you can also take this way: 
1. Download the latest version from [GitHub](https://github.com/valnoxy/GoAwayEdge/releases).
2. Start the application.
3. Click on ```Uninstall```.
4. Done!

You can also silently uninstall GoAwayEdge by parsing the following argument:
```bat
GoAwayEdge.exe -u
```

# 🖼️ Screenshots
<img src="https://dl.exploitox.de/goawayedge/GoAwayEdge_Screenshot2.png" alt="GoAwayEdge Setup" width=650>
<img src="https://dl.exploitox.de/goawayedge/GoAwayEdge_Screenshot3_Bar.png" alt="Copilot Replacement" width=300>

# 🙏 Libraries
This project uses the following libraries:
- [ManagedShell](https://github.com/cairoshell/ManagedShell)
- [Microsoft.Toolkit.Uwp.Notification](https://github.com/CommunityToolkit/WindowsCommunityToolkit)
- [TaskScheduler](https://github.com/dahall/taskscheduler)
- [WPF-UI](https://github.com/lepoco/wpfui)


# 🧾 License
GoAwayEdge is licensed under [MIT](https://github.com/valnoxy/GoAwayEdge/blob/main/LICENSE). So you are allowed to use freely and modify the application. I will not be responsible for any outcome. Proceed with any action at your own risk.

<hr>
<h6 align="center">© 2018 - 2026 valnoxy. All Rights Reserved. 
<br>
By Jonas Günner &lt;jonas@exploitox.de&gt;</h6>
<p align="center">
	<a href="https://github.com/valnoxy/GoAwayEdge/blob/main/LICENSE"><img src="https://img.shields.io/static/v1.svg?style=for-the-badge&label=License&message=MIT&logoColor=d9e0ee&colorA=363a4f&colorB=b7bdf8"/></a>
</p
