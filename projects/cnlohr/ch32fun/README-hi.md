# ch32fun

[CH32V003](http://www.wch-ic.com/products/CH32V003.html) (और CH32V परिवार के कई अन्य चिप्स) के लिए एक ओपन सोर्स डेवलपमेंट एनवायरनमेंट (टूलिंग, हेडर, उदाहरण) है, जो gcc-riscv64 के साथ काम करता है और Windows (नेटिव), Linux और/या WSL में उपयोग किया जा सकता है। CH32V003 एक 10-सेंट का पार्ट है जिसमें RISC-V EC कोर है, जो 48MHz पर चलता है, इसमें 16kB फ्लैश और 2kB RAM है और कई पेरिफेरल्स हैं। यह SOP-8, QFN-20 और SOIC पैकेजों में भी उपलब्ध है। आप इसका डेटाशीट [यहां](http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html) से प्राप्त कर सकते हैं।

इस प्रोजेक्ट का उद्देश्य CH32V003 के कुशल उपयोग के लिए टूलिंग और एनवायरनमेंट विकसित करना है। जटिल HALs से बचें, और हार्डवेयर की पूरी क्षमता का उपयोग करें! मौजूदा EVT बहुत बड़ा और डेवलपमेंट एनवायरनमेंट भारी है। यह प्रोजेक्ट विशेष रूप से HAL से बचता है और इसे ऐसे बनाता है कि आप केवल [TRM](http://www.wch-ic.com/downloads/CH32V003RM_PDF.html) का उपयोग कर सकें। तुलना करें, तो blinky केवल 500 बाइट्स में बनता है ch32fun के साथ, तेजी से बूट होता है, और कुल मिलाकर काफी सरल है।

ch32fun में शामिल है:
1. ch32fun का उपयोग करने वाले उदाहरण, लेकिन HAL के मुकाबले कम। अधिकतर ch32v003 के आसपास केंद्रित हैं, लेकिन इनमें से कई अन्य प्रोसेसर के साथ भी अनुकूल हैं।
2. "minichlink" जो WCH CH-Link को libusb के साथ क्रॉस-प्लेटफ़ॉर्म उपयोग के लिए काम में लेता है।
   * एक STM32F042 प्रोग्रामर, [NHC-Link042](https://github.com/NgoHungCuong/NHC-Link042)
   * एक ESP32S2 प्रोग्रामर, [esp32s2-funprog](https://github.com/cnlohr/esp32s2-cookbook/tree/master/ch32v003programmer)
   * आधिकारिक WCH Link-E प्रोग्रामर।
   * Arduino-आधारित इंटरफ़ेस, [Ardulink](https://gitlab.com/BlueSyncLine/arduino-ch32v003-swio)।
   * Visual Studio के लिए gdbserver-शैली-debugging का समर्थन।
   * printf-over-single-wire का समर्थन। (लगभग 400kBaud पर)
3. libgcc की एक अतिरिक्त कॉपी ताकि आप असामान्य risc-v build chains का उपयोग कर सकें, जो `misc/libgcc.a` में स्थित है।
4. एक "ch32fun" नामक फोल्डर जिसमें ch32v003 के लिए ऐप्स कम्पाइल करने हेतु एक सिंगल सेल्फ-कंटेन्डेड सोर्स फाइल और हेडर फाइल है।
5. कुछ सिस्टम्स पर "printf" बैक करने की क्षमता
6. एक डेमो बूटलोडर।

## अन्य परिवार का समर्थन

वर्तमान में, ch32v103, ch32v203, ch32v208, ch32v303, ch32v305 और ch32v307 के लिए एक्सपेरिमेंटल समर्थन है। GDB मुख्य रूप से 003 पर परीक्षण किया गया है, लेकिन सीमित रूप में अन्य प्रोसेसर पर भी काम करता है।

## शुरुआत कैसे करें

इंस्टॉलेशन / सेटअप के निर्देशों के लिए, [wiki पेज यहां देखें](https://github.com/cnlohr/ch32fun/wiki/Installation)

## विशेषताएँ!

### प्रोग्रामिंग इंटरफ़ेस पर तेज़ "printf" डिबग

और तेज़ से मेरा मतलब बहुत तेज़ है। आमतौर पर लगभग 36kBytes/सेकंड।

```
./minichlink -T | pv > /dev/null
Found ESP32S2 Programmer
 536KiB 0:00:15 [36.7KiB/s] [        <=>                     ]
```

आप डिबगप्रिंटफ प्रोजेक्ट आजमा सकते हैं, या SetupDebugPrintf(); कॉल करें और printf() का उपयोग करें।

### डिबगिंग समर्थन!

minichlink में निर्मित gdbserver के माध्यम से! यह `gdb-multiarch` के साथ-साथ Visual Studio Code में भी काम करता है।

## बिल्डिंग और फ्लैशिंग

```
cd examples/blink
make
```

text = कोड, data = कॉन्स्टेंट्स और इनिशियलाइजेशन वैल्यू, bss = बिना इनिशियलाइज वैल्यू।  
dec इन तीनों का योग है और यह दर्शाता है कि प्रोग्राम फ्लैश में कितने बाइट्स घेरेगा।

जनरेट हुआ .bin minichlink द्वारा उपयोग किया जाता है और .hex फाइल आधिकारिक WCH फ्लैश टूल के साथ संगत है।

## VSCode +/- PlatformIO

नोट: PlatformIO आमतौर पर इस repo पर CI के लिए उपयोग होता है। जबकि PlatformIO का उपयोग VSCode के अंदर ch32fun प्रोजेक्ट को कोड और डिबग करने के लिए किया जा सकता है, आप इसे PlatformIO के बिना भी पूरी तरह कर सकते हैं: इसके लिए [template project](https://github.com/cnlohr/ch32fun/tree/master/examples/template/.vscode) देखें।

यह प्रोजेक्ट VSCode और PlatformIO एक्सटेंशन के साथ बिल्ड, अपलोड और डिबग किया जा सकता है। बस इस प्रोजेक्ट को VSCode में क्लोन और ओपन करें और PlatformIO एक्सटेंशन इंस्टॉल हो। [project environment switcher](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) का उपयोग करके कोई खास उदाहरण चुनें, जैसे "blink"।

ch32fun पर आधारित नया PlatformIO फर्मवेयर प्रोजेक्ट बनाने के लिए, बस [PlatformIO Home](https://docs.platformio.org/en/latest/home/index.html) के "New Project" विजार्ड का उपयोग करें और "Framework" को "ch32v003fun" पर सेट करें। [विभिन्न उदाहरण](https://github.com/Community-PIO-CH32V/platform-ch32v/tree/develop/examples/blinky-ch32v003fun) उपलब्ध हैं।

![pio_proj](.github/pio_project_creation.png)

समान [PlatformIO Core CLI](https://docs.platformio.org/en/latest/integration/ide/vscode.html#platformio-core-cli) कमांड है
```sh
pio init -b genericCH32V003F4P6 -O "framework = ch32v003fun"
```

यदि आप अपना कोड सीधे ch32fun प्रोजेक्ट में जोड़ना चाहते हैं, तो कृपया `platformio.ini` में उपलब्ध environments को [निर्देशानुसार](https://github.com/cnlohr/ch32fun/blob/49640fbccf231191aa83c6a2bbe9d385535b2d1e/platformio.ini#L48-L53) विस्तारित करें।

कृपया ध्यान दें कि जब आप इस प्रोजेक्ट को PlatformIO के अंदर खोलते हैं, तो आप [project environment switcher](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) का उपयोग करके VSCode टास्कबार के नीचे से कोई विशेष उदाहरण फोल्डर चुन सकते हैं। अन्यथा, "Build" डिफ़ॉल्ट रूप से **सभी** उदाहरणों को बिल्ड करेगा।

अधिक जानकारी और प्लेटफ़ॉर्म की इंस्टॉलेशन के लिए देखें [platform-ch32v](https://github.com/Community-PIO-CH32V/platform-ch32v)।

## clangd

यदि C/C++ लैंग्वेज सर्वर clangd को `ch32fun.h` नहीं मिल पा रहा है, तो उदाहरण को `make clean` से साफ़ करना और एक बार `bear -- make build` के साथ बनाना होगा, जिससे `compile_commands.json` जेनरेट होगा, जिसे clangd मेकफाइल्स में निर्दिष्ट इनक्लूड पाथ्स खोजने के लिए उपयोग करता है।  
`make clangd` यह एक स्टेप में करता है।  
`build_all_clangd.sh` (build scripts में) सभी उदाहरणों के लिए यह करता है।

## त्वरित संदर्भ
 * प्रोग्रामिंग/डिबगिंग के लिए **आवश्यक**: `SWIO` `PD1` पर है। PD1 को कई कार्यों के लिए दोबारा उपयोग न करें।
 * **वैकल्पिक**: `NRST` `PD7` पर है। आवश्यक नहीं, कुछ कॉन्फ़िगरेशन में डिफ़ॉल्ट रूप से GPIO के रूप में।
 * **वैकल्पिक** UART `TX`: `PD5` पर है। हम printf डिबगिंग के लिए SWIO का उपयोग करने की सलाह देते हैं।

![ch32v003a4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003a4m6.svg)
![ch32v003f4p6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4p6.svg)
![ch32v003f4u6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4u6.svg)
![ch32v003j4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003j4m6.svg)

## और उदाहरण / प्रोजेक्ट्स?

अन्य थर्ड पार्टी टूल्स कई उदाहरण आदि जोड़ रहे हैं। अतिरिक्त लाइब्रेरी आदि के लिए निम्नलिखित रिपोज देखें।
 * [ch32v003fun_wildwest](https://github.com/recallmenot/ch32v003fun_wildwest)
 * [ch32v003fun_libs](https://github.com/hexeguitar/ch32v003fun_libs)
 * [CH32V003_lib_uart](https://github.com/ADBeta/CH32V003_lib_uart)
 * [CH32Vxxx_lib_i2c](https://github.com/ADBeta/CH32Vxxx_lib_i2c)
 * [CH32Vxxx_lib_swi2c](https://github.com/ADBeta/CH32Vxxx_lib_swi2c)
 * [ch32v003fun_shenanigans](https://github.com/DeadBugEngineering/ch32v003fun_shenanigans)
 * [ch32fun-bmp280-driver](https://github.com/pabloestrado/ch32fun-bmp280-driver)
 * [ch32fun-aht20-driver](https://github.com/pabloestrado/ch32fun-aht20-driver)

## समर्थन

आप एक github टिकट खोल सकते हैं या मेरे Discord पर #ch32fun चैनल में शामिल हो सकते हैं। अभी इनवाइट्स प्राइवेट हैं, तो बस मुझे @cnlohr पर पिंग करें इनवाइट लिंक के लिए। मेरे PM खुले हैं।

### फुटनोट्स/लिंक्स

 * https://raw.githubusercontent.com/openwch/ch32v003/main/RISC-V%20QingKeV2%20Microprocessor%20Debug%20Manual.pdf डिबगिंग मैनुअल
 * http://www.wch-ic.com/downloads/QingKeV2_Processor_Manual_PDF.html प्रोसेसर मैनुअल
 * http://www.wch-ic.com/downloads/CH32V003RM_PDF.html तकनीकी संदर्भ मैनुअल
 * http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html डेटाशीट
 * https://github.com/CaiB/CH32V003-Architecture-Exploration/blob/main/InstructionTypes.md इस चिप पर संपीड़ित ISA का विवरण।
 * CH32V003 में xv एक्सटेंशन हैं, आप इसके ऑपकोड्स के लिए rvcodec.js का यह कस्टम वर्शन इस्तेमाल कर सकते हैं: https://xw.macyler.moe/

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---