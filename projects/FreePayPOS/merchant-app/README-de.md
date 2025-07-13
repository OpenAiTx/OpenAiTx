# NFC-Zahlungsterminal

Ein Multi-Chain-NFC-Zahlungsterminal, das Kryptowährungszahlungen über 5 Blockchain-Netzwerke mit Echtzeit-Transaktionsüberwachung und umfassender Verlaufserfassung abwickelt.

## 🌐 Unterstützte Netzwerke

- **Ethereum**
- **Base**
- **Arbitrum**
- **Optimism**
- **Polygon**

### 🎯 **Intelligente Zahlungspriorität**

Anstatt mit dem Händler eine Kette/Token-Kombination auszuhandeln, übernimmt das Zahlungsterminal dies automatisch. Zuerst wird eine vom Händler unterstützte Kette ermittelt, auf der Sie ebenfalls Guthaben haben, dann wird eine Transaktion mit ETH oder einem ERC-20-Token mit folgender Priorität gesendet:

```
L2 Stablecoin > L2 Andere > L2 ETH > L1 Stablecoin > L1 Andere > L1 ETH
```
## 🚀 Schnellstart

1. **Abhängigkeiten installieren:**
   ```bash
   npm install
   ```

2. **Umgebung einrichten:**
   ```bash
   echo "ALCHEMY_API_KEY=your_alchemy_api_key_here" > .env
   ```

3. **Terminal ausführen:**
   ```bash
   npm start
   ```

4. **Oberfläche öffnen:**
   Navigieren Sie zu `http://localhost:3000`

## 🏗️ Architektur

```
src/
├── server.ts                   # Express-Server & WebSocket-Handler
├── app.ts                      # Hauptanwendungs-Orchestrator
├── web/index.html              # Benutzeroberfläche des Zahlungsterminals
├── config/index.ts             # Multi-Chain-Konfiguration
└── services/
    ├── nfcService.ts           # NFC-Leser & Wallet-Scanning
    ├── alchemyService.ts       # Multi-Chain-Saldo & Überwachung
    ├── paymentService.ts       # Zahlungsauswahl & EIP-681-Generierung
    ├── ethereumService.ts      # Adressvalidierungs-Utilities
    └── addressProcessor.ts     # Verhinderung von doppelter Verarbeitung
scripts/
└── rpi-deploy/
    ├── setup-build-environment.sh  # Installiert Abhängigkeiten, um ein Raspberry Pi-Image zu bauen
    └── build-pi-image-osx.sh       # Erstellt ein Raspberry Pi-Image
```
## 💡 Verwendung

### **Zahlungen verarbeiten**
1. Betrag über das Tastenfeld eingeben (cent-basiert: „150“ = 1,50 €)
2. Auf „Charge“ tippen, um die Zahlung zu starten
3. Kunde hält NFC-Gerät zum Bezahlen an das Terminal
4. Echtzeitüberwachung bestätigt die Transaktion
5. „Genehmigt“-Meldung mit Link zum Block Explorer

### **Transaktionsverlauf**
1. Auf die 📜 Verlaufstaste am Tastenfeld tippen
2. Alle Transaktionen anzeigen oder eine Wallet für spezifische Historie scannen
3. Auf „📱 Wallet für Verlauf scannen“ tippen und den Kunden das Gerät auflegen lassen
4. Gefilterte Transaktionen für diese spezifische Wallet durchsehen


## 🔄 Zahlungsablauf

1. **NFC-Erkennung** → Kunde hält Gerät an das Terminal
2. **Multi-Chain-Abfrage** → Portfolioanalyse über alle 6 Chains
3. **Intelligente Auswahl** → Optimales Zahlungstoken basierend auf Prioritätensystem
4. **EIP-681-Generierung** → Zahlungsanfrage mit Chain-ID
5. **Echtzeitüberwachung** → WebSocket/Polling zur Bestätigung der Transaktion
6. **Verlaufsspeicherung** → Transaktion mit vollständigen Metadaten gespeichert
## 🛡️ Transaktionsüberwachung

- **WebSocket-Überwachung** für Ethereum, Base, Arbitrum, Optimism, Polygon
- **Polling-basierte Überwachung** als Fallback
- **Automatischer Timeout** nach 5 Minuten
- **Blockexplorer-Integration** zur Transaktionsverifizierung
- **Statusverfolgung**: erkannt → bestätigt → fehlgeschlagen

## 🍓 Raspberry Pi Bereitstellung

Dieses NFC-Zahlungsterminal kann als **Plug-and-Play-Kiosk** auf Raspberry Pi Hardware für den Produktionseinsatz bereitgestellt werden.

### **Hardware-Anforderungen**
- Raspberry Pi 4B (4GB+ RAM empfohlen)
- 7" Offizieller Raspberry Pi Touchscreen
- **ACR1252U-M1 NFC-Leser** (speziell unterstützt)
- 32GB+ MicroSD-Karte

### **Bereitstellungsfunktionen**
- **Ein-Befehl-Build** erstellt ein bootfähiges SD-Karten-Image
- **Vorkonfiguriertes WLAN** und API-Zugangsdaten
- **Automatischer Start** im Vollbild-Kioskmodus
- **Sicherheitsvalidierung** verhindert Bereitstellung mit Testadressen
- **macOS und Linux** Build-Unterstützung
### **Schnellbereitstellung**
```bash
# Zu den Bereitstellungsskripten wechseln
cd scripts/rpi-deploy

# Ihre Bereitstellung konfigurieren
cp build-config.env.template build-config.env
# Bearbeiten Sie build-config.env mit Ihrem WLAN, API-Schlüssel und Händleradresse

# Bootfähiges Image erstellen (macOS)
./build-pi-image-osx.sh

# Die generierte Datei nfc-terminal-<date>.img.gz mit Raspberry Pi Imager auf die SD-Karte flashen und starten!
```

📖 **[Vollständige Bereitstellungsanleitung](https://raw.githubusercontent.com/FreePayPOS/merchant-app/main/README-DEPLOYMENT.md)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---