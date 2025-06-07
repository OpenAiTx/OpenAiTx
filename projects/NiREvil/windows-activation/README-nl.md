# Directe Windows 10 & 11 Activering: 40-Seconden Oplossing.

[![Readme](https://img.shields.io/badge/README_IN-فارسی-blue?logo=readme)](README-FA.md)  
[![Readme](https://img.shields.io/badge/README_IN-ENGLISH-blue?logo=readme)](README.md)

> Deze repository bevat een methode waarmee je Windows 10 en 11 in minder dan 40 seconden kunt activeren. Beide methoden zijn compatibel met home, home N, home single language, home country specific, professional, education en enterprise versies van Windows.

## Methode 1 (aanbevolen)  
### Directe Windows-activering met (PowerShell)  
> [!TIP]
> Er zijn veel manieren om PowerShell te starten in Windows 10 & 11. [^1]

Een van de snelste manieren om PowerShell te openen in Windows is via een zoekopdracht in het Startmenu. Volg de onderstaande stappen:

<br>

### Stap 1  
Alles wat je hoeft te doen is op het start- of zoekpictogram te klikken en "PowerShell" te typen in het zoekvak.  
> Een andere makkelijke manier: [^2]

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/5a10538a-c8c2-4934-868b-fd8e910f1f9e" width="540px">
</p>  

---
<br>

### Stap 2  
Klik vervolgens op `Als administrator uitvoeren` om PowerShell te starten, in dit geval moeten we het uitvoeren met **beheerdersrechten**.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1f25dd2a-16db-4053-a45c-aac6f8a9e470" width="540px">
</p>

---
<br>

### Stap 3  
Na een korte pauze om de uitvoering toe te staan, `kopieer` deze regel:

```CSS
irm https://get.activated.win | iex
```

---
<br>

### Stap 4  
Plak het nu (met rechtermuisknop) en druk op enter. In het nieuw geopende venster zijn er verschillende opties beschikbaar, waarvan we optie `1` moeten selecteren en enkele seconden wachten tot het voltooid is.  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/0c3689a1-1595-40b3-97e2-041dac423237" width="540px">
</p>

<br>

#### Gefeliciteerd,
je Windows is geactiveerd.  
nu kun je op enter drukken om CMD te verlaten en PowerShell te sluiten en het Windows-activatiemenu te controleren [^3]

<br><br><br><br><br><br><br><br>

## Methode 2  
### Directe Windows-activering via CMD (Opdrachtprompt)

<br>

> [!NOTE]
> Vergeet niet **verbonden** te zijn met het **internet**
>
> VPN is **niet nodig**

<br>

### Stap 1  
Klik eerst op het start- of zoekpictogram en typ "CMD" in het zoekvak. Voer na het zien van de opdrachtprompt deze uit als **administrator**  
> andere makkelijke manieren: [^2].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/88ac970a-f24b-4acc-82c0-f8e7c0b05249" width="480px">
</p>  

---
<br>

### Hieronder staat de lijst met LICENTIESLEUTELS  

|            **Sleutel**            |  **Versie**     |
| :-------------------------------: | :-------------: |
| TX9XD-98N7V-6WMQ6-BX7FG-H8Q99     |      Home       |
| 3KHY7-WNT83-DGQKR-F7HPR-844BM     |     Home N      |
| 7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH     |  Home sl [^4]   |
| PVMJN-6DFY6–9CCP6–7BKTT-D3WVR     |  Home cs [^5]   |
| W269N-WFGWX-YVC9B-4J6C9-T83GX     |  Professional   |
| MH37W-N47XK-V7XM9-C7227-GCQG9     | Professional N  |
| NW6C2-QMPVW-D7KKK-3GKT6-VCFB2     |   Education     |
| 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ     |  Education N    |
| NPPR9-FWDCX-D2C8J-H872K-2YT43     |   Enterprise    |
| DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4     |  Enterprise N   |

![rainbow](https://github.com/NiREvil/vless/assets/126243832/1aca7f5d-6495-44b7-aced-072bae52f256)

<br>

### Stap 2  
Installeer de KMS client key.

Gebruik dit commando:

```CSS
slmgr /ipk yourlicensekey
```

> [!NOTE]
> Kies een van de **licentiesleutels** uit de lijst die **overeenkomt met jouw versie van Windows** en vervang deze door de term `yourlicencekey` in het commando.

> [!TIP]
> Hoe je de versie van Windows controleert [^3].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1b6401e6-7e63-4351-8a92-fa355dfc30cf" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/90037069-7ea3-44a8-a9fa-e296f5e8d47b" width="340px">
</p>  

---
<br>

### Stap 3  
Stel het KMS-machineadres in.

Gebruik het commando:

```CSS
slmgr /skms kms8.msguides.com
```

om verbinding te maken met mijn KMS-server.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9d634454-1c59-47da-874e-bfe575288fe6" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/2d2e6cfb-4e85-483f-ae0a-c7157d22da36" width="340px">
</p>  

---  
<br>

### Stap 4  
Activeer je Windows.
De laatste stap is om Windows te activeren met het commando:

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

### Stap 5  
Controleer nu opnieuw de activatiestatus [^6].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9ca70137-8e2e-4504-a52d-22f41d959bd7" width="480px">
</p>

#### Klaar ✅  
je Windows is succesvol geactiveerd.

<br>

**Wees nieuwsgierig 🤍**

[![Telegram](https://img.shields.io/badge/TELEGRAM-blue.svg?logo=telegram)](https://t.me/F_NiREvil) [![Twitter](https://img.shields.io/badge/TWITTER-blue.svg?logo=x)](https://twitter.com/NiREvil_)

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/25423296/163456776-7f95b81a-f1ed-45f7-b7ab-8fa810d529fa.png">
  <source media="(prefers-color-scheme: light)" srcset="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
  <img alt="Toont een geïllustreerde zon in de lichte modus en een maan met sterren in de donkere modus." src="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
</picture>

<br>

[^1]: [10 Manieren om PowerShell te starten in Windows](https://www.google.com/amp/s/www.minitool.com/news/open-windows-11-powershell.html%3famp)  

[^2]: Een andere makkelijke manier om PowerShell te starten: **Rechtsklik** op je Startmenu om het snelle linkmenu te openen en selecteer **Windows Terminal (admin)** in Windows 11 of **Windows PowerShell (admin)** in Windows 10 in de menulijst.
[^3]: Om de versie van je Windows te controleren: **Rechtsklik** op je Startmenu en selecteer de optie **systeem**. Je Windows-versie is te zien in het tweede gedeelte onder **Editie.** Je kunt ook de stappen van methode 2 volgen door ze te **kopiëren en plakken**. Kopieer de commando's en druk vervolgens op de **rechtermuisknop** in **cmd of powershell** om ze te plakken.
[^4]: Home Single Language versie.
[^5]: Home Country Specific versie.
[^6]: Om de activatiestatus van Windows te zien ga je naar:  
***Instellingen → Bijwerken & Beveiliging → activatiemenu.***

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---