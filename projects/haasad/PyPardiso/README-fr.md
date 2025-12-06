[![pypardiso-tests](https://github.com/haasad/PyPardisoProject/actions/workflows/tests.yaml/badge.svg?branch=master)](https://github.com/haasad/PyPardisoProject/actions/workflows/tests.yaml)
# PyPardiso

PyPardiso est un paquet python pour résoudre de grands systèmes linéaires creux avec le solveur [Intel oneAPI Math Kernel Library PARDISO](https://www.intel.com/content/www/us/en/develop/documentation/onemkl-developer-reference-fortran/top/sparse-solver-routines/onemkl-pardiso-parallel-direct-sparse-solver-iface.html), un solveur direct creux parallèle multiprocesseur en mémoire partagée.

PyPardiso fournit la même fonctionnalité que [scipy.sparse.linalg.spsolve](https://docs.scipy.org/doc/scipy/reference/generated/scipy.sparse.linalg.spsolve.html#scipy.sparse.linalg.spsolve) de SciPy pour résoudre le système linéaire creux `Ax=b`. Cependant, dans de nombreux cas, il est significativement plus rapide que le solveur SuperLU mono-thread intégré à SciPy.

PyPardiso n’est pas une interface python au solveur PARDISO du [PARDISO 7.2 Solver Project](https://www.pardiso-project.org/) et ne prend pas non plus en charge actuellement les nombres complexes. Consultez [JuliaSparse/Pardiso.jl](https://github.com/JuliaSparse/Pardiso.jl/) pour ces cas d’utilisation plus avancés. Pour les utilisateurs macOS, nous recommandons [scikit-umfpack](https://github.com/scikit-umfpack/scikit-umfpack) comme solveur rapide alternatif, car MKL n’est pas disponible sur Apple silicon.

## Installation

PyPardiso fonctionne sous Linux et Windows. Il peut être installé avec __conda__ ou __pip__. Il est recommandé d’installer PyPardiso en utilisant un environnement virtuel.

conda-forge | PyPI
:---:|:---:
[![conda-forge version](https://anaconda.org/conda-forge/pypardiso/badges/version.svg)](https://anaconda.org/conda-forge/pypardiso) | [![PyPI version](https://badge.fury.io/py/pypardiso.svg)](https://pypi.org/project/pypardiso/)
`conda install -c conda-forge pypardiso` | `pip install pypardiso`


## Utilisation basique

Comment résoudre le système linéaire creux `Ax=b` pour `x`, où `A` est une matrice carrée creuse au format CSR (ou CSC) et `b` est un vecteur (ou une matrice) :
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