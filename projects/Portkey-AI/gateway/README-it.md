<p align="right">
   <strong>Italiano</strong> | <a href="./.github/README.cn.md">中文</a> | <a href="./.github/README.jp.md">日本語</a>
</p>

<div align="center">

<a href="https://portkey.sh/report-github"><img src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Frame.png"></img></a>
<br>

# AI Gateway
#### Instrada verso più di 250 LLM con 1 API veloce e intuitiva

<img src="https://cfassets.portkey.ai/sdk.gif" width="550px" alt="Portkey AI Gateway Demo showing LLM routing capabilities" style="margin-left:-35px">

[Documentazione](https://portkey.wiki/gh-1) | [Enterprise](https://portkey.wiki/gh-2) | [Gateway Ospitato](https://portkey.wiki/gh-3) | [Changelog](https://portkey.wiki/gh-4) | [Riferimento API](https://portkey.wiki/gh-5)


[![Licenza](https://img.shields.io/github/license/Ileriayo/markdown-badges)](./LICENSE)
[![Discord](https://img.shields.io/discord/1143393887742861333)](https://portkey.wiki/gh-6)
[![Twitter](https://img.shields.io/twitter/url/https/twitter/follow/portkeyai?style=social&label=Follow%20%40PortkeyAI)](https://portkey.wiki/gh-7)
[![npm version](https://badge.fury.io/js/%40portkey-ai%2Fgateway.svg)](https://portkey.wiki/gh-8)
[![Better Stack Badge](https://uptime.betterstack.com/status-badges/v1/monitor/q94g.svg)](https://portkey.wiki/gh-9)

<a href="https://us-east-1.console.aws.amazon.com/cloudformation/home?region=us-east-1#/stacks/quickcreate?stackName=portkey-gateway&templateURL=https://portkey-gateway-ec2-quicklaunch.s3.us-east-1.amazonaws.com/portkey-gateway-ec2-quicklaunch.template.yaml"><img src="https://img.shields.io/badge/Deploy_to_EC2-232F3E?style=for-the-badge&logo=amazonwebservices&logoColor=white" alt="Deploy to AWS EC2" width="105"/></a> [![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/Portkey-AI/gateway)
</div>

<br/>

Il [**AI Gateway**](https://portkey.wiki/gh-10) è progettato per instradare in modo veloce, affidabile e sicuro verso oltre 1600 modelli linguistici, visivi, audio e di immagini. È una soluzione leggera, open-source e pronta per l’uso aziendale che ti permette di integrarti con qualsiasi modello linguistico in meno di 2 minuti.

- [x] **Fulmineo** (<1ms di latenza) con un ingombro minimo (122kb)
- [x] **Testato in battaglia**, con oltre 10 miliardi di token processati ogni giorno
- [x] **Pronto per l’azienda** con sicurezza avanzata, scalabilità e deployment personalizzati

<br>

#### Cosa puoi fare con l’AI Gateway?
- Integrati con qualsiasi LLM in meno di 2 minuti - [Avvio rapido](#quickstart-2-mins)
- Previeni i downtime tramite **[ritentativi automatici](https://portkey.wiki/gh-11)** e **[fallback](https://portkey.wiki/gh-12)**
- Scala le app AI con **[load balancing](https://portkey.wiki/gh-13)** e **[instradamento condizionale](https://portkey.wiki/gh-14)**
- Proteggi i tuoi deployment AI con **[guardrail](https://portkey.wiki/gh-15)**
- Oltre il testo con **[funzionalità multimodali](https://portkey.wiki/gh-16)**
- Esplora infine integrazioni di **[workflow agentico](https://portkey.wiki/gh-17)**

<br><br>

> [!TIP]
> Aggiungere una stella a questo repo aiuta più sviluppatori a scoprire AI Gateway 🙏🏻
>
> ![star-2](https://github.com/user-attachments/assets/53597dce-6333-4ecc-a154-eb05532954e4)
> 
<br>


<br>

## Avvio rapido (2 minuti)

### 1. Configura il tuo AI Gateway

```bash
# Esegui il gateway in locale (necessita Node.js e npm)
npx @portkey-ai/gateway
```
> Il Gateway è in esecuzione su `http://localhost:8787/v1`
> 
> La Console Gateway è in esecuzione su `http://localhost:8787/public/`

<sup>
Guide al deployment:
&nbsp; <a href="https://portkey.wiki/gh-18"><img height="12" width="12" src="https://cfassets.portkey.ai/logo/dew-color.svg" /> Portkey Cloud (Consigliato)</a>
&nbsp; <a href="./docs/installation-deployments.md#docker"><img height="12" width="12" src="https://cdn.simpleicons.org/docker/3776AB" /> Docker</a>
&nbsp; <a href="./docs/installation-deployments.md#nodejs-server"><img height="12" width="12" src="https://cdn.simpleicons.org/node.js/3776AB" /> Node.js</a>
&nbsp; <a href="./docs/installation-deployments.md#cloudflare-workers"><img height="12" width="12" src="https://cdn.simpleicons.org/cloudflare/3776AB" /> Cloudflare</a>
&nbsp; <a href="./docs/installation-deployments.md#replit"><img height="12" width="12" src="https://cdn.simpleicons.org/replit/3776AB" /> Replit</a>
&nbsp; <a href="./docs/installation-deployments.md"> Altri...</a>

</sup>

### 2. Effettua la tua prima richiesta

<!-- <details open>
<summary>Esempio Python</summary> -->
```python
# pip install -qU portkey-ai

from portkey_ai import Portkey

# Client compatibile con OpenAI
client = Portkey(
    provider="openai", # oppure 'anthropic', 'bedrock', 'groq', ecc
    Authorization="sk-***" # la API key del provider
)

# Effettua una richiesta tramite il tuo AI Gateway
client.chat.completions.create(
    messages=[{"role": "user", "content": "Che tempo fa?"}],
    model="gpt-4o-mini"
)
```



<sup>Librerie supportate:
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/javascript/3776AB" /> JS](https://portkey.wiki/gh-19)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/python/3776AB" /> Python](https://portkey.wiki/gh-20)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/gnubash/3776AB" /> REST](https://portkey.sh/gh-84)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/openai/3776AB" /> OpenAI SDKs](https://portkey.wiki/gh-21)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/langchain/3776AB" /> Langchain](https://portkey.wiki/gh-22)
&nbsp; [LlamaIndex](https://portkey.wiki/gh-23)
&nbsp; [Autogen](https://portkey.wiki/gh-24)
&nbsp; [CrewAI](https://portkey.wiki/gh-25)
&nbsp; [Altro..](https://portkey.wiki/gh-26)
</sup>

Nella Gateway Console (`http://localhost:8787/public/`) puoi vedere tutti i tuoi log locali in un unico posto.

<img src="https://github.com/user-attachments/assets/362bc916-0fc9-43f1-a39e-4bd71aac4a3a" width="400" />


### 3. Routing & Guardrail
Le `Config` nel gateway LLM ti permettono di creare regole di instradamento, aggiungere affidabilità e impostare guardrail.
```python
config = {
  "retry": {"attempts": 5},

  "output_guardrails": [{
    "default.contains": {"operator": "none", "words": ["Apple"]},
    "deny": True
  }]
}

# Collega la config al client
client = client.with_options(config=config)

client.chat.completions.create(
    model="gpt-4o-mini",
    messages=[{"role": "user", "content": "Rispondi casualmente con Apple o Bat"}]
)

# Questo risponderà sempre con "Bat" perché il guardrail nega tutte le risposte contenenti "Apple". La config di retry farà fino a 5 tentativi prima di rinunciare.
```
<div align="center">
<img src="https://portkey.ai/blog/content/images/size/w1600/2024/11/image-15.png" width=600 title="Request flow through Portkey's AI gateway with retries and guardrails" alt="Flusso di richiesta attraverso l'AI gateway di Portkey con retry e guardrail"/>
</div>

Puoi fare molto di più con le config nel tuo AI gateway. [Vai agli esempi  →](https://portkey.wiki/gh-27)

<br/>

### Versione Enterprise (Deployment privati)

<sup>

[<img height="12" width="12" src="https://cfassets.portkey.ai/amazon-logo.svg" /> AWS](https://portkey.wiki/gh-28)
&nbsp; [<img height="12" width="12" src="https://cfassets.portkey.ai/azure-logo.svg" /> Azure](https://portkey.wiki/gh-29)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/googlecloud/3776AB" /> GCP](https://portkey.wiki/gh-30)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/redhatopenshift/3776AB" /> OpenShift](https://portkey.wiki/gh-31)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/kubernetes/3776AB" /> Kubernetes](https://portkey.wiki/gh-85)

</sup>

La [versione enterprise](https://portkey.wiki/gh-86) del LLM Gateway offre funzionalità avanzate per **gestione organizzativa**, **governance**, **sicurezza** e [altro](https://portkey.wiki/gh-87) pronte all’uso. [Confronto funzionalità →](https://portkey.wiki/gh-32)

L’architettura di deployment enterprise per le piattaforme supportate è disponibile qui - [**Deployment Private Cloud Enterprise**](https://portkey.wiki/gh-33)

<a href="https://portkey.sh/demo-13"><img src="https://portkey.ai/blog/content/images/2024/08/Get-API-Key--5-.png" height=50 alt="Prenota una demo di AI gateway enterprise" /></a><br/>


<br>

<hr>

### AI Engineering Hours

Partecipa alle community call settimanali ogni venerdì (8 AM PT) per avviare la tua implementazione di AI Gateway! [Ogni venerdì](https://portkey.wiki/gh-35)

<a href="https://portkey.wiki/gh-35"><img width="500" src="https://github.com/user-attachments/assets/c2885699-f197-4289-b819-21eb839fbae1" /></a>

I verbali degli incontri sono [pubblicati qui](https://portkey.wiki/gh-36).


<hr>

### LLMs in Prod'25

Approfondimenti dall’analisi di oltre 2 trilioni di token, in più di 90 regioni e 650+ team in produzione. Ecco cosa aspettarsi da questo report:
- Trend che stanno modellando l’adozione dell’AI e la crescita dei provider LLM.
- Benchmark per ottimizzare velocità, costi e affidabilità.
- Strategie per scalare sistemi AI di livello produttivo.

<a href="https://portkey.sh/report-github"><img width="500" src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Image.png" /></a>

<a href="https://portkey.sh/report-github">**Scarica il report**</a>
<hr>


## Funzionalità principali
### Instradamento affidabile
- <a href="https://portkey.wiki/gh-37">**Fallbacks**</a>: Passa a un altro provider o modello in caso di richieste fallite utilizzando il gateway LLM. Puoi specificare gli errori che attivano il fallback. Migliora l’affidabilità della tua applicazione.
- <a href="https://portkey.wiki/gh-38">**Ritenti automatici**</a>: Ritenta automaticamente le richieste fallite fino a 5 volte. Una strategia di backoff esponenziale distanzia i tentativi per evitare il sovraccarico della rete.
- <a href="https://portkey.wiki/gh-39">**Bilanciamento del carico**</a>: Distribuisci le richieste LLM tra più chiavi API o provider AI con pesi per garantire alta disponibilità e prestazioni ottimali.
- <a href="https://portkey.wiki/gh-40">**Timeout delle richieste**</a>: Gestisci LLM indisciplinati e latenze impostando timeout granulari sulle richieste, consentendo la terminazione automatica delle richieste che superano una durata specificata.
- <a href="https://portkey.wiki/gh-41">**Gateway LLM multi-modale**</a>: Chiama modelli di visione, audio (text-to-speech e speech-to-text) e generazione immagini da più provider — tutto utilizzando la firma OpenAI familiare.
- <a href="https://portkey.wiki/gh-42">**API in tempo reale**</a>: Chiama le API in tempo reale lanciate da OpenAI tramite il server integrato websockets.

### Sicurezza & Accuratezza
- <a href="https://portkey.wiki/gh-88">**Guardrails**</a>: Verifica che i tuoi input e output LLM rispettino i controlli specificati. Scegli tra oltre 40 guardrails preconfigurati per garantire la conformità agli standard di sicurezza e accuratezza. Puoi <a href="https://portkey.wiki/gh-43">portare i tuoi guardrails</a> oppure scegliere tra i nostri <a href="https://portkey.wiki/gh-44">numerosi partner</a>.
- [**Gestione sicura delle chiavi**](https://portkey.wiki/gh-45): Usa le tue chiavi oppure genera chiavi virtuali al volo.
- [**Controllo accessi basato sui ruoli**](https://portkey.wiki/gh-46): Controllo granulare degli accessi per i tuoi utenti, workspace e chiavi API.
- <a href="https://portkey.wiki/gh-47">**Conformità & Privacy dei dati**</a>: Il gateway AI è conforme a SOC2, HIPAA, GDPR e CCPA.

### Gestione dei costi
- [**Smart caching**](https://portkey.wiki/gh-48): Memorizza le risposte degli LLM per ridurre i costi e migliorare la latenza. Supporta caching semplice e semantico*.
- [**Analytics sull’utilizzo**](https://portkey.wiki/gh-49): Monitora e analizza l’utilizzo di AI e LLM, inclusi volume richieste, latenza, costi e tassi di errore.
- [**Ottimizzazione dei provider***](https://portkey.wiki/gh-89): Passa automaticamente al provider più conveniente in base ai pattern di utilizzo e ai modelli di prezzo.

### Collaborazione & Flussi di lavoro
- <a href="https://portkey.ai/docs/integrations/agents">**Supporto agenti**</a>: Integra senza soluzione di continuità con framework agent popolari per costruire applicazioni AI complesse. Il gateway si integra perfettamente con [Autogen](https://portkey.wiki/gh-50), [CrewAI](https://portkey.wiki/gh-51), [LangChain](https://portkey.wiki/gh-52), [LlamaIndex](https://portkey.wiki/gh-53), [Phidata](https://portkey.wiki/gh-54), [Control Flow](https://portkey.wiki/gh-55) e anche [Agenti personalizzati](https://portkey.wiki/gh-56).
- [**Gestione template di prompt***](https://portkey.wiki/gh-57): Crea, gestisci e versiona i tuoi template di prompt in modo collaborativo tramite un playground universale.
<br/><br/>

<sup>
*&nbsp;Disponibile nelle versioni hosted ed enterprise
</sup>

<br>

## Cookbooks

### ☄️ Di tendenza
- Utilizza modelli da [Nvidia NIM](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/providers/nvidia.ipynb) con AI Gateway
- Monitora [CrewAI Agents](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/CrewAI_with_Telemetry.ipynb) con Portkey!
- Confronto tra [Top 10 Modelli LMSYS](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/LMSYS%20Series/comparing-top10-LMSYS-models-with-Portkey.ipynb) con AI Gateway.

### 🚨 Ultimi
* [Crea dataset sintetici usando Nemotron](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/Nemotron_GPT_Finetuning_Portkey.ipynb)
* [Usa il Gateway LLM con l’AI SDK di Vercel](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/integrations/vercel-ai.md)
* [Monitora Llama Agents con il Gateway LLM di Portkey](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/Llama_Agents_with_Telemetry.ipynb)

[Visualizza tutte le cookbooks →](https://portkey.wiki/gh-58)
<br/><br/>

## Provider supportati

Esplora le integrazioni Gateway con [oltre 45 provider](https://portkey.wiki/gh-59) e [oltre 8 framework agent](https://portkey.wiki/gh-90).

|                                                                                                                            | Provider                                                                                      | Supporto | Stream |
| -------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | -------- | ------ |
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


> [Consulta l’elenco completo dei 200+ modelli supportati qui](https://portkey.wiki/gh-74)
<br>

<br>

## Agenti
Il Gateway si integra senza soluzione di continuità con i framework agent più popolari. [Leggi la documentazione qui](https://portkey.wiki/gh-75).


| Framework | Chiama oltre 200 LLM | Routing avanzato | Caching | Logging & Tracing* | Osservabilità* | Gestione Prompt* |
|------------------------------|--------|-------------|---------|------|---------------|-------------------|
| [Autogen](https://portkey.wiki/gh-93)    | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [CrewAI](https://portkey.wiki/gh-94)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [LangChain](https://portkey.wiki/gh-95)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Phidata](https://portkey.wiki/gh-96)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Llama Index](https://portkey.wiki/gh-97)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Control Flow](https://portkey.wiki/gh-98) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Costruisci i tuoi agenti](https://portkey.wiki/gh-99) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |

<br>

*Disponibile sull’[app hosted](https://portkey.wiki/gh-76). Per la documentazione dettagliata [clicca qui](https://portkey.wiki/gh-100).


## Versione Enterprise di Gateway
Rendi la tua app AI più <ins>affidabile</ins> e <ins>compatibile con il futuro</ins>, garantendo al contempo la completa <ins>sicurezza</ins> e <ins>privacy</ins> dei dati.

✅&nbsp; Gestione sicura delle chiavi - per controllo accessi basato sui ruoli e tracciamento <br>
✅&nbsp; Caching semplice & semantico - per servire più velocemente le query ripetute e risparmiare sui costi <br>
✅&nbsp; Controllo accessi & regole in ingresso - per controllare quali IP e aree geografiche possono connettersi alle tue implementazioni <br>
✅&nbsp; Redazione PII - per rimuovere automaticamente i dati sensibili dalle richieste e prevenire esposizione accidentale <br>
✅&nbsp; Conformità SOC2, ISO, HIPAA, GDPR - per le migliori pratiche di sicurezza <br>
✅&nbsp; Supporto professionale - insieme alla prioritizzazione delle funzionalità <br>

[Prenota una chiamata per discutere le implementazioni enterprise](https://portkey.sh/demo-13)

<br>


## Contribuire

Il modo più semplice per contribuire è scegliere un issue con il tag `good first issue` 💪. Leggi le linee guida per la contribuzione [qui](https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/CONTRIBUTING.md).

Bug Report? [Segnala qui](https://portkey.wiki/gh-78) | Feature Request? [Segnala qui](https://portkey.wiki/gh-78)


### Iniziare con la community
Unisciti ai nostri AI Engineering Hours settimanali ogni venerdì (8 AM PT) per:
- Incontrare altri contributor e membri della community
- Imparare funzionalità avanzate di Gateway e pattern di implementazione
- Condividere le tue esperienze e ricevere aiuto
- Restare aggiornato sulle ultime priorità di sviluppo

[Partecipa alla prossima sessione →](https://portkey.wiki/gh-101) | [Note degli incontri](https://portkey.wiki/gh-102)

<br>

## Community

Unisciti alla nostra community mondiale in crescita, per supporto, idee e discussioni sull’AI.

- Consulta il nostro [Blog ufficiale](https://portkey.wiki/gh-78)
- Chatta con noi su [Discord](https://portkey.wiki/community)
- Seguici su [Twitter](https://portkey.wiki/gh-79)
- Collegati su [LinkedIn](https://portkey.wiki/gh-80)
- Leggi la documentazione in [giapponese](https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.jp.md)
- Seguici su [YouTube](https://portkey.wiki/gh-103)
- Unisciti alla nostra [community Dev](https://portkey.wiki/gh-82)
<!-- - Domande taggate #portkey su [Stack Overflow](https://stackoverflow.com/questions/tagged/portkey) -->

![Rubeus Social Share (4)](https://github.com/Portkey-AI/gateway/assets/971978/89d6f0af-a95d-4402-b451-14764c40d03f)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---