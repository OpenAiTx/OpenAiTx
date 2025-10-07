
# 🎬 yt-dlp 動画一括ダウンロードツール（Windows / Linux 対応）

> [yt-dlp](https://github.com/yt-dlp/yt-dlp) をベースにしたワンクリック動画ダウンロードスクリプトで、[NodeSeek 氏の共有](https://www.nodeseek.com/post-334093-2#15)に触発されました。
> 単一動画および一括ダウンロードに対応し、Windows と主要な Linux ディストリビューション（Debian / Ubuntu / Alpine / CentOS）に対応しています。

---

## ✨ 機能特徴

* 📥 **ワンクリック実行**：手動設定不要、プロンプトに従って入力するだけでダウンロード開始
* 🍪 **カスタム Cookie 対応**：ログインが必要な動画のダウンロードに対応（⚠️ この機能は未検証でバグの可能性あり）
* 📂 **出力フォルダのカスタマイズ対応**：指定フォルダに簡単保存
* 📃 **一括ダウンロード対応**：`urls.txt` ファイル内のリンクを自動で読み込みダウンロード
* ⚙️ **依存関係の自動インストール**：Linux 環境下で `yt-dlp` と `ffmpeg` を自動インストール

---

## 🖼️ スクリーンショットプレビュー

| サンプル 1                                                              | サンプル 2                                                              |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| ![サンプル 1](https://img.uutv.dpdns.org/file/1746720584399_1000193433.jpg) | ![サンプル 2](https://img.uutv.dpdns.org/file/1746720581006_1000193434.jpg) |
| ![サンプル 3](https://img.uutv.dpdns.org/file/1746720588978_1000193428.jpg) | ![サンプル 4](https://img.uutv.dpdns.org/file/1746720587272_1000193427.jpg) |

---

## 🪟 Windows 使用方法

1. 以下のファイルをダウンロードしてください：

   * [`yt-dlp.exe`](https://github.com/yt-dlp/yt-dlp)
   * [`ffmpeg` Windows 版](https://www.gyan.dev/ffmpeg/builds/ffmpeg-git-full.7z)

2. 解凍後、以下のファイルを同じフォルダ（例：`yt-dlp` フォルダ）に入れてください：

   * `yt-dlp.exe`
   * `ffmpeg.exe`
   * `ffprobe.exe`
   * `yt-dlp.bat`（スクリプトファイル）
3. ダブルクリックで `yt-dlp.bat` を実行し、指示に従って動画をダウンロードします。  
4. config/config.ini を編集してデフォルト設定を変更します。  

---  

## 🐧 Linux 使用方法(科技lion大佬最新スクリプトにも同様の機能スクリプトが統合されています)  

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-07

---