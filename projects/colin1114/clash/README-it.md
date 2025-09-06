
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=it">Italiano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

L'accelerazione CDN e la protezione della sicurezza per questo progetto sono sponsorizzate da Tencent EdgeOne.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

L'autore di questo progetto è colin1114.

# 🚀 Convertitore di abbonamenti Clash

Uno strumento online elegante e potente, progettato per convertire vari link di abbonamento proxy nel formato di configurazione Clash. Supporta la distribuzione automatica tramite Cloudflare Workers & Pages, offrendo un servizio di conversione degli abbonamenti rapido e affidabile.

## ✨ Caratteristiche funzionali

- 🎨 **Interfaccia moderna e accattivante** - Sfondo sfumato e design a schede
- 🔄 **Supporto multi-protocollo** - Compatibile con i principali protocolli come V2Ray, VLESS, Shadowsocks, Trojan
- ☁️ **Distribuzione cloud** - Accelerazione CDN globale tramite Cloudflare Workers
- 📱 **Design responsivo** - Perfettamente adattabile a desktop e dispositivi mobili
- ⚡ **Conversione rapida** - Conversione in tempo reale dei link di sottoscrizione in configurazione Clash
- 📋 **Copia intelligente** - Supporta la copia con un clic della configurazione YAML generata, compatibile con vari browser
- 📡 **Generazione link di sottoscrizione** - Generazione automatica di link di sottoscrizione importabili direttamente in Clash
- 🌐 **Accesso online ai file YAML** - Diverse modalità di accesso ai file YAML:
  - 📡 Link di sottoscrizione: supporta aggiornamento automatico del client Clash
  - 🔗 Visualizzazione online: visualizza la configurazione direttamente nel browser
  - 💾 Download file: scarica il file .yaml in locale
  - ⚡ Accesso rapido: link di download semplificati
- 🔧 **Supporto UTF-8** - Supporto completo per nomi di nodi e configurazioni in cinese
- 🆓 **Completamente gratuito** - Basato su servizi gratuiti Cloudflare, senza limiti d’uso

## 📁 Struttura del progetto

```
clash/
├── index.html              # 前端页面
├── worker.js               # Cloudflare Worker 后端代码
├── wrangler.jsonc          # Wrangler 配置文件
├── _headers                # Cloudflare Pages HTTP头配置
├── .github/
│   └── workflows/
│       └── deploy.yml      # GitHub Actions 部署配置
├── README.md              # 项目说明文档
└── package.json           # 项目配置文件
```

## 🚀 Avvio rapido

### Metodo 1: Esecuzione locale

1. **Clona il progetto**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **Avviare il server locale**
   ```bash
   # 使用 Python
   python -m http.server 8000
   
   # 或使用 Node.js
   npx serve .
   ```

3. **Accesso all'applicazione**
   - Apri il browser e visita `http://localhost:8000`
   - In ambiente locale verrà mostrata la configurazione di esempio

### Metodo 2: Deploy su Cloudflare Workers

#### Passaggio 1: Creare un Worker

