
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=en">Englisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-CN">Vereinfachtes Chinesisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-TW">Traditionelles Chinesisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ja">Japanisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ko">Koreanisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=hi">Hindi</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=th">Thai</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fr">Französisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=es">Spanisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=it">Italienisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ru">Russisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pt">Portugiesisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=nl">Niederländisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pl">Polnisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ar">Arabisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fa">Persisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=tr">Türkisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=vi">Vietnamesisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=id">Indonesisch</a></p>
      </div>
    </div>
  </details>
</div>

Das CDN-Beschleunigungs- und Sicherheitsangebot für dieses Projekt wird von Tencent EdgeOne gesponsert.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

Der Autor dieses Projekts ist colin1114.

# 🚀 Clash Abonnement-Konverter

Ein optisch ansprechendes und leistungsstarkes Online-Tool, das verschiedene Proxy-Abonnement-Links in das Clash-Konfigurationsformat umwandelt. Unterstützt automatische Bereitstellung über Cloudflare Workers & Pages und bietet schnellen, zuverlässigen Abonnement-Konvertierungsservice.

## ✨ Funktionen und Merkmale

- 🎨 **Modernes und ansprechendes Interface** – Mit Farbverlauf-Hintergrund und Kartendesign
- 🔄 **Mehrprotokoll-Unterstützung** – Unterstützt V2Ray, VLESS, Shadowsocks, Trojan und andere gängige Protokolle
- ☁️ **Cloud Deployment** – Globale CDN-Beschleunigung über Cloudflare Workers
- 📱 **Responsives Design** – Perfekte Anpassung an Desktop und Mobilgeräte
- ⚡ **Schnelle Konvertierung** – Wandelt Abonnement-Links in Echtzeit in Clash-Konfigurationen um
- 📋 **Intelligentes Kopieren** – Ein-Klick-Kopieren der generierten YAML-Konfiguration, kompatibel mit allen Browsern
- 📡 **Abonnement-Link-Generierung** – Automatische Erstellung von Abonnement-Links für direkten Clash-Import
- 🌐 **Online-YAML-Zugriff** – Mehrere Zugriffsmöglichkeiten auf YAML-Dateien:
  - 📡 Abonnement-Link: Automatische Aktualisierung im Clash-Client unterstützt
  - 🔗 Online-Anzeige: Konfigurationsinhalt direkt im Browser ansehen
  - 💾 Dateidownload: .yaml-Datei lokal herunterladen
  - ⚡ Schneller Zugriff: Vereinfachter Download-Link
- 🔧 **UTF-8-Unterstützung** – Vollständige Unterstützung für chinesische Knotennamen und Konfigurationen
- 🆓 **Komplett kostenlos** – Basierend auf dem kostenlosen Cloudflare-Dienst, ohne Nutzungsbeschränkungen

## 📁 Projektstruktur

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

## 🚀 Schnellstart

### Methode 1: Lokale Ausführung

1. **Projekt klonen**
   ```bash
   git clone <repository-url>
   cd clash
   ```
2. **Lokalen Server starten**

   ```bash
   # 使用 Python
   python -m http.server 8000
   
   # 或使用 Node.js
   npx serve .
   ```

3. **Anwendung aufrufen**
   - Öffnen Sie den Browser und rufen Sie `http://localhost:8000` auf
   - In der lokalen Umgebung wird die Beispielkonfiguration angezeigt

### Methode 2: Cloudflare Workers Bereitstellung

#### Schritt 1: Worker erstellen

