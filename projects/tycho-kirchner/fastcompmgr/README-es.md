# fastcompmgr

__fastcompmgr__ es un compositor _rápido_ para X, un fork de una versión temprana
de __Compton__ que es un fork de __xcompmgr-dana__ que es un fork
de __xcompmgr__.

Solía usar el buen y viejo xcompmgr por mucho tiempo, porque compton siempre
se sentía un poco lento al mover/redimensionar ventanas o hacer scroll cinético
en una página web. Habiendo probado el último picom-10.2, parece que las cosas empeoraron
(a ver el benchmark abajo). Sin embargo, xcompmgr no dibuja sombras
en ventanas argb (por ejemplo, algunos terminales) y
tiene varios otros fallos. Por eso viajé de regreso a 2011, cuando
esta característica fue recién añadida, seleccioné algunos commits posteriores de compton
para eliminar segfaults y fugas de memoria espurias y hice esa versión aún
más rápida, basado en perfilado.
Por ejemplo, los eventos de mover y redimensionar ventanas están limitados en su
conteo de eventos y renderizados a una tasa de cuadros algo fija, mientras que
el desplazamiento sigue siendo tan rápido como sea posible. Las ventanas ocultas no son
pintadas y las asignaciones/liberaciones de memoria se evitan en gran medida,
permitiendo repintados más rápidos de la pantalla.
En la parte negativa, el desvanecimiento actualmente está roto (yo no lo uso). Perdón
por eso (;

## Benchmark
Mientras en mi Dell Latitude E5570 mover, redimensionar y desplazar ventanas
*se siente* claramente más rápido, también hay algunos números que apoyan esta
observación. Dado un número de ventanas de chromium apiladas, donde ninguna ventana
está completamente oculta, realicé las operaciones respectivas *a mano*,
así que por favor tenga en cuenta que el benchmark no es muy sofisticado. El driver
del touchpad `xserver-xorg-input-synaptics` fue usado, que habilita desplazamiento
cinético (¿Wayland alguien?). Se midieron los siguientes usos de CPU:

| Compositor    | mover | redimensionar | desplazar |
| ------------- | ----- | ------------- | --------- |
| fastcompmgr   | 6.7%  | 4.4%          | 1.5%      |
| xcompmgr      | 7.8%  | 4.9%          | 1.6%      |
| compton       | 26.4% | 6.8%          | 17.1%     |
| picom         | 29.3% | 8.1%          | 23.1%     |


Se usaron herramientas con las siguientes opciones:
~~~
(v0.1) fastcompmgr -o 0.4 -r 12 -c -C
(v1.1.8 de Debian 11) xcompmgr -o 0.4 -r 12 -c -C
(v1 de Debian 11) compton --config /dev/null --backend xrender -o 0.4 -r 12 -c -C
(v10.2) picom --config /dev/null --backend xrender -o 0.4 -r 12 -c

# Calcular promedio usando
$ fastcompmgr -o 0.4 -r 12 -c -C &  pid=$!; sleep 4; \
    top -b -n 20 -d 0.5 -p $pid | LC_ALL=C awk -v pid=$pid \
    '$1==PID {++PIDCOUNT} $1==pid && PIDCOUNT>1 {print $9}' |  \
    datamash mean 1; kill $pid
~~~



## Instalación
Si eres perezoso, simplemente descarga el binario desde la [página de lanzamientos](https://github.com/tycho-kirchner/fastcompmgr/releases).

De lo contrario, instala las versiones de desarrollo de las siguientes librerías:
### Dependencias:

* libx11
* libxcomposite
* libxdamage
* libxfixes
* libxrender
* pkg-config
* make

Para compilar:

~~~ bash
$ make
$ make install
~~~

## Uso

~~~ bash
$ fastcompmgr -o 0.4 -r 12 -c -C
~~~
Todas las opciones (actualmente el desvanecimiento no funciona):
~~~
   -d pantalla
    Qué pantalla debe ser gestionada.
   -r radio
    El radio de desenfoque para las sombras. (por defecto 12)
   -o opacidad
    La translucidez para las sombras. (por defecto .75)
   -l desplazamiento-izquierdo
    El desplazamiento izquierdo para las sombras. (por defecto -15)
   -t desplazamiento-superior
    El desplazamiento superior para las sombras. (por defecto -15)
   -m opacidad
    La opacidad para los menús. (por defecto 1.0)
   -c
    Activa sombras del lado del cliente en las ventanas.
   -C
    Evita dibujar sombras en ventanas de dock/panel.
   -i opacidad
    Opacidad de ventanas inactivas. (0.1 - 1.0)
   -e opacidad
    Opacidad de barras de título y bordes de ventanas. (0.1 - 1.0)
    --shadow-red valor
    Valor del color rojo de la sombra (0.0 - 1.0, por defecto 0).
    --shadow-green valor
    Valor del color verde de la sombra (0.0 - 1.0, por defecto 0).
    --shadow-blue valor
    Valor del color azul de la sombra (0.0 - 1.0, por defecto 0).

~~~


## Licencia

xcompmgr se ha extendido. Según puedo saber, la línea de este
árbol en particular es algo así:

* Keith Packard (autor original)
* Matthew Hawn
* ...
* Dana Jansens
* Christopher Jeffrey
* Tycho Kirchner

Sin contar las decenas de personas que hicieron fork intermedios.

Consulte LICENSE para más información.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-17

---