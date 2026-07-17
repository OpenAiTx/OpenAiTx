<p align="center">
  <b>P R O T E I N V I E W</b>
</p>

<p align="center">
  <em>Explorez les structures moléculaires dans votre terminal</em>
</p>

<p align="center">
  <a href="LICENSE"><img src="https://img.shields.io/badge/License-MIT-blue.svg" alt="Licence : MIT"></a>
  <a href="https://www.rust-lang.org/"><img src="https://img.shields.io/badge/Rust-1.85%2B-orange.svg" alt="Rust"></a>
  <img src="https://img.shields.io/badge/version-0.3.0-green.svg" alt="Version">
  <a href="https://github.com/001TMF/ProteinView/pulls"><img src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg" alt="PRs Bienvenus"></a>
  <a href="https://www.linkedin.com/in/tristan-farmer-973b7a17a/"><img src="https://img.shields.io/badge/LinkedIn-Tristan%20Farmer-0A66C2?logo=linkedin" alt="LinkedIn"></a>
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/hero-histone.png" alt="Particule de base du nucléosome avec protéines histones et ADN rendu en mode FullHD" width="700">
</p>

<p align="center">
  <sub>Particule de base du nucléosome — octamère d’histones enroulé dans l’ADN, rendu avec le protocole graphique Kitty</sub>
</p>

---

Visionneuse de structures moléculaires en terminal — chargez, faites pivoter et explorez protéines, acides nucléiques et petites molécules depuis des fichiers PDB/CIF directement dans votre terminal. Pas de navigateur, pas d’interface graphique, pas de dépendances.

## Fonctionnalités

- **3 modes de rendu** — Braille, HD et FullHD (Sixel/Kitty) avec détection automatique SSH
- **Protocole Kitty compressé PNG** — ~10-20x plus petit que RGBA brut, rendant FullHD viable en SSH
- **Visualisation en rubans cartoon** — rubans ombrés Lambert avec brouillard de profondeur pour hélices, feuillets et boucles
- **Support ARN/ADN** — modes squelette, filaire et cartoon avec coloration selon type de base
- **Rendu des petites molécules** — ligands en bâtonnets-boules, ions en sphères
- **Analyse d’interface** — contacts inter-chaînes, poches de liaison, visualisation des interactions (liaisons H, ponts salins, contacts hydrophobes)
- **7 schémas de couleurs** — structure, chaîne, élément (CPK), facteur B, arc-en-ciel, pLDDT (AlphaFold)
- **Contrôles interactifs** — rotation, zoom, panoramique style vim avec auto-rotation
- **PDB & mmCIF** — support des deux formats, avec récupération RCSB PDB (`--fetch`)
- **Binaire statique unique** — zéro dépendance à l’exécution
## Modes de rendu

Trois niveaux de rendu adaptés à votre terminal et connexion :

<p align="center">
  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/render-modes-grid.png" alt="Comparaison de rendu Braille vs HD vs FullHD" width="700">
</p>

<p align="center">
  <sub>Gauche : Braille (fonctionne partout, y compris SSH/tmux) · Milieu : HD (braille ombré Lambert) · Droite : FullHD (graphismes pixel Kitty)</sub>
</p>

| Mode | Touche | Qualité | Performance SSH |
|------|--------|---------|-----------------|
| **Braille** | par défaut | Basé sur du texte, monochrome par cellule | Excellente |
| **HD** | `m` | Braille ombré avec éclairage + brouillard de profondeur | Excellente |
| **FullHD** | `M` | Graphismes pixel Sixel/Kitty | Bonne (compression PNG) |

`--hd` détecte SSH : HD par défaut en SSH, FullHD localement. Utilisez `--fullhd` pour forcer les graphismes pixel.

## Modes de visualisation

<p align="center">
  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/viz-modes-grid.png" alt="Modes de visualisation Cartoon, Wireframe et Backbone" width="700">
</p>

<p align="center">
  <sub>Gauche : Cartoon (ruban) · Milieu : Wireframe (tout-atome) · Droite : Backbone (trace CA)</sub>
</p>

| Mode | Description |
|------|-------------|
| **Cartoon** | Rendu ruban lisse — hélices, feuillets bêta, et boucles avec ombrage Lambert. Par défaut. |
| **Wireframe** | Liaisons tout-atome incluant peptides inter-résidus et liaisons phosphodiester. |
| **Backbone** | Trace CA (protéines) / trace C4' (acides nucléiques) avec sphères et lignes épaisses de liaison. |

## Analyse d’interface & Interactions

<p align="center">

  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/interface-grid.png" alt="Analyse d'interface avec visualisation des interactions" width="700">
</p>

<p align="center">
  <sub>Gauche : Coloration des résidus d'interface avec panneau latéral · Droite : Lignes d'interaction en pointillés (liaisons H, ponts salins, contacts hydrophobes)</sub>
</p>

