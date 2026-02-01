# 河牌德州扑克求解器

本仓库构建了一个无限注德州扑克河牌子游戏求解器，起初通过Kuhn和Leduc扑克进行验证。核心算法包括CFR、CFR+、外采样MCCFR、虚拟竞赛(Fictitious Play)和DCFR。Python是参考实现；C++面向性能优化。

## 仓库结构

- `python/` 参考实现（算法、游戏、命令行工具）。
- `cpp/` 优化的C++河牌求解器。

贡献者指南：见 `AGENTS.md`。

## 快速开始

Python（Kuhn/Leduc）：

```sh
PYTHONPATH=python/src python -m cli.run_exploitability --game kuhn --algo cfr
```

Python（河流默认值）：

```sh
PYTHONPATH=python/src python -m cli.run_river_exploitability --algo cfr+
```

优化后的 C++（河流默认设置）：

```sh
cmake -S cpp -B cpp/build
cmake --build cpp/build -j
./cpp/build/river_solver_optimized --algo cfr+ --iters 2000
```

## 子游戏 JSON 格式

GUI 导出一个 JSON 文件，两个 C++ 求解器都可以通过 `--config` 加载。关键字段：

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

高级下注大小数组（`oop_first_bets`、`ip_first_bets`、`oop_first_raises`、`ip_first_raises`、`oop_next_raises`、
`ip_next_raises`）是可选的，省略时默认为 `bet_sizes`。

## 说明

- 默认使用均匀范围，公共牌为 `Ks Th 7s 4d 2s`，底池为 1000，筹码为 9500，下注大小为 `0.5, 1.0`，并启用全压。
- 对于从 GUI 保存的子游戏，传递 `--config path/to/subgame.json`。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-01

---