The Media Downloader Project
![Media Downloader logo](https://raw.githubusercontent.com/yuri-maxiutenko/MediaDownloader/master/MediaDownloader/Images/icon.png)
====================
優れた動画ダウンロードコマンドラインユーティリティ[yt-dlp](https://github.com/yt-dlp/yt-dlp)の上に構築された、小さくて使いやすいUIラッパー（C#/WPF、.NET）です。さまざまなインターネットリソース（YouTube、Vimeo、Facebookなど）から異なる品質の動画をダウンロードできます。プレイリストのダウンロードもサポートしています。

## 主な特徴

**Media Downloader** は、主要な動画提供元（YouTube、Vimeo、Facebookなど）からほぼすべての動画をダウンロードできます。リンクを渡すだけで完了です！プレイリストのリンクも問題ありません。

現在、アプリケーションは以下のダウンロード形式をサポートしています：

* 最高品質の動画
* 最高品質のMP4動画
* 直接リンクで利用可能な最高品質の動画
* 音声のみ

さらに、**Media Downloader** はダウンロード履歴をサポートし、最近使用したフォルダのリストを保存します。

インストーラーが付属しており、アプリケーション本体、[yt-dlp](https://github.com/yt-dlp/yt-dlp)、および[FFmpeg](https://ffmpeg.org/)コンバーターがすべて含まれています。

アプリケーションは現在のユーザーのAppDataフォルダにインストールされ、管理者権限は不要です。

現在、**Media Downloader** は英語とロシア語に対応しています。アプリケーションの言語は現在のWindowsロケールに基づいて自動的に選択されます。

## 必要条件

バージョン**2.1**以降、アプリケーションは**[.NET 7 Desktop Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)**を使用します。しかし、Media Downloaderは**[自己完結型アプリケーション](https://devblogs.microsoft.com/dotnet/app-trimming-in-net-5/)**として提供されるため、インストールは不要です。

また、**yt-dlp**は**[Microsoft Visual C++ 2010 Redistributable Package (x86)](https://www.microsoft.com/en-us/download/details.aspx?id=5555)**が必要です。

## スクリーンショット

動画ダウンロード中：
![Video download in progress](https://github.com/yuri-maxiutenko/MediaDownloader/blob/master/Screenshots/Annotation%202020-06-29%20210558.png?raw=true)

動画ダウンロード完了：
![Video download complete](https://github.com/yuri-maxiutenko/MediaDownloader/blob/master/Screenshots/Annotation%202020-06-29%20210909.png?raw=true)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-21

---