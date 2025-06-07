# EmuReady

Eine gemeinschaftsbasierte Plattform zur Nachverfolgung der Emulationskompatibilität auf verschiedenen Geräten und Emulatoren.

Besuche unsere Website: [https://emuready.com](https://emuready.com)

---

**Screenshot der Startseite**

<img src="https://github.com/user-attachments/assets/9a7077fd-a9b1-4a1c-8a81-8f9beed25581" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/df612c7c-4b9d-481b-ae92-175b2b6afb0b" width="48%">

---

**Screenshot der Kompatibilitätslisten-Seite**

<img src="https://github.com/user-attachments/assets/400c48d4-6340-4a60-8d86-f996a35f1bf4" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/4ca1c1de-3616-4c25-81b9-ad80f8a69458" width="48%">

---

**Screenshot der Spiele-Seite**

<img src="https://github.com/user-attachments/assets/b036de53-18ed-4bf4-8117-5cd36e87ee31" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/9fbe12c4-3387-4e1d-986a-df80761134e3" width="48%">

---

## Überblick

EmuReady hilft Nutzern, Emulationskompatibilitätsinformationen über verschiedene Hardware- und Softwarekonfigurationen hinweg zu teilen und zu entdecken. Nutzer können Kompatibilitätsberichte beitragen, über Einträge abstimmen und spezifische Kombinationen aus Spiel/Gerät/Emulator diskutieren.

![License](https://img.shields.io/github/license/Producdevity/emuready?cacheSeconds=1)
![Stars](https://img.shields.io/github/stars/Producdevity/emuready?cacheSeconds=1)
![Forks](https://img.shields.io/github/forks/Producdevity/emuready?cacheSeconds=1)
![Issues](https://img.shields.io/github/issues/Producdevity/emuready?cacheSeconds=1)

## Funktionen

- **Umfassende Kompatibilitätsdatenbank**: Verfolge, wie Spiele auf verschiedenen Emulatoren und Geräten laufen
- **Nutzerbeiträge**: Gemeinschaftsbasierte Berichte und Abstimmungssystem
- **Diskussionssystem**: Kommentar-Threads mit Upvote/Downvote-Funktionalität
- **Admin-Dashboard**: Verwaltung von Nutzern, Einträgen und Inhaltsmoderation
- **Responsives Design**: Funktioniert auf Mobilgeräten, Tablets und Desktop

## Neueste Verbesserungen

Der Code wurde mit den folgenden Verbesserungen erheblich optimiert:

### UI-Komponenten

- Erstellen einer **ErrorBoundary**-Komponente für bessere Fehlerbehandlung und Wiederherstellung
- Hinzufügen einer **OptimizedImage**-Komponente unter Verwendung der Next.js Image-Komponente für bessere Performance
- Verbesserte **Pagination** mit Barrierefreiheitsfunktionen, Tastaturnavigation und besserem UX
- Verbesserte **Badge**-Komponente mit mehr Varianten, Größen und einer Pillen-Option
- Hinzufügen einer **ThemeToggle**-Komponente zum Wechseln zwischen Light-, Dark- und System-Theme
- Implementierung von **SortableHeader** für Tabellen-Sortierung mit visuellen Indikatoren

### Caching & Performance

- Verbesserte React Query Konfiguration mit besseren Standardwerten für Caching, Stale Times und Retry-Logik
- Bildoptimierung für Gerätebilder hinzugefügt
- Durchgehende, ordnungsgemäße Fehlerbehandlung in der Anwendung implementiert

### Barrierefreiheit

- Verbesserte Tastaturnavigation für interaktive Elemente
- Hinzufügen korrekter ARIA Labels und Rollen
- Verbesserte Fokusverwaltung
- Besserer Farbkontrast in UI-Komponenten

### Sicherheit

- Datenvalidierung und -bereinigung auf mehreren Ebenen (Client, Server, Datenbank)
- Implementierung einer Content Security Policy
- Schutz vor XSS- und CSRF-Angriffen
- Sichere Authentifizierung mit NextAuth.js
- Validierung und Sicherheitsmaßnahmen beim Datei-Upload
- Eingabelängenbeschränkung und ordnungsgemäße Bereinigung
- UUID-Validierung zur Vermeidung von Parameter-Manipulation

### Entwicklererlebnis

- Zusätzliche npm-Skripte für den Entwicklungs-Workflow hinzugefügt
- Bessere Projektstruktur mit konsistenten Exports
- Verbesserte Fehlerausgabe mit eigener ErrorBoundary
- Verbesserte 404-Seite mit hilfreichen Navigationsoptionen

### Theming

- Erkennung von System-Theme-Präferenzen hinzugefügt
- Erstellung eines Theme-Toggles mit mehreren UI-Optionen
- Verbesserte Dark-Mode-Implementierung über alle Komponenten hinweg

## Erste Schritte

### Voraussetzungen

- Node.js 20+
- `npm`
- PostgreSQL (oder SQLite für die Entwicklung)

### Installation

1. Repository klonen

```bash
git clone https://github.com/Producdevity/emuready.git
cd emuready
```

2. Abhängigkeiten installieren

```bash
npm install
```

3. Umgebungsvariablen einrichten

```bash
cp .env.example .env
```

Dann die `.env`-Datei mit deinen Datenbankzugangsdaten und weiteren Konfigurationen bearbeiten.

4. Datenbank einrichten

```bash
npx prisma generate
npx prisma db push
```

5. Entwicklungsserver starten

```bash
npm run dev
```

6. [http://localhost:3000](http://localhost:3000) im Browser öffnen

## Verfügbare Skripte

- `npm run dev` - Entwicklungsserver starten
- `npm run dev:strict` - Mit React Strict Mode starten
- `npm run build` - Für Produktion bauen
- `npm run start` - Produktionsserver starten
- `npm run test` - Tests ausführen
- `npm run lint` - ESLint ausführen
- `npm run lint:fix` - Linting-Probleme beheben
- `npm run format` - Code mit Prettier formatieren
- `npm run typecheck` - TypeScript-Typen prüfen
- `npm run analyze` - Bundle-Größe analysieren
- `npm run clean` - Build-Cache bereinigen
- `npm run prepare-deploy` - Für Deployment vorbereiten (lint, typecheck, test, build)

### Prisma-Befehle

- `npx prisma db seed` - Datenbank befüllen (Seed)
- `npx prisma studio` - Prisma Studio öffnen
- `npx prisma db pull` - Datenbankschema abrufen
- `npx prisma db push` - Datenbankschema anwenden

Weitere Details findest du in der [Prisma Cli Reference](https://www.prisma.io/docs/orm/reference/prisma-cli-reference).

## Tech-Stack

- **Framework**: Next.js 15
- **Datenbank-ORM**: Prisma
- **API**: tRPC
- **Authentifizierung**: NextAuth.js
- **Styling**: Tailwind CSS
- **State Management**: React Query
- **Type Checking**: TypeScript
- **Animation**: Framer Motion
- **Validierung**: Zod, Content Security Policy, Input Validation

## Mitwirken

Beiträge sind willkommen! Siehe unsere [Beitragsrichtlinien](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CONTRIBUTING.md) für mehr Details.

## Lizenz

Dieses Projekt steht unter der MIT-Lizenz – siehe die [LICENSE](https://raw.githubusercontent.com/Producdevity/EmuReady/master/LICENSE)-Datei für Details.

## Verhaltenskodex (TODO)

Bitte beachte, dass dieses Projekt einem [Verhaltenskodex](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CODE_OF_CONDUCT.md) unterliegt. Durch deine Teilnahme erklärst du dich mit dessen Bedingungen einverstanden.

## Sicherheit (TODO)

Wenn du eine Sicherheitslücke entdeckst, folge bitte unserer [Sicherheitsrichtlinie](https://raw.githubusercontent.com/Producdevity/EmuReady/master/SECURITY.md) zur Meldung.

## Danksagungen

- Alle unsere [Mitwirkenden](https://github.com/Producdevity/emuready/graphs/contributors)
- Die Emulations-Community für Inspiration und Unterstützung

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---