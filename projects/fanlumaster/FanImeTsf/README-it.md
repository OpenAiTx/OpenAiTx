## FanImeTsf

Questa è la parte TSF di [FanImeServer](https://github.com/fanlumaster/FanImeServer).

Nota: attualmente supporta solo applicazioni a 64 bit.

## Come compilare

### Prerequisiti

- Visual Studio 2022
- CMake
- vcpkg
- Python3
- gsudo

Assicurati che vcpkg e gsudo siano installati tramite **Scoop**.

## Passaggi per la compilazione

### Compilazione

Per prima cosa, clona il repository,

```powershell
git clone --recursive https://github.com/fanlumaster/FanImeTsf.git
```

Poi, prepara l'ambiente,

```powershell
cd FanImeTsf
python .\scripts\prepare_env.py
```

Successivamente, compila,

```powershell
.\scripts\lcompile.ps1
```

### Installazione

Avvia powershell come amministratore e assicurati di aver attivato l'opzione di sistema `Enable sudo`.

![](https://i.postimg.cc/zJCn9Cnn/image.png)

Quindi, crea una cartella in `C:\Program Files\` chiamata `FanImeTsf` e copia al suo interno il file `FanImeTsf.dll`,

```powershell
gsudo
Copy-Item -Path ".\FanImeTsf\build64\Debug\FanImeTsf.dll" -Destination "C:\Program Files\FanImeTsf"
```

Poi, installalo,

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 .\FanImeTsf.dll
```

### Disinstallazione

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 /u .\FanImeTsf.dll
```

## Screenshot

![](https://i.postimg.cc/v8Bpx6Gf/image.png)

![](https://i.postimg.cc/ssBgtM5M/image.png)

![](https://i.postimg.cc/ryDqXH0B/image.png)

![](https://i.postimg.cc/2m9WJTgR/image.png)

![](https://i.postimg.cc/L96qQZT8/image.png)

![](https://i.postimg.cc/FNcz9QTv/image.png)

## Roadmap

Attualmente è supportato solo Xiaohe Shuangpin.

### Cinese

- Xiaohe Shuangpin
- Quanpin
- Codici di aiuto nell'uso dei componenti Hanzi
- Dizionario personalizzabile
- Motore IME personalizzato
- Temi personalizzati
- Passaggio tra cinese semplificato e tradizionale
- Completamento automatico in inglese
- API Cloud IME open source
- Interfaccia finestra candidati commutabile tra modalità verticale e orizzontale
- Interruttori delle funzionalità: la maggior parte delle funzionalità dovrebbe poter essere attivata/disattivata o personalizzata liberamente dagli utenti

### Supporto per il giapponese

Forse un altro progetto.

E forse anche il supporto per altre lingue.

### Riferimenti

- [MS-TSF-IME-Demo](https://github.com/microsoft/Windows-classic-samples/tree/main/Samples/IME/cpp/SampleIME)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---