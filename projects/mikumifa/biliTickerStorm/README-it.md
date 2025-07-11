# 🎫 BiliTickerStorm

## ⚙️ Descrizione del Servizio

| Nome Servizio        | Descrizione                     | Note        |
| -------------------- | ------------------------------ | ----------- |
| `ticket-master`      | Servizio principale, gestisce la pianificazione dei task | Deploy a istanza singola |
| `ticket-worker`      | Worker per l'acquisto biglietti, scalabile orizzontalmente | Supporta più istanze |
| `gt-python`          | Servizio di gestione dei captcha grafici | Deploy a istanza singola |

---

## 🚀 Passaggi Rapidi di Deployment

> Per la configurazione del cluster, fare riferimento alla [Guida alla Configurazione del Cluster](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/docs/集群搭建参考.md).

<details> <summary><strong>📦 Installazione da repository remoto (consigliato)</strong></summary>

```bash
helm repo add bili-ticker-storm https://mikumifa.github.io/biliTickerStorm/
helm repo update
```
### 2. Installazione del Chart

```bash
helm install bili-ticker-storm bili-ticker-storm/bili-ticker-storm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
  
```

> - `hostDataPath` è la directory dei file di configurazione per l’acquisto dei biglietti, da montare nel container `ticket-master`. I file di configurazione si generano utilizzando https://github.com/mikumifa/biliTickerBuy
> - `ticketWorker.pushplusToken` è la configurazione per l’invio delle notifiche tramite plusplus; se impostato, è possibile ricevere notifiche sui risultati dell’acquisto dei biglietti.
> - `ticketWorker.ticketInterval` è l’intervallo in secondi tra i tentativi di acquisto, predefinito a 300 millisecondi.
> - `ticketWorker.ticketTimeStart` è l’orario di avvio programmato, nel formato `2025-05-20T13:14`; se non impostato, il container avvia immediatamente l’acquisto dei biglietti.

### 3. Aggiornamento del Chart

```bash
helm upgrade bili-ticker-storm bili-ticker-storm/bili-ticker-storm --reuse-values \
  --set ticketWorker.ticketInterval="600"
```
</details> 
<details> <summary><strong>📦 Installazione Chart Locale</strong></summary>


### 1. Installazione del Chart

```bash
# Clonare il repository
git clone https://github.com/mikumifa/biliTickerStorm
# Utilizzare il pacchetto Chart locale
helm install bili-ticker-storm ./helm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
```
### 2. Aggiornamento del Chart

```bash
helm upgrade bili-ticker-storm ./helm --reuse-values
```
</details>
<details>
<summary><strong>📌 Comandi Generali</strong></summary>

### ⏹ Disinstallazione
```bash
helm uninstall bili-ticker-storm
```
</details>


## 📩 Disclaimer

Questo progetto segue la licenza MIT License ed è destinato esclusivamente all'apprendimento e alla ricerca personale. È vietato utilizzare questo progetto per qualsiasi attività commerciale a scopo di lucro, così come è severamente proibito utilizzarlo per qualsiasi forma di acquisto automatizzato, attività illegali o che violino le regole delle piattaforme coinvolte. Tutte le conseguenze derivanti dall'uso sono a carico esclusivo dell'utente e non sono in alcun modo imputabili all'autore.

Se effettui un fork o utilizzi questo progetto, assicurati di rispettare le leggi e i regolamenti vigenti nonché le regole delle piattaforme di destinazione.

## 💡 Sulla frequenza di accesso e il controllo della concorrenza
Il progetto è stato progettato seguendo rigorosamente il principio della “non invasività”, evitando qualsiasi interferenza con i server di destinazione (come Bilibili).

Tutti gli intervalli di tempo delle richieste di rete sono configurabili dall'utente, con valori predefiniti che simulano la velocità di un normale utente durante un'operazione manuale. Il programma viene eseguito in modalità single-thread di default, senza task concorrenti. In caso di fallimento di una richiesta, il programma effettuerà un numero limitato di tentativi di ripetizione, aggiungendo un adeguato ritardo tra i tentativi per evitare richieste ad alta frequenza. Il progetto si basa esclusivamente su interfacce pubbliche e sulla struttura delle pagine della piattaforma, senza includere metodi distruttivi come l’elusione dei controlli di sicurezza o il dirottamento delle API.
## 🛡️ Dichiarazione di rispetto della piattaforma

Durante la progettazione di questo programma è stata controllata la frequenza delle richieste il più possibile, per evitare qualsiasi carico o impatto evidente sui server di Bilibili. Il progetto è solo a scopo di apprendimento, non possiede capacità di larga scala o alta concorrenza, né ha alcuna intenzione malevola o di interferenza con il servizio.

Se in questo progetto sono presenti contenuti che violano i diritti legittimi della società Bilibili, vi prego di contattarmi tramite email [1055069518@qq.com](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/mailto:1055069518@qq.com) e provvederò immediatamente a rimuovere i contenuti interessati e a cancellare questo repository. Mi scuso profondamente per eventuali disagi causati e vi ringrazio per la vostra comprensione e tolleranza.

## 📄 Licenza

[Licenza MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---