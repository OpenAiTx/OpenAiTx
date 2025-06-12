<p align="center">
    <img src="https://raw.githubusercontent.com/itext/itext-dotnet/develop/assets/iText_Logo_Small.png" alt="Logo iText">
</p>

![Nuget](https://img.shields.io/nuget/v/itext7)
[![Licence AGPL](https://img.shields.io/badge/license-AGPL-blue.svg)](https://github.com/itext/itext7/blob/master/LICENSE.md)
![Nuget](https://img.shields.io/nuget/dt/itext7)
![GitHub commit activity (branch)](https://img.shields.io/github/commit-activity/m/itext/itext7-dotnet)

iText Core/Community **(anciennement connu sous le nom d'iTextSharp)** est une bibliothèque haute performance, éprouvée sur le terrain, qui vous permet de créer, d’adapter, d’inspecter et de maintenir des documents PDF, ce qui vous permet d’ajouter facilement des fonctionnalités PDF à vos projets logiciels. Elle est également disponible pour [Java](https://github.com/itext/itext7).

### Les principales fonctionnalités d’iText Core/Community sont :

* Bibliothèque principale :
    * Création de PDF grâce à notre moteur de mise en page
    * Manipulation de PDF, par exemple fusion de plusieurs PDF en un seul, ajout de contenu, ...
    * Signature numérique de PDF
    * Création et manipulation de formulaires PDF
    * Travail avec des documents PDF/A
    * Travail avec des documents PDF/UA
    * Cryptographie conforme FIPS
    * Génération de codes-barres
    * Prise en charge du SVG
* [Extensions :][all products]
    * Conversion XML/HTML & CSS en PDF [repo][pdfhtml], [info][pdfhtmlproduct]
    * Rédaction d’informations sensibles dans des documents PDF [repo][pdfsweep], [info][pdfsweepproduct]
    * Prise en charge des jeux de caractères internationaux (ex. arabe, chinois, hébreu, thaï, ...) [info][calligraph]
    * Optimisation des documents PDF pour réduire la taille des fichiers et augmenter les performances [info][optimizer]
    * Aplatissement des documents XFA [info][xfa]
    * Débogage PDF [repo][rups], [info][rupsproduct]

Vous souhaitez découvrir ce qui est possible ? Rendez-vous sur notre [Demo Lab](https://itextpdf.com/demos) ! Il contient une collection d’applications de démonstration prêtes à être utilisées en ligne !

### Démarrage rapide

Le moyen le plus simple de commencer est d’utiliser NuGet, il suffit d’exécuter la commande d’installation suivante dans le dossier de votre projet :

```shell
dotnet add package itext --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
dotnet add package itext.bouncy-castle-adapter --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
```

Pour des cas d’utilisation plus avancés, veuillez vous référer aux [Instructions d’installation](https://kb.itextpdf.com/home/it7kb/installation-guidelines).
Vous pouvez également [compiler iText Community à partir des sources][building].

### Hello PDF !

L’exemple suivant montre à quel point il est facile de créer un document PDF simple :

```csharp
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace HelloPdf {
    class Program {
        static void Main(string[] args) {
            using var document = new Document(new PdfDocument(new PdfWriter("helloworld-pdf.pdf")));
            document.Add(new Paragraph("Hello World!"));
        }
    }
}
```

### Exemples

Pour des exemples plus avancés, consultez notre [Base de connaissances](https://kb.itextpdf.com/home/it7kb/examples) ou le [dépôt principal d’exemples](https://github.com/itext/i7ns-samples). Vous pouvez trouver des équivalents C# des exemples de signature Java [Signing examples](https://github.com/itext/i7js-signing-examples) [ici](https://github.com/itext/itext-publications-samples-dotnet/tree/develop/itext/itext.publications),
même si le code Java est très similaire puisque les deux utilisent la même API.

Certains fichiers PDF générés peuvent être affichés de manière incorrecte par l’aperçu GitHub, il est donc préférable de les télécharger pour voir le rendu correct.

| Description                                | Lien                                                                                                                                                                                                                                                                                                   |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Mise en page de base**                   |                                                                                                                                                                                                                                                                                                        |
| Modifier les propriétés du texte           | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_paragraphTextWithStyle.pdf)                                |
| Créer un tableau simple                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/tables/SimpleTable9.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/tables/cmp_simple_table9.pdf)                                                  |
| Ajouter une image à un document PDF        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/images/MultipleImages.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/images/cmp_multiple_images.pdf)                                               |
| Créer une liste                            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/objects/NestedLists.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/objects/cmp_nested_list.pdf)                                                    |                                                                                                                                                                                                      
| Ajouter un filigrane                       | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/Watermarking.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_watermarkings.pdf)                                                  |
| Ajouter des liens de navigation interne    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/AddLinkAnnotation5.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_add_link_annotation5.pdf)                           |
| Créer une annotation popup                 | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/MovePopup.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_move_popup.pdf)                                              |
| Changer la police                          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs)                                                                                                                                                                     |
| Ajouter des champs de formulaire           | [C#](https://kb.itextpdf.com/home/it7kb/examples/forms-in-itext-core-8-0-0)                                                                                                                                                                                                                            |
 <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Paramètres généraux du document**        |                                                                                                                                                                                                                                                                                                        |
| Modifier la taille de page et les marges   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/PageSizeAndMargins.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_pageSizeAndMargins.pdf)                                       |
| Écrire un PDF dans un tableau d’octets     | [C#](https://stackoverflow.com/a/67411657/10015628)                                                                                                                                                                                                                                                    |
| Modifier la rotation des pages             | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/PageRotation.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_page_rotation.pdf)                                                  |
| Ajouter un en-tête et pied de page         | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/TextFooter.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_text_footer.pdf)                                                      |
| Fusionner des documents                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/merge/AddCover1.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/merge/cmp_add_cover.pdf)                                                           |
| Aplatir les annotations                    | [C#](https://kb.itextpdf.com/home/it7kb/examples/high-level-annotation-flattening)                                                                                                                                                                                                                     |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **PDF/UA, PDF/A**                          |                                                                                                                                                                                                                                                                                                        |
| Créer un document PDF/UA                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/PdfUA.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/pdfua/cmp_pdf_ua.pdf)                                                                  |
| Créer un document PDF/A-3                  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA3.cs)                                                                                                                                                                                        |
| Créer un document PDF/A-4                  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA4.cs)                                                                                                                                                                   |
| Créer un document WTPDF                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/Wtpdf.cs)                                                                                                                                                                  |
| Créer un document ZUGFeRD/Factur-X         | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/zugferd/BasicSample.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/zugferd/cmp_invoice_with_zugferd.pdf) |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **FIPS**                                   |                                                                                                                                                                                                                                                                                                        |
| Activer FIPS                               | [C#](https://kb.itextpdf.com/home/it7kb/releases/release-itext-core-8-0-0/breaking-changes-for-itext-core-8-0-0/bouncy-castle-changes)                                                                                                                                                                 |
| Exemple FIPS SHA3                          | [C#](https://kb.itextpdf.com/home/it7kb/examples/fips-sha3-examples-for-itext-core-8-0-0)                                                                                                                                                                                                              |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **SVG**                                    |                                                                                                                                                                                                                                                                                                        |
| Convertir SVG en PDF                       | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdf.cs)                                                                                                                                                        |
| Convertir SVG en PDF avec layout           | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToLayoutImage.cs)                                                                                                                                                |
| Convertir SVG comme chaîne en PDF          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgStringToPdf.cs)                                                                                                                                                  |
| Convertir SVG en PdfPage                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfPage.cs)                                                                                                                                                    |
| Convertir SVG en XObject                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToXObject.cs)                                                                                                                                                    |
| Convertir SVG en PDF avec pdfCalligraph    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfWithPdfCalligraph.cs)                                                                                                                                       |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Conversion HTML et CSS en PDF**          | [Lien vers le repo](https://github.com/itext/i7j-pdfhtml)                                                                                                                                                                                                                                              |
| Convertir un document HTML simple en PDF   | [C#](https://kb.itextpdf.com/home/it7kb/ebooks/itext-7-converting-html-to-pdf-with-pdfhtml)                                                                                                                                                                                                            |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Rédaction sécurisée du contenu**         | [Lien vers le repo](https://github.com/itext/i7j-pdfsweep)                                                                                                                                                                                                                                             |
| Rédaction de contenu                       | [C#](https://kb.itextpdf.com/home/it7kb/examples/removing-content-with-pdfsweep)                                                                                                                                                                                                                       |
| Rédaction via regex                        | [C#](https://itextpdf.com/products/pdf-redaction-pdfsweep)                                                                                                                                                                                                                                             |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Prise en charge de systèmes d’écriture complexes** | [Lien vers la doc](https://itextpdf.com/products/pdfcalligraph)                                                                                                                                                                                                                                       |
| Ajouter du texte arabe                     | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/typography/arabic/ArabicWordSpacing.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/typography/cmp_ArabicWordSpacing.pdf)                           |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Optimisation des PDF**                   | [Lien vers la doc](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                            |
| Réduire la taille d’un PDF                 | [C#](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                                          |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Aplatissement XFA**                      | [Lien vers la doc](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                   |
| Aplatir un document XFA                    | [C#](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                                 |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **RUPS**                                   | [Lien vers le repo](https://github.com/itext/i7j-rups)                                                                                                                                                                                                                                                 |
| Déboguer un PDF                            | [C#](https://github.com/itext/i7j-rups/releases/latest)                                                                                                                                                                                                                                                |

### FAQ, tutoriels, etc. ###

Consultez la [base de connaissances iText](https://kb.itextpdf.com) pour le [tutoriel Jump-start iText](https://kb.itextpdf.com/home/it7kb/ebooks/itext-jump-start-tutorial-for-net) et d’autres tutoriels, [FAQ](https://kb.itextpdf.com/home/it7kb/faq) et plus encore. Pour des informations spécifiques et des exemples concernant les signatures numériques et iText, consultez également le [Digital Signatures Hub](https://kb.itextpdf.com/home/it7kb/digital-signatures-hub).

De nombreuses questions courantes ont déjà trouvé réponse sur [Stack Overflow](https://stackoverflow.com/questions/tagged/itext+itext7), pensez donc à vérifier aussi là-bas.

### Contribution

De nombreuses personnes ont contribué à **iText Core/Community** au fil des années. Si vous avez trouvé un bug, une erreur dans la documentation, ou si vous souhaitez proposer une nouvelle fonctionnalité, vos contributions sont les bienvenues.

Les petites modifications ou corrections peuvent être soumises en tant que [Pull Request](https://github.com/itext/itext7-dotnet/pulls), tandis que pour les changements majeurs nous vous demandons de nous contacter à community@apryse.com afin que nous puissions mieux coordonner nos efforts et éviter la duplication du travail.

Veuillez lire nos [Directives de contribution][contributing] pour plus de détails sur la soumission de code, les règles de codage, et plus encore.

### Licence

**iText** est distribué sous double licence [AGPL][agpl]/[logiciel commercial][sales].

L’AGPL est une licence logicielle libre/open source, cependant, cela ne signifie pas que le logiciel est [gratuit][gratis] !

L’AGPL est une licence copyleft, ce qui signifie que tout travail dérivé doit également être licencié sous les mêmes termes. Si vous utilisez iText dans un logiciel ou un service qui ne peut pas se conformer aux termes de l’AGPL, nous proposons une licence commerciale qui vous exonère de ces obligations.

Contactez [Sales] pour plus d’informations.

[agpl]: LICENSE.md

[building]: BUILDING.md

[contributing]: CONTRIBUTING.md

[layoutMd]: layout/README.md

[itext]: https://itextpdf.com/

[github]: https://github.com/itext/itext7

[latest]: https://github.com/itext/itext7/releases/latest

[sales]: https://itextpdf.com/sales

[gratis]: https://en.wikipedia.org/wiki/Gratis_versus_libre

[rups]: https://github.com/itext/i7j-rups

[pdfhtml]: https://github.com/itext/i7n-pdfhtml

[pdfsweep]: https://github.com/itext/i7n-pdfsweep

[itext7net]: https://github.com/itext/itext7-dotnet
[pdfsweepproduct]: https://itextpdf.com/products/pdf-redaction-pdfsweep

[optimizer]: https://itextpdf.com/products/compress-pdf-pdfoptimizer

[tous les produits]: https://itextpdf.com/products

[pdfhtmlproduct]: https://itextpdf.com/products/itext-pdf-html

[xfa]: https://itextpdf.com/products/flatten-pdf-pdfxfa

[rupsproduct]: https://itextpdf.com/products/rups

[calligraph]: https://itextpdf.com/products/pdfcalligraph

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-12

---