Appuyez sur `f` pour basculer en mode interface — met en évidence les résidus de contact à travers les limites des chaînes avec un panneau latéral détaillé. Appuyez sur `I` pour superposer les lignes d'interaction :

| Couleur | Interaction | Distance |
|---------|-------------|----------|
| Cyan | Liaison hydrogène | &le; 3.5 &Aring; |
| Rouge | Pont salin | &le; 4.0 &Aring; |
| Jaune | Contact hydrophobe | &le; 4.5 &Aring; |
| Gris | Autre | &le; 4.5 &Aring; |

## Acides nucléiques

<p align="center">
  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/dna-element.png" alt="Double hélice B-ADN avec coloration par élément (CPK)" width="500">
</p>

<p align="center">
  <sub>Dodécamère B-ADN en mode fil de fer avec coloration par élément CPK</sub>
</p>

Support complet pour les structures ADN et ARN — tracés de la chaîne principale, liaisons en fil de fer et rubans cartoon avec coloration par type de base nucléotidique (A=rouge, U/T=bleu, G=vert, C=jaune).

## AlphaFold & pLDDT

<p align="center">
  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/plddt-cartoon.png" alt="Prédiction AlphaFold avec coloration de confiance pLDDT" width="500">
</p>

<p align="center">
  <sub>Prédiction AlphaFold avec coloration de confiance pLDDT — bleu (haute confiance) à orange/jaune (faible confiance)</sub>
</p>

Détecte automatiquement les structures AlphaFold et propose une coloration de confiance pLDDT. Parcourez les schémas de couleurs avec `c`.

## Installation

Nécessite [Rust 1.85+](https://www.rust-lang.org/tools/install). Si vous n'avez pas Rust, installez-le avec :

```bash
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh
```

Ensuite, installez proteinview :

```bash
git clone https://github.com/001TMF/ProteinView.git
cd ProteinView

# Basic install
cargo install --path .

# With RCSB PDB fetch support
cargo install --path . --features fetch

# Update an existing installation
cargo install --path . --force
```

## Démarrage rapide

```bash
# View a local PDB file
proteinview examples/1AOI.pdb

# HD mode (fast text-based shading)
proteinview examples/4HHB.pdb --hd

# FullHD pixel mode (Kitty/Sixel terminals)
proteinview examples/4HHB.pdb --fullhd

# Fetch from RCSB PDB
proteinview --fetch 1UBQ

# Choose color scheme and visualization
proteinview examples/1UBQ.pdb --color rainbow --mode wireframe
```

## Raccourcis Clavier

| Touche | Action |
|-----|--------|
| `h`/`l` | Rotation Y |
| `j`/`k` | Rotation X |
| `u`/`i` | Roulement |
| `+`/`-` | Zoom |
| `w`/`a`/`s`/`d` | Panoramique |
| `r` | Réinitialiser la vue |
| `c` | Changer de palette de couleurs |
| `v` | Changer de mode de visualisation |
| `m` | Braille / HD |
| `M` | HD / FullHD |
| `f` | Analyse de l’interface |
| `I` | Interactions de l’interface |
| `g` | Basculer les ligands |
| `[`/`]` | Chaîne précédente/suivante |
| `Espace` | Rotation automatique |
| `?` | Aide |
| `q` | Quitter |

## Palettes de Couleurs

| Palette | Description |
|--------|-------------|
| **Structure** | Hélice (rouge), feuillet (jaune), boucle (vert). Par défaut. |
| **Chaîne** | Couleur distincte par chaîne. |
| **Élément** | Coloration CPK (C, N, O, S, P, métaux). |
| **Facteur B** | Bleu (rigide) à rouge (flexible). |
| **Arc-en-ciel** | N-terminus (bleu) à C-terminus (rouge). |
| **pLDDT** | Confiance AlphaFold (bleu=élevée, orange=faible). |

## Support Terminal

| Terminal | Braille | HD | FullHD |
|----------|---------|-----|--------|
| Tout terminal Unicode | Oui | Oui | -- |
| Kitty | Oui | Oui | Oui (PNG) |
| WezTerm | Oui | Oui | Oui (Sixel) |
| iTerm2 | Oui | Oui | Oui |
| foot | Oui | Oui | Oui (Sixel) |
| tmux/screen | Oui | Oui | -- |

## Construction

```bash
cargo build --release

# With RCSB fetch support
cargo build --release --features fetch
```

## Contribution

Les contributions sont les bienvenues ! Voici comment commencer :

1. Forkez le dépôt
2. Créez une branche de fonctionnalité (`git checkout -b feature/ma-fonctionnalité`)
3. Faites vos modifications et ajoutez des tests
4. Lancez `cargo test` pour vérifier
5. Ouvrez une pull request vers `develop`

Veuillez d'abord ouvrir une issue pour les changements majeurs afin de discuter de l'approche.

## Licence

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-17

---