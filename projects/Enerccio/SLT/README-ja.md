# SLT - Jetbrains IDEラインアップ向けのCommon Lisp言語プラグイン

![GitHub release (latest by date)](https://img.shields.io/github/v/release/Enerccio/SLT)
[![Version](https://img.shields.io/jetbrains/plugin/v/21132-slt.svg)](https://plugins.jetbrains.com/plugin/21132-slt)
![JetBrains plugins](https://img.shields.io/jetbrains/plugin/d/21132)
![GitHub Release Date](https://img.shields.io/github/release-date/Enerccio/SLT)
![OSS Lifecycle](https://img.shields.io/osslifecycle/Enerccio/SLT)
![GitHub](https://img.shields.io/github/license/Enerccio/SLT)
![GitHub lisp counter](https://img.shields.io/github/search/Enerccio/SLT/lisp)
[![0.1.0](https://badgen.net/github/milestones/enerccio/SLT/1)](https://github.com/enerccio/SLT/milestone/1)
[![0.2.0](https://badgen.net/github/milestones/enerccio/SLT/2)](https://github.com/enerccio/SLT/milestone/2)
[![0.3.0](https://badgen.net/github/milestones/enerccio/SLT/4)](https://github.com/enerccio/SLT/milestone/4)
[![0.4.0](https://badgen.net/github/milestones/enerccio/SLT/5)](https://github.com/enerccio/SLT/milestone/5)
[![0.5.0](https://badgen.net/github/milestones/enerccio/SLT/6)](https://github.com/enerccio/SLT/milestone/6)
![GitHub all releases](https://img.shields.io/github/downloads/Enerccio/SLT/total)
![GitHub last commit](https://img.shields.io/github/last-commit/Enerccio/SLT)
![GitHub commit activity](https://img.shields.io/github/commit-activity/m/Enerccio/SLT)
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/Enerccio/SLT)
![Lines of code](https://img.shields.io/tokei/lines/github/Enerccio/SLT)
![GitHub top language](https://img.shields.io/github/languages/top/Enerccio/SLT)
[![(want-to-support-me? T NIL)](https://img.shields.io/liberapay/receives/Enerccio.svg?logo=liberapay)](https://liberapay.com/Enerccio)
![Liberapay patrons](https://img.shields.io/liberapay/patrons/Enerccio)
[![Support me on Patreon](https://img.shields.io/endpoint.svg?url=https%3A%2F%2Fshieldsio-patreon.vercel.app%2Fapi%3Fusername%3Denerccio%26type%3Dpledges&style=flat)](https://patreon.com/enerccio)[![Support me on Patreon](https://img.shields.io/endpoint.svg?url=https%3A%2F%2Fshieldsio-patreon.vercel.app%2Fapi%3Fusername%3Denerccio%26type%3Dpatrons&style=flat)](https://patreon.com/enerccio)
![Maintenance](https://img.shields.io/maintenance/yes/2023)
![GitHub issues](https://img.shields.io/github/issues/Enerccio/SLT)
![GitHub branch checks state](https://img.shields.io/github/checks-status/Enerccio/SLT/master)

[![Subreddit subscribers](https://img.shields.io/reddit/subreddit-subscribers/SLT_IDE?style=social)](https://old.reddit.com/r/SLT_IDE/)
![GitHub forks](https://img.shields.io/github/forks/Enerccio/SLT?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/Enerccio/SLT?style=social)
![GitHub watchers](https://img.shields.io/github/watchers/Enerccio/SLT?style=social)
[![Join the chat at https://gitter.im/SLT-Plugin/community](https://badges.gitter.im/SLT-Plugin/Lobby.svg)](https://gitter.im/SLT-Plugin/community?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
![GitHub Discussions](https://img.shields.io/github/discussions/Enerccio/SLT)

![Image](https://raw.githubusercontent.com/Enerccio/SLT/master/src/main/resources/logo/logo.svg)

**このプラグインは実験的であり、いつでもクラッシュする可能性があります！すべてのバグを報告してください！**

このプラグインはJetBrains IDE向けにCommon Lispのサポートを提供します。  
修正されたSLIME/Swankプロトコルを使用してリスプインタープリタと通信し、  
Common LispのためのIDE機能を提供します。

# （ある程度の）詳細なインストールおよび使用ガイド

プラグインはマーケットプレイスからダウンロード可能です！ https://plugins.jetbrains.com/plugin/21132-slt

https://github.com/Enerccio/SLT/wiki/User-Guide

## 要件

1) IntellijベースのIDE - `Intellij Idea Community/Ultimate`でテスト済みですが主要なIDEすべてで動作するはずです  
   1) 対応バージョンは2022.2以降です

オプション（詳細はガイド参照）：

1) 対応しているLISPインタープリタのいずれかがインストールされていること：  
   * [Steel Bank Common Lisp](https://www.sbcl.org/)  
   * [Armed Bear Common Lisp](https://armedbear.common-lisp.dev/)  
   * [Clozure Common Lisp](https://ccl.clozure.com/)  
   * [Allegro CL](https://franz.com/products/allegro-common-lisp/)  
   * [CMUCL](https://www.cons.org/cmucl/)  
2) [Quicklisp](https://www.quicklisp.org/beta/) がインストールされていること

（すべての機能がすべてのインタープリタで動作するわけではありません。詳細は[FEATURES.md](https://raw.githubusercontent.com/Enerccio/SLT/master/FEATURES.md)を参照してください！）

## はじめに

https://github.com/Enerccio/SLT/wiki/User-Guide#plugin-installation を参照してください

## プラグインオプション

- SDKについては上記ガイド参照  
- 色の変更について https://github.com/Enerccio/SLT/wiki/User-Guide#change-colors-of-elements  
- インデント設定の変更について https://github.com/Enerccio/SLT/wiki/User-Guide#change-indentation-settings  

## ソースのコンパイル

リポジトリをクローンし、gradle.propertiesをIDEに合わせて変更してください。  
その後、gradleを使ってプラグインをビルドします。  
Intellij Ideaでプロジェクトとして開くことも可能です。

## 今後の機能 / 目標

* [x] 機能が十分揃ったらマーケットプレイスにアップロード  
* [x] 自動インデント  
* [x] REPL  
  * [x] REPLの戻り値インスペクション  
* [x] インタラクティブデバッグ  
* [x] 引数ヘルプ（Ctrl+P）  
* [x] インスペクション  
  * [x] 基本的なインスペクション  
  * [x] アクション  
  * [x] シンボルインスペクタ  
  * [ ] インスペクションeval  
* [x] ブレークポイント  
* [x] ドキュメント  
  * [x] Hyperspec統合  
* [x] マクロ展開（全て、1つ、通常）  
* [x] シンボル名で関数検索  
* [x] シンボル検索
* [x] バックリファレンス  
* [x] レインボーブレース  
* [ ] リファクタリング  
  * [x] ラムダを関数に抽出  
* [ ] quicklispインストール済みパッケージ / ASDFパッケージのリスト  
* [ ] まだ評価されていない修正済みトップレベルフォームのリスト  
* [ ] 実際にIDEを作る、つまり依存関係を含むプラグインではなく一つのアプリケーションとしてのプラグイン  
* [x] SDKサポート  
    * 本当のSDKではない。なぜならそれはIntellijのみで利用可能であり、（例えば）PyCharmでは利用できないため、  
      これは手動で実装されている。  
    * [x] ユーザー向けにSBCLとquicklispをダウンロード  
* [x] Lispインタープリタとquicklispの自動ダウンロード  
* [x] 複数のLispインタープリタサポート  

## ライセンス  

このプロジェクトは[Apache License v2](https://raw.githubusercontent.com/Enerccio/SLT/master/LICENSE.txt)の下でライセンスされています。  

# どうやって手伝う？  

* プラグインをインストールして試してください！  
* バグはすべて報告してください。すべて見つけられるように。[こちら](https://github.com/enerccio/SLT/issues/new)から報告できます。  
* プロジェクトが気に入ったら、スターをつけるか情報を広めてください。  
* このプロジェクトはOSSなので、知識があって何か実装したい場合はリポジトリをフォークし、PRを作成してください！  

## 寄付  

よろしければ、[Liberapay](https://liberapay.com/Enerccio/donate)や  
[Patreon](https://www.patreon.com/enerccio)を通じて私の活動を支援するための寄付をお願いします。  

# SLTとは何の略？  

SLT - スピーチ・ランゲージ・セラピー（言語療法）。LISPの唯一の治療法！  

また、Superior Lisp Toolingの逆頭字語でもあります！

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---