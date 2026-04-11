
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/firemark.png" alt="firemark" width="200">
</p>

<h1 align="center">firemark</h1>

<p align="center">Uma ferramenta rápida e de marca d'água de arquivo único para imagens e PDFs. Construída em Rust.</p>

## Por que marcar seus documentos com marca d'água?

Todos os anos, milhões de pessoas são vítimas de fraudes de identidade que começam com uma
simples troca de documentos. Um cenário comum: você está procurando um apartamento para alugar.
O proprietário — ou alguém se passando por um — pede uma cópia do seu RG, um comprovante de renda,
um aviso de imposto. Você envia esses documentos sem marcação. O "proprietário" desaparece, e seus
documentos agora são usados para abrir contas bancárias, fazer empréstimos ou falsificar
identidades em seu nome.

Adicionar marca d'água a cada documento enviado é a defesa mais eficaz.
Uma sobreposição visível com o texto **"Enviado para Agência XYZ — Março de 2026 — apenas para candidatura de aluguel"**
torna o documento inútil para qualquer outro fim. Se ele vazar, você sabe exatamente de onde veio.

firemark torna isso simples: um comando, qualquer imagem ou PDF, 17 estilos visuais,
padrões criptográficos de filigrana que resistem à edição e processamento em lote para pastas inteiras.

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/paycheck-firemark-comparison.png" alt="Antes e depois da marca d'água" width="800">
  <br>
  <em>Antes e depois — um comando, documento agora rastreável e com evidência de adulteração.</em>
</p>

## Instalação

Via [crates.io](https://crates.io/crates/firemark):



```bash
cargo install firemark
```

Da fonte:

```bash
git clone https://github.com/Vitruves/firemark.git
cd firemark
cargo install --path .
```

Produz um único binário otimizado (~5 MB).

## Início rápido

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

A saída é salva junto com a entrada como `{name}-watermarked.{ext}` por padrão.
Use `-o` para definir um caminho de saída explícito, ou `-S` para um sufixo personalizado.

## Tipos de marca d'água

| Flag | Estilo | Descrição |
|---|---|---|
| `diagonal` | Grade diagonal | Texto diagonal repetido em toda a página (padrão) |
| `stamp` | Carimbo | Grande carimbo centralizado com borda dupla |
| `stencil` | Estêncil | Letras em estêncil de largura total estilo militar |
| `typewriter` | Máquina de escrever | Texto monoespaçado estilo máquina de escrever |
| `handwritten` | Assinatura | Assinatura manuscrita com sublinhado |
| `redacted` | Redação | Barras pretas de redação em largura total |
| `badge` | Distintivo | Emblema de escudo/distintivo de segurança |
| `ribbon` | Fita | Faixa diagonal de canto tipo fita |
| `seal` | Selo | Selo circular estilo notarial |
| `frame` | Moldura | Moldura decorativa em toda a página |
| `tile` | Mosaico | Grade densa e uniforme de texto |
| `mosaic` | Mosaico | Texto disperso aleatoriamente |
| `weave` | Trama | Trama diagonal entrelaçada |
| `ghost` | Fantasma | Texto em relevo ultra sutil |
| `watercolor` | Aquarela | Efeito suave e borrado de aquarela |
| `noise` | Ruído | Texto desgastado com ruído de pixels |
| `halftone` | Meio-tom | Texto em grade de pontos meio-tom |

```bash
firemark doc.pdf -t stamp -m "CONFIDENTIAL" --border --color red
```

## Filigrana de segurança

firemark sobrepõe padrões criptográficos de filigrana inspirados nas características de segurança de notas bancárias.
Esses padrões geométricos finos são extremamente difíceis de remover com editores de imagem.

| Estilo | Descrição |
|---|---|
| `guilloche` | Faixas envolventes de ondas sinusoidais (padrão) |
| `rosette` | Curvas de espirográfo + rosas de canto |
| `crosshatch` | Malha fina de losangos diagonais |
| `border` | Borda de segurança ondulada e aninhada |
| `lissajous` | Figuras paramétricas de Lissajous |
| `moire` | Interferência de círculos concêntricos |
| `spiral` | Vórtice espiral de Arquimedes |
| `mesh` | Grade hexagonal de favos de mel |
| `plume` | Curvas fluidas semelhantes a penas espalhadas pela superfície |
| `constellation` | Nós estrelados conectados por uma fina teia geométrica |
| `ripple` | Frentes de ondas elípticas sobrepostas com origens aleatórias |
| `full` | Todos os padrões combinados |
| `none` | Desativar filigrana |


```bash
firemark id.png -m "Rental application" --filigrane moire
firemark id.png -m "Rental application" --filigrane none   # disable
```

## Endurecimento contra remoção por IA

Cada renderização é não-determinística por padrão. O firemark aplica
perturbação universal pós-renderização (jitter de alfa, ruído de cor subpixel,
micro-pontos nas bordas, pixels fantasmas esparsos) e randomização por
renderizador, de modo que nenhuma saída seja pixel-idêntica — mesmo com as
mesmas configurações. Isso torna impossível para modelos de visão de IA
aprenderem um padrão previsível para subtração.

Além disso, tiras de injeção adversarial de prompts são embutidas por padrão para
confundir ferramentas de remoção de marcas d’água por IA. Desative com `--no-anti-ai`
se não quiser o texto do prompt visível:
```bash
firemark doc.png -m "CONFIDENTIAL" --no-anti-ai
```

## Opções comuns

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

Para a lista completa de mais de 70 flags, veja [`CLI.md`](https://raw.githubusercontent.com/Vitruves/firemark/main/CLI.md).

## Opções de PDF

```
    --pages           Pages to watermark (e.g. 1,3-5 or "all")
    --skip-pages      Pages to skip
    --behind          Place watermark behind content
    --no-flatten      Keep layers separate (flattened by default)
    --dpi             Render resolution (default: 150)
```

## Processamento em lote

```bash
# Process all images and PDFs in a folder
firemark ./inbox/ -m "INTERNAL" -t tile

# Recursive, 8 threads, custom suffix
firemark ./docs/ -R -j 8 -m "Draft" -S draft

# Dry run — list what would be processed
firemark ./docs/ -R -m "Draft" -n
```

Arquivos já marcados com marca d'água (que correspondem ao sufixo) são automaticamente ignorados em
novas execuções.

## Arquivo de configuração

Salve as opções em um arquivo TOML para evitar repetir flags. Veja
[`examples/config/firemark.toml`](https://raw.githubusercontent.com/Vitruves/firemark/main/examples/config/firemark.toml) para um exemplo completo
com dois presets: **ultra-seguro** (mosaico denso, filigrana completa, rastreabilidade por QR,
remoção de metadados) e **leve** (texto diagonal simples, sem extras).

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

## Suporte a formatos

| Formato | Entrada | Saída |
|---|---|---|
| PNG | sim | sim |
| JPEG | sim | sim |
| PDF | sim | sim |
| WebP | sim | sim |
| TIFF | sim | sim |

A conversão entre formatos é suportada (ex.: `firemark photo.webp -o out.pdf`).

## Licença

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---