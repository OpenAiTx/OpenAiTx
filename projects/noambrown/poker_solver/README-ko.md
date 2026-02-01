# 리버 포커 솔버

이 저장소는 노리밋 텍사스 홀덤 리버 서브게임 솔버를 구축하며, 검증을 위해 Kuhn 및 Leduc 포커부터 시작합니다. 핵심 알고리즘에는 CFR, CFR+, 외부 샘플링 MCCFR, 허구적 플레이, DCFR가 포함됩니다. Python은 참조 구현이며, C++는 성능을 목표로 합니다.

## 저장소 구성

- `python/` 참조 구현(알고리즘, 게임, CLI 도구).
- `cpp/` 최적화된 C++ 리버 솔버.

기여자 가이드: `AGENTS.md` 참고.

## 빠른 시작

Python (Kuhn/Leduc):

```sh
PYTHONPATH=python/src python -m cli.run_exploitability --game kuhn --algo cfr
```

파이썬 (river 기본값):

```sh
PYTHONPATH=python/src python -m cli.run_river_exploitability --algo cfr+
```

최적화된 C++ (기본값 리버):

```sh
cmake -S cpp -B cpp/build
cmake --build cpp/build -j
./cpp/build/river_solver_optimized --algo cfr+ --iters 2000
```

## 서브게임 JSON 형식

GUI는 C++ 솔버 모두가 `--config`로 불러올 수 있는 JSON 파일을 내보냅니다. 주요 필드:

```json
{
  "board": ["Ks", "Th", "7s", "4d", "2s"],
  "pot": 1000,
  "stack": 9500,
  "bet_sizes": [1.0],
  "include_all_in": true,
  "max_raises": 1000,
  "players": [
    {"hands": ["AsKd", "..."], "weights": [1.0, "..."]},
    {"hands": ["AsKd", "..."], "weights": [1.0, "..."]}
  ]
}
```
고급 크기 배열(`oop_first_bets`, `ip_first_bets`, `oop_first_raises`, `ip_first_raises`, `oop_next_raises`,
`ip_next_raises`)은 선택 사항이며 생략 시 기본값은 `bet_sizes`입니다.

## 참고사항

- 기본값은 균일한 범위, 보드 `Ks Th 7s 4d 2s`, 팟 1000, 스택 9500, 베팅 크기 `0.5, 1.0`에 올인 활성화 상태를 사용합니다.
- GUI에서 저장된 서브게임의 경우 `--config path/to/subgame.json`을 전달하세요.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-01

---