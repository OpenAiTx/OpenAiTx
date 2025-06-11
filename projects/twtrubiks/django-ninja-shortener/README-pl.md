# Django Ninja Shortener - Usługa skracania linków à la Bitly

Nowoczesna usługa skracania linków zbudowana na Django, Django Ninja i Tailwind CSS, inspirowana Bitly.

Użytkownicy mogą się zarejestrować i zalogować, skracać linki oraz śledzić liczbę kliknięć dla każdego skróconego adresu.

Projekt korzysta z [Cline](https://github.com/twtrubiks/mcp-vscode-cline?tab=readme-ov-file#cline) do automatyzacji, więcej informacji w [.clinerules/01_doc.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/.clinerules/01_doc.md)

## Zrzuty ekranu

Strona skracania linków (dostępna bez rejestracji)

![alt tag](https://cdn.imgpile.com/f/qPDKjsy_xl.png)

Po rejestracji można śledzić kliknięcia

![alt tag](https://cdn.imgpile.com/f/4R3cy01_xl.png)

## ✨ Najważniejsze funkcje

* **Uwierzytelnianie użytkownika**: Obsługa rejestracji, logowania i wylogowania.
* **Tworzenie krótkich linków**: Zalogowani użytkownicy mogą generować unikalne skrócone adresy URL dla długich linków.
* **Przekierowanie krótkiego linku**: Kliknięcie w skrócony link przekierowuje użytkownika do oryginalnego adresu URL.
* **Śledzenie liczby kliknięć**: System automatycznie zlicza liczbę kliknięć dla każdego skróconego linku.
* **Osobisty panel użytkownika**: Użytkownik może przeglądać wszystkie utworzone przez siebie skrócone linki i ich statystyki kliknięć.
* **RESTful API**: Udostępnione są punkty końcowe API do programowego generowania skróconych linków.
* **Wsparcie dla Dockera**: Dostarczony Dockerfile i konfiguracja Docker Compose upraszczają rozwój i wdrożenie.

## 🛠️ Stos technologiczny

* **Backend**: [Django](https://github.com/twtrubiks/django-tutorial)
* **API**: [Django Ninja](https://github.com/twtrubiks/django_ninja_tutorial)
* **Frontend**: [Tailwind CSS](https://tailwindcss.com/) (zintegrowany przez `django-tailwind`)
* **Baza danych**:
  * Środowisko deweloperskie: SQLite (domyślnie)
  * Produkcja: Łatwo można przełączyć na PostgreSQL (konfiguracja w `settings.py`)
* **Generator krótkich kodów**: `shortuuid`
* **Testy**: [Pytest](https://github.com/twtrubiks/django_pytest_tutorial)
* **Konteneryzacja**: [Docker](https://github.com/twtrubiks/docker-tutorial)

## 🚀 Szybki start (z Dockerem - zalecane)

To najbardziej zalecana metoda uruchomienia, gwarantuje spójność środowiska deweloperskiego.

**Kroki uruchomienia:**

1. **Uruchomienie usługi:**

    Użyj Docker Compose do jednoczesnego uruchomienia wszystkich usług.

    ```bash
    docker compose up --build
    ```

    Polecenie to zbuduje obraz Dockera, zainstaluje zależności, wykona migracje bazy danych i uruchomi serwer developerski.

2. **Utworzenie konta superużytkownika (opcjonalnie):**

    Aby uzyskać dostęp do Django Admin, w innym terminalu uruchom:

    ```bash
    docker compose exec django-ninja python manage.py createsuperuser
    ```

3. **Dostęp do aplikacji:**

    * **Strona główna**: [http://localhost:8000](http://localhost:8000)

    * **Dokumentacja API (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🔧 Rozwój lokalny (bez Dockera)

Jeśli wolisz skonfigurować środowisko lokalnie.

**Wymagania:**

* Python 3.12
* Node.js i npm (do obsługi Tailwind CSS)

**Kroki konfiguracji:**

1. **Utworzenie i aktywacja wirtualnego środowiska:**

    ```bash
    python -m venv venv
    source venv/bin/activate  # Na Windows: `venv\Scripts\activate`
    ```

2. **Instalacja zależności Pythona:**

    ```bash
    pip install -r requirements.txt
    ```

3. **Instalacja i konfiguracja Tailwind CSS:**

    `django-tailwind` zajmie się większością konfiguracji.

    ```bash
    python manage.py tailwind install
    ```

    Szczegóły: [https://django-tailwind.readthedocs.io/en/latest/installation.html](https://django-tailwind.readthedocs.io/en/latest/installation.html)

4. **Wykonanie migracji bazy danych:**

    ```bash
    python manage.py migrate
    ```

5. **Tworzenie konta superużytkownika (opcjonalnie):**

    ```bash
    python manage.py createsuperuser
    ```

6. **Uruchomienie serwera developerskiego:**

    Musisz uruchomić zarówno serwer Django, jak i kompilację Tailwind CSS.

    ```bash
    python manage.py runserver
    ```

    W osobnym terminalu:

    ```bash
    python manage.py tailwind start
    ```

7. **Dostęp do aplikacji:**

    * **Strona główna**: [http://localhost:8000](http://localhost:8000)

    * **Dokumentacja API (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🧪 Uruchamianie testów

Projekt wykorzystuje `pytest` do testów oraz generuje raport pokrycia.

Plan testów: [TESTING_PLAN.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/TESTING_PLAN.md)

* **Testy w Dockerze:**

    ```bash
    docker compose --profile test up
    ```

    Raport z testów zostanie zapisany w `htmlcov/index.html`.

* **Testy lokalnie:**

    ```bash
    # Upewnij się, że zainstalowano zależności developerskie
    pytest --cov=. --cov-report=html
    ```

![alt tag](https://cdn.imgpile.com/f/UZnApNQ_xl.png)

## 📄 Punkty końcowe API

API umożliwia programową integrację ze skracaczem linków. Wszystkie endpointy dostępne są pod ścieżką `/api/`.

Zalecamy korzystać bezpośrednio z **dokumentacji API (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

![alt tag](https://cdn.imgpile.com/f/Foa4p5C_md.png)

Użyj [Ninja JWT](https://github.com/twtrubiks/django_ninja_tutorial/tree/main?tab=readme-ov-file#ninja-jwt), najpierw wywołaj `/api/token/pair` z loginem i hasłem, aby uzyskać swój token

![alt tag](https://cdn.imgpile.com/f/84ABFA4_xl.png)

Następnie wklej token w prawym górnym rogu, aby móc korzystać z API

![alt tag](https://cdn.imgpile.com/f/aCbUddW_md.png)

## 📂 Struktura projektu

```cmd
ninja_shortener/
├── Dockerfile
├── docker-compose.yml
├── manage.py
├── requirements.txt
├── ninja_shortener/      # Konfiguracja projektu Django
│   ├── settings.py
│   └── urls.py
├── shortener/            # Główna aplikacja skracacza linków
│   ├── models.py         # Modele bazy danych (Link)
│   ├── api.py            # Punkty końcowe API Django Ninja
│   ├── views.py          # Widoki i logika przekierowania
│   └── utils.py          # Narzędzia do generowania krótkich kodów
└── theme/                # Motyw Django i szablony
    ├── templates/        # Szablony HTML
    └── static_src/       # Źródła Tailwind CSS
```

## 💡 Plany na przyszłość

* **Przełączenie na PostgreSQL**: Solidniejsza baza danych dla środowiska produkcyjnego. (zrealizowano)
* **Szczegółowy panel analityczny**: Więcej danych o kliknięciach, np. czas, źródło, lokalizacja itp.
* **Niestandardowy krótki URL**: Pozwala użytkownikom na dostosowanie kodu krótkiego adresu URL.
* **Generowanie kodu QR**: Generuje odpowiadający kod QR dla każdego krótkiego adresu URL.
* **Zadania asynchroniczne**: Używa Celery do obsługi czasochłonnych zadań, takich jak analiza danych.

## Darowizna

Wszystkie artykuły są mojego autorstwa, powstały na podstawie moich badań i doświadczeń. Jeśli były dla Ciebie pomocne i chcesz mnie wesprzeć, zapraszam na kawę :laughing:

ECPAY (brak konieczności rejestracji)

![alt tag](https://payment.ecpay.com.tw/Upload/QRCode/201906/QRCode_672351b8-5ab3-42dd-9c7c-c24c3e6a10a0.png)

[Płatność dla darczyńców](http://bit.ly/2F7Jrha)

O'Pay (wymagana rejestracja)

![alt tag](https://i.imgur.com/LRct9xa.png)

[Płatność dla darczyńców](https://payment.opay.tw/Broadcaster/Donate/9E47FDEF85ABE383A0F5FC6A218606F8)

## Lista darczyńców

[Lista darczyńców](https://github.com/twtrubiks/Thank-you-for-donate)

## Licencja

MIT license

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---