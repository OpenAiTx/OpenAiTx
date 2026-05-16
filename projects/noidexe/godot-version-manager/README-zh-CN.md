<table><tr width=64px><td><img height=64px src="https://user-images.githubusercontent.com/526829/169241046-3087a41d-9606-43ab-90ae-ee0055bef039.png"/></td><td><h1>godot-version-manager</h1></td></tr></table>
  
从一个简单的应用下载、安装和管理任何版本的 Godot 引擎。

<img alt="screenshot with light theme" src="https://github.com/user-attachments/assets/5b504fa3-59ea-46c8-bb78-6a743759d984" />
<img alt="screenshot with dark theme" src="https://github.com/user-attachments/assets/08ff0100-fbd5-40be-a8a4-80bbb186d37e" />

## 安装
### Windows:
解压后双击运行。（Windows XP 上请确保已安装 Powershell）
### Linux:
解压后双击运行。下载版本的解压需要 `unzip`，如果未安装，应可在您的发行版仓库中找到
### OSX:
- 下载后应自动解压
- 需要运行 `sudo xattr -r -d com.apple.quarantine path/to/Godot Version Manager.app`，因为未签名的二进制文件会被标记为不受信任。如果不信任预构建的二进制文件，可自行编译项目
- 双击 Godot Version Manager.app

## 功能
- 从下拉菜单自动下载并安装任何版本的 Godot。（解压需要 powershell）
- 显示或隐藏下载下拉菜单中的 alpha、beta、rc 和 dev 版本。
- 可在文件系统任何位置添加您自己的二进制文件。
- 彩色图标，轻松区分稳定版、rc、beta、alpha 和 master 构建版本。
- 右键点击可从列表中移除条目
- 拖放以重新排序条目
- 拖放 project.godot 文件或 Godot 项目文件夹，以添加项目并用指定版本启动
- 来自 godotengine.org/news 的新闻订阅

## 常见问题解答
**问：下载的二进制文件保存在哪里？**

答：保存到 `user://versions`，具体位置根据平台不同而不同。Windows 上路径为 %appdata%/Godot/app_userdata/Godot Version Manager/versions

**问：这和 Hourglass 或 Godot Manager 有什么不同？**

答：
 - [Hourglass](https://hourglass.jwestman.net/) 是一个更成熟、功能更丰富的项目，支持更好的项目管理。GVM 唯一的优势可能是它还会从官网获取新闻摘要 :)
 - [Godot Manager](https://github.com/eumario/godot-manager) 似乎也是一个成熟且功能丰富的替代品。
 - [Godots](https://github.com/MakovWait/godots) 是一个新的（2023 年 8 月）替代方案，很多人喜欢。
 - [GodotEnv](https://github.com/chickensoft-games/GodotEnv) 和 [godot-version-manager](https://github.com/gaheldev/godot-version-manager) 是仅命令行界面的替代方案。
 - [Godot Launcher](https://github.com/sebastianoboem/godot-launcher) 是基于 Python 的替代品，支持扩展和缓存管理。
 - [gdvm](https://github.com/adalinesimonian/gdvm) 是另一个使用 Rust 构建的基于 CLI 的版本管理器。

## 许可证
MIT 许可证（见 LICENSE.md）
版权所有 ©️2022 Lisandro Lorea 及贡献者

Lilita One 字体 ©️2011 Juan Montoreano
<a href="https://www.flaticon.com/free-icons/exe" title="exe 图标">Exe 图标由 Freepik - Flaticon 创建</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-16

---