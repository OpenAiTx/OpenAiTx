# Django Ninja Shortener - Service de raccourcissement d’URL type Bitly

Un service moderne de raccourcissement d’URL construit avec Django, Django Ninja et Tailwind CSS, inspiré par Bitly.

Les utilisateurs peuvent s’inscrire et se connecter, raccourcir des URLs, et suivre le nombre de clics sur chaque URL courte.

Ce projet utilise [Cline](https://github.com/twtrubiks/mcp-vscode-cline?tab=readme-ov-file#cline) pour faciliter le développement. Voir [.clinerules/01_doc.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/.clinerules/01_doc.md)

## Captures d’écran

Page de raccourcissement d’URL (accessible même sans inscription)

![alt tag](https://cdn.imgpile.com/f/qPDKjsy_xl.png)

Avec un compte, vous pouvez suivre les clics

![alt tag](https://cdn.imgpile.com/f/4R3cy01_xl.png)

## ✨ Points forts des fonctionnalités

* **Authentification utilisateur** : Prise en charge de l’inscription, connexion et déconnexion utilisateur.
* **Création de liens courts** : Les utilisateurs connectés peuvent générer une URL courte unique pour une URL longue.
* **Redirection de liens courts** : Cliquer sur un lien court redirige vers l’URL d’origine.
* **Suivi des clics** : Le système compte automatiquement le nombre de clics pour chaque lien court.
* **Tableau de bord personnel** : Les utilisateurs peuvent voir tous leurs liens courts créés et les statistiques de clics.
* **API RESTful** : Des endpoints API permettent de créer des liens courts de manière programmatique.
* **Support Docker** : Fournit un Dockerfile et une configuration Docker Compose pour simplifier le développement et le déploiement.

## 🛠️ Pile technologique

* **Framework backend** : [Django](https://github.com/twtrubiks/django-tutorial)
* **Framework API** : [Django Ninja](https://github.com/twtrubiks/django_ninja_tutorial)
* **Style frontend** : [Tailwind CSS](https://tailwindcss.com/) (intégré via `django-tailwind`)
* **Base de données** :
  * Environnement de développement : SQLite (par défaut)
  * Production : Peut être facilement remplacé par PostgreSQL (configuration prévue dans `settings.py`)
* **Code de lien court** : Généré avec `shortuuid`
* **Tests** : [Pytest](https://github.com/twtrubiks/django_pytest_tutorial)
* **Conteneurisation** : [Docker](https://github.com/twtrubiks/docker-tutorial)

## 🚀 Démarrage rapide (avec Docker, recommandé)

C’est la méthode la plus recommandée pour garantir la cohérence de l’environnement de développement.

**Étapes de lancement :**

1. **Démarrer les services :**

    Utilisez Docker Compose pour lancer tous les services d’un seul coup.

    ```bash
    docker compose up --build
    ```

    Cette commande va construire l’image Docker, installer les dépendances, effectuer les migrations de la base de données, puis démarrer le serveur de développement.

2. **Créer un superutilisateur (optionnel) :**

    Pour accéder à Django Admin, exécutez dans un autre terminal :

    ```bash
    docker compose exec django-ninja python manage.py createsuperuser
    ```

3. **Accéder à l’application :**

    * **Page d’accueil du site** : [http://localhost:8000](http://localhost:8000)

    * **Documentation API (Swagger UI)** : [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🔧 Développement local (sans Docker)

Si vous préférez configurer l’environnement localement.

**Prérequis :**

* Python 3.12
* Node.js et npm (pour Tailwind CSS)

**Étapes de configuration :**

1. **Créer et activer un environnement virtuel :**

    ```bash
    python -m venv venv
    source venv/bin/activate  # Sous Windows, utilisez `venv\Scripts\activate`
    ```

2. **Installer les dépendances Python :**

    ```bash
    pip install -r requirements.txt
    ```

3. **Installer et configurer Tailwind CSS :**

    `django-tailwind` gère la plupart des configurations.

    ```bash
    python manage.py tailwind install
    ```

    Voir [https://django-tailwind.readthedocs.io/en/latest/installation.html](https://django-tailwind.readthedocs.io/en/latest/installation.html)

4. **Exécuter les migrations de la base de données :**

    ```bash
    python manage.py migrate
    ```

5. **Créer un superutilisateur (optionnel) :**

    ```bash
    python manage.py createsuperuser
    ```

6. **Démarrer le serveur de développement :**

    Vous devez lancer à la fois le serveur Django et le processus de compilation Tailwind CSS.

    ```bash
    python manage.py runserver
    ```

    Dans un autre terminal :

    ```bash
    python manage.py tailwind start
    ```

7. **Accéder à l’application :**

    * **Page d’accueil du site** : [http://localhost:8000](http://localhost:8000)

    * **Documentation API (Swagger UI)** : [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🧪 Exécuter les tests

Le projet utilise `pytest` pour les tests et calcule la couverture.

Le plan de tests est disponible ici : [TESTING_PLAN.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/TESTING_PLAN.md)

* **Exécuter les tests avec Docker :**

    ```bash
    docker compose --profile test up
    ```

    Un rapport de test sera généré dans `htmlcov/index.html`.

* **Exécuter les tests en local :**

    ```bash
    # Assurez-vous d’avoir installé les dépendances de développement
    pytest --cov=. --cov-report=html
    ```

![alt tag](https://cdn.imgpile.com/f/UZnApNQ_xl.png)

## 📄 Endpoints API

L’API permet d’interagir avec le service de raccourcissement d’URL de manière programmatique. Tous les endpoints API sont sous le chemin `/api/`.

Il est recommandé d’aller directement à la **documentation API (Swagger UI)** : [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

![alt tag](https://cdn.imgpile.com/f/Foa4p5C_md.png)

Avec [Ninja JWT](https://github.com/twtrubiks/django_ninja_tutorial/tree/main?tab=readme-ov-file#ninja-jwt), appelez d’abord `/api/token/pair` avec vos identifiants pour obtenir votre token

![alt tag](https://cdn.imgpile.com/f/84ABFA4_xl.png)

Ensuite, collez le token en haut à droite pour pouvoir appeler les endpoints de l’API

![alt tag](https://cdn.imgpile.com/f/aCbUddW_md.png)

## 📂 Structure du projet

```cmd
ninja_shortener/
├── Dockerfile
├── docker-compose.yml
├── manage.py
├── requirements.txt
├── ninja_shortener/      # Configuration du projet Django
│   ├── settings.py
│   └── urls.py
├── shortener/            # Application principale de raccourcissement
│   ├── models.py         # Modèles de base de données (Link)
│   ├── api.py            # Endpoints API Django Ninja
│   ├── views.py          # Vues de pages et logique de redirection
│   └── utils.py          # Outils de génération de codes courts
└── theme/                # Thème Django et templates
    ├── templates/        # Templates HTML
    └── static_src/       # Sources Tailwind CSS
```

## 💡 Perspectives futures

* **Basculer sur PostgreSQL** : Prévoir une base de données plus robuste pour la production. (déjà fait)
* **Tableau de bord analytique détaillé** : Fournir plus de données sur les clics, comme l’heure, la source, la localisation, etc.
* **URL courte personnalisée** : permet aux utilisateurs de personnaliser le code de leur URL courte.
* **Génération de QR Code** : génère un QR Code correspondant pour chaque URL courte.
* **Tâches asynchrones** : utilise Celery pour traiter les tâches longues, comme l'analyse de données.

## Donation

Tous les articles sont des créations originales issues de mes propres recherches et réflexions. Si cela vous a été utile et que vous souhaitez m’encourager, vous pouvez m’offrir un café :laughing:

ECPAY (pas besoin de créer un compte)

![alt tag](https://payment.ecpay.com.tw/Upload/QRCode/201906/QRCode_672351b8-5ab3-42dd-9c7c-c24c3e6a10a0.png)

[Effectuer un don](http://bit.ly/2F7Jrha)

O'Pay (nécessite la création d’un compte)

![alt tag](https://i.imgur.com/LRct9xa.png)

[Effectuer un don](https://payment.opay.tw/Broadcaster/Donate/9E47FDEF85ABE383A0F5FC6A218606F8)

## Liste des sponsors

[Liste des sponsors](https://github.com/twtrubiks/Thank-you-for-donate)

## License

MIT license

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---