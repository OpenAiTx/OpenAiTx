[![Star History Chart](https://api.star-history.com/svg?repos=labuladong/fucking-algorithm&type=Date)](https://star-history.com/#labuladong/fucking-algorithm&Date)


영문 버전은 [labuladong.online](https://labuladong.online/algo/en/) 에도 있습니다. 마음껏 즐기세요 :)

# labuladong의 알고리즘 노트

이 저장소에는 총 60편이 넘는 오리지널 글이 담겨 있습니다. 모두 LeetCode 문제를 기반으로 하며, 모든 유형과 기법을 포괄하고 있습니다. 반드시 **응용력을 기르고, 알기 쉽게 설명**하는 것을 목표로 하며, 단순한 코드 나열이 아닙니다. 아래에 목차가 있습니다.

먼저 몇 마디 하겠습니다. **문제풀이를 하면서 푸는 것은 문제지만, 기르는 것은 사고력입니다. 이 저장소의 목적은 바로 이런 알고리즘적 사고를 전달하는 것입니다.** 만약 LeetCode 문제 코드만 모아놓은 저장소를 만든다면, 무슨 소용이 있겠습니까? 풀이 설명도, 사고의 틀도 없이 시간 복잡도만 적어놓는다면, 그건 한눈에 알 수 있는 수준입니다.

정답만 원한다면 아주 쉽습니다. 문제 댓글에 각양각색의 답안이 넘쳐나고, 파이썬 한 줄로 해결하는 신기한 코드가 좋아요를 잔뜩 받습니다. 하지만, 여러분이 알고리즘 문제를 푸는 목적이 프로그래밍 언어의 요령을 배우기 위한 것입니까, 아니면 알고리즘적 사고를 배우기 위한 것입니까? 여러분의 기쁨은 남의 한 줄 코드를 복사해 테스트를 통과하고 문제 수 +1 하는 데서 오는 것입니까, 아니면 논리적 추리와 알고리즘 틀을 바탕으로 답을 직접 만들어내는 데서 오는 것입니까?

온라인에서 항상 누군가 저를 비판합니다. 너무 기초적이라고 하거나, 틀에 의존해서 알고리즘을 배우면 안 된다고 합니다. 하지만 대부분의 사람들은 알고리즘을 직장 준비나 생계를 위해 공부하는 것이지, 대회를 위해서가 아닙니다. 저 역시 수많은 시행착오 끝에 여기까지 왔고, 우리가 원하는 것은 명확하고 실질적인 내용이지, 현학적이거나 모호한 것이 아닙니다.

쉽고 알기 쉽게 만드는 방법을 고민하지 않는다면, 《Introduction to Algorithms》를 칭송만 하다가 남들은 존경만 남기고 포기하게 만들겠습니까?

**어떤 일이든 많이 해보면 패턴이 보입니다. 저는 다양한 알고리즘 패턴과 프레임워크를 정리했으니, 다른 사람들이 시행착오를 덜 겪을 수 있기를 바랍니다.** 저는 완전히 독학으로 이 모든 것을 배운 학생입니다. 1년 동안 문제풀이와 정리를 거쳐, 자신만의 알고리즘 치트시트를 만들었고, 아래에 목차가 있습니다. 여기서 더는 길게 말하지 않겠습니다.

## 학습을 시작하기 전에

**1. 먼저 이 저장소에 star를 눌러주세요. 저의 허영심을 채워주세요.** 글의 퀄리티는 star 하나의 가치를 보장합니다. 계속 새로운 글을 쓸 수 있게 동기부여가 필요하니, 감사합니다.

**2. 제 온라인 사이트를 즐겨찾기 해두세요. 각 글의 시작 부분에 해당 LeetCode 문제 링크가 있어서, 글을 보면서 문제를 풀 수 있습니다. 총 500문제를 손쉽게 풀 수 있습니다.**

2024 최신 주소: https://labuladong.online/algo/

~~GitHub Pages 주소: https://labuladong.online/algo/~~

~~Gitee Pages 주소: https://labuladong.gitee.io/algo/~~

## labuladong 문제풀이 올인원 패키지 소개

### 1. 알고리즘 시각화 패널

제 알고리즘 웹사이트와 모든 부가 플러그인은 하나의 알고리즘 시각화 도구를 통합하고 있습니다. 자료구조 및 재귀 과정을 시각화할 수 있어, 알고리즘 이해의 난이도를 대폭 낮춥니다. 거의 모든 문제 풀이 코드에는 해당 시각화 패널이 있으니, 아래 소개를 참고하세요.

### 2. 학습 웹사이트

내용은 당연히 제 시리즈 알고리즘 강의의 핵심입니다. 모든 강의가 [labuladong.online](https://labuladong.online/algo/) 에 공개되어 있으니, 앞으로 이곳에서 많은 학습 시간을 보내게 될 것입니다. 단순히 즐겨찾기만 해두는 곳이 아닙니다~

![](https://labuladong.github.io/pictures/简介/web_intro1.jpg)

### 3. Chrome 플러그인

**주요 기능**: Chrome 플러그인은 중국어/영어 버전 LeetCode에서 제 「문제풀이」 또는 「아이디어」를 빠르게 볼 수 있으며, 문제와 알고리즘 기법 간의 참조 관계도 추가되어 사이트/공식계정/강의와 연동할 수 있습니다. 가장 부드러운 문제풀이 경험을 제공합니다. 설치 및 사용 설명은 아래 목차를 참고하세요.

![](https://labuladong.github.io/pictures/简介/chrome_intro.jpg)

### 4. vscode 플러그인

**주요 기능**: Chrome 플러그인과 거의 동일하며, vscode에서 문제를 푸는 분들은 이 플러그인을 사용할 수 있습니다. 설치 및 사용 설명은 아래 목차를 참고하세요.

![](https://labuladong.github.io/pictures/简介/vs_intro.jpg)

### 5. Jetbrains 플러그인

**주요 기능**: Chrome 플러그인과 거의 동일하며, Jetbrains 계열 IDE(Pycharm/Intellij/Goland 등)에서 문제를 푸는 분들에게 적합합니다. 설치 및 사용 설명은 아래 목차를 참고하세요.

![](https://labuladong.github.io/pictures/简介/jb_intro.jpg)

마지막으로 모두 즐거운 학습 되시고, 문제의 바다에서 자유롭게 항해하시길 바랍니다!

# 글 목차

<!-- table start -->

### [사이트 소개](https://labuladong.online/algo/home/)

### [부가 플러그인 및 알고리즘 시각화](https://labuladong.online/algo/menu/tools/)
  * [Chrome 문제풀이 플러그인](https://labuladong.online/algo/intro/chrome/)
  * [vscode 문제풀이 플러그인](https://labuladong.online/algo/intro/vscode/)
  * [JetBrains 문제풀이 플러그인](https://labuladong.online/algo/intro/jetbrains/)
  * [알고리즘 시각화 패널 사용법](https://labuladong.online/algo/intro/visualize/)
  * [유료 회원 안내](https://labuladong.online/algo/intro/site-vip/)

### [초보 및 단기속성 학습 플랜](https://labuladong.online/algo/menu/plan/)
  * [알고리즘 문제풀이의 핵심과 함정](https://labuladong.online/algo/intro/how-to-learn-algorithms/)
  * [초보자 학습 플랜](https://labuladong.online/algo/intro/beginner-learning-plan/)
  * [단기속성 학습 플랜](https://labuladong.online/algo/intro/quick-learning-plan/)
  * [연습/복습 방법](https://labuladong.online/algo/intro/how-to-practice/)
  * [알고리즘 시각화 빠른 검색](https://labuladong.online/algo/intro/visualize-catalog/)

### [입문: 프로그래밍 언어 기초 및 실습](https://labuladong.online/algo/menu/)
  * [이 장의 가이드](https://labuladong.online/algo/intro/programming-language-basic/)
  * [C++ 언어 기초](https://labuladong.online/algo/programming-language-basic/cpp/)
  * [Java 언어 기초](https://labuladong.online/algo/programming-language-basic/java/)
  * [Golang 언어 기초](https://labuladong.online/algo/programming-language-basic/golang/)
  * [Python 언어 기초](https://labuladong.online/algo/programming-language-basic/python/)
  * [JavaScript 언어 기초](https://labuladong.online/algo/intro/js/)
  * [LeetCode 문제풀이 안내](https://labuladong.online/algo/intro/leetcode/)
  * [프로그래밍 언어별 문제풀이 실습](https://labuladong.online/algo/programming-language-basic/lc-practice/)

### [기초: 자료구조 및 정렬 심화](https://labuladong.online/algo/menu/quick-start/)
  * [이 장의 가이드](https://labuladong.online/algo/intro/data-structure-basic/)
  * [시간·공간 복잡도 입문](https://labuladong.online/algo/intro/complexity-basic/)

  * [직접 구현하는 동적 배열](https://labuladong.online/algo/menu/dynamic-array/)
    * [배열(순차 저장) 기본 원리](https://labuladong.online/algo/data-structure-basic/array-basic/)
    * [동적 배열 코드 구현](https://labuladong.online/algo/data-structure-basic/array-implement/)

  * [직접 구현하는 단일/이중 연결 리스트](https://labuladong.online/algo/menu/linked-list/)
    * [연결 리스트(연결 저장) 기본 원리](https://labuladong.online/algo/data-structure-basic/linkedlist-basic/)
    * [연결 리스트 코드 구현](https://labuladong.online/algo/data-structure-basic/linkedlist-implement/)

  * [직접 구현하는 큐/스택](https://labuladong.online/algo/menu/queue-stack/)
    * [큐/스택 기본 원리](https://labuladong.online/algo/data-structure-basic/queue-stack-basic/)
    * [연결 리스트로 큐/스택 구현](https://labuladong.online/algo/data-structure-basic/linked-queue-stack/)
    * [환형 배열 기법](https://labuladong.online/algo/data-structure-basic/cycle-array/)
    * [배열로 큐/스택 구현](https://labuladong.online/algo/data-structure-basic/array-queue-stack/)
    * [덱(Deque) 원리 및 구현](https://labuladong.online/algo/data-structure-basic/deque-implement/)

  * [해시테이블 원리 및 구현](https://labuladong.online/algo/menu/)
    * [해시테이블 핵심 원리](https://labuladong.online/algo/data-structure-basic/hashmap-basic/)
    * [체이닝법으로 해시테이블 구현](https://labuladong.online/algo/data-structure-basic/hashtable-chaining/)
    * [선형탐사법의 두 가지 난점](https://labuladong.online/algo/data-structure-basic/linear-probing-key-point/)
    * [선형탐사법 두 가지 코드 구현](https://labuladong.online/algo/data-structure-basic/linear-probing-code/)
    * [해시셋 원리 및 코드 구현](https://labuladong.online/algo/data-structure-basic/hash-set/)

  * [해시테이블 구조의 다양한 변형](https://labuladong.online/algo/menu/)
    * [연결 리스트로 강화된 해시테이블(LinkedHashMap)](https://labuladong.online/algo/data-structure-basic/hashtable-with-linked-list/)
    * [배열로 강화된 해시테이블(ArrayHashMap)](https://labuladong.online/algo/data-structure-basic/hashtable-with-array/)

  * [이진트리 구조 및 순회](https://labuladong.online/algo/menu/binary-tree/)
    * [이진트리 기초 및 주요 유형](https://labuladong.online/algo/data-structure-basic/binary-tree-basic/)
    * [이진트리의 재귀/레벨 순회](https://labuladong.online/algo/data-structure-basic/binary-tree-traverse-basic/)
    * [다진트리의 재귀/레벨 순회](https://labuladong.online/algo/data-structure-basic/n-ary-tree-traverse-basic/)

  * [이진트리 구조의 다양한 확장](https://labuladong.online/algo/menu/binary-tree/)
    * [이진 탐색트리 응용 및 시각화](https://labuladong.online/algo/data-structure-basic/tree-map-basic/)
    * [레드블랙트리의 완벽한 균형 및 시각화](https://labuladong.online/algo/data-structure-basic/rbtree-basic/)
    * [Trie/트라이/접두사트리 원리 및 시각화](https://labuladong.online/algo/data-structure-basic/trie-map-basic/)
    * [이진 힙 핵심 원리 및 시각화](https://labuladong.online/algo/data-structure-basic/binary-heap-basic/)
    * [이진 힙/우선순위 큐 코드 구현](https://labuladong.online/algo/data-structure-basic/binary-heap-implement/)
    * [세그먼트트리 핵심 원리 및 시각화](https://labuladong.online/algo/data-structure-basic/segment-tree-basic/)
    * [업데이트 진행중](https://labuladong.online/algo/intro/updating/)

  * [그래프 이론 자료구조 및 순회](https://labuladong.online/algo/menu/graph-theory/)
    * [그래프 구조 기초 및 범용 코드 구현](https://labuladong.online/algo/data-structure-basic/graph-basic/)
    * [그래프 구조의 DFS/BFS 순회](https://labuladong.online/algo/data-structure-basic/graph-traverse-basic/)
    * [Union Find(유니온파인드) 원리](https://labuladong.online/algo/data-structure-basic/union-find-basic/)
    * [업데이트 진행중](https://labuladong.online/algo/intro/updating/)

  * [10대 정렬 알고리즘 원리 및 시각화](https://labuladong.online/algo/menu/sorting/)
    * [이 장의 가이드](https://labuladong.online/algo/intro/sorting/)
    * [정렬 알고리즘 주요 지표](https://labuladong.online/algo/data-structure-basic/sort-basic/)
    * [선택 정렬의 문제점](https://labuladong.online/algo/data-structure-basic/select-sort/)
    * [안정성이 뛰어난 버블 정렬](https://labuladong.online/algo/data-structure-basic/bubble-sort/)
    * [역발상을 활용한 삽입 정렬](https://labuladong.online/algo/data-structure-basic/insertion-sort/)
    * [O(N^2) 한계를 넘는 셸 정렬](https://labuladong.online/algo/data-structure-basic/shell-sort/)
    * [이진트리 전위 탐색: 퀵 정렬](https://labuladong.online/algo/data-structure-basic/quick-sort/)
    * [이진트리 후위 탐색: 병합 정렬](https://labuladong.online/algo/data-structure-basic/merge-sort/)
    * [이진 힙 구조 활용: 힙 정렬](https://labuladong.online/algo/data-structure-basic/heap-sort/)
    * [새로운 정렬 원리: 계수 정렬](https://labuladong.online/algo/data-structure-basic/counting-sort/)
    * [장점을 모은 버킷 정렬](https://labuladong.online/algo/data-structure-basic/bucket-sort/)
    * [기수 정렬(Radix Sort)](https://labuladong.online/algo/data-structure-basic/radix-sort/)

  * [업데이트 진행중](https://labuladong.online/algo/intro/updating/)


### [제0장, 핵심 문제풀이 프레임워크 총정리](https://labuladong.online/algo/menu/core/)
  * [이 장의 가이드](https://labuladong.online/algo/intro/core-intro/)
  * [자료구조와 알고리즘의 프레임워크 사고](https://labuladong.online/algo/essential-technique/algorithm-summary/)
  * [투포인터 기법으로 7가지 연결 리스트 문제 공략](https://labuladong.online/algo/essential-technique/linked-list-skills-summary/)
  * [투포인터 기법으로 7가지 배열 문제 공략](https://labuladong.online/algo/essential-technique/array-two-pointers-summary/)
  * [슬라이딩 윈도우 알고리즘 핵심 코드 템플릿](https://labuladong.online/algo/essential-technique/sliding-window-framework/)
  * [이진 탐색 알고리즘 핵심 코드 템플릿](https://labuladong.online/algo/essential-technique/binary-search-framework/)
  * [동적 계획법 문제풀이 패턴 프레임워크](https://labuladong.online/algo/essential-technique/dynamic-programming-framework/)
  * [백트래킹 알고리즘 문제풀이 패턴 프레임워크](https://labuladong.online/algo/essential-technique/backtrack-framework/)
  * [BFS 알고리즘 문제풀이 패턴 프레임워크](https://labuladong.online/algo/essential-technique/bfs-framework/)
  * [이진트리 시리즈 알고리즘 핵심 지침](https://labuladong.online/algo/essential-technique/binary-tree-summary/)
  * [백트래킹 알고리즘으로 모든 순열/조합/부분집합 문제 공략](https://labuladong.online/algo/essential-technique/permutation-combination-subset-all-in-one/)
  * [그리디 알고리즘 문제풀이 패턴 프레임워크](https://labuladong.online/algo/essential-technique/greedy/)
  * [분할정복 알고리즘 문제풀이 패턴 프레임워크](https://labuladong.online/algo/essential-technique/divide-and-conquer/)
  * [알고리즘 시간·공간 복잡도 분석 실용 가이드](https://labuladong.online/algo/essential-technique/complexity-analysis/)


### [제1장, 고전 자료구조 알고리즘](https://labuladong.online/algo/menu/ds/)
  * [직접 푸는 연결 리스트 알고리즘](https://labuladong.online/algo/menu/linked-list/)
    * [투포인터 기법으로 7가지 연결 리스트 문제 공략](https://labuladong.online/algo/essential-technique/linked-list-skills-summary/)
    * [【강화연습】연결 리스트 투포인터 고전 문제](https://labuladong.online/algo/problem-set/linkedlist-two-pointers/)
    * [단일 연결 리스트 뒤집기 방법 총정리](https://labuladong.online/algo/data-structure/reverse-linked-list-recursion/)
    * [회문 연결 리스트 판별 방법](https://labuladong.online/algo/data-structure/palindrome-linked-list/)

  * [직접 푸는 배열 알고리즘](https://labuladong.online/algo/menu/array/)
    * [투포인터 기법으로 7가지 배열 문제 공략](https://labuladong.online/algo/essential-technique/array-two-pointers-summary/)
    * [2차원 배열 고급 순회 기법](https://labuladong.online/algo/practice-in-action/2d-array-traversal-summary/)
    * [한 가지 방법으로 nSum 문제 전멸](https://labuladong.online/algo/practice-in-action/nsum/)
    * [【강화연습】배열 투포인터 고전 문제](https://labuladong.online/algo/problem-set/array-two-pointers/)
    * [간결한 알고리즘 팁: prefix sum 배열](https://labuladong.online/algo/data-structure/prefix-sum/)
    * [【강화연습】prefix sum 기법 고전 문제](https://labuladong.online/algo/problem-set/perfix-sum/)
    * [간결한 알고리즘 팁: 차분 배열](https://labuladong.online/algo/data-structure/diff-array/)
    * [슬라이딩 윈도우 알고리즘 핵심 코드 템플릿](https://labuladong.online/algo/essential-technique/sliding-window-framework/)
    * [【강화연습】슬라이딩 윈도우 알고리즘 고전 문제](https://labuladong.online/algo/problem-set/sliding-window/)
    * [슬라이딩 윈도우 확장: Rabin Karp 문자열 매칭 알고리즘](https://labuladong.online/algo/practice-in-action/rabinkarp/)
    * [이진 탐색 알고리즘 핵심 코드 템플릿](https://labuladong.online/algo/essential-technique/binary-search-framework/)
    * [실전 이진 탐색 적용 사고 틀](https://labuladong.online/algo/frequency-interview/binary-search-in-action/)
    * [【강화연습】이진 탐색 알고리즘 고전 문제](https://labuladong.online/algo/problem-set/binary-search/)
    * [가중치가 있는 랜덤 선택 알고리즘](https://labuladong.online/algo/frequency-interview/random-pick-with-weight/)
    * [전략적 선택 알고리즘: 전력경기 문제](https://labuladong.online/algo/practice-in-action/advantage-shuffle/)


  * [직접 푸는 이진트리 알고리즘](https://labuladong.online/algo/menu/binary-tree/)
    * [이진트리 시리즈 알고리즘 핵심 지침](https://labuladong.online/algo/essential-technique/binary-tree-summary/)
    * [이진트리 심법(사고편)](https://labuladong.online/algo/data-structure/binary-tree-part1/)
    * [이진트리 심법(구성편)](https://labuladong.online/algo/data-structure/binary-tree-part2/)
    * [이진트리 심법(후위편)](https://labuladong.online/algo/data-structure/binary-tree-part3/)
    * [이진트리 심법(직렬화편)](https://labuladong.online/algo/data-structure/serialize-and-deserialize-binary-tree/)
    * [이진 탐색트리 심법(특징편)](https://labuladong.online/algo/data-structure/bst-part1/)
    * [이진 탐색트리 심법(기초편)](https://labuladong.online/algo/data-structure/bst-part2/)
    * [이진 탐색트리 심법(구성편)](https://labuladong.online/algo/data-structure/bst-part3/)
    * [이진 탐색트리 심법(후위편)](https://labuladong.online/algo/data-structure/bst-part4/)

  * [템플릿으로 100가지 이진트리 문제 해결](https://labuladong.online/algo/menu/100-bt/)
    * [이 장의 가이드](https://labuladong.online/algo/intro/binary-tree-practice/)
    * [【강화연습】"순회" 사고로 문제풀기 I](https://labuladong.online/algo/problem-set/binary-tree-traverse-i/)
    * [【강화연습】"순회" 사고로 문제풀기 II](https://labuladong.online/algo/problem-set/binary-tree-traverse-ii/)
    * [【강화연습】"순회" 사고로 문제풀기 III](https://labuladong.online/algo/problem-set/binary-tree-traverse-iii/)
    * [【강화연습】"문제 분해" 사고로 문제풀기 I](https://labuladong.online/algo/problem-set/binary-tree-divide-i/)
    * [【강화연습】"문제 분해" 사고로 문제풀기 II](https://labuladong.online/algo/problem-set/binary-tree-divide-ii/)
    * [【강화연습】두 가지 사고를 동시에 적용해 문제풀기](https://labuladong.online/algo/problem-set/binary-tree-combine-two-view/)
    * [【강화연습】후위 위치로 문제풀기 I](https://labuladong.online/algo/problem-set/binary-tree-post-order-i/)
    * [【강화연습】후위 위치로 문제풀기 II](https://labuladong.online/algo/problem-set/binary-tree-post-order-ii/)
    * [【강화연습】후위 위치로 문제풀기 III](https://labuladong.online/algo/problem-set/binary-tree-post-order-iii/)
    * [【강화연습】레벨 순회로 문제풀기 I](https://labuladong.online/algo/problem-set/binary-tree-level-i/)
    * [【강화연습】레벨 순회로 문제풀기 II](https://labuladong.online/algo/problem-set/binary-tree-level-ii/)
    * [【강화연습】이진 탐색트리 고전 문제 I](https://labuladong.online/algo/problem-set/bst1/)
    * [【강화연습】이진 탐색트리 고전 문제 II](https://labuladong.online/algo/problem-set/bst2/)

  * [이진트리의 확장 및 응용](https://labuladong.online/algo/menu/more-bt/)
    * [확장: 최소공통조상(LCA) 문제풀이 프레임워크](https://labuladong.online/algo/practice-in-action/lowest-common-ancestor-summary/)
    * [확장: 완전 이진트리 노드 개수 계산](https://labuladong.online/algo/data-structure/count-complete-tree-nodes/)
    * [확장: 느슨하게 확장하는 다진트리](https://labuladong.online/algo/data-structure/flatten-nested-list-iterator/)
    * [확장: 병합 정렬 상세 설명 및 응용](https://labuladong.online/algo/practice-in-action/merge-sort/)
    * [확장: 퀵 정렬 상세 설명 및 응용](https://labuladong.online/algo/practice-in-action/quick-sort/)
    * [확장: 스택으로 재귀 반복 이진트리 순회](https://labuladong.online/algo/data-structure/iterative-traversal-binary-tree/)

  * [직접 설계하는 자료구조](https://labuladong.online/algo/menu/design/)
    * [큐로 스택 구현 및 스택으로 큐 구현](https://labuladong.online/algo/data-structure/stack-queue/)
    * [【강화연습】스택 고전 문제](https://labuladong.online/algo/problem-set/stack/)
    * [【강화연습】괄호 문제 총정리](https://labuladong.online/algo/problem-set/parentheses/)
    * [【강화연습】큐 고전 문제](https://labuladong.online/algo/problem-set/queue/)
    * [단조 스택 알고리즘 템플릿으로 3가지 예제 문제 공략](https://labuladong.online/algo/data-structure/monotonic-stack/)
    * [【강화연습】단조 스택 다양한 변형 및 고전 문제](https://labuladong.online/algo/problem-set/monotonic-stack/)
    * [단조 큐로 슬라이딩 윈도우 문제 해결](https://labuladong.online/algo/data-structure/monotonic-queue/)
    * [【강화연습】단조 큐 범용 구현 및 고전 문제](https://labuladong.online/algo/problem-set/monotonic-queue/)
    * [알고리즘은 레고처럼: 직접 구현하는 LRU 알고리즘](https://labuladong.online/algo/data-structure/lru-cache/)
    * [알고리즘은 레고처럼: 직접 구현하는 LFU 알고리즘](https://labuladong.online/algo/frequency-interview/lfu/)
    * [상수 시간에 배열의 임의 원소 삭제/탐색](https://labuladong.online/algo/data-structure/random-set/)
    * [【강화연습】해시테이블 추가 문제](https://labuladong.online/algo/problem-set/hash-table/)
    * [【강화연습】우선순위 큐 고전 문제](https://labuladong.online/algo/problem-set/binary-heap/)
    * [TreeMap/TreeSet 코드 구현](https://labuladong.online/algo/data-structure-basic/tree-map-implement/)
    * [SegmentTree 세그먼트트리 코드 구현](https://labuladong.online/algo/data-structure/segment-tree-implement/)
    * [Trie/트라이/접두사트리 코드 구현](https://labuladong.online/algo/data-structure/trie-implement/)
    * [【강화연습】Trie 트리 알고리즘 문제](https://labuladong.online/algo/problem-set/trie/)
    * [타임라인(피드) 기능 설계](https://labuladong.online/algo/data-structure/design-twitter/)
    * [시험장 좌석 배치 알고리즘 설계](https://labuladong.online/algo/frequency-interview/exam-room/)
    * [【강화연습】더 많은 고전 설계 문제](https://labuladong.online/algo/problem-set/ds-design/)
    * [확장: 계산기 구현 방법](https://labuladong.online/algo/data-structure/implement-calculator/)
    * [확장: 이진 힙 2개로 중위수 알고리즘 구현](https://labuladong.online/algo/practice-in-action/find-median-from-data-stream/)
    * [확장: 배열 중복 제거 문제(어려움)](https://labuladong.online/algo/frequency-interview/remove-duplicate-letters/)


  * [직접 푸는 그래프 알고리즘](https://labuladong.online/algo/menu/graph/)
    * [사이클 탐지 및 위상 정렬 알고리즘](https://labuladong.online/algo/data-structure/topological-sort/)
    * [유명인 찾기 문제](https://labuladong.online/algo/frequency-interview/find-celebrity/)
    * [이분 그래프 판별 알고리즘](https://labuladong.online/algo/data-structure/bipartite-graph/)
    * [Union-Find(유니온파인드) 알고리즘](https://labuladong.online/algo/data-structure/union-find/)
    * [【강화연습】유니온파인드 고전 문제](https://labuladong.online/algo/problem-set/union-find/)
    * [Kruskal 최소 신장 트리 알고리즘](https://labuladong.online/algo/data-structure/kruskal/)
    * [Prim 최소 신장 트리 알고리즘](https://labuladong.online/algo/data-structure/prim/)
    * [Dijkstra 알고리즘 템플릿 및 응용](https://labuladong.online/algo/data-structure/dijkstra/)
    * [【강화연습】Dijkstra 알고리즘 고전 문제](https://labuladong.online/algo/problem-set/dijkstra/)

### [제2장, 고전 브루트포스 탐색 알고리즘](https://labuladong.online/algo/menu/braute-force-search/)
  * [DFS/백트래킹 알고리즘](https://labuladong.online/algo/menu/dfs/)
    * [백트래킹 알고리즘 문제풀이 패턴 프레임워크](https://labuladong.online/algo/essential-technique/backtrack-framework/)
    * [백트래킹 실전: 스도쿠와 N퀸 문제](https://labuladong.online/algo/practice-in-action/sudoku-nqueue/)
    * [백트래킹으로 모든 순열/조합/부분집합 문제 공략](https://labuladong.online/algo/essential-technique/permutation-combination-subset-all-in-one/)
    * [공과 상자 모델: 백트래킹의 두 가지 시각](https://labuladong.online/algo/practice-in-action/two-views-of-backtrack/)
    * [백트래킹/DFS 알고리즘 자주 묻는 질문](https://labuladong.online/algo/essential-technique/backtrack-vs-dfs/)
    * [한 글로 모든 섬 문제 공략](https://labuladong.online/algo/frequency-interview/island-dfs-summary/)
    * [백트래킹 실전: 괄호 생성](https://labuladong.online/algo/practice-in-action/generate-parentheses/)
    * [백트래킹 실전: 집합 분할](https://labuladong.online/algo/practice-in-action/partition-to-k-equal-sum-subsets/)
    * [【강화연습】백트래킹 고전 문제 I](https://labuladong.online/algo/problem-set/backtrack-i/)
    * [【강화연습】백트래킹 고전 문제 II](https://labuladong.online/algo/problem-set/backtrack-ii/)
    * [【강화연습】백트래킹 고전 문제 III](https://labuladong.online/algo/problem-set/backtrack-iii/)

  * [BFS 알고리즘](https://labuladong.online/algo/menu/bfs/)
    * [BFS 알고리즘 문제풀이 패턴 프레임워크](https://labuladong.online/algo/essential-technique/bfs-framework/)
    * [【강화연습】BFS 고전 문제 I](https://labuladong.online/algo/problem-set/bfs/)
    * [【강화연습】BFS 고전 문제 II](https://labuladong.online/algo/problem-set/bfs-ii/)
    * [업데이트 진행중](https://labuladong.online/algo/intro/updating/)


### [제3장, 고전 동적 계획법 알고리즘](https://labuladong.online/algo/menu/dp/)
  * [동적 계획법 기본 기법](https://labuladong.online/algo/menu/dp-basic/)
    * [동적 계획법 문제풀이 패턴 프레임워크](https://labuladong.online/algo/essential-technique/dynamic-programming-framework/)
    * [동적 계획법 설계: 최장 증가 부분수열](https://labuladong.online/algo/dynamic-programming/longest-increasing-subsequence/)
    * [base case와 메모이제이션 초기값 설정](https://labuladong.online/algo/dynamic-programming/memo-fundamental/)
    * [동적 계획법의 두 가지 시각](https://labuladong.online/algo/dynamic-programming/two-views-of-dp/)
    * [동적 계획법과 백트래킹 사고 전환](https://labuladong.online/algo/dynamic-programming/word-break/)
    * [동적 계획법 차원 축소](https://labuladong.online/algo/dynamic-programming/space-optimization/)
    * [최적 부분구조 원리 및 dp 배열 순회 방향](https://labuladong.online/algo/dynamic-programming/faq-summary/)

  * [부분수열 유형 문제](https://labuladong.online/algo/menu/subsequence/)
    * [고전 동적 계획법: 편집 거리](https://labuladong.online/algo/dynamic-programming/edit-distance/)
    * [동적 계획법 설계: 최대 부분배열](https://labuladong.online/algo/dynamic-programming/maximum-subarray/)
    * [고전 동적 계획법: 최장 공통 부분수열](https://labuladong.online/algo/dynamic-programming/longest-common-subsequence/)
    * [동적 계획법 부분수열 문제 템플릿](https://labuladong.online/algo/dynamic-programming/subsequence-problem/)

  * [배낭 유형 문제](https://labuladong.online/algo/menu/knapsack/)
    * [고전 동적 계획법: 0-1 배낭 문제](https://labuladong.online/algo/dynamic-programming/knapsack1/)
    * [고전 동적 계획법: 부분집합 배낭 문제](https://labuladong.online/algo/dynamic-programming/knapsack2/)
    * [고전 동적 계획법: 완전 배낭 문제](https://labuladong.online/algo/dynamic-programming/knapsack3/)
    * [배낭 문제 변형: 목표 합](https://labuladong.online/algo/dynamic-programming/target-sum/)

  * [동적 계획법으로 게임 풀기](https://labuladong.online/algo/menu/dp-game/)
    * [동적 계획법: 최소 경로 합](https://labuladong.online/algo/dynamic-programming/minimum-path-sum/)
    * [동적 계획법으로 《마탑》 클리어](https://labuladong.online/algo/dynamic-programming/magic-tower/)
    * [동적 계획법으로 《폴아웃4》 클리어](https://labuladong.online/algo/dynamic-programming/freedom-trail/)
    * [여행비 절약법: 가중치 최단 경로](https://labuladong.online/algo/dynamic-programming/cheap-travel/)
    * [고전 동적 계획법: 정규식 매칭](https://labuladong.online/algo/dynamic-programming/regular-expression-matching/)
    * [고전 동적 계획법: 고층 빌딩에서 달걀 떨어뜨리기](https://labuladong.online/algo/dynamic-programming/egg-drop/)
    * [고전 동적 계획법: 풍선 터뜨리기](https://labuladong.online/algo/dynamic-programming/burst-balloons/)
    * [고전 동적 계획법: 게임 이론 문제](https://labuladong.online/algo/dynamic-programming/game-theory/)
    * [한 가지 방법으로 LeetCode 도둑질 문제 공략](https://labuladong.online/algo/dynamic-programming/house-robber/)
    * [한 가지 방법으로 LeetCode 주식 매매 문제 공략](https://labuladong.online/algo/dynamic-programming/stock-problem-summary/)

  * [그리디 유형 문제](https://labuladong.online/algo/menu/greedy/)
    * [그리디 알고리즘 문제풀이 패턴 프레임워크](https://labuladong.online/algo/essential-technique/greedy/)
    * [운전자 주유 알고리즘](https://labuladong.online/algo/frequency-interview/gas-station-greedy/)
    * [그리디 알고리즘: 구간 스케줄링 문제](https://labuladong.online/algo/frequency-interview/interval-scheduling/)
    * [스캔라인 기법: 회의실 배정](https://labuladong.online/algo/frequency-interview/scan-line-technique/)
    * [동영상을 자르는 그리디 알고리즘](https://labuladong.online/algo/frequency-interview/cut-video/)


### [제4장, 기타 주요 알고리즘 팁](https://labuladong.online/algo/menu/other/)
  * [수학 연산 팁](https://labuladong.online/algo/menu/math/)
    * [한 줄 코드로 풀 수 있는 알고리즘 문제](https://labuladong.online/algo/frequency-interview/one-line-solutions/)
    * [자주 쓰는 비트 연산](https://labuladong.online/algo/frequency-interview/bitwise-operation/)
    * [게임 속 랜덤 알고리즘 이야기](https://labuladong.online/algo/frequency-interview/random-algorithm/)
    * [자주 출제되는 팩토리얼 문제 2개](https://labuladong.online/algo/frequency-interview/factorial-problems/)
    * [소수를 효율적으로 찾는 방법](https://labuladong.online/algo/frequency-interview/print-prime-number/)
    * [효율적인 거듭제곱(mod) 연산](https://labuladong.online/algo/frequency-interview/quick-power/)
    * [누락 및 중복 원소 동시 찾기](https://labuladong.online/algo/frequency-interview/mismatch-set/)
    * [몇 가지 직관에 어긋나는 확률 문제](https://labuladong.online/algo/frequency-interview/probability-problem/)
    * [【강화연습】수학 팁 관련 문제](https://labuladong.online/algo/problem-set/math-tricks/)

  * [고전 면접 문제](https://labuladong.online/algo/menu/interview/)
    * [필기 알고리즘 "점수따기" 팁](https://labuladong.online/algo/other-skills/tips-in-exam/)
    * [빗물받기 문제 효율적 해결법](https://labuladong.online/algo/frequency-interview/trapping-rain-water/)
    * [한 글로 모든 못생긴 수 문제 공략](https://labuladong.online/algo/frequency-interview/ugly-number-summary/)
    * [한 가지 방법으로 3가지 구간 문제 해결](https://labuladong.online/algo/practice-in-action/interval-problem-summary/)
    * [누가 알았겠나, 고스톱도 알고리즘 문제로!](https://labuladong.online/algo/practice-in-action/split-array-into-consecutive-subsequences/)
    * [팬케이크 정렬 알고리즘](https://labuladong.online/algo/frequency-interview/pancake-sorting/)
    * [문자열 곱셈 계산](https://labuladong.online/algo/practice-in-action/multiply-strings/)
    * [완벽한 직사각형 판별법](https://labuladong.online/algo/frequency-interview/perfect-rectangle/)

### [부록](https://labuladong.online/algo/menu/appendix/)
  * [labuladong.online 업데이트 로그](https://labuladong.online/algo/changelog/website/)
  * [시각화 패널 업데이트 로그](https://labuladong.online/algo/changelog/visualize/)
  * [Chrome 문제풀이 플러그인 업데이트 로그](https://labuladong.online/algo/changelog/chrome/)
  * [vscode 문제풀이 플러그인 업데이트 로그](https://labuladong.online/algo/changelog/vscode/)
  * [Jetbrain 문제풀이 플러그인 업데이트 로그](https://labuladong.online/algo/changelog/jetbrain/)
  * [웹사이트/플러그인 버그 리포트](https://labuladong.online/algo/intro/bug-report/)

<!-- table end -->

# 아래의 분들께 번역에 감사드립니다

닉네임 알파벳 순서대로:

[ABCpril](https://github.com/ABCpril), 
[andavid](https://github.com/andavid), 
[bryceustc](https://github.com/bryceustc), 
[build2645](https://github.com/build2645), 
[CarrieOn](https://github.com/CarrieOn), 
[cooker](https://github.com/xiaochuhub), 
[Dong Wang](https://github.com/Coder2Programmer), 
[ExcaliburEX](https://github.com/ExcaliburEX), 
[floatLig](https://github.com/floatLig), 
[ForeverSolar](https://github.com/foreversolar), 
[Fulin Li](https://fulinli.github.io/), 
[Funnyyanne](https://github.com/Funnyyanne), 
[GYHHAHA](https://github.com/GYHHAHA), 
[Hi_archer](https://hiarcher.top/), 
[Iruze](https://github.com/Iruze), 
[Jieyixia](https://github.com/Jieyixia), 
[Justin](https://github.com/Justin-YGG), 
[Kevin](https://github.com/Kevin-free), 
[Lrc123](https://github.com/Lrc123), 
[lriy](https://github.com/lriy), 
[Lyjeeq](https://github.com/Lyjeeq), 
[MasonShu](https://greenwichmt.github.io/), 
[Master-cai](https://github.com/Master-cai), 
[miaoxiaozui2017](https://github.com/miaoxiaozui2017), 
[natsunoyoru97](https://github.com/natsunoyoru97), 
[nettee](https://github.com/nettee), 
[PaperJets](https://github.com/PaperJets), 
[qy-yang](https://github.com/qy-yang), 
[realism0331](https://github.com/realism0331), 
[SCUhzs](https://github.com/brucecat), 
[Seaworth](https://github.com/Seaworth), 
[shazi4399](https://github.com/shazi4399), 
[ShuozheLi](https://github.com/ShuoZheLi/), 
[sinjoywong](https://blog.csdn.net/SinjoyWong), 
[sunqiuming526](https://github.com/sunqiuming526), 
[Tianhao Zhou](https://github.com/tianhaoz95), 
[timmmGZ](https://github.com/timmmGZ), 
[tommytim0515](https://github.com/tommytim0515), 
[ucsk](https://github.com/ucsk), 
[wadegrc](https://github.com/wadegrc), 
[walsvid](https://github.com/walsvid), 
[warmingkkk](https://github.com/warmingkkk), 
[Wonderxie](https://github.com/Wonderxie), 
[wsyzxxxx](https://github.com/wsyzxxxx), 
[xiaodp](https://github.com/xiaodp), 
[youyun](https://github.com/youyun), 
[yx-tan](https://github.com/yx-tan), 
[Zero](https://github.com/Mr2er0), 
[Ziming](https://github.com/ML-ZimingMeng/LeetCode-Python3)

# 후원하기

이 저장소가 도움이 되었다면, 저자에게 인스턴트 커피 한 잔을 선물해 주세요.

<img src="pictures/pay.jpg" width = "200" align=center />

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---