<p align="center"><img src="https://raw.githubusercontent.com/MonkeyGG2/monkeygg2.github.io/main/imgs/icon-256-256.png" height="200"></p>

<div align="center">
<a href="https://discord.com/invite/yPYyZ78qCB"><img alt="Discord" src="https://img.shields.io/discord/1051660971900407839?label=discord"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="Github Repo stars" src="https://img.shields.io/github/stars/MonkeyGG2/monkeygg2.github.io?label=github%20stars"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="GitHub Repo forks" src="https://img.shields.io/github/forks/MonkeyGG2/monkeygg2.github.io?label=github%20forks"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo stars" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20stars&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=stars_count"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo forks" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20forks&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=forks_count"></a>
<a href="http://www.wtfpl.net/about"><img alt="License: WTFPL" src="https://img.shields.io/badge/License-WTFPL-brightgreen.svg"></a>
</div>
<h1 align="center">MonkeyGG2</h1>
<p align="center" style="opacity: 0.65;">Jouw Vriendelijke Buurt Game Site.</p>
<br>

Welkom bij MonkeyGG2, een uitgebreide gamesite gemaakt voor jou! Met meer dan 150 spellen om uit te kiezen, biedt MonkeyGG2 een unieke en aanpasbare game-ervaring. Of je nu een gamer, ontwikkelaar of gewoon een doorsnee gebruiker bent, MonkeyGG2 biedt een naadloze en plezierige speelomgeving.

> Overweeg ons een ster te geven! Zeker als je deze repository hebt geforkt of er op een andere manier gebruik van hebt gemaakt.

## Functies

-   Meer dan 150 spellen
-   Gebruiksvriendelijk
-   Eenvoudig te implementeren
-   Aanpasbaar
-   Proxy
-   En meer...

## Aanpassing

### Instellingen

#### Cloaking

Cloaking betekent het openen van de pagina in een `about:blank` tabblad. Dit gedrag is standaard geforceerd, maar kan worden uitgeschakeld. Er zijn presets beschikbaar voor de redirect-link, maar deze kan ook handmatig worden geconfigureerd.

#### Masking

Masking betekent het wijzigen van het pictogram en de tabbladnaam van het about:blank tabblad. Er zijn presets beschikbaar voor het pictogram en de tabbladnaam, maar deze kunnen ook handmatig worden ingesteld.

#### Sneltoetsen

Aangepaste sneltoetsen kunnen worden aangemaakt om verschillende taken uit te voeren. Bijvoorbeeld het afsluiten van het spel, het maskeren van het tabblad en het uitvoeren van aangepaste JavaScript zijn allemaal ondersteund.
> Opmerking: als je aangepaste JavaScript wilt uitvoeren, zorg ervoor dat je weet wat je doet. Als er iets misgaat, is het herladen van de pagina altijd de oplossing.

#### Thema

De volgende thema-aanpassingen worden momenteel ondersteund:
- Achtergrondanimatie in-/uitschakelen (maak je geen zorgen over prestaties tijdens het spelen, het wordt automatisch uitgeschakeld tijdens het gamen)
- Achtergrondkleur
- Blokkleur
- Knopkleur
- Spellenkleur
- Hoverkleur
- Scrollbalkkleur
- Scroll Track Kleur
- Letterkleur

> Opmerking: als je per ongeluk de kleuren zo aanpast dat de site onbruikbaar wordt, moet je je cookies en lokale opslag wissen.

### Geavanceerde Aanpassingen

> Disclaimer: De volgende aanpassingen zijn alleen beschikbaar voor eigenaren van deze repository of een fork hiervan.

Het `config.jsonc` bestand is geformatteerd om configuratie voor de gehele site te bevatten. Momenteel worden de volgende onderdelen ondersteund:
- Spellen
- Thema's (binnenkort beschikbaar)
- Proxyconfiguratie

#### Spellen

Elke spellenvermelding heeft een sleutel die de weergavenaam van het spel vertegenwoordigt, en de waarde moet een object zijn met drie sleutel-waardeparen:
- `"path"`: Pad naar het spel vanuit de `./games` directory
- `"aliases"`: Lijst met alternatieve namen voor het spel om het zoeken te verbeteren
- `"categories"`: Lijst met categorieën waarin het spel past (binnenkort ondersteuning voor het toevoegen van pictogrammen)

