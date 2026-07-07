
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# 🎯 MT7902 Stuurprogramma als Sub-onderdeel van MT7921 Stuurprogramma (✅ Werkend)
Mediatek mt7902 wifi 6E chip Bluetooth en WiFi Ondersteuning

> [!BELANGRIJK]
> Linux 7.1 Kernel Ondersteunt Officieel de MT7902 WIFI 6E chip


## 📁 De repository klonen
Kloon de repository naar je lokale pc
  ```
  git clone https://github.com/OnlineLearningTutorials/mt7902_temp
  ```
Als je de eerdere geschiedenis niet wilt klonen dan
  ```
  git clone --depth 1 https://github.com/OnlineLearningTutorials/mt7902_temp
  ```

## Installatie


### 🚀 Installatiehandleiding Script (Aanbevolen voor Ubuntu-gebaseerd systeem)
Maak het script uitvoerbaar als dit nog niet het geval is
```
chmod +x ./install_guide.sh
```
Voer nu dit script uit
```
./install_guide.sh
```
Het zal automatisch om een wachtwoord vragen wanneer nodig
* Dit script zal je vragen om firmware, bluetooth en wifi-driver één voor één te installeren
* Getest op Ubuntu met linux 7.0 kernel

### 🚀 Eenvoudige Automatische Oplossing (Aanbevolen voor Arch-gebaseerde systemen)
Als je snel je WiFi en Bluetooth wilt repareren op een moderne kernel, volg dan deze stappen:

Maak het script uitvoerbaar als dat nog niet het geval is
```
chmod +x ./fix_my_wifi.sh
```

**Voer het automatische fix-script uit** met sudo:
```bash
sudo bash fix_my_wifi.sh
```

#### 📖 Wat doet dit script:
* **Controleert op afhankelijkheden:** Zorgt ervoor dat je `gcc`/`clang`, `make`, `bc` en je huidige `kernel-headers` geïnstalleerd hebt. Zo niet – installeert ze met je voorkeurs pakketbeheerder.
* **Compileert drivers:** Bouwt automatisch zowel WiFi- als Bluetooth-drivers voor jouw exacte kernelversie.
* **Persistente fix:** Installeert een systeemservice die ervoor zorgt dat je WiFi actief blijft, zelfs na het herstarten van je computer.
* **Veiligheid:** Installeert modules in een aangepaste map (`/lib/modules/mt7902_custom`) om te voorkomen dat je standaard systeemfiles worden beïnvloed.

> [!NOTE]
> Je hebt een internetverbinding nodig (via Ethernet of USB-tethering vanaf je telefoon) de eerste keer dat je dit uitvoert om de benodigde buildtools te downloaden. (Zoals compiler, linux-headers, enz.)

## ✅ Getest op (Bevestigd werkend)
Deze fix is geverifieerd en werkt bevestigd op:

* **Merk:** ASUS
* **Model:** Vivobook Go (E1404FA), Vivobook 14 (X1404ZA)
* **Chipset:** MediaTek MT7902 (WiFi 6E)
* **Kernelversie:** 6.19.0 (Linux), 6.19.11, 7.0.7
* **Besturingssystemen:** Arch, Ubuntu
* **Pakketbeheerder:** pacman, apt

## Beschikbaar voor:
* **OS**: Elk besturingssysteem dat één van de pakketbeheerders ondersteunt
* **Voorkeurs pakketbeheerders**: apt, pacman, dnf, zypper, nix-shell
* **Kernelversies**: 6.14-7.0.7

## 🔧 Gebruikte firmware
Firmwares worden opgeslagen in de map `firmware`.

## 📱 Bluetooth ✅ (Werkend)
> [!WARNING]
> Als de bluetoothdriver conflicteert met `gen4-mt7902` verwijder dan de bluetooth firmware zodat deze niet interfereert met deze driver
> ``` sudo rm /lib/firmware/mediatek/mt7902/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```
> Dit project gebruikt de firmware
> ``` /lib/firmware/mediatek/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```

Om bluetooth te activeren ga naar de directory van je huidige kernelversie. ``
Als je bijvoorbeeld kernel linux-6.16 hebt, ga dan naar de directory `./linux-6.16/drivers/bluetooth`.



Open een terminal in deze map en compileer met het commando `make`.
Twee kernelmodules worden gecompileerd: `btusb.ko` en `btmtk.ko`.
Om bluetooth op je apparaat in te schakelen, verwijder je de btusb en btmtk in je systeem en installeer je deze twee bestanden, gebruik de volgende commando's
```
sudo rmmod btusb 
sudo rmmod btmtk

sudo insmod btmtk.ko
sudo insmod btusb.ko

```
Controleer nu of je bluetooth nu werkt.

## 💻 WiFi ✅ (Werkt)
> [!BELANGRIJK]
> Een werkende repo met enkele beperkingen is [hier](https://github.com/hmtheboy154/gen4-mt7902)

De WiFi-driver voor de mt7902, onlangs uitgebracht door Mediatek, bevindt zich in de map `latest`.

Als je Ubuntu gebruikt, ga dan gewoon naar de map `latest` en voer de volgende opdracht uit in de terminal.
```
make
```

Het zal alle modules compileren, comprimeren en installeren (het originele kernelmodule vervangen door de aangepaste module). Als je een andere distributie gebruikt of niet alle stappen wilt uitvoeren en alleen de code wilt compileren, voer dan uit in de terminal
```
make module_compile
```
Om de module die je hebt gecompileerd te comprimeren, voer je vervolgens uit in de terminal
```
make module_compress
```
Om de gecomprimeerde module aan de kernelmodule van het systeem te installeren, voer uit in de terminal
```
make module_install
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-07

---