1. Visita [Cloudflare Workers](https://workers.cloudflare.com/)
2. Registrati/accedi al tuo account Cloudflare
3. Clicca su "Create a Worker"
4. Copia il codice completo da `worker.js` nell'editor
5. Clicca su "Save and Deploy"

#### Passaggio 2: Deploy tramite Wrangler CLI

```bash
# 安装 Wrangler CLI
npm install -g wrangler

# 登录到 Cloudflare
wrangler login

# 部署 Worker
npm run deploy:worker
```

#### Passo 3: Configurazione del dominio (opzionale)

1. Aggiungi un dominio personalizzato nelle impostazioni di Worker
2. Oppure usa il dominio predefinito fornito da Cloudflare

### Metodo 3: Deployment con Cloudflare Pages

#### Opzione A: Integrazione con GitHub (consigliato)

1. **Prepara il repository**
   - Carica il codice nel repository GitHub
   - Assicurati di includere tutti i file necessari

2. **Crea un progetto Pages**
   - Visita [Cloudflare Pages](https://pages.cloudflare.com/)
   - Collega il tuo repository GitHub
   - Seleziona il repository del progetto

3. **Impostazioni di build**
   - Comando di build: lascia vuoto oppure `echo "No build required"`
   - Directory di output build: `/` (directory radice)
   - Variabili d'ambiente: nessuna impostazione necessaria

#### Opzione B: Caricamento diretto

```bash
# 使用 Wrangler Pages 部署
npm run deploy:pages
```

## 🛠️ Architettura Tecnica

### Stack Tecnologico Frontend
- **HTML5** - Linguaggio di markup moderno
- **CSS3** - Design responsivo ed effetti di animazione
- **Vanilla JavaScript** - Interattività frontend leggera

### Stack Tecnologico Backend
- **Cloudflare Workers** - Piattaforma di calcolo edge
- **Web APIs** - API Fetch standard e gestione delle risposte

### Formati di Protocollo Supportati
- **VMess** - Protocollo standard V2Ray
- **VLESS** - Protocollo leggero V2Ray (supporta Reality)
- **Shadowsocks** - Protocollo proxy classico
- **Trojan** - Protocollo proxy emergente

### Endpoint API
- `GET /` - Pagina principale
- `POST /convert` - API di conversione sottoscrizione
- `GET /clash/{config-id}` - Ottieni file di configurazione YAML (link sottoscrizione)
- `GET /yaml/{config-id}` - Scarica file di configurazione YAML
- `OPTIONS /*` - Richiesta preflight CORS

## 📖 Guida all'Uso

### Uso Base

1. **Inserisci il link di sottoscrizione**
   - Incolla il tuo link di sottoscrizione proxy nel campo di input
   - Supporta link di sottoscrizione codificati in Base64

2. **Imposta nome configurazione**
   - Facoltativamente imposta un nome personalizzato per il file di configurazione
   - Il nome predefinito è "My Clash Config"

3. **Converti configurazione**
   - Clicca sul pulsante "Converti Sottoscrizione"
   - Attendi il completamento della conversione
4. **Utilizzo della configurazione**
   - Copia la configurazione YAML generata
   - Importala nel client Clash per l'utilizzo

5. **Utilizzo del link di sottoscrizione (consigliato)**
   - Copia il link di sottoscrizione generato
   - Aggiungi la sottoscrizione nel client Clash
   - La configurazione si sincronizza automaticamente, senza aggiornamenti manuali

### Configurazione avanzata

La configurazione Clash generata include le seguenti caratteristiche:

- **Politiche dei gruppi proxy**
  - 🚀 Selezione nodo - Selezione manuale del proxy
  - ♻️ Selezione automatica - Selezione automatica tramite test di latenza
  - 🎯 Connessione globale diretta - Connessione diretta

- **Configurazione DNS**
  - Abilita la risoluzione DNS
  - Supporta la modalità fake-ip
  - Split DNS per interno/estero

- **Regole di routing**
  - Connessione diretta agli indirizzi locali
  - Connessione diretta agli IP nazionali
  - Altro traffico tramite proxy

## 🔧 Risoluzione dei problemi di distribuzione

### Problemi comuni

#### 1. Wrangler non trova il punto di ingresso
**Messaggio di errore**: `Missing entry-point to Worker script`

**Soluzione**: 
- Assicurati che nella directory principale del progetto ci sia il file `wrangler.jsonc`
- Verifica che il campo `main` in `wrangler.jsonc` punti a `worker.js`


#### 2. Errore di deployment con GitHub Actions
**Soluzione**:
- Aggiungi i seguenti Secrets nelle impostazioni del repository GitHub:
  - `CLOUDFLARE_API_TOKEN`: Token API di Cloudflare
  - `CLOUDFLARE_ACCOUNT_ID`: ID account Cloudflare

#### 3. Errore di build delle Pages
**Soluzione**:
- Imposta il comando di build come vuoto oppure `echo "No build required"`
- Assicurati che la directory di output della build sia impostata su `/`

### Descrizione dei file di configurazione per il deployment

- **`wrangler.jsonc`**: Configurazione CLI di Wrangler, utilizzata per il deployment dei Worker
- **`_headers`**: Configurazione degli header HTTP per Cloudflare Pages
- **`.github/workflows/deploy.yml`**: Configurazione di GitHub Actions per deployment automatico

## 🔧 Configurazione personalizzata

### Modifica dei gruppi proxy

Puoi modificare la funzione `convertToClash` in `worker.js` per personalizzare i gruppi proxy:

```javascript
'proxy-groups': [
  {
    name: '🚀 节点选择',
    type: 'select',
    proxies: ['♻️ 自动选择', '🎯 全球直连', ...proxyNames]
  },
  // 添加更多代理组...
]
```

### Regole di routing personalizzate

Modifica l'array `rules` per aggiungere regole di routing personalizzate:

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 节点选择',
  'DOMAIN-SUFFIX,local,DIRECT',
  // 添加更多规则...
]
```

## 📊 Caratteristiche delle prestazioni

- **CDN globale** - Cloudflare copre nodi edge in tutto il mondo
- **Risposta rapida** - Tempo di risposta medio < 100ms
- **Alta disponibilità** - Servizio disponibile al 99,9%
- **Quota gratuita** - 100.000 richieste al giorno

## 🔒 Informazioni sulla sicurezza

- **Privacy dei dati** - I dati di abbonamento vengono utilizzati solo durante la conversione, non vengono memorizzati
- **Crittografia HTTPS** - Tutte le comunicazioni sono criptate tramite HTTPS
- **Trasparenza open source** - Il codice sorgente completo è pubblico e può essere verificato autonomamente

## 🤝 Guida alla contribuzione

Sono benvenuti Issue e Pull Request!

1. Fai il fork di questo repository
2. Crea un branch per la feature (`git checkout -b feature/AmazingFeature`)
3. Effettua il commit delle modifiche (`git commit -m 'Add some AmazingFeature'`)
4. Pusha il branch (`git push origin feature/AmazingFeature`)
5. Apri una Pull Request

## 📝 Registro delle modifiche

### v1.1.0
- ✅ Aggiunto supporto al protocollo VLESS (incluso trasporto sicuro Reality)
- ✅ Migliorata compatibilità dei protocolli

### v1.0.0
- ✅ Funzionalità base di conversione abbonamenti
- ✅ Interfaccia utente gradevole
- ✅ Supporto a Cloudflare Workers
- ✅ Supporto a più protocolli (VMess, Shadowsocks, Trojan)
- ✅ Design responsivo
- ✅ Funzione copia con un clic

## 📞 Supporto e feedback

Se durante l'utilizzo riscontri problemi o hai suggerimenti, per favore:

1. Consulta questo documento README
2. Invia una [Issue](../../issues)
3. Avvia una [Discussion](../../discussions)

## 📄 Licenza

Questo progetto adotta la licenza MIT - vedi il file [LICENSE](LICENSE) per dettagli

## 🙏 Ringraziamenti

- [Cloudflare Workers](https://workers.cloudflare.com/) - Fornisce la piattaforma di edge computing
- [Clash](https://github.com/Dreamacro/clash) - Ottimo client proxy
- Il supporto di tutti i contributori e utenti

---

⭐ Se questo progetto ti è stato utile, lascia una Star! 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---