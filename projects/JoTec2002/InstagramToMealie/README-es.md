# InstagramToMealie

Un pequeño conversor sencillo, que importa una URL de Instagram a Mealie

<p align="center">
    <img src="https://raw.githubusercontent.com/PKief/vscode-material-icon-theme/ec559a9f6bfd399b82bb44393651661b08aaf7ba/icons/folder-markdown-open.svg" align="center" width="30%">
</p>
<p align="center"><h1 align="center">INSTAGRAM A MEALIE</h1></p>

<p align="center">
	<img src="https://img.shields.io/github/license/JoTec2002/InstagramToMealie?style=default&logo=opensourceinitiative&logoColor=white&color=0080ff" alt="license">
	<img src="https://img.shields.io/github/last-commit/JoTec2002/InstagramToMealie?style=default&logo=git&logoColor=white&color=0080ff" alt="last-commit">
	<img src="https://img.shields.io/github/languages/top/JoTec2002/InstagramToMealie?style=default&color=0080ff" alt="repo-top-language">
	<img src="https://img.shields.io/github/languages/count/JoTec2002/InstagramToMealie?style=default&color=0080ff" alt="repo-language-count">
</p>
<br>

## Tabla de Contenidos

- [Descripción General](#overview)
- [Primeros Pasos](#getting-started)
    - [Prerequisitos](#prerequisites)
    - [Instalación](#installation)
    - [Uso](#usage)
    - [Configuración](#configuration)
- [Contribuir](#contributing)
- [Licencia](#license)
- [Agradecimientos](#acknowledgments)

---

## Descripción General

Con InstagramToMealie, puedes simplemente ingresar una URL de una publicación de Instagram. El proyecto se integra perfectamente con la API de Mealie para
crear una nueva receta con una imagen o video asociado.

---

## Primeros Pasos

### Requisitos Previos

1. Asegúrate de tener OpenAI / Ollama configurado en Mealie navegando a `/admin/debug/openai` en tu instancia de Mealie. Este proyecto no se integra directamente con OpenAI / Ollama, pero necesita que esté configurado en Mealie para funcionar correctamente. Personalmente obtuve los mejores resultados con `qwen2.5:7b` como Modelo Ollama.  
2. Genera una Clave API de Mealie (`/user/profile/api-tokens`). [Documentación de Mealie](https://docs.mealie.io/documentation/getting-started/api-usage/)  
3. Genera un Archivo de Sesión de Instagram (!ese es el paso más complicado). Se proporciona un [script auxiliar](https://raw.githubusercontent.com/JoTec2002/InstagramToMealie/refs/heads/main/helpers/instaloader_login_helper.py) en este repositorio. Simplemente está  
   copiado de la [Documentación de Instaloader](https://instaloader.github.io/troubleshooting.html).  
    1. Descarga el script: [https://raw.githubusercontent.com/JoTec2002/InstagramToMealie/refs/heads/main/helpers/instaloader_login_helper.py](https://raw.githubusercontent.com/JoTec2002/InstagramToMealie/refs/heads/main/helpers/instaloader_login_helper.py)  
    2. Inicia sesión en Instagram con Firefox  
    3. Ejecuta el fragmento: `python ./instaloader_login_helper.py`  
    4. Copia el archivo que generó el script a una ubicación conocida. Este archivo se montará después en el contenedor Docker. Puede generarse en un sistema diferente y luego copiarse al sistema destino.  

### Instalación

Instala InstagramToMealie usando uno de los siguientes métodos:

**Construir desde la fuente:**  
<details closed>

1. Clona el repositorio InstagramToMealie:

```sh
❯ git clone https://github.com/JoTec2002/InstagramToMealie
```
2. Navegue al directorio del proyecto:


```sh
❯ cd InstagramToMealie
```

3. Instale las dependencias del proyecto:

```sh
❯ pip install -r requirements.txt
```

4. Inicie el servidor:

```sh
❯ python -u main.py
```

</details>

**Utilice la imagen de Docker proporcionada en [jotec2002/instagramtomealie](https://hub.docker.com/repository/docker/jotec2002/instagramtomealie/general)**

Despliegue mediante Docker Compose junto con su instalación de Mealie

Ejemplo de archivo `compose.yaml` usando un archivo de sesión para autenticar:

```yaml
services:
  mealie:
    image: ghcr.io/mealie-recipes/mealie:v2.1.0
    container_name: mealie
    #Look up in the Mealie Docs for how to use Mealie
  InstagramToMealie:
    image: jotec2002/instagramtomealie
    ports:
      - 9001:9001
    environment:
      INSTA_USER: "instagram username"
      MEALIE_API_KEY: "MEALIE API KEY"
      MEALIE_URL: "YOU LOCAL MEALIE INSTALLATION" # e.g http://mealie:9000
      MEALIE_OPENAI_REQUEST_TIMEOUT: 60           # Optional, default: 60
    volumes:
      - ./session-file:/app/session-file        # The Instagram session file you created in the Prerequisites
    depends_on:
      mealie:
        condition: service_healthy
```

Archivo `compose.yaml` de ejemplo que utiliza variables de entorno de nombre de usuario y contraseña para autenticarse:

> [!IMPORTANT]
> **La autenticación de dos factores (TFA/TOTP) debe estar desactivada en la cuenta para que este método funcione.**
> Probablemente necesitarás varios intentos para que esto funcione. Inicia sesión en otros sistemas/IPs en paralelo para no activar la detección de bots de Instagram.
> Esta no es la forma recomendada de configurar InstagramToMealie.

```yaml
services:
  mealie:
    image: ghcr.io/mealie-recipes/mealie:v2.1.0
    container_name: mealie
    #Look up in the Mealie Docs for how to use Mealie
  InstagramToMealie:
    image: jotec2002/instagramtomealie
    ports:
      - 9001:9001
    environment:
      INSTA_USER: "instagram username"
      INSTA_PWD: "Cleartext Instagram password"
      MEALIE_API_KEY: "MEALIE API KEY"
      MEALIE_URL: "YOU LOCAL MEALIE INSTALLATION" # e.g http://mealie:9000
      MEALIE_OPENAI_REQUEST_TIMEOUT: 60           # Optional, default: 60
      MEALIE_USE_INSTAGRAM_TAGS: true
```

**Construyendo la imagen de Docker usted mismo**

Configure igual que cuando usa la imagen de Docker proporcionada, pero reemplace con lo siguiente en `compose.yaml`:

```diff
services:
  mealie:
    image: ghcr.io/mealie-recipes/mealie:v2.1.0
    container_name: mealie
    #Look up in the Mealie Docs for how to use Mealie
  InstagramToMealie:
+   build:
+     context: .
+     dockerfile: Dockerfile
+   image: instagramtomealie:latest
    ports:
      - 9001:9001
```

### Uso

1. Ábrelo en un navegador web (por ejemplo, `http://instagramtomealie.my-server.com`) y simplemente importa la URL de Instagram en el campo de texto
2. Llama desde una automatización (por ejemplo, un atajo de IOS) a la url `http://instagramtomealie.my-server.com?url=<InstagramURL>`
3. Si necesitas una API que responda con el resultado de la importación, usa `POST http://instagramtomealie.my-server.com/api` enviando la URL ya sea en el cuerpo de la solicitud en formato JSON (preferido, `{"url": "<InstagramURL>"}`) o como un parámetro de consulta (ver el punto anterior). La API responde un JSON en el formato:
```json
{
  "recipe_slug": <imported recipe slug>,
  "error": <error message if any error>,
  "url": <Instagram URL which was imported>
}
```

### Configuración

```env
MEALIE_URL:                          # Full URL of your Mealie instance (e.g http://mealie:9000, http://192.168.1.2:9000, http://my-mealie.com), required.
MEALIE_API_KEY:                      # API key used to authenticate with the Mealie REST API, required.
MEALIE_OPENAI_REQUEST_TIMEOUT: 60    # The timeout in seconds for OpenAI / Ollama requests, optional, default 60.
MEALIE_USE_INSTAGRAM_TAGS: true      # Embeds tags provided on the Instagram post as tags in Mealie, optional, default true.
INSTA_USER:                          # Instagram username (e.g mob_kitchen), required.
INSTA_PWD:                           # Instagram password in plaintext, optional (if using a session file).
INSTA_TOTP_SECRET:                   # Secret key used for 2FA authentication, optional, not recommended.
HTTP_PORT:                           # Port to use for the Flask HTTP server, optional, default 9001
```

---

## Contribuyendo

- **💬 [Únete a las discusiones](https://github.com/JoTec2002/InstagramToMealie/discussions)**: Comparte tus ideas, proporciona
  comentarios o haz preguntas.
- **🐛 [Reporta problemas](https://github.com/JoTec2002/InstagramToMealie/issues)**: Envía errores encontrados o registra solicitudes de
  funciones para el proyecto `InstagramToMealie`.
- **💡 [Envía solicitudes de extracción](https://github.com/JoTec2002/InstagramToMealie/blob/main/CONTRIBUTING.md)**: Revisa las PR abiertas,
  y envía tus propias PRs.

<details closed>
<summary>Gráfico de colaboradores</summary>
<br>
<p align="left">
   <a href="https://github.com{/JoTec2002/InstagramToMealie/}graphs/contributors">
      <img src="https://contrib.rocks/image?repo=JoTec2002/InstagramToMealie">
   </a>
</p>
</details>

---

## Licencia

Este proyecto está protegido bajo la Licencia MIT. Para más detalles,
consulta el archivo [LICENSE](https://choosealicense.com/licenses/).

---

## Agradecimientos

- [Mealie](https://github.com/mealie-recipes/mealie/)
- [Instadownloader](https://github.com/instaloader/instaloader)

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-25

---