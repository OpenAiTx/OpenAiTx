# Algoritmos y Estructuras de Datos en JavaScript

> 🇺🇦 UCRANIA [ESTÁ SIENDO ATACADA](https://war.ukraine.ua/) POR EL EJÉRCITO RUSO. LOS CIVILES ESTÁN SIENDO ASESINADOS. ZONAS RESIDENCIALES ESTÁN SIENDO BOMBARDEADAS.
> - Ayuda a Ucrania a través de:
>   - [Fundación Benéfica Serhiy Prytula](https://prytulafoundation.org/en/)
>   - [Fundación Benéfica Come Back Alive](https://savelife.in.ua/en/donate-en/)
>   - [Banco Nacional de Ucrania](https://bank.gov.ua/en/news/all/natsionalniy-bank-vidkriv-spetsrahunok-dlya-zboru-koshtiv-na-potrebi-armiyi)
> - Más información en [war.ukraine.ua](https://war.ukraine.ua/) y [MFA de Ucrania](https://twitter.com/MFA_Ukraine)

<hr/>

[![CI](https://github.com/trekhleb/javascript-algorithms/workflows/CI/badge.svg)](https://github.com/trekhleb/javascript-algorithms/actions?query=workflow%3ACI+branch%3Amaster)
[![codecov](https://codecov.io/gh/trekhleb/javascript-algorithms/branch/master/graph/badge.svg)](https://codecov.io/gh/trekhleb/javascript-algorithms)
![repo size](https://img.shields.io/github/repo-size/trekhleb/javascript-algorithms.svg)

Este repositorio contiene ejemplos en JavaScript de muchos
algoritmos y estructuras de datos populares.

Cada algoritmo y estructura de datos tiene su propio README
con explicaciones relacionadas y enlaces para una lectura adicional (incluyendo algunos
a videos de YouTube).

_Léelo en otros idiomas:_
[_简体中文_](README.zh-CN.md),
[_繁體中文_](README.zh-TW.md),
[_한국어_](README.ko-KR.md),
[_日本語_](README.ja-JP.md),
[_Polski_](README.pl-PL.md),
[_Français_](README.fr-FR.md),
[_Español_](README.es-ES.md),
[_Português_](README.pt-BR.md),
[_Русский_](README.ru-RU.md),
[_Türkçe_](README.tr-TR.md),
[_Italiano_](README.it-IT.md),
[_Bahasa Indonesia_](README.id-ID.md),
[_Українська_](README.uk-UA.md),
[_Arabic_](README.ar-AR.md),
[_Tiếng Việt_](README.vi-VN.md),
[_Deutsch_](README.de-DE.md),
[_Uzbek_](README.uz-UZ.md),
[_עברית_](README.he-IL.md)

*☝ Ten en cuenta que este proyecto está destinado solo para fines de aprendizaje e investigación,
y **no** está destinado para usarse en producción.*

## Estructuras de Datos

Una estructura de datos es una forma particular de organizar y almacenar datos en una computadora para que puedan
ser accedidos y modificados eficientemente. Más precisamente, una estructura de datos es una colección de valores de datos,
las relaciones entre ellos y las funciones u operaciones que se pueden aplicar a los datos.

Recuerda que cada estructura de datos tiene sus propias ventajas y desventajas. Debes prestar más atención al por qué eliges una determinada estructura de datos que a cómo implementarla.

`B` - Principiante, `A` - Avanzado

* `B` [Lista Enlazada](src/data-structures/linked-list)
* `B` [Lista Doblemente Enlazada](src/data-structures/doubly-linked-list)
* `B` [Cola (Queue)](src/data-structures/queue)
* `B` [Pila (Stack)](src/data-structures/stack)
* `B` [Tabla Hash](src/data-structures/hash-table)
* `B` [Heap](src/data-structures/heap) - versiones de heap máximo y mínimo
* `B` [Cola de Prioridad](src/data-structures/priority-queue)
* `A` [Trie](src/data-structures/trie)
* `A` [Árbol (Tree)](src/data-structures/tree)
  * `A` [Árbol Binario de Búsqueda](src/data-structures/tree/binary-search-tree)
  * `A` [Árbol AVL](src/data-structures/tree/avl-tree)
  * `A` [Árbol Rojo-Negro](src/data-structures/tree/red-black-tree)
  * `A` [Árbol de Segmentos](src/data-structures/tree/segment-tree) - con ejemplos de consultas de rango min/máx/suma
  * `A` [Árbol Fenwick](src/data-structures/tree/fenwick-tree) (Árbol Binario Indexado)
* `A` [Grafo](src/data-structures/graph) (dirigido y no dirigido)
* `A` [Conjunto Disjunto (Disjoint Set)](src/data-structures/disjoint-set) - estructura de datos unión-búsqueda o conjunto de fusión-búsqueda
* `A` [Filtro de Bloom](src/data-structures/bloom-filter)
* `A` [Caché LRU](src/data-structures/lru-cache/) - Caché de Menor Reciente Uso (LRU)

## Algoritmos

Un algoritmo es una especificación inequívoca de cómo resolver una clase de problemas. Es
un conjunto de reglas que definen con precisión una secuencia de operaciones.

`B` - Principiante, `A` - Avanzado

### Algoritmos por Tema

* **Matemáticas**
  * `B` [Manipulación de Bits](src/algorithms/math/bits) - establecer/obtener/actualizar/borrar bits, multiplicación/división por dos, hacer negativo, etc.
  * `B` [Punto Flotante Binario](src/algorithms/math/binary-floating-point) - representación binaria de números de punto flotante.
  * `B` [Factorial](src/algorithms/math/factorial)
  * `B` [Número de Fibonacci](src/algorithms/math/fibonacci) - versiones clásicas y de forma cerrada
  * `B` [Factores Primos](src/algorithms/math/prime-factors) - encontrar factores primos y contarlos usando el teorema de Hardy-Ramanujan
  * `B` [Test de Primalidad](src/algorithms/math/primality-test) (método de división por prueba)
  * `B` [Algoritmo de Euclides](src/algorithms/math/euclidean-algorithm) - calcular el Máximo Común Divisor (MCD)
  * `B` [Mínimo Común Múltiplo](src/algorithms/math/least-common-multiple) (MCM)
  * `B` [Criba de Eratóstenes](src/algorithms/math/sieve-of-eratosthenes) - encontrar todos los números primos hasta un límite dado
  * `B` [Es Potencia de Dos](src/algorithms/math/is-power-of-two) - comprobar si un número es potencia de dos (algoritmos ingenuos y con bits)
  * `B` [Triángulo de Pascal](src/algorithms/math/pascal-triangle)
  * `B` [Número Complejo](src/algorithms/math/complex-number) - números complejos y operaciones básicas
  * `B` [Radianes y Grados](src/algorithms/math/radian) - conversión de radianes a grados y viceversa
  * `B` [Exponenciación Rápida](src/algorithms/math/fast-powering)
  * `B` [Método de Horner](src/algorithms/math/horner-method) - evaluación de polinomios
  * `B` [Matrices](src/algorithms/math/matrix) - matrices y operaciones básicas (multiplicación, transposición, etc.)
  * `B` [Distancia Euclidiana](src/algorithms/math/euclidean-distance) - distancia entre puntos/vectores/matrices
  * `A` [Partición de Enteros](src/algorithms/math/integer-partition)
  * `A` [Raíz Cuadrada](src/algorithms/math/square-root) - método de Newton
  * `A` [Algoritmo de Liu Hui para π](src/algorithms/math/liu-hui) - cálculos aproximados de π basados en N-ágonos
  * `A` [Transformada de Fourier Discreta](src/algorithms/math/fourier-transform) - descomposición de una función de tiempo (una señal) en sus frecuencias componentes
* **Conjuntos**
  * `B` [Producto Cartesiano](src/algorithms/sets/cartesian-product) - producto de múltiples conjuntos
  * `B` [Barajado Fisher–Yates](src/algorithms/sets/fisher-yates) - permutación aleatoria de una secuencia finita
  * `A` [Conjunto Potencia](src/algorithms/sets/power-set) - todos los subconjuntos de un conjunto (soluciones con bits, backtracking y en cascada)
  * `A` [Permutaciones](src/algorithms/sets/permutations) (con y sin repeticiones)
  * `A` [Combinaciones](src/algorithms/sets/combinations) (con y sin repeticiones)
  * `A` [Subsecuencia Común Más Larga](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [Subsecuencia Aumentada Más Larga](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [Supersecuencia Común Más Corta](src/algorithms/sets/shortest-common-supersequence) (SCS)
  * `A` [Problema de la Mochila](src/algorithms/sets/knapsack-problem) - versiones "0/1" y "Ilimitada"
  * `A` [Subarreglo Máximo](src/algorithms/sets/maximum-subarray) - versiones "Fuerza Bruta" y "Programación Dinámica" (Kadane)
  * `A` [Suma de Combinaciones](src/algorithms/sets/combination-sum) - encontrar todas las combinaciones que suman un valor específico
* **Cadenas**
  * `B` [Distancia de Hamming](src/algorithms/string/hamming-distance) - número de posiciones en las que los símbolos difieren
  * `B` [Palíndromo](src/algorithms/string/palindrome) - comprobar si la cadena es igual al revés
  * `A` [Distancia de Levenshtein](src/algorithms/string/levenshtein-distance) - distancia mínima de edición entre dos secuencias
  * `A` [Algoritmo Knuth–Morris–Pratt](src/algorithms/string/knuth-morris-pratt) (KMP) - búsqueda de subcadenas (patrones)
  * `A` [Algoritmo Z](src/algorithms/string/z-algorithm) - búsqueda de subcadenas (patrones)
  * `A` [Algoritmo Rabin Karp](src/algorithms/string/rabin-karp) - búsqueda de subcadenas
  * `A` [Subcadena Común Más Larga](src/algorithms/string/longest-common-substring)
  * `A` [Coincidencia de Expresiones Regulares](src/algorithms/string/regular-expression-matching)
* **Búsquedas**
  * `B` [Búsqueda Lineal](src/algorithms/search/linear-search)
  * `B` [Búsqueda por Saltos](src/algorithms/search/jump-search) (o búsqueda en bloques) - búsqueda en un arreglo ordenado
  * `B` [Búsqueda Binaria](src/algorithms/search/binary-search) - búsqueda en un arreglo ordenado
  * `B` [Búsqueda por Interpolación](src/algorithms/search/interpolation-search) - búsqueda en un arreglo ordenado uniformemente distribuido
* **Ordenamiento**
  * `B` [Ordenamiento de Burbuja](src/algorithms/sorting/bubble-sort)
  * `B` [Ordenamiento por Selección](src/algorithms/sorting/selection-sort)
  * `B` [Ordenamiento por Inserción](src/algorithms/sorting/insertion-sort)
  * `B` [Ordenamiento Heap](src/algorithms/sorting/heap-sort)
  * `B` [Ordenamiento por Mezcla](src/algorithms/sorting/merge-sort)
  * `B` [Quicksort](src/algorithms/sorting/quick-sort) - implementaciones en-lugar y no en-lugar
  * `B` [Shellsort](src/algorithms/sorting/shell-sort)
  * `B` [Counting Sort](src/algorithms/sorting/counting-sort)
  * `B` [Radix Sort](src/algorithms/sorting/radix-sort)
  * `B` [Bucket Sort](src/algorithms/sorting/bucket-sort)
* **Listas Enlazadas**
  * `B` [Recorrido Directo](src/algorithms/linked-list/traversal)
  * `B` [Recorrido Inverso](src/algorithms/linked-list/reverse-traversal)
* **Árboles**
  * `B` [Búsqueda en Profundidad](src/algorithms/tree/depth-first-search) (DFS)
  * `B` [Búsqueda en Anchura](src/algorithms/tree/breadth-first-search) (BFS)
* **Grafos**
  * `B` [Búsqueda en Profundidad](src/algorithms/graph/depth-first-search) (DFS)
  * `B` [Búsqueda en Anchura](src/algorithms/graph/breadth-first-search) (BFS)
  * `B` [Algoritmo de Kruskal](src/algorithms/graph/kruskal) - encontrar el Árbol de Expansión Mínima (MST) para grafos ponderados no dirigidos
  * `A` [Algoritmo de Dijkstra](src/algorithms/graph/dijkstra) - encontrar los caminos más cortos a todos los vértices desde un solo vértice
  * `A` [Algoritmo de Bellman-Ford](src/algorithms/graph/bellman-ford) - encontrar los caminos más cortos a todos los vértices desde un solo vértice
  * `A` [Algoritmo de Floyd-Warshall](src/algorithms/graph/floyd-warshall) - encontrar los caminos más cortos entre todos los pares de vértices
  * `A` [Detección de Ciclos](src/algorithms/graph/detect-cycle) - para grafos dirigidos y no dirigidos (versiones basadas en DFS y Conjunto Disjunto)
  * `A` [Algoritmo de Prim](src/algorithms/graph/prim) - encontrar el Árbol de Expansión Mínima (MST) para grafos ponderados no dirigidos
  * `A` [Ordenamiento Topológico](src/algorithms/graph/topological-sorting) - método DFS
  * `A` [Puntos de Articulación](src/algorithms/graph/articulation-points) - algoritmo de Tarjan (basado en DFS)
  * `A` [Puentes](src/algorithms/graph/bridges) - algoritmo basado en DFS
  * `A` [Camino y Circuito Euleriano](src/algorithms/graph/eulerian-path) - algoritmo de Fleury - Visitar cada arista exactamente una vez
  * `A` [Ciclo Hamiltoniano](src/algorithms/graph/hamiltonian-cycle) - Visitar cada vértice exactamente una vez
  * `A` [Componentes Fuertemente Conectados](src/algorithms/graph/strongly-connected-components) - algoritmo de Kosaraju
  * `A` [Problema del Viajante (Travelling Salesman)](src/algorithms/graph/travelling-salesman) - ruta más corta que visita cada ciudad y retorna al origen
* **Criptografía**
  * `B` [Hash Polinomial](src/algorithms/cryptography/polynomial-hash) - función hash rodante basada en polinomio
  * `B` [Cifrado Rail Fence](src/algorithms/cryptography/rail-fence-cipher) - algoritmo de cifrado por transposición
  * `B` [Cifrado César](src/algorithms/cryptography/caesar-cipher) - cifrado por sustitución simple
  * `B` [Cifrado Hill](src/algorithms/cryptography/hill-cipher) - cifrado basado en álgebra lineal
* **Aprendizaje Automático (Machine Learning)**
  * `B` [NanoNeuron](https://github.com/trekhleb/nano-neuron) - 7 funciones JS simples que ilustran cómo las máquinas pueden aprender (propagación hacia adelante/atrás)
  * `B` [k-NN](src/algorithms/ml/knn) - algoritmo de clasificación k-vecinos más cercanos
  * `B` [k-Means](src/algorithms/ml/k-means) - algoritmo de agrupamiento k-Means
* **Procesamiento de Imágenes**
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving) - algoritmo de redimensionado de imagen consciente del contenido
* **Estadística**
  * `B` [Aleatorio Ponderado](src/algorithms/statistics/weighted-random) - seleccionar un elemento aleatorio basado en pesos
* **Algoritmos Evolutivos**
  * `A` [Algoritmo Genético](https://github.com/trekhleb/self-parking-car-evolution) - ejemplo de cómo se puede aplicar para entrenar autos que se estacionan solos
* **Sin Categoría**
  * `B` [Torre de Hanói](src/algorithms/uncategorized/hanoi-tower)
  * `B` [Rotación de Matriz Cuadrada](src/algorithms/uncategorized/square-matrix-rotation) - algoritmo en-lugar
  * `B` [Juego de Saltos (Jump Game)](src/algorithms/uncategorized/jump-game) - backtracking, programación dinámica (de arriba-abajo y de abajo-arriba) y ejemplos voraces
  * `B` [Caminos Únicos](src/algorithms/uncategorized/unique-paths) - backtracking, programación dinámica y ejemplos basados en Triángulo de Pascal
  * `B` [Terrazas de Lluvia](src/algorithms/uncategorized/rain-terraces) - problema de capturar agua de lluvia (versiones dinámica y fuerza bruta)
  * `B` [Escalera Recursiva](src/algorithms/uncategorized/recursive-staircase) - contar el número de formas de llegar a la cima (4 soluciones)
  * `B` [Mejor Momento para Comprar/Vender Acciones](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - ejemplos de divide y vencerás y de una sola pasada
  * `B` [Paréntesis Válidos](src/algorithms/stack/valid-parentheses) - verificar si una cadena tiene paréntesis válidos (usando pila)
  * `A` [Problema de las N-Reinas](src/algorithms/uncategorized/n-queens)
  * `A` [Recorrido del Caballo (Knight's Tour)](src/algorithms/uncategorized/knight-tour)

### Algoritmos por Paradigma

Un paradigma algorítmico es un método o enfoque genérico que subyace en el diseño de una clase
de algoritmos. Es una abstracción más alta que la noción de algoritmo, así como un
algoritmo es una abstracción más alta que un programa informático.

* **Fuerza Bruta** - examina todas las posibilidades y selecciona la mejor solución
  * `B` [Búsqueda Lineal](src/algorithms/search/linear-search)
  * `B` [Terrazas de Lluvia](src/algorithms/uncategorized/rain-terraces) - problema de capturar agua de lluvia
  * `B` [Escalera Recursiva](src/algorithms/uncategorized/recursive-staircase) - contar el número de formas de llegar a la cima
  * `A` [Subarreglo Máximo](src/algorithms/sets/maximum-subarray)
  * `A` [Problema del Viajante (Travelling Salesman)](src/algorithms/graph/travelling-salesman) - ruta más corta que visita cada ciudad y retorna al origen
  * `A` [Transformada de Fourier Discreta](src/algorithms/math/fourier-transform) - descomponer una función de tiempo (una señal) en sus frecuencias
* **Voraz (Greedy)** - elige la mejor opción en el momento actual, sin considerar el futuro
  * `B` [Juego de Saltos (Jump Game)](src/algorithms/uncategorized/jump-game)
  * `A` [Problema de la Mochila Ilimitada](src/algorithms/sets/knapsack-problem)
  * `A` [Algoritmo de Dijkstra](src/algorithms/graph/dijkstra) - encontrar el camino más corto a todos los vértices
  * `A` [Algoritmo de Prim](src/algorithms/graph/prim) - encontrar el Árbol de Expansión Mínima (MST)
  * `A` [Algoritmo de Kruskal](src/algorithms/graph/kruskal) - encontrar el Árbol de Expansión Mínima (MST)
* **Divide y Vencerás** - divide el problema en partes más pequeñas y luego resuélvelas
  * `B` [Búsqueda Binaria](src/algorithms/search/binary-search)
  * `B` [Torre de Hanói](src/algorithms/uncategorized/hanoi-tower)
  * `B` [Triángulo de Pascal](src/algorithms/math/pascal-triangle)
  * `B` [Algoritmo de Euclides](src/algorithms/math/euclidean-algorithm) - calcular el MCD
  * `B` [Ordenamiento por Mezcla](src/algorithms/sorting/merge-sort)
  * `B` [Quicksort](src/algorithms/sorting/quick-sort)
  * `B` [Búsqueda en Profundidad en Árbol](src/algorithms/tree/depth-first-search) (DFS)
  * `B` [Búsqueda en Profundidad en Grafo](src/algorithms/graph/depth-first-search) (DFS)
  * `B` [Matrices](src/algorithms/math/matrix) - generar y recorrer matrices de diferentes formas
  * `B` [Juego de Saltos (Jump Game)](src/algorithms/uncategorized/jump-game)
  * `B` [Exponenciación Rápida](src/algorithms/math/fast-powering)
  * `B` [Mejor Momento para Comprar/Vender Acciones](src/algorithms/uncategorized/best-time-to-buy-sell-stocks)
  * `A` [Permutaciones](src/algorithms/sets/permutations) (con y sin repeticiones)
  * `A` [Combinaciones](src/algorithms/sets/combinations) (con y sin repeticiones)
  * `A` [Subarreglo Máximo](src/algorithms/sets/maximum-subarray)
* **Programación Dinámica** - construir una solución usando sub-soluciones previamente encontradas
  * `B` [Número de Fibonacci](src/algorithms/math/fibonacci)
  * `B` [Juego de Saltos (Jump Game)](src/algorithms/uncategorized/jump-game)
  * `B` [Caminos Únicos](src/algorithms/uncategorized/unique-paths)
  * `B` [Terrazas de Lluvia](src/algorithms/uncategorized/rain-terraces)
  * `B` [Escalera Recursiva](src/algorithms/uncategorized/recursive-staircase)
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving)
  * `A` [Distancia de Levenshtein](src/algorithms/string/levenshtein-distance)
  * `A` [Subsecuencia Común Más Larga](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [Subcadena Común Más Larga](src/algorithms/string/longest-common-substring)
  * `A` [Subsecuencia Aumentada Más Larga](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [Supersecuencia Común Más Corta](src/algorithms/sets/shortest-common-supersequence)
  * `A` [Problema de la Mochila 0/1](src/algorithms/sets/knapsack-problem)
  * `A` [Partición de Enteros](src/algorithms/math/integer-partition)
  * `A` [Subarreglo Máximo](src/algorithms/sets/maximum-subarray)
  * `A` [Algoritmo de Bellman-Ford](src/algorithms/graph/bellman-ford)
  * `A` [Algoritmo de Floyd-Warshall](src/algorithms/graph/floyd-warshall)
  * `A` [Coincidencia de Expresiones Regulares](src/algorithms/string/regular-expression-matching)
* **Backtracking** - similar a fuerza bruta, intenta generar todas las soluciones posibles, pero cada vez que generas la siguiente solución, pruebas
si satisface todas las condiciones y solo entonces continúas generando soluciones posteriores. De lo contrario, retrocedes y vas por un
camino diferente para encontrar una solución. Normalmente se usa el recorrido DFS del espacio de estados.
  * `B` [Juego de Saltos (Jump Game)](src/algorithms/uncategorized/jump-game)
  * `B` [Caminos Únicos](src/algorithms/uncategorized/unique-paths)
  * `B` [Conjunto Potencia](src/algorithms/sets/power-set)
  * `A` [Ciclo Hamiltoniano](src/algorithms/graph/hamiltonian-cycle)
  * `A` [Problema de las N-Reinas](src/algorithms/uncategorized/n-queens)
  * `A` [Recorrido del Caballo (Knight's Tour)](src/algorithms/uncategorized/knight-tour)
  * `A` [Suma de Combinaciones](src/algorithms/sets/combination-sum)
* **Branch & Bound** - recuerda la solución de menor costo encontrada en cada etapa de la búsqueda por backtracking
y utiliza el costo de la solución de menor costo encontrada hasta ese momento como un límite inferior para descartar
soluciones parciales cuyo costo sea mayor. Normalmente se usa BFS en combinación con DFS en el árbol de espacio de estados.

## Cómo usar este repositorio

**Instalar todas las dependencias**

```
npm install
```

**Ejecutar ESLint**

Puedes ejecutarlo para comprobar la calidad del código.

```
npm run lint
```

**Ejecutar todos los tests**

```
npm test
```

**Ejecutar tests por nombre**

```
npm test -- 'LinkedList'
```

**Resolución de Problemas**

Si el linting o las pruebas fallan, intenta eliminar la carpeta `node_modules` y reinstalar los paquetes de npm:

```
rm -rf ./node_modules
npm i
```

Además, asegúrate de estar usando la versión correcta de Node (`>=16`). Si utilizas [nvm](https://github.com/nvm-sh/nvm) para la gestión de versiones de Node, puedes ejecutar `nvm use` desde la carpeta raíz del proyecto y se seleccionará la versión correcta.

**Playground**

Puedes experimentar con estructuras de datos y algoritmos en el archivo `./src/playground/playground.js` y escribir
pruebas para él en `./src/playground/__test__/playground.test.js`.

Luego, simplemente ejecuta el siguiente comando para comprobar si tu código del playground funciona como se espera:

```
npm test -- 'playground'
```

## Información Útil

### Referencias

- [▶ Estructuras de Datos y Algoritmos en YouTube](https://www.youtube.com/playlist?list=PLLXdhg_r2hKA7DPDsunoDZ-Z769jWn4R8)
- [✍🏻 Bocetos de Estructuras de Datos](https://okso.app/showcase/data-structures)

### Notación Big O

*La notación Big O* se utiliza para clasificar los algoritmos según cómo su tiempo de ejecución o requerimientos de espacio crecen a medida que crece el tamaño de la entrada.
En el siguiente gráfico, puedes ver los órdenes de crecimiento más comunes de los algoritmos especificados en notación Big O.

![Gráficas de Big O](./assets/big-o-graph.png)

Fuente: [Big O Cheat Sheet](http://bigocheatsheet.com/).

A continuación se muestra una lista de algunas de las notaciones Big O más usadas y sus comparaciones de rendimiento contra diferentes tamaños de datos de entrada.

| Notación Big O | Tipo        | Cómputos para 10 elementos | Cómputos para 100 elementos | Cómputos para 1000 elementos  |
| -------------- | ----------- | -------------------------- | --------------------------- | ----------------------------- |
| **O(1)**       | Constante   | 1                          | 1                           | 1                             |
| **O(log N)**   | Logarítmica | 3                          | 6                           | 9                             |
| **O(N)**       | Lineal      | 10                         | 100                         | 1000                          |
| **O(N log N)** | n log(n)    | 30                         | 600                         | 9000                          |
| **O(N^2)**     | Cuadrática  | 100                        | 10000                       | 1000000                       |
| **O(2^N)**     | Exponencial | 1024                       | 1.26e+29                    | 1.07e+301                     |
| **O(N!)**      | Factorial   | 3628800                    | 9.3e+157                    | 4.02e+2567                    |

### Complejidad de Operaciones de Estructuras de Datos

| Estructura de Datos      | Acceso    | Búsqueda  | Inserción | Eliminación | Comentarios  |
| ------------------------ | :-------: | :-------: | :-------: | :---------: | :----------: |
| **Arreglo**              | 1         | n         | n         | n           |              |
| **Pila**                 | n         | n         | 1         | 1           |              |
| **Cola**                 | n         | n         | 1         | 1           |              |
| **Lista Enlazada**       | n         | n         | 1         | n           |              |
| **Tabla Hash**           | -         | n         | n         | n           | En caso de función hash perfecta, el costo sería O(1) |
| **Árbol Binario de Búsqueda** | n   | n         | n         | n           | En caso de árbol balanceado, el costo sería O(log(n)) |
| **B-Tree**               | log(n)    | log(n)    | log(n)    | log(n)      |              |
| **Árbol Rojo-Negro**     | log(n)    | log(n)    | log(n)    | log(n)      |              |
| **Árbol AVL**            | log(n)    | log(n)    | log(n)    | log(n)      |              |
| **Filtro de Bloom**      | -         | 1         | 1         | -           | Puede haber falsos positivos en la búsqueda |

### Complejidad de Algoritmos de Ordenamiento de Arreglos

| Nombre                  | Mejor           | Promedio             | Peor                | Memoria   | Estable   | Comentarios  |
| ----------------------- | :-------------: | :------------------: | :-----------------: | :-------: | :-------: | :----------: |
| **Ordenamiento Burbuja**| n               | n<sup>2</sup>        | n<sup>2</sup>       | 1         | Sí        |              |
| **Ordenamiento Inserción**| n             | n<sup>2</sup>        | n<sup>2</sup>       | 1         | Sí        |              |
| **Ordenamiento Selección**| n<sup>2</sup> | n<sup>2</sup>        | n<sup>2</sup>       | 1         | No        |              |
| **Heap Sort**           | n&nbsp;log(n)   | n&nbsp;log(n)        | n&nbsp;log(n)       | 1         | No        |              |
| **Ordenamiento por Mezcla**| n&nbsp;log(n)| n&nbsp;log(n)        | n&nbsp;log(n)       | n         | Sí        |              |
| **Quicksort**           | n&nbsp;log(n)   | n&nbsp;log(n)        | n<sup>2</sup>       | log(n)    | No        | Quicksort normalmente se implementa en-lugar con O(log(n)) espacio en la pila |
| **Shell sort**          | n&nbsp;log(n)   | depende de la secuencia de saltos | n&nbsp;(log(n))<sup>2</sup> | 1 | No |     |
| **Counting sort**       | n + r           | n + r                | n + r               | n + r     | Sí        | r - número más grande en el arreglo |
| **Radix sort**          | n * k           | n * k                | n * k               | n + k     | Sí        | k - longitud de la clave más larga |

## Patrocinadores del Proyecto

> Puedes apoyar este proyecto vía ❤️️ [GitHub](https://github.com/sponsors/trekhleb) o ❤️️ [Patreon](https://www.patreon.com/trekhleb).

[Personas que apoyan este proyecto](https://github.com/trekhleb/javascript-algorithms/blob/master/BACKERS.md) `∑ = 1`

## Autor

[@trekhleb](https://trekhleb.dev)

Algunos [proyectos](https://trekhleb.dev/projects/) y [artículos](https://trekhleb.dev/blog/) más sobre JavaScript y algoritmos en [trekhleb.dev](https://trekhleb.dev)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---