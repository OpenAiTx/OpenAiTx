# expr_codegen Générateur de code d'expression

## Contexte du projet

Après avoir lancé la bibliothèque [polars_ta](https://github.com/wukan1986/polars_ta), je reviens pour réfléchir à ce qu'est `expr_codegen`.

> `expr_codegen` est essentiellement un `DSL` (Domain Specific Language — langage spécifique à un domaine). Mais il ne définit pas de nouvelle syntaxe.

Il résout deux problèmes :

1. `polars_ta` permet déjà d’écrire facilement des expressions de calcul de caractéristiques, mais lorsqu’on rencontre des expressions qui mélangent séries temporelles et cross-sectionnel, l’utilisation de `expr_codegen` permet un regroupement automatique et fait gagner beaucoup de temps.
2. `expr_codegen` utilise l'élimination des sous-expressions communes (`Common Subexpression Elimination`), ce qui réduit considérablement les calculs redondants et améliore l'efficacité.

Même dans le domaine de la finance quantitative, les chercheurs débutants, limités aux indicateurs temporels, peuvent utiliser uniquement `polars_ta`, tandis que les chercheurs de niveau intermédiaire et avancé, qui utilisent des indicateurs cross-sectionnel, sont encouragés à utiliser `expr_codegen`.

Bien que ce projet soit actuellement étroitement lié à `polars_ta`, il peut également être traduit pour d'autres bibliothèques telles que `pandas` ou `cudf.pandas`, mais il manque pour l’instant une bibliothèque simple pour cela.

## Démo en ligne

https://exprcodegen.streamlit.app

Les utilisateurs débutants peuvent directement accéder à ce lien pour générer des expressions sans avoir à installer de logiciel supplémentaire. (Cet outil est hébergé gratuitement à l'étranger, l'ouverture peut donc être un peu lente.)

Pour des exemples plus complets, consultez [alpha_examples](https://github.com/wukan1986/alpha_examples).

## Exemple d'utilisation

```python
import sys
from io import StringIO

import polars as pl

from expr_codegen import codegen_exec


def _code_block_1():
    # Zone d’édition des facteurs, vous pouvez éditer des facteurs ici en profitant de l’auto-complétion de l’IDE
    LOG_MC_ZS = cs_mad_zscore(log1p(market_cap))


def _code_block_2():
    # Le template importe déjà massivement les opérateurs depuis from polars_ta.prefix, mais
    # talib n'est pas importé par défaut dans le template. Cette écriture permet d’importer dans le code généré.
    from polars_ta.prefix.talib import ts_LINEARREG_SLOPE  # noqa

    # Les définitions def et class sont aussi importées telles quelles
    def cs_rank_if(condition, factor):
        return cs_rank(if_else(condition, factor, None))

    class Clazz:
        pass

    # 1. Les variables commençant par un underscore ne sont que des variables intermédiaires, elles seront renommées automatiquement et supprimées à la sortie finale
    # 2. Les variables commençant par un underscore peuvent être réutilisées. Lors de l'écriture de facteurs complexes sur plusieurs lignes, il n'y a plus de conflits pour les variables intermédiaires répétées
    _avg = ts_mean(corr, 20)
    _std = ts_std_dev(corr, 20)
    _beta = ts_LINEARREG_SLOPE(corr, 20)

    # 3. Les variables commençant par un underscore peuvent être réaffectées cycliquement. En débogage, on peut rapidement basculer avec des commentaires
    _avg = cs_mad_zscore_resid(_avg, LOG_MC_ZS, ONE)
    _std = cs_mad_zscore_resid(_std, LOG_MC_ZS, ONE)
    # _beta = cs_mad_zscore_resid(_beta, LOG_MC_ZS, ONE)

    _corr = cs_zscore(_avg) + cs_zscore(_std)
    CPV = cs_zscore(_corr) + cs_zscore(_beta)


code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=sys.stdout)  # Affiche le code
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file="output.py")  # Enregistre dans un fichier
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by')  # Exécute seulement, n’enregistre pas

code = StringIO()
codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=code)  # Sauve dans une chaîne
code.seek(0)
code.read()  # Lit le code

# TODO Remplacer par des données appropriées
df = pl.DataFrame()
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect()  # Lazy CPU
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect(engine="gpu")  # Lazy GPU

```

## Structure du répertoire

```commandline
│  requirements.txt # Installer les dépendances via `pip install -r requirements.txt`
├─data
│      prepare_date.py # Préparer les données
├─examples
│      demo_express.py # Exemple rapide. Montre comment convertir une expression en code
│      demo_exec_pl.py # Montre comment appeler le code converti et tracer des graphiques
│      demo_transformer.py # Montre comment convertir une expression tierce en expression interne
│      output.py # Sortie des résultats. Peut être importé tel quel dans d’autres projets sans modification
│      show_tree.py # Affiche l’arbre d’expression. Sert à analyser et comparer les résultats d’optimisation
│      sympy_define.py # Définitions symboliques, extraites ici car réutilisées à de nombreux endroits
├─expr_codegen
│   │  expr.py # Fonctions de base pour la gestion des expressions
│   │  tool.py # Code des outils principaux
│   ├─polars
│   │  │  code.py # Génération de code spécifique à la syntaxe polars
│   │  │  template.py.j2 # Template `Jinja2`. Sert à générer le fichier py correspondant, généralement sans modification
│   │  │  printer.py # Hérite de `StrPrinter` de `Sympy`, peut nécessiter modification lors de l’ajout de nouvelles fonctions
```

## Principe de fonctionnement

Ce projet dépend de `sympy`. Les principales fonctions utilisées sont :

1. `simplify` : simplifie les expressions complexes
2. `cse` : élimination des sous-expressions communes (`Common Subexpression Elimination`)
3. `StrPrinter` : génère différentes chaînes selon la fonction. En personnalisant ce code, on peut supporter d’autres langages ou bibliothèques

Étant donné que `groupby` et `sort` sont coûteux en temps, si l’on classe les formules à l’avance et que chaque catégorie utilise un `groupby` différent, cela permet de réduire le temps de calcul.

1. `ts_xxx(ts_xxx)` : calculable dans le même `groupby`
2. `cs_xxx(cs_xxx)` : calculable dans le même `groupby`
3. `ts_xxx(cs_xxx)` : nécessite des `groupby` différents
4. `cs_xxx(ts_xxx(cs_xxx))` : nécessite trois `groupby` différents
5. `gp_xxx(aa,) + gp_xxx(bb,)` : comme `aa` et `bb` diffèrent, nécessite deux `groupby` différents

Donc :

1. Un fonction doit permettre d’obtenir la catégorie de l’expression courante (`get_current`) et celle des sous-expressions (`get_children`)
2. Si la catégorie courante diffère de celle des sous-catégories, on peut extraire une formule courte (`extract`). Les expressions de même catégorie à différents niveaux sont ordonnées, elles ne peuvent pas être placées dans le même `groupby`
3. En utilisant les caractéristiques de `cse`, remplacer les longues expressions par les courtes extraites au préalable, puis les injecter dans un graphe orienté acyclique (`DAG`)
4. Exploiter la circulation dans le DAG pour effectuer le classement par niveau. Les fonctions `ts`, `cs`, `gp` d’un même niveau n’ont pas d’ordre entre elles
5. Regrouper par type (`ts`, `cs`, `gp`) au même niveau, puis générer le code (`codegen`)

Informations implicites :

1. `ts` : sort(by=[ASSET, DATE]).groupby(by=[ASSET], maintain_order=True)
2. `cs` : sort(by=[DATE]).groupby(by=[DATE], maintain_order=False)
3. `gp` : sort(by=[DATE, GROUP]).groupby(by=[DATE, GROUP], maintain_order=False)

C’est-à-dire :

1. La fonction temporelle cache deux champs `ASSET, DATE`, la fonction cross-sectionnel en cache un seul `DATE`
2. La fonction de regroupement introduit un champ `GROUP`, tout en cachant un champ `DATE`

Deux méthodes de classification :

1. Classification par préfixe d’opérateur (`get_current_by_prefix`), exige que l’opérateur commence par `ts_`, `cs_`, ou `gp_`
2. Classification par nom complet de l’opérateur (`get_current_by_name`), sans exiger un nom particulier. Par exemple, `cs_rank` pourrait être nommé simplement `rank`

## Gestion des Null

Comment les `null` sont-ils générés ?

1. Arrêt de cotation. Filtré avant le calcul, n’affecte pas les calculs suivants.
2. Différences d’horaires de cotation entre produits
3. Calcul. Les `null` en début et fin de série n’affectent pas les résultats des opérateurs temporels, mais un `null` au milieu peut avoir un impact. Exemple : `if_else(close<2, None, close)`

https://github.com/pola-rs/polars/issues/12925#issuecomment-2552764629

Excellente idée, deux modes de réalisation :

1. Séparer les `null` dans un groupe et les `not_null` dans un autre. Nécessite deux appels
2. Un seul groupe, mais tri composé, les `null` au début, `not_null` ensuite. Un seul appel, légèrement plus rapide

```python
X1 = (ts_returns(CLOSE, 3)).over(CLOSE.is_not_null(), _ASSET_, order_by=_DATE_),
X2 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=[CLOSE.is_not_null(), _DATE_]),
X3 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=_DATE_),
```

Dans le 2ème cas, la zone de `null` en début de série affecte-t-elle le résultat dépend de l’opérateur, en particulier si plusieurs colonnes sont en entrée.

1. `over_null='partition_by'` : les données sont séparées en deux zones
2. `over_null='order_by'` : une seule zone, les `null` d’abord
3. `over_null=None` : pas de traitement, appel direct, plus rapide. Si on est sûr qu’il n’y aura pas de `null` au milieu, il est conseillé d’utiliser ce paramètre

`codegen_exec(over_null='partition_by')` utilise `partition_by` globalement. Mais pour des fonctions comme `ts_count_nulls`, il faut utiliser `over_null=None`, c’est pourquoi cet outil ajoute aussi des commentaires pour spécifier le paramètre pour chaque expression.

1. `# --over_null partition_by` : `over_null='partition_by'` sur la ligne
2. `# --over_null=order_by` : `over_null='order_by'` sur la ligne
3. `# --over_null` : `over_null=None` sur la ligne
4. `# ` : Prend la valeur de `over_null` passée à `codegen_exec`

Remarques :

1. Le commentaire `# --over_null` ne peut être placé qu’à la fin d’une expression sur une seule ligne, sinon il sera ignoré
2. S’il y a plusieurs `#`, seul le premier est pris en compte
3. Valable uniquement pour la fonction `ts` la plus externe. Si la fonction `ts` n’est pas à l’extérieur, il faut la sortir manuellement. Exemple :
   ```python
   X1 = cs_rank(ts_mean(CLOSE, 3)) # --over_null=order_by # Appliqué sur cs_rank, sans effet
   X2 = ts_rank(ts_mean(CLOSE, 3), 5) # --over_null=order_by # On pensait l’appliquer sur ts_rank(ts_mean), mais à cause du ts_mean commun, c’est en fait appliqué sur ts_rank(_x_0)
   ```

   Il faut écrire :

   ```python
   _x_0 = ts_mean(CLOSE, 3)  # --over_null=order_by 
   X1 = cs_rank(_x_0)
   X2 = ts_rank(_x_0, 5)
   ```
4. Comme il est facile de se tromper, il est fortement recommandé de générer un `output_file` pour vérifier si le code généré est correct.

## Limitations de `expr_codegen`

1. Le `DAG` ne peut qu’ajouter des colonnes, jamais en supprimer. Si un nom de colonne existe déjà, il sera écrasé.
2. La suppression de lignes n’est pas supportée, mais on peut ajouter une colonne de marquage pour suppression, puis supprimer les lignes à l’extérieur. Supprimer une ligne affecte toutes les colonnes, ce qui n’est pas compatible avec le `DAG`.
3. Le ré-échantillonnage n’est pas supporté, pour la même raison. Il faut le faire à l’extérieur.
4. On peut considérer la suppression de lignes et le ré-échantillonnage comme une frontière pour diviser le code en plusieurs `DAG` reliés. C’est complexe et difficile à comprendre, donc non implémenté au final.

## Syntaxe spéciale

1. Prend en charge l’expression ternaire `C?T:F` (uniquement dans les chaînes), qui sera convertie en interne en `C or True if( T )else F`, puis corrigée en `T if C else F`, et enfin en `if_else(C,T,F)`. Peut être mixée avec `if else`.
2. `(A<B)*-1` sera transformé en interne en `int_(A<B)*-1`
3. Pour éviter que `A==B` soit remplacé par `False` par `sympy`, il sera converti en interne en `Eq(A,B)`
4. Le sens de `A^B` dépend du paramètre `convert_xor`. Si `convert_xor=True`, il sera converti en interne en `Pow(A,B)`, sinon en `Xor(A,B)`. Par défaut `False`, utiliser `**` pour la puissance.
5. Prend en charge `A&B&C`, mais pas `A==B==C`. Si C est booléen et AB numériques, remplacer manuellement par `(A==B)==C`. Si ABC sont numériques, remplacer par `(A==B)&(B==C)`
6. `A<=B<=C` n’est pas supporté, remplacer par `(A<=B)&(B<=C)`
7. Prend en charge `A[0]+B[1]+C[2]`, qui sera converti en interne en `A+ts_delay(B,1)+ts_delay(C,2)`
8. Prend en charge `~A`, qui sera transformé en interne en `Not(A)`
9. Toute fonction commençant par `gp_` retournera la fonction `cs_` correspondante. Par exemple, `gp_func(A,B,C)` sera remplacé par `cs_func(B,C)`, où `A` sert dans `groupby([date, A])`
10. Prend en charge le déballage de tuples `A,B,C=MACD()`, qui sera converti en interne en :
   ```python
   _x_0 = MACD()
   A = unpack(_x_0, 0)
   B = unpack(_x_0, 1)
   C = unpack(_x_0, 2)
   ```
11. Les commentaires sur une ligne supportent l’entrée de paramètres comme : `# --over_null`, `# --over_null=order_by`, `# --over_null=partition_by`
12. Dans un bloc de code, les syntaxes `import`, `def`, `class` sont automatiquement insérées telles quelles dans le code généré

## Variables commençant par un underscore

1. Toutes les colonnes de sortie commençant par `_` seront automatiquement supprimées à la fin. Pour garder une variable, ne commencez jamais son nom par `_`.
2. Pour réduire les calculs redondants, des variables intermédiaires sont automatiquement ajoutées, commençant par `_x_`, comme `_x_0`, `_x_1`, etc. Elles seront supprimées à la fin.
3. Si une expression sur une seule ligne est trop longue ou implique des calculs redondants, on peut utiliser des variables intermédiaires pour la décomposer sur plusieurs lignes. Si la variable intermédiaire commence par `_`, un suffixe numérique sera automatiquement ajouté pour éviter les conflits, par exemple `_A` deviendra `_A_0_`, `_A_1_`, etc. Utilisations typiques :
    1. Même nom de variable, utilisé plusieurs fois, mais ce sont en fait des variables différentes
    2. Affectation cyclique, mais le `DAG` ne supporte pas de cycles. Les variables de même nom à gauche et à droite du `=` sont en fait différentes

## Exemple de résultat de transcompilation

Extrait de code généré ; pour le code complet, voir [version Polars](examples/output_polars.py)

```python
def func_0_ts__asset(df: pl.DataFrame) -> pl.DataFrame:
    df = df.sort(by=[_DATE_])
    # ========================================
    df = df.with_columns(
        _x_0=1 / ts_delay(OPEN, -1),
        LABEL_CC_1=(-CLOSE + ts_delay(CLOSE, -1)) / CLOSE,
    )
    # ========================================
    df = df.with_columns(
        LABEL_OO_1=_x_0 * ts_delay(OPEN, -2) - 1,
        LABEL_OO_2=_x_0 * ts_delay(OPEN, -3) - 1,
    )
    return df
```

Extrait de code généré ; pour le code complet, voir [version Pandas](examples/output_pandas.py)

```python
def func_2_cs__date(df: pd.DataFrame) -> pd.DataFrame:
    # expr_4 = cs_rank(x_7)
    df["expr_4"] = (df["x_7"]).rank(pct=True)
    return df


def func_3_ts__asset__date(df: pd.DataFrame) -> pd.DataFrame:
    # expr_5 = -ts_corr(OPEN, CLOSE, 10)
    df["expr_5"] = -(df["OPEN"]).rolling(10).corr(df["CLOSE"])
    # expr_6 = ts_delta(OPEN, 10)
    df["expr_6"] = df["OPEN"].diff(10)
    return df

```

## Déploiement local de l’interface web

Il suffit d’exécuter `streamlit run streamlit_app.py`


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---