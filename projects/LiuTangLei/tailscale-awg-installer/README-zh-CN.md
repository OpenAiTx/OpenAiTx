# Tailscale 与 Amnezia-WG 2.0 (v1.88.2+)

[![GitHub Release](https://img.shields.io/github/v/release/LiuTangLei/tailscale)](https://github.com/LiuTangLei/tailscale/releases/latest)
[![Platform Support](https://img.shields.io/badge/platform-Linux%20|%20macOS%20|%20Windows%20|%20OpenWrt%20|%20Android-blue)](https://github.com/LiuTangLei/tailscale/releases/latest)
[![License](https://img.shields.io/badge/license-BSD--3--Clause-green)](LICENSE)

增强型 Tailscale 客户端，集成 Amnezia-WG 2.0 混淆：垃圾流量、协议签名和握手/头信息伪装，以抵御 DPI 和封锁。在启用 AWG 设置前，其行为与标准 Tailscale 相同。

语言： [English](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/README.md) | [中文](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/doc/README-zh.md) | [فارسی](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/doc/README-fa.md) | [Русский](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/doc/README-ru.md)

有关 AWG v1.5 文档，请参阅 [doc/README-awg-v1.5.md](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/doc/README-awg-v1.5.md)。

## 安装

| 平台 | 命令 / 操作 |
| --- | --- |
| Linux | `curl -fsSL https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-linux.sh \| bash` |
| macOS* | `curl -fsSL https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-macos.sh \| bash` |
| Windows (管理员 PowerShell) | `iwr -useb https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-windows.ps1 \| iex` |
| OpenWrt | 参见 [OpenWrt 安装](#openwrt-installation) |
| Android | 从 [releases](https://github.com/LiuTangLei/tailscale-android/releases) 下载 APK |

- macOS：安装程序仅使用命令行的 `tailscaled`。如果检测到官方 Tailscale.app，会提示你移除以避免冲突。
- Android 目前仅支持 AWG 配置同步。请使用应用内的同步按钮。

![Android AWG 同步示例](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/doc/sync1.jpg)

## Docker Compose

仓库包含用于运行带 AWG 支持的 `tailscaled` 的 `docker-compose.yml` 文件。

- 状态存储在 compose 文件旁的 `./tailscale-state` 中，因此节点状态和 AWG 设置能在容器重启及主机重启后保留。
- 如果你是从旧的绑定挂载 `/var/lib/tailscale:/var/lib/tailscale` 升级，请先复制现有状态：

```bash
docker compose down
cp -a /var/lib/tailscale ./tailscale-state
# update docker-compose.yml
docker compose up -d
```
基本流程：

1. 启动服务：`docker compose up -d`
2. 在容器内认证：`docker compose exec tailscaled tailscale up`
3. 以相同方式运行 AWG 命令，例如：`docker compose exec tailscaled tailscale awg sync`

如果使用 Headscale，向 `tailscale up` 添加 `--login-server https://your-headscale-domain`。

可选的主机别名：


```bash
alias tailscale='docker exec -it tailscaled tailscale'
```
那个别名仅适用于当前的 shell。要在重启或新的终端会话后保留它，请将其添加到 `~/.bashrc` 或 `~/.zshrc` 并重新加载你的 shell。

## OpenWrt 安装

默认命令：


```bash
wget -O /usr/bin/install.sh https://raw.githubusercontent.com/LiuTangLei/openwrt-tailscale-awg/main/install_en.sh && chmod +x /usr/bin/install.sh && /usr/bin/install.sh
```

适用于受限 GitHub 访问区域的镜像命令：

```bash
wget -O /usr/bin/install.sh https://ghfast.top/https://raw.githubusercontent.com/LiuTangLei/openwrt-tailscale-awg/main/install.sh && chmod +x /usr/bin/install.sh && /usr/bin/install.sh
```

此脚本源自 [GuNanOvO/openwrt-tailscale](https://github.com/GuNanOvO/openwrt-tailscale)。

## 镜像

如果 GitHub 访问缓慢或被屏蔽，您可以自建一个前缀镜像，例如 `https://your-mirror-site.com`：

```bash
# Linux
curl -fsSL https://your-mirror-site.com/https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-linux.sh | bash -s -- --mirror https://your-mirror-site.com

# macOS
curl -fsSL https://your-mirror-site.com/https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-macos.sh | bash -s -- --mirror https://your-mirror-site.com
```

```powershell
# Windows
$scriptContent = (iwr -useb https://your-mirror-site.com/https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-windows.ps1).Content; $scriptBlock = [scriptblock]::Create($scriptContent); & $scriptBlock -MirrorPrefix 'https://your-mirror-site.com/'
```
如果 PowerShell 阻止执行，请使用 `Set-ExecutionPolicy RemoteSigned` 或 `Bypass -Scope Process`。

## 快速开始

提示：`tailscale amnezia-wg` 与 `tailscale awg` 是相同的。

1. 登录：


```bash
# Official control server
tailscale up

# Headscale
tailscale up --login-server https://your-headscale-domain
```

2. 配置AWG：

```bash
tailscale awg set
```

在自动生成提示符处按 Enter 键，生成除 `i1`-`i5` 之外的所有推荐值。

3. 在其他设备上，从已配置的节点同步相同的 AWG 配置：

- 桌面端：在另一设备上运行 `tailscale awg sync`
- 安卓端：在另一设备的应用中点击同步

4. 需要时进行验证或重置：

```bash
tailscale awg get
tailscale awg reset
```

## 配置预设

| 目标 | 示例 | 兼容性 |
| --- | --- | --- |
| 基础垃圾流量 | `tailscale awg set '{"jc":4,"jmin":64,"jmax":256}'` | 适用于标准 Tailscale 节点 |
| 垃圾流量 + 签名 | `tailscale awg set '{"jc":2,"jmin":64,"jmax":128,"i1":"<b 0x40><r 12>"}'` | 适用于标准 Tailscale 节点 |
| 握手伪装 | `tailscale awg set '{"s1":10,"s2":15,"s3":8,"s4":0}'` | 所有 AWG 节点必须使用相同的 `s1`-`s4` |
| 全面伪装 | `tailscale awg set '{"s1":10,"s2":15,"s3":8,"s4":0,"h1":{"min":100000,"max":200000},"h2":{"min":300000,"max":350000},"h3":{"min":400000,"max":450000},"h4":{"min":500000,"max":550000}}'` | 所有 AWG 节点必须使用相同的 `s1`-`s4` 和 `h1`-`h4` |
| 全面伪装 + 签名 | `tailscale awg set '{"s1":10,"s2":15,"s3":8,"s4":0,"h1":{"min":100000,"max":200000},"h2":{"min":300000,"max":350000},"h3":{"min":400000,"max":450000},"h4":{"min":500000,"max":550000},"i1":"<b 0xc0><r 32><c><t>"}'` | `i1`-`i5` 可因节点而异；`s1`-`s4` 和 `h1`-`h4` 必须匹配 |

## 参数参考

- `jc` 与 `jmin` 和 `jmax`：垃圾包数量及大小范围。
- `i1`-`i5`：可选的 CPS（自定义协议签名）链，用于自定义协议模拟包。
- `s1`-`s4`：握手填充或前缀字段；所有 AWG 节点必须匹配。
- `h1`-`h4`：头字段范围，格式为 `{"min": 低值, "max": 高值}`；必须全部设置或全部不设置。范围不能重叠，且所有 AWG 节点必须匹配。

非常大的垃圾包数量或较长的签名链会增加延迟和带宽使用。

## 平台支持

| 平台 | 架构 | 状态 |
| --- | --- | --- |
| Linux | x86_64，ARM64 | ✅ 完整支持 |
| macOS | Intel，Apple Silicon | ✅ 完整支持 |
| Windows | x86_64，ARM64 | ✅ 安装程序 |
| OpenWrt | 多种 | ✅ 脚本 |
| Android | ARM64，ARM | ✅ APK（仅同步 AWG） |

## 高级：CPS 协议签名

CPS 即自定义协议签名。它允许你组装自定义混淆包，可以模仿任意协议头，不限于某一特定协议。

CPS 格式：

```text
i{n} = <tag1><tag2>...<tagN>
```
标签：

- `<b 0xHEX>`：静态字节  
- `<r N>`：安全随机字节  
- `<c>`：计数器  
- `<t>`：时间戳  

示例：


```text
i1 = <b 0xf6ab3267fa><c><b 0xf6ab><t><r 10>
```
如果未设置 `i1`，则跳过 `i2`-`i5`。

## 故障排除

验证安装：


```bash
tailscale version
tailscale awg get
```
如果连接中断，重置为标准 WireGuard 并从简单的预设开始：


```bash
tailscale awg reset
tailscale awg set '{"jc":2,"jmin":64,"jmax":128}'
sudo journalctl -u tailscaled -f
```
在 Windows PowerShell 上，建议使用交互式设置以避免 JSON 转义问题：


```powershell
tailscale awg set
```

## 链接与支持

- 版本发布：<https://github.com/LiuTangLei/tailscale/releases>
- 安卓APK：<https://github.com/LiuTangLei/tailscale-android/releases>
- 安装程序问题：<https://github.com/LiuTangLei/tailscale-awg-installer/issues>
- Amnezia-WG 文档：<https://docs.amnezia.org/documentation/instructions/new-amneziawg-selfhosted/#how-to-extract-a-protocol-signature-for-amneziawg-manually>

## 许可证

BSD 3-Clause 许可证，与上游 Tailscale 相同。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-29

---