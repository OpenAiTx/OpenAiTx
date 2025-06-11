# Django Ninja Shortener - Servizio di short link tipo Bitly

Un moderno servizio di short link costruito con Django, Django Ninja e Tailwind CSS, ispirato al design di Bitly.

Gli utenti possono registrarsi e accedere, accorciare URL e tracciare il numero di clic per ciascun short link.

Questo progetto utilizza [Cline](https://github.com/twtrubiks/mcp-vscode-cline?tab=readme-ov-file#cline) come supporto, vedi [.clinerules/01_doc.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/.clinerules/01_doc.md)

## Screenshot

Pagina short link (utilizzabile anche senza registrazione)

![alt tag](https://cdn.imgpile.com/f/qPDKjsy_xl.png)

Se registrato, puoi tracciare i clic

![alt tag](https://cdn.imgpile.com/f/4R3cy01_xl.png)

## ✨ Caratteristiche principali

* **Autenticazione utenti**: supporta registrazione, login e logout.
* **Creazione short link**: gli utenti autenticati possono generare un short link unico da un URL lungo.
* **Redirect short link**: il click su uno short link reindirizza all'URL originale.
* **Tracciamento dei clic**: il sistema conta automaticamente il numero di clic per ogni short link.
* **Dashboard personale**: ogni utente può vedere tutti i propri short link e le statistiche di clic.
* **RESTful API**: fornisce endpoint API per la creazione programmata di short link.
* **Supporto Docker**: fornisce Dockerfile e Docker Compose per semplificare sviluppo e deploy.

## 🛠️ Stack tecnologico

* **Backend framework**: [Django](https://github.com/twtrubiks/django-tutorial)
* **API framework**: [Django Ninja](https://github.com/twtrubiks/django_ninja_tutorial)
* **Stile frontend**: [Tailwind CSS](https://tailwindcss.com/) (integrato con `django-tailwind`)
* **Database**:
  * Ambiente di sviluppo: SQLite (default)
  * Produzione: facilmente sostituibile con PostgreSQL (configurazione già pronta in `settings.py`)
* **Codice short link**: generato con `shortuuid`
* **Testing**: [Pytest](https://github.com/twtrubiks/django_pytest_tutorial)
* **Containerizzazione**: [Docker](https://github.com/twtrubiks/docker-tutorial)

## 🚀 Avvio rapido (con Docker, consigliato)

Questo è il metodo consigliato per garantire la coerenza dell'ambiente di sviluppo.

**Passaggi di avvio:**

1. **Avvia i servizi:**

    Avvia tutti i servizi con un solo comando tramite Docker Compose.

    ```bash
    docker compose up --build
    ```

    Questo comando costruisce l'immagine Docker, installa le dipendenze, esegue la migrazione del database e avvia il server di sviluppo.

2. **Crea un superuser (opzionale):**

    Per accedere a Django Admin, esegui in un altro terminale:

    ```bash
    docker compose exec django-ninja python manage.py createsuperuser
    ```

3. **Accedi all'applicazione:**

    * **Homepage**: [http://localhost:8000](http://localhost:8000)

    * **Documentazione API (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🔧 Sviluppo locale (senza Docker)

Se preferisci configurare l'ambiente localmente.

**Prerequisiti:**

* Python 3.12
* Node.js e npm (necessari per Tailwind CSS)

**Passaggi di configurazione:**

1. **Crea e attiva un ambiente virtuale:**

    ```bash
    python -m venv venv
    source venv/bin/activate  # Su Windows, usa `venv\Scripts\activate`
    ```

2. **Installa le dipendenze Python:**

    ```bash
    pip install -r requirements.txt
    ```

3. **Installa e configura Tailwind CSS:**

    `django-tailwind` gestirà la maggior parte della configurazione.

    ```bash
    python manage.py tailwind install
    ```

    Vedi anche [https://django-tailwind.readthedocs.io/en/latest/installation.html](https://django-tailwind.readthedocs.io/en/latest/installation.html)

4. **Esegui la migrazione del database:**

    ```bash
    python manage.py migrate
    ```

5. **Crea un superuser (opzionale):**

    ```bash
    python manage.py createsuperuser
    ```

6. **Avvia il server di sviluppo:**

    È necessario avviare sia il server Django sia il processo di compilazione di Tailwind CSS.

    ```bash
    python manage.py runserver
    ```

    In un altro terminale:

    ```bash
    python manage.py tailwind start
    ```

7. **Accedi all'applicazione:**

    * **Homepage**: [http://localhost:8000](http://localhost:8000)

    * **Documentazione API (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🧪 Esecuzione dei test

Questo progetto utilizza `pytest` per il testing e il calcolo della copertura del codice.

Il piano di test è consultabile in [TESTING_PLAN.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/TESTING_PLAN.md)

* **Esegui i test con Docker:**

    ```bash
    docker compose --profile test up
    ```

    Il report dei test sarà generato in `htmlcov/index.html`.

* **Esegui i test localmente:**

    ```bash
    # Assicurati di aver installato le dipendenze di sviluppo
    pytest --cov=. --cov-report=html
    ```

![alt tag](https://cdn.imgpile.com/f/UZnApNQ_xl.png)

## 📄 Endpoint API

L'API consente di interagire in modo programmato con il servizio short link. Tutti gli endpoint API sono sotto il percorso `/api/`.

Si consiglia di consultare direttamente la **Documentazione API (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

![alt tag](https://cdn.imgpile.com/f/Foa4p5C_md.png)

Usa [Ninja JWT](https://github.com/twtrubiks/django_ninja_tutorial/tree/main?tab=readme-ov-file#ninja-jwt), prima chiama `/api/token/pair` con username e password per ottenere il tuo token

![alt tag](https://cdn.imgpile.com/f/84ABFA4_xl.png)

Poi inserisci il token in alto a destra e puoi chiamare le API

![alt tag](https://cdn.imgpile.com/f/aCbUddW_md.png)

## 📂 Struttura del progetto

```cmd
ninja_shortener/
├── Dockerfile
├── docker-compose.yml
├── manage.py
├── requirements.txt
├── ninja_shortener/      # Configurazione del progetto Django
│   ├── settings.py
│   └── urls.py
├── shortener/            # Applicazione core degli short link
│   ├── models.py         # Modelli database (Link)
│   ├── api.py            # Endpoint API Django Ninja
│   ├── views.py          # View delle pagine e logica di redirect
│   └── utils.py          # Utility per generazione short code
└── theme/                # Tema Django e template
    ├── templates/        # Template HTML
    └── static_src/       # Sorgenti Tailwind CSS
```

## 💡 Prospettive future

* **Switch a PostgreSQL**: database più robusto per produzione. (Completato)
* **Dashboard analitica dettagliata**: offrire più dati sui clic, come orari, sorgenti, localizzazione, ecc.
* **URL corto personalizzato**: consente agli utenti di personalizzare il codice dell'URL abbreviato.
* **Generazione di QR Code**: genera un QR Code corrispondente per ogni URL abbreviato.
* **Attività asincrone**: utilizza Celery per gestire attività che richiedono tempo, come l'analisi dei dati.

## Donazione

Gli articoli sono tutti frutto delle mie ricerche e originali. Se ti sono stati d'aiuto e vuoi incoraggiarmi, sei il benvenuto ad offrirmi un caffè :laughing:

ECPAY di Green World (non è richiesta la registrazione)

![alt tag](https://payment.ecpay.com.tw/Upload/QRCode/201906/QRCode_672351b8-5ab3-42dd-9c7c-c24c3e6a10a0.png)

[Pagamento del donatore](http://bit.ly/2F7Jrha)

O’Pay (è richiesta la registrazione)

![alt tag](https://i.imgur.com/LRct9xa.png)

[Pagamento del donatore](https://payment.opay.tw/Broadcaster/Donate/9E47FDEF85ABE383A0F5FC6A218606F8)

## Elenco donatori

[Elenco donatori](https://github.com/twtrubiks/Thank-you-for-donate)

## Licenza

Licenza MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---