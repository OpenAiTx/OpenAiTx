[![Pre-Release](https://img.shields.io/github/v/tag/till213/skydolly?include_prereleases&label=Pre-Release)](https://github.com/till213/skydolly/releases)
![License: MIT](https://img.shields.io/badge/%E2%9A%96%EF%B8%8F%20License-MIT-brightgreen)
![C++20](https://img.shields.io/badge/C%2B%2B-20-%2300599C?logo=cplusplus)
![Supported Compilers](https://img.shields.io/badge/%E2%9A%99%EF%B8%8F%20Compilers-GCC%2C%20clang%2C%20MSVC-informational)

![Unit Tests](https://github.com/till213/SkyDolly/actions/workflows/unit-tests.yml/badge.svg?event=push)

# Sky Dolly
Sky Dolly - La oveja negra para tus grabaciones de vuelo.

## Acerca de
Sky Dolly se conecta a una instancia en ejecución de Flight Simulator 2020 y registra varias variables de simulación, para su reproducción.

![Sky Dolly v0.11.0](https://raw.githubusercontent.com/till213/SkyDolly/main/./img/SkyDolly-v0.11.0.png)

La conexión se realiza mediante SimConnect, una API estándar introducida con Flight Simulator X para conectarse con el simulador de vuelo.

También consulte el [ABOUT.md](https://raw.githubusercontent.com/till213/SkyDolly/main/ABOUT.MD).

## Características
- Grabar / Pausar / Reproducir
- Vuelos en formación (múltiples aeronaves, reproducción durante la grabación, "volar en formación", desfase temporal)
- Frecuencia de muestreo ajustable para la grabación: fija o variable ("auto")
- Velocidad de reproducción ajustable ("cámara lenta", "timelapse"), bucle de reproducción
- Variables de simulación de posición, velocidad y control básico de vuelo (alerones, timón, flaps, tren de aterrizaje, ...) son registradas
- Arquitectura de plugins con varios plugins de importación/exportación (CSV, GPX, IGC, KML)
- Módulo de ubicación con más de 100 ubicaciones predeterminadas y funcionalidad de importación/exportación
- Persistencia basada en base de datos (SQLite) ("registro de vuelos")

Mira el tráiler de lanzamiento (vista previa) en [YouTube](https://www.youtube.com/watch?v=_n4qRtm78_I):

[![Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)](https://img.youtube.com/vi/_n4qRtm78_I/0.jpg)](https://www.youtube.com/watch?v=_n4qRtm78_I "Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)")

Para más videos creados con Sky Dolly también consulta [SHOWCASE](https://raw.githubusercontent.com/till213/SkyDolly/main/SHOWCASE.md). Las nuevas características y las próximas se encuentran en el [CHANGELOG](https://raw.githubusercontent.com/till213/SkyDolly/main/CHANGELOG.md).

## Uso básico

- Inicia un vuelo
- Haz clic en "Grabar" (tecla R)
- Puedes pausar la grabación (tecla P)
- Detener la grabación (tecla R) y hacer clic en "Reproducir" (barra espaciadora)
- Ajustar la velocidad de reproducción y buscar la posición de reproducción, también durante la repetición
- Los vuelos grabados se guardan automáticamente en el "registro de vuelo"
- Seleccionar un vuelo en el registro y pulsar "Cargar" (o hacer doble clic en la fila) para cargar el vuelo guardado

### Grabación y Reproducción de Formación

#### Grabación

- Cambiar al módulo "Formación" (tecla F2)
- Hacer clic en "Grabar" (tecla R)
- Cada aeronave grabada se añade al vuelo actual
- Mientras las aeronaves existentes se reproducen durante la grabación con la tasa de muestreo "automática", aún puede cambiar la tasa de muestreo de grabación

#### Posición

- La última aeronave grabada se convierte en la "aeronave usuario" (seguida por la cámara en el simulador de vuelo)
- Seleccionar una posición relativa a la actual "aeronave usuario" antes de grabar

#### Reproducción

- Simplemente hacer clic en "Reproducir", "Pausar" y buscar en la línea de tiempo, igual que con un vuelo de una sola aeronave
- Cambiar la "aeronave usuario" (también durante la reproducción) para "saltar de cabina en cabina"
- Tomar el control de la "aeronave usuario" seleccionando la opción "Tomar control" o "Volar con Formación"

#### Gestión de Formaciones

- Se puede eliminar una sola aeronave de un vuelo ("formación")
- Debe haber al menos una aeronave por vuelo, por lo que no se puede eliminar la última aeronave
- Añadir un desfase temporal a la aeronave seleccionada ("sincronización de vuelo en formación multijugador")
- Para iniciar un nuevo vuelo de una sola aeronave, volver al módulo "Registro" (tecla F1) y hacer clic en "Grabar" (tecla R)

¿Por qué no lo pruebas con uno de los guiados ["Tell Tours"](https://github.com/till213/Tell-Tours)? :)

## Descargar

Ir a [Releases](https://github.com/till213/SkyDolly/releases) y descargar la última versión.

Última versión (pre-lanzamiento): **Sky Dolly 0.19.2**

Calcule y compare su suma de verificación con las [sumas de verificación SHA-256 publicadas](https://raw.githubusercontent.com/till213/SkyDolly/main/SHASUM256.md), para verificar la integridad de su copia descargada.

## Compilación

Consulte la documentación [BUILD](https://raw.githubusercontent.com/till213/SkyDolly/main/BUILD.md).

## Proyectos Relacionados

- https://github.com/nguyenquyhy/Flight-Recorder - Una aplicación basada en .Net para grabación y reproducción de vuelos
- https://github.com/saltysimulations/saltyreplay/ - Una grabación y reproducción con interfaz web de usuario
- https://github.com/SAHorowitz/MSFS2020-PilotPathRecorder - Graba el vuelo y genera "repeticiones" para Google Earth (formato KML)
- https://github.com/Elephant42/FS_Tool - Una herramienta simple que permite establecer la ubicación de la aeronave y la tasa de simulación
- https://github.com/pyviator/msfs-geoshot - Toma capturas de pantalla y las "geotaguea" automáticamente
- https://github.com/ijl20/msfs_logger_replay - Registrador y reproductor IGC (para FSX)
- https://joinfs.net/ - Permite sincronizar vuelos multijugador entre diferentes simuladores de vuelo (MSFS, Prepar3D/FSX, XPlane). También proporciona un grabador de vuelo con grabación en formación ("sobrescribir").
- https://github.com/paulalexandrow/a32nx-webremote - WebRemote para FlyByWire's A32NX: controla la funcionalidad de la cabina del FBW A320, usando FSUIPC7
- https://flightloganalyzer.com/ - FlightLog Analyzer analiza el libro de registro de MSFS y tiene una exportación CSV legible por Sky Dolly
- https://github.com/BojoteX/FSAutoSave/ - FSAutoSave almacena automáticamente (o bajo solicitud) planes de vuelo
- https://github.com/mracko/MSFS-Landing-Inspector - Analiza su rendimiento de aterrizaje
- [Puntos de Interés (Google Maps)](https://www.google.com/maps/d/viewer?mid=1KUg5jwyT_9k2A9n5IZ99UChlhfVUfO5S&ll=-3.81666561775622e-14%2C-23.028915134521867&z=1) - Puntos de interés, aeropuertos y ciudades 3D en Microsoft Flight Simulator.

## Otros Recursos Útiles

- https://obsproject.com/ - Aplicación de captura de pantalla / transmisión
- https://sqlitebrowser.org/ - Explore los archivos de base de datos del libro de registro de Sky Dolly (*.sdlog), ejecute sus propias consultas SQL


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---