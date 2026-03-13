# hwpers

[![Crates.io](https://img.shields.io/crates/v/hwpers.svg)](https://crates.io/crates/hwpers)
[![Documentation](https://docs.rs/hwpers/badge.svg)](https://docs.rs/hwpers)
[![CI](https://github.com/Indosaram/hwpers/workflows/CI/badge.svg)](https://github.com/Indosaram/hwpers/actions)
[![License](https://img.shields.io/badge/license-MIT%2FApache--2.0-blue.svg)](LICENSE-MIT)

Une bibliothèque Rust pour analyser les fichiers coréens Hangul Word Processor (HWP) avec prise en charge complète du rendu de mise en page.

## Fonctionnalités

### Analyseur (Lecture des fichiers HWP)
- **Support complet du format HWP 5.0** : Analyse de tous les composants du document, y compris texte, mise en forme, tableaux et objets intégrés
- **Rendu visuel de la mise en page** : Reconstruction des documents avec une précision au pixel près lorsque les données de mise en page sont disponibles
- **Conservation des polices et styles** : Extraction et application des polices, tailles, couleurs et mise en forme de texte d’origine
- **Moteur de mise en page avancé** : Support des mises en page multi-colonnes, positionnement ligne par ligne et mise en forme au niveau des caractères
- **Export SVG** : Rendu des documents en graphiques vectoriels scalables
- **Analyse sans copie** : Analyse efficace avec allocation mémoire minimale
- **Rust sûr** : Implémentation sûre en mémoire avec gestion complète des erreurs

### Éditeur (Création de fichiers HWP) - v0.3.0+
- **Création de documents** : Prise en charge complète de l’écriture de documents HWP
- **Mise en forme riche du texte** : Gras, italique, couleurs, polices, tailles
- **Tableaux** : Création, style, fusion de cellules
- **Listes** : Puces, numérotation, formats coréen/alphabétique/romain
- **Images** : PNG/JPEG/BMP/GIF avec légendes
- **Zones de texte** : Zones de texte positionnées et stylisées
- **Hyperliens** : Liens URL, email, fichier et signet
- **En-têtes/Pieds de page** : Numéros de page et contenu personnalisé
- **Mise en page** : Tailles, marges, orientation, colonnes, arrière-plans

## Démarrage rapide

Ajoutez ceci à votre `Cargo.toml` :

```toml
[dependencies]
hwpers = "0.3"
```
### Utilisation de base


```rust
use hwpers::HwpReader;

// Parse an HWP file
let document = HwpReader::from_file("document.hwp")?;

// Extract text content
let text = document.extract_text();
println!("{}", text);

// Access document properties
if let Some(props) = document.get_properties() {
    println!("Pages: {}", props.total_page_count);
}

// Iterate through sections and paragraphs
for (i, section) in document.sections().enumerate() {
    println!("Section {}: {} paragraphs", i, section.paragraphs.len());
    
    for paragraph in &section.paragraphs {
        if let Some(text) = &paragraph.text {
            println!("  {}", text.content);
        }
    }
}
```

### Rendu de la disposition visuelle

```rust
use hwpers::{HwpReader, render::{HwpRenderer, RenderOptions}};

let document = HwpReader::from_file("document.hwp")?;

// Create renderer with custom options
let options = RenderOptions {
    dpi: 96,
    scale: 1.0,
    show_margins: false,
    show_baselines: false,
};

let renderer = HwpRenderer::new(&document, options);
let result = renderer.render();

// Export first page to SVG
if let Some(svg) = result.to_svg(0) {
    std::fs::write("page1.svg", svg)?;
}

println!("Rendered {} pages", result.pages.len());
```

### Création de documents (v0.3.0+)

```rust
use hwpers::writer::HwpWriter;
use hwpers::model::hyperlink::Hyperlink;

// Create a new document
let mut writer = HwpWriter::new();

// Add formatted text
writer.add_aligned_paragraph(
    "제목",
    hwpers::writer::style::ParagraphAlignment::Center
)?;

// Add hyperlinks
let link = Hyperlink::new_url("Rust", "https://rust-lang.org");
writer.add_paragraph_with_hyperlinks(
    "Visit Rust website",
    vec![link]
)?;

// Configure page layout
writer.set_custom_page_size(210.0, 297.0, // A4 size
    hwpers::model::page_layout::PageOrientation::Portrait)?;
writer.set_page_margins_mm(20.0, 20.0, 20.0, 20.0);

// Add header and footer
writer.add_header("Document Header");
writer.add_footer_with_page_number("Page ", 
    hwpers::model::header_footer::PageNumberFormat::Numeric);

// Save the document
writer.save_to_file("output.hwp")?;
```

### Accès au formatage avancé

```rust
// Access character and paragraph formatting
for section in document.sections() {
    for paragraph in &section.paragraphs {
        // Get paragraph formatting
        if let Some(para_shape) = document.get_para_shape(paragraph.para_shape_id as usize) {
            println!("Indent: {}, Alignment: {}", 
                para_shape.indent, 
                para_shape.get_alignment()
            );
        }
        
        // Get character formatting runs
        if let Some(char_shapes) = &paragraph.char_shapes {
            for pos_shape in &char_shapes.char_positions {
                if let Some(char_shape) = document.get_char_shape(pos_shape.char_shape_id as usize) {
                    println!("Position {}: Size {}, Bold: {}", 
                        pos_shape.position,
                        char_shape.base_size / 100,
                        char_shape.is_bold()
                    );
                }
            }
        }
    }
}
```

## Fonctionnalités prises en charge

### Structure du document
- ✅ En-tête de fichier et détection de version
- ✅ Propriétés et métadonnées du document
- ✅ Définitions de sections et mise en page
- ✅ Formatage des paragraphes et des caractères
- ✅ Définitions de polices (FaceName)
- ✅ Styles et modèles

### Types de contenu
- ✅ Contenu texte avec prise en charge complète de l'Unicode
- ✅ Tableaux et données structurées
- ✅ Objets de contrôle (images, objets OLE)
- ✅ Numérotation et listes à puces
- ✅ Taquets de tabulation et alignement

### Mise en page et rendu
- ✅ Dimensions de page et marges
- ✅ Mises en page en colonnes multiples
- ✅ Positionnement ligne par ligne (quand disponible)
- ✅ Positionnement au niveau du caractère (quand disponible)
- ✅ Bordures et motifs de remplissage
- ✅ Export SVG avec positionnement précis

### Fonctionnalités avancées
- ✅ Support des documents compressés
- ✅ Gestion du format CFB (Compound File Binary)
- ✅ Prise en charge de multiples encodages (UTF-16LE)
- ✅ Récupération d'erreurs et analyse partielle

## Outil en ligne de commande

La bibliothèque inclut un outil en ligne de commande pour inspecter les fichiers HWP :

```bash
# Install the tool
cargo install hwpers

# Inspect an HWP file
hwp_info document.hwp
```
## Support de Format

Cette bibliothèque supporte les fichiers au format HWP 5.0. Pour les formats HWP plus anciens, envisagez d’utiliser d’abord des outils de conversion de format.

## Fonctionnalités de l’Éditeur (v0.3.0+)

La fonctionnalité d’écriture HWP a été significativement améliorée avec un support complet des fonctionnalités :

### ✅ Entièrement Implémenté
- **Hyperliens** : Support complet des hyperliens avec sérialisation appropriée
  - Liens URL, liens email, liens fichier, signets
  - Plusieurs hyperliens par paragraphe
  - Style personnalisé (couleurs, soulignement, état visité)
- **En-tête/Pied de page** : Implémentation complète des en-têtes et pieds de page
  - Texte d’en-tête/pied de page personnalisé
  - Numérotation des pages avec plusieurs formats (numérique, romain, etc.)
  - Plusieurs en-têtes/pieds de page par document
- **Mise en page** : Contrôle complet de la mise en page
  - Tailles de page personnalisées et tailles standards (A4, Lettre, etc.)
  - Orientation portrait/paysage
  - Marges personnalisées (étroites, normales, larges, personnalisées)
  - Mise en page multi-colonnes avec espacement ajustable
  - Couleurs de fond de page
- **Tableaux** : Création et formatage complet des tableaux
  - Bordures et styles des cellules
  - Fusion des cellules (horizontale et verticale)
  - Contenu personnalisé des cellules
- **Listes/Numérotation** : Support complet des listes
  - Listes à puces avec symboles différents par niveau
  - Listes numérotées (1., 2., 3., ...)
  - Listes alphabétiques (a), b), c), ...)
  - Listes en chiffres romains (i., ii., iii., ...)
  - Listes coréennes (가., 나., 다., ...)
  - Listes imbriquées avec indentation correcte
- **Zones de texte** : Implémentation complète des zones de texte
  - Zones de texte positionnées
  - Zones de texte stylisées (surbrillance, avertissement, info, etc.)
  - Style personnalisé (bordures, arrière-plans, alignement)
  - Zones de texte flottantes avec rotation et transparence

- **Images** : Insertion complète d’images  
  - Support PNG, JPEG, BMP, GIF  
  - Dimensions et positionnement personnalisés  
  - Légendes d’images  
  - Intégration correcte de BinData  
- **Texte Stylé** : Mise en forme riche du texte  
  - Gras, italique, souligné, barré  
  - Polices et tailles personnalisées  
  - Couleurs du texte et arrière-plans  
  - Styles multiples dans un seul paragraphe  
- **Mise en Forme Avancée** :  
  - Alignement des paragraphes (gauche, centre, droite, justifié)  
  - Contrôle de l’espacement des lignes  
  - Espacement des paragraphes (avant/après)  
  - Titres avec taille automatique  
  - Styles de caractères et de paragraphes  
- **Propriétés du Document** : Support complet des métadonnées  
  - Titre, auteur, sujet, mots-clés  
  - Statistiques du document (nombre de caractères, mots, etc.)  
  - Mise à jour automatique des statistiques  

### ❌ Pas Encore Implémenté  
- **Formes/Dessin** : Formes géométriques et objets de dessin  
  - Rectangles, cercles, ellipses  
  - Lignes, flèches, polygones  
  - Formes personnalisées avec style  
  - Formes avec contenu texte  
  - Groupement de formes  
  - *(Voir examples/shape_document.rs.disabled pour exemples d’utilisation)*  
- **Graphiques/Diagrammes** : Objets de visualisation de données  
- **Équations Mathématiques** : Support MathML  
- **Formulaires** : Champs de saisie et contrôles de formulaire  
- **Commentaires/Annotations** : Fonctionnalités de révision et commentaires  
- **Suivi des Modifications** : Historique des révisions  
- **Publipostage** : Insertion de champs variables  

### 🔧 Problèmes Connus  
- Pas de support de compression pour l’écrivain (le lecteur supporte compressé et non compressé)  
- Certaines fonctionnalités avancées des tableaux peuvent poser des problèmes de compatibilité avec les anciennes versions de Hanword

## Contribution

Les contributions sont les bienvenues ! N'hésitez pas à soumettre une Pull Request. Pour les changements majeurs, veuillez d'abord ouvrir un ticket pour discuter de ce que vous souhaitez modifier.

## Licence

Ce projet est sous licence sous l'une des licences suivantes

- Licence Apache, version 2.0, ([LICENSE-APACHE](LICENSE-APACHE) ou http://www.apache.org/licenses/LICENSE-2.0)
- Licence MIT ([LICENSE-MIT](LICENSE-MIT) ou http://opensource.org/licenses/MIT)

à votre choix.

## Remerciements

- Spécification du format de fichier HWP par Hancom Inc.
- Communauté de traitement de texte coréen
- Écosystème Rust de parsing et de traitement de documents

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-13

---