<h1 align="center">Master Duel 커뮤니티 한국어 번역 패치</h1>
<div align="center">

![GitHub releases](https://img.shields.io/github/v/release/mikualpha/master-duel-chinese-switch?style=flat-square)
![GitHub license](https://img.shields.io/github/license/mikualpha/master-duel-chinese-switch?style=flat-square)
![GitHub last commit](https://img.shields.io/github/last-commit/mikualpha/master-duel-chinese-switch?style=flat-square)
![GitHub Gist last commit](https://img.shields.io/github/gist/last-commit/de53fb59b1c63a8be98539e04aba5d42?style=flat-square&label=metadata%20version)
![GitHub download count](https://img.shields.io/github/downloads/mikualpha/master-duel-chinese-switch/total?style=flat-square)

[원본 프로젝트 주소](https://gitee.com/fetiss/master-duel-chinese-switch) | [원본 배포 페이지](https://www.bilibili.com/read/cv21869124) | [API 출처](https://ygocdb.com/)
  
</div>

2023년 5월 초 버전부터 MD가 캐시 파일 호출 방식을 변경하여 기존 번역 패치가 작동하지 않아 원본 프로젝트를 기반으로 수정하였습니다.

본 프로젝트는 저자 [@叶lf](https://space.bilibili.com/23834819) / [@Timelic](https://space.bilibili.com/8664322) 님의 작업을 기반으로 하였으며, 이에 감사드립니다! 또한 [@拓王神](https://space.bilibili.com/483116312) 님이 데이터 해석 부분에 지원을 제공해 주신 점도 감사합니다.

## 사용 방법
[Releases 페이지](https://github.com/mikualpha/master-duel-chinese-switch/releases)에서 `MDTR_vx.x.x.exe`를 다운로드하고, 본 프로젝트의 [Wiki](https://github.com/mikualpha/master-duel-chinese-switch/wiki) 페이지를 참고하여 사용하세요.

## 프로젝트 정보
본 프로젝트는 `AGPL-3.0` 라이선스 하에 오픈소스로 배포되며, 모든 배포 및 수정 행위는 [오픈소스 라이선스](https://www.chinasona.org/gnu/agpl-3.0-cn.html)를 반드시 준수해야 합니다. 본 프로젝트의 Release 페이지는 유일한 배포처이며, 공식 그룹이 없고, 제3자 플랫폼에서 실행 파일을 배포하지 않으며, 제3자 플랫폼에서 구매, 기부, 후원 등 결제 수단을 제공하지 않습니다. 악성코드 감염이나 사기에 주의하시기 바랍니다.

오류 발생이나 강제 종료 시 `issue`를 제기할 수 있으며, **관심 있는 분들의 PR 제출을 환영합니다~**

**본 프로젝트가 도움이 되었다면 `Star`를 눌러주시면 감사하겠습니다~**

## 개발 관련
본 프로젝트는 `UnityPy`로 패킹 해제하며, `flet`으로 UI를 제작했습니다. 컴파일 환경은 `Python 3.10`입니다.

<div align="center">
  <img src="https://raw.githubusercontent.com/mikualpha/master-duel-chinese-switch/master/./images/display.png" width="400">
</div>

#### 준비

```
pip install -r requirements.txt
```

#### 开发

无界面

```
python3 index.py
```
flet 인터페이스


```
flet run interface.py
```

#### 打包

PowerShell:

```
./release.ps1
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-24

---