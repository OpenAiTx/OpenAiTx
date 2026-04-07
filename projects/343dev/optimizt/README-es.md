# @343dev/optimizt

<img align="right" width="176" height="176"
     alt="Logo de Optimizt: señal de OK con la imagen de la Mona Lisa entre los dedos"
     src="https://raw.githubusercontent.com/343dev/optimizt/main/./docs/logo.png">

[![npm](https://img.shields.io/npm/v/@343dev/optimizt.svg)](https://www.npmjs.com/package/@343dev/optimizt)
[![Docker](https://img.shields.io/docker/v/343dev/optimizt?label=Docker)](https://hub.docker.com/r/343dev/optimizt)

**Optimizt** es una herramienta de línea de comandos que ayuda a preparar imágenes para la web.

Puede comprimir PNG, JPEG, GIF y SVG con pérdida o sin pérdida, y crear versiones AVIF y WebP para imágenes rasterizadas.

## Justificación

Como desarrolladores frontend, tenemos que cuidar las imágenes: comprimir PNG y JPEG, eliminar partes inútiles de SVG, crear AVIF y WebP para navegadores modernos, y así sucesivamente. Un día, nos cansamos de usar un montón de aplicaciones para eso, y creamos una herramienta que hace todo lo que queremos.

## Uso

Instalar:

```sh
npm install -g @343dev/optimizt
```

¡Optimiza!

```sh
optimizt path/to/picture.jpg
```

## Opciones de Línea de Comandos

- `--avif` — crear versiones AVIF de las imágenes.
- `--webp` — crear versiones WebP de las imágenes.
- `-f, --force` — recrear versiones AVIF y WebP aunque ya existan.
- `-l, --lossless` — optimizar sin pérdida en lugar de con pérdida.
- `-v, --verbose` — mostrar salida detallada (p. ej. archivos omitidos).
- `-c, --config` — usar un archivo de configuración personalizado en lugar del predeterminado.
- `-o, --output` — escribir resultados en el directorio especificado.
- `-p, --prefix` — añadir prefijo a los nombres de archivos optimizados.
- `-s, --suffix` — añadir sufijo a los nombres de archivos optimizados.
- `-V, --version` — mostrar la versión de la herramienta.
- `-h, --help` — mostrar mensaje de ayuda.

## Ejemplos de Uso

```bash
# optimize a single image
optimizt path/to/picture.jpg

# optimize multiple images losslessly
optimizt --lossless path/to/picture.jpg path/to/another/picture.png

# recursively create AVIF and WebP versions for all images in a directory
optimizt --avif --webp path/to/directory

# recursively optimize JPEG files in the current directory
find . -iname \*.jpg -exec optimizt {} +
```

## Diferencias entre con pérdida y sin pérdida

### Con pérdida (predeterminado)

Ofrece el mejor equilibrio entre la reducción del tamaño del archivo y la pérdida mínima de calidad visual.

### Sin pérdida (bandera `--lossless`)

- **AVIF/WebP**: Utiliza compresión sin pérdida.
- **PNG/JPEG/GIF**: Maximiza la calidad de la imagen a costa de tamaños de archivo más grandes.
- **SVG**: Las configuraciones son idénticas en ambos modos.

## Configuración

El procesamiento de imágenes utiliza:

- [sharp](https://github.com/lovell/sharp) para [JPEG](https://sharp.pixelplumbing.com/api-output#jpeg), [PNG](https://sharp.pixelplumbing.com/api-output#png), [WebP](https://sharp.pixelplumbing.com/api-output#webp) y [AVIF](https://sharp.pixelplumbing.com/api-output#avif).
- [svgo](https://github.com/svg/svgo) para SVG.
- [gifsicle](https://github.com/kohler/gifsicle) para GIF.

> [!NOTA]
> En modo sin pérdida para JPEG, se usa [Guetzli](https://github.com/google/guetzli). La optimización repetida puede degradar la calidad visual.

Las configuraciones predeterminadas están definidas en [.optimiztrc.cjs](./.optimiztrc.cjs), que incluye todos los parámetros soportados. Deshabilite cualquier parámetro configurándolo como `false`.

Al usar `--config path/to/.optimiztrc.cjs`, se usará el archivo de configuración especificado. Si no se proporciona `--config`, Optimizt busca recursivamente desde el directorio actual hacia arriba el archivo `.optimiztrc.cjs`. Si no se encuentra ninguno, se aplican los valores predeterminados.

## Solución de problemas

### Errores como “spawn guetzli ENOENT”.

Asegúrese de que la opción npm [ignore-scripts](https://docs.npmjs.com/cli/v6/using-npm/config#ignore-scripts) esté deshabilitada.
Detalles: [funbox/optimizt/issues/9](https://github.com/funbox/optimizt/issues/9).

## Docker

### Imagen preconstruida

```bash
# pull latest
docker pull 343dev/optimizt

# pull specific version
docker pull 343dev/optimizt:9.0.2
```

### Compilación Manual

```bash
# clone repository
git clone https://github.com/343dev/optimizt.git
cd optimizt

# build image
docker build --tag 343dev/optimizt .
```

Alternativamente:

```bash
# build directly from GitHub
# ignores .dockerignore (see: https://github.com/docker/cli/issues/2827)
docker build --tag 343dev/optimizt https://github.com/343dev/optimizt.git
```

### Ejecutar Contenedor

```bash
# mount current directory to /src in the container
docker run --rm --volume $(pwd):/src 343dev/optimizt --webp ./image.png
```

## Integraciones

Optimizt funciona perfectamente con:

- [IDEs de JetBrains](https://raw.githubusercontent.com/343dev/optimizt/main/./docs/jetbrains.md)
- [Visual Studio Code](https://raw.githubusercontent.com/343dev/optimizt/main/./docs/vscode.md)
- [Sublime Text 3](https://raw.githubusercontent.com/343dev/optimizt/main/./docs/sublime-text.md)
- [Flujo de trabajo de GitHub Actions](https://raw.githubusercontent.com/343dev/optimizt/main/./docs/github.md)

## Artículos

- [anuwong.com](https://anuwong.com/blog/2023-08-21-save-tons-of-gbs-with-optimizt/) — Comprime archivos antes de subirlos, ahorra toneladas de GB. 🇹🇭
- [Linux Format, Número 277 (julio 2021)](https://www.linuxformat.com/archives?issue=277#:~:text=Kitchen%20Tales%2C%20zFRAG%2C-,Optimizt,-and%20SingleFileZ.) — Optimizt es ideal para reducir la huella en disco de las imágenes sin ninguna reducción en la calidad.

## Créditos

La imagen linda para el proyecto fue hecha por [Igor Garybaldi](http://pandabanda.com/).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-07

---