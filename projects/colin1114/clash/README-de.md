CDN-Beschleunigung und Sicherheits­schutz für dieses Projekt werden von Tencent EdgeOne gesponsert.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

Der Autor dieses Projekts ist colin1114.

# 🚀 Clash Abonnement-Konverter

Ein ansprechendes und leistungsstarkes Online-Tool, das verschiedene Proxy-Abonnement-Links in das Clash-Konfigurationsformat umwandelt. Unterstützt die automatische Bereitstellung über Cloudflare Workers & Pages und bietet einen schnellen, zuverlässigen Abonnement-Konvertierungsdienst.

## ✨ Funktionsmerkmale

- 🎨 **Modernes und ansprechendes Design** – Mit Farbverlauf-Hintergrund und Kartenlayout
- 🔄 **Mehrprotokoll-Unterstützung** – Unterstützt gängige Protokolle wie V2Ray, VLESS, Shadowsocks, Trojan usw.
- ☁️ **Cloud-Deployment** – Globale CDN-Beschleunigung durch Cloudflare Workers
- 📱 **Responsives Design** – Perfekte Anpassung an Desktop- und Mobilgeräte
- ⚡ **Schnelle Konvertierung** – Echtzeit-Umwandlung von Abonnement-Links in Clash-Konfigurationen
- 📋 **Intelligentes Kopieren** – Unterstützung für das Kopieren der generierten YAML-Konfiguration mit einem Klick, kompatibel mit allen Browsern
- 📡 **Abonnement-Link-Generierung** – Automatische Generierung von Abonnement-Links, die direkt in Clash importiert werden können
- 🌐 **Online-YAML-Zugriff** – Verschiedene Möglichkeiten zum Zugriff auf YAML-Dateien:
  - 📡 Abonnement-Link: Unterstützung für automatische Updates im Clash-Client
  - 🔗 Online-Anzeige: Direktes Anzeigen der Konfiguration im Browser
  - 💾 Datei-Download: Download der .yaml-Datei auf den lokalen Rechner
  - ⚡ Schneller Zugriff: Vereinfachte Download-Links
- 🔧 **UTF-8-Unterstützung** – Perfekte Unterstützung für chinesische Knotennamen und Konfigurationen
- 🆓 **Vollständig kostenlos** – Basierend auf den kostenlosen Diensten von Cloudflare, keine Nutzungseinschränkungen

## 📁 Projektstruktur

```
clash/
├── index.html              # Frontend-Seite
├── worker.js               # Cloudflare Worker Backend-Code
├── wrangler.jsonc          # Wrangler Konfigurationsdatei
├── _headers                # Cloudflare Pages HTTP-Header-Konfiguration
├── .github/
│   └── workflows/
│       └── deploy.yml      # GitHub Actions Deployment-Konfiguration
├── README.md              # Projektbeschreibung
└── package.json           # Projektkonfigurationsdatei
```

## 🚀 Schnellstart

### Methode 1: Lokal ausführen

1. **Projekt klonen**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **Lokalen Server starten**
   ```bash
   # Mit Python
   python -m http.server 8000
   
   # Oder mit Node.js
   npx serve .
   ```

3. **Anwendung aufrufen**
   - Im Browser `http://localhost:8000` öffnen
   - In der lokalen Umgebung wird eine Beispielkonfiguration angezeigt

### Methode 2: Deployment über Cloudflare Workers

#### Schritt 1: Worker erstellen

