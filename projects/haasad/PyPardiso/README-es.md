[![pypardiso-tests](https://github.com/haasad/PyPardisoProject/actions/workflows/tests.yaml/badge.svg?branch=master)](https://github.com/haasad/PyPardisoProject/actions/workflows/tests.yaml)
# PyPardiso

PyPardiso es un paquete de Python para resolver grandes sistemas lineales dispersos de ecuaciones con el [solucionador PARDISO de Intel oneAPI Math Kernel Library](https://www.intel.com/content/www/us/en/develop/documentation/onemkl-developer-reference-fortran/top/sparse-solver-routines/onemkl-pardiso-parallel-direct-sparse-solver-iface.html), un solucionador directo paralelo disperso de memoria compartida.

PyPardiso proporciona la misma funcionalidad que [scipy.sparse.linalg.spsolve](https://docs.scipy.org/doc/scipy/reference/generated/scipy.sparse.linalg.spsolve.html#scipy.sparse.linalg.spsolve) de SciPy para resolver el sistema lineal disperso `Ax=b`. Sin embargo, en muchos casos es significativamente más rápido que el solucionador SuperLU de un solo hilo incorporado en SciPy.

PyPardiso no es una interfaz de Python para el solucionador PARDISO del [Proyecto PARDISO 7.2 Solver](https://www.pardiso-project.org/) y tampoco soporta actualmente números complejos. Consulte [JuliaSparse/Pardiso.jl](https://github.com/JuliaSparse/Pardiso.jl/) para estos casos de uso más avanzados. Para usuarios de macOS recomendamos [scikit-umfpack](https://github.com/scikit-umfpack/scikit-umfpack) como un solucionador rápido alternativo, ya que MKL no está disponible en Apple silicon.

## Instalación

PyPardiso funciona en Linux y Windows. Se puede instalar con __conda__ o __pip__. Se recomienda instalar PyPardiso usando un entorno virtual.

conda-forge | PyPI
:---:|:---:
[![conda-forge version](https://anaconda.org/conda-forge/pypardiso/badges/version.svg)](https://anaconda.org/conda-forge/pypardiso) | [![PyPI version](https://badge.fury.io/py/pypardiso.svg)](https://pypi.org/project/pypardiso/)
`conda install -c conda-forge pypardiso` | `pip install pypardiso`


## Uso básico

Cómo resolver el sistema lineal disperso `Ax=b` para `x`, donde `A` es una matriz cuadrada, dispersa en formato CSR (o CSC) y `b` es un vector (o matriz):
```python
In [1]: import pypardiso

In [2]: import numpy as np

In [3]: import scipy.sparse as sp

In [4]: A = sp.rand(10, 10, density=0.5, format='csr')

In [5]: A
Out[5]:
<10x10 sparse matrix of type '<class 'numpy.float64'>'
	with 50 stored elements in Compressed Sparse Row format>

In [6]: b = np.random.rand(10)

In [7]: x = pypardiso.spsolve(A, b)

In [8]: x
Out[8]:
array([ 0.02918389,  0.59629935,  0.33407289, -0.48788966,  3.44508841,
        0.52565687, -0.48420646,  0.22136413, -0.95464127,  0.58297397])
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-06

---