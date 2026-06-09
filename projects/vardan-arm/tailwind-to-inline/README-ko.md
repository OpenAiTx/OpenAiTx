# Tailwind에서 인라인 스타일 변환기

Tailwind CSS 클래스를 이메일 준비가 된 HTML 템플릿용 인라인 스타일로 변환합니다.

### [온라인으로 사용해보기](https://tailwind-to-inline.vercel.app)

### 설치
`npm install tailwind-to-inline`


### 사용법

#### 파일 경로에서 사용하기

```js
import { makeStylesInline } from 'tailwind-to-inline';

const htmlTemplate = await makeStylesInline('templates/welcome-email.html', {
  name: 'John',
  cta_text: 'Complete Profile'
});
```

**매개변수:**

- `templatePath` — 템플릿 파일의 경로입니다.
- `placeholderValues` *(선택 사항)* — 템플릿 내 동적 콘텐츠를 대체할 키-값 쌍 객체입니다.

#### 원시 HTML 문자열에서부터

```js
import { makeStylesInlineFromString } from 'tailwind-to-inline';

const html = `<div class="pt-10 text-yellow-300">Hello, {{name}}</div>`;
const htmlTemplate = await makeStylesInlineFromString(html, {
  name: 'John',
});
```

**매개변수:**

- `templateString` — Tailwind CSS 클래스가 포함된 원시 HTML 문자열입니다.
- `data` *(선택 사항)* — 템플릿 내 동적 콘텐츠를 대체할 키-값 쌍 객체입니다.


### 예시
#### 원본 템플릿 `welcome-email.html`:

```html
<html>
  <body class="bg-gray-800">
    <div class="pt-10 mb-4 pl-4 max-w-[512px] relative z-20">
      <span class="mr-5 text-yellow-300">Welcome, {{name}}</span>
    </div>
    <div>
      <a href="https://example.com/complete-profile" class="bg-blue-500">
        {{cta_text}}
      </a>
    </div>
  </body>
</html>
```
#### 변환된 결과:


```html
<html>
  <body style="background-color: #1f2937;">
    <div style="position: relative; z-index: 20; max-width: 512px; margin-bottom: 1rem; padding-left: 1rem; padding-top: 2.5rem;">
      <span style="margin-right: 1.25rem; color: #fde047;">Welcome, John</span>
    </div>
    <div>
      <a href="https://example.com/complete-profile" style="background-color: #3b82f6;">
        Complete Profile
      </a>
    </div>
  </body>
</html>
```
### 기여

기여, 이슈 및 기능 요청을 환영합니다!

### 기여자

<a href="https://github.com/vardan-arm"><img src="https://github.com/vardan-arm.png" width="50" height="50" alt="vardan-arm" /></a>
<a href="https://github.com/diogomoretti"><img src="https://github.com/diogomoretti.png" width="50" height="50" alt="diogomoretti" /></a>
<a href="https://github.com/markosmk"><img src="https://github.com/markosmk.png" width="50" height="50" alt="markosmk" /></a>

### 라이선스

이 프로젝트는 MIT 라이선스를 따릅니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-09

---