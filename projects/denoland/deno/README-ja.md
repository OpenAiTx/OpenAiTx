# Deno

[![](https://img.shields.io/crates/v/deno.svg)](https://crates.io/crates/deno)
[![Twitter badge][]][Twitter link] [![Bluesky badge][]][Bluesky link]
[![Discord badge][]][Discord link] [![YouTube badge][]][YouTube link]

<img align="right" src="https://deno.land/logo.svg" height="150px" alt="the deno mascot dinosaur standing in the rain">

[Deno](https://deno.com)
([/ˈdiːnoʊ/](https://ipa-reader.com/?text=%CB%88di%CB%90no%CA%8A)、発音は
`ディーノ`) は、セキュアなデフォルト設定と優れた開発体験を備えた JavaScript、TypeScript、WebAssembly のランタイムです。[V8](https://v8.dev/)、
[Rust](https://www.rust-lang.org/)、[Tokio](https://tokio.rs/) 上に構築されています。

Deno ランタイムについての詳細は
[ドキュメント](https://docs.deno.com/runtime/manual)をご覧ください。

## インストール

以下のコマンドのいずれかを使用して、お使いのシステムに Deno ランタイムをインストールしてください。
Deno のインストール方法はいくつかあり、包括的なインストールオプションの一覧は
[こちら](https://docs.deno.com/runtime/manual/getting_started/installation)で確認できます。

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

### ソースからのビルドとインストール

Deno をソースからビルドするための完全な手順は
[こちら](https://github.com/denoland/deno/blob/main/.github/CONTRIBUTING.md#building-from-source)をご覧ください。

## はじめての Deno プログラム

Deno はさまざまな用途で利用できますが、最も一般的なのは Web サーバーの構築です。`server.ts` というファイルを作成し、以下の TypeScript コードを記述します。

```ts
Deno.serve((_req: Request) => {
  return new Response("Hello, world!");
});
```

以下のコマンドでサーバーを実行します。

```sh
deno run --allow-net server.ts
```

これでローカルの Web サーバーが
[http://localhost:8000](http://localhost:8000) で起動するはずです。

Deno プログラムの記述や実行についての詳細は
[ドキュメント](https://docs.deno.com/runtime/manual)をご覧ください。

## 追加リソース

- **[Deno ドキュメント](https://docs.deno.com)**: Deno ランタイム、[Deno Deploy](https://deno.com/deploy) などの公式ガイドやリファレンス。
- **[Deno 標準ライブラリ](https://jsr.io/@std)**: Deno プログラム向けの公式サポートユーティリティ群。
- **[JSR](https://jsr.io/)**: モダンな JavaScript と TypeScript のためのオープンソースパッケージレジストリ。
- **[開発者ブログ](https://deno.com/blog)**: Deno チームからのプロダクトアップデート、チュートリアルなど。

## コントリビュートについて

ご協力ありがとうございます！貢献いただく際は
[コントリビュートガイド](.github/CONTRIBUTING.md)をお読みください。

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