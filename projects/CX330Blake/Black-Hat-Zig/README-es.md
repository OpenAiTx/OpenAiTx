# Black-Hat-Zig

<p align="center">
  <img alt="Licencia de GitHub" src="https://img.shields.io/github/license/CX330Blake/black-hat-zig">
  <img alt="Lenguaje principal de GitHub" src="https://img.shields.io/github/languages/top/cx330blake/black-hat-zig">
  <img alt="Tamaño del repositorio de GitHub" src="https://img.shields.io/github/repo-size/cx330blake/black-hat-zig">
  <img alt="Seguir en X (anteriormente Twitter)" src="https://img.shields.io/twitter/follow/CX330Blake">
</p>

<p height="350px" align="center">
  <img src="https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Black-Hat-Zig.png">
  <br/>
  <b>Hola hackers. Hola maldevs. Hola reversers. ¡Qué gusto verlos aquí para explorar el poder oscuro de Zig!</b><br/><br/>
  <b>Mantenido y gestionado por <a href="https://github.com/cx330blake">@CX330Blake</a></b>
</p>

---

## ToC

- [Introducción](#intro)
- [¿Por qué Zig?](#why-zig)
- [Compilando los códigos](#compiling-the-codes)
- [Ubicación del Payload](#payload-placement)
- [Ofuscación del Payload](#payload-obfuscation)
- [Encriptación del Payload](#payload-encryption)
- [Ejecución del Payload](#payload-execution)
- [Reverse Shell](#reverse-shell)
- [Técnicas de Malware](#malware-techniques)
- [Herramientas Maldev](#maldev-tools)
- [Colaboradores](#contributors)
- [Créditos y Referencias](#credits--references)
- [Historial de Stars](#star-history)
- [Descargo de responsabilidad](#disclaimer)

## Intro

> [!IMPORTANTE]
> ¡Este proyecto se actualiza continuamente!

Este proyecto proporciona la implementación de muchas técnicas de malware usando Zig, ya que soy un gran fan de este lenguaje. Puedes usar este repositorio para “armar” Zig. Black-Hat-Zig se actualiza continuamente para asegurar que contenga la mayor cantidad de contenido posible. Será perfecto si deseas crear un PR para este proyecto.

¡Bien, vamos a hackear el planeta!

## ¿Por qué Zig?

- 🤝 Fácil interacción con código fuente en C/C++
- 🔎 Es más nuevo, por lo que es más difícil de detectar
- 💪 Control de bajo nivel muy fuerte, incluso más bajo que C
- 😱 Es más difícil de hacer ingeniería inversa debido al compilador moderno
- 🛡️ Dependencias mínimas en tiempo de ejecución - Sin una enorme huella de la biblioteca estándar
- 🎯 Sin comportamiento indefinido - El manejo explícito de casos extremos evita fallos

## Compilando los códigos

Puedes revisar los códigos dentro de cada directorio. Además, si el código usa la API de Windows, verás la indicación en el archivo `README.md` del proyecto correspondiente, por ejemplo, [este](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/).

Ya he establecido el objetivo de compilación predeterminado correspondiente como `windows-x86_64` para aquellos que necesitan una API de Windows, así que puedes copiar y pegar fácilmente el siguiente comando para compilar el código donde sea que estés, en Linux, Windows, ¡incluso MacOS! (Pero aún necesitas un entorno Windows para ejecutar los ejecutables)

```bash
zig build
```

## Ubicación del Payload

Técnicas para colocar cargas maliciosas en varias secciones de un archivo ejecutable.

- [Sección .data](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_data_section/)
- [Sección .rdata](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rdata_section/)
- [Sección .text](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_text_section/)
- [Sección .rsrc](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rsrc_section/)

## Ofuscación del Payload

Técnicas de ofuscación para disfrazar payloads y evitar la detección mediante análisis estático o coincidencia de patrones.

- [Ofuscación de Dirección IP](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/)
  - [Ofuscación IPv4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_obfuscation/)
  - [Desofuscación IPv4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_deobfuscation/)
  - [Ofuscación IPv6](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_obfuscation/)
  - [Desofuscación IPv6](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_deobfuscation/)
- [Ofuscación de Dirección MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/)
  - [Ofuscación de Dirección MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACFuscation/)
  - [Desofuscación de Dirección MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACDeobfuscation/)
- [Ofuscación de UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/)
  - [Ofuscación de UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDFuscation/)
  - [Desofuscación de UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDDeobfuscation/)

## Encriptación del Payload

Varios esquemas de cifrado usados para ocultar la verdadera intención de un payload durante el almacenamiento o transmisión.

- [Encriptación XOR](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/)
  - [XOR con Biblioteca Estándar](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/std_lib_xor/)
- [Encriptación RC4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/)
  - [RC4 con SystemFunction032](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/system_function_032_rc4/)
- [Encriptación AES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/)
  - [AES con Bcrypt.h](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/)
  - [AES con Biblioteca Estándar](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/std_aes/)
  - [AES con TinyAES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/tiny_aes/)

## Ejecución del Payload

- [DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/dll/)
- [Shellcode](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/shellcode/)

## Reverse Shell

Primitivas para establecer reverse shells para acceso C2 o control post-explotación.

- [Reverse Shell con Biblioteca Estándar](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Reverse-Shell/std_reverse_shell/)

## Técnicas de Malware

Una colección de técnicas comunes de ofensiva adaptadas a Zig.

- [Inyección de Procesos](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/)
  - [Inyección DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/dll_injection/)
  - [Inyección de Shellcode](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/shellcode_injection/)
- [Staging de Payload](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/)
  - [Desde Servidor Web](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/web_server/)
  - [Desde el Registro de Windows](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/windows_registry/)
- [Enumeración de Procesos](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/)
  - [Usando CreateToolhelp32Snapshot](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/create_tool_help_32_snapshot/)
  - [Usando EnumProcesses](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/enum_processes/)
  - [Usando NtQuerySystemInformation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/nt_query_system_information/)

## Herramientas Maldev

- [ZYRA: Tu Armadura en Tiempo de Ejecución](https://github.com/cx330blake/zyra)
  - Un empaquetador de ejecutables escrito en Zig
- [ZYPE: Tu Encriptador de Payload](https://github.com/cx330blake/zype)
  - Genera una plantilla de código en Zig que contiene tu payload encriptado/ofuscado y la función correspondiente para desencriptar/desofuscar.

## Colaboradores

Este proyecto está mantenido y gestionado principalmente por [@CX330Blake](https://github.com/CX330Blake). Se aceptan PRs. Espero que más personas usen Zig para desarrollar malware para que el ecosistema sea más maduro.

¡Muchas gracias a estos colaboradores!

<a href="https://github.com/CX330Blake/black-hat-zig/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CX330Blake/black-hat-zig" />
</a>

## Créditos y Referencias

- [Maldev Academy](https://maldevacademy.com/)
- [OffensiveNim](https://github.com/byt3bl33d3r/OffensiveNim)

## Historial de Stars

[![Gráfico de Historial de Stars](https://api.star-history.com/svg?repos=CX330blake/black-hat-zig&type=Date)](https://www.star-history.com/#CX330blake/black-hat-zig&Date)

## Descargo de responsabilidad

Este proyecto es solo para fines éticos y educativos. No seas un ciberdelincuente.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---