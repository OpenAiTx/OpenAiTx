# expr_codegen Traduttore di Espressioni

## Contesto del Progetto

Dopo aver rilasciato il mio nuovo pacchetto [polars_ta](https://github.com/wukan1986/polars_ta), sono tornato a riflettere su cosa sia effettivamente `expr_codegen`.

> `expr_codegen` è essenzialmente un `DSL`, linguaggio specifico di dominio (Domain Specific Language). Tuttavia, non definisce una nuova sintassi.

Risolve due problemi:

1. `polars_ta` permette già di scrivere facilmente espressioni di calcolo di feature, ma quando si incontrano espressioni che mescolano `temporale e cross-sectionale`, con `expr_codegen` si può raggruppare automaticamente risparmiando molto lavoro.
2. `expr_codegen` sfrutta la `Common Subexpression Elimination` per eliminare sottosespressioni comuni, riducendo notevolmente i calcoli ripetuti e migliorando l'efficienza.

Anche nel campo della quantistica, i ricercatori junior limitati agli indicatori temporali possono usare solo `polars_ta`; per quelli di livello medio-alto che usano indicatori cross-sectionali, si raccomanda di usare `expr_codegen`.

Anche se attualmente questo progetto dipende molto da `polars_ta`, è possibile tradurlo per altri pacchetti, come `pandas / cudf.pandas`, manca solo una libreria semplice al momento.

## Demo Online

https://exprcodegen.streamlit.app

Gli utenti principianti possono accedere direttamente a questo link per tradurre espressioni senza installare software aggiuntivo. (Questo strumento è ospitato gratuitamente all'estero, potrebbe essere un po' lento all'apertura)

Per esempi più completi visita [alpha_examples](https://github.com/wukan1986/alpha_examples)

## Esempio d'Uso

```python
import sys
from io import StringIO

import polars as pl

from expr_codegen import codegen_exec


def _code_block_1():
    # Area di editing dei fattori; puoi modificarli qui con l'aiuto dell'IDE
    LOG_MC_ZS = cs_mad_zscore(log1p(market_cap))


def _code_block_2():
    # Nel template sono già importati molti operatori da polars_ta.prefix, ma
    # talib non è importato di default. In questo modo puoi importarlo nel codice generato
    from polars_ta.prefix.talib import ts_LINEARREG_SLOPE  # noqa

    # Supporta anche import, def e class come importazione diretta nel codice generato
    def cs_rank_if(condition, factor):
        return cs_rank(if_else(condition, factor, None))

    class Clazz:
        pass

    # 1. Variabili che iniziano con underscore sono variabili intermedie, saranno rinominate automaticamente ed escluse dall'output finale
    # 2. Variabili che iniziano con underscore possono essere riutilizzate. In caso di variabili intermedie ripetute in più righe non ci saranno conflitti
    _avg = ts_mean(corr, 20)
    _std = ts_std_dev(corr, 20)
    _beta = ts_LINEARREG_SLOPE(corr, 20)

    # 3. Le variabili che iniziano con underscore possono essere riassegnate in loop. Durante il debug puoi cambiare rapidamente con commenti
    _avg = cs_mad_zscore_resid(_avg, LOG_MC_ZS, ONE)
    _std = cs_mad_zscore_resid(_std, LOG_MC_ZS, ONE)
    # _beta = cs_mad_zscore_resid(_beta, LOG_MC_ZS, ONE)

    _corr = cs_zscore(_avg) + cs_zscore(_std)
    CPV = cs_zscore(_corr) + cs_zscore(_beta)


code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=sys.stdout)  # Stampa il codice
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file="output.py")  # Salva su file
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by')  # Solo esegue, non salva il codice

code = StringIO()
codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=code)  # Salva su stringa
code.seek(0)
code.read()  # Legge il codice

# TODO Sostituisci con dati appropriati
df = pl.DataFrame()
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect()  # Lazy CPU
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect(engine="gpu")  # Lazy GPU

```

## Struttura delle Cartelle

```commandline
│  requirements.txt # Installa le dipendenze con `pip install -r requirements.txt`
├─data
│      prepare_date.py # Prepara i dati
├─examples
│      demo_express.py # Esempio rapido. Mostra come convertire espressioni in codice
│      demo_exec_pl.py # Mostra come chiamare il codice convertito e fare plot
│      demo_transformer.py # Mostra come convertire espressioni di terze parti in espressioni interne
│      output.py # Output dei risultati. Può essere importato direttamente da altri progetti senza modifiche
│      show_tree.py # Disegna l'albero delle espressioni. Utile per analisi e confronto ottimizzazioni
│      sympy_define.py # Definizioni simboliche, unificate qui perché usate ripetutamente in molti punti
├─expr_codegen
│   │  expr.py # Funzioni di base per la gestione delle espressioni
│   │  tool.py # Codice degli strumenti principali
│   ├─polars
│   │  │  code.py # Generazione codice per sintassi polars
│   │  │  template.py.j2 # Template `Jinja2` per generare i file py corrispondenti, generalmente non serve modificarlo
│   │  │  printer.py # Estende `StrPrinter` di `Sympy`; potrebbe essere necessario modificare questo file aggiungendo nuove funzioni
```

## Principio di Funzionamento

Questo progetto si basa su `sympy`. Le funzioni principali utilizzate sono:

1. `simplify`: semplifica espressioni complesse
2. `cse`: `Common Subexpression Elimination`, elimina sottosespressioni comuni
3. `StrPrinter`: emette stringhe diverse a seconda delle funzioni. Personalizzando questo codice si può supportare altre lingue o librerie

Poiché `groupby` e `sort` sono operazioni costose, se si classificano le formule in anticipo e si usano diversi `groupby` per categorie diverse, si può risparmiare tempo di calcolo.

1. `ts_xxx(ts_xxx)`: calcolabili nello stesso `groupby`
2. `cs_xxx(cs_xxx)`: calcolabili nello stesso `groupby`
3. `ts_xxx(cs_xxx)`: devono essere calcolati in diversi `groupby`
4. `cs_xxx(ts_xxx(cs_xxx))`: devono essere calcolati in tre diversi `groupby`
5. `gp_xxx(aa, )+gp_xxx(bb, )`: poiché `aa` e `bb` sono diversi, servono due diversi `groupby`

Quindi:

1. Serve una funzione per ottenere la categoria dell'espressione corrente (`get_current`) e delle sotto-espressioni (`get_children`)
2. Se la categoria attuale è diversa da quella dei figli, si può estrarre una formula breve (`extract`). Espressioni con stessa categoria ma su livelli diversi non possono essere nello stesso `groupby`
3. Usando le proprietà di `cse`, si sostituiscono le espressioni lunghe con quelle corte estratte in precedenza, poi si inseriscono in un grafo aciclico diretto (`DAG`)
4. Con il flusso del grafo aciclico diretto, si fanno i livelli. Allo stesso livello, `ts`, `cs`, `gp` non hanno priorità
5. Si raggruppano per `ts`, `cs`, `gp` allo stesso livello, poi si genera il codice (`codegen`)

Informazioni implicite:

1. `ts`: sort(by=[ASSET, DATE]).groupby(by=[ASSET], maintain_order=True)
2. `cs`: sort(by=[DATE]).groupby(by=[DATE], maintain_order=False)
3. `gp`: sort(by=[DATE, GROUP]).groupby(by=[DATE, GROUP], maintain_order=False)

Cioè:

1. Le funzioni temporali nascondono due colonne `ASSET, DATE`, le funzioni cross-sectionali ne nascondono una `DATE`
2. La funzione di gruppo aggiunge una colonna `GROUP`, e nasconde una colonna `DATE`

Due metodi di classificazione:

1. Classificazione per prefisso dell'operatore (`get_current_by_prefix`), richiede che gli operatori inizino con `ts_`, `cs_`, `gp_`
2. Classificazione per nome completo dell'operatore (`get_current_by_name`), non limita il nome dell'operatore. Ad esempio, `cs_rank` può chiamarsi anche `rank`

## Gestione dei Null

Come si generano i `null`?

1. Sospensione delle contrattazioni. Filtrati in anticipo, non influenzano i calcoli successivi.
2. Orari di negoziazione diversi per prodotti diversi
3. Generazione nei calcoli. I `null` alle estremità di una serie non influenzano i risultati delle funzioni temporali, ma se appaiono in mezzo possono avere effetti. Ad esempio: `if_else(close<2, None, close)`

https://github.com/pola-rs/polars/issues/12925#issuecomment-2552764629

Ottima idea, in sintesi ci sono due modi per implementarlo:

1. Mettere i `null` in un gruppo, i `not_null` in un altro. Serve chiamare due volte.
2. Un solo gruppo, ma ordinamento composito: `null` davanti, `not_null` dietro. Si chiama una sola volta, leggermente più veloce.

```python
X1 = (ts_returns(CLOSE, 3)).over(CLOSE.is_not_null(), _ASSET_, order_by=_DATE_),
X2 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=[CLOSE.is_not_null(), _DATE_]),
X3 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=_DATE_),
```

Nel secondo caso, la zona iniziale di `null` può influenzare il risultato a seconda dell'operatore, soprattutto se ci sono più colonne in input e la zona `null` può avere dati.

1. `over_null='partition_by'`: divide in due aree
2. `over_null='order_by'`: una sola area, i `null` davanti
3. `over_null=None`: non gestisce, chiama direttamente, più veloce. Se sei sicuro che non verranno generati `null` a metà serie si consiglia questo parametro

`codegen_exec(over_null='partition_by')` usa globalmente `partition_by`. Ma per funzioni come `ts_count_nulls` che lavorano con i `null`, occorre usare `over_null=None`, quindi questo strumento ha anche aggiunto la possibilità di specificare parametri per singola riga tramite commenti.

1. `# --over_null partition_by`: singola riga `over_null='partition_by'`
2. `# --over_null=order_by`: singola riga `over_null='order_by'`
3. `# --over_null`: singola riga `over_null=None`
4. `#`: prende il valore di `over_null` passato come parametro a `codegen_exec`

Nota:

1. Il commento `# --over_null` può essere scritto solo in coda alla singola riga di espressione, non su una riga a parte, altrimenti sarà ignorato
2. Se ci sono più `# --over_null # --over_null=order_by` sulla stessa riga, si prende solo il primo valido
3. Valido solo per la funzione `ts` più esterna. Se la funzione `ts` non è esterna, bisogna estrarla manualmente. Ad esempio:
   ```python
   X1 = cs_rank(ts_mean(CLOSE, 3)) # --over_null=order_by # Applica a cs_rank, non ha senso
   X2 = ts_rank(ts_mean(CLOSE, 3), 5) # --over_null=order_by # Si pensa di applicarlo a ts_rank(ts_mean), ma con la cse diventa su ts_rank(_x_0)
   ```

   Bisogna scrivere così:

   ```python
   _x_0 = ts_mean(CLOSE, 3)  # --over_null=order_by 
   X1 = cs_rank(_x_0)
   X2 = ts_rank(_x_0, 5)
   ```
4. Poiché è facile sbagliare, si consiglia vivamente di generare `output_file` e controllare se il codice generato è corretto.

## Limiti di `expr_codegen`

1. Il `DAG` può solo aggiungere colonne, non eliminarle. Se aggiungi una colonna con lo stesso nome, viene sovrascritta.
2. Non supporta la `cancellazione di righe`, ma puoi aggiungere una colonna di flag ed eliminarle esternamente. La cancellazione di righe influisce su tutte le colonne, non soddisfa il `DAG`.
3. Non supporta il `resampling`, per lo stesso motivo della cancellazione di righe. Va gestito esternamente.
4. Puoi usare la cancellazione di righe e il resampling come linea di demarcazione e concatenare più `DAG` in blocchi. È complesso e poco comprensibile, perciò non è stato implementato.

## Sintassi Speciale

1. Supporta l'espressione ternaria `C?T:F` (solo nelle stringhe), che viene trasformata in `C or True if( T )else F`, poi in `T if C else F`, infine in `if_else(C,T,F)`. Supporta miscelazione con `if else`.
2. `(A<B)*-1` viene trasformato in `int_(A<B)*-1`
3. Per evitare che `A==B` venga sostituito da `False` in `sympy`, viene cambiato in `Eq(A,B)`
4. Il significato di `A^B` dipende dal parametro `convert_xor`, se `convert_xor=True` si trasforma in `Pow(A,B)`, altrimenti in `Xor(A,B)`. Di default è `False`, per la potenza si usa `**`
5. Supporta `A&B&C`, ma non `A==B==C`. Se C è booleano e AB sono numerici, sostituire manualmente con `(A==B)==C`. Se ABC sono numerici, sostituire manualmente con `(A==B)&(B==C)`
6. Non supporta `A<=B<=C`, sostituire manualmente con `(A<=B)&(B<=C)`
7. Supporta `A[0]+B[1]+C[2]`, trasformato in `A+ts_delay(B,1)+ts_delay(C,2)`
8. Supporta `~A`, trasformato in `Not(A)`
9. Le funzioni che iniziano con `gp_` restituiscono la funzione `cs_` corrispondente. Ad esempio, `gp_func(A,B,C)` viene sostituito con `cs_func(B,C)`, dove `A` è usato in `groupby([date, A])`
10. Supporta l'unpacking di tuple `A,B,C=MACD()`, che viene trasformato in
   ```python
   _x_0 = MACD()
   A = unpack(_x_0, 0)
   B = unpack(_x_0, 1)
   C = unpack(_x_0, 2)
   ```
11. I commenti su singola riga supportano l'input di parametri, come: `# --over_null`, `# --over_null=order_by`, `# --over_null=partition_by`
12. Nei blocchi di codice, le istruzioni `import`, `def`, `class` sono inserite direttamente nel codice generato

## Variabili con Underscore Iniziale

1. Nei dati in output, tutte le colonne che iniziano con `_` vengono automaticamente eliminate. Quindi le variabili che si vogliono mantenere non devono iniziare con `_`
2. Per ridurre i calcoli ripetuti, vengono aggiunte automaticamente variabili intermedie che iniziano con `_x_`, come `_x_0`, `_x_1`, ecc., che saranno eliminate alla fine
3. Se un'espressione su una riga è troppo lunga, o ci sono calcoli ripetuti, puoi usare variabili intermedie. Se la variabile intermedia inizia con `_`, verrà rinominata con un suffisso numerico, come `_A` diventa `_A_0_`, `_A_1_` ecc. Gli scenari sono:
    1. Stesso nome variabile usato più volte, ma in realtà sono variabili diverse
    2. Assegnazione ciclica, ma il `DAG` non supporta cicli. La variabile a sinistra e a destra del `=` sono in realtà diverse

## Esempio di Risultato della Traduzione

Esempio di codice tradotto, il codice completo si trova nella versione [Polars](examples/output_polars.py)

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

Esempio di codice tradotto, il codice completo si trova nella versione [Pandas](examples/output_pandas.py)

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

## Pagina Web Interattiva Locale

È sufficiente eseguire `streamlit run streamlit_app.py`

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---