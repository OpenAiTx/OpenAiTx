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

After you are done, run `mix deps.get` in your shell to fetch and compile **Paasaa**.

## Usage

Detect a language:

```elixir
iex> Paasaa.detect("Detect this!")
"eng"
```
Detect language and return a scored list of languages:


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

Detect a script:

```elixir
iex> Paasaa.detect_script("Detect this!")
{"Latin", 0.8333333333333334}
```

### 使用选项的高级用法

`detect/2` 和 `all/2` 函数接受一个关键字列表的选项来控制它们的行为。

**白名单和黑名单语言**

您可以限制可能的语言集合。如果您已经知道文本必须是几种语言中的一种，或者您想排除一个常见的误报，这将非常有用。

```elixir
# Exclude English to find the next most likely language
iex> Paasaa.detect("Detect this!", blacklist: ["eng"])
"sco"

# Only consider Polish and Serbian
iex> text = "Pošto je priznavanje urođenog dostojanstva i jednakih i neotuđivih prava..."
iex> Paasaa.detect(text, whitelist: ["pol", "srp"])
"srp"
```

**Set Minimum Text Length**

By default, Paasaa returns `"und"` for very short strings. You can adjust this threshold with `:min_length`.

```elixir
iex> Paasaa.detect("Привет", min_length: 10)
"und"

iex> Paasaa.detect("Привет", min_length: 6)
"rus"
```

## Supported Languages

For a full list of supported languages, please see [LANGUAGES.md](https://raw.githubusercontent.com/minibikini/paasaa/master/LANGUAGES.md).

## Contributing

Contributions are welcome! Please feel free to open an issue or submit a pull request on [GitHub](https://github.com/minibikini/paasaa).

If you are updating the language data, you can regenerate the necessary modules with the following command:

```shell
mix run script/generate_language_data.exs
```

## Derivation

**Paasaa** is a derivative work from [Franc](https://github.com/wooorm/franc/) (JavaScript, MIT) by Titus Wormer.

## License

MIT © Egor Kislitsyn


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-04

---