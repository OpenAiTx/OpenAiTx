<p align="right">
   <strong>Englisch</strong> | <a href="./.github/README.cn.md">中文</a> | <a href="./.github/README.jp.md">日本語</a>
</p>

<div align="center">

<a href="https://portkey.sh/report-github"><img src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Frame.png"></img></a>
<br>

# AI Gateway
#### Route zu 250+ LLMs mit einer schnellen & benutzerfreundlichen API

<img src="https://cfassets.portkey.ai/sdk.gif" width="550px" alt="Portkey AI Gateway Demo zeigt LLM-Routing-Fähigkeiten" style="margin-left:-35px">

[Dokumentation](https://portkey.wiki/gh-1) | [Enterprise](https://portkey.wiki/gh-2) | [Gehostetes Gateway](https://portkey.wiki/gh-3) | [Changelog](https://portkey.wiki/gh-4) | [API Referenz](https://portkey.wiki/gh-5)


[![Lizenz](https://img.shields.io/github/license/Ileriayo/markdown-badges)](./LICENSE)
[![Discord](https://img.shields.io/discord/1143393887742861333)](https://portkey.wiki/gh-6)
[![Twitter](https://img.shields.io/twitter/url/https/twitter/follow/portkeyai?style=social&label=Follow%20%40PortkeyAI)](https://portkey.wiki/gh-7)
[![npm version](https://badge.fury.io/js/%40portkey-ai%2Fgateway.svg)](https://portkey.wiki/gh-8)
[![Better Stack Badge](https://uptime.betterstack.com/status-badges/v1/monitor/q94g.svg)](https://portkey.wiki/gh-9)

<a href="https://us-east-1.console.aws.amazon.com/cloudformation/home?region=us-east-1#/stacks/quickcreate?stackName=portkey-gateway&templateURL=https://portkey-gateway-ec2-quicklaunch.s3.us-east-1.amazonaws.com/portkey-gateway-ec2-quicklaunch.template.yaml"><img src="https://img.shields.io/badge/Deploy_to_EC2-232F3E?style=for-the-badge&logo=amazonwebservices&logoColor=white" alt="Deploy to AWS EC2" width="105"/></a> [![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/Portkey-AI/gateway)
</div>

<br/>

Das [**AI Gateway**](https://portkey.wiki/gh-10) wurde für schnelles, zuverlässiges und sicheres Routing zu 1600+ Sprach-, Bild-, Audio- und Bildmodellen entwickelt. Es ist eine leichtgewichtige, Open-Source- und Enterprise-taugliche Lösung, mit der Sie sich in weniger als 2 Minuten mit jedem Sprachmodell integrieren können.

- [x] **Blitzschnell** (<1ms Latenz) mit kleinem Footprint (122kb)
- [x] **Bewährt im Einsatz**, mit über 10 Mrd. verarbeiteten Tokens pro Tag
- [x] **Enterprise-tauglich** mit erhöhter Sicherheit, Skalierbarkeit und individuellen Deployments

<br>

#### Was können Sie mit dem AI Gateway tun?
- Integrieren Sie sich mit jedem LLM in unter 2 Minuten – [Schnellstart](#quickstart-2-mins)
- Verhindern Sie Ausfälle durch **[automatische Wiederholungen](https://portkey.wiki/gh-11)** und **[Fallbacks](https://portkey.wiki/gh-12)**
- Skalieren Sie KI-Anwendungen mit **[Lastverteilung](https://portkey.wiki/gh-13)** und **[konditionalem Routing](https://portkey.wiki/gh-14)**
- Schützen Sie Ihre KI-Bereitstellungen mit **[Guardrails](https://portkey.wiki/gh-15)**
- Gehen Sie über Text hinaus mit **[multimodalen Fähigkeiten](https://portkey.wiki/gh-16)**
- Erkunden Sie schließlich **[agentische Workflow-Integrationen](https://portkey.wiki/gh-17)**

<br><br>

> [!TIPP]
> Einen Stern für dieses Repo zu vergeben, hilft mehr Entwicklern, das AI Gateway zu entdecken 🙏🏻
>
> ![star-2](https://github.com/user-attachments/assets/53597dce-6333-4ecc-a154-eb05532954e4)
> 
<br>


<br>

## Schnellstart (2 Minuten)

### 1. Richten Sie Ihr AI Gateway ein

```bash
# Gateway lokal ausführen (benötigt Node.js und npm)
npx @portkey-ai/gateway
```
> Das Gateway läuft unter `http://localhost:8787/v1`
> 
> Die Gateway-Konsole ist unter `http://localhost:8787/public/` erreichbar

<sup>
Bereitstellungsanleitungen:
&nbsp; <a href="https://portkey.wiki/gh-18"><img height="12" width="12" src="https://cfassets.portkey.ai/logo/dew-color.svg" /> Portkey Cloud (Empfohlen)</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#docker"><img height="12" width="12" src="https://cdn.simpleicons.org/docker/3776AB" /> Docker</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#nodejs-server"><img height="12" width="12" src="https://cdn.simpleicons.org/node.js/3776AB" /> Node.js</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#cloudflare-workers"><img height="12" width="12" src="https://cdn.simpleicons.org/cloudflare/3776AB" /> Cloudflare</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#replit"><img height="12" width="12" src="https://cdn.simpleicons.org/replit/3776AB" /> Replit</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md"> Andere...</a>

</sup>

### 2. Senden Sie Ihre erste Anfrage

<!-- <details open>
<summary>Python Beispiel</summary> -->
```python
# pip install -qU portkey-ai

from portkey_ai import Portkey

# OpenAI-kompatibler Client
client = Portkey(
    provider="openai", # oder 'anthropic', 'bedrock', 'groq', etc
    Authorization="sk-***" # Der API-Schlüssel des Providers
)

# Anfrage über Ihr AI Gateway stellen
client.chat.completions.create(
    messages=[{"role": "user", "content": "Wie ist das Wetter?"}],
    model="gpt-4o-mini"
)
```



<sup>Unterstützte Bibliotheken:
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/javascript/3776AB" /> JS](https://portkey.wiki/gh-19)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/python/3776AB" /> Python](https://portkey.wiki/gh-20)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/gnubash/3776AB" /> REST](https://portkey.sh/gh-84)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/openai/3776AB" /> OpenAI SDKs](https://portkey.wiki/gh-21)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/langchain/3776AB" /> Langchain](https://portkey.wiki/gh-22)
&nbsp; [LlamaIndex](https://portkey.wiki/gh-23)
&nbsp; [Autogen](https://portkey.wiki/gh-24)
&nbsp; [CrewAI](https://portkey.wiki/gh-25)
&nbsp; [Mehr..](https://portkey.wiki/gh-26)
</sup>

In der Gateway-Konsole (`http://localhost:8787/public/`) können Sie alle lokalen Logs an einem Ort einsehen.

<img src="https://github.com/user-attachments/assets/362bc916-0fc9-43f1-a39e-4bd71aac4a3a" width="400" />


### 3. Routing & Guardrails
Mit `Configs` im LLM Gateway können Sie Routing-Regeln erstellen, Zuverlässigkeit erhöhen und Guardrails einrichten.
```python
config = {
  "retry": {"attempts": 5},

  "output_guardrails": [{
    "default.contains": {"operator": "none", "words": ["Apple"]},
    "deny": True
  }]
}

# Konfiguration an den Client anhängen
client = client.with_options(config=config)

client.chat.completions.create(
    model="gpt-4o-mini",
    messages=[{"role": "user", "content": "Antworte zufällig mit Apfel oder Fledermaus"}]
)

# Dies würde immer mit "Fledermaus" antworten, da die Guardrail alle Antworten mit "Apple" verweigert. Die Retry-Konfiguration versucht es 5 Mal, bevor sie aufgibt.
```
<div align="center">
<img src="https://portkey.ai/blog/content/images/size/w1600/2024/11/image-15.png" width=600 title="Anfrageablauf durch das Portkey AI Gateway mit Retries und Guardrails" alt="Anfrageablauf durch das Portkey AI Gateway mit Retries und Guardrails"/>
</div>

Mit Konfigurationen in Ihrem AI Gateway können Sie noch viel mehr machen. [Zu den Beispielen  →](https://portkey.wiki/gh-27)

<br/>

### Enterprise-Version (Private Deployments)

<sup>

[<img height="12" width="12" src="https://cfassets.portkey.ai/amazon-logo.svg" /> AWS](https://portkey.wiki/gh-28)
&nbsp; [<img height="12" width="12" src="https://cfassets.portkey.ai/azure-logo.svg" /> Azure](https://portkey.wiki/gh-29)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/googlecloud/3776AB" /> GCP](https://portkey.wiki/gh-30)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/redhatopenshift/3776AB" /> OpenShift](https://portkey.wiki/gh-31)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/kubernetes/3776AB" /> Kubernetes](https://portkey.wiki/gh-85)

</sup>

Die [Enterprise-Version](https://portkey.wiki/gh-86) des LLM Gateway bietet erweiterte Funktionen für **Organisationsverwaltung**, **Governance**, **Sicherheit** und [mehr](https://portkey.wiki/gh-87) direkt out-of-the-box. [Funktionsvergleich anzeigen →](https://portkey.wiki/gh-32)

Die Enterprise-Bereitstellungsarchitektur für unterstützte Plattformen finden Sie hier – [**Enterprise Private Cloud Deployments**](https://portkey.wiki/gh-33)

<a href="https://portkey.sh/demo-13"><img src="https://portkey.ai/blog/content/images/2024/08/Get-API-Key--5-.png" height=50 alt="Enterprise AI Gateway Demo buchen" /></a><br/>


<br>

<hr>

### AI Engineering Hours

Nehmen Sie jeden Freitag (8 Uhr PT) an den wöchentlichen Community-Calls teil, um den Start Ihres AI Gateway-Projekts zu beschleunigen! [Jeden Freitag live](https://portkey.wiki/gh-35)

<a href="https://portkey.wiki/gh-35"><img width="500" src="https://github.com/user-attachments/assets/c2885699-f197-4289-b819-21eb839fbae1" /></a>

Protokolle der Meetings [hier veröffentlicht](https://portkey.wiki/gh-36).


<hr>

### LLMs in Prod'25

Erkenntnisse aus der Analyse von über 2 Billionen Tokens, über 90+ Regionen und 650+ Teams in der Produktion. Was Sie von diesem Bericht erwarten können:
- Trends, die die KI-Adoption und das Wachstum der LLM-Anbieter prägen.
- Benchmarks zur Optimierung von Geschwindigkeit, Kosten und Zuverlässigkeit.
- Strategien, um KI-Systeme in Produktionsqualität zu skalieren.

<a href="https://portkey.sh/report-github"><img width="500" src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Image.png" /></a>

<a href="https://portkey.sh/report-github">**Bericht anfordern**</a>
<hr>


## Kernfunktionen
### Zuverlässiges Routing
- <a href="https://portkey.wiki/gh-37">**Fallbacks**</a>: Fallback auf einen anderen Anbieter oder ein anderes Modell bei fehlgeschlagenen Anfragen über das LLM-Gateway. Sie können die Fehler angeben, bei denen der Fallback ausgelöst werden soll. Verbessert die Zuverlässigkeit Ihrer Anwendung.
- <a href="https://portkey.wiki/gh-38">**Automatische Wiederholungen**</a>: Fehlgeschlagene Anfragen werden automatisch bis zu 5-mal wiederholt. Eine exponentielle Backoff-Strategie verteilt die Wiederholungsversuche, um eine Überlastung des Netzwerks zu verhindern.
- <a href="https://portkey.wiki/gh-39">**Lastenausgleich**</a>: Verteilen Sie LLM-Anfragen auf mehrere API-Schlüssel oder KI-Anbieter mit Gewichtung, um eine hohe Verfügbarkeit und optimale Leistung zu gewährleisten.
- <a href="https://portkey.wiki/gh-40">**Anfrage-Timeouts**</a>: Verwalten Sie widerspenstige LLMs und Latenzen, indem Sie granulare Anfrage-Timeouts einrichten, wodurch Anfragen, die eine bestimmte Dauer überschreiten, automatisch beendet werden.
- <a href="https://portkey.wiki/gh-41">**Multimodales LLM-Gateway**</a>: Rufen Sie Vision-, Audio- (Text-to-Speech & Speech-to-Text) und Bildgenerierungsmodelle von mehreren Anbietern auf — alles mit der vertrauten OpenAI-Signatur.
- <a href="https://portkey.wiki/gh-42">**Echtzeit-APIs**</a>: Rufen Sie von OpenAI gestartete Echtzeit-APIs über den integrierten Websocket-Server auf.

### Sicherheit & Genauigkeit
- <a href="https://portkey.wiki/gh-88">**Guardrails**</a>: Überprüfen Sie Ihre LLM-Ein- und Ausgaben, um sicherzustellen, dass sie Ihren definierten Prüfungen entsprechen. Wählen Sie aus über 40 vorgefertigten Guardrails, um die Einhaltung von Sicherheits- und Genauigkeitsstandards zu gewährleisten. Sie können <a href="https://portkey.wiki/gh-43">eigene Guardrails einbringen</a> oder aus unseren <a href="https://portkey.wiki/gh-44">zahlreichen Partnern</a> wählen.
- [**Sichere Schlüsselverwaltung**](https://portkey.wiki/gh-45): Verwenden Sie eigene Schlüssel oder generieren Sie virtuelle Schlüssel nach Bedarf.
- [**Rollenbasierte Zugriffskontrolle**](https://portkey.wiki/gh-46): Granulare Zugriffskontrolle für Ihre Benutzer, Workspaces und API-Schlüssel.
- <a href="https://portkey.wiki/gh-47">**Compliance & Datenschutz**</a>: Das KI-Gateway ist SOC2-, HIPAA-, DSGVO- und CCPA-konform.

### Kostenmanagement
- [**Intelligentes Caching**](https://portkey.wiki/gh-48): Zwischenspeichern von LLM-Antworten zur Kostensenkung und Verbesserung der Latenz. Unterstützt einfaches und semantisches* Caching.
- [**Nutzungsanalysen**](https://portkey.wiki/gh-49): Überwachen und analysieren Sie Ihre KI- und LLM-Nutzung, einschließlich Anfragevolumen, Latenz, Kosten und Fehlerquoten.
- [**Anbieteroptimierung***](https://portkey.wiki/gh-89): Automatischer Wechsel zum kosteneffizientesten Anbieter basierend auf Nutzungsverhalten und Preismodellen.

### Zusammenarbeit & Workflows
- <a href="https://portkey.ai/docs/integrations/agents">**Agenten-Unterstützung**</a>: Nahtlose Integration mit beliebten Agenten-Frameworks zum Aufbau komplexer KI-Anwendungen. Das Gateway integriert sich nahtlos mit [Autogen](https://portkey.wiki/gh-50), [CrewAI](https://portkey.wiki/gh-51), [LangChain](https://portkey.wiki/gh-52), [LlamaIndex](https://portkey.wiki/gh-53), [Phidata](https://portkey.wiki/gh-54), [Control Flow](https://portkey.wiki/gh-55) und sogar [eigenen Agenten](https://portkey.wiki/gh-56).
- [**Prompt-Template-Management***](https://portkey.wiki/gh-57): Erstellen, verwalten und versionieren Sie Ihre Prompt-Templates gemeinsam über einen universellen Prompt-Playground.
<br/><br/>

<sup>
*&nbsp;Verfügbar in gehosteten und Enterprise-Versionen
</sup>

<br>

## Kochbücher

### ☄️ Aktuelle Trends
- Verwenden Sie Modelle von [Nvidia NIM](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/providers/nvidia.ipynb) mit dem AI Gateway
- Überwachen Sie [CrewAI-Agenten](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/CrewAI_with_Telemetry.ipynb) mit Portkey!
- Vergleich der [Top 10 LMSYS-Modelle](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/LMSYS%20Series/comparing-top10-LMSYS-models-with-Portkey.ipynb) mit AI Gateway.

### 🚨 Neueste
* [Erstellen Sie synthetische Datensätze mit Nemotron](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/Nemotron_GPT_Finetuning_Portkey.ipynb)
* [Verwendung des LLM-Gateways mit Vercels AI SDK](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/integrations/vercel-ai.md)
* [Überwachen Sie Llama-Agenten mit Portkeys LLM-Gateway](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/Llama_Agents_with_Telemetry.ipynb)

[Alle Kochbücher ansehen →](https://portkey.wiki/gh-58)
<br/><br/>

## Unterstützte Anbieter

Entdecken Sie Gateway-Integrationen mit [45+ Anbietern](https://portkey.wiki/gh-59) und [8+ Agenten-Frameworks](https://portkey.wiki/gh-90).

|                                                                                                                            | Anbieter                                                                                      | Support | Stream |
| -------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | ------- | ------ |
| <img src="docs/images/openai.png" width=35 />                                                                              | [OpenAI](https://portkey.wiki/gh-60)                           | ✅       | ✅      |
| <img src="docs/images/azure.png" width=35>                                                                                 | [Azure OpenAI](https://portkey.wiki/gh-61)               | ✅       | ✅      |
| <img src="docs/images/anyscale.png" width=35>                                                                              | [Anyscale](https://portkey.wiki/gh-62) | ✅       | ✅      |
| <img src="https://upload.wikimedia.org/wikipedia/commons/2/2d/Google-favicon-2015.png" width=35>                           | [Google Gemini](https://portkey.wiki/gh-63)             | ✅       | ✅      |
| <img src="docs/images/anthropic.png" width=35>                                                                             | [Anthropic](https://portkey.wiki/gh-64)                     | ✅       | ✅      |
| <img src="docs/images/cohere.png" width=35>                                                                                | [Cohere](https://portkey.wiki/gh-65)                           | ✅       | ✅      |
| <img src="https://assets-global.website-files.com/64f6f2c0e3f4c5a91c1e823a/654693d569494912cfc0c0d4_favicon.svg" width=35> | [Together AI](https://portkey.wiki/gh-66)                 | ✅       | ✅      |
| <img src="https://www.perplexity.ai/favicon.svg" width=35>                                                                 | [Perplexity](https://portkey.wiki/gh-67)                | ✅       | ✅      |
| <img src="https://docs.mistral.ai/img/favicon.ico" width=35>                                                               | [Mistral](https://portkey.wiki/gh-68)                      | ✅       | ✅      |
| <img src="https://docs.nomic.ai/img/nomic-logo.png" width=35>                                                              | [Nomic](https://portkey.wiki/gh-69)                             | ✅       | ✅      |
| <img src="https://files.readme.io/d38a23e-small-studio-favicon.png" width=35>                                              | [AI21](https://portkey.wiki/gh-91)                                    | ✅       | ✅      |
| <img src="https://platform.stability.ai/small-logo-purple.svg" width=35>                                                   | [Stability AI](https://portkey.wiki/gh-71)               | ✅       | ✅      |
| <img src="https://deepinfra.com/_next/static/media/logo.4a03fd3d.svg" width=35>                                            | [DeepInfra](https://portkey.sh/gh-92)                               | ✅       | ✅      |
| <img src="https://ollama.com/public/ollama.png" width=35>                                                                  | [Ollama](https://portkey.wiki/gh-72)                           | ✅       | ✅      |
| <img src="https://novita.ai/favicon.ico" width=35>                                                                         | [Novita AI](https://portkey.wiki/gh-73)                              | ✅       | ✅      | `/chat/completions`, `/completions` |


> [Sehen Sie hier die vollständige Liste der über 200 unterstützten Modelle](https://portkey.wiki/gh-74)
<br>

<br>

## Agenten
Gateway integriert sich nahtlos mit beliebten Agenten-Frameworks. [Lesen Sie die Dokumentation hier](https://portkey.wiki/gh-75).


| Framework | Über 200 LLMs aufrufen | Fortgeschrittenes Routing | Caching | Logging & Tracing* | Beobachtbarkeit* | Prompt-Management* |
|------------------------------|--------|-------------|---------|------|---------------|-------------------|
| [Autogen](https://portkey.wiki/gh-93)    | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [CrewAI](https://portkey.wiki/gh-94)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [LangChain](https://portkey.wiki/gh-95)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Phidata](https://portkey.wiki/gh-96)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Llama Index](https://portkey.wiki/gh-97)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Control Flow](https://portkey.wiki/gh-98) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Eigenes Agenten-Framework](https://portkey.wiki/gh-99) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |

<br>

*Verfügbar in der [gehosteten App](https://portkey.wiki/gh-76). Für ausführliche Dokumentation [hier klicken](https://portkey.wiki/gh-100).


## Gateway Enterprise-Version
Machen Sie Ihre KI-App <ins>zuverlässiger</ins> und <ins>zukunftssicher</ins> und stellen Sie vollständige <ins>Datensicherheit</ins> und <ins>Datenschutz</ins> sicher.

✅&nbsp; Sichere Schlüsselverwaltung – für rollenbasierte Zugriffskontrolle und Nachverfolgung <br>
✅&nbsp; Einfaches & Semantisches Caching – um wiederkehrende Anfragen schneller zu bedienen & Kosten zu sparen <br>
✅&nbsp; Zugriffskontrolle & Eingehende Regeln – zur Steuerung, welche IPs und Regionen auf Ihre Deployments zugreifen können <br>
✅&nbsp; PII-Redaktion – automatische Entfernung sensibler Daten aus Ihren Anfragen, um unbeabsichtigte Offenlegung zu verhindern <br>
✅&nbsp; SOC2-, ISO-, HIPAA-, DSGVO-Konformität – für beste Sicherheitspraktiken <br>
✅&nbsp; Professioneller Support – inklusive Feature-Priorisierung <br>

[Vereinbaren Sie einen Termin, um Unternehmensbereitstellungen zu besprechen](https://portkey.sh/demo-13)

<br>


## Beitrag leisten

Am einfachsten ist es, ein Issue mit dem Tag `good first issue` 💪 auszuwählen. Lesen Sie die Beitragsrichtlinien [hier](https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/CONTRIBUTING.md).

Fehler gefunden? [Hier melden](https://portkey.wiki/gh-78) | Funktionswunsch? [Hier melden](https://portkey.wiki/gh-78)


### Einstieg in die Community
Nehmen Sie jeden Freitag (8 Uhr PT) an unseren wöchentlichen AI Engineering Hours teil, um:
- Andere Mitwirkende und Community-Mitglieder zu treffen
- Erweiterte Gateway-Features und Implementierungsmuster kennenzulernen
- Erfahrungen zu teilen und Hilfe zu erhalten
- Über die neuesten Entwicklungsprioritäten auf dem Laufenden zu bleiben

[Nehmen Sie an der nächsten Sitzung teil →](https://portkey.wiki/gh-101) | [Besprechungsnotizen](https://portkey.wiki/gh-102)

<br>

## Community

Werden Sie Teil unserer wachsenden Community weltweit – für Hilfe, Ideen und Diskussionen rund um KI.

- Lesen Sie unseren offiziellen [Blog](https://portkey.wiki/gh-78)
- Chatten Sie mit uns auf [Discord](https://portkey.wiki/community)
- Folgen Sie uns auf [Twitter](https://portkey.wiki/gh-79)
- Vernetzen Sie sich mit uns auf [LinkedIn](https://portkey.wiki/gh-80)
- Lesen Sie die Dokumentation auf [Japanisch](https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.jp.md)
- Besuchen Sie uns auf [YouTube](https://portkey.wiki/gh-103)
- Treten Sie unserer [Dev-Community](https://portkey.wiki/gh-82) bei
<!-- - Fragen mit dem Tag #portkey auf [Stack Overflow](https://stackoverflow.com/questions/tagged/portkey) -->

![Rubeus Social Share (4)](https://github.com/Portkey-AI/gateway/assets/971978/89d6f0af-a95d-4402-b451-14764c40d03f)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---