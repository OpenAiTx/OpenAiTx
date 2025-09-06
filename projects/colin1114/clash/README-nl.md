
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=en">Engels</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ja">Japans</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ko">Koreaans</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=hi">Hindi</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=th">Thais</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fr">Frans</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=de">Duits</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=es">Spaans</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=it">Italiaans</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ru">Russisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pt">Portugees</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pl">Pools</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ar">Arabisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fa">Perzisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=tr">Turks</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=vi">Vietnamees</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=id">Indonesisch</a></p>
      </div>
    </div>
  </details>
</div>

CDN-versnelling en beveiligingsbescherming voor dit project worden gesponsord door Tencent EdgeOne.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

De auteur van dit project is colin1114.

# 🚀 Clash Abonnement Converter

Een mooi en krachtig online hulpmiddel om verschillende proxy-abonnementslinks om te zetten naar het Clash-configuratieformaat. Ondersteunt automatische implementatie via Cloudflare Workers & Pages en biedt snelle, betrouwbare abonnementsconversiediensten.

## ✨ Functiekenmerken

- 🎨 **Aantrekkelijke moderne interface** - Gebruik van een verloopachtergrond en kaartontwerp
- 🔄 **Ondersteuning voor meerdere protocollen** - Ondersteunt V2Ray, VLESS, Shadowsocks, Trojan en andere populaire protocollen
- ☁️ **Cloud-implementatie** - Wereldwijde CDN-versnelling via Cloudflare Workers
- 📱 **Responsief ontwerp** - Perfect geschikt voor desktop en mobiel
- ⚡ **Snelle conversie** - Zet abonnementslinks direct om naar Clash-configuratie
- 📋 **Slim kopiëren** - Ondersteunt één-klik kopiëren van de gegenereerde YAML-configuratie, compatibel met alle browsers
- 📡 **Abonnementslink-generatie** - Genereert automatisch een direct importeerbare Clash-abonnementslink
- 🌐 **Online YAML-toegang** - Biedt meerdere manieren om YAML-bestanden te benaderen:
  - 📡 Abonnementslink: ondersteunt automatische updates in de Clash-client
  - 🔗 Online bekijken: bekijk configuratie direct in de browser
  - 💾 Bestandsdownload: download het .yaml-bestand naar je apparaat
  - ⚡ Snelle toegang: vereenvoudigde downloadlink
- 🔧 **UTF-8-ondersteuning** - Volledige ondersteuning voor Chinese node-namen en configuraties
- 🆓 **Volledig gratis** - Gebaseerd op gratis Cloudflare-diensten, zonder gebruiksbeperkingen

## 📁 Projectstructuur

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

## 🚀 Snel starten

### Methode 1: Lokaal uitvoeren

1. **Project klonen**
   ```bash
   git clone <repository-url>
   cd clash
   ```
2. **Start de lokale server**

   ```bash
   # 使用 Python
   python -m http.server 8000
   
   # 或使用 Node.js
   npx serve .
   ```

3. **Toegang tot de applicatie**
   - Open de browser en ga naar `http://localhost:8000`
   - In de lokale omgeving wordt de voorbeeldconfiguratie weergegeven

### Methode 2: Cloudflare Workers implementatie

#### Stap 1: Worker aanmaken

