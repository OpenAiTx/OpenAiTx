
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

## ¿Qué es esto?

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

El Black-White Array (también conocido como BWArr) es una estructura de datos rápida y ordenada basada en arreglos con ***$O(\log N)$*** **asignaciones de memoria**.

## Estructura de Datos
La idea del Arreglo Blanco-Negro fue inventada y publicada por el profesor [Z. George Mou](https://www.cs.brandeis.edu/~mou/) en [Black-White Array: A New Data Structure for
Dynamic Data Sets](https://arxiv.org/abs/2004.09051). Este repositorio contiene la primera implementación pública.

![Profesor Z. George Mou](https://www.cs.brandeis.edu/~mou/mou.gif)

### Características clave:
- $O(\log N)$ asignaciones de memoria para inserciones - sin presión sobre el GC;
- Operaciones rápidas de inserción, eliminación y búsqueda con complejidad amortizada en tiempo de $O(\log N)$;
- Basado en arreglos y sin punteros, lo que lo hace amigable para la CPU: localidad de caché / iteración secuencial / etc;
- Soporta elementos duplicados de forma nativa (comportamiento de multiconjunto) - no es necesario envolver los valores en estructuras para hacerlos únicos;
- Sustituto directo para `github.com/google/btree` y `github.com/petar/GoLLRB`;
- Bajo consumo de memoria - sin punteros por elemento, representación de memoria compacta;
- Fácilmente serializable;

### Compensaciones
- En una de cada $N$ operaciones de inserción, la complejidad cae a $O(N)$, aunque la amortizada permanece en $O(\log N)$. Para sistemas en tiempo real, esto puede introducir picos de latencia en colecciones con millones de elementos. Se podría mitigar mediante inserciones asíncronas/en segundo plano.
- Para un pequeño número de elementos, las operaciones `Search()/Delete()` pueden tomar $O((\log N)^2)$. El 50% de los elementos toma $O(\log N)$ tiempo, el 75%  - $O(2\log N)$, el 87.5% - $O(3\log N)$, etc.
- Al eliminar largas series de elementos, una operación `Max()/Min()` puede tomar $O(N/4)$. La complejidad amortizada para series de llamadas se mantiene en $O(\log N)$.
- Al eliminar largas series de elementos, el paso de iteración puede tomar $O(N/4)$. La complejidad amortizada para la iteración sobre toda la colección permanece en $O(\log N)$ por elemento.

### Caso de uso
Colecciones en memoria con una relación de lectura-escritura 1:1 < r:w < 10:1. BWArr está optimizado para inserciones y eliminaciones intensivas (con bajas asignaciones y fragmentación), mientras sigue proporcionando búsqueda e iteración rápidas.

###  Benchmarks

Benchmarks en comparación con [Google BTree](https://github.com/google/btree).

#### Insertar 
Mide el tiempo, las asignaciones y los KB asignados para insertar N valores únicos aleatorios de int64 en una estructura de datos vacía. Tanto BWArr como BTree comienzan vacíos e insertan todos los valores uno a uno.

![Rendimiento de inserción](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![Inserciones Allocs](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![Insertar Alloc_Bytes](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)

Asignaciones en valores pequeños: 

![Asignaciones de inserción pequeñas](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)


#### Obtener
Mide el tiempo para buscar N valores por sus claves en una estructura de datos pre-poblada. La estructura de datos se llena con todos los valores antes de iniciar la medición, luego cada valor se recupera por su clave.

![Rendimiento de Obtener](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### Iterar
Mide el tiempo para iterar a través de todos los N valores en órdenes ordenados y no ordenados.
![Rendimiento de Iteración Ordenada](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![Rendimiento de Iteración No Ordenada](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### Más pruebas de rendimiento
Pruebas adicionales y detalles están disponibles en el repositorio [bwarr-bench](https://github.com/dronnix/bwarr-bench).
Se agregarán más métodos, también se esperan pruebas separadas para arquitecturas AMD64 y ARM64.

## Instalación

Requiere Go 1.22 o superior.

```bash
go get github.com/dronnix/bwarr
```

Luego importe en su código:

```go
import "github.com/dronnix/bwarr"
```

## Uso

### Ejemplo Básico

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