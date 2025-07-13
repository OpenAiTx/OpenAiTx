# NFC-betalterminal

Een multi-chain NFC-betalterminal die cryptobetalingen verwerkt over 5 blockchainnetwerken met realtime transactiebewaking en uitgebreide geschiedenistracking.

## 🌐 Ondersteunde netwerken

- **Ethereum**
- **Base**
- **Arbitrum**
- **Optimism**
- **Polygon**

### 🎯 **Slimme betalingsprioriteit**

In plaats van een keten/token-combinatie met de handelaar te onderhandelen, regelt de betaalterminal dit automatisch. Eerst zoekt het een keten die de handelaar ondersteunt en waarop jij ook tegoeden hebt, en vervolgens verzendt het een transactie met ETH of een ERC-20-token met deze prioriteit:

```
L2 Stablecoin > L2 Overige > L2 ETH > L1 Stablecoin > L1 Overige > L1 ETH
```
## 🚀 Snel Starten

1. **Installeer afhankelijkheden:**
   ```bash
   npm install
   ```

2. **Omgevingsinstellingen:**
   ```bash
   echo "ALCHEMY_API_KEY=je_alchemy_api_sleutel_hier" > .env
   ```

3. **Start de terminal:**
   ```bash
   npm start
   ```

4. **Open de interface:**
   Navigeer naar `http://localhost:3000`
## 🏗️ Architectuur

```
src/
├── server.ts                   # Express-server & WebSocket-handler
├── app.ts                      # Hoofdapplicatie-orchestrator
├── web/index.html              # Betaalterminal UI
├── config/index.ts             # Multi-chain configuratie
└── services/
    ├── nfcService.ts           # NFC-lezer & wallet-scanning
    ├── alchemyService.ts       # Multi-chain balans & monitoring
    ├── paymentService.ts       # Betalingsselectie & EIP-681-generatie
    ├── ethereumService.ts      # Adresvalidatie-hulpprogramma's
    └── addressProcessor.ts     # Preventie van dubbele verwerking
scripts/
└── rpi-deploy/
    ├── setup-build-environment.sh  # Installeer afhankelijkheden om het bouwen van een Raspberry Pi-image mogelijk te maken
    └── build-pi-image-osx.sh       # Bouw een Raspberry Pi-image
```
## 💡 Gebruik

### **Betalingen Verwerken**
1. Voer het bedrag in met het toetsenbord (in centen: "150" = €1,50)
2. Tik op "Afrekenen" om de betaling te starten
3. Klant tikt met NFC-apparaat om betaling te verzenden
4. Realtime monitoring bevestigt de transactie
5. "Goedgekeurd" bericht met block explorer-link

### **Transactiegeschiedenis**
1. Tik op de 📜 geschiedenis-knop op het toetsenbord
2. Bekijk alle transacties of scan een wallet voor specifieke geschiedenis
3. Tik op "📱 Scan Wallet voor Geschiedenis" en laat de klant hun apparaat tikken
4. Blader door gefilterde transacties voor die specifieke wallet


## 🔄 Betalingsstroom

1. **NFC-detectie** → Klant tikt apparaat
2. **Multi-Chain Ophalen** → Portefeuille-analyse over alle 6 ketens
3. **Slimme Selectie** → Optimale betaalmunt op basis van prioriteitensysteem
4. **EIP-681 Generatie** → Betalingsverzoek met chain ID
5. **Realtime Monitoring** → WebSocket/polling voor transactiebevestiging
6. **Geschiedenis Logging** → Transactie opgeslagen met volledige metadata
## 🛡️ Transactiemonitoring

- **WebSocket-monitoring** voor Ethereum, Base, Arbitrum, Optimism, Polygon
- **Polling-gebaseerde monitoring** als fallback
- **Automatische timeout** na 5 minuten
- **Blokverkenner-integratie** voor transactie-verificatie
- **Status-tracking**: gedetecteerd → bevestigd → mislukt

## 🍓 Raspberry Pi Implementatie

Deze NFC-betaalterminal kan als een **plug-and-play kiosk** worden geïmplementeerd op Raspberry Pi-hardware voor productiegebruik.

### **Hardwarevereisten**
- Raspberry Pi 4B (4GB+ RAM aanbevolen)
- 7" Officieel Raspberry Pi Touchscreen
- **ACR1252U-M1 NFC-lezer** (specifiek ondersteund)
- 32GB+ MicroSD-kaart

### **Implementatiefuncties**
- **One-command build** maakt een opstartbaar SD-kaartimage aan
- **Vooraf geconfigureerde WiFi** en API-gegevens
- **Automatisch opstarten** met fullscreen kioskmodus
- **Veiligheidsvalidatie** voorkomt implementatie met testadressen
- **macOS- en Linux**-buildondersteuning
### **Snelle Implementatie**
```bash
# Ga naar de deployment scripts
cd scripts/rpi-deploy

# Configureer je deployment
cp build-config.env.template build-config.env
# Bewerk build-config.env met je WiFi, API-sleutel en handelsadres

# Bouw het opstartbare image (macOS)
./build-pi-image-osx.sh

# Flash het gegenereerde nfc-terminal-<date>.img.gz bestand naar de SD-kaart met Raspberry Pi Imager en start op!
```

📖 **[Volledige Deploymentsgids](https://raw.githubusercontent.com/FreePayPOS/merchant-app/main/README-DEPLOYMENT.md)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---