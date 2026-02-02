<div align="center">
  <br/>
  <img src="https://raw.githubusercontent.com/therepanic/spotilyrics/master/logo.png" width="350" alt="Spotilyrics logo"/>
  <p><i>在 VS Code 中编写代码时查看同步的 Spotify 歌词。</i></p>
<p>
  <a href="https://marketplace.visualstudio.com/items?itemName=therepanic.spotilyrics"><img src="https://img.shields.io/badge/VS%20Code-Extension-blue?style=flat&logo=visualstudiocode" /></a>
  <a href="https://developer.spotify.com/documentation/web-api"><img src="https://img.shields.io/badge/Spotify-API-1DB954?style=flat&logo=spotify" /></a>
  <a href="https://lrclib.net"><img src="https://img.shields.io/badge/Lyrics-LRClib-orange?style=flat" /></a>
  <a href="https://news.ycombinator.com/item?id=45087905"><img src="https://img.shields.io/badge/Hacker%20News-Discuss-orange?style=flat&logo=ycombinator" /></a>
  <a href="https://unlicense.org/"><img src="https://img.shields.io/badge/License-Unlicensed-red?style=flat" /></a>
</p>
</div>

---

## ✨ 功能

- 📌 与您的 Spotify 播放同步的**实时歌词**。
- 🎨 歌词颜色根据专辑封面自动主题（通过 `colorthief`）。
- 🖥️ 流畅的**侧边栏视图**——左侧编码，右侧显示歌词。
- 📱 **移动模式**——未播放的行为黑色，已播放的行为白色（类似 Spotify 移动应用）。
- 🔑 简单的**一次性登录**，使用您自己的 Spotify 客户端 ID。
- 🚪 快速注销命令以重置会话。
- ⚡ 设置歌词同步的**最大曲目缓存大小**。

---

## 📸 演示

## <img src="https://raw.githubusercontent.com/therepanic/spotilyrics/master/demo.png"/>

## ⚡️ 安装

1. 打开 **VS Code** → 扩展 → 搜索 `spotilyrics` 或者[从 VS Code 市场安装](https://marketplace.visualstudio.com/items?itemName=therepanic.spotilyrics)。

2. 运行命令：

```
Show Spotify Lyrics via Spotilyrics
```

---

## 🔑 认证（一次性设置）

1. 访问 [Spotify 开发者控制台](https://developer.spotify.com/dashboard)。
2. 创建一个应用 → 复制 **客户端 ID**。
3. **重要：** 将应用的 **重定向 URI** 设置为：`http://127.0.0.1:8000/callback`
4. 运行 `通过 Spotilyrics 显示 Spotify 歌词` 命令。
5. 在面板中粘贴你的 **客户端 ID** 并登录。
6. 享受编程时同步的歌词！🎶

> ℹ️ 为什么？– 为了尊重 Spotify API 请求限制，你需要自己的 ID。

---

## ⌨️ 命令

- `通过 Spotilyrics 显示 Spotify 歌词` (`spotilyrics.lyrics`) – 打开同步歌词面板。
- `切换移动模式` (`spotilyrics.toggleMobileMode`) – 在正常模式和移动模式之间切换。
- `退出 Spotilyrics 登录` (`spotilyrics.logout`) – 清除会话，必要时重新认证。
- `设置歌词缓存最大曲目数` (`spotilyrics.setTracksCacheMaxSize`) – 配置缓存歌词的最大曲目数。

---

## ⚙️ 技术栈

- [Spotify Web API](https://developer.spotify.com/documentation/web-api/)
- 用于带时间轴歌词的 [LRClib](https://lrclib.net/)
- 用于封面主题色的 [colorthief](https://lokeshdhakar.com/projects/color-thief/)
- TypeScript + VS Code WebView

---

## 📜 许可

本项目授权为 **无许可证**。  
欢迎使用、修改和重混，但不提供任何担保😉

---

<div align="center">
<sub>由 therepanic ❤️ 制作。努力编码，尽情享受氛围 🎧</sub>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-02

---