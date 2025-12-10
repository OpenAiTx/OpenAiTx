# 🔍 Wimsey

[![Codeberg](https://img.shields.io/badge/Codeberg-2185D0?style=for-the-badge&logo=Codeberg&logoColor=white)](https://codeberg.org/benrutter/wimsey)
[![PyPi](https://img.shields.io/badge/pypi-%23ececec.svg?style=for-the-badge&logo=pypi&logoColor=1f73b7)](https://pypi.org/project/wimsey/)

[![Docs](https://img.shields.io/badge/Docs-hugo-blue)](https://benrutter.codeberg.page/wimsey-site/site/)
![License](https://img.shields.io/badge/license-MIT-blue)
![coverage](https://img.shields.io/badge/coverage-100-green)


Wimsey est une bibliothèque de contrats de données légère, flexible et entièrement open-source.

- 🐋 **Apportez votre propre bibliothèque de dataframes** : Construite sur [Narwhals](https://github.com/narwhals-dev/narwhals), vos tests sont réalisés nativement dans votre propre bibliothèque de dataframes (incluant Pandas, Polars, Pyspark, Dask, DuckDB, CuDF, Rapids, Arrow et Modin)
- 🎍 **Apportez votre propre format de contrat** : Écrivez les contrats en yaml, json ou python - comme vous préférez !
- 🪶 **Ultra légère** : Conçue pour des imports rapides et une surcharge minimale avec seulement deux dépendances ([Narwhals](https://github.com/narwhals-dev/narwhals) et [FSSpec](https://github.com/fsspec/filesystem_spec))
- 🥔 **API simple et facile** : Faible charge mentale avec deux fonctions simples pour tester les dataframes, et une dataclass simple pour les résultats.

Découvrez le [catalogue de tests](https://benrutter.github.io/wimsey/possible_tests/) pratique et le [guide de démarrage rapide](https://benrutter.github.io/wimsey/)

## Qu’est-ce qu’un contrat de données ?

En plus d’être un bon mot à la mode à mentionner lors de votre prochain événement data, les contrats de données sont un bon moyen de tester les valeurs des données aux points limites. Idéalement, toutes les données seraient utilisables dès leur réception, mais vous avez sans doute déjà compris que ce n’est pas toujours le cas.

Un contrat de données est une expression de ce qui *devrait* être vrai concernant certaines données - on pourrait vouloir vérifier que les seules colonnes existantes sont `first_name`, `last_name` et `rating`, ou on pourrait vouloir vérifier que `rating` est un nombre inférieur à 10.

Wimsey vous permet d’écrire des contrats en json, yaml ou python, voici à quoi ressembleraient les vérifications ci-dessus en yaml :

```yaml
- test: columns_should
  be:
    - first_name
    - last_name
    - rating
- column: rating
  test: max_should
  be_less_than_or_equal_to: 10
```

Wimsey peut alors exécuter des tests pour vous de deux manières, `validate` - qui générera une erreur si les tests échouent, et renverra sinon votre dataframe - et `test`, qui vous donnera un compte rendu détaillé des réussites et des échecs des tests individuels.

Validate est conçu pour bien fonctionner avec les méthodes `pipe` de polars ou pandas comme une garde pratique :

```python
import polars as pl
import wimsey

df = (
  pl.read_csv("hopefully_nice_data.csv")
  .pipe(wimsey.validate, "tests.json")
  .group_by("name").agg(pl.col("value").sum())
)
```
Le test est un appel de fonction unique, retournant un type de données `FinalResult` :


```python
import pandas as pd
import wimsey

df = pd.read_csv("hopefully_nice_data.csv")
results = wimsey.test(df, "tests.yaml")

if results.success:
  print("Yay we have good data! 🥳")
else:
  print(f"Oh nooo, something's up! 😭")
  print([i for i in results.results if not i.success])
```

# Feuille de route, Contribution & Retour d'expérience

Wimsey est dupliqué sur github, mais hébergé et développé sur [codeberg](https://codeberg.org/benrutter/wimsey). Les problèmes et demandes de tirage sont acceptés sur les deux.

L'accent est actuellement mis sur l'affinement du profilage et de la génération de tests, si vous avez des tests ou une fonctionnalité qui vous seraient utiles, n'hésitez pas à nous contacter !


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-10

---