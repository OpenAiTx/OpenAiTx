<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://raw.githubusercontent.com/velopack/velopack/develop/artwork/velopack-white.svg">
  <img alt="Velopack ロゴ" src="https://raw.githubusercontent.com/velopack/velopack/develop/artwork/velopack-black.svg" width="400">
</picture>

---

[![Nuget](https://img.shields.io/nuget/v/Velopack?style=flat-square&logo=nuget&logoColor=white)](https://www.nuget.org/packages/Velopack/)
[![Discord](https://img.shields.io/badge/chat-Discord-5865F2?style=flat-square&logo=discord&logoColor=white)](https://discord.gg/M6he8ZPAAJ)
[![Build](https://img.shields.io/github/actions/workflow/status/velopack/velopack/build.yml?branch=develop&style=flat-square&logo=github&logoColor=white)](https://github.com/velopack/velopack/actions)
[![Codecov](https://img.shields.io/codecov/c/github/velopack/velopack?style=flat-square&logo=codecov&logoColor=white)](https://app.codecov.io/gh/velopack/velopack)
[![License](https://img.shields.io/github/license/velopack/velopack?style=flat-square)](https://github.com/velopack/velopack/blob/develop/LICENSE)

Velopackはクロスプラットフォームアプリケーションのためのインストールおよび自動アップデートのフレームワークです。意見を持った設計で、設定不要で非常に簡単に使えます。たった1つのコマンドでインストール可能なアプリケーションをすぐに用意でき、ユーザーにとっても驚くほど高速です。

## 特長

- 😍 **設定不要** – Velopackはコンパイラ出力をもとに、インストーラー、アップデート、差分パッケージ、自己更新型ポータブルパッケージをたった1つのコマンドで生成します。
- 🎯 **クロスプラットフォーム** – Velopackは**Windows**、**OSX**、**Linux**用パッケージのビルドをサポートしており、すべてのターゲットに1つのソリューションを利用できます。
- 🚀 **自動マイグレーション** - 他の人気フレームワーク（例：[Squirrel](https://github.com/Squirrel/Squirrel.Windows)）からの移行も、Velopackが自動でアプリケーションを移行します。
- ⚡️ **超高速** – VelopackはRustで記述されており、ネイティブなパフォーマンスを誇ります。差分パッケージにより、ユーザーはバージョン間の変更分だけをダウンロードします。
- 📔 **言語非依存** - C#、C++、JS、Rustなどに対応。プロジェクトの言語に関係なく、馴染みのあるAPIでアップデートを利用できます。

https://github.com/velopack/velopack/assets/1287295/0ff1bea7-15ed-42ae-8bdd-9519f1033432

## ドキュメント
- 📖 [ドキュメントを読む](https://docs.velopack.io/)
- ⚡ [クイックスタートガイド](https://docs.velopack.io/category/quick-start)
- 🕶️ [サンプルアプリを見る](https://docs.velopack.io/category/sample-apps)
- 📺 [Webサイト & デモを見る](https://velopack.io/)

## コミュニティ
- ❓ [Discord](https://discord.gg/CjrCrNzd3F)で質問、サポート、アイデアの議論ができます
- 🗣️ [GitHub Issues](https://github.com/velopack/velopack/issues)でバグ報告や機能要望ができます

## 貢献について
- 💬 開発に参加したい方は[Discord](https://discord.gg/CjrCrNzd3F)でディスカッションにご参加ください
- 🚦 [貢献ガイド](https://docs.velopack.io/category/contributing)をご一読ください

## ユーザーの声
外部向けアプリケーションでVelopackを使いました。とても感動しています。Squirrelよりも初回ビルドもアップグレードも圧倒的に速く、完璧に動作しています。30年以上開発してきましたが、これまでで最高のインストーラーです。本当にありがとうございます！素晴らしい仕事をしています！
[- Stefan (Discord)](https://discord.com/channels/767856501477343282/767856501477343286/1195642674078830613)

心から感謝を伝えたいです。Squirrel.Windowsが使えなくなってから、ここ数年はClowd.Squirrelを使っていました。今日たまたまそのリポジトリのドキュメントを探しに行ったら、Velopackのリリースを発見しました。予想外でした！素晴らしく動作し、本当に速いです。Clowd.SquirrelとVelopack、どちらにも膨大な作業が注がれており、とても感謝しています。
[- Kizari (Discord)](https://discord.com/channels/767856501477343282/767856501477343286/1200837489640878180)

多くのインストーラーフレームワークを使ってきましたが、Velopackは断トツで最高です。全てが魔法のようです：インストーラーを実行すると、アプリがすぐに開いて使える状態になり、アップデートもUACプロンプト無しで2秒ほどで適用され再起動されます。インストーラー作成も簡単でコード署名との統合も容易、コマンドラインツールでアップデータファイルのアップロードもシンプルです。面倒なインストーラースクリプトを書く必要はなく、全てアプリ本体に組み込めます！サポートも素晴らしく、私の懸念点はすべて解決されました。これこそデスクトップインストーラーの未来です。
[- RandomEngy (Discord)](https://discord.com/channels/767856501477343282/947444323765583913/1200897478036299861)

Velopackのリリース作成やアップデートのチェック・適用の速さに非常に感銘を受けました。他のツールよりも圧倒的に高速です。vpk CLIは直感的で、複雑なビルドパイプラインにも簡単に導入できます。Velopackのおかげで作業フローを効率化でき、貴重な時間を節約できました。非常におすすめできる素晴らしいツールです！
[- khdc (Discord)](https://discord.com/channels/767856501477343282/947444323765583913/1216460920696344576)


---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---