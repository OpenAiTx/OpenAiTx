![cover-v5-optimized](./images/GitHub_README_if.png)

<p align="center">
  📌 <a href="https://dify.ai/blog/introducing-dify-workflow-file-upload-a-demo-on-ai-podcast">Introduzione al caricamento file nei workflow di Dify: Ricrea il podcast Google NotebookLM</a>
</p>

<p align="center">
  <a href="https://cloud.dify.ai">Dify Cloud</a> ·
  <a href="https://docs.dify.ai/getting-started/install-self-hosted">Self-hosting</a> ·
  <a href="https://docs.dify.ai">Documentazione</a> ·
  <a href="https://dify.ai/pricing">Panoramica edizioni Dify</a>
</p>

<p align="center">
    <a href="https://dify.ai" target="_blank">
        <img alt="Static Badge" src="https://img.shields.io/badge/Product-F04438"></a>
    <a href="https://dify.ai/pricing" target="_blank">
        <img alt="Static Badge" src="https://img.shields.io/badge/free-pricing?logo=free&color=%20%23155EEF&label=pricing&labelColor=%20%23528bff"></a>
    <a href="https://discord.gg/FngNHpbcY7" target="_blank">
        <img src="https://img.shields.io/discord/1082486657678311454?logo=discord&labelColor=%20%235462eb&logoColor=%20%23f5f5f5&color=%20%235462eb"
            alt="chatta su Discord"></a>
    <a href="https://reddit.com/r/difyai" target="_blank">  
        <img src="https://img.shields.io/reddit/subreddit-subscribers/difyai?style=plastic&logo=reddit&label=r%2Fdifyai&labelColor=white"
            alt="unisciti a Reddit"></a>
    <a href="https://twitter.com/intent/follow?screen_name=dify_ai" target="_blank">
        <img src="https://img.shields.io/twitter/follow/dify_ai?logo=X&color=%20%23f5f5f5"
            alt="segui su X(Twitter)"></a>
    <a href="https://www.linkedin.com/company/langgenius/" target="_blank">
        <img src="https://custom-icon-badges.demolab.com/badge/LinkedIn-0A66C2?logo=linkedin-white&logoColor=fff"
            alt="segui su LinkedIn"></a>
    <a href="https://hub.docker.com/u/langgenius" target="_blank">
        <img alt="Docker Pulls" src="https://img.shields.io/docker/pulls/langgenius/dify-web?labelColor=%20%23FDB062&color=%20%23f79009"></a>
    <a href="https://github.com/langgenius/dify/graphs/commit-activity" target="_blank">
        <img alt="Commits ultimi 30 giorni" src="https://img.shields.io/github/commit-activity/m/langgenius/dify?labelColor=%20%2332b583&color=%20%2312b76a"></a>
    <a href="https://github.com/langgenius/dify/" target="_blank">
        <img alt="Issue chiusi" src="https://img.shields.io/github/issues-search?query=repo%3Alanggenius%2Fdify%20is%3Aclosed&label=issues%20closed&labelColor=%20%237d89b0&color=%20%235d6b98"></a>
    <a href="https://github.com/langgenius/dify/discussions/" target="_blank">
        <img alt="Post discussione" src="https://img.shields.io/github/discussions/langgenius/dify?labelColor=%20%239b8afb&color=%20%237a5af8"></a>
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

Dify è una piattaforma open-source per lo sviluppo di applicazioni con LLM. La sua interfaccia intuitiva combina workflow AI agentici, pipeline RAG, capacità agent, gestione dei modelli, funzioni di osservabilità e altro, permettendoti di passare rapidamente dal prototipo alla produzione.

## Avvio rapido

> Prima di installare Dify, assicurati che la tua macchina soddisfi i seguenti requisiti minimi di sistema:
>
> - CPU >= 2 Core
> - RAM >= 4 GiB

</br>

