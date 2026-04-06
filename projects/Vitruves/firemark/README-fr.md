<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/firemark.png" alt="firemark" width="200">
</p>

<h1 align="center">firemark</h1>

<p align="center">Un outil rapide de filigrane monobinaire pour images et PDF. Construit en Rust.</p>

## Pourquoi filigraner vos documents ?

Chaque année, des millions de personnes sont victimes de fraudes à l'identité qui commencent par un
simple échange de documents. Un scénario courant : vous cherchez un appartement à louer.
Le propriétaire — ou quelqu’un se faisant passer pour lui — demande une copie de votre pièce d’identité, une fiche
de paie, un avis d’imposition. Vous les envoyez sans marque. Le "propriétaire" disparaît, et vos
documents sont désormais utilisés pour ouvrir des comptes bancaires, contracter des prêts, ou falsifier
des identités en votre nom.

Filigraner chaque document que vous envoyez est la défense la plus efficace.
Un filigrane visible indiquant **« Envoyé à l’agence XYZ — mars 2026 — uniquement pour la demande de location »** rend le document inutile à toute autre fin. S’il
fuit, vous savez exactement d’où il provient.

firemark rend cela simple : une commande, n’importe quelle image ou PDF, 17 styles visuels,
des motifs cryptographiques de filigrane résistants à la modification, et un traitement par lots
pour des dossiers entiers.

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/paycheck-firemark-comparison.png" alt="Before and after watermarking" width="800">
  <br>
  <em>Avant et après — une seule commande, le document est désormais traçable et infalsifiable.</em>
</p>

## Installation

