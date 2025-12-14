
<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# 로제타 스톤크스

- [소개](#introduction)
- [설치](#install)
  - [크롬](#chrome-based-browsers)
    - [시각적 가이드](#chrome-based-browsers)
  - [파이어폭스](#firefox-based-browsers)
- [사용 방법](#how-to-use)
  - [시간 추가하기](#adding-time)
    - [기초 과정](#adding-time-in-foundations)
    - [유창성 빌더](#adding-time-in-fluency-builder)
  - [레슨 검증하기](#validating-lesson)
    - [기초 과정](#validating-lesson-in-foundations)
    - [유창성 빌더](#validating-lesson-in-fluency-builder)

## 소개

RosettaStonks는 Rosetta Stone 언어 학습 플랫폼에서 시간을 추가하고 레슨을 검증할 수 있는 브라우저 확장 프로그램입니다.

> RosettaStonks, 그리고 당신의 rosetta stone이 stonks가 됩니다.

## 설치

### 크롬 기반 브라우저

➡️ **크롬 확장 프로그램을 직접 설치하는 것이 처음이신가요?** [단계별 시각적 가이드](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md)를 참고하세요 — 유용한 스크린샷이 포함되어 있습니다! 🖼️

#### 1. GitHub 릴리즈 사용하기

크롬 기반 브라우저에서 확장 프로그램을 사용하려면 다음을 수행해야 합니다:

- 최신 릴리즈에서 `rosettastonks-chrome.tar.gz` 파일을
  자신의 컴퓨터에 다운로드합니다.
- 확장 프로그램을 저장할 `rosettastonks`라는 폴더를
  컴퓨터 어딘가에 생성합니다.
- `rosettastonks` 폴더에서 다음 명령어를 실행합니다.


```bash
$ tar xvzf /path/to/rosettastonks-chrome.tar.gz
```
2. nix 패키지 매니저 사용하기

이전 명령어 대신, 만약 flakes를 지원하는 nix 시스템을 사용 중이라면,  
다음 명령어를 실행할 수 있습니다. 이 명령어는 `/tmp/rosettastonks` 경로에  
모든 파일이 포함된 폴더를 설치합니다.


```bash
$ nix build --out-link "/tmp/rosettastonks" github:m1dugh/RosettaStonks#chrome
```
폴더가 이제 `/tmp/rosettastonks/`에 설치되었습니다.

**이 부분은 깃허브 방법을 사용하는지, 닉스 방법을 사용하는지와 관계없이 모든 사용자에게 해당됩니다.**

브라우저에서:

- `chrome://extensions`로 이동합니다.
- `개발자 모드` 토글을 확인합니다.
- `압축 해제된 확장 프로그램 로드`를 클릭합니다.
- `rosettastonks` 폴더를 선택합니다.

### 파이어폭스 기반 브라우저

- 최신 릴리스에서 `rosettastonks.xpi` 파일을 다운로드합니다.
- 또는, 플레이크 지원이 있는 닉스 패키지 관리자를 사용하는 경우, 다음 명령어를 실행할 수 있습니다.




```bash
$ nix build --out-link "/tmp/rosettatonks.xpi" github:m1dugh/RosettaStonks#mozilla
```
- 브라우저에서 `about:debugging#/runtime/this-firefox`로 이동합니다.
- 설정 버튼을 클릭하고 `Debug addons`로 이동합니다.
- `Load Temporary Add-On`을 클릭합니다.
- 파일 선택기에서 `/tmp/rosettastonks.xpi` 파일을 선택합니다.

_경고: 이 방법은 확장 프로그램을 임시로만 설치하며, 브라우저를 종료하면 애드온이 제거됩니다. 이는 Firefox 정책상 검증되지 않은 확장 프로그램 사용이 허용되지 않기 때문입니다._

## 사용 방법

### 시간 추가

#### Foundations에서 시간 추가

`foundations` 제품에서 시간을 추가하려면, 자신의 연습문제로 이동하여 적어도 한 문제를 무시하거나 해결하세요. 이 작업을 완료하면 확장 프로그램 페이지에 시간 입력란이 표시되어 시간을 추가할 수 있습니다.

#### Fluency builder에서 시간 추가

`fluency builder` 제품에서 시간을 추가하려면, 자신의 연습문제로 이동하여 적어도 한 문제를 풀어야 합니다. 만약 시간 추가 입력란이 표시되지 않으면, 시간 요청이 감지되지 않은 것입니다. 질문을 새로고침하고 다시 답변하세요. 시간을 추가하려면 시간을 추가한 레슨을 완료해야 합니다.

_참고: 시간 추가 입력란이 보이지 않는다면, Rosetta stone 웹사이트에서 수행한 행동이 유효한 시간 추가로 연결되지 않았다는 의미이며, 다른 문제를 풀어야 합니다._

### 레슨 검증

#### Foundations에서 레슨 검증

레슨을 검증하려면, 레슨을 시작한 후 모든 문제를 오른쪽 하단의 `ignore` 버튼을 눌러서 진행하세요. 모든 문제를 확인한 후 `validate lesson` 버튼을 클릭하면 레슨이 검증됩니다. 만약 검증되지 않으면, 홈 페이지로 돌아가서 동일한 레슨을 클릭하세요.














`계속하시겠습니까 아니면 재설정하시겠습니까?`라고 물어볼 것이며, 둘 다 선택할 수 있고  
작동할 때까지 수업을 다시 검증할 수 있습니다. 최대 3~4회 후에는 작동해야 합니다.  

#### Fluency builder에서 수업 검증하기  

현재 rosetta stonks에서는 수업 검증 기능을 사용할 수 없습니다.  

## 애플리케이션 빌드하기  

### 워커 빌드하기  

워커는 다음 명령어를 사용하여 패키징할 수 있습니다  

```
$ deno task build:worker
```

이는 작업자용으로 패키징된 파일인 `/dist/worker.esm.js` 패키지 파일을 생성합니다.

### 프런트엔드 빌드

작업자는 다음 명령어를 사용하여 패키징할 수 있습니다.


```
$ deno task build:frontend
```

이는 프론트엔드용 패키지 파일인 `/dist/frontend.esm.js`를 생성합니다.

## 확장 프로그램 패키징

### 크롬

크롬용 확장 프로그램을 패키징하려면 다음 명령어를 실행할 수 있습니다:


```
$ make chrome
```

### 파이어폭스

파이어폭스용 확장 프로그램을 패키징하려면 다음 명령어를 실행할 수 있습니다:

```
$ make firefox
```

이렇게 하면 Firefox에서 로드할 수 있는 확장 프로그램 파일인 `rosettastonks.xpi`가 생성됩니다.

📸 시각 자료를 선호하시나요? [이미지가 포함된 Chrome 설치 가이드](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md)를 확인하세요.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-14

---