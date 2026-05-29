<div align="center">

![kirsch](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/header.png)

</div>

## Tabla de Contenidos

- [Tabla de Contenidos](#table-of-contents)
- [Resumen](#overview)
- [Galería](#gallery)
- [Instalación/Uso](#installation/usage)
  - [Nerd Fonts](#nerd-fonts)
  - [Propo](#propo)
  - [Nixpkgs](#nixpkgs)
  - [Nix Flakes](#nix-flakes)
  - [Web](#web)
- [Notas de Diseño](#design-notes)
  - [Adornos](#flourishes)
  - [Espacios](#gaps)
- [Contribuciones](#contributing)
- [Créditos](#credits)
- [Licencias](#licensing)

## Resumen

**kirsch** /ˈkɪərʃ/ _s._

1. _(Alemán)_ cereza.

1. _(Russell A. Kirsch, 1929 - 2020)_ Ingeniero estadounidense reconocido como el
   desarrollador del primer escáner de imágenes digital y el inventor del píxel.

1. Una fuente bitmap monoespaciada con un cuadro delimitador de 6x16 (5px ancho promedio, 4px descenso,
   12px ascenso, 5px altura-x, 9px altura de mayúscula). Toma prestadas formas de letras y motivos de diversas
   fuentes para crear una sensación humanista distintiva en un tamaño compacto.

   Algunos glifos provienen de [Cozette](https://github.com/slavfox/Cozette), a menudo
   con modificaciones para adherirse al diseño de kirsch.

## Galería

<details>
<summary><strong>Glifos</strong></summary>
<div align="center">

![glifos kirsch](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/chars.png)

</div>
</details>

<details>
<summary><strong>Mapa de Glifos</strong></summary>
<div align="center">

![mapa de glifos kirsch](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/map.png)

</div>
</details>

<details open>
<summary><strong>Muestras</strong></summary>
<div align="center">

![muestra kirsch](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/sample.png)

</div>
</details>

## Instalación/Uso

Descargue desde [Releases](https://github.com/molarmanful/kirsch/releases).
Incluye formatos bitmap - OTB, BDF, PCF, DFONT (para usuarios de Mac) - así como
TTF. Hay versiones 2x disponibles para pantallas HiDPI. Nota que PCF no contiene
glifos más allá de U+FFFF.

Para la experiencia de visualización más nítida, intente usar los formatos bitmap cuando
sea posible. Si las fuentes bitmap no son compatibles con su plataforma (p. ej. Windows,
VSCode), entonces use el TTF en tamaños de fuente que sean múltiplos de 16px.

> [!TIP]
> Si necesitas el tamaño de fuente en pt, usa la siguiente conversión:
>
> `pt = px * 72 / dpi`
>
> p.ej. 16px en una pantalla de 96dpi es `16px * 72 / 96dpi = 12pt`.

### Nerd Fonts

kirsch viene con glifos personalizados de Nerd Fonts. El soporte aún está en desarrollo. Por razones de claridad visual, los glifos de Nerd Fonts de kirsch tienden a sobresalir ampliamente más allá de sus anchos. He dibujado estos glifos con la expectativa de que se vean mejor cuando estén acolchonados antes y después con un espacio simple.

Las Nerd Fonts parcheadas que cubren el resto de los Nerd Fonts están disponibles. La variante "Mono" usa glifos más pequeños (de ancho simple en lugar de doble) y funciona para terminales que no pueden mezclar anchos.

### Propo

Para terminales como foot con sangrado parcial, hay una variante Propo de kirsch disponible. Esta variante ajusta los glifos para que sus celdas no sean cortadas por el renderizador de fuentes del terminal.

### Nixpkgs

Gracias a [@ejiektpobehuk](https://github.com/ejiektpobehuk), kirsch está disponible en Nixpkgs como `kirsch`.

### Nix Flakes

Las versiones de kirsch también se envían a
[FlakeHub](https://flakehub.com/flake/molarmanful/kirsch). `kirsch` (alias `default`) es el paquete base, mientras que `kirsch-nerd` incluye los parches de Nerd Fonts.

### Web

Generalmente desaconsejaría el uso de kirsch en la web debido a la falta de soporte bitmap. Pero para los obstinados y valientes, WOFF2 está disponible. También hay una
[hoja de estilos alojada en CDN](https://cdn.jsdelivr.net/npm/kirsch@latest/kirsch.css)










para mayor comodidad.

```html
<link
  rel="stylesheet"
  href="https://cdn.jsdelivr.net/npm/kirsch@latest/kirsch.css"
/>
```
## Notas de Diseño

A diferencia de mi fuente anterior [eldur](https://github.com/molarmanful/eldur), que tenía
un ancho medio de carácter de apenas 4px con el que trabajar, kirsch tiene un ancho medio de carácter de 5px. Ese
1px de ancho extra ofrece una sorprendente cantidad de margen para el diseño. Muchas
más glifos encajan cómodamente en un ancho de 5px - por ejemplo "m" y "w" - lo que
significa que esos glifos no romperán el kerning ni invadirán los espacios de los glifos vecinos.
Los glifos que no caben en un ancho de 5px ahora pueden trabajar con un ancho de 7px, lo que
mantiene el equilibrio y la legibilidad sin afectar demasiado el kerning.

### Florituras

![rogue fijian xylophone](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/design-flourishes.png)

Las florituras - por ejemplo en la "i" o la "f" - son una elección estilística, pero también
cumplen una función práctica. Sin las florituras, la "i" ocuparía 1px de
ancho, dejando 4px de espacio incómodo. Las florituras de 2px en cada lado de la "i" le dan
un ancho de 5px, abordando así el problema del kerning de manera estilosa.

En el caso de la "l", las florituras de estilo script la distinguen aún más de otros
caracteres verticales como `1I|`.

### Espacios

![bad queen peg 69](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/design-gaps.png)

Una de las características distintivas de kirsch es la presencia de un espacio en las curvas de
las letras. Rellenar el espacio haría que las letras fueran demasiado cuadradas o demasiado
apretadas, mientras que dejar el espacio abierto despeja las formas de las letras. Los espacios también
evocan terminaciones de trazo de estilo script.

## Contribuciones

¡Se aceptan problemas, solicitudes de características/glifos y solicitudes de extracción! Los archivos de fuente
se editan mediante [bited](https://github.com/molarmanful/bited).

## Créditos

Estos son proyectos que me han inspirado/ayudado a crear kirsch y que valen 100% la pena

comprobando.

- [Bits'n'Picas](https://github.com/kreativekorp/bitsnpicas)
- [Cozette](https://github.com/slavfox/Cozette)
- [Página de Prueba de Fuente Cyreal](http://www.cyreal.org/Font-Testing-Page/)
- [Demostración W3 UTF-8](https://www.w3.org/2001/06/utf-8-test/UTF-8-demo.html) /
  [Demostración Markus Kuhn UTF-8](https://antofthy.gitlab.io/info/data/utf8-demo.txt)
- [APL386](https://abrudz.github.io/APL386)

## Licencia

Hecho con ♥ por [los Autores del Proyecto kirsch](AUTHORS). Lanzado bajo la Licencia OFL-1.1.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---