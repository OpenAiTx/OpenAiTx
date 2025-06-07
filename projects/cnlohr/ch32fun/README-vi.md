# ch32fun

Một môi trường phát triển mã nguồn mở (công cụ, header, ví dụ) cho [CH32V003](http://www.wch-ic.com/products/CH32V003.html) (và nhiều vi điều khiển khác thuộc họ CH32V) sử dụng gcc-riscv64, có thể dùng trên Windows (Native), Linux và/hoặc WSL. CH32V003 là một vi điều khiển giá 10 cent, lõi RISC-V EC chạy ở 48MHz, có 16kB flash, 2kB RAM và nhiều ngoại vi. Nó có các dạng đóng gói SOP-8, QFN-20 và SOIC. Bạn có thể tải datasheet [tại đây](http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html).

Mục tiêu của dự án này là phát triển công cụ và môi trường để sử dụng hiệu quả CH32V003. Tránh các HAL phức tạp và khai thác tối đa phần cứng! EVT hiện tại rất lớn và môi trường phát triển nặng nề. Dự án này đặc biệt tránh dùng HAL và giúp bạn có thể sử dụng trực tiếp [TRM](http://www.wch-ic.com/downloads/CH32V003RM_PDF.html). Ngược lại, blinky chỉ chiếm 500 byte với ch32fun, khởi động nhanh hơn và đơn giản hơn rất nhiều.

ch32fun bao gồm:
1. Các ví dụ sử dụng ch32fun, nhưng không nhiều như dùng HAL. Chủ yếu tập trung vào ch32v003, nhưng nhiều ví dụ tương thích với các vi điều khiển khác.
2. "minichlink" sử dụng WCH CH-Link với libusb, hỗ trợ đa nền tảng.
  * Một lập trình viên STM32F042, [NHC-Link042](https://github.com/NgoHungCuong/NHC-Link042)
  * Một lập trình viên ESP32S2, [esp32s2-funprog](https://github.com/cnlohr/esp32s2-cookbook/tree/master/ch32v003programmer)
  * Lập trình viên chính thức WCH Link-E.
  * Giao diện dựa trên Arduino, [Ardulink](https://gitlab.com/BlueSyncLine/arduino-ch32v003-swio).
  * Hỗ trợ gdbserver-style-debugging để sử dụng với Visual Studio.
  * Hỗ trợ printf-trên-single-wire. (Khoảng 400kBaud)
3. Một bản sao phụ của libgcc để bạn có thể sử dụng các chuỗi build risc-v khác thường, nằm trong `misc/libgcc.a`.
4. Thư mục "ch32fun" chứa một file mã nguồn và header tự chứa để biên dịch ứng dụng cho ch32v003.
5. Trên một số hệ thống, khả năng "printf" trả về
6. Một bootloader demo.

## Hỗ trợ các họ vi điều khiển khác

Hiện tại, có hỗ trợ thử nghiệm cho ch32v103, ch32v203, ch32v208, ch32v303, ch32v305 và ch32v307. GDB chủ yếu đã được kiểm thử trên 003, nhưng cũng hoạt động ở mức độ hạn chế trên các vi điều khiển khác.

## Bắt đầu

Để xem hướng dẫn cài đặt / thiết lập, xem [wiki tại đây](https://github.com/cnlohr/ch32fun/wiki/Installation)

## Tính năng!

### "printf" debug tốc độ cao qua cổng lập trình

Và tốc độ ở đây là rất cao. Thường khoảng 36kBytes/giây.

```
./minichlink -T | pv > /dev/null
Found ESP32S2 Programmer
 536KiB 0:00:15 [36.7KiB/s] [        <=>                     ]
```

Bạn có thể thử ngay project debugprintf, hoặc gọi SetupDebugPrintf(); và thoải mái dùng printf().

### Hỗ trợ debug!

Thông qua gdbserver tích hợp trong minichlink! Hoạt động với `gdb-multiarch` cũng như trên Visual Studio Code.

## Build và Nạp chương trình

```
cd examples/blink
make
```

text = mã code, data = hằng số và giá trị khởi tạo, bss = giá trị chưa khởi tạo.  
dec là tổng của 3 giá trị và thể hiện số byte flash mà chương trình chiếm dụng.

File .bin được tạo ra dùng cho minichlink và file .hex tương thích với công cụ nạp chính thức của WCH.

## VSCode +/- PlatformIO

Lưu ý: PlatformIO chủ yếu được dùng cho CI trên repo này. Dù PlatformIO có thể dùng để code và debug project ch32fun trong VSCode, bạn cũng có thể thực hiện hoàn toàn mà không cần PlatformIO: Xem [dự án mẫu](https://github.com/cnlohr/ch32fun/tree/master/examples/template/.vscode).

Dự án này có thể được build, upload và debug bằng VSCode với extension PlatformIO. Chỉ cần clone và mở dự án này trên VSCode và cài extension PlatformIO. Sử dụng [project environment switcher](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) để chọn ví dụ cụ thể, như "blink".

Để tạo một firmware PlatformIO mới dựa trên ch32fun, chỉ cần sử dụng wizard "New Project" trong [PlatformIO Home](https://docs.platformio.org/en/latest/home/index.html) và đặt "Framework" thành "ch32v003fun". Có [nhiều ví dụ](https://github.com/Community-PIO-CH32V/platform-ch32v/tree/develop/examples/blinky-ch32v003fun).

![pio_proj](.github/pio_project_creation.png)

Lệnh tương đương của [PlatformIO Core CLI](https://docs.platformio.org/en/latest/integration/ide/vscode.html#platformio-core-cli) là
```sh
pio init -b genericCH32V003F4P6 -O "framework = ch32v003fun"
```

Nếu bạn muốn thêm code trực tiếp vào project ch32fun, vui lòng mở rộng các environment có sẵn trong file `platformio.ini` theo [hướng dẫn](https://github.com/cnlohr/ch32fun/blob/49640fbccf231191aa83c6a2bbe9d385535b2d1e/platformio.ini#L48-L53).

Xin lưu ý khi mở project này trong PlatformIO, bạn có thể dùng [project environment switcher](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) ở thanh taskbar dưới cùng của VSCode để chọn thư mục ví dụ cụ thể. Nếu không, "Build" mặc định sẽ build **tất cả** ví dụ.

Xem [platform-ch32v](https://github.com/Community-PIO-CH32V/platform-ch32v) để biết thêm chi tiết và cách cài đặt platform.

## clangd

Nếu máy chủ ngôn ngữ C/C++ là clangd không tìm được `ch32fun.h`, bạn cần làm sạch ví dụ với `make clean` và build lại một lần với `bear -- make build`, thao tác này sẽ sinh ra file `compile_commands.json` mà clangd sử dụng để tìm đường dẫn include trong makefile.  
`make clangd` sẽ làm điều này chỉ với một bước.
`build_all_clangd.sh` trong `build scripts` sẽ thực hiện cho tất cả các ví dụ.

## Tham khảo nhanh
 * **BẮT BUỘC** để lập trình/debug: `SWIO` ở chân `PD1`. Không dùng lại PD1 cho nhiều chức năng.
 * **TÙY CHỌN** `NRST` ở chân `PD7`. Không bắt buộc, mặc định là GPIO trong một số cấu hình.
 * **TÙY CHỌN** UART `TX` ở chân: `PD5`. Khuyên dùng SWIO để debug `printf`.

![ch32v003a4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003a4m6.svg)
![ch32v003f4p6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4p6.svg)
![ch32v003f4u6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4u6.svg)
![ch32v003j4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003j4m6.svg)

## Thêm ví dụ / dự án?

Các công cụ bên thứ ba khác đang bổ sung rất nhiều ví dụ, v.v. Xem các repo sau để có thêm thư viện, v.v.
 * [ch32v003fun_wildwest](https://github.com/recallmenot/ch32v003fun_wildwest)
 * [ch32v003fun_libs](https://github.com/hexeguitar/ch32v003fun_libs)
 * [CH32V003_lib_uart](https://github.com/ADBeta/CH32V003_lib_uart)
 * [CH32Vxxx_lib_i2c](https://github.com/ADBeta/CH32Vxxx_lib_i2c)
 * [CH32Vxxx_lib_swi2c](https://github.com/ADBeta/CH32Vxxx_lib_swi2c)
 * [ch32v003fun_shenanigans](https://github.com/DeadBugEngineering/ch32v003fun_shenanigans)
 * [ch32fun-bmp280-driver](https://github.com/pabloestrado/ch32fun-bmp280-driver)
 * [ch32fun-aht20-driver](https://github.com/pabloestrado/ch32fun-aht20-driver)

## Hỗ trợ

Bạn có thể mở một ticket trên github hoặc tham gia Discord của tôi ở kênh #ch32fun. Hiện tại invite là riêng tư, hãy ping tôi @cnlohr để xin link mời. PM của tôi luôn mở.

### Chú thích/liên kết

 * https://raw.githubusercontent.com/openwch/ch32v003/main/RISC-V%20QingKeV2%20Microprocessor%20Debug%20Manual.pdf Sổ tay Debugging
 * http://www.wch-ic.com/downloads/QingKeV2_Processor_Manual_PDF.html Sổ tay bộ xử lý
 * http://www.wch-ic.com/downloads/CH32V003RM_PDF.html Sổ tay tham khảo kỹ thuật
 * http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html Datasheet
 * https://github.com/CaiB/CH32V003-Architecture-Exploration/blob/main/InstructionTypes.md Chi tiết ISA nén trên chip này.
 * CH32V003 có các extension xv, bạn có thể dùng phiên bản rvcodec.js tùy chỉnh này để làm việc với opcode của nó: https://xw.macyler.moe/

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---