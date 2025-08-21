
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# ロゼッタストンクス

- [紹介](#introduction)
- [インストール](#install)
  - [Chrome](#chrome-based-browsers)
    - [ビジュアルガイド](#chrome-based-browsers)
  - [Firefox](#firefox-based-browsers)
- [使い方](#how-to-use)
  - [時間の追加](#adding-time)
    - [基礎](#adding-time-in-foundations)
    - [流暢性ビルダー](#adding-time-in-fluency-builder)
  - [レッスンの検証](#validating-lesson)
    - [基礎](#validating-lesson-in-foundations)
    - [流暢性ビルダー](#validating-lesson-in-fluency-builder)

## はじめに

RosettaStonksは、ロゼッタストーン語学学習プラットフォームで時間の追加とレッスンの検証ができるブラウザー拡張機能です。

> RosettaStonksで、あなたのロゼッタストーンがストンクスになります。

## インストール

### Chrome系ブラウザー

➡️ **Chrome拡張機能を手動でインストールするのが初めてですか？** [ステップバイステップのビジュアルガイド](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md)をご覧ください — 便利なスクリーンショット付き！🖼️

#### 1. GitHubリリースを利用する

Chrome系ブラウザーで拡張機能を利用するには、以下の手順を行います：

- 最新リリースから `rosettastonks-chrome.tar.gz` ファイルをダウンロードして
  あなたのパソコンに保存します。
- 拡張機能を格納するために、パソコン上の任意の場所に `rosettastonks` というフォルダーを作成します
- `rosettastonks` フォルダー内で以下のコマンドを実行します。



```bash
$ tar xvzf /path/to/rosettastonks-chrome.tar.gz
```

2. nixパッケージマネージャの使用

以前のコマンドの代わりに、flakesを**サポートする**nixシステム上にいる場合は、以下のコマンドを実行できます。これにより、すべてのファイルを含むフォルダが`/tmp/rosettastonks`のパスにインストールされます。



```bash
$ nix build --out-link "/tmp/rosettastonks" github:m1dugh/RosettaStonks#chrome
```

フォルダは現在 `/tmp/rosettastonks/` にインストールされています。

**この部分は、github方式を使用しているかnix方式を使用しているかに関係なく、すべてのユーザー向けです。**

ブラウザで：

- `chrome://extensions` にアクセス
- `Developer mode` トグルをオンにする
- `Load unpacked` をクリック
- `rosettastonks` フォルダを選択

### Firefox ベースのブラウザ

- 最新リリースから `rosettastonks.xpi` ファイルをダウンロードします。
- または、flakeサポート付きのnixパッケージマネージャを使用している場合、以下のコマンドを実行できます。



```bash
$ nix build --out-link "/tmp/rosettatonks.xpi" github:m1dugh/RosettaStonks#mozilla
```
- ブラウザで `about:addons` にアクセスします  
- 設定ボタンをクリックし、`Debug addons` に移動します。  
- `Load Temporary Add-On` をクリックします  
- ファイルピッカーで `/tmp/rosettastonks.xpi` ファイルを選択します。  

_警告: この方法は拡張機能を一時的にインストールするだけであり、  
ブラウザを閉じるとアドオンはアンインストールされます。これは、  
Firefoxのポリシーにより未検証の拡張機能の使用が許可されていないためです。_

## 使い方

### 時間の追加

#### Foundationsでの時間追加

`foundations` 製品で時間を追加するには、演習にアクセスし、  
少なくとも1つの質問を無視または解決する必要があります。これが完了すると、  
拡張機能ページに時間を追加できる時間フィールドが表示されます。  

#### Fluency builderでの時間追加

`fluency builder` 製品で時間を追加するには、演習にアクセスし、  
少なくとも1つの演習に回答する必要があります。時間追加フィールドが表示されない場合、  
時間リクエストが検出されていないことを意味します。その場合は質問をリフレッシュして  
再度回答してください。時間を追加するには、時間を追加したレッスンを終了する必要があります。  

_注意: 時間追加フィールドが表示されない場合、Rosetta Stoneのウェブサイトでの操作が  
正当な時間追加につながっていないため、別の質問に回答する必要があります。_

### レッスンの検証

#### Foundationsでのレッスン検証

レッスンを検証するには、レッスンを開始し、すべての質問を右下の`ignore`ボタンで  
進める必要があります。すべての質問を見終わったら、`validate lesson`ボタンをクリックすると  
レッスンが検証されます。もし検証されない場合は、ホームページに戻り、同じレッスンをクリックし、それ




`続行しますか、それともリセットしますか？`と尋ねられたら、どちらも選択でき、
動作するまでレッスンを再度検証してください。最大で3～4回で動作するはずです。

#### Fluency builderでのレッスン検証

現在、Rosetta Stonksではレッスン検証機能は利用できません。

## アプリケーションのビルド

### ワーカーのビルド

ワーカーは次のコマンドでパッケージ化できます。

```
$ deno task build:worker
```

`/dist/worker.esm.js` というパッケージ化されたファイルを作成します。これはワーカー用のパッケージ化ファイルです。

### フロントエンドのビルド

ワーカーは次のコマンドを使用してパッケージ化できます。


```
$ deno task build:frontend
```

これはフロントエンド用のパッケージ化されたファイル `/dist/frontend.esm.js` を作成します。

## 拡張機能のパッケージ化

### Chrome

Chrome用の拡張機能をパッケージ化するには、以下のコマンドを実行します:


```
$ make chrome
```

### Firefox

Firefox用の拡張機能をパッケージ化するには、以下のコマンドを実行します:

```
$ make firefox
```

`rosettastonks.xpi` を生成します。これは Firefox に読み込むことができる拡張機能のファイルです。

📸 視覚的な説明が好みですか？[画像付きChromeインストールガイド](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md) をご覧ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---