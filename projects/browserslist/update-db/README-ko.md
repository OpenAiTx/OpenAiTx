# Update Browserslist DB

<img width="120" height="120" alt="Browserslist logo by Anton Popov"
     src="https://browsersl.ist/logo.svg" align="right">

[Browserslist](https://github.com/browserslist/browserslist/) 설정에서
브라우저 DB와 함께 `caniuse-lite`를 업데이트하는 CLI 도구입니다.

`last 2 versions` 또는 `>1%`와 같은 일부 쿼리는 실제
`caniuse-lite` 데이터에 의존합니다.

```sh
npx update-browserslist-db@latest
```

<a href="https://evilmartians.com/?utm_source=update-browserslist-db">
  <img src="https://evilmartians.com/badges/sponsored-by-evil-martians.svg"
       alt="Sponsored by Evil Martians" width="236" height="54">
</a>

## 정기적으로 호출해야 하는 이유

`npx update-browserslist-db@latest`는
npm, yarn, 또는 pnpm lock 파일에 있는 `caniuse-lite` 버전을 업데이트합니다.

이 업데이트는 Autoprefixer나 Babel과 같은 폴리필 도구에 새로운 브라우저 정보를 제공하고,
이미 불필요한 폴리필을 줄여줍니다.

정기적으로 실행해야 하는 이유는 세 가지입니다:

1. `last 2 versions` 또는 `>1%`와 같은 쿼리에서 최신 브라우저 버전과 통계를 사용하기 위해서입니다.
   예를 들어, 프로젝트를 2년 전에 만들고 의존성을 업데이트하지 않았다면,
   `last 1 version`은 2년 전 브라우저를 반환합니다.
2. 실제 브라우저 데이터를 사용하면 폴리필 사용이 줄어듭니다.
   이는 JS와 CSS 파일의 크기를 줄이고 웹사이트 성능을 향상시킵니다.
3. `caniuse-lite` 중복 제거: 여러 도구 간의 버전 동기화를 위해서입니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---