1. Ga naar [Cloudflare Workers](https://workers.cloudflare.com/)
2. Registreer/log in op je Cloudflare-account
3. Klik op "Create a Worker"
4. Kopieer de volledige code uit `worker.js` naar de editor
5. Klik op "Save and Deploy"

#### Stap 2: Deployen met Wrangler CLI

```bash
# 安装 Wrangler CLI
npm install -g wrangler

# 登录到 Cloudflare
wrangler login

# 部署 Worker
npm run deploy:worker
```

#### Stap 3: Domeinnaam configureren (optioneel)

1. Voeg een aangepaste domeinnaam toe in de Worker-instellingen
2. Of gebruik de standaarddomeinnaam die door Cloudflare wordt geleverd

### Methode drie: Cloudflare Pages implementatie

#### Optie A: GitHub-integratie (aanbevolen)

1. **Repository voorbereiden**
   - Push de code naar een GitHub-repository
   - Zorg dat alle benodigde bestanden zijn inbegrepen

2. **Pages-project aanmaken**
   - Bezoek [Cloudflare Pages](https://pages.cloudflare.com/)
   - Verbind je GitHub-repository
   - Selecteer de projectrepository

3. **Build-instellingen**
   - Build-commando: leeg laten of `echo "No build required"`
   - Build-uitvoermap: `/` (rootmap)
   - Omgevingsvariabelen: geen instellingen nodig

#### Optie B: Direct uploaden

```bash
# 使用 Wrangler Pages 部署
npm run deploy:pages
```

## 🛠️ Technische Architectuur

### Frontend Technologie Stack
- **HTML5** - Moderne markup-taal
- **CSS3** - Responsief ontwerp en animatie-effecten
- **Vanilla JavaScript** - Lichtgewicht frontend-interactie

### Backend Technologie Stack
- **Cloudflare Workers** - Edge computing platform
- **Web APIs** - Standaard Fetch API en response-afhandeling

### Ondersteunde protocolformaten
- **VMess** - V2Ray standaardprotocol
- **VLESS** - V2Ray lichtgewicht protocol (ondersteunt Reality)
- **Shadowsocks** - Klassiek proxyprotocol
- **Trojan** - Opkomend proxyprotocol

### API Endpoints
- `GET /` - Hoofdpagina
- `POST /convert` - Subscriptie-conversie API
- `GET /clash/{config-id}` - Haal YAML-configuratiebestand op (subscriptielink)
- `GET /yaml/{config-id}` - Download YAML-configuratiebestand
- `OPTIONS /*` - CORS preflight-verzoeken

## 📖 Gebruiksaanwijzing

### Basisgebruik

1. **Voer subscriptielink in**
   - Plak je proxy-subscriptielink in het invoerveld
   - Ondersteunt Base64-gecodeerde subscriptielinks

2. **Stel configuratienaam in**
   - Optioneel een aangepaste naam geven aan het configuratiebestand
   - Standaard is "Mijn Clash Config"

3. **Converteer configuratie**
   - Klik op de knop "Subscriptie converteren"
   - Wacht tot de conversie voltooid is

4. **Configuratie gebruiken**
   - Kopieer de gegenereerde YAML-configuratie
   - Importeer deze in de Clash-client om te gebruiken

5. **Gebruik van abonnementslink (aanbevolen)**
   - Kopieer de gegenereerde abonnementslink
   - Voeg het abonnement toe in de Clash-client
   - Configuratie wordt automatisch gesynchroniseerd, handmatig updaten is niet nodig

### Geavanceerde configuratie

De gegenereerde Clash-configuratie bevat de volgende kenmerken:

- **Proxygroepbeleid**
  - 🚀 Node-selectie - Handmatig proxy kiezen
  - ♻️ Automatische selectie - Automatische keuze op basis van vertragingstest
  - 🎯 Wereldwijd directe verbinding - Direct verbinden

- **DNS-configuratie**
  - DNS-resolutie inschakelen
  - Ondersteuning voor fake-ip modus
  - DNS-splitsing voor binnen- en buitenland

- **Routeringsregels**
  - Lokale adressen direct verbinden
  - Binnenlandse IP’s direct verbinden
  - Overig verkeer via proxy laten lopen

## 🔧 Problemen met implementatie oplossen

### Veelvoorkomende problemen

#### 1. Wrangler kan het entrypoint niet vinden
**Foutmelding**: `Missing entry-point to Worker script`

**Oplossing**: 
- Zorg ervoor dat er een `wrangler.jsonc` bestand is in de hoofdmap van het project
- Controleer of het `main` veld in `wrangler.jsonc` verwijst naar `worker.js`

#### 2. GitHub Actions Deploy Mislukt
**Oplossing**:
- Voeg de volgende Secrets toe in de GitHub repository-instellingen:
  - `CLOUDFLARE_API_TOKEN`: Cloudflare API-token
  - `CLOUDFLARE_ACCOUNT_ID`: Cloudflare account-ID

#### 3. Pages Build Mislukt
**Oplossing**:
- Stel het build-commando in op leeg of `echo "No build required"`
- Zorg ervoor dat de build-outputdirectory is ingesteld op `/`

### Uitleg van Deploy Configuratiebestanden

- **`wrangler.jsonc`**: Wrangler CLI-configuratie voor Worker-deployment
- **`_headers`**: Cloudflare Pages HTTP-headerconfiguratie
- **`.github/workflows/deploy.yml`**: GitHub Actions automatische deploy-configuratie

## 🔧 Aangepaste Configuratie

### Proxygroep Wijzigen

Je kunt de functie `convertToClash` in `worker.js` bewerken om proxygroepen aan te passen:

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

### Aangepaste routeringsregels

Wijzig de `rules` array om aangepaste routeringsregels toe te voegen:

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 节点选择',
  'DOMAIN-SUFFIX,local,DIRECT',
  // 添加更多规则...
]
```

## 📊 Prestatiekenmerken

- **Globale CDN** - Cloudflare met wereldwijde edge nodes
- **Snelle respons** - Gemiddelde responstijd < 100ms
- **Hoge beschikbaarheid** - 99,9% service beschikbaarheid
- **Gratis limiet** - 100.000 verzoeken per dag

## 🔒 Veiligheidsverklaring

- **Gegevensprivacy** - Abonnementsgegevens worden alleen gebruikt tijdens conversie, niet opgeslagen
- **HTTPS-encryptie** - Alle communicatie is versleuteld via HTTPS
- **Open source transparantie** - Volledige broncode openbaar, zelf te auditen

## 🤝 Bijdragegids

Issues en Pull Requests zijn welkom!

1. Fork deze repository
2. Maak een feature branch aan (`git checkout -b feature/AmazingFeature`)
3. Commit je wijzigingen (`git commit -m 'Add some AmazingFeature'`)
4. Push naar de branch (`git push origin feature/AmazingFeature`)
5. Start een Pull Request

## 📝 Wijzigingslog

### v1.1.0
- ✅ VLESS-protocol ondersteuning toegevoegd (inclusief Reality beveiligde overdracht)
- ✅ Verbeterde protocolcompatibiliteit

### v1.0.0
- ✅ Basisfunctie voor abonnementsconversie
- ✅ Fraaie gebruikersinterface
- ✅ Cloudflare Workers ondersteuning
- ✅ Ondersteuning voor meerdere protocollen (VMess, Shadowsocks, Trojan)
- ✅ Responsief ontwerp
- ✅ One-click kopieerfunctie

## 📞 Support en feedback

Als je tijdens het gebruik problemen ondervindt of suggesties hebt, doe dan het volgende:

1. Bekijk dit README-document
2. Dien een [Issue](../../issues) in
3. Start een [Discussion](../../discussions)

## 📄 Licentie

Dit project gebruikt de MIT-licentie – zie het [LICENSE](LICENSE) bestand voor meer informatie

## 🙏 Dankbetuigingen

- [Cloudflare Workers](https://workers.cloudflare.com/) – biedt edge computing platform
- [Clash](https://github.com/Dreamacro/clash) – uitstekende proxy-client
- Alle bijdragers en gebruikers voor hun steun

---

⭐ Als dit project je heeft geholpen, geef het dan een Star! 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---