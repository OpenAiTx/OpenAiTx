# ZigStar GW Multi tool
[![Build](https://github.com/xyzroe/ZigStarGW-MT/actions/workflows/build.yml/badge.svg)](https://github.com/xyzroe/ZigStarGW-MT/actions/workflows/build.yml)
[![GitHub version](https://img.shields.io/github/release/xyzroe/ZigStarGW-MT.svg)](https://github.com/xyzroe/ZigStarGW-MT/releases)
[![GitHub download](https://img.shields.io/github/downloads/xyzroe/ZigStarGW-MT/total.svg)](https://github.com/xyzroe/ZigStarGW-MT/latest)
[![License](https://img.shields.io/github/license/xyzroe/ZigStarGW-MT.svg)](LICENSE.txt)


> ⚠️ **ARCHIVADO / SIN MANTENIMIENTO**
>
> Este proyecto ahora está archivado y no recibirá más actualizaciones.
> 
> Le invito amablemente a probar la nueva herramienta basada en web [XZG Multi-Tool](https://github.com/xyzroe/XZG-MT), que ofrece funcionalidad mejorada y soporte continuo. 🚀

  
es un envoltorio GUI diseñado inicialmente para un trabajo de servicio conveniente con Zig Star LAN GW  
pero ahora soporta cualquier stick o gateway Zigbee basado en TI CC1352/CC2538/CC2652, independientemente del fabricante. 

Multi tool está empaquetado en un único archivo ejecutable.  
Puede comenzar sin instalar Python y los módulos requeridos, y sin usar la terminal, - solo descargue y ejecute.

## Posibilidades:
- Leer / Escribir / Borrar memoria NVRAM del módulo Zigbee
- Escribir / Verificar / Borrar firmware del módulo Zigbee
- Carga trasera Serial Loader se activa automáticamente
- Reinicio manual del módulo Zigbee o ESP32 está disponible

#### Capturas de pantalla

<table>
<tr> 
<td width="50%">

##### Windows
<img src="https://github.com/xyzroe/ZigStarGW-MT/raw/main/images/win.png">
</td>
<td>

##### OS X
<img src="https://github.com/xyzroe/ZigStarGW-MT/raw/main/images/osx.png">
</td>
</tr>
</table>

## Instrucciones:
### 1. Identificar Puerto
#### Puertas de enlace de red:
Si está utilizando ZigStar LAN GW, la dirección IP se detectará automáticamente, de lo contrario ingrese la IP:PUERTO de su puerta de enlace.
#### Memorias USB:
Haga clic en el botón de actualización para identificar la unidad USB y seleccione su dispositivo en la lista desplegable.
<br>  
<div align="center"><img src="https://zig-star.com/images/radio-docs/multitool/multitool-1.png"></div>


### 2.A Actualización de firmware
- Elija el archivo de firmware *.hex en su disco.
- Seleccione las opciones requeridas. Normalmente es Borrar, Escribir y Verificar.
- Si necesita cambiar la dirección IEEE, escríbala y marque la casilla Escribir IEEE.
- Presione el botón "Iniciar" para comenzar los procesos seleccionados.

Si se realiza alguna acción en el lado derecho de la Multi Tool, la dirección IEEE primaria se coloca en el campo correspondiente. (Reemplazando la ingresada manualmente o la leída anteriormente)

*Para puertas de enlace o memorias USB distintas a ZigStar, puede que necesite habilitar BSL manualmente.  
Además, si usa una puerta de enlace que no sea ZigStar, debe desmarcar la casilla Auto-BSL.*
<br>  
<div align="center"><img src="https://zig-star.com/images/radio-docs/multitool/multitool-2.png"></div>


### 2.B Herramientas NVRAM
Si tiene problemas con la red Zigbee, la herramienta NVRAM puede ayudarle.

- El botón **Leer** guarda un archivo *.json en su disco con el estado actual de NVRAM de su módulo Zigbee para restauración futura.
- El botón **Escribir** lee un archivo *.json de su disco con el estado guardado de NVRAM y lo escribe en su módulo Zigbee.
- El botón **Borrar** limpia la NVRAM de su módulo Zigbee para una instalación limpia.
<div align="center"><img src="https://zig-star.com/images/radio-docs/multitool/multitool-3.png"></div>

### ¿Te gusta ♥️?
[!["Buy Me A Coffee"](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/xyzroe)


### Basado en
[zigpy/zigpy-znp](https://github.com/zigpy/zigpy-znp)  
[JelmerT/cc2538-bsl](https://github.com/JelmerT/cc2538-bsl)  

  

<br>  

xyzroe/ZigStarGW-MT is licensed under the  
##### [GNU General Public License v3.0](https://github.com/xyzroe/ZigStarGW-MT/blob/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-05

---