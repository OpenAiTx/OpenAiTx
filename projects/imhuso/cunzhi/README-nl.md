#寸止 🛑

> **De "vroegtijdige beëindiging" killer voor AI-gesprekken, zodat communicatie tot het einde blijft duren**

Word je gek van AI-assistenten die altijd te vroeg het gesprek beëindigen? Je hebt nog zoveel te bespreken, maar toch zegt het: "Is er verder nog iets waarmee ik kan helpen?" **寸止** lost dit probleem perfect op!

Wanneer AI het gesprek "snel wil afronden", verschijnt寸止 op tijd met een pop-up, zodat je het gesprek kunt voortzetten tot het probleem echt is opgelost.

## 🌟 Kernfuncties

- 🛑 **Slimme onderbreking**: Automatische pop-up met vervolgopties wanneer AI wil afronden
- 🧠 **Geheugenbeheer**: Opslaan van ontwikkelstandaarden en voorkeuren per project
- 🎨 **Elegante interactie**: Markdown-ondersteuning, diverse invoermethoden
- ⚡ **Direct te gebruiken**: Installatie in 3 seconden, platformonafhankelijke ondersteuning

## 📸 Bekijk het resultaat

### 🛑 Slimme onderbrekingspop-up
![寸止弹窗演示](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/popup.png)

*Wanneer AI het gesprek wil beëindigen, verschijnt寸止 direct met een slimme pop-up en vooraf ingestelde opties, zodat het gesprek inhoudelijk blijft doorgaan*
### ⚙️ Instellingen Beheerinterface
![寸止设置界面](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/settings.png)

*Elegante instellingeninterface, ondersteunt geheugenbeheer, functieschakelaars, themawissel en slimme promptgeneratie*

## 🚀 Aan de slag

### Methode 1: Snelle installatie (aanbevolen)

**macOS-gebruikers:**
```bash
# Installatie in 3 seconden, geen compilatie nodig
brew tap imhuso/cunzhi && brew install cunzhi
```

> ⚠️ **Probleemoplossing**: Als je een 404 downloadfout tegenkomt, voer dan de volgende stappen uit:
>
> ```bash
> # Oude tap-cache wissen
> brew untap imhuso/cunzhi
> # Opnieuw installeren
> brew tap imhuso/cunzhi && brew install cunzhi
> ```
>
> **Veelvoorkomend foutvoorbeeld:**
> ```
> curl: (56) The requested URL returned error: 404
> Error: cunzhi: Failed to download resource "cunzhi"
> Download failed: https://github.com/imhuso/cunzhi/releases/download/v0.2.0/cunzhi-cli-v0.2.4-macos-aarch64.tar.gz
> ```
>
> Dit wordt meestal veroorzaakt door een cacheprobleem van een eerdere versie waardoor de versienummers niet overeenkomen. Het wissen van de tap en daarna opnieuw installeren lost dit op.

**Windows/Linux-gebruikers:**
Aanbevolen om methode 2 te gebruiken voor handmatig downloaden, eenvoudig en snel!
### Methode 2: Handmatig downloaden

1. Bezoek de [Releases-pagina](https://github.com/imhuso/cunzhi/releases)
2. Download de versie die geschikt is voor jouw systeem:
   - 🐧 **Linux**: `cunzhi-cli-v*-linux-x86_64.tar.gz`
   - 🍎 **macOS (Intel)**: `cunzhi-cli-v*-macos-x86_64.tar.gz`
   - 🍎 **macOS (Apple Silicon)**: `cunzhi-cli-v*-macos-aarch64.tar.gz`
   - 🪟 **Windows**: `cunzhi-cli-v*-windows-x86_64.zip`

3. Voeg na het uitpakken `寸止` en `等一下` toe aan het systeem-PATH

## ⚡ Snel aan de slag

### Stap 1: MCP-client configureren

Voeg het volgende toe aan het configuratiebestand van je MCP-client (zoals Claude Desktop):

```json
{
  "mcpServers": {
    "寸止": {
      "command": "寸止"
    }
  }
}
```
### Stap 2: Open het instellingenmenu

```bash
# Voer het instellingscommando uit
Even geduld
```

### Stap 3: Configureer promptwoorden

In het tabblad "Referentiepromptwoorden" van het instellingenmenu:
1. Bekijk de automatisch gegenereerde promptwoorden
2. Klik op de kopieerknop
3. Voeg de promptwoorden toe aan je AI-assistent

### Stap 4: Begin met gebruiken

Nu beschikt je AI-assistent over slimme interceptie, geheugenbeheer en popup-interactiefuncties!

> 💡 **Tip**: Je kunt de gegenereerde promptwoorden als referentie gebruiken en ze persoonlijk aanpassen om een unieke AI-interactie-ervaring te creëren.
## 🤝 Bijdragen

Cunzhi is een open source project, en we verwelkomen alle vormen van bijdragen!

### 🐛 Een probleem gevonden?
- [Dien een Issue in](https://github.com/imhuso/cunzhi/issues) om het probleem te beschrijven
- Geef stappen om te reproduceren en omgevingsinformatie

### 💡 Een goed idee?
- [Start een discussie](https://github.com/imhuso/cunzhi/discussions) om je idee te delen
- Dien een Pull Request in om een nieuwe functie te implementeren

### 🛠️ Lokale ontwikkeling
```bash
git clone https://github.com/imhuso/cunzhi.git
cd cunzhi
pnpm install
pnpm tauri:dev
```
## 📞 Contacteer ons

- 🐛 **Probleem melden**: [GitHub Issues](https://github.com/imhuso/cunzhi/issues)
- 💬 **Functiebespreking**: [GitHub Discussions](https://github.com/imhuso/cunzhi/discussions)
- ⭐ **Vind je het project leuk**: Geef ons een ster ter ondersteuning!

## 📄 Open source licentie

MIT-licentie - Vrij te gebruiken, bijdragen welkom!

---

<div align="center">

**Zeg vaarwel tegen AI-gesprekken met "vroegtijdige beëindiging" | Laat elk gesprek tot het einde duren**

[⭐ Ster geven](https://github.com/imhuso/cunzhi) · [🐛 Bug melden](https://github.com/imhuso/cunzhi/issues) · [💡 Functie aanvragen](https://github.com/imhuso/cunzhi/discussions)

</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---