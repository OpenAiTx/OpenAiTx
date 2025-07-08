CDN-versnelling en beveiligingsbescherming voor dit project worden gesponsord door Tencent EdgeOne.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

De auteur van dit project is colin1114.

# 🚀 Clash Abonnement Converter

Een fraai vormgegeven en krachtige online tool voor het omzetten van verschillende proxy-abonnementslinks naar het Clash-configuratieformaat. Ondersteunt automatische implementatie via Cloudflare Workers & Pages en biedt snelle, betrouwbare abonnementsconversie.

## ✨ Functies en Kenmerken

- 🎨 **Moderne en aantrekkelijke interface** - Met een verloop-achtergrond en kaartontwerp
- 🔄 **Ondersteuning voor meerdere protocollen** - Ondersteunt de belangrijkste protocollen zoals V2Ray, VLESS, Shadowsocks, Trojan, enz.
- ☁️ **Cloudimplementatie** - Wereldwijde CDN-versnelling via Cloudflare Workers
- 📱 **Responsief ontwerp** - Perfect geschikt voor zowel desktop als mobiel
- ⚡ **Snelle conversie** - Zet abonnementslinks realtime om naar Clash-configuratie
- 📋 **Slim kopiëren** - Ondersteunt een-klik kopiëren van de gegenereerde YAML-configuratie, compatibel met verschillende browsers
- 📡 **Abonnementslink generator** - Genereert automatisch een link die direct in Clash geïmporteerd kan worden
- 🌐 **Online YAML-toegang** - Biedt meerdere manieren om YAML-bestanden te benaderen:
  - 📡 Abonnementslink: ondersteunt automatische updates in de Clash-client
  - 🔗 Online bekijken: bekijk de configuratie direct in de browser
  - 💾 Bestand downloaden: download het .yaml-bestand naar je lokale apparaat
  - ⚡ Snelle toegang: vereenvoudigde downloadlink
- 🔧 **UTF-8 ondersteuning** - Volledige ondersteuning voor Chinese node-namen en configuraties
- 🆓 **Volledig gratis** - Gebaseerd op de gratis dienst van Cloudflare, zonder gebruiksbeperkingen

## 📁 Projectstructuur

```
clash/
├── index.html              # Frontend pagina
├── worker.js               # Cloudflare Worker backend code
├── wrangler.jsonc          # Wrangler configuratiebestand
├── _headers                # Cloudflare Pages HTTP-headerconfiguratie
├── .github/
│   └── workflows/
│       └── deploy.yml      # GitHub Actions implementatieconfiguratie
├── README.md              # Projectdocumentatie
└── package.json           # Projectconfiguratiebestand
```

## 🚀 Snel aan de slag

### Methode 1: Lokaal uitvoeren

1. **Project klonen**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **Start lokale server**
   ```bash
   # Met Python
   python -m http.server 8000

   # Of met Node.js
   npx serve .
   ```

3. **Open de applicatie**
   - Open de browser en ga naar `http://localhost:8000`
   - In de lokale omgeving wordt een voorbeeldconfiguratie getoond

### Methode 2: Cloudflare Workers implementatie

#### Stap 1: Maak een Worker aan

