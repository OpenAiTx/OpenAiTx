<details align="right">
<summary>🌐 언어</summary>

[English](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=th) | [Français](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=de) | [Español](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=it) | [Русский](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ru) | [Português](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=as)
</details>

# OnionHoster v2.2

> **궁극의 토르 히든 서비스 호스팅 툴** - 웹 프로젝트를 몇 분 만에 다크웹에 배포하세요!
> 
[![Version](https://img.shields.io/badge/version-2.2-brightgreen.svg)](https://github.com/BlackHatDevX/onionhoster)
[![Platform](https://img.shields.io/badge/platform-Linux%20%7C%20macOS-blue.svg)](https://github.com/BlackHatDevX/onionhoster)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](https://github.com/BlackHatDevX/onionhoster)

<img width="1023" height="551" alt="ChatGPT Image Aug 27, 2025, 03_32_08 PM (1)-modified" src="https://github.com/user-attachments/assets/92b6e834-2d4f-4cc7-8f77-82b9bafba8a5" />


---

## 🚀 OnionHoster란?

OnionHoster는 강력한 크로스 플랫폼 bash 스크립트로, 단 한 번의 명령으로 어떤 웹 프로젝트든 토르 히든 서비스로 변환합니다. Next.js 앱, Flask 백엔드, 정적 웹사이트 등 어떤 프로젝트든 OnionHoster가 복잡한 토르 설정을 자동으로 처리해줍니다.

### ✨ OnionHoster를 선택하는 이유는?

- **🔧 무설정** - 모든 웹 프로젝트에서 즉시 동작
- **🌍 크로스 플랫폼** - Linux, macOS 및 주요 배포판 지원
- **⚡ 원클릭 설치** - 2분 내에 히든 서비스 구축
- **🔄 자동 업데이트** - 내장 업데이트 검사기로 최신 상태 유지
- **💾 백업 & 복구** - onion 주소를 절대 잃지 마세요
- **🎯 전문 UI** - 아름다운 컬러 인터페이스와 직관적 메뉴

---
## 미리보기

[![IMAGE ALT TEXT HERE](https://github.com/user-attachments/assets/4b35dfb0-0059-4cc5-99c7-a5b9467a385d)](https://www.youtube.com/watch?v=oPvhA54Tp8w)


# ⚠️ 경고: OnionHoster는 마법의 익명화 도구가 아닙니다 — 최선의 보안 수칙을 따르지 않으면 신원이 노출될 수 있습니다

**시스템 강화**

* 격리를 위해 서비스는 VM 또는 컨테이너에서 실행하세요.

* OS와 패키지를 최신 상태로 유지하세요.
* 불필요한 서비스/포트를 비활성화하여 Tor 트래픽만 입출력되도록 하세요.

**OpSec 실천법**

* 개인 계정이나 활동에 동일한 머신을 사용하지 마세요.
* 식별 가능한 메타데이터(파일명, 헤더, 에러 메시지) 노출을 피하세요.
* 로그 관리에 유의하세요 — 어떤 로그를 남기는지, 얼마나 오래 보관하는지, 정보가 유출되는지 여부를 확인하세요.

**네트워크 위생**

* 히든 서비스를 클리어넷 신원이나 도메인과 연결하지 마세요.
* 방화벽을 사용해 Tor 외부로의 우발적 유출을 방지하세요.
* 추가적인 분리를 위해 리버스 프록시를 고려하세요.

**테스트 및 모니터링**

* torsocks 또는 Tor 브라우저를 사용해 서비스가 `.onion` 주소로만 접근 가능한지 검증하세요.
* 정기적으로 유출 여부를 테스트하세요 (예: 앱이 클리어넷에서 데이터를 가져오려는지 여부).

**사용 사례 인식**

* 취미/테스트/교육용: 위 방법으로 대부분 충분합니다.
* 고위험, 실제 익명성이 요구되는 경우(언론인, 내부고발자, 활동가): 더 깊은 운영 보안과 위협 모델링이 필요하며, 한 번의 실수가 신원 노출로 이어질 수 있습니다.


---
## 🎯 적합 대상

- Tor에서 앱을 테스트하려는 **개발자**
- 익명 서비스를 운영하는 **프라이버시 옹호자**
- 다크웹 기술을 연구하는 **연구자**
- 익명 호스팅 솔루션이 필요한 **기업**
- Tor 네트워크를 탐험하는 **취미 사용자**

---

## 🚀 빠른 시작

### 사전 준비
- 루트/sudo 권한
- 인터넷 연결
- 웹 프로젝트(HTML, Next.js, Flask 등)

### 설치 및 사용법

```bash
# 1. Clone the repository
git clone https://github.com/BlackHatDevX/onionhoster.git

# 2. Navigate to the directory
cd onionhoster

# 3. Make the script executable
chmod +x onionhoster.sh

# 4. Run with sudo
sudo bash onionhoster.sh
```
**그게 다입니다!** 🎉

완전한 OnionHoster 프로젝트를 받게 됩니다:
- 주요 `onionhoster.sh` 스크립트
- 호스팅용 전문적인 `index.html` 템플릿
- 모든 문서와 예제

스크립트는 자동으로:
- 운영 체제를 감지합니다
- 필요한 모든 종속성 설치(Tor, Apache 등)
- Tor 서비스 구성
- 직관적인 메뉴를 제공합니다

---

## 🎮 기능 개요

### 🌐 호스팅 옵션
- **정적 HTML** - 어떤 `index.html` 파일도 호스팅 가능
- **포트 포워딩** - 로컬 애플리케이션 포트로 전달
- **동적 앱** - Next.js, Flask, Node.js 등 지원

### 🛠️ 관리 도구
- **서비스 제어** - 히든 서비스 시작, 중지 및 관리
- **백업 & 복원** - 안전하게 onion 도메인 백업 및 복원
- **URL 새로 고침** - 필요 시 새로운 onion 주소 생성
- **상태 모니터링** - 서비스 상태 및 건강 확인

### 🔄 스마트 업데이트
- **자동 감지** - 최신 버전 자동 탐색
- **원클릭 업데이트** - 메뉴 옵션 하나로 업데이트
- **안전한 업데이트** - 구성 손실 위험 없음

---

## 📱 지원 운영 체제

| 운영 체제 | 패키지 관리자 | 상태 |
|----|----------------|---------|

| **Ubuntu/Debian** | `apt-get` | ✅ 완전 지원 |
| **CentOS/RHEL** | `yum` | ✅ 완전 지원 |
| **Fedora** | `dnf` | ✅ 완전 지원 |
| **Arch Linux** | `pacman` | ✅ 완전 지원 |
| **macOS** | `brew` | ✅ 완전 지원 |

---

## 🎯 사용 사례

### 🏠 개인 프로젝트
- 포트폴리오 익명으로 호스팅하기
- 웹 애플리케이션 비공개로 테스트하기
- 신원 노출 없이 콘텐츠 공유하기

### 🏢 비즈니스 애플리케이션
- 익명 고객 지원 포털
- 안전한 내부 통신 시스템
- 프라이버시 중심 비즈니스 웹사이트

### 🔬 연구 및 개발
- 다크웹 기술 연구
- 프라이버시 도구 개발
- 익명 서비스 테스트

---

## 📖 상세 사용법

### 메인 메뉴 옵션

1. **index.html 호스팅** - 정적 HTML 파일 제공
2. **애플리케이션 포트 포워딩** - 로컬 서비스 프록시
3. **tor 도메인 백업** - onion 설정 저장
4. **tor 도메인 복원** - 백업에서 복원
5. **현재 tor 도메인 보기** - 활성 onion 주소 확인
6. **tor 도메인 갱신** - 새 onion 주소 생성
7. **업데이트 확인** - 최신 버전으로 업데이트
8. **웹 서버 상태** - 서비스 상태 모니터링
9. **OnionHoster 정보** - 버전 및 기능 정보
### 예제 작업 흐름


```bash
# Start the service
sudo ./onionhoster.sh

# Choose option 1 to host index.html
# Your onion address will be displayed
# Access it via Tor Browser or similar
```

---

## 🔧 고급 설정

### 사용자 정의 포트 포워딩
```bash
# Forward your Next.js app running on port 3000
# The script will handle all Tor configuration automatically
```

### 백업 관리
```bash
# Automatic backups are stored in ~/onion_backups/
# Each backup includes your onion keys and configuration
```

---

## 🛡️ 보안 기능

- **자동 Tor 구성** - 기본적으로 안전한 설정 제공
- **적절한 파일 권한** - 안전한 파일 소유권 및 접근 제어
- **서비스 격리** - 각 숨겨진 서비스는 독립적으로 실행
- **데이터 로그 없음** - 사용자의 활동은 비공개로 유지

---

## 🚨 중요 사항

- **루트 접근 권한 필요** - Tor 서비스는 시스템 수준 구성 필요
- **Tor 네트워크** - 서비스는 Tor 브라우저를 통해 접근 가능
- **어니언 주소** - 각 서비스는 고유한 `.onion` 주소 부여
- **정기적 백업 권장** - 어니언 주소는 갱신 시 변경됨

---

## 🤝 기여하기

기여를 환영합니다! 다음과 같은 경우:
- 🐛 버그 리포트
- 💡 기능 요청
- 📝 문서 개선
- 🔧 코드 기여

**시작 방법:**
1. 저장소를 포크하세요
2. 기능 브랜치를 만드세요
3. 변경사항을 적용하세요
4. 풀 리퀘스트를 제출하세요

---

## 📄 라이선스

이 프로젝트는 MIT 라이선스 하에 배포됩니다 - 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

---

## 🙏 감사의 말

- **Tor 프로젝트** - 놀라운 익명 네트워크에 감사드립니다
- **오픈 소스 커뮤니티** - 지속적인 개선에 감사드립니다
- **사용자 및 기여자** - 피드백과 제안에 감사드립니다

---

## 🔗 링크

- **GitHub**: [https://github.com/BlackHatDevX/onionhoster](https://github.com/BlackHatDevX/onionhoster)
- **이슈**: [https://github.com/BlackHatDevX/onionhoster/issues](https://github.com/BlackHatDevX/onionhoster/issues)
- **토론**: [https://github.com/BlackHatDevX/onionhoster/discussions](https://github.com/BlackHatDevX/onionhoster/discussions)

---

## ⭐ 이 프로젝트에 별 주기

OnionHoster가 도움이 되었다면 별을 주세요! 이는 저희가 계속 개선하도록 동기를 부여하고 다른 사람들이 이 도구를 발견하는 데 도움이 됩니다.

---

**익명으로 시작할 준비가 되셨나요?** 🕵️‍♂️

```bash
git clone https://github.com/BlackHatDevX/onionhoster.git
cd onionhoster
sudo bash onionhoster.sh
```
*익명 호스팅 여정이 지금 시작됩니다!* 🚀



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---