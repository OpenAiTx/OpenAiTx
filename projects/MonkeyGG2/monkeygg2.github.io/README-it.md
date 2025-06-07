<p align="center"><img src="https://raw.githubusercontent.com/MonkeyGG2/monkeygg2.github.io/main/imgs/icon-256-256.png" height="200"></p>

<div align="center">
<a href="https://discord.com/invite/yPYyZ78qCB"><img alt="Discord" src="https://img.shields.io/discord/1051660971900407839?label=discord"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="Github Repo stars" src="https://img.shields.io/github/stars/MonkeyGG2/monkeygg2.github.io?label=github%20stars"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="GitHub Repo forks" src="https://img.shields.io/github/forks/MonkeyGG2/monkeygg2.github.io?label=github%20forks"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo stars" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20stars&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=stars_count"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo forks" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20forks&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=forks_count"></a>
<a href="http://www.wtfpl.net/about"><img alt="License: WTFPL" src="https://img.shields.io/badge/License-WTFPL-brightgreen.svg"></a>
</div>
<h1 align="center">MonkeyGG2</h1>
<p align="center" style="opacity: 0.65;">Il tuo sito di giochi di quartiere amichevole.</p>
<br>

Benvenuto su MonkeyGG2, un sito di giochi ricco di funzionalità creato per te! Con oltre 150 giochi tra cui scegliere, MonkeyGG2 offre un'esperienza di gioco unica e personalizzabile. Che tu sia un gamer, uno sviluppatore o una persona qualunque, MonkeyGG2 offre un ambiente di gioco fluido e piacevole.

> Considera di lasciarci una stella! Soprattutto se hai fatto un fork di questo repository o hai trovato qualche altro utilizzo per questo repository.

## Caratteristiche

-   Oltre 150 giochi
-   Facile da usare
-   Facile da distribuire
-   Personalizzabile
-   Proxy
-   E altro ancora...

## Personalizzazione

### Impostazioni

#### Cloaking

Il cloaking si riferisce all'apertura della pagina in una scheda `about:blank`. Questo comportamento è forzato di default, anche se può essere disabilitato. Sono disponibili preset per il link di reindirizzamento ma possono anche essere configurati manualmente.

#### Masking

Il masking si riferisce alla modifica dell'icona e del titolo della scheda about:blank. Sono disponibili preset per l'icona e il titolo della scheda ma possono anche essere configurati manualmente.

#### Scorciatoie

È possibile creare scorciatoie da tastiera personalizzate per eseguire una varietà di azioni. Ad esempio, uscire dal gioco, mascherare la scheda ed eseguire JavaScript personalizzato sono tutte operazioni supportate.
> Nota: se desideri eseguire JavaScript personalizzato, assicurati di sapere cosa stai facendo. Se dovessi rompere qualcosa, un semplice ricaricamento della pagina risolverà il problema.

#### Tema

Attualmente sono supportate le seguenti personalizzazioni del tema:
- Attiva/Disattiva animazione di sfondo (se sei preoccupato per le prestazioni durante il gioco, non preoccuparti: viene automaticamente disabilitata quando stai giocando)
- Colore di sfondo
- Colore dei blocchi
- Colore dei pulsanti
- Colore dei giochi
- Colore hover
- Colore della scrollbar
- Colore della traccia della scrollbar
- Colore del font

> Nota: se cambi accidentalmente i colori rendendo il sito inutilizzabile, dovrai cancellare i cookie e il local storage.

### Personalizzazione Avanzata

> Disclaimer: Le seguenti personalizzazioni sono disponibili solo per i proprietari del repository o di qualsiasi fork di questo repository.

Il file `config.jsonc` è formattato per includere la configurazione di tutto il sito. Attualmente sono supportati i seguenti elementi:
- Giochi
- Temi (in arrivo)
- Configurazione Proxy

#### Giochi

