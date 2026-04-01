# Typst-live
これはあなたの[typst](https://github.com/typst/typst)ファイルの変更を監視し、自動的に再コンパイルしてライブフィードバックを提供するシンプルなユーティリティです。`typst-live`を使うと、ブラウザでtypst生成のPDFを開き、ソースの`.typ`ファイルが変更されるたびに自動的にリロードされます。

## `--watch`フラグとの違い
`typst-live`はウェブサーバーをホストし、ページを自動的にリフレッシュするので、`typst --watch`のように手動でリロードする必要がありません。

## インストール
[rust](https://www.rust-lang.org)がセットアップされている場合は、以下のコマンドを使用してください：


```
cargo install typst-live
```

Nixを使用している場合は、次のコマンドを使ってGitHubリポジトリから直接typst-liveを実行できます:
```
nix run github:ItsEthra/typst-live
```

## 使用方法
### 1. 自動再コンパイル付きで
* ターミナルから `typst-live` を起動します:
```
$ typst-live <file.typ>
Server is listening on http://127.0.0.1:5599/
```
* ブラウザで `http://127.0.0.1:5599/` にアクセスしてください。
* 次に `file.typ` を編集すると、ブラウザのタブで変更が反映されます。

### 2. 手動での再コンパイルの場合
`typst-live` を使うと、ソースファイルの再コンパイルなしで pdf ファイルをリロードできます。
そのためには、再コンパイルを無効にする `--no-recompile` オプションを使用し、
ブラウザのタブで pdf ファイルをホストします。この際、ソースの `.typ` ファイルではなく、pdf の `filename` を指定する必要があります。
pdf ファイルが変更されるたびに、ブラウザのタブが更新されます。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-01

---