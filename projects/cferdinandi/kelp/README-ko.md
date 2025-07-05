# Kelp

HTML을 사랑하는 사람들을 위한 UI 라이브러리, 최신 CSS와 Web Components로 구동됩니다.

**[문서 읽기 &rarr;](https://kelpui.com)**

_**참고:** Kelp는 현재 알파 단계에서 개발 중입니다. 자유롭게 사용하고, 실험하며, 버그를 보고해 주시길 바랍니다. 다만 시간이 지남에 따라 변경될 수 있음을 이해해 주시기 바랍니다._



## 빠른 시작

Kelp는 빌드 과정 없이 작동합니다.

[CDN](https://cdn.jsdelivr.net/npm/kelpui/)이 가장 빠르고 간단한 시작 방법이지만, [GitHub에서 파일을 다운로드](https://github.com/cferdinandi/kelp)할 수도 있습니다.

```html
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/kelpui@0/css/kelp.css">
```

Kelp는 시맨틱 버저닝을 사용합니다. CDN에서 `@1.2.3` 구문을 사용하여 메이저, 마이너 또는 패치 버전을 가져올 수 있습니다. 사용 가능한 모든 버전은 [릴리스](https://github.com/cferdinandi/kelp/tags)에서 확인할 수 있습니다.



## 데모

포함된 `index.html` 파일은 Kelp의 모든 기능과 컴포넌트를 하나의 거대한 파일에 담은 키친 싱크 데모입니다.

베타 단계에서는 Kelp에 컴파일 과정이 없습니다. 웹 컴포넌트는 ES import를 사용하며, 실행을 위해 로컬 서버가 필요합니다.

선호하는 서버를 사용하거나, `npm run dev`로 포함된 `http-server`를 사용할 수 있습니다.

```bash
npm install
npm run dev
```

Kelp가 v1에 가까워지면 컴파일 과정을 추가하여 이러한 작업이 필요 없게 될 예정입니다.



## 테스트

Kelp는... 

- 테스트에 [Playwright](https://playwright.dev) 사용
- 린팅 및 포매팅에 [Biome](https://biomejs.dev) 사용
- 배포 및 PR에서 지속적인 통합 프로세스 사용

```bash
# 테스트 실행
npm run test

# 린터 실행
npm run lint
```



## 라이선스

[Kelp Commons License](https://github.com/cferdinandi/kelp/blob/main/LICENSE.md) 하에 무료로 사용할 수 있습니다. [상업용 라이선스 옵션](/license/)도 제공됩니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---