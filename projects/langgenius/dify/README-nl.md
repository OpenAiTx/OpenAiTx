![cover-v5-optimized](./images/GitHub_README_if.png)

<p align="center">
  📌 <a href="https://dify.ai/blog/introducing-dify-workflow-file-upload-a-demo-on-ai-podcast">Introductie van Dify Workflow Bestand Uploaden: Recreate Google NotebookLM Podcast</a>
</p>

<p align="center">
  <a href="https://cloud.dify.ai">Dify Cloud</a> ·
  <a href="https://docs.dify.ai/getting-started/install-self-hosted">Zelf-hosting</a> ·
  <a href="https://docs.dify.ai">Documentatie</a> ·
  <a href="https://dify.ai/pricing">Dify editie-overzicht</a>
</p>

<p align="center">
    <a href="https://dify.ai" target="_blank">
        <img alt="Static Badge" src="https://img.shields.io/badge/Product-F04438"></a>
    <a href="https://dify.ai/pricing" target="_blank">
        <img alt="Static Badge" src="https://img.shields.io/badge/free-pricing?logo=free&color=%20%23155EEF&label=pricing&labelColor=%20%23528bff"></a>
    <a href="https://discord.gg/FngNHpbcY7" target="_blank">
        <img src="https://img.shields.io/discord/1082486657678311454?logo=discord&labelColor=%20%235462eb&logoColor=%20%23f5f5f5&color=%20%235462eb"
            alt="chat op Discord"></a>
    <a href="https://reddit.com/r/difyai" target="_blank">  
        <img src="https://img.shields.io/reddit/subreddit-subscribers/difyai?style=plastic&logo=reddit&label=r%2Fdifyai&labelColor=white"
            alt="join Reddit"></a>
    <a href="https://twitter.com/intent/follow?screen_name=dify_ai" target="_blank">
        <img src="https://img.shields.io/twitter/follow/dify_ai?logo=X&color=%20%23f5f5f5"
            alt="volg op X(Twitter)"></a>
    <a href="https://www.linkedin.com/company/langgenius/" target="_blank">
        <img src="https://custom-icon-badges.demolab.com/badge/LinkedIn-0A66C2?logo=linkedin-white&logoColor=fff"
            alt="volg op LinkedIn"></a>
    <a href="https://hub.docker.com/u/langgenius" target="_blank">
        <img alt="Docker Pulls" src="https://img.shields.io/docker/pulls/langgenius/dify-web?labelColor=%20%23FDB062&color=%20%23f79009"></a>
    <a href="https://github.com/langgenius/dify/graphs/commit-activity" target="_blank">
        <img alt="Commits laatste maand" src="https://img.shields.io/github/commit-activity/m/langgenius/dify?labelColor=%20%2332b583&color=%20%2312b76a"></a>
    <a href="https://github.com/langgenius/dify/" target="_blank">
        <img alt="Issues gesloten" src="https://img.shields.io/github/issues-search?query=repo%3Alanggenius%2Fdify%20is%3Aclosed&label=issues%20closed&labelColor=%20%237d89b0&color=%20%235d6b98"></a>
    <a href="https://github.com/langgenius/dify/discussions/" target="_blank">
        <img alt="Discussie posts" src="https://img.shields.io/github/discussions/langgenius/dify?labelColor=%20%239b8afb&color=%20%237a5af8"></a>
</p>

<p align="center">
  <a href="./README.md"><img alt="README in English" src="https://img.shields.io/badge/English-d9d9d9"></a>
  <a href="./README_TW.md"><img alt="繁體中文文件" src="https://img.shields.io/badge/繁體中文-d9d9d9"></a>
  <a href="./README_CN.md"><img alt="简体中文版自述文件" src="https://img.shields.io/badge/简体中文-d9d9d9"></a>
  <a href="./README_JA.md"><img alt="日本語のREADME" src="https://img.shields.io/badge/日本語-d9d9d9"></a>
  <a href="./README_ES.md"><img alt="README en Español" src="https://img.shields.io/badge/Español-d9d9d9"></a>
  <a href="./README_FR.md"><img alt="README en Français" src="https://img.shields.io/badge/Français-d9d9d9"></a>
  <a href="./README_KL.md"><img alt="README tlhIngan Hol" src="https://img.shields.io/badge/Klingon-d9d9d9"></a>
  <a href="./README_KR.md"><img alt="README in Korean" src="https://img.shields.io/badge/한국어-d9d9d9"></a>
  <a href="./README_AR.md"><img alt="README بالعربية" src="https://img.shields.io/badge/العربية-d9d9d9"></a>
  <a href="./README_TR.md"><img alt="Türkçe README" src="https://img.shields.io/badge/Türkçe-d9d9d9"></a>
  <a href="./README_VI.md"><img alt="README Tiếng Việt" src="https://img.shields.io/badge/Ti%E1%BA%BFng%20Vi%E1%BB%87t-d9d9d9"></a>
  <a href="./README_DE.md"><img alt="README in Deutsch" src="https://img.shields.io/badge/German-d9d9d9"></a>
  <a href="./README_BN.md"><img alt="README in বাংলা" src="https://img.shields.io/badge/বাংলা-d9d9d9"></a>
