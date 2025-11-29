# Beken7252 OpenCam
Proyecto alternativo RT-Thread para cámaras A9

# Actualizaciones
## 25/09/25
He terminado mi MSc y ahora tengo un poco más de tiempo libre, con muchas de estas cámaras todavía por aquí. Es hora de planificar una primera versión adecuada para este proyecto. He estado trabajando en esto durante algunas semanas y ahora mismo tengo una versión temprana que arranca, se conecta a Wi-Fi, lee y escribe en tarjeta SD, soporta MQTT y lo más importante, funciona con al menos 3 sensores de cámara diferentes: GC0311, HI704 y GC0328. Esto incluye almacenar fotos y transmitir usando HTTP (con multipart/x-mixed-replace).

Todavía necesita pruebas adicionales para estabilidad y mejorar el estado general del SDK y el proyecto.

Consulta [este ticket](https://github.com/daniel-dona/beken7252-opencam/issues/21) para un plan detallado de la versión 1.0.0.

## 20/11/2023
El mes pasado, estaba esperando que llegaran algunas cámaras A9 adicionales, ya que solo tenía una, y me preocupaba arruinar la PCB con este constante soldar y desoldar cables de prueba.
Bueno, eso no resultó como esperaba. Conseguí como 12 cámaras diferentes porque costaban como 3€ en Aliexpress, y obtuve:

~6 con un chip Beken

~3 con un chip desconocido, que parece algún XRadio/Allwinner personalizado

~1 con otro proveedor que no recuerdo

~1 con un chip sin ninguna marca

Sí, los números no suman muy bien; lo importante es que conseguí más con el chip Beken... ¿o sí?

El chip está marcado como BK7252, pero el pinout es diferente. El chip que está documentado y del que al menos tenemos una hoja de datos tiene 68 pines; este tiene 48 pines y la referencia es BK7252UQN48.

Más aquí: https://github.com/daniel-dona/beken7252-opencam/wiki/BK7252-SoC-variations

No voy a trabajar con este chip por el momento. Intenté subir un código funcional a este chip, y no funciona como esperaba. Seguro que quitaron algunas funcionalidades, o ahora están multiplexadas de forma diferente. Tal vez las regiones de memoria para algunos registros son distintas, quizás soy tonto y subí el código mal...

En cualquier caso, creo que es mejor trabajar primero para tener algo funcionando en el chip conocido, y luego podemos explorar este nuevo.

# SDKs conocidos
- FreeRTOS: https://github.com/YanMinge/beken_freertos_sdk_release
- RT-Thread: https://github.com/YangAlex66/bdk_rtt y https://github.com/biemster/bdk_rtt_v3

# Fuentes y publicaciones relacionadas:
- [TODO]


# POR HACER

- Documentar variantes para PCB y sensores
- Documentar asignaciones de pines para variantes de cámara
- Documentar procedimiento de flasheo (y recuperación de bricked)
- Limpiar SDK de Beken
- Migrar código del SDK a GCC y Scons más modernos
- Otros (?)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-29

---