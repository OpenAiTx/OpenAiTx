# Black-Hat-Zig

<p align="center">
  <img alt="Licença do GitHub" src="https://img.shields.io/github/license/CX330Blake/black-hat-zig">
  <img alt="Linguagem principal do GitHub" src="https://img.shields.io/github/languages/top/cx330blake/black-hat-zig">
  <img alt="Tamanho do repositório do GitHub" src="https://img.shields.io/github/repo-size/cx330blake/black-hat-zig">
  <img alt="X (antigo Twitter) Seguir" src="https://img.shields.io/twitter/follow/CX330Blake">
</p>

<p height="350px" align="center">
  <img src="https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Black-Hat-Zig.png">
  <br/>
  <b>Olá hackers. Olá maldevs. Olá reversers. Que bom ver você aqui para explorar o poder sombrio do Zig!</b><br/><br/>
  <b>Mantido e gerenciado por <a href="https://github.com/cx330blake">@CX330Blake</a></b>
</p>

---

## ToC

- [Introdução](#intro)
- [Por que Zig?](#why-zig)
- [Compilando os códigos](#compiling-the-codes)
- [Colocação de Payload](#payload-placement)
- [Ofuscação de Payload](#payload-obfuscation)
- [Criptografia de Payload](#payload-encryption)
- [Execução de Payload](#payload-execution)
- [Reverse Shell](#reverse-shell)
- [Técnicas de Malware](#malware-techniques)
- [Ferramentas de Maldev](#maldev-tools)
- [Contribuidores](#contributors)
- [Créditos & Referências](#credits--references)
- [Histórico de Estrelas](#star-history)
- [Aviso Legal](#disclaimer)

## Intro

> [!IMPORTANTE]
> Este projeto está em atualização contínua!

Este projeto fornece várias implementações de técnicas de malware usando Zig, já que sou um grande fã dessa linguagem. Você pode usar este repositório para potencializar o Zig. O Black-Hat-Zig está em constante atualização para garantir que contenha o máximo de conteúdo possível. Será perfeito se você quiser criar um PR para este projeto.

Ok, vamos hackear o planeta!

## Por que Zig?

- 🤝 Fácil de interagir com código-fonte C/C++
- 🔎 É mais recente, então é mais difícil de ser detectado
- 💪 Controle de baixo nível forte, ainda mais baixo que C
- 😱 É mais difícil de fazer RE devido ao compilador moderno
- 🛡️ Dependências mínimas de runtime - Sem grande pegada de biblioteca padrão
- 🎯 Sem comportamento indefinido - Tratamento explícito de casos extremos evita falhas

## Compilando os códigos

Você pode conferir os códigos dentro de cada diretório. Além disso, se o código usar a API do Windows, você verá uma dica no `README.md` do diretório correspondente do projeto, por exemplo, [este aqui](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/).

Eu já defini o alvo padrão de build para `windows-x86_64` para os que precisam de API do Windows, assim você pode copiar e colar facilmente o comando abaixo para compilar o código, esteja você no Linux, Windows ou até MacOS! (Mas você ainda precisará de um ambiente Windows para rodar os executáveis)

```bash
zig build
```

## Colocação de Payload

Técnicas para posicionar payloads maliciosos em várias seções de um arquivo executável.

- [Seção .data](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_data_section/)
- [Seção .rdata](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rdata_section/)
- [Seção .text](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_text_section/)
- [Seção .rsrc](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rsrc_section/)

## Ofuscação de Payload

Técnicas de ofuscação para disfarçar payloads e evitar detecção por análise estática ou correspondência de padrões.

- [Ofuscação de Endereço IP](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/)
  - [Ofuscação de IPv4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_obfuscation/)
  - [Desofuscação de IPv4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_deobfuscation/)
  - [Ofuscação de IPv6](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_obfuscation/)
  - [Desofuscação de IPv6](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_deobfuscation/)
- [Ofuscação de Endereço MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/)
  - [Ofuscação de Endereço MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACFuscation/)
  - [Desofuscação de Endereço MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACDeobfuscation/)
- [Ofuscação de UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/)
  - [Ofuscação de UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDFuscation/)
  - [Desofuscação de UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDDeobfuscation/)

## Criptografia de Payload

Vários esquemas de criptografia usados para esconder a real intenção de um payload durante o armazenamento ou transmissão.

- [Criptografia XOR](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/)
  - [XOR com Biblioteca Padrão](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/std_lib_xor/)
- [Criptografia RC4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/)
  - [RC4 com SystemFunction032](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/system_function_032_rc4/)
- [Criptografia AES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/)
  - [AES com Bcrypt.h](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/)
  - [AES com Biblioteca Padrão](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/std_aes/)
  - [AES com TinyAES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/tiny_aes/)

## Execução de Payload

- [DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/dll/)
- [Shellcode](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/shellcode/)

## Reverse Shell

Primitivas para estabelecer reverse shells para acesso C2 ou controle pós-exploração.

- [Reverse Shell com Biblioteca Padrão](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Reverse-Shell/std_reverse_shell/)

## Técnicas de Malware

Uma coleção de técnicas comuns de ofensiva adaptadas para Zig.

- [Injeção de Processo](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/)
  - [Injeção de DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/dll_injection/)
  - [Injeção de Shellcode](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/shellcode_injection/)
- [Staging de Payload](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/)
  - [Do Servidor Web](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/web_server/)
  - [Do Registro do Windows](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/windows_registry/)
- [Enumeração de Processos](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/)
  - [Usando CreateToolhelp32Snapshot](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/create_tool_help_32_snapshot/)
  - [Usando EnumProcesses](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/enum_processes/)
  - [Usando NtQuerySystemInformation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/nt_query_system_information/)

## Ferramentas de Maldev

- [ZYRA: Sua Armadura em Runtime](https://github.com/cx330blake/zyra)
  - Um empacotador de executáveis escrito em Zig
- [ZYPE: Seu Criptografador de Payload](https://github.com/cx330blake/zype)
  - Gere um template de código em Zig contendo seu payload criptografado/ofuscado e a função correspondente de descriptografia/desofuscação.

## Contribuidores

Este projeto é principalmente mantido & gerenciado por [@CX330Blake](https://github.com/CX330Blake). PRs são bem-vindos. Espero que mais pessoas usem Zig para desenvolvimento de malware para que o ecossistema se torne mais maduro.

Agradecimento especial a estes contribuidores!

<a href="https://github.com/CX330Blake/black-hat-zig/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CX330Blake/black-hat-zig" />
</a>

## Créditos & Referências

- [Maldev Academy](https://maldevacademy.com/)
- [OffensiveNim](https://github.com/byt3bl33d3r/OffensiveNim)

## Histórico de Estrelas

[![Star History Chart](https://api.star-history.com/svg?repos=CX330blake/black-hat-zig&type=Date)](https://www.star-history.com/#CX330blake/black-hat-zig&Date)

## Aviso Legal

Este projeto é apenas para fins éticos e educacionais. Não seja um criminoso cibernético.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---