# Django Ninja Shortener - Bitly-like URL Shortener Service

A modern URL shortener service built with Django, Django Ninja, and Tailwind CSS, inspired by Bitly.

Users can register and log in to shorten URLs and track the number of clicks for each short URL.

This project uses [Cline](https://github.com/twtrubiks/mcp-vscode-cline?tab=readme-ov-file#cline) for assistance. See [.clinerules/01_doc.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/.clinerules/01_doc.md) for reference.

## Screenshots

Short URL page (usable without registration)

![alt tag](https://cdn.imgpile.com/f/qPDKjsy_xl.png)

If registered, click tracking is available

![alt tag](https://cdn.imgpile.com/f/4R3cy01_xl.png)

## ✨ Feature Highlights

* **User Authentication**: Supports user registration, login, and logout.
* **Create Short URLs**: Logged-in users can generate unique short URLs for long URLs.
* **Short URL Redirection**: Clicking a short URL redirects the user to the original long URL.
* **Click Tracking**: The system automatically counts how many times each short URL is clicked.
* **Personal Dashboard**: Users can view all the short URLs they've created and their click statistics.
* **RESTful API**: Provides API endpoints for programmatically creating short URLs.
* **Docker Support**: Offers Dockerfile and Docker Compose configurations to simplify development and deployment.

## 🛠️ Tech Stack

* **Backend Framework**: [Django](https://github.com/twtrubiks/django-tutorial)
* **API Framework**: [Django Ninja](https://github.com/twtrubiks/django_ninja_tutorial)
* **Frontend Styling**: [Tailwind CSS](https://tailwindcss.com/) (integrated via `django-tailwind`)
* **Database**:
  * Development: SQLite (default)
  * Production: Easily switch to PostgreSQL (settings reserved in `settings.py`)
* **Short URL Code**: Generated using `shortuuid`
* **Testing**: [Pytest](https://github.com/twtrubiks/django_pytest_tutorial)
* **Containerization**: [Docker](https://github.com/twtrubiks/docker-tutorial)

## 🚀 Quick Start (Using Docker, Recommended)

This is the most recommended way to get started, ensuring consistency of the development environment.

**Startup Steps:**

1. **Start Services:**

    Use Docker Compose to start all services with one command.

    ```bash
    docker compose up --build
    ```

    This command will build the Docker image, install dependencies, run database migrations, and start the development server.

2. **Create Superuser (Optional):**

    To access Django Admin, run the following in another terminal:

    ```bash
    docker compose exec django-ninja python manage.py createsuperuser
    ```

3. **Access the Application:**

    * **Website Home**: [http://localhost:8000](http://localhost:8000)

    * **API Docs (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🔧 Local Development (Without Docker)

If you prefer setting up the environment directly on your machine.

**Prerequisites:**

* Python 3.12
* Node.js and npm (for Tailwind CSS)

**Setup Steps:**

1. **Create and Activate Virtual Environment:**

    ```bash
    python -m venv venv
    source venv/bin/activate  # On Windows, use `venv\Scripts\activate`
    ```

2. **Install Python Dependencies:**

    ```bash
    pip install -r requirements.txt
    ```

3. **Install and Set Up Tailwind CSS:**

    `django-tailwind` handles most of the setup.

    ```bash
    python manage.py tailwind install
    ```

    See [https://django-tailwind.readthedocs.io/en/latest/installation.html](https://django-tailwind.readthedocs.io/en/latest/installation.html) for reference.

4. **Run Database Migrations:**

    ```bash
    python manage.py migrate
    ```

5. **Create Superuser (Optional):**

    ```bash
    python manage.py createsuperuser
    ```

6. **Start Development Server:**

    You need to start both the Django server and the Tailwind CSS build process.

    ```bash
    python manage.py runserver
    ```

    In another terminal window:

    ```bash
    python manage.py tailwind start
    ```

7. **Access the Application:**

    * **Website Home**: [http://localhost:8000](http://localhost:8000)

    * **API Docs (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🧪 Running Tests

This project uses `pytest` for testing and measuring test coverage.

Testing plan is available at [TESTING_PLAN.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/TESTING_PLAN.md)

* **Run Tests with Docker:**

    ```bash
    docker compose --profile test up
    ```

    Test reports will be generated at `htmlcov/index.html`.

* **Run Tests Locally:**

    ```bash
    # Ensure development dependencies are installed
    pytest --cov=. --cov-report=html
    ```

![alt tag](https://cdn.imgpile.com/f/UZnApNQ_xl.png)

## 📄 API Endpoints

The API provides a programmatic way to interact with the URL shortener service. All API endpoints are under the `/api/` path.

It is recommended to visit the **API Docs (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

![alt tag](https://cdn.imgpile.com/f/Foa4p5C_md.png)

Using [Ninja JWT](https://github.com/twtrubiks/django_ninja_tutorial/tree/main?tab=readme-ov-file#ninja-jwt), first call `/api/token/pair` with your username and password to obtain your token.

![alt tag](https://cdn.imgpile.com/f/84ABFA4_xl.png)

Then paste the token in the upper right corner, and you can call the API.

![alt tag](https://cdn.imgpile.com/f/aCbUddW_md.png)

## 📂 Project Structure

```cmd
ninja_shortener/
├── Dockerfile
├── docker-compose.yml
├── manage.py
├── requirements.txt
├── ninja_shortener/      # Django project settings
│   ├── settings.py
│   └── urls.py
├── shortener/            # Core URL shortener app
│   ├── models.py         # Database models (Link)
│   ├── api.py            # Django Ninja API endpoints
│   ├── views.py          # Page views and redirect logic
│   └── utils.py          # Short code generator utilities
└── theme/                # Django theme and templates
    ├── templates/        # HTML templates
    └── static_src/       # Tailwind CSS sources
```

## 💡 Future Roadmap

* **Switch to PostgreSQL**: Prepare a more robust database for production. (Completed)
* **Detailed Analytics Dashboard**: Provide more click data, such as time, referrer, geographic location, etc.
* **Custom Short URL**: Allows users to customize the code for their short URLs.
* **QR Code Generation**: Generates a corresponding QR Code for each short URL.
* **Asynchronous Tasks**: Uses Celery to handle time-consuming tasks, such as data analysis.

## Donation

All articles are original content that I have researched and internalized. If you found them helpful and would like to encourage me, feel free to buy me a cup of coffee :laughing:

ECPAY (No member registration required)

![alt tag](https://payment.ecpay.com.tw/Upload/QRCode/201906/QRCode_672351b8-5ab3-42dd-9c7c-c24c3e6a10a0.png)

[Sponsor Payment](http://bit.ly/2F7Jrha)

O'Pay (Member registration required)

![alt tag](https://i.imgur.com/LRct9xa.png)

[Sponsor Payment](https://payment.opay.tw/Broadcaster/Donate/9E47FDEF85ABE383A0F5FC6A218606F8)

## Sponsor List

[Sponsor List](https://github.com/twtrubiks/Thank-you-for-donate)

## License

MIT license

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---