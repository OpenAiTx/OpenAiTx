<p align="center">
  <a href="https://www.jukeboxhq.com">
    <img height="500" src="https://raw.githubusercontent.com/skeptrunedev/jukebox/main/frontend/public/opengraph-image.jpg" alt="Trieve Logo">
  </a>
</p>

<p align="center">
  <a href="https://hub.docker.com/r/skeptrune/jukebox-server" style="text-decoration: none;">
    <img src="https://img.shields.io/docker/pulls/skeptrune/jukebox-server?style=flat-square" alt="Pobrania Docker" />
  </a>
  <a href="https://github.com/skeptrunedev/jukebox/stargazers" style="text-decoration: none;">
    <img src="https://img.shields.io/github/stars/skeptrunedev/jukebox?style=flat-square" alt="Gwiazdy GitHub" />
  </a>
  <a href="https://x.com/skeptrune" style="text-decoration: none;">
    <img src="https://img.shields.io/badge/follow%20on-x.com-1da1f2?logo=x&style=flat-square" alt="Obserwuj na X (Twitter)" />
  </a>
</p>

---
# Zamień dowolne urządzenie w wspólny Jukebox

**Jukebox** pozwala natychmiast stworzyć wspólną playlistę muzyczną z przyjaciółmi—bez aplikacji, bez logowania, bez reklam. Po prostu stwórz box, udostępnij link i zacznijcie razem dodawać utwory. Idealny na imprezy, wycieczki samochodowe lub każde wspólne spotkanie!

- 🌐 **Otwarta alternatywa dla współdzielonych playlist Spotify**
- 🕵️ **Brak potrzeby zakładania konta**: Używaj anonimowo—bez rejestracji i podawania maila
- ✨ **Udostępnij link, dodawajcie utwory razem**: Każdy może dodawać muzykę w czasie rzeczywistym
- 🚀 **Bez pobierania aplikacji**: Działa na każdym urządzeniu, bezpośrednio w przeglądarce
- 🎵 **Integracja z YouTube**: Wyszukuj i odtwarzaj niemal każdy utwór natychmiast
- 📱 **Przyjazny dla urządzeń mobilnych**: Zaprojektowany dla telefonów, tabletów i komputerów
- ⚖️ **Sprawiedliwa kolejka**: Utwory są automatycznie sortowane, by każdy miał swoją kolej
- 🆓 **100% za darmo, bez reklam**

---

## Wypróbuj teraz

1. **Stwórz Jukebox**: Odwiedź stronę główną i utwórz nowy box
2. **Udostępnij link**: Wyślij zaproszenie znajomym
3. **Dodaj utwory**: Wyszukaj w YouTube lub dodaj utwory ręcznie
4. **Odtwarzaj muzykę**: Użyj wbudowanego odtwarzacza, by słuchać razem

---
## Funkcje

- Współdzielone playlisty: Dodawaj, ustawiaj w kolejce i odtwarzaj utwory razem
- Anonimowe korzystanie: Bez logowania i konta
- Wyszukiwanie i odtwarzanie z YouTube: Dostęp do ogromnej biblioteki muzycznej
- Interfejs mobilny, responsywny
- Otwarty kod źródłowy (Licencja MIT)
- Łatwa instalacja z użyciem Dockera

### Wdrożenia za pomocą Docker Compose

Uruchom wszystkie usługi:

```bash
docker-compose up -d
```

Ponownie wdrażaj usługi bez przestojów po aktualizacji obrazów:

```bash
bash ./redeploy.sh
```
---

## Pierwsze kroki

### Wymagania wstępne

- Node.js 16+
- npm lub yarn
- Klucz YouTube Data API v3 (darmowy od Google)

### Konfiguracja YouTube API

1. Przejdź do [Google Cloud Console](https://console.cloud.google.com/)
2. Utwórz nowy projekt lub wybierz istniejący
3. Włącz **YouTube Data API v3**
4. Utwórz dane uwierzytelniające (Klucz API)
5. Skopiuj swój klucz API

### Instalacja
```bash
# Sklonuj repozytorium
git clone <your-repo-url>
cd jukebox

# Zainstaluj zależności serwera
cd server
yarn install

# Zainstaluj zależności frontendowe
cd ../frontend
yarn install

# Skonfiguruj zmienne środowiskowe
cd ../server
cp .env.example .env
# Edytuj plik .env i dodaj swój klucz API YouTube

# Uruchom migracje bazy danych
```
yarn migrate

# Uruchom serwery deweloperskie
# Backend:
cd server
yarn dev
# Worker:
cd server
yarn dev:worker
# Frontend (w nowym terminalu):
cd frontend
yarn dev
```

---

## Licencja

MIT

---
## Współpraca i opinie

- Otwórz zgłoszenie lub pull request na [GitHubie](https://github.com/skeptrunedev/jukebox)
- Propozycje funkcji? Napisz wiadomość prywatną do [@skeptrune na X (Twitterze)](https://twitter.com/skeptrune)

---

## Lista zmian

Zobacz [Listę zmian](https://jukebox.skeptrune.com#changelog), aby uzyskać najnowsze aktualizacje i funkcje.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---