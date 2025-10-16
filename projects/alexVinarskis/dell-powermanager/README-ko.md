[![Build](https://github.com/alexVinarskis/dell-powermanager/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/alexVinarskis/dell-powermanager/actions/workflows/build.yml)
[![GitHub release (with filter)](https://img.shields.io/github/v/release/alexVinarskis/dell-powermanager?label=Release)](https://github.com/alexVinarskis/dell-powermanager/releases/latest)
![GitHub all releases](https://img.shields.io/github/downloads/alexVinarskis/dell-powermanager/total?label=Downloads)

# Dell Power Manager
크로스 플랫폼 Dell Power Manager를 Flutter로 재구현한 버전입니다. 더 많은 스크린샷은 [Wiki](https://github.com/alexVinarskis/dell-powermanager/wiki)에서 확인할 수 있습니다.

![Screenshot Summary](https://raw.githubusercontent.com/alexVinarskis/dell-powermanager/master/images/screenshot_summary.png)

## 이유
Dell 기기(XPS 및 Precision 시리즈 노트북, 잠재적으로 기타 모델)는 여러 가지 열 프로필, 배터리 충전 임계값 등과 같은 고급 BIOS 내 구성 옵션을 제공합니다. 이러한 설정을 외부에서 조절하는 것이 매우 바람직할 수 있지만, Dell의 독점 도구(운 좋게도 제공됨) 없이는 운영체제에서 이를 구성할 방법이 없습니다. 설정 변경 방법은 다음과 같습니다:
* BIOS 직접 접속, 재부팅 필요
* Windows와 Linux 모두에서 사용할 수 있는 [Dell Command | Configure](https://www.dell.com/support/kbdoc/en-us/000178000/dell-command-configure) CLI, 인상적인 [기능 목록](https://dl.dell.com/topicspdf/command-configure_reference-guide4_en-us.pdf) 포함
* Windows 전용 GUI인 [Dell Power Manager](https://www.dell.com/support/contents/en-au/article/product-support/self-support-knowledgebase/software-and-downloads/dell-power-manager). 게다가 시작 속도가 매우 느리며, (주관적으로) UI가 보기 좋지 않습니다.

이 앱은 Dell Command | Configure CLI 위에 구축된 현대적인 Flutter 기반 GUI로, 주된 목표는 Linux 사용자를 위해 Dell Power Manager의 동작을 복제하는 것이며, Windows에서도 실행됩니다.

## 기능
* 'Dell Command | Configure CLI' (CCTK)를 통한 제어 구현
* 현대적인 애니메이션 UI, 다크 모드 지원
* Dell Windows 앱보다 훨씬 빠른 시작 시간
* 지원되는 기기에서 지원하지 않는 모드 감지 및 처리
* Dell이 아닌 기기 감지 시 오류 메시지 표시
* 보호된 BIOS(시스템/설정/소유자 비밀번호) 및 보안 키 저장 지원

Debian/Ubuntu 기반 Linux 및 Windows용으로 약간 더 제품화됨:
* 통합된 의존성 다운로드 및 설치기
* `.deb`/`.msi` 패키징, 시작 메뉴 바로가기 포함
* Github API를 통한 통합 OTA

제어 기능:
* 배터리 상태 개요 (건강 상태 등)
* 배터리 충전 제어 (현재는 고급/일일 타이밍 모드 미지원)
* 열 프로필 제어
* 운영체제의 전원 모드 감지

예정된 TODO:
* 고급 배터리 충전 제어/스케줄링 ([기능 요청](https://github.com/alexVinarskis/dell-powermanager/issues/24))
* "Peak Shift" 제어 ([기능 요청](https://github.com/alexVinarskis/dell-powermanager/issues/57))

잠재적인 미래 기능 고려 사항:
* CPU 부하에 따라 자동으로 열 프로파일을 전환하는 모니터링 서비스 추가
* 전원 설정(예: 배터리 수준, 플러그 연결/해제 등)에 따라 자동으로 열 프로파일을 전환하는 모니터링 서비스 추가

## 개발 상태
애플리케이션은 현재 **안정적이고 유지 관리 중**인 상태입니다.

* Dell의 CCTK 통합(선택된 OS에 대한 자동 설치 프로그램 포함)
* 업데이트 확인 구현(선택된 OS에 대해 Github API를 통한 OTA 포함)
* UI 테스트 완료, CI를 통한 빌드 및 패키징 검증
* `.msi`, `.deb`, `.tar.xz` 형식으로 패키징. 최신 안정 빌드는 [Releases](https://github.com/alexVinarskis/dell-powermanager/releases/latest)에서, 최신 개발 빌드는 [CI artifacts](https://github.com/alexVinarskis/dell-powermanager/actions/workflows/build.yml?query=branch%3Amaster)에서 확인 가능
* 여러 플랫폼에서 테스트됨, [호환성](#compatibility) 참조. 지원 플랫폼:
    * Windows, x86_64 (네이티브 `.msi`)
    * Windows, arm64 (에뮬레이션에서 실행되는 x86_64 `.msi`)
    * Linux, x86_64 (네이티브 `.deb`, `.tar`)
    * Linux, arm64* (네이티브 `.deb`, `.tar`) _배터리 정보 부분만 작동 - Dell의 CCTK가 arm64용으로 아직 제공되지 않아 실제 제어는 불가(아직?)_
## 소스에서 빌드하기
### Linux
* 의존성 설치:
```
sudo apt-get install -y ninja-build libgtk-3-dev libsqlite3-dev libsecret-1-0 libsecret-1-dev
```
* `flutter run` 명령어로 소스에서 실행, `flutter build linux --release` 명령어로 빌드
* `./package.sh` 스크립트로 `.deb`, `.tar.xz` 패키징

주의: flutter를 `snap`으로 설치하지 마십시오, 대신 [네이티브 설치 방법](https://docs.flutter.dev/get-started/install/linux/desktop)을 사용하세요 - snap으로 제공되는 flutter는 [snap 특유의 문제](https://github.com/juliansteenbakker/flutter_secure_storage/issues/676) 때문에 이 프로젝트에서 컴파일에 실패합니다.

### Windows
* `flutter run` 명령어로 소스에서 실행, `flutter build windows --release` 명령어로 빌드
* `.\package.bat` 스크립트로 `.msi` 패키징

## 기여하기

### 디버깅

기본적으로 모든 로깅이 비활성화되어 있습니다. CLI에서 앱 실행 전에 `POWERMANAGER_DEBUG=true`를 내보내면 로그를 확인할 수 있습니다.  
예: `export POWERMANAGER_DEBUG=true && ./dell-powermanager > file.log`. 이슈를 제기할 때 로그를 저장하여 첨부해 주시기 바랍니다.

### 번역
앱은 Flutter의 지역화 라이브러리를 통해 다국어를 지원합니다. 기여를 원하시면:
* [lib/l10n/*.arb](https://raw.githubusercontent.com/alexVinarskis/dell-powermanager/master/lib/l10n/app_en.arb) 파일을 확인하세요.
* 본인 언어에 맞는 유사한 파일을 생성하고 문자열을 번역하세요.
* 변경 사항을 포함한 PR을 열어 주세요.

## 호환성
다음 장치에서 테스트되었습니다:
* Dell G3 15 3500
    * [Windows 11 24H2 (OS Build 26100.4061)](https://github.com/alexVinarskis/dell-powermanager/issues/65)
* Dell Latitude 5400
    * [Ubuntu 24.04](https://github.com/alexVinarskis/dell-powermanager/issues/56)
* Dell Precision 7560
    * [Fedora 41, 6.12.4](https://github.com/alexVinarskis/dell-powermanager/issues/47)
* Dell XPS 17 9700
    * [Tumbleweed OpenSUSE, 6.7.5](https://github.com/alexVinarskis/dell-powermanager/issues/31)
* Dell XPS 15 9560
    * [Arch Linux, 6.11.6-arch1-1](https://github.com/alexVinarskis/dell-powermanager/issues/46)
* Dell XPS 15 9530 (2023/Fiorano)
    * Ubuntu 23.04, 6.5.0-060500-generic
    * Ubuntu 23.10, 6.5.0-060500-generic
    * Windows 11 Pro 22H2, 22621.2428
* Dell XPS 15 9520
    * [Arch, 6.7.5](https://github.com/alexVinarskis/dell-powermanager/issues/31)
    * Ubuntu 22.04, 6.2.0
    * Windows 11 Home 22H2, 22621.2428
* Dell XPS 13 9345 (Tributo)
    * Ubuntu 24.10, 6.12.0-28-qcom-x1e (배터리 정보만 지원)
    * Windows 11 프로
* Dell XPS 13 9310
    * Ubuntu 22.04.3, 6.2.0-26-generic
    * Windows 10 프로 22H2, 19045.3324
* Dell Vostro 5401
    * [Ubuntu 23.10](https://github.com/alexVinarskis/dell-powermanager/issues/23) 

위에 언급된 장치 중 문제를 경험하셨다면, [**버그 리포트**](https://github.com/alexVinarskis/dell-powermanager/issues/new?template=bug_report.md&title=[BUG])를 열어주시기 바랍니다. 다른 장치에서 테스트하셨다면, [**테스트된 장치**](https://github.com/alexVinarskis/dell-powermanager/issues)로 보고해 주세요.

## 알려진 문제
자세한 내용은 [이슈](https://github.com/alexVinarskis/dell-powermanager/issues)를 참고하세요.
## 크레딧
* 'Dell Command | Configure CLI'를 제공한 Dell에 감사드립니다.
* Flutter를 만든 Google에 감사드립니다 :)

## 면책 조항
라이선스에 따라 이 소프트웨어는 어떠한 보증 없이 있는 그대로 제공됩니다. Dell과 어떤 형태로든 제휴되어 있지 않습니다. 사용은 전적으로 사용자 책임입니다. 저나 다른 기여자는 이 소프트웨어로 인해 발생하는 데이터 손실, 하드웨어 손상, 데이터 유출 등 모든 피해에 대해 책임지지 않습니다. 적용 가능한 경우, 보안 키 저장을 위한 통합 솔루션을 사용하지만, 보안이 보장되지는 않습니다. 사용 전에 위험과 영향을 충분히 이해하시기 바랍니다. 작성자나 기여자에게 법적 청구를 할 수 없습니다.

## 라이선스
이 애플리케이션은 GPLv3 라이선스 하에 배포됩니다. 간단히 말해, 이를 무료로 사용/복사/수정/배포할 수 있지만, 수정한 소스 코드를 제공하고 동일한 라이선스를 유지해야 합니다. 독점 소프트웨어로 판매할 수 없습니다. 자세한 내용은 [LICENSE](LICENSE)를 참조하세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---