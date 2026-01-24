# Serie de Adaptadores de Programación EPROM 27C322/160/800/400

![GitHub issues](https://img.shields.io/github/issues-raw/mafe72/27c160-tl866-adapter?logo=Github&style=for-the-badge)

## Introducción

Este adaptador convierte las asignaciones de pines de las piezas listadas abajo (que son similares a las ROMs enmascaradas en encapsulado DIP contemporáneas) al pinout de 27C4096 tal como lo soporta la serie TL866 de programadores USB, que es económica y fácilmente disponible.

Las EPROMs soportadas son:
- **27C400:** 40 pines, 4Mbit (256k x 16 bits, 512k x 8 bits)
- **27C800:** 42 pines, 8Mbit (512k x 16 bits, 1M x 8 bits)
- **27C160:** 42 pines, 16Mbit (1M x 16 bits, 2M x 8 bits)
- **27C322:** 42 pines, 32Mbit (2M x 16 bits, sin modo de acceso de 8 bits)

## Diseño

Este adaptador fue diseñado usando KiCad 5.0, puedes encontrar los archivos del proyecto en la carpeta llamada kicad-project.

Lado Superior:

![top](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/front_th.png)

Lado Inferior:

![bottom](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/back_th.png)

## Uso

Inserta el adaptador de programación en el TL866 con las asas del zócalo adyacentes entre sí. Inserta la EPROM en la posición más baja posible del adaptador y con el pin 1 más cercano al asa.

![Adapter when in use](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/adapter_in_use.jpg)

Si vas a programar una EPROM 27C322, mueve el interruptor a la **Posición 27c322**, para EPROMs 27C160, 27C400 y 27C800, el interruptor debe estar en la **Posición otra**.

![Adapter mode](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/addapter_mode.jpg)

## Software

Las siguientes instrucciones describen cómo grabar una EPROM 27c160.

Divide la EPROM fuente en partes de 512Kbytes, en este caso uso el HJSplit, aunque se pueden usar otros programas.

![HJSplit](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/hjsplit_512k.jpg)

Ubica la ruta de salida, para este ejemplo cuatro archivos de tamaño 512Kbyte con la extensión terminando en ".001" - ".004".

Lanza el software MiniPro, selecciona el dispositivo `AMD 27C4096 DIP40`, deselecciona `Check ID` y configura `Pulse Delay` en `50us`. Opcionalmente, también puedes reducir `VPP Voltage` a `12.50V`, dependiendo de la hoja de datos de tu EPROM y el éxito de la programación.

![MiniPro Software Configuration](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/minipro.jpg)

La EPROM ahora puede ser accedida como si fuera un dispositivo 27C4096, 512kB a la vez, según lo configurado por el DIP Switch:

- **27C400:** programa los 512kB en una sola pasada.
- **27C800:** programa en 2 (dos) pasadas de 512kB.
- **27C160:** programa en 4 (cuatro) pasadas de 512kB.
- **27C322:** programa en 8 (ocho) pasadas de 512kB.

Consulta la siguiente tabla para la configuración del DIP Switch:

![DIP Switch configuration](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/dip_config.png)

## Solución de Problemas

Si tienes errores de escritura o verificación al programar, prueba estos pasos:

1. Asegúrate de que la EPROM esté completamente borrada antes de programarla (`Device -> Blank Check`). Todas las EPROM disponibles hoy en día son 'pulls' de segunda mano; los vendedores no siempre son cuidadosos al borrar antes de la reventa.

2. Abre y cierra la palanca ZIF del adaptador varias veces, y reposiciona la EPROM de manera cuadrada en el zócalo.

3. Intenta ajustar `VPP Voltage` entre `12.50V` y `13.50V`. Subjetivamente, he tenido más éxito con el voltaje más alto, que da margen para pérdidas de voltaje al transferir VPP a través de la lógica del adaptador.

4. Los errores de programación ocurrirán ocasionalmente, y por supuesto, las probabilidades aumentan con dispositivos de mayor tamaño. Tiene sentido invertir en un borrador UV. Estos están disponibles a bajo costo en eBay por alrededor de $15-20. La mayoría de los dispositivos se borrarán después de 10 a 20 minutos bajo luz UV.

5. [Maillouski](https://github.com/Maillouski/), reportó que Xgpro v12.38 establece el valor predeterminado de VDD Write en 6.60V para el AT27C4096. Para evitar problemas de programación, asegúrate de cambiar este valor a 3.30V.

![IC Config Information VDD Write](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/vdd_3v30.png)

6. [Tim aka BeepFixer](https://x.com/@beepfixer), comparte sus valores de programación para las variantes **27C160** obtenidas en AliExpress.

   La principal diferencia: la configuración de la almohadilla de la ventana UV. Llámalos Tipos A, B y C.
    - **Tipo A**: pads 2x2 usando solo el centro del espacio disponible en la ventana 
    - **Tipo B**: pads 2x2 usando la mayor parte del espacio disponible en la ventana 
    - **Tipo C**: pads 2x4

![IC Config Information VDD Write](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/m27c160_variants.jpg)

**Resultados de las pruebas**

  **Tipo A**: 2/10 chips necesitaron un poco de cuidado—un pequeño ajuste fuera de los parámetros recomendados (cambiar 50us por 100us) los hizo programables y verificables. Solo para estar seguros, aquí están los ajustes completos usados: Voltaje VPP: 13.50V / Verificación VCC: 5.00V / Escritura VDD: 5.00V / Retardo de pulso: 100us. Aunque también tuve éxito con otros voltajes, siempre que el retardo de pulso fuera 100 y no 50us.

  **Tipo B**: 7/10 chips funcionaron a la perfección—en el primer intento, con la configuración recomendada por Eladio (50us)

  **Tipo C**: 1/10 chip falló estrepitosamente. Lee y borra bien, y puede escribir una sola palabra. Pero después de esa única palabra escrita se niega a escribir más. Probablemente una variante más antigua y estricta; no está roto, solo es una diva del silicio. Intenté una y otra vez con diferentes configuraciones y simplemente no pude hacer que escribiera un lote completo.

**Consejos prácticos**

   - Siempre verificar después de programar. 
   - Prueba diferentes voltajes como también se menciona en el GitHub del adaptador.
   - Y ten cuidado con las escrituras de archivos; dado que usarás el adaptador para escribir una imagen dividida en 4 secciones, es fácil escribir el archivo equivocado en la memoria equivocada (ups, sí, culpable de escribir el archivo 3 en la memoria 3 y 4 una vez). Así que, ¡verifica el EPROM en el dispositivo destino!

## Registro de cambios de hardware

R_20231123

* Corregir la polaridad correcta del interruptor DIP EDG-03.
* Actualizar el número de revisión a R_20231123
* Actualizar el número de versión a 1.1

V_20180919

* Lanzamiento inicial.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-24

---