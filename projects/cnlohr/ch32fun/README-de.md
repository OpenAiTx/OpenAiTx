# ch32fun

Eine Open-Source-Entwicklungsumgebung (Toolchain, Header, Beispiele) für den [CH32V003](http://www.wch-ic.com/products/CH32V003.html) (und viele andere Chips der CH32V-Familie) mit gcc-riscv64, die unter Windows (nativ), Linux und/oder WSL verwendet werden kann. Der CH32V003 ist ein 10-Cent-Baustein mit einem RISC-V-EC-Kern, der mit 48 MHz läuft, 16 kB Flash und 2 kB RAM sowie zahlreiche Peripherie besitzt. Er ist in SOP-8-, QFN-20- und SOIC-Gehäusen erhältlich. Das Datenblatt finden Sie [hier](http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html).

Das Ziel dieses Projekts ist die Entwicklung von Tools und einer Umgebung für die effiziente Nutzung des CH32V003. Komplexe HALs werden vermieden, um die Hardware voll auszunutzen! Das bestehende EVT ist riesig und die Entwicklungsumgebung schwergewichtig. Dieses Projekt vermeidet gezielt die HAL und ermöglicht die direkte Nutzung des [TRM](http://www.wch-ic.com/downloads/CH32V003RM_PDF.html). Im Vergleich dazu ist Blinky mit ch32fun nur 500 Bytes groß, startet schneller und ist insgesamt deutlich einfacher.

ch32fun enthält:
1. Beispiele, die ch32fun verwenden, jedoch nicht so viele wie mit der HAL. Die meisten konzentrieren sich auf den ch32v003, viele sind jedoch auch mit anderen Prozessoren kompatibel.
2. "minichlink", das den WCH CH-Link mit libusb nutzt und plattformübergreifend funktioniert.
   * Einen STM32F042-Programmer, den [NHC-Link042](https://github.com/NgoHungCuong/NHC-Link042)
   * Einen ESP32S2-Programmer, den [esp32s2-funprog](https://github.com/cnlohr/esp32s2-cookbook/tree/master/ch32v003programmer)
   * Den offiziellen WCH Link-E-Programmer.
   * Ein Arduino-basiertes Interface, [Ardulink](https://gitlab.com/BlueSyncLine/arduino-ch32v003-swio).
   * Unterstützt GDBserver-Debugging zur Verwendung mit Visual Studio.
   * Unterstützt printf-over-single-wire (mit ca. 400 kBaud).
3. Eine zusätzliche Kopie von libgcc, damit auch ungewöhnliche RISC-V-Buildchains verwendet werden können, zu finden in `misc/libgcc.a`.
4. Einen Ordner "ch32fun" mit einer einzigen, selbstständigen Quell- und Headerdatei zum Kompilieren von Anwendungen für den ch32v003.
5. Auf manchen Systemen die Möglichkeit, "printf" zurückzusenden
6. Einen Demo-Bootloader.

## Unterstützung weiterer Familien

Aktuell gibt es experimentelle Unterstützung für ch32v103, ch32v203, ch32v208, ch32v303, ch32v305 und ch32v307. GDB ist hauptsächlich auf dem 003 getestet, funktioniert aber in begrenztem Umfang auch auf anderen Prozessoren.

## Einstieg

Installations- und Einrichtungshinweise finden Sie auf der [Wiki-Seite](https://github.com/cnlohr/ch32fun/wiki/Installation).

## Features!

### Schnelles "printf"-Debugging über die Programmierschnittstelle

Und mit schnell ist wirklich schnell gemeint. Typischerweise etwa 36 kByte/s.

```
./minichlink -T | pv > /dev/null
Found ESP32S2 Programmer
 536KiB 0:00:15 [36.7KiB/s] [        <=>                     ]
```

Sie können einfach das Debugprintf-Projekt ausprobieren oder SetupDebugPrintf(); aufrufen und mit printf() loslegen.

### Debugging-Unterstützung!

Über den in minichlink integrierten GDBserver! Funktioniert mit `gdb-multiarch` sowie in Visual Studio Code.

## Kompilieren und Flashen

```
cd examples/blink
make
```

text = Code, data = Konstanten und Initialisierungswerte, bss = nicht initialisierte Werte.  
dec ist die Summe der drei und gibt die Anzahl der Bytes im Flash an, die vom Programm belegt werden.

Die erzeugte .bin-Datei wird von minichlink verwendet und die .hex-Datei ist mit dem offiziellen WCH-Flash-Tool kompatibel.

## VSCode +/- PlatformIO

Hinweis: PlatformIO wird auf diesem Repo meist für CI verwendet. Während PlatformIO zum Entwickeln und Debuggen eines ch32fun-Projekts in VSCode genutzt werden kann, ist dies auch komplett ohne PlatformIO möglich: Siehe hierzu das [Template-Projekt](https://github.com/cnlohr/ch32fun/tree/master/examples/template/.vscode).

Dieses Projekt kann mit VSCode und der PlatformIO-Erweiterung gebaut, hochgeladen und debuggt werden. Klonen und öffnen Sie einfach dieses Projekt in VSCode und installieren Sie die PlatformIO-Erweiterung. Mit dem [Projektumgebungsschalter](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) können Sie ein bestimmtes Beispiel, z. B. "blink", auswählen.

Um ein neues PlatformIO-Firmwareprojekt auf Basis von ch32fun zu erstellen, verwenden Sie einfach den "New Project"-Assistenten von [PlatformIO Home](https://docs.platformio.org/en/latest/home/index.html) und wählen Sie "Framework" auf "ch32v003fun". Es gibt [verschiedene Beispiele](https://github.com/Community-PIO-CH32V/platform-ch32v/tree/develop/examples/blinky-ch32v003fun).

![pio_proj](.github/pio_project_creation.png)

Der äquivalente Befehl für die [PlatformIO Core CLI](https://docs.platformio.org/en/latest/integration/ide/vscode.html#platformio-core-cli) lautet:
```sh
pio init -b genericCH32V003F4P6 -O "framework = ch32v003fun"
```

Wenn Sie Ihren Code direkt zum ch32fun-Projekt hinzufügen möchten, erweitern Sie bitte die verfügbaren Umgebungen in der `platformio.ini` wie in der [Anleitung](https://github.com/cnlohr/ch32fun/blob/49640fbccf231191aa83c6a2bbe9d385535b2d1e/platformio.ini#L48-L53) beschrieben.

Bitte beachten Sie auch, dass Sie beim Öffnen dieses Projekts in PlatformIO mit dem [Projektumgebungsschalter](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) unten in der VSCode-Taskleiste einen bestimmten Beispielordner auswählen können. Andernfalls werden beim "Build" standardmäßig **alle** Beispiele gebaut.

Weitere Informationen und die Installation der Plattform finden Sie unter [platform-ch32v](https://github.com/Community-PIO-CH32V/platform-ch32v).

## clangd

Falls der C/C++-Sprachserver clangd `ch32fun.h` nicht findet, muss das Beispiel mit `make clean` gelöscht und einmal mit `bear -- make build` gebaut werden. Dadurch wird eine `compile_commands.json` generiert, welche clangd nutzt, um die in den Makefiles angegebenen Include-Pfade zu finden.  
`make clangd` erledigt dies in einem Schritt.  
`build_all_clangd.sh` im Verzeichnis `build scripts` erledigt dies für alle Beispiele.

## Schnellreferenz
 * **ERFORDERLICH** für Programmierung/Debugging: `SWIO` ist auf `PD1`. PD1 nicht für mehrere Funktionen gleichzeitig nutzen.
 * **OPTIONAL** `NRST` ist auf `PD7`. Nicht zwingend erforderlich, wird in manchen Konfigurationen standardmäßig als GPIO genutzt.
 * **OPTIONAL** UART `TX` ist auf: `PD5`. Für `printf`-Debugging wird SWIO empfohlen.

![ch32v003a4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003a4m6.svg)
![ch32v003f4p6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4p6.svg)
![ch32v003f4u6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4u6.svg)
![ch32v003j4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003j4m6.svg)

## Weitere Beispiele / Projekte?

Andere Drittanbieter-Tools fügen viele Beispiele usw. hinzu. Siehe folgende Repos für zusätzliche Bibliotheken usw.:
 * [ch32v003fun_wildwest](https://github.com/recallmenot/ch32v003fun_wildwest)
 * [ch32v003fun_libs](https://github.com/hexeguitar/ch32v003fun_libs)
 * [CH32V003_lib_uart](https://github.com/ADBeta/CH32V003_lib_uart)
 * [CH32Vxxx_lib_i2c](https://github.com/ADBeta/CH32Vxxx_lib_i2c)
 * [CH32Vxxx_lib_swi2c](https://github.com/ADBeta/CH32Vxxx_lib_swi2c)
 * [ch32v003fun_shenanigans](https://github.com/DeadBugEngineering/ch32v003fun_shenanigans)
 * [ch32fun-bmp280-driver](https://github.com/pabloestrado/ch32fun-bmp280-driver)
 * [ch32fun-aht20-driver](https://github.com/pabloestrado/ch32fun-aht20-driver)

## Support

Sie können ein GitHub-Ticket eröffnen oder meinem Discord im #ch32fun-Kanal beitreten. Momentan sind Einladungen privat – einfach @cnlohr für einen Einladungslink anpingen. Meine PMs sind offen.

### Fußnoten/Links

 * https://raw.githubusercontent.com/openwch/ch32v003/main/RISC-V%20QingKeV2%20Microprocessor%20Debug%20Manual.pdf Debugging-Handbuch
 * http://www.wch-ic.com/downloads/QingKeV2_Processor_Manual_PDF.html Prozessor-Handbuch
 * http://www.wch-ic.com/downloads/CH32V003RM_PDF.html Technisches Referenzhandbuch
 * http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html Datenblatt
 * https://github.com/CaiB/CH32V003-Architecture-Exploration/blob/main/InstructionTypes.md Details zur komprimierten ISA auf diesem Chip
 * Der CH32V003 hat XV-Erweiterungen. Sie können diese angepasste Version von rvcodec.js für seine Opcodes verwenden: https://xw.macyler.moe/

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---