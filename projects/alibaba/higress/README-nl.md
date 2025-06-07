<a name="readme-top"></a>
<h1 align="center">
    <img src="https://img.alicdn.com/imgextra/i2/O1CN01NwxLDd20nxfGBjxmZ_!!6000000006895-2-tps-960-290.png" alt="Higress" width="240" height="72.5">
  <br>
  AI Gateway
</h1>
<h4 align="center"> AI Native API Gateway </h4>

<div align="center">
    
[![Build Status](https://github.com/alibaba/higress/actions/workflows/build-and-test.yaml/badge.svg?branch=main)](https://github.com/alibaba/higress/actions)
[![license](https://img.shields.io/github/license/alibaba/higress.svg)](https://www.apache.org/licenses/LICENSE-2.0.html)
[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=flat-square)](https://discord.gg/tSbww9VDaM)

<a href="https://trendshift.io/repositories/10918" target="_blank"><img src="https://trendshift.io/api/badge/repositories/10918" alt="alibaba%2Fhigress | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a> <a href="https://www.producthunt.com/posts/higress?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-higress" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=951287&theme=light&t=1745492822283" alt="Higress - Global&#0032;APIs&#0032;as&#0032;MCP&#0032;powered&#0032;by&#0032;AI&#0032;Gateway | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

</div>

[**Officiële Website**](https://higress.ai/en/) &nbsp; |
&nbsp; [**MCP Server QuickStart**](https://higress.cn/en/ai/mcp-quick-start/) &nbsp; |
&nbsp; [**Wasm Plugin Hub**](https://higress.cn/en/plugin/) &nbsp; |

<p>
   English | <a href="README_ZH.md">中文<a/> | <a href="README_JP.md">日本語<a/>
</p>

## Wat is Higress?

Higress is een cloud-native API-gateway gebaseerd op Istio en Envoy, die kan worden uitgebreid met Wasm-plugins geschreven in Go/Rust/JS. Het biedt tientallen direct inzetbare, algemene plugins en een gebruiksklare console (probeer de [demo hier](http://demo.higress.io/)).

### Belangrijkste Toepassingen

De AI-gatewaymogelijkheden van Higress ondersteunen alle [mainstream modelproviders](https://raw.githubusercontent.com/alibaba/higress/main/plugins/wasm-go/extensions/ai-proxy/provider) zowel nationaal als internationaal. Het ondersteunt ook hosting van MCP (Model Context Protocol) Servers via het pluginmechanisme, waardoor AI Agents eenvoudig verschillende tools en diensten kunnen aanroepen. Met de [openapi-to-mcp tool](https://github.com/higress-group/openapi-to-mcpserver) kun je snel OpenAPI-specificaties omzetten naar externe MCP-servers voor hosting. Higress biedt een uniforme beheerslaag voor zowel LLM API als MCP API.

**🌟 Probeer het nu op [https://mcp.higress.ai/](https://mcp.higress.ai/)** om zelf ervaring op te doen met door Higress gehoste Remote MCP Servers:

![Higress MCP Server Platform](https://img.alicdn.com/imgextra/i2/O1CN01nmVa0a1aChgpyyWOX_!!6000000003294-0-tps-3430-1742.jpg)

### Gebruik door Bedrijven

Higress is ontstaan binnen Alibaba om problemen met Tengine-herlaadacties (die langlopende verbindingen verstoren) en onvoldoende loadbalancing voor gRPC/Dubbo op te lossen. Binnen Alibaba Cloud ondersteunen de AI-gatewaymogelijkheden van Higress kern AI-toepassingen zoals het Tongyi Bailian modelstudio, machine learning PAI-platform en andere essentiële AI-diensten. Alibaba Cloud heeft zijn cloud-native API-gatewayproduct gebouwd op Higress, en levert 99,99% hoge beschikbaarheid van de gateway voor vele zakelijke klanten.

## Inhoudsopgave

- [**Snelstart**](#snelstart)    
- [**Functieoverzicht**](#functieoverzicht)
- [**Toepassingen**](#toepassingen)
- [**Kernvoordelen**](#kernvoordelen)
- [**Community**](#community)

## Snelstart

Higress kan eenvoudig met Docker worden gestart, waardoor individuele ontwikkelaars het lokaal kunnen opzetten voor studie of voor het bouwen van eenvoudige sites:

```bash
# Maak een werkmap aan
mkdir higress; cd higress
# Start higress, configuratiebestanden worden geschreven naar de werkmap
docker run -d --rm --name higress-ai -v ${PWD}:/data \
        -p 8001:8001 -p 8080:8080 -p 8443:8443  \
        higress-registry.cn-hangzhou.cr.aliyuncs.com/higress/all-in-one:latest
```

Poortbeschrijvingen:

- Poort 8001: Higress UI console ingang
- Poort 8080: Gateway HTTP protocol ingang
- Poort 8443: Gateway HTTPS protocol ingang

> Alle Higress Docker-images gebruiken de eigen imagerepository van Higress en worden niet beïnvloed door Docker Hub snelheidslimieten.
> Daarnaast zijn de uploads en updates van images beschermd door een beveiligingsscanningmechanisme (aangedreven door Alibaba Cloud ACR), waardoor ze zeer veilig zijn voor gebruik in productieomgevingen.
> 
> Mocht je een timeout ervaren bij het ophalen van het image van `higress-registry.cn-hangzhou.cr.aliyuncs.com`, probeer dan de volgende Docker registry mirror:
> 
> **Zuidoost-Azië**: `higress-registry.ap-southeast-7.cr.aliyuncs.com`

Voor andere installatiemethoden, zoals Helm-deployment onder K8s, raadpleeg de officiële [Quick Start documentatie](https://higress.io/en-us/docs/user/quickstart).

## Toepassingen

- **MCP Server Hosting**:

  Higress host MCP Servers via het pluginmechanisme, waardoor AI Agents eenvoudig verschillende tools en diensten kunnen aanroepen. Met de [openapi-to-mcp tool](https://github.com/higress-group/openapi-to-mcpserver) kun je snel OpenAPI-specificaties omzetten naar externe MCP-servers.

  ![](https://img.alicdn.com/imgextra/i1/O1CN01wv8H4g1mS4MUzC1QC_!!6000000004952-2-tps-1764-597.png)

  Belangrijkste voordelen van MCP Server hosting met Higress:
  - Uniforme authenticatie- en autorisatiemechanismen
  - Fijngranulaire snelheidslimiet om misbruik te voorkomen
  - Uitgebreide auditlogs voor alle tool-aanroepen
  - Rijke observabiliteit voor prestatiemonitoring
  - Vereenvoudigde deployment via het Higress pluginmechanisme
  - Dynamische updates zonder onderbrekingen of verbindingsverlies

     [Meer informatie...](https://higress.cn/en/ai/mcp-quick-start/?spm=36971b57.7beea2de.0.0.d85f20a94jsWGm)

- **AI Gateway**:

  Higress verbindt met alle LLM-modelproviders via een uniform protocol, met AI-observabiliteit, multi-model loadbalancing, tokenratelimiet en cachingmogelijkheden:

  ![](https://img.alicdn.com/imgextra/i2/O1CN01izmBNX1jbHT7lP3Yr_!!6000000004566-0-tps-1920-1080.jpg)

- **Kubernetes ingress controller**:

  Higress kan dienen als een uitgebreide ingress controller, compatibel met veel annotaties van de K8s nginx ingress controller.
  
  [Gateway API](https://gateway-api.sigs.k8s.io/) ondersteuning komt binnenkort en zal soepele migratie van Ingress API naar Gateway API mogelijk maken.
  
- **Microservice gateway**:

  Higress kan fungeren als microservice gateway, en kan microservices ontdekken uit verschillende service registries, zoals Nacos, ZooKeeper, Consul, Eureka, enz.
  
  Het integreert diep met [Dubbo](https://github.com/apache/dubbo), [Nacos](https://github.com/alibaba/nacos), [Sentinel](https://github.com/alibaba/Sentinel) en andere microservice-technologiestacks.
  
- **Security gateway**:

  Higress kan worden ingezet als security gateway, met ondersteuning voor WAF en diverse authenticatiestrategieën zoals key-auth, hmac-auth, jwt-auth, basic-auth, oidc, enz.


## Kernvoordelen

- **Productieklaar**

  Ontstaan als intern product bij Alibaba met meer dan 2 jaar productievalidatie, ondersteuning van grootschalige scenario's met honderdduizenden verzoeken per seconde.

  Elimineert volledig verkeersschommelingen veroorzaakt door Nginx herlaadacties, configuratiewijzigingen zijn in milliseconden actief en transparant voor de business. Vooral geschikt voor scenario's met langlopende verbindingen, zoals AI-diensten.

- **Streamingverwerking**

  Ondersteunt volledige streamingverwerking van request/response-bodies, Wasm-plugins kunnen eenvoudig streamingprotocollen zoals SSE (Server-Sent Events) aanpassen.

  In scenario's met hoge bandbreedte, zoals AI-diensten, wordt het geheugengebruik aanzienlijk verlaagd.
    
- **Eenvoudig uit te breiden**
  
  Biedt een uitgebreide officiële pluginbibliotheek die AI, traffic management, beveiligingsbescherming en andere veelvoorkomende functies dekt, waarmee aan meer dan 90% van de zakelijke scenario's wordt voldaan.

  Richt zich op Wasm-pluginextensies, garandeert geheugenveiligheid door sandbox-isolatie, ondersteunt meerdere programmeertalen, maakt onafhankelijke pluginversie-upgrades mogelijk, en realiseert hot updates van gateway-logica zonder verkeersverlies.

- **Veilig en gebruiksvriendelijk**
  
  Gebaseerd op Ingress API- en Gateway API-standaarden, biedt een out-of-the-box UI-console, WAF-beschermingsplugin, IP/Cookie CC-beschermingsplugin direct inzetbaar.

  Ondersteunt aansluiting op Let's Encrypt voor automatische uitgifte en verlenging van gratis certificaten, en kan buiten K8s worden ingezet, te starten met één enkele Docker-opdracht, handig voor individuele ontwikkelaars.

## Community

Word lid van onze Discord-community! Hier kun je in contact komen met ontwikkelaars en andere enthousiaste gebruikers van Higress.

[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=for-the-badge)](https://discord.gg/tSbww9VDaM)


### Dankwoord

Higress zou niet mogelijk zijn zonder het waardevolle open source-werk van projecten uit de community. In het bijzonder danken wij Envoy en Istio.

### Gerelateerde Repositories

- Higress Console: https://github.com/higress-group/higress-console
- Higress Standalone: https://github.com/higress-group/higress-standalone

### Bijdragers

<a href="https://github.com/alibaba/higress/graphs/contributors">
  <img alt="contributors" src="https://contrib.rocks/image?repo=alibaba/higress"/>
</a>

### Sterrenhistorie

[![Star History Chart](https://api.star-history.com/svg?repos=alibaba/higress&type=Date)](https://star-history.com/#alibaba/higress&Date)

<p align="right" style="font-size: 14px; color: #555; margin-top: 20px;">
    <a href="#readme-top" style="text-decoration: none; color: #007bff; font-weight: bold;">
        ↑ Terug naar boven ↑
    </a>
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---