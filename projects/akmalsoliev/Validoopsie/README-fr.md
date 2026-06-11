<h1 align="center">
    <img width="400" alt="validoopsie" src=https://raw.githubusercontent.com/akmalsoliev/Validoopsie/refs/heads/main/docs/assets/validoopsie-text.png>
    <p style="font-size: 16px; font-weight: bold;">Une bibliothèque de validation de données simple et facile à utiliser pour Python.</p>
    <img width="400" alt="validoopsie" src=https://raw.githubusercontent.com/akmalsoliev/Validoopsie/refs/heads/main/docs/assets/logo.png>
</h1>

<p align="center">
  <a href="https://badge.fury.io/py/Validoopsie">
    <img src="https://badge.fury.io/py/Validoopsie.svg" alt="Version PyPI" />
  </a>
  <a href="https://pepy.tech/projects/validoopsie">
    <img src="https://static.pepy.tech/badge/validoopsie" alt="Téléchargements PyPI">
  </a>
  <a href="https://github.com/akmalsoliev/Validoopsie/actions/workflows/tests.yaml">
    <img src="https://github.com/akmalsoliev/Validoopsie/actions/workflows/tests.yaml/badge.svg" alt="Tests et Linters" />
  </a>
  <a href="https://github.com/akmalsoliev/Validoopsie/actions/workflows/docs.yaml">
    <img src="https://github.com/akmalsoliev/Validoopsie/actions/workflows/docs.yaml/badge.svg" alt="Documentation" />
  </a>
</p>

# Validoopsie

Validoopsie est une bibliothèque de validation de données remarquablement légère et conviviale pour Python.  
Elle est conçue pour vous aider à déclarer facilement des classes et à enchaîner les validations, dans un style rappelant les bibliothèques populaires de DataFrame.  
Cela en fait un outil familier et intuitif pour les développeurs qui travaillent régulièrement avec des dataframes.

