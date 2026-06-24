# MonkSynth

[![Build](https://github.com/JonET/monksynth/actions/workflows/build.yml/badge.svg)](https://github.com/JonET/monksynth/actions/workflows/build.yml)
[![Release](https://img.shields.io/github/v/release/JonET/monksynth?include_prereleases)](https://github.com/JonET/monksynth/releases)
[![License](https://img.shields.io/github/license/JonET/monksynth)](LICENSE)

수도승이 노래하는 듯한 소리를 내는 단성 보컬 신디사이저입니다. 고전적인 AudioNerdz(2002)의 [Delay Lama](http://www.audionerdz.nl/) VST 플러그인에서 영감을 받은 포먼트-웨이브-함수(FOF) 합성을 사용하여 제작되었습니다.

**[최신 릴리스 다운로드](https://github.com/JonET/monksynth/releases)** — Windows, macOS, Linux용으로 제공됩니다.

<img src="https://raw.githubusercontent.com/JonET/monksynth/main/docs/screenshot1.png" alt="MonkSynth running in Ableton Live 12 with the classic Delay Lama theme" width="600">

*Ableton Live 12에서 실행 중인 MonkSynth v0.0.1-beta.1, 원본 Delay Lama DLL에서 가져온 고전 테마 적용*

## 기능

- 현실적인 보컬 포먼트를 생성하는 FOF 합성 엔진
- 실시간 피치 및 모음 조절을 위한 XY 패드
- 내장 스테레오 딜레이 이펙트
- MIDI 지원: 노트 온/오프, 피치 휠, CC1(비브라토), CC5(글라이드), CC7(볼륨), CC12(딜레이), CC13(보이스)
- 자동화 가능한 **피치 벤드** 파라미터(±12 반음). 하드웨어 피치 휠은 오른쪽 클릭 → 피치 벤드를 통해 모음(고전 / Delay Lama 호환, 기본값) 또는 피치로 라우팅 가능
- 설정 가능한 어택, 디케이, 서스테인, 릴리스가 있는 ADSR 엔벨로프
- 최대 10개의 디튠 보이스와 보이스 스프레드를 갖춘 유니슨 모드
- 사용자 지정 테마를 위한 오른쪽 클릭 컨텍스트 메뉴가 있는 테마 시스템
- 원본 Delay Lama DLL에서 고전 테마 가져오기
- 5개의 공장 프리셋
- VST3 플러그인 포맷(Windows, macOS, Linux) 및 Audio Unit(macOS)

## 빌드

### 필수 조건

- CMake 3.20 이상
- C/C++ 컴파일러(MSVC, GCC 또는 Clang)

### 빌드

```bash
cd cpp
cmake -B build
cmake --build build --config Release --target MonkSynth
```
VST3 SDK는 CMake에 의해 자동으로 가져옵니다. 빌드된 플러그인은 시스템 VST3 디렉토리에 배치됩니다.

### macOS 오디오 유닛

AU 플러그인도 빌드하려면 [AudioUnit SDK](https://github.com/apple/AudioUnitSDK)를 설치하고 다음과 같이 구성하세요:


```bash
cmake -B build -G Xcode -DSMTG_AUDIOUNIT_SDK_PATH=/path/to/AudioUnitSDK
cmake --build build --config Release --target MonkSynth-au
```
### DSP 단위 테스트

순수 C DSP 레이어(`dsp/`)는 ADSR 엔벨로프 경계, 노트 스택, 유니슨 디튠 수학, 피치 밴드 전파, 딜레이 라인 피드백 안정성을 검사하는 작은 단위 테스트 모음을 포함합니다. 테스트는 선택적이어서 일반 플러그인 빌드에 영향을 미치지 않습니다:


```bash
cd cpp
cmake -B build-tests -DMONKSYNTH_BUILD_TESTS=ON
cmake --build build-tests --config Release
ctest --test-dir build-tests --output-on-failure
```
CI는 각 릴리스 패키징 전에 Linux 작업에서 테스트 스위트를 실행하므로, DSP 회귀가 발생하면 빌드가 차단됩니다.

## 설치

- **macOS:** `.pkg` 설치 프로그램 실행 — VST3 및 AU 플러그인 모두 설치
- **Windows:** `.exe` 설치 프로그램 실행 — VST3 플러그인 설치
- **Linux:** `MonkSynth.vst3`를 추출하여 `~/.vst3/`에 복사

### Linux 호환성

Linux 빌드는 각 릴리스마다 엄격한 로더 시맨틱(Bitwig 스타일 `dlopen(RTLD_NOW)`) 하에서 다음 배포판 계열에서 정상적으로 로드되는지 검증됩니다:

- Ubuntu 22.04 / 24.04 LTS (및 파생판: Linux Mint, Pop!_OS, Elementary, KDE neon)
- Debian 12 (및 파생판: KX Studio, AV Linux, MX Linux)
- Fedora (최신)
- Arch Linux (및 파생판: Manjaro, EndeavourOS, CachyOS)

목록에 없는 배포판도 대체로 작동할 가능성이 높습니다 — 이는 CI에서 누락된 공유 라이브러리 종류의 버그를 잡기 위한 스모크 테스트이지, 완전한 지원 주장이 아닙니다. 플러그인은 Ubuntu 22.04 (glibc 2.35)에서 빌드되었으므로 glibc ≥ 2.35를 사용하는 배포판과 호환되어야 합니다. 다른 배포판의 보고는 [GitHub Issues](https://github.com/JonET/monksynth/issues)를 통해 환영합니다.

## 테마

MonkSynth는 내장 테마 없이 제공됩니다. 처음 실행 시 설정 화면이 나타나며, 여기서 원본 Delay Lama DLL의 클래식 룩을 가져올 수 있습니다(무료로 [audionerdz.nl](http://www.audionerdz.nl/download.htm)에서 제공).

플러그인 GUI에서 오른쪽 클릭을 통해 사용자 정의 테마도 불러올 수 있습니다. 테마 폴더는 `theme.json` 매니페스트와 다음 PNG 파일 조합을 포함합니다(누락된 파일은 1x1 플레이스홀더로 대체):

- `background.png` — 메인 배경 (360x510)
- `monk-strip.png` — 애니메이션 스프라이트 시트 (5x6 그리드, 311x311 프레임)
- `knob-left.png` / `knob-right.png` — 로터리 노브 필름스트립 (50x3000, 60 프레임)
- `fader-down-large.png` / `fader-down-sm.png` / `fader-right-sm.png` — 페이더 핸들
- `info.png` — 정보 오버레이 (253x275)

**플러그인에 기본 제공할 새 테마를 찾고 있습니다.** 자신 있는 테마를 디자인하셨다면 PR을 열어 주세요 — 다음 릴리스에 기여된 테마를 포함하고 싶습니다. 오른쪽 클릭 메뉴에 "Open Themes Folder" 항목이 있어 테마가 저장된 위치를 확인할 수 있습니다.

## 번역

플러그인 UI(설정 화면, 정보 오버레이, 오른쪽 클릭 메뉴, DLL 임포터 오류 메시지)는 영어, 일본어, 한국어로 제공됩니다. 언어는 OS 로케일에서 자동 감지하며, 오른쪽 클릭 → Language에서 수동 변경 가능합니다.

**일본어 및 한국어 번역은 대형 언어 모델이 초안으로 생성하였습니다.** 원어민 기여를 환영합니다 — `cpp/src/strings_ja.h` 또는 `cpp/src/strings_ko.h`를 편집하는 PR을 열어 주세요. 모든 문자열은 `cpp/src/i18n.h`의 `StringId` 열거형으로 인덱싱되어 있으며, 항목 순서를 유지하고 확신이 없는 항목은 빈 문자열로 두어 영어로 대체되도록 해 주세요.


파라미터 이름(DAW의 자동화 레인에 표시되는 이름)은 의도적으로 영어로 유지됩니다 — 튜토리얼, 프리셋, 커뮤니티 토론 모두 영어 이름을 기준으로 합니다.

## 코드 서명 정책

[SignPath.io](https://about.signpath.io/)에서 제공하는 무료 코드 서명, 인증서는 [SignPath Foundation](https://signpath.org/)에서 발급합니다.

Windows VST3 플러그인과 설치 프로그램은 GitHub Actions의 릴리즈 빌드 과정에서 서명됩니다. 서명 요청은 이 저장소에서 빌드된 태그된 릴리즈에 대해서만 SignPath에 제출되며, 각 요청은 인증서 적용 전에 SignPath UI에서 수동으로 승인됩니다.

| 권한 역할       | 서명자 |
|-----------------|--------|
| 작성자          | [Jonathan Taylor](https://github.com/JonET) |
| 검토자          | [Jonathan Taylor](https://github.com/JonET) |
| 승인자          | [Jonathan Taylor](https://github.com/JonET) |

### 개인정보 보호 정책

이 프로그램은 사용자 또는 설치 및 운영자가 명시적으로 요청하지 않는 한 어떤 정보도 다른 네트워크 시스템으로 전송하지 않습니다.

## 감사의 글

- AudioNerdz의 [Delay Lama](http://www.audionerdz.nl/) (2002) — 이 프로젝트에 영감을 준 사랑받는 프리웨어 VST 플러그인
- Xavier Rodet (IRCAM) — 포먼트-웨이브-펑션(FOF) 합성 기법
- Sean Barrett의 [stb_image_write](https://github.com/nothings/stb) — 단일 헤더 이미지 쓰기 라이브러리 (MIT / 퍼블릭 도메인)
- Steinberg의 [VST3 SDK](https://github.com/steinbergmedia/vst3sdk) — 플러그인 프레임워크 (MIT)
- [SignPath Foundation](https://signpath.org/) — 오픈 소스 프로젝트를 위한 무료 Windows 코드 서명

## 라이선스

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---