1. Ga naar [Cloudflare Workers](https://workers.cloudflare.com/)
2. Registreer/log in op je Cloudflare-account
3. Klik op "Create a Worker"
4. Kopieer de volledige code uit `worker.js` naar de editor
5. Klik op "Save and Deploy"

#### Stap 2: Deploy met Wrangler CLI

```bash
# Installeer Wrangler CLI
npm install -g wrangler

# Log in bij Cloudflare
wrangler login

# Deploy Worker
npm run deploy:worker
```

#### Stap 3: Domein instellen (optioneel)

1. Voeg een aangepast domein toe in de Worker-instellingen
2. Of gebruik het standaarddomein van Cloudflare

### Methode 3: Cloudflare Pages implementatie

#### Optie A: GitHub integratie (aanbevolen)

1. **Bereid de repository voor**
   - Push de code naar een GitHub-repository
   - Zorg ervoor dat alle benodigde bestanden aanwezig zijn
2. **Een Pages-project aanmaken**
   - Bezoek [Cloudflare Pages](https://pages.cloudflare.com/)
   - Verbind je GitHub-repository
   - Selecteer de projectrepository

3. **Build-instellingen**
   - Build-commando: leeg laten of `echo "No build required"`
   - Build-uitvoermap: `/` (rootmap)
   - Omgevingsvariabelen: niet nodig

#### Optie B: Direct uploaden

```bash
# Deployen met Wrangler Pages
npm run deploy:pages
```

## 🛠️ Technische architectuur

### Frontend-technologiestack
- **HTML5** - Moderne opmaaktalen
- **CSS3** - Responsief ontwerp en animatie
- **Vanilla JavaScript** - Lichtgewicht frontend-interactie

### Backend-technologiestack
- **Cloudflare Workers** - Edge computing platform
- **Web API's** - Standaard Fetch API en response-afhandeling

### Ondersteunde protocolformaten
- **VMess** - V2Ray-standaardprotocol
- **VLESS** - V2Ray-lichtgewichtprotocol (ondersteunt Reality)
- **Shadowsocks** - Klassiek proxyprotocol
- **Trojan** - Modern proxyprotocol

### API-eindpunten
- `GET /` - Hoofdpagina
- `POST /convert` - Subscription conversie-API
- `GET /clash/{config-id}` - Haal YAML-configuratiebestand op (abonnementslink)
- `GET /yaml/{config-id}` - Download YAML-configuratiebestand
- `OPTIONS /*` - CORS preflight-verzoek

## 📖 Gebruiksaanwijzing

### Basisgebruik

1. **Voer de abonnementslink in**
   - Plak je proxy-abonnementslink in het invoerveld
   - Ondersteunt Base64-gecodeerde abonnementslinks

2. **Configuratienaam instellen**
   - Optioneel een aangepaste naam voor het configuratiebestand instellen
   - Standaard is "My Clash Config"

3. **Configuratie converteren**
   - Klik op de knop "Converteren"
   - Wacht tot de conversie voltooid is

4. **Configuratie gebruiken**
   - Kopieer de gegenereerde YAML-configuratie
   - Importeer deze in de Clash-client

5. **Gebruik de abonnementslink (aanbevolen)**
   - Kopieer de gegenereerde abonnementslink
   - Voeg deze toe in de Clash-client
   - Configuratie wordt automatisch gesynchroniseerd, geen handmatige updates nodig

### Geavanceerde configuratie

De gegenereerde Clash-configuratie bevat de volgende kenmerken:

- **Proxygroepbeleid**
  - 🚀 Node Selectie - Handmatig proxy kiezen
  - ♻️ Automatische selectie - Automatisch kiezen op basis van latency-tests
  - 🎯 Global Direct - Directe verbinding

- **DNS-instellingen**
  - DNS-resolutie ingeschakeld
  - Ondersteunt fake-ip-modus
  - DNS-splitting binnen/buitenland

- **Routeregels**
  - Lokale adressen direct verbinden
  - Chinese IP's direct verbinden
  - Overig verkeer via proxy

## 🔧 Foutopsporing bij deployment

### Veelvoorkomende problemen

#### 1. Wrangler kan het entry-point niet vinden
**Foutmelding**: `Missing entry-point to Worker script`

**Oplossing**: 
- Zorg dat er een `wrangler.jsonc` bestand in de rootmap van het project staat
- Controleer of het `main` veld in `wrangler.jsonc` verwijst naar `worker.js`

#### 2. GitHub Actions deployment mislukt
**Oplossing**:
- Voeg de volgende Secrets toe in de instellingen van je GitHub-repository:
  - `CLOUDFLARE_API_TOKEN`: Cloudflare API-token
  - `CLOUDFLARE_ACCOUNT_ID`: Cloudflare account-ID

#### 3. Pages build mislukt
**Oplossing**:
- Stel het build-commando in op leeg of `echo "No build required"`
- Zorg ervoor dat de build-uitvoermap is ingesteld op `/`

### Uitleg van de deployconfiguratiebestanden

- **`wrangler.jsonc`**: Wrangler CLI-configuratie voor Worker-deploy
- **`_headers`**: Cloudflare Pages HTTP-headerconfiguratie
- **`.github/workflows/deploy.yml`**: GitHub Actions automatische deployconfiguratie

## 🔧 Aangepaste configuratie

### Proxygroepen wijzigen

Je kunt de functie `convertToClash` in `worker.js` bewerken om proxygroepen aan te passen:

```javascript
'proxy-groups': [
  {
    name: '🚀 Nodekeuze',
    type: 'select',
    proxies: ['♻️ Automatische selectie', '🎯 Wereldwijde directe verbinding', ...proxyNames]
  },
  // Meer proxygroepen toevoegen...
]
```

### Aangepaste routeregels

Wijzig de array `rules` om aangepaste routeregels toe te voegen:

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 Nodekeuze',
  'DOMAIN-SUFFIX,local,DIRECT',
  // Meer regels toevoegen...
]
```

## 📊 Prestatiekenmerken

- **Wereldwijde CDN** - Cloudflare heeft een wereldwijde edge node-dekking
- **Snelle respons** - Gemiddelde responstijd < 100ms
- **Hoge beschikbaarheid** - 99,9% servicebeschikbaarheid
- **Gratis limiet** - 100.000 verzoeken per dag

## 🔒 Veiligheidsverklaring

- **Gegevensprivacy** - Abonnementsgegevens worden alleen gebruikt tijdens conversie en niet opgeslagen
- **HTTPS-versleuteling** - Alle communicatie is versleuteld via HTTPS
- **Open source transparantie** - Volledige broncode is openbaar en kan zelf worden gecontroleerd

## 🤝 Richtlijnen voor bijdragen

Issues en Pull Requests zijn van harte welkom!

1. Fork deze repository
2. Maak een feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit je wijzigingen (`git commit -m 'Add some AmazingFeature'`)
4. Push naar de branch (`git push origin feature/AmazingFeature`)
5. Maak een Pull Request aan

## 📝 Changelog

### v1.1.0
- ✅ Ondersteuning voor VLESS-protocol toegevoegd (inclusief Reality-beveiligde overdracht)
- ✅ Verbeterde protocolcompatibiliteit

### v1.0.0
- ✅ Basis abonnementconversie
- ✅ Mooie gebruikersinterface
- ✅ Cloudflare Workers-ondersteuning
- ✅ Multi-protocolondersteuning (VMess, Shadowsocks, Trojan)
- ✅ Responsief design
- ✅ One-click kopieerfunctie

## 📞 Support en feedback

Als je problemen ondervindt tijdens het gebruik of suggesties hebt, graag:

1. Bekijk deze README-documentatie
2. Dien een [Issue](../../issues) in
3. Start een [Discussion](../../discussions)

## 📄 Licentie

Dit project is gelicentieerd onder de MIT-licentie – zie het [LICENSE](LICENSE) bestand voor details

## 🙏 Dankwoord

- [Cloudflare Workers](https://workers.cloudflare.com/) – Edge computing platform
- [Clash](https://github.com/Dreamacro/clash) – Uitstekende proxyclient
- Alle bijdragers en gebruikers voor hun steun

---
⭐ Als dit project je heeft geholpen, geef het dan een ster!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---