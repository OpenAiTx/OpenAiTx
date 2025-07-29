# Pebble用IntelliJプラグイン [![Gitter](https://badges.gitter.im/bjansen/pebble-intellij.svg)](https://gitter.im/bjansen/pebble-intellij) [![GitHub Actions](https://github.com/bjansen/pebble-intellij/workflows/Java%20CI/badge.svg?branch=master)](https://github.com/bjansen/pebble-intellij/actions) [![GitHub release](https://img.shields.io/github/release/bjansen/pebble-intellij.svg)](https://plugins.jetbrains.com/plugin/9407-pebble) [![Coverage](https://sonarcloud.io/api/project_badges/measure?project=pebble-intellij&metric=coverage)](https://sonarcloud.io/dashboard?id=pebble-intellij)

このプラグインは[IntelliJ IDEA 2017.3以降](https://github.com/PebbleTemplates/pebble)での  
[Pebbleテンプレートエンジン](https://github.com/PebbleTemplates/pebble)のサポートを提供します。

<p align="center">
  <img src="https://github.com/bjansen/pebble-intellij/raw/master/images/plugin.png" 
       width="594" alt="Pebble用IntelliJプラグイン"/>
<p>

## 機能

* パーサー/レキサー<sup>1</sup> と構文ハイライト（カスタムデリミタ対応）
* 組み込みタグ用ライブテンプレート
* 括弧の対応、コード折りたたみ、コメント化
* クオートハンドラ
* ナビゲーション（メソッド・フィールド、インクルードファイル）
* コード補完
* 未知の参照のハイライト
* [pebble-spring](https://github.com/PebbleTemplates/pebble/wiki/spring-integration)で導入された変数や関数のサポート
* [今後の機能追加予定](https://github.com/bjansen/pebble-intellij/issues?utf8=%E2%9C%93&q=is%3Aissue%20is%3Aopen%20label%3At-feature)

<sup>1</sup>: *カスタム演算子は現在サポートされていません*。

## インストール

このプラグインはJetBrainsの[プラグインリポジトリ](https://plugins.jetbrains.com/idea/plugin/9407-pebble)で利用可能です。  
IDEの `Preferences > Plugins` に行き、検索バーに `pebble` と入力してください。

## Pebbleと他言語の混在

同一ファイル内でHTMLとPebbleのように2つの言語を認識させるには、  
`Preferences > Languages & Frameworks > Template Data Languages` に移動し、  
Pebbleテンプレートを含むディレクトリに対して `HTML` のデータ言語を選択してください：

![テンプレートデータ言語設定](https://raw.githubusercontent.com/bjansen/pebble-intellij/master/images/settings.png)

これにより構文ハイライト、コード補完、ナビゲーション、Emmet展開などの機能が利用可能になります。

## コード補完の使用方法

コード補完を使うには、`foo` の型をプラグインに知らせる必要があります。  
これはJSP、FreeMarker、Velocityプラグインと同様に `@pebvariable` ヒントを使って行います：

![コード補完](https://raw.githubusercontent.com/bjansen/pebble-intellij/master/images/completion.png)

`@pebvariable` ヒントは `var` ライブテンプレートで簡単にテンプレートに追加できます。  
以下の構文に従う必要があります：

    {# @pebvariable name="<name>" type="<type>" #}

コード補完が正しく機能するには、`.peb` ファイルが[コンテンツルート](https://www.jetbrains.com/help/idea/content-roots.html)（例：`src/main/resources`）の下に配置されている必要があります。  
そうでない場合は、自身のソースファイルで定義されたクラスは補完候補に表示されません。

## ナイトリービルド

スナップショットビルドはActions CIで利用可能です：  
 * https://github.com/bjansen/pebble-intellij/actions にアクセス  
 * 最新ビルドをクリック  
 * ページ下部の `Artifacts` セクションで `pebble-intellij-development` をクリック  
 * これによりZIPファイルがダウンロードされ、IDEの[ディスクからプラグインをインストール](https://www.jetbrains.com/help/idea/managing-plugins.html#install_plugin_from_disk)でインストール可能です。






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---