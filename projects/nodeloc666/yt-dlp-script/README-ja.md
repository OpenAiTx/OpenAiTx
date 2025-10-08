
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>


# 🎬 yt-dlp 動画一括ダウンロードツール（Windows / Linux 対応）

> [yt-dlp](https://github.com/yt-dlp/yt-dlp) をベースにしたワンクリック動画ダウンロードスクリプト。[NodeSeek 氏の共有](https://www.nodeseek.com/post-334093-2#15)にインスパイアされました。
> 単体動画と一括ダウンロードの両方に対応し、Windows および主要な Linux ディストリビューション（Debian / Ubuntu / Alpine / CentOS）に対応しています。

---

## ✨ 機能の特徴

* 📥 **ワンクリック実行**：手動設定不要、指示に従って入力すればすぐにダウンロード開始
* 🍪 **カスタムCookie対応**：ログインが必要な動画のダウンロードに対応（⚠️ この機能は未検証でバグの可能性あり）
* 📂 **カスタム出力ディレクトリ対応**：指定フォルダへの保存が簡単
* 📃 **バッチダウンロード対応**：`urls.txt` ファイル内のリンクを自動で読み込みダウンロード
* ⚙️ **依存関係自動インストール**：Linux環境で `yt-dlp` と `ffmpeg` を自動インストール

---

## 🖼️ スクリーンショットプレビュー

| サンプル 1                                                                 | サンプル 2                                                                 |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| ![サンプル 1](https://img.uutv.dpdns.org/file/1746720584399_1000193433.jpg) | ![サンプル 2](https://img.uutv.dpdns.org/file/1746720581006_1000193434.jpg) |
| ![サンプル 3](https://img.uutv.dpdns.org/file/1746720588978_1000193428.jpg) | ![サンプル 4](https://img.uutv.dpdns.org/file/1746720587272_1000193427.jpg) |

---

## 🪟 Windows の使い方

1. 以下のファイルをダウンロードしてください：

   * [`yt-dlp.exe`](https://github.com/yt-dlp/yt-dlp)
   * [`ffmpeg` Windows 版](https://www.gyan.dev/ffmpeg/builds/ffmpeg-git-full.7z)

2. 解凍後、次のファイルを同じディレクトリ（例：`yt-dlp` フォルダ）に配置してください：

   * `yt-dlp.exe`
   * `ffmpeg.exe`
   * `ffprobe.exe`
   * `yt-dlp.bat`（スクリプトファイル）

3. `yt-dlp.bat` をダブルクリックして、指示に従い動画をダウンロードしてください。
4. config/config.ini を編集してデフォルト設定を変更できます

---

## 🐧 Linux の使い方（テクノロジーlion氏の最新スクリプトにも同機能が統合されています）

**対応システム**：Debian / Ubuntu / Alpine / CentOS

ワンクリックでデプロイまたは更新して実行：

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/install.sh)"
```
アンインストールするには：


```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/uninstall.sh)"
```

---

## 📱 Android 使用推薦

1. 使用 [Seal](https://github.com/JunkFood02/Seal) アプリで、Android 上で `yt-dlp` 機能を体験できます。
2. termuxでDebianをインストールしてもダウンロード可能ですが、わざわざ使う必要はなく、Sealが非常に使いやすいです。

---

## ⚠️ 注意事項

1. **一括ダウンロードモード**：スクリプトは現在のディレクトリの `config\urls.txt` を自動的に読み込み、1行に1つの動画リンクを期待します。ファイルが存在しない場合は自動で作成されます。
2. **リソース使用に関する注意**：メモリが少ないデバイスでは複数の大きな動画を同時にダウンロードしたり、高すぎる並列スレッド数の設定は避けてください。
3. **CentOS 特別説明**：環境が特殊なため、全面的なテストはされていません。非本番環境での使用を推奨します。他の主要なシステムは動作確認済みです。
4. Linux版の小さなバグ：スクリプトがトップページに到達すると依存関係を一度チェックします。コードが動けば良いという方針なので修正していません。
5. Windows版の小さなバグ：他のページからトップページに戻り再度選択すると、デフォルト選択肢が無効になりループする場合があります。対応能力に限界があり、修正できていません。
二つの解決策：
    1. 終了して再起動する
    2. デフォルトは使わず、数字で選択する

---

## 📄 ライセンス

本プロジェクトは [MIT License](https://opensource.org/licenses/MIT) に準拠しています。

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-08

---