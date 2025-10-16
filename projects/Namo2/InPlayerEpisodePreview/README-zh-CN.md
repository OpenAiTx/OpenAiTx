In Player 集数预览
====================
## 关于 ##
此插件为视频播放器添加了一个剧集列表，允许您在播放器内预览电视剧的每一集，无需离开播放器。

此修改支持以下客户端：
* [Jellyfin Web 客户端](https://github.com/jellyfin/jellyfin-web)
* [Jellyfin 媒体播放器](https://github.com/jellyfin/jellyfin-media-player)（JMP）桌面客户端

### 功能 ###
* 列出一季中的所有剧集
* 在季之间切换
* 显示剧集标题、简介、缩略图和播放进度
* 显示剧集详情，如社区评分
* 标记剧集为已播放或收藏
* 开始新的剧集播放
* 应支持自定义主题

## 预览 ##
<img src="https://github.com/Namo2/InPlayerEpisodePreview/blob/master/Images/preview.gif" width="550" height="450">

使用主题：（SkinManager）Kaleidochromic
<br>
此预览缺少标记剧集为完成或收藏的新按钮。

## 安装 ##

### Jellyfin Web 客户端（服务器） ###
1. 将清单 `https://raw.githubusercontent.com/Namo2/InPlayerEpisodePreview/master/manifest.json` 添加为服务器的 Jellyfin 插件仓库。
2. 从该仓库安装插件 `InPlayerEpisodePreview`。
3. 重启 Jellyfin 服务器。

<br/>

### Jellyfin 媒体播放器（JMP）桌面客户端 ###
### **自 JMP 版本 [1.11.0](https://github.com/jellyfin/jellyfin-media-player/releases/tag/v1.11.0) 起已废弃** ###
由于新版 JMP 客户端使用的是来自服务器本身的当前网页版播放器，因此不再需要直接修改客户端代码。

这是在桌面客户端上安装脚本的推荐方式。
如果您对自行编辑 nativeshell.js 文件（步骤3至6）不熟悉，可以下载完整版本，该版本已将脚本添加到 nativeshell.js 文件中。
目前尚不清楚用发布版的 nativeshell.js 文件替换原文件是否会出现潜在问题，因此建议按照以下所有步骤操作。

1. 下载最新版本 [JMP](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp.zip) 或 [JMP-full](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp-full.zip)（已包含添加至 nativeshell.js 文件的脚本）
2. 将压缩包解压到你的 Jellyfin 目录（例如 C:\Program Files\Jellyfin\Jellyfin Media Player）
3. 在 Jellyfin 目录中，依次进入文件夹路径 "web-client\extension"
4. 用文本编辑器打开 "nativeshell.js" 文件。
5. 在文件中找到 `const plugins = [];` 这一部分。在列表开头添加一行，粘贴 `'inPlayerEpisodePreviewPlugin',`。该部分应类似如下所示：
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

## 故障排除 ##

### 1. 预览按钮不可见 ###
这很可能与 `index.html` 文件的权限错误有关。

#### 1.1 在 Docker 容器内更改所有权 ####
如果您在 Docker 容器中运行 jellyfin，可以使用以下命令更改所有权
（将 jellyfin 替换为您的容器名称，user 和 group 替换为您的容器的用户和组）：
```
docker exec -it --user root jellyfin chown user:group /jellyfin/jellyfin-web/index.html && docker restart jellyfin
```
您可以将此作为系统启动时的cron作业运行。

（感谢 [muisje](https://github.com/muisje) 帮助解决了 [此问题](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issue-2825745530)）

#### 1.2 在Windows安装上更改所有权 ####
1. 进入路径：`C:\Program Files\Jellyfin\Server\jellyfin-web\`
2. 右键点击 `index.html` → `属性` → `安全` 选项卡 → 点击 `编辑`
3. 从列表中选择您的用户并勾选写入 `权限` 框。
4. 重启服务器和客户端。

（感谢 [xeuc](https://github.com/xeuc) 提供了 [此解决方案](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issuecomment-2746136069)）

如果这仍然不起作用，请参阅 [此](https://github.com/Namo2/InPlayerEpisodePreview/issues/10)（或 [此](https://github.com/Namo2/InPlayerEpisodePreview/issues/49)）问题中的讨论。

<br/>
如果您遇到无法自行解决的错误，欢迎随时提交问题。
<br/>请记住，每个系统都有所不同，这可能导致意外行为，因此请尽可能提供详细信息。
<br/>Jellyfin日志和浏览器控制台日志（带有 [InPlayerEpisodePreview] 前缀）总是非常有用。

## 缺点 ##
* 插件会从服务器下载一些额外的数据，如剧集描述。

## 致谢 ##
该插件结构基于并受到了 [NickNSY](https://github.com/nicknsy) 的 [Jellyscrub](https://github.com/nicknsy/jellyscrub) 插件的启发。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---