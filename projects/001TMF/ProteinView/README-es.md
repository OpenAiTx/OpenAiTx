<p align="center">
  <b>P R O T E Í N A V I S T A</b>
</p>

<p align="center">
  <em>Explora estructuras moleculares en tu terminal</em>
</p>

<p align="center">
  <a href="LICENSE"><img src="https://img.shields.io/badge/License-MIT-blue.svg" alt="Licencia: MIT"></a>
  <a href="https://www.rust-lang.org/"><img src="https://img.shields.io/badge/Rust-1.85%2B-orange.svg" alt="Rust"></a>
  <img src="https://img.shields.io/badge/version-0.3.0-green.svg" alt="Versión">
  <a href="https://github.com/001TMF/ProteinView/pulls"><img src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg" alt="PRs Bienvenidos"></a>
  <a href="https://www.linkedin.com/in/tristan-farmer-973b7a17a/"><img src="https://img.shields.io/badge/LinkedIn-Tristan%20Farmer-0A66C2?logo=linkedin" alt="LinkedIn"></a>
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/hero-histone.png" alt="Partícula núcleo de nucleosoma con proteínas histonas y ADN renderizado en modo FullHD" width="700">
</p>

<p align="center">
  <sub>Partícula núcleo de nucleosoma — octámero de histonas envuelto en ADN, renderizado con el protocolo gráfico Kitty</sub>
</p>

---

Visor de estructuras moleculares para terminal — carga, rota y explora proteínas, ácidos nucleicos y pequeñas moléculas desde archivos PDB/CIF directamente en tu terminal. Sin navegador, sin GUI, sin dependencias.

## Características

- **3 modos de renderizado** — Braille, HD y FullHD (Sixel/Kitty) con detección automática de SSH
- **Protocolo Kitty comprimido en PNG** — ~10-20 veces más pequeño que RGBA sin comprimir, haciendo viable FullHD vía SSH
- **Visualización de cintas tipo cartoon** — cintas sombreadas con Lambert y niebla de profundidad para hélices, láminas y bucles
- **Soporte para RNA/ADN** — modos backbone, alambre y cartoon con coloreado por tipo de base
- **Renderizado de pequeñas moléculas** — ligandos como bola y palo, iones como esferas
- **Análisis de interfaz** — contactos entre cadenas, bolsillos de unión y visualización de interacciones (puentes de hidrógeno, puentes salinos, contactos hidrofóbicos)
- **7 esquemas de color** — estructura, cadena, elemento (CPK), factor B, arcoíris, pLDDT (AlphaFold)
- **Controles interactivos** — rotación estilo vim, zoom, paneo con auto-rotación
- **PDB & mmCIF** — soporte para ambos formatos, con descarga desde RCSB PDB (`--fetch`)
- **Binario estático único** — sin dependencias en tiempo de ejecución
## Modos de Renderizado

Tres niveles de renderizado para adaptarse a tu terminal y conexión:

<p align="center">
  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/render-modes-grid.png" alt="Comparación de renderizado Braille vs HD vs FullHD" width="700">
</p>

<p align="center">
  <sub>Izquierda: Braille (funciona en todas partes, incluyendo SSH/tmux) · Centro: HD (braille sombreado con Lambert) · Derecha: FullHD (gráficos de píxeles Kitty)</sub>
</p>

| Modo | Tecla | Calidad | Rendimiento SSH |
|------|-------|---------|-----------------|
| **Braille** | predeterminado | Basado en texto, monocromo por celda | Excelente |
| **HD** | `m` | Braille sombreado con iluminación + niebla de profundidad | Excelente |
| **FullHD** | `M` | Gráficos de píxeles Sixel/Kitty | Bueno (PNG comprimido) |

`--hd` detecta SSH: por defecto usa HD en SSH, FullHD localmente. Usa `--fullhd` para forzar gráficos de píxeles.

## Modos de Visualización

<p align="center">
  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/viz-modes-grid.png" alt="Modos de visualización Cartoon, Wireframe y Backbone" width="700">
</p>

<p align="center">
  <sub>Izquierda: Cartoon (cinta) · Centro: Wireframe (todo átomo) · Derecha: Backbone (traza CA)</sub>
</p>

| Modo | Descripción |
|------|-------------|
| **Cartoon** | Renderizado de cinta suave — hélices, hojas beta y vueltas con sombreado Lambert. Predeterminado. |
| **Wireframe** | Enlaces de todos los átomos incluyendo enlaces peptídicos y fosfodiéster entre residuos. |
| **Backbone** | Traza CA (proteínas) / traza C4' (ácidos nucleicos) con esferas y líneas gruesas conectivas. |

