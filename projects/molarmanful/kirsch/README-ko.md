<div align="center">

![kirsch](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/header.png)

</div>

## 목차

- [목차](#table-of-contents)
- [개요](#overview)
- [갤러리](#gallery)
- [설치/사용법](#installation/usage)
  - [너드 폰트](#nerd-fonts)
  - [프로포](#propo)
  - [닉스팩스](#nixpkgs)
  - [닉스 플레이크](#nix-flakes)
  - [웹](#web)
- [디자인 노트](#design-notes)
  - [장식](#flourishes)
  - [간격](#gaps)
- [기여](#contributing)
- [크레딧](#credits)
- [라이선스](#licensing)

## 개요

**kirsch** /ˈkɪərʃ/ _명사_

1. _(독일어)_ 체리.

1. _(러셀 A. 커쉬, 1929 - 2020)_ 최초의 디지털 이미지 스캐너 개발자이자 픽셀의 발명가로 인정받는 미국 엔지니어.

1. 6x16 바운딩 박스(평균 너비 5px, 하강 4px, 상승 12px, x-높이 5px, 대문자 높이 9px)를 가진 모노스페이스 비트맵 글꼴. 다양한 서체 형태와 모티프에서 영감을 받아 컴팩트한 크기에서 독특한 휴머니스트 느낌을 창출함.

   일부 글리프는 [Cozette](https://github.com/slavfox/Cozette)에서 가져왔으며, 종종 kirsch 디자인에 맞게 수정됨.





## 갤러리

<details>
<summary><strong>글리프</strong></summary>
<div align="center">

![kirsch 글리프](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/chars.png)

</div>
</details>

<details>
<summary><strong>글리프 맵</strong></summary>
<div align="center">

![kirsch 글리프 맵](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/map.png)

</div>
</details>

<details open>
<summary><strong>샘플</strong></summary>
<div align="center">

![kirsch 샘플](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/sample.png)

</div>
</details>

## 설치/사용법

[릴리스](https://github.com/molarmanful/kirsch/releases)에서 다운로드하세요.
비트맵 형식인 OTB, BDF, PCF, DFONT (Mac 사용자용)와
TTF가 포함되어 있습니다. HiDPI 화면용 2배 버전도 제공됩니다. PCF는
U+FFFF 이후의 글리프를 포함하지 않는 점에 유의하세요.

가장 선명한 시각 경험을 위해 가능하면 비트맵 형식을 사용해 보세요.
만약 플랫폼에서 비트맵 폰트를 지원하지 않는 경우(예: Windows,
VSCode)에는 16px의 배수 크기에서 TTF를 사용하세요.

> [!TIP]
> 폰트 크기를 pt 단위로 사용해야 한다면, 다음 변환식을 사용하세요:
>
> `pt = px * 72 / dpi`
>
> 예: 96dpi 화면에서 16px는 `16px * 72 / 96dpi = 12pt` 입니다.

### Nerd Fonts

kirsch는 커스텀 Nerd Fonts 글리프를 포함합니다. 지원은 아직 진행 중입니다.  
시각적 명확성을 위해, kirsch의 Nerd Fonts 글리프는 너비를 넘어 크게 번지는 경향이 있습니다.  
이 글리프들은 앞뒤에 한 칸의 공백을 두었을 때 가장 잘 보일 것이라 예상하며 디자인했습니다.

나머지 Nerd Fonts를 포함하는 패치된 Nerd Fonts도 제공됩니다.  
"Mono" 버전은 더 작은 글리프(단일 너비 대신 두 배 너비)를 사용하며, 너비 혼합이 불가능한 터미널에서 작동합니다.

### Propo

부분적으로 번지는 foot 같은 터미널을 위해, kirsch의 Propo 버전이 제공됩니다.  
이 버전은 터미널의 폰트 렌더러에 의해 셀 일부가 잘리지 않도록 글리프를 조정합니다.

### Nixpkgs

[@ejiektpobehuk](https://github.com/ejiektpobehuk) 덕분에, kirsch는  
Nixpkgs에서 `kirsch`로 이용할 수 있습니다.

### Nix Flakes

kirsch 릴리스는 또한  
[FlakeHub](https://flakehub.com/flake/molarmanful/kirsch)에 푸시됩니다. `kirsch` (별칭 `default`)는 기본 패키지이며, `kirsch-nerd`는 Nerd Fonts 패치를 포함합니다.

### Web

비트맵 지원이 부족하여 웹에서 kirsch 사용은 일반적으로 권장하지 않습니다.  
하지만 고집스럽고 용감한 분들을 위해 WOFF2가 제공됩니다. 또한  
[CDN 호스팅 스타일시트](https://cdn.jsdelivr.net/npm/kirsch@latest/kirsch.css)도 있습니다.




편의를 위해.

```html
<link
  rel="stylesheet"
  href="https://cdn.jsdelivr.net/npm/kirsch@latest/kirsch.css"
/>
```
## 디자인 노트

이전 폰트 [eldur](https://github.com/molarmanful/eldur)와는 달리,  
평균 문자 폭이 겨우 4px였던 것과 달리 kirsch는 평균 문자 폭이 5px입니다.  
추가된 1px의 너비는 디자인에 놀라운 여유를 제공합니다.  
더 많은 글리프가 5px 너비에 편안하게 들어갑니다 - 예를 들어 "m"과 "w" -  
이는 해당 글리프들이 커닝을 깨뜨리지 않고 이웃 글리프의 공간을 침범하지 않음을 의미합니다.  
5px 너비에 들어가지 않는 글리프는 이제 7px 너비로 작업할 수 있어,  
커닝에 너무 부정적인 영향을 주지 않으면서 균형과 가독성을 유지합니다.

### 장식

![rogue fijian xylophone](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/design-flourishes.png)

"i"나 "f" 같은 글자의 장식은 스타일적 선택이지만,  
기능적 목적도 수행합니다. 장식이 없으면 "i"는 1px 너비를 차지해  
4px의 어색한 공간이 남게 됩니다. "i" 양쪽에 2px 장식을 더해  
5px 너비를 갖게 하여 커닝 문제를 세련되게 해결합니다.

"l"의 경우, 스크립트 스타일 장식이  
`1I|` 같은 다른 수직 문자들과 더 명확하게 구분되게 합니다.

### 틈새

![bad queen peg 69](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/design-gaps.png)

kirsch의 특징 중 하나는 글자의 곡선 부분에 틈새가 있다는 점입니다.  
틈새를 채우면 글자가 너무 각지거나 빽빽해 보이지만,  
틈새를 열어두면 글자 형태가 더 깔끔해집니다. 틈새는 또한  
스크립트 스타일 획 끝맺음을 연상시킵니다.

## 기여

이슈, 기능/글리프 요청, 풀 리퀘스트 모두 환영합니다! 폰트 파일은  
[bited](https://github.com/molarmanful/bited)을 통해 편집됩니다.

## 크레딧

이 프로젝트들은 kirsch를 만드는 데 영감을 주고 도움을 준 프로젝트들이며,  
100% 추천할 만합니다.
체크아웃.

- [Bits'n'Picas](https://github.com/kreativekorp/bitsnpicas)
- [Cozette](https://github.com/slavfox/Cozette)
- [Cyreal Font Testing Page](http://www.cyreal.org/Font-Testing-Page/)
- [W3 UTF-8 Demo](https://www.w3.org/2001/06/utf-8-test/UTF-8-demo.html) /
  [Markus Kuhn UTF-8 Demo](https://antofthy.gitlab.io/info/data/utf8-demo.txt)
- [APL386](https://abrudz.github.io/APL386)

## 라이선스

[the kirsch Project Authors](AUTHORS)가 ♥로 만들었습니다. OFL-1.1
라이선스 하에 배포됩니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---