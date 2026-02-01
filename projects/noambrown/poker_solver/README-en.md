# River Poker Solver

This repository builds a no-limit Texas hold'em river subgame solver, starting with Kuhn and Leduc poker for validation. Core algorithms include CFR, CFR+, external-sampling MCCFR, Fictitious Play, and DCFR. Python is the reference implementation; C++ targets performance.

## Repository Layout

- `python/` reference implementation (algorithms, games, CLI tooling).
- `cpp/` optimized C++ river solver.

Contributor guide: see `AGENTS.md`.

## Quick Start

Python (Kuhn/Leduc):

```sh
PYTHONPATH=python/src python -m cli.run_exploitability --game kuhn --algo cfr
```

Python (river defaults):

```sh
PYTHONPATH=python/src python -m cli.run_river_exploitability --algo cfr+
```

Optimized C++ (river defaults):

```sh
cmake -S cpp -B cpp/build
cmake --build cpp/build -j
./cpp/build/river_solver_optimized --algo cfr+ --iters 2000
```

## Subgame JSON Format

GUI exports a JSON file that both C++ solvers can load with `--config`. Key fields:

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

Advanced sizing arrays (`oop_first_bets`, `ip_first_bets`, `oop_first_raises`, `ip_first_raises`, `oop_next_raises`,
`ip_next_raises`) are optional and default to `bet_sizes` when omitted.

## Notes

- Defaults use a uniform range, board `Ks Th 7s 4d 2s`, pot 1000, stacks 9500, and bet sizes `0.5, 1.0` with all-in enabled.
- For subgames saved from the GUI, pass `--config path/to/subgame.json`.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-01

---