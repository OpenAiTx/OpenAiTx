# SyncClipboard
[![build](https://github.com/Jeric-X/SyncClipboard/actions/workflows/build-entry.yml/badge.svg?branch=master)](https://github.com/Jeric-X/SyncClipboard/actions?query=branch%3Amaster)

Chinese | [English](https://raw.githubusercontent.com/Jeric-X/SyncClipboard/master/docs/README_EN.md)  

<details>
<summary>Contents</summary>

- [SyncClipboard](#syncclipboard)
  - [Features](#功能)
  - [Server](#服务器)
    - [Standalone Server](#独立服务器)
      - [Server Configuration](#服务器配置)
      - [Docker](#docker)
      - [Arch Linux](#arch-linux)
    - [Client Built-in Server](#客户端内置服务器)
    - [WebDAV Server](#webdav服务器)
  - [Client](#客户端)
    - [Windows](#windows)
      - [Portable Version](#免安装板)
      - [Troubleshooting](#故常排除)
    - [macOS](#macos)
      - [Manual Installation](#手动安装)
      - [Troubleshooting](#故常排除-1)
    - [Linux](#linux)
      - [Manual Installation](#手动安装-1)
      - [Arch Linux](#arch-linux-1)
      - [Troubleshooting](#故常排除-2)
    - [Desktop Client Command Line Arguments](#桌面客户端命令行参数)
      - [--shutdown-previous](#--shutdown-previous)
      - [--command-{command-name}](#--command-command-name)
    - [iOS](#ios)
      - [Using Shortcuts](#使用快捷指令)
    - [Android](#android)
      - [Using HTTP Request Shortcuts](#使用http-request-shortcuts)
      - [Using Autox.js](#使用autoxjs)
      - [Using SmsForwarder](#使用smsforwarder)
      - [Using Tasker](#使用tasker)
    - [Client Configuration Description](#客户端配置说明)
  - [API](#api)
    - [Get/Upload Clipboard (Text)](#获取上传剪贴板文字)
    - [Get/Upload Clipboard (Image/File)](#获取上传剪贴板图片文件)
    - [SyncClipboard.json](#syncclipboardjson)
  - [Project Dependencies](#项目依赖)

</details>

## Features

- Clipboard synchronization, supporting text, images, and files. Server/client architecture, can use built-in server on client, independently deployed server, or WebDAV-supported cloud drives as server  
- Optimized clipboard for image types, features include:
  - When copying images from any location, you can directly paste image files into the file system, and vice versa
  - After copying images from a browser, the original image is downloaded in the background locally, solving the issue of not being able to copy dynamic images from browsers (most websites require authentication, limited applicability, supports bilibili dynamic images)
  - When copying newer format image files (webp/heic etc.) from the file system, stores gif or jpg format in the clipboard for direct pasting into image-supporting text boxes

## Server
### Standalone Server
[SyncClipboard.Server](https://github.com/Jeric-X/SyncClipboard/releases/) supports cross-platform operation, depends on [ASP.NET Core 8.0](https://dotnet.microsoft.com/zh-cn/download/dotnet/8.0), after installing `ASP.NET Core Runtime`, run with the following command
```
dotnet /path/to/SyncClipboard.Server.dll --contentRoot ./
```
The working directory is the same as the directory where the dll is located and requires write permission. If you need to change the working directory, copy a copy of `appsettings.json` to the new working directory and modify the path after `--contentRoot`  

#### Server Configuration
The server is configured through the `appsettings.json` file, in the following form:
```jsonc
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "Kestrel": {
    "Endpoints": {
      "http": {
        "Url": "http://*:5033"
      },
      //"https": {
      //  "Url": "https://*:5033"
      //}
    },
    //"Certificates": {
    //  "Default": {
    //    "Path": "/path/to/pem",
    //    "KeyPath": "/path/to/pem_key"
    //  }
    //}
  },
  "AppSettings": {
    "UserName": "your_username",
    "Password": "your_password"
  }
}
```
To enable HTTPS, uncomment the `https` and `Certificates` sections and set the HTTPS certificate path. Finally, comment out or delete the `http` section to disable insecure connections. To enable both HTTP and HTTPS simultaneously, set different port numbers for their `Url` values.  
The configuration methods for different types of certificates can be found in the [Microsoft official documentation](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/servers/kestrel/endpoints?view=aspnetcore-8.0#configure-https-in-appsettingsjson).

Username and password support environment variable configuration. When both `SYNCCLIPBOARD_USERNAME` and `SYNCCLIPBOARD_PASSWORD` environment variables are not empty, these two environment variables will be used as the username and password with priority.

The environment variable `ASPNETCORE_hostBuilder__reloadConfigOnChange` is used to configure whether to automatically detect changes in appsettings.json and reload the configuration. The default value is `false`. Changing it to any value other than `false` will enable this feature.

> [!WARNING]  
> HTTP transmits data in plain text. For servers deployed on public networks, please enable HTTPS or use a reverse proxy tool to configure HTTPS. If you cannot obtain a certificate from a certificate authority, it is recommended to use the open source tool [mkcert](https://github.com/FiloSottile/mkcert) or other methods to generate a self-signed certificate.

#### Docker

```shell
# docker
docker run -d \
  --name=syncclipboard-server \
  -p 5033:5033 \
  -e SYNCCLIPBOARD_USERNAME=your_username \
  -e SYNCCLIPBOARD_PASSWORD=your_password \
  --restart unless-stopped \
  jericx/syncclipboard-server:latest

# docker compose
curl -sL https://github.com/Jeric-X/SyncClipboard/raw/master/src/SyncClipboard.Server/docker-compose.yml
docker compose up -d
```
If you need to configure HTTPS, please map the `appsettings.json` and certificate files yourself. The container path for `appsettings.json` is `/app/appsettings.json`

#### Arch Linux

You can install it directly from [AUR](https://aur.archlinux.org/packages/syncclipboard-server) (maintained by [@devome](https://github.com/devome)):

```shell
paru -Sy syncclipboard-server
```

The configuration file path is `/etc/syncclipboard/appsettings.json`. After modifying the configuration, start it using the `systemctl` command:

```shell
sudo systemctl enable --now syncclipboard.service
```

### Built-in Server in Client

The desktop client (Windows/Linux/macOS) has a built-in server function that can be configured using a visual interface

### WebDAV Server
You can use cloud drives that support the WebDAV protocol as servers  
Tested servers:   

- [x] [Nextcloud](https://nextcloud.com/) 
- [x] [AList](https://alist.nn.ci/)
- [x] [InfiniCLOUD](https://infini-cloud.net/en/)
- [x] [aliyundrive-webdav](https://github.com/messense/aliyundrive-webdav)

## Client

The desktop client (Windows/Linux/macOS) will automatically sync the clipboard when running in the background
<details>
<summary>Expand/Collapse Screenshot</summary>

![](https://raw.githubusercontent.com/Jeric-X/SyncClipboard/master/docs/image/WinUI.png)

</details>

### Windows
#### Portable Version

Download the zip file starting with `SyncClipboard_win_` from the [Release](https://github.com/Jeric-X/SyncClipboard/releases/latest) page, unzip and run `SyncClipboard.exe`

#### Troubleshooting
- The minimum supported system version is Windows 10 2004
- When running SyncClipboard on Windows 10, many interface icons appear incorrectly; please download and install Microsoft's [Segoe Fluent Icons](https://aka.ms/SegoeFluentIcons) icon font

### macOS
#### Manual Installation
Download the installer starting with `SyncClipboard_macos_` from the [Release](https://github.com/Jeric-X/SyncClipboard/releases/latest) page, double-click it, and drag the SyncClipboard icon to the Applications folder

#### Troubleshooting
- If the system prompts `SyncClipboard cannot be opened because the developer cannot be verified`:  
Go to macOS `Settings` -> `Privacy & Security`, then click `Open Anyway`
- System prompt "SyncClipboard is damaged and cannot be opened": execute `sudo xattr -d com.apple.quarantine /Applications/SyncClipboard.app` in the terminal
- Shortcut keys depend on Accessibility permissions, the software will prompt for authorization when needed

### Linux
#### Manual Installation
Download the installation package starting with `SyncClipboard_linux_` from the [Release](https://github.com/Jeric-X/SyncClipboard/releases/latest) page

#### Arch Linux

Arch Linux users can install directly from the [AUR](https://aur.archlinux.org/packages/syncclipboard-desktop) (maintained by [@devome](https://github.com/devome)):

```shell
paru -Sy syncclipboard-desktop
```

After installation, start it from the menu. If starting with the command `syncclipboard-desktop` in the command line results in an error, please set the environment variable `LANG` to `en_US.UTF-8`, and start with `LANG=en_US.UTF-8 syncclipboard-desktop`.

#### Troubleshooting
- Clipboard sync is not timely, cannot sync, or uploads garbled text: It is recommended to install `xclip` (X11) or `wl-clipboard` (Wayland) on your system. SyncClipboard uses these tools to assist in obtaining the clipboard for enhanced stability. Use the command `xclip -version` or `wl-paste -version` to confirm installation.
- When upgrading using `deb` or `rpm` packages, if the upgrade fails, please uninstall the old version before installing the new one.
- When using the `AppImage` package, please ensure the AppImage file has executable permissions.
- Hotkeys may not work under Wayland.
- Language is not automatically detected and defaults to English; you can change it in SyncClipboard’s settings after startup.

> [!NOTE]  
> To completely remove SyncClipboard, please manually delete the configuration files and temporary file directories:  
> `%AppData%\SyncClipboard\` (Windows), `~/Library/Application Support/SyncClipboard/` (macOS), `~/.config/SyncClipboard/` (Linux)

### Desktop Client Command Line Parameters

#### --shutdown-previous
Shuts down the already running SyncClipboard and runs a new instance.

#### --command-{command-name}
Runs a specified command, where `{command-name}` is the command name. After setting a hotkey, the corresponding command name can be viewed in the configuration file. Even if the hotkey configuration is cleared, the command line parameter remains effective.  
If a SyncClipboard instance is already running, a new instance will not start; instead, the running SyncClipboard will execute the command. If no instance is running, the command will execute immediately after startup completes.  
Supports multiple `--command-{command-name}` parameters for simultaneous execution of multiple commands.

> [!NOTE]  
> When using command line parameters on macOS, please use the full path to the executable: `/Applications/SyncClipboard.app/Contents/MacOS/SyncClipboard.Desktop.MacOS`

### IOS 
#### Using [Shortcuts](https://apps.apple.com/cn/app/%E5%BF%AB%E6%8D%B7%E6%8C%87%E4%BB%A4/id1462947752)  

- Manual sync: import this [shortcut](https://www.icloud.com/shortcuts/d1b9e49556e04c2ca290590294afbd99) to manually trigger upload or download.
- Automatic sync: import this [shortcut](https://www.icloud.com/shortcuts/1ced32f011bc4d3498dca9960dc2c0d5). After running, the device will automatically sync clipboard content in the background. This shortcut runs indefinitely and must be manually stopped. You can also manually modify whether to send system notifications after syncing and set the query interval in seconds.
- Automatic SMS verification code upload: refer to the video tutorial in this post https://github.com/Jeric-X/SyncClipboard/discussions/60

### Android
#### Using [HTTP Request Shortcuts](https://github.com/Waboodoo/HTTP-Shortcuts)
Import this [configuration file](/script/shortcuts.zip), modify the `UserName`, `UserToken`, and `url` variables. The `url` should not end with a slash `/`. `HTTP Request Shortcuts` supports usage from dropdown menus, desktop widgets, desktop icons, and the share menu.

<details>
<summary>Illustration of modifying configuration after importing the configuration file</summary>

![](https://raw.githubusercontent.com/Jeric-X/SyncClipboard/master/docs/image/android1.jpg)
![](https://raw.githubusercontent.com/Jeric-X/SyncClipboard/master/docs/image/android2.jpg)
![](https://raw.githubusercontent.com/Jeric-X/SyncClipboard/master/docs/image/android3.jpg)

</details>

#### Using [Autox.js](https://github.com/kkevsekk1/AutoX)

- Automatic synchronization, use this [js file](/script/SyncAutoxJs.js). Due to Android system restrictions, on Android 10 and above, apps cannot read the clipboard in the background, but you can use tools based on Root permissions (Magisk/Xposed) to remove the app’s background clipboard reading restrictions, such as [Riru-ClipboardWhitelist](https://github.com/Kr328/Riru-ClipboardWhitelist), [Clipboard Whitelist](https://modules.lsposed.org/module/io.github.tehcneko.clipboardwhitelist). Since on Android 13 and above, apps must be manually authorized by the user to access system logs (clipboard), you can also use Xposed to automatically grant apps permission to access system logs, such as [DisableLogRequest](https://github.com/QueallyTech/DisableLogRequest).
- Automatic upload of verification codes, use this [js file](/script/UploadVerificationCode.js), this script runs in the background and reads all notification messages, uploading the verification code to the server when it detects verification code information.

After importing the js file and modifying the user configuration at the top of each file, manually click run or set a trigger for each js file, for example: trigger at boot.

#### Using [SmsForwarder](https://github.com/pppscn/SmsForwarder)

- Automatic upload of verification codes, https://github.com/Jeric-X/SyncClipboard/discussions/109

#### Using [Tasker](https://tasker.joaoapps.com/)

- https://github.com/forrestgao/taskerforSyncClipboard, author: [forrestgao](https://github.com/forrestgao)

Tasker is a very powerful automation tool on the Android system. You can create your own profiles based on SyncClipboard’s API. If you think your profile is very general and want to share it, feel free to contact me to place it here.


### Client Configuration Instructions

All platforms rely on three necessary configurations (the spelling of the configurations may vary but the meaning is the same).
- user
- password
- url, format is http(s)://ip(or domain):port. When using a WebDav server, the url needs to specify an existing folder as the working directory, for example `https://domain.com/dav/folder1/working%20folder`. Special characters need to be replaced with url escape codes, and do not use this folder to store other files. When not using desktop clients (Windows/Linux/macOS), you need to create a `file` folder inside the working directory to sync files; the desktop client will automatically create the `file` folder when setting the server. Try not to end the url with a slash `/` as this may cause problems in some clients.

## API

The API is based on WebDAV. In a standalone server environment, set the environment variable ASPNETCORE_ENVIRONMENT to Development before running the server, or open the server in the desktop client and enable diagnostic mode in the settings.  
Access `http://ip:port/swagger/index.html` to open the API page. Below are some key APIs.

### Get/Upload Clipboard (Text)
```
GET /SyncClipboard.json
PUT /SyncClipboard.json
```

### Get/Upload Clipboard (Image/File)
```
GET  /SyncClipboard.json
HEAD /file/filename         // optional
GET  /file/filename

PUT /file/filename
PUT /SyncClipboard.json
```

### SyncClipboard.json
```
{
    "Type" : "Text"
    "Clipboard" : "Content",
    "File":""
}

{
    "Type": "Image", // or "File", "Group"
    "Clipboard": "hash, optional",
    "File": "filename"
}
```

## 项目依赖
[NativeNotification](https://github.com/Jeric-X/NativeNotification)  
[Magick.NET](https://github.com/dlemstra/Magick.NET)  
[.NET Community Toolkit](https://github.com/CommunityToolkit/dotnet)  
[H.NotifyIcon](https://github.com/HavenDV/H.NotifyIcon)  
[WinUIEx](https://github.com/dotMorten/WinUIEx)  
[moq](https://github.com/moq/moq)  
[Avalonia](https://avaloniaui.net/)  
[FluentAvalonia.BreadcrumbBar](https://github.com/indigo-san/FluentAvalonia.BreadcrumbBar)  
[FluentAvalonia](https://github.com/amwx/FluentAvalonia)  
[Vanara](https://github.com/dahall/Vanara)  
[Tmds.DBus](https://github.com/tmds/Tmds.DBus)  
[SharpHook](https://github.com/TolikPylypchuk/SharpHook)  
[DotNetZip.Semverd](https://github.com/haf/DotNetZip.Semverd)  
[Quartz.NET](https://github.com/quartznet/quartznet)  
[MiSans](https://hyperos.mi.com/font)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-23

---