1. Besuche [Cloudflare Workers](https://workers.cloudflare.com/)
2. Registriere dich/melde dich bei Cloudflare an
3. Klicke auf "Create a Worker"
4. Kopiere den gesamten Code aus `worker.js` in den Editor
5. Klicke auf "Save and Deploy"

#### Schritt 2: Deployment mit Wrangler CLI

```bash
# Wrangler CLI installieren
npm install -g wrangler

# Bei Cloudflare anmelden
wrangler login

# Worker bereitstellen
npm run deploy:worker
```

#### Schritt 3: Domain konfigurieren (optional)

1. Füge in den Worker-Einstellungen eine eigene Domain hinzu
2. Oder verwende die von Cloudflare bereitgestellte Standarddomain

### Methode 3: Deployment über Cloudflare Pages

#### Option A: GitHub-Integration (empfohlen)

1. **Repository vorbereiten**
   - Code ins GitHub-Repository pushen
   - Sicherstellen, dass alle notwendigen Dateien enthalten sind
2. **Pages-Projekt erstellen**
   - Besuche [Cloudflare Pages](https://pages.cloudflare.com/)
   - Verbinde dein GitHub-Repository
   - Wähle das Projekt-Repository aus

3. **Build-Einstellungen**
   - Build-Befehl: Leer lassen oder `echo "No build required"`
   - Build-Ausgabeverzeichnis: `/` (Root-Verzeichnis)
   - Umgebungsvariablen: Keine Einstellung erforderlich

#### Option B: Direktes Hochladen

```bash
# Deployment mit Wrangler Pages
npm run deploy:pages
```

## 🛠️ Technische Architektur

### Frontend-Technologie-Stack
- **HTML5** – Moderne Auszeichnungssprache
- **CSS3** – Responsives Design und Animationseffekte
- **Vanilla JavaScript** – Leichtgewichtige Frontend-Interaktionen

### Backend-Technologie-Stack
- **Cloudflare Workers** – Edge-Computing-Plattform
- **Web APIs** – Standard-Fetch-API und Response-Handling

### Unterstützte Protokollformate
- **VMess** – V2Ray Standardprotokoll
- **VLESS** – V2Ray Leichtgewichtsprotokoll (unterstützt Reality)
- **Shadowsocks** – Klassisches Proxy-Protokoll
- **Trojan** – Modernes Proxy-Protokoll

### API-Endpunkte
- `GET /` – Hauptseite
- `POST /convert` – API zur Abonnement-Konvertierung
- `GET /clash/{config-id}` – Abrufen der YAML-Konfigurationsdatei (Abo-Link)
- `GET /yaml/{config-id}` – YAML-Konfigurationsdatei herunterladen
- `OPTIONS /*` – CORS-Preflight-Anfrage

## 📖 Benutzerhandbuch

### Grundlegende Nutzung

1. **Abonnement-Link eingeben**
   - Füge deinen Proxy-Abonnement-Link in das Eingabefeld ein
   - Unterstützt Base64-codierte Abonnement-Links

2. **Konfigurationsnamen festlegen**
   - Optional kann ein individueller Name für die Konfigurationsdatei vergeben werden
   - Standardmäßig "My Clash Config"

3. **Konfiguration konvertieren**
   - Klicke auf die Schaltfläche "Abonnement konvertieren"
   - Warte, bis die Konvertierung abgeschlossen ist

4. **Konfiguration verwenden**
   - Kopiere die generierte YAML-Konfiguration
   - Importiere sie in den Clash-Client

5. **Abonnement-Link verwenden (empfohlen)**
   - Kopiere den generierten Abonnement-Link
   - Füge den Link im Clash-Client als Abonnement hinzu
   - Die Konfiguration wird automatisch synchronisiert, kein manuelles Update nötig

### Erweiterte Konfiguration

Die generierte Clash-Konfiguration enthält folgende Eigenschaften:

- **Proxy-Gruppenstrategie**
  - 🚀 Node-Auswahl – Manuelle Proxy-Auswahl
  - ♻️ Automatische Auswahl – Latenztest und automatische Auswahl
  - 🎯 Global Direct – Direkte Verbindung

- **DNS-Konfiguration**
  - DNS-Auflösung aktiviert
  - Unterstützt Fake-IP-Modus
  - Aufteilung von DNS inländisch/ausländisch

- **Routing-Regeln**
  - Lokale Adressen direkt verbinden
  - Inländische IPs direkt verbinden
  - Anderer Traffic über Proxy

## 🔧 Fehlerbehebung beim Deployment

### Häufige Probleme

#### 1. Wrangler findet keinen Einstiegspunkt
**Fehlermeldung**: `Missing entry-point to Worker script`

**Lösung**:
- Stelle sicher, dass sich im Projekt-Root ein `wrangler.jsonc` befindet
- Prüfe, ob das Feld `main` in `wrangler.jsonc` auf `worker.js` verweist

#### 2. GitHub Actions Deployment schlägt fehl
**Lösung**:
- Füge in den Einstellungen des GitHub-Repositories folgende Secrets hinzu:
- `CLOUDFLARE_API_TOKEN`: Cloudflare API-Token
- `CLOUDFLARE_ACCOUNT_ID`: Cloudflare Konto-ID

#### 3. Pages-Build fehlgeschlagen
**Lösung**:
- Setze den Build-Befehl auf leer oder `echo "No build required"`
- Stelle sicher, dass das Build-Ausgabeverzeichnis auf `/` gesetzt ist

### Erläuterung der Deployment-Konfigurationsdateien

- **`wrangler.jsonc`**: Wrangler CLI Konfiguration für Worker-Deployments
- **`_headers`**: Cloudflare Pages HTTP-Header-Konfiguration
- **`.github/workflows/deploy.yml`**: GitHub Actions Konfiguration für automatisches Deployment

## 🔧 Benutzerdefinierte Konfiguration

### Proxy-Gruppen anpassen

Du kannst die Funktion `convertToClash` in `worker.js` bearbeiten, um Proxy-Gruppen individuell anzupassen:

```javascript
'proxy-groups': [
  {
    name: '🚀 节odenauswahl',
    type: 'select',
    proxies: ['♻️ Automatische Auswahl', '🎯 Global Direkt', ...proxyNames]
  },
  // Füge weitere Proxy-Gruppen hinzu ...
]
```

### Benutzerdefinierte Routing-Regeln

Bearbeite das Array `rules`, um eigene Routing-Regeln hinzuzufügen:

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 节odenauswahl',
  'DOMAIN-SUFFIX,local,DIRECT',
  // Füge weitere Regeln hinzu ...
]
```

## 📊 Performance-Features

- **Globales CDN** – Cloudflare deckt Edge-Standorte weltweit ab
- **Schnelle Reaktion** – Durchschnittliche Antwortzeit < 100ms
- **Hohe Verfügbarkeit** – 99,9% Serviceverfügbarkeit
- **Freies Kontingent** – 100.000 Anfragen pro Tag

## 🔒 Sicherheitshinweise

- **Datenschutz** – Abonnierten Daten werden nur während der Konvertierung verwendet und nicht gespeichert
- **HTTPS-Verschlüsselung** – Sämtliche Kommunikation ist per HTTPS verschlüsselt
- **Open Source & Transparenz** – Vollständiger Quellcode ist öffentlich und kann überprüft werden

## 🤝 Beitragshinweise

Beiträge in Form von Issues und Pull Requests sind willkommen!

1. Forke dieses Repository
2. Erstelle einen Feature-Branch (`git checkout -b feature/AmazingFeature`)
3. Übertrage deine Änderungen (`git commit -m 'Add some AmazingFeature'`)
4. Push in den Branch (`git push origin feature/AmazingFeature`)
5. Erstelle einen Pull Request

## 📝 Changelog

### v1.1.0
- ✅ Unterstützung für VLESS-Protokoll hinzugefügt (inklusive Reality-Sicherheitstransport)
- ✅ Verbesserte Protokollkompatibilität

### v1.0.0
- ✅ Basis-Abonnement-Konvertierungsfunktion
- ✅ Ansprechende Benutzeroberfläche
- ✅ Unterstützung für Cloudflare Workers
- ✅ Multiprotokoll-Unterstützung (VMess, Shadowsocks, Trojan)
- ✅ Responsives Design
- ✅ One-Click-Kopierfunktion

## 📞 Support & Feedback

Wenn du während der Nutzung Probleme oder Vorschläge hast:

1. Lies bitte dieses README
2. Reiche ein [Issue](../../issues) ein
3. Starte eine [Discussion](../../discussions)

## 📄 Lizenz

Dieses Projekt steht unter der MIT-Lizenz – siehe [LICENSE](LICENSE) Datei

## 🙏 Danksagung

- [Cloudflare Workers](https://workers.cloudflare.com/) – Bereitstellung der Edge-Computing-Plattform
- [Clash](https://github.com/Dreamacro/clash) – Ausgezeichneter Proxy-Client
- Allen Mitwirkenden und Nutzern für ihre Unterstützung

---
⭐ Wenn dieses Projekt für dich hilfreich ist, gib ihm bitte einen Stern!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---