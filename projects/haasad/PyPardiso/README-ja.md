[![pypardiso-tests](https://github.com/haasad/PyPardisoProject/actions/workflows/tests.yaml/badge.svg?branch=master)](https://github.com/haasad/PyPardisoProject/actions/workflows/tests.yaml)
# PyPardiso

PyPardisoは、[Intel oneAPI Math Kernel Library PARDISOソルバー](https://www.intel.com/content/www/us/en/develop/documentation/onemkl-developer-reference-fortran/top/sparse-solver-routines/onemkl-pardiso-parallel-direct-sparse-solver-iface.html)を用いて、大規模な疎線形方程式系を解くためのPythonパッケージです。これは共有メモリマルチプロセッシング並列直接疎ソルバーです。

PyPardisoは、疎線形系 `Ax=b` を解くためのSciPyの[scipy.sparse.linalg.spsolve](https://docs.scipy.org/doc/scipy/reference/generated/scipy.sparse.linalg.spsolve.html#scipy.sparse.linalg.spsolve)と同様の機能を提供します。ただし、多くの場合、SciPyの組み込みの単一スレッドのSuperLUソルバーよりも大幅に高速です。

PyPardisoは、[PARDISO 7.2 Solver Project](https://www.pardiso-project.org/)のPARDISOソルバーのPythonインターフェースではなく、現在複素数には対応していません。これらのより高度なユースケースには[JuliaSparse/Pardiso.jl](https://github.com/JuliaSparse/Pardiso.jl/)を参照してください。macOSユーザーには、Appleシリコン上でMKLが利用できないため、代替の高速ソルバーとして[scikit-umfpack](https://github.com/scikit-umfpack/scikit-umfpack)を推奨します。

## インストール

PyPardisoはLinuxおよびWindowsで動作します。__conda__または__pip__でインストール可能です。仮想環境を使用してPyPardisoをインストールすることを推奨します。

conda-forge | PyPI
:---:|:---:
[![conda-forge version](https://anaconda.org/conda-forge/pypardiso/badges/version.svg)](https://anaconda.org/conda-forge/pypardiso) | [![PyPI version](https://badge.fury.io/py/pypardiso.svg)](https://pypi.org/project/pypardiso/)
`conda install -c conda-forge pypardiso` | `pip install pypardiso`


## 基本的な使い方

`A` がCSR（またはCSC）形式の正方疎行列で、`b` がベクトル（または行列）のとき、疎線形系 `Ax=b` を `x` について解く方法：
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