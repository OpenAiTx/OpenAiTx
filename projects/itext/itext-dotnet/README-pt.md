<p align="center">
    <img src="https://raw.githubusercontent.com/itext/itext-dotnet/develop/assets/iText_Logo_Small.png" alt="Logo iText">
</p>

![Nuget](https://img.shields.io/nuget/v/itext7)
[![AGPL License](https://img.shields.io/badge/license-AGPL-blue.svg)](https://github.com/itext/itext7/blob/master/LICENSE.md)
![Nuget](https://img.shields.io/nuget/dt/itext7)
![GitHub commit activity (branch)](https://img.shields.io/github/commit-activity/m/itext/itext7-dotnet)

O iText Core/Community **(anteriormente conhecido como iTextSharp)** é uma biblioteca de alto desempenho, comprovada em campo, que permite criar, adaptar,
inspecionar e manter documentos PDF, possibilitando adicionar funcionalidades PDF aos seus projetos de software com facilidade. Também está disponível para [Java](https://github.com/itext/itext7).

### Os principais recursos do iText Core/Community são:

* Biblioteca principal:
    * Criação de PDF utilizando nosso motor de layout
    * Manipulação de PDF, por exemplo, mesclar múltiplos PDFs em um só, adicionar novo conteúdo, ...
    * Assinatura digital de PDF
    * Criação e manipulação de formulários PDF
    * Trabalhar com documentos PDF/A
    * Trabalhar com documentos PDF/UA
    * Criptografia compatível com FIPS
    * Geração de códigos de barras
    * Suporte a SVG
* [Addons:][all products]
    * Conversão de XML/HTML & CSS para PDF [repo][pdfhtml], [info][pdfhtmlproduct]
    * Redação de informações sensíveis em documentos PDF [repo][pdfsweep], [info][pdfsweepproduct]
    * Suporte para conjuntos de caracteres internacionais (ex: Árabe, Chinês, Hebraico, Tailandês, ...) [info][calligraph]
    * Otimização de documentos PDF para redução de tamanho do arquivo e aumento de desempenho [info][optimizer]
    * Flattening de documentos XFA [info][xfa]
    * Depuração de PDF [repo][rups], [info][rupsproduct]

Quer descobrir o que é possível? Acesse nosso [Demo Lab](https://itextpdf.com/demos)! Ele contém uma coleção de
aplicações de demonstração prontas para uso online!

### Primeiros passos

A forma mais fácil de começar é usar o NuGet, basta executar o seguinte comando de instalação na pasta do seu projeto:

```shell
dotnet add package itext --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
dotnet add package itext.bouncy-castle-adapter --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
```

Para casos de uso mais avançados, consulte as [Diretrizes de Instalação](https://kb.itextpdf.com/home/it7kb/installation-guidelines).
Você também pode [compilar o iText Community a partir do código-fonte][building].

### Olá PDF!

O exemplo a seguir mostra como é fácil criar um documento PDF simples:

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

### Exemplos

Para exemplos mais avançados, consulte nossa [Knowledge Base](https://kb.itextpdf.com/home/it7kb/examples) ou o
repositório principal de [Exemplos](https://github.com/itext/i7ns-samples). Você pode encontrar equivalentes em C# para os
exemplos de [Assinatura em Java](https://github.com/itext/i7js-signing-examples) [aqui](https://github.com/itext/itext-publications-samples-dotnet/tree/develop/itext/itext.publications),
embora o código Java seja muito semelhante, já que ambos usam a mesma API.

Alguns dos arquivos PDF gerados podem ser exibidos incorretamente no visualizador de prévia do GitHub, então certifique-se de baixá-los para ver os resultados corretos.

| Descrição                                  | Link                                                                                                                                                                                                                                                                                                   |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Layout básico**                          |                                                                                                                                                                                                                                                                                                        |
| Alterar propriedades de texto              | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_paragraphTextWithStyle.pdf)                                |
| Criando uma tabela simples                 | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/tables/SimpleTable9.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/tables/cmp_simple_table9.pdf)                                                  |
| Adicionar uma imagem a um documento PDF    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/images/MultipleImages.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/images/cmp_multiple_images.pdf)                                               |
| Criar uma lista                            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/objects/NestedLists.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/objects/cmp_nested_list.pdf)                                                    |                                                                                                                                                                                                      
| Adicionar uma marca d'água                 | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/Watermarking.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_watermarkings.pdf)                                                  |
| Adicionar links para navegação no documento| [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/AddLinkAnnotation5.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_add_link_annotation5.pdf)                           |
| Criar uma anotação pop-up                  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/MovePopup.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_move_popup.pdf)                                              |
| Alterar fonte                              | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs)                                                                                                                                                                     |
| Adicionar campos de formulário             | [C#](https://kb.itextpdf.com/home/it7kb/examples/forms-in-itext-core-8-0-0)                                                                                                                                                                                                                            |
 <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Configurações gerais de documento**      |                                                                                                                                                                                                                                                                                                        |
| Alterar tamanho da página e margens        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/PageSizeAndMargins.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_pageSizeAndMargins.pdf)                                       |
| Escrever PDF para array de bytes           | [C#](https://stackoverflow.com/a/67411657/10015628)                                                                                                                                                                                                                                                    |
| Alterar rotação da página                  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/PageRotation.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_page_rotation.pdf)                                                  |
| Adicionar cabeçalho e rodapé               | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/TextFooter.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_text_footer.pdf)                                                      |
| Mesclar documentos                         | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/merge/AddCover1.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/merge/cmp_add_cover.pdf)                                                           |
| Achatar anotações                          | [C#](https://kb.itextpdf.com/home/it7kb/examples/high-level-annotation-flattening)                                                                                                                                                                                                                     |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **PDF/UA, PDF/A**                          |                                                                                                                                                                                                                                                                                                        |
| Criar documento PDF/UA                     | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/PdfUA.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/pdfua/cmp_pdf_ua.pdf)                                                                  |
| Criar documento PDF/A-3                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA3.cs)                                                                                                                                                                                        |
| Criar documento PDF/A-4                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA4.cs)                                                                                                                                                                   |
| Criar documento WTPDF                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/Wtpdf.cs)                                                                                                                                                                  |
| Criar documento ZUGFeRD/Factur-X           | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/zugferd/BasicSample.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/zugferd/cmp_invoice_with_zugferd.pdf) |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **FIPS**                                   |                                                                                                                                                                                                                                                                                                        |
| Habilitar FIPS                             | [C#](https://kb.itextpdf.com/home/it7kb/releases/release-itext-core-8-0-0/breaking-changes-for-itext-core-8-0-0/bouncy-castle-changes)                                                                                                                                                                 |
| Exemplo FIPS SHA3                          | [C#](https://kb.itextpdf.com/home/it7kb/examples/fips-sha3-examples-for-itext-core-8-0-0)                                                                                                                                                                                                              |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **SVG**                                    |                                                                                                                                                                                                                                                                                                        |
| Converter SVG para PDF                     | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdf.cs)                                                                                                                                                        |
| Converter SVG para PDF usando layout        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToLayoutImage.cs)                                                                                                                                                |
| Converter SVG como string para PDF          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgStringToPdf.cs)                                                                                                                                                  |
| Converter SVG para PdfPage                  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfPage.cs)                                                                                                                                                    |
| Converter SVG como XObject                  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToXObject.cs)                                                                                                                                                    |
| Converter SVG para PDF com pdfCalligraph    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfWithPdfCalligraph.cs)                                                                                                                                       |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Converter HTML e CSS para PDF**           | [Link para o repositório](https://github.com/itext/i7j-pdfhtml)                                                                                                                                                                                                                                        |
| Converter documento HTML simples para PDF   | [C#](https://kb.itextpdf.com/home/it7kb/ebooks/itext-7-converting-html-to-pdf-with-pdfhtml)                                                                                                                                                                                                            |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Redação segura de conteúdo**              | [Link para o repositório](https://github.com/itext/i7j-pdfsweep)                                                                                                                                                                                                                                       |
| Redigindo conteúdo                          | [C#](https://kb.itextpdf.com/home/it7kb/examples/removing-content-with-pdfsweep)                                                                                                                                                                                                                       |
| Redigir com base em regex                   | [C#](https://itextpdf.com/products/pdf-redaction-pdfsweep)                                                                                                                                                                                                                                             |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Suporte a sistemas de escrita complexos** | [Link para docs](https://itextpdf.com/products/pdfcalligraph)                                                                                                                                                                                                                                          |
| Adicionar texto em árabe                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/typography/arabic/ArabicWordSpacing.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/typography/cmp_ArabicWordSpacing.pdf)                           |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Otimização de PDFs**                      | [Link para docs](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                              |
| Reduzir tamanho do PDF                      | [C#](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                                          |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Flattening de XFA**                       | [Link para docs](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                     |
| Achatar um documento XFA                    | [C#](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                                 |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **RUPS**                                   | [Link para o repositório](https://github.com/itext/i7j-rups)                                                                                                                                                                                                                                           |
| Depurar um PDF                             | [C#](https://github.com/itext/i7j-rups/releases/latest)                                                                                                                                                                                                         |

### FAQs, tutoriais, etc. ###

Confira a [Base de Conhecimento iText](https://kb.itextpdf.com) para o
[Tutorial Jump-start do iText](https://kb.itextpdf.com/home/it7kb/ebooks/itext-jump-start-tutorial-for-net) e outros
tutoriais, [FAQs](https://kb.itextpdf.com/home/it7kb/faq) e mais. Para informações e exemplos específicos relacionados a
assinaturas digitais e iText, não deixe de acessar o
[Digital Signatures Hub](https://kb.itextpdf.com/home/it7kb/digital-signatures-hub).

Muitas perguntas comuns já foram respondidas
no [Stack Overflow](https://stackoverflow.com/questions/tagged/itext+itext7), portanto, verifique lá também.

### Contribuindo

Muitas pessoas contribuíram para o **iText Core/Community** ao longo dos anos. Se você encontrou um bug, um erro na documentação ou tem um novo recurso interessante para implementar, suas contribuições são bem-vindas.

Pequenas alterações ou correções podem ser enviadas como um [Pull Request](https://github.com/itext/itext7-dotnet/pulls), enquanto para
mudanças maiores pedimos que entre em contato conosco pelo e-mail community@apryse.com para que possamos coordenar melhor nossos esforços e evitar duplicação de trabalho.

Por favor, leia nossas [Diretrizes de Contribuição][contributing] para detalhes sobre submissão de código, regras de codificação e mais.

### Licenciamento

O **iText** possui dupla licença [AGPL][agpl]/[Software comercial][sales].

AGPL é uma licença de software livre/código aberto, porém, isso não significa que o software seja [gratuito][gratis]!

A AGPL é uma licença copyleft, o que significa que qualquer trabalho derivado também deve ser licenciado sob os mesmos termos. Se
você está usando o iText em um software ou serviço que não pode cumprir com os termos da AGPL, temos uma licença comercial
disponível que o isenta dessas obrigações.

Entre em contato com [Vendas] para mais informações.

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

[todos os produtos]: https://itextpdf.com/products

[pdfhtmlproduct]: https://itextpdf.com/products/itext-pdf-html

[xfa]: https://itextpdf.com/products/flatten-pdf-pdfxfa

[rupsproduct]: https://itextpdf.com/products/rups

[calligraph]: https://itextpdf.com/products/pdfcalligraph

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-12

---