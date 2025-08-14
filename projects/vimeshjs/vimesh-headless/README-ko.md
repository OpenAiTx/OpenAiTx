# Vimesh 헤드리스 UI
## 특징
이것은 [Tailwind Headless UI](https://headlessui.com/)의 Alpine.js 구현체입니다. [Vimesh UI](https://github.com/vimeshjs/vimesh-ui) 프레임워크로 구축된 Vimesh 헤드리스 UI는 다음과 같은 멋진 기능을 갖추고 있습니다:
### 초경량
Vimesh 헤드리스 UI는 훨씬 더 작은 코드 크기를 가집니다

| 컴포넌트   | Vimesh 헤드리스 UI   | Vue용 Tailwind 헤드리스 UI | React용 Tailwind 헤드리스 UI |
| ----------- | -------------------- | -------- | ----- |
| 리스트박스   | 8k  | 34k | 30k | 
| 콤보박스  | 9k  | 25k | 39k |
| 메뉴      | 7k  | 18k | 20k |
| 스위치    | 0.6k | 5k | 6k |
| 탭      | 4k  | 12k | 16k |
| 다이얼로그    | 2k  | 15k | 17k |
| 팝오버   | 6k  | 23k | 28k |
| 라디오 그룹 | 1k | 11k | 14k |

Vimesh와 Tailwind 헤드리스 다이얼로그 예제 페이지의 프로덕션 버전 크기를 비교하면, Vimesh가 더 많은 기능과 적은 버그로 훨씬 더 작습니다 (tailwind 팝업 다이얼로그에서 메뉴 표시를 확인하세요).

* Vimesh (192k) 
![](https://raw.githubusercontent.com/vimeshjs/vimesh-headless/master/./assets/vimesh001.png) 
* Tailwind (425k)
![](https://raw.githubusercontent.com/vimeshjs/vimesh-headless/master/./assets/tailwind001.png)

### 사용된 컴포넌트만 동적으로 로드
컴포넌트는 일반 html 파일로, 어디서나 호스팅할 수 있으며 보통 CDN에 위치합니다. 추가 트리 쉐이킹 작업 없이도 다른 프로젝트 간에 공유할 수 있습니다. 예를 들어, 다이얼로그 기본 예제는 두 개의 컴포넌트 `hui-dialog`와 `hui-menu`를 사용합니다. 이들을 `x-import`로 비동기 로드하면 Vimesh UI가 해당 네이티브 커스텀 엘리먼트를 등록하고 초기화합니다.

```html
<template x-component:page="dialog-basic" x-import="hui:dialog,menu" x-data="setupDialogBasicData()"
    class="overflow-y-auto">
    ...
    <hui-dialog :open="isOpen" @close="setIsOpen(false)">
        ...
        <hui-menu>
        </hui-menu>
    </hui-dialog>
    ...
</template>
```
### 빌드 없음, 번들 없음
작성한 내용이 그대로 출력됩니다. 구성 요소를 의미 있는 네임스페이스 아래 html 파일로 구성하세요. webpack, rollup, vite 등이 필요하지 않습니다.

## 시작하기
### 개발 모드
alpinejs, @vimesh/style, @vimesh/ui, universal-router 및 http-server를 포함한 개발 의존성을 설치하세요.

```
yarn
```
정적 HTTP 서버 실행
```
yarn dev
```
`http://127.0.0.1:8080/playground/dev.html` URL을 엽니다.

인덱스 페이지가 표시됩니다.
![](https://raw.githubusercontent.com/vimeshjs/vimesh-headless/master/./assets/vimesh002.jpg)

상대 경로의 소스 코드와 함께 다양한 컴포넌트 예제가 있습니다.

![](https://raw.githubusercontent.com/vimeshjs/vimesh-headless/master/./assets/vimesh003.jpg)

node_modules 폴더에 있는 개발 버전의 alpinejs와 @vimesh/ui를 사용합니다.

### 프로덕션 모드
`playground/index.html`을 확인하세요. 여기서는 `unpkg.com`의 최신 alpinejs와 @vimesh/ui를 사용합니다. 실제 프로젝트에서 Vimesh Headless UI를 사용할 때도 이 방법을 사용합니다.
``` html
<head>
    <link rel="icon" type="image/x-icon" href="./assets/favicon.ico">

    <script src="https://unpkg.com/@vimesh/style"></script>
    <script src="https://unpkg.com/@vimesh/ui"></script>
    <script src="https://unpkg.com/alpinejs" defer></script>
    <script src="https://unpkg.com/universal-router/universal-router.min.js"></script>

    <script>
        const DEBUG = false
        $vui.config.debug = DEBUG
        $vui.config.importMap = {
            "hui": '../components/${component}.html' + (DEBUG ? '?v=' + new Date().valueOf() : '?v=0.1'),
            "app": './components/${path}${component}.html' + (DEBUG ? '?v=' + new Date().valueOf() : '?v=0.1'),
            "page": './pages/${path}${component}.html' + (DEBUG ? '?v=' + new Date().valueOf() : '?v=0.1'),
        }
    </script>
    ...
</head>
```

[Online Playground](https://unpkg.com/@vimesh/headless/playground/index.html)

Yes, the online playground are 100% plain html hosted at `unpkg.com`. It is very old school style, right? Let's make frondend development back to what it should be.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-14

---