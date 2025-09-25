> [!WARNING]
> 現在iOSで`refresh_token`が取得できない問題が発生しています。これは`colmsg`の問題ではなくメッセージアプリ側のアップデートによる影響です。現状この問題に対する完全な解決策はありません。Androidの場合は引き続き[こちら](https://github.com/proshunsuke/colmsg/blob/main/doc/how_to_get_refresh_token.md#android%E3%82%A2%E3%83%97%E3%83%AA%E3%81%AE%E5%A0%B4%E5%90%88)を参考にしてください。

<div align="center">
  <h1><strong>colmsg</strong></h1>
  <img src="https://user-images.githubusercontent.com/3148511/158018437-09822a33-8767-4e03-ba90-e0f69594c493.jpeg" width="32px" alt="櫻坂46メッセージのロゴ"><img src="https://user-images.githubusercontent.com/3148511/158018441-dd7cb9eb-bf31-4938-830d-1ef293a2afba.jpg" width="32px" alt="日向坂46メッセージのロゴ"><img src="https://user-images.githubusercontent.com/3148511/158018442-ae54e926-760d-4b47-b0a0-7255485e1f28.jpg" width="32px" alt="乃木坂46メッセージのロゴ">

  「櫻坂46メッセージ」「日向坂46メッセージ」「乃木坂46メッセージ」「齋藤飛鳥メッセージ」「白石麻衣メッセージ」「yodel」アプリのメッセージをPCに保存します。

  ![demo](https://user-images.githubusercontent.com/3148511/158026220-90735546-2401-40ca-a9e6-89d2176ad3b4.gif)
</div>

## 概要

`colmsg` のインストール方法は[こちら](#インストール)を参照してください。

**まず初めに**refresh_tokenを取得してください。取得方法は[こちら](https://raw.githubusercontent.com/proshunsuke/colmsg/main/doc/how_to_get_refresh_token.md)を参照してください。

取得出来たら以下を実行してください。  
`<s_refresh_token>` , `<h_refresh_token>` , `<n_refresh_token>` , `<a_refresh_token>` , `<m_refresh_token>` , `<y_refresh_token>` に「櫻坂46メッセージ」「日向坂46メッセージ」「乃木坂46メッセージ」「齋藤飛鳥メッセージ」「白石麻衣メッセージ」「yodel」それぞれで取得してきたrefresh_tokenを入れてください。  
※ 指定するのは購読しているアプリのみで問題ありません。  

購読しているメンバー全員の全期間のメッセージが保存されます。  

```shell script
colmsg --s_refresh_token <s_refresh_token> --h_refresh_token <h_refresh_token> --n_refresh_token <n_refresh_token> --a_refresh_token <a_refresh_token> --m_refresh_token <m_refresh_token> --y_refresh_token <y_refresh_token>
```
Windowsの場合は実行ファイル名を `colmsg.exe` に読み替えてください。

## 特徴

* ✅ 端末のroot化の必要がありません
* ✅ Android, iosアプリどちらにも対応しています
* ✅ Windows, macos, Linuxで実行できます
* ✅ 様々な保存方法が選べます
* ✅ 以下のアプリのバージョンに対応しています
  * 「櫻坂46メッセージ」: バージョン1.12.01.169
  * 「日向坂46メッセージ」: バージョン2.13.01.169
  * 「乃木坂46メッセージ」: バージョン1.8.01.169
  * 「齋藤飛鳥メッセージ」: バージョン1.1.01.169
  * 「白石麻衣メッセージ」: バージョン3.4.3.426
  * 「yodel」: バージョン4.1.1.455

## 使い方

概要で基本的な使い方を説明しました。  
しかし、refresh_tokenは機微情報なため、ターミナル上で直接入力するのはあまり良くないでしょう。  
そこで、configファイルにデフォルトのオプションを設定しておくことをおすすめします。  
configファイルについては[こちら](#configファイル)を参照してください。  
以降はconfigファイルでrefresh_tokenが設定されているものとします。

`colmsg` にはいくつかのオプションがあり、様々な保存方法を選べます。

特定のメンバーのメッセージを保存したい場合


```shell script
colmsg -n 菅井友香 -n 佐々木久美
```

特定のグループのメッセージを保存したい場合

```shell script
colmsg -g sakurazaka
```

特定の種類のメッセージを保存したい場合

```shell script
colmsg -k picture -k video
```

特定の日時以降のメッセージを保存したい場合

```shell script
colmsg -F '2020/01/01 00:00:00'
```
オプションは組み合わせて使用することができます。より詳細な説明は以下を実行して確認してください。


```shell script
colmsg --help
```

## 詳細な仕様

* 既にいくつかメッセージが保存されている場合にコマンドを実行すると、最後に保存したメッセージ以降のメッセージを取得して保存します  
* 保存されるメッセージは次のディレクトリ構造で保存されます
  * ```shell script
    colmsg/
    ├── 日向坂46 一期生
    │   └── 佐々木久美
    │       └── 1_0_20191231235959.txt
    ├── 乃木坂46
    │   └── 秋元真夏
    │       └── 2_1_20200101000000.jpg
    └── 櫻坂46 一期生
        └── 菅井友香
            ├── 3_2_20200101000001.mp4
            └── 4_3_20200101000002.mp4
    ```
* ファイル名の形式は `<シーケンス番号>_<種類>_<日付>.<拡張子>` となっています
  * シーケンス番号はメッセージの時系列を表す番号になっています。若い数字程昔のメッセージです。ファイルブラウザで辞書順に並べると保存したメッセージが時系列通りに並びます
  * 種類の数字は以下のように対応しています
    * 0: テキストメッセージ
    * 1: 画像
    * 2: 動画
    * 3: ボイス
    * 4: リンク
* 各環境毎のデフォルトの保存先は以下を実行することで確認することが出来ます
  * ```shell script
    colmsg --download-dir
    ```
* 既に保存済のメッセージは上書き保存されません

## configファイル

`colmsg` は設定ファイルで予めオプションを指定することが出来ます。  
デフォルトのパスは以下を実行することで確認することが出来ます。

```shell script
colmsg --config-dir
```
また、環境変数 `COLMSG_CONFIG_PATH` に設定ファイルの場所を明記することもできます。  
You can also specify the location of the configuration file in the environment variable `COLMSG_CONFIG_PATH`.
```shell script
export COLMSG_CONFIG_PATH="/path/to/colmsg.conf"
```

### フォーマット

この設定ファイルはコマンドライン引数の単純なリストです。`colmsg --help` を利用すると、利用可能なオプションとその値を閲覧することが出来ます。さらに、`#` でコメント文を加えることができます。

設定ファイルの例:

```bash
# s_refresh_tokenを指定
--s_refresh_token s_refresh_token

# h_refresh_tokenを指定
--h_refresh_token h_refresh_token

# n_refresh_tokenを指定
--n_refresh_token n_refresh_token

# a_refresh_tokenを指定
--a_refresh_token a_refresh_token

# m_refresh_tokenを指定
--m_refresh_token m_refresh_token

# y_refresh_tokenを指定
--y_refresh_token y_refresh_token

# メディアファイルだけ保存するように設定
-k picture -k video -k voice
```

## インストール

### Windows

Windows用のビルド済み実行ファイルをzip形式で圧縮し、[リリースページ](https://github.com/proshunsuke/colmsg/releases)に配置しています。  
ダウンロード後、[7-Zip](https://sevenzip.osdn.jp/)などの解凍ソフトで展開してください。  
展開すると実行ファイル `colmsg.exe` が得られます。  
[PowerShell](https://docs.microsoft.com/ja-jp/powershell/)などの環境で実行してください。

### macOS

Homebrewを使ってインストール可能です。

```shell script
brew tap proshunsuke/colmsg
brew install colmsg
```

### Arch Linux

[AUR](https://aur.archlinux.org/packages/colmsg/)からインストールできます。

```bash
yay -S colmsg
```

### バイナリ

異なるアーキテクチャのためのビルド済み実行ファイルを[リリースページ](https://github.com/proshunsuke/colmsg/releases)に配置しました。

## 開発

`colmsg` は外部APIを呼び出します。開発時にはOpenApiを利用したモックサーバーを立てることができます。

```shell
make server/kh
make server/n46
```
環境変数 `S_BASE_URL` 、`H_BASE_URL` 、`N_BASE_URL` を指定することでモックサーバーへリクエストすることが出来ます。


```shell script
S_BASE_URL=http://localhost:8003 H_BASE_URL=http://localhost:8003 N_BASE_URL=http://localhost:8006 cargo run -- -d ~/Downloads/temp/ --help
```

## TODO

* [ ] Automated testing with CI
* [ ] Preparation of examples
* [ ] Parallelization of message saving process
* [ ] Crate-ization of API client

## License

`colmsg` is distributed under the terms of the MIT License.

For details of the license, please refer to the [LICENSE](https://raw.githubusercontent.com/proshunsuke/colmsg/main/LICENSE.txt) file.

## Notes

Please be aware of the following items in Article 8 (Prohibited Matters) of the application's Terms of Use.

* (16) Accessing or attempting to access this service by means other than those specified by the company
* (17) Accessing or attempting to access this service using automated means (including crawlers and similar technologies)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---