## OpenFIRE-DONGLE para EPS32


![foto_dongle](https://github.com/user-attachments/assets/a38d7390-f7e7-42d7-844c-ad8388670f6d)



https://github.com/user-attachments/assets/70a193a0-686e-4da3-8d30-f0067de6b63c



Este repositorio fue creado para ser utilizado junto con el código del proyecto OpenFIRE-Firmware-ESP32, un port del proyecto original 'OpenFIRE-firmware' del TeamOpenFIRE, adaptado para funcionar en el microcontrolador ESP32S3.
El proyecto, desarrollado usando PlatformIO, representa el firmware para un ESP32S3 para ser usado como dongle conectado al PC, con el fin de habilitar una conexión inalámbrica mediante el protocolo ESP-NOW de ESP32. Este dongle está diseñado para usarse en combinación con el firmware 'OpenFIRE-Firmware-ESP32', que se instala en la lightgun.
El código está estructurado para detectar automáticamente las lightgun y configurarse de forma autónoma.
La comunicación entre la lightgun y el dongle es bidireccional, permitiendo usar la lightgun como si estuviera conectada directamente al PC vía USB.
El PC no detecta ninguna diferencia entre una conexión directa por USB y una conexión inalámbrica a través del dongle.
Quiero expresar mi sincera gratitud al TeamOpenFIRE por la creación del proyecto 'OpenFIRE': todo el mérito y mi más profundo reconocimiento van para ellos.
Una pequeña parte del código fue extraída y modificada del repositorio "SerialTransfer": https://github.com/PowerBroker2/SerialTransfer.git.
Por lo tanto, deseo agradecer también al autor de dicho código, PowerBroker2, por su contribución.


Este repositorio fue creado para usarse junto con el código del proyecto OpenFIRE-Firmware-ESP32, un port del proyecto original 'OpenFIRE-firmware' de TeamOpenFIRE, adaptado para funcionar en el microcontrolador ESP32S3.
El proyecto, desarrollado usando PlatformIO, sirve como firmware para un ESP32S3 que se usa como dongle conectado al PC, habilitando conectividad inalámbrica mediante el protocolo ESP-NOW de ESP32. Este dongle está diseñado para usarse en combinación con el firmware 'OpenFIRE-Firmware-ESP32', que se instala en la lightgun.
El código está estructurado para detectar automáticamente las lightgun y configurarse de forma independiente.
La comunicación entre la lightgun y el dongle es bidireccional, permitiendo que la lightgun funcione como si estuviera conectada directamente al PC vía USB.
El PC no nota ninguna diferencia entre una conexión USB directa y una conexión inalámbrica a través del dongle.
Quisiera expresar mi sincera gratitud al TeamOpenFIRE por crear el proyecto 'OpenFIRE'; todo el crédito y mi más profundo agradecimiento son para ellos.
Una pequeña porción del código fue tomada y modificada del repositorio "SerialTransfer": https://github.com/PowerBroker2/SerialTransfer.git.
Por lo tanto, quisiera agradecer al autor de este código, PowerBroker2, por su contribución.


## ... sigue la página original del proyecto 'OpenFIRE-firmware' del TeamOpenFIRE
## ... follows the original project page 'OpenFIRE-firmware' project by TeamOpenFIRE

### ¿Te gusta nuestro trabajo? [¡Recuerda apoyar a los desarrolladores!](https://github.com/TeamOpenFIRE/.github/blob/main/profile/README.md)

![BannerDark](https://raw.githubusercontent.com/alessandro-satanassi/OpenFIRE-DONGLE-ESP32/main/docs/of_bannerLoD.png#gh-dark-mode-only)![BannerLight](https://raw.githubusercontent.com/alessandro-satanassi/OpenFIRE-DONGLE-ESP32/main/docs/of_bannerDoL.png#gh-light-mode-only)
# OpenFIRE - El Sistema de Light Gun de Emisor Infrarrojo Abierto *Four Infa-Red Emitter*
###### Sucesor de [IR-GUN4ALL](http://github.com/SeongGino/ir-light-gun-plus), que se basa en el fork [Prow Enhanced](https://github.com/Prow7/ir-light-gun), que a su vez se basa en el Beta 4IR "Big Code Update" [proyecto SAMCO](https://github.com/samuelballantyne/IR-Light-Gun)

## Características:
- **Periféricos completamente funcionales**, desde solenoide y retroalimentación de fuerza por vibración, hasta monitoreo de temperatura TMP36, y otros por venir.
- **Soporte para múltiples configuraciones de IR**, con *seguimiento en tiempo real ajustado a la perspectiva* para barras de luz dobles (¡recomendado!) y configuraciones tipo diamante Xwiigun (compatibles con otros sistemas).
- **Sistema de entrada flexible**, con salidas a teclado, ratón ABS(oluto) de 5 botones y gamepad de doble palanca con soporte de d-pad, con un **sistema robusto de asignación de botones** para ajustarse a tus necesidades.
- **Instalación fácil** con binarios *.UF2* simples que pueden ser arrastrados y soltados directamente en un microcontrolador basado en *RP2040*.
- **Configuraciones portátiles integradas** para almacenar perfiles de calibración, conmutadores, ajustes, identificador USB y más.
- **Se integra con la [App OpenFIRE](https://github.com/TeamOpenFIRE/OpenFIRE-App)** para una configuración amigable y multiplataforma sobre la marcha.
- **Optimizado para el RP2040**, usando su segundo núcleo para sondeo y encolado de entradas y manejo serial, y el núcleo principal para procesamiento de cámara y periféricos, cuando sea posible.
- **Compatible con manejadores de retroalimentación de fuerza para PC** como [Mame Hooker](https://dragonking.arcadecontrols.com/static.php?page=aboutmamehooker), [The Hook Of The Reaper](https://github.com/6Bolt/Hook-Of-The-Reaper) y [QMamehook](https://github.com/SeongGino/QMamehook).
- **Soporta salida integrada en pantalla OLED** para *pantallas SSD1306 I2C* para navegación de menús y retroalimentación visual de elementos del juego como vida y munición actual.
- **Compatible con el ecosistema MiSTer FPGA**, con asignaciones dedicadas para optimizar al máximo la experiencia del usuario.
- **¡Siempre gratuito y de código abierto para la comunidad de pistolas de luz!**

___
## Agradecimientos:
* Samuel Ballantyne, por su proyecto original SAMCO, la hermosa marca OpenFIRE y el sistema de seguimiento basado en perspectiva.
* Prow7, por su mejora del fork SAMCO que proporcionó la base para el modo pausa y los subsistemas de guardado.
* Odwalla-J, mrkylegp, RG2020 y lemmingDev por la consulta previa al lanzamiento, pruebas de errores y retroalimentación.
* Los testers de IR-GUN4ALL por sus comentarios iniciales y solicitudes de funciones - ¡esto no habría sido posible sin ustedes!
* Chris Young por su biblioteca compatible con TinyUSB (ahora parte de `TinyUSB_Devices`).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---