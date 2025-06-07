# ch32fun

Lingkungan pengembangan open source (alat, header, contoh) untuk [CH32V003](http://www.wch-ic.com/products/CH32V003.html) (dan banyak chip lain dalam keluarga CH32V) dengan gcc-riscv64 yang dapat digunakan di Windows (Native), Linux dan/atau WSL. CH32V003 adalah komponen seharga 10 sen dengan inti RISC-V EC yang berjalan pada 48MHz, memiliki 16kB flash dan 2kB RAM serta berbagai periferal. Chip ini juga tersedia dalam kemasan SOP-8, QFN-20, dan SOIC. Anda dapat mengunduh datasheet-nya [di sini](http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html).

Tujuan dari proyek ini adalah mengembangkan alat dan lingkungan untuk penggunaan CH32V003 yang efisien. Menghindari HAL yang rumit, dan memaksimalkan kemampuan hardware! EVT yang ada sangat besar, dan lingkungan pengembangannya berat. Proyek ini secara khusus menghindari HAL dan memungkinkan Anda cukup menggunakan [TRM](http://www.wch-ic.com/downloads/CH32V003RM_PDF.html). Sebagai perbandingan, blinky hanya 500 byte dengan ch32fun, boot lebih cepat, dan jauh lebih sederhana.

ch32fun mencakup:
1. Contoh penggunaan ch32fun, namun tidak sebanyak yang menggunakan HAL. Sebagian besar fokus pada ch32v003, tetapi banyak juga yang kompatibel dengan prosesor lain.
2. "minichlink" yang menggunakan WCH CH-Link dengan libusb, untuk penggunaan lintas platform.
  * Programmer STM32F042, [NHC-Link042](https://github.com/NgoHungCuong/NHC-Link042)
  * Programmer ESP32S2, [esp32s2-funprog](https://github.com/cnlohr/esp32s2-cookbook/tree/master/ch32v003programmer)
  * Programmer resmi WCH Link-E.
  * Antarmuka berbasis Arduino, [Ardulink](https://gitlab.com/BlueSyncLine/arduino-ch32v003-swio).
  * Mendukung debugging gaya gdbserver untuk digunakan dengan Visual Studio.
  * Mendukung printf lewat single-wire. (Sekitar 400kBaud)
3. Salinan tambahan libgcc agar Anda dapat menggunakan toolchain riscv yang tidak biasa, terletak di `misc/libgcc.a`.
4. Folder bernama "ch32fun" yang berisi satu file sumber dan header yang mandiri untuk kompilasi aplikasi pada ch32v003.
5. Pada beberapa sistem kemampuan untuk "printf" balik melalui
6. Demo bootloader.

## Dukungan keluarga lain

Saat ini, ada dukungan eksperimental untuk ch32v103, ch32v203, ch32v208, ch32v303, ch32v305, dan ch32v307. GDB sebagian besar diuji pada 003, tetapi bekerja, dengan tingkat terbatas pada prosesor lainnya.

## Memulai

Untuk instruksi instalasi / setup, lihat [halaman wiki di sini](https://github.com/cnlohr/ch32fun/wiki/Installation)

## Fitur!

### "printf" debug cepat melalui interface pemrograman.

Dan cepat di sini benar-benar cepat. Biasanya sekitar 36kByte/detik.

```
./minichlink -T | pv > /dev/null
Found ESP32S2 Programmer
 536KiB 0:00:15 [36.7KiB/s] [        <=>                     ]
```

Anda dapat mencoba proyek debugprintf, atau panggil SetupDebugPrintf(); lalu printf() sesuka Anda.

### Dukungan Debugging!

Melalui gdbserver yang terintegrasi di minichlink! Berfungsi dengan `gdb-multiarch` juga di Visual Studio Code

## Build dan Flash

```
cd examples/blink
make
```

text = kode, data = nilai konstanta dan inisialisasi, bss = nilai tidak diinisialisasi.
dec adalah jumlah dari ketiganya dan mencerminkan jumlah byte flash yang akan digunakan oleh program.

File .bin yang dihasilkan digunakan oleh minichlink dan file .hex kompatibel dengan tool flash resmi WCH.

## VSCode +/- PlatformIO

Catatan: PlatformIO umumnya digunakan untuk CI di repo ini. Meskipun PlatformIO dapat digunakan untuk coding dan debugging proyek ch32fun di dalam VSCode, Anda juga dapat melakukannya tanpa PlatformIO sama sekali: Untuk itu, lihat [template project](https://github.com/cnlohr/ch32fun/tree/master/examples/template/.vscode).

Proyek ini dapat di-build, upload dan debug dengan VSCode dan ekstensi PlatformIO. Cukup clone dan buka proyek ini di VSCode dan pastikan ekstensi PlatformIO sudah terpasang. Gunakan [project environment switcher](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) untuk memilih contoh spesifik, seperti "blink".

Untuk membuat proyek firmware PlatformIO baru berbasis ch32fun, cukup gunakan wizard "New Project" pada [PlatformIO Home](https://docs.platformio.org/en/latest/home/index.html) dan atur "Framework" ke "ch32v003fun". Ada [berbagai contoh](https://github.com/Community-PIO-CH32V/platform-ch32v/tree/develop/examples/blinky-ch32v003fun).

![pio_proj](https://raw.githubusercontent.com/cnlohr/ch32fun/master/.github/pio_project_creation.png)

Perintah [PlatformIO Core CLI](https://docs.platformio.org/en/latest/integration/ide/vscode.html#platformio-core-cli) yang setara adalah
```sh
pio init -b genericCH32V003F4P6 -O "framework = ch32v003fun"
```

Jika Anda ingin menambah kode langsung ke proyek ch32fun, harap perluas environment yang tersedia di `platformio.ini` sesuai [petunjuk](https://github.com/cnlohr/ch32fun/blob/49640fbccf231191aa83c6a2bbe9d385535b2d1e/platformio.ini#L48-L53).

Perlu diperhatikan juga bahwa saat membuka proyek ini di PlatformIO, Anda bisa menggunakan [project environment switcher](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) di bagian bawah taskbar VSCode untuk memilih folder contoh tertentu. Jika tidak, "Build" secara default akan membangun **semua** contoh.

Lihat [platform-ch32v](https://github.com/Community-PIO-CH32V/platform-ch32v) untuk detail lebih lanjut dan instalasi platform.

## clangd

Jika language server C/C++ clangd tidak dapat menemukan `ch32fun.h`, contoh harus dihapus dengan `make clean` dan dibangun sekali dengan `bear -- make build`, yang akan menghasilkan `compile_commands.json` yang digunakan clangd untuk menemukan path include yang ditentukan di makefile.
`make clangd` melakukan ini dalam satu langkah.
`build_all_clangd.sh` di `build scripts` melakukan ini untuk semua contoh.

## Referensi Cepat
 * **WAJIB** untuk pemrograman/debugging: `SWIO` ada di `PD1`. Jangan gunakan PD1 untuk beberapa fungsi.
 * **OPSIONAL** `NRST` ada di `PD7`. Tidak dibutuhkan, default sebagai GPIO pada beberapa konfigurasi.
 * **OPSIONAL** UART `TX` ada di: `PD5`. Kami rekomendasikan menggunakan SWIO untuk debugging `printf`.

![ch32v003a4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003a4m6.svg)
![ch32v003f4p6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4p6.svg)
![ch32v003f4u6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4u6.svg)
![ch32v003j4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003j4m6.svg)

## Contoh / proyek lain?

Alat pihak ketiga lainnya menambahkan banyak contoh, dll. Lihat repositori berikut untuk pustaka tambahan, dll.
 * [ch32v003fun_wildwest](https://github.com/recallmenot/ch32v003fun_wildwest)
 * [ch32v003fun_libs](https://github.com/hexeguitar/ch32v003fun_libs)
 * [CH32V003_lib_uart](https://github.com/ADBeta/CH32V003_lib_uart)
 * [CH32Vxxx_lib_i2c](https://github.com/ADBeta/CH32Vxxx_lib_i2c)
 * [CH32Vxxx_lib_swi2c](https://github.com/ADBeta/CH32Vxxx_lib_swi2c)
 * [ch32v003fun_shenanigans](https://github.com/DeadBugEngineering/ch32v003fun_shenanigans)
 * [ch32fun-bmp280-driver](https://github.com/pabloestrado/ch32fun-bmp280-driver)
 * [ch32fun-aht20-driver](https://github.com/pabloestrado/ch32fun-aht20-driver)

## Dukungan

Anda dapat membuka tiket github atau bergabung di Discord saya di channel #ch32fun. Saat ini undangan bersifat privat, jadi cukup ping saya @cnlohr untuk mendapatkan link undangan. PM saya terbuka.

### Catatan kaki/link

 * https://raw.githubusercontent.com/openwch/ch32v003/main/RISC-V%20QingKeV2%20Microprocessor%20Debug%20Manual.pdf Debugging Manual
 * http://www.wch-ic.com/downloads/QingKeV2_Processor_Manual_PDF.html Processor Manual
 * http://www.wch-ic.com/downloads/CH32V003RM_PDF.html Technical Reference Manual
 * http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html Datasheet
 * https://github.com/CaiB/CH32V003-Architecture-Exploration/blob/main/InstructionTypes.md Detail untuk ISA terkompresi di chip ini.
 * CH32V003 memiliki ekstensi xv, Anda dapat menggunakan versi kustom rvcodec.js ini untuk bekerja dengan opcode-nya: https://xw.macyler.moe/

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---