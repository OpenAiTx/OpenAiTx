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

# SparkyFitness

Un'alternativa self-hosted e privacy-first a MyFitnessPal. Tieni traccia di alimentazione, esercizio fisico, metriche corporee e dati sulla salute mantenendo il pieno controllo dei tuoi dati.

![Screenshot](https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docs/public/web_screenshot.png)

SparkyFitness è una piattaforma di monitoraggio fitness self-hosted composta da:

- Un server backend (API + archiviazione dati)
- Un frontend basato sul web
- App mobili nativi per iOS e Android

Memorizza e gestisce i dati sulla salute su un'infrastruttura che controlli tu, senza affidarsi a servizi di terze parti.

## Funzionalità principali

- Monitoraggio di alimentazione, esercizio, idratazione, sonno, digiuno, umore e misurazioni corporee
- Impostazione degli obiettivi e check-in giornalieri
- Grafici interattivi e report a lungo termine
- Profili multipli e accesso familiare
- Temi chiari e scuri
- OIDC, TOTP, Passkey, MFA ecc.

## Integrazioni Salute & Dispositivi

SparkyFitness può sincronizzare dati da molteplici piattaforme di salute e fitness:

- **Apple Salute** (iOS)
- **Google Health Connect** (Android)
- **Fitbit**
- **Garmin Connect**
- **Withings**
- **Polar Flow** (testato parzialmente)
- **Hevy** (non testato)
- **OpenFoodFacts**
- **USDA**
- **Fatsecret**
- **Nutritioninx**
- **Mealie**
- **Tandoor**
- **Strava** (testato parzialmente)

Le integrazioni sincronizzano automaticamente dati di attività come passi, allenamenti e sonno, insieme a metriche come peso e misure corporee, sul tuo server SparkyFitness.

## Funzionalità opzionali AI (Beta)

SparkyAI fornisce un'interfaccia conversazionale per registrare dati e rivedere i progressi.

- Registra alimenti, esercizi, dati corporei e passi tramite chat
- Carica immagini dei pasti per la registrazione automatica
- Conserva la cronologia delle conversazioni per i seguiti

Nota: le funzionalità AI sono attualmente in beta.

## Avvio rapido (Server)

Avvia un server SparkyFitness in pochi minuti utilizzando Docker Compose.

```bash
# 1. Create a new folder
mkdir sparkyfitness && cd sparkyfitness

# 2. Download Docker files only
curl -L -o docker-compose.yml https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/docker-compose.prod.yml
curl -L -o .env https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/default.env.example

# 3. (Optional) Edit .env to customize database credentials, ports, etc.

# 4. Start the app
docker compose pull && docker compose up -d

# Access application at http://localhost:8080
```

## 🎥 Video Tutorial

[![Guarda il video](https://img.youtube.com/vi/B13IiL2DeQc/maxresdefault.jpg)](https://www.youtube.com/watch?v=B13IiL2DeQc)

Breve tutorial di 2 minuti che mostra come installare SparkyFitness (fitness tracker self-hosted).


## Documentazione

Per guide complete all'installazione, opzioni di configurazione e documenti di sviluppo, visita il nostro [Sito di Documentazione](https://codewithcj.github.io/SparkyFitness/).

### Link Rapidi

- **[Guida all'Installazione](https://codewithcj.github.io/SparkyFitness/install/docker-compose)** - Deployment e configurazioni
- **[Panoramica delle Funzionalità](https://codewithcj.github.io/SparkyFitness/features)** - Documentazione completa delle funzionalità
- **[Flusso di Sviluppo](https://codewithcj.github.io/SparkyFitness/developer/getting-started)** - Guida per sviluppatori e processo di contributo
- **[Info App iOS](https://github.com/CodeWithCJ/SparkyFitness/wiki/Apple-Health-Integration)** e **[Info App Android](https://github.com/CodeWithCJ/SparkyFitness/wiki/Android-Mobile-App)**

### Hai bisogno di aiuto?

- Scrivi su Github issues/discussion.
- Per una risposta più rapida e per ricevere aiuto dalla comunità **[Unisciti al nostro Discord](https://discord.gg/vcnMT5cPEA)**

## Storico delle Stelle

<a href="https://star-history.com/#CodeWithCJ/SparkyFitness&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" />
    <img alt="Grafico Storico Stelle" src="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" width="100%" />
  </picture>
</a>

## Traduzioni

**[Traduzioni Weblate](https://hosted.weblate.org/engage/sparkyfitness)**

<a href="https://hosted.weblate.org/engage/sparkyfitness/">

<img src="https://hosted.weblate.org/widget/sparkyfitness/sparkyfitness-translations/multi-auto.svg" alt="Stato della traduzione" />
</a>

## Attività del repository

![Alt](https://repobeats.axiom.co/api/embed/828203d3070ff56c8873c727b6873b684c4ed399.svg "Immagine analitica Repobeats")

## Contributori

<a href="https://github.com/CodeWithCJ/SparkyFitness/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CodeWithCJ/SparkyFitness" width="100%"/>
</a>

## ⚠️ Problemi noti / Funzionalità Beta ⚠️

SparkyFitness è in fase di sviluppo attivo.
Cambiamenti incompatibili potrebbero verificarsi tra le release.

- L’aggiornamento automatico dei container non è raccomandato
- Rivedi sempre le note di rilascio prima di aggiornare

Le seguenti funzionalità sono attualmente in beta e potrebbero non essere state testate a fondo. Aspettati potenziali bug o funzionalità incomplete:

- Chatbot AI
- Accesso Famiglia & Amici
- Documentazione API


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---