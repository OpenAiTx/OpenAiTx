<div align="right">
  <details>
    <summary >🌐 기타 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>


[English](https://raw.githubusercontent.com/sz30/2048--/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-TW.md)

# 🎮 2048++

고전 2048 게임을 한 단계 업그레이드! 더 많은 재미 요소가 추가된 버전입니다. 여유 시간에 만들었던 작은 프로젝트이니 즐거움을 드리길 바라요!

## 🎯 게임 소개

2048은 단순하지만 중독성 있는 숫자 합치기 게임입니다. 4x4 그리드에서 위, 아래, 왼쪽, 오른쪽으로 스와이프하여 같은 숫자 타일을 합치세요. 목표는? 2048에 도달하는 것(하지만 더 높은 점수에 도전해도 좋아요)!

**플레이 방법:**
- 방향키 또는 WASD로 타일을 이동하세요.
- 같은 숫자의 타일 두 개가 충돌하면 하나로 합쳐집니다.
- 각 이동 후, 빈 칸에 무작위로 2 또는 4가 새로 생성됩니다.
- 더 이상 움직일 수 없으면 게임이 종료됩니다.

## ✨ 특별 기능

### 1. 실행 취소 기능
- 실수로 잘못 움직였나요? 걱정 마세요!
- "Undo" 버튼을 누르면 한 단계 이전으로 돌아갈 수 있습니다.
- 시작점까지 원하는 만큼 실행 취소가 가능합니다.
- 손가락 실수로 게임이 망치는 일, 이제 걱정 끝!

### 2. 비밀 치트 모드
- 마법의 시퀀스 입력: ←←→→ →→←← (왼쪽, 왼쪽, 오른쪽, 오른쪽, 오른쪽, 오른쪽, 왼쪽, 왼쪽)
- 모든 타일이 마법처럼 128로 변합니다!
- 재미로 숨겨진 이스터에그예요.
- 꿀팁: 치트는 재밌지만, 너무 남용하지 마세요! 😉

## 🎯 데모

🎯 여기서 플레이: [2048.765431.xyz](https://2048.765431.xyz/)
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
- `2048.py`: Flask로 작성된 백엔드 서버로, 게임 로직과 API 요청을 처리합니다.
- `script.js`: 프론트엔드 게임 로직, 이동, 애니메이션 및 특수 기능을 포함합니다.
- `styles.css`: 게임 스타일을 담당하여 모든 요소가 깔끔하고 반응형으로 보이게 합니다.
- `index.html`: 모든 것을 하나로 모으는 메인 페이지입니다.

## 🚀 시작하기

**방법 1: 릴리스 다운로드**
1. 최신 릴리스를 다운로드합니다.
2. Python 3.x가 설치되어 있는지 확인합니다.
3. 의존성 설치: `pip install flask`
4. 실행: `python 2048.py`
5. 브라우저를 열고 다음 주소로 이동: [http://localhost:9969](http://localhost:9969)

**방법 2: GitHub에서 클론하기**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```

## 🎨 커스터마이즈

직접 꾸미고 싶으신가요? `styles.css`를 수정하여 새로운 스타일을 적용하거나, `script.js`를 수정하여 게임플레이를 변경할 수 있습니다. 모든 코드는 쉽게 수정할 수 있도록 주석이 잘 달려 있습니다!

## 📝 라이선스

GPL-2.0 라이선스

## 🤝 기여하기

계속 업데이트 중입니다! 이슈 및 풀리퀘스트 환영합니다—함께 이 게임을 더 멋지게 만들어봐요!


## 🙏 감사의 말씀

다음 후원사들이 이 프로젝트를 지원해주셨습니다. 감사합니다:
- [IDC.REST](https://idc.rest/) 서버 제공
- [Serv00](https://www.serv00.com/) 서버 제공

---
_최종 업데이트: 2025년 6월_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---