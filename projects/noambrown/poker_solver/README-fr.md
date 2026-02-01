# Solveur River Poker

Ce dépôt construit un solveur de sous-jeu river pour le Texas hold'em no-limit, en commençant par le poker Kuhn et Leduc pour validation. Les algorithmes principaux incluent CFR, CFR+, MCCFR par échantillonnage externe, Fictitious Play, et DCFR. Python est l’implémentation de référence ; C++ vise la performance.

## Organisation du dépôt

- `python/` implémentation de référence (algorithmes, jeux, outils CLI).
- `cpp/` solveur river C++ optimisé.

Guide du contributeur : voir `AGENTS.md`.

## Démarrage rapide

Python (Kuhn/Leduc) :

```sh
PYTHONPATH=python/src python -m cli.run_exploitability --game kuhn --algo cfr
```

Python (paramètres par défaut de river) :

```sh
PYTHONPATH=python/src python -m cli.run_river_exploitability --algo cfr+
```

C++ optimisé (paramètres par défaut de river) :

```sh
cmake -S cpp -B cpp/build
cmake --build cpp/build -j
./cpp/build/river_solver_optimized --algo cfr+ --iters 2000
```

## Format JSON de Sous-Jeu

L'interface graphique exporte un fichier JSON que les deux solveurs C++ peuvent charger avec `--config`. Champs clés :

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

Les tableaux de tailles avancées (`oop_first_bets`, `ip_first_bets`, `oop_first_raises`, `ip_first_raises`, `oop_next_raises`,
`ip_next_raises`) sont optionnels et prennent par défaut la valeur de `bet_sizes` lorsqu’ils sont omis.

## Notes

- Les valeurs par défaut utilisent une range uniforme, un tableau `Ks Th 7s 4d 2s`, un pot de 1000, des stacks de 9500, et des tailles de mises `0.5, 1.0` avec l’all-in activé.
- Pour les sous-jeux sauvegardés depuis l’interface graphique, passez `--config path/to/subgame.json`.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-01

---