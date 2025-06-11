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
  <b>Hallo hackers. Hallo maldevs. Hallo reversers. Leuk om jullie hier te zien om de duistere kracht van Zig te verkennen!</b><br/><br/>
  <b>Onderhouden en beheerd door <a href="https://github.com/cx330blake">@CX330Blake</a></b>
</p>

---

## Inhoudsopgave

- [Intro](#intro)
- [Waarom Zig?](#waarom-zig)
- [Compileren van de code](#compileren-van-de-code)
- [Payload Plaatsing](#payload-plaatsing)
- [Payload Obfuscatie](#payload-obfuscatie)
- [Payload Encryptie](#payload-encryptie)
- [Payload Uitvoering](#payload-uitvoering)
- [Reverse Shell](#reverse-shell)
- [Malware Technieken](#malware-technieken)
- [Maldev Tools](#maldev-tools)
- [Bijdragers](#bijdragers)
- [Credits & Referenties](#credits--referenties)
- [Sterren Geschiedenis](#sterren-geschiedenis)
- [Disclaimer](#disclaimer)

## Intro

> [!BELANGRIJK]
> Dit project wordt continu bijgewerkt!

Dit project biedt veel implementaties van malwaretechnieken met Zig omdat ik er een grote fan van ben. Je kunt deze repo gebruiken om Zig te bewapenen. Black-Hat-Zig wordt continu bijgewerkt om ervoor te zorgen dat het zo veel mogelijk inhoud bevat. Het zou perfect zijn als je een PR voor dit project wilt maken.

Oké, laten we de planeet hacken!

## Waarom Zig?

- 🤝 Gemakkelijk te integreren met C/C++ broncode
- 🔎 Het is nieuw, dus moeilijker te detecteren
- 💪 Sterk laag-niveau controle, zelfs lager dan C
- 😱 Moeilijker te reverse engineeren door de moderne compiler
- 🛡️ Minimale runtime afhankelijkheden - Geen massale standaardbibliotheek footprint
- 🎯 Geen ongedefinieerd gedrag - Expliciete afhandeling van edge cases voorkomt crashes

## Compileren van de code

Je kunt de code bekijken in elke directory. Als de code gebruikmaakt van de Windows API, zie je de hint in het bijbehorende projectdirectory `README.md`, bijvoorbeeld [deze](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/).

Ik heb het bijbehorende standaard builddoel al ingesteld op `windows-x86_64` voor diegene die een Windows API nodig hebben, dus je kunt eenvoudig het volgende commando kopiëren & plakken om de code te compileren, waar je ook bent op Linux, Windows, zelfs MacOS! (Maar je hebt nog steeds een Windows-omgeving nodig om de uitvoerbare bestanden te draaien)

```bash
zig build
```

## Payload Plaatsing

Technieken om kwaadaardige payloads in verschillende secties van een uitvoerbaar bestand te plaatsen.

- [.data Sectie](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_data_section/)
- [.rdata Sectie](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rdata_section/)
- [.text Sectie](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_text_section/)
- [.rsrc Sectie](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rsrc_section/)

## Payload Obfuscatie

Obfuscatietechnieken om payloads te camoufleren en detectie via statische analyse of patroonherkenning te vermijden.

- [IP Adres Obfuscatie](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/)
  - [IPv4 Obfuscatie](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_obfuscation/)
  - [IPv4 Deobfuscatie](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_deobfuscation/)
  - [IPv6 Obfuscatie](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_obfuscation/)
  - [IPv6 Deobfuscatie](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_deobfuscation/)
- [MAC Adres Obfuscatie](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/)
  - [MAC Adres Obfuscatie](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACFuscation/)
  - [MAC Adres Deobfuscatie](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACDeobfuscation/)
- [UUID Obfuscatie](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/)
  - [UUID Obfuscatie](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDFuscation/)
  - [UUID Deobfuscatie](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDDeobfuscation/)

## Payload Encryptie

Verschillende encryptieschema’s die gebruikt worden om het echte doel van een payload te verbergen tijdens opslag of verzending.

- [XOR Encryptie](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/)
  - [XOR Met Standaardbibliotheek](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/std_lib_xor/)
- [RC4 Encryptie](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/)
  - [RC4 Met SystemFunction032](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/system_function_032_rc4/)
- [AES Encryptie](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/)
  - [AES Met Bcrypt.h](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/)
  - [AES Met Standaardbibliotheek](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/std_aes/)
  - [AES Met TinyAES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/tiny_aes/)

## Payload Uitvoering

- [DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/dll/)
- [Shellcode](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/shellcode/)

## Reverse Shell

Primitieven voor het opzetten van reverse shells voor C2-toegang of post-exploitatiecontrole.

- [Reverse Shell Met Standaardbibliotheek](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Reverse-Shell/std_reverse_shell/)

## Malware Technieken

Een verzameling van veelgebruikte offensieve tradecraft technieken aangepast aan Zig.

- [Procesinjectie](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/)
  - [DLL Injectie](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/dll_injection/)
  - [Shellcode Injectie](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/shellcode_injection/)
- [Payload Staging](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/)
  - [Van Webserver](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/web_server/)
  - [Van Windows Register](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/windows_registry/)
- [Proces Enumeratie](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/)
  - [Met CreateToolhelp32Snapshot](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/create_tool_help_32_snapshot/)
  - [Met EnumProcesses](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/enum_processes/)
  - [Met NtQuerySystemInformation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/nt_query_system_information/)

## Maldev Tools

- [ZYRA: Je Runtime Armor](https://github.com/cx330blake/zyra)
  - Een executable packer geschreven in Zig
- [ZYPE: Je Payload Encryptor](https://github.com/cx330blake/zype)
  - Genereer een codetemplate in Zig met jouw versleutelde/obfusceerde payload en de bijbehorende decryptie-/deobfuscatie-functie.

## Bijdragers

Dit project wordt voornamelijk onderhouden & beheerd door [@CX330Blake](https://github.com/CX330Blake). PR’s zijn welkom. Hopelijk gebruiken meer mensen Zig voor malwareontwikkeling zodat het ecosysteem volwassener wordt.

Grote dank aan deze bijdragers!

<a href="https://github.com/CX330Blake/black-hat-zig/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CX330Blake/black-hat-zig" />
</a>

## Credits & Referenties

- [Maldev Academy](https://maldevacademy.com/)
- [OffensiveNim](https://github.com/byt3bl33d3r/OffensiveNim)

## Sterren Geschiedenis

[![Star History Chart](https://api.star-history.com/svg?repos=CX330blake/black-hat-zig&type=Date)](https://www.star-history.com/#CX330blake/black-hat-zig&Date)

## Disclaimer

Dit project is uitsluitend bedoeld voor ethische en educatieve doeleinden. Word geen cybercrimineel.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---