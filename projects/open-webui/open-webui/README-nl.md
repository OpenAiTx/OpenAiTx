# Open WebUI 👋

![GitHub stars](https://img.shields.io/github/stars/open-webui/open-webui?style=social)
![GitHub forks](https://img.shields.io/github/forks/open-webui/open-webui?style=social)
![GitHub watchers](https://img.shields.io/github/watchers/open-webui/open-webui?style=social)
![GitHub repo size](https://img.shields.io/github/repo-size/open-webui/open-webui)
![GitHub language count](https://img.shields.io/github/languages/count/open-webui/open-webui)
![GitHub top language](https://img.shields.io/github/languages/top/open-webui/open-webui)
![GitHub last commit](https://img.shields.io/github/last-commit/open-webui/open-webui?color=red)
[![Discord](https://img.shields.io/badge/Discord-Open_WebUI-blue?logo=discord&logoColor=white)](https://discord.gg/5rJgQTnV4s)
[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/tjbck)

**Open WebUI is een [uitbreidbaar](https://docs.openwebui.com/features/plugin/), rijk aan functionaliteiten en gebruiksvriendelijk zelf-gehost AI-platform dat volledig offline werkt.** Het ondersteunt verschillende LLM-runners zoals **Ollama** en **OpenAI-compatibele API's**, met een **ingebouwde inference engine** voor RAG, waardoor het een **krachtige AI-deploymentsoplossing** is.

![Open WebUI Demo](./demo.gif)

> [!TIP]  
> **Op zoek naar een [Enterprise Plan](https://docs.openwebui.com/enterprise)?** – **[Neem vandaag nog contact op met ons salesteam!](mailto:sales@openwebui.com)**
>
> Ontvang **uitgebreide mogelijkheden**, waaronder **aangepaste thema's en branding**, **Service Level Agreement (SLA)-ondersteuning**, **Long-Term Support (LTS)-versies** en **meer!**

Voor meer informatie, bekijk onze [Open WebUI Documentatie](https://docs.openwebui.com/).

## Belangrijkste Kenmerken van Open WebUI ⭐

- 🚀 **Moeiteloze Installatie**: Installeer eenvoudig met Docker of Kubernetes (kubectl, kustomize of helm) voor een probleemloze ervaring, met ondersteuning voor zowel `:ollama` als `:cuda` images.

- 🤝 **Ollama/OpenAI API-integratie**: Integreer moeiteloos OpenAI-compatibele API's voor veelzijdige gesprekken naast Ollama-modellen. Pas de OpenAI API URL aan om te koppelen met **LMStudio, GroqCloud, Mistral, OpenRouter en meer**.

- 🛡️ **Granulaire machtigingen en gebruikersgroepen**: Door beheerders in staat te stellen gedetailleerde gebruikersrollen en machtigingen te creëren, zorgen we voor een veilige gebruikersomgeving. Deze granulariteit verhoogt niet alleen de veiligheid, maar maakt ook aangepaste gebruikerservaringen mogelijk, waardoor eigenaarschap en verantwoordelijkheid bij gebruikers wordt gestimuleerd.

- 📱 **Responsief ontwerp**: Geniet van een naadloze ervaring op Desktop PC, Laptop en Mobiele apparaten.

- 📱 **Progressive Web App (PWA) voor mobiel**: Ervaar een app-achtige beleving op je mobiele apparaat met onze PWA, die offline toegang biedt op localhost en een gebruiksvriendelijke interface heeft.

- ✒️🔢 **Volledige Markdown- en LaTeX-ondersteuning**: Verrijk je LLM-ervaring met uitgebreide Markdown- en LaTeX-mogelijkheden voor een interactieve communicatie.

- 🎤📹 **Handsfree spraak-/videogesprek**: Geniet van naadloze communicatie met geïntegreerde handsfree spraak- en videogesprek functies, voor een dynamischer en interactiever chatomgeving.

- 🛠️ **Model Builder**: Maak eenvoudig Ollama-modellen via de Web UI. Maak en voeg aangepaste karakters/agenten toe, pas chattelementen aan en importeer modellen moeiteloos via de [Open WebUI Community](https://openwebui.com/) integratie.

- 🐍 **Native Python Functie-aanroeptool**: Versterk je LLMs met ingebouwde code-editor ondersteuning in de tools workspace. Voeg je eigen pure Python-functies toe (BYOF) voor een naadloze integratie met LLMs.

- 📚 **Lokale RAG-integratie**: Ontdek de toekomst van chatinteracties met baanbrekende Retrieval Augmented Generation (RAG)-ondersteuning. Deze functie integreert documentinteracties direct in je chat. Je kunt documenten direct in de chat laden of bestanden toevoegen aan je documentbibliotheek, en ze eenvoudig openen via het `#`-commando voor een vraag.

- 🔍 **Webzoekfunctie voor RAG**: Voer webzoekopdrachten uit met providers als `SearXNG`, `Google PSE`, `Brave Search`, `serpstack`, `serper`, `Serply`, `DuckDuckGo`, `TavilySearch`, `SearchApi` en `Bing` en voeg de resultaten direct toe aan je chatervaring.

- 🌐 **Webbrowsingmogelijkheid**: Integreer websites direct in je chatervaring via het `#`-commando gevolgd door een URL. Zo kun je webinhoud direct in je conversaties opnemen, wat de diepgang en rijkdom van je interacties vergroot.

- 🎨 **Afbeeldingsgeneratie-integratie**: Voeg eenvoudig afbeeldingsgeneratiemogelijkheden toe via opties zoals AUTOMATIC1111 API of ComfyUI (lokaal) en OpenAI's DALL-E (extern), waardoor je chatervaring wordt verrijkt met dynamische visuele content.

- ⚙️ **Multi-Model Gesprekken**: Voer moeiteloos gesprekken met verschillende modellen tegelijk en benut hun unieke krachten voor optimale antwoorden. Verhoog je ervaring door meerdere modellen parallel te gebruiken.

- 🔐 **Role-Based Access Control (RBAC)**: Zorg voor veilige toegang met beperkte rechten; alleen geautoriseerde personen kunnen bij je Ollama, en alleen beheerders mogen modellen aanmaken of downloaden.

- 🌐🌍 **Meertalige ondersteuning**: Ervaar Open WebUI in je favoriete taal dankzij onze internationalisatie (i18n). Help mee om het aantal ondersteunde talen uit te breiden! We zoeken actief naar bijdragers!

- 🧩 **Pipelines, Open WebUI Plugin-ondersteuning**: Integreer eenvoudig aangepaste logica en Python-bibliotheken in Open WebUI met het [Pipelines Plugin Framework](https://github.com/open-webui/pipelines). Start je Pipelines-instantie, stel de OpenAI URL in op de Pipelines URL en ontdek eindeloze mogelijkheden. [Voorbeelden](https://github.com/open-webui/pipelines/tree/main/examples) omvatten **Function Calling**, gebruikers **Rate Limiting** voor toegangscontrole, **Usage Monitoring** met tools als Langfuse, **Live Translation met LibreTranslate** voor meertalige ondersteuning, **Toxic Message Filtering** en veel meer.

- 🌟 **Continue updates**: We zetten ons in voor het verbeteren van Open WebUI met regelmatige updates, bugfixes en nieuwe functies.

Meer weten over de mogelijkheden van Open WebUI? Bekijk onze [Open WebUI documentatie](https://docs.openwebui.com/features) voor een uitgebreid overzicht!

## Sponsoren 🙌

#### Smaragd

<table>
  <tr>
    <td>
      <a href="https://n8n.io/" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/n8n.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      N8N • Heeft jouw interface al een backend?<br>Probeer <a href="https://n8n.io/">n8n</a>
    </td>
  </tr>
  <tr>
    <td>
      <a href="https://warp.dev/open-webui" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/warp.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      <a href="https://warp.dev/open-webui">Warp</a> • De intelligente terminal voor ontwikkelaars
    </td>
  </tr>
</table>

---

We zijn ontzettend dankbaar voor de genereuze steun van onze sponsoren. Hun bijdragen helpen ons om het project te onderhouden en te verbeteren, zodat we kwaliteitswerk kunnen blijven leveren aan onze community. Dank je wel!

## Installeren 🚀

### Installatie via Python pip 🐍

Open WebUI kan worden geïnstalleerd met pip, de Python package installer. Zorg ervoor dat je **Python 3.11** gebruikt om compatibiliteitsproblemen te voorkomen.

1. **Installeer Open WebUI**:
   Open je terminal en voer het volgende commando uit om Open WebUI te installeren:

   ```bash
   pip install open-webui
   ```

2. **Open WebUI uitvoeren**:
   Na installatie kun je Open WebUI starten met:

   ```bash
   open-webui serve
   ```

Hiermee start de Open WebUI-server, die toegankelijk is op [http://localhost:8080](http://localhost:8080)

### Snelstart met Docker 🐳

> [!NOTE]  
> Houd er rekening mee dat voor bepaalde Docker-omgevingen extra configuraties nodig kunnen zijn. Als je verbindingsproblemen ondervindt, staat onze gedetailleerde handleiding op [Open WebUI Documentatie](https://docs.openwebui.com/) klaar om te helpen.

> [!WARNING]
> Gebruik je Docker om Open WebUI te installeren, voeg dan `-v open-webui:/app/backend/data` toe aan je Docker-commando. Deze stap is cruciaal om je database correct te mounten en dataverlies te voorkomen.

> [!TIP]  
> Wil je Open WebUI gebruiken met Ollama of CUDA-versnelling? Gebruik dan onze officiële images met `:cuda` of `:ollama`. Om CUDA te activeren, moet je de [Nvidia CUDA container toolkit](https://docs.nvidia.com/dgx/nvidia-container-runtime-upgrade/) installeren op je Linux/WSL-systeem.

### Installatie met standaardconfiguratie

- **Als Ollama op je computer staat**, gebruik dit commando:

  ```bash
  docker run -d -p 3000:8080 --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **Als Ollama op een andere server draait**, gebruik dit commando:

  Om verbinding te maken met Ollama op een andere server, wijzig de `OLLAMA_BASE_URL` naar de URL van de server:

  ```bash
  docker run -d -p 3000:8080 -e OLLAMA_BASE_URL=https://voorbeeld.nl -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **Open WebUI uitvoeren met Nvidia GPU-ondersteuning**, gebruik dit commando:

  ```bash
  docker run -d -p 3000:8080 --gpus all --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:cuda
  ```

### Installatie voor alleen OpenAI API-gebruik

- **Als je alleen de OpenAI API gebruikt**, gebruik dan dit commando:

  ```bash
  docker run -d -p 3000:8080 -e OPENAI_API_KEY=je_geheime_sleutel -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

### Open WebUI installeren met ingebouwde Ollama-ondersteuning

Deze installatiemethode gebruikt één container image waarin Open WebUI en Ollama zijn gebundeld, voor een eenvoudige installatie via één commando. Kies het juiste commando op basis van je hardware:

- **Met GPU-ondersteuning**:
  Gebruik GPU-resources door het volgende commando uit te voeren:

  ```bash
  docker run -d -p 3000:8080 --gpus=all -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

- **Alleen CPU**:
  Als je geen GPU gebruikt, gebruik dan dit commando:

  ```bash
  docker run -d -p 3000:8080 -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

Beide commando's zorgen voor een ingebouwde, probleemloze installatie van zowel Open WebUI als Ollama, zodat je snel aan de slag kunt.

Na installatie is Open WebUI bereikbaar op [http://localhost:3000](http://localhost:3000). Veel plezier! 😄

### Andere installatiemethoden

We bieden diverse alternatieven, waaronder niet-Docker native installatie, Docker Compose, Kustomize en Helm. Bekijk onze [Open WebUI Documentatie](https://docs.openwebui.com/getting-started/) of sluit je aan bij onze [Discord-community](https://discord.gg/5rJgQTnV4s) voor uitgebreide begeleiding.

### Problemen oplossen

Loop je tegen verbindingsproblemen aan? Onze [Open WebUI Documentatie](https://docs.openwebui.com/troubleshooting/) helpt je verder. Voor extra hulp en om deel te nemen aan onze levendige community, bezoek de [Open WebUI Discord](https://discord.gg/5rJgQTnV4s).

#### Open WebUI: Serververbindingsfout

Als je verbindingsproblemen ervaart, komt dit vaak doordat de WebUI Docker-container de Ollama-server op 127.0.0.1:11434 (host.docker.internal:11434) binnen de container niet kan bereiken. Gebruik de `--network=host` flag in je Docker-commando om dit op te lossen. Let op: de poort verandert van 3000 naar 8080, met als link: `http://localhost:8080`.

**Voorbeeld Docker-commando**:

```bash
docker run -d --network=host -v open-webui:/app/backend/data -e OLLAMA_BASE_URL=http://127.0.0.1:11434 --name open-webui --restart always ghcr.io/open-webui/open-webui:main
```

### Je Docker-installatie up-to-date houden

Wil je je lokale Docker-installatie bijwerken naar de nieuwste versie? Gebruik dan [Watchtower](https://containrrr.dev/watchtower/):

```bash
docker run --rm --volume /var/run/docker.sock:/var/run/docker.sock containrrr/watchtower --run-once open-webui
```

Vervang in het laatste deel van het commando `open-webui` door je containenaam als deze anders is.

Bekijk onze Updategids in onze [Open WebUI Documentatie](https://docs.openwebui.com/getting-started/updating).

### De Dev Branch gebruiken 🌙

> [!WARNING]
> De `:dev` branch bevat de nieuwste onstabiele functies en wijzigingen. Gebruik deze op eigen risico, want hij kan bugs of onvolledige functionaliteiten bevatten.

Wil je de nieuwste functies testen en vind je het niet erg als het soms onstabiel is? Gebruik dan de `:dev` tag als volgt:

```bash
docker run -d -p 3000:8080 -v open-webui:/app/backend/data --name open-webui --add-host=host.docker.internal:host-gateway --restart always ghcr.io/open-webui/open-webui:dev
```

### Offline modus

Als je Open WebUI in een offline omgeving gebruikt, kun je de `HF_HUB_OFFLINE` omgevingsvariabele op `1` zetten om te voorkomen dat er modellen van internet worden gedownload.

```bash
export HF_HUB_OFFLINE=1
```

## Wat nu? 🌟

Ontdek komende functies op onze roadmap in de [Open WebUI Documentatie](https://docs.openwebui.com/roadmap/).

## Licentie 📜

Dit project valt onder de [Open WebUI Licentie](LICENSE), een aangepaste BSD-3-Clause licentie. Je krijgt dezelfde rechten als bij de klassieke BSD-3-licentie: je mag de software gebruiken, aanpassen en verspreiden, ook in propriëtaire en commerciële producten, met minimale beperkingen. De enige extra vereiste is dat je de "Open WebUI"-branding behoudt, zoals uitgelegd in het LICENSE-bestand. Zie het [LICENSE](LICENSE) document voor de volledige voorwaarden. 📄

## Ondersteuning 💬

Heb je vragen, suggesties of hulp nodig? Open dan een issue of sluit je aan bij onze
[Open WebUI Discord-community](https://discord.gg/5rJgQTnV4s) om contact met ons op te nemen! 🤝

## Sterrenhistorie

<a href="https://star-history.com/#open-webui/open-webui&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
  </picture>
</a>

---

Gemaakt door [Timothy Jaeryang Baek](https://github.com/tjbck) - Laten we samen Open WebUI nog beter maken! 💪

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---