[![pypardiso-tests](https://github.com/haasad/PyPardisoProject/actions/workflows/tests.yaml/badge.svg?branch=master)](https://github.com/haasad/PyPardisoProject/actions/workflows/tests.yaml)
# PyPardiso

PyPardiso는 [Intel oneAPI Math Kernel Library PARDISO 솔버](https://www.intel.com/content/www/us/en/develop/documentation/onemkl-developer-reference-fortran/top/sparse-solver-routines/onemkl-pardiso-parallel-direct-sparse-solver-iface.html)를 사용하여 대규모 희소 선형 방정식 시스템을 해결하는 파이썬 패키지입니다. 이 솔버는 공유 메모리 멀티프로세싱 병렬 직접 희소 솔버입니다.

PyPardiso는 희소 선형 시스템 `Ax=b`를 푸는 SciPy의 [scipy.sparse.linalg.spsolve](https://docs.scipy.org/doc/scipy/reference/generated/scipy.sparse.linalg.spsolve.html#scipy.sparse.linalg.spsolve)와 동일한 기능을 제공합니다. 그러나 많은 경우 SciPy 내장 단일 스레드 SuperLU 솔버보다 훨씬 빠릅니다.

PyPardiso는 [PARDISO 7.2 솔버 프로젝트](https://www.pardiso-project.org/)의 PARDISO 솔버에 대한 파이썬 인터페이스가 아니며, 현재 복소수를 지원하지 않습니다. 이러한 고급 용도의 경우 [JuliaSparse/Pardiso.jl](https://github.com/JuliaSparse/Pardiso.jl/)을 확인하십시오. macOS 사용자의 경우 Apple 실리콘에서 MKL을 사용할 수 없으므로 대안으로 [scikit-umfpack](https://github.com/scikit-umfpack/scikit-umfpack)을 권장합니다.

## 설치

PyPardiso는 Linux와 Windows에서 실행됩니다. __conda__ 또는 __pip__로 설치할 수 있습니다. 가상 환경을 사용하여 PyPardiso를 설치하는 것이 권장됩니다.

conda-forge | PyPI
:---:|:---:
[![conda-forge version](https://anaconda.org/conda-forge/pypardiso/badges/version.svg)](https://anaconda.org/conda-forge/pypardiso) | [![PyPI version](https://badge.fury.io/py/pypardiso.svg)](https://pypi.org/project/pypardiso/)
`conda install -c conda-forge pypardiso` | `pip install pypardiso`


## 기본 사용법

`A`가 CSR(또는 CSC) 형식의 정방 희소 행렬이고 `b`가 벡터(또는 행렬)일 때, 희소 선형 시스템 `Ax=b`에서 `x`를 푸는 방법:
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