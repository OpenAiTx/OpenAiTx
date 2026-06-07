# WG Commander 

也称为 "wg-cmd" — 用于管理 WireGuard 配置文件的终端用户界面（TUI）

<a href="https://github.com/andrianbdn/wg-cmd/releases/latest"><img src="https://img.shields.io/github/v/release/andrianbdn/wg-cmd" /></a>
<a href="./LICENSE"><img src="https://img.shields.io/github/license/andrianbdn/wg-cmd" /></a>
<a href="./go.mod"><img src="https://img.shields.io/github/go-mod/go-version/andrianbdn/wg-cmd" /></a>
[![Go Report Card](https://goreportcard.com/badge/github.com/andrianbdn/wg-cmd)](https://goreportcard.com/report/github.com/andrianbdn/wg-cmd)

![截图](https://user-images.githubusercontent.com/994900/218720566-e5b3ab22-d7fc-4df7-a777-ad9b6280ada8.png)

# 特性
- 无需浏览器或 HTTP 端口 - 可在终端中使用，也支持 SSH
- 配备了友好的安装向导
- 基于文本的用户界面，用于管理节点
- 在终端中查看二维码
- 复制配置到剪贴板（OSC 52）
- 自动配置 sysctl、systemd、NAT

## 当前限制
- 支持简单的客户端-服务器 WireGuard 设置
- 主要适用于 Linux（假设可用 iptables、systemd、sysctl）— 参见 [其他操作系统](#other-os-besides-linux) 部分
- 不能管理已有的 WireGuard 配置（但可以在同一主机上创建新的 WireGuard 接口）

# 安装 

确保已安装 WireGuard 和 iptables  
（Ubuntu / Debian 中运行 `apt install wireguard-tools`，Rocky/Alma 9 中运行 `dnf install wireguard-tools iptables`）。

使用 curl 下载请运行：
```shell
# for x86_64 
curl -SL https://github.com/andrianbdn/wg-cmd/releases/download/v0.1.7/wg-cmd-0.1.7-linux-amd64 -o /usr/local/bin/wg-cmd

# for arm64 
curl -SL https://github.com/andrianbdn/wg-cmd/releases/download/v0.1.7/wg-cmd-0.1.7-linux-arm64 -o /usr/local/bin/wg-cmd
```

设置适当的权限并运行工具： 
```
chmod 755 /usr/local/bin/wg-cmd
wg-cmd
```
如果你的 $PATH 中没有 `/usr/local/bin`，你需要使用完整路径运行 `/usr/local/bin/wg-cmd` 命令。

WG Commander 需要 root 权限以自动调整 sysctl，创建 systemd 单元，并写入 /etc/wireguard。

# 使用说明

首次运行时，WG Commander 会显示设置向导，允许你交互式配置新的 WireGuard 接口。

后续运行（如果向导成功完成）将直接显示管理 TUI。

关于二维码的说明：某些设备（安卓？）可能需要更高质量的二维码。WG Commander 会在你调整终端窗口分辨率变大（字体变小，窗口变大）时自动提高二维码质量。

## 高级用法

如果你手动更改了 /etc/wireguard 的权限并手动配置 sysctl/systemd，可以以非 root 用户身份运行 WG Commander。

WG Commander 会将其 UI 配置保存在 `~/.config/wg-cmd/wg-cmd.toml` 中。

最重要的选项有：



```toml
WireguardDir = "/etc/wireguard"
# directory for WireGuard configuration files 

DatabaseDir = "/etc/wireguard"
# directory for WG Commander database files (wgc-<interface-name>)
```
您可以更改这些选项以指向您有写权限的目录。

### 特殊选项 

运行 `wg-cmd new` 启动新接口配置向导。

运行 `wg-cmd <wg-interface>` 切换到特定接口（必须先用 wg-cmd 创建）。

运行 `wg-cmd <wg-interface> make` 生成 Wireguard 配置且不显示 UI。

### 配置 

WG Commander 使用目录作为其“数据库”。  
它将接口配置存储在 /etc/wireguard/wgc-<interface-name> 目录中。

配置使用 [TOML](https://toml.io) 文件格式存储。

大多数配置键与 WireGuard 的类似。

#### 服务器配置 (0001-server.toml)  
此配置文件中的某些键实际上将用于生成  
客户端配置文件。

`ClientRoute` - 客户端配置的 AllowedIPs

`ClientDNS` - 所有客户端的 DNS 配置值

`ClientServerEndpoint` - 客户端配置的端点

`ClientPersistentKeepalive` - 客户端配置的 PersistentKeepalive

`MTU` - 服务器和客户端的 MTU（0 — 由 WireGuard 选择）

#### 客户端配置 (nnnn-%client%.toml)

`ClientRoute` - 完全覆盖服务器配置中的 `ClientRoute`

`AddServerRoute` - 在服务器端为客户端的 AllowedIPs 添加额外网络（当您想通过服务器将一个客户端的流量路由到另一个客户端的网络时非常有用）


`MTU` - 为此客户端覆盖服务器的MTU值。设置为-1以从此WireGuard客户端配置中省略MTU。

`DNS` - 覆盖服务器的`ClientDNS`设置，适用于所有客户端。指定以逗号分隔的IP列表。  
设置为`no`或`none`以从此WireGuard客户端配置中省略DNS。

客户端配置文件包含`PrivateKey`字段。  
如果您觉得不可接受，可以在导出配置（或二维码）到客户端后将其从文件中删除。

### 除Linux外的其他操作系统

WG Commander设计用于Linux，因为它使用procfs、systemd、iptables、sysctl。  
不过，它是用纯Go编写的，因此应能在任何Go支持的操作系统上运行。

- 您需要自行编译二进制文件。  
- 设置环境变量`WG_CMD_NO_DEPS`为1以禁用启动时的任何Linux特定检查。  
- 编辑0001-server.toml，在PostUp4/PostUp6/PostDown4/PostDown6字段中设置您的操作系统命令。  
- 您需要重新加载WireGuard配置：更改时手动操作，  
或监视/etc/wireguard/wg*.conf文件的更改并自动重新加载WireGuard。

欢迎提交PR以添加对其他操作系统的支持。

### 在Docker中运行

虽然可以，但不建议在Docker中运行WG Commander。

设置向导将无法正常工作，因为它需要创建systemd单元并修改sysctl。

### 卸载

要卸载WG Commander，只需从/usr/local/bin/wg-cmd删除二进制文件。  
您还可以删除目录/etc/wireguard/wgc-*和~/.config/wg-cmd

如果您创建了systemd单元，则需要手动删除它们。

下面是如何删除WG Commander管理的接口wg7的示例  
（请更改为您需要删除的接口）：




```sh
systemctl stop wgc-wg7.{path,service}
systemctl disable wgc-wg7.{path,service}
rm /etc/systemd/system/wgc-wg7.{path,service}
systemctl stop wg-quick@wg7.service
systemctl disable wg-quick@wg7.service
rm /etc/wireguard/wg7.conf
rm -Rf /etc/wireguard/wgc-wg7
```


# 测试环境  
WG Commander 应该可以在任何基于 systemd 的 Linux 发行版上良好运行，前提是系统中包含 WireGuard、iptables、sysctl 和 procfs。  

测试过的系统包括：  
- Ubuntu 24.04（v0.1.7 版本测试于 2026 年 4 月 9 日）  
- Ubuntu 20.04  
- Ubuntu 22.04  
- Rocky Linux 9  
- Debian 11  
- Debian 12  

# 贡献  

欢迎贡献代码。请参阅 [CONTRIBUTING.md](https://raw.githubusercontent.com/AndrianBdn/wg-cmd/main/CONTRIBUTING.md) 获取指导，包括我们的 AI 公开政策。  

# 说明  
WG Commander 并无商业目的。  
该项目采用  
[MIT 许可证](https://github.com/andrianbdn/wg-cmd/blob/master/LICENSE) 许可。  

本项目与 WireGuard® 的创建者无关。  
WG Commander 项目未获得 WireGuard® 或 WireGuard® 社区的批准、赞助或关联。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-07

---