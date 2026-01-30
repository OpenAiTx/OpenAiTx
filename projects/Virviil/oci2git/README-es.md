
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
<img src="https://raw.githubusercontent.com/Virviil/oci2git/main/assets/logo.png" width="140px" />

# OCI2Git

[![Documentación](https://docs.rs/oci2git/badge.svg)][documentation]
[![Crates.io](https://img.shields.io/crates/v/oci2git.svg)](https://crates.io/crates/oci2git)
[![Licencia](https://img.shields.io/crates/l/oci2git.svg)](https://github.com/Virviil/oci2git/blob/master/LICENSE)
[![Descargas](https://img.shields.io/crates/d/oci2git.svg)](https://crates.io/crates/oci2git)

[//]: # (simulación para el futuro test.yaml)
[//]: # ([![Estado de Prueba]&#40;https://img.shields.io/github/actions/workflow/status/Virviil/oci2git/rust.yml?branch=master&event=push&label=Test&#41;]&#40;https://github.com/Virviil/oci2git/actions&#41;)

<div align="left"> </div>  
</div>

Una aplicación en Rust que convierte imágenes de contenedores (Docker, etc.) en repositorios Git. Cada capa del contenedor se representa como un commit de Git, preservando la historia y la estructura de la imagen original.

![Demostración de OCI2Git convirtiendo la imagen de nginx](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## Características

- Analiza imágenes Docker y extrae información de capas
- Crea un repositorio Git donde cada capa de la imagen se representa como un commit
- Soporte para capas vacías (ENV, WORKDIR, etc.) como commits vacíos
- Extracción completa de metadatos en formato Markdown
- Arquitectura extensible para soportar diferentes motores de contenedores

## Casos de uso

### Diferenciación de capas
Al solucionar problemas de contenedores, puedes usar las potentes capacidades de comparación de Git para identificar exactamente qué cambió entre dos capas. Al ejecutar `git diff` entre commits, los ingenieros pueden ver con precisión qué archivos se agregaron, modificaron o eliminaron, facilitando mucho la comprensión del impacto de cada instrucción Dockerfile y la localización de cambios problemáticos.
![Ejemplo de diferencia de capa](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### Rastreo de origen
Usando `git blame`, los desarrolladores pueden determinar rápidamente qué capa introdujo un archivo específico o línea de código. Esto es especialmente útil al diagnosticar problemas con archivos de configuración o dependencias. En lugar de inspeccionar manualmente cada capa, puedes rastrear inmediatamente el origen de cualquier archivo hasta su capa fuente y la instrucción Dockerfile correspondiente.

### Rastreo del ciclo de vida de archivos
OCI2Git te permite seguir el recorrido de un archivo específico a lo largo de la historia de la imagen del contenedor. Puedes observar cuándo se creó originalmente un archivo, cómo fue modificado en diferentes capas, y si/cuándo fue eliminado. Esta vista integral ayuda a entender la evolución del archivo sin tener que rastrear manualmente los cambios en docenas de capas potenciales.

Para rastrear el historial de un archivo en tu imagen de contenedor — incluyendo cuándo apareció por primera vez, fue cambiado, o eliminado — puedes usar estos comandos de Git después de la conversión:

```bash
# Full history of a file (including renames)
git log --follow -- /rootfs/my/file/path

# First appearance (i.e. creation) - see which layer introduced the file
git log --diff-filter=A -- /rootfs/my/file/path

# All changes made to the file (with diffs)
git log -p --follow -- /rootfs/my/file/path

# When the file was deleted
git log --diff-filter=D -- /rootfs/my/file/path

# Show short commit info (concise layer history)
git log --follow --oneline -- /rootfs/my/file/path
```
Estos comandos facilitan rastrear el historial completo de cualquier archivo a través de las capas del contenedor sin la complejidad de extraer y comparar manualmente los archivos tar de las capas.

### Análisis Multicapa
A veces, las comparaciones más reveladoras provienen de examinar cambios a través de múltiples capas no consecutivas. Con OCI2Git, puedes usar las herramientas de comparación de Git para analizar cómo evolucionaron los componentes a lo largo de varias etapas de construcción, identificando patrones que podrían ser invisibles al mirar solo capas adyacentes.

### Exploración de Capas
Al usar `git checkout` para moverte a cualquier commit específico, puedes examinar el sistema de archivos del contenedor exactamente como existía en esa capa. Esto permite a los desarrolladores inspeccionar el estado preciso de archivos y directorios en cualquier punto del proceso de creación de la imagen, proporcionando un contexto invaluable al depurar o examinar el comportamiento del contenedor.
![Checkout a commit anterior](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/checkout.png)

### Análisis Multi-Imagen

Al trabajar con múltiples imágenes de contenedor que comparten un ancestro común, OCI2Git crea ramas inteligentemente solo cuando las imágenes realmente divergen. Esto te permite analizar múltiples imágenes relacionadas en un único repositorio mientras preservas su historia común.


```bash
# Convert first image to create the base repository
oci2git postgres:16.9-alpine3.21 -o alp

# Convert second image to the same output folder
oci2git nginx:1.28.0-alpine-slim -o alp
```
OCI2Git detecta automáticamente las capas compartidas entre imágenes y crea una estructura de ramificación que refleja su base común. El historial de Git mostrará:
- Un tronco común que contiene todas las capas compartidas
- Ramas separadas que divergen solo cuando las imágenes realmente difieren
- Visualización clara de dónde las imágenes comparten ascendencia común vs. dónde se vuelven únicas
- Manejo inteligente de duplicados: si la misma imagen exacta se procesa dos veces, el algoritmo lo detecta antes del commit final de metadatos y omite la creación de una rama duplicada

Este enfoque es particularmente valioso para:
- **Análisis de familias de imágenes**: Comprender cómo diferentes variantes de una imagen (diferentes versiones, arquitecturas o configuraciones) se relacionan entre sí
- **Impacto de la imagen base**: Ver exactamente cómo los cambios en una imagen base afectan a múltiples imágenes derivadas
- **Oportunidades de optimización**: Identificar componentes compartidos que podrían aprovecharse mejor entre variantes de imágenes

![Estructura de repositorio multi-imagen mostrando base compartida y ramas divergentes](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### Casos de uso adicionales

- **Auditoría de seguridad**: Identifique exactamente cuándo se introdujeron paquetes o configuraciones vulnerables y rastree hasta instrucciones de compilación específicas.
- **Optimización de imagen**: Analice la estructura de capas para encontrar operaciones redundantes o archivos grandes que puedan consolidarse, ayudando a reducir el tamaño de la imagen.
- **Gestión de dependencias**: Controle cuándo se agregaron, actualizaron o eliminaron dependencias a lo largo del historial de la imagen.
- **Mejora del proceso de compilación**: Examine la composición de capas para optimizar instrucciones de Dockerfile y mejorar el caché y tamaño de la imagen.
- **Comparación entre imágenes**: Convierta varias imágenes relacionadas en repositorios Git y utilice las herramientas de comparación de Git para analizar sus diferencias y similitudes.

## Instalación

### Gestores de paquetes

#### macOS / Linux (Homebrew)


```bash
brew tap virviil/oci2git
brew install oci2git
```

#### Debian / Ubuntu

Descargue e instale el paquete .deb desde la [última versión](https://github.com/virviil/oci2git/releases/latest):

```bash
# For amd64 (x86_64)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_amd64.deb
sudo dpkg -i oci2git_VERSION_amd64.deb

# For arm64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_arm64.deb
sudo dpkg -i oci2git_VERSION_arm64.deb
```

#### Arch Linux (AUR)

```bash
# Using yay
yay -S oci2git-bin

# Using paru
paru -S oci2git-bin

# Manual installation
git clone https://aur.archlinux.org/oci2git-bin.git
cd oci2git-bin
makepkg -si
```

### Binarios precompilados

Descarga el binario apropiado para tu plataforma desde la [última versión](https://github.com/virviil/oci2git/releases/latest):

```bash
# Linux x86_64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-linux-x86_64.tar.gz
tar xzf oci2git-linux-x86_64.tar.gz
sudo mv oci2git-linux-x86_64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git

# macOS (Apple Silicon)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-darwin-aarch64.tar.gz
tar xzf oci2git-darwin-aarch64.tar.gz
sudo mv oci2git-darwin-aarch64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git
```

### Desde Crates.io

```bash
cargo install oci2git
```

### Desde la fuente

```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

## Uso

```bash
oci2git [OPTIONS] <IMAGE>
```
Argumentos:  
  `<IMAGE>`  Nombre de la imagen a convertir (por ejemplo, 'ubuntu:latest') o ruta al archivo tar cuando se usa el motor tar  

Opciones:  
  `-o, --output <o>`  Directorio de salida para el repositorio Git [por defecto: ./container_repo]  
  `-e, --engine <ENGINE>`  Motor de contenedor a usar (docker, nerdctl, tar) [por defecto: docker]  
  `-h, --help`            Imprimir información de ayuda  
  `-V, --version`         Imprimir información de la versión  

Variables de Entorno:  
  `TMPDIR`  Establezca esta variable de entorno para cambiar la ubicación predeterminada usada para el procesamiento intermedio de datos. Esto depende de la plataforma (por ejemplo, `TMPDIR` en Unix/macOS, `TEMP` o `TMP` en Windows).  

## Ejemplos  

Usando el motor Docker (por defecto):

```bash
oci2git -o ./ubuntu-repo ubuntu:latest
```

Usando un archivo tarball de imagen ya descargado:
```bash
oci2git -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```

El motor tar espera un tarball en formato OCI válido, que típicamente se crea con `docker save`:
```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

Esto creará un repositorio Git en `./ubuntu-repo` que contiene:
- `Image.md` - Metadatos completos sobre la imagen en formato Markdown
- `rootfs/` - El contenido del sistema de archivos del contenedor

El historial de Git refleja el historial de capas del contenedor:
- El primer commit contiene solo el archivo `Image.md` con metadatos completos
- Cada commit subsiguiente representa una capa de la imagen original
- Los commits incluyen el comando Dockerfile como mensaje del commit

## Estructura del Repositorio

```
repository/
├── .git/
├── Image.md     # Complete image metadata
└── rootfs/      # Filesystem content from the container
```
## Requisitos

- Rust edición 2021
- Docker CLI (para soporte del motor Docker)
- Git

## Licencia

MIT

[documentación]: https://docs.rs/oci2git/




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---