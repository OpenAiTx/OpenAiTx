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
  <b>Hallo Hacker. Hallo Maldevs. Hallo Reverser. Schön, dass ihr hier seid, um die dunkle Macht von Zig zu erkunden!</b><br/><br/>
  <b>Gepflegt und verwaltet von <a href="https://github.com/cx330blake">@CX330Blake</a></b>
</p>

---

## Inhaltsverzeichnis

- [Einleitung](#intro)
- [Warum Zig?](#why-zig)
- [Kompilieren der Codes](#compiling-the-codes)
- [Payload-Platzierung](#payload-placement)
- [Payload-Obfuskation](#payload-obfuscation)
- [Payload-Verschlüsselung](#payload-encryption)
- [Payload-Ausführung](#payload-execution)
- [Reverse Shell](#reverse-shell)
- [Malware-Techniken](#malware-techniques)
- [Maldev-Tools](#maldev-tools)
- [Mitwirkende](#contributors)
- [Danksagungen & Referenzen](#credits--references)
- [Stern-Verlauf](#star-history)
- [Haftungsausschluss](#disclaimer)

## Einleitung

> [!IMPORTANT]
> Dieses Projekt wird kontinuierlich aktualisiert!

Dieses Projekt stellt viele Implementierungen von Malware-Techniken mit Zig bereit, da ich ein großer Fan davon bin. Du kannst dieses Repository nutzen, um Zig zu bewaffnen. Black-Hat-Zig wird ständig aktualisiert, um so viel Inhalt wie möglich zu enthalten. Es wäre perfekt, wenn du einen PR zu diesem Projekt beitragen möchtest.

Okay, lass uns den Planeten hacken!

## Warum Zig?

- 🤝 Einfach mit C/C++-Quellcode zu interagieren
- 🔎 Es ist neuer, daher schwerer zu erkennen
- 💪 Starke Low-Level-Kontrolle, sogar niedriger als C
- 😱 Wegen des modernen Compilers schwieriger zu reverse engineeren
- 🛡️ Minimale Laufzeitabhängigkeiten – Kein großer Standardbibliotheks-Footprint
- 🎯 Kein undefiniertes Verhalten – Explizite Behandlung von Randfällen verhindert Abstürze

## Kompilieren der Codes

Du kannst den Code in jedem Verzeichnis überprüfen. Wenn der Code die Windows API verwendet, findest du einen Hinweis im entsprechenden Projektverzeichnis `README.md`, zum Beispiel [hier](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/).

Ich habe das entsprechende Standard-Build-Ziel auf `windows-x86_64` gesetzt für diejenigen, die eine Windows API benötigen, sodass du den folgenden Befehl einfach kopieren und einfügen kannst, um den Code überall zu kompilieren – unter Linux, Windows oder sogar MacOS! (Du benötigst jedoch immer noch eine Windows-Umgebung, um die ausführbaren Dateien zu starten)

```bash
zig build
```

## Payload-Platzierung

Techniken, um bösartige Payloads in verschiedenen Abschnitten einer ausführbaren Datei zu platzieren.

- [.data Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_data_section/)
- [.rdata Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rdata_section/)
- [.text Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_text_section/)
- [.rsrc Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rsrc_section/)

## Payload-Obfuskation

Obfuskationstechniken, um Payloads zu verschleiern und die Erkennung durch statische Analyse oder Musterabgleich zu vermeiden.

- [IP-Adress-Obfuskation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/)
  - [IPv4-Obfuskation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_obfuscation/)
  - [IPv4-Deobfuskation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_deobfuscation/)
  - [IPv6-Obfuskation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_obfuscation/)
  - [IPv6-Deobfuskation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_deobfuscation/)
- [MAC-Adress-Obfuskation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/)
  - [MAC-Adress-Obfuskation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACFuscation/)
  - [MAC-Adress-Deobfuskation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACDeobfuscation/)
- [UUID-Obfuskation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/)
  - [UUID-Obfuskation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDFuscation/)
  - [UUID-Deobfuskation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDDeobfuscation/)

## Payload-Verschlüsselung

Verschiedene Verschlüsselungsschemata, die verwendet werden, um die eigentliche Absicht einer Payload während der Speicherung oder Übertragung zu verbergen.

- [XOR-Verschlüsselung](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/)
  - [XOR mit Standardbibliothek](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/std_lib_xor/)
- [RC4-Verschlüsselung](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/)
  - [RC4 mit SystemFunction032](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/system_function_032_rc4/)
- [AES-Verschlüsselung](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/)
  - [AES mit Bcrypt.h](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/)
  - [AES mit Standardbibliothek](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/std_aes/)
  - [AES mit TinyAES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/tiny_aes/)

## Payload-Ausführung

- [DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/dll/)
- [Shellcode](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/shellcode/)

## Reverse Shell

Grundlagen zur Einrichtung von Reverse Shells für C2-Zugriff oder Post-Exploitation-Kontrolle.

- [Reverse Shell mit Standardbibliothek](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Reverse-Shell/std_reverse_shell/)

## Malware-Techniken

Eine Sammlung verbreiteter offensiver Techniken, angepasst für Zig.

- [Prozess-Injektion](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/)
  - [DLL-Injektion](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/dll_injection/)
  - [Shellcode-Injektion](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/shellcode_injection/)
- [Payload-Staging](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/)
  - [Vom Webserver](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/web_server/)
  - [Aus der Windows-Registry](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/windows_registry/)
- [Prozess-Aufzählung](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/)
  - [Mit CreateToolhelp32Snapshot](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/create_tool_help_32_snapshot/)
  - [Mit EnumProcesses](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/enum_processes/)
  - [Mit NtQuerySystemInformation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/nt_query_system_information/)

## Maldev-Tools

- [ZYRA: Your Runtime Armor](https://github.com/cx330blake/zyra)
  - Ein Executable-Packer, geschrieben in Zig
- [ZYPE: Your Payload Encryptor](https://github.com/cx330blake/zype)
  - Erzeugt eine Code-Vorlage in Zig, die deinen verschlüsselten/obfuskierten Payload und die entsprechende Entschlüsselungs-/Deobfuskationsfunktion enthält.

## Mitwirkende

Dieses Projekt wird hauptsächlich von [@CX330Blake](https://github.com/CX330Blake) gepflegt und verwaltet. PRs sind willkommen. Ich hoffe, dass mehr Menschen Zig für Malware-Entwicklung nutzen, damit das Ökosystem reifer wird.

Ein großes Dankeschön an diese Mitwirkenden!

<a href="https://github.com/CX330Blake/black-hat-zig/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CX330Blake/black-hat-zig" />
</a>

## Danksagungen & Referenzen

- [Maldev Academy](https://maldevacademy.com/)
- [OffensiveNim](https://github.com/byt3bl33d3r/OffensiveNim)

## Stern-Verlauf

[![Star History Chart](https://api.star-history.com/svg?repos=CX330blake/black-hat-zig&type=Date)](https://www.star-history.com/#CX330blake/black-hat-zig&Date)

## Haftungsausschluss

Dieses Projekt dient ausschließlich ethischen und Bildungszwecken. Sei kein Cyberkrimineller.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---