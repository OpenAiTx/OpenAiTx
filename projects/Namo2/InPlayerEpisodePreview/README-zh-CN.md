<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <p>以下翻译是通过 AI 自动生成的。请注意，其中可能包含不准确或引用了较旧版本的自述文件的内容。</p>
        <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

播放器剧集预览
====================
## 📄 关于
此插件会在视频播放器中添加剧集列表，让您无需离开播放器即可预览电视剧的每一集。

此修改支持以下客户端：
* [Jellyfin Web 客户端](https://github.com/jellyfin/jellyfin-web)
* [Jellyfin 媒体播放器](https://github.com/jellyfin/jellyfin-media-player)（JMP）桌面客户端

## ✨ 功能
* 列出某季的所有剧集
* 在季之间切换
* 显示剧集标题、描述、缩略图和播放进度
* 显示剧集详情，如社区排名
* 标记剧集为已播放或收藏
* 开始播放新剧集
* 支持自定义主题

## 📸 预览
<img src="https://github.com/Namo2/InPlayerEpisodePreview/blob/master/Images/preview.gif" width="550" height="450">

使用主题：（SkinManager）Kaleidochromic
<br>
此预览未显示用于标记剧集为已完成或收藏的新按钮。

## 🔧 安装

### Jellyfin Web 客户端（服务器）

> [!注意]
> 强烈推荐安装至少 v2.2.1.0 版本的 [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation)。该插件有助于避免在任何类型的安装中修改 index.html 时出现权限问题！
<details open>
<summary> 查看安装说明... </summary>

1. 将清单 `https://raw.githubusercontent.com/Namo2/InPlayerEpisodePreview/master/manifest.json` 添加为 Jellyfin 插件仓库到您的服务器。
2. 从仓库安装插件 `InPlayerEpisodePreview`。
3. 重启 Jellyfin 服务器。
</details>

### Jellyfin Media Player (JMP) 桌面客户端（已弃用）
<details>
<summary> 查看安装说明... </summary>

**自 JMP 版本 [1.11.0](https://github.com/jellyfin/jellyfin-media-player/releases/tag/v1.11.0) 起已弃用**

由于新版 JMP 客户端直接使用服务器上的当前网页播放器，已无需直接修改客户端代码。

这是在桌面客户端安装该脚本的推荐方式。
如果您不愿意自己编辑 nativeshell.js 文件（步骤3到6），您可以直接下载完整发布版，其中脚本已添加到 nativeshell.js 文件中。
目前还不清楚将 nativeshell.js 文件替换为发布版中的文件是否会有潜在问题，因此建议按照以下所有步骤操作。

1. 下载最新版 [JMP](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp.zip) 或 [JMP-full](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp-full.zip)（已包含脚本添加到 nativeshell.js 文件中）
2. 将压缩包解压到你的 Jellyfin 目录下（如 C:\Program Files\Jellyfin\Jellyfin Media Player）
3. 在你的 Jellyfin 目录下，按照文件夹路径“web-client\extension”查找
4. 用文本编辑器打开“nativeshell.js”文件。
5. 在文件中找到 `const plugins = [];` 这一部分。在列表开头添加新的一行，并粘贴 `'inPlayerEpisodePreviewPlugin',`。该部分现在应如下所示：
```javascript
const plugins = [
    'inPlayerEpisodePreviewPlugin',
    'mpvVideoPlayer',
    'mpvAudioPlayer',
    'jmpInputPlugin',
    'jmpUpdatePlugin',
    'jellyscrubPlugin',
    'skipIntroPlugin'
];
```
6. 保存文件并重启 JMP 客户端。
</details>

## 💡 故障排查

### 1. 预览按钮不可见
这很可能是由于 `index.html` 文件权限错误导致的。

<details>
<summary> 查看可能的解决方案列表... </summary>

#### 1.1 使用 [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation) 插件可避免此问题。

#### 1.2 在 docker 容器内更改所有权
如果你在 docker 容器中运行 jellyfin，可以通过以下命令更改所有权
（将 jellyfin 替换为你的容器名，user 和 group 替换为你容器的用户和用户组）：
```
docker exec -it --user root jellyfin chown user:group /jellyfin/jellyfin-web/index.html && docker restart jellyfin
```
你可以在系统启动时将此作为一个定时任务（cron job）运行。
（感谢 [muisje](https://github.com/muisje) 协助解决了 [此问题](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issue-2825745530)）

#### 1.3 在 Windows 安装环境下更改所有权
1. 导航至：`C:\Program Files\Jellyfin\Server\jellyfin-web\`
2. 右键点击 `index.html` → `属性` → `安全`标签页 → 点击`编辑`
3. 在列表中选择你的用户，并勾选写入`权限`框。
4. 重启服务端和客户端。
   （感谢 [xeuc](https://github.com/xeuc) 提供了 [此](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issuecomment-2746136069) 解决方案）

如果上述解决方案均无效，请查阅旧的问题。例如[这里](https://github.com/Namo2/InPlayerEpisodePreview/issues/10)或[这里](https://github.com/Namo2/InPlayerEpisodePreview/issues/49)。
</details>

<br/>
<br/>
如果你遇到无法自行解决的错误，欢迎随时提交问题。
<br/>请记住每个系统都不同，这可能导致意外行为，因此请尽可能提供详细的信息。
<br/>Jellyfin 日志和浏览器的控制台日志（以 [InPlayerEpisodePreview] 为前缀）总是很有帮助。

## 致谢
插件结构基于并受 [NickNSY](https://github.com/nicknsy) 的 [Jellyscrub](https://github.com/nicknsy/jellyscrub) 插件启发。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---