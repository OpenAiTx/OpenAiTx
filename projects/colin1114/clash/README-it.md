L'accelerazione CDN e la protezione della sicurezza per questo progetto sono sponsorizzate da Tencent EdgeOne.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

L'autore di questo progetto è colin1114.

# 🚀 Convertitore di abbonamenti Clash

Uno strumento online elegante e potente, utilizzato per convertire vari link di abbonamento proxy nel formato di configurazione Clash. Supporta il deployment automatico tramite Cloudflare Workers & Pages, offrendo un servizio di conversione abbonamenti veloce e affidabile.

## ✨ Caratteristiche principali

- 🎨 **Interfaccia moderna ed elegante** - Basata su sfondo sfumato e design a schede
- 🔄 **Supporto multi-protocollo** - Supporta i principali protocolli come V2Ray, VLESS, Shadowsocks, Trojan e altri
- ☁️ **Deployment cloud** - Accelerazione CDN globale tramite Cloudflare Workers
- 📱 **Design responsivo** - Perfetta compatibilità con desktop e dispositivi mobili
- ⚡ **Conversione rapida** - Conversione in tempo reale dei link di abbonamento in configurazione Clash
- 📋 **Copia intelligente** - Supporta la copia con un clic della configurazione YAML generata, compatibile con tutti i browser
- 📡 **Generazione link di abbonamento** - Genera automaticamente link di abbonamento importabili direttamente in Clash
- 🌐 **Accesso online YAML** - Offre diversi metodi di accesso ai file YAML:
  - 📡 Link di abbonamento: supporta aggiornamenti automatici dal client Clash
  - 🔗 Visualizzazione online: visualizza direttamente la configurazione nel browser
  - 💾 Download file: scarica il file .yaml in locale
  - ⚡ Accesso rapido: link di download semplificato
- 🔧 **Supporto UTF-8** - Supporta perfettamente nomi di nodi e configurazioni in cinese
- 🆓 **Completamente gratuito** - Basato sui servizi gratuiti di Cloudflare, senza limiti d'uso

## 📁 Struttura del progetto

```
clash/
├── index.html              # Pagina frontend
├── worker.js               # Codice backend Cloudflare Worker
├── wrangler.jsonc          # File di configurazione Wrangler
├── _headers                # Configurazione intestazioni HTTP di Cloudflare Pages
├── .github/
│   └── workflows/
│       └── deploy.yml      # Configurazione deploy GitHub Actions
├── README.md              # Documentazione del progetto
└── package.json           # File di configurazione progetto
```

## 🚀 Guida rapida

### Metodo 1: Esecuzione locale

1. **Clona il progetto**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **Avvia il server locale**
   ```bash
   # Con Python
   python -m http.server 8000

   # Oppure con Node.js
   npx serve .
   ```

3. **Accedi all'applicazione**
   - Apri il browser e visita `http://localhost:8000`
   - In ambiente locale verrà mostrata una configurazione di esempio

### Metodo 2: Deployment su Cloudflare Workers

#### Passaggio 1: Crea un Worker