1. Besuchen Sie [Cloudflare Workers](https://workers.cloudflare.com/)
2. Registrieren/Anmelden bei einem Cloudflare-Konto
3. Klicken Sie auf "Create a Worker"
4. Kopieren Sie den gesamten Code aus `worker.js` in den Editor
5. Klicken Sie auf "Save and Deploy"

#### Schritt 2: Mit Wrangler CLI bereitstellen

```bash
# 安装 Wrangler CLI
npm install -g wrangler

# 登录到 Cloudflare
wrangler login

# 部署 Worker
npm run deploy:worker
```

#### Schritt 3: Domain konfigurieren (optional)

1. Füge eine benutzerdefinierte Domain in den Worker-Einstellungen hinzu
2. Oder verwende die von Cloudflare bereitgestellte Standard-Domain

### Methode 3: Deployment mit Cloudflare Pages

#### Option A: GitHub-Integration (empfohlen)

1. **Repository vorbereiten**
   - Code in ein GitHub-Repository pushen
   - Stelle sicher, dass alle notwendigen Dateien enthalten sind

2. **Pages-Projekt erstellen**
   - Besuche [Cloudflare Pages](https://pages.cloudflare.com/)
   - Verbinde dein GitHub-Repository
   - Wähle das Projekt-Repository aus

3. **Build-Einstellungen**
   - Build-Befehl: leer lassen oder `echo "No build required"`
   - Build-Ausgabeverzeichnis: `/` (Stammverzeichnis)
   - Umgebungsvariablen: keine Einstellungen erforderlich

#### Option B: Direktes Hochladen

```bash
# 使用 Wrangler Pages 部署
npm run deploy:pages
```

## 🛠️ Technische Architektur

### Frontend-Technologie-Stack
- **HTML5** - Moderne Auszeichnungssprache
- **CSS3** - Responsives Design und Animationseffekte
- **Vanilla JavaScript** - Leichtgewichtige Frontend-Interaktionen

### Backend-Technologie-Stack
- **Cloudflare Workers** - Edge-Computing-Plattform
- **Web APIs** - Standard-Fetch API und Antwortverarbeitung

### Unterstützte Protokollformate
- **VMess** - V2Ray Standardprotokoll
- **VLESS** - V2Ray Leichtprotokoll (unterstützt Reality)
- **Shadowsocks** - Klassisches Proxy-Protokoll
- **Trojan** - Modernes Proxy-Protokoll

### API-Endpunkte
- `GET /` - Hauptseite
- `POST /convert` - Abonnement-Konvertierungs-API
- `GET /clash/{config-id}` - YAML-Konfigurationsdatei abrufen (Abonnement-Link)
- `GET /yaml/{config-id}` - YAML-Konfigurationsdatei herunterladen
- `OPTIONS /*` - CORS-Vorabprüfungsanfrage

## 📖 Benutzerhandbuch

### Grundlegende Verwendung

1. **Abonnement-Link eingeben**
   - Füge deinen Proxy-Abonnement-Link in das Eingabefeld ein
   - Unterstützt Base64-codierte Abonnement-Links

2. **Konfigurationsnamen festlegen**
   - Optional kann ein benutzerdefinierter Name für die Konfigurationsdatei vergeben werden
   - Standardmäßig "My Clash Config"

3. **Konfiguration konvertieren**
   - Klicke auf die Schaltfläche "Abonnement konvertieren"
   - Warte bis die Konvertierung abgeschlossen ist

4. **Konfiguration verwenden**
   - Kopieren Sie die generierte YAML-Konfiguration
   - Importieren Sie sie in den Clash-Client zur Nutzung

5. **Verwendung des Abonnement-Links (empfohlen)**
   - Kopieren Sie den generierten Abonnement-Link
   - Abonnement im Clash-Client hinzufügen
   - Die Konfiguration wird automatisch synchronisiert, kein manuelles Update nötig

### Erweiterte Konfiguration

Die generierte Clash-Konfiguration enthält folgende Merkmale:

- **Proxy-Gruppenstrategie**
  - 🚀 Node-Auswahl – Manuelle Proxy-Auswahl
  - ♻️ Automatische Auswahl – Auswahl nach Latenztest
  - 🎯 Globaler Direktzugriff – Direkte Verbindung

- **DNS-Konfiguration**
  - DNS-Auflösung aktivieren
  - Unterstützung für Fake-IP-Modus
  - DNS-Split für Inland und Ausland

- **Routing-Regeln**
  - Lokale Adressen direkt verbinden
  - Inländische IPs direkt verbinden
  - Sonstiger Traffic über Proxy

## 🔧 Fehlerbehebung bei der Bereitstellung

### Häufige Probleme

#### 1. Wrangler findet keinen Einstiegspunkt
**Fehlermeldung**: `Missing entry-point to Worker script`

**Lösung**: 
- Stellen Sie sicher, dass im Projektstammverzeichnis eine `wrangler.jsonc`-Datei vorhanden ist
- Prüfen Sie, ob das `main`-Feld in `wrangler.jsonc` auf `worker.js` verweist

#### 2. GitHub Actions Deployment fehlgeschlagen
**Lösung**:
- Fügen Sie in den Einstellungen des GitHub-Repositorys folgende Secrets hinzu:
  - `CLOUDFLARE_API_TOKEN`: Cloudflare API-Token
  - `CLOUDFLARE_ACCOUNT_ID`: Cloudflare Konten-ID

#### 3. Pages Build fehlgeschlagen
**Lösung**:
- Setzen Sie den Build-Befehl auf leer oder `echo "No build required"`
- Stellen Sie sicher, dass das Build-Ausgabeverzeichnis auf `/` gesetzt ist

### Erläuterung der Deploy-Konfigurationsdateien

- **`wrangler.jsonc`**: Wrangler CLI-Konfiguration für Worker-Deployment
- **`_headers`**: Cloudflare Pages HTTP-Header-Konfiguration
- **`.github/workflows/deploy.yml`**: GitHub Actions Auto-Deployment-Konfiguration

## 🔧 Benutzerdefinierte Konfiguration

### Proxy-Gruppen bearbeiten

Sie können die Funktion `convertToClash` in `worker.js` bearbeiten, um Proxy-Gruppen anzupassen:

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

### Benutzerdefinierte Routing-Regeln

Bearbeiten Sie das Array `rules`, um benutzerdefinierte Routing-Regeln hinzuzufügen:

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 节点选择',
  'DOMAIN-SUFFIX,local,DIRECT',
  // 添加更多规则...
]
```

## 📊 Leistungseigenschaften

- **Globales CDN** - Cloudflare mit Edge-Knoten weltweit
- **Schnelle Reaktion** - Durchschnittliche Antwortzeit < 100ms
- **Hohe Verfügbarkeit** - 99,9% Dienstverfügbarkeit
- **Kostenloses Kontingent** - 100.000 Anfragen pro Tag

## 🔒 Sicherheitshinweise

- **Datenschutz** - Abonnementdaten werden nur während der Konvertierung verwendet und nicht gespeichert
- **HTTPS-Verschlüsselung** - Alle Kommunikation erfolgt über HTTPS verschlüsselt
- **Transparente Open-Source** - Vollständiger Quellcode ist öffentlich einsehbar und kann überprüft werden

## 🤝 Beitragsrichtlinien

Issues und Pull Requests sind willkommen!

1. Forken Sie dieses Repository
2. Erstellen Sie einen Feature-Branch (`git checkout -b feature/AmazingFeature`)
3. Änderungen committen (`git commit -m 'Add some AmazingFeature'`)
4. Pushen Sie auf den Branch (`git push origin feature/AmazingFeature`)
5. Öffnen Sie einen Pull Request

## 📝 Änderungsprotokoll

### v1.1.0
- ✅ Unterstützung für VLESS-Protokoll hinzugefügt (inklusive Reality-Sicherheitstransport)
- ✅ Verbesserte Protokollkompatibilität

### v1.0.0
- ✅ Grundfunktion für Abonnement-Konvertierung
- ✅ Ansprechende Benutzeroberfläche
- ✅ Cloudflare Workers Unterstützung
- ✅ Unterstützung mehrerer Protokolle (VMess, Shadowsocks, Trojan)
- ✅ Responsives Design
- ✅ One-Click-Kopierfunktion

## 📞 Support und Feedback

Wenn du während der Nutzung auf Probleme stößt oder Vorschläge hast, dann:

1. Sieh dir dieses README-Dokument an
2. Reiche ein [Issue](../../issues) ein
3. Starte eine [Discussion](../../discussions)

## 📄 Lizenz

Dieses Projekt verwendet die MIT-Lizenz – siehe die [LICENSE](LICENSE) Datei für Details

## 🙏 Danksagung

- [Cloudflare Workers](https://workers.cloudflare.com/) – stellt die Edge-Computing-Plattform bereit
- [Clash](https://github.com/Dreamacro/clash) – hervorragender Proxy-Client
- Unterstützung aller Mitwirkenden und Nutzer

---

⭐ Wenn dir dieses Projekt geholfen hat, gib ihm bitte einen Star! 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---