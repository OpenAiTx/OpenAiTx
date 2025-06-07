# JavaScript 알고리즘과 자료구조

> 🇺🇦 우크라이나가 [러시아 군대의 공격](https://war.ukraine.ua/)을 받고 있습니다. 민간인이 희생되고 있습니다. 주거 지역이 폭격당하고 있습니다.
> - 우크라이나를 도와주세요:
>   - [Serhiy Prytula 자선 재단](https://prytulafoundation.org/en/)
>   - [Come Back Alive 자선 재단](https://savelife.in.ua/en/donate-en/)
>   - [우크라이나 국립은행](https://bank.gov.ua/en/news/all/natsionalniy-bank-vidkriv-spetsrahunok-dlya-zboru-koshtiv-na-potrebi-armiyi)
> - 더 많은 정보: [war.ukraine.ua](https://war.ukraine.ua/) 및 [우크라이나 외교부](https://twitter.com/MFA_Ukraine)

<hr/>

[![CI](https://github.com/trekhleb/javascript-algorithms/workflows/CI/badge.svg)](https://github.com/trekhleb/javascript-algorithms/actions?query=workflow%3ACI+branch%3Amaster)
[![codecov](https://codecov.io/gh/trekhleb/javascript-algorithms/branch/master/graph/badge.svg)](https://codecov.io/gh/trekhleb/javascript-algorithms)
![repo size](https://img.shields.io/github/repo-size/trekhleb/javascript-algorithms.svg)

이 저장소는 JavaScript로 구현된 다양한 인기 알고리즘과 자료구조 예시를 담고 있습니다.

각 알고리즘과 자료구조는 별도의 README를 가지고 있으며, 관련 설명과 더 읽을 수 있는 링크(YouTube 영상 포함)가 있습니다.

_다른 언어로 읽기:_
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

*☝ 이 프로젝트는 학습 및 연구 목적을 위한 것이며, **프로덕션** 용도로 사용되는 것이 아님을 유의하세요.*

## 자료구조

자료구조는 데이터를 효율적으로 접근 및 수정할 수 있도록 컴퓨터 내에 조직하고 저장하는 특정한 방식입니다. 보다 정확히는, 자료구조는 데이터 값의 집합, 이들 간의 관계, 그리고 데이터에 적용할 수 있는 함수나 연산의 집합입니다.

각 자료구조마다 장단점이 있으니, 구현 방법보다 왜 해당 자료구조를 선택하는지에 더 주의를 기울이세요.

`B` - 초급, `A` - 고급

* `B` [연결 리스트](src/data-structures/linked-list)
* `B` [이중 연결 리스트](src/data-structures/doubly-linked-list)
* `B` [큐](src/data-structures/queue)
* `B` [스택](src/data-structures/stack)
* `B` [해시 테이블](src/data-structures/hash-table)
* `B` [힙](src/data-structures/heap) - 최대 힙과 최소 힙 버전
* `B` [우선순위 큐](src/data-structures/priority-queue)
* `A` [트라이](src/data-structures/trie)
* `A` [트리](src/data-structures/tree)
  * `A` [이진 탐색 트리](src/data-structures/tree/binary-search-tree)
  * `A` [AVL 트리](src/data-structures/tree/avl-tree)
  * `A` [레드-블랙 트리](src/data-structures/tree/red-black-tree)
  * `A` [세그먼트 트리](src/data-structures/tree/segment-tree) - min/max/sum 구간 쿼리 예시 포함
  * `A` [펜윅 트리](src/data-structures/tree/fenwick-tree) (이진 인덱스 트리)
* `A` [그래프](src/data-structures/graph) (방향, 무방향 모두)
* `A` [분리 집합](src/data-structures/disjoint-set) - 유니온-파인드 또는 머지-파인드 집합
* `A` [블룸 필터](src/data-structures/bloom-filter)
* `A` [LRU 캐시](src/data-structures/lru-cache/) - 가장 최근에 사용되지 않은(LRU) 캐시

## 알고리즘

알고리즘이란 문제의 한 범주를 해결하는 방법을 명확하게 지정한 것입니다. 즉, 일련의 연산 순서를 정확히 정의하는 규칙들의 집합입니다.

`B` - 초급, `A` - 고급

### 주제별 알고리즘

* **수학**
  * `B` [비트 조작](src/algorithms/math/bits) - 비트 설정/획득/갱신/클리어, 2로 곱셈/나눗셈, 음수 만들기 등
  * `B` [이진 부동소수점](src/algorithms/math/binary-floating-point) - 부동소수점 수의 이진 표현
  * `B` [팩토리얼](src/algorithms/math/factorial)
  * `B` [피보나치 수](src/algorithms/math/fibonacci) - 고전적/닫힌 형태 구현
  * `B` [소인수 분해](src/algorithms/math/prime-factors) - Hardy-Ramanujan의 정리를 이용한 소인수 찾기와 개수 세기
  * `B` [소수 판별](src/algorithms/math/primality-test) (시도 분할법)
  * `B` [유클리드 알고리즘](src/algorithms/math/euclidean-algorithm) - 최대공약수(GCD) 계산
  * `B` [최소공배수](src/algorithms/math/least-common-multiple) (LCM)
  * `B` [에라토스테네스의 체](src/algorithms/math/sieve-of-eratosthenes) - 주어진 한계까지 모든 소수 찾기
  * `B` [2의 거듭제곱 판별](src/algorithms/math/is-power-of-two) - 숫자가 2의 거듭제곱인지 확인 (단순, 비트 연산 방식)
  * `B` [파스칼의 삼각형](src/algorithms/math/pascal-triangle)
  * `B` [복소수](src/algorithms/math/complex-number) - 복소수 및 기본 연산
  * `B` [라디안 & 도](src/algorithms/math/radian) - 라디안과 도 단위 변환
  * `B` [빠른 거듭제곱](src/algorithms/math/fast-powering)
  * `B` [호너 방법](src/algorithms/math/horner-method) - 다항식 평가
  * `B` [행렬](src/algorithms/math/matrix) - 행렬 및 기본 행렬 연산(곱셈, 전치 등)
  * `B` [유클리드 거리](src/algorithms/math/euclidean-distance) - 두 점/벡터/행렬 간 거리
  * `A` [정수 분할](src/algorithms/math/integer-partition)
  * `A` [제곱근](src/algorithms/math/square-root) - 뉴턴 방법
  * `A` [유휘 π 알고리즘](src/algorithms/math/liu-hui) - N각형을 이용한 π 근사
  * `A` [이산 푸리에 변환](src/algorithms/math/fourier-transform) - 시간 함수(신호)를 구성하는 주파수로 분해
* **집합**
  * `B` [데카르트 곱](src/algorithms/sets/cartesian-product) - 여러 집합의 곱
  * `B` [피셔-예이츠 셔플](src/algorithms/sets/fisher-yates) - 유한 시퀀스의 무작위 순열
  * `A` [부분집합의 집합](src/algorithms/sets/power-set) - 집합의 모든 부분집합 (비트, 백트래킹, 계단식 풀이)
  * `A` [순열](src/algorithms/sets/permutations) (중복 포함/미포함)
  * `A` [조합](src/algorithms/sets/combinations) (중복 포함/미포함)
  * `A` [최장 공통 부분수열](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [최장 증가 부분수열](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [최단 공통 수퍼시퀀스](src/algorithms/sets/shortest-common-supersequence) (SCS)
  * `A` [배낭 문제](src/algorithms/sets/knapsack-problem) - "0/1" 및 "무제한" 버전
  * `A` [최대 부분 배열](src/algorithms/sets/maximum-subarray) - "브루트포스" 및 "동적 프로그래밍"(Kadane) 버전
  * `A` [조합 합](src/algorithms/sets/combination-sum) - 특정 합이 되는 모든 조합 찾기
* **문자열**
  * `B` [해밍 거리](src/algorithms/string/hamming-distance) - 서로 다른 기호의 개수
  * `B` [회문](src/algorithms/string/palindrome) - 문자열이 뒤집어서도 동일한지 확인
  * `A` [레벤슈타인 거리](src/algorithms/string/levenshtein-distance) - 두 시퀀스의 최소 편집 거리
  * `A` [KMP 알고리즘](src/algorithms/string/knuth-morris-pratt) - 부분 문자열 검색(패턴 매칭)
  * `A` [Z 알고리즘](src/algorithms/string/z-algorithm) - 부분 문자열 검색(패턴 매칭)
  * `A` [라빈-카프 알고리즘](src/algorithms/string/rabin-karp) - 부분 문자열 검색
  * `A` [최장 공통 부분 문자열](src/algorithms/string/longest-common-substring)
  * `A` [정규표현식 매칭](src/algorithms/string/regular-expression-matching)
* **탐색**
  * `B` [선형 탐색](src/algorithms/search/linear-search)
  * `B` [점프 탐색](src/algorithms/search/jump-search) (블록 탐색) - 정렬된 배열에서 탐색
  * `B` [이진 탐색](src/algorithms/search/binary-search) - 정렬된 배열에서 탐색
  * `B` [보간 탐색](src/algorithms/search/interpolation-search) - 균등 분포된 정렬 배열에서 탐색
* **정렬**
  * `B` [버블 정렬](src/algorithms/sorting/bubble-sort)
  * `B` [선택 정렬](src/algorithms/sorting/selection-sort)
  * `B` [삽입 정렬](src/algorithms/sorting/insertion-sort)
  * `B` [힙 정렬](src/algorithms/sorting/heap-sort)
  * `B` [병합 정렬](src/algorithms/sorting/merge-sort)
  * `B` [퀵 정렬](src/algorithms/sorting/quick-sort) - 제자리/비제자리 구현
  * `B` [셸 정렬](src/algorithms/sorting/shell-sort)
  * `B` [카운팅 정렬](src/algorithms/sorting/counting-sort)
  * `B` [기수 정렬](src/algorithms/sorting/radix-sort)
  * `B` [버킷 정렬](src/algorithms/sorting/bucket-sort)
* **연결 리스트**
  * `B` [순방향 순회](src/algorithms/linked-list/traversal)
  * `B` [역방향 순회](src/algorithms/linked-list/reverse-traversal)
* **트리**
  * `B` [깊이 우선 탐색](src/algorithms/tree/depth-first-search) (DFS)
  * `B` [너비 우선 탐색](src/algorithms/tree/breadth-first-search) (BFS)
* **그래프**
  * `B` [깊이 우선 탐색](src/algorithms/graph/depth-first-search) (DFS)
  * `B` [너비 우선 탐색](src/algorithms/graph/breadth-first-search) (BFS)
  * `B` [크루스칼 알고리즘](src/algorithms/graph/kruskal) - 가중 무방향 그래프의 최소 신장 트리(MST) 찾기
  * `A` [다익스트라 알고리즘](src/algorithms/graph/dijkstra) - 단일 정점에서 모든 정점까지 최단 경로 찾기
  * `A` [벨만-포드 알고리즘](src/algorithms/graph/bellman-ford) - 단일 정점에서 모든 정점까지 최단 경로 찾기
  * `A` [플로이드-워셜 알고리즘](src/algorithms/graph/floyd-warshall) - 모든 정점 쌍 간 최단 경로 찾기
  * `A` [사이클 탐지](src/algorithms/graph/detect-cycle) - 방향/무방향 그래프 모두(DFS, 분리 집합 기반)
  * `A` [프림 알고리즘](src/algorithms/graph/prim) - 가중 무방향 그래프의 최소 신장 트리(MST) 찾기
  * `A` [위상 정렬](src/algorithms/graph/topological-sorting) - DFS 방식
  * `A` [관절점](src/algorithms/graph/articulation-points) - 타잔 알고리즘(DFS 기반)
  * `A` [다리](src/algorithms/graph/bridges) - DFS 기반 알고리즘
  * `A` [오일러 경로/회로](src/algorithms/graph/eulerian-path) - 플뢰리 알고리즘 - 모든 간선 한 번씩 방문
  * `A` [해밀턴 순환](src/algorithms/graph/hamiltonian-cycle) - 모든 정점 한 번씩 방문
  * `A` [강결합 컴포넌트](src/algorithms/graph/strongly-connected-components) - Kosaraju 알고리즘
  * `A` [외판원 문제](src/algorithms/graph/travelling-salesman) - 각 도시를 방문 후 출발 도시로 돌아오는 최단 경로
* **암호화**
  * `B` [다항식 해시](src/algorithms/cryptography/polynomial-hash) - 다항식 기반 롤링 해시 함수
  * `B` [레일 펜스 암호](src/algorithms/cryptography/rail-fence-cipher) - 메시지 인코딩을 위한 전치 암호 알고리즘
  * `B` [카이사르 암호](src/algorithms/cryptography/caesar-cipher) - 간단한 치환 암호
  * `B` [힐 암호](src/algorithms/cryptography/hill-cipher) - 선형대수 기반 치환 암호
* **머신러닝**
  * `B` [NanoNeuron](https://github.com/trekhleb/nano-neuron) - 기계가 실제로 학습하는 방식을 보여주는 7가지 간단한 JS 함수(순전파/역전파)
  * `B` [k-NN](src/algorithms/ml/knn) - k-최근접 이웃 분류 알고리즘
  * `B` [k-평균](src/algorithms/ml/k-means) - k-평균 클러스터링 알고리즘
* **이미지 처리**
  * `B` [심 카빙](src/algorithms/image-processing/seam-carving) - 콘텐츠 인식 이미지 리사이징 알고리즘
* **통계**
  * `B` [가중치 무작위 선택](src/algorithms/statistics/weighted-random) - 항목 가중치에 따른 무작위 선택
* **진화 알고리즘**
  * `A` [유전 알고리즘](https://github.com/trekhleb/self-parking-car-evolution) - 자가주차 자동차 훈련에 유전 알고리즘 적용 예제
* **미분류**
  * `B` [하노이의 탑](src/algorithms/uncategorized/hanoi-tower)
  * `B` [정방행렬 회전](src/algorithms/uncategorized/square-matrix-rotation) - 제자리 알고리즘
  * `B` [점프 게임](src/algorithms/uncategorized/jump-game) - 백트래킹, 동적 프로그래밍(탑다운/바텀업), 그리디 예시
  * `B` [고유 경로](src/algorithms/uncategorized/unique-paths) - 백트래킹, 동적 프로그래밍, 파스칼 삼각형 활용
  * `B` [빗물받이 문제](src/algorithms/uncategorized/rain-terraces) - 빗물 저장 문제(동적 프로그래밍, 브루트포스)
  * `B` [재귀 계단 오르기](src/algorithms/uncategorized/recursive-staircase) - 꼭대기까지 오르는 방법의 수 세기(4가지 방법)
  * `B` [주식 사고팔기 최적 시점](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - 분할정복 및 단일 패스 예시
  * `B` [유효한 괄호](src/algorithms/stack/valid-parentheses) - 스택을 이용한 괄호의 유효성 검사
  * `A` [N-퀸 문제](src/algorithms/uncategorized/n-queens)
  * `A` [나이트의 투어](src/algorithms/uncategorized/knight-tour)

### 패러다임별 알고리즘

알고리즘 패러다임이란 특정 알고리즘 설계의 일반적인 방법 혹은 접근 방식입니다. 이는 알고리즘이라는 추상화보다 더 높은 수준의 추상화입니다.

* **브루트포스** - 모든 경우를 시도하여 최적 해를 찾음
  * `B` [선형 탐색](src/algorithms/search/linear-search)
  * `B` [빗물받이 문제](src/algorithms/uncategorized/rain-terraces)
  * `B` [재귀 계단 오르기](src/algorithms/uncategorized/recursive-staircase)
  * `A` [최대 부분 배열](src/algorithms/sets/maximum-subarray)
  * `A` [외판원 문제](src/algorithms/graph/travelling-salesman)
  * `A` [이산 푸리에 변환](src/algorithms/math/fourier-transform)
* **그리디** - 미래를 고려하지 않고 현재 최선의 선택을 함
  * `B` [점프 게임](src/algorithms/uncategorized/jump-game)
  * `A` [무제한 배낭 문제](src/algorithms/sets/knapsack-problem)
  * `A` [다익스트라 알고리즘](src/algorithms/graph/dijkstra)
  * `A` [프림 알고리즘](src/algorithms/graph/prim)
  * `A` [크루스칼 알고리즘](src/algorithms/graph/kruskal)
* **분할정복** - 문제를 더 작은 부분으로 나누고 각각을 해결
  * `B` [이진 탐색](src/algorithms/search/binary-search)
  * `B` [하노이의 탑](src/algorithms/uncategorized/hanoi-tower)
  * `B` [파스칼의 삼각형](src/algorithms/math/pascal-triangle)
  * `B` [유클리드 알고리즘](src/algorithms/math/euclidean-algorithm)
  * `B` [병합 정렬](src/algorithms/sorting/merge-sort)
  * `B` [퀵 정렬](src/algorithms/sorting/quick-sort)
  * `B` [트리 깊이 우선 탐색](src/algorithms/tree/depth-first-search)
  * `B` [그래프 깊이 우선 탐색](src/algorithms/graph/depth-first-search)
  * `B` [행렬](src/algorithms/math/matrix) - 다양한 형태의 행렬 생성 및 순회
  * `B` [점프 게임](src/algorithms/uncategorized/jump-game)
  * `B` [빠른 거듭제곱](src/algorithms/math/fast-powering)
  * `B` [주식 사고팔기 최적 시점](src/algorithms/uncategorized/best-time-to-buy-sell-stocks)
  * `A` [순열](src/algorithms/sets/permutations)
  * `A` [조합](src/algorithms/sets/combinations)
  * `A` [최대 부분 배열](src/algorithms/sets/maximum-subarray)
* **동적 프로그래밍** - 이전에 찾은 부분해를 이용해 전체 해를 구축
  * `B` [피보나치 수](src/algorithms/math/fibonacci)
  * `B` [점프 게임](src/algorithms/uncategorized/jump-game)
  * `B` [고유 경로](src/algorithms/uncategorized/unique-paths)
  * `B` [빗물받이 문제](src/algorithms/uncategorized/rain-terraces)
  * `B` [재귀 계단 오르기](src/algorithms/uncategorized/recursive-staircase)
  * `B` [심 카빙](src/algorithms/image-processing/seam-carving)
  * `A` [레벤슈타인 거리](src/algorithms/string/levenshtein-distance)
  * `A` [최장 공통 부분수열](src/algorithms/sets/longest-common-subsequence)
  * `A` [최장 공통 부분 문자열](src/algorithms/string/longest-common-substring)
  * `A` [최장 증가 부분수열](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [최단 공통 수퍼시퀀스](src/algorithms/sets/shortest-common-supersequence)
  * `A` [0/1 배낭 문제](src/algorithms/sets/knapsack-problem)
  * `A` [정수 분할](src/algorithms/math/integer-partition)
  * `A` [최대 부분 배열](src/algorithms/sets/maximum-subarray)
  * `A` [벨만-포드 알고리즘](src/algorithms/graph/bellman-ford)
  * `A` [플로이드-워셜 알고리즘](src/algorithms/graph/floyd-warshall)
  * `A` [정규표현식 매칭](src/algorithms/string/regular-expression-matching)
* **백트래킹** - 브루트포스와 유사하지만, 매번 다음 해를 생성할 때 조건을 만족하면 계속 진행하고, 아니면 되돌아가 다른 경로를 탐색. 보통 상태 공간의 DFS 탐색을 사용.
  * `B` [점프 게임](src/algorithms/uncategorized/jump-game)
  * `B` [고유 경로](src/algorithms/uncategorized/unique-paths)
  * `B` [부분집합의 집합](src/algorithms/sets/power-set)
  * `A` [해밀턴 순환](src/algorithms/graph/hamiltonian-cycle)
  * `A` [N-퀸 문제](src/algorithms/uncategorized/n-queens)
  * `A` [나이트의 투어](src/algorithms/uncategorized/knight-tour)
  * `A` [조합 합](src/algorithms/sets/combination-sum)
* **분기 한정** - 백트래킹 과정에서 각 단계에서 찾은 최소 비용 해를 기억하고, 지금까지 찾은 최소 비용 해보다 더 큰 비용의 부분 해는 버림. BFS와 DFS 조합의 상태 공간 트리 탐색을 사용.

## 이 저장소 사용법

**모든 의존성 설치**

```
npm install
```

**ESLint 실행**

코드 품질을 확인하고 싶다면 다음을 실행하세요.

```
npm run lint
```

**모든 테스트 실행**

```
npm test
```

**테스트 이름으로 실행**

```
npm test -- 'LinkedList'
```

**문제 해결**

lint나 테스트에 실패한다면 `node_modules` 폴더를 삭제하고 npm 패키지를 다시 설치해 보세요:

```
rm -rf ./node_modules
npm i
```

또한 Node 버전(`>=16`)을 올바르게 사용하고 있는지 확인하세요. Node 버전 관리를 위해 [nvm](https://github.com/nvm-sh/nvm)을 사용하는 경우 프로젝트 루트 폴더에서 `nvm use`를 실행하면 올바른 버전이 선택됩니다.

**플레이그라운드**

`./src/playground/playground.js` 파일에서 자료구조 및 알고리즘을 실험할 수 있으며, `./src/playground/__test__/playground.test.js`에서 테스트를 작성할 수 있습니다.

이후 다음 명령어로 플레이그라운드 코드가 예상대로 동작하는지 테스트할 수 있습니다:

```
npm test -- 'playground'
```

## 유용한 정보

### 참고 자료

- [▶ YouTube의 자료구조와 알고리즘](https://www.youtube.com/playlist?list=PLLXdhg_r2hKA7DPDsunoDZ-Z769jWn4R8)
- [✍🏻 자료구조 스케치](https://okso.app/showcase/data-structures)

### 빅오 표기법

*빅오 표기법*은 입력 크기가 커짐에 따라 알고리즘의 실행 시간 또는 공간 복잡도가 어떻게 증가하는지 분류하는 데 사용됩니다. 아래 차트는 알고리즘의 가장 일반적인 성장 차수를 빅오 표기법으로 나타낸 것입니다.

![Big O graphs](./assets/big-o-graph.png)

출처: [Big O Cheat Sheet](http://bigocheatsheet.com/).

아래 표는 가장 많이 사용되는 빅오 표기법과 서로 다른 입력 데이터 크기에서의 성능 비교입니다.

| 빅오 표기법 | 유형         | 10개 입력 계산 | 100개 입력 계산 | 1000개 입력 계산  |
| ----------- | ----------- | ------------- | -------------- | ---------------- |
| **O(1)**    | 상수        | 1             | 1              | 1                |
| **O(log N)**| 로그        | 3             | 6              | 9                |
| **O(N)**    | 선형        | 10            | 100            | 1000             |
| **O(N log N)** | n log(n) | 30            | 600            | 9000             |
| **O(N^2)**  | 제곱        | 100           | 10000          | 1000000          |
| **O(2^N)**  | 지수        | 1024          | 1.26e+29       | 1.07e+301        |
| **O(N!)**   | 팩토리얼    | 3628800       | 9.3e+157       | 4.02e+2567       |

### 자료구조 연산 복잡도

| 자료구조             | 접근    | 탐색    | 삽입    | 삭제    | 비고  |
| -------------------- | :-----: | :-----: | :-----: | :-----: | :---- |
| **배열**             | 1       | n       | n       | n       |       |
| **스택**             | n       | n       | 1       | 1       |       |
| **큐**               | n       | n       | 1       | 1       |       |
| **연결 리스트**       | n       | n       | 1       | n       |       |
| **해시 테이블**      | -       | n       | n       | n       | 완벽한 해시 함수일 경우 O(1) |
| **이진 탐색 트리**   | n       | n       | n       | n       | 균형 트리일 경우 O(log(n)) |
| **B-트리**           | log(n)  | log(n)  | log(n)  | log(n)  |       |
| **레드-블랙 트리**   | log(n)  | log(n)  | log(n)  | log(n)  |       |
| **AVL 트리**         | log(n)  | log(n)  | log(n)  | log(n)  |       |
| **블룸 필터**        | -       | 1       | 1       | -       | 탐색 시 false positive 가능 |

### 배열 정렬 알고리즘 복잡도

| 이름                 | 최선            | 평균              | 최악               | 메모리    | 안정성   | 비고  |
| -------------------- | :-------------: | :---------------: | :----------------: | :-------: | :------: | :---- |
| **버블 정렬**        | n               | n<sup>2</sup>     | n<sup>2</sup>      | 1         | 예       |       |
| **삽입 정렬**        | n               | n<sup>2</sup>     | n<sup>2</sup>      | 1         | 예       |       |
| **선택 정렬**        | n<sup>2</sup>   | n<sup>2</sup>     | n<sup>2</sup>      | 1         | 아니오   |       |
| **힙 정렬**          | n&nbsp;log(n)   | n&nbsp;log(n)     | n&nbsp;log(n)      | 1         | 아니오   |       |
| **병합 정렬**        | n&nbsp;log(n)   | n&nbsp;log(n)     | n&nbsp;log(n)      | n         | 예       |       |
| **퀵 정렬**          | n&nbsp;log(n)   | n&nbsp;log(n)     | n<sup>2</sup>      | log(n)    | 아니오   | 일반적으로 제자리 O(log(n)) 스택 공간 사용 |
| **셸 정렬**          | n&nbsp;log(n)   | gap 시퀀스에 따라 다름 | n&nbsp;(log(n))<sup>2</sup> | 1 | 아니오 |       |
| **카운팅 정렬**      | n + r           | n + r             | n + r              | n + r     | 예       | r - 배열 내 최대값 |
| **기수 정렬**        | n * k           | n * k             | n * k              | n + k     | 예       | k - 가장 긴 키 길이 |

## 프로젝트 후원자

> ❤️️ [GitHub](https://github.com/sponsors/trekhleb) 또는 ❤️️ [Patreon](https://www.patreon.com/trekhleb)을 통해 이 프로젝트를 후원할 수 있습니다.

[이 프로젝트를 후원하는 분들](https://github.com/trekhleb/javascript-algorithms/blob/master/BACKERS.md) `∑ = 1`

## 저자

[@trekhleb](https://trekhleb.dev)

[trekhleb.dev](https://trekhleb.dev)에서 JavaScript와 알고리즘에 관한 [프로젝트](https://trekhleb.dev/projects/) 및 [글](https://trekhleb.dev/blog/)도 더 만나보세요.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---