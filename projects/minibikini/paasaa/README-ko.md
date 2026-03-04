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
작업을 마친 후, 셸에서 `mix deps.get`을 실행하여 **Paasaa**를 가져오고 컴파일하세요.

## 사용법

언어 감지:


```elixir
iex> Paasaa.detect("Detect this!")
"eng"
```

언어를 감지하고 점수화된 언어 목록을 반환합니다:

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

스크립트 감지:

```elixir
iex> Paasaa.detect_script("Detect this!")
{"Latin", 0.8333333333333334}
```

### 옵션을 사용한 고급 사용법

`detect/2` 및 `all/2` 함수는 동작을 제어하기 위한 옵션 키워드 목록을 받습니다.

**화이트리스트 및 블랙리스트 언어**

가능한 언어 집합을 제한할 수 있습니다. 이는 텍스트가 몇 가지 언어 중 하나임을 이미 알고 있거나 일반적인 오탐을 제외하고 싶을 때 유용합니다.

```elixir
# Exclude English to find the next most likely language
iex> Paasaa.detect("Detect this!", blacklist: ["eng"])
"sco"

# Only consider Polish and Serbian
iex> text = "Pošto je priznavanje urođenog dostojanstva i jednakih i neotuđivih prava..."
iex> Paasaa.detect(text, whitelist: ["pol", "srp"])
"srp"
```

**최소 텍스트 길이 설정**

기본적으로 Paasaa는 매우 짧은 문자열에 대해 `"und"`를 반환합니다. 이 임계값은 `:min_length`로 조정할 수 있습니다.

```elixir
iex> Paasaa.detect("Привет", min_length: 10)
"und"

iex> Paasaa.detect("Привет", min_length: 6)
"rus"
```

## 지원 언어

지원되는 전체 언어 목록은 [LANGUAGES.md](https://raw.githubusercontent.com/minibikini/paasaa/master/LANGUAGES.md)를 참조하십시오.

## 기여하기

기여를 환영합니다! 문제를 열거나 [GitHub](https://github.com/minibikini/paasaa)에서 풀 리퀘스트를 제출해 주세요.

언어 데이터를 업데이트하는 경우, 다음 명령어로 필요한 모듈을 다시 생성할 수 있습니다:

```shell
mix run script/generate_language_data.exs
```
## 유도

**Paasaa**는 Titus Wormer의 [Franc](https://github.com/wooorm/franc/) (JavaScript, MIT)에서 파생된 작업입니다.

## 라이선스

MIT © Egor Kislitsyn



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-04

---