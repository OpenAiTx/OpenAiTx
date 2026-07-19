
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

## O que é?

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

O Black-White Array (também conhecido como BWArr) é uma estrutura de dados rápida e ordenada baseada em arrays com ***$O(\log N)$*** **alocações de memória**.

## Estrutura de Dados
A ideia do Black-White Array foi inventada e publicada pelo professor [Z. George Mou](https://www.cs.brandeis.edu/~mou/) em [Black-White Array: A New Data Structure for
Dynamic Data Sets](https://arxiv.org/abs/2004.09051). Este repositório contém a primeira implementação pública.

![Professor Z. George Mou](https://www.cs.brandeis.edu/~mou/mou.gif)

### Principais características:
- $O(\log N)$ alocações de memória para inserções - sem pressão no GC;
- Operações rápidas de inserção, exclusão e busca com complexidade de tempo amortizado $O(\log N)$;
- Baseado em array e sem ponteiros, tornando-o amigável à CPU: localidade de cache / iteração sequencial / etc;
- Suporta elementos duplicados nativamente (comportamento de multiconjunto) - não é necessário encapsular valores em structs para torná-los únicos;
- Substituição direta para `github.com/google/btree` e `github.com/petar/GoLLRB`;
- Baixo overhead de memória - sem ponteiros por elemento, representação de memória compacta;
- Facilmente serializável;

### Tradeoffs
- Uma a cada $N$ operações de inserção a complexidade cai para $O(N)$, embora o amortizado permaneça $O(\log N)$. Para sistemas em tempo real, pode causar picos de latência em coleções com milhões de elementos. Pode ser mitigado por inserções assíncronas/em segundo plano.
- Para um pequeno número de elementos, as operações `Search()/Delete()` podem levar $O((\log N)^2)$. 50% dos elementos levam $O(\log N)$ de tempo, 75%  - $O(2\log N)$, 87,5% - $O(3\log N)$, etc.
- Ao deletar longas séries de elementos, uma operação `Max()/Min()` pode levar $O(N/4)$. A complexidade amortizada para séries de chamadas permanece $O(\log N)$.
- Ao deletar longas séries de elementos, o passo de iteração pode levar $O(N/4)$. A complexidade amortizada para iteração sobre toda a coleção permanece $O(\log N)$ por elemento.

### Caso de uso
Coleções em memória com razão leitura-escrita 1:1 < l:e < 10:1. BWArr é otimizado para inserções e deleções pesadas (com baixas alocações e fragmentação), mantendo busca e iteração rápidas.

###  Benchmarks

Benchmarks em comparação com [Google BTree](https://github.com/google/btree).

#### Inserção 
Mede o tempo, alocações e KBs alocados para inserir N valores int64 únicos aleatórios em uma estrutura de dados vazia. Tanto BWArr quanto BTree começam vazios e inserem todos os valores um a um.

![Desempenho de Inserção](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![Alocações de Inserção](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![Bytes Alocados na Inserção](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)

Alocações em valores menores:

![Alocações de Inserção pequenas](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)


#### Get 
Mede o tempo para buscar N valores por suas chaves em uma estrutura de dados pré-preenchida. A estrutura de dados é preenchida com todos os valores antes do início da cronometragem, então cada valor é recuperado por sua chave.

![Desempenho do Get](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### Iterar
Mede o tempo para iterar por todos os N valores em ordens ordenadas e não ordenadas.
![Desempenho da iteração ordenada](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![Desempenho da iteração não ordenada](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### Mais benchmarks
Benchmarks adicionais e detalhes estão disponíveis no repositório [bwarr-bench](https://github.com/dronnix/bwarr-bench).
Mais métodos serão adicionados, assim como benchmarks separados para as arquiteturas AMD64 e ARM64.

## Instalação

Requer Go 1.22 ou superior.

```bash
go get github.com/dronnix/bwarr
```

Em seguida, importe no seu código:

```go
import "github.com/dronnix/bwarr"
```

## Uso

### Exemplo Básico

```go
package main

import (
    "cmp"
    "fmt"

    "github.com/dronnix/bwarr"
)

func main() {
    // Create a BWArr with an integer comparison function
    // The second parameter (10) is the initial capacity hint
    bwa := bwarr.New(func(a, b int64) int {
        return cmp.Compare(a, b)
    }, 10)

    // Insert elements
    bwa.Insert(42)
    bwa.Insert(17)
    bwa.Insert(99)
    bwa.Insert(23)
    bwa.Insert(8)

    fmt.Printf("Length: %d\n", bwa.Len()) // Output: Length: 5

    // Get an element
    val, found := bwa.Get(42)
    if found {
        fmt.Printf("Found: %d\n", val) // Output: Found: 42
    }

    // Delete an element
    deleted, found := bwa.Delete(17)
    if found {
        fmt.Printf("Deleted: %d\n", deleted) // Output: Deleted: 17
    }

    // Iterate in ascending order
    fmt.Println("Elements in sorted order:")
    bwa.Ascend(func(item int64) bool {
        fmt.Printf("  %d\n", item)
        return true // return false to stop iteration early
    })
    // Output:
    //   8
    //   23
    //   42
    //   99
}
```




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-19

---