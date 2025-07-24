# CCU-Jack

CCU-Jack 提供了一种简单且安全的基于 **REST** 和 **MQTT** 的访问方式，用于访问 [Hausautomations-Systems](http://de.wikipedia.org/wiki/Hausautomation) HomeMatic 公司 [eQ-3](http://www.eq-3.de/) 中中枢 (CCU) 的数据点。它为此实现了 [Very Easy Automation Protocol](https://github.com/mdzio/veap)，许多编程语言都可以轻松使用该协议，以及在物联网中广泛应用的 [MQTT 协议](https://de.wikipedia.org/wiki/MQTT)。此外，使用上述协议也可以将第三方设备接入 CCU。

CCU-Jack 追求以下目标：

**CCU-Jack 应为其他应用程序提供对 CCU 数据点的简易访问。** 例如，访问带有 HM、HM-Wired 和 HM-IP 设备的 CCU 总共需要 9 个网络连接，有的作为回传通道，且使用不同的协议。此外，CCU 的网络接口未加密，因此不应在 CCU 的防火墙中开放。CCU-Jack 通过统一协议和加密连接标准化了对所有设备和系统变量的访问。

**此外，应尽可能简化第三方设备（例如 WLAN 插座）与 CCU 的连接及自动化。** 连接的第三方设备在 CCU 上表现为原生 HM 设备。它们可通过 CCU 的 Web UI 进行操作和监控。此外，它们可无限制地在 CCU 程序中使用。

**多个 CCU 及其他配备 MQTT 服务器的自动化设备可通过 CCU-Jack 互联并交换数值变化。** 为此，CCU-Jack 提供了一个 MQTT 桥接。CCU 也可以连接到云端的 MQTT 服务器。

在功能上，CCU-Jack 是 [XML-API 插件](https://github.com/jens-maus/XML-API) 的替代方案。XML-API 插件长期未维护，存在未修复的错误和安全漏洞。此外，CCU-Jack 可以替代 [hm2mqtt](https://github.com/owagner/hm2mqtt) 和 [Mosquitto](https://github.com/hobbyquaker/ccu-addon-mosquitto) 两个插件的组合。hm2mqtt 插件同样长期未维护。

关于第三方设备的接入，CCU-Jack 替代了许多复杂且繁琐的解决方案，同时提供更多功能。

# 用户手册

所有用户信息（例如安装、配置）均可在 [**用户手册**](https://github.com/mdzio/ccu-jack/wiki) 中找到。安装前请务必阅读！

# 下载

CCU-Jack 的官方发布版本位于右侧 [Releases](https://github.com/mdzio/ccu-jack/releases)。

对应最新开发状态的预发布版本可在 [Actions](https://github.com/mdzio/ccu-jack/actions) 中找到。选择一个 _Workflow_，然后在 _Artifacts_ 下可下载适用于所有平台的版本。这些版本包含新的功能或修复，但未经测试！

# CCU-Jack 相关项目

与 CCU-Jack 相关的其他项目有：
* [CCU-Jack to HomeAssistant](https://github.com/kaistraube/ccujack_homeassistant)（通过 CCU-Jack 将 HomeMatic CCU 接入 HomeAssistant）
* [node-red-contrib-ccu-jack](https://github.com/ptweety/node-red-contrib-ccu-jack)（通过 CCU-Jack 将 HomeMatic CCU 接入 Node-RED）
* [ngx-ccu-jack-client](https://github.com/pottio/ngx-ccu-jack-client)（将 CCU-Jack 集成到 Angular 应用）

# 开发

## 从源码构建

CCU-Jack 使用 [Go 语言](https://golang.org/) 编写。CCU-Jack 的所有发行版都可以非常简单且快速地在多种平台（包括 Windows、Linux、MacOS）上构建。只需在任意目录克隆 Git 仓库，或将源码复制到该目录。然后在该目录打开命令行，输入以下命令：
```
cd build
go run .
```
在主目录中将构建所有发行版。

对于开发，推荐使用开发环境 [Visual Studio Code](https://code.visualstudio.com/)。只需打开主目录。所需的扩展将自动提供安装。

## 参与

当然欢迎贡献者参与。无论是文档编写、测试、在 [HomeMatic 论坛](https://homematic-forum.de/forum/viewtopic.php?f=41&t=53553) 提供支持、错误修复还是新功能的实现。对于代码贡献需遵守许可证（GPL v3）。代码贡献应始终在新的分支上独立于 `master` 分支开发。

## 作者

* [Mathias Dz.](https://github.com/mdzio)
* [martgras](https://github.com/martgras)（Raspberry Pi 4，证书处理）
* [twendt](https://github.com/twendt)（CUxD 的 BIN-RPC）
* [Theta Gamma](https://github.com/ThetaGamma)（Docker 镜像）

## 许可证和免责声明

许可证和免责声明见文件 [LICENSE.txt](https://raw.githubusercontent.com/mdzio/ccu-jack/master/LICENSE.txt)。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---