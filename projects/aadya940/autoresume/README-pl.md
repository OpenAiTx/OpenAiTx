<p align="center">
  <img src="https://raw.githubusercontent.com/aadya940/autoresume/main/main_app/frontend/public/autoresume-logo.png" alt="autoResume Logo" title="autoResume Logo" width="180"/>
</p>

<h1 align="center">autoResume</h1>

<p align="center">
  <b>Otwarty kreator CV, wklej swoje linki, edytuj ręcznie i pozwól AI pomóc w dopracowaniu, aktualizacji oraz dostosowaniu Twojego CV.</b>
</p>

---

### Jak tego używać?

[Link do bloga na Medium](https://medium.com/@aadyachinubhai/autoresume-copy-and-paste-links-its-that-simple-8e50e6d155a1)

Blog jest nieaktualny w stosunku do interfejsu użytkownika i użytego szablonu.

## Funkcje

- <b>Łatwy import linków:</b> Wklejaj linki ze stron internetowych i szybko twórz CV w formacie PDF.
- <b>Wbudowany edytor ręczny:</b> Dopracuj lub zbuduj CV od podstaw za pomocą wbudowanego edytora kodu.
- <b>Inteligentne sugestie:</b> Przekazuj opinie lub nowe linki, a funkcja smartedits pomoże ulepszyć i zaktualizować Twoje CV.
- <b>Dopasowanie do ofert pracy:</b> Wklej opis stanowiska i otrzymaj rekomendacje, jak dostosować swoje CV.
- <b>Jakość LaTeX:</b> Wszystkie CV są generowane za pomocą LaTeX, co zapewnia czytelny i profesjonalny układ.
- <b>Podgląd na żywo:</b> Zobacz swoje CV jako PDF w czasie rzeczywistym.
- <b>Łatwy reset:</b> Wyczyść i rozpocznij tworzenie CV od nowa jednym kliknięciem.
- <b>Lokalnie:</b> Działa w pełni na Twoim komputerze przy użyciu Dockera.

---

## Pierwsze kroki

### Wymagania wstępne
- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/)

### Instalacja

1. Sklonuj repozytorium:
   ```bash
   git clone https://github.com/aadya940/autoresume.git
   cd autoresume
   ```
2. Zbuduj i uruchom aplikację:
   ```bash
   docker compose up --build
   ```
3. Uzyskaj dostęp do aplikacji:
   
   [_http://localhost:5173_](http://localhost:5173)
---

## Użytkowanie

1. Otwórz autoResume w swojej przeglądarce.
2. Kliknij ikonę :gear:, wklej swój [KLUCZ API GOOGLE](https://aistudio.google.com/) oraz swój e‑mail.
3. Wklej linki do swoich danych zawodowych (np. Github, strona osobista itp.).
4. Opcjonalnie dodaj opinię lub link do oferty pracy, aby dalej dostosować CV.
5. Kliknij <b>Generate Resume</b> i pozwól, by AI zrobiło resztę!

---

## Licencja

Ten projekt jest objęty licencją Apache 2.0.

## Przewodnik dla współtwórców

### Frontend
- Implementuj komponenty React w folderze `frontend/src/components/`
- Używamy Chakra UI do implementacji komponentów.
- Importuj i używaj swoich komponentów w `frontend/src/App.jsx`

### Backend
- Implementuj trasy API w katalogu `backend/src/routes/`
- Dodawaj funkcjonalności AI w katalogu `backend/src/ai/`
- Używamy formatowania kodu `black` dla Pythona
- Zachowuj przejrzystość obsługi tras i oddzielaj logikę

### Ogólne wytyczne
- Twórz nową gałąź dla swojej funkcji/poprawki: `git checkout -b twoja-nazwa-galezi`
- Pisz czytelne komunikaty commitów
- Przetestuj zmiany przed wysłaniem PR

### Zgłaszanie zmian
1. Utwórz Pull Request
2. W opisie PR zamieść:
   - Jakie zmiany zostały wprowadzone
   - Dlaczego zostały wprowadzone
   - Wszelkie istotne zrzuty ekranu lub wyniki testów
   - Wszelkie zmiany powodujące niezgodność lub wymagane migracje

Doceniamy Twój wkład i przejrzymy Twój PR tak szybko, jak to możliwe!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---