# 코발트 스트라이크 리눅스 비콘

C로 작성된 개념 증명용 맞춤형 리눅스 비콘으로, HTTP/S 프로토콜을 사용하여 코발트 스트라이크 팀서버와 통신합니다.

이 프로젝트의 목표는 완전한 기능을 갖춘 임플란트가 되는 것이 아니며, 리눅스에만 국한되지도 않습니다. 코발트 스트라이크를 위한 맞춤형 임플란트를 어떤 플랫폼에서도 만들 수 있다는 것을 보여주는 것입니다. 유일한 요구 사항은 팀서버와 올바르게 통신하는 것입니다.

맞춤형 임플란트를 사용하면 맞춤 동작 정의, 새로운 기능 추가, 다양한 플랫폼 및 파일 형식 지원, 컴파일 시 난독화 적용 등 무한한 가능성이 있습니다.

언젠가 코발트 스트라이크가 공식적으로 맞춤형 비콘 개발을 지원하여 더 많은 문서와 사용 편의 기능을 추가하길 희망합니다.


## 기능
- HTTP/S 리스너 지원 (기본 C2 프로필)
- 내장 명령어 포함: `sleep`, `cd`, `pwd`, `shell`, `ls`, `exit`, `upload`, `download`
- TrustedSec의 ELFLoader를 사용한 리눅스 BOF 실행. TrustedSec 및 Outflank BOF 모두 지원
- SOCKS 프록시

## 데모
Aggressor 스크립트로 페이로드 생성
![리눅스 비콘 페이로드 생성](https://raw.githubusercontent.com/EricEsquivel/CobaltStrike-Linux-Beacon/main/demo/generate_payloads.gif)

리눅스 비콘에서 명령어 및 BOF 실행
![리눅스 비콘 명령어 데모](https://raw.githubusercontent.com/EricEsquivel/CobaltStrike-Linux-Beacon/main/demo/commands.gif)

## 설치
[SETUP](https://raw.githubusercontent.com/EricEsquivel/CobaltStrike-Linux-Beacon/main/SETUP.md) 파일에서 설치 단계를 확인할 수 있습니다.

## 특별 감사
BOF 실행 통합과 임플란트 테스트에 도움을 주신 [Kyle Avery](https://x.com/kyleavery)께 감사드립니다.

## 향후 목표
* 맞춤형 C2 프로필 지원 추가
* TCP 리스너 및 연결 기능 추가
* 버그 수정 지속

## 자료
- 코발트 스트라이크 (와우!)
- [TrustedSec의 ELFLoader 및 BOF](https://github.com/trustedsec/ELFLoader)
- [Outflank의 BOF](https://github.com/outflanknl/nix_bof_template)
- [PaloAltoNetworks Unit42](https://unit42.paloaltonetworks.com/cobalt-strike-metadata-encryption-decryption/)
- [SANS ISC](https://isc.sans.edu/diary/27968)
- [cs-decrypt-metadata-py](https://blog.didierstevens.com/2021/10/22/new-tool-cs-decrypt-metadata-py/)
- [SentinelOne CobaltStrikeParser](https://github.com/Sentinel-One/CobaltStrikeParser)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-27

---