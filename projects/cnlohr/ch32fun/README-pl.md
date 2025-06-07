# ch32fun

Otwarta platforma deweloperska (narzędzia, nagłówki, przykłady) dla [CH32V003](http://www.wch-ic.com/products/CH32V003.html) (oraz wielu innych układów z rodziny CH32V) przy użyciu gcc-riscv64, działająca na Windows (Native), Linux i/lub WSL. CH32V003 to układ za 10 centów z rdzeniem RISC-V EC, taktowany zegarem 48MHz, z 16kB pamięci flash, 2kB RAM oraz wieloma peryferiami. Dostępny jest w obudowach SOP-8, QFN-20 oraz SOIC. Dokumentację można pobrać [tutaj](http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html).

Celem projektu jest opracowanie narzędzi i środowiska do efektywnego wykorzystania CH32V003. Unikaj złożonych HAL-i i uwolnij sprzęt! Istniejące EVT jest ogromne, a środowisko deweloperskie ciężkie. Ten projekt celowo unika HAL i pozwala korzystać bezpośrednio z [TRM](http://www.wch-ic.com/downloads/CH32V003RM_PDF.html). Dla porównania, blinky zajmuje tylko 500 bajtów w ch32fun, uruchamia się szybciej i jest znacznie prostszy.

ch32fun zawiera:
1. Przykłady wykorzystujące ch32fun, choć nie jest ich aż tyle co z użyciem HAL. Większość dotyczy ch32v003, ale wiele z nich jest kompatybilnych z innymi procesorami.
2. „minichlink”, który wykorzystuje WCH CH-Link z libusb, dla pracy wieloplatformowej.
   * Programator STM32F042, [NHC-Link042](https://github.com/NgoHungCuong/NHC-Link042)
   * Programator ESP32S2, [esp32s2-funprog](https://github.com/cnlohr/esp32s2-cookbook/tree/master/ch32v003programmer)
   * Oficjalny programator WCH Link-E.
   * Interfejs oparty na Arduino, [Ardulink](https://gitlab.com/BlueSyncLine/arduino-ch32v003-swio).
   * Obsługa debugowania w stylu gdbserver dla Visual Studio.
   * Obsługa printf przez pojedynczą linię (ok. 400kBaud).
3. Dodatkowa kopia libgcc do użycia z niestandardowymi narzędziami risc-v, dostępna w `misc/libgcc.a`.
4. Katalog "ch32fun" zawierający pojedynczy, samodzielny plik źródłowy i nagłówkowy do kompilacji aplikacji dla ch32v003.
5. Na niektórych systemach możliwość użycia „printf” przez
6. Demo-bootloader.

## Obsługa innych rodzin

Aktualnie istnieje eksperymentalne wsparcie dla ch32v103, ch32v203, ch32v208, ch32v303, ch32v305 oraz ch32v307. GDB jest głównie testowane na 003, ale działa w ograniczonym zakresie także na innych procesorach.

## Pierwsze kroki

Instrukcje instalacji i konfiguracji znajdują się na [stronie wiki](https://github.com/cnlohr/ch32fun/wiki/Installation)

## Funkcje!

### Szybki debug „printf” przez interfejs programowania.

I przez szybki, mam na myśli bardzo szybki. Typowo ok. 36kB/s.

```
./minichlink -T | pv > /dev/null
Found ESP32S2 Programmer
 536KiB 0:00:15 [36.7KiB/s] [        <=>                     ]
```

Możesz po prostu wypróbować projekt debugprintf lub wywołać SetupDebugPrintf(); i korzystać z printf().

### Obsługa debugowania!

Przez gdbserver wbudowany w minichlink! Działa z `gdb-multiarch` oraz w Visual Studio Code.

## Kompilacja i programowanie

```
cd examples/blink
make
```

text = kod, data = stałe i wartości inicjalizacyjne, bss = niezinicjowane wartości.  
dec to suma tych trzech i odzwierciedla liczbę bajtów flash zajmowaną przez program.

Wygenerowany .bin używany jest przez minichlink, a plik .hex jest kompatybilny z oficjalnym narzędziem WCH.

## VSCode +/- PlatformIO

Uwaga: PlatformIO jest głównie używane do CI w tym repozytorium. Chociaż PlatformIO można wykorzystać do kodowania i debugowania projektu ch32fun w VSCode, nie jest to wymagane — można pracować także bez PlatformIO. Zobacz [projekt szablonowy](https://github.com/cnlohr/ch32fun/tree/master/examples/template/.vscode).

Projekt można budować, wgrywać i debugować w VSCode z rozszerzeniem PlatformIO. Wystarczy sklonować i otworzyć projekt w VSCode oraz mieć zainstalowane rozszerzenie PlatformIO. Użyj [przełącznika środowisk projektu](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks), by wybrać konkretny przykład, np. „blink”.

Aby utworzyć nowy projekt firmware PlatformIO oparty na ch32fun, skorzystaj z kreatora „Nowy projekt” w [PlatformIO Home](https://docs.platformio.org/en/latest/home/index.html) i ustaw „Framework” na „ch32v003fun”. Istnieją [różne przykłady](https://github.com/Community-PIO-CH32V/platform-ch32v/tree/develop/examples/blinky-ch32v003fun).

![pio_proj](https://raw.githubusercontent.com/cnlohr/ch32fun/master/.github/pio_project_creation.png)

Odpowiednie polecenie [PlatformIO Core CLI](https://docs.platformio.org/en/latest/integration/ide/vscode.html#platformio-core-cli) to:
```sh
pio init -b genericCH32V003F4P6 -O "framework = ch32v003fun"
```

Jeśli chcesz dodać swój kod bezpośrednio do projektu ch32fun, rozwiń dostępne środowiska w `platformio.ini` zgodnie z [instrukcją](https://github.com/cnlohr/ch32fun/blob/49640fbccf231191aa83c6a2bbe9d385535b2d1e/platformio.ini#L48-L53).

Pamiętaj też, że otwierając ten projekt w PlatformIO, możesz użyć [przełącznika środowisk projektu](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) na dole paska zadań VSCode, aby wybrać konkretny katalog z przykładem. W przeciwnym razie „Build” domyślnie zbuduje **wszystkie** przykłady.

Więcej szczegółów i instrukcji instalacji platformy znajdziesz na [platform-ch32v](https://github.com/Community-PIO-CH32V/platform-ch32v).

## clangd

Jeśli serwer języka C/C++ clangd nie znajduje `ch32fun.h`, należy wyczyścić przykład `make clean` i raz skompilować przy użyciu `bear -- make build`, co wygeneruje `compile_commands.json`, którego clangd używa do znalezienia ścieżek do include’ów z makefile.  
`make clangd` wykonuje to w jednym kroku.  
`build_all_clangd.sh` w katalogu `build scripts` wykonuje to dla wszystkich przykładów.

## Szybka ściągawka
 * **WYMAGANE** do programowania/debugowania: `SWIO` znajduje się na `PD1`. Nie używaj PD1 do wielu funkcji jednocześnie.
 * **OPCJONALNIE** `NRST` znajduje się na `PD7`. Nie jest wymagany, domyślnie jako GPIO w niektórych konfiguracjach.
 * **OPCJONALNIE** UART `TX` na: `PD5`. Zalecamy korzystanie z SWIO do debugowania „printf”.

![ch32v003a4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003a4m6.svg)
![ch32v003f4p6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4p6.svg)
![ch32v003f4u6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4u6.svg)
![ch32v003j4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003j4m6.svg)

## Więcej przykładów / projektów?

Inne narzędzia zewnętrzne dodają wiele przykładów itp. Zobacz poniższe repozytoria dla dodatkowych bibliotek itd.
 * [ch32v003fun_wildwest](https://github.com/recallmenot/ch32v003fun_wildwest)
 * [ch32v003fun_libs](https://github.com/hexeguitar/ch32v003fun_libs)
 * [CH32V003_lib_uart](https://github.com/ADBeta/CH32V003_lib_uart)
 * [CH32Vxxx_lib_i2c](https://github.com/ADBeta/CH32Vxxx_lib_i2c)
 * [CH32Vxxx_lib_swi2c](https://github.com/ADBeta/CH32Vxxx_lib_swi2c)
 * [ch32v003fun_shenanigans](https://github.com/DeadBugEngineering/ch32v003fun_shenanigans)
 * [ch32fun-bmp280-driver](https://github.com/pabloestrado/ch32fun-bmp280-driver)
 * [ch32fun-aht20-driver](https://github.com/pabloestrado/ch32fun-aht20-driver)

## Wsparcie

Możesz otworzyć zgłoszenie na githubie lub dołączyć do mojego Discorda na kanale #ch32fun. Obecnie zaproszenia są prywatne, więc napisz do mnie @cnlohr po link. Wiadomości prywatne są otwarte.

### Przypisy/linki

 * https://raw.githubusercontent.com/openwch/ch32v003/main/RISC-V%20QingKeV2%20Microprocessor%20Debug%20Manual.pdf Debugging Manual
 * http://www.wch-ic.com/downloads/QingKeV2_Processor_Manual_PDF.html Processor Manual
 * http://www.wch-ic.com/downloads/CH32V003RM_PDF.html Technical Reference Manual
 * http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html Datasheet
 * https://github.com/CaiB/CH32V003-Architecture-Exploration/blob/main/InstructionTypes.md Szczegóły kompresowanej ISA dla tego układu.
 * CH32V003 posiada rozszerzenia xv, możesz użyć tej dostosowanej wersji rvcodec.js do pracy z jego kodami: https://xw.macyler.moe/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---