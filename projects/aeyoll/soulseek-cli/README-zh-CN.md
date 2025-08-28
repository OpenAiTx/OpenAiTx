# Soulseek CLI

[![Build Status](https://travis-ci.org/aeyoll/soulseek-cli.svg?branch=develop)](https://travis-ci.org/aeyoll/soulseek-cli)

一个 Soulseek 命令行客户端。

需求
---

NodeJS >= 20

安装
---

```sh
npm install -g soulseek-cli
```
### 在 Linux 上

soulseek-cli 的一个依赖项（[node-keytar](https://github.com/atom/node-keytar)）使用 libsecret，因此您需要在运行 `npm install` 之前安装它。

根据您的发行版，您需要运行以下命令：

- Debian/Ubuntu：`sudo apt-get install libsecret-1-dev`
- 基于 Red Hat：`sudo yum install libsecret-devel`
- Arch Linux：`sudo pacman -S libsecret`

### 在无头 Linux 上

在 Linux 上，[node-keytar](https://github.com/atom/node-keytar) 使用 Linux SecretService API。可以在没有 X11 服务器的 Linux 系统上使用 SecretService 后端（只需要 D-Bus）。在这种情况下，您可以执行以下操作（示例基于 Debian 环境）：

#### 安装依赖项


```sh
apt install gnome-keyring --no-install-recommends # Install the GNOME Keyring daemon. "no-install-recommends" prevents X11 install
```

#### 用法

```sh
dbus-run-session -- $SHELL # Start a D-Bus session
echo 'root' | /usr/bin/gnome-keyring-daemon -r -d --unlock # Unlock GNOME Keyring
soulseek ... # Use soulseek-cli normally
```

命令
---

### 登录

在能够搜索之前，您需要先登录。

用法：
```
soulseek login
```

系统将提示您输入Soulseek的登录名和密码。凭据会存储并加密在您的系统钥匙串中。

或者，您也可以通过设置环境变量来登录：

```sh
export SOULSEEK_ACCOUNT=youraccount
export SOULSEEK_PASSWORD=yourpassword
soulseek download "..."
```

### 下载

使用所需查询下载。

用法：
```
soulseek download|d [options] [query...]
```

:warning: 该命令在 0.1.0 版本之前被称为 `search`。

选项：

| 选项                       | 说明                                                                          |
| ------------------------- | ----------------------------------------------------------------------------- |
| -d --destination <folder> | 下载的目标文件夹                                                               |
| -q --quality <quality>    | 仅显示指定质量的 mp3                                                          |
| -m --mode <mode>          | 过滤你想要的文件类型（可选："mp3", "flac"，默认："mp3"）                     |
| -h --help                 | 显示命令帮助                                                                  |

示例：

```sh
soulseek download "Your query" # Download in the current folder
soulseek download "Your query" --destination=/path/to/directory # Download in a defined folder (relative or absolute)
soulseek download "Your query" --quality=320 # Filter by quality
soulseek download "Your query" --mode=flac # Filter by file type
```

### 查询

使用必需的查询进行搜索，但不下载任何内容。如果找到结果，返回码将为0。否则，
返回码将为1（适用于脚本编写）

用法：

```
soulseek query|q [options] [query...]
```

选项：

| 选项                  | 描述                                                                       |
| --------------------- | -------------------------------------------------------------------------- |
| -q --quality <quality> | 仅显示具有指定质量的 mp3                                                  |
| -m --mode <mode>      | 过滤您想要的文件类型（可用："mp3", "flac"，默认："mp3"）                 |
| -h --help             | 显示命令帮助                                                              |



贡献
---

请参阅 [CONTRIBUTING.md](https://raw.githubusercontent.com/aeyoll/soulseek-cli/main/CONTRIBUTING.md)。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---