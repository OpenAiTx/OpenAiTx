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
  <b>안녕하세요, 해커 여러분. 안녕하세요, 악성코드 개발자 여러분. 안녕하세요, 리버서 여러분. Zig의 어두운 힘을 탐구하기 위해 여기 오신 여러분을 환영합니다!</b><br/><br/>
  <b>유지 및 관리: <a href="https://github.com/cx330blake">@CX330Blake</a></b>
</p>

---

## 목차

- [소개](#intro)
- [왜 Zig인가?](#why-zig)
- [코드 컴파일하기](#compiling-the-codes)
- [페이로드 배치](#payload-placement)
- [페이로드 난독화](#payload-obfuscation)
- [페이로드 암호화](#payload-encryption)
- [페이로드 실행](#payload-execution)
- [리버스 셸](#reverse-shell)
- [악성코드 기법](#malware-techniques)
- [Maldev 도구](#maldev-tools)
- [기여자](#contributors)
- [감사의 글 & 참고자료](#credits--references)
- [스타 히스토리](#star-history)
- [면책 조항](#disclaimer)

## 소개

> [!IMPORTANT]
> 이 프로젝트는 지속적으로 업데이트되고 있습니다!

이 프로젝트는 제가 Zig의 열렬한 팬이기 때문에 Zig를 이용한 다양한 악성코드 기법의 구현을 제공합니다. 이 저장소를 사용하여 Zig를 무기로 삼을 수 있습니다. Black-Hat-Zig는 가능한 한 많은 내용을 담기 위해 지속적으로 업데이트되고 있습니다. 이 프로젝트에 PR을 생성해주시면 완벽할 것입니다.

자, 이제 세상을 해킹해봅시다!

## 왜 Zig인가?

- 🤝 C/C++ 소스와 쉽게 상호작용 가능
- 🔎 새롭기 때문에 탐지가 더 어렵다
- 💪 매우 저수준의 제어, C보다도 더 낮은 수준
- 😱 최신 컴파일러 덕분에 리버스 엔지니어링이 더 어렵다
- 🛡️ 최소한의 런타임 의존성 - 방대한 표준 라이브러리의 부담 없음
- 🎯 정의되지 않은 동작 없음 - 경계 케이스를 명시적으로 처리하여 충돌 방지

## 코드 컴파일하기

각 디렉터리 안의 코드를 확인할 수 있습니다. 또한 코드에서 Windows API를 사용하는 경우, 해당 프로젝트 디렉터리의 `README.md`에서 힌트를 확인할 수 있습니다. 예를 들어, [이 예시](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/)를 참고하세요.

Windows API가 필요한 경우, 기본 빌드 타겟이 이미 `windows-x86_64`로 설정되어 있으므로, Linux, Windows, MacOS 어디서나 아래 명령어를 복사하여 붙여넣으면 쉽게 코드를 컴파일할 수 있습니다! (단, 실행 파일을 실행하려면 Windows 환경이 필요합니다)

```bash
zig build
```

## 페이로드 배치

실행 파일의 다양한 섹션에 악성 페이로드를 배치하는 기법입니다.

- [.data 섹션](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_data_section/)
- [.rdata 섹션](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rdata_section/)
- [.text 섹션](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_text_section/)
- [.rsrc 섹션](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rsrc_section/)

## 페이로드 난독화

페이로드를 위장하거나 정적 분석 또는 패턴 매칭을 통해 탐지되는 것을 방지하는 난독화 기법입니다.

- [IP 주소 난독화](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/)
  - [IPv4 난독화](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_obfuscation/)
  - [IPv4 복호화](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_deobfuscation/)
  - [IPv6 난독화](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_obfuscation/)
  - [IPv6 복호화](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_deobfuscation/)
- [MAC 주소 난독화](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/)
  - [MAC 주소 난독화](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACFuscation/)
  - [MAC 주소 복호화](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACDeobfuscation/)
- [UUID 난독화](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/)
  - [UUID 난독화](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDFuscation/)
  - [UUID 복호화](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDDeobfuscation/)

## 페이로드 암호화

페이로드의 실제 의도를 저장 또는 전송 중 숨기기 위해 사용되는 다양한 암호화 기법입니다.

- [XOR 암호화](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/)
  - [표준 라이브러리 XOR](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/std_lib_xor/)
- [RC4 암호화](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/)
  - [SystemFunction032을 이용한 RC4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/system_function_032_rc4/)
- [AES 암호화](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/)
  - [Bcrypt.h를 이용한 AES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/)
  - [표준 라이브러리를 이용한 AES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/std_aes/)
  - [TinyAES를 이용한 AES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/tiny_aes/)

## 페이로드 실행

- [DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/dll/)
- [쉘코드](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/shellcode/)

## 리버스 셸

C2 접근이나 사후 침투 제어를 위한 리버스 셸 구현 방법입니다.

- [표준 라이브러리를 이용한 리버스 셸](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Reverse-Shell/std_reverse_shell/)

## 악성코드 기법

Zig에 맞게 적용된 일반적인 공격 무역 기술들의 모음입니다.

- [프로세스 인젝션](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/)
  - [DLL 인젝션](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/dll_injection/)
  - [쉘코드 인젝션](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/shellcode_injection/)
- [페이로드 스테이징](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/)
  - [웹 서버로부터](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/web_server/)
  - [Windows 레지스트리로부터](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/windows_registry/)
- [프로세스 열거](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/)
  - [CreateToolhelp32Snapshot 사용](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/create_tool_help_32_snapshot/)
  - [EnumProcesses 사용](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/enum_processes/)
  - [NtQuerySystemInformation 사용](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/nt_query_system_information/)

## Maldev 도구

- [ZYRA: Your Runtime Armor](https://github.com/cx330blake/zyra)
  - Zig로 작성된 실행 파일 패커
- [ZYPE: Your Payload Encryptor](https://github.com/cx330blake/zype)
  - 암호화/난독화된 페이로드와 해당 복호/복원 함수가 포함된 Zig 코드 템플릿 생성

## 기여자

이 프로젝트는 주로 [@CX330Blake](https://github.com/CX330Blake)가 유지 및 관리합니다. PR 환영합니다. 더 많은 분들이 Zig로 악성코드 개발을 하셔서 생태계가 더 성숙해지기를 바랍니다.

기여해주신 모든 분들께 큰 감사를 드립니다!

<a href="https://github.com/CX330Blake/black-hat-zig/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CX330Blake/black-hat-zig" />
</a>

## 감사의 글 & 참고자료

- [Maldev Academy](https://maldevacademy.com/)
- [OffensiveNim](https://github.com/byt3bl33d3r/OffensiveNim)

## 스타 히스토리

[![Star History Chart](https://api.star-history.com/svg?repos=CX330blake/black-hat-zig&type=Date)](https://www.star-history.com/#CX330blake/black-hat-zig&Date)

## 면책 조항

이 프로젝트는 윤리적 및 교육적 목적으로만 제공됩니다. 사이버 범죄자가 되지 마십시오.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---