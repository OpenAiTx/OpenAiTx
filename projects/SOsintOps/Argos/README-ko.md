# ARGOS — 베타
<img align="right" width="86" height="150" src="https://github.com/SOsintOps/Argos/blob/master/multimedia/images/scribblenauts-argos.png">

> **경고: 베타 버전**
> 이 스크립트는 Ubuntu 24.04 LTS와 Ubuntu Budgie 24.04 LTS용으로 업데이트되었습니다.
> 현재 적극적으로 테스트 중입니다. 사용 전에 항상 깨끗한 VM에서 실행하세요.
> 문제 발생 시 이슈를 열어 보고해 주세요.

Argos는 깨끗한 Ubuntu 24.04 LTS 가상 머신에서 오픈 소스 OSINT 워크스테이션을 자동으로 구성합니다.

최선의 방법은 각 OSINT 조사마다 전용 VM을 사용하는 것입니다.
이 스크립트는 Michael Bazzell의 [Open Source Intelligence Techniques](https://inteltechniques.com/book1.html)에서 설명한 방법을 따릅니다.

## 목차
- [요구 사항](#requirements)
- [도구](#tools)
- [설치](#installation)
- [설치 로그](#installation-log)
- [할 일](#to-do)
- [자료](#resources)
- [크레딧](#credits)
- [라이선스](#licences)
- [버전 기록](https://raw.githubusercontent.com/SOsintOps/Argos/master/docs/VERSION_HISTORY.md)
- [OSINT 분석 가이드라인](https://raw.githubusercontent.com/SOsintOps/Argos/master/docs/guidelines.md)
- [자주 묻는 질문](https://raw.githubusercontent.com/SOsintOps/Argos/master/docs/faq.md)

---

## 요구 사항

- Ubuntu **24.04 LTS** 또는 **Ubuntu Budgie 24.04 LTS** (VM 또는 워크스테이션)
- 임의의 Linux 사용자명 (이전의 `osint` 사용자명 요구 사항은 제거됨)
- 시스템 언어: **영어**
- 설치 중 활성 인터넷 연결
- **VirtualBox Guest Additions가 이미 설치되어 있어야 함** — 스크립트는 이를 설치하지 않습니다. 클립보드 공유, 드래그 앤 드롭, 전체 화면 지원을 활성화하려면 `setup.sh` 실행 전에 Guest Additions를 설치하세요.

> 이 스크립트는 VirtualBox에 최적화되어 있습니다. VMware Tools용 코드는 주석에 있습니다.

**테스트 환경:**
- Ubuntu Budgie 24.04 LTS (VM)
- Ubuntu 24.04 LTS (VM)

**더 이상 지원되지 않음:**
- Ubuntu 22.04 LTS (일부 종속성 호환 불가)
- Ubuntu 20.04 LTS

---

## 도구

### OSINT

| 도구 | 상태 | 비고 |
|------|--------|-------|
| [Amass](https://github.com/owasp-amass/amass) | 활성 | 서브도메인 열거 |
| [Instaloader](https://instaloader.github.io/) | 활성 | 인스타그램 OSINT |
| [Toutatis](https://github.com/megadose/toutatis) | 제한적 | 인스타그램 세션 ID 필요 |
| [HTTrack](https://www.httrack.com/) | 활성 | 웹 크롤링 및 미러링 |
| [MediaInfo](https://mediaarea.net/en/MediaInfo) | 활성 | 미디어 메타데이터 분석 |
| [ExifTool](https://exiftool.org/) | 활성 | 문서 및 이미지 메타데이터 |
| [EyeWitness](https://github.com/FortyNorthSecurity/EyeWitness) | 활성 | 웹사이트 스크린샷 |
| [The Harvester](https://github.com/laramies/theHarvester) | 활성 | 이메일 및 도메인 정찰 |
| [Metagoofil](https://github.com/opsdisk/metagoofil) | 활성 | 공개 문서 메타데이터 |
| [recon-ng](https://github.com/lanmaster53/recon-ng) | 활성 | 모듈식 OSINT 프레임워크 |
| [Sherlock](https://github.com/sherlock-project/sherlock) | 활성 | 사용자 이름 검색 |
| [SpiderFoot](https://github.com/smicallef/spiderfoot) | 활성 | OSINT 자동화 |
| [blackbird](https://github.com/p1ngul1n0/blackbird) | 활성 | 고급 사용자 이름 검색 |
| [holehe](https://github.com/megadose/holehe) | 활성 | 이메일 OSINT |
| [maigret](https://github.com/soxoj/maigret) | 활성 | 사용자 이름 검색 (고급 Sherlock 포크) |
| [Maltego](https://www.maltego.com/) | 활성 | 링크 분석 (계정 필요) |
| [yt-dlp](https://github.com/yt-dlp/yt-dlp) | 활성 | 비디오 다운로더 (youtube-dl 대체) |

**제거된 도구 (중단 또는 폐기):**
- ~~Instalooter~~: Instaloader 사용
- ~~Sublist3r~~: Amass 사용
- ~~Photon~~: Katana 또는 GoSpider 사용
- ~~youtube-dl~~: yt-dlp로 대체
- ~~Moriarty-Project~~: PhoneInfoga 사용
- ~~Elasticsearch-Crawler~~: Shodan CLI 사용
- ~~Atom Editor~~ (2022년 12월 중단): VSCodium으로 대체
### 일반 도구

| 도구 | 상태 |
|------|--------|
| [VLC](https://www.videolan.org/vlc/) | 활성 |
| [Google Earth Pro](https://www.google.com/earth/versions/#earth-pro) | 활성 |
| [VSCodium](https://vscodium.com/) | 활성 (Atom 대체) |
| [CherryTree](https://www.giuspen.com/cherrytree/) | 활성 |
| [KeePassXC](https://keepassxc.org/) | 활성 |
| [Kazam](https://launchpad.net/kazam) | 활성 |
| [Audacity](https://www.audacityteam.org/) | 활성 |
| [Tor Browser](https://www.torproject.org/) | 활성 |
| [OpenShot](https://www.openshot.org/) | 활성 |
| [Obsidian](https://obsidian.md/) | 활성 (최신 버전 동적 가져오기) |
| [Ripgrep](https://github.com/BurntSushi/ripgrep) | 활성 |
| [Threat Intelligence Resources](https://github.com/pstirparo/threatintel-resources) | 활성 |

---

## 설치

1. 터미널을 엽니다.

2. Git이 설치되어 있지 않으면 설치합니다:

    ```bash
    sudo apt install -y git
    ```

3. 저장소를 `Downloads` 디렉터리에 클론합니다:
    ```bash
    git clone https://github.com/SOsintOps/Argos ~/Downloads/Argos
    ```

4. 스크립트를 실행 가능하게 만드세요:
    ```bash
    chmod +x ~/Downloads/Argos/setup.sh
    ```

5. 스크립트를 실행합니다:
    ```bash
    ~/Downloads/Argos/setup.sh
    ```

    > Firefox는 수동으로 닫거나 열 필요가 없습니다. 스크립트는 아직 생성되지 않은 경우 Firefox 프로필을 자동으로 초기화합니다.

---

## 설치 로그

스크립트는 다운로드 디렉터리에 로그 파일을 자동으로 생성합니다:

```
~/Downloads/argos_install_YYYYMMDD_HHMMSS.log
```
로그에는 타임스탬프와 함께 전체 설치 출력이 포함되어 있습니다. 오류가 발생하면 로그에 정확한 행 번호가 기록됩니다.

---

## 할 일

- Moriarty-Project를 대체할 PhoneInfoga 추가
- Photon을 대체할 Katana 또는 GoSpider 추가
- OSINT 조사용 LibreOffice 보고서 템플릿 업데이트
- Ubuntu Budgie 24.04 LTS VM에서 종단 간 테스트 완료
- holehe, maigret 독립 실행형, blackbird 독립 실행형에 대한 바로 가기 추가

---

## 자료

- [OSIntOps 웹사이트](https://osintops.com/en/)
- [Argos 프로젝트 발표 (이탈리아어)](https://osintops.com/progetto-argos/)
- [OSInt 데일리 뉴스](https://t.me/Osintlatestnews)
- [Michael Bazzell의 오픈 소스 인텔리전스 기법](https://inteltechniques.com/book1.html)

---

## 크레딧

- 원본 OSINT_VM_Setup 스크립트의 Skykn0t
- 스크립트 이름 제공자 [oh6hay](https://github.com/oh6hay)
- 배경화면 스크립트 제공자 [pinkevilpimp](https://github.com/pinkevilpimp)

---

## 라이선스

저장소에 포함된 라이선스 파일을 참조하세요.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-21

---