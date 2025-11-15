
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

[![Pre-Release](https://img.shields.io/github/v/tag/till213/skydolly?include_prereleases&label=Pre-Release)](https://github.com/till213/skydolly/releases)
![Licencia: MIT](https://img.shields.io/badge/%E2%9A%96%EF%B8%8F%20License-MIT-brightgreen)
![C++20](https://img.shields.io/badge/C%2B%2B-20-%2300599C?logo=cplusplus)
![Compiladores compatibles](https://img.shields.io/badge/%E2%9A%99%EF%B8%8F%20Compilers-GCC%2C%20clang%2C%20MSVC-informational)

![Pruebas unitarias](https://github.com/till213/SkyDolly/actions/workflows/unit-tests.yml/badge.svg?event=push)

# Sky Dolly
Sky Dolly - La oveja negra para tus grabaciones de vuelo.

## Acerca de
Sky Dolly se conecta a una instancia en ejecución de Flight Simulator 2020 y registra diversas variables de simulación, para su reproducción.

![Sky Dolly v0.11.0](https://raw.githubusercontent.com/till213/SkyDolly/main/./img/SkyDolly-v0.11.0.png)

La conexión se realiza mediante SimConnect, una API estándar introducida con Flight Simulator X para conectarse con el simulador de vuelo.

Consulta también el [ABOUT.md](https://raw.githubusercontent.com/till213/SkyDolly/main/ABOUT.md).

## Características
- Grabar / Pausar / Reproducir
- Vuelos en formación (múltiples aeronaves, reproducción durante la grabación, "volar en formación", desfase de tiempo)
- Frecuencia de muestreo de grabación configurable: fija o variable ("auto")
- Velocidad de reproducción ajustable ("cámara lenta", "timelapse"), bucle de reproducción
- Se graban variables de simulación de posición, velocidad y controles básicos de vuelo (alerones, timón, flaps, tren de aterrizaje, ...)
- Arquitectura de plugins con varios plugins de importación/exportación (CSV, GPX, IGC, KML)
- Módulo de ubicaciones con más de 100 ubicaciones predeterminadas y funcionalidad de importación/exportación
- Persistencia basada en base de datos (SQLite) ("bitácora")

Mira el tráiler de lanzamiento (previa) en [YouTube](https://www.youtube.com/watch?v=_n4qRtm78_I):

[![Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)](https://img.youtube.com/vi/_n4qRtm78_I/0.jpg)](https://www.youtube.com/watch?v=_n4qRtm78_I "Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)")

Para más videos creados con Sky Dolly consulta también [SHOWCASE](https://raw.githubusercontent.com/till213/SkyDolly/main/SHOWCASE.md). Las nuevas funciones y las próximas se encuentran en el [CHANGELOG](https://raw.githubusercontent.com/till213/SkyDolly/main/CHANGELOG.md).

## Uso básico

- Inicia un vuelo
- Haz clic en "Grabar" (tecla R)
- Puedes pausar la grabación (tecla P)
- Detén la grabación (tecla R) y haz clic en "Reproducir" (barra espaciadora)
- Ajusta la velocidad de reproducción y busca la posición de reproducción, también durante la reproducción
- Los vuelos grabados se guardan automáticamente en la "bitácora"
- Selecciona un vuelo en la bitácora y presiona "Cargar" (o haz doble clic en la fila) para cargar el vuelo guardado

### Grabación y reproducción en formación

#### Grabación

- Cambia al módulo "Formación" (tecla F2)
- Haz clic en "Grabar" (tecla R)
- Cada aeronave grabada se añade al vuelo actual
- Mientras las aeronaves existentes se reproducen durante la grabación con la frecuencia de muestreo "auto", aún puedes cambiar la frecuencia de muestreo de grabación

#### Posición

- La última aeronave grabada se convierte en la "aeronave de usuario" (siendo seguida por la cámara en el simulador de vuelo)
- Selecciona una posición relativa a la actual "aeronave de usuario" antes de grabar

#### Reproducción

- Simplemente haz clic en "Reproducir", "Pausa" y navega en la línea de tiempo, igual que con un vuelo de una sola aeronave
- Cambia la "aeronave de usuario" (también durante la reproducción) para "saltar de cabina en cabina"
- Toma el control de la "aeronave de usuario" seleccionando la opción "Tomar control" o "Volar en formación"

#### Gestión de formaciones

- Puedes eliminar aeronaves individuales de un vuelo ("formación")
- Debe haber al menos una aeronave por vuelo, por lo que la última no se puede eliminar
- Añade un desfase de tiempo a la aeronave seleccionada ("sincronización de vuelo en formación multijugador")
- Para iniciar un nuevo vuelo de una sola aeronave vuelve al módulo "Bitácora" (tecla F1) y haz clic en "Grabar" (tecla R)

¿Por qué no pruebas con uno de los ["Tell Tours" guiados](https://github.com/till213/Tell-Tours)? :)

## Descarga

Ve a [Releases](https://github.com/till213/SkyDolly/releases) y descarga la última versión.

Última (pre-)versión: **Sky Dolly 0.19.2**

Calcula y compara tu suma de comprobación con las [sumas de comprobación SHA-256 publicadas](https://raw.githubusercontent.com/till213/SkyDolly/main/SHASUM256.md), para verificar la integridad de tu copia descargada.

## Compilación

Consulta la documentación [BUILD](https://raw.githubusercontent.com/till213/SkyDolly/main/BUILD.md).

## Proyectos relacionados

- https://github.com/nguyenquyhy/Flight-Recorder - Una aplicación de grabación y reproducción de vuelos basada en .Net
- https://github.com/saltysimulations/saltyreplay/ - Grabación y reproducción con una interfaz web de usuario
- https://github.com/SAHorowitz/MSFS2020-PilotPathRecorder - Graba el vuelo y genera "reproducciones" en formato Google Earth (KML)
- https://github.com/Elephant42/FS_Tool - Una herramienta sencilla que permite establecer la ubicación de la aeronave y la velocidad de simulación
- https://github.com/pyviator/msfs-geoshot - Toma capturas de pantalla y las "geoetiqueta" automáticamente
- https://github.com/ijl20/msfs_logger_replay - Registrador y reproductor IGC (para FSX)
- https://joinfs.net/ - Permite sincronizar vuelos multijugador entre diferentes simuladores de vuelo (MSFS, Prepar3D/FSX, XPlane). También ofrece un grabador de vuelos con grabación de vuelo en formación ("overdub").
- https://github.com/paulalexandrow/a32nx-webremote - WebRemote para el A32NX de FlyByWire: controla la funcionalidad de cabina del FBW A320, usando FSUIPC7
- https://flightloganalyzer.com/ - FlightLog Analyzer analiza el libro de registro de MSFS y tiene una exportación CSV legible por Sky Dolly
- https://github.com/BojoteX/FSAutoSave/ - FSAutoSave guarda automáticamente (o bajo demanda) los planes de vuelo
- https://github.com/mracko/MSFS-Landing-Inspector - Analiza el rendimiento de tus aterrizajes
- [Puntos de Interés (Google Maps)](https://www.google.com/maps/d/viewer?mid=1KUg5jwyT_9k2A9n5IZ99UChlhfVUfO5S&ll=-3.81666561775622e-14%2C-23.028915134521867&z=1) - Puntos de interés, aeropuertos y ciudades 3D en Microsoft Flight Simulator.

## Otros recursos útiles

- https://obsproject.com/ - Aplicación de captura y transmisión de pantalla
- https://sqlitebrowser.org/ - Navega por los archivos de la base de datos del libro de registro de Sky Dolly (*.sdlog), ejecuta tus propias consultas SQL


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---