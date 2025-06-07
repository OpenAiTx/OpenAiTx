## FanImeTsf

Dit is de TSF-kant van [FanImeServer](https://github.com/fanlumaster/FanImeServer).

Let op: momenteel worden alleen 64-bit apps ondersteund.

## Hoe te bouwen

### Vereisten

- Visual Studio 2022
- CMake
- vcpkg
- Python3
- gsudo

Zorg ervoor dat vcpkg en gsudo zijn geïnstalleerd via **Scoop**.

## Bouwstappen

### Bouwen

Kloon eerst de repository,

```powershell
git clone --recursive https://github.com/fanlumaster/FanImeTsf.git
```

Bereid daarna de omgeving voor,

```powershell
cd FanImeTsf
python .\scripts\prepare_env.py
```

Bouw vervolgens,

```powershell
.\scripts\lcompile.ps1
```

### Installeren

Start Powershell als administrator en zorg ervoor dat je de systeemoptie `Enable sudo` hebt ingeschakeld.

![](https://i.postimg.cc/zJCn9Cnn/image.png)

Maak vervolgens een map in `C:\Program Files\` met de naam `FanImeTsf` en kopieer `FanImeTsf.dll` ernaartoe,

```powershell
gsudo
Copy-Item -Path ".\FanImeTsf\build64\Debug\FanImeTsf.dll" -Destination "C:\Program Files\FanImeTsf"
```

Installeer het daarna,

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 .\FanImeTsf.dll
```

### Deïnstalleren

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

Momenteel wordt alleen Xiaohe Shuangpin ondersteund.

### Chinees

- Xiaohe Shuangpin
- Quanpin
- Hulpcodes bij gebruik van Hanzi-componenten
- Aanpasbaar woordenboek
- Aangepaste IME-engine
- Aangepaste skins
- Wisselen tussen Vereenvoudigd Chinees en Traditioneel Chinees
- Engelse autocomplete
- Open-source Cloud IME API
- Kandidatenvenster UI schakelen tussen verticale en horizontale modus
- Functieschakelaars: de meeste functies moeten vrij door gebruikers kunnen worden in- of uitgeschakeld of aangepast

### Japanse ondersteuning

Misschien een ander project.

En mogelijk ook ondersteuning voor andere talen.

### Referenties

- [MS-TSF-IME-Demo](https://github.com/microsoft/Windows-classic-samples/tree/main/Samples/IME/cpp/SampleIME)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---