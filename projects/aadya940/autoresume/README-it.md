<p align="center">
  <img src="https://raw.githubusercontent.com/aadya940/autoresume/main/main_app/frontend/public/autoresume-logo.png" alt="autoResume Logo" title="autoResume Logo" width="180"/>
</p>

<h1 align="center">autoResume</h1>

<p align="center">
  <b>Generatore di curriculum open source: incolla i tuoi link, modifica manualmente e lascia che l’IA ti aiuti a rifinire, aggiornare e personalizzare il tuo curriculum.</b>
</p>

---

### Come si usa?

[Link al Blog su Medium](https://medium.com/@aadyachinubhai/autoresume-copy-and-paste-links-its-that-simple-8e50e6d155a1)

Il blog è obsoleto rispetto all’interfaccia utente e al template utilizzato.

## Caratteristiche

- <b>Importazione Link Facile:</b> Incolla link da siti web e crea rapidamente un curriculum PDF.
- <b>Editor Manuale Incluso:</b> Affina o crea il tuo curriculum da zero con un editor di codice integrato.
- <b>Suggerimenti Intelligenti:</b> Condividi feedback o nuovi link, e le modifiche intelligenti aiuteranno a perfezionare e aggiornare il tuo curriculum.
- <b>Personalizzato per il Lavoro:</b> Incolla una descrizione del lavoro e ricevi raccomandazioni per allineare il tuo curriculum.
- <b>Qualità LaTeX:</b> Tutti i curriculum sono generati tramite LaTeX per un layout pulito e professionale.
- <b>Anteprima Istantanea:</b> Visualizza il tuo curriculum come PDF in tempo reale.
- <b>Ripristino Facile:</b> Cancella e ricomincia il tuo curriculum con un clic.
- <b>Locale:</b> Funziona completamente sulla tua macchina tramite Docker.

---

## Per iniziare

### Prerequisiti
- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/)

### Configurazione

1. Clona il repository:
   ```bash
   git clone https://github.com/aadya940/autoresume.git
   cd autoresume
   ```
2. Costruisci e avvia l'app:
   ```bash
   docker compose up --build
   ```
3. Accedi alle applicazioni:
   
   [_http://localhost:5173_](http://localhost:5173)
---

## Utilizzo

1. Apri autoResume nel tuo browser.
2. Clicca sull’icona :gear:, incolla la tua [GOOGLE API KEY](https://aistudio.google.com/) e la tua Email.
3. Incolla i link alle tue informazioni professionali (es. Github, sito personale, ecc.).
4. Facoltativamente, aggiungi feedback o un link a un annuncio di lavoro per ulteriori personalizzazioni.
5. Clicca su <b>Genera Curriculum</b> e lascia che l’IA faccia il resto!

---

## Licenza

Questo progetto è rilasciato sotto Licenza Apache 2.0.

## Guida al Contributo

### Frontend
- Implementa i componenti React nella cartella `frontend/src/components/`
- Usiamo Chakra UI per implementare i componenti.
- Importa e utilizza i tuoi componenti in `frontend/src/App.jsx`

### Backend
- Implementa le rotte API nella directory `backend/src/routes/`
- Aggiungi funzionalità IA nella directory `backend/src/ai/`
- Usiamo il formattatore di codice `black` per il codice Python
- Mantieni i gestori delle rotte puliti e la logica separata

### Linee Guida Generali
- Crea un nuovo branch per la tua funzione/correzione: `git checkout -b nome-del-tuo-branch`
- Scrivi messaggi di commit chiari
- Testa le tue modifiche prima di inviare una PR

### Invio delle Modifiche
1. Crea una Pull Request
2. Nella descrizione della tua PR includi:
   - Le modifiche apportate
   - La motivazione delle modifiche
   - Eventuali screenshot o risultati dei test rilevanti
   - Eventuali modifiche breaking o passaggi di migrazione necessari

Apprezziamo i tuoi contributi e revisioneremo la tua PR il prima possibile!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---