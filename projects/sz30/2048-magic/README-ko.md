[English](https://raw.githubusercontent.com/sz30/2048-magic/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-TW.md)

# 🎮 2048++

고전 2048 게임의 향상된 버전으로, 더욱 재미있는 기능들이 추가되었습니다! 여가 시간에 만든 작은 프로젝트인데, 여러분께 즐거움을 드리길 바랍니다!

## 🎯 게임 소개

2048은 간단하면서도 중독성 있는 숫자 합치기 게임입니다. 4x4 격자에서 위, 아래, 왼쪽, 오른쪽으로 스와이프하여 같은 숫자의 타일을 합칩니다. 목표는? 2048에 도달하는 것(하지만 더 높은 점수를 위해 계속 플레이할 수도 있어요)!

**게임 방법:**
- 화살표 키 또는 WASD 키로 타일을 이동하세요.
- 같은 숫자의 두 타일이 충돌하면 하나로 합쳐집니다.
- 매 이동 후 빈 칸에 2 또는 4가 무작위로 나타납니다.
- 더 이상 이동할 수 없으면 게임이 종료됩니다.

## ✨ 특별 기능

### 1. 실행 취소 기능
- 잘못된 움직임을 했나요? 걱정 마세요!
- "Undo" 버튼을 눌러 한 단계 되돌릴 수 있습니다.
- 시작부터 원하는 만큼 여러 번 실행 취소할 수 있습니다.
- 손가락 실수로 게임이 망치지 않도록 하세요!

### 2. 비밀 치트 모드
- 마법의 시퀀스를 입력하세요: ←←→→ →→←← (왼쪽, 왼쪽, 오른쪽, 오른쪽, 오른쪽, 오른쪽, 왼쪽, 왼쪽)
- 모든 타일이 마법처럼 128로 변합니다!
- 이건 재미를 위한 이스터 에그입니다.
- 프로 팁: 치트는 재미있지만 너무 남용하지 마세요! 😉

## 🎯 데모

🎯 여기서 플레이하세요: [http://2048.ct8.pl](http://2048.ct8.pl:9969/)
<img width="1279" alt="demo" src="https://github.com/user-attachments/assets/0df2c956-b6d9-4371-a916-f6ac3ae642be" />



## 📁 프로젝트 구조

```
2048/
├── static/
│ ├── css/
│ │ └── styles.css # Game styles
│ └── js/
│ └── script.js # Frontend game logic
├── index.html # Main game page
└── 2048.py # Backend server
```
**파일 설명:**
- `2048.py`: Flask로 작성된 백엔드 서버, 게임 로직과 API 요청 처리.
- `script.js`: 프론트엔드 게임 로직, 이동, 애니메이션 및 특별 기능 포함.
- `styles.css`: 게임 스타일, 모든 것이 깔끔하고 반응형으로 보이도록 함.
- `index.html`: 모든 것을 하나로 모으는 메인 페이지.

## 🚀 시작하기

**방법 1: 릴리스 다운로드**
1. 최신 릴리스를 다운로드합니다.
2. Python 3.x가 설치되어 있는지 확인합니다.
3. 종속성 설치: `pip install flask`
4. 실행: `python 2048.py`
5. 브라우저를 열고 다음 주소로 접속: [http://localhost:9969](http://localhost:9969)

**방법 2: GitHub에서 클론**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```
## 🎨 사용자 정의

나만의 스타일로 바꾸고 싶나요? 새로운 외관을 위해 `styles.css`를 조정하거나, 게임 플레이를 변경하려면 `script.js`를 살펴보세요. 모든 코드는 쉽게 수정할 수 있도록 주석이 잘 달려 있습니다!

## 📝 라이선스

GPL-2.0 라이선스

## 🤝 기여

아직도 업데이트 중입니다! 이슈와 풀 리퀘스트는 언제나 환영합니다—함께 이 게임을 더욱 멋지게 만들어 봅시다!


## 🙏 감사의 말

이 프로젝트를 지원해주신 후원자분들께 감사드립니다:
- 서버 제공: [Serv00](https://www.serv00.com/)

---
_최종 업데이트: 2025년 6월_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---