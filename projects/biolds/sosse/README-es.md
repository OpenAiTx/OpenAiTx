<p>
  <img src="https://raw.githubusercontent.com/biolds/sosse/main/se/static/se/logo.svg" width="64" align="right">
  <a href="https://gitlab.com/biolds1/sosse/" alt="Cobertura de código en Gitlab" style="text-decoration: none">
    <img src="https://img.shields.io/gitlab/pipeline-coverage/biolds1/sosse?branch=main&style=flat-square">
  </a>
  <a href="https://gitlab.com/biolds1/sosse/-/pipelines" alt="Estado de la tubería en Gitlab" style="text-decoration: none">
    <img src="https://img.shields.io/gitlab/pipeline-status/biolds1/sosse?branch=main&style=flat-square">
  </a>
  <a href="https://sosse.readthedocs.io/en/stable/" alt="Documentación" style="text-decoration: none">
    <img src="https://img.shields.io/readthedocs/sosse?style=flat-square">
  </a>
  <a href="https://discord.gg/Vt9cMf7BGK" alt="Discord" style="text-decoration: none">
    <img src="https://img.shields.io/discord/1102142186423844944?style=flat-square&color=%235865f2">
  </a>
  <a href="https://gitlab.com/biolds1/sosse/-/blob/main/LICENSE" alt="Licencia" style="text-decoration: none">
    <img src="https://img.shields.io/gitlab/license/biolds1/sosse?style=flat-square">
  </a>
</p>

# Sosse 🦦

**Descubre Sosse** — el Motor de Búsqueda de Código Abierto basado en Selenium, creado para archivado web potente, rastreo y búsqueda.  
Explora todas sus características y capacidades en el [sitio web oficial](https://sosse.io).

Ya seas desarrollador, investigador o entusiasta de datos, Sosse está listo para apoyar tus proyectos.  
Únete a la comunidad en [GitHub](https://github.com/biolds/sosse) o [GitLab](https://gitlab.com/biolds1/sosse) para enviar solicitudes de funciones, reportar errores, contribuir con código o [iniciar una discusión](https://github.com/biolds/sosse/discussions).

## Características clave

- 🌍 **Búsqueda de Páginas Web**: Busca el contenido de páginas web, incluyendo las renderizadas dinámicamente, con consultas avanzadas.  
  ([doc](https://sosse.readthedocs.io/en/stable/guides/search.html))

- 🕑 **Rastreo Recurrente**: Rastrea páginas a intervalos fijos o adapta la frecuencia según los cambios en el contenido.  
  ([doc](https://sosse.readthedocs.io/en/stable/crawl/policies.html))

- 🔖 **Archivado de Páginas Web**: Archiva contenido HTML, ajusta enlaces para uso local, descarga los recursos necesarios y soporta  
  contenido dinámico. ([doc](https://sosse.readthedocs.io/en/stable/guides/archive.html))

- 🏷️ **Etiquetas**: Organiza y filtra páginas rastreadas o archivadas usando etiquetas para mejorar la búsqueda y gestión.  
  ([doc](https://sosse.readthedocs.io/en/stable/tags.html))
- 📂 **Descargas de Archivos**: Descarga en lote archivos binarios desde páginas web.  
  ([doc](https://sosse.readthedocs.io/en/stable/guides/download.html))

- 📡 **Webhooks**: Integra con servicios externos usando webhooks altamente flexibles. Conéctate a plataformas de IA propietarias  
  ([doc](https://sosse.readthedocs.io/en/stable/guides/ai_api_processing.html)) o soluciones alojadas localmente  
  ([doc](https://sosse.readthedocs.io/en/stable/guides/local_ai.html)) para habilitar extracción avanzada de datos,  
  resumen, auto-etiquetado, notificaciones y más.

- 🔔 **Feeds Atom**: Genera feeds de contenido para sitios web que no los tienen, o recibe actualizaciones cuando se publica una página nueva  
  que contenga una palabra clave.  
  ([doc](https://sosse.readthedocs.io/en/stable/guides/feed_website_monitor.html))

- 🔒 **Autenticación**: El rastreador puede autenticarse para acceder a páginas privadas y recuperar contenido.  
  ([doc](https://sosse.readthedocs.io/en/stable/guides/authentication.html))

- 👥 **Permisos**: Los administradores pueden configurar rastreadores y ver estadísticas, mientras que los usuarios autenticados pueden buscar o hacerlo de forma anónima.  
  ([doc](https://sosse.readthedocs.io/en/stable/permissions.html))

- 👤 **Funciones de Búsqueda**: Incluye historial de búsqueda privado ([doc](https://sosse.readthedocs.io/en/stable/user/history.html)),  
  y accesos directos a motores de búsqueda externos ([doc](https://sosse.readthedocs.io/en/stable/user/shortcuts.html)), etc.

Explora la 📚 [documentación](https://sosse.readthedocs.io/en/stable/index.html) y echa un vistazo a algunas  
📷 [capturas de pantalla](https://sosse.readthedocs.io/en/stable/screenshots.html).

Sosse está escrito en Python y se distribuye bajo la [licencia GNU AGPLv3](https://www.gnu.org/licenses/agpl-3.0.en.html). Usa rastreo basado en navegador con [Mozilla Firefox](https://www.mozilla.org/firefox/) o  
[Google Chromium](https://www.chromium.org/Home) junto con [Selenium](https://www.selenium.dev/) para indexar páginas que dependen de JavaScript. Para un rastreo más rápido, también puede usarse [Requests](https://docs.python-requests.org/en/latest/index.html). Sosse utiliza  
[PostgreSQL](https://www.postgresql.org/) para almacenamiento de datos.

## Pruébalo

Para probar rápidamente la última versión con Docker:


```
docker run -p 8005:80 biolds/sosse:stable
```

Luego, abra [http://127.0.0.1:8005/](http://127.0.0.1:8005/) e inicie sesión con el nombre de usuario `admin` y la contraseña `admin`.

Para la persistencia de datos de Docker o métodos alternativos de instalación, consulte la [guía de instalación](https://sosse.readthedocs.io/en/stable/install.html).

## Mantente Conectado

¡Únete al [servidor de Discord](https://discord.gg/Vt9cMf7BGK) para obtener ayuda, compartir ideas o discutir sobre Sosse!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-29

---