Ogni voce di gioco ha una chiave che rappresenta il nome visualizzato del gioco e il valore deve essere un oggetto con tre coppie chiave-valore:
- `"path"`: Percorso del gioco dalla directory `./games`
- `"aliases"`: Elenco di nomi alternativi per il gioco utilizzati per migliorare la ricerca
- `"categories"`: Elenco di categorie a cui il gioco appartiene (il supporto per l'aggiunta di icone arriverà presto)

Aggiungere una voce manualmente è possibile, ma tedioso, soprattutto se vuoi mantenere l'ordine alfanumerico della lista (non necessario per il funzionamento della configurazione!).
Per questo è stato creato lo script `add-game-entry.js`, un modo semplice per aggiungere un nuovo gioco alla configurazione senza dover modificare manualmente il file.

```bash
# Puoi usare qualsiasi runtime js come node.js, bun o deno
# In questa dimostrazione verrà utilizzato bun, poiché le dipendenze vengono installate automaticamente
bun add-game-script.js
# Rispondi alle domande successive e la configurazione verrà aggiornata
```

#### Temi

Lo standard dei temi non è ancora implementato (TODO)

#### Proxy

Le opzioni di configurazione del proxy si trovano sotto la chiave **"config"**. 
Il valore della chiave `"proxy"` è un valore booleano che abilita o disabilita la funzione proxy. Se `"proxy"` è impostato su false, l'utente riceverà un messaggio di errore quando tenta di accedere al proxy.
Il valore della chiave `"proxyPath"` è il percorso del proxy. Può essere un percorso assoluto o relativo, ma il proxy deve supportare **CORS** poiché la pagina del proxy verrà visualizzata come iframe nel sito.


## Deploy

### Senza Proxy

[![Run on Replit](https://binbashbanana.github.io/deploy-buttons/buttons/remade/replit.svg)](https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Remix on Glitch](https://binbashbanana.github.io/deploy-buttons/buttons/remade/glitch.svg)](https://glitch.com/edit/#!/import/github/MonkeyGG2/monkeygg2.github.io)
[![Deploy to IBM Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/ibmcloud.svg)](https://cloud.ibm.com/devops/setup/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Amplify Console](https://binbashbanana.github.io/deploy-buttons/buttons/remade/amplifyconsole.svg)](https://console.aws.amazon.com/amplify/home#/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Run on Google Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/googlecloud.svg)](https://deploy.cloud.run/?git_repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Oracle Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/oraclecloud.svg)](https://cloud.oracle.com/resourcemanager/stacks/create?zipUrl=https://github.com/MonkeyGG2/monkeygg2.github.io/archive/refs/heads/main.zip)
[![Deploy with Vercel](https://binbashbanana.github.io/deploy-buttons/buttons/remade/vercel.svg)](https://vercel.com/new/clone?repository-url=https%3A%2F%2Fgithub.com%2FMonkeyGG2%2Fmonkeygg2.github.io)
[![Deploy with Netlify](https://binbashbanana.github.io/deploy-buttons/buttons/remade/netlify.svg)](https://app.netlify.com/start/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Render](https://binbashbanana.github.io/deploy-buttons/buttons/remade/render.svg)](https://render.com/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)

In alternativa, puoi semplicemente fare il fork di questo repository su [GitHub](https://github.com/MonkeyGG2/monkeygg2.github.io) o [Codeberg](https://codeberg.org/MonkeyGG2/pages) e distribuire su GitHub Pages o Codeberg Pages, rispettivamente.

### Con Proxy

Visita la pagina [VioletGG2](https://github.com/MonkeyGG2/VioletGG2) per saperne di più su come ospitare MonkeyGG2 con un proxy.

### Esecuzione Locale

```bash
# ATTENZIONE: se hai una cartella chiamata "monkeygg2", questo comando rimuoverà tutti i file all'interno di quella cartella
# ti preghiamo di cambiare il nome della directory nei due comandi seguenti
git clone https://github.com/MonkeyGG2/monkeygg2.github.io.git monkeygg2
cd monkeygg2
# da qui puoi usare qualsiasi tool per eseguire un server statico, in questo esempio verrà usato "live-server" da npm
npm install -g live-server # solo se non l'hai già installato
npx live-server
```

## Licenza

Distribuito sotto licenza WTFPL. Vedi [qui](https://github.com/MonkeyGG2/monkeygg2.github.io/blob/main/LICENSE) per maggiori dettagli.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---