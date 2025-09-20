
<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-CN">Simplified Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-TW">Traditional Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ja">Japanese</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ko">Korean</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fr">French</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=de">German</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=es">Spanish</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=it">Italian</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ru">Russian</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pt">Portuguese</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=nl">Dutch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pl">Polish</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ar">Arabic</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fa">Persian</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=tr">Turkish</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=vi">Vietnamese</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=id">Indonesian</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=as">Assamese</
      </div>
    </div>
  </details>
</div>

# Xbox_SMC
PIC16/Xyclops dumps from the original Xbox and IDA databases with some reverse engineering done.

![Image of PIC16LC63A from an original Xbox](https://raw.githubusercontent.com/Prehistoricman/Xbox_SMC/master/pic16lc63a.jpg)

# Xyclops flashing (XycloMod)
See [the Xyclops directory and README](/Xyclops)

# Dumps
The .bin file for each PIC dump has the bytes swapped for correct loading into IDA. So the first word of PIC memory is byte_0 + byte_1 << 8.

The .idb IDA databases contain information about variables and some observations in the database notepad.

See this wiki page for a breakdown of the SMC versions: https://xboxdevwiki.net/Xboxen_Info

## B2A
Dumped from a DVT3 Xbox. Same config word as P01. It also has the device ID burned in the config area as 0000 0000 000B 002A, unlike the production PICs.

It's completely missing the boot challenge.

## D01
Dumped from XDK BETA 2 Xbox. Identical to P01 except for missing boot challenge. The function to compute the expected boot challenge response is still present, but never called.

## DXF
Dumped from an XDK D2 debug kit. Very similar to D01 but with slightly different tray logic, overheat logic and boot logic. Boot challenge is missing in the same way as D01.

## D2E
Dumped from a Tuscany (v1.6) dev kit. Xyclops chip is marked X01202-001, and is missing the A-A02 or A-B01 line that retail units have.

The debug serial code at FC00 matches the retail P2L dump. There is a strange pattern of data from 0x4000 to 0xFBFF.

## P01
Dumped from a v1.0 Xbox. The config word is 0x86:
- CP1:CP0 = 0 (Code Protection enabled for the whole memory)
- BODEN = 0 (Brown-out Reset disabled)
- ~PWRTE = 0 (Power-up Timer enabled)
- WDTE = 1 (Watchdog Timer enabled)
- FOSC1:FOSC0 = 2 (HS oscillator)

A config value of 0x3FB6 is suitable for SMC clones so that they don't have code protection enabled.

## P11
Dumped from a v1.3 Xbox. Same config word as P01.

There are a few small changes in P11 versus P01 including an extra SMBus command (write 0x22), different LED priorities, and more relaxed timings for boot.

I checked scrambled dumps of v1.3 against v1.4 and they matched. This means it's highly likely they have the same program.

## P2L
Dumped from a v1.6 Xbox. Xyclops revision A-A02. It contains Intel 8051 code but has lots of special function registers with unknown functions.

The debug serial is powered by the code at FC00. It appears to be a basic debugger that can pause execution, dump data, and write to registers/RAM.

# Xyclops dumping

The Xyclops chip has 3 pins for 'debug': TXD (pin 64), RXD (pin 63), and DEBUG (pin 29). Set the DEBUG pin high to enable the serial port on the TX and RX pins. The serial operates at 9600 baud.

The protocol is based on 4-byte commands that are typically in the format `<cmd>` `<address MSByte>` `<address LSByte>` `<don't care>`

Command 0x14 dumps 64 bytes of BIOS data at a time and 0x15 dumps 64 bytes of SMC program data at a time. A dump from Xyclops, P2L.bin, is included in the repo. [xyclops_dumper.py](/Xyclops/xyclops_dumper.py) is also included for you to dump your own machine.

# PIC dumping methodology
Full writeup at https://wiki.recessim.com/view/PIC_Burnout

The PIC has its code protection enabled so all the data reads as 0000. I used a trick to get scrambled data output instead, discovered the scrambling algorithm using a sacrificial chip, and then used an exploit to change the ROM data to fix some bits to known values. Then I could extract the required information from multiple scrambled dumps to rebuild the original data.

# PICProgrammer
PICProgrammer is one of a few Arduino projects for the RP2040 that I used in my research. It provides a simple command-line interface to execute ICSP (in-circuit serial programming) operations on the PIC. This is preferred over using a purpose-built programmer such as the PICkit due to its flexibility and the option of doing things that the manufacturer didn't intend.

You should have a good understanding of electronics and programming before using this, and take a good look over what commands do before executing them.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---