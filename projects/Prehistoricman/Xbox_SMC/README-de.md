
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ja">Japanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ko">Koreanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fa">Persisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=vi">Vietnamesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Xbox_SMC
PIC16/Xyclops-Dumps von der originalen Xbox und IDA-Datenbanken mit etwas Reverse Engineering.

![Bild des PIC16LC63A aus einer originalen Xbox](https://raw.githubusercontent.com/Prehistoricman/Xbox_SMC/master/pic16lc63a.jpg)

# Xyclops-Flashen (XycloMod)
Siehe [das Xyclops-Verzeichnis und README](/Xyclops)

# Dumps
Die .bin-Datei für jeden PIC-Dump hat die Bytes vertauscht, damit sie korrekt in IDA geladen werden können. Das erste Wort des PIC-Speichers ist also byte_0 + byte_1 << 8.

Die .idb IDA-Datenbanken enthalten Informationen über Variablen und einige Beobachtungen im Datenbank-Notizblock.

Siehe diese Wiki-Seite für eine Übersicht der SMC-Versionen: https://xboxdevwiki.net/Xboxen_Info

## B2A
Aus einer DVT3 Xbox ausgelesen. Gleiches Konfigurationswort wie P01. Es hat außerdem die Geräte-ID im Konfigurationsbereich als 0000 0000 000B 002A eingebrannt, anders als die Produktions-PICs.

Die Boot-Challenge fehlt vollständig.

## D01
Aus einer XDK BETA 2 Xbox ausgelesen. Identisch zu P01, außer dass die Boot-Challenge fehlt. Die Funktion zur Berechnung der erwarteten Boot-Challenge-Antwort ist noch vorhanden, wird aber nie aufgerufen.

## DXF
Aus einem XDK D2 Debug-Kit ausgelesen. Sehr ähnlich zu D01, aber mit etwas anderer Tray-Logik, Überhitzungslogik und Boot-Logik. Boot-Challenge fehlt genauso wie bei D01.

## D2E
Aus einem Tuscany (v1.6) Dev-Kit ausgelesen. Xyclops-Chip ist mit X01202-001 markiert und es fehlt die A-A02 oder A-B01 Linie, die die Retail-Geräte haben.

Der Debug-Seriencode bei FC00 entspricht dem Retail-P2L-Dump. Von 0x4000 bis 0xFBFF gibt es ein seltsames Datenmuster.

## P01
Aus einer v1.0 Xbox ausgelesen. Das Konfigurationswort ist 0x86:
- CP1:CP0 = 0 (Code-Schutz für den gesamten Speicher aktiviert)
- BODEN = 0 (Brown-out-Reset deaktiviert)
- ~PWRTE = 0 (Power-up-Timer aktiviert)
- WDTE = 1 (Watchdog-Timer aktiviert)
- FOSC1:FOSC0 = 2 (HS-Oszillator)

Ein Konfigurationswert von 0x3FB6 ist für SMC-Klone geeignet, damit sie keinen Code-Schutz aktiviert haben.

## P11
Aus einer v1.3 Xbox ausgelesen. Gleiches Konfigurationswort wie P01.

Es gibt einige kleine Änderungen in P11 gegenüber P01, darunter ein zusätzlicher SMBus-Befehl (Schreiben von 0x22), andere LED-Prioritäten und entspanntere Timings für den Bootvorgang.

Ich habe verschlüsselte Dumps von v1.3 mit v1.4 verglichen und sie stimmten überein. Das bedeutet, dass sie sehr wahrscheinlich dasselbe Programm haben.

## P2L
Aus einer v1.6 Xbox ausgelesen. Xyclops Revision A-A02. Enthält Intel 8051-Code, aber viele spezielle Funktionsregister mit unbekannter Funktion.

Die Debug-Serielle Schnittstelle wird durch den Code bei FC00 betrieben. Sieht aus wie ein rudimentärer Debugger, der die Ausführung anhalten, Daten ausgeben und in Register/RAM schreiben kann.

# Xyclops-Auslesen

Der Xyclops-Chip hat 3 Pins für „Debug“: TXD (Pin 64), RXD (Pin 63) und DEBUG (Pin 29). Setze den DEBUG-Pin auf High, um die serielle Schnittstelle auf den TX- und RX-Pins zu aktivieren. Die serielle Schnittstelle arbeitet mit 9600 Baud.

Das Protokoll basiert auf 4-Byte-Befehlen, die typischerweise im Format `<cmd>` `<Adresse MSByte>` `<Adresse LSByte>` `<egal>` sind.

Befehl 0x14 liest jeweils 64 Byte BIOS-Daten aus und Befehl 0x15 jeweils 64 Byte SMC-Programmdaten. Ein Dump von Xyclops, P2L.bin, ist im Repository enthalten. [xyclops_dumper.py](/Xyclops/xyclops_dumper.py) ist ebenfalls enthalten, damit du deine eigene Maschine auslesen kannst.

# PIC-Auslesemethodik
Vollständiger Bericht unter https://wiki.recessim.com/view/PIC_Burnout

Der PIC hat seinen Codeschutz aktiviert, sodass alle Daten als 0000 gelesen werden. Ich habe einen Trick verwendet, um stattdessen verschlüsselte Daten zu erhalten, den Verschlüsselungsalgorithmus mit einem Opferschip entdeckt und dann eine Art Exploit genutzt, um die ROM-Daten zu ändern und einige Bits auf bekannte Werte zu setzen. Anschließend kann ich die benötigten Informationen aus den mehreren verschlüsselten Dumps extrahieren, um die Originaldaten wiederherzustellen.

# PICProgrammer
PICProgrammer ist eines von mehreren Arduino-Projekten für den RP2040, das ich in meiner Forschung verwendet habe. Es bietet eine einfache Kommandozeilenschnittstelle, um ICSP-Operationen (In-Circuit Serial Programming) auf dem PIC auszuführen. Dies wird gegenüber der Verwendung eines speziellen Programmiergeräts wie dem PICkit bevorzugt, da es flexibler ist und Optionen bietet, die der Hersteller nicht vorgesehen hat.

Du solltest ein gutes Verständnis von Elektronik und Programmierung haben, bevor du dies benutzt, und die Befehle genau prüfen, bevor du sie ausführst.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---