Handmatig toevoegen van een vermelding is mogelijk, maar tijdrovend, vooral als je de lijst alfanumeriek wilt ordenen (niet vereist voor de werking van de configuratie!).
Daarom is het script `add-game-entry.js` gemaakt, een eenvoudige manier om een nieuw spel toe te voegen zonder het bestand handmatig te bewerken.

```bash
# Je kunt elke js-runtime gebruiken, zoals node.js, bun of deno
# In dit voorbeeld wordt bun gebruikt omdat afhankelijkheden automatisch geïnstalleerd worden
bun add-game-script.js
# Beantwoord de volgende prompts en de configuratie wordt bijgewerkt
```

#### Thema's

Themastandaard nog niet geïmplementeerd (TODO)

#### Proxy

Proxyconfiguratie-opties staan onder de **"config"** sleutel. 
De waarde voor de sleutel `"proxy"` is een booleaanse waarde die de proxyfunctie in- of uitschakelt. Als `"proxy"` op false staat, krijgt de gebruiker een foutmelding te zien wanneer hij probeert de proxy te openen.
De waarde voor de sleutel `"proxyPath"` is het pad naar de proxy. Dit kan een absoluut of relatief pad zijn, maar de proxy moet **CORS** ondersteunen omdat de proxypagina als een iframe op de site wordt weergegeven.

## Implementatie

### Zonder Proxy

[![Run on Replit](https://binbashbanana.github.io/deploy-buttons/buttons/remade/replit.svg)](https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Remix on Glitch](https://binbashbanana.github.io/deploy-buttons/buttons/remade/glitch.svg)](https://glitch.com/edit/#!/import/github/MonkeyGG2/monkeygg2.github.io)
[![Deploy to IBM Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/ibmcloud.svg)](https://cloud.ibm.com/devops/setup/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Amplify Console](https://binbashbanana.github.io/deploy-buttons/buttons/remade/amplifyconsole.svg)](https://console.aws.amazon.com/amplify/home#/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Run on Google Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/googlecloud.svg)](https://deploy.cloud.run/?git_repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Oracle Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/oraclecloud.svg)](https://cloud.oracle.com/resourcemanager/stacks/create?zipUrl=https://github.com/MonkeyGG2/monkeygg2.github.io/archive/refs/heads/main.zip)
[![Deploy with Vercel](https://binbashbanana.github.io/deploy-buttons/buttons/remade/vercel.svg)](https://vercel.com/new/clone?repository-url=https%3A%2F%2Fgithub.com%2FMonkeyGG2%2Fmonkeygg2.github.io)
[![Deploy with Netlify](https://binbashbanana.github.io/deploy-buttons/buttons/remade/netlify.svg)](https://app.netlify.com/start/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Render](https://binbashbanana.github.io/deploy-buttons/buttons/remade/render.svg)](https://render.com/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)

Als alternatief kun je deze repository gewoon forken op [GitHub](https://github.com/MonkeyGG2/monkeygg2.github.io) of [Codeberg](https://codeberg.org/MonkeyGG2/pages) en vervolgens implementeren op GitHub Pages of Codeberg Pages.

### Met Proxy

Bezoek de [VioletGG2](https://github.com/MonkeyGG2/VioletGG2) pagina om meer te weten te komen over het hosten van MonkeyGG2 met een proxy.

### Lokaal draaien

```bash
# WAARSCHUWING: als je een map met de naam "monkeygg2" hebt, worden alle bestanden daarin verwijderd door dit commando
# verander de naam van de directory in de volgende twee commando's als dat nodig is
git clone https://github.com/MonkeyGG2/monkeygg2.github.io.git monkeygg2
cd monkeygg2
# vanaf hier kun je elke tool gebruiken om een statische server te draaien, "live-server" van npm wordt hier gebruikt
npm install -g live-server # alleen als je het nog niet hebt geïnstalleerd
npx live-server
```

## Licentie

Verspreid onder de WTFPL-licentie. Zie [hier](https://github.com/MonkeyGG2/monkeygg2.github.io/blob/main/LICENSE) voor meer informatie.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---