# SparkyFitness - Alternativa self-hosted a MyFitnessPal

SparkyFitness è un'applicazione completa per il monitoraggio e la gestione del fitness, progettata per aiutare gli utenti a tenere traccia della nutrizione, dell'esercizio fisico e delle misurazioni corporee. Fornisce strumenti per il monitoraggio giornaliero dei progressi, la definizione degli obiettivi e report approfonditi per supportare uno stile di vita sano.


## ✨ Funzionalità

### 🍎 Monitoraggio della Nutrizione

* **Registra i tuoi pasti giornalieri**
* **Crea e gestisci alimenti e categorie personalizzati**
* **Visualizza riepiloghi e analizza le tendenze con grafici interattivi**

### 💪 Registrazione dell’Esercizio

* **Registra i tuoi allenamenti**
* **Sfoglia e cerca in un database completo di esercizi**
* **Tieni traccia dei progressi nel tempo**

### 💧 Monitoraggio dell’Assunzione di Acqua

* **Monitora i tuoi obiettivi di idratazione giornaliera**
* **Registrazione dell’acqua semplice e veloce**

### 📏 Misurazioni Corporee

* **Registra le metriche corporee** (es. peso, vita, braccia)
* **Aggiungi tipi di misurazione personalizzati**
* **Visualizza i progressi tramite grafici**

### 🎯 Definizione degli Obiettivi

* **Imposta e gestisci obiettivi di fitness e nutrizione**
* **Monitora i progressi nel tempo**

### 🗓️ Check-In Giornalieri

* **Monitora l’attività quotidiana**
* **Mantieni la costanza con il monitoraggio delle abitudini**

### 🤖 Coach Nutrizionale AI (SparkyAI)

* **Registra cibo, esercizio, dati corporei e passi tramite chat**
* **Carica immagini degli alimenti per registrare i pasti automaticamente**
* **Include cronologia chat e consigli personalizzati**

### 🔒 Autenticazione Utente & Profili

* **Sistema di login sicuro**
* **Passa da un profilo utente all’altro**
* **Supporto per accesso e gestione familiare**

### 📊 Report Completi

* **Genera riepiloghi per nutrizione e metriche corporee**
* **Monitora le tendenze a lungo termine su settimane o mesi**

### 🎨 Temi Personalizzabili

* **Passa dalla modalità chiara a quella scura**
* **Progettato con un’interfaccia minimale e priva di distrazioni**

### Hai bisogno di aiuto?
* **Unisciti al discord**
  https://discord.gg/vcnMT5cPEA
* **Partecipa alla discussione**


![image](https://github.com/user-attachments/assets/ccc7f34e-a663-405f-a4d4-a9888c3197bc)


## 🚀 Per Iniziare

Per far funzionare l'applicazione SparkyFitness sulla tua macchina locale, segui questi passaggi:

### Prerequisiti

*   **Progetto Supabase**: Avrai bisogno di un progetto Supabase configurato.
    *   **Crea un nuovo progetto su Supabase**: Vai su [Supabase](https://app.supabase.com/) e crea un nuovo progetto. (Puoi anche provare a configurare un progetto Supabase locale se preferisci.)
    *   Ottieni l’URL del tuo Progetto Supabase e la Anon Key dalle impostazioni del progetto (sezione API).
    *   **Nota importante sull'autenticazione Supabase:** Aggiorna la configurazione dell'URL nelle impostazioni di Autenticazione Supabase per farla corrispondere al tuo dominio. Questo è fondamentale affinché il tuo dominio funzioni e per ricevere gli inviti tramite email per la registrazione. Supabase offre funzionalità di sicurezza avanzate e opzioni di SSO di terze parti; configuralo secondo le esigenze del tuo progetto.
    *   Il deployment automatico del DB su Supabase non funziona con IPV4 se hai la versione gratuita di Supabase. Quindi, devi configurare la tua rete per usare la connessione IPV6. Altrimenti la migrazione del DB fallirà e dovrai effettuare il deployment manualmente.       


    

### Installazione

1.  **Configura le Variabili d’Ambiente:**
    Crea un file `.env` nella cartella privata. Se utilizzi Portainer, crealo direttamente lì.
    Aggiungi le credenziali di Supabase:
    ```
    VITE_SUPABASE_URL="YOUR_SUPABASE_PROJECT_URL"
    VITE_SUPABASE_ANON_KEY="YOUR_SUPABASE_ANON_KEY"
    SUPABASE_PROJECT_REF="YOUR_SUPABASE_PROJECT_REF"    
    ```

2.  **Esegui con Docker Compose:**
    Scarica le immagini Docker e avvia i servizi:
    ```sh
    docker compose pull
    docker compose up -d
    ```

3.  **Accedi all'Applicazione:**
    Una volta che i servizi sono attivi e funzionanti, accedi a SparkyFitness nel tuo browser web all'indirizzo:
    ```
    http://localhost:3000
    ```

4.  **Chatbot AI - Configurazione Opzionale:**
    Per abilitare la piena funzionalità del Chatbot AI, inclusa l'archiviazione sicura delle chiavi API e l'accesso al database, segui questi passaggi:

    *   **Configura `AI_API_ENCRYPTION_KEY`:** Genera un segreto in "Supabase -> Edge Functions" -> "Environment Variables". Questa chiave viene utilizzata per criptare le tue chiavi AI quando vengono memorizzate all'interno di Supabase.

    *   **Genera `SUPABASE_ACCESS_TOKEN`:**
        1.  Accedi alla tua console Docker.
        2.  Esegui `supabase login` e autenticati utilizzando l'URL fornito.
        3.  Recupera il token di accesso eseguendo `cat ~/.supabase/access-token`.
        4.  Aggiorna il tuo file `docker-compose.yml` o la configurazione di Portainer con questo token per effettuare il redeploy.
        5.  Dopo il redeploy, accedi a SparkyFitness e configura il servizio AI con il provider che preferisci.
     

### Deploy Manuale di DB & Funzioni su Supabase
**Metodo 1:  
**Se non hai la connessione di rete IPV6 abilitata, la migrazione del DB fallirà poiché la versione gratuita di Supabase non supporta la connessione diretta IPV4.

   1. Scarica l'ultima release e decomprimila sul tuo PC.
   2. Vai nella cartella del progetto. Docker deve essere avviato e funzionante.
   3. Esegui i seguenti comandi. (il deploy delle functions è necessario solo per la configurazione AI. Se non ti serve il ChatBOT, puoi saltare questo passaggio)
``
      supabase login  
      supabase link  
      supabase db push  
      supabase functions deploy chat   
``
Riesegui Docker compose. L'app Front end inizierà a funzionare.

**Metodo 2:  
   1. Scarica l'ultima release e decomprimila sul tuo PC.  
   2. Vai nella cartella del progetto.  
   3. Vai su supabase/migrations. Copia le istruzioni SQL ed eseguile in Supabase-->Project-->SQL Editor una alla volta in ordine ASC.  
   4. [Opzionale] Fai lo stesso per supabase/functions/chat se hai bisogno del ChatBOT AI. Copia index.js ed eseguilo in Supabase-->Project-->Edge Function-->Deploy new function.  

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---