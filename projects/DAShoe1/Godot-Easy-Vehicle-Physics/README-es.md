# Godot-Easy-Vehicle-Physics
Un sistema de vehículo con cuerpo rígido basado en rayos para Godot 4.2 y superior

## Descripción
Un controlador de vehículo basado en física diseñado para funcionar bien con teclado y ser fácil de configurar. Todos los parámetros están contenidos en un solo script (vehicle.gd) y se proporcionan descripciones emergentes para todos ellos.

## Características
Este controlador cuenta con muchos sistemas que ayudan a crear un vehículo competente, tales como:
- Asistencias de dirección
- Asistencias de contramanillar
- Control de tracción
- Frenos antibloqueo
- Asistencia de estabilidad
- Asistencia en el aire
- Caja de cambios automática
- Diferenciales bloqueantes
- Asistencias de agarre de neumáticos
- Parámetros de suspensión calculados; obtener parámetros correctos de suspensión puede ser difícil, por lo tanto este controlador calculará tasas de resorte y amortiguación basándose en proporciones y distribución de peso.

## Ejemplos
Se incluyen 4 vehículos de ejemplo:
- demo_arcade.tscn: Maneja similar a un coche de carreras estilo arcade, mucho agarre, fácil de controlar y muchas asistencias.
- demo_simcade.tscn: Maneja más parecido a un coche real con asistencias para ayudar a mantener el control del coche.
- demo_monster_truck.tscn: Maneja como un monster truck, con muy pocas asistencias.
- demo_drift.tscn: Configurado para derrapes fáciles.

## Controles
- Dirección: Izquierda: ← o a Derecha: → o d
- Acelerador: ↑ o w
- Freno: ↓ o s
- Freno de mano: Espacio
- Embrague: C
- Cambiar caja de cambios (Auto/Manual): T
- Subir marcha: F o +
- Bajar marcha: R o -
- Información de depuración: ~
- Cambiar pantallas de depuración: < o >

## Motor de física
Este controlador funciona bien tanto en los motores de física Godot como Jolt. Se recomienda una tasa de actualización física de al menos 120 y se pueden usar valores más altos, pero tenga en cuenta que el comportamiento del vehículo será diferente al cambiar las tasas de actualización.

## Agradecimientos
Muchísimas gracias a Dechode y Wolfe por compartir sus proyectos con la comunidad de Godot. Compartir este proyecto es mi manera de retribuir. Parte de este código se basa en [Godot Advanced Vehicle de Dechode](https://github.com/Dechode/Godot-Advanced-Vehicle) y [SERIES: Driving Simulator Workshop](https://lupine-vidya.itch.io/gdsim/devlog/677572/series-driving-simulator-workshop-mirror) y la atribución está incluida en los archivos fuente correspondientes.
El modelo de coche proporcionado como demo es de [Kenney.nl Car Kit](https://www.kenney.nl/assets/car-kit)

## Proyectos que usan Godot Easy Vehicle Physics
Si estás trabajando en un proyecto que usa este complemento y quieres listarlo aquí, abre un issue para informarme.
- [Jack of all Cars](https://dashoe1.itch.io/jack-of-all-cars)
- [Another Lap](https://store.steampowered.com/app/3550210/Another_Lap/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---