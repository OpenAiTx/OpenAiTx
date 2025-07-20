<translate-content># 이미지 변경 팝업

버튼 클릭 시 이미지가 순차적으로 변경되는 맞춤형 인터랙티브 팝업


## 프로젝트 개요

이 프로젝트는 일련의 이미지를 표시하는 스타일리시한 팝업 창을 만듭니다. 사용자가 버튼을 클릭할 때마다 이미지가 다음 순서의 이미지로 변경됩니다. 마지막 이미지에 도달하면 버튼이 사라지고 최종 메시지가 표시됩니다.

## 학습 내용

* 손쉬운 커스터마이징을 위한 CSS 변수
* 기본 HTML 플렉스 구조
* 자바스크립트 이벤트 처리
* DOM 조작

## 주요 기능

- CSS 변수를 통한 색상, 글꼴 및 스타일링 커스터마이징
- 배경 이미지, 주요 이미지 시퀀스 및 모든 텍스트 맞춤 설정
- 이미지 간 부드러운 페이드 전환 효과
- 모바일 반응형 디자인
- 장식용 UI 요소(닫기 및 축소 버튼)

## 📁 프로젝트 구조

```
image-changer-popup/
├── assets/
│   ├── image-content/
│   │   ├── image-1.png
│   │   ├── image-2.png
│   │   ├── image-3.png
│   │   ├── image-4.png
│   │   ├── image-5.png
│   │   └── image-6.png
│   ├── close-icon.png
│   ├── favicon.png
│   ├── main-bg.png
│   └── shrink-icon.png
├── index.html
├── style.css
└── index.js
```
## 작동 원리

1. 페이지가 스타일화된 팝업 컨테이너와 함께 로드됩니다  
2. 첫 번째 이미지가 자동으로 표시됩니다  
3. 사용자가 버튼을 클릭하면:  
   - 현재 이미지가 서서히 사라집니다  
   - 다음 이미지가 미리 로드됩니다  
   - 로드가 완료되면 새 이미지가 서서히 나타납니다  
4. 마지막 이미지에 도달하면:  
   - 버튼이 사라집니다  
   - 최종 메시지가 표시됩니다  
  
## 이 프로젝트를 재현하는 방법  
1. GitHub에서 프로젝트를 클론합니다  
2. 선호하는 텍스트 편집기(VScode 또는 기타 편집기)로 프로젝트를 엽니다  
3. 프로젝트 구조와 파일을 검토합니다:  
   - `index.html`: 팝업의 기본 구조를 포함  
   - `style.css`: 모든 스타일링 및 시각적 커스터마이징 옵션 포함  
   - `index.js`: 이미지 변경 기능을 처리  
4. 브라우저에서 `index.html`을 열어 프로젝트를 확인합니다:  
   - 파일 탐색기에서 파일을 더블 클릭  
5. 코드 내 지침을 따라 프로젝트를 커스터마이징합니다:  
   - `style.css`에서 CSS 변수를 수정해 색상, 폰트, 스타일 변경  
   - `assets` 폴더의 이미지를 교체(위의 Artwork Images Requirements 참고)  
   - HTML 파일 내 텍스트 내용을 업데이트  
6. 자바스크립트 기능에 대해서는:  
   - 각 줄의 기능을 주석으로 달아 두었으니 직접 다시 구현해보길 권장합니다 :)  
7. 브라우저를 새로고침하여 변경 사항을 실시간으로 테스트  
8. 배포 시 아래 Netlify 호스팅 지침을 따름  
  
*프로젝트 구조와 파일 이름이 현재 보유한 이름과 일치하는지 확인하거나, 코드 내에서 이름을 변경하세요.  
  
## 커스터마이징 옵션  
  
### 아트워크 이미지 요구사항  
- 애니메이션 시퀀스(4-8 이미지): 300 x 360px - 투명 배경 png 권장  
- 배경 이미지: 2093 x 1132 px  
- 파비콘: 유연한 크기, 본 예시는 238 x 279px - 투명 배경 png 권장  
- 닫기 및 축소 아이콘: 정사각형 비율로 유연한 크기, 본 예시는 287 x 287px  
  
