# BookBounty

![Build Status](https://github.com/TheWicklowWolf/BookBounty/actions/workflows/main.yml/badge.svg)
![Docker Pulls](https://img.shields.io/docker/pulls/thewicklowwolf/bookbounty.svg)

<img src="/src/static/bookbounty.png" alt="image">


BookBounty is a tool for finding missing Readarr books.


## Run using docker-compose

```yaml
services:
  bookbounty:
    image: thewicklowwolf/bookbounty:latest
    container_name: bookbounty
    ports:
      - 5000:5000
    volumes:
      - /path/to/config:/bookbounty/config
      - /path/to/downloads:/bookbounty/downloads
      - /etc/localtime:/etc/localtime:ro
    restart: unless-stopped

```
---

## 環境変数による設定

特定の値は環境変数で設定できます：

* __PUID__: アプリを実行するユーザーID。デフォルトは `1000`。
* __PGID__: アプリを実行するグループID。デフォルトは `1000`。
* __readarr_address__: Readarr のURL。デフォルトは `http://192.168.1.2:8787`。
* __readarr_api_key__: Readarr のAPIキー。デフォルトは ` `。
* __libgen_address__: Library Genesis のURL。現在サポートされている唯一のURLは `http://libgen.is`。
* __sleep_interval__: ダウンロード間の待機時間（秒）。デフォルトは `0`。
* __sync_schedule__: 実行予定の時間（24時間形式のカンマ区切り）。例：14は午後2時。デフォルトは ` `。
* __minimum_match_ratio__: マッチの最低パーセンテージ。デフォルトは `90`。
* __selected_path_type__: ダウンロード構造の選択（ファイルまたはフォルダ）。デフォルトは `file`。
* __search_type__: 検索タイプの選択（フィクションまたはノンフィクション）。デフォルトは `fiction`。
* __library_scan_on_completion__: 完了時にReadarrライブラリをスキャンするかどうか。デフォルトは `True`。
* __request_timeout__: リクエストのタイムアウト（秒）。デフォルトは `120`。
* __thread_limit__: 使用するスレッドの最大数。デフォルトは `1`。
* __selected_language__: ダウンロードを言語でフィルタリング（特定の言語またはすべて）。デフォルトは `English`。これはBookBountyがReadarrメタデータプロファイルから言語を取得できない場合に使用されます。
* __preferred_extensions_fiction__: フィクションのダウンロードを拡張子でフィルタリング（カンマ区切り）。デフォルトは `.epub, .mobi, .azw3, .djvu`。
* __preferred_extensions_non_fiction__: ノンフィクションのダウンロードを拡張子でフィルタリング（カンマ区切り）。デフォルトは `.pdf .epub, .mobi, .azw3, .djvu`。
* __search_last_name_only__: 検索時に著者の姓のみを使用。デフォルトは `False`。
* __search_shortened_title__: 検索時に短縮タイトルを使用（`:`以降を削除）。デフォルトは `False`。


## 同期スケジュール

同期を開始する時間をカンマ区切りのリストで指定します（例：`2, 20`は午前2時と午後8時に同期を開始します）。
> 注意：予定開始時間から最大10分のデッドバンドがあります。


## Readarrとの統合

BookBountyをReadarrと統合する方法は2つあります：

1. `/bookbounty/downloads`をメインのReadarrフォルダに直接マッピングし、`selected_path_type=folder`を設定します。  
   この方法では正しいフォルダ構造（`/author/book/filename.ext`など）を作成し、ファイルをそれぞれのフォルダに直接ダウンロードします。

2. または、`/bookbounty/downloads`を`_unprocessed`フォルダにマッピングし、`selected_path_type=file`を設定します。
   This method downloads all files into a single folder. After a library scan in Readarr, some files may remain unmapped and require manual import.  
   After importing, you can use the "**Rename Files**" function in Readarr to organize the files into the correct folders.

For both methods, setting `library_scan_on_completion=True` automates the import process in Readarr.

**Note:** Readarr does not automatically rename files upon import.


---


<img src="/src/static/dark.png" alt="image">


---


<img src="/src/static/light.png" alt="image">


---

https://hub.docker.com/r/thewicklowwolf/bookbounty



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-14

---