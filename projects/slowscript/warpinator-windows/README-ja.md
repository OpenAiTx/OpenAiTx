# Windows用Warpinator（非公式）

これはLinux Mintのファイル共有ツール[Warpinator](https://github.com/linuxmint/warpinator)の非公式なWindows 7以降向け再実装です。

Linux、Windows、Androidデバイス間でファイルを転送します

## ⚠️ 警告：偽の悪意のあるウェブサイト

`http://warpinator.com`は偽のウェブサイトで、悪意がある可能性があります！

そこからソフトウェアをダウンロードしたり実行したりしないでください！

誰が管理しているか不明です。[Linux Mintチームからの注意](https://github.com/linuxmint/warpinator?tab=readme-ov-file#%EF%B8%8F-warning-fakemalicious-website)を参照してください。

## ダウンロード
現在は[Releases](https://github.com/slowscript/warpinator-windows/releases)ページで入手可能です

またはwinget経由でインストール可能です：  
`winget install slowscript.Warpinator`

## ビルド
.NET SDK 4.7.2が必要です

Visual Studioでビルドしてください

### スクリーンショット
![screenshot](https://raw.githubusercontent.com/slowscript/warpinator-windows/master/screenshot.png)

## 翻訳
最新のVisual Studioが必要です
1) ResourcesフォルダにStrings.xx.resxという名前の新しいリソースファイルを作成します。xxは翻訳する言語のコードです
2) Strings.resxからテーブル全体をコピーし、値を翻訳します。コメントは文脈のためのものです
3) Controls\TransferPanel、Form1、SettingsForm、TransferFromをデザイナーで開き、それぞれで4〜6を繰り返します
4) 最上位要素（ウィンドウ全体）を選択し、プロパティのLanguageを翻訳言語に切り替えます
5) テキストがあるコントロール（ボタン、ラベル、メニュー）を選択して「Text」プロパティを翻訳します。実行時に置き換えられる明らかなプレースホルダーは翻訳不要です。アプリケーションを実行して（ツールバーの緑の再生矢印）確認できます。また、TransferPanelの2つのボタンは他の2つの下に隠れています
6) 新しい文字列に合わせてコントロールの移動やサイズ変更も可能で、選択中の言語にのみ影響します


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-20

---