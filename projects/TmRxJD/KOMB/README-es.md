<head><meta name="google-site-verification" content="YTr2AYTpsxIQk7KIOlVTOfKr11dqkzZP-gOUiyhPU5s" />
<body>

<h1>KOMB: El Macro Definitivo de Cepillado de Klipper</h1>

Bienvenido a KOMB, el Macro Optimizado de Klipper para Cepillado! Este macro versátil agiliza las secuencias de cepillado, diseñado tanto para cepillos montados en la cama como en el carro. ¡Di adiós a la molestia de adaptar macros existentes o crear nuevos—ahora puedes aprovechar todo el potencial de tu cepillo en tres dimensiones!

<h3> Instalación: </h3>

La forma más limpia y sencilla de comenzar con KAMP es usar la utilidad Update Manager de Moonraker. ¡Esto te permitirá instalar fácilmente y ayudará a proporcionar futuras actualizaciones cuando se lancen más funciones!

1. `ssh` en tu dispositivo Klipper y ejecuta los siguientes comandos:
   ```bash
    cd
    
    git clone https://github.com/TmRxJD/KOMB    

    ln -s ~/KOMB printer_data/config/KOMB

    cp ~/KOMB/_KOMB_Variables.cfg ~/printer_data/config/KOMB_Variables.cfg

    ```
2. Abre tu archivo `moonraker.conf` y añade esta configuración:

   ```yaml
   [update_manager KOMB]
   type: git_repo
   channel: dev
   path: ~/KOMB
   origin: https://github.com/TmRxJD/KOMB
   managed_services: klipper
   primary_branch: main
    ```

    > **Nota:**
    > Cada vez que se cambian las configuraciones de Moonraker, debe reiniciarse para que los cambios tengan efecto. Si no desea que Moonraker le notifique sobre futuras actualizaciones de KAMP, puede omitir este paso.

3. Opcionalmente, incluya KOMB_Purge.cfg en su KOMB_Variables.cfg para usar la macro allí.

<h3>Características y Funcionalidad</h3>

Movimiento Flexible: El movimiento predeterminado de KOMB barre desde la esquina inferior izquierda hacia la derecha, pero puede personalizar fácilmente el movimiento a lo largo de varios ejes y direcciones. Incluso úselo durante la impresión dependiendo de su impresora y la colocación del cepillo.

Patrones Diversos: Actualmente soporta barridos diagonales y circulares (requiere gcode_arcs habilitado), el repertorio de KOMB pronto se expandirá para incluir más patrones.

Cepillado Tridimensional: Aproveche toda el área y la profundidad posible de su cepillo para asegurar una boquilla más limpia con un rendimiento más consistente, puede estar seguro de que su boquilla estará limpia cada vez. La boquilla puede descender en el cepillo paso a paso para permitir que más superficie de la boquilla alcance el cepillo.

Úselo Durante la Impresión: con el disparador KOMB puede usar la macro tantas veces como desee durante el curso de su impresión, asegurando que su boquilla se mantenga limpia durante toda la duración.

<h3>Parámetros Ajustables del Cepillo: Ajuste variables para un control preciso</h3>
* Especifique la ubicación de su cepillo en (X, Y, Z), así como el tamaño y profundidad en milímetros <br>
* Tamaño del paso: Distancia entre las pasadas diagonales o circulares <br>
* Paso Z: Descender después de cada iteración al usar repetición. Poner en 0 para desactivar. <br>
* Desplazamiento: Permite iniciar y terminar movimientos fuera de los límites del cepillo, o para permanecer más confinado dentro use un valor negativo para esto <br>
* Número de repeticiones: Especifique cuántas veces desea que el patrón se repita <br>
* Invertir: Habilite para repetir el patrón de regreso al inicio en reversa antes de la siguiente repetición. Si está deshabilitado la boquilla viajará directamente de regreso al inicio después del patrón <br>
* Comenzar en lado opuesto y/o adyacente: Si el lado opuesto está habilitado, la boquilla se moverá de derecha a izquierda. Si el adyacente está habilitado, la boquilla se moverá a lo largo del eje opuesto y comenzará desde abajo hacia arriba. Si ambos, opuesto y adyacente están habilitados, la boquilla se moverá de arriba hacia abajo. <br>
* Velocidad Variable: Especifique la velocidad en mm/s e incremente o disminuya la velocidad con cada repetición. También puede controlar la velocidad de desplazamiento al cepillo <br>
* Patrones: Elija entre diferentes patrones de cepillado, actualmente se soportan diagonales y círculos. (Si aún desea usar un patrón horizontal clásico puede hacerlo, solo configure el tamaño del cepillo en el eje opuesto a 0. Si aún quiere que pueda avanzar configure el ángulo a 0) <br>
* Ángulo: especifique el ángulo de las pasadas diagonales al usar el patrón 1, el ángulo recomendado por defecto es 45 <br>
* Calentamiento Automático: Habilite y especifique una temperatura mínima para permitir el cepillado y calentar automáticamente a esta temperatura antes de cepillar <br>
* Auto Home: Lleva automáticamente el cabezal de impresión a casa si es necesario. Solo hará home si no está ya en posición. <br>
* Retracción: Configure la retracción antes, durante y después del cepillado. <br>
* Salto Z: Especifique una altura para elevar la boquilla antes de moverse a la ubicación del cepillo y luego descender. Poner en 0 para desactivar.<br>
* Retroalimentación Detallada: Habilite salida detallada en consola para obtener información completa sobre el proceso de cepillado, incluyendo valores de ejes, cálculos y puntos de posicionamiento. <br>

