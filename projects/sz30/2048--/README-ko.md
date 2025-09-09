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

고전 2048 게임을 업그레이드한 버전으로, 더욱 다양한 재미있는 기능들이 추가되었습니다! 이것은 제가 여가 시간에 간단히 만든 작은 프로젝트입니다—여러분께 즐거움을 드릴 수 있길 바랍니다!

## 🎯 게임 소개

2048은 간단하지만 중독성 있는 숫자 합치기 게임입니다. 4x4 그리드에서 위, 아래, 왼쪽, 오른쪽으로 스와이프하여 같은 숫자의 타일을 합칩니다. 목표는? 2048에 도달하는 것(하지만 더 높은 점수를 위해 계속 도전할 수도 있어요)!

**플레이 방법:**
- 방향키 또는 WASD로 타일을 이동하세요.
- 동일한 숫자를 가진 두 타일이 충돌하면 하나로 합쳐집니다.
- 각 이동 후에는 빈 공간에 2 또는 4가 무작위로 나타납니다.
- 더 이상 이동할 수 없으면 게임이 종료됩니다.

## ✨ 특별 기능

### 1. 되돌리기 기능
- 잘못 움직였나요? 걱정 마세요!
- "되돌리기" 버튼을 눌러 한 단계 뒤로 돌아가세요.
- 시작점까지 원하는 만큼 되돌릴 수 있습니다.
- 실수로 게임이 망치는 일은 이제 없습니다!

### 2. 비밀 치트 모드
- 마법의 순서 입력: ←←→→ →→←← (왼쪽, 왼쪽, 오른쪽, 오른쪽, 오른쪽, 오른쪽, 왼쪽, 왼쪽)
- 모든 타일이 마법처럼 128로 변합니다!
- 재미를 위한 이스터에그입니다.
- 팁: 치트는 재미있지만, 너무 많이 쓰지는 마세요! 😉

## 🎯 데모

🎯 : [여기서 플레이](http://34.150.49.127:5000/)
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

## 🎨 커스터마이징

나만의 게임을 만들고 싶으신가요? `styles.css`를 수정해 새로운 스타일을 적용하거나, `script.js`를 변경해 게임플레이를 바꿔보세요. 모든 코드는 쉽게 수정할 수 있도록 주석이 잘 달려 있습니다!

## 📝 라이선스

GPL-2.0 라이선스

## 🤝 기여하기

계속 업데이트 중입니다! 이슈와 풀 리퀘스트는 언제든 환영합니다—함께 이 게임을 더욱 멋지게 만들어봐요!


## 🙏 감사의 말씀

다음 후원자분들께서 본 프로젝트를 지원해 주셨습니다:
- [None](https://#/) 서버 제공
- [Serv00](https://www.serv00.com/) 서버 제공

---
_최종 업데이트: 2025년 8월_




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---