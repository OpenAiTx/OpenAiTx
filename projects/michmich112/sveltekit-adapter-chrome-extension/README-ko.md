# sveltekit-adapter-chrome-extension

[SvelteKit 앱을 위한 어댑터](https://kit.svelte.dev/docs#adapters)로, 사이트를 정적 파일 모음으로 사전 렌더링하고, manifest v3를 사용하는 크롬 확장 프로그램의 콘텐츠 소스 정책을 준수하기 위해 인라인 스크립트를 제거합니다.

> [@sveltekit/adapter-static](https://github.com/sveltejs/kit/blob/master/packages/adapter-static)를 기반으로 합니다. Svelte를 훌륭하게 만든 [이분들](https://github.com/sveltejs/kit/graphs/contributors)께 감사드립니다.

> 🚧 SvelteKit v1.0.0+를 사용 중이라면 확장 프로그램이 참조하는 모든 페이지에 대해 `prerender=true`를 설정하여 SvelteKit이 HTML 파일을 생성하도록 해야 합니다. (참조: 이슈 #27)

## 사용법

`npm i -D sveltekit-adapter-chrome-extension`로 설치한 후, `svelte.config.js`에 어댑터를 추가하세요:

```js
// svelte.config.js
import adapter from "sveltekit-adapter-chrome-extension";

export default {
  kit: {
    adapter: adapter({
      // default options are shown
      pages: "build",
      assets: "build",
      fallback: null,
      precompress: false,
      manifest: "manifest.json",
    }),
    appDir: "app",
  },
};
```
## 옵션

### pages

사전 렌더링된 페이지를 쓸 디렉토리입니다. 기본값은 `build`입니다.

### assets

정적 자산을 쓸 디렉토리입니다(`static`의 내용과 SvelteKit이 생성한 클라이언트 측 JS 및 CSS). 보통 `pages`와 같아야 하며, 기본적으로 `pages` 값과 동일하지만, 드문 경우에 페이지와 자산을 별도의 위치에 출력해야 할 수도 있습니다.

### fallback

SPA 모드의 폴백 페이지를 지정합니다. 예: `index.html`, `200.html`, `404.html`.

### precompress

`true`일 경우, brotli와 gzip으로 파일을 사전 압축합니다. `.br` 및 `.gz` 파일이 생성됩니다.

### manifest

다른 대상 플랫폼별로 다른 매니페스트를 원할 경우 매니페스트 파일 이름을 지정합니다. 예: `chrome_manifest.json`, `firefox_manifest.json`.
이 파일 이름은 `static` 디렉토리(정적 파일이 있는 디렉토리)에 존재하는 파일 이름과 일치해야 합니다. 선택된 대상 파일은 빌드 디렉토리에서 `manifest.json`으로 이름이 변경되며, 이름에 `manifest`가 포함된 다른 모든 `.json` 파일은 복사되지 않습니다.

## 라이선스

[MIT](LICENSE)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-30

---