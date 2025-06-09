![note-gen](https://socialify.git.ci/codexu/note-gen/image?custom_description=Cross-Platform+%7C+LLM+%7C+Markdown+%7C++Recording++%26+Writing&description=1&font=Raleway&forks=1&issues=1&logo=https%3A%2F%2Fcamo.githubusercontent.com%2Fbe4a3a39f8724658ad5bc549d63f0454ad4ca98564c73b7b0778704ca5212509%2F68747470733a2f2f73322e6c6f6c692e6e65742f323032352f30352f32362f594d4e67784b5644724238345a74572e706e67&name=1&owner=1&pattern=Circuit+Board&stargazers=1&theme=Light)

# NoteGen

![](https://github.com/codexu/note-gen/actions/workflows/release.yml/badge.svg?branch=release)
![](https://img.shields.io/github/v/release/codexu/note-gen)
![](https://img.shields.io/badge/version-alpha-orange)
![](https://img.shields.io/github/downloads/codexu/note-gen/total)
![](https://img.shields.io/github/commit-activity/m/codexu/note-gen)

English | [简体中文](.github/README.zh.md) | [日本語](.github/README.ja.md)

<div style="display: flex; gap: 1rem;">
  <a href="https://www.producthunt.com/products/notegen-2?embed=true&utm_source=badge-featured&utm_medium=badge&utm_source=badge-notegen&#0045;2" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=956348&theme=light&t=1749194675492" alt="NoteGen - A&#0032;cross&#0045;platform&#0032;Markdown&#0032;note&#0045;taking&#0032;application | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

  <a href="https://trendshift.io/repositories/12784" target="_blank"><img src="https://trendshift.io/api/badge/repositories/12784" alt="codexu%2Fnote-gen | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>
</div>

## Guía

NoteGen es una aplicación de toma de notas en `Markdown` multiplataforma dedicada a usar IA para unir la grabación y la escritura, organizando el conocimiento fragmentado en una nota legible.

🖥️ Documento oficial: [https://notegen.top](https://notegen.top)

💬 Únete al [Grupo de WeChat/QQ](https://github.com/codexu/note-gen/discussions/110)

## ¿Por qué elegir NoteGen?

- Ligero: El [paquete de instalación](https://github.com/codexu/note-gen/releases) tiene **solo 20MB**, es gratuito y sin anuncios ni software adicional.
- Multiplataforma: Compatible con Mac, Windows, Linux, y gracias a las capacidades multiplataforma de `Tauri2`, en el futuro será compatible con iOS y Android.
- Soporta múltiples métodos de grabación, incluyendo `capturas de pantalla`, `texto`, `ilustraciones`, `archivos`, `enlaces`, etc., cubriendo necesidades de registro fragmentado en diversos escenarios.
- Formato de almacenamiento nativo en `Markdown(.md)`, sin modificaciones, fácil de migrar.
- Uso nativo sin conexión, soporta sincronización en tiempo real con `GitHub, repositorios privados de Gitee` con retroceso de historial, y sincronización WebDAV.
- Mejorado con IA: configurable con ChatGPT, Gemini, Ollama, LM Studio, Grok y otros modelos, con soporte para configuración de modelos de terceros personalizados.
- RAG: Tus notas son tu base de conocimiento. Soporta modelos de embedding y modelos de reranking.

## Capturas de pantalla

https://github.com/user-attachments/assets/4f8a3bc5-17f5-4b36-9b17-d87128685257

Grabación:

![1.png](https://s2.loli.net/2025/05/19/Cs5viKfkqb2HJmd.png)

Escritura:

![2.png](https://s2.loli.net/2025/05/19/5vwQBPoLr6jzgUA.png)

Tema:

![3.png](https://s2.loli.net/2025/05/19/8yU72prmWdsCHeu.png)

## De la grabación a la escritura

Las aplicaciones convencionales de toma de notas generalmente no ofrecen funcionalidad de grabación. Los usuarios deben copiar y pegar manualmente el contenido para grabarlo, lo que reduce mucho la eficiencia. Cuando se enfrentan a contenido grabado disperso, requiere un gran esfuerzo organizarlo.

NoteGen está dividido en las páginas de `Grabación` y `Escritura`, con la siguiente relación:

- Las grabaciones pueden organizarse en notas y transferirse a la página de escritura para una composición más profunda.
- Durante la escritura, puedes insertar grabaciones en cualquier momento.

### Grabación

La función de grabación es similar a un **chatbot de IA**, pero al conversar con él, puedes asociarlo con contenido grabado previamente, cambiando del modo de conversación al modo de organización para organizar las grabaciones en una nota legible.

Las siguientes funciones auxiliares pueden ayudarte a grabar de manera más eficiente:

- **Etiquetas** para distinguir diferentes escenarios de grabación.
- **Personas** con soporte para prompts personalizados para controlar con precisión tu asistente de IA.
- **Asistente de Portapapeles** que reconoce automáticamente texto o imágenes en tu portapapeles y los graba en tu lista.

### Escritura

La sección de escritura se divide en dos partes: **Administrador de Archivos** y **Editor Markdown**.

**Administrador de Archivos**

- Soporta la gestión de archivos Markdown locales y archivos sincronizados con GitHub.
- Soporta jerarquía de directorios ilimitada.
- Soporta múltiples métodos de ordenamiento.

**Editor Markdown**

- Soporta WYSIWYG, renderizado instantáneo y modos de previsualización en pantalla dividida.
- Soporta control de versiones con retroceso de historial.
- Soporta asistencia de IA para conversación, continuación, pulido y funciones de traducción.
- Soporta alojamiento de imágenes, subiendo imágenes y convirtiéndolas en enlaces de imagen en Markdown.
- Soporta conversión de HTML a Markdown, convirtiendo automáticamente el contenido copiado del navegador al formato Markdown.
- Soporta esquemas, fórmulas matemáticas, mapas mentales, gráficos, diagramas de flujo, diagramas de Gantt, diagramas de secuencia, pentagramas, multimedia, lectura en voz alta, anclas de títulos, resaltado y copiado de código, renderizado graphviz y diagramas UML plantuml.
- Soporta guardado en tiempo real del contenido local, sincronización automática retrasada (10s sin editar) y retroceso de historial.

## Otras características

- Búsqueda global para encontrar y saltar rápidamente a contenido específico.
- Gestión de alojamiento de imágenes para administrar convenientemente el contenido del repositorio de imágenes.
- Temas y apariencia con soporte para temas oscuros y configuraciones de apariencia para Markdown, código, etc.
- Soporte de internacionalización, actualmente disponible en chino e inglés.

## ¿Cómo usarlo?

### Descargar

Actualmente compatible con Mac, Windows y Linux. Gracias a las capacidades multiplataforma de Tauri2, en el futuro será compatible con iOS y Android.

[Descargar NoteGen (alpha)](https://github.com/codexu/note-gen/releases)

### Mejoras

La aplicación de notas puede usarse directamente sin configuración. Si deseas una mejor experiencia, por favor abre la página de configuración para configurar la IA y la sincronización.

## Contribuir

- [Leer la guía de contribución](https://raw.githubusercontent.com/codexu/note-gen/dev/.github/CONTRIBUTING.md)
- [Planes de actualización](https://github.com/codexu/note-gen/issues/46)
- [Reportar errores o sugerencias de mejora](https://github.com/codexu/note-gen/issues)
- [Discusiones](https://github.com/codexu/note-gen/discussions)

## Colaboradores

<a href="https://github.com/codexu/note-gen/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=codexu/note-gen" />
</a>

## Historial de estrellas

[![Star History Chart](https://api.star-history.com/svg?repos=codexu/note-gen&type=Date)](https://www.star-history.com/#codexu/note-gen&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---