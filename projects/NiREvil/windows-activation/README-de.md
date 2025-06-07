# Sofortige Aktivierung von Windows 10 & 11: 40-Sekunden-Lösung

[![Readme](https://img.shields.io/badge/README_IN-فارسی-blue?logo=readme)](README-FA.md)  
[![Readme](https://img.shields.io/badge/README_IN-ENGLISH-blue?logo=readme)](README.md)

> Dieses Repository enthält eine Methode, mit der Sie Windows 10 und 11 in weniger als 40 Sekunden aktivieren können. Beide Methoden sind kompatibel mit Home, Home N, Home Single Language, Home Country Specific, Professional, Education und Enterprise Versionen von Windows.

## Methode 1 (empfohlen)  
### Sofortige Windows-Aktivierung mit PowerShell  
> [!TIPP]
> Es gibt viele Möglichkeiten, PowerShell in Windows 10 & 11 zu starten. [^1]

Eine der schnellsten Methoden, PowerShell in Windows zu öffnen, ist die Suche im Startmenü. Folgen Sie den untenstehenden Schritten:

<br>

### Schritt 1  
Sie müssen lediglich auf das Start- oder Suchsymbol klicken und „PowerShell“ in das Suchfeld eingeben.  
> Eine weitere einfache Methode: [^2]

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/5a10538a-c8c2-4934-868b-fd8e910f1f9e" width="540px">
</p>  

---
<br>

### Schritt 2  
Klicken Sie anschließend auf `Als Administrator ausführen`, um PowerShell mit **Administratorrechten** zu starten.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1f25dd2a-16db-4053-a45c-aac6f8a9e470" width="540px">
</p>

---
<br>

### Schritt 3  
Nach einer kurzen Pause zum Ausführen, bitte diese Zeile `kopieren`:

```CSS
irm https://get.activated.win | iex
```

---
<br>

### Schritt 4  
Fügen Sie diese Zeile nun (per Rechtsklick) ein und drücken Sie die Eingabetaste. Im neu geöffneten Fenster stehen mehrere Optionen zur Auswahl, aus denen wir die Option `1` wählen und einige Sekunden warten, bis der Vorgang abgeschlossen ist.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/0c3689a1-1595-40b3-97e2-041dac423237" width="540px">
</p>

<br>

#### Glückwunsch,
Ihr Windows wurde aktiviert.  
Sie können nun die Eingabetaste drücken, um die CMD zu verlassen und PowerShell zu schließen und das Windows-Aktivierungsmenü überprüfen [^3]

<br><br><br><br><br><br><br><br>

## Methode 2  
### Sofortige Windows-Aktivierung mit CMD (Eingabeaufforderung)

<br>

> [!HINWEIS]
> Denken Sie daran, eine **Verbindung** zum **Internet** herzustellen.
>
> VPN ist **nicht erforderlich**

<br>

### Schritt 1  
Klicken Sie zuerst auf das Start- oder Suchsymbol und geben Sie „CMD“ in das Suchfeld ein. Nach dem Anzeigen der Option „Eingabeaufforderung“ führen Sie diese als **Administrator** aus.  
> Weitere einfache Methoden: [^2].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/88ac970a-f24b-4acc-82c0-f8e7c0b05249" width="480px">
</p>  

---
<br>

### Die folgende Liste enthält LIZENZSCHLÜSSEL  

|            **Key**            |  **Version**   |
| :---------------------------: | :------------: |
| TX9XD-98N7V-6WMQ6-BX7FG-H8Q99 |      Home      |
| 3KHY7-WNT83-DGQKR-F7HPR-844BM |     Home N     |
| 7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH |  Home sl [^4]  |
| PVMJN-6DFY6–9CCP6–7BKTT-D3WVR |  Home cs [^5]  |
| W269N-WFGWX-YVC9B-4J6C9-T83GX |  Professional  |
| MH37W-N47XK-V7XM9-C7227-GCQG9 | Professional N |
| NW6C2-QMPVW-D7KKK-3GKT6-VCFB2 |   Education    |
| 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ |  Education N   |
| NPPR9-FWDCX-D2C8J-H872K-2YT43 |   Enterprise   |
| DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4 |  Enterprise N  |

![rainbow](https://github.com/NiREvil/vless/assets/126243832/1aca7f5d-6495-44b7-aced-072bae52f256)

<br>

### Schritt 2  
Installieren Sie den KMS-Clientschlüssel.

Verwenden Sie diesen Befehl:

```CSS
slmgr /ipk yourlicensekey
```

> [!HINWEIS]
> Bitte wählen Sie einen der **Lizenzschlüssel** aus der Liste, der **zu Ihrer Windows-Version passt**, und ersetzen Sie ihn durch den Ausdruck `yourlicencekey` im Befehl.

> [!TIPP]
> So prüfen Sie die Windows-Version [^3].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1b6401e6-7e63-4351-8a92-fa355dfc30cf" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/90037069-7ea3-44a8-a9fa-e296f5e8d47b" width="340px">
</p>  

---
<br>

### Schritt 3  
Setzen Sie die KMS-Serveradresse.

Verwenden Sie den Befehl:

```CSS
slmgr /skms kms8.msguides.com
```

um sich mit meinem KMS-Server zu verbinden.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9d634454-1c59-47da-874e-bfe575288fe6" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/2d2e6cfb-4e85-483f-ae0a-c7157d22da36" width="340px">
</p>  

---  
<br>

### Schritt 4  
Aktivieren Sie Ihr Windows.
Der letzte Schritt ist die Aktivierung Ihres Windows mit folgendem Befehl:

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

### Schritt 5  
Überprüfen Sie nun erneut den Aktivierungsstatus [^6].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9ca70137-8e2e-4504-a52d-22f41d959bd7" width="480px">
</p>

#### Fertig ✅  
Ihr Windows wurde erfolgreich aktiviert.

<br>

**Seien Sie neugierig 🤍**

[![Telegram](https://img.shields.io/badge/TELEGRAM-blue.svg?logo=telegram)](https://t.me/F_NiREvil) [![Twitter](https://img.shields.io/badge/TWITTER-blue.svg?logo=x)](https://twitter.com/NiREvil_)

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/25423296/163456776-7f95b81a-f1ed-45f7-b7ab-8fa810d529fa.png">
  <source media="(prefers-color-scheme: light)" srcset="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
  <img alt="Zeigt eine illustrierte Sonne im Light-Mode und einen Mond mit Sternen im Dark-Mode." src="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
</picture>

<br>

[^1]: [10 Wege, PowerShell in Windows zu starten](https://www.google.com/amp/s/www.minitool.com/news/open-windows-11-powershell.html%3famp)  

[^2]: Eine weitere einfachste Möglichkeit, PowerShell zu starten: **Rechtsklick** auf das Startmenü, um das Schnellzugriffsmenü zu öffnen und **Windows Terminal (Admin)** unter Windows 11 oder **Windows PowerShell (Admin)** unter Windows 10 auszuwählen.
[^3]: Um Ihre Windows-Version zu überprüfen: **Rechtsklick** auf das Startmenü und **System** auswählen. Ihre Windows-Version finden Sie im zweiten Abschnitt unter **Edition.** Sie können die Schritte aus Methode 2 auch durch **Kopieren und Einfügen** ausführen. Kopieren Sie die Befehle und fügen Sie sie mit **Rechtsklick** in **CMD oder PowerShell** ein.
[^4]: Home Single Language Version.
[^5]: Home Country Specific Version.
[^6]: Um den Windows-Aktivierungsstatus zu sehen, gehen Sie zu:  
***Einstellungen → Update & Sicherheit → Aktivierungsmenü.***

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---