<h4>Disparador KOMB</h4>

You can use KOMB at a specified frequency throughout the print to ensure your nozzle stays clean for the entire duration. Include `KOMB_trigger` in the 'at layer change' section of your slicer configuration to effortlessly trigger the macro at your preferred frequency. Additionally, integrate this macro name into your start print routine to use the macro before starting printing. This feature is not intended for per-object printing and is tailored for use with gantry and frame-mounted brushes. While functional with bed-mounted brushes, cautious use is advised, as attention to your printer's clearances is essential to prevent potential collisions. If utilizing Z hop, the nozzle will ascend before maneuvering over the brush, descend for brushing, and subsequently reascend to its initial height before resuming printing. Configure Z hop settings to provide added clearance during elevation and descent. It is strongly recommended not to set the Z hop value below 2. Additionally, ensure that your axis limits are accurately defined for the macro's effective operation. For guidance on setting axis limits, refer to the guide provided at the end of this readme.
<h4>Purgado KOMB</h4>

La opción de purgado de KOMB te permite iniciar un purgado controlado de material antes de comenzar la secuencia de cepillado. Esta función resulta especialmente útil cuando la precisión es importante, como durante la calibración del desplazamiento Z o en otras operaciones que dependen de mediciones, sin necesidad de trazar una línea adicional de purgado. Al utilizar esta función, puedes definir fácilmente la ubicación de tu contenedor de purgado, la cantidad deseada de extrusión de filamento y el tiempo de espera antes de pasar a la secuencia de cepillado. La opción de purgado también puede activarse de forma independiente al resto del macro; esto te brinda la flexibilidad para adaptar tu proceso de impresión según tus requisitos específicos. Para usar el macro en tu inicio de impresión, añade "KOMB_purge" a tu configuración.

<h3>La Distintividad de KOMB</h3>

KOMB está diseñado para adaptarse sin problemas a diferentes configuraciones de impresoras, acomodando diversos tamaños y ubicaciones de cepillos. A diferencia de los macros tradicionales que fuerzan el movimiento de la boquilla a ubicaciones específicas, KOMB genera una secuencia completa de coordenadas basadas en tus variables, ajustadas previamente para mantenerse dentro de los límites de la impresora. Este enfoque proactivo elimina casi por completo el riesgo de errores, garantizando un cepillado exitoso sin importar errores del usuario. Cualquier punto generado que exceda los límites de la impresora se ajusta automáticamente para mantenerse dentro, asegurando una ejecución fluida. Una vez que la lista se genera instantáneamente, KOMB guía la boquilla a través de las coordenadas predeterminadas con facilidad.

<h3>Comenzando con KOMB</h3>

Asegúrate de que el firmware Klipper esté instalado en tu impresora 3D.

Integra el código macro suministrado de KOMB, `KOMB.cfg`, en tu archivo de configuración de Klipper "printer.cfg", junto con tus otros macros. Para mejorar la facilidad de uso, se recomienda mantener las Variables KOMB en un archivo separado e incluirlo usando `[include _KOMB_Variables.cfg].` Alternativamente, puedes fusionarlo con la configuración principal si te resulta más conveniente.

Especifica las variables en la sección KOMB_Variables para que coincidan con tus requerimientos de cepillado.

Determina la posición exacta XY del cepillo mediante la interfaz de usuario de la impresora. Comienza desde la esquina inferior izquierda, ajustando con una precisión de hasta 0.1 mm si lo deseas.

Mide el tamaño del cepillo o cálculalo moviéndote a la esquina superior derecha y restando la posición de la esquina inferior izquierda de la superior derecha en ambos ejes X e Y.
Repite un proceso similar para la posición Z, considerando la opción de bajar la boquilla incrementalmente con cada iteración (z_step).

Guarda el archivo de configuración y recarga Klipper para aplicar los cambios.

Ejecuta KOMB en la consola, mediante un botón macro en la interfaz de usuario, o añade `KOMB` a tu macro de inicio de impresión. Asegúrate de que las variables estén configuradas correctamente antes de la ejecución.

Monitorea el progreso a través de la salida de la consola cuando la salida detallada esté habilitada.

¡Disfruta de un cepillado mejorado con KOMB!

<h3>Notas Importantes</h3>

Este macro está diseñado para trabajar con una variedad de variables y parámetros. Asegúrate de ajustarlos de acuerdo con las especificaciones de tu impresora y tus necesidades de cepillado. Asegúrate de entender qué hace cada variable y cómo usarla.

Debes garantizar que los límites de tus ejes estén configurados correctamente para que este macro funcione adecuadamente. Sigue esta guía si tienes dudas: https://github.com/rootiest/zippy_guides/blob/main/guides/axis_limits.md

Dado que este macro implica mover la boquilla de la impresora, ejerce precaución para evitar colisiones durante el proceso de cepillado y asegúrate de que todos los valores sean correctos. Se recomienda probar el macro a baja velocidad sobre el cepillo antes de bajarlo a la posición.

¡Asegúrate de volver en el futuro para actualizaciones y más patrones!


KOMB está en desarrollo, y no todas las combinaciones de variables han sido probadas exhaustivamente. Agradecemos mucho sus comentarios y contribuciones para mejorar la macro.

Si encuentra algún problema, tiene sugerencias para mejoras o desea contribuir al desarrollo de KOMB, no dude en enviarme un mensaje, abrir un problema o enviar una solicitud de extracción en el repositorio de GitHub.

¡Feliz KOMBing!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-14

---