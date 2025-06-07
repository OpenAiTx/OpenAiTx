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

**Open WebUI è una piattaforma AI self-hosted [estendibile](https://docs.openwebui.com/features/plugin/), ricca di funzionalità e facile da usare, progettata per funzionare completamente offline.** Supporta diversi motori LLM come **Ollama** e **API compatibili con OpenAI**, con un **motore di inferenza integrato** per RAG, rendendolo una **soluzione potente per il deployment di AI**.

![Open WebUI Demo](./demo.gif)

> [!TIP]  
> **Cerchi un [Enterprise Plan](https://docs.openwebui.com/enterprise)?** – **[Parla con il nostro team commerciale oggi stesso!](mailto:sales@openwebui.com)**
>
> Ottieni **funzionalità avanzate**, inclusi **personalizzazione del tema e del branding**, supporto **SLA (Service Level Agreement)**, versioni **LTS (Long-Term Support)** e **molto altro!**

Per ulteriori informazioni, consulta la nostra [Documentazione di Open WebUI](https://docs.openwebui.com/).

## Caratteristiche principali di Open WebUI ⭐

- 🚀 **Installazione Semplice**: Installa facilmente tramite Docker o Kubernetes (kubectl, kustomize o helm) per un'esperienza senza problemi, con supporto sia per immagini con tag `:ollama` che `:cuda`.

- 🤝 **Integrazione API Ollama/OpenAI**: Integra senza sforzo API compatibili con OpenAI per conversazioni versatili insieme ai modelli Ollama. Personalizza l’URL API OpenAI per collegarti a **LMStudio, GroqCloud, Mistral, OpenRouter e altri**.

- 🛡️ **Permessi Granulari e Gruppi Utenti**: Consentendo agli amministratori di creare ruoli e permessi utente dettagliati, garantiamo un ambiente sicuro. Questa granularità non solo aumenta la sicurezza ma consente anche esperienze utente personalizzate, promuovendo senso di proprietà e responsabilità tra gli utenti.

- 📱 **Design Responsivo**: Godi di un'esperienza senza interruzioni su PC Desktop, Laptop e dispositivi mobili.

- 📱 **Progressive Web App (PWA) per Mobile**: Vivi un’esperienza simile ad un’app nativa sul tuo dispositivo mobile con la nostra PWA, che offre accesso offline in locale e un'interfaccia utente fluida.

- ✒️🔢 **Supporto Completo a Markdown e LaTeX**: Migliora la tua esperienza LLM con capacità complete di Markdown e LaTeX per interazioni arricchite.

- 🎤📹 **Chiamata Vocale/Video Senza Mani**: Sperimenta comunicazioni fluide con funzioni integrate di chiamata vocale e video senza mani, per un ambiente chat più dinamico e interattivo.

- 🛠️ **Model Builder**: Crea facilmente modelli Ollama tramite la Web UI. Crea e aggiungi personaggi/agent personalizzati, personalizza elementi della chat e importa modelli senza sforzo tramite l’integrazione con la [Community Open WebUI](https://openwebui.com/).

- 🐍 **Strumento Nativo per Chiamata Funzioni Python**: Potenzia i tuoi LLM con supporto per editor di codice integrato nell’area strumenti. Porta le tue funzioni Python (BYOF) aggiungendo semplicemente le tue funzioni pure, per un'integrazione fluida con i LLM.

- 📚 **Integrazione RAG Locale**: Entra nel futuro delle interazioni in chat con il supporto innovativo a Retrieval Augmented Generation (RAG). Questa funzione integra senza soluzione di continuità l’interazione con i documenti nella chat. Puoi caricare documenti direttamente nella chat o aggiungere file alla tua libreria documenti, accedendovi facilmente tramite il comando `#` prima di una query.

- 🔍 **Ricerca Web per RAG**: Esegui ricerche web usando provider come `SearXNG`, `Google PSE`, `Brave Search`, `serpstack`, `serper`, `Serply`, `DuckDuckGo`, `TavilySearch`, `SearchApi` e `Bing` e inserisci i risultati direttamente nella tua chat.

- 🌐 **Funzionalità di Navigazione Web**: Integra facilmente siti web nella chat utilizzando il comando `#` seguito da un URL. Questa funzione consente di incorporare contenuti web direttamente nelle conversazioni, arricchendo la profondità delle interazioni.

- 🎨 **Integrazione Generazione Immagini**: Integra senza difficoltà la generazione di immagini usando opzioni come AUTOMATIC1111 API o ComfyUI (locale), e DALL-E di OpenAI (esterno), arricchendo le chat con contenuti visivi dinamici.

- ⚙️ **Conversazioni Multi-Modello**: Interagisci con vari modelli simultaneamente, sfruttando le loro peculiarità per risposte ottimali. Migliora l’esperienza utilizzando diversi modelli in parallelo.

- 🔐 **Controllo Accessi Basato sui Ruoli (RBAC)**: Garantisce accesso sicuro con permessi restrittivi; solo persone autorizzate possono accedere a Ollama, e la creazione/estrazione dei modelli è riservata agli amministratori.

- 🌐🌍 **Supporto Multilingua**: Vivi Open WebUI nella tua lingua preferita grazie al supporto internazionale (i18n). Aiutaci ad ampliare le lingue supportate! Cerchiamo attivamente contributori!

- 🧩 **Pipelines, Supporto Plugin Open WebUI**: Integra facilmente logica personalizzata e librerie Python in Open WebUI usando il [Pipelines Plugin Framework](https://github.com/open-webui/pipelines). Avvia la tua istanza Pipelines, imposta l’URL OpenAI su quello delle Pipelines ed esplora infinite possibilità. Gli [esempi](https://github.com/open-webui/pipelines/tree/main/examples) includono **Function Calling**, **Rate Limiting** per controllare l’accesso, **Monitoraggio Utilizzo** con strumenti come Langfuse, **Traduzione Live con LibreTranslate** per supporto multilingua, **Filtro Messaggi Tossici** e altro ancora.

- 🌟 **Aggiornamenti Continui**: Siamo impegnati a migliorare Open WebUI con aggiornamenti regolari, correzioni e nuove funzionalità.

Vuoi saperne di più sulle funzionalità di Open WebUI? Consulta la nostra [documentazione di Open WebUI](https://docs.openwebui.com/features) per una panoramica completa!

## Sponsor 🙌

#### Smeraldo

<table>
  <tr>
    <td>
      <a href="https://n8n.io/" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/n8n.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      N8N • La tua interfaccia ha già un backend?<br>Prova <a href="https://n8n.io/">n8n</a>
    </td>
  </tr>
  <tr>
    <td>
      <a href="https://warp.dev/open-webui" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/warp.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      <a href="https://warp.dev/open-webui">Warp</a> • Il terminale intelligente per sviluppatori
    </td>
  </tr>
</table>

---

Siamo estremamente grati per il generoso supporto dei nostri sponsor. I loro contributi ci aiutano a mantenere e migliorare il progetto, garantendo che possiamo continuare a offrire lavoro di qualità alla nostra community. Grazie!

## Come installare 🚀

### Installazione tramite Python pip 🐍

Open WebUI può essere installato utilizzando pip, il gestore pacchetti di Python. Prima di procedere, assicurati di utilizzare **Python 3.11** per evitare problemi di compatibilità.

1. **Installa Open WebUI**:
   Apri il terminale ed esegui il seguente comando per installare Open WebUI:

   ```bash
   pip install open-webui
   ```

2. **Esecuzione di Open WebUI**:
   Dopo l’installazione, puoi avviare Open WebUI eseguendo:

   ```bash
   open-webui serve
   ```

Questo avvierà il server Open WebUI, accessibile all’indirizzo [http://localhost:8080](http://localhost:8080)

### Avvio rapido con Docker 🐳

> [!NOTE]  
> Nota che in alcuni ambienti Docker potrebbero essere necessarie configurazioni aggiuntive. In caso di problemi di connessione, la nostra guida dettagliata sulla [Documentazione Open WebUI](https://docs.openwebui.com/) è pronta ad aiutarti.

> [!WARNING]
> Quando usi Docker per installare Open WebUI, assicurati di includere `-v open-webui:/app/backend/data` nel comando Docker. Questo passaggio è fondamentale per montare correttamente il database ed evitare la perdita di dati.

> [!TIP]  
> Se desideri utilizzare Open WebUI con Ollama incluso o accelerazione CUDA, ti consigliamo di usare le immagini ufficiali taggate `:cuda` o `:ollama`. Per abilitare CUDA, devi installare il [Nvidia CUDA container toolkit](https://docs.nvidia.com/dgx/nvidia-container-runtime-upgrade/) sul tuo sistema Linux/WSL.

### Installazione con configurazione predefinita

- **Se Ollama è sul tuo computer**, usa questo comando:

  ```bash
  docker run -d -p 3000:8080 --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **Se Ollama è su un altro server**, usa questo comando:

  Per collegarti a Ollama su un altro server, cambia `OLLAMA_BASE_URL` con l’URL del server:

  ```bash
  docker run -d -p 3000:8080 -e OLLAMA_BASE_URL=https://example.com -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **Per eseguire Open WebUI con supporto GPU Nvidia**, usa questo comando:

  ```bash
  docker run -d -p 3000:8080 --gpus all --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:cuda
  ```

### Installazione solo per uso API OpenAI

- **Se usi solo l’API OpenAI**, usa questo comando:

  ```bash
  docker run -d -p 3000:8080 -e OPENAI_API_KEY=your_secret_key -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

### Installazione di Open WebUI con supporto Ollama integrato

Questo metodo utilizza una singola immagine container che include Open WebUI con Ollama, permettendo una configurazione semplificata tramite un solo comando. Scegli il comando appropriato in base all’hardware:

- **Con supporto GPU**:
  Utilizza le risorse GPU eseguendo il comando:

  ```bash
  docker run -d -p 3000:8080 --gpus=all -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

- **Solo CPU**:
  Se non usi una GPU, usa invece questo comando:

  ```bash
  docker run -d -p 3000:8080 -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

Entrambi i comandi facilitano un'installazione integrata e senza problemi sia di Open WebUI che di Ollama, garantendo una rapida messa in funzione.

Dopo l’installazione, puoi accedere a Open WebUI all’indirizzo [http://localhost:3000](http://localhost:3000). Buon divertimento! 😄

### Altri metodi di installazione

Offriamo diverse alternative di installazione, incluse modalità native senza Docker, Docker Compose, Kustomize e Helm. Visita la nostra [Documentazione Open WebUI](https://docs.openwebui.com/getting-started/) o unisciti alla nostra [community Discord](https://discord.gg/5rJgQTnV4s) per guide complete.

### Risoluzione dei problemi

Hai problemi di connessione? La nostra [Documentazione Open WebUI](https://docs.openwebui.com/troubleshooting/) può aiutarti. Per ulteriore assistenza e per unirti alla nostra community, visita [Open WebUI Discord](https://discord.gg/5rJgQTnV4s).

#### Open WebUI: Errore di Connessione al Server

Se riscontri problemi di connessione, spesso è dovuto al fatto che il container docker WebUI non riesce a raggiungere il server Ollama su 127.0.0.1:11434 (host.docker.internal:11434) dall’interno del container. Usa il flag `--network=host` nel comando docker per risolvere. Nota che la porta cambia da 3000 a 8080, risultando nel link: `http://localhost:8080`.

**Esempio comando Docker**:

```bash
docker run -d --network=host -v open-webui:/app/backend/data -e OLLAMA_BASE_URL=http://127.0.0.1:11434 --name open-webui --restart always ghcr.io/open-webui/open-webui:main
```

### Aggiornare la tua installazione Docker

Se vuoi aggiornare l’installazione Docker locale all’ultima versione, puoi farlo con [Watchtower](https://containrrr.dev/watchtower/):

```bash
docker run --rm --volume /var/run/docker.sock:/var/run/docker.sock containrrr/watchtower --run-once open-webui
```

Nell’ultima parte del comando, sostituisci `open-webui` con il nome del tuo container se è diverso.

Consulta la nostra guida all’aggiornamento disponibile nella [Documentazione Open WebUI](https://docs.openwebui.com/getting-started/updating).

### Utilizzo della Dev Branch 🌙

> [!WARNING]
> Il ramo `:dev` contiene le ultime funzionalità instabili e modifiche. Usalo a tuo rischio poiché potrebbe avere bug o funzionalità incomplete.

Se vuoi provare le ultime funzionalità all’avanguardia e accetti un po’ di instabilità, puoi usare il tag `:dev` così:

```bash
docker run -d -p 3000:8080 -v open-webui:/app/backend/data --name open-webui --add-host=host.docker.internal:host-gateway --restart always ghcr.io/open-webui/open-webui:dev
```

### Modalità Offline

Se esegui Open WebUI in un ambiente offline, puoi impostare la variabile d’ambiente `HF_HUB_OFFLINE` a `1` per impedire tentativi di scaricare modelli da Internet.

```bash
export HF_HUB_OFFLINE=1
```

## Cosa succede ora? 🌟

Scopri le funzionalità in arrivo sulla nostra roadmap nella [Documentazione Open WebUI](https://docs.openwebui.com/roadmap/).

## Licenza 📜

Questo progetto è concesso sotto la [Licenza Open WebUI](LICENSE), una licenza BSD-3-Clause rivista. Hai tutti gli stessi diritti della classica BSD-3: puoi usare, modificare e distribuire il software, anche in prodotti proprietari e commerciali, con restrizioni minime. L’unico requisito aggiuntivo è preservare il branding "Open WebUI", come dettagliato nel file LICENSE. Per i termini completi, vedi il documento [LICENSE](LICENSE). 📄

## Supporto 💬

Se hai domande, suggerimenti o hai bisogno di assistenza, apri una issue o unisciti alla nostra
[community Discord di Open WebUI](https://discord.gg/5rJgQTnV4s) per entrare in contatto con noi! 🤝

## Storico delle Stelle

<a href="https://star-history.com/#open-webui/open-webui&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
  </picture>
</a>

---

Creato da [Timothy Jaeryang Baek](https://github.com/tjbck) - Rendiamo Open WebUI ancora più straordinario, insieme! 💪

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---