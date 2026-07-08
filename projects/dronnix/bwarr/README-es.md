## ¿Qué es?

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

El Black-White Array (también conocido como BWArr) es una estructura de datos ordenada y rápida basada en arrays con ***$O(\log N)$*** **asignaciones de memoria**.

## Estructura de Datos
La idea del Black-White Array fue inventada y publicada por el profesor [Z. George Mou](https://www.cs.brandeis.edu/~mou/) en [Black-White Array: A New Data Structure for
Dynamic Data Sets](https://arxiv.org/abs/2004.09051). Este repositorio contiene la primera implementación pública.

![Profesor Z. George Mou](https://www.cs.brandeis.edu/~mou/mou.gif)

### Características clave:
- $O(\log N)$ asignaciones de memoria para inserciones - sin presión sobre el GC;
- Operaciones rápidas de inserción, eliminación y búsqueda con complejidad amortizada de tiempo $O(\log N)$;
- Basado en arrays y sin punteros, lo que lo hace amigable para la CPU: localidad de caché / iteración secuencial / etc;
- Soporta elementos duplicados de forma nativa (comportamiento multiconjunto) - no es necesario envolver valores en structs para hacerlos únicos;
- Reemplazo directo para `github.com/google/btree` y `github.com/petar/GoLLRB`;
- Bajo consumo de memoria - sin punteros por elemento, representación de memoria compacta;
- Fácilmente serializable;

### Contras
- Una inserción de cada $N$ tiene complejidad $O(N)$, aunque amortizada sigue siendo $O(\log N)$. Para sistemas en tiempo real, puede introducir picos de latencia en colecciones con millones de elementos. Puede mitigarse con inserciones asíncronas/en segundo plano.
- Para un número pequeño de elementos, las operaciones `Search()/Delete()` pueden tomar $O((\log N)^2)$. El 50% de los elementos toman $O(\log N)$ tiempo, el 75% - $O(2\log N)$, el 87.5% - $O(3\log N)$, etc.
- Al eliminar largas series de elementos, una operación `Max()/Min()` puede tomar $O(N/4)$. La complejidad amortizada para series de llamadas sigue siendo $O(\log N)$.
- Al eliminar largas series de elementos, un paso de iteración puede tomar $O(N/4)$. La complejidad amortizada para la iteración sobre toda la colección sigue siendo $O(\log N)$ por elemento.

###  Benchmarks

Benchmarks en comparación con [Google BTree](https://github.com/google/btree).

#### Inserción
Mide el tiempo, asignaciones y KB asignados para insertar N valores int64 aleatorios únicos en una estructura de datos vacía. Tanto BWArr como BTree comienzan vacíos e insertan todos los valores uno por uno.

![Rendimiento de inserción](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![Asignaciones en inserción](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![Bytes asignados en inserción](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)
Asignaciones en valores más pequeños:

![Insertar Asignaciones pequeñas](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)


#### Obtener
Mide el tiempo para buscar N valores por sus claves en una estructura de datos pre-poblada. La estructura de datos se llena con todos los valores antes de que comience la medición, luego se recupera cada valor por clave.

![Rendimiento de Obtener](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### Iterar
Mide el tiempo para iterar a través de todos los N valores en órdenes ordenados y no ordenados.
![Rendimiento de Iteración Ordenada](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![Rendimiento de Iteración No Ordenada](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### Más benchmarks
Benchmarks adicionales y detalles están disponibles en el repositorio [bwarr-bench](https://github.com/dronnix/bwarr-bench).
Se agregarán más métodos, también se esperan benchmarks separados para arquitecturas AMD64 y ARM64.

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
    "fmt"

    "github.com/dronnix/bwarr"
)

func main() {
    // Create a BWArr with an integer comparison function
    // The second parameter (10) is the initial capacity hint
    bwa := bwarr.New(func(a, b int64) int {
        return int(a - b)
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-08

---