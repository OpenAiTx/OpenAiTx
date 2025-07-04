# SparkyFitness - Samohostowana alternatywa dla MyFitnessPal

SparkyFitness to kompleksowa aplikacja do śledzenia i zarządzania fitnessem, zaprojektowana, aby pomóc użytkownikom monitorować odżywianie, ćwiczenia oraz pomiary ciała. Zapewnia narzędzia do codziennego śledzenia postępów, ustalania celów i generowania przejrzystych raportów wspierających zdrowy styl życia.


## ✨ Funkcje

### 🍎 Śledzenie Odżywiania

* **Rejestruj swoje codzienne posiłki**
* **Twórz i zarządzaj własnymi produktami spożywczymi i kategoriami**
* **Przeglądaj podsumowania i analizuj trendy na interaktywnych wykresach**

### 💪 Rejestrowanie Ćwiczeń

* **Zapisuj swoje treningi**
* **Przeglądaj i wyszukuj w obszernej bazie ćwiczeń**
* **Śledź postępy treningowe w czasie**

### 💧 Monitorowanie Spożycia Wody

* **Śledź dzienne cele nawodnienia**
* **Proste, szybkie rejestrowanie wody**

### 📏 Pomiary Ciała

* **Rejestruj parametry ciała** (np. waga, talia, ramiona)
* **Dodawaj własne typy pomiarów**
* **Wizualizuj postępy na wykresach**

### 🎯 Ustalanie Celów

* **Ustawiaj i zarządzaj celami fitness i odżywiania**
* **Śledź postępy w czasie**

### 🗓️ Codzienne Raporty

* **Monitoruj codzienną aktywność**
* **Zachowuj regularność dzięki śledzeniu nawyków**

### 🤖 AI Trener Żywieniowy (SparkyAI)

* **Rejestruj jedzenie, ćwiczenia, statystyki ciała i kroki przez czat**
* **Wgrywaj zdjęcia jedzenia, aby automatycznie rejestrować posiłki**
* **Zawiera historię czatu i spersonalizowane wskazówki**

### 🔒 Uwierzytelnianie i Profile Użytkowników

* **Bezpieczny system logowania**
* **Przełączanie między profilami użytkowników**
* **Wsparcie dla dostępu rodzinnego i zarządzania**

### 📊 Rozbudowane Raporty

* **Generuj podsumowania dla odżywiania i parametrów ciała**
* **Śledź długoterminowe trendy na przestrzeni tygodni lub miesięcy**

### 🎨 Personalizowane Motywy

* **Przełączaj się między trybem jasnym a ciemnym**
* **Projekt z minimalistycznym, wolnym od rozpraszaczy interfejsem**

### Potrzebujesz pomocy?
* **Dołącz do Discorda**
  https://discord.gg/vcnMT5cPEA
* **Napisz na forum dyskusyjnym**


