# 프로젝트 소개
<div align="center">

# ![logo3](https://github.com/user-attachments/assets/8d1a37bd-5955-4dc2-b314-aecb04f985dc)

**게임 서버의 배포, 관리 및 유지보수를 간편하고 효율적으로 만듭니다**

[![GitHub Stars](https://badgen.net/github/stars/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/stargazers)
[![GitHub Release](https://badgen.net/github/release/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/releases)
[![Docker Pulls](https://badgen.net/docker/pulls/xiaozhu674/gameservermanager)](https://hub.docker.com/r/xiaozhu674/gameservermanager)
[![License](https://badgen.net/github/license/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/blob/main/LICENSE)

[📖 문서 사이트](http://blogpage.xiaozhuhouses.asia/html6/index.html#/) • [🌐 공식 웹사이트](http://blogpage.xiaozhuhouses.asia/html5/index.html) • [💬 QQ 그룹](https://qm.qq.com/q/oNd4HvMj6M)

</div>

---

## 📋 프로젝트 개요

GameServerManager(약칭 GSManager)는 **Docker** 기술을 기반으로 한 현대적인 게임 서버 관리 플랫폼으로, 게임 서버의 배포, 관리 및 유지보수를 간소화하기 위해 설계되었습니다.

### ✨ 핵심 기능

- 🐳 **Docker 컨테이너화** - 완전히 Docker 기반으로 실행, 환경 격리, 뛰어난 호환성
- 🎯 **원클릭 배포** - 다양한 인기 게임의 신속한 배포 지원
- 🌐 **웹 관리 인터페이스** - 현대적인 React 프론트엔드, 직관적이고 사용이 쉬움
- 🔧 **실시간 터미널** - 내장 웹 터미널, 실시간 명령 실행 지원
- 📊 **리소스 모니터링** - 서버 리소스 사용 현황 실시간 모니터링
- 🔐 **권한 관리** - 완비된 사용자 인증 및 권한 제어 시스템
- 🎮 **다중 게임 지원** - Steam 플랫폼의 다양한 인기 게임 서버 지원
- 💾 **데이터 영속성** - 게임 데이터 및 설정 파일 외부 매핑, 안전하고 신뢰성 높음

![컨테이너 정보 패널](http://images.server.xiaozhuhouses.asia:40061/i/2025/06/09/wbnc63.png)

---

## 🚀 빠른 시작

### 원클릭 설치 스크립트

```bash
rm -f install.py && wget http://blogpage.xiaozhuhouses.asia/api/api1/install.py && python3 install.py
```
> debian(Docker는 별도 설치) 및 centos는 수동 설치를 권장합니다. 자세한 내용은 문서 사이트 참고

---

## 🎮 지원 게임 목록

| 게임 이름 | 한글명 | Steam ID | 익명 다운로드 | 상태 |
|---------|--------|----------|----------|------|
| **인기 게임** | | | | |
| Palworld | 환수 파루 | 2394010 | ✅ | 🟢 완전 지원 |
| Rust | 러스트 | 258550 | ✅ | 🟢 완전 지원 |
| Satisfactory | 새티스팩토리 | 1690800 | ✅ | 🟢 완전 지원 |
| Valheim | 발하임 | 896660 | ✅ | 🟢 완전 지원 |
| 7 Days to Die | 세븐데이즈 투 다이 | 294420 | ✅ | 🟢 완전 지원 |
| Project Zomboid | 프로젝트 좀보이드 | 380870 | ✅ | 🟢 완전 지원 |
| ARK: Survival Evolved | 아크: 서바이벌 이볼브드 | 376030 | ✅ | 🟢 완전 지원 |
| **슈팅 게임** | | | | |
| Left 4 Dead 2 | 레프트 4 데드 2 | 222860 | ❌ | 🟡 정품 필요 |
| Team Fortress 2 | 팀 포트리스 2 | 232250 | ✅ | 🟢 완전 지원 |
| Squad | 스쿼드 | 403240 | ✅ | 🟢 완전 지원 |
| Insurgency: Sandstorm | 인서전시: 샌드스톰 | 581330 | ✅ | 🟢 완전 지원 |
| Killing Floor 2 | 킬링 플로어 2 | 232130 | ✅ | 🟢 완전 지원 |
| Insurgency (2014) | 인서전시 2 | 237410 | ✅ | 🟢 완전 지원 |
| MORDHAU | 모르드하우 | 629800 | ✅ | 🟢 완전 지원 |
| No More Room in Hell | 노 모어 룸 인 헬 | 317670 | ✅ | 🟢 완전 지원 |
| Fistful of Frags | Fistful of Frags | 295230 | ✅ | 🟢 완전 지원 |
| Half-Life | 하프라이프 | 90 | ✅ | 🟢 완전 지원 |
| Half-Life 2: Deathmatch | 하프라이프 2 | 232370 | ✅ | 🟢 완전 지원 |
| Operation: Harsh Doorstop | 작전명: 하쉬 도어스탑 | 950900 | ✅ | 🟢 완전 지원 |
| Vox Machinae | 복스 마키나이 | 944490 | ✅ | 🟡 설정 필요 |
| **인디 게임** | | | | |
| Unturned | 언턴드 | 1110390 | ✅ | 🟢 완전 지원 |
| Don't Starve Together | 돈스타브 투게더 | 343050 | ✅ | 🟡 설정 필요 |
| Last Oasis | 라스트 오아시스 | 920720 | ✅ | 🟢 완전 지원 |
| Hurtworld | 허트월드 | 405100 | ✅ | 🟢 완전 지원 |
| Soulmask | 소울마스크 | 3017300 | ✅ | 🟢 완전 지원 |
| **시뮬레이션 게임** | | | | |
| Euro Truck Simulator 2 | 유로 트럭 시뮬레이터 2 | 1948160 | ✅ | 🟡 설정 필요 |
| American Truck Simulator | 아메리칸 트럭 시뮬레이터 | 2239530 | ✅ | 🟡 설정 필요 |
| ECO | 에코 | 739590 | ✅ | 🟡 설정 필요 |

> 더 많은 게임이 지속적으로 추가되고 있습니다...

---

## 🏗️ 기술 아키텍처

### 프론트엔드 기술 스택
- **React 18** - 현대적인 프론트엔드 프레임워크
- **Ant Design** - 엔터프라이즈급 UI 컴포넌트 라이브러리
- **Monaco Editor** - 코드 에디터
- **Xterm.js** - 웹 터미널 에뮬레이터
- **Vite** - 빠른 빌드 도구

### 백엔드 기술 스택
- **Python 3.13** - 주요 개발 언어
- **Flask** - 웹 프레임워크
- **Gunicorn** - WSGI 서버
- **Docker** - 컨테이너화 기술
- **SteamCMD** - Steam 명령행 도구
- **Aria2** - 다중 프로토콜 다운로드 관리자

---

## 📁 프로젝트 구조

```
GameServerManager/
├── app/                    # 프론트엔드 애플리케이션
│   ├── src/               # React 소스 코드
│   ├── public/            # 정적 리소스
│   └── package.json       # 프론트엔드 의존성
├── server/                # 백엔드 서비스
│   ├── api_server.py      # 주요 API 서버
│   ├── game_installer.py  # 게임 설치기
│   ├── pty_manager.py     # 터미널 관리자
│   ├── auth_middleware.py # 인증 미들웨어
│   └── installgame.json   # 게임 설정 파일
├── docker-compose.yml     # Docker 오케스트레이션 파일
├── Dockerfile            # Docker 이미지 빌드 파일
└── README.md             # 프로젝트 설명 문서
```

---

## 🔧 설정 설명

### 포트 설정
- **5000** - 웹 관리 인터페이스
- **27015-27020** - Steam 게임 서버 포트 범위

### 데이터 볼륨 매핑
- `./game_data` → `/home/steam/games` - 게임 데이터 디렉터리
- `./game_file` → `/home/steam/.config` - 게임 설정 디렉터리
- `./game_file` → `/home/steam/.local` - 게임 저장 디렉터리

### 환경 변수
- `TZ=Asia/Shanghai` - 타임존 설정
- `USE_GUNICORN=true` - Gunicorn 활성화
- `GUNICORN_TIMEOUT=120` - 요청 타임아웃
- `GUNICORN_PORT=5000` - 서비스 포트

---

## 🤝 기여 가이드

모든 형태의 기여를 환영합니다!

1. **Fork** 본 프로젝트
2. 기능 브랜치 생성 (`git checkout -b feature/AmazingFeature`)
3. 변경사항 커밋 (`git commit -m 'Add some AmazingFeature'`)
4. 브랜치에 푸시 (`git push origin feature/AmazingFeature`)
5. **Pull Request** 생성

---

## 📞 지원 및 피드백

- 🐛 **이슈 피드백**：[GitHub Issues](https://github.com/yxsj245/GameServerManager/issues)
- 💬 **QQ 소통방**：1040201322
- 📖 **상세 문서**：[문서 보기](http://blogpage.xiaozhuhouses.asia/html6/index.html#/)

---

## 📄 오픈소스 라이선스

본 프로젝트는 [AGPL-3.0 license](LICENSE) 오픈소스 라이선스를 따릅니다.

---

## 👨‍💻 저자 소개

이 프로젝트는 **又菜又爱玩的小朱**가 단독 개발 및 유지보수하고 있습니다.

이 프로젝트가 도움이 되었다면 ⭐ Star로 응원해주세요!

---

## 📈 프로젝트 통계

![Star History](https://api.star-history.com/svg?repos=yxsj245/GameServerManager&type=Date)

---

<div align="center">

**🎮 게임 서버 관리를 쉽고 재미있게!**

</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---