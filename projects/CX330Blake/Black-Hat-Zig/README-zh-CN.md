# Black-Hat-Zig

<p align="center">
  <img alt="GitHub License" src="https://img.shields.io/github/license/CX330Blake/black-hat-zig">
  <img alt="GitHub top language" src="https://img.shields.io/github/languages/top/cx330blake/black-hat-zig">
  <img alt="GitHub repo size" src="https://img.shields.io/github/repo-size/cx330blake/black-hat-zig">
  <img alt="X (formerly Twitter) Follow" src="https://img.shields.io/twitter/follow/CX330Blake">
</p>

<p height="350px" align="center">
  <img src="https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Black-Hat-Zig.png">
  <br/>
  <b>你好，黑客。你好，恶意软件开发者。你好，逆向工程师。很高兴在这里见到你，一起探索 Zig 的黑暗力量！</b><br/><br/>
  <b>由 <a href="https://github.com/cx330blake">@CX330Blake</a> 维护与管理</b>
</p>

---

## 目录

- [简介](#intro)
- [为什么选择 Zig?](#why-zig)
- [编译代码](#compiling-the-codes)
- [载荷植入](#payload-placement)
- [载荷混淆](#payload-obfuscation)
- [载荷加密](#payload-encryption)
- [载荷执行](#payload-execution)
- [反弹 Shell](#reverse-shell)
- [恶意软件技术](#malware-techniques)
- [恶意开发工具](#maldev-tools)
- [贡献者](#contributors)
- [致谢与参考](#credits--references)
- [Star 记录](#star-history)
- [免责声明](#disclaimer)

## 简介

> [!IMPORTANT]
> 本项目持续更新中！

本项目提供了许多使用 Zig 实现的恶意软件技术，因为我是它的超级粉丝。你可以用此仓库将 Zig 武器化。Black-Hat-Zig 持续更新，力求包含更多内容。如果你能为本项目提交 PR，将会非常完美。

好了，让我们一起 hack the planet 吧！

## 为什么选择 Zig?

- 🤝 与 C/C++ 源码轻松交互
- 🔎 更为新颖，因而更难被检测
- 💪 极低级别的控制，甚至低于 C
- 😱 由于现代编译器，逆向难度更高
- 🛡️ 极少的运行时依赖——无庞大的标准库负担
- 🎯 无未定义行为——显式处理边界情况，防止崩溃

## 编译代码

你可以在每个目录下查看代码。如果代码使用了 Windows API，你会在对应项目目录的 `README.md` 中看到提示，例如[这个](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/)。

对于需要 Windows API 的项目，我已经将默认构建目标设置为 `windows-x86_64`，因此你可以在 Linux、Windows、甚至 MacOS 上直接复制粘贴以下命令进行编译！（但你仍然需要 Windows 环境来运行可执行文件）

```bash
zig build
```

## 载荷植入

将恶意载荷放置到可执行文件不同节区的技术。

- [.data 节](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_data_section/)
- [.rdata 节](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rdata_section/)
- [.text 节](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_text_section/)
- [.rsrc 节](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rsrc_section/)

## 载荷混淆

通过混淆技术伪装载荷，避免静态分析或特征匹配检测。

- [IP 地址混淆](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/)
  - [IPv4 混淆](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_obfuscation/)
  - [IPv4 反混淆](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_deobfuscation/)
  - [IPv6 混淆](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_obfuscation/)
  - [IPv6 反混淆](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_deobfuscation/)
- [MAC 地址混淆](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/)
  - [MAC 地址混淆](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACFuscation/)
  - [MAC 地址反混淆](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACDeobfuscation/)
- [UUID 混淆](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/)
  - [UUID 混淆](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDFuscation/)
  - [UUID 反混淆](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDDeobfuscation/)

## 载荷加密

用于在存储或传输过程中隐藏载荷真实意图的各种加密方案。

- [XOR 加密](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/)
  - [使用标准库的 XOR](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/std_lib_xor/)
- [RC4 加密](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/)
  - [使用 SystemFunction032 的 RC4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/system_function_032_rc4/)
- [AES 加密](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/)
  - [通过 Bcrypt.h 的 AES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/)
  - [通过标准库的 AES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/std_aes/)
  - [通过 TinyAES 的 AES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/tiny_aes/)

## 载荷执行

- [DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/dll/)
- [Shellcode](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/shellcode/)

## 反弹 Shell

用于建立反弹 shell，实现 C2 访问或后渗透控制的原语。

- [使用标准库实现反弹 Shell](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Reverse-Shell/std_reverse_shell/)

## 恶意软件技术

一系列适配于 Zig 的常见进攻性技术。

- [进程注入](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/)
  - [DLL 注入](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/dll_injection/)
  - [Shellcode 注入](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/shellcode_injection/)
- [载荷分阶段](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/)
  - [来自 Web 服务器](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/web_server/)
  - [来自 Windows 注册表](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/windows_registry/)
- [进程枚举](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/)
  - [使用 CreateToolhelp32Snapshot](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/create_tool_help_32_snapshot/)
  - [使用 EnumProcesses](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/enum_processes/)
  - [使用 NtQuerySystemInformation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/nt_query_system_information/)

## 恶意开发工具

- [ZYRA: 你的运行时护甲](https://github.com/cx330blake/zyra)
  - 一个用 Zig 编写的可执行文件加壳器
- [ZYPE: 你的载荷加密器](https://github.com/cx330blake/zype)
  - 生成包含你加密/混淆载荷及其解密/反混淆函数的 Zig 代码模板。

## 贡献者

本项目主要由 [@CX330Blake](https://github.com/CX330Blake) 维护与管理。欢迎 PR。希望有更多人用 Zig 进行恶意软件开发，让生态更加成熟。

非常感谢以下贡献者！

<a href="https://github.com/CX330Blake/black-hat-zig/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CX330Blake/black-hat-zig" />
</a>

## 致谢与参考

- [Maldev Academy](https://maldevacademy.com/)
- [OffensiveNim](https://github.com/byt3bl33d3r/OffensiveNim)

## Star 记录

[![Star History Chart](https://api.star-history.com/svg?repos=CX330blake/black-hat-zig&type=Date)](https://www.star-history.com/#CX330blake/black-hat-zig&Date)

## 免责声明

本项目仅供道德及教育用途。请不要成为网络犯罪分子。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---