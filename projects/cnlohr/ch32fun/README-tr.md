# ch32fun

[GCC-riscv64](http://www.wch-ic.com/products/CH32V003.html) ile [CH32V003](http://www.wch-ic.com/products/CH32V003.html) (ve CH32V ailesindeki birçok diğer çip) için açık kaynaklı bir geliştirme ortamı (araçlar, başlık dosyaları, örnekler); Windows (Yerel), Linux ve/veya WSL'de kullanılabilir. CH32V003, 48MHz hızında çalışan RISC-V EC çekirdeğine sahip, 16kB flaş ve 2kB RAM ile donatılmış, birçok çevre birimi olan 10 sentlik bir parçadır. Ayrıca SOP-8, QFN-20 ve SOIC paketlerinde de mevcuttur. Veri sayfasına [buradan](http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html) ulaşabilirsiniz.

Bu projenin amacı, CH32V003 için verimli bir şekilde kullanılacak araçları ve ortamı geliştirmektir. Karmaşık HAL’lerden kaçının ve donanımın gücünü ortaya çıkarın! Mevcut EVT çok büyük ve geliştirme ortamı ağır. Bu proje özellikle HAL kullanımından kaçınır ve sadece [TRM](http://www.wch-ic.com/downloads/CH32V003RM_PDF.html) ile çalışmanızı sağlar. Karşılaştırma için, ch32fun ile blinky sadece 500 bayt, daha hızlı başlar ve genel olarak çok daha basittir.

ch32fun şunları içerir:
1. ch32fun kullanan örnekler, ancak HAL kullanan kadar çok yoktur. Çoğu ch32v003 üzerine yoğunlaşmıştır, ancak birçoğu diğer işlemcilerle de uyumludur.
2. "minichlink" - WCH CH-Link'i libusb ile kullanan, çapraz platform desteği sunan araç.
   * STM32F042 programlayıcı: [NHC-Link042](https://github.com/NgoHungCuong/NHC-Link042)
   * ESP32S2 programlayıcı: [esp32s2-funprog](https://github.com/cnlohr/esp32s2-cookbook/tree/master/ch32v003programmer)
   * Resmi WCH Link-E programlayıcı.
   * Arduino tabanlı arayüz: [Ardulink](https://gitlab.com/BlueSyncLine/arduino-ch32v003-swio).
   * Visual Studio ile kullanılmak üzere gdbserver tarzı hata ayıklama desteği.
   * Tek tel üzerinden printf desteği. (Yaklaşık 400kBaud hızında)
3. `misc/libgcc.a` içinde, alışılmadık risc-v derleyici zincirleri kullanabilmeniz için ekstra bir libgcc kopyası.
4. "ch32fun" adlı bir klasörde, ch32v003 için uygulama derlemek amacıyla tek başına bir kaynak dosyası ve başlık dosyası içerir.
5. Bazı sistemlerde, geri "printf" yapabilme.
6. Bir demo bootloader.

## Diğer aile desteği

Şu anda ch32v103, ch32v203, ch32v208, ch32v303, ch32v305 ve ch32v307 için deneysel destek vardır. GDB çoğunlukla 003 üzerinde test edilmiştir, fakat sınırlı da olsa diğer işlemcilerde de çalışır.

## Başlangıç

Kurulum / yapılandırma talimatları için [wiki sayfasına buradan](https://github.com/cnlohr/ch32fun/wiki/Installation) ulaşabilirsiniz.

## Özellikler!

### Programlama arayüzü üzerinden hızlı "printf" hata ayıklama.

Ve hızlı derken gerçekten hızlı! Genellikle yaklaşık 36kByte/sn hızında.

```
./minichlink -T | pv > /dev/null
Found ESP32S2 Programmer
 536KiB 0:00:15 [36.7KiB/s] [        <=>                     ]
```

Sadece debugprintf projesini deneyebilir ya da SetupDebugPrintf(); fonksiyonunu çağırıp printf() ile veri gönderebilirsiniz.

### Hata ayıklama desteği!

minichlink'e gömülü gdbserver üzerinden! `gdb-multiarch` ile ve Visual Studio Code ile çalışır.

## Derleme ve Yükleme

```
cd examples/blink
make
```

text = kod, data = sabitler ve başlatma değerleri, bss = başlatılmamış değerler.  
dec, bu üçünün toplamıdır ve programın flaşta kaplayacağı bayt sayısını gösterir.

Oluşturulan .bin dosyası minichlink tarafından, .hex dosyası ise resmi WCH flaş aracıyla uyumlu olarak kullanılır.

## VSCode +/- PlatformIO

Not: PlatformIO bu depoda genellikle CI için kullanılır. PlatformIO, VSCode içinde bir ch32fun projesini kodlamak ve hata ayıklamak için kullanılabilir, fakat tamamen PlatformIO olmadan da yapabilirsiniz: Bunun için [şablon projeye](https://github.com/cnlohr/ch32fun/tree/master/examples/template/.vscode) bakınız.

Bu proje, VSCode ve PlatformIO uzantısı ile derlenebilir, yüklenebilir ve hata ayıklanabilir. Sadece projeyi klonlayıp VSCode'da açın ve PlatformIO uzantısının kurulu olduğundan emin olun. [Proje ortamı değiştiricisini](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) kullanarak "blink" gibi belirli bir örneği seçebilirsiniz.

ch32fun tabanlı yeni bir PlatformIO firmware projesi oluşturmak için, [PlatformIO Home](https://docs.platformio.org/en/latest/home/index.html)'un "Yeni Proje" sihirbazını kullanın ve "Framework" olarak "ch32v003fun" seçin. [Çeşitli örnekler](https://github.com/Community-PIO-CH32V/platform-ch32v/tree/develop/examples/blinky-ch32v003fun) mevcuttur.

![pio_proj](https://raw.githubusercontent.com/cnlohr/ch32fun/master/.github/pio_project_creation.png)

Eşdeğer [PlatformIO Core CLI](https://docs.platformio.org/en/latest/integration/ide/vscode.html#platformio-core-cli) komutu şöyle olurdu:
```sh
pio init -b genericCH32V003F4P6 -O "framework = ch32v003fun"
```

Kodunuzu doğrudan ch32fun projesine eklemek istiyorsanız, lütfen `platformio.ini` dosyasındaki mevcut ortamları [talimatlara göre](https://raw.githubusercontent.com/cnlohr/ch32fun/master/platformio.ini) genişletin.

Ayrıca, bu projeyi PlatformIO içinde açtığınızda, VSCode görev çubuğunun altındaki [proje ortamı değiştiricisini](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) kullanarak belirli bir örnek klasörünü seçebilirsiniz. Aksi takdirde, "Build" varsayılan olarak **tüm** örnekleri derleyecektir.

Daha fazla ayrıntı ve platform kurulumu için [platform-ch32v](https://github.com/Community-PIO-CH32V/platform-ch32v) sayfasına bakınız.

## clangd

C/C++ dil sunucusu clangd `ch32fun.h` dosyasını bulamazsa, örnek `make clean` ile temizlenmeli ve bir kez `bear -- make build` ile derlenmelidir, böylece makefile’larda belirtilen include yollarını clangd’in bulabilmesi için bir `compile_commands.json` dosyası oluşturulur.  
`make clangd` bunu tek adımda yapar.  
`build_all_clangd.sh` ise `build scripts` klasöründe tüm örnekler için bunu yapar.

## Hızlı Referans
 * **GEREKLİ** programlama/hata ayıklama için: `SWIO` pini `PD1` üzerindedir. PD1’i birden fazla fonksiyon için kullanmayınız.
 * **OPSİYONEL** `NRST` pini `PD7` üzerindedir. Gerekli değildir, bazı konfigürasyonlarda varsayılan olarak GPIO’dur.
 * **OPSİYONEL** UART `TX` pini: `PD5`. `printf` hata ayıklama için SWIO kullanmanız önerilir.

![ch32v003a4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003a4m6.svg)
![ch32v003f4p6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4p6.svg)
![ch32v003f4u6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4u6.svg)
![ch32v003j4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003j4m6.svg)

## Daha fazla örnek/proje?

Diğer üçüncü parti araçlar çok sayıda örnek eklemekte ve ekstra kütüphaneler sunmaktadır. Ek kütüphaneler için aşağıdaki depolara bakınız:
 * [ch32v003fun_wildwest](https://github.com/recallmenot/ch32v003fun_wildwest)
 * [ch32v003fun_libs](https://github.com/hexeguitar/ch32v003fun_libs)
 * [CH32V003_lib_uart](https://github.com/ADBeta/CH32V003_lib_uart)
 * [CH32Vxxx_lib_i2c](https://github.com/ADBeta/CH32Vxxx_lib_i2c)
 * [CH32Vxxx_lib_swi2c](https://github.com/ADBeta/CH32Vxxx_lib_swi2c)
 * [ch32v003fun_shenanigans](https://github.com/DeadBugEngineering/ch32v003fun_shenanigans)
 * [ch32fun-bmp280-driver](https://github.com/pabloestrado/ch32fun-bmp280-driver)
 * [ch32fun-aht20-driver](https://github.com/pabloestrado/ch32fun-aht20-driver)

## Destek

Github’da bir ticket açabilir veya Discord’daki #ch32fun kanalına katılabilirsiniz. Şu anda davetler özeldir, bu yüzden bana @cnlohr olarak ulaşarak davet linki isteyebilirsiniz. Özel mesajlarım açıktır.

### Dipnotlar/bağlantılar

 * https://raw.githubusercontent.com/openwch/ch32v003/main/RISC-V%20QingKeV2%20Microprocessor%20Debug%20Manual.pdf Hata Ayıklama Kılavuzu
 * http://www.wch-ic.com/downloads/QingKeV2_Processor_Manual_PDF.html İşlemci Kılavuzu
 * http://www.wch-ic.com/downloads/CH32V003RM_PDF.html Teknik Referans Kılavuzu
 * http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html Veri Sayfası
 * https://github.com/CaiB/CH32V003-Architecture-Exploration/blob/main/InstructionTypes.md Bu çipteki sıkıştırılmış ISA ayrıntıları.
 * CH32V003 xv uzantılarına sahiptir, opcode’larıyla çalışmak için bu özelleştirilmiş rvcodec.js sürümünü kullanabilirsiniz: https://xw.macyler.moe/

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---