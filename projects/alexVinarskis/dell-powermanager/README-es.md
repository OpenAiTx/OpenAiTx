[![Build](https://github.com/alexVinarskis/dell-powermanager/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/alexVinarskis/dell-powermanager/actions/workflows/build.yml)
[![GitHub release (with filter)](https://img.shields.io/github/v/release/alexVinarskis/dell-powermanager?label=Release)](https://github.com/alexVinarskis/dell-powermanager/releases/latest)
![GitHub all releases](https://img.shields.io/github/downloads/alexVinarskis/dell-powermanager/total?label=Downloads)

# Dell Power Manager
Reimplementación multiplataforma de Dell Power Manager en Flutter. Más capturas de pantalla en [Wiki](https://github.com/alexVinarskis/dell-powermanager/wiki).

![Captura de pantalla resumen](https://raw.githubusercontent.com/alexVinarskis/dell-powermanager/master/images/screenshot_summary.png)

## Por qué
Las máquinas Dell (portátiles de las series XPS y Precision, potencialmente otras) ofrecen opciones avanzadas configurables en la BIOS, como múltiples perfiles térmicos, umbrales de carga de batería, etc. Puede ser muy deseable ajustarlas sobre la marcha, y no hay forma de configurarlas desde el sistema operativo sin las herramientas propietarias de Dell (que afortunadamente están disponibles). Las configuraciones se pueden cambiar mediante:
* BIOS directamente, requiere reinicio
* [Dell Command | Configure](https://www.dell.com/support/kbdoc/en-us/000178000/dell-command-configure) CLI, disponible para Windows y Linux, con una impresionante [lista de capacidades](https://dl.dell.com/topicspdf/command-configure_reference-guide4_en-us.pdf).
* [Dell Power Manager](https://www.dell.com/support/contents/en-au/article/product-support/self-support-knowledgebase/software-and-downloads/dell-power-manager) GUI, disponible solo para Windows. Además, es ridículamente lento para iniciar y (subjetivamente) feo.

Esta aplicación es una GUI moderna basada en Flutter sobre Dell Command | Configure CLI, con el objetivo principal de replicar el comportamiento de Dell Power Manager para usuarios de Linux, pero también funciona en Windows.

## Funcionalidades
* Implementa control vía 'Dell Command | Configure CLI' (CCTK)
* UI moderna animada, soporta Modo Oscuro
* Tiempo de inicio corto, mucho más rápido que la app de Dell para Windows
* Detecta y maneja modos no soportados en máquinas compatibles
* Detecta máquinas no Dell, muestra mensaje de error
* Soporta BIOS protegido (contraseñas de Sistema/Setup/Propietario), y guardado seguro de claves

Para Linux basado en Debian/Ubuntu y Windows, la app está ligeramente más productizada:
* Descargador e instalador de dependencias integrado
* Empaquetado en `.deb`/`.msi`, con accesos directos en el menú de inicio, etc.
* OTA integrado vía API de Github

Funciones de control:
* Resumen del estado de la batería (salud, etc.)
* Control de carga de batería (sin modo avanzado/programación diaria por ahora)
* Control de perfiles térmicos
* Detecta el modo de energía del sistema operativo

Pendientes planificados:
* Control/programación avanzada de carga de batería ([Solicitud de función](https://github.com/alexVinarskis/dell-powermanager/issues/24))
* Control de "Peak Shift" ([Solicitud de función](https://github.com/alexVinarskis/dell-powermanager/issues/57))

Características futuras potenciales a considerar:
* Añadir servicio de monitoreo para cambio automático de perfiles térmicos basado en la carga de la CPU
* Añadir servicio de monitoreo para cambio automático de perfiles térmicos basado en configuraciones de energía, p.ej. nivel de batería, conectado/desconectado, etc.

## Estado de desarrollo
La aplicación está actualmente en estado **estable, mantenido**.

* CCTK de Dell integrado (con instalador automatizado para sistemas operativos seleccionados)
* Comprobaciones de actualización implementadas (con OTA vía API de Github para sistemas operativos seleccionados)
* Interfaz de usuario probada, compilación y empaquetado asegurados por CI
* Empaquetado en `.msi`, `.deb`, `.tar.xz`. Obtén la última versión estable en [Releases](https://github.com/alexVinarskis/dell-powermanager/releases/latest), o la última versión de desarrollo en [CI artifacts](https://github.com/alexVinarskis/dell-powermanager/actions/workflows/build.yml?query=branch%3Amaster)
* Probado en múltiples plataformas, ver [Compatibilidad](#compatibility). Soportado en:
    * Windows, x86_64 (nativo `.msi`)
    * Windows, arm64 (x64_86 `.msi` ejecutándose en emulación)
    * Linux, x86_64 (nativo `.deb`, `.tar`)
    * Linux, arm64* (nativo `.deb`, `.tar`) _Solo funciona la parte de información de batería - no el control real ya que los CCTK de Dell no están disponibles para arm64 (¿todavía?)_
## Compilar desde el código fuente
### Linux
* Instalar dependencias:
```
sudo apt-get install -y ninja-build libgtk-3-dev libsqlite3-dev libsecret-1-0 libsecret-1-dev
```
* Ejecutar desde el código fuente mediante `flutter run`, construir mediante `flutter build linux --release`
* Empaquetar en `.deb`, `.tar.xz` mediante `./package.sh`

ATENCIÓN: _no_ instale flutter desde `snap`, use la [instalación nativa en su lugar](https://docs.flutter.dev/get-started/install/linux/desktop) - flutter proporcionado por snap fallará al compilar para este proyecto debido a [problemas específicos de snap](https://github.com/juliansteenbakker/flutter_secure_storage/issues/676).

### Windows
* Ejecutar desde el código fuente mediante `flutter run`, construir mediante `flutter build windows --release`
* Empaquetar en `.msi` mediante `.\package.bat`

## Contribuir

### Depuración

Por defecto, todo el registro está suprimido. Exporte `POWERMANAGER_DEBUG=true` antes de ejecutar la aplicación desde CLI para obtener registros.
Ej.: `export POWERMANAGER_DEBUG=true && ./dell-powermanager > file.log`. Al abrir un issue, por favor guarde y adjunte el registro.

### Traducciones
La aplicación soporta múltiples idiomas mediante la biblioteca de localización de Flutter. Si desea contribuir:
* Revise los archivos [lib/l10n/*.arb](https://raw.githubusercontent.com/alexVinarskis/dell-powermanager/master/lib/l10n/app_en.arb).
* Cree un archivo similar para su idioma, traduzca las cadenas.
* Abra un PR con sus cambios.

## Compatibilidad
Probado en los siguientes dispositivos:
* Dell G3 15 3500
    * [Windows 11 24H2 (OS Build 26100.4061)](https://github.com/alexVinarskis/dell-powermanager/issues/65)
* Dell Latitude 5400
    * [Ubuntu 24.04](https://github.com/alexVinarskis/dell-powermanager/issues/56)
* Dell Precision 7560
    * [Fedora 41, 6.12.4](https://github.com/alexVinarskis/dell-powermanager/issues/47)
* Dell XPS 17 9700
    * [Tumbleweed OpenSUSE, 6.7.5](https://github.com/alexVinarskis/dell-powermanager/issues/31)
* Dell XPS 15 9560
    * [Arch Linux, 6.11.6-arch1-1](https://github.com/alexVinarskis/dell-powermanager/issues/46)
* Dell XPS 15 9530 (2023/Fiorano)
    * Ubuntu 23.04, 6.5.0-060500-generic
    * Ubuntu 23.10, 6.5.0-060500-generic
    * Windows 11 Pro 22H2, 22621.2428
* Dell XPS 15 9520
    * [Arch, 6.7.5](https://github.com/alexVinarskis/dell-powermanager/issues/31)
    * Ubuntu 22.04, 6.2.0
    * Windows 11 Home 22H2, 22621.2428
* Dell XPS 13 9345 (Tributo)
    * Ubuntu 24.10, 6.12.0-28-qcom-x1e (solo información de batería)
    * Windows 11 pro
* Dell XPS 13 9310
    * Ubuntu 22.04.3, 6.2.0-26-generic
    * Windows 10 pro 22H2, 19045.3324
* Dell Vostro 5401
    * [Ubuntu 23.10](https://github.com/alexVinarskis/dell-powermanager/issues/23) 

Si experimentaste problemas con alguno de los dispositivos mencionados anteriormente, por favor abre un [**Reporte de Error**](https://github.com/alexVinarskis/dell-powermanager/issues/new?template=bug_report.md&title=[BUG]). Si lo has probado en otros dispositivos, por favor reporta en [**Dispositivo probado**](https://github.com/alexVinarskis/dell-powermanager/issues).

## Problemas conocidos
Por favor revisa los [problemas](https://github.com/alexVinarskis/dell-powermanager/issues).
## Créditos
* Dell por proveer 'Dell Command | Configure CLI'
* Google por crear Flutter :)

## Descargo de responsabilidad
Según la licencia, este software se proporciona tal cual, sin ninguna garantía. No está afiliado a Dell de ninguna manera. Úsalo bajo tu propio riesgo. Ni yo ni otros colaboradores somos responsables por cualquier daño causado por este software, incluyendo pero no limitado a pérdida de datos, daños al hardware, violaciones de datos, etc. Donde sea aplicable, se usa una solución integrada para el almacenamiento seguro de claves, pero no se garantiza que sea segura de ninguna manera. Comprende los riesgos e implicaciones antes de usarlo. No se pueden hacer reclamaciones legales contra el autor o colaboradores.

## Licencia
Esta aplicación está licenciada bajo GPLv3. En resumen, esto significa que puedes usar/copiar/modificar/distribuirlo gratuitamente, pero debes proporcionar el código fuente de tus modificaciones, y mantener la misma licencia. No puedes venderlo como software propietario. Consulta [LICENSE](LICENSE) para más detalles.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---