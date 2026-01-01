
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=it">Italiano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# SparkyFitness - Alternativa self-hosted a MyFitnessPal

SparkyFitness è un'applicazione completa per il monitoraggio e la gestione della forma fisica, progettata per aiutare gli utenti a tenere traccia della nutrizione, dell'esercizio fisico e delle misurazioni corporee. Offre strumenti per il monitoraggio quotidiano dei progressi, la definizione degli obiettivi e report dettagliati per supportare uno stile di vita sano.

Documentazione: https://codewithcj.github.io/SparkyFitness

## ✨ Caratteristiche

### 🍎 Monitoraggio della Nutrizione

* **Registra i tuoi pasti quotidiani**
* **Crea e gestisci alimenti e categorie personalizzate**
* **Visualizza riepiloghi e analizza le tendenze con grafici interattivi**

### 💪 Registrazione degli Esercizi

* **Registra i tuoi allenamenti**
* **Sfoglia e cerca in un database completo di esercizi**
* **Monitora i progressi nel fitness nel tempo**

### 💧 Monitoraggio dell’Assunzione d’Acqua

* **Tieni traccia degli obiettivi di idratazione giornaliera**
* **Registrazione dell’acqua semplice e veloce**

### 📏 Misurazioni Corporee

* **Registra le metriche corporee** (es. peso, vita, braccia)
* **Aggiungi tipi di misurazione personalizzati**
* **Visualizza i progressi tramite grafici**

### 🎯 Impostazione degli Obiettivi

* **Imposta e gestisci obiettivi di fitness e nutrizione**
* **Monitora i progressi nel tempo**

### 🗓️ Check-In Quotidiani

* **Monitora l’attività giornaliera**
* **Rimani costante con il tracciamento delle abitudini**

### 🤖 Coach Nutrizionale AI (SparkyAI)

* **Registra cibo, esercizio, statistiche corporee e passi tramite chat**
* **Carica immagini di cibo per registrare automaticamente i pasti**
* **Include cronologia chat e guida personalizzata**

### 🔒 Autenticazione Utente & Profili

* **Sistema di login sicuro**
* **Passa tra i profili utente**
* **Supporto per accesso e gestione familiare**

### 📊 Report completi

* **Genera riepiloghi per nutrizione e metriche corporee**
* **Monitora le tendenze a lungo termine su settimane o mesi**

### 🎨 Temi personalizzabili

* **Passa tra modalità chiara e scura**
* **Progettato con un'interfaccia minimale e senza distrazioni**

### Hai bisogno di aiuto?
* **Unisciti a Discord**
  https://discord.gg/vcnMT5cPEA
* **Pubblica una discussione**


![image](https://github.com/user-attachments/assets/ccc7f34e-a663-405f-a4d4-a9888c3197bc)

## � Avvio rapido

Avvia SparkyFitness in pochi minuti:

```bash
# 1. Create a new folder
mkdir sparkyfitness && cd sparkyfitness

# 2. Download Docker files only
curl -o docker-compose.yml https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docker/docker-compose.prod.yml
curl -o .env https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docker/.env.example

# 3. (Optional) Edit .env to customize your setup
# e.g., update database credentials, ports, etc.
# if you require Gamrin integration, uncomment Garmin section from compose file.

# 4. Start the app
docker compose pull && docker compose up -d

# Access application at http://localhost:8080
```

## 📖 Documentazione

Per guide complete all’installazione, configurazione per lo sviluppo e istruzioni d’uso, visita la nostra documentazione completa:

**👉 [Sito Documentazione SparkyFitness](https://codewithcj.github.io/SparkyFitness)**

### Collegamenti Rapidi

- **[🚀 Per Iniziare](https://codewithcj.github.io/SparkyFitness/developer/getting-started)** - Guida completa alla configurazione per sviluppo e produzione
- **[🐳 Guida Docker](https://codewithcj.github.io/SparkyFitness/developer/docker)** - Distribuzione e configurazione con Docker
- **[🔧 Workflow di Sviluppo](https://codewithcj.github.io/SparkyFitness/developer/workflow)** - Guida per sviluppatori e processo di contributo  
- **[📊 Panoramica delle Funzionalità](https://codewithcj.github.io/SparkyFitness/features/)** - Documentazione completa delle funzionalità
- **[🏗️ Architettura](https://codewithcj.github.io/SparkyFitness/app-overview)** - Architettura tecnica e design
- Consulta la WIiki per esempio di configurazione env e configurazione dell’App Mobile.


## Cronologia delle Stelle

<a href="https://star-history.com/#CodeWithCJ/SparkyFitness&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" />
    <img alt="Grafico Cronologia Stelle" src="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" width="100%" />
  </picture>
</a>

## Traduzioni

<a href="https://hosted.weblate.org/engage/sparkyfitness/">
<img src="https://hosted.weblate.org/widget/sparkyfitness/sparkyfitness-translations/multi-auto.svg" alt="Stato traduzioni" />
</a>

## Attività del repository

![Alt](https://repobeats.axiom.co/api/embed/828203d3070ff56c8873c727b6873b684c4ed399.svg "Immagine analisi Repobeats")


## Contributori

<a href="https://github.com/CodeWithCJ/SparkyFitness/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CodeWithCJ/SparkyFitness" width="100%"/>
</a>

### ⚠️ Problemi Conosciuti / Funzionalità Beta ⚠️

Le seguenti funzionalità sono attualmente in beta e potrebbero non essere state testate approfonditamente. Aspettati potenziali bug o funzionalità incomplete:

*   Chatbot AI
*   Supporto multi-utente
*   Accesso Famiglia & Amici
*   Integrazione Dati Apple Health

Questa applicazione è soggetta a forte sviluppo. Alcune cose potrebbero non funzionare come previsto a causa della migrazione da Supabase a PostgreSQL. POTREBBERO ESSERE INTRODOTTI CAMBIAMENTI IMPORTANTI finché l’applicazione non sarà stabile.
Potresti dover modificare le variabili Docker/ambiente per le nuove release. Pertanto, gli aggiornamenti automatici tramite Watchtower o app simili non sono raccomandati. Leggi le note di rilascio per eventuali CAMBIAMENTI IMPORTANTI.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---