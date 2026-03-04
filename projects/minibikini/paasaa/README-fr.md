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

Après avoir terminé, exécutez `mix deps.get` dans votre terminal pour récupérer et compiler **Paasaa**.

## Utilisation

Détecter une langue :

```elixir
iex> Paasaa.detect("Detect this!")
"eng"
```

Détecter la langue et retourner une liste de langues avec score :

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

Détecter un script :

```elixir
iex> Paasaa.detect_script("Detect this!")
{"Latin", 0.8333333333333334}
```

### Utilisation avancée avec options

Les fonctions `detect/2` et `all/2` acceptent une liste de mots-clés d’options pour contrôler leur comportement.

**Langues en liste blanche et en liste noire**

Vous pouvez restreindre l’ensemble des langues possibles. Cela est utile si vous savez déjà que le texte doit être dans l’une de quelques langues, ou si vous souhaitez exclure un faux positif courant.

```elixir
# Exclude English to find the next most likely language
iex> Paasaa.detect("Detect this!", blacklist: ["eng"])
"sco"

# Only consider Polish and Serbian
iex> text = "Pošto je priznavanje urođenog dostojanstva i jednakih i neotuđivih prava..."
iex> Paasaa.detect(text, whitelist: ["pol", "srp"])
"srp"
```

**Définir la longueur minimale du texte**

Par défaut, Paasaa retourne `"und"` pour les chaînes très courtes. Vous pouvez ajuster ce seuil avec `:min_length`.

```elixir
iex> Paasaa.detect("Привет", min_length: 10)
"und"

iex> Paasaa.detect("Привет", min_length: 6)
"rus"
```

## Langues prises en charge

Pour une liste complète des langues prises en charge, veuillez consulter [LANGUAGES.md](https://raw.githubusercontent.com/minibikini/paasaa/master/LANGUAGES.md).

## Contribution

Les contributions sont les bienvenues ! N'hésitez pas à ouvrir une issue ou à soumettre une pull request sur [GitHub](https://github.com/minibikini/paasaa).

Si vous mettez à jour les données linguistiques, vous pouvez régénérer les modules nécessaires avec la commande suivante :

```shell
mix run script/generate_language_data.exs
```

## Dérivation

**Paasaa** est une œuvre dérivée de [Franc](https://github.com/wooorm/franc/) (JavaScript, MIT) par Titus Wormer.

## Licence

MIT © Egor Kislitsyn


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-04

---