# expr_codegen Ausdrucks-Übersetzer

## Projekt-Hintergrund

Nachdem ich meine neue Bibliothek [polars_ta](https://github.com/wukan1986/polars_ta) veröffentlicht habe, habe ich rückblickend reflektiert, was `expr_codegen` eigentlich ist.

> `expr_codegen` ist im Wesentlichen eine `DSL`, eine domänenspezifische Sprache (Domain Specific Language). Sie definiert jedoch keine neue Syntax.

Es löst zwei Probleme:

1. Mit `polars_ta` können bereits sehr einfach Feature-Berechnungsausdrücke geschrieben werden. Bei Ausdrücken, die `zeitliche und Querschnitts-Indikatoren mischen`, kann mit `expr_codegen` eine automatische Gruppierung erfolgen, was die Arbeit stark erleichtert.
2. `expr_codegen` nutzt `Common Subexpression Elimination` (gemeinsame Unterausdrucksbeseitigung), reduziert dadurch massiv doppelte Berechnungen und steigert die Effizienz.

Selbst im quantitativen Bereich: Für Einsteiger, die nur zeitliche Indikatoren verwenden, reicht `polars_ta`. Für fortgeschrittene Anwender, die Querschnittsindikatoren benötigen, wird `expr_codegen` empfohlen.

Obwohl das Projekt aktuell stark von `polars_ta` abhängt, ist es auch möglich, eine Übersetzung für andere Bibliotheken wie `pandas` oder `cudf.pandas` zu unterstützen – es fehlt derzeit nur eine entsprechend einfache Bibliothek.

## Online-Demo

https://exprcodegen.streamlit.app

Anfänger können diesen Link direkt nutzen, um Ausdrücke zu übersetzen, ohne zusätzliche Software zu installieren. (Dieses Tool ist kostenlos im Ausland gehostet und kann daher etwas langsam laden.)

Weitere Beispiele finden Sie unter [alpha_examples](https://github.com/wukan1986/alpha_examples)

## Anwendungsbeispiel

```python
import sys
from io import StringIO

import polars as pl

from expr_codegen import codegen_exec


def _code_block_1():
    # Faktor-Editierbereich. Mit der IDE-Autovervollständigung können hier Faktoren bearbeitet werden.
    LOG_MC_ZS = cs_mad_zscore(log1p(market_cap))


def _code_block_2():
    # Im Template sind bereits viele Operatoren aus from polars_ta.prefix importiert,
    # talib ist jedoch standardmäßig nicht importiert. Mit dieser Schreibweise kann der Import im generierten Code erfolgen.
    from polars_ta.prefix.talib import ts_LINEARREG_SLOPE  # noqa

    # Auch def- und class-Definitionen werden unverändert übernommen.
    def cs_rank_if(condition, factor):
        return cs_rank(if_else(condition, factor, None))

    class Clazz:
        pass

    # 1. Mit Unterstrich beginnende Variablen sind nur Zwischenvariablen, werden automatisch umbenannt und beim Output entfernt.
    # 2. Mit Unterstrich beginnende Variablen können wiederverwendet werden. Bei komplexen Faktoren mit mehreren Zeilen gibt es keine Konflikte bei mehrfach verwendeten Zwischenvariablen.
    _avg = ts_mean(corr, 20)
    _std = ts_std_dev(corr, 20)
    _beta = ts_LINEARREG_SLOPE(corr, 20)

    # 3. Mit Unterstrich beginnende Variablen können zyklisch zugewiesen werden. Beim Debuggen kann man schnell mit Kommentaren umschalten.
    _avg = cs_mad_zscore_resid(_avg, LOG_MC_ZS, ONE)
    _std = cs_mad_zscore_resid(_std, LOG_MC_ZS, ONE)
    # _beta = cs_mad_zscore_resid(_beta, LOG_MC_ZS, ONE)

    _corr = cs_zscore(_avg) + cs_zscore(_std)
    CPV = cs_zscore(_corr) + cs_zscore(_beta)


code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=sys.stdout)  # Code ausgeben
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file="output.py")  # In Datei speichern
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by')  # Nur ausführen, nicht speichern

code = StringIO()
codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=code)  # In String speichern
code.seek(0)
code.read()  # Code lesen

# TODO Mit passenden Daten ersetzen
df = pl.DataFrame()
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect()  # Lazy CPU
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect(engine="gpu")  # Lazy GPU

```

## Verzeichnisstruktur

```commandline
│  requirements.txt # Abhängigkeiten mit `pip install -r requirements.txt` installieren
├─data
│      prepare_date.py # Daten vorbereiten
├─examples
│      demo_express.py # Schnelles Beispiel: Ausdruck in Code umwandeln
│      demo_exec_pl.py # Generierten Code ausführen und plotten
│      demo_transformer.py # Drittanbieter-Ausdruck in internen Ausdruck umwandeln
│      output.py # Ergebnisausgabe. Kann ohne Änderungen von anderen Projekten importiert werden
│      show_tree.py # Ausdrucksbaum zeichnen. Nützlich für Vergleich und Optimierung
│      sympy_define.py # Symboldefinitionen. Aufgrund häufiger Nutzung extrahiert
├─expr_codegen
│   │  expr.py # Grundlegende Ausdrucksverarbeitungsfunktionen
│   │  tool.py # Zentrale Werkzeugfunktionen
│   ├─polars
│   │  │  code.py # Codegenerierung für Polars-Syntax
│   │  │  template.py.j2 # `Jinja2`-Template zur Generierung der py-Datei, muss i.d.R. nicht angepasst werden
│   │  │  printer.py # Von `Sympy.StrPrinter` abgeleitet; bei neuen Funktionen ggf. anpassen
```

## Funktionsweise

Dieses Projekt basiert auf dem `sympy`-Projekt. Die wichtigsten verwendeten Funktionen sind:

1. `simplify`: Vereinfacht komplexe Ausdrücke
2. `cse`: `Common Subexpression Elimination` (gemeinsame Unterausdrucksbeseitigung)
3. `StrPrinter`: Gibt je nach Funktion unterschiedliche Strings aus. Durch Anpassung kann Unterstützung für andere Sprachen/Bibliotheken erfolgen

Da `groupby` und `sort` recht zeitintensiv sind, kann durch vorherige Klassifizierung der Formeln und Nutzung unterschiedlicher `groupby`-Operationen die Rechenzeit reduziert werden.

1. `ts_xxx(ts_xxx)`: Kann in derselben `groupby`-Gruppe berechnet werden
2. `cs_xxx(cs_xxx)`: Kann in derselben `groupby`-Gruppe berechnet werden
3. `ts_xxx(cs_xxx)`: Muss in unterschiedlichen `groupby`-Gruppen berechnet werden
4. `cs_xxx(ts_xxx(cs_xxx))`: Muss in drei unterschiedlichen `groupby`-Gruppen berechnet werden
5. `gp_xxx(aa, )+gp_xxx(bb, )`: Da sich `aa` und `bb` unterscheiden, müssen zwei verschiedene `groupby`-Gruppen verwendet werden

Daher:

1. Es wird eine Funktion benötigt, die die aktuelle Kategorie (`get_current`) und die Kategorie der Unterausdrücke (`get_children`) ermittelt
2. Unterscheiden sich aktuelle Kategorie und Unterkategorie, können kurze Formeln extrahiert werden (`extract`). Gleichartige Ausdrücke auf verschiedenen Ebenen stehen in Beziehung und dürfen nicht in derselben `groupby`-Gruppe sein
3. Mit Hilfe von `cse` werden lange Ausdrücke durch zuvor extrahierte kurze Ausdrücke ersetzt und in einen gerichteten azyklischen Graphen (`DAG`) gegeben
4. Über die Ebenen im DAG werden `ts`, `cs`, `gp` einer Ebene ohne Reihenfolge berechnet
5. In jeder Ebene werden `ts`, `cs`, `gp` gruppiert und der Code generiert (`codegen`)

Implizite Informationen:

1. `ts`: sort(by=[ASSET, DATE]).groupby(by=[ASSET], maintain_order=True)
2. `cs`: sort(by=[DATE]).groupby(by=[DATE], maintain_order=False)
3. `gp`: sort(by=[DATE, GROUP]).groupby(by=[DATE, GROUP], maintain_order=False)

Das bedeutet:

1. Zeitreihenfunktionen verbergen die beiden Felder `ASSET` und `DATE`, Querschnittsfunktionen das Feld `DATE`
2. Gruppierungsfunktionen führen ein Feld `GROUP` ein und verbergen gleichzeitig das Feld `DATE`

Zwei Klassifizierungsmethoden:

1. Klassifizierung nach Operatorpräfix (`get_current_by_prefix`), Operatoren müssen mit `ts_`, `cs_`, `gp_` beginnen
2. Klassifizierung nach Operatorname (`get_current_by_name`), keine Einschränkung beim Namen. Zum Beispiel kann `cs_rank` auch einfach `rank` heißen

## Null-Behandlung

Wie entstehen `null`-Werte?

1. Durch Handelsaussetzung. Diese werden vor der Berechnung herausgefiltert und beeinflussen die nachfolgenden Berechnungen nicht.
2. Unterschiedliche Handelszeiten verschiedener Instrumente
3. Durch Berechnungen. `null`-Werte an den Enden einer Zeitreihe beeinflussen die nachfolgenden Zeitreihenfunktionen nicht, aber `null`-Werte in der Mitte können Auswirkungen haben. Beispiel: `if_else(close<2, None, close)`

https://github.com/pola-rs/polars/issues/12925#issuecomment-2552764629

Sehr gute Idee, zusammengefasst gibt es zwei Umsetzungsvarianten:

1. `null`-Werte in eine Gruppe, `not_null`-Werte in eine andere Gruppe. Zweimal aufrufen.
2. Nur eine Gruppe, aber mit zusammengesetztem Sortieren: `null` zuerst, `not_null` danach. Einmal aufrufen, etwas schneller.

```python
X1 = (ts_returns(CLOSE, 3)).over(CLOSE.is_not_null(), _ASSET_, order_by=_DATE_),
X2 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=[CLOSE.is_not_null(), _DATE_]),
X3 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=_DATE_),
```

Ob bei Methode 2 der vordere `null`-Bereich das Ergebnis beeinflusst, hängt vom Operator ab – besonders bei mehreren Spalten kann in `null`-Bereichen Daten vorhanden sein.

1. `over_null='partition_by'`: In zwei Bereiche aufteilen
2. `over_null='order_by'`: In einen Bereich, `null` vorne
3. `over_null=None`: Keine Behandlung, direkt aufrufen, schneller. Wenn sicher ist, dass keine mittigen `null` entstehen, diesen Parameter verwenden

`codegen_exec(over_null='partition_by')` verwendet global `partition_by`. Bei Funktionen wie `ts_count_nulls` muss jedoch `over_null=None` verwendet werden. Daher gibt es eine Kommentarfunktion zur Festlegung von Parametern für einzelne Ausdrücke:

1. `# --over_null partition_by`: Einzelzeile mit `over_null='partition_by'`
2. `# --over_null=order_by`: Einzelzeile mit `over_null='order_by'`
3. `# --over_null`: Einzelzeile mit `over_null=None`
4. `# `: Verwendet den bei `codegen_exec` übergebenen Wert für `over_null`

Hinweise:

1. Der Kommentar `# --over_null` muss am Ende des Ausdrucks stehen, nicht allein in einer Zeile, sonst wird er ignoriert.
2. Bei mehreren `#`-Kommentaren wie `# --over_null # --over_null=order_by` wird nur der erste gültige genommen.
3. Gilt nur für die äußerste `ts`-Funktion. Ist `ts` nicht äußerste, muss manuell extrahiert werden. Beispiel:
   ```python
   X1 = cs_rank(ts_mean(CLOSE, 3)) # --over_null=order_by # Wirkt auf cs_rank, ist aber nicht sinnvoll
   X2 = ts_rank(ts_mean(CLOSE, 3), 5) # --over_null=order_by # Sollte eigentlich auf ts_rank(ts_mean) wirken, aber wegen cse wird es auf ts_rank(_x_0) angewendet
   ```

   Muss geschrieben werden als:

   ```python
   _x_0 = ts_mean(CLOSE, 3)  # --over_null=order_by 
   X1 = cs_rank(_x_0)
   X2 = ts_rank(_x_0, 5)
   ```
4. Da Fehler leicht passieren können, wird dringend empfohlen, ein `output_file` zu generieren und den Code zu prüfen.

## Einschränkungen von `expr_codegen`

1. `DAG` kann nur Spalten hinzufügen, nicht löschen. Beim Hinzufügen mit gleichem Namen wird überschrieben.
2. Zeilen löschen wird nicht unterstützt, aber es kann eine Markierungsspalte hinzugefügt werden, um Zeilen extern zu löschen. Das Löschen betrifft alle Spalten und widerspricht dem `DAG`-Prinzip.
3. Resampling wird nicht unterstützt, aus demselben Grund wie das Löschen von Zeilen. Muss extern erfolgen.
4. Zeilenlöschen und Resampling können als Trennlinie genutzt werden, sodass große Codeblöcke in mehrere `DAG`s aufgeteilt werden. Dies ist aber komplex und schwer verständlich, daher nicht umgesetzt.

## Spezielle Syntax

1. Unterstützung für ternäre Ausdrücke `C?T:F` (nur als String), wird intern zu `C or True if( T )else F`, dann zu `T if C else F` und schließlich zu `if_else(C,T,F)` umgewandelt. Kann mit `if else` gemischt werden.
2. `(A<B)*-1` wird zu `int_(A<B)*-1` umgewandelt.
3. Um zu verhindern, dass `A==B` von `sympy` zu `False` ersetzt wird, wird intern `Eq(A,B)` verwendet.
4. Die Bedeutung von `A^B` hängt vom Parameter `convert_xor` ab: `convert_xor=True` wandelt es in `Pow(A,B)` um, sonst in `Xor(A,B)`. Standard ist `False`, für Potenz wird `**` empfohlen.
5. Unterstützung für `A&B&C`, aber nicht für `A==B==C`. Wenn C boolesch, AB numerisch, kann manuell zu `(A==B)==C` ersetzt werden. Wenn ABC numerisch, zu `(A==B)&(B==C)`.
6. `A<=B<=C` wird nicht unterstützt, muss manuell zu `(A<=B)&(B<=C)` umgewandelt werden.
7. Unterstützung für `A[0]+B[1]+C[2]`, wird intern zu `A+ts_delay(B,1)+ts_delay(C,2)` umgewandelt.
8. Unterstützung für `~A`, wird intern zu `Not(A)` umgewandelt.
9. Funktionen mit `gp_`-Präfix geben die jeweilige `cs_`-Funktion zurück. Beispiel: `gp_func(A,B,C)` wird zu `cs_func(B,C)`, wobei `A` für `groupby([date, A])` genutzt wird.
10. Unterstützung für Tuple-Unpacking wie `A,B,C=MACD()`, was intern ersetzt wird durch:
   ```python
   _x_0 = MACD()
   A = unpack(_x_0, 0)
   B = unpack(_x_0, 1)
   C = unpack(_x_0, 2)
   ```
11. Einzelzeilenkommentare unterstützen Parameter wie `# --over_null`, `# --over_null=order_by`, `# --over_null=partition_by`
12. In Codeblöcken werden `import`, `def` und `class`-Anweisungen automatisch unverändert in den generierten Code übernommen

## Variablen mit Unterstrich am Anfang

1. Spalten, die mit `_` beginnen, werden im Output automatisch gelöscht. Variablen, die erhalten bleiben sollen, dürfen daher nicht mit `_` beginnen.
2. Um Wiederholungsberechnungen zu vermeiden, werden automatisch Zwischenvariablen mit Präfix `_x_` wie `_x_0`, `_x_1` etc. hinzugefügt. Diese werden am Ende entfernt.
3. Bei zu langen Einzelzeilenausdrücken oder Wiederholungsberechnungen kann mittels Zwischenvariablen ein Ausdruck in mehrere Zeilen aufgeteilt werden. Werden diese mit `_` begonnen, wird automatisch eine numerische Endung hinzugefügt, sodass unterschiedliche Variablen wie `_A_0_`, `_A_1_` etc. entstehen. Anwendungsfälle:
    1. Wiederverwendung desselben Variablennamens; eigentlich verschiedene Variablen
    2. Zyklische Zuweisung, aber `DAG` unterstützt keine Kreise. Gleicher Variablenname links und rechts vom `=` sind unterschiedliche Variablen

## Beispiel für Übersetzungsergebnis

Auszug aus dem übersetzten Code – vollständigen Code siehe [Polars-Version](examples/output_polars.py):

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

Auszug aus dem übersetzten Code – vollständigen Code siehe [Pandas-Version](examples/output_pandas.py):

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

## Lokale Bereitstellung der interaktiven Webseite

Einfach `streamlit run streamlit_app.py` ausführen.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---