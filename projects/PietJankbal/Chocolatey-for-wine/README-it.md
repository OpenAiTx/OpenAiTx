
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Chocolatey-for-wine

Chocolatey packagemanager installatore automatico in wine, utile per installare rapidamente programmi in wine (e successivamente trovare bug in wine ;) )  
Per alcuni bug sono state aggiunte soluzioni come per Visual Studio Community 2022 e nodejs, vedi più avanti.  

Durante il lock-down, annoiato, ho scritto un winetricks(.ps1) personalizzato con i comandi che trovo utili. Basta fare 'winetricks' per vedere quali sono.
Per alcuni comandi è necessario un riavvio completo di wine (a causa delle recenti modifiche di wine). Vedrai un messaggio e la sessione verrà terminata. Basta riavviare powershell e riprovare il comando. Se viene fatto una volta, non sarà più necessario per nessun comando.  

Esempio:

'winetricks vs22_interactiveinstaller'  ( --> la sessione verrà terminata)

eseguire 'wine powershell'

eseguire 'winetricks vs22_interactiveinstaller'

(Tra l'altro, tramite 'winetricks vs22_interactive_installer' puoi scegliere cosa installare tramite l’installer di Visual Studio 2022; 'winetricks vs22_interactive_installer' mi ha portato in dieci minuti al programma principale (ho selezionato Desktop development with C++)).

Installazione:
- Scarica e decomprimi il file zip della release ed esegui 'wine ChoCinstaller_0.5c.751.exe' (ci mette circa un minuto a completare)

Opzionale:
- Esegui l’installer come 'wine ChoCinstaller_0.5a.751.exe /s', quindi i file di installazione (come Powershell*.msi e dotnet48) vengono salvati in
  MyDocuments e non dovranno essere riscaricati se crei un nuovo prefisso)
Opzionale:
- Esegui l’installer come 'wine ChoCinstaller_0.5a.751.exe /q' per prevenire l’apertura automatica della finestra powershell (solo installazione).

Opzionale:
- Verifica se tutto è andato bene: "choco install chromium" e "start chrome.exe (--no-sandbox non più necessario da wine-8,4)"

