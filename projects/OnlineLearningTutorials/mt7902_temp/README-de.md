
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=vi">Vietnamesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# 🎯 MT7902-Treiber als Unterteil des MT7921-Treibers (✅ Funktioniert)
Mediatek mt7902 WiFi 6E Chip Bluetooth- und WiFi-Unterstützung

> [!WICHTIG]
> Linux Kernel 7.1 unterstützt den MT7902 WIFI 6E Chip offiziell


## 📁 Repository klonen
Klonen Sie das Repository auf Ihren lokalen PC
  ```
  git clone https://github.com/OnlineLearningTutorials/mt7902_temp
  ```
Wenn Sie die bisherige Historie nicht klonen möchten, dann
  ```
  git clone --depth 1 https://github.com/OnlineLearningTutorials/mt7902_temp
  ```

## Installation


### 🚀 Installationsanleitung-Skript (Empfohlen für Ubuntu-basiertes System)
Machen Sie das Skript ausführbar, falls es noch nicht ausführbar ist
```
chmod +x ./install_guide.sh
```
Führen Sie nun dieses Skript aus
```
./install_guide.sh
```
Es wird bei Bedarf automatisch zur Eingabe des Passworts auffordern
* Dieses Skript fordert Sie nacheinander auf, Firmware, Bluetooth- und WLAN-Treiber zu installieren
* Getestet auf Ubuntu mit Linux 7.0 Kernel

### 🚀 Einfacher automatischer Fix (Empfohlen für Arch-basierte Systeme)
Wenn Sie Ihr WLAN und Bluetooth schnell auf jedem modernen Kernel reparieren möchten, führen Sie diese Schritte aus:

Machen Sie das Skript ausführbar, falls noch nicht geschehen
```
chmod +x ./fix_my_wifi.sh
```

**Führen Sie das automatische Reparaturskript** mit sudo aus:
```bash
sudo bash fix_my_wifi.sh
```

#### 📖 Was dieses Skript macht:
* **Überprüft Abhängigkeiten:** Stellt sicher, dass `gcc`/`clang`, `make`, `bc` und die aktuellen `kernel-headers` installiert sind. Falls nicht, werden sie mit deinem bevorzugten Paketmanager installiert.
* **Kompiliert Treiber:** Baut automatisch sowohl WLAN- als auch Bluetooth-Treiber für deine exakte Kernel-Version.
* **Persistente Lösung:** Installiert einen Systemdienst, der sicherstellt, dass dein WLAN auch nach einem Neustart aktiv bleibt.
* **Sicherheit:** Installiert Module in ein benutzerdefiniertes Verzeichnis (`/lib/modules/mt7902_custom`), um die Standard-Systemdateien nicht zu beeinträchtigen.

> [!NOTE]
> Du benötigst beim ersten Ausführen eine Internetverbindung (über Ethernet oder USB-Tethering von deinem Handy), um die notwendigen Build-Tools herunterzuladen. (Wie Compiler, linux-headers usw.)


## ✅ Getestet auf (verifiziert funktionierend)
Dieser Fix wurde überprüft und funktioniert bestätigt auf:

* **Marke:** ASUS
* **Modell:** Vivobook Go (E1404FA), Vivobook 14 (X1404ZA)
* **Chipsatz:** MediaTek MT7902 (WiFi 6E)
* **Kernel-Version:** 6.19.0 (Linux), 6.19.11, 7.0.7
* **Betriebssysteme:** Arch, Ubuntu
* **Paketmanager:** pacman, apt

## Verfügbar für:
* **Betriebssystem:** Jedes OS, das einen der Paketmanager unterstützt
* **Bevorzugte Paketmanager:** apt, pacman, dnf, zypper, nix-shell
* **Kernel-Versionen:** 6.14-7.0.7


## 🔧 Verwendete Firmwares
Firmwares befinden sich im Ordner `firmware`.


## 📱 Bluetooth ✅ (funktioniert)
> [!WARNING]
> Falls der Bluetooth-Treiber mit `gen4-mt7902` in Konflikt steht, entferne bitte die Bluetooth-Firmware, damit sie diesen Treiber nicht beeinträchtigt.
> ``` sudo rm /lib/firmware/mediatek/mt7902/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```
> Dieses Projekt verwendet die Firmware
> ``` /lib/firmware/mediatek/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```

Um Bluetooth zu aktivieren, gehe in das Verzeichnis deiner aktuellen Kernel-Version. ``
Wenn du beispielsweise Kernel linux-6.16 hast, dann gehe in das Verzeichnis `./linux-6.16/drivers/bluetooth` .
Öffnen Sie das Terminal in diesem Verzeichnis und kompilieren Sie mit dem Befehl `make`.
Zwei Kernel-Module werden kompiliert: `btusb.ko` und `btmtk.ko`.
Um Bluetooth auf Ihrem Gerät zu aktivieren, entfernen Sie btusb und btmtk in Ihrem System und installieren Sie diese beiden Dateien, verwenden Sie die Befehle
```
sudo rmmod btusb 
sudo rmmod btmtk

sudo insmod btmtk.ko
sudo insmod btusb.ko

```
Überprüfen Sie jetzt, ob Ihr Bluetooth jetzt funktioniert.

## 💻 WLAN ✅ (Funktioniert)
> [!WICHTIG]
> Ein funktionierendes Repository mit einigen Einschränkungen finden Sie [hier](https://github.com/hmtheboy154/gen4-mt7902)

Der WiFi-Treiber für den mt7902, der kürzlich von Mediatek veröffentlicht wurde, befindet sich im Ordner `latest`.

Wenn Sie Ubuntu verwenden, gehen Sie einfach in den Ordner `latest` und führen Sie den folgenden Befehl im Terminal aus.
```
make
```
Es wird alle Module kompilieren, sie komprimieren und installieren (das ursprüngliche Kernel-Modul durch das modifizierte Modul ersetzen). Wenn Sie eine andere Distribution verwenden oder nicht alle Schritte ausführen möchten und nur den Code kompilieren wollen, führen Sie im Terminal aus

```
make module_compile
```
Um das von Ihnen kompilierte Modul zu komprimieren, führen Sie anschließend im Terminal aus
```
make module_compress
```
Um das komprimierte Modul im Kernel-Modul des Systems zu installieren, führen Sie im Terminal aus
```
make module_install
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-07

---