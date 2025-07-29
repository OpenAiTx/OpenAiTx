# tailwind-bootstrap-grid

[![npm version](https://img.shields.io/npm/v/tailwind-bootstrap-grid)](https://www.npmjs.com/package/tailwind-bootstrap-grid)
![license](https://img.shields.io/npm/l/tailwind-bootstrap-grid)

Bootstrap **v5** 플렉스박스 그리드 시스템을 Tailwind CSS 플러그인으로 제공합니다.

[데모 플레이그라운드](https://tailwind-bootstrap-grid.netlify.app/)를 확인하세요.

## 설치

```shell
npm i -D tailwind-bootstrap-grid
```

`index.css` 파일에서:

```css
@import 'tailwindcss';

@plugin 'tailwind-bootstrap-grid' {
  container_max_widths:
    'sm', '540px', 'md', '720px', 'lg', '960px', 'xl', '1140px', '2xl', '1320px';
}
```

또는 `tailwind.config.js` 파일을 통해:

```js
module.exports = {
  plugins: [
    require('tailwind-bootstrap-grid')({
      container_max_widths: [
        'sm',
        '540px',
        'md',
        '720px',
        'lg',
        '960px',
        'xl',
        '1140px',
        '2xl',
        '1320px',
      ],
    }),
  ],
};
```
이것은 Bootstrap v5 플렉스박스 그리드를 생성합니다.

## 옵션

- 원본 Bootstrap 그리드 옵션:

  - `grid_columns` (기본값 - `12`) - 그리드 크기
  - `grid_gutter_width` (기본값 - `"1.5rem"`) - 컨테이너 및 행 간격 너비
  - `grid_gutters` (기본값 - `[0, 0]`) - 간격 변수 클래스 단계
    (`--bs-gutter-x`, `--bs-gutter-y`)
  - `container_max_widths` (기본값 - `[]`) - 각 브레이크포인트에 대한
    `max-width` 컨테이너 값

- 추가 옵션:
  - `generate_container` (기본값 - `true`) - `.container` 및
    `.container-fluid` 클래스 생성 여부
  - `rtl` (기본값 - `false`) - rtl 지원 (`.offset-x` 클래스가
    [dir](https://www.w3schools.com/tags/att_global_dir.asp)
    `[dir=ltr]` / `[dir=rtl]`에 반응하기 시작)
  - `debug` (기본값 - `false`) - 디버그 모드 활성화

## 버전 호환성

| TailwindCSS | Bootstrap | tailwind-bootstrap-grid |
| ----------- | --------- | ----------------------- |
| 3           | 4         | 3                       |
| 3           | 5         | 5                       |
| 4           | 5         | 6+                      |

## 관련

[postcss-bootstrap-4-grid](https://github.com/johnwatkins0/postcss-bootstrap-4-grid)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---