# Algoritmos e Estruturas de Dados em JavaScript

> 🇺🇦 A UCRÂNIA [ESTÁ SENDO ATACADA](https://war.ukraine.ua/) PELO EXÉRCITO RUSSO. CIVIS ESTÃO SENDO MORTOS. ÁREAS RESIDENCIAIS ESTÃO SENDO BOMBARDIADAS.
> - Ajude a Ucrânia através de:
>   - [Serhiy Prytula Charity Foundation](https://prytulafoundation.org/en/)
>   - [Come Back Alive Charity Foundation](https://savelife.in.ua/en/donate-en/)
>   - [Banco Nacional da Ucrânia](https://bank.gov.ua/en/news/all/natsionalniy-bank-vidkriv-spetsrahunok-dlya-zboru-koshtiv-na-potrebi-armiyi)
> - Mais informações em [war.ukraine.ua](https://war.ukraine.ua/) e [MFA da Ucrânia](https://twitter.com/MFA_Ukraine)

<hr/>

[![CI](https://github.com/trekhleb/javascript-algorithms/workflows/CI/badge.svg)](https://github.com/trekhleb/javascript-algorithms/actions?query=workflow%3ACI+branch%3Amaster)
[![codecov](https://codecov.io/gh/trekhleb/javascript-algorithms/branch/master/graph/badge.svg)](https://codecov.io/gh/trekhleb/javascript-algorithms)
![repo size](https://img.shields.io/github/repo-size/trekhleb/javascript-algorithms.svg)

Este repositório contém exemplos, baseados em JavaScript, de muitos
algoritmos e estruturas de dados populares.

Cada algoritmo e estrutura de dados possui seu próprio README separado
com explicações relacionadas e links para leitura adicional (incluindo vídeos no YouTube).

_Leia isto em outros idiomas:_
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

*☝ Note que este projeto é destinado apenas para fins de aprendizado e pesquisa,
e **não** deve ser usado em produção.*

## Estruturas de Dados

Uma estrutura de dados é uma forma específica de organizar e armazenar dados em um computador para que possam
ser acessados e modificados de forma eficiente. Mais precisamente, uma estrutura de dados é uma coleção de valores,
os relacionamentos entre eles e as funções ou operações que podem ser aplicadas aos dados.

Lembre-se de que cada estrutura de dados possui seus próprios prós e contras. E você precisa prestar mais atenção ao motivo pelo qual está escolhendo determinada estrutura de dados do que à forma de implementá-la.

`B` - Iniciante, `A` - Avançado

* `B` [Lista Encadeada](src/data-structures/linked-list)
* `B` [Lista Duplamente Encadeada](src/data-structures/doubly-linked-list)
* `B` [Fila (Queue)](src/data-structures/queue)
* `B` [Pilha (Stack)](src/data-structures/stack)
* `B` [Tabela Hash](src/data-structures/hash-table)
* `B` [Heap](src/data-structures/heap) - versões de heap máximo e mínimo
* `B` [Fila de Prioridade](src/data-structures/priority-queue)
* `A` [Trie](src/data-structures/trie)
* `A` [Árvore](src/data-structures/tree)
  * `A` [Árvore Binária de Busca](src/data-structures/tree/binary-search-tree)
  * `A` [Árvore AVL](src/data-structures/tree/avl-tree)
  * `A` [Árvore Rubro-Negra](src/data-structures/tree/red-black-tree)
  * `A` [Árvore de Segmentos](src/data-structures/tree/segment-tree) - com exemplos de consultas de intervalo min/máx/soma
  * `A` [Árvore Fenwick](src/data-structures/tree/fenwick-tree) (Árvore Binária Indexada)
* `A` [Grafo](src/data-structures/graph) (direcionado e não direcionado)
* `A` [Conjunto Disjunto](src/data-structures/disjoint-set) - estrutura union–find ou merge–find set
* `A` [Filtro de Bloom](src/data-structures/bloom-filter)
* `A` [Cache LRU](src/data-structures/lru-cache/) - cache Least Recently Used (LRU)

## Algoritmos

Um algoritmo é uma especificação não ambígua de como resolver uma classe de problemas. É
um conjunto de regras que define precisamente uma sequência de operações.

`B` - Iniciante, `A` - Avançado

### Algoritmos por Tópico

* **Matemática**
  * `B` [Manipulação de Bits](src/algorithms/math/bits) - setar/obter/atualizar/limpar bits, multiplicação/divisão por dois, transformar em negativo etc.
  * `B` [Ponto Flutuante Binário](src/algorithms/math/binary-floating-point) - representação binária de números de ponto flutuante.
  * `B` [Fatorial](src/algorithms/math/factorial)
  * `B` [Número de Fibonacci](src/algorithms/math/fibonacci) - versões clássica e de forma fechada
  * `B` [Fatores Primos](src/algorithms/math/prime-factors) - encontrando fatores primos e contando-os usando o teorema de Hardy-Ramanujan
  * `B` [Teste de Primalidade](src/algorithms/math/primality-test) (método da divisão por tentativa)
  * `B` [Algoritmo de Euclides](src/algorithms/math/euclidean-algorithm) - calcular o Máximo Divisor Comum (MDC)
  * `B` [Mínimo Múltiplo Comum](src/algorithms/math/least-common-multiple) (MMC)
  * `B` [Crivo de Eratóstenes](src/algorithms/math/sieve-of-eratosthenes) - encontrar todos os números primos até um determinado limite
  * `B` [É Potência de Dois](src/algorithms/math/is-power-of-two) - verifica se o número é potência de dois (algoritmos ingênuo e por bits)
  * `B` [Triângulo de Pascal](src/algorithms/math/pascal-triangle)
  * `B` [Número Complexo](src/algorithms/math/complex-number) - números complexos e operações básicas
  * `B` [Radianos e Graus](src/algorithms/math/radian) - conversão de radianos para graus e vice-versa
  * `B` [Exponenciação Rápida](src/algorithms/math/fast-powering)
  * `B` [Método de Horner](src/algorithms/math/horner-method) - avaliação de polinômios
  * `B` [Matrizes](src/algorithms/math/matrix) - matrizes e operações básicas (multiplicação, transposição, etc.)
  * `B` [Distância Euclidiana](src/algorithms/math/euclidean-distance) - distância entre dois pontos/vetores/matrizes
  * `A` [Partição de Inteiro](src/algorithms/math/integer-partition)
  * `A` [Raiz Quadrada](src/algorithms/math/square-root) - método de Newton
  * `A` [Algoritmo de Liu Hui para π](src/algorithms/math/liu-hui) - cálculos aproximados de π com base em polígonos N-lados
  * `A` [Transformada Discreta de Fourier](src/algorithms/math/fourier-transform) - decompõe uma função do tempo (um sinal) nas frequências que a compõem
* **Conjuntos**
  * `B` [Produto Cartesiano](src/algorithms/sets/cartesian-product) - produto de múltiplos conjuntos
  * `B` [Embaralhamento Fisher–Yates](src/algorithms/sets/fisher-yates) - permutação aleatória de uma sequência finita
  * `A` [Conjunto Potência](src/algorithms/sets/power-set) - todos os subconjuntos de um conjunto (soluções por bits, backtracking e cascata)
  * `A` [Permutações](src/algorithms/sets/permutations) (com e sem repetição)
  * `A` [Combinações](src/algorithms/sets/combinations) (com e sem repetição)
  * `A` [Subsequência Comum Mais Longa](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [Subsequência Crescente Mais Longa](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [Supersequência Comum Mais Curta](src/algorithms/sets/shortest-common-supersequence) (SCS)
  * `A` [Problema da Mochila](src/algorithms/sets/knapsack-problem) - versões "0/1" e "Sem Limite"
  * `A` [Subarray Máximo](src/algorithms/sets/maximum-subarray) - versões "Força Bruta" e "Programação Dinâmica" (Kadane)
  * `A` [Combinação de Soma](src/algorithms/sets/combination-sum) - encontrar todas as combinações que formam uma soma específica
* **Strings**
  * `B` [Distância de Hamming](src/algorithms/string/hamming-distance) - número de posições em que os símbolos são diferentes
  * `B` [Palíndromo](src/algorithms/string/palindrome) - verifica se a string é igual invertida
  * `A` [Distância de Levenshtein](src/algorithms/string/levenshtein-distance) - distância mínima de edição entre duas sequências
  * `A` [Algoritmo Knuth–Morris–Pratt](src/algorithms/string/knuth-morris-pratt) (KMP) - busca de substring (casamento de padrões)
  * `A` [Algoritmo Z](src/algorithms/string/z-algorithm) - busca de substring (casamento de padrões)
  * `A` [Algoritmo Rabin Karp](src/algorithms/string/rabin-karp) - busca de substring
  * `A` [Substring Comum Mais Longa](src/algorithms/string/longest-common-substring)
  * `A` [Casamento de Expressão Regular](src/algorithms/string/regular-expression-matching)
* **Buscas**
  * `B` [Busca Linear](src/algorithms/search/linear-search)
  * `B` [Busca por Saltos](src/algorithms/search/jump-search) (ou Busca em Blocos) - busca em array ordenado
  * `B` [Busca Binária](src/algorithms/search/binary-search) - busca em array ordenado
  * `B` [Busca por Interpolação](src/algorithms/search/interpolation-search) - busca em array ordenado uniformemente distribuído
* **Ordenação**
  * `B` [Bubble Sort](src/algorithms/sorting/bubble-sort)
  * `B` [Selection Sort](src/algorithms/sorting/selection-sort)
  * `B` [Insertion Sort](src/algorithms/sorting/insertion-sort)
  * `B` [Heap Sort](src/algorithms/sorting/heap-sort)
  * `B` [Merge Sort](src/algorithms/sorting/merge-sort)
  * `B` [Quicksort](src/algorithms/sorting/quick-sort) - implementações in-place e não in-place
  * `B` [Shellsort](src/algorithms/sorting/shell-sort)
  * `B` [Counting Sort](src/algorithms/sorting/counting-sort)
  * `B` [Radix Sort](src/algorithms/sorting/radix-sort)
  * `B` [Bucket Sort](src/algorithms/sorting/bucket-sort)
* **Listas Encadeadas**
  * `B` [Percurso Direto](src/algorithms/linked-list/traversal)
  * `B` [Percurso Reverso](src/algorithms/linked-list/reverse-traversal)
* **Árvores**
  * `B` [Busca em Profundidade](src/algorithms/tree/depth-first-search) (DFS)
  * `B` [Busca em Largura](src/algorithms/tree/breadth-first-search) (BFS)
* **Grafos**
  * `B` [Busca em Profundidade](src/algorithms/graph/depth-first-search) (DFS)
  * `B` [Busca em Largura](src/algorithms/graph/breadth-first-search) (BFS)
  * `B` [Algoritmo de Kruskal](src/algorithms/graph/kruskal) - encontra a Árvore Geradora Mínima (MST) para grafo não direcionado e ponderado
  * `A` [Algoritmo de Dijkstra](src/algorithms/graph/dijkstra) - encontra o menor caminho de um vértice para todos os outros
  * `A` [Algoritmo de Bellman-Ford](src/algorithms/graph/bellman-ford) - encontra o menor caminho de um vértice para todos os outros
  * `A` [Algoritmo de Floyd-Warshall](src/algorithms/graph/floyd-warshall) - encontra os menores caminhos entre todos os pares de vértices
  * `A` [Detecção de Ciclo](src/algorithms/graph/detect-cycle) - para grafos direcionados e não direcionados (versões com DFS e Conjuntos Disjuntos)
  * `A` [Algoritmo de Prim](src/algorithms/graph/prim) - encontra a Árvore Geradora Mínima (MST) para grafo não direcionado e ponderado
  * `A` [Ordenação Topológica](src/algorithms/graph/topological-sorting) - método DFS
  * `A` [Pontos de Articulação](src/algorithms/graph/articulation-points) - algoritmo de Tarjan (baseado em DFS)
  * `A` [Pontes](src/algorithms/graph/bridges) - algoritmo baseado em DFS
  * `A` [Caminho Euleriano e Circuito Euleriano](src/algorithms/graph/eulerian-path) - algoritmo de Fleury - visita cada aresta exatamente uma vez
  * `A` [Ciclo Hamiltoniano](src/algorithms/graph/hamiltonian-cycle) - visita cada vértice exatamente uma vez
  * `A` [Componentes Fortemente Conexos](src/algorithms/graph/strongly-connected-components) - algoritmo de Kosaraju
  * `A` [Problema do Caixeiro Viajante](src/algorithms/graph/travelling-salesman) - menor rota possível que visita cada cidade e retorna à origem
* **Criptografia**
  * `B` [Hash Polinomial](src/algorithms/cryptography/polynomial-hash) - função hash "rolling" baseada em polinômios
  * `B` [Cifra da Cerca de Trilhos](src/algorithms/cryptography/rail-fence-cipher) - cifra por transposição para codificação de mensagens
  * `B` [Cifra de César](src/algorithms/cryptography/caesar-cipher) - cifra de substituição simples
  * `B` [Cifra de Hill](src/algorithms/cryptography/hill-cipher) - cifra de substituição baseada em álgebra linear
* **Aprendizado de Máquina**
  * `B` [NanoNeuron](https://github.com/trekhleb/nano-neuron) - 7 funções JS simples que ilustram como máquinas podem aprender (propagação direta/retropropagação)
  * `B` [k-NN](src/algorithms/ml/knn) - algoritmo de classificação k-vizinhos mais próximos
  * `B` [k-Means](src/algorithms/ml/k-means) - algoritmo de agrupamento k-means
* **Processamento de Imagens**
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving) - redimensionamento de imagens sensível ao conteúdo
* **Estatística**
  * `B` [Aleatório Ponderado](src/algorithms/statistics/weighted-random) - seleciona item aleatório baseado nos pesos
* **Algoritmos Evolutivos**
  * `A` [Algoritmo Genético](https://github.com/trekhleb/self-parking-car-evolution) - exemplo de aplicação do algoritmo genético para treinar carros autônomos
* **Não Categorizados**
  * `B` [Torre de Hanói](src/algorithms/uncategorized/hanoi-tower)
  * `B` [Rotação de Matriz Quadrada](src/algorithms/uncategorized/square-matrix-rotation) - algoritmo in-place
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game) - exemplos de backtracking, programação dinâmica (top-down + bottom-up) e ganancioso
  * `B` [Caminhos Únicos](src/algorithms/uncategorized/unique-paths) - exemplos com backtracking, programação dinâmica e Triângulo de Pascal
  * `B` [Terraços de Chuva](src/algorithms/uncategorized/rain-terraces) - problema de retenção de água (versões por programação dinâmica e força bruta)
  * `B` [Escada Recursiva](src/algorithms/uncategorized/recursive-staircase) - contar o número de maneiras de chegar ao topo (4 soluções)
  * `B` [Melhor Momento Para Comprar e Vender Ações](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - exemplos de divisão e conquista e passagem única
  * `B` [Parênteses Válidos](src/algorithms/stack/valid-parentheses) - verifica se uma string possui parênteses válidos (usando pilha)
  * `A` [Problema das N-Rainhas](src/algorithms/uncategorized/n-queens)
  * `A` [Passeio do Cavalo](src/algorithms/uncategorized/knight-tour)

### Algoritmos por Paradigma

Um paradigma algorítmico é um método ou abordagem genérica que fundamenta o design de uma classe
de algoritmos. É uma abstração acima da noção de algoritmo, assim como um
algoritmo é uma abstração acima de um programa de computador.

* **Força Bruta** - avalia todas as possibilidades e seleciona a melhor solução
  * `B` [Busca Linear](src/algorithms/search/linear-search)
  * `B` [Terraços de Chuva](src/algorithms/uncategorized/rain-terraces) - problema de retenção de água
  * `B` [Escada Recursiva](src/algorithms/uncategorized/recursive-staircase) - conta o número de maneiras de chegar ao topo
  * `A` [Subarray Máximo](src/algorithms/sets/maximum-subarray)
  * `A` [Problema do Caixeiro Viajante](src/algorithms/graph/travelling-salesman) - menor rota possível que visita cada cidade e retorna à origem
  * `A` [Transformada Discreta de Fourier](src/algorithms/math/fourier-transform) - decompõe uma função do tempo (um sinal) nas frequências que a compõem
* **Ganancioso (Greedy)** - escolhe a melhor opção no momento atual, sem considerar o futuro
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `A` [Problema da Mochila Sem Limite](src/algorithms/sets/knapsack-problem)
  * `A` [Algoritmo de Dijkstra](src/algorithms/graph/dijkstra) - encontra o menor caminho para todos os vértices do grafo
  * `A` [Algoritmo de Prim](src/algorithms/graph/prim) - encontra a Árvore Geradora Mínima (MST)
  * `A` [Algoritmo de Kruskal](src/algorithms/graph/kruskal) - encontra a Árvore Geradora Mínima (MST)
* **Divisão e Conquista** - divide o problema em partes menores e resolve cada uma delas
  * `B` [Busca Binária](src/algorithms/search/binary-search)
  * `B` [Torre de Hanói](src/algorithms/uncategorized/hanoi-tower)
  * `B` [Triângulo de Pascal](src/algorithms/math/pascal-triangle)
  * `B` [Algoritmo de Euclides](src/algorithms/math/euclidean-algorithm) - calcular o MDC
  * `B` [Merge Sort](src/algorithms/sorting/merge-sort)
  * `B` [Quicksort](src/algorithms/sorting/quick-sort)
  * `B` [Busca em Profundidade em Árvores](src/algorithms/tree/depth-first-search) (DFS)
  * `B` [Busca em Profundidade em Grafos](src/algorithms/graph/depth-first-search) (DFS)
  * `B` [Matrizes](src/algorithms/math/matrix) - geração e percurso de matrizes de diferentes formatos
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `B` [Exponenciação Rápida](src/algorithms/math/fast-powering)
  * `B` [Melhor Momento Para Comprar e Vender Ações](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - exemplos de divisão e conquista e passagem única
  * `A` [Permutações](src/algorithms/sets/permutations) (com e sem repetição)
  * `A` [Combinações](src/algorithms/sets/combinations) (com e sem repetição)
  * `A` [Subarray Máximo](src/algorithms/sets/maximum-subarray)
* **Programação Dinâmica** - constrói uma solução utilizando sub-soluções previamente encontradas
  * `B` [Número de Fibonacci](src/algorithms/math/fibonacci)
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `B` [Caminhos Únicos](src/algorithms/uncategorized/unique-paths)
  * `B` [Terraços de Chuva](src/algorithms/uncategorized/rain-terraces) - problema de retenção de água
  * `B` [Escada Recursiva](src/algorithms/uncategorized/recursive-staircase) - conta o número de maneiras de chegar ao topo
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving) - redimensionamento de imagens sensível ao conteúdo
  * `A` [Distância de Levenshtein](src/algorithms/string/levenshtein-distance) - distância mínima de edição entre duas sequências
  * `A` [Subsequência Comum Mais Longa](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [Substring Comum Mais Longa](src/algorithms/string/longest-common-substring)
  * `A` [Subsequência Crescente Mais Longa](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [Supersequência Comum Mais Curta](src/algorithms/sets/shortest-common-supersequence)
  * `A` [Problema da Mochila 0/1](src/algorithms/sets/knapsack-problem)
  * `A` [Partição de Inteiro](src/algorithms/math/integer-partition)
  * `A` [Subarray Máximo](src/algorithms/sets/maximum-subarray)
  * `A` [Algoritmo de Bellman-Ford](src/algorithms/graph/bellman-ford) - encontra o menor caminho para todos os vértices do grafo
  * `A` [Algoritmo de Floyd-Warshall](src/algorithms/graph/floyd-warshall) - encontra os menores caminhos entre todos os pares de vértices
  * `A` [Casamento de Expressão Regular](src/algorithms/string/regular-expression-matching)
* **Backtracking** - semelhante à força bruta, tenta gerar todas as soluções possíveis, mas a cada vez que gera uma próxima solução, testa
se ela satisfaz todas as condições e só então continua. Caso contrário, retrocede e segue outro caminho para encontrar uma solução. Normalmente, a travessia DFS do espaço de estados é utilizada.
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `B` [Caminhos Únicos](src/algorithms/uncategorized/unique-paths)
  * `B` [Conjunto Potência](src/algorithms/sets/power-set) - todos os subconjuntos de um conjunto
  * `A` [Ciclo Hamiltoniano](src/algorithms/graph/hamiltonian-cycle) - visita cada vértice exatamente uma vez
  * `A` [Problema das N-Rainhas](src/algorithms/uncategorized/n-queens)
  * `A` [Passeio do Cavalo](src/algorithms/uncategorized/knight-tour)
  * `A` [Combinação de Soma](src/algorithms/sets/combination-sum) - encontra todas as combinações que formam uma soma específica
* **Branch & Bound** - lembra a solução de menor custo encontrada em cada estágio da busca por backtracking,
e usa o custo da solução de menor custo encontrada até então como um limite inferior para descartar soluções parciais com custos maiores. Normalmente, BFS em combinação com DFS do espaço de estados é utilizado.

## Como usar este repositório

**Instale todas as dependências**

```
npm install
```

**Execute o ESLint**

Você pode executá-lo para verificar a qualidade do código.

```
npm run lint
```

**Execute todos os testes**

```
npm test
```

**Execute testes por nome**

```
npm test -- 'LinkedList'
```

**Solução de Problemas**

Se o lint ou os testes falharem, tente deletar a pasta `node_modules` e reinstalar os pacotes npm:

```
rm -rf ./node_modules
npm i
```

Além disso, certifique-se de estar usando a versão correta do Node (`>=16`). Se estiver usando o [nvm](https://github.com/nvm-sh/nvm) para gerenciamento de versões do Node, você pode rodar `nvm use` na raiz do projeto para selecionar a versão correta.

**Playground**

Você pode brincar com estruturas de dados e algoritmos no arquivo `./src/playground/playground.js` e escrever
testes para ele em `./src/playground/__test__/playground.test.js`.

Depois, basta rodar o comando a seguir para testar se seu código no playground está funcionando como esperado:

```
npm test -- 'playground'
```

## Informações Úteis

### Referências

- [▶ Estruturas de Dados e Algoritmos no YouTube](https://www.youtube.com/playlist?list=PLLXdhg_r2hKA7DPDsunoDZ-Z769jWn4R8)
- [✍🏻 Esboços de Estruturas de Dados](https://okso.app/showcase/data-structures)

### Notação Big O

*A notação Big O* é usada para classificar algoritmos de acordo com o crescimento do tempo de execução ou do uso de memória à medida que o tamanho da entrada aumenta.
No gráfico abaixo, você pode ver as ordens de crescimento mais comuns especificadas em notação Big O.

![Big O graphs](./assets/big-o-graph.png)

Fonte: [Big O Cheat Sheet](http://bigocheatsheet.com/).

Abaixo está a lista de algumas das notações Big O mais usadas e suas comparações de desempenho para diferentes tamanhos de entrada.

| Notação Big O  | Tipo         | Cálculos para 10 elementos | Cálculos para 100 elementos | Cálculos para 1000 elementos   |
| -------------- | ------------ | -------------------------- | --------------------------- | ------------------------------ |
| **O(1)**       | Constante    | 1                          | 1                           | 1                              |
| **O(log N)**   | Logarítmico  | 3                          | 6                           | 9                              |
| **O(N)**       | Linear       | 10                         | 100                         | 1000                           |
| **O(N log N)** | n log(n)     | 30                         | 600                         | 9000                           |
| **O(N^2)**     | Quadrático   | 100                        | 10000                       | 1000000                        |
| **O(2^N)**     | Exponencial  | 1024                       | 1.26e+29                    | 1.07e+301                      |
| **O(N!)**      | Fatorial     | 3628800                    | 9.3e+157                    | 4.02e+2567                     |

### Complexidade das Operações das Estruturas de Dados

| Estrutura de Dados       | Acesso  | Busca   | Inserção | Remoção  | Observações  |
| ------------------------ | :-----: | :-----: | :------: | :------: | :----------- |
| **Array**                | 1       | n       | n        | n        |              |
| **Pilha (Stack)**        | n       | n       | 1        | 1        |              |
| **Fila (Queue)**         | n       | n       | 1        | 1        |              |
| **Lista Encadeada**      | n       | n       | 1        | n        |              |
| **Tabela Hash**          | -       | n       | n        | n        | Com função hash perfeita, o custo seria O(1) |
| **Árvore Binária de Busca** | n    | n       | n        | n        | Se a árvore estiver balanceada, o custo é O(log(n)) |
| **B-Tree**               | log(n)  | log(n)  | log(n)   | log(n)   |              |
| **Árvore Rubro-Negra**   | log(n)  | log(n)  | log(n)   | log(n)   |              |
| **Árvore AVL**           | log(n)  | log(n)  | log(n)   | log(n)   |              |
| **Filtro de Bloom**      | -       | 1       | 1        | -        | Possibilidade de falso positivo na busca |

### Complexidade dos Algoritmos de Ordenação de Arrays

| Nome                  | Melhor          | Médio               | Pior                | Memória   | Estável   | Observações  |
| --------------------- | :-------------: | :-----------------: | :-----------------: | :-------: | :-------: | :----------- |
| **Bubble sort**       | n               | n<sup>2</sup>       | n<sup>2</sup>       | 1         | Sim       |              |
| **Insertion sort**    | n               | n<sup>2</sup>       | n<sup>2</sup>       | 1         | Sim       |              |
| **Selection sort**    | n<sup>2</sup>   | n<sup>2</sup>       | n<sup>2</sup>       | 1         | Não       |              |
| **Heap sort**         | n&nbsp;log(n)   | n&nbsp;log(n)       | n&nbsp;log(n)       | 1         | Não       |              |
| **Merge sort**        | n&nbsp;log(n)   | n&nbsp;log(n)       | n&nbsp;log(n)       | n         | Sim       |              |
| **Quick sort**        | n&nbsp;log(n)   | n&nbsp;log(n)       | n<sup>2</sup>       | log(n)    | Não       | Normalmente feito in-place com espaço O(log(n)) na pilha |
| **Shell sort**        | n&nbsp;log(n)   | depende da sequência de gaps | n&nbsp;(log(n))<sup>2</sup> | 1 | Não   |              |
| **Counting sort**     | n + r           | n + r               | n + r               | n + r     | Sim       | r - maior número no array |
| **Radix sort**        | n * k           | n * k               | n * k               | n + k     | Sim       | k - comprimento da maior chave |

## Apoiadores do Projeto

> Você pode apoiar este projeto via ❤️️ [GitHub](https://github.com/sponsors/trekhleb) ou ❤️️ [Patreon](https://www.patreon.com/trekhleb).

[Pessoas que apoiam este projeto](https://github.com/trekhleb/javascript-algorithms/blob/master/BACKERS.md) `∑ = 1`

## Autor

[@trekhleb](https://trekhleb.dev)

Mais alguns [projetos](https://trekhleb.dev/projects/) e [artigos](https://trekhleb.dev/blog/) sobre JavaScript e algoritmos em [trekhleb.dev](https://trekhleb.dev)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---