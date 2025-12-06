[![pypardiso-tests](https://github.com/haasad/PyPardisoProject/actions/workflows/tests.yaml/badge.svg?branch=master)](https://github.com/haasad/PyPardisoProject/actions/workflows/tests.yaml)
# PyPardiso

PyPardiso 是一个用于使用 [Intel oneAPI 数学核心库 PARDISO 求解器](https://www.intel.com/content/www/us/en/develop/documentation/onemkl-developer-reference-fortran/top/sparse-solver-routines/onemkl-pardiso-parallel-direct-sparse-solver-iface.html) 求解大型稀疏线性方程组的 Python 包，该求解器是一个共享内存多处理器并行直接稀疏求解器。

PyPardiso 提供与 SciPy 的 [scipy.sparse.linalg.spsolve](https://docs.scipy.org/doc/scipy/reference/generated/scipy.sparse.linalg.spsolve.html#scipy.sparse.linalg.spsolve) 相同的功能，用于求解稀疏线性系统 `Ax=b`。然而，在许多情况下，它比 SciPy 内置的单线程 SuperLU 求解器快得多。

PyPardiso 不是来自 [PARDISO 7.2 求解器项目](https://www.pardiso-project.org/) 的 PARDISO 求解器的 Python 接口，目前也不支持复数。有关这些更高级用例，请查看 [JuliaSparse/Pardiso.jl](https://github.com/JuliaSparse/Pardiso.jl/)。对于 macOS 用户，我们推荐使用 [scikit-umfpack](https://github.com/scikit-umfpack/scikit-umfpack) 作为替代的快速求解器，因为 MKL 在 Apple silicon 上不可用。

## 安装

PyPardiso 支持 Linux 和 Windows。可以通过 __conda__ 或 __pip__ 安装。建议使用虚拟环境安装 PyPardiso。

conda-forge | PyPI
:---:|:---:
[![conda-forge version](https://anaconda.org/conda-forge/pypardiso/badges/version.svg)](https://anaconda.org/conda-forge/pypardiso) | [![PyPI version](https://badge.fury.io/py/pypardiso.svg)](https://pypi.org/project/pypardiso/)
`conda install -c conda-forge pypardiso` | `pip install pypardiso`


## 基本用法

如何求解稀疏线性系统 `Ax=b` 中的 `x`，其中 `A` 是 CSR（或 CSC）格式的方阵稀疏矩阵，`b` 是向量（或矩阵）：
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