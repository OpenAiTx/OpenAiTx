# Paasaa

[![Elixir CI](https://github.com/minibikini/paasaa/actions/workflows/elixir.yml/badge.svg)](https://github.com/minibikini/paasaa/actions/workflows/elixir.yml)
[![Coverage Status](https://coveralls.io/repos/github/minibikini/paasaa/badge.svg?branch=master)](https://coveralls.io/github/minibikini/paasaa?branch=master)
[![Hex.pm](https://img.shields.io/hexpm/v/paasaa.svg?maxAge=2592001)](https://hex.pm/packages/paasaa)
[![Hex.pm](https://img.shields.io/hexpm/l/paasaa.svg?maxAge=2592000)](https://hex.pm/packages/paasaa)

Paasaa is an Elixir library for robust natural language and script detection. It achieves this through statistical analysis of character n-grams and Unicode script properties, without relying on AI. It helps in tasks like text processing, natural language understanding, or internationalization by accurately identifying the writing system and human language of a given text.

[API Documentation](https://hexdocs.pm/paasaa/) | [Hex Package](https://hex.pm/packages/paasaa)

## Installation

Add `paasaa` to your list of dependencies in `mix.exs`:

```elixir
def deps do
  [{:paasaa, "~> 1.0.0"}]
end
```

完了したら、シェルで `mix deps.get` を実行して **Paasaa** を取得およびコンパイルしてください。

## 使用法

言語を検出する:

```elixir
iex> Paasaa.detect("Detect this!")
"eng"
```
言語を検出し、言語のスコア付きリストを返します:


```elixir
iex> Paasaa.all("Detect this!")
[
  {"eng", 1.0},
  {"sco", 0.8230731943771207},
  {"nob", 0.6030053320407174},
  {"nno", 0.5525933107125545},
  ...
]
```

スクリプトを検出:

```elixir
iex> Paasaa.detect_script("Detect this!")
{"Latin", 0.8333333333333334}
```

### オプションを使った高度な利用法

`detect/2` と `all/2` 関数は、動作を制御するためのキーワードリスト形式のオプションを受け取ります。

**ホワイトリストと言語のブラックリスト**

可能な言語のセットを制限できます。これは、テキストが既にいくつかの言語のうちのどれかであると分かっている場合や、一般的な誤検出を除外したい場合に便利です。

```elixir
# Exclude English to find the next most likely language
iex> Paasaa.detect("Detect this!", blacklist: ["eng"])
"sco"

# Only consider Polish and Serbian
iex> text = "Pošto je priznavanje urođenog dostojanstva i jednakih i neotuđivih prava..."
iex> Paasaa.detect(text, whitelist: ["pol", "srp"])
"srp"
```

**最小テキスト長の設定**

デフォルトでは、Paasaは非常に短い文字列に対して `"und"` を返します。` :min_length` でこの閾値を調整できます。

```elixir
iex> Paasaa.detect("Привет", min_length: 10)
"und"

iex> Paasaa.detect("Привет", min_length: 6)
"rus"
```

## 対応言語

対応言語の完全なリストについては、[LANGUAGES.md](https://raw.githubusercontent.com/minibikini/paasaa/master/LANGUAGES.md)をご覧ください。

## 貢献について

貢献は歓迎します！どうぞお気軽に[GitHub](https://github.com/minibikini/paasaa)でイシューを開くかプルリクエストを提出してください。

言語データを更新する場合は、次のコマンドで必要なモジュールを再生成できます：

```shell
mix run script/generate_language_data.exs
```

## 導出

**Paasaa** は Titus Wormer による [Franc](https://github.com/wooorm/franc/)（JavaScript、MIT）の派生作品です。

## ライセンス

MIT © Egor Kislitsyn


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-04

---