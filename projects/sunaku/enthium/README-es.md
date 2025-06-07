# Enthium - Engrammer se encuentra con Hands Down Promethium

![Fotografía de Enthium v7 en mi teclado Glove80](
https://github.com/sunaku/glove80-keymaps/raw/main/README/base-layer-photograph-Enthium.jpg
)

Esta adaptación de los diseños de teclado [Engrammer] y [Hands Down Promethium]
mejora el rendimiento del último en los analizadores de diseños de teclado (ver abajo)
al espejarlo horizontalmente para restaurar la familiaridad con el diseño [Engram 2.0 de Arno]
(CIEA en la fila central de la mano izquierda; PF intercambiado con WV para parecerse a Engram)
y el diseño [Dvorak] (HTNS en la fila central de la mano derecha), y al optimizar
la colocación de los signos de puntuación para la programación en el espíritu del diseño Engrammer.

Cabe destacar que las diferencias entre Engram/mer y Enthium son tan mínimas que uno
puede cambiar completamente a este con aproximadamente 6 horas de práctica, repartidas en 2-3
días (comenzando viernes y usando el fin de semana), para desbloquear todas las letras en el entrenamiento de [KeyBr].

Véase también: [mi publicación en el blog]( https://sunaku.github.io/enthium-keyboard-layout.html
) sobre el inesperado viaje "por la madriguera del conejo" que me llevó a desarrollar este
diseño de teclado.