Il modo più semplice per avviare il server Dify è tramite [docker compose](docker/docker-compose.yaml). Prima di eseguire Dify con i comandi seguenti, assicurati che [Docker](https://docs.docker.com/get-docker/) e [Docker Compose](https://docs.docker.com/compose/install/) siano installati sulla tua macchina:

```bash
cd dify
cd docker
cp .env.example .env
docker compose up -d
```

Dopo l'esecuzione, puoi accedere alla dashboard Dify dal tuo browser all'indirizzo [http://localhost/install](http://localhost/install) e avviare il processo di inizializzazione.

#### Assistenza

Consulta le nostre [FAQ](https://docs.dify.ai/getting-started/install-self-hosted/faqs) se riscontri problemi nell'installazione di Dify. Contatta [la community e noi](#community--contact) se hai ancora problemi.

> Se vuoi contribuire a Dify o effettuare sviluppi aggiuntivi, consulta la nostra [guida alla distribuzione dal codice sorgente](https://docs.dify.ai/getting-started/install-self-hosted/local-source-code)

## Caratteristiche principali

**1. Workflow**:
Crea e testa potenti workflow AI su una canvas visuale, sfruttando tutte le funzioni seguenti e oltre.

**2. Supporto completo dei modelli**:
Integrazione senza soluzione di continuità con centinaia di LLM proprietari/open-source da decine di provider di inference e soluzioni self-hosted, coprendo GPT, Mistral, Llama3 e qualsiasi modello compatibile con OpenAI API. L'elenco completo dei provider supportati è disponibile [qui](https://docs.dify.ai/getting-started/readme/model-providers).

![providers-v5](https://github.com/langgenius/dify/assets/13230914/5a17bdbe-097a-4100-8363-40255b70f6e3)

**3. Prompt IDE**:
Interfaccia intuitiva per creare prompt, confrontare le prestazioni dei modelli e aggiungere funzionalità aggiuntive come text-to-speech ad app basate su chat.

**4. Pipeline RAG**:
Estese capacità RAG che coprono tutto, dall'ingestione documentale al recupero, con supporto out-of-the-box per l'estrazione di testo da PDF, PPT e altri formati di documenti comuni.

**5. Capacità agent**:
Puoi definire agenti basati su LLM Function Calling o ReAct e aggiungere strumenti predefiniti o personalizzati all’agente. Dify offre oltre 50 strumenti integrati per agenti AI, come Google Search, DALL·E, Stable Diffusion e WolframAlpha.

**6. LLMOps**:
Monitora e analizza i log e le prestazioni delle applicazioni nel tempo. Puoi migliorare continuamente prompt, dataset e modelli in base ai dati e alle annotazioni di produzione.

**7. Backend-as-a-Service**:
Tutte le offerte di Dify dispongono delle relative API, così puoi integrare facilmente Dify nella tua logica di business.

## Confronto delle funzionalità

<table style="width: 100%;">
  <tr>
    <th align="center">Funzionalità</th>
    <th align="center">Dify.AI</th>
    <th align="center">LangChain</th>
    <th align="center">Flowise</th>
    <th align="center">OpenAI Assistants API</th>
  </tr>
  <tr>
    <td align="center">Approccio di programmazione</td>
    <td align="center">API + Orientato all’app</td>
    <td align="center">Codice Python</td>
    <td align="center">Orientato all’app</td>
    <td align="center">Orientato alle API</td>
  </tr>
  <tr>
    <td align="center">LLM supportati</td>
    <td align="center">Ampia varietà</td>
    <td align="center">Ampia varietà</td>
    <td align="center">Ampia varietà</td>
    <td align="center">Solo OpenAI</td>
  </tr>
  <tr>
    <td align="center">Motore RAG</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">Agente</td>
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
    <td align="center">Osservabilità</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Funzionalità Enterprise (SSO/Controllo accessi)</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Distribuzione locale</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
</table>

## Utilizzo di Dify

- **Cloud </br>**
  Offriamo un servizio [Dify Cloud](https://dify.ai) a cui chiunque può accedere senza configurazione. Include tutte le funzionalità della versione self-hosted e 200 chiamate gratuite a GPT-4 nel piano sandbox.

- **Self-hosting Dify Community Edition</br>**
  Avvia rapidamente Dify nel tuo ambiente con questa [guida introduttiva](#quick-start).
  Usa la nostra [documentazione](https://docs.dify.ai) per riferimenti aggiuntivi e istruzioni più approfondite.

- **Dify per aziende/organizzazioni</br>**
  Offriamo funzionalità aggiuntive per aziende. [Lascia le tue domande tramite questo chatbot](https://udify.app/chat/22L1zSxg6yW1cWQg) oppure [inviaci una email](mailto:business@dify.ai?subject=[GitHub]Business%20License%20Inquiry) per discutere le tue esigenze aziendali. </br>
  > Per startup e piccole imprese che utilizzano AWS, consulta [Dify Premium su AWS Marketplace](https://aws.amazon.com/marketplace/pp/prodview-t22mebxzwjhu6) e distribuiscilo nel tuo AWS VPC con un solo click. È un’offerta AMI conveniente con la possibilità di creare app con logo e branding personalizzati.

## Rimani aggiornato

Metti una stella a Dify su GitHub per essere subito informato sulle nuove release.

![star-us](https://github.com/langgenius/dify/assets/13230914/b823edc1-6388-4e25-ad45-2f6b187adbb4)

## Configurazione avanzata

Se hai bisogno di personalizzare la configurazione, consulta i commenti nel nostro file [.env.example](docker/.env.example) e aggiorna i valori corrispondenti nel tuo file `.env`. Potresti inoltre dover apportare modifiche al file `docker-compose.yaml`, come cambiare versioni delle immagini, mapping delle porte o volumi, in base all’ambiente e alle esigenze specifiche. Dopo ogni modifica, esegui nuovamente `docker-compose up -d`. Puoi trovare l’elenco completo delle variabili di ambiente disponibili [qui](https://docs.dify.ai/getting-started/install-self-hosted/environments).

Se desideri configurare un setup ad alta disponibilità, sono disponibili [Helm Charts](https://helm.sh/) e file YAML realizzati dalla community che permettono di distribuire Dify su Kubernetes.

- [Helm Chart di @LeoQuote](https://github.com/douban/charts/tree/master/charts/dify)
- [Helm Chart di @BorisPolonsky](https://github.com/BorisPolonsky/dify-helm)
- [Helm Chart di @magicsong](https://github.com/magicsong/ai-charts)
- [File YAML di @Winson-030](https://github.com/Winson-030/dify-kubernetes)
- [File YAML di @wyy-holding](https://github.com/wyy-holding/dify-k8s)

#### Utilizzo di Terraform per il deployment

Distribuisci Dify su Cloud Platform con un solo click usando [terraform](https://www.terraform.io/)

##### Azure Global

- [Azure Terraform di @nikawang](https://github.com/nikawang/dify-azure-terraform)

##### Google Cloud

- [Google Cloud Terraform di @sotazum](https://github.com/DeNA/dify-google-cloud-terraform)

#### Utilizzo di AWS CDK per il deployment

Distribuisci Dify su AWS con [CDK](https://aws.amazon.com/cdk/)

##### AWS

- [AWS CDK di @KevinZhao](https://github.com/aws-samples/solution-for-deploying-dify-on-aws)

## Contribuire

Se desideri contribuire con codice, consulta la nostra [Guida al contributo](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md).
Nel frattempo, considera di supportare Dify condividendolo sui social media e durante eventi e conferenze.

> Cerchiamo contributori per tradurre Dify in lingue diverse dal mandarino e dall’inglese. Se sei interessato, consulta il [README i18n](https://github.com/langgenius/dify/blob/main/web/i18n/README.md) per maggiori informazioni e lasciaci un commento nel canale `global-users` del nostro [Discord Community Server](https://discord.gg/8Tpq4AcN9c).

## Community & contatti

- [Discussione GitHub](https://github.com/langgenius/dify/discussions). Ideale per: feedback e domande.
- [Issue GitHub](https://github.com/langgenius/dify/issues). Ideale per: bug riscontrati durante l’utilizzo di Dify.AI e proposte di funzionalità. Consulta la nostra [Guida al contributo](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md).
- [Discord](https://discord.gg/FngNHpbcY7). Ideale per: condividere le tue applicazioni e partecipare alla community.
- [X(Twitter)](https://twitter.com/dify_ai). Ideale per: condividere le tue applicazioni e partecipare alla community.

**Contributori**

<a href="https://github.com/langgenius/dify/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=langgenius/dify" />
</a>

## Cronologia delle stelle

[![Star History Chart](https://api.star-history.com/svg?repos=langgenius/dify&type=Date)](https://star-history.com/#langgenius/dify&Date)

## Segnalazione di sicurezza

Per proteggere la tua privacy, evita di pubblicare problemi di sicurezza su GitHub. Invece, invia le tue domande a security@dify.ai e ti forniremo una risposta più dettagliata.

## Licenza

Questo repository è disponibile sotto la [Dify Open Source License](LICENSE), essenzialmente una Apache 2.0 con alcune restrizioni aggiuntive.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---