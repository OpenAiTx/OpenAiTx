# expr_codegen Tłumacz wyrażeń

## Tło projektu

Po wydaniu mojego nowego pakietu [polars_ta](https://github.com/wukan1986/polars_ta), ponownie zastanowiłem się, czym właściwie jest `expr_codegen`.

> `expr_codegen` to w istocie `DSL`, czyli język specyficzny dla dziedziny (Domain Specific Language). Jednak nie definiuje on nowej składni.

Rozwiązuje dwa problemy:

1. `polars_ta` pozwala bardzo wygodnie pisać wyrażenia do obliczania cech, ale przy wyrażeniach `mieszających szereg czasowy i przekrój`, dzięki `expr_codegen` można automatycznie grupować, co znacznie oszczędza pracę.
2. `expr_codegen` wykorzystuje eliminację wspólnych podwyrażeń (Common Subexpression Elimination), przez co znacznie ogranicza powtarzane obliczenia i poprawia wydajność.

Nawet w dziedzinie kwantytatywnej, początkujący badacze, ograniczeni do wskaźników szeregów czasowych, mogą używać samego `polars_ta`, a średniozaawansowanym i zaawansowanym badaczom korzystającym z wskaźników przekrojowych poleca się `expr_codegen`.

Chociaż obecnie projekt ten jest bardzo ściśle powiązany z `polars_ta`, można go również przetłumaczyć na inne biblioteki, np. `pandas / cudf.pandas`, tylko obecnie brakuje prostszego pakietu.

## Demo online

https://exprcodegen.streamlit.app

Użytkownicy początkujący mogą bezpośrednio odwiedzić ten link, aby tłumaczyć wyrażenia, bez konieczności instalowania dodatkowego oprogramowania. (To narzędzie jest darmowo hostowane za granicą, więc może otwierać się wolniej)

Bardziej kompletne przykłady znajdziesz w [alpha_examples](https://github.com/wukan1986/alpha_examples)

## Przykład użycia

```python
import sys
from io import StringIO

import polars as pl

from expr_codegen import codegen_exec


def _code_block_1():
    # Edycja wskaźników, możesz edytować wskaźniki w tym obszarze korzystając z podpowiedzi IDE
    LOG_MC_ZS = cs_mad_zscore(log1p(market_cap))


def _code_block_2():
    # W szablonie domyślnie zaimportowano wiele operatorów z from polars_ta.prefix,
    # ale talib nie jest domyślnie importowany. Taki zapis pozwala na import w wygenerowanym kodzie
    from polars_ta.prefix.talib import ts_LINEARREG_SLOPE  # noqa

    # Obsługiwane są także oryginalne importy def i class
    def cs_rank_if(condition, factor):
        return cs_rank(if_else(condition, factor, None))

    class Clazz:
        pass

    # 1. Zmienne zaczynające się od podkreślenia to tylko zmienne pośrednie, zostaną automatycznie przemianowane i usunięte przy końcowym wyjściu
    # 2. Zmienne zaczynające się od podkreślenia można używać wielokrotnie. Przy wielu złożonych wskaźnikach i wieloliniowych zapisach nie będzie konfliktów przy powtarzających się zmiennych pośrednich
    _avg = ts_mean(corr, 20)
    _std = ts_std_dev(corr, 20)
    _beta = ts_LINEARREG_SLOPE(corr, 20)

    # 3. Zmienne z podkreśleniem mają cykliczne przypisanie. Podczas debugowania można szybko przełączać za pomocą komentarzy
    _avg = cs_mad_zscore_resid(_avg, LOG_MC_ZS, ONE)
    _std = cs_mad_zscore_resid(_std, LOG_MC_ZS, ONE)
    # _beta = cs_mad_zscore_resid(_beta, LOG_MC_ZS, ONE)

    _corr = cs_zscore(_avg) + cs_zscore(_std)
    CPV = cs_zscore(_corr) + cs_zscore(_beta)


code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=sys.stdout)  # Wydrukuj kod
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file="output.py")  # Zapisz do pliku
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by')  # Tylko wykonaj, nie zapisuj kodu

code = StringIO()
codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=code)  # Zapisz do stringa
code.seek(0)
code.read()  # Odczytaj kod

# TODO Zamień na odpowiednie dane
df = pl.DataFrame()
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect()  # Lazy CPU
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect(engine="gpu")  # Lazy GPU

```

## Struktura katalogów

```commandline
│  requirements.txt # Instalacja zależności przez `pip install -r requirements.txt`
├─data
│      prepare_date.py # Przygotowanie danych
├─examples
│      demo_express.py # Szybki przykład. Pokazuje jak przekształcić wyrażenie na kod
│      demo_exec_pl.py # Przykład wywołania przekształconego kodu i rysowania wykresu
│      demo_transformer.py # Pokazuje konwersję wyrażenia zewnętrznego na wewnętrzne
│      output.py # Wyjście wyników. Może być importowane przez inne projekty bez modyfikacji kodu
│      show_tree.py # Rysowanie drzewa wyrażeń. Przydatne do analizy i porównania wyników optymalizacji
│      sympy_define.py # Definicje symboli, ponieważ są często używane, wyodrębnione tutaj
├─expr_codegen
│   │  expr.py # Podstawowe funkcje obsługi wyrażeń
│   │  tool.py # Kluczowe narzędzia
│   ├─polars
│   │  │  code.py # Generowanie kodu w składni polars
│   │  │  template.py.j2 # Szablon `Jinja2`. Używany do generowania plików py, zwykle nie wymaga zmian
│   │  │  printer.py # Dziedziczy po `StrPrinter` z `Sympy`, przy dodawaniu nowych funkcji może wymagać edycji
```

## Zasada działania

Ten projekt opiera się na projekcie `sympy`. Główne używane funkcje to:

1. `simplify`: upraszcza złożone wyrażenia
2. `cse`: eliminacja wspólnych podwyrażeń (Common Subexpression Elimination)
3. `StrPrinter`: w zależności od funkcji generuje różne ciągi znaków. Modyfikując ten kod można wspierać inne języki lub biblioteki

Ponieważ `groupby` i `sort` są czasochłonne, wcześniejsze klasyfikowanie formuł i użycie różnych `groupby` dla różnych kategorii pozwala skrócić czas obliczeń.

1. `ts_xxx(ts_xxx)`: można liczyć w jednym `groupby`
2. `cs_xxx(cs_xxx)`: można liczyć w jednym `groupby`
3. `ts_xxx(cs_xxx)`: trzeba liczyć w różnych `groupby`
4. `cs_xxx(ts_xxx(cs_xxx))`: trzeba liczyć w trzech różnych `groupby`
5. `gp_xxx(aa, )+gp_xxx(bb, )`: ponieważ `aa` i `bb` są różne, trzeba liczyć w dwóch różnych `groupby`

Dlatego

1. Potrzebna jest funkcja do uzyskania kategorii bieżącego wyrażenia (`get_current`) oraz kategorii podwyrażeń (`get_children`)
2. Jeśli bieżąca kategoria i podkategoria są różne, można wyodrębnić krótką formułę (`extract`). Wyrażenia tego samego typu, ale na różnych poziomach, mają kolejność i nie mogą być w tym samym `groupby`
3. Wykorzystując cechę `cse`, długie wyrażenia są zamieniane na wcześniej wyodrębnione krótkie wyrażenia, a następnie wprowadzane do skierowanego acyklicznego grafu (`DAG`)
4. Przepływ w `DAG` umożliwia warstwowanie. W tej samej warstwie `ts`, `cs`, `gp` nie rozróżnia się kolejności
5. W tej samej warstwie grupuje się `ts`, `cs`, `gp`, a następnie generuje kod (`codegen`)

Informacje ukryte

1. `ts`: sort(by=[ASSET, DATE]).groupby(by=[ASSET], maintain_order=True)
2. `cs`: sort(by=[DATE]).groupby(by=[DATE], maintain_order=False)
3. `gp`: sort(by=[DATE, GROUP]).groupby(by=[DATE, GROUP], maintain_order=False)

Czyli

1. Funkcje szeregów czasowych ukrywają dwa pola: `ASSET, DATE`, a funkcje przekrojowe jedno pole: `DATE`
2. Funkcje grupujące wprowadzają pole `GROUP`, a jednocześnie ukrywają pole `DATE`

Dwa sposoby klasyfikacji

1. Klasyfikacja według prefiksu operatora (`get_current_by_prefix`), wymaga aby operator zaczynał się od `ts_`, `cs_`, `gp_`
2. Klasyfikacja według pełnej nazwy operatora (`get_current_by_name`), nie ogranicza już nazw operatorów. Np. `cs_rank` może nazywać się `rank`

## Obsługa Null

Jak powstaje `null`?

1. Zatrzymanie notowań. Jest filtrowane przed obliczeniami, więc nie wpływa na dalsze kalkulacje.
2. Różne instrumenty mają różne godziny handlu
3. Powstaje podczas obliczeń. `null` na końcach szeregu nie wpływa na dalsze wyniki operatorów czasowych, ale `null` w środku już tak. Przykład: `if_else(close<2, None, close)`

https://github.com/pola-rs/polars/issues/12925#issuecomment-2552764629

Świetny pomysł, podsumowując są dwa sposoby implementacji:

1. `null` w jednej grupie, `not_null` w innej. Potrzeba dwóch wywołań
2. Jedna grupa, ale złożone sortowanie, gdzie `null` idzie na początek, `not_null` na koniec. Tylko jedno wywołanie, nieco szybsze

```python
X1 = (ts_returns(CLOSE, 3)).over(CLOSE.is_not_null(), _ASSET_, order_by=_DATE_),
X2 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=[CLOSE.is_not_null(), _DATE_]),
X3 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=_DATE_),
```

W drugim przypadku, czy początkowy obszar `null` wpływa na wynik, zależy od operatora, szczególnie przy wielu kolumnach wejściowych `null` może zawierać dane.

1. `over_null='partition_by'`. Podział na dwa obszary
2. `over_null='order_by'`. Jeden obszar, `null` na początku
3. `over_null=None`. Bez obsługi, wywołanie bezpośrednie, szybsze. Jeśli masz pewność, że nie powstanie `null` pośrodku, zaleca się ten parametr

`codegen_exec(over_null='partition_by')` ustawia globalne użycie `partition_by`. Ale dla funkcji typu `ts_count_nulls` trzeba użyć `over_null=None`, dlatego narzędzie dodaje również obsługę adnotacji do określania parametru w pojedynczej linii.

1. `# --over_null partition_by`. Pojedyncza linia `over_null='partition_by'`
2. `# --over_null=order_by`. Pojedyncza linia `over_null='order_by'`
3. `# --over_null`. Pojedyncza linia `over_null=None`
4. `# `. Przyjmuje wartość parametru `over_null` przekazaną do `codegen_exec`

Uwaga:

1. Komentarz `# --over_null` z parametrem można pisać tylko na końcu pojedynczego wyrażenia, nie jako osobną linię, w przeciwnym razie zostanie zignorowany
2. Gdy jest wiele `# --over_null # --over_null=order_by`, brana jest tylko pierwsza ważna
3. Działa tylko na zewnętrzną funkcję `ts`. Jeśli `ts` nie jest na zewnątrz, trzeba wyodrębnić ręcznie. Przykład:
   ```python
   X1 = cs_rank(ts_mean(CLOSE, 3)) # --over_null=order_by # Stosuje się do cs_rank, co nie ma sensu
   X2 = ts_rank(ts_mean(CLOSE, 3), 5) # --over_null=order_by # Miało być do ts_rank(ts_mean), ale przez wspólny ts_mean, stosuje się do ts_rank(_x_0)
   ```

   Powinno być zapisane jako

   ```python
   _x_0 = ts_mean(CLOSE, 3)  # --over_null=order_by 
   X1 = cs_rank(_x_0)
   X2 = ts_rank(_x_0, 5)
   ```
4. Łatwo się tu pomylić, dlatego zaleca się wygenerować `output_file` i sprawdzić, czy kod jest poprawny.

## Ograniczenia `expr_codegen`

1. `DAG` może tylko dodawać kolumny, nie usuwać. Przy dodawaniu kolumn z tą samą nazwą zostaną nadpisane
2. Nie obsługuje `usuwania wierszy`, ale można dodać kolumnę z oznaczeniem do usunięcia, a usuwanie wykonać na zewnątrz. Usuwanie wierszy wpływa na wszystkie kolumny, co nie spełnia założeń `DAG`
3. Nie obsługuje `resamplingu`, z tego samego powodu co brak obsługi usuwania wierszy. Trzeba to wykonać na zewnątrz
4. Można traktować `usuwanie wierszy` i `resampling` jako linię podziału i podzielić kod na kilka `DAG` połączonych szeregowo. Jest to złożone i trudne do zrozumienia, więc ostatecznie nie zaimplementowano

## Szczególna składnia

1. Obsługuje trójargumentowy operator `C?T:F` (tylko w ciągu tekstowym), na dole zostaje przekształcony do `C or True if( T )else F`, potem naprawiony do `T if C else F`, a na koniec do `if_else(C,T,F)`. Można mieszać z `if else`
2. `(A<B)*-1`, zostanie przekształcone do `int_(A<B)*-1`
3. Aby zapobiec przekształceniu `A==B` przez `sympy` do `False`, zostanie zamienione na `Eq(A,B)`
4. Znaczenie `A^B` zależy od parametru `convert_xor`; jeśli `convert_xor=True`, zostanie zamienione na `Pow(A,B)`, w przeciwnym razie na `Xor(A,B)`. Domyślnie `False`, do potęgowania używaj `**`
5. Obsługuje `A&B&C`, ale nie obsługuje `A==B==C`. Jeśli C jest typu bool, a A i B są liczbami, ręcznie zamień na `(A==B)==C`. Jeśli wszystkie są liczbami, zamień ręcznie na `(A==B)&(B==C)`
6. Nie obsługuje `A<=B<=C`, należy zamienić ręcznie na `(A<=B)&(B<=C)`
7. Obsługuje `A[0]+B[1]+C[2]`, zostanie przekształcone do `A+ts_delay(B,1)+ts_delay(C,2)`
8. Obsługuje `~A`, zostanie zamienione na `Not(A)`
9. Funkcje zaczynające się od `gp_` zwracają odpowiadającą funkcję `cs_`. Np. `gp_func(A,B,C)` zostanie zamienione na `cs_func(B,C)`, gdzie `A` używane jest w `groupby([date, A])`
10. Obsługuje rozpakowywanie krotek `A,B,C=MACD()`, na dole zamieniane na
   ```python
   _x_0 = MACD()
   A = unpack(_x_0, 0)
   B = unpack(_x_0, 1)
   C = unpack(_x_0, 2)
   ```
11. Komentarze w jednej linii obsługują parametry wejściowe, np.: `# --over_null`, `# --over_null=order_by`, `# --over_null=partition_by`
12. W bloku kodu składnie `import`, `def`, `class` są automatycznie wstawiane w oryginalnej formie do generowanego kodu

## Zmienne zaczynające się od podkreślenia

1. Wszystkie kolumny zaczynające się od `_` w danych wyjściowych zostaną automatycznie usunięte. Dlatego nie nazywaj tak zmiennych, które chcesz zachować.
2. Aby zmniejszyć liczbę powtórnych obliczeń, automatycznie dodawane są zmienne pośrednie zaczynające się od `_x_`, np. `_x_0`, `_x_1` itd. Zostaną one automatycznie usunięte na końcu.
3. Jeśli wyrażenie w jednej linii jest zbyt długie lub zawiera powtórzone obliczenia, możesz użyć zmiennych pośrednich, aby podzielić je na kilka linii. Jeśli zmienne pośrednie zaczynają się od `_`, zostanie automatycznie dodany sufiks liczbowy, tworząc różne zmienne, np. `_A` zostanie zamienione na `_A_0_`, `_A_1_` itd. Scenariusze użycia:
    1. Ta sama nazwa zmiennej, używana wielokrotnie. W rzeczywistości to różne zmienne
    2. Przypisania cykliczne, ale `DAG` nie obsługuje cykli. Zmienna po obu stronach `=` to w istocie różne zmienne

## Przykład wynikowego kodu po tłumaczeniu

Fragment wygenerowanego kodu, szczegółowy kod znajdziesz w [Polars](examples/output_polars.py)

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

Fragment wygenerowanego kodu, szczegółowy kod znajdziesz w [Pandas](examples/output_pandas.py)

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

## Interaktywny serwis www do wdrożenia lokalnego

Wystarczy uruchomić `streamlit run streamlit_app.py`

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---