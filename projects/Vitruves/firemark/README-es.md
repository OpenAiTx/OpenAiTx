<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/firemark.png" alt="firemark" width="200">
</p>

<h1 align="center">firemark</h1>

<p align="center">Una herramienta de marca de agua rápida, con un solo binario, para imágenes y PDFs. Construida en Rust.</p>

## ¿Por qué marcar con agua tus documentos?

Cada año, millones de personas son víctimas de fraudes de identidad que comienzan con un
simple intercambio de documentos. Un escenario común: buscas un piso para alquilar.
El propietario — o alguien que se hace pasar por él — pide una copia de tu identificación, un recibo de pago,
un aviso fiscal. Se los envías sin marcar. El "propietario" desaparece, y tus
documentos ahora se usan para abrir cuentas bancarias, solicitar préstamos o falsificar
identidades en tu nombre.

Marcar con agua cada documento que envíes es la defensa más efectiva.
Una superposición visible que dice **"Enviado a la agencia XYZ — marzo de 2026 — solo para solicitud de alquiler de piso"** hace que el documento sea inútil para cualquier otro propósito. Si se
filtra, sabes exactamente de dónde provino.

firemark hace esto sin esfuerzo: un comando, cualquier imagen o PDF, 17 estilos
visuales, patrones criptográficos de filigrana que resisten la edición, y procesamiento por lotes
para carpetas completas.

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/paycheck-firemark-comparison.png" alt="Antes y después de la marca de agua" width="800">
  <br>
  <em>Antes y después — un comando, el documento ahora es rastreable y evidencia manipulación.</em>
</p>

## Instalar

Desde [crates.io](https://crates.io/crates/firemark):


```bash
cargo install firemark
```
Desde la fuente:


```bash
git clone https://github.com/Vitruves/firemark.git
cd firemark
cargo install --path .
```
Produce un único binario optimizado (~5 MB).

## Inicio rápido


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
La salida se guarda junto con la entrada como `{name}-watermarked.{ext}` por defecto.  
Usa `-o` para establecer una ruta de salida explícita, o `-S` para un sufijo personalizado.  

## Tipos de marca de agua  

| Bandera | Estilo | Descripción |  
|---|---|---|  
| `diagonal` | Rejilla diagonal | Texto diagonal repetido en toda la página (por defecto) |  
| `stamp` | Sello de goma | Sello grande centrado con doble borde |  
| `stencil` | Plantilla | Letras militares de plantilla a ancho completo |  
| `typewriter` | Máquina de escribir | Texto monoespaciado estilo máquina de escribir |  
| `handwritten` | Firma | Firma estilo manuscrito con subrayado |  
| `redacted` | Redactado | Barras negras de redacción a ancho completo |  
| `badge` | Escudo | Emblema de escudo o placa de seguridad |  
| `ribbon` | Cinta | Banda diagonal de cinta en la esquina |  
| `seal` | Sello | Sello circular estilo notarial |  
| `frame` | Marco | Borde decorativo a toda la página |  
| `tile` | Baldosa | Rejilla de texto densa y uniforme |  
| `mosaic` | Mosaico | Texto disperso aleatoriamente |  
| `weave` | Trenzado | Trenzado diagonal entrelazado |  
| `ghost` | Fantasma | Texto en relieve ultra sutil |  
| `watercolor` | Acuarela | Efecto suave de lavado borroso |  
| `noise` | Ruido | Texto desgastado con ruido de píxeles |  
| `halftone` | Semitono | Texto como rejilla de puntos de semitono |


```bash
firemark doc.pdf -t stamp -m "CONFIDENTIAL" --border --color red
```

## Filigrana de seguridad

firemark superpone patrones criptográficos de filigrana inspirados en las características
de seguridad de los billetes. Estos finos patrones geométricos son extremadamente difíciles de
eliminar con editores de imágenes.

| Estilo | Descripción |
|---|---|
| `guilloche` | Bandas de envolvente de onda sinusoidal (predeterminado) |
| `rosette` | Espirógrafo + curvas de rosa en las esquinas |
| `crosshatch` | Rejilla fina de diamantes diagonales |
| `border` | Borde de seguridad ondulado anidado |
| `lissajous` | Figuras paramétricas de Lissajous |
| `moire` | Interferencia de círculos concéntricos |
| `spiral` | Vórtice de espiral aritmética |
| `mesh` | Rejilla hexagonal tipo panal |
| `plume` | Curvas fluidas semejantes a plumas esparcidas por la superficie |
| `constellation` | Nodos estelares conectados por una red geométrica fina |
| `ripple` | Frentes de ondas elípticas superpuestos desde orígenes aleatorios |
| `full` | Todos los patrones combinados |
| `none` | Desactivar filigrana |

```bash
firemark id.png -m "Rental application" --filigrane moire
firemark id.png -m "Rental application" --filigrane none   # disable
```

## Endurecimiento contra eliminación por IA

Cada render es no determinista por defecto. firemark aplica una
perturbación universal post-render (jitter alfa, ruido de color sub-píxel, micro-puntos en bordes,
píxeles fantasma dispersos) y una aleatorización por renderizador para que no haya dos salidas
idénticas a nivel de píxel — incluso con los mismos ajustes. Esto hace imposible que los modelos
de visión IA aprendan un patrón predecible para sustraer.

Además, se incrustan por defecto tiras adversariales de inyección de prompts para
confundir las herramientas de eliminación de marcas de agua por IA. Desactívelo con `--no-anti-ai` si no desea
el texto visible del prompt:

```bash
firemark doc.png -m "CONFIDENTIAL" --no-anti-ai
```

## Opciones comunes

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

Para la lista completa de más de 70 opciones, consulte [`CLI.md`](https://raw.githubusercontent.com/Vitruves/firemark/main/CLI.md).

## Opciones de PDF

```
    --pages           Pages to watermark (e.g. 1,3-5 or "all")
    --skip-pages      Pages to skip
    --behind          Place watermark behind content
    --no-flatten      Keep layers separate (flattened by default)
    --dpi             Render resolution (default: 150)
```

## Procesamiento por lotes

```bash
# Process all images and PDFs in a folder
firemark ./inbox/ -m "INTERNAL" -t tile

# Recursive, 8 threads, custom suffix
firemark ./docs/ -R -j 8 -m "Draft" -S draft

# Dry run — list what would be processed
firemark ./docs/ -R -m "Draft" -n
```

Los archivos ya marcados (que coinciden con el sufijo) se omiten automáticamente en
ejecuciones repetidas.

## Archivo de configuración

Guarde las opciones en un archivo TOML para evitar repetir los flags. Vea
[`examples/config/firemark.toml`](https://raw.githubusercontent.com/Vitruves/firemark/main/examples/config/firemark.toml) para un ejemplo completo con dos preajustes: **ultra-seguro** (rejilla densa, filigrana completa, trazabilidad QR, eliminación de metadatos) y **ligero** (texto diagonal simple, sin extras).



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

## Soporte de formato

| Formato | Entrada | Salida |
|---|---|---|
| PNG | sí | sí |
| JPEG | sí | sí |
| PDF | sí | sí |
| WebP | sí | sí |
| TIFF | sí | sí |

Se admite la conversión entre formatos (por ejemplo, `firemark photo.webp -o out.pdf`).

## Licencia

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-06

---