# readsql

Convertir le SQL au format le plus lisible possible. Pour l'instant, il met en majuscules les mots-clés SQL, il pourrait à l'avenir améliorer la présentation ou même suggérer des améliorations du code SQL. Il convertit le code SQL et même les chaînes SQL dans les langages de programmation (seulement Python pour le moment).

Donc si nous écrivons

```sql
select sushi, avg(price) from tokyo where ocean = 'pacific' group by sushi
```
readsql nous aidera à le lire comme  


```sql
SELECT sushi, AVG(price) FROM tokyo WHERE ocean = 'pacific' GROUP BY sushi
```

# Installation

```bash
pip install readsql
```

Nécessite Python 3.8+.

# Utilisation

1. Formater le code SQL fourni en ligne de commande
    - `readsql <SQL_STRING> -s`
2. Formater un fichier ou un dossier SQL
    - dans un dossier, il recherchera les fichiers se terminant par .sql ou .py
    - `readsql <CHEMIN_FICHIER_OU_DOSSIER>`

Il prend également en charge plusieurs chaînes et fichiers ou dossiers

1.
```bash
readsql <SQL_STRING1> <SQL_STRING2> -s
```
2. Dans les fichiers Python, il recherche les chaînes de variables `query` et les formate.

```bash
readsql <FILE_OR_FOLDER_PATH1> <FILE_OR_FOLDER_PATH2>
```
Nous pouvons rechercher différentes chaînes dans les fichiers Python avec les arguments `-py`

```bash
readsql <FILE_OR_FOLDER_PATH> -py <PY_VAR1> <PY_VAR2>
```

> **Remarque** : `readsql` utilise le parseur AST de Python, il supporte donc :
> - **Annotations de type** : `query: str = "..."`
> - **F-strings** : `f"SELECT * FROM {table}"`
> - **Portées imbriquées** : Gère de manière robuste les variables à l'intérieur des fonctions et des classes.
> - **Commentaires/Docstrings** : Ignore correctement le texte de type SQL dans les commentaires ou docstrings.

# Exemples d'utilisation

1. La commande `readsql 'select sushi from tokyo' -s` renvoie
    - `SELECT sushi FROM tokyo`

2. a. La commande `readsql sql_example.sql`, alors que `sql_example.sql` est un fichier SQL avec le code ci-dessous,
```sql
select max(height), avg(mass), min(age) from jungle group by forest where animal=elephant;
```
remplace le fichier par ce code
```sql
SELECT MAX(height), AVG(mass), MIN(age) FROM jungle GROUP BY forest WHERE animal=elephant;
```

2. b. La commande `readsql sql_in_python_variable_example.py`, tandis que `sql_in_python_variable_example.py` est un fichier Python avec le code ci-dessous,
```python
def get_query():
    limit = 6
    query = f"SELEct speed from world where animal='dolphin' limit {limit}"
    return query
```
remplace le fichier par ce code
```python
def get_query():
    limit = 6
    query = f"SELECT speed FROM world WHERE animal='dolphin' LIMIT {limit}"
    return query
```
2. c. Commande `readsql sql_in_python_variable_example.py -py sql`, tandis que `sql_in_python_variable_example.py` est un fichier Python avec le code ci-dessous,

```python
def get_query():
    limit = 6
    sql = f"SELEct speed from world where animal='dolphin' limit {limit}"
    return sql
```
remplace le fichier par ce code
```python
def get_query():
    limit = 6
    sql = f"SELECT speed FROM world WHERE animal='dolphin' LIMIT {limit}"
    return sql
```

2. d. La commande `readsql tests -n` affiche tout le code SQL formaté dans le dossier `tests`, les fichiers ne sont pas remplacés par la version formatée (l'argument `-n` signifie ne pas remplacer)

Plus d'exemples peuvent être trouvés dans le dossier `/tests`

# Ajouter un hook pre-commit
Comment ajouter un hook [pre-commit](https://pre-commit.com/) de readsql ?
```yaml
repos:
-   repo: https://github.com/AzisK/readsql
    rev: v1.0.0  # Replace by any tag/version: https://github.com/azisk/readsql/tags
    hooks:
    -   id: readsql
```

# Développement

Clonez le dépôt et utilisez [uv](https://docs.astral.sh/uv/) pour le développement :

```bash
uv sync --all-extras                                    # Install dependencies
uv run readsql "select sushi from tokyo" -s             # Format a string
uv run readsql tests/sql_example.sql                    # Format SQL file
uv run readsql tests/sql_in_python_example.py           # Format SQL in Python
uv run readsql tests/sql_in_python_variable_example.py -py sql  # Custom variable
uv run readsql tests                                    # Format all files in folder
```

# Test

```bash
uv run pytest -v
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-30

---