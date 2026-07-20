# Plugin de Cronología para Obsidian

Proporciona una barra lateral con una vista de calendario de tus notas.

![](https://raw.githubusercontent.com/Canna71/obsidian-chronology/master/media/demo.gif)

El calendario permite navegar y seleccionar un rango diario, semanal, mensual o personalizado de notas. Los rangos diarios y semanales se muestran en una línea de tiempo, pero puedes forzar la visualización de las notas en una lista simple activando la configuración `Display Simple List`.  
En la visualización de la línea de tiempo, puedes agrupar notas que fueron creadas o modificadas en el mismo intervalo de tiempo activando `Group Notes in same time slot`.

Haz clic en el nombre del mes para ver una lista de todas las notas de ese mes.

Para seleccionar un rango de fechas a mostrar: selecciona una fecha y luego haz shift-clic en la otra fecha del rango.

Las notas en la línea de tiempo se mostrarán con una marca de color que indica si fueron **creadas** o **modificadas** en ese momento.


![](https://raw.githubusercontent.com/Canna71/obsidian-chronology/master/media/example.png)


Al hacer clic en el nombre de la nota, esta se abrirá. Ctrl-(o Command-) clic en el nombre de la nota la abrirá en un nuevo panel.

En el calendario puedes seleccionar los días individuales o el número de la semana (a la izquierda).

El fondo de los cuadros de los días da una indicación sobre cuántas notas fueron creadas o editadas ese día. La escala también depende del número promedio de notas diarias configurado en las opciones.

# Problemas con Obsidian Sync  
Si tienes Obsidian Sync, puede que hayas notado que los archivos sincronizados tienen una marca de tiempo de creación que corresponde a cuando se sincronizaron en las otras máquinas.  
En la versión 1.1.9 se añadieron un par de configuraciones para solucionar este problema (opcionalmente) leyendo de los metadatos del archivo la fecha real de creación de la nota.  
No es obligatorio que cada nota tenga una fecha de creación/modificación en los metadatos; si falta, el plugin recurrirá a la fecha de creación o modificación del archivo.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-20

---