# Paquete Big Tree para Python

Implementación de Árbol y Métodos para Python, integrado con listas, diccionarios, pandas y DataFrame de polars.

Es pythonico, lo que facilita su aprendizaje y es extensible a muchos tipos de flujos de trabajo.

----

Enlaces Relacionados:
- [Documentación](https://bigtree.readthedocs.io/)
- [GitHub](https://github.com/kayjan/bigtree/)
- Comunidad
  - [Issues](https://github.com/kayjan/bigtree/issues)
  / [Discussions](https://github.com/kayjan/bigtree/discussions)
  / [Changelog](https://github.com/kayjan/bigtree/blob/master/CHANGELOG.md)
  / [Contributing](https://bigtree.readthedocs.io/stable/home/contributing/)
- Paquete
  - [PyPI](https://pypi.org/project/bigtree/)
  / [Conda](https://anaconda.org/conda-forge/bigtree)
- Artículos
  - [Implementación de Árbol en Python con BigTree](https://medium.com/data-science/python-tree-implementation-with-bigtree-13cdabd77adc#245a-94ae81f0b3f1)
  - [El Algoritmo Reingold Tilford Explicado, con Ejemplo](https://medium.com/data-science/reingold-tilford-algorithm-explained-with-walkthrough-be5810e8ed93?sk=2db8e10398cee76c486c4b06b0b33322)
- <div><p>Si quieres apoyar bigtree, <a href="https://www.buymeacoffee.com/kayjan"><img src="https://img.shields.io/badge/Buy_Me_A_Coffee-FFDD00?style=for-the-badge&logo=buy-me-a-coffee&logoColor=black" alt="Buy Me a Coffee" style="vertical-align:middle"></a></p></div>

-----

## Componentes
Big Tree consta de 3 segmentos que incluyen la implementación de Árbol, Árbol Binario y Grafo Acíclico Dirigido (DAG).

Para la implementación de **Árbol**, hay 12 componentes principales.

1. [**🌺 Nodo**](https://bigtree.readthedocs.io/stable/bigtree/node/node/)
   1. ``BaseNode``, clase extensible
   2. ``Node``, BaseNode con atributo de nombre de nodo
2. [**🎄 Árbol**](https://bigtree.readthedocs.io/stable/bigtree/tree/tree/)
   1. ``Tree``, envoltorio alrededor de ``Node``, que proporciona APIs de alto nivel para construir, iterar, consultar y exportar toda la estructura del árbol
3. [**✨ Construcción del Árbol**](https://bigtree.readthedocs.io/stable/bigtree/tree/construct/)
   1. Desde `Node`, usando constructores de padre e hijos
   2. Desde *str*, usando visualización de árbol o notación en cadena Newick
   3. Desde *list*, usando rutas o tuplas padre-hijo
   4. Desde *diccionario anidado*, usando pares clave-valor de atributos de ruta o estructura recursiva
   5. Desde *pandas DataFrame*, usando rutas o columnas padre-hijo
   6. Desde *polars DataFrame*, usando rutas o columnas padre-hijo
   7. Desde *interfaz de usuario interactiva*
   8. Agregar nodos al árbol existente usando cadena de ruta
   9. Agregar nodos y atributos al árbol existente usando *diccionario*, *pandas DataFrame* o *polars DataFrame*, usando ruta
   10. Agregar solo atributos al árbol existente usando *diccionario*, *pandas DataFrame* o *polars DataFrame*, usando nombre del nodo
4. [**➰ Recorrido del Árbol**](https://bigtree.readthedocs.io/stable/bigtree/utils/iterators/)
   1. Recorrido Preorden
   2. Recorrido Postorden
   3. Recorrido por Niveles
   4. Recorrido por Grupos de Niveles
   5. Recorrido ZigZag
   6. Recorrido por Grupos ZigZag
5. [**🧩 Análisis del Árbol**](https://bigtree.readthedocs.io/stable/bigtree/tree/parsing/)
   1. Obtener ancestros comunes entre nodos
   2. Obtener ruta de un nodo a otro nodo
6. [**📝 Modificación del Árbol**](https://bigtree.readthedocs.io/stable/bigtree/tree/modify/)
   1. Copiar nodos de una ubicación a otra
   2. Mover nodos de una ubicación a otra
   3. Mover y reemplazar nodos de una ubicación a otra
   4. Copiar nodos de un árbol a otro
   5. Copiar y reemplazar nodos de un árbol a otro
7. [**📌 Consulta del Árbol**](https://bigtree.readthedocs.io/stable/bigtree/tree/query/)
   1. Filtrar árbol usando Lenguaje de Consulta de Árbol
8. [**🔍 Búsqueda en el Árbol**](https://bigtree.readthedocs.io/stable/bigtree/tree/search/)
   1. Encontrar múltiples nodos basados en nombre, ruta parcial, ruta relativa, valor de atributo, condición definida por el usuario
   2. Encontrar un solo nodo basado en nombre, ruta parcial, ruta relativa, ruta completa, valor de atributo, condición definida por el usuario
   3. Encontrar múltiples nodos hijos basados en condición definida por el usuario
   4. Encontrar un solo nodo hijo basado en nombre, condición definida por el usuario
9. [**🔧 Funciones Auxiliares**](https://bigtree.readthedocs.io/stable/bigtree/tree/helper/)
   1. Clonar árbol a otro tipo `Node`
   2. Obtener subárbol (árbol más pequeño con raíz diferente)
   3. Podar árbol (árbol más pequeño con misma raíz)
   4. Obtener diferencias entre dos árboles
10. [**📊 Graficar Árbol**](https://bigtree.readthedocs.io/stable/bigtree/utils/plot/)
   1. Algoritmo Reingold Tilford mejorado para obtener coordenadas (x, y) para una estructura de árbol
   2. Graficar árbol usando matplotlib (dependencia opcional)
11. [**🔨 Exportar Árbol**](https://bigtree.readthedocs.io/stable/bigtree/tree/export/)
   1. Imprimir en consola, en orientación vertical u horizontal
   2. Exportar a *notación de cadena Newick*, *diccionario*, *diccionario anidado*, *DataFrame de pandas* o *DataFrame de polars*
   3. Exportar árbol a *dot* (puede guardar en archivos .dot, .png, .svg, .jpeg)
   4. Exportar árbol a *Pillow* (puede guardar en .png, .jpg)
   5. Exportar árbol a *Mermaid Flowchart* (puede mostrarse en .md)
   6. Exportar árbol a *Pyvis Network* (puede mostrarse interactivo en .html)
12. [**✔️ Flujos de trabajo**](https://bigtree.readthedocs.io/stable/bigtree/workflows/app_todo)
   1. ¡Ejemplos de flujos de trabajo para demostración de árboles!

--------

Para la implementación de **Árbol Binario**, hay 4 componentes principales.
El Nodo Binario hereda de Nodo, por lo que los componentes en la implementación de Árbol también están disponibles en Árbol Binario.

1. [**🌿 Nodo**](https://bigtree.readthedocs.io/stable/bigtree/node/binarynode)
   1. ``BinaryNode``, Nodo con reglas de árbol binario
2. [**🎄 Árbol Binario**](https://bigtree.readthedocs.io/stable/bigtree/binarytree/binarytree/)
   1. ``BinaryTree``, envoltorio alrededor de ``BinaryNode``, que proporciona APIs de alto nivel para construir, iterar, consultar y exportar toda la estructura del árbol
3. [**✨ Construcción de Árbol Binario**](https://bigtree.readthedocs.io/stable/bigtree/binarytree/construct/)
   1. Desde *lista*, usando estructura de lista aplanada
4. [**➰ Recorrido de Árbol Binario**](https://bigtree.readthedocs.io/stable/bigtree/utils/iterators/)
   1. Recorrido In-Order

-----

Para la implementación de **Grafo Acíclico Dirigido (DAG)**, hay 6 componentes principales.

1. [**🌼 Nodo**](https://bigtree.readthedocs.io/stable/bigtree/node/dagnode/)
   1. ``DAGNode``, clase extensible para construir Grafos Acíclicos Dirigidos (DAG)
2. [**🎄 DAG**](https://bigtree.readthedocs.io/stable/bigtree/dag/dag/)
   1. ``DAG``, envoltorio alrededor de ``DAGNode``, que proporciona APIs de alto nivel para construir, exportar e iterar todo el DAG
3. [**✨ Construcción de DAG**](https://bigtree.readthedocs.io/stable/bigtree/dag/construct/)
   1. Desde *lista*, que contiene tuplas padre-hijo
   2. Desde *diccionario anidado*
   3. Desde *DataFrame de pandas*
4. [**➰ Recorrido de DAG**](https://bigtree.readthedocs.io/stable/bigtree/utils/iterators/)
   1. Método genérico de recorrido
5. [**🧩 Análisis de DAG**](https://bigtree.readthedocs.io/stable/bigtree/dag/parsing/)
   1. Obtener posibles rutas desde un nodo a otro nodo
6. [**🔨 Exportación de DAG**](https://bigtree.readthedocs.io/stable/bigtree/dag/export/)
   1. Exportar a *lista*, *diccionario* o *DataFrame de pandas*
   2. Exportar DAG a *dot* (puede guardarse en archivos .dot, .png, .svg, .jpeg)

-----

## Instalación

`bigtree` requiere Python 3.10+. Hay dos formas de instalar `bigtree`, con pip (recomendado) o conda.

### a) Instalación con pip

#### Instalación básica

Para instalar `bigtree`, ejecute la siguiente línea en el símbolo del sistema:

```console
$ pip install bigtree
```
#### Instalación de dependencias opcionales

`bigtree` tiene una serie de dependencias opcionales, que se pueden instalar usando la sintaxis de "extras".


```console
$ pip install 'bigtree[extra_1, extra_2]'
```

Ejemplos de paquetes adicionales incluyen:

- `all`: incluye todas las dependencias opcionales
- `image`: para exportar el árbol a imagen
- `matplotlib`: para graficar árboles
- `pandas`: para métodos de pandas
- `polars`: para métodos de polars
- `query`: para métodos de consulta del árbol
- `vis`: para visualización con pyvis

Para la dependencia extra `image`, puede que necesite instalar más complementos.

```console
$ brew install gprof2dot  # for MacOS
$ conda install graphviz  # for Windows
```

### b) Instalación con conda

Para instalar `bigtree` con conda, ejecute la siguiente línea en el símbolo del sistema:

```console
$ conda install -c conda-forge bigtree
```

-----

## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=kayjan/bigtree&type=Date)](https://star-history.com/#kayjan/bigtree&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-16

---