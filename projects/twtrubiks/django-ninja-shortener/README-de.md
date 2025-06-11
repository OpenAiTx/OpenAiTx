# Django Ninja Shortener - Bitly-ähnlicher Kurz-URL-Dienst

Ein moderner Kurz-URL-Dienst, entwickelt mit Django, Django Ninja und Tailwind CSS, inspiriert von Bitly.

Benutzer können sich registrieren und anmelden, um URLs zu verkürzen und die Klickanzahl jeder Kurz-URL zu verfolgen.

Dieses Projekt nutzt [Cline](https://github.com/twtrubiks/mcp-vscode-cline?tab=readme-ov-file#cline) zur Unterstützung. Siehe [.clinerules/01_doc.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/.clinerules/01_doc.md)

## Screenshots

Kurz-URL-Seite (auch ohne Registrierung nutzbar)

![alt tag](https://cdn.imgpile.com/f/qPDKjsy_xl.png)

Wenn registriert, kann die Klickanzahl verfolgt werden

![alt tag](https://cdn.imgpile.com/f/4R3cy01_xl.png)

## ✨ Funktions-Highlights

* **Benutzerauthentifizierung**: Unterstützung für Benutzerregistrierung, Login und Logout.
* **Kurz-URL-Erstellung**: Angemeldete Benutzer können für eine Lang-URL eine einzigartige Kurz-URL generieren.
* **Kurz-URL-Weiterleitung**: Ein Klick auf die Kurz-URL leitet den Benutzer zur ursprünglichen Lang-URL weiter.
* **Klickzählung**: Das System zählt automatisch die Klicks jeder Kurz-URL.
* **Persönliches Dashboard**: Benutzer können alle eigenen Kurz-URLs und deren Klickstatistiken einsehen.
* **RESTful API**: API-Endpunkte zur programmgesteuerten Erstellung von Kurz-URLs.
* **Docker-Unterstützung**: Dockerfile und Docker Compose-Konfigurationen zur Vereinfachung von Entwicklung und Deployment.

## 🛠️ Technologiestack

* **Backend-Framework**: [Django](https://github.com/twtrubiks/django-tutorial)
* **API-Framework**: [Django Ninja](https://github.com/twtrubiks/django_ninja_tutorial)
* **Frontend-Styling**: [Tailwind CSS](https://tailwindcss.com/) (integriert über `django-tailwind`)
* **Datenbank**:
  * Entwicklungsumgebung: SQLite (Standard)
  * Produktionsumgebung: Einfach ersetzbar durch PostgreSQL (Einstellungen in `settings.py` vorbereitet)
* **Kurz-URL-Code**: Generiert mit `shortuuid`
* **Tests**: [Pytest](https://github.com/twtrubiks/django_pytest_tutorial)
* **Containerisierung**: [Docker](https://github.com/twtrubiks/docker-tutorial)

## 🚀 Schnellstart (mit Docker, empfohlen)

Dies ist die empfohlene Methode, um eine konsistente Entwicklungsumgebung sicherzustellen.

**Startanleitung:**

1. **Dienst starten:**

    Mit Docker Compose alle Dienste mit einem Befehl starten.

    ```bash
    docker compose up --build
    ```

    Dieser Befehl erstellt das Docker-Image, installiert Abhängigkeiten, führt Datenbankmigrationen aus und startet den Entwicklungsserver.

2. **Superuser anlegen (optional):**

    Um Zugriff auf das Django Admin zu erhalten, in einem weiteren Terminalfenster ausführen:

    ```bash
    docker compose exec django-ninja python manage.py createsuperuser
    ```

3. **Anwendung aufrufen:**

    * **Webseite**: [http://localhost:8000](http://localhost:8000)

    * **API-Dokumentation (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🔧 Lokale Entwicklung (ohne Docker)

Wenn du das Projekt lieber lokal einrichtest.

**Voraussetzungen:**

* Python 3.12
* Node.js und npm (für Tailwind CSS)

**Setup-Schritte:**

1. **Virtuelle Umgebung erstellen und aktivieren:**

    ```bash
    python -m venv venv
    source venv/bin/activate  # Unter Windows: `venv\Scripts\activate`
    ```

2. **Python-Abhängigkeiten installieren:**

    ```bash
    pip install -r requirements.txt
    ```

3. **Tailwind CSS installieren und konfigurieren:**

    `django-tailwind` übernimmt den Großteil der Konfiguration.

    ```bash
    python manage.py tailwind install
    ```

    Siehe auch [https://django-tailwind.readthedocs.io/en/latest/installation.html](https://django-tailwind.readthedocs.io/en/latest/installation.html)

4. **Datenbankmigrationen ausführen:**

    ```bash
    python manage.py migrate
    ```

5. **Superuser anlegen (optional):**

    ```bash
    python manage.py createsuperuser
    ```

6. **Entwicklungsserver starten:**

    Django-Server und Tailwind-CSS-Kompilierung müssen parallel laufen.

    ```bash
    python manage.py runserver
    ```

    In einem weiteren Terminalfenster:

    ```bash
    python manage.py tailwind start
    ```

7. **Anwendung aufrufen:**

    * **Webseite**: [http://localhost:8000](http://localhost:8000)

    * **API-Dokumentation (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🧪 Tests ausführen

Dieses Projekt verwendet `pytest` für Tests und zur Messung der Testabdeckung.

Den Test-Plan findest du unter [TESTING_PLAN.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/TESTING_PLAN.md)

* **Tests mit Docker ausführen:**

    ```bash
    docker compose --profile test up
    ```

    Der Testbericht wird unter `htmlcov/index.html` erstellt.

* **Tests lokal ausführen:**

    ```bash
    # Stelle sicher, dass Entwicklungs-Abhängigkeiten installiert sind
    pytest --cov=. --cov-report=html
    ```

![alt tag](https://cdn.imgpile.com/f/UZnApNQ_xl.png)

## 📄 API-Endpunkte

Die API ermöglicht die programmatische Interaktion mit dem Kurz-URL-Dienst. Alle API-Endpunkte sind unter dem Pfad `/api/` verfügbar.

Es wird empfohlen, direkt die **API-Dokumentation (Swagger UI)** zu nutzen: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

![alt tag](https://cdn.imgpile.com/f/Foa4p5C_md.png)

Mit [Ninja JWT](https://github.com/twtrubiks/django_ninja_tutorial/tree/main?tab=readme-ov-file#ninja-jwt) zuerst `/api/token/pair` mit Benutzername und Passwort aufrufen, um dein Token zu erhalten.

![alt tag](https://cdn.imgpile.com/f/84ABFA4_xl.png)

Dann das Token oben rechts einfügen, um die API zu nutzen.

![alt tag](https://cdn.imgpile.com/f/aCbUddW_md.png)

## 📂 Projektstruktur

```cmd
ninja_shortener/
├── Dockerfile
├── docker-compose.yml
├── manage.py
├── requirements.txt
├── ninja_shortener/      # Django-Projekteinstellungen
│   ├── settings.py
│   └── urls.py
├── shortener/            # Kern-Kurz-URL-App
│   ├── models.py         # Datenbankmodell (Link)
│   ├── api.py            # Django Ninja API-Endpunkte
│   ├── views.py          # Seiten-Views und Redirect-Logik
│   └── utils.py          # Werkzeug zur Kurzcode-Generierung
└── theme/                # Django-Theme und Templates
    ├── templates/        # HTML-Templates
    └── static_src/       # Tailwind CSS-Quellcode
```

## 💡 Ausblick

* **Umstellung auf PostgreSQL**: Für produktive Umgebungen auf eine robustere Datenbank wechseln. (bereits umgesetzt)
* **Detailliertes Analyse-Dashboard**: Mehr Klickdaten wie Zeit, Quelle, Geostandort usw. bereitstellen.
* **Benutzerdefinierte Kurz-URL**: Ermöglicht es dem Benutzer, den Code der Kurz-URL selbst festzulegen.
* **QR-Code-Erstellung**: Für jede Kurz-URL wird ein entsprechender QR-Code generiert.
* **Asynchrone Aufgaben**: Zeitaufwändige Aufgaben wie Datenanalyse werden mit Celery verarbeitet.

## Spende

Alle Artikel sind aus meiner eigenen Forschung und Originalarbeit entstanden. Wenn sie Ihnen geholfen haben und Sie mich unterstützen möchten, freue ich mich über eine Tasse Kaffee :laughing:

ECPAY (keine Registrierung erforderlich)

![alt tag](https://payment.ecpay.com.tw/Upload/QRCode/201906/QRCode_672351b8-5ab3-42dd-9c7c-c24c3e6a10a0.png)

[Zahlung durch Unterstützer](http://bit.ly/2F7Jrha)

O'Pay (Mitgliedsregistrierung erforderlich)

![alt tag](https://i.imgur.com/LRct9xa.png)

[Zahlung durch Unterstützer](https://payment.opay.tw/Broadcaster/Donate/9E47FDEF85ABE383A0F5FC6A218606F8)

## Liste der Unterstützer

[Liste der Unterstützer](https://github.com/twtrubiks/Thank-you-for-donate)

## Lizenz

MIT-Lizenz

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---