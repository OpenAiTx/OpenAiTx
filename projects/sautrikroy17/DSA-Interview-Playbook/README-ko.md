# 🚀 80/20 DSA 인터뷰 플레이북

이것은 500개의 무작위 문제 리스트가 아닙니다. 이것은 상위 기술 회사들(마이크로소프트, 아마존, 구글, 메타, 애플)이 실제 기술 면접에서 테스트하는 정확한 데이터 구조 및 알고리즘 패턴을 **엄선하고, 불필요한 내용 없이** 모은 컬렉션입니다.

---

## 🛑 1단계: 핵심 기초 (먼저 이것을 하세요)

LeetCode 문제 풀이를 시작하기 전에, 핵심 논리와 데이터 구조 기초가 탄탄한지 확인해야 합니다. 기초 논리가 약하면 실제 면접에서 이런 패턴을 인식하는 데 어려움을 겪게 됩니다.

아래 패턴에 뛰어들기 전에, 마이크로소프트의 공식 100% 무료 개발자 교육 허브를 통해 핵심 논리를 복습하는 것을 **강력히 권장**합니다.

👉 **[마이크로소프트 공식 개발자 교육 허브 접속하기 (DSA 기초 및 논리)](https://learn.microsoft.com/training/?wt.mc_id=studentamb_514816)**

*(기초가 약하다면 이 단계를 건너뛰지 마세요. 상위 기업들은 LeetCode 해법 암기 능력보다 근본적인 논리를 더 중요하게 생각합니다.)*

---

## 🧠 2단계: 핵심 DSA 패턴 (80/20 법칙)

### 1. 슬라이딩 윈도우
*   [최대 평균 부분배열 I](https://leetcode.com/problems/maximum-average-subarray-i/) (쉬움)
*   [반복 없는 가장 긴 부분 문자열](https://leetcode.com/problems/longest-substring-without-repeating-characters/) (중간)
*   [가장 긴 반복 문자 교체](https://leetcode.com/problems/longest-repeating-character-replacement/) (중간)
*   [최대 연속 1의 개수 III](https://leetcode.com/problems/max-consecutive-ones-iii/) (중간)
*   [과일 바구니](https://leetcode.com/problems/fruit-into-baskets/) (중간)
*   [최소 윈도우 부분 문자열](https://leetcode.com/problems/minimum-window-substring/) (어려움)
*   [슬라이딩 윈도우 최대값](https://leetcode.com/problems/sliding-window-maximum/) (어려움)

### 2. 두 포인터
*   [유효한 팰린드롬](https://leetcode.com/problems/valid-palindrome/) (쉬움)
*   [두 수 합 II - 입력 배열 정렬됨](https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/) (중간)
*   [정렬된 배열에서 중복 제거](https://leetcode.com/problems/remove-duplicates-from-sorted-array/) (쉬움)
*   [3합](https://leetcode.com/problems/3sum/) (중간)
*   [4합](https://leetcode.com/problems/4sum/) (중간)
*   [가장 많은 물을 담을 수 있는 용기](https://leetcode.com/problems/container-with-most-water/) (중간)
*   [색깔 정렬](https://leetcode.com/problems/sort-colors/) (중간)
*   [빗물 트래핑](https://leetcode.com/problems/trapping-rain-water/) (어려움)

### 3. 빠른 & 느린 포인터
*   [연결 리스트 사이클](https://leetcode.com/problems/linked-list-cycle/) (쉬움)
*   [연결 리스트의 중간 노드](https://leetcode.com/problems/middle-of-the-linked-list/) (쉬움)
*   [팰린드롬 연결 리스트](https://leetcode.com/problems/palindrome-linked-list/) (쉬움)
*   [중복 숫자 찾기](https://leetcode.com/problems/find-the-duplicate-number/) (보통)
*   [연결 리스트 사이클 II](https://leetcode.com/problems/linked-list-cycle-ii/) (보통)
*   [리스트 재정렬](https://leetcode.com/problems/reorder-list/) (보통)

### 4. 구간 합치기
*   [구간 합치기](https://leetcode.com/problems/merge-intervals/) (보통)
*   [구간 삽입](https://leetcode.com/problems/insert-interval/) (보통)
*   [겹치지 않는 구간](https://leetcode.com/problems/non-overlapping-intervals/) (보통)
*   [회의실](https://leetcode.com/problems/meeting-rooms/) (쉬움) *(프리미엄)*
*   [회의실 II](https://leetcode.com/problems/meeting-rooms-ii/) (보통) *(프리미엄)*
*   [풍선 터뜨리는 최소 화살 개수](https://leetcode.com/problems/minimum-number-of-arrows-to-burst-balloons/) (보통)

### 5. 이진 탐색 (변형)
*   [이진 탐색](https://leetcode.com/problems/binary-search/) (쉬움)
*   [삽입 위치 찾기](https://leetcode.com/problems/search-insert-position/) (쉬움)
*   [정렬된 배열에서 원소의 첫 번째와 마지막 위치 찾기](https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/) (보통)
*   [회전된 정렬 배열에서 탐색](https://leetcode.com/problems/search-in-rotated-sorted-array/) (보통)
*   [회전된 정렬 배열에서 최솟값 찾기](https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/) (보통)
*   [2차원 행렬 탐색](https://leetcode.com/problems/search-a-2d-matrix/) (보통)
*   [코코의 바나나 먹기](https://leetcode.com/problems/koko-eating-bananas/) (보통)

---

## 🌳 단계 3: 고급 자료구조

### 6. 트리 / 그래프 BFS
*   [이진 트리 레벨 순회](https://leetcode.com/problems/binary-tree-level-order-traversal/) (보통)
*   [이진 트리 오른쪽 시야](https://leetcode.com/problems/binary-tree-right-side-view/) (보통)
*   [이진 트리 지그재그 레벨 순회](https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/) (보통)
*   [썩은 오렌지](https://leetcode.com/problems/rotting-oranges/) (보통)
*   [각 노드의 다음 오른쪽 포인터 채우기](https://leetcode.com/problems/populating-next-right-pointers-in-each-node/) (보통)
*   [단어 사다리](https://leetcode.com/problems/word-ladder/) (어려움)

### 7. 트리 / 그래프 DFS
*   [이진 트리 최대 깊이](https://leetcode.com/problems/maximum-depth-of-binary-tree/) (쉬움)
*   [이진 트리 뒤집기](https://leetcode.com/problems/invert-binary-tree/) (쉬움)
*   [이진 트리 지름](https://leetcode.com/problems/diameter-of-binary-tree/) (쉬움)
*   [이진 트리의 최저 공통 조상](https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/) (중간)
*   [섬의 개수](https://leetcode.com/problems/number-of-islands/) (중간)
*   [섬의 최대 면적](https://leetcode.com/problems/max-area-of-island/) (중간)
*   [강의 계획서](https://leetcode.com/problems/course-schedule/) (중간)
*   [강의 계획서 II](https://leetcode.com/problems/course-schedule-ii/) (중간)

### 8. 부분 집합 / 백트래킹
*   [부분 집합](https://leetcode.com/problems/subsets/) (중간)
*   [부분 집합 II](https://leetcode.com/problems/subsets-ii/) (중간)
*   [순열](https://leetcode.com/problems/permutations/) (중간)
*   [조합 합](https://leetcode.com/problems/combination-sum/) (중간)
*   [단어 찾기](https://leetcode.com/problems/word-search/) (중간)
*   [팰린드롬 분할](https://leetcode.com/problems/palindrome-partitioning/) (중간)
*   [N-퀸](https://leetcode.com/problems/n-queens/) (어려움)

### 9. 상위 K개 요소 (힙)
*   [배열에서 K번째 큰 요소](https://leetcode.com/problems/kth-largest-element-in-an-array/) (중간)
*   [가장 자주 등장하는 상위 K개 요소](https://leetcode.com/problems/top-k-frequent-elements/) (중간)
*   [원점에 가장 가까운 K개 점](https://leetcode.com/problems/k-closest-points-to-origin/) (중간)
*   [K개의 정렬된 리스트 병합](https://leetcode.com/problems/merge-k-sorted-lists/) (어려움)
*   [데이터 스트림에서 중앙값 찾기](https://leetcode.com/problems/find-median-from-data-stream/) (어려움)

### 10. 동적 계획법 (1D & 2D)
*   [계단 오르기](https://leetcode.com/problems/climbing-stairs/) (쉬움)
*   [최소 비용 계단 오르기](https://leetcode.com/problems/min-cost-climbing-stairs/) (쉬움)
*   [도둑질 문제](https://leetcode.com/problems/house-robber/) (중간)
*   [동전 교환](https://leetcode.com/problems/coin-change/) (중간)
*   [최장 증가 부분 수열](https://leetcode.com/problems/longest-increasing-subsequence/) (중간)
*   [최장 공통 부분 수열](https://leetcode.com/problems/longest-common-subsequence/) (중간)
*   [유일한 경로](https://leetcode.com/problems/unique-paths/) (중간)
*   [단어 분할](https://leetcode.com/problems/word-break/) (중간)

---
*이 저장소를 즐겨찾기에 추가하고 친구들과 공유하여 면접 준비에 도움을 주세요! 행운을 빕니다.*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-05

---