# mock

[![Go Reference](https://pkg.go.dev/badge/github.com/dhuan/mock.svg)](https://pkg.go.dev/github.com/dhuan/mock)
[![Go Report Card](https://goreportcard.com/badge/github.com/dhuan/mock)](https://goreportcard.com/report/github.com/dhuan/mock)

*mock* は API ユーティリティです - 次のことができます：

- API 設定ファイルやコマンドラインパラメータを通じて
  簡単に API ルートを定義できます。
- シェルスクリプトをレスポンスハンドラとして使用できます。または他の種類のプログラムも
  レスポンスハンドラとして機能します。
- API のテストを行い、エンドポイントがリクエストされたかどうかを
  アサーションできます。

[`mock` を学び理解する最速の方法は、例のページを見ることです。](https://dhuan.github.io/mock/latest/examples.html)

## クイックリンク

- [ユーザーガイド](https://dhuan.github.io/mock)
- [ユーザーガイド（メインブランチ、未リリース）](https://dhuan.github.io/mock/latest)
- [ハウツー＆例](https://dhuan.github.io/mock/latest/examples.html)

## はじめに

```sh
$ mock serve --port 3000 \
  --get "/time-now" \
  --exec 'printf "Now it is %s" $(date +"%H:%M") | mock write' \
  --post "/shut-down/{application}" \
  --exec 'killall $(mock get-route-param application)'
```
試してみましょう：


```sh
$ curl localhost:3000/time-now
# Prints out:
Now it is 22:00

$ curl -X POST localhost:3000/shut-down/mock
# Shuts down the server!
```
*mock* は他のAPI（または任意のHTTPサービス）を拡張することも可能です。  
既存のAPIが ``example.com`` で動作しているとします。  
新しいルートを追加したい場合：  
```  
example.com  
```  
:
```sh
$ mock serve --port 3000 \
  --base example.com \
  --get 'some-new-route' \
  --exec 'printf "Hello, world!" | mock write' 
```

上記の ``--base example.com`` オプションを使用すると、APIはその他のウェブサイトのプロキシとして機能し、
`GET /some-new-route` という追加のルートを拡張します。
詳細はドキュメントの「Base APIs」を参照してください。

*[*mock* を使ったAPIのさらなるカスタマイズ方法は多数あります。ガイドを読み進めて学んでください。](https://dhuan.github.io/mock)*

## インストール

mock は単一ファイル実行可能形式で配布されています。リリースページを確認し、最新のtarballをダウンロードしてください。

## ライセンス

**mock** はMITライセンスの下で提供されています。詳細は [LICENSEファイル](LICENSE) をご覧ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-18

---