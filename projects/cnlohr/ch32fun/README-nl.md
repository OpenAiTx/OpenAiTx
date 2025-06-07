# ch32fun

Een open source ontwikkelomgeving (tooling, headers, voorbeelden) voor de [CH32V003](http://www.wch-ic.com/products/CH32V003.html) (en vele andere chips binnen de CH32V-familie) met gcc-riscv64 die gebruikt kan worden op Windows (Native), Linux en/of WSL. De CH32V003 is een onderdeel van 10 cent met een RISC-V EC-core die draait op 48MHz, beschikt over 16kB flash en 2kB RAM en een reeks aan randapparatuur. Hij is beschikbaar in SOP-8, QFN-20 en SOIC behuizingen. Het datasheet kun je [hier](http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html) vinden.

Het doel van dit project is het ontwikkelen van de tooling en omgeving voor efficiënt gebruik van de CH32V003. Voorkom ingewikkelde HALs, en gebruik de hardware optimaal! De bestaande EVT is enorm, en de ontwikkelomgeving zwaar. Dit project vermijdt bewust de HAL en maakt het mogelijk om direct de [TRM](http://www.wch-ic.com/downloads/CH32V003RM_PDF.html) te gebruiken. Ter vergelijking: blinky is slechts 500 bytes met ch32fun, start sneller op en is significant eenvoudiger.

ch32fun bevat:
1. Voorbeelden die ch32fun gebruiken, maar niet zoveel als bij gebruik van de HAL. De meeste zijn gericht op de ch32v003, maar veel zijn ook compatibel met andere processoren.
2. "minichlink" dat de WCH CH-Link gebruikt met libusb, voor cross-platform gebruik.
  * Een STM32F042 Programmeur, de [NHC-Link042](https://github.com/NgoHungCuong/NHC-Link042)
  * Een ESP32S2 Programmeur, de [esp32s2-funprog](https://github.com/cnlohr/esp32s2-cookbook/tree/master/ch32v003programmer)
  * De officiële WCH Link-E Programmeur.
  * Een Arduino-gebaseerde interface, [Ardulink](https://gitlab.com/BlueSyncLine/arduino-ch32v003-swio).
  * Ondersteuning voor gdbserver-style-debugging voor gebruik met Visual Studio.
  * Ondersteunt printf-over-single-wire. (Ongeveer 400kBaud)
3. Een extra kopie van libgcc zodat je ongebruikelijke risc-v build chains kunt gebruiken, te vinden in `misc/libgcc.a`.
4. Een map genaamd "ch32fun" met één zelfvoorzienend bronbestand en headerbestand voor het compileren van apps voor de ch32v003.
5. Op sommige systemen de mogelijkheid om "printf" terug te sturen via
6. Een demo bootloader.

## Ondersteuning voor andere familie

Momenteel is er experimentele ondersteuning voor de ch32v103, ch32v203, ch32v208, ch32v303, ch32v305 en ch32v307. GDB is vooral getest op de 003, maar werkt in beperkte mate ook op de andere processoren.

## Aan de slag

Voor installatie-/setupinstructies, zie de [wiki-pagina hier](https://github.com/cnlohr/ch32fun/wiki/Installation)

## Functies!

###  Een snelle "printf" debug via de programmeerinterface.

En met snel bedoel ik echt snel. Typisch rond de 36kBytes/sec.

```
./minichlink -T | pv > /dev/null
Found ESP32S2 Programmer
 536KiB 0:00:15 [36.7KiB/s] [        <=>                     ]
```

Je kunt het debugprintf-project gewoon uitproberen, of SetupDebugPrintf(); aanroepen en printf() gebruiken.

### Debugging ondersteuning!

Via gdbserver ingebouwd in minichlink! Werkt met `gdb-multiarch` en ook in Visual Studio Code

## Bouwen en Flashen

```
cd examples/blink
make
```

text = code, data = constanten en initialisatiewaarden, bss = niet-geïnitialiseerde waarden.  
dec is de som van de drie en geeft het aantal bytes in flash aan dat door het programma wordt ingenomen.

Het gegenereerde .bin-bestand wordt gebruikt door minichlink en het .hex-bestand is compatibel met de officiële WCH flash tool.

## VSCode +/- PlatformIO

Let op: PlatformIO wordt over het algemeen gebruikt voor CI op deze repo. Hoewel PlatformIO kan worden gebruikt om een ch32fun-project te coderen en te debuggen binnen VSCode, kun je het ook volledig zonder PlatformIO doen: Zie daarvoor het [template project](https://github.com/cnlohr/ch32fun/tree/master/examples/template/.vscode).

Dit project kan worden gebouwd, geüpload en gedebugd met VSCode en de PlatformIO-extensie. Clone en open dit project gewoon in VSCode en zorg dat de PlatformIO-extensie is geïnstalleerd. Gebruik de [project environment switcher](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) om een specifiek voorbeeld te selecteren, zoals "blink".

Om een nieuw PlatformIO firmwareproject te maken op basis van ch32fun, gebruik je de "New Project"-wizard van [PlatformIO Home](https://docs.platformio.org/en/latest/home/index.html) en stel je "Framework" in op "ch32v003fun". Er zijn [verschillende voorbeelden](https://github.com/Community-PIO-CH32V/platform-ch32v/tree/develop/examples/blinky-ch32v003fun).

![pio_proj](.github/pio_project_creation.png)

Het equivalente [PlatformIO Core CLI](https://docs.platformio.org/en/latest/integration/ide/vscode.html#platformio-core-cli) commando zou zijn
```sh
pio init -b genericCH32V003F4P6 -O "framework = ch32v003fun"
```

Wil je je code direct toevoegen aan het ch32fun-project, breid dan de beschikbare omgevingen uit in de `platformio.ini` zoals [hier beschreven](https://github.com/cnlohr/ch32fun/blob/49640fbccf231191aa83c6a2bbe9d385535b2d1e/platformio.ini#L48-L53).

Let ook op dat je bij het openen van dit project binnen PlatformIO de [project environment switcher](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) onderaan de VSCode-taakbalk kunt gebruiken om een specifieke voorbeeldmap te selecteren. Anders wordt standaard **alle** voorbeelden gebouwd bij "Build".

Zie [platform-ch32v](https://github.com/Community-PIO-CH32V/platform-ch32v) voor meer details en installatie van het platform.

## clangd

Als de C/C++ language server clangd `ch32fun.h` niet kan vinden, moet het voorbeeld worden gewist met `make clean` en één keer worden gebouwd met `bear -- make build`, waardoor een `compile_commands.json` wordt gegenereerd die clangd gebruikt om de in de makefiles gespecificeerde include-paden te vinden.  
`make clangd` doet dit in één stap.
`build_all_clangd.sh` in `build scripts` doet dit voor alle voorbeelden.

## Snelle Referentie
 * **VEREIST** voor programmeren/debugging: `SWIO` zit op `PD1`. Gebruik PD1 niet voor meerdere functies.
 * **OPTIONEEL** `NRST` zit op `PD7`. Niet nodig, standaard als GPIO in sommige configuraties.
 * **OPTIONEEL** UART `TX` zit op: `PD5`. We raden aan om SWIO te gebruiken voor `printf` debugging.

![ch32v003a4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003a4m6.svg)
![ch32v003f4p6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4p6.svg)
![ch32v003f4u6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4u6.svg)
![ch32v003j4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003j4m6.svg)

## Meer voorbeelden / projecten?

Andere tools van derden voegen veel voorbeelden toe, enzovoorts. Zie de volgende repos voor extra bibliotheken, enz.
 * [ch32v003fun_wildwest](https://github.com/recallmenot/ch32v003fun_wildwest)
 * [ch32v003fun_libs](https://github.com/hexeguitar/ch32v003fun_libs)
 * [CH32V003_lib_uart](https://github.com/ADBeta/CH32V003_lib_uart)
 * [CH32Vxxx_lib_i2c](https://github.com/ADBeta/CH32Vxxx_lib_i2c)
 * [CH32Vxxx_lib_swi2c](https://github.com/ADBeta/CH32Vxxx_lib_swi2c)
 * [ch32v003fun_shenanigans](https://github.com/DeadBugEngineering/ch32v003fun_shenanigans)
 * [ch32fun-bmp280-driver](https://github.com/pabloestrado/ch32fun-bmp280-driver)
 * [ch32fun-aht20-driver](https://github.com/pabloestrado/ch32fun-aht20-driver)

## Ondersteuning

Je kunt een github-ticket openen of mijn Discord joinen in het #ch32fun kanaal. Op dit moment zijn uitnodigingen privé, dus stuur me gewoon een ping @cnlohr voor een uitnodigingslink. Mijn privéberichten staan open.

### Voetnoten/links

 * https://raw.githubusercontent.com/openwch/ch32v003/main/RISC-V%20QingKeV2%20Microprocessor%20Debug%20Manual.pdf Debugging Manual
 * http://www.wch-ic.com/downloads/QingKeV2_Processor_Manual_PDF.html Processor Manual
 * http://www.wch-ic.com/downloads/CH32V003RM_PDF.html Technical Reference Manual
 * http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html Datasheet
 * https://github.com/CaiB/CH32V003-Architecture-Exploration/blob/main/InstructionTypes.md Details voor de gecomprimeerde ISA op deze chip.
 * De CH32V003 heeft xv-extensies, je kunt deze aangepaste versie van rvcodec.js gebruiken om met zijn opcodes te werken: https://xw.macyler.moe/

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---