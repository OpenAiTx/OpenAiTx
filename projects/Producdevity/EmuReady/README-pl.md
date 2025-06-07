# EmuReady

Platforma społecznościowa do śledzenia kompatybilności emulacji na różnych urządzeniach i emulatorach.

Odwiedź naszą stronę: [https://emuready.com](https://emuready.com)

---

**Zrzut ekranu strony głównej**

<img src="https://github.com/user-attachments/assets/9a7077fd-a9b1-4a1c-8a81-8f9beed25581" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/df612c7c-4b9d-481b-ae92-175b2b6afb0b" width="48%">

---

**Zrzut ekranu strony listy kompatybilności**

<img src="https://github.com/user-attachments/assets/400c48d4-6340-4a60-8d86-f996a35f1bf4" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/4ca1c1de-3616-4c25-81b9-ad80f8a69458" width="48%">

---

**Zrzut ekranu strony gier**

<img src="https://github.com/user-attachments/assets/b036de53-18ed-4bf4-8117-5cd36e87ee31" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/9fbe12c4-3387-4e1d-986a-df80761134e3" width="48%">

---

## Przegląd

EmuReady pomaga użytkownikom dzielić się oraz odkrywać informacje o kompatybilności emulacji na różnych konfiguracjach sprzętowych i programowych. Użytkownicy mogą zgłaszać raporty o kompatybilności, głosować na wpisy oraz dyskutować o konkretnych kombinacjach gra/urządzenie/emulator.

![License](https://img.shields.io/github/license/Producdevity/emuready?cacheSeconds=1)
![Stars](https://img.shields.io/github/stars/Producdevity/emuready?cacheSeconds=1)
![Forks](https://img.shields.io/github/forks/Producdevity/emuready?cacheSeconds=1)
![Issues](https://img.shields.io/github/issues/Producdevity/emuready?cacheSeconds=1)

## Funkcje

- **Kompleksowa baza kompatybilności**: Śledzenie jak gry działają na różnych emulatorach i urządzeniach
- **Wkład użytkowników**: Raporty i system głosowania napędzany przez społeczność
- **System dyskusji**: Wątki komentarzy z możliwością głosowania w górę/w dół
- **Panel administratora**: Zarządzanie użytkownikami, wpisami i moderacją treści
- **Responsywny design**: Działa na urządzeniach mobilnych, tabletach i komputerach stacjonarnych

## Ostatnie ulepszenia

Kod źródłowy został znacząco ulepszony poprzez następujące zmiany:

### Komponenty UI

- Stworzono komponent **ErrorBoundary** dla lepszego obsługi błędów i odzyskiwania
- Dodano komponent **OptimizedImage** wykorzystujący Next.js Image dla lepszej wydajności
- Ulepszono **Paginację** o funkcje dostępności, nawigację klawiaturą i lepszy UX
- Udoskonalono komponent **Badge** o więcej wariantów, rozmiarów i opcję „pill”
- Dodano komponent **ThemeToggle** do przełączania motywów: jasny, ciemny i systemowy
- Wdrożono **SortableHeader** do sortowania tabeli z wizualnymi wskaźnikami

### Cache & Wydajność

- Ulepszono konfigurację React Query z lepszymi domyślnymi ustawieniami cache, czasami starych danych i logiką ponawiania
- Dodano optymalizację obrazów urządzeń
- Wdrożono właściwą obsługę błędów w całej aplikacji

### Dostępność

- Ulepszona nawigacja klawiaturą dla elementów interaktywnych
- Dodano odpowiednie etykiety ARIA i role
- Poprawione zarządzanie fokusem
- Lepszy kontrast kolorów w komponentach UI

### Bezpieczeństwo

- Walidacja i sanityzacja danych na wielu poziomach (klient, serwer, baza danych)
- Implementacja Content Security Policy
- Ochrona przed atakami XSS i CSRF
- Bezpieczna autoryzacja z NextAuth.js
- Walidacja przesyłanych plików i środki bezpieczeństwa
- Ograniczenia długości wejścia i właściwa sanityzacja
- Walidacja UUID, aby zapobiec manipulacji parametrami

### Doświadczenie deweloperskie

- Dodano dodatkowe skrypty npm dla workflow deweloperskiego
- Lepsza struktura projektu z konsekwentnym eksportem
- Ulepszone informacje o błędach za pomocą własnego ErrorBoundary
- Udoskonalona strona 404 z przydatnymi opcjami nawigacji

### Motywy

- Dodano wykrywanie preferencji motywu systemowego
- Stworzono przełącznik motywów z wieloma opcjami UI
- Ulepszona implementacja ciemnego motywu w komponentach

## Pierwsze kroki

### Wymagania wstępne

- Node.js 20+
- `npm`
- PostgreSQL (lub SQLite do dewelopmentu)

### Instalacja

1. Sklonuj repozytorium

```bash
git clone https://github.com/Producdevity/emuready.git
cd emuready
```

2. Zainstaluj zależności

```bash
npm install
```

3. Skonfiguruj zmienne środowiskowe

```bash
cp .env.example .env
```

Następnie edytuj plik `.env` wprowadzając dane do bazy danych oraz inne ustawienia.

4. Skonfiguruj bazę danych

```bash
npx prisma generate
npx prisma db push
```

5. Uruchom serwer deweloperski

```bash
npm run dev
```

6. Otwórz [http://localhost:3000](http://localhost:3000) w swojej przeglądarce

## Dostępne skrypty

- `npm run dev` - Uruchamia serwer deweloperski
- `npm run dev:strict` - Uruchamia z trybem ścisłym React
- `npm run build` - Buduje aplikację do produkcji
- `npm run start` - Uruchamia serwer produkcyjny
- `npm run test` - Uruchamia testy
- `npm run lint` - Uruchamia ESLint
- `npm run lint:fix` - Naprawia błędy lintowania
- `npm run format` - Formatuje kod za pomocą Prettier
- `npm run typecheck` - Sprawdza typy TypeScript
- `npm run analyze` - Analizuje rozmiar paczki
- `npm run clean` - Czyści cache builda
- `npm run prepare-deploy` - Przygotowuje do wdrożenia (lint, typecheck, test, build)

### Komendy Prisma

- `npx prisma db seed` - Zasieje bazę danych
- `npx prisma studio` - Otwiera Prisma Studio
- `npx prisma db pull` - Pobiera schemat bazy danych
- `npx prisma db push` - Wysyła schemat bazy danych

Zobacz [Prisma Cli Reference](https://www.prisma.io/docs/orm/reference/prisma-cli-reference) po więcej szczegółów.

## Stos technologiczny

- **Framework**: Next.js 15
- **Database ORM**: Prisma
- **API**: tRPC
- **Uwierzytelnianie**: NextAuth.js
- **Styling**: Tailwind CSS
- **Zarządzanie stanem**: React Query
- **Sprawdzanie typów**: TypeScript
- **Animacje**: Framer Motion
- **Walidacja**: Zod, Content Security Policy, Walidacja danych wejściowych

## Współpraca

Zapraszamy do współpracy! Zobacz nasze [Wytyczne dotyczące współpracy](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CONTRIBUTING.md) po więcej szczegółów.

## Licencja

Ten projekt jest objęty licencją MIT – szczegóły znajdziesz w pliku [LICENSE](https://raw.githubusercontent.com/Producdevity/EmuReady/master/LICENSE).

## Kodeks postępowania (TODO)

Pamiętaj, że ten projekt przestrzega [Kodeksu postępowania](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CODE_OF_CONDUCT.md). Biorąc udział w tym projekcie, zgadzasz się na przestrzeganie jego zasad.

## Bezpieczeństwo (TODO)

Jeśli odkryjesz lukę bezpieczeństwa, postępuj zgodnie z naszą [Polityką bezpieczeństwa](https://raw.githubusercontent.com/Producdevity/EmuReady/master/SECURITY.md) podczas zgłaszania.

## Podziękowania

- Wszyscy nasi [Współtwórcy](https://github.com/Producdevity/emuready/graphs/contributors)
- Społeczność emulacji za inspirację i wsparcie

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---