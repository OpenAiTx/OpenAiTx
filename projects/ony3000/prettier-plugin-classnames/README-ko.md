<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# prettier-plugin-classnames

`printWidth` 옵션을 기반으로 장황한 클래스명을 자동으로 줄바꿈해주는 Prettier 플러그인입니다.

![이 플러그인의 사용 예시.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/banner.png)

## 설치[^1]

```sh
npm install -D prettier prettier-plugin-classnames
```
[^1]: `prettier-plugin-classnames` 버전이 `0.4.0` 미만인 경우, `@prettier/sync`도 설치해야 합니다.

## 설정

JSON 예시:


```json
{
  "plugins": ["prettier-plugin-classnames"]
}
```

JS 예제 (CommonJS 모듈):

```javascript
module.exports = {
  plugins: ['prettier-plugin-classnames'],
  customAttributes: ['myClassProp'],
  customFunctions: ['clsx'],
};
```

JS 예제 (ES 모듈):

```javascript
export default {
  plugins: ['prettier-plugin-classnames'],
  endingPosition: 'absolute',
};
```

### Markdown/MDX 오버라이드

이 플러그인은 Markdown과 MDX를 지원하지 않지만, 만약 이 플러그인이 코드 블록 내의 언어(Vue 등)를 지원할 경우 코드 블록 내에서 원치 않는 서식이 발생할 수 있습니다.

원치 않는 서식을 방지하려면 Markdown 및 MDX에 대한 구성 오버라이드를 사용할 수 있습니다.

JSON 예시:

```json
{
  "plugins": ["prettier-plugin-classnames"],
  "customFunctions": ["clsx"],
  "overrides": [
    {
      "files": ["*.md", "*.mdx"],
      "options": {
        "plugins": []
      }
    }
  ]
}
```
## 옵션

### 사용자 정의 속성

포함하는 클래스 이름의 속성 목록입니다.<br>
`class`와 `className` 속성은 옵션이 지정되지 않아도 항상 지원됩니다.

<!-- prettier-ignore -->
기본값 | CLI&nbsp;재정의 | API&nbsp;재정의
--- | --- | ---
`[]` | `--custom-attributes <string>` | `customAttributes: ["<string>"]`

### 사용자 정의 함수

포함하는 클래스 이름의 함수 목록입니다.<br>
`classNames` 함수는 옵션이 지정되지 않아도 항상 지원됩니다.

<!-- prettier-ignore -->
기본값 | CLI&nbsp;재정의 | API&nbsp;재정의
--- | --- | ---
`[]` | `--custom-functions <string>` | `customFunctions: ["<string>"]`

### 종료 위치

v0.5.0에서 처음 제공되었습니다.<br>
`absolute-with-indent`는 v0.6.0에서 추가되었습니다.<br>
`absolute-with-indent`는 v0.8.0에서 제거되었지만 `absolute`로 동일한 출력을 얻을 수 있습니다.<br>
기본값은 v0.8.0에서 `relative`에서 `absolute`로 변경되었습니다.

이것은 원래 클래스 이름을 여러 줄 클래스 이름으로 바꿀 때 각 줄에서 클래스 이름을 끝내는 기준입니다.

- `absolute` 예시:


  ```
  ------------------------------------------------------------| printWidth=60
  export function Callout({ children }) {
    return (
      <div
        className="bg-gray-100/50 dark:bg-neutral-900/50
          border border-zinc-400/30 dark:border-neutral-500/30
          rounded-xl px-4 py-4"
      >
        {children}
      </div>
    );
  }
  ```

- `relative` 예제:

  ```
  ------------------------------------------------------------| printWidth=60
  export function Callout({ children }) {
    return (
      <div
       |------------------------------------------------------------|
        className="bg-gray-100/50 dark:bg-neutral-900/50 border
         |------------------------------------------------------------|
          border-zinc-400/30 dark:border-neutral-500/30 rounded-xl
          px-4 py-4"
      >
        {children}
      </div>
    );
  }
  ```

<!-- prettier-ignore -->
기본값 | CLI&nbsp;재정의 | API&nbsp;재정의
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### 구문 변환

v0.7.7에서 처음 도입되었습니다.

비표현식 구문으로 작성된 클래스 이름에서 줄 바꿈이 발생하면 표현식 구문으로 변환됩니다. 이 변환은 되돌릴 수 있는 포맷팅을 지원하지 않습니다.

<!-- prettier-ignore -->
기본값 | CLI&nbsp;재정의 | API&nbsp;재정의
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

### 클래스명 인쇄 폭

v0.10.0에서 처음 도입되었습니다.

클래스 이름의 인쇄 폭을 지정합니다. 값이 지정되지 않은 경우 기본값으로 `printWidth` 값이 사용됩니다.

<!-- prettier-ignore -->
기본값 | CLI&nbsp;재정의 | API&nbsp;재정의
--- | --- | ---
`undefined` | `--classnames-print-width <number>` | `classnamesPrintWidth: <number>`

## 형제 플러그인과의 버전 상관관계

`0.6.0`부터 한쪽에서 마이너 릴리즈가 있을 경우, 가능하다면 그 변경사항을 다른 쪽에도 반영할 예정입니다.

![버전 상관관계.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## 다른 Prettier 플러그인과의 호환성

포맷하려는 텍스트를 처리할 수 있는 Prettier 플러그인이 둘 이상일 경우, Prettier는 그중 마지막 플러그인만 사용합니다.

이 경우, [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge)를 추가하여 이러한 플러그인들이 순차적으로 적용되도록 아래와 같이 설정할 수 있습니다.

JSON 예시:

<!-- prettier-ignore -->
```json
{
  "plugins": [
    "prettier-plugin-tailwindcss",
    "prettier-plugin-classnames",
    "prettier-plugin-merge"
  ]
}
```

## Stargazers over time

[![Stargazers over time](https://starchart.cc/ony3000/prettier-plugin-classnames.svg?variant=adaptive)](https://starchart.cc/ony3000/prettier-plugin-classnames)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---