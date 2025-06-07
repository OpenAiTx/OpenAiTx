## FanImeTsf

To jest końcówka TSF dla [FanImeServer](https://github.com/fanlumaster/FanImeServer).

Uwaga: obecnie obsługiwane są tylko aplikacje 64-bitowe.

## Jak zbudować

### Wymagania wstępne

- Visual Studio 2022
- CMake
- vcpkg
- Python3
- gsudo

Upewnij się, że vcpkg i gsudo są zainstalowane przez **Scoop**.

## Kroki budowania

### Budowanie

Najpierw sklonuj repozytorium,

```powershell
git clone --recursive https://github.com/fanlumaster/FanImeTsf.git
```

Następnie przygotuj środowisko,

```powershell
cd FanImeTsf
python .\scripts\prepare_env.py
```

Następnie zbuduj,

```powershell
.\scripts\lcompile.ps1
```

### Instalacja

Uruchom powershell jako administrator, upewnij się, że masz włączoną opcję systemową `Enable sudo`.

![](https://i.postimg.cc/zJCn9Cnn/image.png)

Następnie utwórz folder w `C:\Program Files\` o nazwie `FanImeTsf` i skopiuj do niego plik `FanImeTsf.dll`,

```powershell
gsudo
Copy-Item -Path ".\FanImeTsf\build64\Debug\FanImeTsf.dll" -Destination "C:\Program Files\FanImeTsf"
```

Następnie zainstaluj,

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 .\FanImeTsf.dll
```

### Odinstalowanie

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 /u .\FanImeTsf.dll
```

## Zrzuty ekranu

![](https://i.postimg.cc/v8Bpx6Gf/image.png)

![](https://i.postimg.cc/ssBgtM5M/image.png)

![](https://i.postimg.cc/ryDqXH0B/image.png)

![](https://i.postimg.cc/2m9WJTgR/image.png)

![](https://i.postimg.cc/L96qQZT8/image.png)

![](https://i.postimg.cc/FNcz9QTv/image.png)

## Plan rozwoju

Obecnie obsługiwany jest tylko Xiaohe Shuangpin.

### Chiński

- Xiaohe Shuangpin
- Quanpin
- Kody pomocnicze przy użyciu komponentów Hanzi
- Słownik konfigurowalny przez użytkownika
- Konfigurowalny silnik IME
- Konfigurowalne skórki
- Przełączanie między chińskim uproszczonym a tradycyjnym
- Autouzupełnianie po angielsku
- Otwarty interfejs Cloud IME
- Przełączanie interfejsu okna kandydatów między trybem pionowym a poziomym
- Przełączniki funkcji: większość funkcji powinna być swobodnie przełączana lub konfigurowana przez użytkownika

### Obsługa języka japońskiego

Może być jako osobny projekt.

I być może obsługa innych języków.

### Odnośniki

- [MS-TSF-IME-Demo](https://github.com/microsoft/Windows-classic-samples/tree/main/Samples/IME/cpp/SampleIME)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---