![Screenshot from 2022-08-26 12-31-18](https://user-images.githubusercontent.com/26839562/186885380-d5a617c4-9cf4-4831-a475-2bd85a3b5784.png)
Informazioni su PowerShell:

Suggerimento: Chocolatey di solito installa l’ultima versione di un programma, che potrebbe rivelare nuovi bug di wine. Potresti avere più fortuna con una versione precedente del software.
Esempio:

choco search --exact microsoft-edge --all (--> elenca tutte le versioni)

choco install microsoft-edge --version --version='135.0.3179.98'

Informazioni generali:

- 'wine powershell.exe' avvia la console PowerShell-Core.

 
Informazioni su ConEmu:


La console ConEmu soffre di alcuni bug di wine:
  - Ctrl^C per uscire da un programma che non restituisce il controllo alla console non funziona. Usa invece Shift^Ctrl^C.
  - La selezione del testo nella finestra di ConEmu (per copiare/incollare) non evidenzia la selezione. È incluso un triste hack per le versioni recenti di wine che risolve questo problema, quindi ora l’evidenziazione dovrebbe funzionare.
   
Informazioni su winetricks(.ps1):

- Se non lo esegui ('winetricks' nella console powershell), non viene scaricato nulla, quindi nessun sovraccarico.
- Molti verbi (come powershell 5.1) necessitano di alcuni file essenziali per estrarre contenuti dai pacchetti msu. L’installazione di questi file essenziali richiede prima grandi download e molto tempo al primo utilizzo. Ma una volta che i file sono in cache, tutto è più veloce. Ad esempio, se provi 'winetricks ps51' per primo, ci vorranno circa 15 minuti. Altri verbi possono richiedere 5 minuti al primo utilizzo. Ma dopo il primo utilizzo, questo fastidio scompare.
- I file vengono memorizzati nella directory MyDocuments. Se esegui tutti i verbi, occuperanno circa 800 MB lì.
- Speriamo in un migliore supporto a 64 bit per vari verbi.
- Possibilità di estrarre un file e (provare a) installarlo da un file msu. Esegui 'winetricks install_dll_from_msu' per vedere come si fa.
- Una rudimentale Powershell 5.1.
- Installazione sperimentale di dotnet481 e dotnet35 (potrebbe essere necessario per app non soddisfatte dell’attuale installazione di dotnet48).
- Completamento automatico delle tab. Nota: usando più verbi dalla riga di comando, devono essere separati da una virgola
  da ora in poi (è così che powershell gestisce più argomenti)
  Quindi 'winetricks riched20 gdiplus' non funzionerà più, usa invece 'winetricks riched20,gdiplus'
- Alcuni programmi non si installano/eseguono tramite Chocolatey a causa di bug di wine. Ho aggiunto alcune soluzioni in winetricks per questi, vedi sotto.
- Verbi speciali (winetricks vs19, vs22 e vs22_interactive_installer) per installare Visual Studio Community 2019 e 2022 funzionanti (vedi screenshot, >10 min per installare e richiede circa 10GB!, dopo l’installazione avvia devenv.exe dalla directory c:\Program\ Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE/)
  ![screenshot](https://github.com/PietJankbal/Chocolatey-for-wine/assets/26839562/d576a619-c752-4eb1-81c2-6f6b66b50ff6)
- Verbo speciale per accedere a vari comandi unix come grep, sed, file, less, curl ecc. (winetricks git.portable, Disclaimer: alcuni comandi non funzionano ancora a causa di bug di wine
- Inclusi anche alcuni script powershell adattati da snippet trovati in rete:
    - Come incorporare un exe in uno script powershell tramite Invoke-ReflectivePEInjection (l’exe non apparirà in tasklist).
    - Come creare finestre di messaggio avanzate
    - Convertire uno script powershell (ps1) in un exe.
    - E qualche altro
 
     
Informazioni sui programmi di sistema:

È stata aggiunta una funzione per sostituire semplici programmi di sistema come ad esempio setx.exe con una funzione in
c:\\Program Files\Powershell\7\profile.ps1. Oppure aggiungere programmi di sistema mancanti come getmac.exe.
Se i programmi falliscono a causa di programmi di sistema non sufficientemente maturi o mancanti, si può scrivere una
funzione che restituisce ciò che il programma si aspetta.
Come in profile.ps1 ho aggiunto (tra gli altri) un wmic.exe che supporta un po’ più di opzioni,
e un setx.exe di base.
Oppure puoi semplicemente manipolare gli argomenti passati al programma di sistema. Vedi profile.ps1 e choc_install.ps1.
Nessuna garanzia che funzioni anche per programmi più complessi...
 
Note:

  - NON utilizzare su un wineprefix esistente, solo su un nuovo prefix appena creato! L'installer installa stupidamente dotnet48 da solo e modifica le chiavi di registro.
    Se hai già una versione di dotnet installata con il winetricks.sh regolare, probabilmente fallirà, e anche se dovesse riuscire, rischi di ritrovarti con un prefix danneggiato.
    Se devi installare software con il winetricks.sh regolare per i programmi, NON utilizzare nessuno dei verbi dotnet*.
    A proposito, i verbi 'Arial' e 'd3dcompiler_47' sono già installati di default.
  - WINEARCH=win32 _non_ è supportato!
  - L'aggiornamento da una versione precedente per ora non è (ancora) supportato, forse in futuro

Compilazione:
  - Se vuoi compilare tu stesso invece di scaricare i binari: consulta le istruzioni di compilazione in mainv1.c e installer.c 
  - Poi copia choc_install.ps1 nella stessa directory
  - Poi esegui 'wine ChoCinstaller_0.5a.735.exe'
  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-23

---