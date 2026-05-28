# 🌌 GNOME ライブ壁紙エンジン

> **[今すぐ GNOME Extensions でインストール](https://extensions.gnome.org/extension/9558/gnome-wallpaper-engine/)**

複雑な設定なし。重い依存関係なし。ただ mpv、ffmpeg ＋ 拡張機能だけ。

GNOME でライブ壁紙を使うための**最もシンプルで信頼性の高い方法** — **Wayland & X11** に完全対応。

最大のパフォーマンス、低リソース使用、完全なフォーマット対応（MP4、GIF、WebM、MKV…）のために **mpv** を搭載。

このプロジェクトが気に入ったら、ぜひスター ⭐ をお願いします — 本当に助かります！

## ☕ サポート & アップデート

プロジェクトをサポートしたい場合は、こちらからどうぞ：

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/achu94)

Ko-fi で開発のアップデートや進捗、舞台裏の作業も共有していきます。

投稿を見るために寄付は必要ありません — 誰でもフォローして最新情報を受け取れます 🙂

プロジェクトを楽しんでいただけたら、GitHub での ⭐ も大歓迎です！

---

## 🎥 デモ

> GNOME (Wayland) で動作するライブ壁紙

![demo](https://raw.githubusercontent.com/achu94/gnome-wallpaper-engine/main/assets/demo.gif)

---

## ✨ 特徴

- 🎬 **統合ギャラリー:** GNOME 設定から直接壁紙を閲覧・選択可能
- 🖼️ **サムネイルプレビュー:** すべての壁紙に自動生成されるプレビュー
- 📥 **スマートインポート:** ワンクリックで動画を追加し即適用
- 🚀 **GPUアクセラレーション（デフォルトで有効）:** `hwdec=auto` を使った mpv の活用
- ⚡ **非常に低いCPU使用率:** 通常は約1～3%
- 🔄 **即時適用:** 壁紙をリアルタイムで切り替え
- 🖥️ **Wayland対応:** 多くのツールが動作しない環境でも安定稼働
- 📦 **最小限のセットアップ:** mpvとffmpegのみ必要
- 🎞️ **幅広いフォーマット対応:** MP4、GIF、WebM、MKVなど多数
- 🔁 **自動起動:** ログイン時に壁紙を自動で開始
- 🧩 **トレイアイコントグル:** 上部パネルのインジケーターの表示/非表示切替
- ⏸️ **自動一時停止（全画面）:** 全画面アプリ起動時に一時停止
- 🔋 **自動一時停止（バッテリー）:** バッテリー駆動時に省電力のため一時停止

---

## 🚧 ロードマップ

- 🎮 Steam Wallpaper Engine連携（対応壁紙の自動検出とリスト表示）
- 🎛️ 高度な再生設定（ループモード、速度調整など）
- 🎨 将来的なレンダリングエンジン（mpv非依存）

---

## 🛠 必要条件

必要なのは**mpv**のインストールのみ：

### Ubuntu / Debian / Zorin OS

```bash
sudo apt update && sudo apt install mpv ffmpeg
```

### Fedora

```bash
sudo dnf install mpv ffmpeg
```

### アーチ・リナックス

```bash
sudo pacman -S mpv ffmpeg
```

### openSUSE

```bash
sudo zypper in mpv ffmpeg
```

## 📦 インストール

### 🎖️ 公式GNOME拡張機能（最も簡単）
GNOME Extensionsのウェブサイトから直接インストールしてください：

**[GNOME Extensionsでダウンロード](https://extensions.gnome.org/extension/9558/gnome-wallpaper-engine/)**

---

### ⚡ クイックインストール（ローカルZIP）

```bash
gnome-extensions install gnome-wallpaper-engine@gjs.com.zip
```

次に：

- Wayland：ログアウトして再度ログイン
- X11：`Alt + F2` を押し、`r` と入力して Enter を押す

最後に、**拡張機能**アプリで拡張機能を有効にする  
（または有効にしていればトップパネルのインジケーターから）。

---

### 🧩 手動インストール

1. 最新リリースからZIPファイルをダウンロード
2. 次の場所に展開：

```
~/.local/share/gnome-shell/extensions/
```

3. フォルダーの名前が次のようになっていることを確認してください:

```
gnome-wallpaper-engine@gjs.com
```

4. ターミナルで次のコマンドを実行してGSettingsスキーマをコンパイルします:

```
glib-compile-schemas ~/.local/share/gnome-shell/extensions/gnome-wallpaper-engine@gjs.com/schemas/
```
5. GNOMEシェルを再起動する  
    - Wayland: ログアウトして再度ログインする  
    - X11: `Alt + F2`を押し、`r`と入力してEnterキーを押す  

6. **Extensions**アプリで拡張機能を有効にする  

---  

## 📖 使い方  

1. 拡張機能の設定を開く  
2. **「ビデオ/GIFを追加」**をクリックする  
3. ギャラリーから壁紙を選択する  
4. 壁紙が即座に適用される  
5. 必要に応じてトップパネルのインジケーターで再生の開始・停止を行う  
6. 必要に応じて設定からトレイアイコンを非表示にする  

---  

## 💡 なぜこれがあるのか  

特にWayland上のGNOMEで、シンプルで信頼性のあるライブ壁紙ソリューションが不足している問題を解決するために作りました。  

---  

## ⚖️ ライセンス  

GPL-3.0 — 無料かつオープンソースです。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-28

---