<div align="center">

  <!-- 项目徽标 -->
  <br />
    <a href="https://goawayedge.com">
      <img src="https://dl.exploitox.de/goawayedge/gh-banner-goawayedge.png" alt="GoAwayEdge 横幅">
    </a>
  <br />

  [![版本][version-shield]][version-url]
  [![下载计数][downloads-shield]][downloads-url]
  [![许可证][license-shield]][license-url]
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
    <p>不喜欢微软 Edge？我也不喜欢。将所有 Edge 调用重定向到你喜欢的浏览器！</p>
    <a href="https://github.com/valnoxy/GoAwayEdge/releases">立即下载</a>
    ·
    <a href="https://github.com/valnoxy/GoAwayEdge/issues">报告错误</a>
    ·
    <a href="https://github.com/valnoxy/GoAwayEdge/discussions/">讨论区</a>
    ·
    <a href="https://translate.valnoxy.dev/engage/goawayedge/">帮助我翻译</a>
    <br />
    <br />
    🎉 版本 2.0.1 已发布。查看发布说明
    <a href="https://github.com/valnoxy/GoAwayEdge/releases">这里</a>。
    <br />
    <br />
  </p>
</div>

---

> [!注意]
> 本应用将修改系统。因使用本应用导致的任何损害，作者不承担任何责任。

# 🚀介绍
GoAwayEdge 适合像我一样不喜欢 Microsoft Edge 或 Windows Copilot 的用户。如果你经常被突然弹出的 Edge 打扰，不必担心！这个巧妙的工具会将所有与 Edge 相关的调用重定向到你喜欢的浏览器，确保流畅的浏览体验。

以下是关于 GoAwayEdge 的一些关键点：

- 目的：GoAwayEdge 的主要目的是拦截任何本应启动 Microsoft Edge 的请求或操作，并将其重定向到你喜欢的浏览器。
- 工作原理：GoAwayEdge 通过 Image File Execution Options 挂钩，阻止 Edge 进程启动。然后读取参数，解析并重定向到默认浏览器。
- 兼容性：它适用于 Windows 10 / 11 系统，为想完全避免 Edge 的用户提供简单解决方案。

欢迎探索代码、贡献或尽情享受无意外 Edge 弹出的浏览体验！🚀

# 🤸 安装方法
## 💿 1. 默认安装
1. 从 [GitHub](https://github.com/valnoxy/GoAwayEdge/releases) 下载最新版本。
2. 启动应用程序。
3. 接受许可协议。
4. 根据需要自定义 GoAwayEdge。
5. 完成！

## 📦 2. 包管理器
| 包管理器                 | 命令                                                                 |
| ------------------------ | -------------------------------------------------------------------- |
| winget                   | `winget install Exploitox.GoAwayEdge`<br>你也可以用 `--custom` 预配置 GoAwayEdge：`winget install goawayedge --custom "-e:DuckDuckGo"` |                        

## 🤫 3. 静默安装
你可以通过解析以下参数静默安装 GoAwayEdge：

| 参数                     | 描述                                                                 |
| ------------------------ | ------------------------------------------------------------------------------------------------------------------------------ |
| `-s`                     | 静默安装                                                                                                                        |
| `-e:<Engine>`            | 指定搜索引擎：`Google`（默认），`Bing`，`DuckDuckGo`，`Yahoo`，`Yandex`，`Ecosia`，`Ask`，`Qwant`，`Perplexity`                 |
| `-a:<AI Service>`        | 指定AI服务：`Default`，`Copilot`，`ChatGPT`，`Gemini`，`GitHub_Copilot`，`Grok`                                                 |
| `-w:<Weather Service>`   | 指定天气服务：`Default`，`WeatherCom`，`AccuWeather`                                                                           |
| `--search-url:<Url>`     | 自定义搜索查询网址（例如：`https://google.com/search?q=`）                                                                     |
| `--ai-url:<Url>`         | 自定义AI网站（例如：`https://chatgpt.com`）                                                                                     |
| `--weather-url:<Url>`    | 自定义天气查询网址（例如：`https://my-weather.com/{country-code}/{latitude},{longitude}`）                                      |

<b>示例</b>:

```bat
GoAwayEdge.exe -s -e:DuckDuckGo
```

# 🗑️ 移除 GoAwayEdge
您可以像卸载其他应用程序一样卸载 GoAwayEdge。或者，您也可以通过以下方式操作：
1. 从 [GitHub](https://github.com/valnoxy/GoAwayEdge/releases) 下载最新版本。
2. 启动应用程序。
3. 点击 ```卸载```。
4. 完成！

您也可以通过解析以下参数静默卸载 GoAwayEdge：
```bat
GoAwayEdge.exe -u
```

# 🖼️ 截图
<img src="https://dl.exploitox.de/goawayedge/GoAwayEdge_Screenshot2.png" alt="GoAwayEdge 设置" width=650>
<img src="https://dl.exploitox.de/goawayedge/GoAwayEdge_Screenshot3_Bar.png" alt="Copilot 替代" width=300>

# 🙏 库
本项目使用以下库：
- [ManagedShell](https://github.com/cairoshell/ManagedShell)
- [Microsoft.Toolkit.Uwp.Notification](https://github.com/CommunityToolkit/WindowsCommunityToolkit)
- [TaskScheduler](https://github.com/dahall/taskscheduler)
- [WPF-UI](https://github.com/lepoco/wpfui)


# 🧾 许可
GoAwayEdge 采用 [MIT](https://github.com/valnoxy/GoAwayEdge/blob/main/LICENSE) 许可协议。您可以自由使用和修改此应用程序。对于任何结果，我不承担责任。请自行承担风险进行操作。

<hr>
<h6 align="center">© 2018 - 2026 valnoxy。版权所有。 
<br>
作者 Jonas Günner &lt;jonas@exploitox.de&gt;</h6>
<p align="center">
	<a href="https://github.com/valnoxy/GoAwayEdge/blob/main/LICENSE"><img src="https://img.shields.io/static/v1.svg?style=for-the-badge&label=License&message=MIT&logoColor=d9e0ee&colorA=363a4f&colorB=b7bdf8"/></a>
</p


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-05

---