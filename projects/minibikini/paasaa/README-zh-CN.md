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
完成后，在你的终端运行 `mix deps.get` 来获取并编译 **Paasaa**。

## 使用方法

检测一种语言：


```elixir
iex> Paasaa.detect("Detect this!")
"eng"
```
检测语言并返回评分语言列表：


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

检测脚本：

```elixir
iex> Paasaa.detect_script("Detect this!")
{"Latin", 0.8333333333333334}
```

### 带选项的高级用法

`detect/2` 和 `all/2` 函数接受一个选项关键字列表以控制它们的行为。

**白名单和黑名单语言**

你可以限制可能的语言集合。如果你已经知道文本必须是几种语言中的一种，或者你想排除一个常见的误报，这非常有用。

```elixir
# Exclude English to find the next most likely language
iex> Paasaa.detect("Detect this!", blacklist: ["eng"])
"sco"

# Only consider Polish and Serbian
iex> text = "Pošto je priznavanje urođenog dostojanstva i jednakih i neotuđivih prava..."
iex> Paasaa.detect(text, whitelist: ["pol", "srp"])
"srp"
```

**设置最小文本长度**

默认情况下，Paasaa 对非常短的字符串返回 `"und"`。您可以使用 `:min_length` 调整此阈值。

```elixir
iex> Paasaa.detect("Привет", min_length: 10)
"und"

iex> Paasaa.detect("Привет", min_length: 6)
"rus"
```

## 支持的语言

有关支持语言的完整列表，请参见 [LANGUAGES.md](https://raw.githubusercontent.com/minibikini/paasaa/master/LANGUAGES.md)。

## 贡献

欢迎贡献！请随时在 [GitHub](https://github.com/minibikini/paasaa) 上打开问题或提交拉取请求。

如果您正在更新语言数据，可以使用以下命令重新生成所需的模块：

```shell
mix run script/generate_language_data.exs
```

## 推导

**Paasaa** 是 Titus Wormer 基于 [Franc](https://github.com/wooorm/franc/)（JavaScript，MIT）衍生的作品。

## 许可证

MIT © Egor Kislitsyn


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-04

---