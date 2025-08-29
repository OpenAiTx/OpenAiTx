# MangaJaNai

[![Discord](https://img.shields.io/discord/1121653618173546546?label=Discord&logo=Discord&logoColor=white)](https://discord.gg/EeFfZUBvxj)

<a href="./mangajanaiv1demo.webp?raw=1"><img src="https://raw.githubusercontent.com/the-database/MangaJaNai/main/mangajanaiv1demo.webp"/></a>
<p align="center"><sup>(clic en la imagen para ampliar)</sup></p>

## Visión General

MangaJaNai es una colección de modelos de ampliación para manga. Los modelos están principalmente optimizados para ampliar imágenes digitales de manga con texto en japonés o inglés con alturas que van desde aproximadamente 1200px hasta 2048px.

Únete al [**servidor de Discord JaNai**](https://discord.gg/EeFfZUBvxj) para obtener las últimas noticias, descargar modelos pre-lanzamiento y experimentales, obtener soporte y hacer preguntas, compartir tus ampliaciones o compartir tus comentarios. 日本語も大丈夫です。

## Instrucciones de Uso

### Ampliación con MangaJaNaiConverterGui

Para una experiencia sencilla y lista para usar, utiliza [MangaJaNaiConverterGui](https://github.com/the-database/MangaJaNaiConverterGui) para ampliar tu manga con los modelos MangaJaNai.

## Modelos MangaJaNai
Aunque el manga se produce a muy alta resolución (más de 10000px) y se imprime con excelente calidad en ediciones físicas, los mangas digitales oficiales suelen tener baja resolución y están plagados de artefactos JPEG y moiré. El objetivo de los modelos MangaJaNai es ampliar mangas digitales en blanco y negro de baja calidad para producir resultados que limpien los artefactos JPEG y moiré, entregando resultados que se aproximen más a las versiones impresas en libro.

La mayoría de los mangas se producen con puntos de semitono, pero algunas ediciones digitales están tan degradadas que los puntos de semitono ya no son visibles. Los modelos MangaJaNai pueden parecer que crean puntos que no estaban en la imagen original, pero en la mayoría de los casos los modelos restauran correctamente puntos que ya no eran visibles en la imagen fuente de baja calidad. Para asegurar que los semitonos se generen con el tamaño y frecuencia correctos, se entrenaron varios modelos MangaJaNai, cada uno optimizado para usarse en imágenes con una de siete alturas diferentes, correspondientes a los tamaños de imagen más comunes en mangas digitales en Japón: 1200p, 1300p, 1400p, 1500p, 1600p, 1920p y 2048p. [MangaJaNaiConverterGui](https://github.com/the-database/MangaJaNaiConverterGui) selecciona automáticamente el mejor modelo según la resolución de la imagen de entrada.

## Modelos IllustrationJaNai
Dado que los modelos MangaJaNai solo son adecuados para páginas de manga en blanco y negro, se entrenaron modelos suplementarios IllustrationJaNai para usarse en imágenes a color de manga, como portadas y páginas a color. Estos modelos fueron entrenados para eliminar artefactos comunes de imagen, como artefactos JPEG y puntos de semitono impresos de baja resolución, y también funcionan bien como modelos de ampliación de propósito general para arte digital. [MangaJaNaiConverterGui](https://github.com/the-database/MangaJaNaiConverterGui) selecciona automáticamente el modelo IllustrationJaNai para imágenes a color.

## Proyectos Relacionados

- [mpv-upscale-2x_animejanai](https://github.com/the-database/mpv-upscale-2x_animejanai): Ampliación en tiempo real de anime a 4k en mpv con modelos compactos Real-ESRGAN
- [MangaJaNaiConverterGui](https://github.com/the-database/MangaJaNaiConverterGui): Interfaz gráfica para Windows para ampliación de manga con modelos MangaJaNai
- [traiNNer-redux](https://github.com/the-database/traiNNer-redux): Software para entrenar modelos de ampliación

## Agradecimientos
- [422415](https://github.com/422415) por asistencia significativa en la preparación del conjunto de datos y retroalimentación continua durante el desarrollo de los modelos V1
- Miembros del servidor JaNai Discord por asistencia con recursos de manga:
    - Alexandros
    - umzi
    - M7MedOo
    - Gnathonic
- Miembros del servidor de Discord de JaNai para retroalimentación continua sobre modelos beta:
    - junmittens
    - SOUNDSPHERE BEST GAME
    - marv
    - Big_herooooo
    - avc1657
    - risho
- [traiNNer-redux](https://github.com/joeyballentine/traiNNer-redux)
- [Dataset Destroyer](https://github.com/Kim2091/helpful-scripts/tree/main/Dataset%20Destroyer)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---