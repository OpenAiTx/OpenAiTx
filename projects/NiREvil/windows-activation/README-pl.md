# Natychmiastowa aktywacja Windows 10 & 11: rozwiązanie w 40 sekund

[![Readme](https://img.shields.io/badge/README_IN-فارسی-blue?logo=readme)](README-FA.md)  
[![Readme](https://img.shields.io/badge/README_IN-ENGLISH-blue?logo=readme)](README.md)

> To repozytorium zawiera sposób, który pozwala aktywować system Windows 10 i 11 w mniej niż 40 sekund. Obie metody są kompatybilne z wersjami home, home N, home single lang, home country specific, professional, education oraz enterprise systemu Windows.

## Metoda 1 (zalecana)  
### Natychmiastowa aktywacja Windows z użyciem (PowerShell)  
> [!TIP]
> Istnieje wiele sposobów uruchamiania PowerShell w Windows 10 & 11. [^1]

Jednym z najszybszych sposobów otwarcia PowerShell w Windows jest wyszukiwanie w menu Start. Możesz wykonać następujące kroki:

<br>

### Krok 1  
Wystarczy kliknąć ikonę start lub wyszukiwania i wpisać "PowerShell" w polu wyszukiwania.  
> Inny prosty sposób: [^2]

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/5a10538a-c8c2-4934-868b-fd8e910f1f9e" width="540px">
</p>  

---
<br>

### Krok 2  
Następnie musisz kliknąć na `Uruchom jako administrator`, aby uruchomić PowerShell, w tym przypadku musimy uruchomić go z **uprawnieniami administratora**.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1f25dd2a-16db-4053-a45c-aac6f8a9e470" width="540px">
</p>

---
<br>

### Krok 3  
Teraz, po krótkiej chwili potrzebnej na wykonanie operacji, proszę `skopiować` tę linię:

```CSS
irm https://get.activated.win | iex
```

---
<br>

### Krok 4  
Wklej ją (prawym przyciskiem myszy) i naciśnij klawisz Enter. W nowo otwartym oknie pojawi się kilka opcji, z których musisz wybrać opcję `1` i poczekać kilka sekund na zakończenie procesu.  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/0c3689a1-1595-40b3-97e2-041dac423237" width="540px">
</p>

<br>

#### Gratulacje,
Twój system Windows został aktywowany.  
Teraz możesz nacisnąć Enter, aby zamknąć CMD i zamknąć PowerShell oraz sprawdzić menu Aktywacji systemu Windows [^3]

<br><br><br><br><br><br><br><br>

## Metoda 2  
### Natychmiastowa aktywacja Windows przez CMD (Wiersz polecenia)

<br>

> [!NOTE]
> Pamiętaj o **połączeniu** z **Internetem**
>
> VPN **nie jest konieczny**

<br>

### Krok 1  
Najpierw kliknij ikonę start lub wyszukiwania i wpisz "CMD" w polu wyszukiwania. Po pojawieniu się opcji wiersza poleceń, uruchom go jako **administrator**  
> inne proste sposoby: [^2].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/88ac970a-f24b-4acc-82c0-f8e7c0b05249" width="480px">
</p>  

---
<br>

### Poniżej znajduje się lista KLUCZY LICENCYJNYCH  

|            **Klucz**            |  **Wersja**   |
| :-----------------------------: | :-----------: |
| TX9XD-98N7V-6WMQ6-BX7FG-H8Q99   |     Home      |
| 3KHY7-WNT83-DGQKR-F7HPR-844BM   |    Home N     |
| 7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH   | Home sl [^4]  |
| PVMJN-6DFY6–9CCP6–7BKTT-D3WVR   | Home cs [^5]  |
| W269N-WFGWX-YVC9B-4J6C9-T83GX   | Professional  |
| MH37W-N47XK-V7XM9-C7227-GCQG9   | Professional N|
| NW6C2-QMPVW-D7KKK-3GKT6-VCFB2   |   Education   |
| 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ   |  Education N  |
| NPPR9-FWDCX-D2C8J-H872K-2YT43   |   Enterprise  |
| DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4   | Enterprise N  |

![rainbow](https://github.com/NiREvil/vless/assets/126243832/1aca7f5d-6495-44b7-aced-072bae52f256)

<br>

### Krok 2  
Zainstaluj klucz klienta KMS.

Użyj tej komendy:

```CSS
slmgr /ipk yourlicensekey
```

> [!NOTE]
> Proszę wybrać jeden z **kluczy licencyjnych** z listy, który **odpowiada wersji Twojego Windowsa** i zamienić frazę `yourlicencekey` w poleceniu.

> [!TIP]
> Jak sprawdzić wersję Windows [^3].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1b6401e6-7e63-4351-8a92-fa355dfc30cf" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/90037069-7ea3-44a8-a9fa-e296f5e8d47b" width="340px">
</p>  

---
<br>

### Krok 3  
Ustaw adres serwera KMS.

Użyj polecenia:

```CSS
slmgr /skms kms8.msguides.com
```

aby połączyć się z moim serwerem KMS.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9d634454-1c59-47da-874e-bfe575288fe6" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/2d2e6cfb-4e85-483f-ae0a-c7157d22da36" width="340px">
</p>  

---  
<br>

### Krok 4  
Aktywuj swój system Windows.
Ostatnim krokiem jest aktywacja Windows za pomocą polecenia:

```CSS
slmgr /ato
```

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/5e495d42-6ce5-4884-9de2-96a56efb4343" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/aecd9cfd-8c09-4433-b410-a62205a8d692" width="240px">
</p>  

---
<br>

### Krok 5  
A teraz ponownie sprawdź status aktywacji [^6].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9ca70137-8e2e-4504-a52d-22f41d959bd7" width="480px">
</p>

#### Gotowe ✅  
Twój Windows został pomyślnie aktywowany.

<br>

**Bądź ciekawy 🤍**

[![Telegram](https://img.shields.io/badge/TELEGRAM-blue.svg?logo=telegram)](https://t.me/F_NiREvil) [![Twitter](https://img.shields.io/badge/TWITTER-blue.svg?logo=x)](https://twitter.com/NiREvil_)

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/25423296/163456776-7f95b81a-f1ed-45f7-b7ab-8fa810d529fa.png">
  <source media="(prefers-color-scheme: light)" srcset="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
  <img alt="Pokazuje narysowane słońce w trybie jasnym i księżyc z gwiazdami w trybie ciemnym." src="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
</picture>

<br>

[^1]: [10 sposobów uruchamiania PowerShell w Windows](https://www.google.com/amp/s/www.minitool.com/news/open-windows-11-powershell.html%3famp)  

[^2]: Inny najprostszy sposób uruchomienia PowerShell: **Kliknij prawym przyciskiem myszy** na menu Start, aby wywołać szybkie menu i wybierz **Windows Terminal (admin)** w Windows 11 lub **Windows powershell (admin)** w Windows 10 z listy.
[^3]: Aby sprawdzić wersję Windows: **Kliknij prawym przyciskiem myszy** na menu Start i wybierz opcję **system**. Wersja Twojego Windowsa widoczna jest w drugiej sekcji pod **Edycja.** Możesz także wykonać kroki z metody 2 przez **kopiowanie i wklejanie** poleceń. Skopiuj komendy i potem naciśnij **prawy przycisk myszy** w **cmd lub powershell**, aby je wkleić.
[^4]: Wersja Home Single language.
[^5]: Wersja Home Country Specific.
[^6]: Aby sprawdzić status aktywacji Windows, przejdź do:  
***Ustawienia → Aktualizacja i zabezpieczenia → menu aktywacji.***

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---