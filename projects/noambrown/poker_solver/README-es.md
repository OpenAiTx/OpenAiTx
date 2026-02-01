# Solucionador de River Poker

Este repositorio construye un solucionador de subjuego river para Texas hold'em sin límite, comenzando con poker Kuhn y Leduc para validación. Los algoritmos principales incluyen CFR, CFR+, MCCFR con muestreo externo, Juego Ficticio y DCFR. Python es la implementación de referencia; C++ está orientado al rendimiento.

## Estructura del Repositorio

- `python/` implementación de referencia (algoritmos, juegos, herramientas CLI).
- `cpp/` solucionador river optimizado en C++.

Guía para colaboradores: ver `AGENTS.md`.

## Inicio Rápido

Python (Kuhn/Leduc):

```sh
PYTHONPATH=python/src python -m cli.run_exploitability --game kuhn --algo cfr
```

Python (valores predeterminados de river):

```sh
PYTHONPATH=python/src python -m cli.run_river_exploitability --algo cfr+
```

C++ optimizado (valores predeterminados de river):

```sh
cmake -S cpp -B cpp/build
cmake --build cpp/build -j
./cpp/build/river_solver_optimized --algo cfr+ --iters 2000
```

## Formato JSON del Subjuego

La GUI exporta un archivo JSON que ambos solucionadores en C++ pueden cargar con `--config`. Campos clave:

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

Los arreglos de tamaños avanzados (`oop_first_bets`, `ip_first_bets`, `oop_first_raises`, `ip_first_raises`, `oop_next_raises`,
`ip_next_raises`) son opcionales y por defecto usan `bet_sizes` cuando se omiten.

## Notas

- Los valores predeterminados usan un rango uniforme, tablero `Ks Th 7s 4d 2s`, bote 1000, stacks 9500, y tamaños de apuesta `0.5, 1.0` con all-in habilitado.
- Para subjuegos guardados desde la GUI, pase `--config path/to/subgame.json`.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-01

---