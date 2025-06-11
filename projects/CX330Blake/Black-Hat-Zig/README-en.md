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
  <b>Hello hackers. Hello maldevs. Hello reversers. Nice to see you here to explore the dark power of Zig!</b><br/><br/>
  <b>Maintained and managed by <a href="https://github.com/cx330blake">@CX330Blake</a></b>
</p>

---

## ToC

- [Intro](#intro)
- [Why Zig?](#why-zig)
- [Compiling the codes](#compiling-the-codes)
- [Payload Placement](#payload-placement)
- [Payload Obfuscation](#payload-obfuscation)
- [Payload Encryption](#payload-encryption)
- [Payload Execution](#payload-execution)
- [Reverse Shell](#reverse-shell)
- [Malware Techniques](#malware-techniques)
- [Maldev Tools](#maldev-tools)
- [Contributors](#contributors)
- [Credits & References](#credits--references)
- [Star History](#star-history)
- [Disclaimer](#disclaimer)

## Intro

> [!IMPORTANT]
> This project is continuously updating!

This project provides many malware techniques implementation using Zig since I'm a huge fan of it. You can use this repo to weaponize Zig. Black-Hat-Zig is continuously updating to make sure it contains as more content as it could. It will be perfect if you want to create a PR for this project.

Okay, let's hack the planet!

## Why Zig?

- 🤝 Easy to interact with C/C++ source
- 🔎 It's newer, so it's harder to be detect
- 💪 Strongly low level control, even lower than C
- 😱 It's harder to RE because of the modern compiler
- 🛡️ Minimal runtime dependencies - No massive standard library footprint
- 🎯 No undefined behavior - Explicit handling of edge cases prevents crashes

## Compiling the codes

You can check the codes inside each directory. Also, if the code uses Windows API, you will see the hint in the corresponding project directory `README.md`, for example, [this one](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/).

I've already set the corresponding default building target to `windows-x86_64` for those needed a Windows API, so you can easily copy & paste the following command to compile the code wherever you are on Linux, Windows, even MacOS! (But you still need a Windows environment to run the executables)

```bash
zig build
```

## Payload Placement

Techniques to place malicious payloads in various sections of an executable file.

- [.data Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_data_section/)
- [.rdata Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rdata_section/)
- [.text Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_text_section/)
- [.rsrc Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rsrc_section/)

## Payload Obfuscation

Obfuscation techniques to disguise payloads and avoid detection through static analysis or pattern matching.

- [IP Address Obfuscation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/)
  - [IPv4 Obfuscation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_obfuscation/)
  - [IPv4 Deobfuscation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_deobfuscation/)
  - [IPv6 Obfuscation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_obfuscation/)
  - [IPv6 Deobfuscation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_deobfuscation/)
- [MAC Address Obfuscation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/)
  - [MAC Address Obfuscation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACFuscation/)
  - [MAC Address Deobfuscation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACDeobfuscation/)
- [UUID Obfuscation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/)
  - [UUID Obfuscation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDFuscation/)
  - [UUID Deobfuscation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDDeobfuscation/)

## Payload Encryption

Various encryption schemes used to hide the real intent of a payload during storage or transmission.

- [XOR Encryption](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/)
  - [XOR With Standard Library](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/std_lib_xor/)
- [RC4 Encryption](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/)
  - [RC4 With SystemFunction032](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/system_function_032_rc4/)
- [AES Encryption](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/)
  - [AES With Bcrypt.h](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/)
  - [AES With Standard Library](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/std_aes/)
  - [AES With TinyAES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/tiny_aes/)

## Payload Execution

- [DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/dll/)
- [Shellcode](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/shellcode/)

## Reverse Shell

Primitives for establishing reverse shells for C2 access or post-exploitation control.

- [Reverse Shell With Standard Library](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Reverse-Shell/std_reverse_shell/)

## Malware Techniques

A collection of common offensive tradecraft techniques adapted to Zig.

- [Process Injection](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/)
  - [DLL Injection](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/dll_injection/)
  - [Shellcode Injection](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/shellcode_injection/)
- [Payload Staging](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/)
  - [From Web Server](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/web_server/)
  - [From Windows Registry](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/windows_registry/)
- [Process Enumeration](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/)
  - [Using CreateToolhelp32Snapshot](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/create_tool_help_32_snapshot/)
  - [Using EnumProcesses](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/enum_processes/)
  - [Using NtQuerySystemInformation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/nt_query_system_information/)

## Maldev Tools

- [ZYRA: Your Runtime Armor](https://github.com/cx330blake/zyra)
  - An executable packer written in Zig
- [ZYPE: Your Payload Encryptor](https://github.com/cx330blake/zype)
  - Generate a code template in Zig containing your encrypted/obfuscated payload and the corresponding decrypting/deobfuscating function.

## Contributors

This project is mainly maintained & managed by [@CX330Blake](https://github.com/CX330Blake). PRs are welcomed. Hope there's more people use Zig for malware developing so the ecosystem will be more mature.

Huge thanks for these contributors!

<a href="https://github.com/CX330Blake/black-hat-zig/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CX330Blake/black-hat-zig" />
</a>

## Credits & References

- [Maldev Academy](https://maldevacademy.com/)
- [OffensiveNim](https://github.com/byt3bl33d3r/OffensiveNim)

## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=CX330blake/black-hat-zig&type=Date)](https://www.star-history.com/#CX330blake/black-hat-zig&Date)

## Disclaimer

This project is for ethical and educational purpose only. Don't be a cyber criminal.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---