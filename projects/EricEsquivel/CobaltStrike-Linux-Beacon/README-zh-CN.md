# Cobalt Strike Linux Beacon

一个用C语言编写的概念验证自定义Linux Beacon，使用HTTP/S协议与Cobalt Strike团队服务器通信。

该项目的目标不是成为一个功能齐全的植入程序，也不限于仅支持Linux。目的是展示可以为任何平台制作Cobalt Strike的自定义植入程序。唯一的要求是正确地与团队服务器通信。

通过自定义植入程序，您可以定义自定义行为，添加新功能，支持不同的平台和文件类型，在编译时应用混淆等。可能性是无限的。

希望有一天Cobalt Strike能通过增加更多文档和便捷功能，官方支持开发自定义Beacon。


## 功能
- 支持HTTP/S监听器（默认C2配置文件）
- 包含一些内置命令：`sleep`，`cd`，`pwd`，`shell`，`ls`，`exit`，`upload`，`download`
- 使用TrustedSec的ELFLoader执行Linux BOF。支持TrustedSec和Outflank BOF
- SOCKS代理

## 演示
使用Aggressor脚本生成有效载荷
![Linux Beacon Payload Generation](https://raw.githubusercontent.com/EricEsquivel/CobaltStrike-Linux-Beacon/main/demo/generate_payloads.gif)

在Linux Beacon中运行命令和BOF
![Linux Beacon Commands Demo](https://raw.githubusercontent.com/EricEsquivel/CobaltStrike-Linux-Beacon/main/demo/commands.gif)

## 安装
您可以查看[SETUP](https://raw.githubusercontent.com/EricEsquivel/CobaltStrike-Linux-Beacon/main/SETUP.md)文件中的安装步骤。

## 特别感谢
感谢[Kyle Avery](https://x.com/kyleavery)协助集成BOF执行并测试该植入程序。

## 未来目标
* 添加对自定义C2配置文件的支持
* 添加TCP监听器和连接功能
* 继续修复漏洞

## 资源
- Cobalt Strike (惊讶！)
- [TrustedSec的ELFLoader和BOFs](https://github.com/trustedsec/ELFLoader)
- [Outflank的BOFs](https://github.com/outflanknl/nix_bof_template)
- [PaloAltoNetworks Unit42](https://unit42.paloaltonetworks.com/cobalt-strike-metadata-encryption-decryption/)
- [SANS ISC](https://isc.sans.edu/diary/27968)
- [cs-decrypt-metadata-py](https://blog.didierstevens.com/2021/10/22/new-tool-cs-decrypt-metadata-py/)
- [SentinelOne CobaltStrikeParser](https://github.com/Sentinel-One/CobaltStrikeParser)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-27

---