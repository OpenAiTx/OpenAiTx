<img src=".github/splash.png" alt="Tauri" />

[![status](https://img.shields.io/badge/status-stable-blue.svg)](https://github.com/tauri-apps/tauri/tree/dev)
[![License](https://img.shields.io/badge/License-MIT%20or%20Apache%202-green.svg)](https://opencollective.com/tauri)
[![test core](https://img.shields.io/github/actions/workflow/status/tauri-apps/tauri/test-core.yml?label=test%20core&logo=github)](https://github.com/tauri-apps/tauri/actions/workflows/test-core.yml)
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_shield)
[![Chat Server](https://img.shields.io/badge/chat-discord-7289da.svg)](https://discord.gg/SpmNs4S)
[![website](https://img.shields.io/badge/website-tauri.app-purple.svg)](https://tauri.app)
[![https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg](https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg)](https://good-labs.github.io/greater-good-affirmation)
[![support](https://img.shields.io/badge/sponsor-Open%20Collective-blue.svg)](https://opencollective.com/tauri)

## はじめに

Tauriは、すべての主要なデスクトッププラットフォーム向けに小さく非常に高速なバイナリを構築するためのフレームワークです。開発者は、ユーザーインターフェースの構築にHTML、JS、CSSへコンパイルできる任意のフロントエンドフレームワークを統合できます。アプリケーションのバックエンドはRustで構築されたバイナリであり、APIを通じてフロントエンドと連携します。

Tauriアプリのユーザーインターフェースは、現在、macOS、Windows、Linux、Android、iOSにおいてウィンドウ管理ライブラリとして[`tao`](https://docs.rs/tao)を利用しています。アプリケーションの描画には、Tauriは[WRY](https://github.com/tauri-apps/wry)というライブラリを使用し、システムWebViewへの統一インターフェースを提供します。これは、macOSおよびiOSではWKWebView、WindowsではWebView2、LinuxではWebKitGTK、AndroidではAndroid System WebViewを利用します。

これらすべての構成要素がどのように連携しているかの詳細については、[ARCHITECTURE.md](https://github.com/tauri-apps/tauri/blob/dev/ARCHITECTURE.md)ドキュメントをご参照ください。

## はじめるには

Tauriアプリの作成に興味がある場合は、[ドキュメントサイト](https://tauri.app)をご覧ください。

最も手早く始める方法は、システムに合わせて[必要な前提条件](https://v2.tauri.app/start/prerequisites/)をインストールし、[`create-tauri-app`](https://github.com/tauri-apps/create-tauri-app/#usage)を使って新しいプロジェクトを作成することです。例えば、`npm`を使用する場合は次の通りです:

```sh
npm create tauri-app@latest
```

## 機能

Tauriの主な機能は、以下に限りませんが、次の通りです:

- `.app`、`.dmg`、`.deb`、`.rpm`、`.AppImage`といった形式や、Windowsインストーラー（NSISによる`.exe`、WiXによる`.msi`）など、さまざまな形式でアプリバンドルを作成するための組み込みバンドラー
- 組み込みのセルフアップデーター（デスクトップのみ）
- システムトレイアイコン
- ネイティブ通知
- ネイティブWebViewプロトコル（TauriはWebViewのコンテンツを提供するためにローカルホストのhttp(s)サーバーを作成しません）
- 効率化されたCIのためのGitHubアクション
- VS Code拡張機能

### 対応プラットフォーム

Tauriは現在、以下のプラットフォームでの開発および配布をサポートしています:

| プラットフォーム | バージョン                                                                                       |
| :-------------- | :---------------------------------------------------------------------------------------------- |
| Windows         | 7以降                                                                                           |
| macOS           | 10.15以降                                                                                       |
| Linux           | Tauri v1はwebkit2gtk 4.0（例: Ubuntu 18.04）、Tauri v2はwebkit2gtk 4.1（例: Ubuntu 22.04）       |
| iOS/iPadOS      | 9以降                                                                                           |
| Android         | 7以降（現在は8以降）                                                                            |

## 貢献方法

作業を始める前に、既存のIssueがあるかどうかを確認するのが最善です。また、Discordサーバーに立ち寄り、チームに確認してから作業することや、すでに誰かが取り組んでいないか確認することもおすすめします。

プルリクエストを作成する前に、必ず[コントリビューションガイド](./.github/CONTRIBUTING.md)をお読みください。

Tauriに貢献してくださる皆様に感謝します！

### ドキュメント

多言語システムにおけるドキュメント作成は難しい課題です。そのため、RustおよびJSのソースコード内でのインラインドキュメントをできるだけ利用する方針です。ドキュメントサイトのホスティングリポジトリについては、以下をご覧ください: <https://github.com/tauri-apps/tauri-docs>

## パートナー

<table>
  <tbody>
    <tr>
      <td align="center" valign="middle">
        <a href="https://crabnebula.dev" target="_blank">
          <img src=".github/sponsors/crabnebula.svg" alt="CrabNebula" width="283">
        </a>
      </td>
    </tr>
  </tbody>
</table>

スポンサーの全リストは、[ウェブサイト](https://tauri.app#sponsors)および[Open Collective](https://opencollective.com/tauri)をご覧ください。

## 組織

Tauriは、[持続可能な自由かつオープンなソフトウェアコミュニティ](https://sfosc.org)を導く原則に基づく持続可能なコレクティブを目指しています。そのため、[Commons Conservancy](https://commonsconservancy.org/)内のプログラムとなり、[Open Collective](https://opencollective.com/tauri)を通じて財政的な貢献も可能です。

## ライセンス

コード: (c) 2015 - 現在 - The Commons Conservancy内のTauri Programme

MITまたは該当する場合はMIT/Apache 2.0

ロゴ: CC-BY-NC-ND

- Tauriロゴのオリジナルデザイン: [Alve Larsson](https://alve.io/)、[Daniel Thompson-Yvetot](https://github.com/nothingismagick)、[Guillaume Chau](https://github.com/akryum)

[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_large)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---