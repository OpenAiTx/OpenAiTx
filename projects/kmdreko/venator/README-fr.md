<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" height=170 srcset="docs/images/icon-dark.svg">
    <source media="(prefers-color-scheme: light)" height=170 srcset="docs/images/icon-light.svg">
    <img alt="venator logo" height=170 src="https://raw.githubusercontent.com/kmdreko/venator/main/docs/images/icon-light.svg">
  </picture>
</p>

Venator est une application pour enregistrer, visualiser et filtrer les logs et spans
des programmes instrumentés avec la crate Rust tracing ou utilisant OpenTelemetry.
Elle est conçue spécialement pour un développement local rapide.

<picture>
  <img alt="demo" src="https://raw.githubusercontent.com/kmdreko/venator/main/docs/images/screenshot-demo.gif">
</picture>

## Installation

### Avec des binaires précompilés :

Les binaires sont précompilés et disponibles sur la [page des releases](https://github.com/kmdreko/venator/releases) pour :
- Windows (x64)
- MacOS (Intel, Apple silicon)

### Avec Cargo :

Compilation et installation de `venator` depuis la source avec Cargo (nécessite Rust 1.76 ou
plus récent) :

```
cargo install venator-app
```

## Utilisation

### Utilisation d'OpenTelemetry :

Configurez le SDK OpenTelemetry de votre programme pour exporter les logs et les traces vers
`127.0.0.1:8362` (le port d'écoute par défaut de Venator) et pour utiliser `grpc` ou
`http/protobuf`.

### Utilisation de Rust Tracing :

Dans votre programme instrumenté :

```toml
[dependencies]
venator = "1.1.0"
```

```rust
use venator::Venator;

Venator::default().install();
```
Voir la [documentation](https://docs.rs/venator/latest/venator/) pour plus d’informations.

## Fonctionnalités

Les événements peuvent être visualisés en étant restreints par plage temporelle et filtrés par attributs, niveau, et
autres propriétés. La table des enregistrements peut inclure des colonnes de propriétés personnalisées.
Le graphique affiche les comptes par niveau à chaque barre.

<picture>
  <img alt="captures d’écran de l’écran des événements" src="https://raw.githubusercontent.com/kmdreko/venator/main/docs/images/screenshot-events.png">
</picture>

Les intervalles peuvent également être restreints par plage temporelle et filtre. Un panneau de détails peut montrer
toutes les propriétés des événements et intervalles sélectionnés. Le graphique affiche les intervalles superposés
hiérarchiquement.

<picture>
  <img alt="captures d’écran de l’écran des intervalles" src="https://raw.githubusercontent.com/kmdreko/venator/main/docs/images/screenshot-spans.png">
</picture>

Les traces peuvent être visualisées montrant à la fois les événements et les intervalles au sein d’une seule exécution.

<picture>
  <img alt="captures d’écran de l’écran des traces" src="https://raw.githubusercontent.com/kmdreko/venator/main/docs/images/screenshot-traces.png">
</picture>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-04

---