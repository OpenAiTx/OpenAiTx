<a name="readme-top"></a>
<h1 align="center">
    <img src="https://img.alicdn.com/imgextra/i2/O1CN01NwxLDd20nxfGBjxmZ_!!6000000006895-2-tps-960-290.png" alt="Higress" width="240" height="72.5">
  <br>
  AI Gateway
</h1>
<h4 align="center"> Gateway API nativo per l’IA </h4>

<div align="center">
    
[![Build Status](https://github.com/alibaba/higress/actions/workflows/build-and-test.yaml/badge.svg?branch=main)](https://github.com/alibaba/higress/actions)
[![license](https://img.shields.io/github/license/alibaba/higress.svg)](https://www.apache.org/licenses/LICENSE-2.0.html)
[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=flat-square)](https://discord.gg/tSbww9VDaM)

<a href="https://trendshift.io/repositories/10918" target="_blank"><img src="https://trendshift.io/api/badge/repositories/10918" alt="alibaba%2Fhigress | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a> <a href="https://www.producthunt.com/posts/higress?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-higress" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=951287&theme=light&t=1745492822283" alt="Higress - Global&#0032;APIs&#0032;as&#0032;MCP&#0032;powered&#0032;by&#0032;AI&#0032;Gateway | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

</div>

[**Sito Ufficiale**](https://higress.ai/en/) &nbsp; |
&nbsp; [**MCP Server QuickStart**](https://higress.cn/en/ai/mcp-quick-start/) &nbsp; |
&nbsp; [**Wasm Plugin Hub**](https://higress.cn/en/plugin/) &nbsp; |

<p>
   English | <a href="README_ZH.md">中文<a/> | <a href="README_JP.md">日本語<a/>
</p>

## Che cos'è Higress?

Higress è un gateway API cloud-native basato su Istio ed Envoy, estendibile tramite plugin Wasm scritti in Go/Rust/JS. Offre decine di plugin generici pronti all’uso e una console pronta all’uso (prova la [demo qui](http://demo.higress.io/)).

### Casi d'Uso Principali

Le funzionalità di gateway IA di Higress supportano tutti i [principali provider di modelli](https://raw.githubusercontent.com/alibaba/higress/main/plugins/wasm-go/extensions/ai-proxy/provider) sia nazionali che internazionali. Supporta inoltre l’hosting di server MCP (Model Context Protocol) tramite il suo meccanismo di plugin, permettendo agli agenti IA di chiamare facilmente vari strumenti e servizi. Con lo strumento [openapi-to-mcp](https://github.com/higress-group/openapi-to-mcpserver), puoi convertire rapidamente specifiche OpenAPI in server MCP remoti da ospitare. Higress fornisce una gestione unificata sia per API LLM che MCP. 

**🌟 Provalo ora su [https://mcp.higress.ai/](https://mcp.higress.ai/)** per sperimentare direttamente i server MCP remoti ospitati da Higress:

![Piattaforma Higress MCP Server](https://img.alicdn.com/imgextra/i2/O1CN01nmVa0a1aChgpyyWOX_!!6000000003294-0-tps-3430-1742.jpg)

### Adozione Aziendale

Higress è nato all’interno di Alibaba per risolvere i problemi di reload di Tengine che impattavano i servizi a connessione lunga e l’insufficienza delle capacità di bilanciamento del carico per gRPC/Dubbo. All’interno di Alibaba Cloud, le funzionalità di gateway IA di Higress supportano applicazioni IA core come lo studio di modelli Tongyi Bailian, la piattaforma di machine learning PAI e altri servizi IA critici. Alibaba Cloud ha costruito il proprio prodotto gateway API cloud-native su Higress, offrendo capacità di servizio gateway ad alta disponibilità (99,99%) a numerosi clienti aziendali.

## Sommario

- [**Guida Rapida**](#quick-start)    
- [**Dimostrazione Funzionalità**](#feature-showcase)
- [**Casi d'Uso**](#use-cases)
- [**Vantaggi Principali**](#core-advantages)
- [**Comunità**](#community)

## Guida Rapida

Higress può essere avviato con Docker, rendendo semplice per i singoli sviluppatori configurarlo localmente per apprendimento o per la creazione di siti semplici:

```bash
# Crea una directory di lavoro
mkdir higress; cd higress
# Avvia higress, i file di configurazione saranno scritti nella directory di lavoro
docker run -d --rm --name higress-ai -v ${PWD}:/data \
        -p 8001:8001 -p 8080:8080 -p 8443:8443  \
        higress-registry.cn-hangzhou.cr.aliyuncs.com/higress/all-in-one:latest
```

Descrizione delle porte:

- Porta 8001: Console UI di Higress
- Porta 8080: Ingresso protocollo HTTP del gateway
- Porta 8443: Ingresso protocollo HTTPS del gateway

> Tutte le immagini Docker di Higress utilizzano il repository immagini proprietario di Higress e non sono soggette ai limiti di frequenza di Docker Hub.
> Inoltre, la pubblicazione e l’aggiornamento delle immagini sono protetti da un meccanismo di scansione della sicurezza (fornito da Alibaba Cloud ACR), rendendole molto sicure anche in ambienti di produzione.
> 
> Se riscontri timeout durante il pull dell’immagine da `higress-registry.cn-hangzhou.cr.aliyuncs.com`, puoi provare a sostituirlo con il seguente mirror del registry docker:
> 
> **Sud-est asiatico**: `higress-registry.ap-southeast-7.cr.aliyuncs.com`

Per altri metodi di installazione come il deployment Helm su K8s, consulta la [documentazione ufficiale Quick Start](https://higress.io/en-us/docs/user/quickstart).

## Casi d'Uso

- **Hosting MCP Server**:

  Higress ospita server MCP tramite il suo meccanismo di plugin, permettendo agli agenti IA di chiamare facilmente vari strumenti e servizi. Con lo strumento [openapi-to-mcp](https://github.com/higress-group/openapi-to-mcpserver), puoi convertire rapidamente specifiche OpenAPI in server MCP remoti.

  ![](https://img.alicdn.com/imgextra/i1/O1CN01wv8H4g1mS4MUzC1QC_!!6000000004952-2-tps-1764-597.png)

  Vantaggi chiave dell’hosting MCP Server con Higress:
  - Meccanismi unificati di autenticazione e autorizzazione
  - Rate limiting granulare per prevenire abusi
  - Log di audit completi per tutte le chiamate agli strumenti
  - Ricca osservabilità per monitorare le performance
  - Deployment semplificato tramite plugin di Higress
  - Aggiornamenti dinamici senza interruzione o perdita di connessione

     [Scopri di più...](https://higress.cn/en/ai/mcp-quick-start/?spm=36971b57.7beea2de.0.0.d85f20a94jsWGm)

- **AI Gateway**:

  Higress si collega a tutti i provider di modelli LLM tramite un protocollo unificato, offrendo osservabilità IA, bilanciamento del carico multi-modello, rate limiting a token e caching:

  ![](https://img.alicdn.com/imgextra/i2/O1CN01izmBNX1jbHT7lP3Yr_!!6000000004566-0-tps-1920-1080.jpg)

- **Kubernetes ingress controller**:

  Higress può funzionare come un controller ingress ricco di funzionalità, compatibile con molte annotazioni del controller nginx ingress di K8s.
  
  Il supporto per [Gateway API](https://gateway-api.sigs.k8s.io/) è in arrivo e supporterà la migrazione fluida da Ingress API a Gateway API.
  
- **Gateway microservizi**:

  Higress può funzionare come gateway per microservizi, scoprendo microservizi da vari registry come Nacos, ZooKeeper, Consul, Eureka, ecc.
  
  Si integra profondamente con [Dubbo](https://github.com/apache/dubbo), [Nacos](https://github.com/alibaba/nacos), [Sentinel](https://github.com/alibaba/Sentinel) e altri stack tecnologici per microservizi.
  
- **Gateway di sicurezza**:

  Higress può essere usato come gateway di sicurezza, supportando WAF e varie strategie di autenticazione, come key-auth, hmac-auth, jwt-auth, basic-auth, oidc, ecc.

## Vantaggi Principali

- **Grado di produzione**

  Nato dal prodotto interno Alibaba con oltre 2 anni di validazione in produzione, supporta scenari su larga scala con centinaia di migliaia di richieste al secondo.

  Elimina completamente i jitter di traffico causati da reload di Nginx, le modifiche di configurazione hanno effetto in millisecondi e sono trasparenti al business. Particolarmente adatto a scenari a connessione lunga come le attività IA.

- **Elaborazione streaming**

  Supporta la vera elaborazione streaming completa dei corpi request/response, i plugin Wasm possono personalizzare facilmente la gestione di protocolli streaming come SSE (Server-Sent Events).

  In scenari ad alta larghezza di banda come le attività IA, può ridurre significativamente il consumo di memoria.
    
- **Facile da estendere**
  
  Offre una ricca libreria di plugin ufficiali che coprono IA, gestione traffico, protezione di sicurezza e altre funzionalità comuni, soddisfacendo oltre il 90% delle esigenze di scenario aziendale.

  Si concentra sull’estensione tramite plugin Wasm, garantendo la sicurezza della memoria tramite isolamento sandbox, supportando più linguaggi di programmazione, permettendo l’aggiornamento indipendente delle versioni dei plugin e aggiornamenti hot senza perdita di traffico della logica gateway.

- **Sicuro e facile da usare**
  
  Basato sugli standard Ingress API e Gateway API, offre console UI pronta all’uso, plugin di protezione WAF, plugin di protezione IP/Cookie CC subito disponibili.

  Supporta la connessione a Let's Encrypt per emissione e rinnovo automatico di certificati gratuiti e può essere distribuito anche fuori da K8s, avviato con un solo comando Docker, conveniente per sviluppatori singoli.

## Comunità

Unisciti alla nostra comunità Discord! Qui puoi connetterti con sviluppatori e altri utenti entusiasti di Higress.

[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=for-the-badge)](https://discord.gg/tSbww9VDaM)


### Ringraziamenti

Higress non sarebbe possibile senza il prezioso lavoro open-source dei progetti della comunità. Un ringraziamento speciale a Envoy e Istio.

### Repository Correlati

- Higress Console: https://github.com/higress-group/higress-console
- Higress Standalone: https://github.com/higress-group/higress-standalone

### Contributori

<a href="https://github.com/alibaba/higress/graphs/contributors">
  <img alt="contributors" src="https://contrib.rocks/image?repo=alibaba/higress"/>
</a>

### Cronologia stelle

[![Star History Chart](https://api.star-history.com/svg?repos=alibaba/higress&type=Date)](https://star-history.com/#alibaba/higress&Date)

<p align="right" style="font-size: 14px; color: #555; margin-top: 20px;">
    <a href="#readme-top" style="text-decoration: none; color: #007bff; font-weight: bold;">
        ↑ Torna su ↑
    </a>
</p>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---