# MonkSynth

[![Build](https://github.com/JonET/monksynth/actions/workflows/build.yml/badge.svg)](https://github.com/JonET/monksynth/actions/workflows/build.yml)
[![Release](https://img.shields.io/github/v/release/JonET/monksynth?include_prereleases)](https://github.com/JonET/monksynth/releases)
[![License](https://img.shields.io/github/license/JonET/monksynth)](LICENSE)

Un sintetizador vocal monofónico que suena como un monje cantando. Construido usando síntesis por función de onda formante (FOF), inspirado en el clásico plugin VST [Delay Lama](http://www.audionerdz.nl/) de AudioNerdz (2002).

**[Descarga la última versión](https://github.com/JonET/monksynth/releases)** — disponible para Windows, macOS y Linux.

<img src="https://raw.githubusercontent.com/JonET/monksynth/main/docs/screenshot1.png" alt="MonkSynth running in Ableton Live 12 with the classic Delay Lama theme" width="600">

*MonkSynth v0.0.1-beta.1 en Ableton Live 12, con el tema clásico importado del DLL original Delay Lama*

## Características

- Motor de síntesis FOF que produce formantes vocales realistas
- Pad XY para control en tiempo real del tono y vocales
- Efecto de retardo estéreo integrado
- Soporte MIDI: nota on/off, rueda de tono, CC1 (vibrato), CC5 (deslizamiento), CC7 (volumen), CC12 (retardo), CC13 (voz)
- Parámetro **Pitch Bend** automatizable (±12 semitonos). La rueda de tono del hardware es direccionable a Vocal (Clásico / compatibilidad Delay Lama, por defecto) o a Tono mediante clic derecho → Pitch Bend
- Envolvente ADSR con ataque, decaimiento, sustain y release configurables
- Modo unísono con hasta 10 voces desafinadas y dispersión de voces
- Sistema de temas con menú contextual de clic derecho para temas personalizados
- Importa tema clásico del DLL original Delay Lama
- 5 presets de fábrica
- Formato de plugin VST3 (Windows, macOS, Linux) y Audio Unit (macOS)

## Compilación

### Requisitos previos

- CMake 3.20+
- Compilador C/C++ (MSVC, GCC o Clang)

### Compilar

```bash
cd cpp
cmake -B build
cmake --build build --config Release --target MonkSynth
```

El SDK VST3 se obtiene automáticamente mediante CMake. El plugin compilado se coloca en el directorio VST3 de tu sistema.

### Audio Unit en macOS

Para también compilar el plugin AU, instala el [AudioUnit SDK](https://github.com/apple/AudioUnitSDK) y configura con:

```bash
cmake -B build -G Xcode -DSMTG_AUDIOUNIT_SDK_PATH=/path/to/AudioUnitSDK
cmake --build build --config Release --target MonkSynth-au
```

### Pruebas unitarias de DSP

La capa DSP pura en C (`dsp/`) tiene un pequeño conjunto de pruebas unitarias que ejercitan los límites del sobre ADSR, la pila de notas, la matemática de desafinación unísona, la propagación del pitch-bend y la estabilidad del feedback de la línea de retardo. Las pruebas son opcionales para no afectar las compilaciones normales del plugin:

```bash
cd cpp
cmake -B build-tests -DMONKSYNTH_BUILD_TESTS=ON
cmake --build build-tests --config Release
ctest --test-dir build-tests --output-on-failure
```

CI ejecuta la suite de pruebas en el trabajo de Linux antes de empaquetar cada versión, por lo que cualquier regresión de DSP bloquea la compilación.

## Instalación

- **macOS:** Ejecuta el instalador `.pkg` — instala los plugins VST3 y AU
- **Windows:** Ejecuta el instalador `.exe` — instala el plugin VST3
- **Linux:** Extrae y copia `MonkSynth.vst3` a `~/.vst3/`

### Compatibilidad con Linux

La compilación para Linux se verifica en cada versión para cargarse sin problemas bajo semánticas estrictas del cargador (dlopen estilo Bitwig `RTLD_NOW`) en estas familias de distribuciones:

- Ubuntu 22.04 / 24.04 LTS (y derivados: Linux Mint, Pop!_OS, Elementary, KDE neon)
- Debian 12 (y derivados: KX Studio, AV Linux, MX Linux)
- Fedora (última versión)
- Arch Linux (y derivados: Manjaro, EndeavourOS, CachyOS)

Si tu distribución no está listada, probablemente aún funcione — estas se prueban en CI para detectar errores del tipo biblioteca compartida faltante, no es una afirmación exhaustiva de soporte. El plugin se construye en Ubuntu 22.04 (glibc 2.35), por lo que cualquier distro con glibc ≥ 2.35 debería ser compatible. Se agradecen reportes de otras distros vía [GitHub Issues](https://github.com/JonET/monksynth/issues).

## Temas

MonkSynth se entrega sin un tema incorporado. En el primer lanzamiento, muestra una pantalla de configuración donde puedes importar el aspecto clásico del DLL original Delay Lama (disponible gratuitamente en [audionerdz.nl](http://www.audionerdz.nl/download.htm)).

También puedes cargar temas personalizados con clic derecho en la interfaz del plugin. Una carpeta de tema contiene un manifiesto `theme.json` y cualquier combinación de estos archivos PNG (los que falten usarán marcadores de posición 1x1):

- `background.png` — fondo principal (360x510)
- `monk-strip.png` — hoja de sprites de animación (rejilla 5x6, cuadros 311x311)
- `knob-left.png` / `knob-right.png` — tiras de película de perillas rotativas (50x3000, 60 cuadros)
- `fader-down-large.png` / `fader-down-sm.png` / `fader-right-sm.png` — controles deslizantes
- `info.png` — superposición de información (253x275)

**Buscando nuevos temas predeterminados para incluir con el plugin.** Si diseñas un tema del que te sientas orgulloso, abre un PR — me encantaría incluir temas contribuidos en la próxima versión. El menú de clic derecho tiene un ítem "Open Themes Folder" que revela dónde se almacenan los temas en disco.

## Traducciones

La interfaz del plugin (pantalla de configuración, superposición de información, menú de clic derecho y mensajes de error del importador DLL) está disponible en inglés, japonés y coreano. El idioma se detecta automáticamente según la configuración regional del sistema operativo; puedes cambiarlo con clic derecho → Language.

**Las traducciones al japonés y coreano fueron generadas por un modelo de lenguaje grande como punto de partida.** Las contribuciones de hablantes nativos son muy bienvenidas — por favor abre un PR editando `cpp/src/strings_ja.h` o `cpp/src/strings_ko.h`. Cada cadena está indexada por el enum `StringId` en `cpp/src/i18n.h`; mantén las entradas en el mismo orden y deja las que no estés seguro como cadenas vacías para que se usen las de inglés.

Los nombres de los parámetros (que se muestran en las líneas de automatización de tu DAW) permanecen en inglés a propósito: tutoriales, presets y discusiones en la comunidad asumen los nombres en inglés.

## Política de Firma de Código

Firma de código gratuita proporcionada por [SignPath.io](https://about.signpath.io/), certificado por [SignPath Foundation](https://signpath.org/).

El plugin VST3 para Windows y el instalador se firman como parte de la compilación de lanzamiento en GitHub Actions. Las solicitudes de firma se envían a SignPath solo para lanzamientos etiquetados construidos desde este repositorio, y cada solicitud es aprobada manualmente en la interfaz de SignPath antes de aplicar el certificado.

| Rol privilegiado | Firmante |
|-----------------|----------|
| Autor           | [Jonathan Taylor](https://github.com/JonET) |
| Revisor         | [Jonathan Taylor](https://github.com/JonET) |
| Aprobador       | [Jonathan Taylor](https://github.com/JonET) |

### Política de Privacidad

Este programa no transferirá ninguna información a otros sistemas en red a menos que sea específicamente solicitado por el usuario o la persona que lo instale u opere.

## Agradecimientos

- [Delay Lama](http://www.audionerdz.nl/) por AudioNerdz (2002) — el querido plugin VST freeware que inspiró este proyecto
- Xavier Rodet (IRCAM) — técnica de síntesis de función de onda formante (FOF)
- [stb_image_write](https://github.com/nothings/stb) por Sean Barrett — escritura de imágenes en un solo encabezado (MIT / dominio público)
- [VST3 SDK](https://github.com/steinbergmedia/vst3sdk) por Steinberg — framework de plugins (MIT)
- [SignPath Foundation](https://signpath.org/) — firma de código gratuita para Windows en proyectos de código abierto

## Licencia

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---