<image src="https://raw.githubusercontent.com/UglyToad/Pdf/master/documentation/pdfpig.png" width="128px" height="128px"/>

# PdfPig

[![nuget](https://img.shields.io/nuget/dt/PdfPig)](https://www.nuget.org/packages/PdfPig/)
[![Build and test](https://github.com/UglyToad/PdfPig/actions/workflows/build_and_test.yml/badge.svg)](https://github.com/UglyToad/PdfPig/actions/workflows/build_and_test.yml)
[![Build and test [MacOS]](https://github.com/UglyToad/PdfPig/actions/workflows/build_and_test_macos.yml/badge.svg)](https://github.com/UglyToad/PdfPig/actions/workflows/build_and_test_macos.yml)

PdfPig prend en charge la lecture du texte et du contenu des fichiers PDF. Il prend également en charge la création basique de fichiers PDF.

## Installation

Le package est disponible via l’onglet des releases ou depuis Nuget :

https://www.nuget.org/packages/PdfPig/

Ou depuis la console du gestionnaire de packages :

    > Install-Package PdfPig

Tant que la version est inférieure à 1.0.0, les versions mineures modifieront l’API publique sans avertissement (SemVer ne sera pas respecté avant d’atteindre la version 1.0.0).

## Commencer

Consultez le [wiki](https://github.com/UglyToad/PdfPig/wiki) pour plus d’exemples

### Lire du texte depuis un PDF

L’utilisation la plus simple à ce stade est d’ouvrir un document, en lisant les mots de chaque page :

```cs
// using UglyToad.PdfPig.DocumentLayoutAnalysis.TextExtractor;
// using UglyToad.PdfPig.DocumentLayoutAnalysis.WordExtractor;
using (PdfDocument document = PdfDocument.Open(@"C:\Documents\document.pdf"))
{
    foreach (Page page in document.GetPages())
    {
        string text = ContentOrderTextExtractor.GetText(page);
        IEnumerable<Word> words = page.GetWords(NearestNeighbourWordExtractor.Instance);
    }
}
```

Vous **ne devez pas** utiliser directement `page.Text`, sauf si vous savez ce que vous faites. La propriété `Text` préserve l'ordre du contenu interne, qui est rarement l'ordre du texte que vous souhaitez.

Ces outils d'analyse de mise en page devraient vous permettre d'obtenir le texte souhaité dans la plupart des cas.

### Créer un document PDF
Pour créer des documents, utilisez la classe `PdfDocumentBuilder`. Les polices Standard 14 offrent un moyen rapide de commencer :

```cs
PdfDocumentBuilder builder = new PdfDocumentBuilder();

PdfPageBuilder page = builder.AddPage(PageSize.A4);

// Fonts must be registered with the document builder prior to use to prevent duplication.
PdfDocumentBuilder.AddedFont font = builder.AddStandard14Font(Standard14Font.Helvetica);

page.AddText("Hello World!", 12, new PdfPoint(25, 700), font);

byte[] documentBytes = builder.Build();

File.WriteAllBytes(@"C:\git\newPdf.pdf", documentBytes);
```
La sortie est un document PDF d'une page avec le texte "Hello World !" en Helvetica près du haut de la page :

![Image montre un document PDF dans le visualiseur PDF de Google Chrome. Le texte "Hello World !" est visible](https://raw.githubusercontent.com/UglyToad/Pdf/master/documentation/builder-output.png)

Chaque police doit être enregistrée auprès du `PdfDocumentBuilder` avant utilisation pour permettre aux pages de partager les ressources de police. Seules les polices Standard 14 et les polices TrueType (.ttf) sont prises en charge.

La création de documents prend en charge des modifications très limitées des documents PDF existants. Cependant, elle ne prend pas en charge les éléments suivants :

- Modification des formulaires
- Copie ou modification des annotations, des métadonnées ou des données de structure du document
- Ajout ou suppression de texte avec les polices existantes

### Extraction avancée de documents
Dans cet exemple, une extraction de document plus avancée est effectuée. `PdfDocumentBuilder` est utilisé pour créer une copie du pdf avec des informations de débogage (zones de délimitation et ordre de lecture) ajoutées.



```cs
//using UglyToad.PdfPig;
//using UglyToad.PdfPig.DocumentLayoutAnalysis.PageSegmenter;
//using UglyToad.PdfPig.DocumentLayoutAnalysis.ReadingOrderDetector;
//using UglyToad.PdfPig.DocumentLayoutAnalysis.WordExtractor;
//using UglyToad.PdfPig.Fonts.Standard14Fonts;
//using UglyToad.PdfPig.Writer;


var sourcePdfPath = "";
var outputPath = "";
var pageNumber = 1;
using (var document = PdfDocument.Open(sourcePdfPath))
{
    var builder = new PdfDocumentBuilder { };
    PdfDocumentBuilder.AddedFont font = builder.AddStandard14Font(Standard14Font.Helvetica);
    var pageBuilder = builder.AddPage(document, pageNumber);
    pageBuilder.SetStrokeColor(0, 255, 0);
    var page = document.GetPage(pageNumber);

    var letters = page.Letters; // no preprocessing

    // 1. Extract words
    var wordExtractor = NearestNeighbourWordExtractor.Instance;

    var words = wordExtractor.GetWords(letters);

    // 2. Segment page
    var pageSegmenter = DocstrumBoundingBoxes.Instance;

    var textBlocks = pageSegmenter.GetBlocks(words);

    // 3. Postprocessing
    var readingOrder = UnsupervisedReadingOrderDetector.Instance;
    var orderedTextBlocks = readingOrder.Get(textBlocks);

    // 4. Add debug info - Bounding boxes and reading order
    foreach (var block in orderedTextBlocks)
    {
        var bbox = block.BoundingBox;
        pageBuilder.DrawRectangle(bbox.BottomLeft, bbox.Width, bbox.Height);
        pageBuilder.AddText(block.ReadingOrder.ToString(), 8, bbox.TopLeft, font);
    }

    // 5. Write result to a file
    byte[] fileBytes = builder.Build();
    File.WriteAllBytes(outputPath, fileBytes); // save to file
}
```

![Image montre un document PDF créé par le bloc de code ci-dessus avec les boîtes englobantes et l’ordre de lecture des mots affichés](/documentation/boundingBoxes_ReadingOrder.png)

Voir [Analyse de la mise en page du document](https://github.com/UglyToad/PdfPig/wiki/Document-Layout-Analysis) pour plus d’informations sur l’analyse avancée des documents.

Voir [Exportation](https://github.com/UglyToad/PdfPig/wiki/Document-Layout-Analysis#export) pour des outils plus avancés d’analyse des mises en page des documents.


## Utilisation

### PdfDocument

La classe `PdfDocument` donne accès au contenu d’un document chargé soit à partir d’un fichier, soit passé en tant qu’octets. Pour ouvrir à partir d’un fichier, utilisez la méthode statique `PdfDocument.Open` :

```cs
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;

using (PdfDocument document = PdfDocument.Open(@"C:\my-file.pdf"))
{
	int pageCount = document.NumberOfPages;

	// Page number starts from 1, not 0.
	Page page = document.GetPage(1);

	decimal widthInPoints = page.Width;
	decimal heightInPoints = page.Height;

	string text = page.Text;
}
```

`PdfDocument` ne doit être utilisé que dans une instruction `using` puisqu'il implémente `IDisposable` (à moins que le consommateur ne le libère ailleurs).

Les documents chiffrés peuvent être ouverts par PdfPig. Pour fournir un mot de passe propriétaire ou utilisateur, fournissez les `ParsingOptions` optionnelles lors de l'appel à `Open` avec la propriété `Password` définie. Par exemple :

    using (PdfDocument document = PdfDocument.Open(@"C:\mon-fichier.pdf",  new ParsingOptions { Password = "mot de passe ici" }))

Vous pouvez également fournir une liste de mots de passe à essayer :

```cs
using (PdfDocument document = PdfDocument.Open(@"C:\file.pdf", new ParsingOptions
{
	Passwords = new List<string> { "One", "Two" }
}))
```

Le document contient la version de la spécification PDF à laquelle il se conforme, accessible via `document.Version` :

    decimal version = document.Version;

### Création de document

Le `PdfDocumentBuilder` crée un nouveau document sans pages ni contenu.

Pour le contenu textuel, une police doit être enregistrée auprès du constructeur. Cette bibliothèque prend en charge par défaut les polices Standard 14 fournies par Adobe ainsi que les polices au format TrueType.

Pour ajouter une police Standard 14, utilisez :

    public AddedFont AddStandard14Font(Standard14Font type)

Ou pour une police TrueType, utilisez :

    AddedFont AddTrueTypeFont(IReadOnlyList<byte> fontFileBytes)

En passant les octets d’un fichier TrueType (.ttf). Vous pouvez vérifier la compatibilité d’un fichier TrueType pour l’intégration dans un document PDF avec :

    bool CanUseTrueTypeFont(IReadOnlyList<byte> fontFileBytes, out IReadOnlyList<string> reasons)

Qui fournit une liste des raisons pour lesquelles la police ne peut pas être utilisée en cas d’échec de la vérification. Vous devez vérifier la licence d’une police TrueType avant utilisation, car le fichier de police compressé est intégré et distribué avec le document résultant.

La classe `AddedFont` représente une clé pour la police stockée dans le constructeur de document. Celle-ci doit être fournie lors de l’ajout de contenu textuel aux pages. Pour ajouter une page à un document, utilisez :

    PdfPageBuilder AddPage(PageSize size, bool isPortrait = true)

Cela crée un nouveau `PdfPageBuilder` avec la taille spécifiée. La première page ajoutée est la page numéro 1, puis 2, puis 3, etc. Le constructeur de page prend en charge l’ajout de texte, le dessin de lignes et de rectangles, ainsi que la mesure de la taille du texte avant dessin.

Pour dessiner des lignes et des rectangles, utilisez les méthodes :

```cs
void DrawLine(PdfPoint from, PdfPoint to, decimal lineWidth = 1)
void DrawRectangle(PdfPoint position, decimal width, decimal height, decimal lineWidth = 1)
```
La largeur de ligne peut être modifiée et est par défaut de 1. Les rectangles ne sont pas remplis et la couleur de remplissage ne peut pas être modifiée pour le moment.

Pour écrire du texte sur la page, vous devez avoir une référence à une `AddedFont` provenant des méthodes de `PdfDocumentBuilder` comme décrit ci-dessus. Vous pouvez ensuite dessiner le texte sur la page en utilisant :

    IReadOnlyList<Letter> AddText(string text, decimal fontSize, PdfPoint position, PdfDocumentBuilder.AddedFont font)

Où `position` est la ligne de base du texte à dessiner. Actuellement **seul le texte ASCII est pris en charge**. Vous pouvez également mesurer la taille résultante du texte avant de le dessiner en utilisant la méthode :

    IReadOnlyList<Letter> MeasureText(string text, decimal fontSize, PdfPoint position, PdfDocumentBuilder.AddedFont font)

Qui ne modifie pas l’état de la page, contrairement à `AddText`.

Le changement de la couleur RVB du texte, des lignes et des rectangles est pris en charge en utilisant :


```cs
void SetStrokeColor(byte r, byte g, byte b)
void SetTextAndFillColor(byte r, byte g, byte b)
```

Qui prennent des valeurs RVB comprises entre 0 et 255. La couleur restera active pour toutes les opérations appelées après ces méthodes jusqu'à ce que reset soit appelé en utilisant :

    void ResetColor()

Ce qui réinitialise la couleur pour le contour, le remplissage et le dessin du texte en noir.

### Informations sur le document

Le `PdfDocument` donne accès aux métadonnées du document sous `DocumentInformation` définies dans le fichier PDF. Celles-ci ne sont généralement pas fournies, donc la plupart de ces entrées seront `null` :

```
PdfDocument document = PdfDocument.Open(fileName);

// The name of the program used to convert this document to PDF.
string producer = document.Information.Producer;

// The title given to the document
string title = document.Information.Title;
// etc...
```

### Structure du document

Le `PdfDocument` possède un membre Structure :

    UglyToad.PdfPig.Structure structure = document.Structure;

Cela permet d’accéder au contenu du document PDF tokenisé :

```cs
Catalog catalog = structure.Catalog;
DictionaryToken pagesDictionary = catalog.PagesDictionary;
```

Le dictionnaire des pages est la racine de l'arbre des pages dans un document PDF. La structure expose également une méthode `GetObject(IndirectReference reference)` qui permet un accès aléatoire à n'importe quel objet dans le PDF tant que son numéro d'identifiant est connu. Il s'agit d'un identifiant de la forme `69 0 R` où 69 est le numéro de l'objet et 0 la génération.

### Page

La `Page` contient la largeur et la hauteur de la page en points ainsi qu'un mappage vers l'énumération `PageSize` :


```cs
PageSize size = Page.Size;

bool isA4 = size == PageSize.A4;
```
`Page` donne accès au texte de la page mais vous devriez utiliser `ContentOrderTextExtractor` ou des alternatives si vous indexez le texte, par exemple pour RAG/LLMs :

    string text = page.Text;

Il existe une méthode qui donne accès aux mots. La méthode par défaut utilise des heuristiques basiques. Pour des cas avancés, vous pouvez aussi implémenter votre propre `IWordExtractor` ou utiliser le `NearestNeighbourWordExtractor` :

    IEnumerable<Word> words = page.GetWords();

Vous pouvez aussi accéder aux opérations brutes utilisées dans le flux de contenu de la page pour dessiner des graphiques et du contenu sur la page :

    IReadOnlyList<IGraphicsStateOperation> operations = page.Operations;

Consultez la spécification PDF pour la signification des opérateurs individuels.

Il y a aussi une API pour récupérer les objets image PDF par page :

    IEnumerable<XObjectImage> images = page.GetImages();

Veuillez lire le [wiki sur les Images](https://github.com/UglyToad/PdfPig/wiki/Images).

### Lettre

En raison de la structure interne d’un PDF, le texte de la page peut ne pas être une représentation lisible du texte tel qu’il apparaît dans le document. Puisque le PDF est un format de présentation, le texte peut être dessiné dans n’importe quel ordre, pas nécessairement l’ordre de lecture. Cela signifie que des espaces peuvent manquer ou que des mots peuvent être dans des positions inattendues dans le texte.

Pour aider les utilisateurs à résoudre l’ordre réel du texte sur la page, le fichier `Page` donne accès à une liste des lettres :

    IReadOnlyList<Letter> letters = page.Letters;

Ces lettres contiennent :

- Le texte de la lettre : `letter.Value`.
- La position du coin inférieur gauche de la lettre : `letter.Location`.
- La largeur de la lettre : `letter.Width`.
- La taille de la police en unités de texte relatives non mises à l’échelle (ces tailles sont internes au PDF et ne correspondent pas aux tailles en pixels, points ou autres unités) : `letter.FontSize`.
- Le nom de la police utilisée pour rendre la lettre si disponible : `letter.FontName`.
- Un rectangle qui est le plus petit rectangle contenant complètement la région visible de la lettre/glyphe : `letter.GlyphRectangle`.
- Les points au début et à la fin de la ligne de base `StartBaseLine` et `EndBaseLine` qui indiquent si la lettre est tournée. La `TextDirection` indique s’il s’agit d’une rotation couramment utilisée ou d’une rotation personnalisée.

La position des lettres est mesurée en coordonnées PDF où l’origine est le coin inférieur gauche de la page. Par conséquent, une valeur Y plus élevée signifie plus proche du haut de la page.

### Annotations

La récupération des annotations sur chaque page est fournie via la méthode :

    page.GetAnnotations()

Cet appel n'est pas mis en cache et le document ne doit pas avoir été fermé avant son utilisation. Les annotations ne peuvent pas être modifiées.

### Signets

Les signets (plans) d’un document peuvent être récupérés au niveau du document :

    bool hasBookmarks = document.TryGetBookmarks(out Bookmarks bookmarks);

Cela renverra `false` si le document ne définit aucun signet.

### Formulaires

Les champs de formulaire pour les formulaires interactifs (AcroForms) peuvent être récupérés en utilisant :

    bool hasForm = document.TryGetForm(out AcroForm form);

Cela renverra `false` si le document ne contient pas de formulaire.

Les champs peuvent être accédés via la propriété `Fields` de `AcroForm`. Puisque le formulaire est défini au niveau du document, cela renverra des champs de toutes les pages du document. Les champs sont des types définis par l’énumération `AcroFieldType`, par exemple `PushButton`, `Checkbox`, `Text`, etc.

Veuillez noter que les formulaires sont en lecture seule et que les valeurs ne peuvent pas être modifiées ou ajoutées avec PdfPig.

### Hyperliens

Une page possède une méthode pour extraire les hyperliens (annotations de type lien) :

    IReadOnlyList<UglyToad.PdfPig.Content.Hyperlink> hyperlinks = page.GetHyperlinks();

Les hyperliens ne peuvent pas être ajoutés ou modifiés lors de la création de documents.

### TrueType

Les classes utilisées pour travailler avec les polices TrueType dans le fichier PDF sont disponibles pour usage public. Étant donné un fichier d’entrée :



```cs
using UglyToad.PdfPig.Fonts.TrueType;
using UglyToad.PdfPig.Fonts.TrueType.Parser;

byte[] fontBytes = System.IO.File.ReadAllBytes(@"C:\font.ttf");
TrueTypeDataBytes input = new TrueTypeDataBytes(fontBytes);
TrueTypeFont font = TrueTypeFontParser.Parse(input);
```

La police analysée peut alors être inspectée.

### Fichiers intégrés

Les fichiers PDF peuvent contenir d’autres fichiers entièrement intégrés à l’intérieur pour les annotations de documents. La liste des fichiers intégrés et leur contenu en octets peut être consultée :

```cs
if (document.Advanced.TryGetEmbeddedFiles(out IReadOnlyList<EmbeddedFile> files)
    && files.Count > 0)
{
    var firstFile = files[0];
    string name = firstFile.Name;
    IReadOnlyList<byte> bytes = firstFile.Bytes;
}
```

### Fusion

Vous pouvez fusionner 2 fichiers PDF existants ou plus en utilisant la classe `PdfMerger` :

```cs
var resultFileBytes = PdfMerger.Merge(filePath1, filePath2);
File.WriteAllBytes(@"C:\pdfs\outputfilename.pdf", resultFileBytes);
```

## Wiki
Consultez notre [wiki](https://github.com/UglyToad/PdfPig/wiki) pour plus d'exemples et des guides détaillés sur l'API.

## Problèmes

Veuillez signaler un problème si vous rencontrez un bug. Voir notre [politique de problèmes](https://github.com/UglyToad/PdfPig/issues/1095) et le [guide de contribution](https://github.com/UglyToad/PdfPig/blob/master/CONTRIBUTING.md) pour plus de détails.

## Référence API

Si vous souhaitez générer la documentation doxygen, exécutez `doxygen doxygen-docs` et ouvrez `docs/doxygen/html/index.html`.

## Crédit

Ce projet a commencé comme un effort pour porter [PDFBox](https://github.com/apache/pdfbox) en C#. Ce projet n'aurait pas été possible sans le travail effectué par l'équipe [PDFBox](https://pdfbox.apache.org/) et la Fondation Apache.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---