**프로젝트 구조와 파일 이름이 현재 보유한 이름과 일치하는지 확인하거나, 코드 내에서 이름을 변경하세요.  
  
이 프로젝트에서 이미지 크기를 변경하고 싶다면, CSS에서 해당 비율을 업데이트해야 합니다. 수정해야 할 구체적인 섹션은 다음과 같습니다:  
  
이미지 콘텐츠(애니메이션 영역)용:

```css
.image-content {
  /* ... other properties ... */
  height: 65%;
  aspect-ratio: 142.5 / 171; /* Change these values to match your animation dimensions (300x360px) */
}
``` 
배경 이미지 크기 조정을 위해:

```css
body {
  /* ... other properties ... */
  background-size: 100% auto; /* Adjust based on your background image dimensions (2093x1132px) */
}
```
<translate-content>

### 색상 및 스타일링

모든 시각적 요소는 `style.css`의 `:root` 섹션에 있는 CSS 변수들을 통해 사용자 정의할 수 있습니다:
</translate-content>
```css
:root {
  /* Colors */
  --color-page-background: #50AFC9;
  --color-main-container-background: #FF5B70;
  --color-inner-container-background: #FFF7F4;
  --color-border: #9E0E2B;
  --color-button-background: #FFF;
  --color-heading-text: #FFF;
  --color-button-text: #9E0E2B;
  --color-message-text: #9E0E2B;
  
  /* Images */
  --image-path-background: url('assets/main-bg.png');
  --image-path-content: url('assets/image-content/image-1.png');
  
  /* Fonts */
  --font-family-main: "Pixelify Sans", sans-serif;
  /* ... and more variables ... */
}
```
### 텍스트 내용

HTML 파일에서 다음을 수정하세요:

- 페이지 제목: `<title>For you &lt;3</title>`
- 헤더 텍스트: `<h1>For you &lt;3</h1>`
- 버튼 텍스트: `<button id="waterButton">Grow!</button>`
- 최종 메시지: `<div class="final-message">Have a good day!</div>`

### 이미지

1. `assets/image-content/` 디렉토리의 이미지를 자신의 이미지로 교체하세요
2. 동일한 파일 이름을 유지하거나 자바스크립트 배열의 경로를 업데이트하세요
3. 배열에 항목을 추가하여 이미지를 더 추가할 수 있습니다


```javascript
const images = [
  './assets/image-content/image-1.png',
  './assets/image-content/image-2.png',
  // Add more images here...
];
```
## 🌐 Netlify에 호스팅하기

이 프로젝트는 Netlify의 무료 플랜을 사용하여 배포할 수 있습니다:

**프로젝트 준비**:
* 파일 이름이 정확한지 확인하세요: `index.html` 및 `index.js` (이름을 변경한 경우)
* 모든 파일 경로가 정확한지 확인하세요 (대소문자 구분)

**Netlify 가입하기**:
* netlify.com에 접속하여 무료 계정을 만드세요
* GitHub, GitLab, Bitbucket 또는 이메일로 가입할 수 있습니다

**사이트 배포하기**: 
* 프로젝트 폴더를 Netlify 대시보드에 드래그 앤 드롭하세요
* Netlify가 자동으로 사이트를 배포합니다

**사이트 설정하기**:
* 배포 후 사이트 이름을 커스터마이징할 수 있습니다
* "Site settings" → "Change site name"으로 이동하세요
* 사이트는 `your-site-name.netlify.app`에서 사용 가능합니다

**사이트 업데이트하기**:
* 드래그 앤 드롭 방식을 사용했다면, 폴더를 다시 드래그 앤 드롭하세요
* Git과 연결했다면, 변경 사항을 리포지토리에 푸시하면 됩니다


## 프로젝트 확장 아이디어

- 닫기 및 축소 아이콘에 클릭 기능 추가
- 마지막 이미지에 도달했을 때 재시작 버튼 구현
- 버튼 클릭 및 전환 시 사운드 효과 추가




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---