Depuis [crates.io](https://crates.io/crates/firemark) :


```bash
cargo install firemark
```
Depuis la source :


```bash
git clone https://github.com/Vitruves/firemark.git
cd firemark
cargo install --path .
```

Produit un seul binaire optimisé (~5 Mo).

## Démarrage rapide

```bash
# Watermark a single image
firemark photo_id.png -m "Flat rental — SCI Dupont — March 2026"

# Watermark a PDF
firemark tax_notice.pdf -m "CONFIDENTIAL" -s "Do not distribute"

# Watermark an entire folder recursively
firemark ./documents/ -R -m "Sent to Agency X" -t stamp

# Preview without writing files
firemark id_card.jpg -m "Draft" -n
```
La sortie est enregistrée à côté de l'entrée sous le nom `{name}-watermarked.{ext}` par défaut.  
Utilisez `-o` pour définir un chemin de sortie explicite, ou `-S` pour un suffixe personnalisé.  

## Types de filigrane  

| Drapeau | Style | Description |  
|---|---|---|  
| `diagonal` | Grille diagonale | Texte diagonal répétitif sur toute la page (par défaut) |  
| `stamp` | Tampon en caoutchouc | Grand tampon centré avec double bordure |  
| `stencil` | Pochoir | Lettres militaires pochoir pleine largeur |  
| `typewriter` | Machine à écrire | Texte à espacement fixe de machine à écrire |  
| `handwritten` | Signature | Signature style manuscrit avec soulignement |  
| `redacted` | Raturé | Barres noires pleine largeur de caviardage |  
| `badge` | Écusson | Emblème de bouclier de sécurité |  
| `ribbon` | Ruban | Bannière ruban diagonale d'angle |  
| `seal` | Sceau | Sceau circulaire style notaire |  
| `frame` | Cadre | Bordure décorative pleine page |  
| `tile` | Carreau | Grille de texte uniforme dense |  
| `mosaic` | Mosaïque | Texte dispersé aléatoirement |  
| `weave` | Tissage | Tissage diagonal entrelacé |  
| `ghost` | Fantôme | Texte embossé ultra-subtil |  
| `watercolor` | Aquarelle | Effet de lavis flou doux |  
| `noise` | Bruit | Texte distressed avec bruit pixelisé |  
| `halftone` | Trame | Texte en grille de points trame |


```bash
firemark doc.pdf -t stamp -m "CONFIDENTIAL" --border --color red
```

## Filigrane de sécurité

firemark superpose des motifs cryptographiques de filigrane inspirés des
caractéristiques de sécurité des billets de banque. Ces motifs géométriques
fins sont extrêmement difficiles à supprimer avec des éditeurs d’images.

| Style | Description |
|---|---|
| `guilloche` | Bandes enveloppes sinusoïdales (par défaut) |
| `rosette` | Spirographe + courbes en forme de rose d’angle |
| `crosshatch` | Treillis fin en losanges diagonaux |
| `border` | Bordure de sécurité ondulée imbriquée |
| `lissajous` | Figures paramétriques de Lissajous |
| `moire` | Interférence de cercles concentriques |
| `spiral` | Vortex en spirale d’Archimède |
| `mesh` | Grille hexagonale en nid d’abeille |
| `plume` | Courbes fluides semblables à des plumes réparties sur la surface |
| `constellation` | Nœuds d’étoiles reliés par une fine toile géométrique |
| `ripple` | Fronts d’onde elliptiques superposés provenant d’origines aléatoires |
| `full` | Tous les motifs combinés |
| `none` | Désactiver le filigrane |

```bash
firemark id.png -m "Rental application" --filigrane moire
firemark id.png -m "Rental application" --filigrane none   # disable
```

## Renforcement contre la suppression par IA

Chaque rendu est non déterministe par défaut. firemark applique une
perturbation universelle post-rendu (tremblement alpha, bruit de couleur sous-pixel,
micro-points sur les bords, pixels fantômes clairsemés) et une randomisation par moteur de rendu
afin qu'aucune sortie ne soit pixel-identique — même avec les mêmes réglages. Cela rend impossible pour les modèles de vision IA
d'apprendre un schéma prévisible à soustraire.

De plus, des bandes d'injection d'invite adversariale sont intégrées par défaut pour
déstabiliser les outils de suppression de filigrane IA. Désactivez avec `--no-anti-ai` si vous ne souhaitez pas
le texte d'invite visible :

```bash
firemark doc.png -m "CONFIDENTIAL" --no-anti-ai
```

## Options communes

```
-m, --main-text           Primary watermark text
-s, --secondary-text      Secondary text line
-t, --type                Watermark style (see table above)
-o, --output              Output file path
-S, --suffix              Custom output suffix (default: "watermarked")
-c, --color               Color — name or #RRGGBB (default: blue)
-O, --opacity             Opacity 0.0–1.0 (default: 0.5)
-r, --rotation            Angle in degrees (default: -45)
-p, --position            center, top-left, top-right, bottom-left, bottom-right, tile
-f, --font                Font name or path to .ttf/.otf
-I, --image               Overlay an image as watermark
    --qr-data             Embed a QR code with custom data
    --qr-code-position    QR code placement (default: center)
    --qr-code-size        QR code size in pixels (default: auto)
    --border              Draw a border around the watermark
    --shadow              Add a drop shadow
    --filigrane           Security filigrane style (default: guilloche)
    --no-anti-ai          Disable adversarial prompt injection (on by default)
```

Pour la liste complète des plus de 70 options, voir [`CLI.md`](https://raw.githubusercontent.com/Vitruves/firemark/main/CLI.md).

## Options PDF

```
    --pages           Pages to watermark (e.g. 1,3-5 or "all")
    --skip-pages      Pages to skip
    --behind          Place watermark behind content
    --no-flatten      Keep layers separate (flattened by default)
    --dpi             Render resolution (default: 150)
```

## Traitement par lots

```bash
# Process all images and PDFs in a folder
firemark ./inbox/ -m "INTERNAL" -t tile

# Recursive, 8 threads, custom suffix
firemark ./docs/ -R -j 8 -m "Draft" -S draft

# Dry run — list what would be processed
firemark ./docs/ -R -m "Draft" -n
```

Les fichiers déjà filigranés (correspondant au suffixe) sont automatiquement ignorés lors des
relances.

## Fichier de configuration

Enregistrez les options dans un fichier TOML pour éviter de répéter les options. Voir
[`examples/config/firemark.toml`](https://raw.githubusercontent.com/Vitruves/firemark/main/examples/config/firemark.toml) pour un
exemple complet avec deux préréglages : **ultra-sécurisé** (carrelage dense, filigrane complet, traçabilité QR,
suppression des métadonnées) et **léger** (texte diagonal simple, sans extras).

```toml
# Global defaults
main_text = "CONFIDENTIAL"
secondary_text = "{author} — {date}"
watermark_type = "diagonal"
color = "#1a3c6e"
opacity = 0.45
font_weight = "bold"
filigrane = "guilloche"
border = true

[preset.ultra-secure]
main_text = "CONFIDENTIAL — {author}"
watermark_type = "tile"
color = "#CC0000"
opacity = 0.6
filigrane = "full"
anti_ai = true
qr_data = "firemark://{author}/{timestamp}/{uuid}"
strip_metadata = true

[preset.light]
main_text = "COPY"
watermark_type = "diagonal"
color = "#555555"
opacity = 0.3
filigrane = "none"
anti_ai = false
```

```bash
firemark doc.pdf --config firemark.toml
firemark doc.pdf --config firemark.toml --preset ultra-secure
firemark doc.pdf --config firemark.toml --preset light
firemark doc.pdf --save-preset mypreset    # save current flags
firemark --list-presets                     # list available presets
```

## Support des formats

| Format | Entrée | Sortie |
|---|---|---|
| PNG | oui | oui |
| JPEG | oui | oui |
| PDF | oui | oui |
| WebP | oui | oui |
| TIFF | oui | oui |

La conversion entre formats est prise en charge (par ex. `firemark photo.webp -o out.pdf`).

## Licence

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-06

---