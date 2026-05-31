<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://github.com/Andarius/piou/raw/master/docs/static/piou-dark.png">
  <source media="(prefers-color-scheme: light)" srcset="https://github.com/Andarius/piou/raw/master/docs/static/piou.jpg">
  <img alt="Logo Piou"
    src="https://github.com/Andarius/piou/raw/master/docs/static/piou.jpg"
    width="250"/>
</picture>

# Piou

[![Versions Python](https://img.shields.io/pypi/pyversions/piou)](https://pypi.python.org/pypi/piou)
[![Dernière version PyPI](https://img.shields.io/pypi/v/piou?logo=pypi)](https://pypi.python.org/pypi/piou)
[![CI](https://github.com/Andarius/piou/actions/workflows/ci.yml/badge.svg)](https://github.com/Andarius/piou/actions/workflows/ci.yml)
[![Dernière version conda-forge](https://img.shields.io/conda/vn/conda-forge/piou?logo=conda-forge)](https://anaconda.org/conda-forge/piou)

Un outil CLI pour créer de belles interfaces en ligne de commande avec validation de type.

## Exemple rapide

```python
from piou import Cli, Option

cli = Cli(description='A CLI tool')


@cli.command(cmd='foo', help='Run foo command')
def foo_main(
        bar: int = Option(help='Bar positional argument (required)'),
        baz: str = Option('-b', '--baz', help='Baz keyword argument (required)'),
        foo: str | None = Option(None, '--foo', help='Foo keyword argument'),
):
    """
    A longer description on what the function is doing.
    """
    pass


if __name__ == '__main__':
    cli.run()
```

![example](https://github.com/Andarius/piou/raw/master/docs/static/simple-output.svg)

## Installation

```bash
pip install piou
```

Ou avec [uv](https://docs.astral.sh/uv/) :

```bash
uv add piou
```

Ou avec [conda](https://docs.conda.io/) :

```bash
conda install piou -c conda-forge
```

### Formateur brut

Par défaut, Piou utilise [Rich](https://github.com/Textualize/rich) pour une sortie terminale élégante. Si vous préférez une sortie en texte brut, vous pouvez utiliser le formateur brut :

```bash
# Force raw output via environment variable
PIOU_FORMATTER=raw python your_cli.py --help
```

## Documentation

La documentation complète est disponible sur **[andarius.github.io/piou](https://andarius.github.io/piou)**.

### Fonctionnalités

- Expérience développeur type FastAPI avec annotations de type
- Formatteurs personnalisés (basés sur Rich par défaut)
- Groupes de commandes imbriqués / sous-commandes
- Options dérivées pour motifs d’arguments réutilisables
- Support des commandes asynchrones
- Validation et conversion de type
- **Mode TUI interactif** avec suggestions de commandes et historique
- **Aide JSON structurée** (`--help-json`) pour outils et découverte programmatique du CLI

## Pourquoi Piou ?

Je n’ai pas trouvé de bibliothèque offrant :

- La même expérience développeur que [FastAPI](https://fastapi.tiangolo.com/)
- La personnalisation de l’interface (pour construire un CLI similaire à [Poetry](https://python-poetry.org/))
- La validation / conversion de type

[Typer](https://github.com/tiangolo/typer) est l’alternative la plus proche mais n’offre pas la possibilité de formater la sortie de manière personnalisée avec des bibliothèques externes (comme [Rich](https://github.com/Textualize/rich)).

**Piou** offre toutes ces possibilités et vous permet de définir votre propre Formatteur.

## Commandes asynchrones

Les commandes peuvent être des fonctions `async` — piou détecte les coroutines et les exécute automatiquement, sans besoin de faire manuellement `asyncio.run()` :

```python
from piou import Cli, Option

cli = Cli(description='Async example')

@cli.command(cmd='fetch', help='Fetch data')
async def fetch(url: str = Option(help='URL to fetch')):
    import niquests
    async with niquests.AsyncSession() as client:
        r = await client.get(url)
        print(r.status_code)

if __name__ == '__main__':
    cli.run()
```

Cela fonctionne de la même manière pour les commandes à l'intérieur des groupes de commandes.

## Mode TUI interactif

Piou inclut un mode TUI (Interface Utilisateur Texte) interactif optionnel propulsé par [Textual](https://textual.textualize.io/).
Cela offre une expérience terminal riche avec des suggestions de commandes, un historique et des complétions en ligne.

### Installation

```bash
pip install piou[tui]

# With auto-reload support for development
pip install piou[tui-reload]
```

### Utilisation

Activez le mode TUI en définissant `tui=True` lors de la création de votre CLI :

```python
from piou import Cli, Option

cli = Cli(description='My Interactive CLI', tui=True)

@cli.command(cmd='hello', help='Say hello')
def hello(name: str = Option(..., help='Name to greet')):
    print(f'Hello, {name}!')

if __name__ == '__main__':
    cli.run()
```

Ou via l'option `--tui` :

```bash
python my_cli.py --tui
```

Ou via la variable d’environnement `PIOU_TUI=1` :

```bash
PIOU_TUI=1 python my_cli.py
```

### Fonctionnalités TUI

- **Suggestions de commandes** : Tapez `/` pour voir les commandes disponibles avec descriptions
- **Navigation sous-commandes** : Utilisez `:` pour naviguer dans les sous-commandes (ex. : `/stats:uploads`)
- **Complétions en ligne** : Voyez les espaces réservés aux arguments pendant la saisie
- **Historique des commandes** : Naviguez dans les commandes précédentes avec les flèches haut/bas (persisté entre sessions)
- **Sortie enrichie** : Couleurs ANSI et formatage conservés dans la sortie
- **Raccourcis clavier** :
  - `Tab` - Confirmer la suggestion sélectionnée
  - `Haut/Bas` - Naviguer dans les suggestions ou l'historique
  - `Ctrl+C` - Effacer la saisie (appuyez deux fois pour quitter)
  - `Échap` - Quitter
- **Mode dev** : Rechargement automatique des commandes lors des changements des fichiers sources (voir ci-dessous)

<img alt="Démo TUI" src="https://github.com/Andarius/piou/raw/master/docs/static/tui-demo.gif" width="600"/>

### Mode Dev avec Rechargement Automatique

Pour une itération de développement plus rapide, activez le mode dev pour recharger automatiquement vos commandes lors des changements des fichiers sources :

```bash
pip install piou[tui-reload]
```

Puis utilisez l’option `--tui-reload` :

```bash
python my_cli.py --tui-reload
```

Ou via une variable d'environnement :

```bash
PIOU_TUI_DEV=1 python my_cli.py --tui
```

Lorsqu'il est activé, Piou surveille vos fichiers source de commandes et les recharge à chaud lors de leur sauvegarde. Vous pouvez également basculer le mode de rechargement à l'exécution avec la commande `/tui-reload`.

Pour exécuter du code personnalisé après chaque rechargement (par exemple, actualiser les données en cache), utilisez le décorateur `@cli.tui_on_reload` :

```python
@cli.tui_on_reload
def on_reload():
    print('Code reloaded!')
```

### Exemple Avancé : Benchmark HTTP

Le mode TUI prend en charge le montage de widgets Textual personnalisés pour des affichages interactifs riches. Cet exemple mesure les performances des bibliothèques HTTP avec des grilles de progression en direct :

<img alt="Benchmark HTTP TUI" src="https://github.com/Andarius/piou/raw/master/docs/static/bench_1000.gif" width="700"/>

Voir [examples/http_bench_tui.py](https://raw.githubusercontent.com/Andarius/piou/master/examples/http_bench_tui.py) pour l’implémentation complète utilisant `TuiContext` et des widgets personnalisés.

## Développement

### Exécution des Tests

```bash
uv run pytest
```

### Génération de la documentation

```bash
# Build docs
uv run --group docs mkdocs build

# Serve locally
uv run --group docs mkdocs serve
```

### Génération de captures d’écran et de GIFs

Les enregistrements de terminal sont créés avec [VHS](https://github.com/charmbracelet/vhs). Installez-le d’abord :

```bash
# Ubuntu/Debian
sudo apt install vhs ttyd

# macOS
brew install vhs

# Or via Go
go install github.com/charmbracelet/vhs@latest
```

Générez ensuite des enregistrements à partir des fichiers de bande :

```bash
vhs docs/static/tui-demo.tape
```

Les fichiers de bande sont situés dans `docs/static/` et définissent des sessions de terminal scriptées qui produisent des GIFs.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-31

---