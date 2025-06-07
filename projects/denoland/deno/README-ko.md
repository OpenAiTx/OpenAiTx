# Deno

[![](https://img.shields.io/crates/v/deno.svg)](https://crates.io/crates/deno)
[![Twitter badge][]][Twitter link] [![Bluesky badge][]][Bluesky link]
[![Discord badge][]][Discord link] [![YouTube badge][]][YouTube link]

<img align="right" src="https://deno.land/logo.svg" height="150px" alt="the deno mascot dinosaur standing in the rain">

[Deno](https://deno.com)
([/ˈdiːnoʊ/](https://ipa-reader.com/?text=%CB%88di%CB%90no%CA%8A), 발음은
`디노`)는 안전한 기본값과 뛰어난 개발자 경험을 제공하는 JavaScript, TypeScript, WebAssembly 런타임입니다. Deno는 [V8](https://v8.dev/),
[Rust](https://www.rust-lang.org/), [Tokio](https://tokio.rs/) 위에 구축되었습니다.

Deno 런타임에 대해 더 알고 싶다면
[문서](https://docs.deno.com/runtime/manual)를 참고하세요.

## 설치

아래 명령어 중 하나를 사용하여 시스템에 Deno 런타임을 설치할 수 있습니다. Deno를 설치하는 방법은 여러 가지가 있으며, 모든 설치 옵션의 종합 목록은
[여기](https://docs.deno.com/runtime/manual/getting_started/installation)에서 확인할 수 있습니다.

Shell (Mac, Linux):

```sh
curl -fsSL https://deno.land/install.sh | sh
```

PowerShell (Windows):

```powershell
irm https://deno.land/install.ps1 | iex
```

[Homebrew](https://formulae.brew.sh/formula/deno) (Mac):

```sh
brew install deno
```

[Chocolatey](https://chocolatey.org/packages/deno) (Windows):

```powershell
choco install deno
```

[WinGet](https://winstall.app/apps/DenoLand.Deno) (Windows):

```powershell
winget install --id=DenoLand.Deno
```

### 소스에서 빌드 및 설치

Deno를 소스에서 빌드하는 방법에 대한 전체 지침은
[여기](https://github.com/denoland/deno/blob/main/.github/CONTRIBUTING.md#building-from-source)에서 확인할 수 있습니다.

## 나의 첫 번째 Deno 프로그램

Deno는 다양한 애플리케이션에 사용할 수 있지만, 주로 웹 서버를 구축하는 데 많이 사용됩니다. `server.ts`라는 파일을 만들고 다음 TypeScript 코드를 입력하세요:

```ts
Deno.serve((_req: Request) => {
  return new Response("Hello, world!");
});
```

다음 명령어로 서버를 실행하세요:

```sh
deno run --allow-net server.ts
```

이렇게 하면 [http://localhost:8000](http://localhost:8000)에서 로컬 웹 서버가 시작됩니다.

Deno 프로그램 작성 및 실행에 대해 더 알고 싶다면
[문서](https://docs.deno.com/runtime/manual)를 참고하세요.

## 추가 자료

- **[Deno 문서](https://docs.deno.com)**: Deno 런타임, [Deno Deploy](https://deno.com/deploy) 등 공식 가이드 및 참고 문서.
- **[Deno 표준 라이브러리](https://jsr.io/@std)**: Deno 프로그램을 위한 공식 지원 공용 유틸리티.
- **[JSR](https://jsr.io/)**: 최신 JavaScript 및 TypeScript를 위한 오픈소스 패키지 레지스트리
- **[개발자 블로그](https://deno.com/blog)**: Deno 팀의 제품 업데이트, 튜토리얼 등 다양한 소식.

## 기여하기

여러분의 도움에 감사드립니다! 기여를 원하신다면,
[기여 지침](.github/CONTRIBUTING.md)을 읽어주세요.

[Build status - Cirrus]: https://github.com/denoland/deno/workflows/ci/badge.svg?branch=main&event=push
[Build status]: https://github.com/denoland/deno/actions
[Twitter badge]: https://img.shields.io/twitter/follow/deno_land.svg?style=social&label=Follow
[Twitter link]: https://twitter.com/intent/follow?screen_name=deno_land
[Bluesky badge]: https://img.shields.io/badge/Follow-whitesmoke?logo=bluesky
[Bluesky link]: https://bsky.app/profile/deno.land
[YouTube badge]: https://img.shields.io/youtube/channel/subscribers/UCqC2G2M-rg4fzg1esKFLFIw?style=social
[YouTube link]: https://www.youtube.com/@deno_land
[Discord badge]: https://img.shields.io/discord/684898665143206084?logo=discord&style=social
[Discord link]: https://discord.gg/deno

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---