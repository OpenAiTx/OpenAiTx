# expr_codegen Expressie-codegenerator

## Projectachtergrond

Na de introductie van mijn nieuwe [polars_ta](https://github.com/wukan1986/polars_ta) bibliotheek, kijk ik terug op wat `expr_codegen` eigenlijk is.

> `expr_codegen` is in essentie een `DSL`, een domeinspecifieke taal (Domain Specific Language). Maar het definieert geen nieuwe syntaxis.

Het lost twee problemen op:

1. Met `polars_ta` is het al eenvoudig om kenmerkberekeningsexpressies te schrijven, maar bij expressies die `tijdreeksen en cross-secties mengen`, kan met `expr_codegen` automatisch groeperen veel werk besparen.
2. `expr_codegen` gebruikt `Common Subexpression Elimination` (eliminatie van gemeenschappelijke subexpressies), wat veel dubbele berekeningen vermindert en de efficiëntie verhoogt.

Zelfs in de kwantitatieve sector: junior onderzoekers, die zich beperken tot tijdreeksindicatoren, kunnen alleen `polars_ta` gebruiken, maar voor gevorderden die cross-sectie-indicatoren gebruiken, wordt `expr_codegen` aanbevolen.

Hoewel dit project momenteel sterk afhankelijk is van `polars_ta`, ondersteunt het ook vertaling naar andere bibliotheken, zoals `pandas / cudf.pandas`, alleen ontbreekt er momenteel een vrij eenvoudige bibliotheek.

## Online demo

https://exprcodegen.streamlit.app

Beginners kunnen deze link direct bezoeken om expressies te vertalen, zonder extra software te hoeven installeren. (Deze tool is gratis gehost in het buitenland, het laden kan wat traag zijn.)

Voor meer volledige voorbeelden, zie [alpha_examples](https://github.com/wukan1986/alpha_examples).

## Voorbeeld van gebruik

```python
import sys
from io import StringIO

import polars as pl

from expr_codegen import codegen_exec


def _code_block_1():
    # Factorbewerkingsgebied, gebruik de slimme suggesties van de IDE om factoren in dit gebied te bewerken
    LOG_MC_ZS = cs_mad_zscore(log1p(market_cap))


def _code_block_2():
    # In de sjabloon zijn standaard veel operatoren uit polars_ta.prefix geïmporteerd,
    # maar talib is niet standaard geïmporteerd. Met deze schrijfwijze wordt de import in de gegenereerde code opgenomen
    from polars_ta.prefix.talib import ts_LINEARREG_SLOPE  # noqa

    # Ook def en class worden ongewijzigd geïmporteerd
    def cs_rank_if(condition, factor):
        return cs_rank(if_else(condition, factor, None))

    class Clazz:
        pass

    # 1. Variabelen die beginnen met een underscore zijn slechts tussenvariabelen,
    # worden automatisch hernoemd en bij de uiteindelijke uitvoer verwijderd
    # 2. Variabelen die beginnen met een underscore kunnen herhaaldelijk worden gebruikt.
    # Bij het schrijven van meerdere complexe factoren over meerdere regels is er geen conflict bij hergebruik van tussenvariabelen
    _avg = ts_mean(corr, 20)
    _std = ts_std_dev(corr, 20)
    _beta = ts_LINEARREG_SLOPE(corr, 20)

    # 3. Variabelen die beginnen met een underscore kunnen cyclisch worden toegekend.
    # Bij het debuggen kan men snel schakelen met commentaarregels
    _avg = cs_mad_zscore_resid(_avg, LOG_MC_ZS, ONE)
    _std = cs_mad_zscore_resid(_std, LOG_MC_ZS, ONE)
    # _beta = cs_mad_zscore_resid(_beta, LOG_MC_ZS, ONE)

    _corr = cs_zscore(_avg) + cs_zscore(_std)
    CPV = cs_zscore(_corr) + cs_zscore(_beta)


code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=sys.stdout)  # Code printen
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file="output.py")  # Opslaan naar bestand
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by')  # Alleen uitvoeren, niet opslaan

code = StringIO()
codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=code)  # Opslaan naar string
code.seek(0)
code.read()  # Code lezen

# TODO Vervang door geschikte data
df = pl.DataFrame()
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect()  # Lazy CPU
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect(engine="gpu")  # Lazy GPU

```

## Mappenstructuur

```commandline
│  requirements.txt # Installeer afhankelijkheden met `pip install -r requirements.txt`
├─data
│      prepare_date.py # Data voorbereiden
├─examples
│      demo_express.py # Snelstartvoorbeeld. Laat zien hoe expressies naar code worden omgezet
│      demo_exec_pl.py # Laat zien hoe de geconverteerde code wordt aangeroepen en gevisualiseerd
│      demo_transformer.py # Laat zien hoe externe expressies naar interne expressies worden vertaald
│      output.py # Resultaatuitvoer. Kan zonder aanpassing door andere projecten worden geïmporteerd
│      show_tree.py # Teken expressieboomdiagram. Voor analyse en vergelijking van optimalisatieresultaten
│      sympy_define.py # Symbooldefinities, vanwege veelvuldig gebruik centraal verzameld
├─expr_codegen
│   │  expr.py # Basisfuncties voor expressieverwerking
│   │  tool.py # Kernhulpcodes
│   ├─polars
│   │  │  code.py # Codegeneratiefuncties voor polars-syntaxis
│   │  │  template.py.j2 # `Jinja2`-sjabloon. Voor het genereren van py-bestanden, meestal niet aan te passen
│   │  │  printer.py # Uitgebreid van `Sympy`'s `StrPrinter`, mogelijk aan te passen bij toevoegen van nieuwe functies
```

## Werkingsprincipe

Dit project is afhankelijk van het `sympy`-project. De belangrijkste functies die worden gebruikt zijn:

1. `simplify`: Vereenvoudigt complexe expressies
2. `cse`: `Common Subexpression Elimination` (eliminatie van gemeenschappelijke subexpressies)
3. `StrPrinter`: Genereert verschillende stringuitvoer afhankelijk van de functie. Door deze code aan te passen, kan men andere talen of bibliotheken ondersteunen

Omdat `groupby` en `sort` tijdrovend zijn, kan het vooraf indelen van formules in categorieën en het gebruik van verschillende `groupby`'s per categorie de rekentijd verminderen.

1. `ts_xxx(ts_xxx)`: Kan binnen dezelfde `groupby` worden berekend
2. `cs_xxx(cs_xxx)`: Kan binnen dezelfde `groupby` worden berekend
3. `ts_xxx(cs_xxx)`: Moet in verschillende `groupby`'s worden berekend
4. `cs_xxx(ts_xxx(cs_xxx))`: Moet in drie verschillende `groupby`'s worden berekend
5. `gp_xxx(aa, )+gp_xxx(bb, )`: Omdat `aa` en `bb` verschillen, moeten deze in twee verschillende `groupby`'s worden berekend

Dus:

1. Er moet een functie zijn die de categorie van de huidige expressie (`get_current`) en van de subexpressies (`get_children`) kan bepalen
2. Als de huidige categorie verschilt van de subcategorie, kan een korte formule worden geëxtraheerd (`extract`). Expressies van dezelfde categorie op verschillende niveaus hebben een volgorde, en mogen niet in dezelfde `groupby`
3. Gebruik het kenmerk van `cse` om lange expressies te vervangen door eerder geëxtraheerde korte expressies, en voer ze in een gerichte acyclische graaf (`DAG`) in
4. Gebruik de doorstroming van de gerichte acyclische graaf om te groeperen per laag. Binnen dezelfde laag worden `ts`, `cs`, `gp` niet onderscheiden
5. Binnen dezelfde laag worden `ts`, `cs`, `gp` gegroepeerd, waarna de code wordt gegenereerd (`codegen`)

Impliciete informatie:

1. `ts`: sort(by=[ASSET, DATE]).groupby(by=[ASSET], maintain_order=True)
2. `cs`: sort(by=[DATE]).groupby(by=[DATE], maintain_order=False)
3. `gp`: sort(by=[DATE, GROUP]).groupby(by=[DATE, GROUP], maintain_order=False)

Dus:

1. Tijdreeksfuncties verbergen twee velden: `ASSET, DATE`; cross-sectiefuncties verbergen één veld: `DATE`
2. Groepeerfuncties voegen een veld `GROUP` toe en verbergen één veld `DATE`

Twee classificatiemethoden:

1. Classificatie op basis van operatorprefix (`get_current_by_prefix`), waarbij operatoren moeten beginnen met `ts_`, `cs_`, `gp_`
2. Classificatie op basis van de volledige operatornaam (`get_current_by_name`), zonder beperking van de operatornaam. Bijvoorbeeld: `cs_rank` kan ook `rank` heten

## Null-afhandeling

Hoe ontstaat `null`?

1. Door opschorting van de handel. Wordt vóór de berekening gefilterd en beïnvloedt latere berekeningen niet.
2. Verschillende handelsuren voor verschillende producten
3. Wordt gegenereerd tijdens berekening. `null` aan de randen van een reeks heeft geen invloed op latere tijdreeksoperatoren, maar `null` in het midden wel. Bijvoorbeeld: `if_else(close<2, None, close)`

https://github.com/pola-rs/polars/issues/12925#issuecomment-2552764629

Een uitstekend idee, samengevat zijn er twee manieren om dit te realiseren:

1. `null` en `not_null` in aparte groepen opdelen. Twee keer aanroepen vereist
2. Slechts één groep, maar met samengestelde sortering: `null` vooraan, `not_null` achteraan. Slechts één keer aanroepen, iets sneller

```python
X1 = (ts_returns(CLOSE, 3)).over(CLOSE.is_not_null(), _ASSET_, order_by=_DATE_),
X2 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=[CLOSE.is_not_null(), _DATE_]),
X3 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=_DATE_),
```

Bij optie 2 bepaalt de operator of het `null`-gebied aan het begin het resultaat beïnvloedt, vooral bij meerdere kolommen kan het `null`-gebied data bevatten.

1. `over_null='partition_by'`: Opdelen in twee gebieden
2. `over_null='order_by'`: In één gebied, `null` vooraan
3. `over_null=None`: Niet verwerken, direct aanroepen, sneller. Gebruik deze parameter als je zeker weet dat er geen `null` in het midden ontstaat

`codegen_exec(over_null='partition_by')` gebruikt globaal `partition_by`. Maar bij functies zoals `ts_count_nulls` moet `over_null=None` worden gebruikt, daarom is er een commentaarfunctie toegevoegd voor parameters per expressieregel:

1. `# --over_null partition_by`: Per regel `over_null='partition_by'`
2. `# --over_null=order_by`: Per regel `over_null='order_by'`
3. `# --over_null`: Per regel `over_null=None`
4. `# `: Gebruikt de waarde van de `over_null` parameter van `codegen_exec`

Let op:

1. Commentaar zoals `# --over_null` mag alleen aan het einde van de regel staan, niet los, anders wordt het genegeerd
2. Als er meerdere `# --over_null # --over_null=order_by` op een regel staan, wordt alleen de eerste gebruikt
3. Geldt alleen voor de buitenste `ts`-functie. Als de `ts`-functie niet buitenaan staat, moet deze handmatig worden geëxtraheerd, bijvoorbeeld:
   ```python
   X1 = cs_rank(ts_mean(CLOSE, 3)) # --over_null=order_by # Past toe op cs_rank, heeft geen betekenis
   X2 = ts_rank(ts_mean(CLOSE, 3), 5) # --over_null=order_by # Men denkt dat het op ts_rank(ts_mean) slaat, maar bij een gedeelde ts_mean is het eigenlijk op ts_rank(_x_0)
   ```

   Moet worden geschreven als:

   ```python
   _x_0 = ts_mean(CLOSE, 3)  # --over_null=order_by 
   X1 = cs_rank(_x_0)
   X2 = ts_rank(_x_0, 5)
   ```
4. Omdat fouten snel gemaakt zijn, wordt aangeraden om het `output_file` te genereren en de gegenereerde code te controleren.

## Beperkingen van `expr_codegen`

1. `DAG` kan alleen kolommen toevoegen, niet verwijderen. Toevoegen van kolommen met dezelfde naam overschrijft bestaande
2. Verwijderen van rijen wordt niet ondersteund, maar een kolom met verwijdermarkering kan worden toegevoegd, waarna buitenaf rijen verwijderd worden. Verwijderen van rijen beïnvloedt alle kolommen, en voldoet niet aan `DAG`
3. Resampling wordt niet ondersteund, om dezelfde reden als het niet ondersteunen van rijen verwijderen. Dit moet buitenaf gebeuren
4. Verwijderen van rijen en resampling kunnen als scheidingslijn worden gebruikt, waarbij grote stukken code in meerdere `DAG`'s worden gesplitst. Dit is complex en moeilijk te begrijpen, daarom is het uiteindelijk niet geïmplementeerd

## Speciale syntaxis

1. Ondersteuning voor de drie-waarde-operator `C?T:F` (alleen in strings), wordt intern eerst omgezet naar `C or True if( T )else F`, dan naar `T if C else F`, en uiteindelijk naar `if_else(C,T,F)`. Ondersteunt gemengd gebruik met `if else`
2. `(A<B)*-1` wordt intern omgezet naar `int_(A<B)*-1`
3. Om te voorkomen dat `A==B` door `sympy` wordt vervangen door `False`, wordt dit intern omgezet naar `Eq(A,B)`
4. De betekenis van `A^B` hangt af van de parameter `convert_xor`. Bij `convert_xor=True` wordt het omgezet naar `Pow(A,B)`, anders naar `Xor(A,B)`. Standaard is `False`, gebruik `**` voor machtsverheffen
5. Ondersteunt `A&B&C`, maar niet `A==B==C`. Als C boolean is en AB numeriek, vervang dan handmatig door `(A==B)==C`. Als ABC numeriek zijn, vervang dan handmatig door `(A==B)&(B==C)`
6. `A<=B<=C` wordt niet ondersteund, vervang handmatig door `(A<=B)&(B<=C)`
7. Ondersteunt `A[0]+B[1]+C[2]`, wordt intern omgezet naar `A+ts_delay(B,1)+ts_delay(C,2)`
8. Ondersteunt `~A`, wordt intern omgezet naar `Not(A)`
9. Functies die beginnen met `gp_` retourneren altijd de corresponderende `cs_`-functie. Bijvoorbeeld: `gp_func(A,B,C)` wordt `cs_func(B,C)`, waarbij `A` wordt gebruikt in `groupby([date, A])`
10. Ondersteunt tuple-unpacking zoals `A,B,C=MACD()`, wat intern wordt omgezet naar:
   ```python
   _x_0 = MACD()
   A = unpack(_x_0, 0)
   B = unpack(_x_0, 1)
   C = unpack(_x_0, 2)
   ```
11. Ondersteunt parameterinput via commentaar op één regel, zoals: `# --over_null`, `# --over_null=order_by`, `# --over_null=partition_by`
12. In codeblokken worden `import`, `def`, en `class` ongewijzigd in de gegenereerde code opgenomen

## Variabelen die beginnen met een underscore

1. Alle outputkolommen die beginnen met `_` worden uiteindelijk automatisch verwijderd. Variabelen die behouden moeten blijven, mogen niet met `_` beginnen
2. Om dubbele berekeningen te verminderen worden automatisch tussenvariabelen toegevoegd, beginnend met `_x_`, zoals `_x_0`, `_x_1`, enz. Deze worden uiteindelijk automatisch verwijderd
3. Bij te lange expressies op één regel, of bij dubbele berekeningen, kan men tussenvariabelen gebruiken om de expressie op te splitsen in meerdere regels. Als de tussenvariabele met `_` begint, wordt automatisch een numeriek achtervoegsel toegevoegd, zodat verschillende variabelen ontstaan, zoals `_A` wordt `_A_0_`, `_A_1_`, etc. Toepassingen:
    1. Herhaald gebruik van dezelfde variabelenaam, feitelijk verschillende variabelen
    2. Cyclische toekenning, maar `DAG` ondersteunt geen cycli. Links en rechts van het `=`-teken zijn feitelijk verschillende variabelen

## Voorbeeld van vertaalde code

Fragment van de vertaalde code, zie voor volledige code de [Polars-versie](examples/output_polars.py)

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

Fragment van de vertaalde code, zie voor volledige code de [Pandas-versie](examples/output_pandas.py)

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

## Lokale webinterface

Voer gewoon uit: `streamlit run streamlit_app.py`


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---