![Immagine banner](https://user-images.githubusercontent.com/10284570/173569848-c624317f-42b1-45a6-ab09-f0ea3c247648.png)

# n8n - Automazione di Workflow Sicura per Team Tecnici

n8n è una piattaforma di automazione dei workflow che offre ai team tecnici la flessibilità del codice con la velocità del no-code. Con oltre 400 integrazioni, funzionalità AI native e una licenza fair-code, n8n ti consente di creare potenti automazioni mantenendo il pieno controllo sui tuoi dati e sulle tue implementazioni.

![n8n.io - Screenshot](https://raw.githubusercontent.com/n8n-io/n8n/master/assets/n8n-screenshot-readme.png)

## Funzionalità Principali

- **Codice Quando Serve**: Scrivi in JavaScript/Python, aggiungi pacchetti npm o usa l’interfaccia visiva
- **Piattaforma AI-Nativa**: Crea workflow di agenti AI basati su LangChain con i tuoi dati e modelli
- **Controllo Totale**: Self-host con la nostra licenza fair-code o utilizza la nostra [offerta cloud](https://app.n8n.cloud/login)
- **Pronto per le Aziende**: Permessi avanzati, SSO e implementazioni air-gapped
- **Comunità Attiva**: Oltre 400 integrazioni e più di 900 [template](https://n8n.io/workflows) pronti all’uso

## Avvio Rapido

Prova n8n immediatamente con [npx](https://docs.n8n.io/hosting/installation/npm/) (richiede [Node.js](https://nodejs.org/en/)):

```
npx n8n
```

Oppure distribuiscilo con [Docker](https://docs.n8n.io/hosting/installation/docker/):

```
docker volume create n8n_data
docker run -it --rm --name n8n -p 5678:5678 -v n8n_data:/home/node/.n8n docker.n8n.io/n8nio/n8n
```

Accedi all’editor su http://localhost:5678

## Risorse

- 📚 [Documentazione](https://docs.n8n.io)
- 🔧 [Oltre 400 Integrazioni](https://n8n.io/integrations)
- 💡 [Workflow di Esempio](https://n8n.io/workflows)
- 🤖 [Guida AI & LangChain](https://docs.n8n.io/langchain/)
- 👥 [Forum della Comunità](https://community.n8n.io)
- 📖 [Tutorial della Comunità](https://community.n8n.io/c/tutorials/28)

## Supporto

Hai bisogno di aiuto? Il nostro forum della comunità è il posto dove ottenere supporto e connetterti con altri utenti:
[community.n8n.io](https://community.n8n.io)

## Licenza

n8n è [fair-code](https://faircode.io) distribuito sotto la [Sustainable Use License](https://github.com/n8n-io/n8n/blob/master/LICENSE.md) e la [n8n Enterprise License](https://github.com/n8n-io/n8n/blob/master/LICENSE_EE.md).

- **Codice Sorgente Disponibile**: Codice sorgente sempre visibile
- **Self-Hostabile**: Distribuibile ovunque
- **Estensibile**: Aggiungi i tuoi nodi e funzionalità

[Licenze enterprise](mailto:license@n8n.io) disponibili per funzionalità aggiuntive e supporto.

Ulteriori informazioni sul modello di licenza sono disponibili nella [documentazione](https://docs.n8n.io/reference/license/).

## Contribuire

Hai trovato un bug 🐛 o hai un’idea per una funzionalità ✨? Consulta la nostra [Guida ai Contributi](https://github.com/n8n-io/n8n/blob/master/CONTRIBUTING.md) per iniziare.

## Unisciti al Team

Vuoi plasmare il futuro dell’automazione? Dai un’occhiata alle nostre [offerte di lavoro](https://n8n.io/careers) e unisciti al nostro team!

## Cosa significa n8n?

**Risposta breve:** Significa "nodemation" e si pronuncia n-eight-n.

**Risposta lunga:** "Mi viene fatta spesso questa domanda (più spesso di quanto mi aspettassi), quindi ho deciso che probabilmente è meglio rispondere qui. Cercando un buon nome per il progetto con un dominio libero, ho capito molto rapidamente che tutti quelli buoni a cui riuscivo a pensare erano già presi. Alla fine, ho scelto nodemation. 'node-' nel senso che utilizza una Node-View e che usa Node.js, e '-mation' da 'automation', che è ciò che il progetto dovrebbe aiutare a fare. Tuttavia, non mi piaceva quanto fosse lungo il nome e non riuscivo a immaginare di scrivere qualcosa di così lungo ogni volta nella CLI. Ed è così che sono arrivato a 'n8n'." - **Jan Oberhauser, Fondatore e CEO, n8n.io**

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---