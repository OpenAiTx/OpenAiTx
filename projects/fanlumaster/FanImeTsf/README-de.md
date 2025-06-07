## FanImeTsf

Dies ist das TSF-Ende von [FanImeServer](https://github.com/fanlumaster/FanImeServer).

Hinweis: Unterstützt derzeit nur 64-Bit-Anwendungen.

## Wie baut man

### Voraussetzungen

- Visual Studio 2022
- CMake
- vcpkg
- Python3
- gsudo

Stellen Sie sicher, dass vcpkg und gsudo mit **Scoop** installiert wurden.

## Bauschritte

### Bauen

Zuerst das Repository klonen,

```powershell
git clone --recursive https://github.com/fanlumaster/FanImeTsf.git
```

Dann die Umgebung vorbereiten,

```powershell
cd FanImeTsf
python .\scripts\prepare_env.py
```

Dann bauen,

```powershell
.\scripts\lcompile.ps1
```

### Installation

Starten Sie PowerShell als Administrator und stellen Sie sicher, dass Sie die Systemoption `Enable sudo` aktiviert haben.

![](https://i.postimg.cc/zJCn9Cnn/image.png)

Erstellen Sie dann einen Ordner in `C:\Program Files\` mit dem Namen `FanImeTsf` und kopieren Sie die `FanImeTsf.dll` dorthin,

```powershell
gsudo
Copy-Item -Path ".\FanImeTsf\build64\Debug\FanImeTsf.dll" -Destination "C:\Program Files\FanImeTsf"
```

Dann installieren Sie es,

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 .\FanImeTsf.dll
```

### Deinstallation

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 /u .\FanImeTsf.dll
```

## Screenshots

![](https://i.postimg.cc/v8Bpx6Gf/image.png)

![](https://i.postimg.cc/ssBgtM5M/image.png)

![](https://i.postimg.cc/ryDqXH0B/image.png)

![](https://i.postimg.cc/2m9WJTgR/image.png)

![](https://i.postimg.cc/L96qQZT8/image.png)

![](https://i.postimg.cc/FNcz9QTv/image.png)

## Roadmap

Derzeit wird nur Xiaohe Shuangpin unterstützt.

### Chinesisch

- Xiaohe Shuangpin
- Quanpin
- Hilfscodes bei der Verwendung von Hanzi-Komponenten
- Anpassen des Wörterbuchs möglich
- Anpassbare IME-Engine
- Anpassbare Skins
- Umschalten zwischen vereinfachtem und traditionellem Chinesisch
- Englisch-Autovervollständigung
- Open-Source-Cloud-IME-API
- Umschalten des Kandidatenfenster-UIs zwischen vertikalem und horizontalem Modus
- Feature-Schalter: Die meisten Funktionen sollten von Benutzern frei umgeschaltet oder angepasst werden können

### Japanisch-Unterstützung

Vielleicht ein separates Projekt.

Und eventuell Unterstützung für weitere Sprachen.

### Referenzen

- [MS-TSF-IME-Demo](https://github.com/microsoft/Windows-classic-samples/tree/main/Samples/IME/cpp/SampleIME)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---