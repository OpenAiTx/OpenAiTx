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

Después de terminar, ejecuta `mix deps.get` en tu consola para obtener y compilar **Paasaa**.

## Uso

Detectar un idioma:

```elixir
iex> Paasaa.detect("Detect this!")
"eng"
```

Detectar el idioma y devolver una lista puntuada de idiomas:

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
Detectar un script:


```elixir
iex> Paasaa.detect_script("Detect this!")
{"Latin", 0.8333333333333334}
```

### Uso Avanzado con Opciones

Las funciones `detect/2` y `all/2` aceptan una lista de opciones con palabras clave para controlar su comportamiento.

**Idiomas en Lista Blanca y Lista Negra**

Puedes restringir el conjunto de idiomas posibles. Esto es útil si ya sabes que el texto debe ser uno de unos pocos idiomas, o si quieres excluir un falso positivo común.

```elixir
# Exclude English to find the next most likely language
iex> Paasaa.detect("Detect this!", blacklist: ["eng"])
"sco"

# Only consider Polish and Serbian
iex> text = "Pošto je priznavanje urođenog dostojanstva i jednakih i neotuđivih prava..."
iex> Paasaa.detect(text, whitelist: ["pol", "srp"])
"srp"
```

**Establecer la Longitud Mínima de Texto**

Por defecto, Paasaa devuelve `"und"` para cadenas muy cortas. Puedes ajustar este umbral con `:min_length`.

```elixir
iex> Paasaa.detect("Привет", min_length: 10)
"und"

iex> Paasaa.detect("Привет", min_length: 6)
"rus"
```

## Idiomas Soportados

Para una lista completa de idiomas soportados, por favor consulte [LANGUAGES.md](https://raw.githubusercontent.com/minibikini/paasaa/master/LANGUAGES.md).

## Contribuir

¡Las contribuciones son bienvenidas! No dude en abrir un issue o enviar un pull request en [GitHub](https://github.com/minibikini/paasaa).

Si está actualizando los datos de idioma, puede regenerar los módulos necesarios con el siguiente comando:

```shell
mix run script/generate_language_data.exs
```

## Derivación

**Paasaa** es un trabajo derivado de [Franc](https://github.com/wooorm/franc/) (JavaScript, MIT) por Titus Wormer.

## Licencia

MIT © Egor Kislitsyn


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-04

---