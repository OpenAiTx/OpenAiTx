# EmuReady

Een community-gedreven platform voor het bijhouden van emulatiecompatibiliteit op verschillende apparaten en emulators.

Bezoek onze website: [https://emuready.com](https://emuready.com)

---

**Screenshot van de Startpagina**

<img src="https://github.com/user-attachments/assets/9a7077fd-a9b1-4a1c-8a81-8f9beed25581" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/df612c7c-4b9d-481b-ae92-175b2b6afb0b" width="48%">

---

**Screenshot van de Compatibiliteitspagina**

<img src="https://github.com/user-attachments/assets/400c48d4-6340-4a60-8d86-f996a35f1bf4" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/4ca1c1de-3616-4c25-81b9-ad80f8a69458" width="48%">

---

**Screenshot van de Gamespagina**

<img src="https://github.com/user-attachments/assets/b036de53-18ed-4bf4-8117-5cd36e87ee31" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/9fbe12c4-3387-4e1d-986a-df80761134e3" width="48%">

---

## Overzicht

EmuReady helpt gebruikers om informatie over emulatiecompatibiliteit te delen en te ontdekken op verschillende hardware- en softwareconfiguraties. Gebruikers kunnen compatibiliteitsrapporten bijdragen, stemmen op vermeldingen en discussiëren over specifieke combinaties van spel/apparaat/emulator.

![Licentie](https://img.shields.io/github/license/Producdevity/emuready?cacheSeconds=1)
![Sterren](https://img.shields.io/github/stars/Producdevity/emuready?cacheSeconds=1)
![Forks](https://img.shields.io/github/forks/Producdevity/emuready?cacheSeconds=1)
![Issues](https://img.shields.io/github/issues/Producdevity/emuready?cacheSeconds=1)

## Functies

- **Uitgebreide Compatibiliteitsdatabase**: Houd bij hoe spellen presteren op verschillende emulators en apparaten
- **Gebruikersbijdragen**: Community-gedreven rapporten en stemsysteem
- **Discussiesysteem**: Reactiedraden met upvote/downvote-functionaliteit
- **Beheerderdashboard**: Beheer gebruikers, vermeldingen en contentmoderatie
- **Responsief Design**: Werkt op mobiel, tablet en desktop

## Recente Verbeteringen

De codebase is aanzienlijk verbeterd met de volgende vernieuwingen:

### UI-componenten

- Een **ErrorBoundary**-component gemaakt voor betere foutafhandeling en herstel
- Een **OptimizedImage**-component toegevoegd met gebruik van de Next.js Image-component voor betere prestaties
- **Paginering** verbeterd met toegankelijkheidsfuncties, toetsenbordnavigatie en betere UX
- **Badge**-component uitgebreid met meer varianten, maten en een pill-optie
- **ThemeToggle**-component toegevoegd voor het wisselen tussen lichte, donkere en systeemthema’s
- **SortableHeader** geïmplementeerd voor sorteermogelijkheden met visuele indicatoren

### Caching & Prestaties

- Verbeterde React Query-configuratie met betere standaardinstellingen voor caching, stale-tijden en retry-logica
- Afbeeldingsoptimalisatie toegevoegd voor apparaatbeelden
- Correcte foutafhandeling geïmplementeerd in de hele applicatie

### Toegankelijkheid

- Verbeterde toetsenbordnavigatie voor interactieve elementen
- Correcte ARIA-labels en rollen toegevoegd
- Verbeterd focusbeheer
- Betere kleurcontrasten in UI-componenten

### Beveiliging

- Gegevensvalidatie en -sanitatie op meerdere niveaus (client, server, database)
- Content Security Policy geïmplementeerd
- Bescherming tegen XSS- en CSRF-aanvallen
- Veilige authenticatie met NextAuth.js
- Validatie en beveiliging van bestandsuploads
- Invoerlimieten en correcte sanitatie
- UUID-validatie om parametermanipulatie te voorkomen

### Ontwikkelaarservaring

- Extra npm-scripts toegevoegd voor de ontwikkelworkflow
- Betere projectstructuur met consistente exports
- Verbeterde foutmeldingen met aangepaste ErrorBoundary
- Verbeterde 404-pagina met handige navigatieopties

### Thema’s

- Detectie van systeemthemapreferentie toegevoegd
- Themawisselaar gemaakt met meerdere UI-opties
- Verbeterde implementatie van dark mode in componenten

## Aan de slag

### Vereisten

- Node.js 20+
- `npm`
- PostgreSQL (of SQLite voor ontwikkeling)

### Installatie

1. Clone de repository

```bash
git clone https://github.com/Producdevity/emuready.git
cd emuready
```

2. Installeer de afhankelijkheden

```bash
npm install
```

3. Stel de omgevingsvariabelen in

```bash
cp .env.example .env
```

Bewerk vervolgens het `.env`-bestand met je databasegegevens en andere configuratie.

4. Zet de database op

```bash
npx prisma generate
npx prisma db push
```

5. Start de ontwikkelserver

```bash
npm run dev
```

6. Open [http://localhost:3000](http://localhost:3000) in je browser

## Beschikbare Scripts

- `npm run dev` - Start de ontwikkelserver
- `npm run dev:strict` - Start met React strict mode
- `npm run build` - Bouw voor productie
- `npm run start` - Start de productieomgeving
- `npm run test` - Voer tests uit
- `npm run lint` - Voer ESLint uit
- `npm run lint:fix` - Los lintproblemen op
- `npm run format` - Format code met Prettier
- `npm run typecheck` - Controleer TypeScript-types
- `npm run analyze` - Analyseer de bundelgrootte
- `npm run clean` - Maak build cache schoon
- `npm run prepare-deploy` - Bereid voor op uitrol (lint, typecheck, test, build)

### Prisma-commando’s

- `npx prisma db seed` - Seed de database
- `npx prisma studio` - Open Prisma Studio
- `npx prisma db pull` - Haal het databaseschema op
- `npx prisma db push` - Zet het databaseschema door

Zie [Prisma Cli Reference](https://www.prisma.io/docs/orm/reference/prisma-cli-reference) voor meer details.

## Technische Stack

- **Framework**: Next.js 15
- **Database ORM**: Prisma
- **API**: tRPC
- **Authenticatie**: NextAuth.js
- **Styling**: Tailwind CSS
- **State Management**: React Query
- **Type Checking**: TypeScript
- **Animatie**: Framer Motion
- **Validatie**: Zod, Content Security Policy, Input Validation

## Bijdragen

We verwelkomen bijdragen! Zie onze [Richtlijnen voor bijdragen](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CONTRIBUTING.md) voor meer informatie.

## Licentie

Dit project is gelicentieerd onder de MIT-licentie - zie het [LICENSE](https://raw.githubusercontent.com/Producdevity/EmuReady/master/LICENSE) bestand voor details.

## Gedragscode (TODO)

Let op: dit project houdt zich aan een [Gedragscode](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CODE_OF_CONDUCT.md). Door deel te nemen aan dit project ga je akkoord met de voorwaarden.

## Beveiliging (TODO)

Als je een beveiligingslek ontdekt, volg dan ons [Beveiligingsbeleid](https://raw.githubusercontent.com/Producdevity/EmuReady/master/SECURITY.md) voor het melden.

## Erkenningen

- Al onze [Contributors](https://github.com/Producdevity/emuready/graphs/contributors)
- De emulatiecommunity voor inspiratie en ondersteuning

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---