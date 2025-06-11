# Django Ninja Shortener - Bitly-achtige Korte URL-service

Een moderne korte URL-service gebouwd met Django, Django Ninja en Tailwind CSS, geïnspireerd door Bitly.

Gebruikers kunnen zich registreren en inloggen om een URL te verkorten, en elke korte URL is voorzien van klikstatistieken.

Dit project gebruikt [Cline](https://github.com/twtrubiks/mcp-vscode-cline?tab=readme-ov-file#cline) ter ondersteuning. Zie [.clinerules/01_doc.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/.clinerules/01_doc.md)

## Screenshots

Korte URL-pagina (ook bruikbaar zonder registratie)

![alt tag](https://cdn.imgpile.com/f/qPDKjsy_xl.png)

Na registratie kun je klikken bijhouden

![alt tag](https://cdn.imgpile.com/f/4R3cy01_xl.png)

## ✨ Belangrijkste functionaliteiten

* **Gebruikersauthenticatie**: Ondersteunt gebruikersregistratie, inloggen en uitloggen.
* **Aanmaken van korte URL**: Ingelogde gebruikers kunnen unieke korte URLs aanmaken voor lange URLs.
* **Korte URL redirectie**: Klikken op een korte URL stuurt de gebruiker door naar de originele lange URL.
* **Klikstatistieken**: Het systeem telt automatisch het aantal keren dat op elke korte URL is geklikt.
* **Persoonlijk dashboard**: Gebruikers kunnen alle door henzelf aangemaakte korte URLs en hun klikstatistieken bekijken.
* **RESTful API**: Biedt API-eindpunten voor het programmatisch aanmaken van korte URLs.
* **Docker-ondersteuning**: Bevat Dockerfile en Docker Compose-configuraties voor eenvoudige ontwikkeling en deployment.

## 🛠️ Technische stack

* **Backend framework**: [Django](https://github.com/twtrubiks/django-tutorial)
* **API framework**: [Django Ninja](https://github.com/twtrubiks/django_ninja_tutorial)
* **Frontend styling**: [Tailwind CSS](https://tailwindcss.com/) (geïntegreerd via `django-tailwind`)
* **Database**:
  * Ontwikkelomgeving: SQLite (standaard)
  * Productie: Kan eenvoudig worden vervangen door PostgreSQL (instellingen vooraf gedefinieerd in `settings.py`)
* **Korte URL-code**: gegenereerd met `shortuuid`
* **Testen**: [Pytest](https://github.com/twtrubiks/django_pytest_tutorial)
* **Containerisatie**: [Docker](https://github.com/twtrubiks/docker-tutorial)

## 🚀 Snel starten (met Docker, aanbevolen)

Dit is de aanbevolen methode om te starten, zodat de ontwikkelomgeving consistent is.

**Stappen om te starten:**

1. **Start de service:**

    Start alle services met één commando via Docker Compose.

    ```bash
    docker compose up --build
    ```

    Dit commando bouwt de Docker-image, installeert afhankelijkheden, voert database-migraties uit en start de development server.

2. **Maak een superuser aan (optioneel):**

    Om toegang te krijgen tot Django Admin, voer uit in een extra terminalvenster:

    ```bash
    docker compose exec django-ninja python manage.py createsuperuser
    ```

3. **Toegang tot de applicatie:**

    * **Website-homepage**: [http://localhost:8000](http://localhost:8000)

    * **API-documentatie (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🔧 Lokaal ontwikkelen (zonder Docker)

Als je liever direct lokaal werkt.

**Vereisten:**

* Python 3.12
* Node.js en npm (voor Tailwind CSS)

**Installatiestappen:**

1. **Maak en activeer een virtuele omgeving:**

    ```bash
    python -m venv venv
    source venv/bin/activate  # Op Windows: `venv\Scripts\activate`
    ```

2. **Installeer Python-afhankelijkheden:**

    ```bash
    pip install -r requirements.txt
    ```

3. **Installeer en configureer Tailwind CSS:**

    `django-tailwind` regelt het meeste van de configuratie.

    ```bash
    python manage.py tailwind install
    ```

    Zie ook [https://django-tailwind.readthedocs.io/en/latest/installation.html](https://django-tailwind.readthedocs.io/en/latest/installation.html)

4. **Voer database-migraties uit:**

    ```bash
    python manage.py migrate
    ```

5. **Maak een superuser aan (optioneel):**

    ```bash
    python manage.py createsuperuser
    ```

6. **Start de ontwikkelserver:**

    Je moet zowel de Django-server als het Tailwind CSS-compilatieproces starten.

    ```bash
    python manage.py runserver
    ```

    In een ander terminalvenster:

    ```bash
    python manage.py tailwind start
    ```

7. **Toegang tot de applicatie:**

    * **Website-homepage**: [http://localhost:8000](http://localhost:8000)

    * **API-documentatie (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🧪 Testen uitvoeren

Dit project gebruikt `pytest` voor testen en het meten van testdekking.

Het testplan vind je in [TESTING_PLAN.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/TESTING_PLAN.md)

* **Testen uitvoeren met Docker:**

    ```bash
    docker compose --profile test up
    ```

    Het testrapport wordt gegenereerd in `htmlcov/index.html`.

* **Testen uitvoeren op lokaal systeem:**

    ```bash
    # Zorg dat alle dev dependencies zijn geïnstalleerd
    pytest --cov=. --cov-report=html
    ```

![alt tag](https://cdn.imgpile.com/f/UZnApNQ_xl.png)

## 📄 API-eindpunten

De API maakt het mogelijk om programmatisch met de korte URL-service te werken. Alle API-eindpunten bevinden zich onder het pad `/api/`.

Ga bij voorkeur direct naar de **API-documentatie (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

![alt tag](https://cdn.imgpile.com/f/Foa4p5C_md.png)

Gebruik [Ninja JWT](https://github.com/twtrubiks/django_ninja_tutorial/tree/main?tab=readme-ov-file#ninja-jwt), roep eerst `/api/token/pair` aan met gebruikersnaam en wachtwoord om je token te verkrijgen.

![alt tag](https://cdn.imgpile.com/f/84ABFA4_xl.png)

Plak het token vervolgens rechtsboven om de API te kunnen aanroepen.

![alt tag](https://cdn.imgpile.com/f/aCbUddW_md.png)

## 📂 Projectstructuur

```cmd
ninja_shortener/
├── Dockerfile
├── docker-compose.yml
├── manage.py
├── requirements.txt
├── ninja_shortener/      # Django projectconfiguratie
│   ├── settings.py
│   └── urls.py
├── shortener/            # Kernapplicatie voor korte URLs
│   ├── models.py         # Databasemodellen (Link)
│   ├── api.py            # Django Ninja API-eindpunten
│   ├── views.py          # Paginaviews en redirect-logica
│   └── utils.py          # Hulpmiddelen voor codegeneratie
└── theme/                # Django thema en templates
    ├── templates/        # HTML-templates
    └── static_src/       # Tailwind CSS bronbestanden
```

## 💡 Toekomstige plannen

* **Overschakelen naar PostgreSQL**: Voor een robuustere database in productie. (reeds voltooid)
* **Gedetailleerd analyse-dashboard**: Meer klikstatistieken, zoals tijd, bron, locatie, enz.
* **Aangepaste korte URL**: Staat gebruikers toe om een aangepaste code voor de korte URL te kiezen.
* **QR-code generatie**: Genereert een bijbehorende QR-code voor elke korte URL.
* **Asynchrone taken**: Gebruikt Celery voor het verwerken van tijdrovende taken, zoals data-analyse.

## Donatie

Alle artikelen zijn origineel en gebaseerd op mijn eigen onderzoek. Als het u geholpen heeft en u mij wilt aanmoedigen, trakteer mij gerust op een kopje koffie :laughing:

ECPAY van Green World Technology (Geen registratie vereist)

![alt tag](https://payment.ecpay.com.tw/Upload/QRCode/201906/QRCode_672351b8-5ab3-42dd-9c7c-c24c3e6a10a0.png)

[Donateursbetaling](http://bit.ly/2F7Jrha)

O'Pay (Registratie vereist)

![alt tag](https://i.imgur.com/LRct9xa.png)

[Donateursbetaling](https://payment.opay.tw/Broadcaster/Donate/9E47FDEF85ABE383A0F5FC6A218606F8)

## Lijst van donateurs

[Lijst van donateurs](https://github.com/twtrubiks/Thank-you-for-donate)

## Licentie

MIT-licentie

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---