# 빅트리 파이썬 패키지

파이썬용 트리 구현 및 메서드로, 리스트, 딕셔너리, 판다스 및 폴라스 DataFrame과 통합되어 있습니다.

파이써닉하게 설계되어 배우기 쉽고 다양한 워크플로우에 확장 가능합니다.

----

관련 링크:
- [문서](https://bigtree.readthedocs.io/)
- [GitHub](https://github.com/kayjan/bigtree/)
- 커뮤니티
  - [이슈](https://github.com/kayjan/bigtree/issues)
  / [토론](https://github.com/kayjan/bigtree/discussions)
  / [변경 로그](https://github.com/kayjan/bigtree/blob/master/CHANGELOG.md)
  / [기여하기](https://bigtree.readthedocs.io/stable/home/contributing/)
- 패키지
  - [PyPI](https://pypi.org/project/bigtree/)
  / [Conda](https://anaconda.org/conda-forge/bigtree)
- 기사
  - [BigTree와 함께하는 파이썬 트리 구현](https://medium.com/data-science/python-tree-implementation-with-bigtree-13cdabd77adc#245a-94ae81f0b3f1)
  - [Reingold Tilford 알고리즘 설명 및 워크스루](https://medium.com/data-science/reingold-tilford-algorithm-explained-with-walkthrough-be5810e8ed93?sk=2db8e10398cee76c486c4b06b0b33322)
- <div><p>빅트리를 지원하고 싶다면, <a href="https://www.buymeacoffee.com/kayjan"><img src="https://img.shields.io/badge/Buy_Me_A_Coffee-FFDD00?style=for-the-badge&logo=buy-me-a-coffee&logoColor=black" alt="Buy Me a Coffee" style="vertical-align:middle"></a></p></div>

-----

## 구성 요소
빅트리는 트리, 이진 트리, 방향성 비순환 그래프(DAG) 구현으로 구성된 3개의 세그먼트가 있습니다.

**트리** 구현에는 12개의 주요 구성 요소가 있습니다.

1. [**🌺 노드**](https://bigtree.readthedocs.io/stable/bigtree/node/node/)
   1. ``BaseNode``, 확장 가능한 클래스
   2. ``Node``, 노드 이름 속성이 있는 BaseNode
2. [**🎄 트리**](https://bigtree.readthedocs.io/stable/bigtree/tree/tree/)
   1. ``Tree``, ``Node``를 감싸는 래퍼로 전체 트리 구조를 구축, 반복, 쿼리 및 내보내기 위한 고수준 API 제공
3. [**✨ 트리 구성**](https://bigtree.readthedocs.io/stable/bigtree/tree/construct/)
   1. `Node`에서 부모 및 자식 생성자를 사용하여 생성
   2. *문자열*에서 트리 표시 또는 Newick 문자열 표기법 사용
   3. *리스트*에서 경로나 부모-자식 튜플 사용하여 생성
   4. *중첩 사전*에서, 경로-속성 키-값 쌍 또는 재귀 구조를 사용하여
   5. *pandas DataFrame*에서, 경로나 부모-자식 열을 사용하여
   6. *polars DataFrame*에서, 경로나 부모-자식 열을 사용하여
   7. *인터랙티브 UI*에서
   8. 경로 문자열을 사용하여 기존 트리에 노드 추가
   9. 경로를 사용하여 *사전*, *pandas DataFrame* 또는 *polars DataFrame*으로 기존 트리에 노드 및 속성 추가
   10. 노드 이름을 사용하여 *사전*, *pandas DataFrame* 또는 *polars DataFrame*으로 기존 트리에 속성만 추가
4. [**➰ 트리 순회하기**](https://bigtree.readthedocs.io/stable/bigtree/utils/iterators/)
   1. 전위 순회
   2. 후위 순회
   3. 레벨 순회
   4. 레벨 그룹 순회
   5. 지그재그 순회
   6. 지그재그 그룹 순회
5. [**🧩 트리 파싱하기**](https://bigtree.readthedocs.io/stable/bigtree/tree/parsing/)
   1. 노드 간 공통 조상 찾기
   2. 한 노드에서 다른 노드로 가는 경로 찾기
6. [**📝 트리 수정하기**](https://bigtree.readthedocs.io/stable/bigtree/tree/modify/)
   1. 노드를 위치에서 목적지로 복사하기
   2. 노드를 위치에서 목적지로 이동하기
   3. 노드를 위치에서 목적지로 이동 및 교체하기
   4. 한 트리에서 다른 트리로 노드 복사하기
   5. 한 트리에서 다른 트리로 노드 복사 및 교체하기
7. [**📌 트리 쿼리하기**](https://bigtree.readthedocs.io/stable/bigtree/tree/query/)
   1. 트리 쿼리 언어를 사용하여 트리 필터링하기
8. [**🔍 트리 검색**](https://bigtree.readthedocs.io/stable/bigtree/tree/search/)
   1. 이름, 부분 경로, 상대 경로, 속성 값, 사용자 정의 조건을 기반으로 여러 노드 찾기
   2. 이름, 부분 경로, 상대 경로, 전체 경로, 속성 값, 사용자 정의 조건을 기반으로 단일 노드 찾기
   3. 사용자 정의 조건을 기반으로 여러 자식 노드 찾기
   4. 이름, 사용자 정의 조건을 기반으로 단일 자식 노드 찾기
9. [**🔧 헬퍼 함수**](https://bigtree.readthedocs.io/stable/bigtree/tree/helper/)
   1. 트리를 다른 `Node` 타입으로 복제하기
   2. 서브트리 가져오기 (다른 루트를 가진 작은 트리)
   3. 트리 가지치기 (같은 루트를 가진 작은 트리)
   4. 두 트리 간 차이점 가져오기
10. [**📊 트리 플로팅**](https://bigtree.readthedocs.io/stable/bigtree/utils/plot/)
   1. 트리 구조의 (x, y) 좌표를 가져오기 위한 향상된 Reingold Tilford 알고리즘
   2. matplotlib을 사용하여 트리 플로팅하기 (선택적 의존성)
11. [**🔨 트리 내보내기**](https://bigtree.readthedocs.io/stable/bigtree/tree/export/)
   1. 수직 또는 수평 방향으로 콘솔에 출력하기
   2. *Newick 문자열 표기법*, *사전*, *중첩 사전*, *pandas DataFrame*, 또는 *polars DataFrame*으로 내보내기  
   3. 트리를 *dot*으로 내보내기 (.dot, .png, .svg, .jpeg 파일로 저장 가능)  
   4. 트리를 *Pillow*로 내보내기 (.png, .jpg로 저장 가능)  
   5. 트리를 *Mermaid Flowchart*로 내보내기 (.md에서 표시 가능)  
   6. 트리를 *Pyvis Network*로 내보내기 (인터랙티브 .html에서 표시 가능)  
12. [**✔️ 워크플로우**](https://bigtree.readthedocs.io/stable/bigtree/workflows/app_todo)  
   1. 트리 시연을 위한 샘플 워크플로우!  

--------  

**이진 트리(Binary Tree)** 구현을 위해 4가지 주요 구성 요소가 있습니다.  
Binary Node는 Node를 상속하므로, Tree 구현의 구성 요소들도 이진 트리에서 사용할 수 있습니다.  

1. [**🌿 노드(Node)**](https://bigtree.readthedocs.io/stable/bigtree/node/binarynode)  
   1. ``BinaryNode``, 이진 트리 규칙을 가진 노드  
2. [**🎄 이진 트리(Binary Tree)**](https://bigtree.readthedocs.io/stable/bigtree/binarytree/binarytree/)  
   1. ``BinaryTree``, ``BinaryNode``를 감싸는 래퍼로 전체 트리 구조를 구축, 순회, 조회, 내보내기 위한 고수준 API 제공  
3. [**✨ 이진 트리 구성하기**](https://bigtree.readthedocs.io/stable/bigtree/binarytree/construct/)  
   1. *리스트*에서 평탄화된 리스트 구조를 사용하여 생성  
4. [**➰ 이진 트리 순회하기**](https://bigtree.readthedocs.io/stable/bigtree/utils/iterators/)  
   1. 중위 순회(In-Order Traversal)  

-----  

**방향성 비순환 그래프(Directed Acyclic Graph, DAG)** 구현을 위해 6가지 주요 구성 요소가 있습니다.  

1. [**🌼 노드(Node)**](https://bigtree.readthedocs.io/stable/bigtree/node/dagnode/)  
   1. ``DAGNode``, 방향성 비순환 그래프(DAG) 구축을 위한 확장 가능한 클래스  
2. [**🎄 DAG**](https://bigtree.readthedocs.io/stable/bigtree/dag/dag/)  
   1. ``DAG``, ``DAGNode``를 감싸는 래퍼로 전체 DAG를 구축, 내보내기, 순회하기 위한 고수준 API 제공  
3. [**✨ DAG 구성하기**](https://bigtree.readthedocs.io/stable/bigtree/dag/construct/)  
   1. 부모-자식 튜플을 포함하는 *리스트*에서 생성  
   2. *중첩 사전*에서 생성  
   3. *pandas DataFrame*에서 생성  
4. [**➰ DAG 순회하기**](https://bigtree.readthedocs.io/stable/bigtree/utils/iterators/)  
   1. 일반적인 순회 방법  
5. [**🧩 DAG 구문 분석하기**](https://bigtree.readthedocs.io/stable/bigtree/dag/parsing/)  
   1. 한 노드에서 다른 노드로 가는 가능한 경로 얻기  
6. [**🔨 DAG 내보내기**](https://bigtree.readthedocs.io/stable/bigtree/dag/export/)  
   1. *리스트*, *사전*, 또는 *pandas DataFrame*으로 내보내기  
   2. DAG를 *dot* 형식으로 내보내기 (.dot, .png, .svg, .jpeg 파일로 저장 가능)

-----

## 설치

`bigtree`는 Python 3.10 이상이 필요합니다. `bigtree`를 설치하는 방법은 pip(권장) 또는 conda 두 가지가 있습니다.

### a) pip로 설치하기

#### 기본 설치

`bigtree`를 설치하려면 명령 프롬프트에서 다음 명령어를 실행하세요:

```console
$ pip install bigtree
```
#### 선택적 종속성 설치

`bigtree`에는 여러 선택적 종속성이 있으며, "extras" 구문을 사용하여 설치할 수 있습니다.


```console
$ pip install 'bigtree[extra_1, extra_2]'
```
추가 패키지의 예는 다음과 같습니다:

- `all`: 모든 선택적 종속성 포함
- `image`: 트리를 이미지로 내보내기 위해
- `matplotlib`: 트리 플로팅을 위해
- `pandas`: pandas 메서드를 위해
- `polars`: polars 메서드를 위해
- `query`: 트리 쿼리 메서드를 위해
- `vis`: pyvis 시각화를 위해

`image` 추가 종속성의 경우, 더 많은 플러그인을 설치해야 할 수 있습니다.


```console
$ brew install gprof2dot  # for MacOS
$ conda install graphviz  # for Windows
```

### b) conda를 사용한 설치

`bigtree`를 conda로 설치하려면, 명령 프롬프트에서 다음 줄을 실행하세요:

```console
$ conda install -c conda-forge bigtree
```

-----

## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=kayjan/bigtree&type=Date)](https://star-history.com/#kayjan/bigtree&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-16

---