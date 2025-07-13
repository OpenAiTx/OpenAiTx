# Terminale di Pagamento NFC

Un terminale di pagamento NFC multi-chain che elabora pagamenti in criptovaluta su 5 reti blockchain con monitoraggio delle transazioni in tempo reale e tracciamento storico completo.

## 🌐 Reti Supportate

- **Ethereum**
- **Base**
- **Arbitrum**
- **Optimism**
- **Polygon**

### 🎯 **Priorità di Pagamento Intelligente**

Invece di negoziare una combinazione chain/token con il commerciante, il terminale di pagamento la gestisce automaticamente. Prima individua una rete supportata dal commerciante su cui anche tu possiedi fondi, poi invia una transazione con ETH o un token ERC-20 seguendo questa priorità:

```
L2 Stablecoin > L2 Altro > L2 ETH > L1 Stablecoin > L1 Altro > L1 ETH
```
## 🚀 Avvio Rapido

1. **Installa le dipendenze:**
   ```bash
   npm install
   ```

2. **Configurazione dell'ambiente:**
   ```bash
   echo "ALCHEMY_API_KEY=your_alchemy_api_key_here" > .env
   ```

3. **Avvia il terminale:**
   ```bash
   npm start
   ```

4. **Apri l'interfaccia:**
   Vai su `http://localhost:3000`

## 🏗️ Architettura

```
src/
├── server.ts                   # Server Express & gestore WebSocket
├── app.ts                      # Orchestratore principale dell'applicazione
├── web/index.html              # Interfaccia utente del terminale di pagamento
├── config/index.ts             # Configurazione multi-chain
└── services/
    ├── nfcService.ts           # Lettore NFC & scansione del wallet
    ├── alchemyService.ts       # Bilancio multi-chain & monitoraggio
    ├── paymentService.ts       # Selezione pagamento & generazione EIP-681
    ├── ethereumService.ts      # Utilità di validazione indirizzi
    └── addressProcessor.ts     # Prevenzione elaborazione duplicati
scripts/
└── rpi-deploy/
    ├── setup-build-environment.sh  # Installa le dipendenze per consentire la creazione di un'immagine Raspberry Pi
    └── build-pi-image-osx.sh       # Crea un'immagine Raspberry Pi
```
## 💡 Utilizzo

### **Elaborazione dei Pagamenti**
1. Inserire l'importo utilizzando il tastierino numerico (in centesimi: "150" = €1,50)
2. Toccare "Addebita" per avviare il pagamento
3. Il cliente avvicina il dispositivo NFC per inviare il pagamento
4. Il monitoraggio in tempo reale conferma la transazione
5. Messaggio "Approvato" con link al block explorer

### **Storico delle Transazioni**
1. Toccare il pulsante 📜 dello storico sul tastierino
2. Visualizzare tutte le transazioni o scansionare un portafoglio per uno storico specifico
3. Toccare "📱 Scansiona Portafoglio per Storico" e far avvicinare il dispositivo del cliente
4. Esplorare le transazioni filtrate per quel portafoglio specifico


## 🔄 Flusso di Pagamento

1. **Rilevamento NFC** → Il cliente avvicina il dispositivo
2. **Recupero Multi-Chain** → Analisi del portafoglio su tutte le 6 chain
3. **Selezione Intelligente** → Token di pagamento ottimale in base al sistema di priorità
4. **Generazione EIP-681** → Richiesta di pagamento con ID chain
5. **Monitoraggio in Tempo Reale** → WebSocket/polling per la conferma della transazione
6. **Registrazione Storico** → Transazione archiviata con tutti i metadati
## 🛡️ Monitoraggio delle Transazioni

- **Monitoraggio WebSocket** per Ethereum, Base, Arbitrum, Optimism, Polygon
- **Monitoraggio basato su polling** come fallback
- **Timeout automatico** dopo 5 minuti
- **Integrazione con block explorer** per la verifica delle transazioni
- **Tracciamento dello stato**: rilevato → confermato → fallito

## 🍓 Distribuzione su Raspberry Pi

Questo terminale di pagamento NFC può essere distribuito come **chiosco plug-and-play** su hardware Raspberry Pi per l’uso in produzione.

### **Requisiti Hardware**
- Raspberry Pi 4B (consigliati 4GB+ di RAM)
- Touchscreen ufficiale Raspberry Pi da 7"
- **Lettore NFC ACR1252U-M1** (specificamente supportato)
- Scheda MicroSD da 32GB o superiore

### **Caratteristiche della Distribuzione**
- **Build con un solo comando** crea un’immagine SD card avviabile
- **WiFi preconfigurato** e credenziali API
- **Avvio automatico** con modalità chiosco a schermo intero
- **Validazione di sicurezza** impedisce la distribuzione con indirizzi di test
- Supporto build per **macOS e Linux**
### **Distribuzione Rapida**
```bash
# Vai agli script di distribuzione
cd scripts/rpi-deploy

# Configura la tua distribuzione
cp build-config.env.template build-config.env
# Modifica build-config.env con il tuo WiFi, la chiave API e l'indirizzo del commerciante

# Crea l'immagine avviabile (macOS)
./build-pi-image-osx.sh

# Scrivi il file nfc-terminal-<date>.img.gz generato sulla scheda SD usando Raspberry Pi Imager e avvia!
```

📖 **[Guida Completa alla Distribuzione](https://raw.githubusercontent.com/FreePayPOS/merchant-app/main/README-DEPLOYMENT.md)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---