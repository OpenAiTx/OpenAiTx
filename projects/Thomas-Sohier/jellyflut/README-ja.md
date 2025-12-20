<img height="80" width="80" src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/icon/rounded_logo.png"/>

# Jellyflut

Flutterで作られたJellyfinクライアント

ベータ版で、まあまあ動きます。

## :warning: ニュース

プロジェクトは現在停滞しています。今のところこのプロジェクトにあまり時間も興味もありません。Flutterでのビデオプレーヤーはとても厄介です。まだ解決策を探していますが、現状ではこのアプリの開発をゆっくり進めるつもりです。

プルリクエストは常に募集しており、喜んで受け入れます。

## :gear: 機能

以下が可能です：
- [x] ビデオを再生する
- [x] 本を読む（epub/CBZ）
  - Epubは今のところかなり制限されており、単なるパーサーとHTMLビューアの組み合わせです
  - まだ改善が必要
- [x] 音楽を聴く
  - Linuxではバグがある（調査が必要、またはLinux用に別のパッケージを使う必要あり）
- [x] 写真を見る
- [x] ロギングとサーバーURL保存のためのSQLite
- [x] すべてのファイルを閲覧
- [x] ~~最大の課題はトランスコーディングを動作させることで、現時点ではファイルがダイレクトプレイ可能かどうかの判定方法がわからず、不可能な場合にJellyfinに正しいURLを送らせる方法もわかりません~~ 動作します（もうあまり動かず、10.8.0 beta 3以降壊れています）
  - Windowsでは正しく動作しません（libvlcのdllや証明書の問題で壊れているようです）
  - パソコンでは対応コーデックを手動で追加しました。コーデックが欠けている場合は、イシューを作成してもらえれば再生可能か確認します
- [x] どの画面からでも音楽をコントロール
- [x] 動画ファイルから字幕を抽出または解析
 - リモートのsrtのみ対応、mkvファイルからは解析不可（VLCを除く）

## 完了
  - [X] ログアウトボタンを追加し、適切に処理
  - [X] ログインページを改良
  - [x] ヒーローアニメーションOK
  - [x] 詳細情報の非同期読み込み
  - [x] 詳細画面からの戻る際のスタッター解消
  - [x] レスポンシブ対応（作業中）
  - [x] Dパッドによるナビゲーション（問題なさそうですが、ウェブではホームページの画面外からも選択できてしまう）
    - まだ改善の余地がありますが、現在はアプリの80％をナビゲート可能で十分です
  - [x] 複数ユーザーおよびサーバーの対応
  - [x] リサイズ時のデータ処理を改善し、APIからの再読み込みを回避
    - 現状はかなり良好で、将来的にさらなる改善が必要かもしれません
  - [X] テーマ（ダーク/ライト）
  - [X] ローカリゼーション（英語、フランス語、ドイツ語）

## Todo
  - [ ] 常にリファクタリングを行う
  - [ ] 単体テストを追加する
  - [ ] jellyfinの"transcodeReasons=0"を修正する
  - [ ] Flutter関連の問題をすべて修正し、動作を高速化する
  - [ ] IPTVをウェブ版と同等にする
    - ガイドは機能している
    - IPTVチャンネルの再生が可能
    - 録画機能を追加する必要あり

## スクリーン

 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/home.png"/>

### 携帯電話

<div style="display: flex">
 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/series_details_phone_1.png"/>
 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/series_details_phone_2.png"/>
</div>

### デスクトップ

<div style="display: flex">
 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/details_desktop.png" height="360" />
 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/series_details_desktop.png" height="360" />
 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/music_details_desktop.png" height="360" />
</div>

## はじめに

このアプリはすべてのプラットフォームで動作するはずですが、iOSとMacOSではテストされていません。

### テスト方法は？

```bash
  git clone https://github.com/Thomas-Sohier/jellyflut.git
  cd jellyflut
  flutter packages get
  flutter packages upgrade
  flutter run
```

### ビルド方法は？（Android）

```bash
  flutter build apk --release
```

### ビルド方法？（プラットフォームに依存するコンピュータ）

Linuxに特有ですが、depをインストールする必要があります

```bash
  # depend of your distro of course
  sudo apt-get update -y
  sudo apt-get install -y vlc libvlc-dev ninja-build clang libgtk-3-dev
```

```bash
  # enable desktop support at first (shouldn't be necessary but anyway)
  flutter config --enable-windows-desktop
  flutter config --enable-macos-desktop
  flutter config --enable-linux-desktop

  # build the app depending of your platform
  flutter build windows
  flutter build macos
  flutter build linux
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-20

---