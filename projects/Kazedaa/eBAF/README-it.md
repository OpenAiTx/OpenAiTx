# eBAF - Firewall pubblicitario basato su eBPF
<p align="center">
    <img src="https://raw.githubusercontent.com/Kazedaa/eBAF/main/assets/banner.png" alt="eBAF - eBPF Ad Firewall Banner" width="600"/>
</p>

## "Non scaricheresti mai una pubblicità"
### Ma la bloccheresti volentieri!

Spotify ha costruito un impero su una formula semplice: monetizzare la tua attenzione, sottopagare gli artisti e rivenderti il tuo tempo come funzionalità premium.
Nel loro mondo, la tua esperienza di ascolto non ti appartiene. È un mercato accuratamente curato — le tue orecchie sono il prodotto, la tua pazienza è la valuta.

A loro piace chiamarla una fascia "gratuita".
Ma diciamoci la verità: non è gratuita se la paghi con il tuo tempo.

Nel frattempo, gli artisti che ami — le persone il cui lavoro mantiene viva la piattaforma — spesso guadagnano solo frazioni di centesimo per ogni riproduzione. Spotify ne trae grandi profitti, gli inserzionisti ottengono visibilità e i creatori? Si accontentano delle briciole.

Non si tratta solo di saltare qualche pubblicità fastidiosa.
Si tratta di rifiutarsi di partecipare a un sistema che trae profitto dallo sfruttamento, dalla distrazione e dalla mercificazione della tua attenzione.

#### Che cos'è questo?
Un elegante piccolo atto di resistenza digitale: un adblocker pulito e open-source per Spotify che ferma il rumore — letteralmente.

Nessuna mod sospetta, nessun client craccato, nessun malware che si spaccia per libertà. Solo un obiettivo: lasciare che la musica suoni senza essere tenuti in ostaggio dagli annunci.

Spotify non è gratis — paghi con la tua pazienza.

Ti bombardano con gli stessi fastidiosi annunci, ancora e ancora, finché non ti arrendi e ti abboni. Non perché ami Premium. Ma perché sei stato logorato. Questo non è freemium — questa è guerra psicologica con una playlist.

Nel frattempo, gli artisti? Ancora sottopagati.
Gli annunci? Più rumorosi. Più frequenti. A volte letteralmente più rumorosi.
Tu? Solo a cercare di goderti la musica.

Loro traggono profitto dalla tua pazienza e dal loro sottopagare i creatori, il tutto fingendo che sia l’unico modo sostenibile. Spoiler: non lo è. Avevano una scelta — ma hanno scelto i margini di profitto invece delle persone.

Spotify vuole farti credere che questo sia il prezzo dell’accesso.
Noi crediamo che sia una bugia.

Non siamo pirati. Non siamo criminali. Siamo solo persone che pensano sia giusto tracciare un confine.

Questo progetto non riguarda lo skippare qualche annuncio. Riguarda il rifiuto di un sistema che dice che il tuo silenzio può essere venduto, la tua esperienza può essere interrotta, e il tuo valore inizia solo quando apri il portafoglio.

Bloccare gli annunci non è un furto.<br>
Rubare il tuo tempo lo è.<br>
Non siamo qui per piratare. Siamo qui per scegliere di non partecipare.<br>
<br>
**Non scaricheresti mai una pubblicità. Ma la bloccheresti di sicuro.**
## Come funziona eBAF?

eBAF (eBPF Ad Firewall) sfrutta la potenza di eBPF (Extended Berkeley Packet Filter) per bloccare le pubblicità indesiderate a livello kernel. Ecco una panoramica ad alto livello del suo funzionamento:

## Come funziona eBAF?

eBAF (eBPF Ad Firewall) utilizza eBPF (Extended Berkeley Packet Filter) per bloccare le pubblicità a livello kernel in modo efficiente. Ecco una panoramica semplificata:

1. **Filtraggio dei pacchetti**:
   - Analizza i pacchetti di rete in ingresso e blocca quelli che corrispondono a una blacklist di indirizzi IP utilizzando XDP (eXpress Data Path).

