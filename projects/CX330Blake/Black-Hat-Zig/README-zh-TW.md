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
  <b>你好，駭客們。你好，惡意開發者們。你好，逆向工程師們。很高興看到你們來這裡探索 Zig 的黑暗力量！</b><br/><br/>
  <b>由 <a href="https://github.com/cx330blake">@CX330Blake</a> 維護與管理</b>
</p>

---

## 目錄

- [介紹](#intro)
- [為什麼選擇 Zig?](#why-zig)
- [編譯程式碼](#compiling-the-codes)
- [有效載荷放置](#payload-placement)
- [有效載荷混淆](#payload-obfuscation)
- [有效載荷加密](#payload-encryption)
- [有效載荷執行](#payload-execution)
- [反向殼](#reverse-shell)
- [惡意軟體技術](#malware-techniques)
- [惡意開發工具](#maldev-tools)
- [貢獻者](#contributors)
- [鳴謝與參考](#credits--references)
- [Star 歷史](#star-history)
- [免責聲明](#disclaimer)

## 介紹

> [!IMPORTANT]
> 本專案持續更新中！

本專案提供許多利用 Zig 實現的惡意軟體技術，因為我非常喜愛這個語言。你可以利用本倉庫將 Zig 武器化。Black-Hat-Zig 持續更新，以確保內容盡可能豐富。如果你能為這個專案建立 PR 就太完美了。

好了，讓我們一起 hack the planet！

## 為什麼選擇 Zig?

- 🤝 容易與 C/C++ 原始碼互動
- 🔎 它較新，因此較難被偵測
- 💪 強大的低階控制，比 C 還要低階
- 😱 由於現代編譯器，逆向工程更困難
- 🛡️ 最小化運行時依賴——沒有龐大的標準函式庫負擔
- 🎯 沒有未定義行為——明確處理邊界情況以防止崩潰

## 編譯程式碼

你可以在每個目錄下檢查程式碼。如果程式碼使用了 Windows API，你會在對應的專案目錄 `README.md` 中看到提示，例如，[這個](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/)。

我已為那些需要 Windows API 的程式碼設置了預設的建構目標為 `windows-x86_64`，所以你可以輕鬆複製並貼上下列指令，在 Linux、Windows 甚至 MacOS 上編譯程式碼！（但你仍然需要 Windows 環境才能執行產生的可執行檔）

```bash
zig build
```

## 有效載荷放置

將惡意有效載荷放置於可執行檔不同區段的技術。

- [.data 區段](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_data_section/)
- [.rdata 區段](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rdata_section/)
- [.text 區段](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_text_section/)
- [.rsrc 區段](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rsrc_section/)

## 有效載荷混淆

用於偽裝有效載荷、避開靜態分析或模式匹配偵測的混淆技術。

- [IP 位址混淆](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/)
  - [IPv4 混淆](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_obfuscation/)
  - [IPv4 反混淆](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_deobfuscation/)
  - [IPv6 混淆](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_obfuscation/)
  - [IPv6 反混淆](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_deobfuscation/)
- [MAC 位址混淆](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/)
  - [MAC 位址混淆](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACFuscation/)
  - [MAC 位址反混淆](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACDeobfuscation/)
- [UUID 混淆](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/)
  - [UUID 混淆](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDFuscation/)
  - [UUID 反混淆](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDDeobfuscation/)

## 有效載荷加密

用於在儲存或傳輸過程中隱藏有效載荷真實意圖的各種加密方案。

- [XOR 加密](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/)
  - [使用標準函式庫的 XOR](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/std_lib_xor/)
- [RC4 加密](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/)
  - [使用 SystemFunction032 的 RC4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/system_function_032_rc4/)
- [AES 加密](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/)
  - [使用 Bcrypt.h 的 AES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/)
  - [使用標準函式庫的 AES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/std_aes/)
  - [使用 TinyAES 的 AES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/tiny_aes/)

## 有效載荷執行

- [DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/dll/)
- [Shellcode](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/shellcode/)

## 反向殼

用於建立反向殼以進行 C2 存取或後滲透控制的基礎元件。

- [使用標準函式庫的反向殼](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Reverse-Shell/std_reverse_shell/)

## 惡意軟體技術

收錄各種常見進攻技術，並以 Zig 實現。

- [行程注入](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/)
  - [DLL 注入](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/dll_injection/)
  - [Shellcode 注入](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/shellcode_injection/)
- [有效載荷分段](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/)
  - [來自 Web 伺服器](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/web_server/)
  - [來自 Windows 登錄檔](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/windows_registry/)
- [行程列舉](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/)
  - [使用 CreateToolhelp32Snapshot](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/create_tool_help_32_snapshot/)
  - [使用 EnumProcesses](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/enum_processes/)
  - [使用 NtQuerySystemInformation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/nt_query_system_information/)

## 惡意開發工具

- [ZYRA: 你的運行時防護](https://github.com/cx330blake/zyra)
  - 一個以 Zig 撰寫的可執行檔打包器
- [ZYPE: 你的有效載荷加密器](https://github.com/cx330blake/zype)
  - 產生 Zig 程式碼範本，內含你的加密／混淆有效載荷及對應的解密／還原函式。

## 貢獻者

本專案主要由 [@CX330Blake](https://github.com/CX330Blake) 維護與管理。歡迎提交 PR。希望有更多人使用 Zig 進行惡意軟體開發，讓生態系更加成熟。

非常感謝以下貢獻者！

<a href="https://github.com/CX330Blake/black-hat-zig/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CX330Blake/black-hat-zig" />
</a>

## 鳴謝與參考

- [Maldev Academy](https://maldevacademy.com/)
- [OffensiveNim](https://github.com/byt3bl33d3r/OffensiveNim)

## Star 歷史

[![Star History Chart](https://api.star-history.com/svg?repos=CX330blake/black-hat-zig&type=Date)](https://www.star-history.com/#CX330blake/black-hat-zig&Date)

## 免責聲明

本專案僅供道德與教育目的使用。請勿成為網路犯罪分子。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---