Grâce à l’excellent travail de  
[Narwhals](https://github.com/narwhals-dev/narwhals), Validoopsie intègre  
le concept "Bring Your Own DataFrame" (BYOD). Cette flexibilité vous permet  
d’utiliser n’importe quel DataFrame supporté par Narwhals pour vos tâches de validation de données. Pour  
explorer la gamme complète des DataFrames supportés, vous pouvez visiter  
[ce lien](https://narwhals-dev.github.io/narwhals/extending/).

La syntaxe de Validoopsie a été soigneusement conçue pour garantir une facilité d’utilisation.  
Chaque fonction de validation est encapsulée dans sa propre méthode, qui peut être  
enchaînée de manière fluide. Ce design spécifique aux méthodes privilégie la simplicité  
et la lisibilité, vous libérant de la nécessité de vous adapter à une nouvelle API à chaque fois que vous


bibliothèques de commutation. Il vous permet de vous concentrer sur le maintien d’un code propre et compréhensible.

Validoopsie s’inspire largement de la bibliothèque Great Expectations.
Il s’efforce de distiller le processus de validation des données en quelque chose de simple
et efficace. Que vous vérifiiez l’intégrité des données ou assuriez la conformité
aux normes de données, Validoopsie offre une solution simplifiée mais puissante pour
rendre ces tâches accessibles et simples.

## Table des matières

1. [Installation](#installation)
2. [Prise en main](#getting-started)
3. [Version](#version)
4. [Méthodes Dunder](#dunder-methods)
5. [Méthode Validate](#validate-method)
6. [Développement](#development)
7. [Licence](#license)

## Installation

- pip

  `pip install Validoopsie`

- uv

  `uv add Validoopsie`

## Prise en main

- [📖 Documentation](https://akmalsoliev.github.io/Validoopsie/)
- [🚨 Niveaux d’impact dans Validoopsie](https://akmalsoliev.github.io/Validoopsie/impact_levels.html)
- [🎯 Niveaux de seuil dans Validoopsie](https://akmalsoliev.github.io/Validoopsie/threshold_levels.html)
- [🛠️ Directives de contribution](https://akmalsoliev.github.io/Validoopsie/contributing/CONTRIBUTING.html)
- [✨ Contribuer une nouvelle validation à Validoopsie](https://akmalsoliev.github.io/Validoopsie/contributing/DevelopingValidation.html)
- [🧑‍💻 Développez votre propre validation personnalisée](https://akmalsoliev.github.io/Validoopsie/custom_validations/DevelopingValidationCustom.html)
- [🗂️ Catalogue de validations](https://akmalsoliev.github.io/Validoopsie/validation_catalogue/Date%20Validation.html)

Validoopsie est incroyablement facile à utiliser, à tel point que vous pourriez le faire

à moitié endormi. La simplicité de la bibliothèque est renforcée par le concept BYOD (Apportez Votre
Propre DataFrame), où il vous suffit d'utiliser la classe `Validate`
et d'enchaîner les validations souhaitées. Cette approche garantit que vous pouvez
commencer avec un minimum d'effort et sans aucune complexité inutile.

```py
import pandas as pd

from validoopsie import Validate

p_df = pd.DataFrame(
    {
        "name": ["John", "Doe", "Jane"],
        "target_name": ["John", "Doe", "Jane"],
        "last_name": ["Smith", "Smith", "Smith"],
        "age": [25, 30, 35],
    },
)

# `vd` stands for Validate Data
vd = Validate(p_df)
vd.EqualityValidation.PairColumnEquality(
    column="name",
    target_column="age",
    impact="high",
).UniqueValidation.ColumnUniqueValuesToBeInList(
    column="last_name",
    values=["Smith"],
).ValuesValidation.ColumnValuesToBeBetween(
    column="age",
    min_value=20,
    max_value=40,
)

vd.results
```

**SORTIE :**

```json
{
  "Summary": {
    "passed": false,
    "validations": [
      "PairColumnEquality_name",
      "ColumnUniqueValuesToBeInList_last_name",
      "ColumnValuesToBeBetween_age"
    ],
    "failed_validation": ["PairColumnEquality_name"]
  },
  "PairColumnEquality_name": {
    "validation": "PairColumnEquality",
    "impact": "high",
    "timestamp": "2025-10-07T11:25:04.213211+02:00",
    "column": "name",
    "result": {
      "status": "Fail",
      "threshold_pass": false,
      "message": "The column 'name' is not equal to the column'age'.",
      "failing_items": [
        "Doe - column name - column age - 30",
        "Jane - column name - column age - 35",
        "John - column name - column age - 25"
      ],
      "failed_number": 3,
      "frame_row_number": 3,
      "threshold": 0.0,
      "failed_percentage": 1.0
    }
  },
  "ColumnUniqueValuesToBeInList_last_name": {
    "validation": "ColumnUniqueValuesToBeInList",
    "impact": "low",
    "timestamp": "2025-10-07T11:25:04.216417+02:00",
    "column": "last_name",
    "result": {
      "status": "Success",
      "threshold_pass": true,
      "message": "All items passed the validation.",
      "frame_row_number": 3,
      "threshold": 0.0
    }
  },
  "ColumnValuesToBeBetween_age": {
    "validation": "ColumnValuesToBeBetween",
    "impact": "low",
    "timestamp": "2025-10-07T11:25:04.217300+02:00",
    "column": "age",
    "result": {
      "status": "Success",
      "threshold_pass": true,
      "message": "All items passed the validation.",
      "frame_row_number": 3,
      "threshold": 0.0
    }
  }
}
```

Vous pouvez également afficher les résultats de la validation dans un tableau formaté en utilisant la
méthode `display_summary`, qui offre une vue claire et lisible de vos
résultats de validation :

```py
vd.display_summary()
```

![default display_summary](https://raw.githubusercontent.com/akmalsoliev/Validoopsie/main/./docs/assets/display_summary_default.png)

### Display a full detailed table with all available information

```py
vd.display_summary(information="full")
```

![full display_summary](https://raw.githubusercontent.com/akmalsoliev/Validoopsie/main/./docs/assets/display_summary_full.png)

### Customize the table format (supports tabulate formatting options)

```py
vd.display_summary(tablefmt="pipe", maxcolwidths=20)
```

![kwargs display_summary](https://raw.githubusercontent.com/akmalsoliev/Validoopsie/main/./docs/assets/display_summary_pipe.png)

La méthode `display_summary` prend en charge deux niveaux d'information :

- `"short"` (par défaut) : Affiche les métriques clés telles que le timestamp, l'impact, le statut,
  le type de validation, la colonne, le seuil, et les détails d'échec
- `"full"` : Affiche tous les champs disponibles de validation et de résultat

Vous pouvez également personnaliser l'apparence du tableau en utilisant n'importe quelle option de formatage `tabulate`
comme `tablefmt` pour différents styles de tableau (par exemple, "github", "grid",
"pipe", "html") et `maxcolwidths` pour contrôler la largeur des colonnes.

## Version

Vous pouvez vérifier à tout moment la version installée de Validoopsie :

```py
from validoopsie import __version__

print(__version__)
```

## Méthodes Dunder

La classe `Validate` prend en charge plusieurs méthodes dunder Python pour plus de commodité :

- `repr(vd)` — renvoie une chaîne récapitulative avec le nombre de lignes et le nombre de validations :

  ```py
  >>> repr(vd)
  'Validate(rows=3, validations=3)'
  ```

- `str(vd)` — renvoie une chaîne de caractères lisible par l’homme représentant le statut :

  ```py
  >>> str(vd)
  'Validate: 3 validation(s), passed=False'
  ```

- `len(vd)` — renvoie le nombre de validations :

  ```py
  >>> len(vd)
  3
  ```

## Méthode Validate

Pour vous assurer que toutes vos validations ont été correctement exécutées et pour gérer
toutes les erreurs potentielles pouvant survenir lors du processus de validation, vous pouvez utiliser
la méthode `validate`. Cependant, il est important de noter que les erreurs ne seront
levées que si le niveau `impact` est défini sur `high`. Sans ce paramètre,
les problèmes potentiels peuvent ne pas déclencher de message d'erreur.

**REMARQUE :** L’erreur levée est une `ValueError` personnalisée.

```py
import pandas as pd

from validoopsie import Validate

p_df = pd.DataFrame(
    {
        "name": ["John", "Doe", "Jane"],
        "target_name": ["John", "Doe", "Jane"],
        "last_name": ["Smith", "Smith", "Smith"],
        "age": [25, 30, 35],
    },
)

# `vd` stands for Validate Data
vd = Validate(p_df)
vd.EqualityValidation.PairColumnEquality(
    column="name",
    target_column="age",
    impact="high",
).UniqueValidation.ColumnUniqueValuesToBeInList(
    column="last_name",
    values=["Smith"],
).ValuesValidation.ColumnValuesToBeBetween(
    column="age",
    min_value=20,
    max_value=40,
).validate()
```

Grâce à [loguru](https://github.com/Delgan/loguru), la sortie fournira des informations très
condensées sur les validations et leur statut de manière colorée.

<p align="left">
    <img width="1000" alt="sortie de validation" src=./docs/assets/validate.png>
</p>

## Développement

Validoopsie inclut un Makefile pour simplifier les tâches de développement :

```bash
# Install dependencies
make setup

# Run linters (mypy, ruff)
make lint

# Run tests (includes doctests, stubtest)
make test

# Run both lint and test
make all
```

Pour plus d'informations sur le développement, consultez les
[directives de contribution](https://akmalsoliev.github.io/Validoopsie/contributing/CONTRIBUTING.html).

## Licence

MIT © Validoopsie

Créateur original - [Akmal Soliev](https://github.com/akmalsoliev)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-11

---