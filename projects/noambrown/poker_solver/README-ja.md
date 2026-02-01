# リバーポーカーソルバー

このリポジトリは、ノーリミットテキサスホールデムのリバーサブゲームソルバーを構築しており、検証のためにクーンポーカーとルーダックポーカーから開始します。コアアルゴリズムにはCFR、CFR+、外部サンプリングMCCFR、フィクティシャスプレイ、DCFRが含まれます。Pythonはリファレンス実装であり、C++はパフォーマンスを目指しています。

## リポジトリ構成

- `python/` リファレンス実装（アルゴリズム、ゲーム、CLIツール）。
- `cpp/` 最適化されたC++リバーソルバー。

コントリビューターガイド：`AGENTS.md`を参照してください。

## クイックスタート

Python（クーン／ルーダック）：

```sh
PYTHONPATH=python/src python -m cli.run_exploitability --game kuhn --algo cfr
```

Python（リバーのデフォルト）：

```sh
PYTHONPATH=python/src python -m cli.run_river_exploitability --algo cfr+
```

最適化された C++（river デフォルト）：

```sh
cmake -S cpp -B cpp/build
cmake --build cpp/build -j
./cpp/build/river_solver_optimized --algo cfr+ --iters 2000
```

## サブゲームJSONフォーマット

GUIは、C++ソルバーの両方が`--config`で読み込めるJSONファイルをエクスポートします。主なフィールド：

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

高度なサイズ配列（`oop_first_bets`、`ip_first_bets`、`oop_first_raises`、`ip_first_raises`、`oop_next_raises`、
`ip_next_raises`）はオプションで、省略した場合は `bet_sizes` がデフォルトとなります。

## 注意事項

- デフォルトは均一なレンジ、ボードは `Ks Th 7s 4d 2s`、ポットは1000、スタックは9500、ベットサイズは `0.5, 1.0` でオールインが有効です。
- GUIから保存したサブゲームの場合は、`--config path/to/subgame.json` を指定してください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-01

---