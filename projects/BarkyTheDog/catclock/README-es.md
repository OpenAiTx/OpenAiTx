<p align="center">
  <img src="https://raw.githubusercontent.com/BarkyTheDog/catclock/master/catclock.gif">
</p>

catclock
========

Esta es una versión del programa xclock del Sistema de Ventanas X, que ha sido mejorada con un "modo gato". Originalmente un programa X10 de Tony Della Fera (MIT-Athena, DEC), Dave Mankins (MIT-Athena, BBN) y Ed Moy (UC Berkeley), Deanna Hohn y yo (en Digital Equipment Corporation) lo creamos para nuestro propio entretenimiento a finales de los años 80. Los gráficos se inspiraron en el famoso, de hecho icónico, reloj Kit-Cat (R), uno de los cuales todavía cuelga en mi cocina. Lo he subido a github en honor al 30 aniversario de la introducción de X10 este año, y porque es un juguete divertido para el escritorio.

Desde el momento de nuestras mejoras, el código ha cambiado muy poco, principalmente para ajustarse a compiladores ahora más estrictos. Actualmente, se compila y ejecuta en varias distribuciones de Linux, Cygwin y OS X (XQuartz), con cambios en el Makefile necesarios solo por la instalación predeterminada de Macport de archivos relacionados con X en /opt/local. El Imakefile está algo anticuado, y aún no he intentado hacerlo funcionar — ahora solo está incluido por razones "históricas". El archivo original readme, ahora llamado readme_original, también está incluido por razones históricas.

Además del modo gato, esta versión de xclock incluye una función de alarma y un timbre horario (consulte la página man para más detalles). Se pueden usar varios valores predeterminados de X y opciones de línea de comandos para controlar los colores del gato. Puede que tenga que modificar la cabecera y las rutas de biblioteca del Makefile para la configuración X de su máquina. La única dependencia "no estándar" es Motif, que se puede obtener fácilmente desde su gestor de paquetes favorito.

## Seguimiento del Tempo

Esta versión es capaz de seguir el tempo de la música y mover los ojos y la cola del gato sincronizados con la música.  
Para compilarlo con el seguimiento del tempo habilitado, necesitará una biblioteca adicional que alimenta el seguimiento del tempo:

```bash
sudo apt install libaubio5 libaubio-dev
```

Utilice la opción `WITH_TEMPO_TRACKER=1` para compilar con el rastreador de tempo habilitado:

```bash
make WITH_TEMPO_TRACKER=1
```

Después de ejecutar clock en modo "cat", ejecute algún mezclador de PulseAudio (por ejemplo - `pavucontrol`) y seleccione la fuente de audio deseada para el análisis en la pestaña "Grabación".

## Uso

```
xclock [toolkitoptions]
       [-mode <analog, digital, cat>]
       [-alarm]  [-bell]  [-chime]
       [-file <alarm file>]  [-period <seconds>]
       [-hl <color>]  [-hd <color>]
       [-catcolor <color>]
       [-detailcolor <color>]
       [-tiecolor <color>]
       [-padding <pixels>]
       [-update <seconds>]
       [-ntails <number>]
       [-help]
```

¡Disfruta!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-02

---