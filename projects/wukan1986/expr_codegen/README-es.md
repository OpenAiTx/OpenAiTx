# expr_codegen Traductor de Expresiones

## Antecedentes del proyecto

Después de lanzar mi nueva biblioteca [polars_ta](https://github.com/wukan1986/polars_ta), reflexioné sobre qué es realmente `expr_codegen`.

> En esencia, `expr_codegen` es un `DSL`, un Lenguaje Específico de Dominio (Domain Specific Language). Pero no define una nueva sintaxis.

Resuelve dos problemas:

1. `polars_ta` ya permite escribir fácilmente expresiones para el cálculo de características, pero al encontrar expresiones que mezclan series temporales y transversales, el uso de `expr_codegen` permite agrupar automáticamente, ahorrando mucho trabajo.
2. `expr_codegen` utiliza la Eliminación de Subexpresiones Comunes (`Common Subexpression Elimination`), lo que reduce considerablemente los cálculos repetidos y mejora la eficiencia.

Incluso en el campo cuantitativo, los investigadores principiantes limitados a indicadores temporales pueden usar solo `polars_ta`, mientras que los investigadores intermedios y avanzados que usan indicadores transversales deberían usar `expr_codegen`.

Aunque actualmente este proyecto depende estrechamente de `polars_ta`, también es compatible para traducirse a otras bibliotecas como `pandas / cudf.pandas`, solo que por ahora falta una biblioteca sencilla para ello.

## Demostración en línea

https://exprcodegen.streamlit.app

Los usuarios principiantes pueden acceder directamente a este enlace para traducir expresiones sin necesidad de instalar software adicional. (Esta herramienta está alojada gratuitamente en el extranjero, por lo que puede abrirse algo lento)

Para ejemplos más completos visita [alpha_examples](https://github.com/wukan1986/alpha_examples)

## Ejemplo de uso

```python
import sys
from io import StringIO

import polars as pl

from expr_codegen import codegen_exec


def _code_block_1():
    # Zona de edición de factores, puedes editar factores aquí con la ayuda de la sugerencia inteligente del IDE
    LOG_MC_ZS = cs_mad_zscore(log1p(market_cap))


def _code_block_2():
    # El template ya importa por defecto numerosos operadores desde polars_ta.prefix, pero
    # talib no se importa por defecto. Esta forma permite importar en el código generado
    from polars_ta.prefix.talib import ts_LINEARREG_SLOPE  # noqa

    # También soporta importación literal de def y class
    def cs_rank_if(condition, factor):
        return cs_rank(if_else(condition, factor, None))

    class Clazz:
        pass

    # 1. Las variables que comienzan con guion bajo son variables intermedias, se renombran automáticamente y se eliminan en la salida final
    # 2. Las variables que comienzan con guion bajo se pueden reutilizar. Al escribir múltiples factores complejos en varias líneas, no hay conflictos si se repiten
    _avg = ts_mean(corr, 20)
    _std = ts_std_dev(corr, 20)
    _beta = ts_LINEARREG_SLOPE(corr, 20)

    # 3. Las variables que comienzan con guion bajo pueden reasignarse en bucles. Durante la depuración se puede cambiar rápidamente usando comentarios
    _avg = cs_mad_zscore_resid(_avg, LOG_MC_ZS, ONE)
    _std = cs_mad_zscore_resid(_std, LOG_MC_ZS, ONE)
    # _beta = cs_mad_zscore_resid(_beta, LOG_MC_ZS, ONE)

    _corr = cs_zscore(_avg) + cs_zscore(_std)
    CPV = cs_zscore(_corr) + cs_zscore(_beta)


code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=sys.stdout)  # Imprime el código
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file="output.py")  # Guarda en archivo
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by')  # Solo ejecuta, no guarda código

code = StringIO()
codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=code)  # Guarda como string
code.seek(0)
code.read()  # Lee el código

# TODO Reemplazar con los datos adecuados
df = pl.DataFrame()
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect()  # Lazy CPU
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect(engine="gpu")  # Lazy GPU

```

## Estructura del directorio

```commandline
│  requirements.txt # Instala dependencias con `pip install -r requirements.txt`
├─data
│      prepare_date.py # Preparar datos
├─examples
│      demo_express.py # Ejemplo rápido. Muestra cómo convertir expresiones en código
│      demo_exec_pl.py # Muestra cómo llamar al código convertido y graficar
│      demo_transformer.py # Muestra cómo convertir expresiones de terceros a expresiones internas
│      output.py # Salida de resultados. Puede ser importado directamente por otros proyectos sin modificar
│      show_tree.py # Dibuja el árbol de expresiones. Útil para analizar y comparar resultados de optimización
│      sympy_define.py # Definiciones simbólicas, extraídas aquí por su uso repetido en muchas partes
├─expr_codegen
│   │  expr.py # Funciones básicas de manejo de expresiones
│   │  tool.py # Código de herramientas núcleo
│   ├─polars
│   │  │  code.py # Función de generación de código para sintaxis polars
│   │  │  template.py.j2 # Plantilla `Jinja2`. Para generar el archivo py correspondiente, generalmente no es necesario modificarla
│   │  │  printer.py # Hereda de `StrPrinter` de `Sympy`, puede necesitar cambios al agregar nuevas funciones
```

## Principio de funcionamiento

Este proyecto depende del proyecto `sympy`. Las funciones principales utilizadas son:

1. `simplify`: simplifica expresiones complejas
2. `cse`: Eliminación de Subexpresiones Comunes (`Common Subexpression Elimination`)
3. `StrPrinter`: imprime diferentes cadenas según la función. Personalizando este código se pueden soportar otros lenguajes o bibliotecas

Dado que `groupby` y `sort` consumen mucho tiempo, si se clasifican las fórmulas por adelantado y diferentes categorías usan diferentes `groupby`, se puede reducir el tiempo de cómputo.

1. `ts_xxx(ts_xxx)`: Puede calcularse en el mismo `groupby`
2. `cs_xxx(cs_xxx)`: Puede calcularse en el mismo `groupby`
3. `ts_xxx(cs_xxx)`: Debe calcularse en diferentes `groupby`
4. `cs_xxx(ts_xxx(cs_xxx))`: Debe calcularse en tres `groupby` diferentes
5. `gp_xxx(aa, )+gp_xxx(bb, )`: Debido a que `aa` y `bb` son diferentes, deben calcularse en dos `groupby` diferentes

Por lo tanto:

1. Se necesita una función para obtener la categoría de la expresión actual (`get_current`) y la categoría de las subexpresiones (`get_children`)
2. Si la categoría actual y la de los hijos son diferentes, se puede extraer una fórmula corta (`extract`). Expresiones del mismo tipo en diferentes niveles tienen relación de precedencia y no pueden colocarse en el mismo `groupby`
3. Aprovechando la característica de `cse`, las expresiones largas se reemplazan por las fórmulas cortas extraídas previamente. Luego se ingresan en un grafo acíclico dirigido (`DAG`)
4. Utilizando el flujo del grafo acíclico dirigido, se realiza la estratificación. En la misma capa, `ts`, `cs`, `gp` no se distinguen por orden
5. En la misma capa se agrupan `ts`, `cs`, `gp`, y luego se genera el código (`codegen`)

Información implícita:

1. `ts`: sort(by=[ASSET, DATE]).groupby(by=[ASSET], maintain_order=True)
2. `cs`: sort(by=[DATE]).groupby(by=[DATE], maintain_order=False)
3. `gp`: sort(by=[DATE, GROUP]).groupby(by=[DATE, GROUP], maintain_order=False)

Es decir:

1. Las funciones temporales ocultan dos campos: `ASSET`, `DATE`; las funciones transversales ocultan uno: `DATE`
2. Las funciones de agrupación agregan el campo `GROUP` y ocultan el campo `DATE`

Dos métodos de clasificación:

1. Clasificación por prefijo del operador (`get_current_by_prefix`), donde el operador debe comenzar con `ts_`, `cs_`, `gp_`
2. Clasificación por nombre completo del operador (`get_current_by_name`), sin restringir el nombre. Por ejemplo, `cs_rank` puede llamarse simplemente `rank`

## Manejo de Null

¿Cómo se produce `null`?

1. Por suspensión de la cotización. Antes del cálculo se filtran directamente, no afectan los cálculos posteriores.
2. Diferentes variedades tienen diferentes horarios de negociación
3. Por el cálculo. `null` en los extremos de la serie no afecta los resultados de los operadores temporales, pero si aparece en medio sí afecta. Por ejemplo: `if_else(close<2, None, close)`

https://github.com/pola-rs/polars/issues/12925#issuecomment-2552764629

Excelente idea, en resumen hay dos formas de implementarlo:

1. Dividir `null` en un grupo y `not_null` en otro. Requiere dos llamadas.
2. Solo un grupo, pero con orden compuesto, colocando `null` al principio y `not_null` al final. Solo una llamada, un poco más rápido.

```python
X1 = (ts_returns(CLOSE, 3)).over(CLOSE.is_not_null(), _ASSET_, order_by=_DATE_),
X2 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=[CLOSE.is_not_null(), _DATE_]),
X3 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=_DATE_),
```

En el caso 2, si la región de `null` al principio afecta el resultado depende del operador, especialmente cuando hay múltiples columnas de entrada, la región de `null` puede contener datos

1. `over_null='partition_by'`: divide en dos regiones
2. `over_null='order_by'`: una sola región, `null` al principio
3. `over_null=None`: no se maneja, se llama directamente, más rápido. Se recomienda si se sabe que no habrá `null` intermedios

`codegen_exec(over_null='partition_by')` utiliza globalmente `partition_by`. Pero para funciones como `ts_count_nulls` que operan sobre `null`, se debe usar `over_null=None`. Por eso, la herramienta permite especificar parámetros por línea con comentarios:

1. `# --over_null partition_by`: por línea, `over_null='partition_by'`
2. `# --over_null=order_by`: por línea, `over_null='order_by'`
3. `# --over_null`: por línea, `over_null=None`
4. `#`: toma el valor de `over_null` pasado a `codegen_exec`

Notas:

1. Los comentarios de parámetro `# --over_null` solo pueden ir al final de la línea de expresión, no en línea separada, de lo contrario serán ignorados
2. Si hay varios `# --over_null # --over_null=order_by`, solo se toma el primero válido
3. Solo es efectivo para la función `ts` del nivel más externo. Si la función `ts` no está en el exterior, debe extraerse manualmente. Por ejemplo:
   ```python
   X1 = cs_rank(ts_mean(CLOSE, 3)) # --over_null=order_by # Se aplica a cs_rank, sin sentido
   X2 = ts_rank(ts_mean(CLOSE, 3), 5) # --over_null=order_by # Se piensa que se aplica a ts_rank(ts_mean), pero por la existencia de ts_mean común, en realidad es para ts_rank(_x_0)
   ```

   Debe escribirse como

   ```python
   _x_0 = ts_mean(CLOSE, 3)  # --over_null=order_by 
   X1 = cs_rank(_x_0)
   X2 = ts_rank(_x_0, 5)
   ```
4. Debido a la facilidad de error, se recomienda encarecidamente generar el `output_file` para verificar si el código generado es correcto.

## Limitaciones de `expr_codegen`

1. `DAG` solo puede agregar columnas, no eliminarlas. Si se agrega una columna con el mismo nombre, se sobrescribe.
2. No soporta `eliminar filas`, pero se puede agregar una columna de marcas de eliminación y luego eliminar filas externamente. Eliminar filas afecta a todas las columnas, lo que no cumple con el principio de `DAG`
3. No soporta `reesampleo`, por la misma razón que no soporta eliminar filas. Debe hacerse externamente
4. Eliminar filas y reesampleo pueden usarse como divisores para dividir grandes bloques de código en varios `DAG` encadenados. Es complejo y difícil de entender, por lo que finalmente no se implementó

## Sintaxis especial

1. Soporta la expresión ternaria `C?T:F` (solo en cadenas), que internamente se convierte primero en `C or True if( T )else F`, después en `T if C else F`, y finalmente en `if_else(C,T,F)`. Soporta mezcla con `if else`
2. `(A<B)*-1` se transforma internamente en `int_(A<B)*-1`
3. Para evitar que `A==B` sea reemplazado por `False` por `sympy`, se convierte en `Eq(A,B)`
4. El significado de `A^B` depende del parámetro `convert_xor`: si `convert_xor=True`, se convierte en `Pow(A,B)`, de lo contrario en `Xor(A,B)`. Por defecto es `False`, se usa `**` para potencia
5. Soporta `A&B&C`, pero no `A==B==C`. Si C es booleano y AB son valores, puede reemplazarse manualmente por `(A==B)==C`. Si ABC son valores, puede reemplazarse por `(A==B)&(B==C)`
6. No soporta `A<=B<=C`, debe reemplazarse manualmente por `(A<=B)&(B<=C)`
7. Soporta `A[0]+B[1]+C[2]`, que se traduce en `A+ts_delay(B,1)+ts_delay(C,2)`
8. Soporta `~A`, que se traduce en `Not(A)`
9. Las funciones que empiezan con `gp_` devuelven la función `cs_` correspondiente. Por ejemplo, `gp_func(A,B,C)` se reemplaza por `cs_func(B,C)`, donde `A` se usa en `groupby([date, A])`
10. Soporta desempaquetado de tuplas `A,B,C=MACD()`, que internamente se reemplaza por:
    ```python
    _x_0 = MACD()
    A = unpack(_x_0, 0)
    B = unpack(_x_0, 1)
    C = unpack(_x_0, 2)
    ```
11. Los comentarios en línea soportan entrada de parámetros, como: `# --over_null`, `# --over_null=order_by`, `# --over_null=partition_by`
12. En los bloques de código, las sentencias `import`, `def` y `class` se insertan automáticamente tal cual en el código generado

## Variables con guion bajo inicial

1. En los datos de salida, todas las columnas que comienzan con `_` se eliminan automáticamente. Así que las variables que se quieran conservar no deben comenzar con `_`
2. Para reducir cálculos repetidos, se agregan automáticamente variables intermedias que comienzan con `_x_`, como `_x_0`, `_x_1`, etc. Al final se eliminan automáticamente
3. Si una expresión de una sola línea es muy larga o hay cálculos repetidos, se puede dividir en varias líneas usando variables intermedias que comienzan con `_`. Estas recibirán automáticamente un sufijo numérico, formando variables diferentes como `_A_0_`, `_A_1_`, etc. Usos:
    1. El mismo nombre de variable se usa varias veces, pero en realidad son variables diferentes
    2. Asignación en bucles, pero `DAG` no soporta ciclos. Las variables con el mismo nombre a ambos lados del `=` son realmente diferentes

## Ejemplo de resultado de traducción

Fragmento de código traducido, para ver el código completo consulta la [versión Polars](examples/output_polars.py)

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

Fragmento de código traducido, para ver el código completo consulta la [versión Pandas](examples/output_pandas.py)

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

## Página web interactiva de despliegue local

Solo necesitas ejecutar `streamlit run streamlit_app.py`


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---