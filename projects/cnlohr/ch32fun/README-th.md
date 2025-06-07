# ch32fun

สภาพแวดล้อมการพัฒนาแบบโอเพ่นซอร์ส (เครื่องมือ, เฮดเดอร์, ตัวอย่าง) สำหรับ [CH32V003](http://www.wch-ic.com/products/CH32V003.html) (และชิปอื่นๆ ในตระกูล CH32V) ที่ใช้ gcc-riscv64 ซึ่งสามารถใช้งานได้ทั้งบน Windows (Native), Linux และ/หรือ WSL โดย CH32V003 เป็นชิ้นส่วนราคาประมาณ 10 เซ็นต์ ที่ใช้คอร์ RISC-V EC ทำงานที่ 48MHz, มีแฟลช 16kB และ RAM 2kB พร้อมอุปกรณ์ต่อพ่วงหลากหลาย นอกจากนี้ยังมีแพ็คเกจ SOP-8, QFN-20 และ SOIC คุณสามารถดาวน์โหลด datasheet ได้ [ที่นี่](http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html)

เป้าหมายของโปรเจ็กต์นี้คือการพัฒนาเครื่องมือและสภาพแวดล้อมสำหรับการใช้งาน CH32V003 อย่างมีประสิทธิภาพ หลีกเลี่ยง HAL ที่ซับซ้อน และใช้งานฮาร์ดแวร์อย่างเต็มที่! EVT ที่มีอยู่ค่อนข้างใหญ่ และสภาพแวดล้อมการพัฒนาหนัก โปรเจ็กต์นี้ตั้งใจหลีกเลี่ยง HAL และทำให้คุณสามารถใช้ [TRM](http://www.wch-ic.com/downloads/CH32V003RM_PDF.html) ได้โดยตรง ในทางตรงข้าม ตัวอย่าง blinky มีขนาดเพียง 500 ไบต์ เมื่อใช้ ch32fun, บู๊ตเร็วขึ้น และเรียบง่ายกว่ามาก

ch32fun ประกอบด้วย:
1. ตัวอย่างการใช้งาน ch32fun ซึ่งอาจไม่มากเท่ากับ HAL ส่วนใหญ่เน้นที่ ch32v003 แต่หลายตัวอย่างก็สามารถใช้กับโปรเซสเซอร์อื่นได้ด้วย
2. "minichlink" ซึ่งใช้ WCH CH-Link กับ libusb สำหรับการใช้งานข้ามแพลตฟอร์ม
   * STM32F042 Programmer คือ [NHC-Link042](https://github.com/NgoHungCuong/NHC-Link042)
   * ESP32S2 Programmer คือ [esp32s2-funprog](https://github.com/cnlohr/esp32s2-cookbook/tree/master/ch32v003programmer)
   * ตัวโปรแกรมอย่างเป็นทางการ WCH Link-E Programmer
   * อินเทอร์เฟซบน Arduino [Ardulink](https://gitlab.com/BlueSyncLine/arduino-ch32v003-swio)
   * รองรับ gdbserver-style-debugging สำหรับใช้งานกับ Visual Studio
   * รองรับ printf-over-single-wire (ที่ประมาณ 400kBaud)
3. สำเนา libgcc เพิ่มเติม เพื่อให้สามารถใช้ build chain riscv ที่ไม่ปกติได้ อยู่ใน `misc/libgcc.a`
4. โฟลเดอร์ชื่อ "ch32fun" ที่มีไฟล์ซอร์สและเฮดเดอร์เพียงไฟล์เดียวสำหรับคอมไพล์แอปสำหรับ ch32v003
5. บางระบบรองรับ "printf" กลับผ่าน
6. ตัวอย่าง bootloader

## การรองรับตระกูลอื่น

ปัจจุบันมีการรองรับแบบทดลองสำหรับ ch32v103, ch32v203, ch32v208, ch32v303, ch32v305 และ ch32v307 GDB ได้ทดสอบส่วนใหญ่บน 003 แต่ก็ใช้งานได้ในระดับหนึ่งกับโปรเซสเซอร์อื่น

## เริ่มต้นใช้งาน

สำหรับคำแนะนำการติดตั้ง/ตั้งค่า ดูได้ที่ [wiki page ที่นี่](https://github.com/cnlohr/ch32fun/wiki/Installation)

## คุณสมบัติ!

###  "printf" debug เร็วสูงผ่านพอร์ตโปรแกรม

และที่ว่าร็ว หมายถึง เร็วมาก โดยทั่วไปประมาณ 36kBytes/วินาที

```
./minichlink -T | pv > /dev/null
Found ESP32S2 Programmer
 536KiB 0:00:15 [36.7KiB/s] [        <=>                     ]
```

คุณสามารถทดลองโปรเจ็กต์ debugprintf ได้เลย หรือเรียก SetupDebugPrintf(); และใช้ printf() ได้ทันที

### รองรับการดีบัก!

ผ่าน gdbserver ที่ฝังอยู่ใน minichlink! ใช้งานได้กับ `gdb-multiarch` และ Visual Studio Code

## การ build และ Flash

```
cd examples/blink
make
```

text = โค้ด, data = ค่าคงที่และค่าที่ใช้สำหรับ initialize, bss = ค่าที่ไม่ได้ initialize  
dec คือผลรวมของทั้ง 3 และแสดงจำนวนไบต์ในแฟลชที่โปรแกรมจะใช้

ไฟล์ .bin ที่สร้างขึ้นใช้กับ minichlink ส่วนไฟล์ .hex สามารถใช้กับ WCH flash tool อย่างเป็นทางการ

## VSCode +/- PlatformIO

หมายเหตุ: โดยทั่วไป PlatformIO ใช้สำหรับ CI ใน repo นี้ แม้ว่า PlatformIO สามารถใช้สำหรับโค้ดและดีบักโปรเจ็กต์ ch32fun ใน VSCode ได้ คุณก็สามารถทำทุกอย่างได้โดยไม่ต้องใช้ PlatformIO เช่นกัน: ดูได้ที่ [template project](https://github.com/cnlohr/ch32fun/tree/master/examples/template/.vscode)

โปรเจ็กต์นี้สามารถ build, upload และ debug ได้ด้วย VSCode และ PlatformIO extension เพียง clone และเปิดโปรเจ็กต์นี้ใน VSCode และติดตั้ง PlatformIO extension ใช้ [project environment switcher](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) เพื่อเลือกตัวอย่างที่ต้องการ เช่น "blink"

หากต้องการสร้างเฟิร์มแวร์โปรเจ็กต์ PlatformIO ใหม่ที่ใช้ ch32fun เพียงใช้ [PlatformIO Home](https://docs.platformio.org/en/latest/home/index.html) "New Project" wizard และตั้งค่า "Framework" เป็น "ch32v003fun" มี [ตัวอย่างหลากหลาย](https://github.com/Community-PIO-CH32V/platform-ch32v/tree/develop/examples/blinky-ch32v003fun)

![pio_proj](.github/pio_project_creation.png)

คำสั่ง [PlatformIO Core CLI](https://docs.platformio.org/en/latest/integration/ide/vscode.html#platformio-core-cli) ที่เทียบเท่าคือ
```sh
pio init -b genericCH32V003F4P6 -O "framework = ch32v003fun"
```

ถ้าต้องการเพิ่มโค้ดของคุณโดยตรงในโปรเจ็กต์ ch32fun กรุณาขยาย environment ที่มีอยู่ใน `platformio.ini` ตาม [คำแนะนำ](https://github.com/cnlohr/ch32fun/blob/49640fbccf231191aa83c6a2bbe9d385535b2d1e/platformio.ini#L48-L53)

โปรดทราบว่าเมื่อคุณเปิดโปรเจ็กต์นี้ใน PlatformIO คุณสามารถใช้ [project environment switcher](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) ที่ด้านล่างของ taskbar VSCode เพื่อเลือกโฟลเดอร์ตัวอย่างที่ต้องการ ไม่เช่นนั้น "Build" จะ build **ตัวอย่างทั้งหมด** เป็นค่าเริ่มต้น

ดู [platform-ch32v](https://github.com/Community-PIO-CH32V/platform-ch32v) สำหรับรายละเอียดเพิ่มเติมและการติดตั้ง platform

## clangd

หากภาษาเซิร์ฟเวอร์ C/C++ อย่าง clangd ไม่สามารถหา `ch32fun.h` ได้ จะต้องลบตัวอย่าง (`make clean`) และ build ใหม่หนึ่งครั้งด้วย `bear -- make build` ซึ่งจะสร้าง `compile_commands.json` ซึ่ง clangd จะใช้ในการหา include path ที่ระบุใน makefile  
`make clangd` จะทำทั้งหมดนี้ในขั้นตอนเดียว  
`build_all_clangd.sh` ใน `build scripts` จะทำแบบเดียวกันสำหรับตัวอย่างทั้งหมด

## อ้างอิงด่วน
 * **จำเป็น** สำหรับการโปรแกรม/ดีบัก: `SWIO` อยู่ที่ `PD1` ห้ามใช้ PD1 ซ้ำกับฟังก์ชันอื่น
 * **ทางเลือก** `NRST` อยู่ที่ `PD7` ไม่จำเป็น, ค่าเริ่มต้นเป็น GPIO ในบางคอนฟิก
 * **ทางเลือก** UART `TX` อยู่ที่: `PD5` แนะนำให้ใช้ SWIO สำหรับ printf debugging

![ch32v003a4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003a4m6.svg)
![ch32v003f4p6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4p6.svg)
![ch32v003f4u6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4u6.svg)
![ch32v003j4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003j4m6.svg)

## ตัวอย่าง/โปรเจ็กต์เพิ่มเติม?

เครื่องมือจาก third party อื่นๆ มีการเพิ่มตัวอย่างมากมาย ฯลฯ ดู repo เหล่านี้สำหรับไลบรารีเสริม ฯลฯ
 * [ch32v003fun_wildwest](https://github.com/recallmenot/ch32v003fun_wildwest)
 * [ch32v003fun_libs](https://github.com/hexeguitar/ch32v003fun_libs)
 * [CH32V003_lib_uart](https://github.com/ADBeta/CH32V003_lib_uart)
 * [CH32Vxxx_lib_i2c](https://github.com/ADBeta/CH32Vxxx_lib_i2c)
 * [CH32Vxxx_lib_swi2c](https://github.com/ADBeta/CH32Vxxx_lib_swi2c)
 * [ch32v003fun_shenanigans](https://github.com/DeadBugEngineering/ch32v003fun_shenanigans)
 * [ch32fun-bmp280-driver](https://github.com/pabloestrado/ch32fun-bmp280-driver)
 * [ch32fun-aht20-driver](https://github.com/pabloestrado/ch32fun-aht20-driver)

## การสนับสนุน

คุณสามารถเปิด ticket ใน github หรือเข้าร่วม Discord ของผมในช่อง #ch32fun ตอนนี้ invite เป็นแบบส่วนตัว ให้ ping ผม @cnlohr เพื่อขอลิงก์ invite ได้ PM ของผมเปิดตลอด

### เชิงอรรถ/ลิงก์

 * https://raw.githubusercontent.com/openwch/ch32v003/main/RISC-V%20QingKeV2%20Microprocessor%20Debug%20Manual.pdf คู่มือการดีบัก
 * http://www.wch-ic.com/downloads/QingKeV2_Processor_Manual_PDF.html คู่มือโปรเซสเซอร์
 * http://www.wch-ic.com/downloads/CH32V003RM_PDF.html Technical Reference Manual
 * http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html Datasheet
 * https://github.com/CaiB/CH32V003-Architecture-Exploration/blob/main/InstructionTypes.md รายละเอียด compressed ISA บนชิปนี้
 * CH32V003 มี xv extensions คุณสามารถใช้ rvcodec.js เวอร์ชันปรับแต่งนี้เพื่อดู opcode ได้ที่: https://xw.macyler.moe/

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---