2. **Aggiornamenti dinamici**:
   - Risolve i nomi di dominio in indirizzi IP e aggiorna dinamicamente la blacklist per rimanere efficace contro i server pubblicitari in continua evoluzione.

3. **Dashboard web**:
   - Fornisce statistiche in tempo reale e monitoraggio tramite un'interfaccia facile da usare.

4. **Alta prestazione**:
   - Opera direttamente a livello dell’interfaccia di rete, bypassando lo stack di rete del kernel per una elaborazione più rapida e un uso minimo delle risorse.

eBAF combina efficienza, trasparenza e facilità d’uso per offrire una soluzione potente per il blocco delle pubblicità.
## Installazione Semplice (Consigliato)
Assicurati di avere git e curl installati
```bash
git --version
curl --version
```
### Installazione
#### Abilita integrazione con Spotify (Consigliato)
```bash
EBAF_ENABLE_SPOTIFY=yes curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo -E bash
```
#### Disabilita esplicitamente
```bash
EBAF_ENABLE_SPOTIFY=no curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo bash```
```

### Disinstallazione
```bash
curl -sSL https://raw.githubusercontent.com/Kazedaa/eBAF/main/uninstall.sh | sudo bash
```
## Installazione Dev
Esegui i seguenti comandi per installare le dipendenze richieste:
### Ubuntu/Debian
```bash
sudo apt-get update
sudo apt-get install libbpf-dev clang llvm libelf-dev zlib1g-dev gcc make python3

sudo apt update
sudo apt install net-tools
```

### Fedora/CentOS/RHEL 8+
```bash
sudo dnf update
sudo dnf install -y libbpf-devel clang llvm elfutils-libelf-devel zlib-devel gcc make python3 net-tools bc
```

### Arch
```bash
sudo pacman -Syu
sudo pacman -S --needed libbpf clang llvm libelf zlib gcc make python net-tools bc
```

### Correggere l'errore asm/types.h durante l'esecuzione del codice eBPF
Controlla il link corrente
`ls -l /usr/include/asm`
Trova il link corretto
`find /usr/include -name "types.h" | grep asm`
Correggi il collegamento simbolico
```bash
sudo rm /usr/include/asm
sudo ln -s <current_link> /usr/include/asm
```

### Compilazione del Progetto

Per compilare l'eBPF Adblocker, segui questi passaggi:

1. Clona il repository:
   ```bash
   git clone <repository-url>
   cd eBAF
   ```
2. Compila il progetto:
   ```bash
   make
   ```

3. (Opzionale) Installa a livello di sistema:
   ```bash
   sudo make install
   ```

4. Altre opzioni di installazione (help desk)
    ```bash
    make help
    ````
5. Disinstalla
    ```bash
    make uninstall
    ````
## Utilizzo

### Avvio dell’Adblocker
    Usa spotify-stable.txt come blacklist predefinita.
    Utilizzo: ebaf [OPZIONI] [INTERFACCIA...]
    OPZIONI:
    -a, --all               Esegui su tutte le interfacce attive
    -d, --default           Esegui solo sull’interfaccia predefinita (con accesso a Internet)
    -i, --interface IFACE   Specifica un’interfaccia da utilizzare
    -D, --dash              Avvia la dashboard web (http://localhost:8080)
    -q, --quiet             Sopprime l’output (modalità silenziosa)
    -h, --help              Mostra questo messaggio di aiuto


### Configurazione della Blacklist
Modifica le liste per aggiungere o rimuovere domini. Ogni dominio deve essere su una riga separata. I commenti iniziano con `#`.

## Riconoscimenti

Un ringraziamento speciale a ❤️ <br>
1. [Spotify-AdsList di Isaaker](https://github.com/Isaaker/Spotify-AdsList/tree/main) <br>
2. [spotify-adblock di AnanthVivekanand](https://github.com/AnanthVivekanand/spotify-adblock)

per aver fornito una lista di blocco per Spotify
## ⭐️ Supporta il Progetto

Se trovi eBAF utile, considera di aggiungere una stella al repository su GitHub! Il tuo supporto aiuta ad aumentare la visibilità e incoraggia lo sviluppo futuro.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---