# EmuReady

Una piattaforma guidata dalla comunità per tracciare la compatibilità dell’emulazione su diversi dispositivi ed emulatori.

Visita il nostro sito web: [https://emuready.com](https://emuready.com)

---

**Screenshot della Home Page**

<img src="https://github.com/user-attachments/assets/9a7077fd-a9b1-4a1c-8a81-8f9beed25581" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/df612c7c-4b9d-481b-ae92-175b2b6afb0b" width="48%">

---

**Screenshot della Pagina delle Liste di Compatibilità**

<img src="https://github.com/user-attachments/assets/400c48d4-6340-4a60-8d86-f996a35f1bf4" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/4ca1c1de-3616-4c25-81b9-ad80f8a69458" width="48%">

---

**Screenshot della Pagina Giochi**

<img src="https://github.com/user-attachments/assets/b036de53-18ed-4bf4-8117-5cd36e87ee31" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/9fbe12c4-3387-4e1d-986a-df80761134e3" width="48%">

---

## Panoramica

EmuReady aiuta gli utenti a condividere e scoprire informazioni sulla compatibilità dell’emulazione su diverse configurazioni hardware e software. Gli utenti possono contribuire con report di compatibilità, votare le liste e discutere combinazioni specifiche di gioco/dispositivo/emulatore.

![License](https://img.shields.io/github/license/Producdevity/emuready?cacheSeconds=1)
![Stars](https://img.shields.io/github/stars/Producdevity/emuready?cacheSeconds=1)
![Forks](https://img.shields.io/github/forks/Producdevity/emuready?cacheSeconds=1)
![Issues](https://img.shields.io/github/issues/Producdevity/emuready?cacheSeconds=1)

## Funzionalità

- **Database di Compatibilità Completo**: Traccia le prestazioni dei giochi su diversi emulatori e dispositivi
- **Contributi degli Utenti**: Report guidati dalla comunità e sistema di votazione
- **Sistema di Discussione**: Thread di commenti con funzionalità di voto positivo/negativo
- **Dashboard Amministratore**: Gestisci utenti, liste e moderazione dei contenuti
- **Design Responsivo**: Funziona su mobile, tablet e desktop

## Miglioramenti Recenti

La base di codice è stata notevolmente migliorata con i seguenti aggiornamenti:

### Componenti UI

- Creato un componente **ErrorBoundary** per una migliore gestione e recupero degli errori
- Aggiunto un componente **OptimizedImage** utilizzando il componente Image di Next.js per migliori prestazioni
- Migliorata la **Paginazione** con funzionalità di accessibilità, navigazione tramite tastiera e migliore esperienza utente
- Potenziato il componente **Badge** con più varianti, dimensioni e un’opzione pillola
- Aggiunto il componente **ThemeToggle** per passare tra temi chiaro, scuro e di sistema
- Implementato **SortableHeader** per l’ordinamento delle tabelle con indicatori visivi

### Cache e Prestazioni

- Migliorata la configurazione di React Query con predefiniti migliori per caching, tempi di staleness e logica di retry
- Aggiunta ottimizzazione delle immagini per le immagini dei dispositivi
- Implementata una corretta gestione degli errori in tutta l’applicazione

### Accessibilità

- Migliorata la navigazione tramite tastiera per gli elementi interattivi
- Aggiunte etichette ARIA e ruoli appropriati
- Migliore gestione del focus
- Miglior contrasto dei colori nei componenti UI

### Sicurezza

- Validazione e sanificazione dei dati su più livelli (client, server, database)
- Implementazione della Content Security Policy
- Protezione contro attacchi XSS e CSRF
- Autenticazione sicura con NextAuth.js
- Validazione e misure di sicurezza per il caricamento dei file
- Restrizioni sulla lunghezza degli input e sanificazione adeguata
- Validazione UUID per prevenire la manomissione dei parametri

### Esperienza Sviluppatore

- Aggiunti script npm aggiuntivi per il flusso di lavoro di sviluppo
- Migliore struttura del progetto con export coerenti
- Miglior feedback sugli errori con ErrorBoundary personalizzato
- Migliorata la pagina 404 con opzioni di navigazione utili

### Temi

- Aggiunto il rilevamento della preferenza del tema di sistema
- Creato un toggle tema con opzioni UI multiple
- Migliorata l’implementazione della modalità scura su tutti i componenti

## Per Iniziare

### Prerequisiti

- Node.js 20+
- `npm`
- PostgreSQL (oppure SQLite per lo sviluppo)

### Installazione

1. Clona il repository

```bash
git clone https://github.com/Producdevity/emuready.git
cd emuready
```

2. Installa le dipendenze

```bash
npm install
```

3. Configura le variabili d’ambiente

```bash
cp .env.example .env
```

Poi modifica il file `.env` con le credenziali del tuo database e altre configurazioni.

4. Imposta il database

```bash
npx prisma generate
npx prisma db push
```

5. Avvia il server di sviluppo

```bash
npm run dev
```

6. Apri [http://localhost:3000](http://localhost:3000) nel tuo browser

## Script Disponibili

- `npm run dev` - Avvia il server di sviluppo
- `npm run dev:strict` - Avvia con React in modalità strict
- `npm run build` - Compila per la produzione
- `npm run start` - Avvia il server di produzione
- `npm run test` - Esegui i test
- `npm run lint` - Esegui ESLint
- `npm run lint:fix` - Risolvi i problemi di linting
- `npm run format` - Formattta il codice con Prettier
- `npm run typecheck` - Controlla i tipi TypeScript
- `npm run analyze` - Analizza la dimensione del bundle
- `npm run clean` - Pulisci la cache di build
- `npm run prepare-deploy` - Prepara per il deploy (lint, typecheck, test, build)

### Comandi Prisma

- `npx prisma db seed` - Popola il database con dati di esempio
- `npx prisma studio` - Apri Prisma Studio
- `npx prisma db pull` - Recupera lo schema del database
- `npx prisma db push` - Invia lo schema al database

Vedi la [Prisma Cli Reference](https://www.prisma.io/docs/orm/reference/prisma-cli-reference) per maggiori dettagli.

## Stack Tecnologico

- **Framework**: Next.js 15
- **ORM Database**: Prisma
- **API**: tRPC
- **Autenticazione**: NextAuth.js
- **Stilizzazione**: Tailwind CSS
- **Gestione Stato**: React Query
- **Type Checking**: TypeScript
- **Animazioni**: Framer Motion
- **Validazione**: Zod, Content Security Policy, Validazione Input

## Contribuire

Accogliamo contributi! Consulta le nostre [Linee guida per i contributori](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CONTRIBUTING.md) per maggiori dettagli.

## Licenza

Questo progetto è concesso sotto licenza MIT - vedi il file [LICENSE](https://raw.githubusercontent.com/Producdevity/EmuReady/master/LICENSE) per i dettagli.

## Codice di Condotta (TODO)

Nota che questo progetto aderisce a un [Codice di Condotta](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CODE_OF_CONDUCT.md). Partecipando a questo progetto, accetti di rispettarne i termini.

## Sicurezza (TODO)

Se scopri una vulnerabilità di sicurezza, segui la nostra [Security Policy](https://raw.githubusercontent.com/Producdevity/EmuReady/master/SECURITY.md) per la segnalazione.

## Ringraziamenti

- Tutti i nostri [Contributors](https://github.com/Producdevity/emuready/graphs/contributors)
- La comunità dell’emulazione per ispirazione e supporto

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---