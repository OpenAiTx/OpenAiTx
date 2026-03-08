# cq - Moteur de requêtes SQL haute performance pour fichiers CSV

 [![Compilation croisée et test (avec le système de build zig)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

Un processeur de requêtes SQL léger et rapide écrit en C qui permet d'exécuter des requêtes SQL directement sur des fichiers CSV sans nécessiter de base de données. Pour la documentation complète, voir le répertoire /doc.

 ![cq en action](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)

## Documentation

- Prise en main : `doc/GettingStarted.md`
- Installation : `doc/Installation.md`
- Interface en ligne de commande : `doc/CLI.md`
- **TUI (Interface Utilisateur Terminal)** : `doc/TUI.md`
- Architecture : `doc/Architecture.md`
- Tests : `doc/Testing.md`
- Feuille de route : `doc/Roadmap.md`
- Contribution : `doc/Contributing.md`

## Démarrage rapide

Compilation : `make`

### Ligne de commande

Exécuter une requête d'exemple :
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### Interface Terminal

Lancer l'interface TUI interactive :
`./build/cqtui data/`

Fonctionnalités :
- Parcourir et ouvrir des fichiers CSV comme des tables
- Exécuter des requêtes SQL de manière interactive
- Interface multi-onglets pour plusieurs tables
- Navigation au clavier
- Aucune dépendance externe

## Fichiers SQL d'exemple

Le dépôt inclut des exemples SQL dans assets/ (example_between.sql, example_aggregation.sql, etc.). Voir assets/ pour plus de détails.

## Aperçu des données et des fonctionnalités

- Voir le dossier /doc pour des sections détaillées sur les types de données, les formats de date, le format CSV, et plus encore.

## Licence

Licence MIT. Voir le fichier LICENSE pour plus de détails.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---