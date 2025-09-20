
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Xbox_SMC
Dump PIC16/Xyclops dall'Xbox originale e database IDA con alcune analisi di reverse engineering.

![Immagine del PIC16LC63A da una Xbox originale](https://raw.githubusercontent.com/Prehistoricman/Xbox_SMC/master/pic16lc63a.jpg)

# Flashing di Xyclops (XycloMod)
Vedi [la directory Xyclops e il README](/Xyclops)

# Dump
Il file .bin di ciascun dump PIC ha i byte invertiti per il corretto caricamento in IDA. Quindi la prima parola della memoria PIC è byte_0 + byte_1 << 8.

I database .idb di IDA contengono informazioni sulle variabili e alcune osservazioni nel blocco note del database.

Consulta questa pagina wiki per una panoramica delle versioni SMC: https://xboxdevwiki.net/Xboxen_Info

## B2A
Dumpato da una Xbox DVT3. Stessa parola di configurazione della P01. Ha anche l'ID del dispositivo scritto nell'area di configurazione come 0000 0000 000B 002A, a differenza dei PIC di produzione.

Manca completamente la sfida di avvio.

## D01
Dumpato da una Xbox XDK BETA 2. Identico a P01, eccetto per la mancanza della sfida di avvio. La funzione per calcolare la risposta prevista alla sfida di avvio è ancora presente, ma non viene mai chiamata.

## DXF
Dumpato da un kit di debug XDK D2. Molto simile a D01, ma con logica del cassetto, logica di surriscaldamento e logica di avvio leggermente differenti. La sfida di avvio manca allo stesso modo di D01.

## D2E
Dumpato da un dev kit Tuscany (v1.6). Il chip Xyclops è marcato X01202-001, e manca la linea A-A02 o A-B01 che le unità retail hanno.

Il codice seriale di debug a FC00 corrisponde al dump retail P2L. C'è un motivo strano di dati da 0x4000 a 0xFBFF.

## P01
Dumpato da una Xbox v1.0. La parola di configurazione è 0x86:
- CP1:CP0 = 0 (Protezione del codice abilitata per tutta la memoria)
- BODEN = 0 (Reset per Brown-out disabilitato)
- ~PWRTE = 0 (Timer di accensione abilitato)
- WDTE = 1 (Timer watchdog abilitato)
- FOSC1:FOSC0 = 2 (Oscillatore HS)

Un valore di configurazione di 0x3FB6 è adatto per cloni SMC in modo che non abbiano la protezione del codice abilitata.

## P11
Dumpato da una Xbox v1.3. Stessa parola di configurazione della P01.

Ci sono alcune piccole modifiche in P11 rispetto a P01, tra cui un comando SMBus aggiuntivo (scrittura 0x22), priorità LED diverse e tempi più rilassati per l'avvio.

Ho confrontato i dump criptati di v1.3 con quelli di v1.4 e coincidevano. Questo significa che è altamente probabile che abbiano lo stesso programma.

## P2L
Dumpato da una Xbox v1.6. Revisione Xyclops A-A02. Contiene codice Intel 8051 ma possiede molti registri a funzione speciale con funzione sconosciuta.

Il debug seriale è gestito dal codice a FC00. Sembra un debugger rudimentale che può mettere in pausa l'esecuzione, scaricare dati e scrivere su registri/RAM.

# Dumping di Xyclops

Il chip Xyclops ha 3 pin per il 'debug': TXD (pin 64), RXD (pin 63), e DEBUG (pin 29). Impostare il pin DEBUG alto per abilitare la porta seriale sui pin TX e RX. La seriale opera a 9600 baud.

Il protocollo si basa su comandi di 4 byte che sono tipicamente nel formato `<cmd>` `<address MSByte>` `<address LSByte>` `<don't care>`

Il comando 0x14 scarica 64 byte di dati BIOS alla volta e 0x15 scarica 64 byte di dati programma SMC alla volta. Un dump da Xyclops, P2L.bin, è incluso nel repository. [xyclops_dumper.py](/Xyclops/xyclops_dumper.py) è incluso anche per permetterti di scaricare la tua macchina.

# Metodologia di dumping PIC
Scrittura completa su https://wiki.recessim.com/view/PIC_Burnout

Il PIC ha la protezione del codice attivata quindi tutti i dati vengono letti come 0000. Ho usato un trucco per ottenere invece dati criptati in uscita, scoperto l'algoritmo di criptaggio usando un chip sacrificabile, e poi sfruttato una sorta di exploit per modificare i dati ROM e fissare alcuni bit a valori noti. Così posso estrarre le informazioni richieste dai molteplici dump criptati per ricostruire i dati originali.

# PICProgrammer
PICProgrammer è uno dei diversi progetti Arduino per RP2040 che ho usato nella mia ricerca. Offre una semplice interfaccia a riga di comando per eseguire operazioni ICSP (programmazione seriale in-circuit) sul PIC. È preferito rispetto all’uso di un programmatore dedicato come il PICkit grazie alla sua flessibilità e alla possibilità di fare cose non previste dal produttore.

Dovresti avere una buona conoscenza di elettronica e programmazione prima di usarlo, e dare un’attenta occhiata a cosa fanno i comandi prima di eseguirli.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---