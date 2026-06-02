# EbookDownloader
一个用于从不同出版商下载已购买电子书的工具。

![预览](https://raw.githubusercontent.com/RythenGlyth/EbookDownloader/master/preview.png)

## 目录
- [支持的出版商（网站）](#supported-publishers-websites)
- [自动安装](#automatic-installation)
- [手动安装](#manual-installation)
- [运行](#running)
- [保存凭证](#saving-credentials-to-avoid-entering-them-every-time-optional)
- [Bildungslogin（Cornelsen / Westermann）](#bildungslogin)

## 支持的出版商（网站）
| 出版商 | 网站 | 最佳质量 | 可选文本 | 超链接 | 备注 |
| --- | --- | --- | --- | --- | --- |
| Cornelsen（“新方法”） | cornelsen.de | 无损 PDF | &check; | &check; |  |
| Cornelsen（“旧方法”） | cornelsen.de | 图像（8617px x 11792px）合成 | &check; | &cross; |  |
| Cornelsen.CH | ebooks.cornelsen.ch | 无损 PDF | &check; | &cross; |  |
| Cornelsen | scook.de | 图像（？）合成 | &cross; | &cross; | |
| Allango Klett | allango.net | 无损 PDF | &check; | ? | [1] |
| Klett | klett.de | 图像（3072px x 4096px）合成 | &check; | &check; | |
| Westermann | westermann.de | 图像（2244px x 3071px）合成 | &check; | &cross; | |
| C.C.BUCHNER | click-and-study.de | 图像（1658px x 2211px）合成 | &check; | &cross; | |
| C.C.BUCHNER | click-and-teach.de | 图像（1658px x 2211px）合成 | &check; | &cross; | |
| Book2Look | book2look.com | 无损 PDF | &check; | ? | [2] |
| kiosquemag | kiosquemag.com | 图像（？）合成 | &cross; | &cross; | |
| Helbling Media App | helbling.com | 无损 PDF | &check; | &cross; | |

[1]: 网站允许下载未拥有的文件

[2]: 不需要账户，仅需书籍ID

## 自动安装
首先，克隆或下载仓库。

该工具使用图像处理库，必须用 nodejs 运行，因此需要一些依赖。

你可以使用安装脚本（Windows 使用 `init.bat`，Debian 系发行版使用 `init.sh`）或手动安装。安装脚本会为你下载所有依赖。执行方法：Windows 下双击 `.bat` 文件，Linux 下赋予 `.sh` 文件执行权限后在终端执行 `.sh` 文件。

## 手动安装
首先，克隆或下载仓库。然后按照以下操作系统特定的说明进行操作：

### Windows
1. 从 http://www.unifoundry.com/pub/unifont/unifont-15.0.01/font-builds/unifont-15.0.01.ttf 下载 `unifont-15.0.01.ttf` 并放置在项目根目录
1. 安装 `ffmpeg`，并将 ffmpeg 可执行文件（命名为 `ffmpeg`）放入项目根目录或添加到你的路径环境变量中，如需帮助可参考[此教程](https://phoenixnap.com/kb/ffmpeg-windows)
1. 安装 `mutool`，并将 mutool 可执行文件（命名为 `mutool`）放入项目根目录或添加到你的路径环境变量中，你可以在[这里](https://mupdf.com/releases)找到最新版本。搜索带有 `windows` 的发布版本。（仅对 book2look 和 cornelsen.ch 必需）
1. 如果尚未安装，安装 `nodejs` 和 `npm`，你可以在[这里](https://phoenixnap.com/kb/install-node-js-npm-on-windows)找到帮助
1. 运行 `npm install`
1. 可选安装 `image magick`，并将 magick 可执行文件（命名为 `magick`）放入项目根目录或添加到你的路径环境变量中（仅对 cornelsen “旧方法” 必需）

### Linux
1. 运行 `wget "http://www.unifoundry.com/pub/unifont/unifont-15.0.01/font-builds/unifont-15.0.01.ttf"`
1. 使用你喜欢的软件包管理器安装 `ffmpeg`、`nodejs`、`mutool`/`mupdf-tools`/`mupdf`（book2look 和 cornelsen.ch 需要）以及可选的 `imagemagick`（仅对 cornelsen “旧方法” 必需）
1. 运行 `npm install`

### Linux/Darwin 使用 Nix
- 如果你有 nix-direnv，运行 `direnv allow` 来获取所有依赖
- 否则，运行 `nix-shell`
- 运行 `wget "http://www.unifoundry.com/pub/unifont/unifont-15.0.01/font-builds/unifont-15.0.01.ttf"`

## 运行
在项目目录中运行 `npm install` 完成设置，
然后在项目目录执行 `npm start` 启动程序。

## 保存凭据以避免每次输入（可选）
你可以将凭据保存在 `config.json` 文件中，以避免每次启动程序时输入。为此，在项目根目录创建一个名为 `config.json` 的文件，并添加以下内容：

```json
{
    "[PUBLISHER]": {
        "email": "[YOUR_USERNAME_OR_EMAIL]", 
        "passwd": "[YOUR_PASSWORD]"
    },
    "[PUBLISHER]": {
        "email": "[YOUR_USERNAME_OR_EMAIL]", 
        "passwd": "[YOUR_PASSWORD]"
    }
    [...]
}
```

Replace all the square brackets with your data. Publisher keys are: `cornelsen`, `klett`, `allango`, `scook`, `westermann`, `clicknstudy`, `clicknteach`, `kiosquemag`, `cornelsench`, `book2look`, `helbling`

## Bildungslogin

Cornelsen, Click-n-Study, Klett, and Westermann have token-login support, allowing login using Bildungslogin accounts.

### Cornelsen

1. 打开 Bildungslogin 并登录  
1. 进入存储开发者工具（SHIFT+F9，或者按 CTRL+SHIFT+I 并点击 Storage 选项卡）  
1. 打开图书  
1. 在开发者工具中选择本地存储（可能还需要选择网站）  
1. 在打开的表格中向下滚动，直到找到 `id_token`，它应该是一个长的字母数字字符串  
1. 复制它。（双击，然后 ctrl+c）  
1. 使用它作为密码，用户名使用 `token`  

### Click-and-Study

1. 打开 Bildungslogin 并登录  
1. 打开图书  
1. 进入存储开发者工具（SHIFT+F9，或者按 CTRL+SHIFT+I 并点击 Storage 选项卡）  
1. 在开发者工具中选择 Cookies（可能还需要选择网站）  
1. 在打开的表格中向下滚动，直到找到 `CASSID`，后面应有一个字母数字字符串  
1. 复制它（那些随机字符）。（双击，然后 ctrl+c）  
1. 使用它作为密码，用户名使用 `token`  

### Klett

1. 打开 Bildungslogin 并登录  
1. 打开图书  
1. 进入存储开发者工具（SHIFT+F9，或者按 CTRL+SHIFT+I 并点击 Storage 选项卡）  
1. 在开发者工具中选择 Cookies（可能还需要选择网站）  
1. 在打开的表格中向下滚动，直到找到 `SESSION`，后面应有一个字母数字字符串  
1. 复制它（那些随机字符）。（双击，然后 ctrl+c）  
1. 使用它作为密码，用户名使用**你正在使用的图书查看器的 URL**  

### Westermann

1. 打开 Bildungslogin 并登录  
1. 打开书籍  
1. 进入网络开发工具（CTRL+SHIFT+E，或者按CTRL+SHIFT+I然后点击网络标签页）。  
1. 勾选 `Persist logs`（可能在齿轮菜单中，大概在右上角某处）  
1. 重新加载页面  
1. 在开发者工具的“过滤URL”字段中输入 `/api/user`  
1. 点击第一个不是 OPTIONS 的条目  
1. 旁边会打开一个小面板。点击其 Headers 标签  
1. 在“过滤请求头”字段中输入 `auth`（如果有该字段）  
1. 向下滚动直到找到一串长的字母和数字  
1. 复制它并粘贴到文本文件中  
1. 再次从文本文件复制，但确保不要选择“Authorization: Bearer ”部分，只选结尾的长字符串。  
1. 使用它作为密码，用户名使用 `token`。  

## 贡献  

欢迎创建 issue 和 pull request 来为项目做出贡献。  

## 免责声明  
本项目仅供教育用途。项目对软件的任何滥用不负责任。根据您所在的司法管辖区，未经出版商同意使用本软件下载电子书可能是违法的。在其他司法管辖区，下载电子书仅供个人使用可能是合法的。请在使用本软件前检查当地法律。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-02

---