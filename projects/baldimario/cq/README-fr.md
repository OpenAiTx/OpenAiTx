
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# cq - Moteur SQL haute performance pour fichiers CSV

 [![Cross-Build and Test (with zig build system)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

Un processeur SQL léger et rapide écrit en C permettant d'exécuter des requêtes SQL directement sur des fichiers CSV sans nécessiter de base de données. Pour la documentation complète, consultez le répertoire /doc.

 ![cq en action](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)

## Documentation

- Démarrage : `doc/GettingStarted.md`
- Installation : `doc/Installation.md`
- Interface en ligne de commande : `doc/CLI.md`
- **TUI (Interface utilisateur terminal)** : `doc/TUI.md`
- Architecture : `doc/Architecture.md`
- Tests : `doc/Testing.md`
- Feuille de route : `doc/Roadmap.md`
- Contribution : `doc/Contributing.md`

## Démarrage rapide

Compilation : `make`

### Ligne de commande

Exécutez une requête exemple :
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### Interface terminal

Lancez la TUI interactive :
`./build/cqtui data/`

Fonctionnalités :
- Parcourir et ouvrir des fichiers CSV en tant que tables
- Exécuter des requêtes SQL de manière interactive
- Interface multi-onglets pour plusieurs tables
- Navigation entièrement au clavier
- Aucune dépendance externe

## Fichiers SQL d'exemple

Le dépôt inclut des exemples SQL sous assets/ (example_between.sql, example_aggregation.sql, etc.). Voir assets/ pour les détails.

## Aperçu des données et fonctionnalités

- Consultez le dossier /doc pour des sections détaillées sur les types de données, les formats de date, le format CSV, et plus encore.

## Licence

Licence MIT. Voir le fichier LICENSE pour plus de détails.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---