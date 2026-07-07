
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

# 🎯 Sterownik MT7902 jako podczęść sterownika MT7921 (✅ Działa)
Chip Mediatek mt7902 wifi 6E Obsługa Bluetooth i WiFi

> [!WAŻNE]
> Oficjalne wsparcie dla układu MT7902 WIFI 6E w jądrze Linux 7.1


## 📁 Klonowanie repozytorium
Sklonuj repozytorium na swój lokalny komputer
  ```
  git clone https://github.com/OnlineLearningTutorials/mt7902_temp
  ```
Jeśli nie chcesz klonować wcześniejszej historii, to
  ```
  git clone --depth 1 https://github.com/OnlineLearningTutorials/mt7902_temp
  ```

## Instalacja


### 🚀 Skrypt Przewodnika Instalacyjnego (Zalecany dla systemów opartych na Ubuntu)
Uczyń skrypt wykonywalnym, jeśli jeszcze nie jest
```
chmod +x ./install_guide.sh
```
Teraz uruchom ten skrypt
```
./install_guide.sh
```
Automatycznie poprosi o hasło, gdy będzie to konieczne
* Ten skrypt poprosi Cię o zainstalowanie firmware, sterownika bluetooth oraz wifi po kolei
* Przetestowano na Ubuntu z jądrem linux 7.0

### 🚀 Łatwa Automatyczna Naprawa (Zalecane dla systemów opartych na Arch)
Jeśli chcesz szybko naprawić WiFi i Bluetooth na dowolnym nowoczesnym jądrze, wykonaj te kroki:

Uczyń skrypt wykonywalnym, jeśli jeszcze taki nie jest
```
chmod +x ./fix_my_wifi.sh
```

**Uruchom automatyczny skrypt naprawczy** za pomocą sudo:
```bash
sudo bash fix_my_wifi.sh
```

#### 📖 Co robi ten skrypt:
* **Sprawdza zależności:** Upewnia się, że masz zainstalowane `gcc`/`clang`, `make`, `bc` oraz aktualne `kernel-headers`. Jeśli nie – instaluje je za pomocą preferowanego menedżera pakietów.
* **Kompiluje sterowniki:** Automatycznie buduje sterowniki WiFi i Bluetooth dla Twojej dokładnej wersji jądra.
* **Trwała poprawka:** Instaluje usługę systemową, która zapewnia aktywność WiFi nawet po ponownym uruchomieniu komputera.
* **Bezpieczeństwo:** Instaluje moduły do niestandardowego katalogu (`/lib/modules/mt7902_custom`), aby nie ingerować w domyślne pliki systemowe.

> [!NOTE]
> Podczas pierwszego uruchomienia będziesz potrzebować połączenia z internetem (przez Ethernet lub tethering USB z telefonu), aby pobrać niezbędne narzędzia do budowy (takie jak kompilator, linux-headers itp).


## ✅ Przetestowano na (Działa zweryfikowane)
Ta poprawka została zweryfikowana i potwierdzona jako działająca na:

* **Marka:** ASUS
* **Model:** Vivobook Go (E1404FA), Vivobook 14 (X1404ZA)
* **Chipset:** MediaTek MT7902 (WiFi 6E)
* **Wersja jądra:** 6.19.0 (Linux), 6.19.11, 7.0.7
* **Systemy:** Arch, Ubuntu
* **Menedżer pakietów:** pacman, apt

## Dostępne dla:
* **System:** Każdy system obsługujący jeden z wymienionych menedżerów pakietów
* **Preferowane menedżery pakietów:** apt, pacman, dnf, zypper, nix-shell
* **Wersje jądra:** 6.14-7.0.7


## 🔧 Używane firmware
Pliki firmware są przechowywane w folderze `firmware`.


## 📱 Bluetooth ✅ (Działa)
> [!WARNING]
> Jeśli sterownik bluetooth koliduje z `gen4-mt7902`, usuń firmware bluetooth, aby nie zakłócał działania tego sterownika
> ``` sudo rm /lib/firmware/mediatek/mt7902/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```
> Ten projekt korzysta z firmware
> ``` /lib/firmware/mediatek/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```

Aby włączyć bluetooth, przejdź do katalogu odpowiadającego Twojej wersji jądra. ``
Na przykład jeśli masz jądro linux-6.16, przejdź do katalogu `./linux-6.16/drivers/bluetooth` .
Otwórz terminal w tym katalogu i skompiluj poleceniem `make`.
Kompilowane są dwa moduły jądra: `btusb.ko` i `btmtk.ko`.
Aby włączyć bluetooth w swoim urządzeniu, usuń btusb i btmtk z systemu i zainstaluj te dwa pliki, użyj poleceń
```
sudo rmmod btusb 
sudo rmmod btmtk

sudo insmod btmtk.ko
sudo insmod btusb.ko

```
Teraz sprawdź, czy bluetooth działa.

## 💻 WiFi ✅ (Działa)
> [!WAŻNE]
> Działające repozytorium z pewnymi ograniczeniami znajduje się [tutaj](https://github.com/hmtheboy154/gen4-mt7902)

Sterownik WiFi dla mt7902, niedawno wydany przez mediatek, znajduje się w folderze `latest`. 

Jeśli używasz Ubuntu, przejdź do folderu `latest` i uruchom następującą komendę w terminalu.
```
make
```

Skompiluje wszystkie moduły, skompresuje je i zainstaluje (zastąpi oryginalny moduł jądra zmodyfikowanym modułem). Jeśli używasz innej dystrybucji lub nie chcesz wykonywać wszystkich kroków, a jedynie skompilować kod, uruchom w terminalu
```
make module_compile
```
Aby skompresować skompilowany moduł, następnie uruchom w terminalu
```
make module_compress
```
Aby zainstalować skompresowany moduł do modułu jądra systemu, uruchom w terminalu
```
make module_install
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-07

---