<details align="right">
<summary>🌐 Taal</summary>

[English](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=th) | [Français](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=de) | [Español](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=it) | [Русский](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ru) | [Português](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=as)
</details>

# OnionHoster v2.2

> **De Ultieme Tor Hidden Service Hosting Tool** - Zet je webprojecten binnen enkele minuten op het dark web!
> 
[![Versie](https://img.shields.io/badge/version-2.2-brightgreen.svg)](https://github.com/BlackHatDevX/onionhoster)
[![Platform](https://img.shields.io/badge/platform-Linux%20%7C%20macOS-blue.svg)](https://github.com/BlackHatDevX/onionhoster)
[![Licentie](https://img.shields.io/badge/license-MIT-green.svg)](https://github.com/BlackHatDevX/onionhoster)

<img width="1023" height="551" alt="ChatGPT Image Aug 27, 2025, 03_32_08 PM (1)-modified" src="https://github.com/user-attachments/assets/92b6e834-2d4f-4cc7-8f77-82b9bafba8a5" />


---

## 🚀 Wat is OnionHoster?

OnionHoster is een krachtige, cross-platform bash-script die elk webproject omzet in een Tor hidden service met slechts één commando. Of je nu een Next.js-app, Flask-backend of statische website host, OnionHoster regelt alle complexe Tor-configuratie automatisch.

### ✨ Waarom kiezen voor OnionHoster?

- **🔧 Geen Configuratie Nodig** - Werkt direct met elk webproject
- **🌍 Cross-Platform** - Ondersteunt Linux, macOS en grote distributies
- **⚡ One-Click Installatie** - Van niets naar hidden service in minder dan 2 minuten
- **🔄 Automatische Updates** - Ingebouwde updatechecker houdt je up-to-date
- **💾 Backup & Herstel** - Verlies nooit je onion-adressen
- **🎯 Professionele UI** - Prachtige gekleurde interface met intuïtieve menu's

---
## Voorbeeld

[![IMAGE ALT TEXT HERE](https://github.com/user-attachments/assets/4b35dfb0-0059-4cc5-99c7-a5b9467a385d)](https://www.youtube.com/watch?v=oPvhA54Tp8w)


# ⚠️ Waarschuwing: OnionHoster is GEEN magisch anonimiteitsmiddel — volg best practices of loop risico op deanonymisatie

**Systeemhardening**

* Draai de service in een VM of container voor isolatie.

* Houd het besturingssysteem en de pakketten up-to-date.
* Schakel onnodige services/poorten uit zodat alleen Tor-verkeer in/uit gaat.

**OpSec Praktijken**

* Gebruik niet dezelfde machine voor persoonlijke accounts of activiteiten.
* Voorkom het blootstellen van identificerende metadata (bestandsnamen, headers, foutmeldingen).
* Let op logs — wat je logt, hoe lang je ze bewaart, en of ze informatie lekken.

**Netwerkhygiëne**

* Verbind je verborgen dienst niet met je clearnet-identiteit of domein.
* Gebruik een firewall om te zorgen dat er geen toevallige lekken buiten Tor plaatsvinden.
* Overweeg reverse proxies voor extra isolatie.

**Testen & Monitoren**

* Gebruik torsocks of de Tor Browser om te verifiëren dat je dienst alleen bereikbaar is via het `.onion`-adres.
* Test regelmatig op lekken (bijvoorbeeld of je app probeert te verbinden met de clearnet).

**Bewustzijn van Gebruikssituatie**

* Voor hobby/test/educatief gebruik: bovenstaande is meestal voldoende.
* Voor hoog-risico, echte anonimiteit (journalisten, klokkenluiders, activisten): vereist diepere operationele beveiliging en dreigingsmodellering, omdat één fout al tot de-anonimisering kan leiden.


---
## 🎯 Perfect Voor

- **Ontwikkelaars** die hun apps op Tor willen testen
- **Privacyvoorvechters** die anonieme diensten hosten (
- **Onderzoekers** die dark web technologieën bestuderen
- **Bedrijven** die anonieme hostingoplossingen nodig hebben
- **Hobbyisten** die het Tor-netwerk verkennen

---

## 🚀 Snel Beginnen

### Vereisten
- Root/sudo-toegang
- Internetverbinding
- Elk webproject (HTML, Next.js, Flask, enz.)

### Installatie & Gebruik

```bash
# 1. Clone the repository
git clone https://github.com/BlackHatDevX/onionhoster.git

# 2. Navigate to the directory
cd onionhoster

# 3. Make the script executable
chmod +x onionhoster.sh

# 4. Run with sudo
sudo bash onionhoster.sh
```

**Dat is alles!** 🎉

Je ontvangt het complete OnionHoster-project inclusief:
- Het hoofdscript `onionhoster.sh`
- Een professioneel `index.html` template om te hosten
- Alle documentatie en voorbeelden

Het script zal automatisch:
- Je besturingssysteem detecteren
- Alle benodigde afhankelijkheden installeren (Tor, Apache, enz.)
- Tor-diensten configureren
- Je een intuïtief menu presenteren

---

## 🎮 Functieoverzicht

### 🌐 Hostingopties
- **Statische HTML** - Host elk `index.html` bestand
- **Port Forwarding** - Doorsturen naar elke lokale applicatiepoort
- **Dynamische Apps** - Ondersteuning voor Next.js, Flask, Node.js en meer

### 🛠️ Beheertools
- **Servicecontrole** - Starten, stoppen en beheren van je verborgen dienst
- **Backup & Herstel** - Veilig back-uppen en herstellen van je onion-domeinen
- **URL Vernieuwen** - Genereer nieuwe onion-adressen indien nodig
- **Statusmonitoring** - Controleer de status en gezondheid van de dienst

### 🔄 Slimme updates
- **Auto-detectie** - Vindt automatisch de nieuwste versie
- **One-Click Updates** - Update met één menu-optie
- **Veilige updates** - Geen risico op verlies van je configuratie

---

## 📱 Ondersteunde besturingssystemen

| OS | Pakketbeheerder | Status |
|----|-----------------|---------|
| **Ubuntu/Debian** | `apt-get` | ✅ Volledige ondersteuning |
| **CentOS/RHEL** | `yum` | ✅ Volledige ondersteuning |
| **Fedora** | `dnf` | ✅ Volledige ondersteuning |
| **Arch Linux** | `pacman` | ✅ Volledige ondersteuning |
| **macOS** | `brew` | ✅ Volledige ondersteuning |

---

## 🎯 Gebruiksscenario's

### 🏠 Persoonlijke projecten
- Host je portfolio anoniem
- Test webapplicaties privé
- Deel content zonder je identiteit prijs te geven

### 🏢 Zakelijke toepassingen
- Anonieme klantenondersteuningsportalen
- Veilige interne communicatiesystemen
- Privacygerichte zakelijke websites

### 🔬 Onderzoek & Ontwikkeling
- Onderzoek naar dark web technologie
- Ontwikkeling van privacytools
- Anonieme servicetests

---

## 📖 Gedetailleerd gebruik

### Hoofdmenu Opties

1. **Host index.html** - Serveer een statisch HTML-bestand
2. **Doorsturen naar applicatiepoort** - Proxy naar elke lokale dienst
3. **Back-up tor-domein** - Sla je onion-configuratie op
4. **Herstel tor-domein** - Herstellen vanaf back-up
5. **Bekijk huidig tor-domein** - Bekijk je actieve onion-adres
6. **Vernieuw tor-domein** - Genereer een nieuw onion-adres
7. **Controleer op updates** - Update naar de nieuwste versie
8. **Webserverstatus** - Monitor de gezondheid van de dienst
9. **Over OnionHoster** - Versie- en functie-informatie

### Voorbeeldworkflow

```bash
# Start the service
sudo ./onionhoster.sh

# Choose option 1 to host index.html
# Your onion address will be displayed
# Access it via Tor Browser or similar
```

---

## 🔧 Geavanceerde Configuratie

### Aangepaste Poortforwarding
```bash
# Forward your Next.js app running on port 3000
# The script will handle all Tor configuration automatically
```

### Back-upbeheer
```bash
# Automatic backups are stored in ~/onion_backups/
# Each backup includes your onion keys and configuration
```
---

## 🛡️ Beveiligingsfuncties

- **Automatische Tor-configuratie** - Veilige standaardinstellingen uit de doos
- **Correcte Bestandsrechten** - Veilige bestandsbezit en toegang
- **Dienstisolatie** - Elke verborgen dienst draait onafhankelijk
- **Geen Gegevensregistratie** - Je activiteiten blijven privé

---

## 🚨 Belangrijke Opmerkingen

- **Roottoegang Vereist** - Tor-diensten vereisen systeemconfiguratie
- **Tor-netwerk** - Je dienst is toegankelijk via Tor Browser
- **Onion-adressen** - Elke dienst krijgt een uniek `.onion`-adres
- **Regelmatig Back-uppen** - Onion-adressen veranderen bij verversen

---

## 🤝 Bijdragen

Bijdragen zijn welkom! Of het nu gaat om:
- 🐛 Foutenrapportages
- 💡 Functieaanvragen
- 📝 Documentatieverbeteringen
- 🔧 Codebijdragen

**Begin met:**
1. Fork de repository
2. Maak een feature branch
3. Breng je wijzigingen aan
4. Dien een pull request in

---

## 📄 Licentie

Dit project is gelicentieerd onder de MIT-licentie - zie het [LICENSE](LICENSE) bestand voor details.


---

## 🙏 Dankbetuigingen

- **Tor Project** - Voor het geweldige anonimiteitsnetwerk
- **Open Source Community** - Voor voortdurende verbeteringen
- **Gebruikers & Bijdragers** - Voor feedback en suggesties

---

## 🔗 Links

- **GitHub**: [https://github.com/BlackHatDevX/onionhoster](https://github.com/BlackHatDevX/onionhoster)
- **Issues**: [https://github.com/BlackHatDevX/onionhoster/issues](https://github.com/BlackHatDevX/onionhoster/issues)
- **Discussies**: [https://github.com/BlackHatDevX/onionhoster/discussions](https://github.com/BlackHatDevX/onionhoster/discussions)

---

## ⭐ Geef Dit Project een Ster

Als OnionHoster je helpt, geef het dan een ster! Dit motiveert ons om te blijven verbeteren en helpt anderen deze tool te ontdekken.

---

**Klaar om anoniem te gaan?** 🕵️‍♂️

```bash
git clone https://github.com/BlackHatDevX/onionhoster.git
cd onionhoster
sudo bash onionhoster.sh
```

*Je reis naar anoniem hosten begint nu!* 🚀


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---