[Hands Down Promethium]: https://reddit.com/r/KeyboardLayouts/comments/1g66ivi
[Arno's Engram 2.0]:     https://engram.dev
[Engrammer]:             https://github.com/sunaku/engrammer
[Dvorak]:                https://www.dvzine.org
[KeyBr]:                 https://github.com/aradzie/keybr.com#readme

## Diseño

      q y o u - x l d w z
    b c i e a , k h t n s v
      ' / = . ; j m g p f
                r

>![Renderizado de Enthium v7 en un teclado de portátil.](https://raw.githubusercontent.com/sunaku/enthium/main/linux/layout.png)
>![Renderizado de Enthium v7 en mi teclado Glove80.](
https://github.com/sunaku/glove80-keymaps/raw/main/README/base-layer-diagram-Enthium.png
)

<!-- vim-markdown-toc GFM -->

* [Justificación](#justificación)
  * [Desviación: PF y WV](#desviación-pf-y-wv)
  * [Desviación: B y V](#desviación-b-y-v)
* [Rendimiento](#rendimiento)
  * [Analizador Cyanophage](#analizador-cyanophage)
  * [Analizador KeySolve](#analizador-keysolve)
  * [Analizador de Oxey](#analizador-de-oxey)
  * [Comparación](#comparación)
* [Instalación](#instalación)
  * [Configuración en Linux](#configuración-en-linux)
  * [Configuración en MacOS](#configuración-en-macos)
    * [Instalación](#instalación-1)
    * [Modificación compleja](#modificación-compleja)
    * [Desinstalación](#desinstalación)
* [Licencia](#licencia)

<!-- vim-markdown-toc -->

## Justificación

* Q y Z están separadas en manos diferentes para balance y simetría.

* B y V están en las teclas laterales de meñique de la fila central (CapsLock, Comilla simple)
  para evitar estirarse hacia arriba para personas con meñiques cortos o [debilitados].

* La comilla simple está alejada (en un dedo completamente distinto) de YOU e I, así
  puede escribirse sin bigramas de mismo dedo como `you'd` e `I'd`.

* La coma y el punto y coma están agrupados para búsquedas cíclicas f/F/t/T en Vim
  y también para reflejar el orden relativo de K y J en la mano derecha.

* Aunque el punto y la coma están invertidos en términos de sus símbolos con mayúsculas
  `>` y `<`, esta disposición ayuda a reducir bigramas de estiramiento lateral
  y también los apila verticalmente en teclados tradicionales de filas escalonadas.

* El guion está en el dedo índice (igual que la coma, el punto y el punto y coma)
  para una responsabilidad consistente de los signos de puntuación delimitadores de palabra/oración
  y por facilidad de acceso al frecuente guion bajo `_` en programación,
  especialmente en teclados escalonados donde su posición sigue la
  dirección natural de extensión del índice izquierdo, minimizando el esfuerzo.

* Barra y punto permiten alternar `/.`, `./` y rutas de sistema de archivos `../`.

[debilitados]: https://reddit.com/r/KeyboardLayouts/comments/1fy8nve/_/lqulnww/

### Desviación: PF y WV

PF se intercambia con WV para abordar las siguientes incomodidades:

* WN es un bigrama de ascenso escalonado con el mismo dedo que preferiría poder rastrillar hacia abajo
* DW (salto de 2u) no es tan conveniente para Vim como en Engram (donde están adyacentes)
* FG (salto de 2u) no es tan conveniente para trabajos en segundo plano en shell (`bg`, `fg`) como en Engram
* SW (media tijera) se siente un poco más débil doblando hacia adentro que extendiéndose hacia arriba (como en Engram)
* FF (ej. "stu*ff*") es un poco trabajoso para el meñique al pulsar dos veces en la fila superior

Realmente no quería desviarme del diseño canónico Hands Down Promethium
(este derivado "Enthium" solo iba a ser un simple espejo horizontal,
más algunos signos de puntuación rearranjados), así que fui de mala gana a los
analizadores de diseño de teclado a ver qué tan malo sería intercambiar PF por WV... y
para mi total sorpresa, ¡este cambio apenas afectó el rendimiento del diseño!

* El analizador de Oxey no mostró ningún cambio en las estadísticas.
* El analizador KeySolve mostró un aumento en FSB de 0.14% a 0.37% pero las otras
  estadísticas mejoraron: FSS se redujo de 0.82% a 0.48%, HSB se redujo de 6.05% a
  5.64%, y HSS se redujo de 5.97% a 5.50%; todo lo demás fue idéntico.
* El Total Word Effort del analizador Cyanophage aumentó de 730.9 a 735.9 pero el resto
  de las estadísticas se mantuvieron igual.

Estoy _tan feliz_ de que este experimento haya funcionado porque hace el diseño mucho más
cómodo para mí en la práctica y además reduciría aún más la barrera de entrada
para quienes buscan cambiar a Enthium desde el diseño Engrammer. :)

### Desviación: B y V

B y V rotan desde la fila superior hacia la lateral de la fila central para
evitar estirarse hacia arriba para personas con meñiques cortos o [debilitados]. Sus teclas
se reasignan a las letras menos frecuentes en inglés: Q y Z.

En el analizador Cyanophage, este cambio reduce las Tijeras Meñique/Anular de 0.49%
a 0.35% (¡una caída masiva!) y Bigramas de salto (2u) de 0.30% a 0.29%.
Los otros analizadores no comprenden completamente la ubicación de las teclas laterales de meñique,
como se explica en la nota al principio de cada subtítulo de analizador,
pero el analizador de Oxey reporta una reducción notable en SFBs de 0.829% a 0.818%.

## Rendimiento

### [Analizador Cyanophage][cNT]

> **NOTA:** Este analizador actualmente tiene la limitación de que solo soporta
> colocar una letra en el pulgar izquierdo y no en el derecho, por lo que este diseño se
> espeja horizontalmente para su análisis. El espejado no afecta los resultados.

![Captura de pantalla](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/cyanophage.png)

Estadísticas generales:
* Total Word Effort: 748.5
* Effort:            432.54

Uso de dedos:
* Bigramas de mismo dedo: 0.55%
* Bigramas de salto (2u): 0.29%
* Bigramas de estiramiento lateral: 0.23%
* Tijeras meñique/anular: 0.34%

Estadísticas de trigramas:
* alt:             37.45%
* bigram roll in:  29.02%
* bigram roll out: 14.67%
* other:           8.28%
* alt sfs:         5.10%
* redirect:        2.14%
* roll in:         1.71%
* weak redirect:   1.32%
* roll out:        0.31%

### [Analizador KeySolve](https://grassfedreeve.github.io/keysolve-web/)

> **NOTA:** Este analizador actualmente no soporta colocar letras en las teclas laterales
> de meñique de la fila central como la tradicional tecla CapsLock y la comilla simple,
> por lo que estos resultados pueden no ser precisos. Por ejemplo, el porcentaje SFB aquí
> asume que R B V se escriben todos con el pulgar cuando en realidad están en
> diferentes dedos: R en el pulgar derecho, B en el meñique izquierdo, V en el meñique derecho.

![Captura de pantalla](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve1.png)
![Captura de pantalla](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve2.png)
![Captura de pantalla](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve3.png)

Estadísticas generales:

    BIGRAMS     SFB: 0.97%      LSB: 0.44%      HSB: 4.79%      FSB: 0.35%
    SKIPGRAMS   SFS: 6.99%      LSS: 0.92%      HSS: 4.66%      FSS: 0.38%
    TRIGRAMS    ALT: 41.24%     ROL: 40.71%     ONE: 2.47%      RED: 1.66%

Uso de dedos:

    IZQUIERDA   LI: 13.91%      LM: 20.17%      LR: 8.70%       LP: 3.05%
    DERECHA     RI: 13.12%      RM: 14.59%      RR: 10.60%      RP: 7.94%
    TOTAL               LH: 45.83%                      RH: 54.17%

Fuente personalizada para copiar/pegar:

    q y o u - x l d w z
    c i e a , k h t n s
    ' / = . ; j m g p f
    r b v

### [Analizador de Oxey](https://oxey.dev/playground/index.html)

> **NOTA:** Este analizador actualmente no soporta colocar letras en las teclas laterales
> de meñique de la fila central como la tradicional tecla CapsLock y la comilla simple,
> por lo que estos resultados pueden no ser precisos. Por ejemplo, el porcentaje SFB aquí
> asume que B y V se escriben con el pulgar izquierdo cuando en realidad están en
> diferentes dedos: B con el meñique izquierdo y V con el meñique derecho.

![Captura de pantalla](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/oxey.png)

Estadísticas generales:
* Sfb:              0.811%
* Dsfb:             6.286%
* Lsb:              0.372%
* Inrolls:          29.442%
* Outrolls:         15.841%
* Total Rolls:      45.283%
* Onehands:         2.348%
* Alternates:       31.877%
* Alternates (sfs): 7.284%
* Total Alternates: 39.161%
* Redirects:        3.864%
* BadRedirects:     1.002%
* Total Redirects:  4.866%
* Other:            8.341%
* Invalid:          0.001%

Uso de dedos:

    dedo 0:   3.63%   dedo 9:       8.60%
    dedo 1:   9.08%   dedo 8:       10.65%
    dedo 2:   19.30%  dedo 7:       14.56%
    dedo 3:   13.28%  dedo 6:       12.33%

    Mano izquierda:   45.29% Mano derecha:     46.14%
    Centro izquierda: 1.384% Centro derecha:   1.189%

    Uso de teclas centrales: 56.37%

Sfb% por dedo:

    dedo 0:   0.011%  dedo 9:       0.024%
    dedo 1:   0.047%  dedo 8:       0.100%
    dedo 2:   0.122%  dedo 7:       0.051%
    dedo 3:   0.339%  dedo 6:       0.114%

### Comparación

> **NOTA:** El analizador de Oxey actualmente no soporta colocar letras en las teclas laterales
> de meñique de la fila central como la tradicional tecla CapsLock y la comilla simple,
> por lo que estos resultados pueden no ser precisos. Por ejemplo, el porcentaje SFB aquí
> asume que B y V se escriben con el pulgar izquierdo cuando en realidad están en
> diferentes dedos: B con el meñique izquierdo y V con el meñique derecho.
> En su lugar, considere los [resultados del analizador Cyanophage](#analizador-cyanophage)
> porque tiene en cuenta las teclas laterales de meñique y una tecla de pulgar para letras.

La [comunidad de diseños de teclado][rKL] suele recomendar la [guía y tabla comparativa de Pascal Getreuer][PGt]
como punto de partida para la exploración de diseños,
y verás que Enthium está entre los mejores (estadísticamente) diseños allí:

* 0.811% SFBs -- 🥈 segundo lugar; superado solo por Focal
* 0.372% LSBs -- 🥇 primer lugar; ¡mejor que toda la tabla!
* 45.283% rolls -- mejor que Nerps, Gallium, MTGAP, Graphite, Dvorak, Halmak, etc.
* 4.866% redirects -- mejor que MTGAP, Sturdy, Recurva, APTv3, Canary, Colemak, etc.
* 2.80% meñique fuera _excluyendo_ lateral -- mejor que Graphite, Canary, Gallium, MTGAP, etc.
  * `Q` (0.10%) + `'` (0.48%) + `Z` (0.10%) + `F` (2.12%)
* 5.35% meñique fuera _incluyendo_ lateral -- mejor que Engram, Halmak; superado por el resto
  * `Q` (0.10%) + `'` (0.48%) + `Z` (0.10%) + `F` (2.12%) + `B` (1.49%) + `V` (1.06%)

[rKL]: https://www.reddit.com/r/KeyboardLayouts/
[PGt]: https://getreuer.info/posts/keyboards/alt-layouts/index.html#which-alt-keyboard-layout-should-i-learn

Para mayor detalle, he tabulado todas las [estadísticas de este y diseños relacionados](https://raw.githubusercontent.com/sunaku/enthium/main/stats/):

[cNT]: https://cyanophage.github.io/playground.html?layout=zwdlx-uoyq%5Csnthk%2Caeicbfpgmj%3B.%3D%2F%27vr&mode=ergo&lan=english
[cPM]: https://cyanophage.github.io/playground.html?layout=fpdlx%3Buoybzsnthk%2Caeicqvwgmj-.%27%3D%2F%5Cr&mode=ergo&lan=english
[cNG]: https://cyanophage.github.io/playground.html?layout=byou%27%3Bldwvzciea%2C.htsnqgxjk-%2Frmfp%5C%5E&mode=ergo&lan=english
[cDV]: https://cyanophage.github.io/playground.html?layout=%27%2C.pyfgcrl%2Faoeuidhtns-%3Bqjkxbmwvz%5C%5E&mode=ergo&lan=english
[cCD]: https://cyanophage.github.io/playground.html?layout=qwfpbjluy%3B-arstgmneio%27zxcdvkh%2C.%2F%5C%5E&mode=ergo&lan=english

| Analizador | Categoría | Estadística           | [Enthium][cNT] | [Promethium][cPM] | [Engrammer][cNG] | [Dvorak][cDV] | [Colemak-DH][cCD] |
| ---------- | --------- | --------------------- | -------------- | ----------------- | ---------------- | ------------- | ----------------- |
| Oxey's     | Bigramas  | SFB                   | 0.811%         | 0.868%            | 1.511%           | 2.779%        | 1.367%            |
| Oxey's     | Bigramas  | DSFB                  | 6.286%         | 6.761%            | 7.620%           | 6.979%        | 8.767%            |
| Oxey's     | Bigramas  | LSB                   | 0.372%         | 0.404%            | 0.671%           | 1.255%        | 1.975%            |
| Oxey's     | Trigramas | Inrolls               | 29.442%        | 29.333%           | 28.273%          | 23.820%       | 25.173%           |
| Oxey's     | Trigramas | Outrolls              | 15.841%        | 14.526%           | 14.050%          | 15.104%       | 20.940%           |
| Oxey's     | Trigramas | Total Rolls           | 45.283%        | 43.858%           | 42.323%          | 38.924%       | 46.113%           |
| Oxey's     | Trigramas | Onehands              | 2.348%         | 2.189%            | 2.146%           | 0.624%        | 2.484%            |
| Oxey's     | Trigramas | Alternates            | 31.877%        | 33.770%           | 32.483%          | 35.769%       | 22.913%           |
| Oxey's     | Trigramas | Alternates (SFS)      | 7.284%         | 8.205%            | 8.752%           | 8.787%        | 7.461%            |
| Oxey's     | Trigramas | Total Alternates      | 39.161%        | 41.974%           | 41.235%          | 44.556%       | 30.375%           |
| Oxey's     | Trigramas | Redirects             | 3.864%         | 2.273%            | 3.103%           | 2.639%        | 9.081%            |
| Oxey's     | Trigramas | BadRedirects          | 1.002%         | 1.236%            | 1.386%           | 0.818%        | 1.498%            |
| Oxey's     | Trigramas | Total Redirects       | 4.866%         | 3.509%            | 4.489%           | 3.458%        | 10.579%           |
| Oxey's     | Trigramas | Other                 | 8.341%         | 8.468%            | 9.806%           | 12.437%       | 9.202%            |
| Oxey's     | Trigramas | Invalid               | 0.001%         | 0.001%            | 0.001%           | 0.001%        | 1.248%            |
| Oxey's     | Uso       | Dedo 0                | 3.63%          | 9.56%             | 6.58%            | 8.50%         | 8.12%             |
| Oxey's     | Uso       | Dedo 1                | 9.08%          | 10.65%            | 9.21%            | 8.72%         | 8.04%             |
| Oxey's     | Uso       | Dedo 2                | 19.30%         | 14.56%            | 19.47%           | 12.99%        | 11.55%            |
| Oxey's     | Uso       | Dedo 3                | 13.28%         | 12.33%            | 13.35%           | 14.95%        | 19.19%            |
| Oxey's     | Uso       | Dedo 6                | 12.33%         | 13.28%            | 16.04%           | 16.33%        | 18.88%            |
| Oxey's     | Uso       | Dedo 7                | 14.56%         | 19.77%            | 14.93%           | 13.73%        | 15.60%            |
| Oxey's     | Uso       | Dedo 8                | 10.65%         | 9.01%             | 10.31%           | 13.84%        | 10.11%            |
| Oxey's     | Uso       | Dedo 9                | 8.60%          | 4.62%             | 9.90%            | 10.59%        | 7.77%             |
| Oxey's     | Uso       | Mano izquierda        | 45.29%         | 47.10%            | 48.61%           | 45.16%        | 46.89%            |
| Oxey's     | Uso       | Mano derecha          | 46.14%         | 46.68%            | 51.18%           | 54.49%        | 52.36%            |
| Oxey's     | Uso       | Centro izquierda      | 1.384%         | 1.189%            | 1.765%           | 9.208%        | 4.592%            |
| Oxey's     | Uso       | Centro derecha        | 1.189%         | 1.384%            | 1.294%           | 7.257%        | 3.393%            |
| Oxey's     | Uso       | Teclas centrales      | 56.37%         | 56.37%            | 56.37%           | 56.70%        | 62.31%            |
| Oxey's     | SFB%      | Dedo 0                | 0.011%         | 0.028%            | 0.012%           | 0.020%        | 0.041%            |
| Oxey's     | SFB%      | Dedo 1                | 0.047%         | 0.100%            | 0.089%           | 0.028%        | 0.047%            |
| Oxey's     | SFB%      | Dedo 2                | 0.122%         | 0.051%            | 0.230%           | 0.253%        | 0.186%            |
| Oxey's     | SFB%      | Dedo 3                | 0.339%         | 0.114%            | 0.591%           | 1.075%        | 0.219%            |
| Oxey's     | SFB%      | Dedo 6                | 0.114%         | 0.339%            | 0.380%           | 0.433%        | 0.388%            |
| Oxey's     | SFB%      | Dedo 7                | 0.051%         | 0.185%            | 0.053%           | 0.494%        | 0.341%            |
| Oxey's     | SFB%      | Dedo 8                | 0.100%         | 0.040%            | 0.098%           | 0.256%        | 0.137%            |
| Oxey's     | SFB%      | Dedo 9                | 0.024%         | 0.011%            | 0.058%           | 0.220%        | 0.007%            |
| KeySolve   | Bigramas  | SFB                   | 0.97%          | 0.94%             | 1.56%            | 2.62%         | 1.49%             |
| KeySolve   | Bigramas  | LSB                   | 0.44%          | 0.45%             | 0.98%            | 1.17%         | 2.21%             |
| KeySolve   | Bigramas  | HSB                   | 4.79%          | 6.04%             | 3.02%            | 6.11%         | 5.93%             |
| KeySolve   | Bigramas  | FSB                   | 0.35%          | 0.26%             | 0.30%            | 0.14%         | 0.37%             |
| KeySolve   | Skipgrams | SFS                   | 6.99%          | 7.02%             | 7.50%            | 7.00%         | 7.95%             |
| KeySolve   | Skipgrams | LSS                   | 0.92%          | 0.93%             | 1.34%            | 4.48%         | 1.75%             |
| KeySolve   | Skipgrams | HSS                   | 4.66%          | 6.11%             | 6.91%            | 8.56%         | 6.49%             |
| KeySolve   | Skipgrams | FSS                   | 0.38%          | 0.78%             | 0.81%            | 1.22%         | 0.78%             |
| KeySolve   | Trigramas | ALT                   | 41.24%         | 40.37%            | 39.59%           | 41.70%        | 27.58%            |
| KeySolve   | Trigramas | ROL                   | 40.71%         | 40.84%            | 39.35%           | 37.19%        | 42.78%            |
| KeySolve   | Trigramas | ONE                   | 2.47%          | 2.66%             | 2.65%            | 0.43%         | 2.45%             |
| KeySolve   | Trigramas | RED                   | 1.66%          | 1.78%             | 2.65%            | 2.25%         | 6.74%             |
| KeySolve   | Uso       | LI                    | 13.91%         | 13.91%            | 13.91%           | 14.56%        | 18.82%            |
| KeySolve   | Uso       | LM                    | 20.17%         | 20.92%            | 20.30%           | 13.96%        | 10.18%            |
| KeySolve   | Uso       | LR                    | 8.70%          | 8.70%             | 8.83%            | 9.55%         | 7.83%             |
| KeySolve   | Uso       | LP                    | 3.05%          | 3.64%             | 5.72%            | 8.24%         | 7.63%             |
| KeySolve   | Uso       | RI                    | 13.12%         | 13.12%            | 16.52%           | 16.90%        | 20.00%            |
| KeySolve   | Uso       | RM                    | 14.59%         | 14.59%            | 15.03%           | 13.35%        | 16.91%            |
| KeySolve   | Uso       | RR                    | 10.60%         | 10.60%            | 10.08%           | 13.36%        | 10.46%            |
| KeySolve   | Uso       | RP                    | 7.94%          | 8.95%             | 9.47%            | 10.08%        | 8.16%             |
| KeySolve   | Total     | LH                    | 45.83%         | 47.18%            | 48.75%           | 46.31%        | 44.46%            |
| KeySolve   | Total     | RH                    | 54.17%         | 52.82%            | 51.25%           | 53.69%        | 55.54%            |
| Cyanophage | Resumen   | Total Word Effort     | 748.5          | 732.3             | 899.8            | 1185.5        | 1048.2            |
| Cyanophage | Resumen   | Effort                | 432.54         | 398.07            | 457.44           | 769.78        | 535.05            |
| Cyanophage | Bigramas  | Same Finger Bigrams   | 0.55%          | 0.58%             | 0.99%            | 1.87%         | 0.91%             |
| Cyanophage | Bigramas  | Skip Bigrams (2u)     | 0.29%          | 0.36%             | 0.39%            | 0.45%         | 0.41%             |
| Cyanophage | Bigramas  | Lat Stretch Bigrams   | 0.23%          | 0.24%             | 0.41%            | 0.80%         | 1.27%             |
| Cyanophage | Bigramas  | Pinky/Ring Scissors   | 0.34%          | 0.42%             | 0.71%            | 0.40%         | 0.65%             |
| Cyanophage | Trigramas | Alt                   | 37.45%         | 36.98%            | 35.62%           | 39.08%        | 25.43%            |
| Cyanophage | Trigramas | Alt SFS               | 5.10%          | 5.27%             | 5.93%            | 5.85%         | 5.47%             |
| Cyanophage | Trigramas | Roll in               | 1.71%          | 1.37%             | 1.82%            | 0.86%         | 1.50%             |
| Cyanophage | Trigramas | Roll out              | 0.31%          | 0.11%             | 0.29%            | 0.27%         | 0.98%             |
| Cyanophage | Trigramas | Bigram roll in        | 29.02%         | 29.18%            | 28.14%           | 23.51%        | 25.18%            |
| Cyanophage | Trigramas | Bigram roll out       | 14.67%         | 14.56%            | 14.03%           | 15.14%        | 21.55%            |
| Cyanophage | Trigramas | Redirect              | 2.14%          | 2.03%             | 3.05%            | 2.57%         | 9.22%             |
| Cyanophage | Trigramas | Weak redirect         | 1.32%          | 1.30%             | 1.40%            | 0.28%         | 1.52%             |
| Cyanophage | Trigramas | Other                 | 8.28%          | 9.20%             | 9.72%            | 12.44%        | 9.17%             |

## Instalación

### Configuración en Linux

>*Leyenda:* QWERTY=blanco; Engram=oro; Enthium=azul/verde; Peculiaridades=rosa.
>![Renderizado de este diseño en un teclado de filas escalonadas.](https://raw.githubusercontent.com/sunaku/enthium/main/linux/layout.png)

Instalar:

    cd linux/
    sudo make install
    echo Ahora reinicia tu sesión gráfica.

Activar:

    setxkbmap -layout us    -variant enthium         # un diseño; sin intercambio
    setxkbmap -layout us,us -variant enthium,basic   # intercambio dual de diseño

Reparar (ej. cuando una actualización global de XKB revierta la instalación):

    cd linux/
    sudo make reinstall
    echo Ahora reinicia tu sesión gráfica.

Desinstalar:

    cd linux/
    sudo make uninstall
    echo Ahora reinicia tu sesión gráfica.

### Configuración en MacOS

#### Instalación

Para usar el diseño en MacOS, necesitas instalar [Karabiner-Elements](https://karabiner-elements.pqrs.org/).

Puedes instalarlo vía [Homebrew](https://brew.sh/):

    brew install --cask karabiner-elements

O descargarlo desde el sitio principal de [Karabiner-Elements](https://karabiner-elements.pqrs.org/).

Una vez descargado, simplemente sigue las instrucciones de la [guía de instalación](https://karabiner-elements.pqrs.org/docs/getting-started/installation/).

#### Modificación compleja

Una vez todo instalado, puedes usar la [función de modificación compleja](https://karabiner-elements.pqrs.org/docs/manual/configuration/configure-complex-modifications/) para reasignar tus teclas.

La modificación compleja de Enthium está disponible [aquí](https://ke-complex-modifications.pqrs.org/?q=enthium).

Para volver al diseño básico, simplemente elimina la modificación compleja de Enthium.

#### Desinstalación

* Brew : `brew uninstall --cask karabiner-elements`
* Manual : Elimina `Karabiner-Elements.app` de tu carpeta de Aplicaciones.

## Licencia

Publicado bajo los mismos términos que las fuentes del diseño de teclado [Engram 2.0 de Arno]:

> Licencia MIT
>
> Copyright 2022 Ricard Figueroa <https://github.com/rfiga>  
> Copyright 2021 Suraj Kurapati <https://github.com/sunaku>  
> Copyright 2021 Arno Klein <https://github.com/binarybottle>  
>
> Por la presente se concede permiso, de forma gratuita, a cualquier persona que obtenga una copia
> de este software y los archivos de documentación asociados (el "Software"), para tratar
> el Software sin restricción, incluyendo sin limitación los derechos
> de usar, copiar, modificar, fusionar, publicar, distribuir, sublicenciar y/o vender
> copias del Software, y permitir a las personas a quienes se les proporcione el Software
> hacer lo mismo, sujeto a las siguientes condiciones:
>
> El aviso de copyright anterior y este aviso de permiso deberán incluirse en
> todas las copias o partes sustanciales del Software.
>
> EL SOFTWARE SE PROPORCIONA "TAL CUAL", SIN GARANTÍA DE NINGÚN TIPO, EXPRESA O
> IMPLÍCITA, INCLUYENDO PERO NO LIMITADO A LAS GARANTÍAS DE COMERCIALIZACIÓN,
> IDONEIDAD PARA UN PROPÓSITO PARTICULAR Y NO INFRACCIÓN. EN NINGÚN CASO LOS
> AUTORES O TITULARES DEL COPYRIGHT SERÁN RESPONSABLES POR NINGÚN RECLAMO, DAÑO U OTRA
> RESPONSABILIDAD, YA SEA EN UNA ACCIÓN DE CONTRATO, AGRAVIO O DE OTRA MANERA, QUE SURJA DE,
> O EN CONEXIÓN CON EL SOFTWARE O EL USO U OTROS TRATOS EN EL
> SOFTWARE.

---------------------------------------------------------------------------
[Spare A Life]: https://sunaku.github.io/vegan-for-life.html
> ¿Te gusta mi trabajo? 👍 Por favor [¡salva una vida!] hoy como agradecimiento 🐄🐖🐑🐔🐣🐟✨🙊✌  
> ¿Por qué? Por ética 💕, el medio ambiente 🌎 y salud 💪; ver enlace arriba. 🙇

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---