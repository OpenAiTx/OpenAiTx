# Deno

[![](https://img.shields.io/crates/v/deno.svg)](https://crates.io/crates/deno)
[![Twitter badge][]][Twitter link] [![Bluesky badge][]][Bluesky link]
[![Discord badge][]][Discord link] [![YouTube badge][]][YouTube link]

<img align="right" src="https://deno.land/logo.svg" height="150px" alt="the deno mascot dinosaur standing in the rain">

[Deno](https://deno.com)
([/ˈdiːnoʊ/](https://ipa-reader.com/?text=%CB%88di%CB%90no%CA%8A)，發音為
`dee-no`) 是一個具有安全預設值且提供優異開發體驗的 JavaScript、TypeScript 和 WebAssembly 執行環境。它是建立於 [V8](https://v8.dev/)、[Rust](https://www.rust-lang.org/) 和 [Tokio](https://tokio.rs/) 之上。

進一步瞭解 Deno 執行環境，請參閱
[文件說明](https://docs.deno.com/runtime/manual)。

## 安裝

請使用下列其中一個指令將 Deno 執行環境安裝到您的系統。請注意，Deno 有多種安裝方式——完整安裝選項列表請參見
[這裡](https://docs.deno.com/runtime/manual/getting_started/installation)。

Shell（Mac、Linux）:

```sh
curl -fsSL https://deno.land/install.sh | sh
```

PowerShell（Windows）:

```powershell
irm https://deno.land/install.ps1 | iex
```

[Homebrew](https://formulae.brew.sh/formula/deno)（Mac）:

```sh
brew install deno
```

[Chocolatey](https://chocolatey.org/packages/deno)（Windows）:

```powershell
choco install deno
```

[WinGet](https://winstall.app/apps/DenoLand.Deno)（Windows）:

```powershell
winget install --id=DenoLand.Deno
```

### 從原始碼建置與安裝

完整的 Deno 原始碼建置說明請參見
[這裡](https://github.com/denoland/deno/blob/main/.github/CONTRIBUTING.md#building-from-source)。

## 您的第一個 Deno 程式

Deno 可用於多種不同應用，但最常用於建立網頁伺服器。請建立一個名為 `server.ts` 的檔案，並加入下列 TypeScript 程式碼：

```ts
Deno.serve((_req: Request) => {
  return new Response("Hello, world!");
});
```

使用以下指令執行您的伺服器：

```sh
deno run --allow-net server.ts
```

這將會在本地啟動一個網頁伺服器，網址為
[http://localhost:8000](http://localhost:8000)。

進一步瞭解如何撰寫及執行 Deno 程式，
請參閱[文件說明](https://docs.deno.com/runtime/manual)。

## 其他資源

- **[Deno 文件](https://docs.deno.com)**：官方 Deno 執行環境、[Deno Deploy](https://deno.com/deploy) 等的導覽與參考文件。
- **[Deno 標準函式庫](https://jsr.io/@std)**：官方支援的 Deno 程式常用工具庫。
- **[JSR](https://jsr.io/)**：現代 JavaScript 與 TypeScript 的開源套件註冊中心。
- **[開發者部落格](https://deno.com/blog)**：來自 Deno 團隊的產品更新、教學與更多內容。

## 貢獻

非常感謝您的協助！如果您想參與貢獻，請詳讀我們的
[貢獻說明](.github/CONTRIBUTING.md)。

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