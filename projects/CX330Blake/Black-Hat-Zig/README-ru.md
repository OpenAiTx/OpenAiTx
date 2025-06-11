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
  <b>Привет, хакеры. Привет, maldev’ы. Привет, реверсеры. Рад видеть вас здесь, чтобы исследовать темную силу Zig!</b><br/><br/>
  <b>Поддерживается и управляется <a href="https://github.com/cx330blake">@CX330Blake</a></b>
</p>

---

## ToC

- [Введение](#intro)
- [Почему Zig?](#why-zig)
- [Компиляция кода](#compiling-the-codes)
- [Размещение полезной нагрузки](#payload-placement)
- [Обфускация полезной нагрузки](#payload-obfuscation)
- [Шифрование полезной нагрузки](#payload-encryption)
- [Выполнение полезной нагрузки](#payload-execution)
- [Reverse Shell](#reverse-shell)
- [Техники вредоносного ПО](#malware-techniques)
- [Инструменты maldev](#maldev-tools)
- [Участники](#contributors)
- [Благодарности и источники](#credits--references)
- [История звезд](#star-history)
- [Отказ от ответственности](#disclaimer)

## Intro

> [!IMPORTANT]
> Этот проект постоянно обновляется!

Этот проект предоставляет множество реализаций техник вредоносного ПО на Zig, поскольку я большой поклонник этого языка. Вы можете использовать этот репозиторий для превращения Zig в оружие. Black-Hat-Zig постоянно обновляется, чтобы содержать как можно больше контента. Было бы отлично, если бы вы создали PR для этого проекта.

Ну что ж, давайте взломаем планету!

## Why Zig?

- 🤝 Легко взаимодействует с исходниками C/C++
- 🔎 Он новый, поэтому его сложнее обнаружить
- 💪 Очень низкоуровневый контроль, даже ниже, чем в C
- 😱 Сложнее для реверса из-за современного компилятора
- 🛡️ Минимум зависимостей во время выполнения — нет тяжелой стандартной библиотеки
- 🎯 Нет неопределенного поведения — явная обработка крайних случаев предотвращает сбои

## Compiling the codes

Вы можете просматривать коды в каждом каталоге. Также, если код использует Windows API, вы увидите подсказку в соответствующем проектном каталоге `README.md`, например, [здесь](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/).

Я уже установил соответствующую цель сборки по умолчанию на `windows-x86_64` для тех, кто требует Windows API, так что вы можете просто скопировать и вставить следующую команду для компиляции кода где угодно — на Linux, Windows, даже MacOS! (Но для запуска исполняемых файлов все же потребуется среда Windows)

```bash
zig build
```

## Payload Placement

Техники размещения вредоносных полезных нагрузок в различных секциях исполняемого файла.

- [.data секция](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_data_section/)
- [.rdata секция](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rdata_section/)
- [.text секция](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_text_section/)
- [.rsrc секция](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rsrc_section/)

## Payload Obfuscation

Методы обфускации для маскировки полезных нагрузок и предотвращения их обнаружения при статическом анализе или сопоставлении шаблонов.

- [Обфускация IP-адреса](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/)
  - [Обфускация IPv4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_obfuscation/)
  - [Деобфускация IPv4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_deobfuscation/)
  - [Обфускация IPv6](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_obfuscation/)
  - [Деобфускация IPv6](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_deobfuscation/)
- [Обфускация MAC-адреса](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/)
  - [Обфускация MAC-адреса](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACFuscation/)
  - [Деобфускация MAC-адреса](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACDeobfuscation/)
- [Обфускация UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/)
  - [Обфускация UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDFuscation/)
  - [Деобфускация UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDDeobfuscation/)

## Payload Encryption

Различные схемы шифрования, используемые для сокрытия истинного назначения полезной нагрузки при хранении или передаче.

- [XOR-шифрование](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/)
  - [XOR со стандартной библиотекой](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/std_lib_xor/)
- [RC4-шифрование](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/)
  - [RC4 с SystemFunction032](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/system_function_032_rc4/)
- [AES-шифрование](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/)
  - [AES с Bcrypt.h](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/)
  - [AES со стандартной библиотекой](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/std_aes/)
  - [AES с TinyAES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/tiny_aes/)

## Payload Execution

- [DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/dll/)
- [Shellcode](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/shellcode/)

## Reverse Shell

Примитивы для создания обратных оболочек для доступа C2 или контроля после эксплуатации.

- [Обратная оболочка на стандартной библиотеке](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Reverse-Shell/std_reverse_shell/)

## Malware Techniques

Коллекция распространенных наступательных техник, адаптированных для Zig.

- [Инъекция в процесс](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/)
  - [Инъекция DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/dll_injection/)
  - [Инъекция shell-кода](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/shellcode_injection/)
- [Стадирование полезной нагрузки](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/)
  - [С веб-сервера](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/web_server/)
  - [Из реестра Windows](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/windows_registry/)
- [Перечисление процессов](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/)
  - [С использованием CreateToolhelp32Snapshot](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/create_tool_help_32_snapshot/)
  - [С использованием EnumProcesses](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/enum_processes/)
  - [С использованием NtQuerySystemInformation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/nt_query_system_information/)

## Maldev Tools

- [ZYRA: Ваша защита во время выполнения](https://github.com/cx330blake/zyra)
  - Пакер исполняемых файлов, написанный на Zig
- [ZYPE: Ваш шифратор полезных нагрузок](https://github.com/cx330blake/zype)
  - Генерирует шаблон кода на Zig с вашим зашифрованным/обфусцированным payload и соответствующей функцией дешифрования/деобфускации.

## Contributors

Этот проект в основном поддерживается и управляется [@CX330Blake](https://github.com/CX330Blake). PR приветствуются. Надеюсь, больше людей будут использовать Zig для разработки вредоносного ПО, чтобы экосистема стала более зрелой.

Огромное спасибо этим участникам!

<a href="https://github.com/CX330Blake/black-hat-zig/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CX330Blake/black-hat-zig" />
</a>

## Credits & References

- [Maldev Academy](https://maldevacademy.com/)
- [OffensiveNim](https://github.com/byt3bl33d3r/OffensiveNim)

## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=CX330blake/black-hat-zig&type=Date)](https://www.star-history.com/#CX330blake/black-hat-zig&Date)

## Disclaimer

Этот проект предназначен только для этических и образовательных целей. Не становитесь киберпреступником.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---