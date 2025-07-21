<translate-content># winjs-plugin-security

WinJS 프로젝트에 보안 강화 기능을 제공하는 플러그인으로, 주로 SRI(하위 리소스 무결성) 속성 생성을 위해 사용됩니다.

## 기능 특성

- HTML 파일 내의 `<script>` 및 `<link>` 태그에 자동으로 SRI 속성 생성
- SHA-256, SHA-384, SHA-512 해시 알고리즘 지원(구성 가능)
- SRI가 정상 작동하도록 자동으로 `crossorigin="anonymous"` 속성 추가
- 프로덕션 환경에서만 활성화되며, 개발 환경에서는 자동으로 건너뜀

## 설치
</translate-content>
```bash
pnpm add @winner-fed/plugin-security
```
## 사용 방법

당신의 `.winrc.ts` 구성 파일에 플러그인 구성을 추가하세요:


```typescript
import { defineConfig } from '@winner-fed/winjs';

export default defineConfig({
  plugins: ['@winner-fed/plugin-security'],
  security: {
    sri: true // 启用 SRI 功能
  },
});
```
## 구성 옵션

### `sri`

- **유형**: `boolean | { algorithm: 'sha256' | 'sha384' | 'sha512' }`
- **기본값**: 수동 설정 필요
- **설명**: SRI(서브리소스 무결성) 기능 활성화 여부 및 선택적 해시 알고리즘 설정

`true` 또는 `{}`로 설정하면, 플러그인은:

1. 빌드된 HTML 파일을 스캔합니다
2. `src` 속성이 있는 모든 `<script>` 태그에 `integrity` 속성을 추가합니다
3. `href` 속성이 있는 모든 `<link>` 태그에 `integrity` 속성을 추가합니다
4. `crossorigin="anonymous"` 속성이 없으면 자동으로 추가합니다

객체 방식으로 해시 알고리즘을 지정할 수도 있습니다:


```typescript
security: {
  sri: {
    algorithm: 'sha512' // 可选 'sha256' | 'sha384' | 'sha512'，默认 'sha512'
  }
}
```

## 示例

### 输入 HTML

```html
<!DOCTYPE html>
<html>
<head>
  <link rel="stylesheet" href="/assets/app.css">
</head>
<body>
  <script src="/assets/app.js"></script>
</body>
</html>
```
### HTML 출력 (SRI 활성화 후)


```html
<!DOCTYPE html>
<html>
<head>
  <link rel="stylesheet" href="/assets/app.css" integrity="sha512-ABC123..." crossorigin="anonymous">
</head>
<body>
  <script src="/assets/app.js" integrity="sha512-XYZ789..." crossorigin="anonymous"></script>
</body>
</html>
```
## 안전 설명

SRI(서브리소스 무결성)는 브라우저가 가져온 리소스(예: CDN에서 가져온 리소스)가 악의적으로 변경되지 않았는지 검증할 수 있게 하는 보안 기능입니다. 브라우저가 리소스를 로드할 때 리소스의 해시 값을 계산하고 `integrity` 속성에 지정된 해시 값과 비교합니다. 해시 값이 일치하지 않으면 브라우저는 해당 리소스의 로드를 거부합니다.

`<script>` 태그의 경우, 해당 코드 실행을 거부하며; CSS 링크의 경우, 스타일 로드를 하지 않습니다.

SRI에 대한 자세한 내용은 [Subresource Integrity - MDN](https://developer.mozilla.org/zh-CN/docs/Web/Security/Subresource_Integrity)을 참조하세요.

## 주의 사항

1. 이 플러그인은 프로덕션 빌드에서만 작동하며, 개발 환경에서는 자동으로 건너뜁니다.
2. 리소스 파일이 빌드 출력 디렉터리에서 접근 가능해야 합니다.
3. `integrity` 속성은 정상 작동을 위해 `crossorigin` 속성과 함께 사용해야 합니다.

## 라이선스

MIT




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---