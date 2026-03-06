# LetterboxdからIMDbへ

[![GitHub stars](https://img.shields.io/github/stars/TobiasPankner/Letterboxd-to-IMDb.svg?style=social&label=Star)](https://GitHub.com/TobiasPankner/Letterboxd-to-IMDb/stargazers/)
[![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=3TU2XDBK2JFU4&source=url)

- [前提条件](#prerequisites)
- [スクリプトの実行](#run-the-script)
- [IMDbのクッキー取得方法](#getting-the-imdb-cookie)
- [よくある利用例](#common-use-cases)
- [コマンドラインオプション](#command-line-options)

Letterboxdの映画をIMDbにインポートするPythonスクリプト。  

動作概要：  
スクリプトはまずzipファイル内のすべてのLetterboxdリンクを「訪問」し、対応するIMDbページを取得します。これにより、正しい映画に評価を付けることが保証されます。  
その後、クッキーを使って内部のIMDb GraphQL評価APIへの認証リクエストを行います。  

**動画チュートリアル**はこちら：<https://www.youtube.com/watch?v=KF7cfdUTEgw>

## オンラインでスクリプトを実行（Python不要）

[![Run Script](https://simple-script.com/api/badge/letterboxd-to-imdb)](https://simple-script.com/app/letterboxd-to-imdb)

## 前提条件  
  
- Python 3 ([ダウンロード](https://www.python.org/downloads/))
- [Letterboxd](https://letterboxd.com/) アカウント
- [IMDb](https://www.imdb.com/) アカウント

## スクリプトの実行方法

 1. Letterboxdの評価とウォッチリストをエクスポートする（[方法はこちら](https://listy.is/help/how-to-export-letterboxd-watchlists-reviews/)）
 2. [IMDbのクッキーを取得](#getting-the-imdb-cookie)し、スクリプトフォルダに「cookie.txt」として保存する
 3. 依存関係をインストール：`pip install -r requirements.txt`
 4. letterboxd2imdb.pyを実行：`python letterboxd2imdb.py -f <あなたのZIPファイル>.zip`

[よくある利用例](#common-use-cases)

## IMDbのクッキー取得方法

**このクッキーはパスワードと同じように扱ってください！**

  1. IMDbアカウントにログインする
  2. Chromeの開発者ツールを開く -> ネットワーク
  3. Fetch/XHRでフィルターをかける
  4. ページをリロードする
  5. リクエストの一つのクッキーをコピーする（右クリック -> 値をコピー）
  
  ![例](https://imgur.com/chRo9wj.jpg)  

## よくある使用例

**評価とウォッチリストを転送する：**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -w`

**評価が5/10の視聴済み映画を転送する：**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -r 5`

**評価なしの視聴済み映画のIMDbリストを作成する：**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -l`

**評価なしの視聴済み映画のカスタム名付きIMDbリストを作成する：**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -l --list-name "My Letterboxd Movies"`

## コマンドラインオプション

```
usage: letterboxd2imdb.py [-h] -f ZIPFILE [-p PARALLEL] [-c] [-r RATING] [-w] [-l] [--list-name LIST_NAME]

Imports your Letterboxd ratings and watchlist into IMDb. Can also create custom lists for unrated movies.

required arguments:
  -f ZIPFILE            The exported zip file from letterboxd

options:
  -h, --help            show this help message and exit
  -p PARALLEL           Urls to be processed in parallel (valid: 1 to 20)
  -c                    Add this flag to disable the history
  -r RATING             The rating to give watched but unrated movies. By default they are ignored (valid: 1 to 10)
  -w                    Add this flag to also transfer your watchlist
  -l                    Create an IMDb list for watched but unrated movies instead of rating them
  --list-name LIST_NAME Name for the IMDb list to create for unrated movies (default: 'Watched on Letterboxd - Unrated')
```
`-p`: 処理を高速化したい場合に使用できます。設定を高くしすぎるとレート制限される可能性があります。デフォルト: 5  
`-c`: 履歴が問題を引き起こしている場合、このフラグを追加して無効化できます。  
`-r`: 視聴済みだが評価されていない映画に評価を付けるために使用します。IMDbには「視聴のみ」オプションがないため、デフォルトの評価を指定する必要があります。  
`-w`: 視聴リストも転送するために使用します。  
`-l`: 視聴済みだが評価されていない映画に任意の評価を付ける代わりにIMDbリストを作成します。これにより、評価データを綺麗に保ちつつ視聴済み映画を追跡できます。  
`--list-name`: `-l`オプションで作成されるIMDbリストのカスタム名を指定します。デフォルト: "Watched on Letterboxd - Unrated"  

**注意:** `-r` と `-l` オプションは相互排他です。評価されていない映画にデフォルト評価を付ける (`-r`) かリストを作成する (`-l`) のどちらか一方しか選べません。  
  
## 使用例  
  
**基本的なインポート（評価のみ）:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip`  
*LetterboxdからIMDbへ評価済み映画のみをインポートします。評価されていない映画は無視されます。*  
  
**評価と視聴リストをインポート:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -w`  
*LetterboxdからIMDbへ評価と視聴リストの両方を転送します。*  
  
**評価されていない映画にデフォルト評価を付ける:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -r 7`  
*評価をインポートし、視聴済みだが評価されていない全ての映画に7/10のデフォルト評価を付けます。*  
  
**評価されていない映画のリストを作成:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -l`  
*評価していない視聴済み映画のために"Watched on Letterboxd - Unrated"というIMDbリストを作成します。*  
  
**評価されていない映画のカスタム名リストを作成:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -l --list-name "My Letterboxd Backlog"`  
*評価していない視聴済み映画のためにカスタム名のIMDbリストを作成します。*  
  
**より高い並列処理で高速化:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -p 15`  
*15本の映画を並列で処理し、実行を高速化します（レート制限に注意）。*  
  
**カスタム設定で完全転送:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -p 10 -r 5 -w`  
*高速処理（並列10）、評価と視聴リストをインポートし、評価されていない映画に5/10の評価を付けます。*  
  

**ウォッチリストと高速処理でカスタムリストを作成:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -p 10 -l --list-name "My Letterboxd Movies" -w`  
*高速で処理し、ウォッチリストをインポートし、未評価の映画のためにカスタム名のリストを作成します。*  
  
**履歴を無効化（トラブルシューティング用）:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -c`  
*履歴機能を使用せずに実行します。履歴ファイルに問題がある場合に便利です。*  
  
**保守的な方法（遅いが安全）:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -p 1 -w`  
*一度に1つの映画を処理し、評価とウォッチリストの両方をインポートする際のレート制限問題を回避します。*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---