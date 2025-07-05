# TeamSpeak 6 Server - Beta Release README

Benvenuto alla versione Beta del TeamSpeak 6 Server! Siamo entusiasti di averti a bordo mentre esplori la prossima generazione di TeamSpeak. Questo documento ti guiderà nell’avvio e metterà in evidenza dettagli importanti riguardo all’attuale Beta.

Poiché si tratta di una versione Beta, alcune funzionalità sono ancora in fase di sviluppo e potresti incontrare dei bug. Il tuo feedback è importante e ci aiuterà a realizzare una versione finale più stabile e completa.

<h2><img width="24" src="/icons/teamspeak_blue.svg">&nbsp;Informazioni su TeamSpeak</h2>

Testato e collaudato per quasi 25 anni, abbiamo una soluzione che si adatta alle esigenze di tutti. TeamSpeak offre la comunicazione vocale ideale per il gaming, l’istruzione e la formazione, la comunicazione aziendale interna e per restare in contatto con amici e famiglia. Il nostro obiettivo principale è offrire una soluzione facile da usare, con elevati standard di sicurezza, eccellente qualità vocale e basso consumo di sistema e di banda.

## ℹ️ Stato della Beta & Problemi Conosciuti
**Questa è una versione beta. L’obiettivo principale è raccogliere feedback diversificati e identificare potenziali problemi prima del rilascio stabile.**

**File Server Self-Hosted:** Il software server dedicato per TeamSpeak 6 è ancora in fase di sviluppo attivo e non è ancora completamente completo di tutte le funzionalità. Siamo impegnati a offrire la completa esperienza TS6 per i server self-hosted.

**Instabilità delle Funzionalità:** Alcune delle nuove funzionalità potrebbero essere instabili o soggette a modifiche mentre continuiamo a perfezionarle.

**Il Feedback è Essenziale:** La tua esperienza è preziosa e il tuo contributo è fondamentale per noi. Segnala eventuali problemi o condividi suggerimenti nel nostro [Forum della Community](https://community.teamspeak.com/c/teamspeak-6-server/45) o direttamente qui su [GitHub](https://github.com/teamspeak/teamspeak6-server/issues).

**Limitazioni:** Si prega di notare che **le licenze del Server TeamSpeak 3 non sono compatibili** con i Server TeamSpeak 6 e attualmente **non è disponibile alcun percorso di migrazione tra le due versioni**.

**Licenza di Anteprima:** In risposta ai vostri feedback, il server ora viene fornito con una **licenza temporanea** di anteprima da 32 slot per offrire maggiore flessibilità durante il periodo di valutazione. Si noti che questa licenza è **valida solo per due mesi**.

Inoltre, **non è ancora possibile ottenere o aggiornare a una licenza più ampia per TeamSpeak 6**.

Apprezziamo davvero la vostra pazienza e comprensione mentre continuiamo a lavorare su soluzioni per supportare meglio le vostre esigenze in futuro.

## 👇 Per Iniziare con TS6
Per iniziare con il Client TeamSpeak 6, visita la nostra pagina [Download](https://teamspeak.com/en/downloads/).

Per informazioni sull’hosting autonomo, consulta la breve guida di seguito. Per gli ultimi aggiornamenti, annunci e per partecipare alla community di TeamSpeak, assicurati di visitare il nostro [Forum della Community](https://community.teamspeak.com/) e seguirci su [Twitter](https://x.com/teamspeak).

Non vuoi gestire un server autonomo, oppure cerchi semplicemente un modo più semplice per iniziare con TeamSpeak 6? Puoi noleggiare Server Ufficiali TeamSpeak 6 affidabili direttamente tramite noi su [TeamSpeak Communities](https://www.myteamspeak.com/communities).
## ⚙️ Configurazione
### Puoi configurare il tuo server in tre modi principali:

1. **Argomenti della Riga di Comando:** Passa le opzioni direttamente all’avvio del server (ad esempio, ./tsserver --default-voice-port 9987). Questo è utile per modifiche temporanee o per scripting.

2. **Variabili d’Ambiente:** Imposta le variabili d’ambiente prima di avviare il server. Utile per Docker o quando vuoi evitare di sovraccaricare la riga di comando.

3. **File di Configurazione YAML:** Per una configurazione persistente, è fortemente consigliato utilizzare un file tsserver.yaml. Puoi generare un file di configurazione predefinito usando il flag --write-config-file.

Le principali impostazioni che puoi controllare includono porte di rete (voce, trasferimento file), connessioni al database (supporta SQLite e MariaDB), binding IP e opzioni di logging.

Per l’elenco completo delle opzioni disponibili, esegui il server con il flag `--help` oppure consulta il file [CONFIG.md](https://raw.githubusercontent.com/teamspeak/teamspeak6-server/main/CONFIG.md).

### Eseguire il Server con i Binari
Se non stai usando Docker, puoi eseguire il server direttamente sul tuo sistema operativo.

<h2><img width="22" src="/icons/linux.svg">&nbsp;Su Linux:</h2>

Rendi eseguibile il file binario del server:
```sh
chmod +x tsserver
```

Esegui il server dal terminale, assicurandoti di accettare la licenza:

```sh
./tsserver --accept-license
```

<h2><img width="22" src="/icons/windows.svg">&nbsp;Su Windows:</h2>

Apri il Prompt dei Comandi o PowerShell e vai nella cartella dove hai estratto i file del server.

Esegui il file eseguibile del server, assicurandoti di accettare la licenza:
```powershell
tsserver.exe
```

<h2><img width="32" src="/icons/docker.svg">&nbsp;Eseguire il Server con Docker (Consigliato):</h2>
Docker è il modo più semplice per eseguire il server TeamSpeak 6 in un ambiente isolato e gestibile.

### 1. Comando semplice docker run:

Per un avvio rapido, puoi usare il comando docker run.

```sh
docker run -it --rm \
  -p 9987:9987/udp \
  -p 30033:30033 \
  -e TSSERVER_LICENSE_ACCEPTED=accept \
  teamspeaksystems/teamspeak6-server:latest
```

### 2. Utilizzo di docker-compose.yaml (per setup persistenti):
Questa è la pratica migliore per un server che intendi mantenere attivo. Crea un file docker-compose.yaml:

```yaml
services:
  teamspeak:
    image: teamspeaksystems/teamspeak6-server:latest
    container_name: teamspeak-server
    restart: unless-stopped
    ports:
      - "9987:9987/udp"   # Porta Voce
      - "30033:30033/tcp" # Trasferimento File
      # - "10080:10080/tcp" # Web Query
    environment:
      - TSSERVER_LICENSE_ACCEPTED=accept
    volumes:
      - teamspeak-data:/var/tsserver/

volumi:
  teamspeak-data:
```

## 🔗 Link Utili
[Sito Ufficiale](https://teamspeak.com/en/)<br>
[Forum della Comunità](https://community.teamspeak.com)<br>
[Problemi su GitHub](https://github.com/teamspeak/teamspeak6-server/issues)<br>

La tua partecipazione e i tuoi feedback ci aiuteranno a plasmare il futuro di TeamSpeak! 💙<br>
Grazie per far parte del programma Beta di TeamSpeak 6 e per contribuire ai suoi progressi! 🫡

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---