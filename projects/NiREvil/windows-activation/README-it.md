# Attivazione Istantanea di Windows 10 & 11: Soluzione in 40 Secondi

[![Readme](https://img.shields.io/badge/README_IN-فارسی-blue?logo=readme)](README-FA.md)  
[![Readme](https://img.shields.io/badge/README_IN-ENGLISH-blue?logo=readme)](README.md)

> Questo repository contiene un metodo che può attivare Windows 10 e 11 in meno di 40 secondi. Entrambi i metodi sono compatibili con le versioni home, home N, home single language, home country specific, professional, education ed enterprise di Windows.

## Metodo 1 (consigliato)  
### Attivazione istantanea di Windows tramite (PowerShell)  
> [!TIP]
> Esistono molti modi per avviare PowerShell in Windows 10 e 11. [^1]

Uno dei modi più veloci per aprire PowerShell in Windows è tramite la ricerca nel menu Start. Segui i passaggi seguenti:

<br>

### Passaggio 1  
Tutto ciò che devi fare è cliccare sull’icona start o sulla lente di ricerca e digitare "PowerShell" nella casella di ricerca.  
> Un altro modo semplice: [^2]

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/5a10538a-c8c2-4934-868b-fd8e910f1f9e" width="540px">
</p>  

---
<br>

### Passaggio 2  
Successivamente, devi cliccare su `Esegui come amministratore` per avviare PowerShell, in questo caso è necessario eseguirlo con **privilegi amministrativi**.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1f25dd2a-16db-4053-a45c-aac6f8a9e470" width="540px">
</p>

---
<br>

### Passaggio 3  
Ora, dopo una breve pausa per consentire l’esecuzione, per favore `copia` questa riga:

```CSS
irm https://get.activated.win | iex
```

---
<br>

### Passaggio 4  
Ora incollala (con il tasto destro) e premi invio. Nella nuova finestra che si apre, ci sono diverse opzioni disponibili, tra cui dobbiamo selezionare l’opzione `1` e attendere qualche secondo per il completamento.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/0c3689a1-1595-40b3-97e2-041dac423237" width="540px">
</p>

<br>

#### Congratulazioni,
il tuo Windows è stato attivato.  
ora puoi premere il tasto invio per uscire dal CMD e chiudere PowerShell e controllare il menu Attivazione di Windows [^3]

<br><br><br><br><br><br><br><br>

## Metodo 2  
### Attivazione istantanea di Windows tramite CMD (Prompt dei comandi)

<br>

> [!NOTE]
> Ricorda di **connetterti** a **Internet**
>
> La VPN **non è necessaria**

<br>

### Passaggio 1  
Per prima cosa, clicca sull’icona start o sulla lente di ricerca e digita "CMD" nella casella di ricerca. Dopo aver visualizzato l’opzione prompt dei comandi, eseguilo come **amministratore**  
> altri modi semplici: [^2].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/88ac970a-f24b-4acc-82c0-f8e7c0b05249" width="480px">
</p>  

---
<br>

### Di seguito è riportato l'elenco delle CHIAVI DI LICENZA  

|            **Key**            |  **Versione**   |
| :---------------------------: | :-------------: |
| TX9XD-98N7V-6WMQ6-BX7FG-H8Q99 |      Home       |
| 3KHY7-WNT83-DGQKR-F7HPR-844BM |     Home N      |
| 7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH | Home sl [^4]    |
| PVMJN-6DFY6–9CCP6–7BKTT-D3WVR | Home cs [^5]    |
| W269N-WFGWX-YVC9B-4J6C9-T83GX |  Professional   |
| MH37W-N47XK-V7XM9-C7227-GCQG9 | Professional N  |
| NW6C2-QMPVW-D7KKK-3GKT6-VCFB2 |   Education     |
| 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ |  Education N    |
| NPPR9-FWDCX-D2C8J-H872K-2YT43 |   Enterprise    |
| DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4 |  Enterprise N   |

![rainbow](https://github.com/NiREvil/vless/assets/126243832/1aca7f5d-6495-44b7-aced-072bae52f256)

<br>

### Passaggio 2  
Installa la chiave client KMS.

Usa questo comando:

```CSS
slmgr /ipk yourlicensekey
```

> [!NOTE]
> Seleziona una delle **chiavi di licenza** dalla lista che **corrisponde alla tua versione di Windows** e sostituiscila alla frase `yourlicencekey` nel comando.

> [!TIP]
> Come controllare la versione di Windows [^3].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1b6401e6-7e63-4351-8a92-fa355dfc30cf" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/90037069-7ea3-44a8-a9fa-e296f5e8d47b" width="340px">
</p>  

---
<br>

### Passaggio 3  
Imposta l’indirizzo della macchina KMS.

Usa il comando:

```CSS
slmgr /skms kms8.msguides.com
```

per connetterti al mio server KMS.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9d634454-1c59-47da-874e-bfe575288fe6" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/2d2e6cfb-4e85-483f-ae0a-c7157d22da36" width="340px">
</p>  

---  
<br>

### Passaggio 4  
Attiva il tuo Windows.
L’ultimo passaggio è attivare Windows utilizzando il comando:

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

### Passaggio 5  
Ora controlla di nuovo lo stato di attivazione [^6].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9ca70137-8e2e-4504-a52d-22f41d959bd7" width="480px">
</p>

#### Fatto ✅  
il tuo Windows è stato attivato con successo.

<br>

**Sii curioso 🤍**

[![Telegram](https://img.shields.io/badge/TELEGRAM-blue.svg?logo=telegram)](https://t.me/F_NiREvil) [![Twitter](https://img.shields.io/badge/TWITTER-blue.svg?logo=x)](https://twitter.com/NiREvil_)

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/25423296/163456776-7f95b81a-f1ed-45f7-b7ab-8fa810d529fa.png">
  <source media="(prefers-color-scheme: light)" srcset="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
  <img alt="Shows an illustrated sun in light mode and a moon with stars in dark mode." src="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
</picture>

<br>

[^1]: [10 modi per eseguire PowerShell in Windows](https://www.google.com/amp/s/www.minitool.com/news/open-windows-11-powershell.html%3famp)  

[^2]: Un altro modo semplicissimo per eseguire PowerShell: **Clic destro** sul menu Start per aprire il menu rapido e selezionare **Windows Terminal (admin)** su win11 o **Windows powershell (admin)** su win10 nell’elenco.
[^3]: Per controllare la versione di Windows: **Clic destro** sul menu Start e seleziona l’opzione **sistema**. La versione di Windows è visibile nella seconda sezione sotto **Edizione.** Puoi anche seguire i passaggi del metodo 2 **copiandoli e incollandoli**. Copia i comandi e poi premi **clic destro** in **cmd o powershell** per incollarli.
[^4]: Versione Home Single language.
[^5]: Versione Home Country Specific.
[^6]: Per vedere lo stato di attivazione di Windows devi andare su:  
***Impostazioni → Aggiornamento e sicurezza → menu attivazione.***

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---