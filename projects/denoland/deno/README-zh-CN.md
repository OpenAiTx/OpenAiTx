# Deno

[![](https://img.shields.io/crates/v/deno.svg)](https://crates.io/crates/deno)
[![Twitter badge][]][Twitter link] [![Bluesky badge][]][Bluesky link]
[![Discord badge][]][Discord link] [![YouTube badge][]][YouTube link]

<img align="right" src="https://deno.land/logo.svg" height="150px" alt="the deno mascot dinosaur standing in the rain">

[Deno](https://deno.com)
([/ˈdiːnoʊ/](https://ipa-reader.com/?text=%CB%88di%CB%90no%CA%8A)，发音为
`dee-no`) 是一个默认安全、开发体验极佳的 JavaScript、TypeScript 和 WebAssembly 运行时。它基于 [V8](https://v8.dev/)、[Rust](https://www.rust-lang.org/) 和 [Tokio](https://tokio.rs/) 构建。

在[文档](https://docs.deno.com/runtime/manual)中了解更多关于 Deno 运行时的信息。

## 安装

使用以下命令之一在您的系统上安装 Deno 运行时。请注意，安装 Deno 的方式有多种——完整的安装选项列表请见
[这里](https://docs.deno.com/runtime/manual/getting_started/installation)。

Shell（Mac，Linux）:

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

### 从源码构建与安装

关于从源码构建 Deno 的完整说明请见
[这里](https://github.com/denoland/deno/blob/main/.github/CONTRIBUTING.md#building-from-source)。

## 你的第一个 Deno 程序

Deno 可用于多种不同的应用，但最常见的是用于构建 Web 服务器。创建一个名为 `server.ts` 的文件，并包含以下 TypeScript 代码：

```ts
Deno.serve((_req: Request) => {
  return new Response("Hello, world!");
});
```

使用以下命令运行你的服务器：

```sh
deno run --allow-net server.ts
```

这将在本地启动一个 Web 服务器，访问
[http://localhost:8000](http://localhost:8000)。

在[文档](https://docs.deno.com/runtime/manual)中了解更多关于编写和运行 Deno 程序的信息。

## 其他资源

- **[Deno 文档](https://docs.deno.com)**：Deno 运行时、[Deno Deploy](https://deno.com/deploy) 等官方指南和参考文档。
- **[Deno 标准库](https://jsr.io/@std)**：官方支持的 Deno 程序通用工具库。
- **[JSR](https://jsr.io/)**：面向现代 JavaScript 和 TypeScript 的开源包注册中心。
- **[开发者博客](https://deno.com/blog)**：来自 Deno 团队的产品更新、教程等内容。

## 参与贡献

感谢您的参与！如需贡献，请阅读我们的
[贡献说明](.github/CONTRIBUTING.md)。

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