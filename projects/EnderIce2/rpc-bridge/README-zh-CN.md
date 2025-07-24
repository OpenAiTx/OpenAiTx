
# Wine 的 Discord RPC 桥接

![GitHub 许可证](https://img.shields.io/github/license/EnderIce2/rpc-bridge?style=for-the-badge)
![GitHub 下载量（所有资源，所有版本）](https://img.shields.io/github/downloads/EnderIce2/rpc-bridge/total?style=for-the-badge)
![GitHub 发布版本](https://img.shields.io/github/v/release/EnderIce2/rpc-bridge?style=for-the-badge)

一个简单的桥接程序，允许你在 Wine 游戏/软件中使用 Discord 富状态。

通过在前缀内运行一个小程序，创建一个名为 [named pipe](https://learn.microsoft.com/en-us/windows/win32/ipc/named-pipes) `\\.\pipe\discord-ipc-0` 的管道，并将所有数据转发到管道 `/run/user/1000/discord-ipc-0`。

此桥接利用了 Wine 中的 Windows 服务实现，省去了手动运行程序的需求。

---

## 安装与使用

安装程序会将自身复制到 `C:\windows\bridge.exe` 并创建一个 Windows 服务。  
日志存储在 `C:\windows\logs\bridge.log`。

#### 在前缀内安装

##### Wine (~/.wine)

- 双击 `bridge.exe` 并点击 `Install`。
    - ![gui](https://raw.githubusercontent.com/EnderIce2/rpc-bridge/master/docs/assets/gui.png)
- 若要移除，可按相同流程操作，但点击 `Remove`。

*注意，MacOS 需要额外的[步骤](https://github.com/EnderIce2/rpc-bridge?tab=readme-ov-file#macos)*

##### Lutris

- 点击某游戏，选择 `Run EXE inside Wine prefix`。
    - ![lutris](https://raw.githubusercontent.com/EnderIce2/rpc-bridge/master/docs/assets/lutris.png)
- 操作流程与 Wine 相同。

##### Steam

- 右击游戏，选择 `Properties`。
- 在 `Set Launch Options` 中添加以下内容：
    - ![bridge.sh](https://raw.githubusercontent.com/EnderIce2/rpc-bridge/master/docs/assets/steam_script.png "设置启动选项为 bridge.sh 的路径")
- `bridge.sh` 脚本必须与 `bridge.exe` 位于同一目录。

#### 如果你使用 Flatpak

- 如果你在 Flatpak 中运行 Steam、Lutris 等，需要允许桥接程序访问 `/run/user/1000/discord-ipc-0` 文件。
	- ##### 使用 [Flatseal](https://flathub.org/apps/details/com.github.tchx84.Flatseal)
		- 在 `Filesystems` 分类中添加 `xdg-run/discord-ipc-0`
			- ![flatseal](https://raw.githubusercontent.com/EnderIce2/rpc-bridge/master/docs/assets/flatseal_permission.png)
	- ##### 通过终端
		- 针对单个应用
			- `flatpak override --filesystem=xdg-run/discord-ipc-0 <flatpak 应用名>`
		- 全局设置
			- `flatpak override --user --filesystem=xdg-run/discord-ipc-0`

##### MacOS

MacOS 的步骤几乎相同，但由于 `$TMPDIR` 的工作方式不同，你需要安装一个 **LaunchAgent**。

- 从[发布页面](https://github.com/EnderIce2/rpc-bridge/releases)下载最新版本
- 解压后，将 `launchd.sh` 脚本设为可执行：`chmod +x launchd.sh`
- 运行 `./launchd.sh install` 来**安装** LaunchAgent，运行 `./launchd.sh remove` 来**移除**。

该脚本会为你的用户添加一个 LaunchAgent，将 `$TMPDIR` 目录符号链接到 `/tmp/rpc-bridge/tmpdir`。

*注意：你至少需要手动在 Wine 中启动一次 `bridge.exe`，以便它能注册并在下次自动启动。*

关于如何安装 LaunchAgent 的更多细节，请参见[文档](https://enderice2.github.io/rpc-bridge/)。

## 从源码编译

- 安装 `wine`、`gcc-mingw-w64` 和 `make` 软件包。
- 在包含此文件的目录打开终端，运行 `make`。
- 编译后的可执行文件位于 `build/bridge.exe`。

## 致谢

本项目灵感来源于 [wine-discord-ipc-bridge](https://github.com/0e4ef622/wine-discord-ipc-bridge)。

---



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---