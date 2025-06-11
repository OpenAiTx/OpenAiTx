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
  <b>Witajcie hakerzy. Witajcie maldevsi. Witajcie reversersi. Miło was tu widzieć, by odkrywać ciemną moc Zig!</b><br/><br/>
  <b>Utrzymywane i zarządzane przez <a href="https://github.com/cx330blake">@CX330Blake</a></b>
</p>

---

## Spis treści

- [Wstęp](#intro)
- [Dlaczego Zig?](#why-zig)
- [Kompilacja kodu](#compiling-the-codes)
- [Umieszczanie payloadu](#payload-placement)
- [Obfuskacja payloadu](#payload-obfuscation)
- [Szyfrowanie payloadu](#payload-encryption)
- [Wykonywanie payloadu](#payload-execution)
- [Reverse Shell](#reverse-shell)
- [Techniki malware](#malware-techniques)
- [Narzędzia Maldev](#maldev-tools)
- [Współtwórcy](#contributors)
- [Podziękowania i źródła](#credits--references)
- [Historia gwiazdek](#star-history)
- [Zastrzeżenie](#disclaimer)

## Wstęp

> [!IMPORTANT]
> Projekt jest ciągle aktualizowany!

Ten projekt dostarcza wiele implementacji technik malware z wykorzystaniem Zig, ponieważ jestem jego wielkim fanem. Możesz użyć tego repozytorium, aby uzbroić Zig. Black-Hat-Zig jest stale aktualizowany, by zawierał jak najwięcej treści. Byłoby idealnie, gdybyś chciał stworzyć PR dla tego projektu.

No to hakujemy planetę!

## Dlaczego Zig?

- 🤝 Łatwa interakcja z kodem źródłowym C/C++
- 🔎 Jest nowszy, więc trudniej go wykryć
- 💪 Bardzo niski poziom kontroli, nawet niższy niż C
- 😱 Trudniej przeprowadzić RE przez nowoczesny kompilator
- 🛡️ Minimalne zależności w czasie działania - brak masywnej biblioteki standardowej
- 🎯 Brak niezdefiniowanego zachowania - Jawne obsługiwanie przypadków brzegowych zapobiega awariom

## Kompilacja kodu

Możesz sprawdzić kody w każdym katalogu. Jeśli kod używa Windows API, zobaczysz informację w odpowiednim katalogu projektu `README.md`, na przykład [tutaj](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/).

Ustawiłem już domyślny docelowy system budowania na `windows-x86_64` dla tych, które potrzebują Windows API, więc możesz łatwo skopiować i wkleić poniższą komendę, aby skompilować kod gdziekolwiek jesteś – na Linuksie, Windowsie, nawet MacOS! (Ale nadal potrzebujesz środowiska Windows, aby uruchomić pliki wykonywalne)

```bash
zig build
```

## Umieszczanie payloadu

Techniki umieszczania złośliwych payloadów w różnych sekcjach pliku wykonywalnego.

- [.data Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_data_section/)
- [.rdata Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rdata_section/)
- [.text Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_text_section/)
- [.rsrc Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rsrc_section/)

## Obfuskacja payloadu

Techniki obfuskacji w celu ukrycia payloadów i unikania wykrycia przez analizę statyczną lub dopasowywanie wzorców.

- [Obfuskacja adresu IP](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/)
  - [Obfuskacja IPv4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_obfuscation/)
  - [Deobfuskacja IPv4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_deobfuscation/)
  - [Obfuskacja IPv6](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_obfuscation/)
  - [Deobfuskacja IPv6](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_deobfuscation/)
- [Obfuskacja adresu MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/)
  - [Obfuskacja adresu MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACFuscation/)
  - [Deobfuskacja adresu MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACDeobfuscation/)
- [Obfuskacja UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/)
  - [Obfuskacja UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDFuscation/)
  - [Deobfuskacja UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDDeobfuscation/)

## Szyfrowanie payloadu

Różne schematy szyfrowania używane do ukrycia rzeczywistego celu payloadu podczas przechowywania lub transmisji.

- [Szyfrowanie XOR](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/)
  - [XOR z biblioteką standardową](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/std_lib_xor/)
- [Szyfrowanie RC4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/)
  - [RC4 z SystemFunction032](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/system_function_032_rc4/)
- [Szyfrowanie AES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/)
  - [AES z Bcrypt.h](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/)
  - [AES z biblioteką standardową](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/std_aes/)
  - [AES z TinyAES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/tiny_aes/)

## Wykonywanie payloadu

- [DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/dll/)
- [Shellcode](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/shellcode/)

## Reverse Shell

Prymitywy do ustanawiania reverse shelli dla dostępu C2 lub kontroli po eksploatacji.

- [Reverse Shell z biblioteką standardową](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Reverse-Shell/std_reverse_shell/)

## Techniki malware

Zbiór popularnych technik ofensywnych zaadaptowanych do Zig.

- [Iniekcja procesu](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/)
  - [Iniekcja DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/dll_injection/)
  - [Iniekcja shellcode](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/shellcode_injection/)
- [Staging payloadu](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/)
  - [Z serwera WWW](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/web_server/)
  - [Z rejestru Windows](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/windows_registry/)
- [Enumeracja procesów](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/)
  - [Z użyciem CreateToolhelp32Snapshot](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/create_tool_help_32_snapshot/)
  - [Z użyciem EnumProcesses](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/enum_processes/)
  - [Z użyciem NtQuerySystemInformation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/nt_query_system_information/)

## Narzędzia Maldev

- [ZYRA: Twoja zbroja w czasie działania](https://github.com/cx330blake/zyra)
  - Packer plików wykonywalnych napisany w Zig
- [ZYPE: Twój szyfrator payloadu](https://github.com/cx330blake/zype)
  - Generuje szablon kodu w Zig zawierający zaszyfrowany/obfuskowany payload oraz odpowiadającą funkcję deszyfrującą/deobfuskującą.

## Współtwórcy

Projekt jest głównie utrzymywany i zarządzany przez [@CX330Blake](https://github.com/CX330Blake). PR są mile widziane. Mam nadzieję, że więcej osób będzie używać Zig do rozwoju malware, aby ekosystem stał się dojrzalszy.

Wielkie podziękowania dla tych współtwórców!

<a href="https://github.com/CX330Blake/black-hat-zig/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CX330Blake/black-hat-zig" />
</a>

## Podziękowania i źródła

- [Maldev Academy](https://maldevacademy.com/)
- [OffensiveNim](https://github.com/byt3bl33d3r/OffensiveNim)

## Historia gwiazdek

[![Star History Chart](https://api.star-history.com/svg?repos=CX330blake/black-hat-zig&type=Date)](https://www.star-history.com/#CX330blake/black-hat-zig&Date)

## Zastrzeżenie

Projekt ten jest przeznaczony wyłącznie do celów etycznych i edukacyjnych. Nie bądź cyberprzestępcą.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---