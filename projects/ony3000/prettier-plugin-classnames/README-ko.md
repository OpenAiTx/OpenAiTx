# prettier-plugin-classnames

`printWidth` 옵션을 기반으로 긴 클래스 이름을 감싸는 Prettier 플러그인입니다.

![이 플러그인의 사용 사례.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/banner.png)

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
  --------------------------------------------------| printWidth=50
  export function Callout({ children }) {
    return (
      <div
        className="bg-gray-100/50 border
          border-zinc-400/30 dark:bg-neutral-900/50
          dark:border-neutral-500/30 px-4 py-4
          rounded-xl"
      >
        {children}
      </div>
    );
  }
  ```

- `relative` 예제:

  ```
  --------------------------------------------------| printWidth=50
  export function Callout({ children }) {
    return (
      <div
                  |--------------------------------------------------|
        className="bg-gray-100/50 border border-zinc-400/30
         |--------------------------------------------------|
          dark:bg-neutral-900/50 dark:border-neutral-500/30
          px-4 py-4 rounded-xl"
      >
        {children}
      </div>
    );
  }
  ```

<!-- prettier-ignore -->
기본 | CLI&nbsp;재정의 | API&nbsp;재정의
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### 구문 변환

v0.7.7에서 처음 지원됩니다.

비표현식 구문으로 작성된 클래스 이름에서 줄 바꿈이 발생하면, 이를 표현식 구문으로 변환합니다. 이 변환은 가역적인 포맷팅을 지원하지 않습니다.

<!-- prettier-ignore -->
기본 | CLI&nbsp;재정의 | API&nbsp;재정의
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

## 형제 플러그인과의 버전 연동

`0.6.0`부터 한 쪽에서 마이너 릴리스가 있을 경우, 가능하면 다른 쪽에도 해당 변경 사항을 반영할 계획입니다.

![버전 연동.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## 다른 Prettier 플러그인과의 호환성

포맷팅하려는 텍스트를 처리할 수 있는 Prettier 플러그인이 두 개 이상 있을 경우, Prettier는 그 중 마지막 플러그인만 사용합니다.

이 경우, [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge)를 추가하여 해당 플러그인들을 순차적으로 적용하도록 다음과 같이 구성할 수 있습니다.

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


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-02

---