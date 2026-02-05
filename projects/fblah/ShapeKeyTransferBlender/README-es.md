## Herramientas de Shape Key para Blender
<!-- BADGES/ -->
<span class="badge-blenderartists"><a href="https://blenderartists.org/t/free-shape-key-transfer-addon" title="Enlace al post en el foro Blender Artists"><img src="https://img.shields.io/badge/Blender-Artists-orange.svg?logo=blender&longCache=true&style=popout-square" alt="Post en el foro Blender Artists" /></a></span>
<span class="badge-discord"><a href="https://discord.gg/CmgdEvw" title="Únete en discord"><img src="https://img.shields.io/badge/Discord-Join-768ADC.svg?logo=discord&longCache=true&style=popout-square" alt="Botón del servidor de Discord" /></a></span>
<span class="badge-youtube"><a href="https://www.youtube.com/watch?v=-zBlaedkkVs" title="Ver tutorial en Youtube"><img src="https://img.shields.io/badge/Tutorial-Video-F40000.svg?logo=youtube&longCache=true&style=popout-square" alt="Tutorial en Youtube" /></a></span>

Shape Key Transfer para Blender 2.93

Usa este addon para transferir fácilmente shape keys entre mallas con topologías diferentes.

Coloca ambas mallas en el origen y superpónlas en la ubicación donde quieres que la malla destino copie las shape keys de la malla fuente.

Este addon fue creado inicialmente para copiar shape keys del personaje ManuelBastioniLab a otras mallas, pero puede usarse en cualquier situación.

Este addon está basado en el código dentro de este [post de StackoverFlow](https://blender.stackexchange.com/questions/119836/scripting-transferring-shape-keys-between-different-meshes/119867#119867) hecho por mí.

El addon estará en Herramientas -> Herramientas de Shape Key

También puedes excluir shape keys.

Usa Increment Radius para aumentar el número de vértices de la malla fuente que afectan a la malla destino.

Cuando Use Closest Vertex está desactivado promediará las posiciones de todos los vértices cercanos dentro del Increment Radius.

#### Menos vértices en la malla fuente harán que la operación sea más rápida.

##

### Características:

- Transferir Shape Keys entre mallas con topologías diferentes

- Gestionar qué shape keys se transfieren añadiendo exclusiones

- Copiar todos los nombres de shape keys de una malla al portapapeles

### Casos de uso de ejemplo:

- Copiar shape keys de la cara a tarjetas de bigote o cejas.

- Copiar las shape keys de la malla base al LOD.

##

### Nota:
A veces es bueno duplicar la malla fuente y eliminar los vértices que consideres que no son necesarios para afectar la malla destino.

Un ejemplo en caso de un bigote y una cara: Duplica la cara y elimina todos los vértices excepto los que están alrededor de los labios, que son los que probablemente influirán en el bigote, y usa la malla resultante como fuente para copiar las shape keys a tus tarjetas de cabello de bigote o malla destino.

Se añadirá más funcionalidad a este addon si es necesario. También puedes eliminar todas las shape keys en una malla fácilmente con esta herramienta.

##

### Licencia:

Addon de Transferencia de Shape Keys para Blender - Copyright (C) 2018 Ajit Christopher D'Monte

Todos los archivos python se publican bajo la Licencia Pública General GNU 3.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-05

---