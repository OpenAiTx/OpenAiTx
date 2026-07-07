
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# 🎯 Driver MT7902 come sotto-parte del driver MT7921 (✅ Funzionante)
Chip wifi 6E Mediatek mt7902 Supporto Bluetooth e WiFi

> [!IMPORTANTE]
> Il kernel Linux 7.1 supporta ufficialmente il chip WIFI 6E MT7902


## 📁 Clonare il repository
Clona il repository sul tuo PC locale
  ```
  git clone https://github.com/OnlineLearningTutorials/mt7902_temp
  ```
Se non vuoi clonare la cronologia passata allora
  ```
  git clone --depth 1 https://github.com/OnlineLearningTutorials/mt7902_temp
  ```

## Installazione


### 🚀 Script Guida all'Installazione (Consigliato per sistemi basati su Ubuntu)
Rendi lo script eseguibile se non lo è già
```
chmod +x ./install_guide.sh
```
Ora esegui questo script
```
./install_guide.sh
```
Richiederà automaticamente la password quando necessario
* Questo script ti chiederà di installare firmware, driver bluetooth e wifi uno alla volta
* Testato su Ubuntu con kernel linux 7.0

### 🚀 Correzione Automatica Facile (Consigliata per sistemi basati su Arch)
Se vuoi correggere rapidamente il tuo WiFi e Bluetooth su qualsiasi kernel moderno, segui questi passaggi:

Rendi eseguibile lo script se non lo è già
```
chmod +x ./fix_my_wifi.sh
```

**Esegui lo script di correzione automatica** con sudo:
```bash
sudo bash fix_my_wifi.sh
```

#### 📖 Cosa fa questo script:
* **Controlla le dipendenze:** Garantisce che tu abbia installato `gcc`/`clang`, `make`, `bc` e gli attuali `kernel-headers`. In caso contrario, li installa con il tuo gestore di pacchetti preferito.
* **Compila i Driver:** Compila automaticamente sia i driver WiFi che Bluetooth per la tua esatta versione del kernel.
* **Correzione Persistente:** Installa un servizio di sistema che assicura che il WiFi rimanga attivo anche dopo il riavvio del computer.
* **Sicurezza:** Installa i moduli in una directory personalizzata (`/lib/modules/mt7902_custom`) per evitare di modificare i file di sistema predefiniti.

> [!NOTA]
> Avrai bisogno di una connessione internet (tramite Ethernet o tethering USB dal tuo telefono) la prima volta che esegui questo script per scaricare gli strumenti necessari alla compilazione. (Come compilatore, linux-headers, ecc.)


## ✅ Testato su (Verificato funzionante)
Questa soluzione è stata verificata e funziona confermata su:

* **Marca:** ASUS
* **Modello:** Vivobook Go (E1404FA), Vivobook 14 (X1404ZA)
* **Chipset:** MediaTek MT7902 (WiFi 6E)
* **Versione Kernel:** 6.19.0 (Linux), 6.19.11, 7.0.7
* **Sistemi Operativi:** Arch, Ubuntu
* **Gestore Pacchetti:** pacman, apt

## Disponibile per:
* **OS**: Qualsiasi sistema operativo che supporti uno dei gestori pacchetti indicati
* **Gestori pacchetti preferiti**: apt, pacman, dnf, zypper, nix-shell
* **Versioni Kernel**: 6.14-7.0.7


## 🔧 Firmware utilizzati
I firmware sono memorizzati nella cartella `firmware`.


## 📱 Bluetooth ✅ (Funzionante)
> [!ATTENZIONE]
> Se il driver bluetooth è in conflitto con `gen4-mt7902` rimuovere il firmware bluetooth in modo che non interferisca con questo driver
> ``` sudo rm /lib/firmware/mediatek/mt7902/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```
> Questo progetto utilizza il firmware
> ``` /lib/firmware/mediatek/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```

Per abilitare il bluetooth vai nella directory della versione attuale del tuo kernel. ``
Ad esempio, se hai il kernel linux-6.16 vai nella directory `./linux-6.16/drivers/bluetooth` .
Apri il terminale in questa directory e compila con il comando `make`.
Vengono compilati due moduli kernel `btusb.ko` e `btmtk.ko`.
Per abilitare il bluetooth nel tuo dispositivo, rimuovi btusb e btmtk dal tuo sistema e installa questi due file, usa i comandi
```
sudo rmmod btusb 
sudo rmmod btmtk

sudo insmod btmtk.ko
sudo insmod btusb.ko

```
Ora verifica che il tuo bluetooth funzioni ora.

## 💻 WiFi ✅ (Funzionante)
> [!IMPORTANTE]
> Un repository funzionante con alcune limitazioni è [qui](https://github.com/hmtheboy154/gen4-mt7902)

Il driver WiFi per il mt7902, rilasciato recentemente da mediatek, si trova nella cartella `latest`.

Se stai usando Ubuntu vai semplicemente nella cartella `latest` ed esegui il seguente comando nel terminale.
```
make
```

Compilerà tutti i moduli, li comprimerà e li installerà (sostituendo il modulo kernel originale con il modulo modificato). Se usi un'altra distribuzione o non vuoi tutti i passaggi ma solo compilare il codice, allora esegui nel terminale
```
make module_compile
```
Per comprimere il modulo che hai compilato, poi esegui nel terminale
```
make module_compress
```
Per installare il modulo compresso nel modulo kernel del sistema, eseguire nel terminale
```
make module_install
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-07

---