## Análisis de Interfaz e Interacciones

<p align="center">

  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/interface-grid.png" alt="Análisis de interfaz con visualización de interacciones" width="700">
</p>

<p align="center">
  <sub>Izquierda: Coloración de residuos de interfaz con panel lateral · Derecha: Líneas de interacción discontinuas (puentes de hidrógeno, puentes salinos, contactos hidrofóbicos)</sub>
</p>

Presione `f` para alternar el modo de interfaz — resalta los residuos de contacto a través de los límites de cadenas con un panel lateral detallado. Presione `I` para superponer líneas de interacción:

| Color | Interacción | Distancia |
|-------|-------------|----------|
| Cian | Puente de hidrógeno | &le; 3.5 &Aring; |
| Rojo | Puente salino | &le; 4.0 &Aring; |
| Amarillo | Contacto hidrofóbico | &le; 4.5 &Aring; |
| Gris | Otro | &le; 4.5 &Aring; |

## Ácidos nucleicos

<p align="center">
  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/dna-element.png" alt="Doble hélice de B-ADN con coloración por elemento (CPK)" width="500">
</p>

<p align="center">
  <sub>Dodecámero de B-ADN en modo alambre con coloración por elemento CPK</sub>
</p>

Soporte completo para estructuras de ADN y ARN — trazos de la columna vertebral, enlaces en modo alambre y cintas tipo caricatura con coloración por tipo de base nucleotídica (A=rojo, U/T=azul, G=verde, C=amarillo).

## AlphaFold y pLDDT

<p align="center">
  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/plddt-cartoon.png" alt="Predicción de AlphaFold con coloración de confianza pLDDT" width="500">
</p>

<p align="center">
  <sub>Predicción de AlphaFold con coloración de confianza pLDDT — azul (alta confianza) a naranja/amarillo (baja confianza)</sub>
</p>

Detecta automáticamente estructuras de AlphaFold y ofrece coloración de confianza pLDDT. Cambie los esquemas de color con `c`.

## Instalación

Requiere [Rust 1.85+](https://www.rust-lang.org/tools/install). Si no tienes Rust, instálalo con:

```bash
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh
```

Luego instala proteinview:

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
## Inicio Rápido


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
## Atajos de Teclado

| Tecla | Acción |
|-------|--------|
| `h`/`l` | Rotar Y |
| `j`/`k` | Rotar X |
| `u`/`i` | Rodar |
| `+`/`-` | Zoom |
| `w`/`a`/`s`/`d` | Desplazar |
| `r` | Restablecer vista |
| `c` | Cambiar esquema de colores |
| `v` | Cambiar modo de visualización |
| `m` | Braille / HD |
| `M` | HD / FullHD |
| `f` | Análisis de interfaz |
| `I` | Interacciones de interfaz |
| `g` | Alternar ligandos |
| `[`/`]` | Cadena anterior/siguiente |
| `Space` | Rotación automática |
| `?` | Ayuda |
| `q` | Salir |

## Esquemas de Colores

| Esquema | Descripción |
|---------|-------------|
| **Estructura** | Hélice (rojo), hoja (amarillo), lazo (verde). Por defecto. |
| **Cadena** | Color distinto por cadena. |
| **Elemento** | Colores CPK (C, N, O, S, P, metales). |
| **B-factor** | Azul (rígido) a rojo (flexible). |
| **Arcoíris** | N-terminus (azul) a C-terminus (rojo). |
| **pLDDT** | Confianza AlphaFold (azul=alta, naranja=baja). |

## Soporte de Terminal

| Terminal | Braille | HD | FullHD |
|----------|---------|----|--------|
| Cualquier terminal Unicode | Sí | Sí | -- |
| Kitty | Sí | Sí | Sí (PNG) |

| WezTerm | Sí | Sí | Sí (Sixel) |
| iTerm2 | Sí | Sí | Sí |
| foot | Sí | Sí | Sí (Sixel) |
| tmux/screen | Sí | Sí | -- |

## Construcción

```bash
cargo build --release

# With RCSB fetch support
cargo build --release --features fetch
```

## Contribuyendo

¡Las contribuciones son bienvenidas! Aquí te mostramos cómo empezar:

1. Haz un fork del repositorio
2. Crea una rama de funciones (`git checkout -b feature/mi-funcion`)
3. Realiza tus cambios y añade pruebas
4. Ejecuta `cargo test` para verificar
5. Abre un pull request contra `develop`

Por favor, abre un issue primero para cambios importantes y discutir el enfoque.

## Licencia

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-17

---