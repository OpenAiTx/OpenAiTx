# ch32fun

Un ambiente di sviluppo open source (tooling, header, esempi) per il [CH32V003](http://www.wch-ic.com/products/CH32V003.html) (e molti altri chip della famiglia CH32V) con gcc-riscv64, utilizzabile su Windows (Nativo), Linux e/o WSL. Il CH32V003 è un componente da 10 centesimi con core RISC-V EC che funziona a 48MHz, ha 16kB di flash e 2kB di RAM e numerose periferiche. È disponibile anche in package SOP-8, QFN-20 e SOIC. Puoi trovare il datasheet [qui](http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html).

L'obiettivo di questo progetto è sviluppare strumenti e ambiente per l'uso efficiente del CH32V003. Evita HAL complicati e sfrutta l'hardware! L'EVT esistente è enorme e l'ambiente di sviluppo pesante. Questo progetto evita specificamente l'HAL e ti permette di usare direttamente il [TRM](http://www.wch-ic.com/downloads/CH32V003RM_PDF.html). In confronto, il blinky occupa solo 500 byte con ch32fun, si avvia più velocemente ed è notevolmente più semplice.

ch32fun include:
1. Esempi che utilizzano ch32fun, ma non tanti quanti usando l'HAL. La maggior parte sono focalizzati su ch32v003, ma molti sono compatibili anche con altri processori.
2. "minichlink" che utilizza il WCH CH-Link con libusb, per uso cross-platform.
   * Un programmatore STM32F042, il [NHC-Link042](https://github.com/NgoHungCuong/NHC-Link042)
   * Un programmatore ESP32S2, il [esp32s2-funprog](https://github.com/cnlohr/esp32s2-cookbook/tree/master/ch32v003programmer)
   * Il programmatore ufficiale WCH Link-E.
   * Un'interfaccia basata su Arduino, [Ardulink](https://gitlab.com/BlueSyncLine/arduino-ch32v003-swio).
   * Supporta il debugging stile gdbserver per l'uso con Visual Studio.
   * Supporta printf su singolo filo. (A circa 400kBaud)
3. Una copia extra di libgcc per poter usare toolchain risc-v inusuali, situata in `misc/libgcc.a`.
4. Una cartella chiamata "ch32fun" contenente un singolo file sorgente e header autonomi per compilare app per ch32v003.
5. Su alcuni sistemi la possibilità di effettuare "printf" di ritorno tramite
6. Un bootloader demo.

## Supporto per altre famiglie

Attualmente esiste supporto sperimentale per ch32v103, ch32v203, ch32v208, ch32v303, ch32v305 e ch32v307. GDB è testato principalmente sul 003, ma funziona, in misura limitata, anche sugli altri processori.

## Iniziare

Per istruzioni di installazione/configurazione, vedere la [pagina wiki qui](https://github.com/cnlohr/ch32fun/wiki/Installation)

## Caratteristiche!

### Un debug "printf" veloce sull'interfaccia di programmazione.

E per veloce intendo davvero veloce. Tipicamente intorno a 36kBytes/sec.

```
./minichlink -T | pv > /dev/null
Found ESP32S2 Programmer
 536KiB 0:00:15 [36.7KiB/s] [        <=>                     ]
```

Puoi semplicemente provare il progetto debugprintf, o chiamare SetupDebugPrintf(); e usare printf() liberamente.

### Supporto al debugging!

Tramite gdbserver integrato in minichlink! Funziona sia con `gdb-multiarch` sia in Visual Studio Code

## Compilazione e Flash

```
cd examples/blink
make
```

text = codice, data = costanti e valori di inizializzazione, bss = valori non inizializzati.  
dec è la somma dei tre e riflette il numero di byte di flash occupati dal programma.

Il file .bin generato viene usato da minichlink e il file .hex è compatibile con il tool di flash ufficiale WCH.

## VSCode +/- PlatformIO

Nota: PlatformIO è generalmente usato per la CI su questo repository. Sebbene PlatformIO possa essere usato per scrivere e fare debug di un progetto ch32fun in VSCode, puoi anche farlo completamente senza PlatformIO: per questo, vedi il [progetto template](https://github.com/cnlohr/ch32fun/tree/master/examples/template/.vscode).

Questo progetto può essere compilato, caricato e debuggato con VSCode e l'estensione PlatformIO. Basta clonare e aprire questo progetto in VSCode e avere l'estensione PlatformIO installata. Usa il [project environment switcher](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) per selezionare uno specifico esempio, come "blink".

Per creare un nuovo progetto firmware PlatformIO basato su ch32fun, usa semplicemente la funzione "New Project" di [PlatformIO Home](https://docs.platformio.org/en/latest/home/index.html) e imposta "Framework" su "ch32v003fun". Ci sono [vari esempi](https://github.com/Community-PIO-CH32V/platform-ch32v/tree/develop/examples/blinky-ch32v003fun).

![pio_proj](https://raw.githubusercontent.com/cnlohr/ch32fun/master/.github/pio_project_creation.png)

Il comando equivalente della [PlatformIO Core CLI](https://docs.platformio.org/en/latest/integration/ide/vscode.html#platformio-core-cli) sarebbe
```sh
pio init -b genericCH32V003F4P6 -O "framework = ch32v003fun"
```

Se vuoi aggiungere il tuo codice direttamente al progetto ch32fun, espandi gli ambienti disponibili nel file `platformio.ini` come indicato nelle [istruzioni](https://github.com/cnlohr/ch32fun/blob/49640fbccf231191aa83c6a2bbe9d385535b2d1e/platformio.ini#L48-L53).

Nota anche che aprendo questo progetto in PlatformIO puoi usare il [project environment switcher](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) in fondo alla barra delle attività di VSCode per selezionare una specifica cartella di esempio. Altrimenti, "Build" compilerà **tutti** gli esempi di default.

Vedi [platform-ch32v](https://github.com/Community-PIO-CH32V/platform-ch32v) per ulteriori dettagli e installazione della piattaforma.

## clangd

Se il language server C/C++ clangd non trova `ch32fun.h`, l'esempio dovrà essere ripulito con `make clean` e compilato una volta con `bear -- make build`, che genererà un file `compile_commands.json`, utilizzato da clangd per trovare i percorsi di include specificati nei makefile.  
`make clangd` esegue tutto in un solo passaggio.
`build_all_clangd.sh` nella cartella `build scripts` lo fa per tutti gli esempi.

## Riferimento rapido
 * **RICHIESTO** per programmazione/debug: `SWIO` si trova su `PD1`. Non riutilizzare PD1 per più funzioni.
 * **OPZIONALE** `NRST` è su `PD7`. Non necessario, di default come GPIO in alcune configurazioni.
 * **OPZIONALE** UART `TX` è su: `PD5`. Si consiglia di usare SWIO per il debug `printf`.

![ch32v003a4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003a4m6.svg)
![ch32v003f4p6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4p6.svg)
![ch32v003f4u6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4u6.svg)
![ch32v003j4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003j4m6.svg)

## Altri esempi / progetti?

Altri strumenti di terze parti stanno aggiungendo molti esempi, ecc. Vedi i seguenti repository per librerie extra, ecc.
 * [ch32v003fun_wildwest](https://github.com/recallmenot/ch32v003fun_wildwest)
 * [ch32v003fun_libs](https://github.com/hexeguitar/ch32v003fun_libs)
 * [CH32V003_lib_uart](https://github.com/ADBeta/CH32V003_lib_uart)
 * [CH32Vxxx_lib_i2c](https://github.com/ADBeta/CH32Vxxx_lib_i2c)
 * [CH32Vxxx_lib_swi2c](https://github.com/ADBeta/CH32Vxxx_lib_swi2c)
 * [ch32v003fun_shenanigans](https://github.com/DeadBugEngineering/ch32v003fun_shenanigans)
 * [ch32fun-bmp280-driver](https://github.com/pabloestrado/ch32fun-bmp280-driver)
 * [ch32fun-aht20-driver](https://github.com/pabloestrado/ch32fun-aht20-driver)

## Supporto

Puoi aprire un ticket su github o unirti al mio Discord nel canale #ch32fun. Al momento gli inviti sono privati, quindi pingami @cnlohr per un link di invito. I miei messaggi privati sono aperti.

### Note/link

 * https://raw.githubusercontent.com/openwch/ch32v003/main/RISC-V%20QingKeV2%20Microprocessor%20Debug%20Manual.pdf Manuale di Debug
 * http://www.wch-ic.com/downloads/QingKeV2_Processor_Manual_PDF.html Manuale del Processore
 * http://www.wch-ic.com/downloads/CH32V003RM_PDF.html Manuale di Riferimento Tecnico
 * http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html Datasheet
 * https://github.com/CaiB/CH32V003-Architecture-Exploration/blob/main/InstructionTypes.md Dettagli per l'ISA compressa su questo chip.
 * Il CH32V003 ha estensioni xv, puoi usare questa versione personalizzata di rvcodec.js per lavorare con i suoi opcode: https://xw.macyler.moe/

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---