![image](https://github.com/user-attachments/assets/ccc7f34e-a663-405f-a4d4-a9888c3197bc)


## 🚀 Pierwsze Kroki

Aby uruchomić aplikację SparkyFitness na swoim komputerze lokalnym, wykonaj poniższe kroki:

### Wymagania wstępne

*   **Projekt Supabase**: Musisz mieć skonfigurowany projekt Supabase.
    *   **Utwórz nowy projekt w Supabase**: Przejdź do [Supabase](https://app.supabase.com/) i utwórz nowy projekt. (Możesz też spróbować skonfigurować lokalny projekt Supabase, jeśli wolisz.)
    *   Uzyskaj adres URL projektu Supabase oraz Anon Key z ustawień projektu (sekcja API).
    *   **Ważna uwaga dotycząca uwierzytelniania Supabase:** Zaktualizuj konfigurację URL w ustawieniach uwierzytelniania Supabase, aby pasowała do Twojej domeny. To kluczowe, aby domena działała i aby otrzymywać zaproszenia e-mailowe do rejestracji. Supabase oferuje zaawansowane opcje bezpieczeństwa i logowania SSO; skonfiguruj je zgodnie z potrzebami projektu.
    *   Automatyczne wdrażanie bazy danych do Supabase nie działa z IPv4 w darmowej wersji Supabase. Musisz skonfigurować swoją sieć do korzystania z połączenia IPv6. W przeciwnym razie migracja bazy danych się nie powiedzie i będziesz musiał wdrożyć ją ręcznie.       


    

### Instalacja

1.  **Skonfiguruj zmienne środowiskowe:**
    Utwórz plik `.env` w folderze prywatnym. Jeśli korzystasz z Portainera, utwórz go bezpośrednio tam. 
    Dodaj swoje dane dostępowe do Supabase:
    ```
    VITE_SUPABASE_URL="TWÓJ_SUPABASE_PROJECT_URL"
    VITE_SUPABASE_ANON_KEY="TWÓJ_SUPABASE_ANON_KEY"
    SUPABASE_PROJECT_REF="TWÓJ_SUPABASE_PROJECT_REF"    
    ```

2.  **Uruchom za pomocą Docker Compose:**
    Pobierz obrazy Dockera i uruchom usługi:
    ```sh
```markdown
    docker compose pull
    docker compose up -d
    ```

3.  **Dostęp do aplikacji:**
    Po uruchomieniu usług, otwórz SparkyFitness w swojej przeglądarce internetowej pod adresem:
    ```
    http://localhost:3000
    ```

4.  **AI Chatbot - Konfiguracja opcjonalna:**
    Aby włączyć pełną funkcjonalność AI Chatbota, w tym bezpieczne przechowywanie kluczy API i dostęp do bazy danych, wykonaj następujące kroki:

    *   **Skonfiguruj `AI_API_ENCRYPTION_KEY`:** Wygeneruj sekret w "Supabase -> Edge Functions" -> "Environment Variables". Ten klucz służy do szyfrowania Twoich kluczy AI podczas ich przechowywania w Supabase.

    *   **Wygeneruj `SUPABASE_ACCESS_TOKEN`:**
        1.  Uzyskaj dostęp do swojej konsoli Dockera.
        2.  Uruchom `supabase login` i uwierzytelnij się przy użyciu podanego URL.
        3.  Pobierz token dostępu, uruchamiając `cat ~/.supabase/access-token`.
        4.  Zaktualizuj swój plik `docker-compose.yml` lub konfigurację Portainera tym tokenem, aby ponownie wdrożyć.
        5.  Po ponownym wdrożeniu zaloguj się do SparkyFitness i skonfiguruj usługę AI z wybranym dostawcą.
     

### Ręczne wdrożenie bazy danych i funkcji do Supabase
**Metoda 1:  
**Jeśli nie masz włączonego połączenia sieciowego IPV6, migracja bazy danych nie powiedzie się, ponieważ darmowa wersja Supabase nie obsługuje bezpośredniego połączenia IPV4.

   1. Pobierz najnowsze wydanie i rozpakuj na swoim komputerze.
   2. Przejdź do folderu projektu. Docker musi być uruchomiony.
   3. Wykonaj poniższe polecenia. (Deploy funkcji jest potrzebny tylko do konfiguracji AI. Jeśli nie potrzebujesz ChatBOTA, możesz to pominąć)
``
      supabase login  
      supabase link  
      supabase db push  
      supabase functions deploy chat   
``
Uruchom ponownie Docker compose. Aplikacja frontendowa zacznie działać.

**Metoda 2:  
   1. Pobierz najnowsze wydanie i rozpakuj na swoim komputerze.  
   2. Przejdź do folderu projektu.  
   3. Przejdź do supabase/migrations. Skopiuj polecenia SQL i uruchamiaj je kolejno w Supabase-->Projekt-->Edytor SQL w kolejności rosnącej (ASC).  
   4. [Opcjonalnie] Zrób to samo dla supabase/functions/chat, jeśli potrzebujesz AI ChatBOTA. Skopiuj index.js i uruchom go w Supabase-->Projekt-->Edge Function-->Deploy new function.  
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---