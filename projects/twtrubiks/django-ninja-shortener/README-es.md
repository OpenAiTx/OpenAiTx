# Django Ninja Shortener - Servicio de URLs cortas tipo Bitly

Un servicio moderno de URLs cortas construido con Django, Django Ninja y Tailwind CSS, inspirado en el diseño de Bitly.

Los usuarios pueden registrarse e iniciar sesión para acortar URLs y rastrear el número de clics de cada URL corta.

Este proyecto utiliza [Cline](https://github.com/twtrubiks/mcp-vscode-cline?tab=readme-ov-file#cline) para ayudar en el desarrollo. Consulta [.clinerules/01_doc.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/.clinerules/01_doc.md)

## Capturas de pantalla

Página de acortador de URLs (se puede usar sin registrarse)

![alt tag](https://cdn.imgpile.com/f/qPDKjsy_xl.png)

Si te registras, puedes rastrear los clics

![alt tag](https://cdn.imgpile.com/f/4R3cy01_xl.png)

## ✨ Características destacadas

* **Autenticación de usuarios**: Soporte para registro, inicio de sesión y cierre de sesión.
* **Crear URLs cortas**: Los usuarios autenticados pueden generar una URL corta única para una URL larga.
* **Redirección de URLs cortas**: Al hacer clic en una URL corta, el usuario será redirigido a la URL larga original.
* **Seguimiento de clics**: El sistema cuenta automáticamente el número de clics de cada URL corta.
* **Panel de usuario**: Los usuarios pueden ver todas sus URLs cortas creadas y las estadísticas de clics.
* **API RESTful**: Proporciona endpoints API para crear URLs cortas de forma programática.
* **Soporte Docker**: Incluye Dockerfile y configuración de Docker Compose para simplificar el desarrollo y el despliegue.

## 🛠️ Stack tecnológico

* **Framework backend**: [Django](https://github.com/twtrubiks/django-tutorial)
* **Framework API**: [Django Ninja](https://github.com/twtrubiks/django_ninja_tutorial)
* **Estilos frontend**: [Tailwind CSS](https://tailwindcss.com/) (integrado mediante `django-tailwind`)
* **Base de datos**:
  * Entorno de desarrollo: SQLite (por defecto)
  * Entorno de producción: Fácil de cambiar a PostgreSQL (la configuración está preparada en `settings.py`)
* **Códigos cortos de URL**: Generados con `shortuuid`
* **Pruebas**: [Pytest](https://github.com/twtrubiks/django_pytest_tutorial)
* **Contenerización**: [Docker](https://github.com/twtrubiks/docker-tutorial)

## 🚀 Inicio rápido (usando Docker, recomendado)

Esta es la forma más recomendada de iniciar, garantiza la consistencia del entorno de desarrollo.

**Pasos para iniciar:**

1. **Iniciar los servicios:**

    Usa Docker Compose para iniciar todos los servicios con un solo comando.

    ```bash
    docker compose up --build
    ```

    Este comando creará la imagen de Docker, instalará las dependencias, ejecutará las migraciones de la base de datos y arrancará el servidor de desarrollo.

2. **Crear un superusuario (opcional):**

    Si deseas acceder al panel de administración de Django, ejecuta en otra terminal:

    ```bash
    docker compose exec django-ninja python manage.py createsuperuser
    ```

3. **Acceder a la aplicación:**

    * **Página principal:** [http://localhost:8000](http://localhost:8000)

    * **Documentación de la API (Swagger UI):** [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🔧 Desarrollo local (sin Docker)

Si prefieres configurar el entorno localmente.

**Requisitos previos:**

* Python 3.12
* Node.js y npm (para Tailwind CSS)

**Pasos de configuración:**

1. **Crear y activar entorno virtual:**

    ```bash
    python -m venv venv
    source venv/bin/activate  # En Windows, usa `venv\Scripts\activate`
    ```

2. **Instalar dependencias de Python:**

    ```bash
    pip install -r requirements.txt
    ```

3. **Instalar y configurar Tailwind CSS:**

    `django-tailwind` gestiona la mayor parte de la configuración.

    ```bash
    python manage.py tailwind install
    ```

    Consulta [https://django-tailwind.readthedocs.io/en/latest/installation.html](https://django-tailwind.readthedocs.io/en/latest/installation.html)

4. **Ejecutar migraciones de base de datos:**

    ```bash
    python manage.py migrate
    ```

5. **Crear superusuario (opcional):**

    ```bash
    python manage.py createsuperuser
    ```

6. **Iniciar el servidor de desarrollo:**

    Debes iniciar tanto el servidor de Django como el proceso de compilación de Tailwind CSS.

    ```bash
    python manage.py runserver
    ```

    En otra terminal:

    ```bash
    python manage.py tailwind start
    ```

7. **Acceder a la aplicación:**

    * **Página principal:** [http://localhost:8000](http://localhost:8000)

    * **Documentación de la API (Swagger UI):** [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🧪 Ejecutar pruebas

Este proyecto utiliza `pytest` para las pruebas y calcula la cobertura.

El plan de pruebas se encuentra en [TESTING_PLAN.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/TESTING_PLAN.md)

* **Ejecutar pruebas con Docker:**

    ```bash
    docker compose --profile test up
    ```

    El reporte de pruebas se generará en `htmlcov/index.html`.

* **Ejecutar pruebas localmente:**

    ```bash
    # Asegúrate de tener las dependencias de desarrollo instaladas
    pytest --cov=. --cov-report=html
    ```

![alt tag](https://cdn.imgpile.com/f/UZnApNQ_xl.png)

## 📄 Endpoints de la API

La API proporciona una forma programática de interactuar con el servicio de URLs cortas. Todos los endpoints de la API están bajo la ruta `/api/`.

Se recomienda acceder directamente a la **Documentación de la API (Swagger UI):** [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

![alt tag](https://cdn.imgpile.com/f/Foa4p5C_md.png)

Usa [Ninja JWT](https://github.com/twtrubiks/django_ninja_tutorial/tree/main?tab=readme-ov-file#ninja-jwt), primero llama a `/api/token/pair` con usuario y contraseña para obtener tu token

![alt tag](https://cdn.imgpile.com/f/84ABFA4_xl.png)

Luego pega el token en la esquina superior derecha para poder llamar a la API

![alt tag](https://cdn.imgpile.com/f/aCbUddW_md.png)

## 📂 Estructura del proyecto

```cmd
ninja_shortener/
├── Dockerfile
├── docker-compose.yml
├── manage.py
├── requirements.txt
├── ninja_shortener/      # Configuración del proyecto Django
│   ├── settings.py
│   └── urls.py
├── shortener/            # Aplicación principal de URLs cortas
│   ├── models.py         # Modelos de base de datos (Link)
│   ├── api.py            # Endpoints de la API Django Ninja
│   ├── views.py          # Vistas y lógica de redirección
│   └── utils.py          # Utilidades para generación de códigos cortos
└── theme/                # Tema y plantillas de Django
    ├── templates/        # Plantillas HTML
    └── static_src/       # Archivos fuente de Tailwind CSS
```

## 💡 Próximas mejoras

* **Cambio a PostgreSQL**: Preparar una base de datos más robusta para producción. (Ya implementado)
* **Panel de análisis detallado**: Proveer más datos sobre los clics, como tiempo, fuente, ubicación geográfica, etc.
* **URL personalizada**: Permite a los usuarios personalizar el código de la URL corta.
* **Generación de código QR**: Genera un código QR correspondiente para cada URL corta.
* **Tareas asíncronas**: Usa Celery para manejar tareas que consumen mucho tiempo, como el análisis de datos.

## Donación

Todos los artículos son originales y resultado de mi propia investigación. Si te han sido de ayuda y deseas animarme, ¡bienvenido a invitarme a un café! :laughing:

ECPAY de Green World (no es necesario registrarse como miembro)

![alt tag](https://payment.ecpay.com.tw/Upload/QRCode/201906/QRCode_672351b8-5ab3-42dd-9c7c-c24c3e6a10a0.png)

[Pago para patrocinadores](http://bit.ly/2F7Jrha)

O'Pay (requiere registro)

![alt tag](https://i.imgur.com/LRct9xa.png)

[Pago para patrocinadores](https://payment.opay.tw/Broadcaster/Donate/9E47FDEF85ABE383A0F5FC6A218606F8)

## Lista de patrocinadores

[Lista de patrocinadores](https://github.com/twtrubiks/Thank-you-for-donate)

## Licencia

Licencia MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---