## ***DISCLAIMER***

Non sono **responsabile** per qualsiasi uso improprio, abuso o azione non etica compiuta con gli strumenti o i metodi elencati in questo documento. **OSINT è una tecnica neutrale**—chiunque può usarla e chiunque può esserne un bersaglio.

Nota: Alcuni domini (es. `exposed.lol`) potrebbero essere scaduti. Fare riferimento all'elenco curato o ai link alternativi forniti.

## Suggerimenti

Apri una [issue](https://github.com/airborne-commando/OPSEC-OSINT-Tools/issues) per suggerimenti o feedback.

## Perché?

Le persone si fidano troppo di Internet. Nel mondo di oggi, online e offline sono praticamente la stessa cosa—la verità e la finzione si confondono. Questo README esiste per sensibilizzare. Clonalo, forkalo, remixalo o trasformalo anche in una pagina [Rentry](https://rentry.co/). Diffondi la conoscenza come preferisci.

Puoi prevedere il comportamento di qualcuno con questi strumenti? Non esattamente; le persone sono imprevedibili a volte.

# Strumenti OSINT/OPSEC

Un elenco di strumenti OSINT/OPSEC che ho creato, forkato e/o utilizzo. Prima, parliamo delle definizioni.

## Indice
1. [OPSEC](#operations-security-is-a-systematic-process-for)
   - [Come fare OPSEC](#how-to-opsec)
      - [Smoke Screen e disinformazione](#Smoke-Screen-and-misinfo) 
2. [Open Source Intelligence (OSINT)](#open-source-intelligence-osint)
3. [Chi usa l’Open-Source Intelligence (OSINT)?](#who-uses-open-source-intelligence-osint)
4. [Fonti OSINT](#sources-of-osint)
5. [Profilazione OSINT](#digital-profiling-osint-profiling)
6. [Closed sourced](#closed-sourced-info)
7. [Esempi reali di OSINT](#real-world-examples-of-osint)
   - [Coordinamento attacco aereo 2016](#in-the-year-2016-a-basket-weaving-image-board-used-osint-to-pay-some-supposed-terrorist-a-vist-from-a-govt-in-russia-resulting-in-airstrikes)
   - [Protesta Shia LaBeouf 2017](#in-2017-shia-labeouf-had-a-protest-due-to-trumps-election-this-resulted-in-a-basket-weaving-image-board-using-osint-and-sky-patterns-to-figure-out-where-a-flag-is)
8. [Strumenti](#tools)
      - [Raccomandazioni Toolchain](#toolchain-recommendations)
9. [Strumenti ricerca persone (USA)](#people-search-tools-in-the-states)
10. [Letteratura grigia](#grey-literature)
11. [Dati violati](#breached-data)
12. [Social Media](#social-media)
13. [Self OSINT](#toolchain-self-osint)
14. [Liste curate](#curated-lists)
16. [Strumenti archivio](#archive-tools-that-ive-made)

## (Operations Security) è un processo sistematico per:
1. Identificare
2. Proteggere e controllare informazioni critiche

È una disciplina di sicurezza e una funzione operativa che implica un ciclo continuo di:
* Identificazione di informazioni e indicatori critici (CII)
  * Le informazioni critiche e gli indicatori sono componenti essenziali dell’Operations Security, mirate a proteggere i dati sensibili che potrebbero essere sfruttati dagli avversari. Le informazioni critiche includono dati non classificati o controllati sulle attività, intenzioni, capacità o limitazioni che gli avversari possono usare per ottenere un vantaggio. Gli indicatori sono azioni osservabili o informazioni che rivelano dettagli critici sulle operazioni, come cambiamenti improvvisi nelle procedure o misure di sicurezza aumentate. Proteggere queste informazioni implica identificare vulnerabilità e implementare contromisure per prevenire divulgazioni non autorizzate.
* Analisi delle potenziali minacce e vulnerabilità
* Valutazione dei rischi
* Sviluppo di contromisure per proteggere le CII

Viene usato per proteggere informazioni e attività dagli avversari. Aiuta a identificare e proteggere informazioni sensibili che potrebbero dare un vantaggio all’avversario. I principi OPSEC possono essere applicati nella vita quotidiana, come non condividere informazioni personali tipo data di nascita, indirizzo, email, numero di telefono.

**Esempi di errori OPSEC includono:**
* Condivisione eccessiva di informazioni personali online
   * [Chris Chan](https://www.youtube.com/playlist?list=PLABqEYq6H3vpCmsmyUnHnfMOeAnjBdSNm)
   * [suspectAGB](https://opsecfail.github.io/blog.html?filecase=suspectAGB)

* Lasciare social media inutilizzati online
* Interagire con un target sui social media
   * [w0rmer](https://opsecfail.github.io/blog.html?filecase=w0rmer)
   * [darknetdiaries](https://darknetdiaries.com/transcript/63/)

* [Esempi di buon e cattivo OPSEC e un po' di OSINT.](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/examples.md)

OPSEC integra altre discipline di sicurezza, non le sostituisce.

### Come fare OPSEC:

* **Usa servizi che possono nascondere la tua identità:**
---

| **Categoria**               | **Strumento/Tecnica**       | **Descrizione**                                                                 | **Pro**                                      | **Contro/Limiti**                          |
|---------------------------|-------------------------|-------------------------------------------------------------------------------|---------------------------------------------|---------------------------------------------|
| **Messaggistica Crittografata**   | [Telegram](https://telegram.org/)                | Messaggistica cloud con E2E opzionale ("Secret Chats")                      | Diffuso, ricco di funzioni               | Non E2E di default; dati su server; richiede numero di telefono |
|                            | [Simplex](https://simplex.chat/)                 | Nessun identificatore utente (nemmeno numeri casuali)                                 | Massima privacy dei metadati                   | Meno user-friendly; rete più piccola         |
|                            | [Signal](https://signal.org/download/)                  | Crittografia E2E di default; minima conservazione metadati                         | Standard oro per la privacy; resistente in tribunale | Richiede numero di telefono                       |
| **Reti di anonimato**    | [Tor](https://www.torproject.org/)                     | Traffico instradato su nodi criptati per nascondere IP                             | Gratis; robusto contro il tracciamento              | Lento; frequenti CAPTCHA                     |
|                            | [Mullvad VPN](https://mullvad.net/en)             | VPN no-log che accetta pagamenti Monero (XMR)                                   | Forte privacy; pagamenti anonimi  | Le VPN non correggono cattive abitudini OPSEC            |
| **Criptovalute**        | [Monero (XMR)](https://www.getmonero.org/)            | Criptovaluta non tracciabile                                                   | Transazioni private                       | Richiede mining/nodo locale per anonimato completo + tempo |
| **Gestione identità**   | Username unici        | Usa credenziali diverse per ogni sito                                           | Previene attacchi di correlazione               | Difficile da gestire senza password manager   |
|                            | Parafrasi testuale           | Riformula testi per evitare il rilevamento                                           | Elude plagio/collegamenti identità        | Può sembrare innaturale                         |
|                            | Volti AI generati      | Foto profilo false (es. ThisPersonDoesNotExist.com)                     | Nasconde identità reale                        | Può sembrare innaturale               |
| **Self-OSINT**           | Guide opt-out          | Rimuovi dati personali dai siti di ricerca persone                                | Riduce impronta digitale                 | Lento; non tutti i siti accolgono richieste senza pagamento |
| **Risorse OPSEC**      | Esempi di cattivo OPSEC      | [Lista errori](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/badopsec.md) | Impara dagli errori altrui               | N/A                                        |
|                            | Buone pratiche OPSEC    | [Linee guida](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/good-opsec.md) | Consigli pratici                          | Serve disciplina                         |
| **Liste strumenti**           | Strumenti OPSEC             | [Lista curata](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/opsec.md) | Risorsa completa                   | Può necessitare aggiornamenti                            |

---

### **Punti chiave**  
1. **Messaggistica**:  
   - **Signal** O **Simplex** > **Telegram** per la privacy.  

   - Ricorda: E2E ≠ anonimato totale (i metadati e le abitudini contano).


2. **Anonimato**:  
   - **Tor** + **Mullvad VPN** + **XMR** = protezione a livelli.  
   - Evita di accedere ad account personali usando questi strumenti.
   - Nota: usa TOR e Mullvad separatamente per massima anonimizzazione, usa una [Virtual Machine](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/opsec.md#virtualization) per le VPN e TOR su un’altra (o sull’host).

3. **Identità**:  
   - **Username unici** + **volti AI** + **parafrasi** = più difficile da tracciare.  

4. **Auto-verifica**:  
   - **Opt-out** regolari dai data broker e **OSINT su te stesso**.  

5. **Mentalità OPSEC**:  
   - Segui **[buon OPSEC](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/good-opsec.md)** ed evita **[cattive abitudini](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/badopsec.md)**.


**Nota**:

TOR si riferisce al Tor Browser, VPN come Virtual Private Network (Mullvad; ma vanno bene anche altri tipi di VPN se sicuri e approvati da esperti di privacy); XMR è Monero, una privacy coin.

Consulta Wikipedia se hai dubbi:
1. [VPN](https://it.wikipedia.org/wiki/Virtual_private_network)
   - [Servizio VPN](https://en.wikipedia.org/wiki/VPN_service)
2. [TOR](https://it.wikipedia.org/wiki/Tor_(rete))
3. [XMR](https://it.wikipedia.org/wiki/Monero)

--- 

### **Pro Tips**  
- **Signal workaround**: Usa un numero temporaneo (es. Google Voice) per la registrazione.    
- **Monero mining**: Esegui un nodo locale per evitare che gli exchange centralizzati traccino gli acquisti.  

Per tutti i dettagli sugli strumenti, consulta la **[Lista strumenti OPSEC](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/opsec.md)**.

## Smoke Screen e disinformazione

Un’operazione smoke screen nel contesto OSINT (Open Source Intelligence) si riferisce ad azioni deliberate per oscurare, depistare o mascherare le vere attività, intenzioni o identità di individui o organizzazioni da chi effettua raccolta OSINT. Il termine deriva da tattiche militari dove si usa una cortina fumogena per nascondere movimenti o posizioni all’osservazione nemica. Nel cyber e nell’intelligence il concetto è adattato ad ambienti digitali e informativi. Puoi leggere di più [qui](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/smokescreen-misinfo.md).

## Open Source Intelligence (OSINT)

**<div align="center">Cos’è, come viene usata e perché è importante:</div>**

- OSINT è la pratica di raccogliere e analizzare informazioni da fonti pubbliche per rispondere a specifiche esigenze di intelligence. OSINT viene usata da agenzie governative e organizzazioni commerciali per vari scopi, tra cui:

  - Ricognizione
  - Investigazioni su crimini informatici
  - Analisi delle tendenze di mercato
  - Analisi del posizionamento del brand
  - Valutazione del rischio per un’organizzazione
  - Comprendere attori, tattiche e obiettivi
  - Raccolta di informazioni in tempo reale
  - Prendere decisioni informate
  - Ricevere avvisi precoci su potenziali minacce

## Chi usa l’Open-Source Intelligence (OSINT)?

- Agenzie di sicurezza nazionale e intelligence, Forze dell’ordine, Aziende, Gruppi di cybersecurity/crimini informatici, Persone attente alla privacy, ONG

  - La CIA, Defense Intelligence Agency (DIA) e Office of the Director of National Intelligence (ODNI) usano tutti OSINT.
  - OSINT può proteggere i cittadini (privati o meno) da furti d’identità, violenza sessuale e abusi.
  - OSINT può monitorare concorrenti, esplorare nuovi mercati, pianificare attività di marketing.
  - OSINT può raccogliere intelligence su target specifici online.
  - OSINT può testare la vulnerabilità dei dispositivi informatici.
  - OSINT può essere utilizzato su sé stessi per aumentare la privacy.
  - Bellingcat, Center for Information Resilience e Oryx usano OSINT.
  - E anche tu! Sì, puoi usare OSINT.

## Fonti OSINT
OSINT può raccogliere informazioni da varie fonti, tra cui:
- [Dati pubblici governativi](https://www.opendatasoft.com/en/glossary/public-data/)

  - I dati pubblici sono tutte le informazioni rese disponibili gratuitamente da enti pubblici o autorità locali. Questi dati sono di dominio pubblico. Si distinguono dai dati open, che sono una sotto-categoria, più strutturata e di facile accesso. I dati pubblici possono essere difficili da trovare, o (nel caso di enti pubblici), richiedere la richiesta FOIA.

- [Pubblicazioni professionali e accademiche](https://www.lawinsider.com/dictionary/academic-publication)

  - Pubblicazione accademica significa la pubblicazione di abstract, articoli o paper su riviste scientifiche o repository elettronici, o la presentazione a conferenze o seminari.


- [Dati commerciali](https://www.lawinsider.com/dictionary/commercial-data)

  - Dati commerciali significa qualsiasi informazione relativa a una persona identificata o identificabile (che l’informazione sia accurata o meno), anche combinata con altri dati, ed è o era cliente effettivo o potenziale di, o consumatore di prodotti/servizi offerti dall’azienda.

- [Letteratura grigia](https://browse.welch.jhmi.edu/c.php?g=1195274)

  - La letteratura grigia è “Informazione prodotta a tutti i livelli di governo, accademia, affari e industria, in formato elettronico e cartaceo, non controllata dall’editoria commerciale, cioè dove la pubblicazione non è l’attività primaria del produttore”.
   
  - La letteratura grigia può essere utile per la ricerca, ma trovare risorse richiede tattiche diverse rispetto ai materiali pubblicati commercialmente. Molte tipologie non sono indicizzate nei principali strumenti di ricerca.

### Esempi reali di OSINT

## Nel 2016, un imageboard ha usato OSINT per far ricevere a presunti terroristi una visita da [un governo in Russia, con conseguenti attacchi aerei.](https://imgur.com/pol-helps-coordinate-airstrike-on-moderate-syrian-rebels-N7DwWP1)

- [Un video che dettaglia gli eventi](https://www.youtube.com/watch?v=OR6epSP_Xlw)

  - Nel 2016, durante la complessa guerra civile siriana, vari gruppi ribelli—alcuni con buone intenzioni e altri no—cercavano di rovesciare Assad. Il caos ha permesso ai gruppi terroristici di prosperare, portando all’intervento USA e Russia. Un utente anonimo su 4chan (Syria General board) ha affermato che un gruppo ribelle, Jaysh al-Izza, ha pubblicato un video su YouTube rivelando il loro accampamento segreto. Il gruppo, collegato ad Al-Qaeda, è stato visto come target dagli utenti. Un utente, Ivan Sirenko, con legami militari russi, ha ricevuto le coordinate dalla community e le ha inviate al Ministero della Difesa russo. Questo ha portato a un attacco aereo. Due mesi dopo, lo stesso gruppo ha pubblicato un altro video e 4chan ha nuovamente localizzato la posizione, portando a un altro attacco.

UPDATE: Era una guerra molto complessa e 4chan ci si è infilato, ma resta un esempio chiave; il problema principale è che hanno esposto le posizioni di addestramento in rete, segno di cattivo OPSEC.

## Nel 2017, Shia LaBeouf ha protestato per l’elezione di Trump; questo ha portato un imageboard a usare OSINT e [schemi celesti per trovare la posizione di una bandiera.](https://www.vice.com/en/article/4chan-does-first-good-thing-pulls-off-the-heist-of-the-century1/)

- Nel 2017, utenti di 4chan hanno rintracciato e sostituito la bandiera della protesta “He Will Not Divide Us” di Shia LaBeouf. Usando solo lo streaming live della bandiera, hanno analizzato rotte aeree, stelle e un tweet per localizzare la bandiera a Greeneville, Tennessee. Un troll locale ha suonato il clacson finché il suono non è stato rilevato dallo streaming, individuando la posizione esatta. La bandiera è stata sostituita con un cappello di Trump, fine dell’operazione di trolling.

## Profilazione digitale (profilazione OSINT)

La profilazione digitale e l’analisi comportamentale sono tecniche potenti per comprendere individui in base alle attività online e alle impronte digitali. Questi metodi sono spesso usati da professionisti, ma puoi applicare molti degli stessi principi seguendo un approccio strutturato.

Leggi di più in questo readme su [profilazione OSINT](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/OSINT-profiling.md)

## Informazioni Closed Source

- [HUMINT](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/HUMINT.md)

**L’HUMINT può essere raccolta in modo palese (interviste, debriefing, rapporti diplomatici) o segreto (spionaggio, sorveglianza clandestina).**

**Comprare da data broker può essere closed source se l’informazione non è liberamente disponibile, SE non viene incrociata tramite le [liste curate](#curated-lists) O la [toolchain](#toolchain-self-osint) per il self OSINT.**

## Strumenti

---

| **Categoria**               | **Strumento**                  | **Link**                                                                 | **Funzionalità**                                                                 | **Limitazioni/Note**                                                                 |
|----------------------------|--------------------------|-------------------------------------------------------------------------|---------------------------------------------------------------------------------|-------------------------------------------------------------------------------------|
| **Query motori di ricerca**  | Google-FU                | [GitHub](https://github.com/airborne-commando/GoogleFU-improved)        | Google dorking avanzato per ricerche mirate                                  | Limitazioni di frequenza; possibili CAPTCHA                                              |
| **Analisi biometrica**     | Facecheck.ID             | [GitHub](https://github.com/vin3110/facecheck.id-results-extractor)     | Ricerca immagini inversa bypassando paywall                                        | Richiede Tampermonkey; estrae solo i link                                   |
| **Ricerca username/email**  | Blackbird                | [GitHub](https://github.com/p1ngul1n0/blackbird)                       | Ricerca veloce cross-platform di username/email                                      | Solo CLI; leggero                                                               |
|                            | Crow (GUI per Blackbird) | [GitHub](https://github.com/airborne-commando/crow)                     | GUI per Blackbird                                                       | Stesse funzionalità della CLI                                                           |
|                            | Sherlock                 | [GitHub](https://github.com/sherlock-project/sherlock)                  | Ricerca username su 300+ siti                                | Falsi positivi (es. Imgur); basato su CLI                                            |
|                            | No-Shit-Sherlock (GUI)   | [GitHub](https://github.com/airborne-commando/no-shit-sherlock)         | GUI per Sherlock                                                       | Stesse limitazioni di Sherlock                                                     |
|                            | Maigret                  | [GitHub](https://github.com/soxoj/maigret)                              | Trova collegamenti username (fork di Sherlock)                                     | Si concentra sui link profilo                                                         |
|                            | Maigret-Night (GUI)      | [GitHub](https://github.com/airborne-commando/maigret-night)            | GUI per Maigret                                                                | Come la CLI Maigret                                                                 |
|                            | Holehe                   | [GitHub](https://github.com/megadose/holehe)                            | Verifica utilizzo email su vari siti                                                | Falsi positivi Imgur; solo CLI                                                    |
| **Email compromesse**      | Hudson Rock Extractor    | [GitHub](https://github.com/airborne-commando/hudsonrock-search-extractor)| Verifica manuale email violate (Flask)                                     | Non automatizzato; input manuale                                                |
| **Geolocalizzazione**            | Google Maps              | [maps.google.com](https://maps.google.com/)                             | Individua luoghi/confronta punti di riferimento                                           | Solo dati pubblici; nessuna funzione OSINT avanzata                                        |
| **OSINT generalizzato**      | OSINT Rocks              | [osint.rocks](https://osint.rocks/)                                     | Multi-tool: Hudson Rock, Holehe, GHunt (Gmail), ricerca telefono/dominio/username  | Web; combina più strumenti                                 |

---

### **Insight chiave & Pro Tips**

1. **Falsi positivi**:  
   - **Sherlock/Holehe**: Imgur restituisce spesso risultati fuorvianti—verifica manualmente.  
   - **Facecheck.ID**: Estrae link ma non analizza immagini; incrocia con [Pimeyes (10 ricerche)](https://pimeyes.com/en) o altri elencati al punto 6.  

2. **GUI vs. CLI**:  
   - **CLI (Blackbird, Sherlock, Maigret)**: Più veloci ma richiedono familiarità tecnica.  
   - **GUI (Crow, No-Shit-Sherlock)**: Più semplici per i principianti; stessa logica backend.  

3. **Indagini email**:  
   - Combina **Holehe** (individua account) + **Hudson Rock Extractor** (dati violati) per controllo approfondito; vedi [**Toolchain Recommendations**](#Toolchain-Recommendations).  
   - Per OSINT su Gmail, usa **GHunt** (tramite OSINT Rocks).  

4. **Geolocalizzazione**:  
   - Usa **Google Maps Street View** per verificare indirizzi/punti di riferimento da altri strumenti (es. ClustrMaps).  

5. **Note OPSEC**:  
   - **Rate limit**: Strumenti come Google-FU possono essere bloccati—usa proxy/VPN.  
   - **Legalità**: Evita scraping di dati privati (es. Facebook pro) senza consenso.  

6. **Analisi biometrica**: Puoi integrare la tua analisi biometrica con questi strumenti estraendo i risultati da:
 - faceonlive.com (limite 3 o 4 ricerche, può servire TOR)
 - lenso.ai 

Poi apri l’immagine in una nuova scheda e salvala o trascinala su facecheck.id per il confronto (come da step 1)

---

### **Raccomandazioni Toolchain**
- **Ricerca username veloce**: Crow (GUI per approfondita) → Maigret (GUI per approfondita) → Sherlock (CLI per profondità).  
- **Email violate**: Have I Been Pwned → Pentester (quasi gratis) → OSINT Rocks (Hudson Rock/Holehe) → LOLArchiver.  
- **Immagini**: Facecheck.ID → Pimeyes → lenso.ai → faceonlive  
- **File**: Dischi criptati (LUKS) → veracrypt → keepassxc

Nota su Pentester: fornisce risultati gratis su username, ecc., ma a tempo; non vale la pena acquistare se si è attenti e si tengono record (snapshot).

Nota: Per keepassxc è consigliato usare una password forte o una YubiKey (security key hardware).
Puoi creare anche due database: uno con la password che ricordi; l’altro con quella generata per file sensibili.

Per strumenti di nicchia, consulta la sezione [Liste curate](#curated-lists).

Pipeline discussa [qui](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/opsec.md#opsec-pipeline-for-secure-files)
    
## Strumenti ricerca persone (USA):

**DISCLAIMER: La maggior parte delle email trovate su questi siti deriva da una vecchia data breach; i soggetti possono ancora usare le email trovate poiché raramente si cambia provider (TFA + password manager), a meno che l’email stessa sia stata compromessa o cambiata per molestie, spam, ecc.**

---

| **Strumento**               | **Cerca per**                | **Restituisce**                              | **Note**                                                                 |
|------------------------|-----------------------------|------------------------------------------|---------------------------------------------------------------------------|
| **[FastPeopleSearch](https://www.fastpeoplesearch.com/)**   | Nome, Telefono, Indirizzo        | Età, Indirizzo, Telefono, Email               | Gratis; dati possibili obsoleti.                                               |
| **[That's Them](https://thatsthem.com/)**        | Nome, Email, IP, VIN, Telefono | IP, Indirizzi, Telefono, Email              | Aggrega dati da Intelius/Spokeo; alcuni risultati a pagamento.                 |
| **[Nuwber](https://nuwber.com/)**            | Nome, Telefono, Email, Indirizzo | DOB, Indirizzo, Email, Telefono               | Report dettagliati potrebbero essere a pagamento.                                    |
| **[IDCrawl](https://idcrawl.com/)**           | Nome, Username, Telefono, Email | Nomi, Username, Telefono, Email           | Si concentra su username/social.                                       |
| **[PeekYou](https://www.peekyou.com/)**           | Nome, Username, Stato       | Età, Social Media, Email, Indirizzi     | Forte per la profilazione social.                                       |
| **[Webmii](https://webmii.com/)**            | Nome e Cognome           | Social, Risultati ricerca             | Leggero; scansiona web/social pubblici.                           |
| **[PublicRecords](https://www.publicrecords.onlinesearches.com/)**     | Nome, Indirizzo, Stato        | Nome, Indirizzo, Telefono parziale             | Directory gratuita; rimanda a Intelius per dettagli a pagamento.                  |
| **[ClustrMaps](https://clustrmaps.com/)**        | Nome, Indirizzo               | Indirizzi, Residenti, Proprietà, IP  | Si concentra su geolocalizzazione/demografia; può includere cronologia proprietà.      |
| **[fastbackgroundcheck](https://www.fastbackgroundcheck.com)** | Nome, Indirizzo, Telefono | Nome, Indirizzo, Telefono, Email | Sembra scandagliare miliardi di record come da [sito](https://www.fastbackgroundcheck.com/about) |

---

### **Osservazioni chiave**:
1. **Gratis vs. Pagamento**: La maggior parte offre info base gratis ma report dettagliati a pagamento (es. PublicRecords → Intelius).  
2. **Fonti dati**: Molti attingono dagli stessi breach/archivi pubblici (email/telefono spesso obsolete ma ancora in uso).  
3. **Specializzazione**:  
   - *Social Media*: PeekYou, IDCrawl.  
   - *Geolocalizzazione*: ClustrMaps.  
   - *Completi*: FastPeopleSearch, Nuwber, fastbackgroundcheck.  

**Disclaimer**: L’accuratezza varia; gli utenti raramente cambiano email se non compromessi. Usare eticamente!

- Per altri strumenti vedi [Liste curate](#curated-lists)

## Letteratura grigia

Usa questo sito; [non registrarti](https://vote.gov/register), controlla una registrazione elettorale. Potrebbero servire più dati in alcuni stati; meno in altri.

Uno strumento automatico che ho creato per [pa voter services](https://github.com/airborne-commando/voter-reg-status). Sentiti libero di adattarlo per altri stati.

## Dati violati:
---

| **Strumento**               | **Cerca per**       | **Restituisce**                              | **Limitazioni/Costi**                          | **Note**                                                                 |
|------------------------|--------------------|------------------------------------------|-----------------------------------------------|---------------------------------------------------------------------------|
| **[Have I Been Pwned](https://haveibeenpwned.com/)**  | Email, Telefono       | Breach, date, dati compromessi    | Gratis; no password/raw data                   | Fonte affidabile; alert per nuovi breach.                                  |
| **[BreachDirectory](https://breachdirectory.org/)**    | Email, Username    | Hash parziali password (SHA-1, primi 4 caratteri), lunghezza | Gratis; no password complete            | Utile per test stuffing credenziali.                                    |
| **[Breach.vip](https://Breach.vip)**         | Email, Username    | Leak Minecraft (username, IP) | Gratis; login richiesto                          | Niche per gaming account; “memey” ma funzionale.                        |
| **[LeakPeek](https://leakpeek.com/)**           | Email, Username    | Breach parziali (es. domini)  | 5 ricerche gratis; bypass con Tor possibile          | Piani a pagamento per dati completi; risultati offuscati.                             |
| **[LOLArchiver](https://osint.lolarchiver.com/)**        | Email, Username    | Database completi breach (email, password) | Solo a pagamento                     | Per professionisti OSINT; leak di alto valore.                        |
| **[Icebreaker](https://github.com/airborne-commando/ice-breaker)**         | File breach locali | Analizza grandi dataset breach    | Python/EXE; ottimale per file <1000GB      | Script demo fornito; usalo con cautela (es. [Facebook 533M](https://github.com/davidfegyver/facebook-533m)).        |
| **[hashes.com](https://hashes.com/)**         | Hash (MD5, SHA-1, ecc.) | Password decriptate (se hash crackato) | Strumenti gratis/a pagamento                      | Utile per invertire hash da breach.                               |
| **[pentester.com](https://pentester.com/)**          | Email, Username    | Dettagli breach (più di HIBP)     | Gratis; no Tor necessario                           | Non ufficiale ma esteso; può includere dati sensibili.                    |

---

### **Punti chiave**:  
1. **Gratis vs. Pagamento**:  
   - *Gratis*: HIBP, BreachDirectory, Pentester, Hashes.com.  
   - *Gratis limitato*: LeakPeek (5 ricerche), Breach.vip (login richiesto).  
   - *Pagamento*: LOLArchiver, LeakPeek piani.  

2. **Specializzazione**:  
   - *Password recovery*: Hashes.com (decifra hash), BreachDirectory (hash parziali).  
   - *Gaming leak*: Breach.vip (Minecraft).  
   - *Analisi locale*: Icebreaker (tool Python per grandi dataset).  

3. **Etica/Legalità**:  
   - Molti strumenti forniscono **dati parziali** (es. primi 4 caratteri password) per motivi etici.  
   - Usa **Tor** con LeakPeek per superare i limiti.  
   - Evita abusi: alcuni (es. Pentester) possono mostrare dati sensibili.  

4. **Per grandi dataset**:  
   - [Icebreaker](https://github.com/airborne-commando/ice-breaker) + [Facebook 533M](https://github.com/davidfegyver/facebook-533m) (senza password) per analisi massiva.  

---

### **Risorse addizionali**:  
- **Liste curate**: Vedi [Liste curate](#curated-lists) per strumenti di nicchia.  
- **Script demo**: [Icebreaker](https://github.com/airborne-commando/ice-breaker) include un demo.  

## Social media
---

| **Piattaforma**  | **Strumento**               | **URL**                              | **Funzionalità**                          | **Limitazioni/Note**                     |
|--------------|-----------------------|--------------------------------------|------------------------------------------|------------------------------------------|
| **Generale**  | Social Searcher       | [social-searcher.com](https://www.social-searcher.com/) | Cerca su più piattaforme | Free tier limitato |
| **Snapchat** | Snapchat Map          | [map.snapchat.com](https://map.snapchat.com/) | Visualizza storie pubbliche localizzate | Richiede account Snapchat |
| **Instagram**| Dumpor               | [dumpor.com](https://dumpor.com/)    | Visualizza profili/storie anonimamente      | Possibili rate limit |
| **Twitter**  | Sotwe                | [sotwe.com](https://www.sotwe.com/)  | Navigazione Twitter anonima             | Nessun login richiesto |
|              | Xcancel              | [xcancel.com](https://xcancel.com/)  | Visualizzatore Twitter alternativo             | Interfaccia leggera |
|              | Nitter               | [nitter.net](https://nitter.net/)    | Front-end privacy Twitter      | Evita il tracking Twitter |
| **Facebook** | Facebook Search      | [facebook.com/search](https://www.facebook.com/search/) | Ricerca nativa Facebook | Limitata senza login |
|              | WhoPostedWhat       | [whopostedwhat.com](https://www.whopostedwhat.com/) | Cerca post Facebook per data/keyword | Richiede query precise, profili pubblici |
| **reddit**   | r00m101.com         | [r00m101](https://r00m101.com/)       | Ottieni info da account reddit attivi o cancellati                                       | Pricing per copertura completa

---

### **Pro Tips & Workarounds**

1. **Account Facebook privati**:
   - Metodo 1: Crea un account fake (difficile per verifiche Facebook)
   - Metodo 2: Usa *Inspect Element* del browser → *Simulatore dispositivo* (o smartphone) + URL diretto
   - Prova sempre da disconnesso o in modalità privata prima

2. **Limitazioni LinkedIn**:
   - Se i profili non caricano:
     - Attendi 1-2 minuti (rotazione cookie/IP)
     - Crea un account base (evita comportamenti sospetti)
   - Il tracciamento HWID/IP può bloccare ricerche ripetute

3. **Alternative Twitter**:
   - Usa **Nitter**/**Xcancel** per evitare limiti/tracciamento
   - **Sotwe** funziona senza login

4. **Instagram**:
   - **Dumpor** bypassa alcune impostazioni privacy
   - **Quick Use** https://dumpor.io/v/USERNAME sostituisci ``USERNAME`` con l’utente che vuoi vedere
   - **Non funziona su account privati**

---

### **Punti chiave**
- **Anonimato**: Strumenti come Nitter/Dumpor evitano il tracciamento piattaforme
- **Trucchi mobile**: Simulare dispositivi mobili spesso funziona meglio per contenuti limitati
- **Persistenza**: Alcune piattaforme (LinkedIn/Facebook) richiedono pazienza o creazione account

- Per altri strumenti vedi la sezione Liste curate.


## Liste curate

- [Awesome OSINT](https://github.com/jivoi/awesome-osint) - lista curata di strumenti, blog e video OSINT

- [OSINT Framework](https://osintframework.com/) - lista ampia di tool
  
- [OSINT Resources](https://sizeof.cat/post/osint-resources/) - Raccolta risorse OSINT aggiornata (incluso NSFW)

  - [Archivio](https://archive.ph/rZZf0) 

- Wiki reddit dalla [community OSINT](https://www.reddit.com/r/OSINT/wiki/index/)

- Elenco social, mappe, domini, ecc anche in [raccolta OSINT di cipher387](https://github.com/cipher387/osint_stuff_tool_collection). 

**OPT OUT**

- [Big Ass List](https://github.com/yaelwrites/Big-Ass-Data-Broker-Opt-Out-List) per opt-out e confronto info.

- [inteltechniques opt out workbook](https://inteltechniques.com/workbook.html)

- [Results about you (indice google)](https://myactivity.google.com/results-about-you) - Controlla cosa Google ti segnala; visita i siti e valuta l’opt-out lì.

## Toolchain (self-OSINT):

Google dorks: `https://www.google.com/search?q= "nome+cognome" "Indirizzo" "Città stato" "età"` -> [Results about you (indice google)](https://myactivity.google.com/results-about-you) -> [big ass list](https://github.com/yaelwrites/Big-Ass-Data-Broker-Opt-Out-List) -> [inteltechniques opt out workbook](https://inteltechniques.com/workbook.html) -> [People Search tools](https://github.com/airborne-commando/OPSEC-OSINT-Tools/tree/main?tab=readme-ov-file#people-search-tools-in-the-states)

**Nota** 

[Results about you (indice google)](https://myactivity.google.com/results-about-you) può anche essere inviato via email; tienilo presente nel confronto delle info. Google troverà siti con il tuo nome e indirizzo e ti chiederà di rimuoverli dall’indice. Prima di rimuovere da Google, assicurati di rimuovere le info dal sito stesso. I Google Dork manuali aiutano a non essere segnalati come bot.

## Strumenti archivio creati da me
 
- [estrattore link e archivio](https://github.com/airborne-commando/link-extractor-and-archive) usa archive.ph - utile su pagine base. Richiede intervento manuale (trova+sostituisci testo).


Altri strumenti:

- Per altri strumenti vedi le liste curate sopra



Donazioni:

Se ti è stato utile, puoi donare a questo indirizzo monero:

![mon](https://github.com/user-attachments/assets/f77ce530-5a5d-479d-bb47-481674c93f4c)

    8BPdcsLtA5iWLNTWvYzUVyTWtQkM62e8r7xqAuwjXTSC4RcoSWqpmtyLsMYvz3QNZtT1rbgPUnmVpMAudhxTn6zkRxUFcZN

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---