</p>

Dify is een open-source LLM-app ontwikkelplatform. De intuïtieve interface combineert agent-gebaseerde AI-workflow, RAG-pijplijn, agent-capaciteiten, modelbeheer, observatiekenmerken en meer, zodat je snel van prototype naar productie kunt gaan.

## Snelstart

> Zorg ervoor dat je machine aan de volgende minimale systeemvereisten voldoet voordat je Dify installeert:
>
> - CPU >= 2 Cores
> - RAM >= 4 GiB

</br>

De makkelijkste manier om de Dify-server te starten is via [docker compose](docker/docker-compose.yaml). Voordat je Dify met de volgende commando's uitvoert, controleer of [Docker](https://docs.docker.com/get-docker/) en [Docker Compose](https://docs.docker.com/compose/install/) geïnstalleerd zijn op je machine:

```bash
cd dify
cd docker
cp .env.example .env
docker compose up -d
```

Na het uitvoeren kun je het Dify-dashboard in je browser openen op [http://localhost/install](http://localhost/install) en het initialisatieproces starten.

#### Hulp nodig

Raadpleeg onze [FAQ](https://docs.dify.ai/getting-started/install-self-hosted/faqs) als je problemen ondervindt bij het instellen van Dify. Neem contact op met [de community en ons](#community--contact) als je nog steeds problemen hebt.

> Als je wilt bijdragen aan Dify of extra ontwikkeling wilt doen, raadpleeg dan onze [handleiding voor implementatie vanuit broncode](https://docs.dify.ai/getting-started/install-self-hosted/local-source-code)

## Belangrijkste kenmerken

**1. Workflow**:
Bouw en test krachtige AI-workflows op een visueel canvas, met gebruik van alle onderstaande functies en meer.

**2. Uitgebreide modelondersteuning**:
Naadloze integratie met honderden propriëtaire/open-source LLM's van tientallen inference-providers en zelf-gehoste oplossingen, waaronder GPT, Mistral, Llama3 en elk OpenAI API-compatibel model. Een volledige lijst van ondersteunde modelproviders vind je [hier](https://docs.dify.ai/getting-started/readme/model-providers).

![providers-v5](https://github.com/langgenius/dify/assets/13230914/5a17bdbe-097a-4100-8363-40255b70f6e3)

**3. Prompt IDE**:
Intuïtieve interface voor het maken van prompts, het vergelijken van modelprestaties en het toevoegen van extra functionaliteiten zoals tekst-naar-spraak aan een chatgebaseerde app.

**4. RAG-pijplijn**:
Uitgebreide RAG-mogelijkheden die alles omvatten van documentinname tot ophalen, met standaard ondersteuning voor tekstextractie uit PDF's, PPT's en andere gangbare documentformaten.

**5. Agent-capaciteiten**:
Je kunt agents definiëren op basis van LLM Function Calling of ReAct, en vooraf gebouwde of aangepaste tools toevoegen aan de agent. Dify biedt 50+ ingebouwde tools voor AI-agents, zoals Google Search, DALL·E, Stable Diffusion en WolframAlpha.

**6. LLMOps**:
Monitor en analyseer applicatielogs en prestaties in de tijd. Je kunt prompts, datasets en modellen continu verbeteren op basis van productiegegevens en annotaties.

**7. Backend-as-a-Service**:
Alle Dify-functionaliteiten hebben bijbehorende API's, zodat je Dify moeiteloos kunt integreren in je eigen bedrijfslogica.

## Functievergelijking

<table style="width: 100%;">
  <tr>
    <th align="center">Functie</th>
    <th align="center">Dify.AI</th>
    <th align="center">LangChain</th>
    <th align="center">Flowise</th>
    <th align="center">OpenAI Assistants API</th>
  </tr>
  <tr>
    <td align="center">Programmeerbenadering</td>
    <td align="center">API + App-georiënteerd</td>
    <td align="center">Python-code</td>
    <td align="center">App-georiënteerd</td>
    <td align="center">API-georiënteerd</td>
  </tr>
  <tr>
    <td align="center">Ondersteunde LLM's</td>
    <td align="center">Rijke variëteit</td>
    <td align="center">Rijke variëteit</td>
    <td align="center">Rijke variëteit</td>
    <td align="center">Alleen OpenAI</td>
  </tr>
  <tr>
    <td align="center">RAG-engine</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">Agent</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">Workflow</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Observatie</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Enterprise-functie (SSO/Toegangscontrole)</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Lokale implementatie</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
</table>

## Dify gebruiken

- **Cloud </br>**
  Wij hosten een [Dify Cloud](https://dify.ai) dienst die je zonder installatie kunt proberen. Het biedt alle mogelijkheden van de zelf-gehoste versie en bevat 200 gratis GPT-4-aanroepen in het sandbox-abonnement.

- **Zelf-hosting Dify Community Edition</br>**
  Start snel met Dify in jouw omgeving met deze [starthandleiding](#quick-start).
  Gebruik onze [documentatie](https://docs.dify.ai) voor verdere referenties en meer diepgaande instructies.

- **Dify voor bedrijven/organisaties</br>**
  We bieden extra functies gericht op ondernemingen. [Stel je vragen via deze chatbot](https://udify.app/chat/22L1zSxg6yW1cWQg) of [stuur ons een e-mail](mailto:business@dify.ai?subject=[GitHub]Business%20License%20Inquiry) om bedrijfsbehoeften te bespreken. </br>
  > Voor startups en kleine bedrijven die AWS gebruiken: bekijk [Dify Premium op AWS Marketplace](https://aws.amazon.com/marketplace/pp/prodview-t22mebxzwjhu6) en implementeer het met één klik naar je eigen AWS VPC. Het is een betaalbare AMI-oplossing met de optie om apps te maken met een eigen logo en branding.

## Voorop blijven lopen

Geef Dify een ster op GitHub en ontvang direct notificaties over nieuwe releases.

![star-us](https://github.com/langgenius/dify/assets/13230914/b823edc1-6388-4e25-ad45-2f6b187adbb4)

## Geavanceerde installatie

Als je de configuratie wilt aanpassen, raadpleeg dan de opmerkingen in ons [.env.example](docker/.env.example) bestand en werk de bijbehorende waarden bij in je `.env` bestand. Daarnaast moet je mogelijk aanpassingen maken in het `docker-compose.yaml` bestand zelf, zoals het wijzigen van image-versies, poorttoewijzingen of volumemounts, afhankelijk van jouw specifieke implementatie-omgeving en vereisten. Na het aanbrengen van wijzigingen, voer opnieuw `docker-compose up -d` uit. Je vindt de volledige lijst van beschikbare omgevingsvariabelen [hier](https://docs.dify.ai/getting-started/install-self-hosted/environments).

Als je een high-availability setup wilt configureren, zijn er door de community bijgedragen [Helm Charts](https://helm.sh/) en YAML-bestanden waarmee Dify op Kubernetes kan worden uitgerold.

- [Helm Chart door @LeoQuote](https://github.com/douban/charts/tree/master/charts/dify)
- [Helm Chart door @BorisPolonsky](https://github.com/BorisPolonsky/dify-helm)
- [Helm Chart door @magicsong](https://github.com/magicsong/ai-charts)
- [YAML-bestand door @Winson-030](https://github.com/Winson-030/dify-kubernetes)
- [YAML-bestand door @wyy-holding](https://github.com/wyy-holding/dify-k8s)

#### Deployen met Terraform

Implementeer Dify op een cloudplatform met één klik via [terraform](https://www.terraform.io/)

##### Azure Global

- [Azure Terraform door @nikawang](https://github.com/nikawang/dify-azure-terraform)

##### Google Cloud

- [Google Cloud Terraform door @sotazum](https://github.com/DeNA/dify-google-cloud-terraform)

#### Deployen met AWS CDK

Implementeer Dify op AWS met [CDK](https://aws.amazon.com/cdk/)

##### AWS

- [AWS CDK door @KevinZhao](https://github.com/aws-samples/solution-for-deploying-dify-on-aws)

## Bijdragen

Voor wie code wil bijdragen, zie onze [Contributierichtlijn](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md).
Overweeg ook Dify te steunen door het te delen op sociale media en bij evenementen en conferenties.

> Wij zoeken bijdragers om Dify te vertalen in andere talen dan Mandarijn of Engels. Ben je geïnteresseerd, bekijk dan de [i18n README](https://github.com/langgenius/dify/blob/main/web/i18n/README.md) voor meer informatie en laat een bericht achter in het `global-users` kanaal van onze [Discord Community Server](https://discord.gg/8Tpq4AcN9c).

## Community & contact

- [GitHub Discussie](https://github.com/langgenius/dify/discussions). Beste voor: feedback delen en vragen stellen.
- [GitHub Issues](https://github.com/langgenius/dify/issues). Beste voor: bugs die je ervaart met Dify.AI en functievoorstellen. Zie onze [Contributierichtlijn](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md).
- [Discord](https://discord.gg/FngNHpbcY7). Beste voor: je applicaties delen en samenkomen met de community.
- [X(Twitter)](https://twitter.com/dify_ai). Beste voor: je applicaties delen en samenkomen met de community.

**Bijdragers**

<a href="https://github.com/langgenius/dify/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=langgenius/dify" />
</a>

## Sterrenhistorie

[![Star History Chart](https://api.star-history.com/svg?repos=langgenius/dify&type=Date)](https://star-history.com/#langgenius/dify&Date)

## Beveiligingsmelding

Om je privacy te beschermen, plaats geen beveiligingsproblemen op GitHub. Stuur in plaats daarvan je vragen naar security@dify.ai en wij zullen je van een gedetailleerder antwoord voorzien.

## Licentie

Deze repository is beschikbaar onder de [Dify Open Source Licentie](LICENSE), die in wezen Apache 2.0 is met een paar extra restricties.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---