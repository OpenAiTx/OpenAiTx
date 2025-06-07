# expr_codegen Tradutor de Expressões

## Contexto do Projeto

Após lançar o novo pacote [polars_ta](https://github.com/wukan1986/polars_ta), olhei para trás para refletir sobre o que é o `expr_codegen`.

> `expr_codegen` é essencialmente uma `DSL` (Domain Specific Language - Linguagem Específica de Domínio). Mas não define uma nova sintaxe.

Ele resolve dois problemas:

1. `polars_ta` já permite escrever expressões de cálculo de features de forma conveniente, mas ao lidar com expressões que `misturam séries temporais e seções transversais`, o uso de `expr_codegen` pode agrupar automaticamente e poupar muito trabalho.
2. `expr_codegen` utiliza a `Common Subexpression Elimination` (Eliminação de Subexpressões Comuns), reduzindo significativamente cálculos repetidos e aumentando a eficiência.

Mesmo na área de quant, pesquisadores iniciantes limitados a indicadores temporais podem usar apenas o `polars_ta`. Para pesquisadores intermediários e avançados que utilizam indicadores transversais, recomenda-se o uso do `expr_codegen`.

Embora atualmente este projeto dependa muito do `polars_ta`, também suporta tradução para outras bibliotecas, como `pandas / cudf.pandas`, faltando apenas uma biblioteca mais simples neste momento.

## Demonstração Online

https://exprcodegen.streamlit.app

Usuários iniciantes podem acessar este link diretamente para tradução de expressões, sem necessidade de instalar software adicional. (Esta ferramenta está hospedada gratuitamente no exterior, pode demorar um pouco para abrir.)

Para exemplos mais completos, acesse [alpha_examples](https://github.com/wukan1986/alpha_examples)

## Exemplo de Uso

```python
import sys
from io import StringIO

import polars as pl

from expr_codegen import codegen_exec


def _code_block_1():
    # Área de edição de fator, pode-se utilizar sugestões inteligentes do IDE para editar fatores aqui
    LOG_MC_ZS = cs_mad_zscore(log1p(market_cap))


def _code_block_2():
    # O template já importa por padrão vários operadores de from polars_ta.prefix, mas
    # talib não é importado por padrão. Esta abordagem permite importar no código gerado
    from polars_ta.prefix.talib import ts_LINEARREG_SLOPE  # noqa

    # Também suporta importação literal de def e class
    def cs_rank_if(condition, factor):
        return cs_rank(if_else(condition, factor, None))

    class Clazz:
        pass

    # 1. Variáveis iniciadas com sublinhado são intermediárias, serão renomeadas automaticamente e removidas na saída final
    # 2. Variáveis iniciadas com sublinhado podem ser reutilizadas. Não há conflito ao usar variáveis intermediárias em múltiplas linhas de fatores complexos
    _avg = ts_mean(corr, 20)
    _std = ts_std_dev(corr, 20)
    _beta = ts_LINEARREG_SLOPE(corr, 20)

    # 3. Variáveis iniciadas com sublinhado têm atribuição em ciclo. No debug, podem ser rapidamente alternadas via comentário
    _avg = cs_mad_zscore_resid(_avg, LOG_MC_ZS, ONE)
    _std = cs_mad_zscore_resid(_std, LOG_MC_ZS, ONE)
    # _beta = cs_mad_zscore_resid(_beta, LOG_MC_ZS, ONE)

    _corr = cs_zscore(_avg) + cs_zscore(_std)
    CPV = cs_zscore(_corr) + cs_zscore(_beta)


code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=sys.stdout)  # Imprime o código
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file="output.py")  # Salva em arquivo
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by')  # Apenas executa, não salva o código

code = StringIO()
codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=code)  # Salva em string
code.seek(0)
code.read()  # Lê o código

# TODO Substitua pelos dados adequados
df = pl.DataFrame()
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect()  # Lazy CPU
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect(engine="gpu")  # Lazy GPU

```

## Estrutura de Diretórios

```commandline
│  requirements.txt # Instale as dependências via `pip install -r requirements.txt`
├─data
│      prepare_date.py # Preparar dados
├─examples
│      demo_express.py # Exemplo rápido. Demonstra como converter expressões em código
│      demo_exec_pl.py # Demonstra chamada de código convertido e plotagem
│      demo_transformer.py # Demonstra como converter expressões de terceiros em expressões internas
│      output.py # Saída de resultados. Pode ser importado diretamente por outros projetos sem modificar o código
│      show_tree.py # Desenha árvore de expressões. Pode ser usado para analisar e comparar resultados otimizados
│      sympy_define.py # Definições simbólicas, extraídas para uso repetido em vários lugares
├─expr_codegen
│   │  expr.py # Funções básicas de processamento de expressões
│   │  tool.py # Código principal de ferramentas
│   ├─polars
│   │  │  code.py # Geração de código para sintaxe polars
│   │  │  template.py.j2 # Template `Jinja2`. Usado para gerar o arquivo py correspondente, geralmente não precisa ser modificado
│   │  │  printer.py # Herdado de `StrPrinter` do `Sympy`, pode precisar ser modificado ao adicionar novas funções
```

## Princípio de Funcionamento

Este projeto depende do projeto `sympy`. As principais funções utilizadas são:

1. `simplify`: Simplificação de expressões complexas
2. `cse`: `Common Subexpression Elimination` (Eliminação de Subexpressões Comuns)
3. `StrPrinter`: Gera diferentes strings de saída para diferentes funções. Personalizando este código é possível suportar outros idiomas ou bibliotecas

Como `groupby` e `sort` consomem tempo, se as fórmulas forem classificadas previamente e diferentes categorias usarem diferentes `groupby`, pode-se reduzir o tempo de cálculo.

1. `ts_xxx(ts_xxx)`: Pode ser calculado no mesmo `groupby`
2. `cs_xxx(cs_xxx)`: Pode ser calculado no mesmo `groupby`
3. `ts_xxx(cs_xxx)`: Precisa ser calculado em diferentes `groupby`
4. `cs_xxx(ts_xxx(cs_xxx))`: Precisa ser calculado em três `groupby` diferentes
5. `gp_xxx(aa, )+gp_xxx(bb, )`: Como `aa` e `bb` são diferentes, precisa ser calculado em dois `groupby` diferentes

Portanto,

1. É necessário ter uma função que obtenha a categoria da expressão atual (`get_current`) e das subexpressões (`get_children`)
2. Se a categoria atual for diferente da subcategoria, pode-se extrair fórmulas curtas (`extract`). Expressões do mesmo tipo em diferentes camadas têm relação de precedência e não podem ser colocadas no mesmo `groupby`
3. Aproveitando as características de `cse`, substitui expressões longas por subexpressões extraídas previamente e, em seguida, insere no grafo acíclico dirigido (`DAG`)
4. Usa o fluxo do grafo acíclico para estratificar. Na mesma camada, `ts`, `cs`, `gp` não distinguem ordem
5. Na mesma camada, agrupa `ts`, `cs`, `gp` e então gera o código (`codegen`)

Informações implícitas

1. `ts`: sort(by=[ASSET, DATE]).groupby(by=[ASSET], maintain_order=True)
2. `cs`: sort(by=[DATE]).groupby(by=[DATE], maintain_order=False)
3. `gp`: sort(by=[DATE, GROUP]).groupby(by=[DATE, GROUP], maintain_order=False)

Ou seja,

1. Funções temporais ocultam dois campos `ASSET, DATE`, funções transversais ocultam o campo `DATE`
2. Funções de grupo recebem um campo `GROUP` e ocultam o campo `DATE`

Dois métodos de classificação

1. Classificação por prefixo de operador (`get_current_by_prefix`), exige que o operador comece com `ts_`, `cs_`, `gp_`
2. Classificação pelo nome completo do operador (`get_current_by_name`), não exige prefixo. Por exemplo, `cs_rank` pode ser chamado apenas de `rank`

## Tratamento de Null

Como o `null` é gerado?

1. Suspensão de negociação. Filtrado antes do cálculo, não afeta cálculos subsequentes.
2. Diferentes instrumentos têm diferentes horários de negociação
3. Produzido pelo cálculo. `null` nas extremidades de séries não afeta operadores temporais subsequentes, mas se aparecer no meio, pode afetar. Exemplo: `if_else(close<2, None, close)`

https://github.com/pola-rs/polars/issues/12925#issuecomment-2552764629

Excelente ideia, resumindo existem duas formas de implementar:

1. Agrupar `null` em um grupo e `not_null` em outro. Requer duas chamadas
2. Apenas um grupo, mas usando ordenação composta, coloca `null` no início e `not_null` no fim. Apenas uma chamada, um pouco mais rápido

```python
X1 = (ts_returns(CLOSE, 3)).over(CLOSE.is_not_null(), _ASSET_, order_by=_DATE_),
X2 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=[CLOSE.is_not_null(), _DATE_]),
X3 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=_DATE_),
```

No segundo método, se a área de `null` no início afeta o resultado depende do operador, especialmente quando há várias colunas de entrada onde pode haver dados nas áreas `null`

1. `over_null='partition_by'`. Divide em duas áreas
2. `over_null='order_by'`. Divide em uma área, `null` vem primeiro
3. `over_null=None`. Não trata, chama diretamente, mais rápido. Se tiver certeza que não haverá `null` no meio, recomenda-se usar este parâmetro

`codegen_exec(over_null='partition_by')` usa globalmente `partition_by`. Mas ao encontrar funções como `ts_count_nulls`, deve-se usar `over_null=None`. Por isso, esta ferramenta adicionou suporte a comentários para especificar parâmetros de expressão por linha

1. `# --over_null partition_by`. Define `over_null='partition_by'` para a linha
2. `# --over_null=order_by`. Define `over_null='order_by'` para a linha
3. `# --over_null`. Define `over_null=None` para a linha
4. `# `. Usa o valor de `over_null` passado para `codegen_exec`

Atenção:

1. O comentário `# --over_null` só pode ser colocado no final de uma linha de expressão, não pode estar sozinho, senão será ignorado
2. `# --over_null # --over_null=order_by` se houver múltiplos `#`, apenas o primeiro válido é considerado
3. Só é válido para a função `ts` mais externa. Se a função `ts` não estiver na camada externa, é preciso extrair manualmente. Por exemplo:
   ```python
   X1 = cs_rank(ts_mean(CLOSE, 3)) # --over_null=order_by # Aplica-se ao cs_rank, sem efeito
   X2 = ts_rank(ts_mean(CLOSE, 3), 5) # --over_null=order_by # Esperava-se aplicar em ts_rank(ts_mean), mas como há um ts_mean comum, aplica-se em ts_rank(_x_0)
   ```

   Deve ser escrito como

   ```python
   _x_0 = ts_mean(CLOSE, 3)  # --over_null=order_by 
   X1 = cs_rank(_x_0)
   X2 = ts_rank(_x_0, 5)
   ```
4. Como é fácil cometer erros, recomenda-se fortemente gerar um `output_file` e verificar se o código gerado está correto.

## Limitações do `expr_codegen`

1. O `DAG` só pode adicionar colunas, não pode removê-las. Ao adicionar uma coluna com nome igual, ela será sobrescrita
2. Não suporta `remoção de linhas`, mas pode adicionar uma coluna de marcação para remoção e deletar linhas externamente. Remover linhas afeta todas as colunas, não satisfazendo o `DAG`
3. Não suporta `re-amostragem`, pelo mesmo motivo de não suportar remoção de linhas. Deve ser feito externamente
4. A remoção de linhas e re-amostragem podem ser usadas como divisores, separando grandes blocos de código em múltiplos `DAG` encadeados. Porém, por ser complexo e difícil de entender, não foi implementado no final

## Sintaxe Especial

1. Suporta expressão ternária `C?T:F` (apenas em string), que é convertida internamente para `C or True if( T )else F`, depois corrigida para `T if C else F` e, por fim, para `if_else(C,T,F)`. Suporta mistura com `if else`
2. `(A<B)*-1` será convertido internamente para `int_(A<B)*-1`
3. Para evitar que `A==B` seja substituído por `False` no `sympy`, será trocado por `Eq(A,B)`
4. O significado de `A^B` depende do parâmetro `convert_xor`. Se `convert_xor=True`, será convertido para `Pow(A,B)`, caso contrário para `Xor(A,B)`. Por padrão é `False`, use `**` para potência
5. Suporta `A&B&C`, mas não `A==B==C`. Se C for booleano e AB forem numéricos, pode-se substituir manualmente por `(A==B)==C`. Se ABC forem numéricos, substitua por `(A==B)&(B==C)`
6. Não suporta `A<=B<=C`, substitua manualmente por `(A<=B)&(B<=C)`
7. Suporta `A[0]+B[1]+C[2]`, que será convertido internamente para `A+ts_delay(B,1)+ts_delay(C,2)`
8. Suporta `~A`, que será convertido para `Not(A)`
9. Funções que começam com `gp_` sempre retornam a função correspondente `cs_`. Por exemplo, `gp_func(A,B,C)` será substituída por `cs_func(B,C)`, onde `A` é usado em `groupby([date, A])`
10. Suporta desempacotamento de tuplas `A,B,C=MACD()`, que internamente será substituído por
   ```python
   _x_0 = MACD()
   A = unpack(_x_0, 0)
   B = unpack(_x_0, 1)
   C = unpack(_x_0, 2)
   ```
11. Comentários de linha única suportam entrada de parâmetro, como: `# --over_null`, `# --over_null=order_by`, `# --over_null=partition_by`
12. Em blocos de código, as sintaxes `import`, `def` e `class` são inseridas literalmente no código gerado

## Variáveis Iniciadas com Sublinhado

1. Nos dados de saída, todas as colunas iniciadas com `_` são automaticamente removidas no final. Portanto, para variáveis que precisam ser mantidas, não use `_` no início
2. Para reduzir cálculos repetidos, variáveis intermediárias são adicionadas automaticamente, iniciando com `_x_`, como `_x_0`, `_x_1` etc. Serão removidas no final
3. Expressões de linha única muito longas ou com cálculos repetidos podem ser divididas em múltiplas linhas usando variáveis intermediárias. Se a variável intermediária começar com `_`, será adicionado um sufixo numérico automaticamente, criando variáveis diferentes, como `_A` será substituído por `_A_0_`, `_A_1_` etc. Cenários de uso:
    1. Mesmo nome de variável, uso repetido. Na essência, são variáveis diferentes
    2. Atribuição em loop, mas `DAG` não suporta ciclos. Variáveis de mesmo nome nos dois lados do `=` são, na verdade, variáveis diferentes

## Exemplo de Resultado da Tradução

Trecho de código após tradução, para o código completo veja [versão Polars](examples/output_polars.py)

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

Trecho de código após tradução, para o código completo veja [versão Pandas](examples/output_pandas.py)

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

## Página Web Interativa Local

Basta rodar `streamlit run streamlit_app.py`


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---