# OfficeIMO - Bibliothèque Microsoft Word .NET

OfficeIMO est disponible en tant que package NuGet depuis la galerie et est la méthode d'installation recommandée.

[![nuget downloads](https://img.shields.io/nuget/dt/officeIMO.Word?label=nuget%20downloads)](https://www.nuget.org/packages/OfficeIMO.Word)
[![nuget version](https://img.shields.io/nuget/v/OfficeIMO.Word)](https://www.nuget.org/packages/OfficeIMO.Word)
[![license](https://img.shields.io/github/license/EvotecIT/OfficeIMO.svg)](#)
[![CI](https://github.com/EvotecIT/OfficeIMO/actions/workflows/dotnet-tests.yml/badge.svg?branch=master)](https://github.com/EvotecIT/OfficeIMO/actions/workflows/dotnet-tests.yml)
[![codecov](https://codecov.io/gh/EvotecIT/OfficeIMO/branch/master/graph/badge.svg)](https://codecov.io/gh/EvotecIT/OfficeIMO)

Si vous souhaitez me contacter, vous pouvez le faire via Twitter ou LinkedIn.

[![twitter](https://img.shields.io/twitter/follow/PrzemyslawKlys.svg?label=Twitter%20%40PrzemyslawKlys&style=social)](https://twitter.com/PrzemyslawKlys)
[![blog](https://img.shields.io/badge/Blog-evotec.xyz-2A6496.svg)](https://evotec.xyz/hub)
[![linked](https://img.shields.io/badge/LinkedIn-pklys-0077B5.svg?logo=LinkedIn)](https://www.linkedin.com/in/pklys)
[![discord](https://img.shields.io/discord/508328927853281280?style=flat-square&label=discord%20chat)](https://evo.yt/discord)

## De quoi s'agit-il

C'est un petit projet (en cours de développement) qui permet de créer des documents Microsoft Word (.docx) avec .NET.
Il utilise en dessous le [OpenXML SDK](https://github.com/OfficeDev/Open-XML-SDK) mais le simplifie fortement.
Il a été créé parce que travailler avec OpenXML est beaucoup trop difficile pour moi et chronophage.
Je l'ai créé pour une utilisation dans le module PowerShell appelé [PSWriteOffice](https://github.com/EvotecIT/PSWriteOffice),
mais j'ai pensé qu'il pourrait être utile à d'autres dans la communauté .NET.
Ce dépôt inclut également un composant expérimental **OfficeIMO.Excel** pour créer des feuilles de calcul simples.

Si vous voulez voir ce qu'il peut faire, jetez un œil à ce [billet de blog](https://evotec.xyz/officeimo-free-cross-platform-microsoft-word-net-library/).

J'utilisais la bibliothèque DocX (que j'ai co-écrite/maintenue avant qu'elle ne soit reprise par Xceed) pour créer des documents Microsoft Word,
mais elle ne supporte que .NET Framework, et leur dernière licence communautaire rend le projet inutilisable.

*Comme je ne suis pas vraiment développeur, et que je ne sais pas trop ce que je fais, si vous savez comment aider – merci.*

- Si vous voyez de mauvaises pratiques, veuillez ouvrir un ticket/soumettre une PR.
- Si vous savez comment faire quelque chose en OpenXML qui pourrait aider ce projet – veuillez ouvrir un ticket/soumettre une PR.
- Si vous voyez quelque chose qui pourrait mieux fonctionner – veuillez ouvrir un ticket/soumettre une PR.
- Si vous voyez quelque chose où je me suis ridiculisé – veuillez ouvrir un ticket/soumettre une PR.
- Si vous voyez quelque chose qui ne fonctionne pas comme je le pense – veuillez ouvrir un ticket/soumettre une PR.

Si vous remarquez des problèmes ou avez des suggestions d'amélioration, veuillez ouvrir un ticket ou soumettre une pull request.
L'essentiel est que cela fonctionne avec .NET Framework 4.7.2, .NET Standard 2.0, etc.

**Ce projet est en développement et, en tant que tel, beaucoup de choses peuvent et vont changer, surtout si des personnes aident.**


| Plateforme | Statut | Couverture du code | .NET |
| -------- | ------ | ------------- | ---- |
| Windows  | ![Windows](https://github.com/EvotecIT/OfficeIMO/actions/workflows/dotnet-tests.yml/badge.svg?branch=master) | [Codecov](https://codecov.io/gh/EvotecIT/OfficeIMO) | OfficeIMO.Word : `netstandard2.0`, `net472`, `net8.0`, `net9.0`; OfficeIMO.Excel : `netstandard2.0`, `net472`, `net48`, `net8.0`, `net9.0` |
| Linux    | ![Linux](https://github.com/EvotecIT/OfficeIMO/actions/workflows/dotnet-tests.yml/badge.svg?branch=master) | [Codecov](https://codecov.io/gh/EvotecIT/OfficeIMO) | OfficeIMO.Word : `net8.0`; OfficeIMO.Excel : `net8.0`, `net9.0` |
| MacOs    | ![macOS](https://github.com/EvotecIT/OfficeIMO/actions/workflows/dotnet-tests.yml/badge.svg?branch=master) | [Codecov](https://codecov.io/gh/EvotecIT/OfficeIMO) | OfficeIMO.Word : `net8.0`; OfficeIMO.Excel : `net8.0`, `net9.0` |
## Soutenez ce projet

Si vous trouvez ce projet utile, veuillez envisager de soutenir son développement.
Votre parrainage aidera les mainteneurs à consacrer plus de temps à la maintenance et au développement de nouvelles fonctionnalités pour tous.

Cela demande beaucoup de temps et d'efforts pour créer et maintenir ce projet.
En devenant sponsor, vous pouvez aider à garantir qu'il reste gratuit et accessible à tous ceux qui en ont besoin.

Pour devenir sponsor, vous pouvez choisir parmi les options suivantes :

- [Devenir sponsor via GitHub Sponsors :heart:](https://github.com/sponsors/PrzemyslawKlys)
- [Devenir sponsor via PayPal :heart:](https://paypal.me/PrzemyslawKlys)

Votre parrainage est totalement optionnel et non requis pour utiliser ce projet.
Nous voulons que ce projet reste open-source et disponible gratuitement pour tous,
que vous choisissiez ou non de le sponsoriser.

Si vous travaillez pour une entreprise qui utilise nos bibliothèques .NET ou modules PowerShell,
veuillez envisager de demander à votre responsable ou à l'équipe marketing si votre entreprise serait intéressée par le soutien de ce projet.
Le soutien de votre entreprise peut nous aider à continuer de maintenir et améliorer ce projet au bénéfice de tous.

Merci de considérer de soutenir ce projet !

## Merci de partager avec la communauté

Veuillez envisager de partager un post au sujet d’OfficeIMO et de la valeur qu’il apporte. Cela aide vraiment !

[![Share on reddit](https://img.shields.io/badge/share%20on-reddit-red?logo=reddit)](https://reddit.com/submit?url=https://github.com/EvotecIT/OfficeIMO&title=OfficeIMO)
[![Share on hacker news](https://img.shields.io/badge/share%20on-hacker%20news-orange?logo=ycombinator)](https://news.ycombinator.com/submitlink?u=https://github.com/EvotecIT/OfficeIMO)
[![Share on twitter](https://img.shields.io/badge/share%20on-twitter-03A9F4?logo=twitter)](https://twitter.com/share?url=https://github.com/EvotecIT/OfficeIMO&t=OfficeIMO)
[![Share on facebook](https://img.shields.io/badge/share%20on-facebook-1976D2?logo=facebook)](https://www.facebook.com/sharer/sharer.php?u=https://github.com/EvotecIT/OfficeIMO)
[![Share on linkedin](https://img.shields.io/badge/share%20on-linkedin-3949AB?logo=linkedin)](https://www.linkedin.com/shareArticle?url=https://github.com/EvotecIT/OfficeIMO&title=OfficeIMO)

## Fonctionnalités

Voici une liste des fonctionnalités actuellement prises en charge (et probablement beaucoup que j'ai oubliées) et celles qui sont prévues. Ce n’est pas une liste fermée, plutôt un TODO, et je suis sûr qu’il y en a plus :

- ☑️ Bases de Word
    - ☑️ Créer
    - ☑️ Charger
    - ☑️ Enregistrer (option d'ouverture automatique après enregistrement sous)
    - ☑️ Enregistrer sous (option d'ouverture automatique après enregistrement sous)
- ☑️ Propriétés Word
    - ☑️ Lecture des propriétés de base et personnalisées
    - ☑️ Définition des propriétés de base et personnalisées
- ☑️ Sections
    - ☑️ Ajouter des paragraphes
    - ☑️ Ajouter des en-têtes et pieds de page (impairs/pairs/premier)
    - ☑️ Supprimer les en-têtes et pieds de page (impairs/pairs/premier)
    - ☑️ Supprimer des paragraphes
    - ☑️ Supprimer des sections
- ☑️ En-têtes et pieds de page dans le document (hors sections)
    - ☑️ Ajouter Défaut, Impair, Pair, Premier
    - ☑️ Supprimer Défaut, Impair, Pair, Premier
- ☑️ Paragraphes/Texte et le mettre en gras, souligné, coloré, etc.
    - ☑️ Styles de paragraphes personnalisés via `WordParagraphStyle`
- ☑️ Paragraphes et changement d’alignement
- ☑️ Retrait des paragraphes (avant, après, première ligne, suspendu)
- ☑️ Interligne avec support pour twips et points
- ☑️ Tableaux
    - ☑️ [Ajouter et modifier les styles de tableaux (un des 105 styles intégrés)](https://evotec.xyz/docs/adding-tables-with-built-in-styles-managing-borders/)
    - ☑️ Ajouter des lignes et colonnes
    - ☑️ Ajouter des cellules
    - ☑️ Ajouter des propriétés de cellule
    - ☑️ [Ajouter et modifier les bordures des cellules de tableau](https://evotec.xyz/docs/adding-tables-with-built-in-styles-managing-borders/)
    - ☑️ Supprimer des lignes
    - ☑️ Supprimer des cellules
    - ☑️ Autres
        - ☑️ Fusionner des cellules (verticalement, horizontalement)
        - ☑️ Scinder des cellules (verticalement)
        - ☑️ Scinder des cellules (horizontalement)
        - ☑️ Détecter les cellules fusionnées (verticalement, horizontalement)
        - ☑️ Tableaux imbriqués
        - ☑️ Répéter la ligne d’en-tête sur chaque page
        - ☑️ Contrôler les sauts de page sur les lignes
        - ☑️ Définir la hauteur des lignes et la largeur du tableau
- ☑️ Images/Photos (supporte BMP, GIF, JPEG, PNG, TIFF, EMF avec diverses options d’habillage)
    - ☑️ Ajouter des images depuis un fichier vers Word
    - ☑️ Ajouter des images depuis des chaînes Base64
    - ☑️ Sauvegarder une image de Word vers un fichier
    - ☑️ Rogner des images et définir la transparence
    - ☑️ Positionnement des images et récupération de leur emplacement
    - ◼️ Autres types d’emplacements
- ☑️ Hyperliens
    - ☑️ Ajouter un hyperlien
    - ☑️ Lire un hyperlien
    - ☑️ Supprimer un hyperlien
    - ☑️ Modifier un hyperlien
- ☑️ Sauts de page
    - ☑️ Ajouter un saut de page
    - ☑️ Lire un saut de page
    - ☑️ Supprimer un saut de page
    - ☑️ Modifier un saut de page
- ☑️ Numérotation des pages
    - ☑️ Insérer des numéros de page dans les en-têtes ou pieds de page
    - ☑️ Choisir le style avec `WordPageNumberStyle`
- ☑️ Signets
    - ☑️ Ajouter un signet
    - ☑️ Lire un signet
    - ☑️ Supprimer un signet
    - ☑️ Modifier un signet
- ☑️ Rechercher et remplacer du texte
  - ☑️ Commentaires
      - ☑️ Ajouter des commentaires
      - ☑️ Lire des commentaires
      - ☑️ Supprimer des commentaires (un ou tous)
      - ☑️ Suivi des commentaires
      - ☑️ Réponses en fil de discussion
- ☑️ Champs
    - ☑️ Ajouter un champ
    - ☑️ Lire un champ
    - ☑️ Supprimer un champ
    - ☑️ Modifier un champ
- ☑️ Notes de bas de page
    - ☑️ Ajouter de nouvelles notes de bas de page
    - ☑️ Lire les notes de bas de page
    - ☑️ Supprimer les notes de bas de page
- ☑️ Notes de fin
    - ☑️ Ajouter de nouvelles notes de fin
    - ☑️ Lire les notes de fin
    - ☑️ Supprimer les notes de fin
- ☑️ Variables de document
    - ☑️ Définir et lire les variables stockées dans le document
    - ☑️ Supprimer les variables par nom ou par index
- ☑️ Macros
    - ☑️ Ajouter ou extraire des projets VBA
    - ☑️ Supprimer des modules de macros
- ☑️ Publipostage
    - ☑️ Remplacer les valeurs `MERGEFIELD`
    - ☑️ Optionnellement garder les codes de champ
- ☑️ Contrôles de contenu
    - ☑️ Ajouter des contrôles
    - ☑️ Lire les contrôles
    - ☑️ Mettre à jour le texte du contrôle
    - ☑️ Supprimer les contrôles
    - ☑️ Contrôles de formulaire case à cocher
    - ☑️ Contrôles de formulaire sélecteur de date
    - ☑️ Contrôles de formulaire liste déroulante
    - ☑️ Contrôles de formulaire zone combinée
    - ☑️ Contrôles de formulaire image
    - ☑️ Contrôles de formulaire section répétée
- ☑️ Formes
    - ☑️ Ajouter des rectangles
    - ☑️ Ajouter des ellipses
    - ☑️ Ajouter des lignes
    - ☑️ Ajouter des polygones
    - ☑️ Définir la couleur de remplissage et de contour
    - ☑️ Supprimer des formes
- ☑️ Graphiques
    - ☑️ Ajouter des graphiques
        - ☑️ Camembert et Camembert 3D
        - ☑️ Barres et Barres 3D
        - ☑️ Ligne et Ligne 3D
        - ☑️ Combo (Barres + Ligne)
        - ☑️ Aire et Aire 3D
        - ☑️ Nuage de points
        - ☑️ Radar
    - ☑️ Ajouter des catégories et des légendes
    - ☑️ Configurer les axes
    - ☑️ Ajouter plusieurs séries
    - ⚠️ Lors du mélange de séries en barres et en lignes, appeler `AddChartAxisX` avant d’ajouter
      des données afin que les deux types de graphiques partagent le même axe des catégories.
- ☑️ Équations
    - ☑️ Insérer des équations Office Math à partir d’OMML
    - ☑️ Supprimer les équations si nécessaire
- ☑️ Listes
    - ☑️ Ajouter des listes
    - ☑️ Supprimer des listes
    - ☑️ Cloner des listes en conservant les paramètres de numérotation
    - ☑️ Ajouter des listes à puces avec images
    - ☑️ Créer des listes personnalisées à puces et numérotées
    - ☑️ Détecter le style de liste à partir des paragraphes existants
- ☑️ Table des matières
    - ☑️ Ajouter une TDM
    - ☑️ Mettre à jour les champs de la TDM à l’ouverture
- ☑️ Bordures
    - ☑️ Styles intégrés ou paramètres personnalisés
    - ☑️ Modifier la taille, la couleur, le style et l’espacement
- ☑️ Arrière-plan
    - ☑️ Définir la couleur d’arrière-plan
- ☑️ Filigranes
    - ☑️ Ajouter un filigrane texte ou image
    - ☑️ Choisir le style texte ou image via `WordWatermarkStyle`
    - ☑️ Définir la rotation, la largeur et la hauteur
    - ☑️ Supprimer le filigrane

- ☑️ Pages de garde
    - ☑️ Ajouter des pages de garde intégrées

- ☑️ Polices
    - ☑️ Intégrer des polices via `WordDocument.EmbedFont`

- ☑️ Contenu intégré
    - ☑️ Ajouter des documents intégrés (RTF, HTML, TXT)
    - ☑️ Ajouter des fragments HTML
    - ☑️ Insérer un fragment HTML après un paragraphe
    - ☑️ Remplacer du texte par un fragment HTML
    - ☑️ Supprimer des documents intégrés
    - ☑️ Intégrer des objets avec des icônes et tailles personnalisées
 - ☑️ [Signatures numériques et sécurité des documents](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.DigitalSignature.cs)
 - ☑️ [Options de protection de document](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Settings.cs) (document final, lecture seule recommandée, lecture seule forcée)
 - ☑️ [Acceptation/refus des révisions](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Revisions.cs)
 - ☑️ [APIs asynchrones de sauvegarde/chargement](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Async.cs)
 - ☑️ [Fusion de plusieurs documents](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.MergeDocuments.cs)
 - ☑️ [Zones de texte avec options de positionnement](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.TextBox.cs)
 - ☑️ [Orientation de page, taille et marges prédéfinies](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.PageSettings.cs) ([marges](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Sections.cs))
 - ☑️ [Caractères de tabulation et tabulations personnalisées](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.TabStops.cs)
 - ☑️ [Utilitaires de validation de document](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Validation.cs)
 - ☑️ [Méthode CleanupDocument](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Cleanup.cs) fusionne les runs identiques
 - ☑️ [Sérialisation XML de paragraphes](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Examples/Word/XmlSerialization/XmlSerialization.Basic.cs)
 - ☑️ [Aides à la conversion d’unités de mesure](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.HelpersConversions.cs)

- ☑️ Composant Excel expérimental
    - ☑️ Créer et charger des classeurs
    - ☑️ Ajouter des feuilles de calcul
    - ☑️ APIs asynchrones de sauvegarde et chargement


## Fonctionnalités (en une ligne) :

Cette liste de fonctionnalités est destinée aux moments où vous souhaitez corriger rapidement quelque chose plutôt que d’utiliser toutes les fonctionnalités complètes.
Ces fonctionnalités sont disponibles dans la classe `WordHelpers`.

- ☑️ Supprimer les en-têtes et pieds de page d’un fichier
- ☑️ Convertir un modèle DOTX en DOCX

## Exemples

### Document basique avec quelques propriétés et un paragraphe

Ce court exemple montre comment créer un document Word avec un seul paragraphe de texte et quelques propriétés de document.

```csharp
string filePath = System.IO.Path.Combine(
    "Support",
    "GitHub",
    "PSWriteOffice",
    "Examples",
    "Documents",
    "BasicDocument.docx");

using (WordDocument document = WordDocument.Create(filePath)) {
    document.BuiltinDocumentProperties.Title = "This is my title";
    document.BuiltinDocumentProperties.Creator = "Przemysław Kłys";
    document.BuiltinDocumentProperties.Keywords = "word, docx, test";

    var paragraph = document.AddParagraph("Basic paragraph");
    paragraph.ParagraphAlignment = JustificationValues.Center;
    paragraph.Color = SixLabors.ImageSharp.Color.Red;

document.Save(true);
}
```

### Création de documents directement dans un flux

Cette surcharge permet de générer un document entièrement en mémoire ou sur n'importe quel flux fourni.

```csharp
using var stream = new MemoryStream();
using (var document = WordDocument.Create(stream)) {
    document.AddParagraph("Stream based document");
    document.Save(stream);
}
stream.Position = 0;
using (var loaded = WordDocument.Load(stream)) {
    Console.WriteLine(loaded.Paragraphs[0].Text);
}
```

### Enregistrer sous un nouveau document

`SaveAs` clone le document actuel vers un nouveau chemin et retourne une nouvelle instance `WordDocument` sans modifier le `FilePath` original.

```csharp
using (WordDocument document = WordDocument.Create()) {
    document.AddParagraph("Some text");
    using var copy = document.SaveAs(filePath);
    // document.FilePath is still null
    // copy.FilePath equals filePath
}
```

### Enregistrement dans des tableaux d'octets et des flux

`SaveAsByteArray` et `SaveAsMemoryStream` vous permettent de tout conserver en mémoire. `SaveAs(Stream)` clone le document dans un flux fourni et retourne une nouvelle instance chargée à partir de celui-ci.

```csharp
using (WordDocument document = WordDocument.Create()) {
    document.AddParagraph("In memory");
    byte[] data = document.SaveAsByteArray();
    using MemoryStream stream = document.SaveAsMemoryStream();
    using var clone = document.SaveAs(stream);
}
```

### Intégration d'une police

`EmbedFont` ajoute un fichier de police TrueType ou OpenType au document afin qu'il puisse être utilisé sur n'importe quelle machine.

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.EmbedFont(fontPath);
    document.AddParagraph("This document uses an embedded font.");
    document.Save();
}
```
`EmbedFont` dispose d’une surcharge qui peut enregistrer automatiquement un style de paragraphe :


```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.EmbedFont(fontPath, "DejaVuStyle", "DejaVu Style");
    document.AddParagraph("Styled paragraph").SetStyleId("DejaVuStyle");
    document.Save();
}
```

### Mélange des polices intégrées et incorporées

Après avoir incorporé une police, vous pouvez la référencer par son nom ainsi que les polices standard.

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.EmbedFont(fontPath);
    document.AddParagraph("Builtin Arial").SetFontFamily("Arial");
    document.AddParagraph("Embedded DejaVu Sans").SetFontFamily("DejaVu Sans");
    var mixed = document.AddParagraph("Mix: ");
    mixed.AddText("Arial, ").SetFontFamily("Arial");
    mixed.AddText("DejaVu").SetFontFamily("DejaVu Sans");
    document.Save();
}
```

Vous pouvez également créer un style de paragraphe qui utilise la police intégrée.

```csharp
var style = new Style { Type = StyleValues.Paragraph, StyleId = "EmbeddedStyle" };
style.Append(new StyleName { Val = "EmbeddedStyle" });
style.Append(new StyleRunProperties(new RunFonts { Ascii = "DejaVu Sans" }));
WordParagraphStyle.RegisterCustomStyle("EmbeddedStyle", style);

using (WordDocument document = WordDocument.Create(filePath)) {
    document.EmbedFont(fontPath);
    document.AddParagraph("Paragraph with embedded style").SetStyleId("EmbeddedStyle");
    document.AddParagraph("Built-in style example").Style = WordParagraphStyles.Normal;
    document.Save();
}
```

### Document de base avec en-têtes/pieds de page (premier, impair, pair)

Ce court exemple montre comment ajouter des en-têtes et des pieds de page à un document Word.

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.Sections[0].PageOrientation = PageOrientationValues.Landscape;
    document.AddParagraph("Test Section0");
    document.AddHeadersAndFooters();
    document.DifferentFirstPage = true;
    document.DifferentOddAndEvenPages = true;

    document.Sections[0].Header.First.AddParagraph().SetText("Test Section 0 - First Header");
    document.Sections[0].Header.Default.AddParagraph().SetText("Test Section 0 - Header");
    document.Sections[0].Header.Even.AddParagraph().SetText("Test Section 0 - Even");

    document.AddPageBreak();
    document.AddPageBreak();
    document.AddPageBreak();
    document.AddPageBreak();

    var section1 = document.AddSection();
    section1.PageOrientation = PageOrientationValues.Portrait;
    section1.AddParagraph("Test Section1");
    section1.AddHeadersAndFooters();
    section1.Header.Default.AddParagraph().SetText("Test Section 1 - Header");
    section1.DifferentFirstPage = true;
    section1.Header.First.AddParagraph().SetText("Test Section 1 - First Header");

    document.AddPageBreak();
    document.AddPageBreak();
    document.AddPageBreak();
    document.AddPageBreak();

    var section2 = document.AddSection();
    section2.AddParagraph("Test Section2");
    section2.PageOrientation = PageOrientationValues.Landscape;
    section2.AddHeadersAndFooters();
    section2.Header.Default.AddParagraph().SetText("Test Section 2 - Header");

    document.AddParagraph("Test Section2 - Paragraph 1");

    var section3 = document.AddSection();
    section3.AddParagraph("Test Section3");
    section3.AddHeadersAndFooters();
    section3.Header.Default.AddParagraph().SetText("Test Section 3 - Header");

    Console.WriteLine("Section 0 - Text 0: " + document.Sections[0].Paragraphs[0].Text);
    Console.WriteLine("Section 1 - Text 0: " + document.Sections[1].Paragraphs[0].Text);
    Console.WriteLine("Section 2 - Text 0: " + document.Sections[2].Paragraphs[0].Text);
    Console.WriteLine("Section 2 - Text 1: " + document.Sections[2].Paragraphs[1].Text);
    Console.WriteLine("Section 3 - Text 0: " + document.Sections[3].Paragraphs[0].Text);

    Console.WriteLine("Section 0 - Text 0: " + document.Sections[0].Header.Default.Paragraphs[0].Text);
    Console.WriteLine("Section 1 - Text 0: " + document.Sections[1].Header.Default.Paragraphs[0].Text);
    Console.WriteLine("Section 2 - Text 0: " + document.Sections[2].Header.Default.Paragraphs[0].Text);
    Console.WriteLine("Section 3 - Text 0: " + document.Sections[3].Header.Default.Paragraphs[0].Text);
    document.Save(true);
}
```

### Ajout d’un contrôle de contenu

Cet exemple montre comment ajouter et mettre à jour un contrôle de contenu simple, puis le récupérer par étiquette.

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    var sdt = document.AddStructuredDocumentTag("Hello", "MyAlias", "MyTag");
    sdt.Text = "Changed";
    document.Save(true);
}

using (WordDocument document = WordDocument.Load(filePath)) {
    var tag = document.GetStructuredDocumentTagByTag("MyTag");
Console.WriteLine(tag.Text);
}
```

### Contrôles de contenu multiples

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.AddStructuredDocumentTag("First", "Alias1", "Tag1");
    document.AddStructuredDocumentTag("Second", "Alias2", "Tag2");
    document.AddStructuredDocumentTag("Third", "Alias3", "Tag3");
    document.Save(true);
}

using (WordDocument document = WordDocument.Load(filePath)) {
    foreach (var control in document.StructuredDocumentTags) {
        Console.WriteLine(control.Tag + ": " + control.Text);
    }
}
```

### Utilisation avancée du contrôle de contenu

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.AddStructuredDocumentTag("First", "Alias1", "Tag1");
    document.AddStructuredDocumentTag("Second", "Alias2", "Tag2");
    document.Save(true);
}

using (WordDocument document = WordDocument.Load(filePath)) {
    var alias = document.GetStructuredDocumentTagByAlias("Alias2");
    alias.Text = "Updated";
    var tag = document.GetStructuredDocumentTagByTag("Tag1");
    Console.WriteLine(tag.Text);
}
```

### Utilisation avancée de OfficeIMO

Cet exemple court montre plusieurs fonctionnalités de `OfficeIMO.Word`

```csharp
string filePath = System.IO.Path.Combine(folderPath, "AdvancedDocument.docx");
using (WordDocument document = WordDocument.Create(filePath)) {
    // lets add some properties to the document
    document.BuiltinDocumentProperties.Title = "Cover Page Templates";
    document.BuiltinDocumentProperties.Subject = "How to use Cover Pages with TOC";
    document.ApplicationProperties.Company = "Evotec Services";

    // we force document to update fields on open, this will be used by TOC
    document.Settings.UpdateFieldsOnOpen = true;

    // lets add one of multiple added Cover Pages
    document.AddCoverPage(CoverPageTemplate.IonDark);

    // lets add Table of Content (1 of 2)
    document.AddTableOfContent(TableOfContentStyle.Template1);

    // lets add page break
    document.AddPageBreak();

    // lets create a list that will be binded to TOC
    var wordListToc = document.AddTableOfContentList(WordListStyle.Headings111);

    wordListToc.AddItem("How to add a table to document?");

    document.AddParagraph("In the first paragraph I would like to show you how to add a table to the document using one of the 105 built-in styles:");

    // adding a table and modifying content
    var table = document.AddTable(5, 4, WordTableStyle.GridTable5DarkAccent5);
    table.Rows[3].Cells[2].Paragraphs[0].Text = "Adding text to cell";
    table.Rows[3].Cells[2].Paragraphs[0].Color = Color.Blue; ;
    table.Rows[3].Cells[3].Paragraphs[0].Text = "Different cell";

    document.AddParagraph("As you can see adding a table with some style, and adding content to it ").SetBold().SetUnderline(UnderlineValues.Dotted).AddText("is not really complicated").SetColor(Color.OrangeRed);

    wordListToc.AddItem("How to add a list to document?");

    var paragraph = document.AddParagraph("Adding lists is similar to ading a table. Just define a list and add list items to it. ").SetText("Remember that you can add anything between list items! ");
    paragraph.SetColor(Color.Blue).SetText("For example TOC List is just another list, but defining a specific style.");

    var list = document.AddList(WordListStyle.Bulleted);
    list.AddItem("First element of list", 0);
    list.AddItem("Second element of list", 1);

    var paragraphWithHyperlink = document.AddHyperLink("Go to Evotec Blogs", new Uri("https://evotec.xyz"), true, "URL with tooltip");
    // you can also change the hyperlink text, uri later on using properties
    paragraphWithHyperlink.Hyperlink.Uri = new Uri("https://evotec.xyz/hub");
    paragraphWithHyperlink.ParagraphAlignment = JustificationValues.Center;

    list.AddItem("3rd element of list, but added after hyperlink", 0);
    list.AddItem("4th element with hyperlink ").AddHyperLink("included.", new Uri("https://evotec.xyz/hub"), addStyle: true);

    document.AddParagraph();

    // create a custom bullet list
    var custom = document.AddCustomBulletList(WordListLevelKind.BulletSquareSymbol, "Courier New", SixLabors.ImageSharp.Color.Red, fontSize: 16);
    custom.AddItem("Custom bullet item");

    // create a list using an image as the bullet
    var pictureList = document.AddPictureBulletList(Path.Combine(folderPath, "Images", "Kulek.jpg"));
    pictureList.AddItem("Image bullet 1");
    pictureList.AddItem("Image bullet 2");

    // create a multi-level custom list
    var builder = document.AddCustomList()
        .AddListLevel(1, WordListLevelKind.BulletSquareSymbol, "Courier New", SixLabors.ImageSharp.Color.Red, fontSize: 14)
        .AddListLevel(5, WordListLevelKind.BulletBlackCircle, "Arial", colorHex: "#00ff00", fontSize: 10);
    builder.AddItem("First");
    builder.AddItem("Fifth", 4);

    // Note: use AddCustomList() rather than AddList(WordListStyle.Custom)
    // when you want to build lists with your own levels.
    // See [Custom Lists](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/Docs/custom-lists.md) for details on configuring levels.

    var listNumbered = document.AddList(WordListStyle.Heading1ai);
    listNumbered.AddItem("Different list number 1");
    listNumbered.AddItem("Different list number 2", 1);
    listNumbered.AddItem("Different list number 3", 1);
    listNumbered.AddItem("Different list number 4", 1);

    var section = document.AddSection();
    section.PageOrientation = PageOrientationValues.Landscape;
    section.PageSettings.PageSize = WordPageSize.A4;

    wordListToc.AddItem("Adding headers / footers");

    // lets add headers and footers
    document.AddHeadersAndFooters();

    // adding text to default header
    document.Header.Default.AddParagraph("Text added to header - Default");

    var section1 = document.AddSection();
    section1.PageOrientation = PageOrientationValues.Portrait;
    section1.PageSettings.PageSize = WordPageSize.A5;

    wordListToc.AddItem("Adding custom properties to document");

    document.CustomDocumentProperties.Add("TestProperty", new WordCustomProperty { Value = DateTime.Today });
    document.CustomDocumentProperties.Add("MyName", new WordCustomProperty("Some text"));
    document.CustomDocumentProperties.Add("IsTodayGreatDay", new WordCustomProperty(true));

    // document variables available via DocVariable fields
    document.SetDocumentVariable("Project", "OfficeIMO");
    document.SetDocumentVariable("Year", DateTime.Now.Year.ToString());

    if (document.HasDocumentVariables) {
        foreach (var pair in document.DocumentVariables) {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }

    document.Save(openWord);
}
```

## Tests

En plus du fait que `OfficeIMO.Word` utilise des tests unitaires, des [tests de caractérisation](https://fr.wikipedia.org/wiki/Test_de_caractérisation) sont également utilisés.  
Les tests de caractérisation ont été ajoutés afin de ne pas négliger un changement qui casserait le comportement. Ces tests sont basés sur [Verify](https://github.com/VerifyTests/Verify) (["Test de capture instantanée en .NET avec Verify"](https://youtu.be/wA7oJDyvn4c)).  
si vous devez ajouter ou mettre à jour une capture instantanée vérifiée, vous pouvez utiliser le script powershell :
```bash
$ pwsh -c ./Build/ApproveVerifyTests.ps1
```
Pour afficher une comparaison graphique au lieu de la sortie console lorsque les tests Verify échouent, définissez
la variable d'environnement `DiffEngine_Disabled=false` avant d'exécuter les tests.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-06

---