1. Visita [Cloudflare Workers](https://workers.cloudflare.com/)
2. Registrati/accedi al tuo account Cloudflare
3. Clicca su "Create a Worker"
4. Copia tutto il codice da `worker.js` nell'editor
5. Clicca su "Save and Deploy"

#### Passaggio 2: Deployment tramite Wrangler CLI

```bash
# Installa Wrangler CLI
npm install -g wrangler

# Accedi a Cloudflare
wrangler login

# Deploy del Worker
npm run deploy:worker
```

#### Passaggio 3: Configura il dominio (opzionale)

1. Aggiungi un dominio personalizzato nelle impostazioni del Worker
2. Oppure usa il dominio predefinito fornito da Cloudflare

### Metodo 3: Deployment su Cloudflare Pages

#### Opzione A: Integrazione GitHub (consigliato)

1. **Prepara il repository**
   - Carica il codice su un repository GitHub
   - Assicurati di includere tutti i file necessari
2. **Creazione del progetto Pages**
   - Visita [Cloudflare Pages](https://pages.cloudflare.com/)
   - Collega il tuo repository GitHub
   - Seleziona il repository del progetto

3. **Impostazioni di build**
   - Comando di build: lascia vuoto oppure `echo "No build required"`
   - Directory di output della build: `/` (directory radice)
   - Variabili d’ambiente: nessuna necessaria

#### Opzione B: Caricamento diretto

```bash
# Distribuzione con Wrangler Pages
npm run deploy:pages
```

## 🛠️ Architettura tecnica

### Stack tecnologico frontend
- **HTML5** - Linguaggio di markup moderno
- **CSS3** - Design responsivo ed effetti animati
- **Vanilla JavaScript** - Interazioni frontend leggere

### Stack tecnologico backend
- **Cloudflare Workers** - Piattaforma di edge computing
- **Web APIs** - Fetch API standard e gestione delle risposte

### Formati di protocollo supportati
- **VMess** - Protocollo standard V2Ray
- **VLESS** - Protocollo leggero V2Ray (supporta Reality)
- **Shadowsocks** - Protocollo proxy classico
- **Trojan** - Nuovo protocollo proxy emergente

### Endpoint API
- `GET /` - Pagina principale
- `POST /convert` - API di conversione abbonamenti
- `GET /clash/{config-id}` - Ottieni file di configurazione YAML (link abbonamento)
- `GET /yaml/{config-id}` - Scarica il file di configurazione YAML
- `OPTIONS /*` - Richieste preflight CORS

## 📖 Guida all’uso

### Utilizzo di base

1. **Inserisci il link dell’abbonamento**
   - Incolla il tuo link di abbonamento proxy nel campo di input
   - Supporta link di abbonamento codificati in Base64

2. **Imposta il nome della configurazione**
   - Opzionalmente imposta un nome personalizzato per il file di configurazione
   - Il valore predefinito è "My Clash Config"

3. **Converti la configurazione**
   - Clicca sul pulsante "Converti abbonamento"
   - Attendi il completamento della conversione

4. **Usa la configurazione**
   - Copia la configurazione YAML generata
   - Importala nel client Clash

5. **Utilizza il link di abbonamento (consigliato)**
   - Copia il link di abbonamento generato
   - Aggiungilo come abbonamento nel client Clash
   - La configurazione si sincronizzerà automaticamente, senza necessità di aggiornamenti manuali

### Configurazione avanzata

La configurazione Clash generata include le seguenti caratteristiche:

- **Politica dei gruppi proxy**
  - 🚀 Selezione nodo - Selezione manuale del proxy
  - ♻️ Selezione automatica - Selezione automatica tramite test di latenza
  - 🎯 Connessione diretta globale - Connessione diretta

- **Configurazione DNS**
  - Abilitazione della risoluzione DNS
  - Supporto modalità fake-ip
  - Split DNS per Cina/estero

- **Regole di routing**
  - Indirizzi locali in connessione diretta
  - IP cinesi in connessione diretta
  - Altri traffici instradati tramite proxy

## 🔧 Risoluzione dei problemi di distribuzione

### Problemi comuni

#### 1. Wrangler non trova il punto di ingresso
**Messaggio di errore**: `Missing entry-point to Worker script`

**Soluzione**: 
- Assicurati che nella directory principale del progetto sia presente il file `wrangler.jsonc`
- Verifica che il campo `main` in `wrangler.jsonc` punti a `worker.js`

#### 2. Distribuzione tramite GitHub Actions fallita
**Soluzione**:
- Aggiungi i seguenti Secrets nelle impostazioni del repository GitHub:
  - `CLOUDFLARE_API_TOKEN`: Token API di Cloudflare
  - `CLOUDFLARE_ACCOUNT_ID`: ID account Cloudflare

#### 3. Errore nella build di Pages
**Soluzione**:
- Impostare il comando di build come vuoto oppure `echo "No build required"`
- Assicurarsi che la directory di output della build sia impostata su `/`

### Descrizione dei file di configurazione di deploy

- **`wrangler.jsonc`**: Configurazione CLI di Wrangler, per il deploy dei Worker
- **`_headers`**: Configurazione degli header HTTP per Cloudflare Pages
- **`.github/workflows/deploy.yml`**: Configurazione di deploy automatico tramite GitHub Actions

## 🔧 Configurazione personalizzata

### Modifica dei gruppi proxy

È possibile modificare la funzione `convertToClash` in `worker.js` per personalizzare i gruppi proxy:

```javascript
'proxy-groups': [
  {
    name: '🚀 Scelta Nodo',
    type: 'select',
    proxies: ['♻️ Selezione Automatica', '🎯 Connessione Globale Diretta', ...proxyNames]
  },
  // Aggiungi altri gruppi proxy...
]
```

### Regole di routing personalizzate

Modificare l’array `rules` per aggiungere regole di routing personalizzate:

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 Scelta Nodo',
  'DOMAIN-SUFFIX,local,DIRECT',
  // Aggiungi altre regole...
]
```

## 📊 Caratteristiche di performance

- **CDN globale** - Cloudflare copre nodi edge in tutto il mondo
- **Risposta rapida** - Tempo di risposta medio < 100ms
- **Alta disponibilità** - 99,9% di uptime del servizio
- **Quota gratuita** - 100.000 richieste al giorno

## 🔒 Informazioni sulla sicurezza

- **Privacy dei dati** - I dati di sottoscrizione sono utilizzati solo durante la conversione e non vengono memorizzati
- **Crittografia HTTPS** - Tutte le comunicazioni sono crittografate tramite HTTPS
- **Trasparenza open source** - Codice sorgente completo pubblico e verificabile

## 🤝 Guida al contributo

Sono benvenuti Issue e Pull Request!

1. Fai un fork di questo repository
2. Crea un branch per la funzionalità (`git checkout -b feature/AmazingFeature`)
3. Effettua il commit delle modifiche (`git commit -m 'Add some AmazingFeature'`)
4. Pusha sul branch (`git push origin feature/AmazingFeature`)
5. Apri una Pull Request

## 📝 Changelog

### v1.1.0
- ✅ Aggiunto supporto al protocollo VLESS (incluso Reality per trasmissione sicura)
- ✅ Migliorata la compatibilità con i protocolli

### v1.0.0
- ✅ Funzionalità base di conversione delle sottoscrizioni
- ✅ Interfaccia utente accattivante
- ✅ Supporto per Cloudflare Workers
- ✅ Supporto multi-protocollo (VMess, Shadowsocks, Trojan)
- ✅ Design responsivo
- ✅ Funzione di copia con un clic

## 📞 Supporto e feedback

Se incontri problemi o hai suggerimenti durante l’uso, per favore:

1. Consulta questo file README
2. Apri una [Issue](../../issues)
3. Avvia una [Discussion](../../discussions)

## 📄 Licenza

Questo progetto è sotto licenza MIT - vedi il file [LICENSE](LICENSE) per i dettagli

## 🙏 Ringraziamenti

- [Cloudflare Workers](https://workers.cloudflare.com/) - Piattaforma di edge computing
- [Clash](https://github.com/Dreamacro/clash) - Eccellente client proxy
- Tutti i contributor e utenti per il supporto

---
⭐ Se questo progetto ti è stato utile, dagli una Stella!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---