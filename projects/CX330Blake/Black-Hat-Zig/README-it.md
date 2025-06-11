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
  <b>Ciao hacker. Ciao maldev. Ciao reverser. È un piacere vederti qui per esplorare il lato oscuro della potenza di Zig!</b><br/><br/>
  <b>Mantenuto e gestito da <a href="https://github.com/cx330blake">@CX330Blake</a></b>
</p>

---

## Indice

- [Introduzione](#intro)
- [Perché Zig?](#why-zig)
- [Compilazione dei codici](#compiling-the-codes)
- [Posizionamento dei Payload](#payload-placement)
- [Offuscamento dei Payload](#payload-obfuscation)
- [Crittografia dei Payload](#payload-encryption)
- [Esecuzione dei Payload](#payload-execution)
- [Reverse Shell](#reverse-shell)
- [Tecniche Malware](#malware-techniques)
- [Strumenti Maldev](#maldev-tools)
- [Contributori](#contributors)
- [Crediti & Riferimenti](#credits--references)
- [Cronologia Stelle](#star-history)
- [Disclaimer](#disclaimer)

## Intro

> [!IMPORTANT]
> Questo progetto è in continuo aggiornamento!

Questo progetto fornisce molte implementazioni di tecniche malware utilizzando Zig, dal momento che ne sono un grande fan. Puoi usare questo repository per armare Zig. Black-Hat-Zig è costantemente aggiornato per assicurarsi che contenga il maggior numero di contenuti possibile. Sarebbe perfetto se volessi creare una PR per questo progetto.

Ok, hack the planet!

## Why Zig?

- 🤝 Facile interazione con sorgenti C/C++
- 🔎 È più recente, quindi più difficile da rilevare
- 💪 Controllo a basso livello molto forte, anche più basso di C
- 😱 Più difficile da fare RE a causa del compilatore moderno
- 🛡️ Dipendenze minime a runtime - Nessuna grossa impronta della libreria standard
- 🎯 Nessun comportamento indefinito - La gestione esplicita dei casi limite previene crash

## Compilazione dei codici

Puoi controllare i codici all'interno di ogni directory. Inoltre, se il codice utilizza le API di Windows, vedrai l'indicazione nella directory `README.md` corrispondente del progetto, per esempio, [questa](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/).

Ho già impostato il target di compilazione predefinito su `windows-x86_64` per quelli che necessitano delle API di Windows, quindi puoi facilmente copiare e incollare il seguente comando per compilare il codice ovunque tu sia, su Linux, Windows o anche MacOS! (Ma avrai comunque bisogno di un ambiente Windows per eseguire gli eseguibili)

```bash
zig build
```

## Posizionamento dei Payload

Tecniche per posizionare payload malevoli in varie sezioni di un file eseguibile.

- [.data Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_data_section/)
- [.rdata Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rdata_section/)
- [.text Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_text_section/)
- [.rsrc Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rsrc_section/)

## Offuscamento dei Payload

Tecniche di offuscamento per mascherare i payload ed evitare il rilevamento tramite analisi statica o pattern matching.

- [Offuscamento Indirizzo IP](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/)
  - [Offuscamento IPv4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_obfuscation/)
  - [Deoffuscamento IPv4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_deobfuscation/)
  - [Offuscamento IPv6](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_obfuscation/)
  - [Deoffuscamento IPv6](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_deobfuscation/)
- [Offuscamento Indirizzo MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/)
  - [Offuscamento Indirizzo MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACFuscation/)
  - [Deoffuscamento Indirizzo MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACDeobfuscation/)
- [Offuscamento UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/)
  - [Offuscamento UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDFuscation/)
  - [Deoffuscamento UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDDeobfuscation/)

## Crittografia dei Payload

Schemi di crittografia vari utilizzati per nascondere le reali intenzioni di un payload durante lo storage o la trasmissione.

- [Crittografia XOR](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/)
  - [XOR con libreria standard](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/std_lib_xor/)
- [Crittografia RC4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/)
  - [RC4 con SystemFunction032](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/system_function_032_rc4/)
- [Crittografia AES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/)
  - [AES con Bcrypt.h](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/)
  - [AES con libreria standard](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/std_aes/)
  - [AES con TinyAES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/tiny_aes/)

## Esecuzione dei Payload

- [DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/dll/)
- [Shellcode](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/shellcode/)

## Reverse Shell

Primitive per stabilire reverse shell per accesso C2 o controllo post-exploitation.

- [Reverse Shell con libreria standard](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Reverse-Shell/std_reverse_shell/)

## Tecniche Malware

Una raccolta di tecniche offensive comuni adattate a Zig.

- [Iniezione di Processo](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/)
  - [Iniezione DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/dll_injection/)
  - [Iniezione Shellcode](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/shellcode_injection/)
- [Staging dei Payload](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/)
  - [Da Web Server](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/web_server/)
  - [Da Registro di Windows](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/windows_registry/)
- [Enumerazione Processi](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/)
  - [Con CreateToolhelp32Snapshot](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/create_tool_help_32_snapshot/)
  - [Con EnumProcesses](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/enum_processes/)
  - [Con NtQuerySystemInformation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/nt_query_system_information/)

## Strumenti Maldev

- [ZYRA: La tua Runtime Armor](https://github.com/cx330blake/zyra)
  - Un packer eseguibile scritto in Zig
- [ZYPE: Il tuo Payload Encryptor](https://github.com/cx330blake/zype)
  - Genera un template di codice in Zig contenente il tuo payload criptato/offuscato e la relativa funzione di decriptazione/deoffuscazione.

## Contributori

Questo progetto è principalmente mantenuto e gestito da [@CX330Blake](https://github.com/CX330Blake). PR sono benvenuti. Speriamo che sempre più persone utilizzino Zig per lo sviluppo di malware così l'ecosistema diventerà più maturo.

Un enorme grazie a questi contributori!

<a href="https://github.com/CX330Blake/black-hat-zig/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CX330Blake/black-hat-zig" />
</a>

## Crediti & Riferimenti

- [Maldev Academy](https://maldevacademy.com/)
- [OffensiveNim](https://github.com/byt3bl33d3r/OffensiveNim)

## Cronologia Stelle

[![Star History Chart](https://api.star-history.com/svg?repos=CX330blake/black-hat-zig&type=Date)](https://www.star-history.com/#CX330blake/black-hat-zig&Date)

## Disclaimer

Questo progetto è solo per scopi etici ed educativi. Non diventare un cyber criminale.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---