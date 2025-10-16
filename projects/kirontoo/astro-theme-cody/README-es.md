<a name="readme-top"></a>
<div align="center">
  
[![Contribuidores][contributors-shield]][contributors-url]
[![Bifurcaciones][forks-shield]][forks-url]
[![Estrellas][stars-shield]][stars-url]
[![Problemas][issues-shield]][issues-url]
[![Licencia MIT][license-shield]][license-url]
[![Estado Netlify](https://api.netlify.com/api/v1/badges/3d9506ce-9212-47ae-b686-fb932a24f940/deploy-status)](https://app.netlify.com/sites/astro-theme-cody/deploys)  

<a href='https://ko-fi.com/F1F2J3RV9' target='_blank'><img height='36' style='border:0px;height:36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=6' border='0' alt='Buy Me a Coffee at ko-fi.com' /></a>


  <p align="center">
    <h1>Astro Theme Cody</h1>
  <p>
    Un tema de blog minimalista construido con Astro. Una construcción rápida y fácil para cualquiera que quiera comenzar su propio blog.
  </p>
    <a href="https://astro-theme-cody.netlify.app">Ver Demo</a>
    ·
    <a href="https://github.com/kirontoo/astro-theme-cody/issues">Reportar Error</a>
    ·
    <a href="https://github.com/kirontoo/astro-theme-cody/issues">Solicitar Función</a>
  </p>
  </p>
</div>

![demo-preview](https://github.com/kirontoo/astro-theme-cody/assets/28286622/d585dcb2-6d5f-4a68-871c-b6028cfcc27f)


## Tabla de Contenidos
- [Motivación](#motivation)
- [Características Clave](#key-features)
- [Demo](#demo)
- [Inicio Rápido](#quick-start)
- [Comandos](#commands)
- [Configurando Tu Sitio Web](#configuring-your-website)
  - [Configuración del Sitio, Enlaces de Redes Sociales y Enlaces de la Barra de Navegación](#site-config-social-media-links-and-navbar-links)
  - [Añadiendo Publicaciones y Proyectos](#adding-posts-and-projects)
  - [Soporte Multilenguaje](#multi-language-support)
- [Desplegar](#deploy)
- [Funcionalidad Extra](#extra-funtionality)
- [Crédito](#credit)

## Motivación
Aunque ya existen muchos temas para blogs, quería uno que transmitiera
esa vibra de terminal/desarrollador y algunas características que otros temas no tenían.

## Características Clave:
- Astro v4 Rápido 🚀
- Clases utilitarias de TailwindCSS
- Marcado HTML accesible y semántico
- Adaptable y amigable con SEO
- Soporte multilingüe
- Modo oscuro / claro, usando Tailwind y variables CSS
- Publicaciones y proyectos fijados
- [Integración de Astro Assets](https://docs.astro.build/en/guides/assets/) para imágenes optimizadas
- Publicaciones MD y [MDX](https://docs.astro.build/en/guides/markdown-content/#mdx-only-features)
- Paginación
- Búsqueda en publicaciones con [PageFind](https://pagefind.app/)
- [RSS automático](https://docs.astro.build/en/guides/rss)
- [Mapa del sitio](https://docs.astro.build/en/guides/integrations-guide/sitemap/) auto-generado
- Componente de íconos svg [Astro Icon](https://github.com/natemoo-re/astro-icon)
- Botón Volver Arriba

## Demo
Mira la demo [aquí](https://astro-theme-cody.netlify.app).

## Inicio Rápido
[Crea un nuevo repositorio](https://github.com/new?template_name=astro-theme-cody&template_owner=kirontoo) desde esta plantilla.

```
# npm 7+
npm create astro@latest -- --template kirontoo/astro-theme-cody

# pnpm
pnpm dlx create-astro --template kirontoo/astro-theme-cody
```
<p align="right">(<a href="#readme-top">volver arriba</a>)</p>


## Comandos

Todos los comandos se ejecutan desde la raíz del proyecto, en una terminal:

| Comando                   | Acción                                           |
| :------------------------ | :----------------------------------------------- |
| `pnpm install`             | Instala dependencias                            |
| `pnpm run dev`             | Inicia el servidor local de desarrollo en `localhost:4321`      |
| `pnpm run build`           | Construye tu sitio de producción en `./dist/`          |
| `pnpm run preview`         | Previsualiza tu compilación localmente, antes de desplegar     |
| `pnpm run astro ...`       | Ejecuta comandos CLI como `astro add`, `astro check` |
| `pnpm run astro -- --help` | Obtén ayuda usando la CLI de Astro                     |

<p align="right">(<a href="#readme-top">volver arriba</a>)</p>

## Configurando Tu Sitio Web

### Configuración del Sitio, Enlaces de Redes Sociales y Enlaces de la Barra de Navegación
La configuración de tu sitio, enlaces de redes sociales y enlaces de la barra de navegación están todos ubicados en [`src/consts.ts`](https://github.com/kirontoo/astro-theme-cody/blob/main/src/consts.ts).
Ahí puedes configurar el título predeterminado de tu sitio, descripción, idioma, perfil, enlaces de redes sociales y enlaces visibles en la barra de navegación.

### Añadiendo Posts y Proyectos
Este tema utiliza [ Colecciones de Contenido ](https://docs.astro.build/en/guides/content-collections/) 
para organizar archivos Markdown y/o MDX, así como la comprobación de tipos en el frontmatter 
mediante un esquema -> `src/content/config.ts`.

Puedes encontrar ejemplos de posts en `src/content/blog` y ejemplos de proyectos en `src/content/project`.

#### Frontmatter de posts de blog
| Propiedad (* = obligatorio) | Descripción |
|:---------------------------| :---------- |
| title * | Título de tu post. Limitado a un máximo de 150 caracteres  |
| description * | Descripción corta de tu post, que también se usará para SEO. Tiene un máximo de 250 caracteres. |
| pubDate * | Fecha de publicación |
| updateDate | Fecha opcional que representa cuándo se actualizó el post. Ten en cuenta que esta fecha se usará en lugar de la fecha de publicación para ordenar los posts cuando esté disponible.|
| heroImage | Imagen de portada opcional para tu post. Incluye tanto una propiedad `src` como `alt`. Consulta `src/content/blog/first-post.md` para un ejemplo.|

| ogImage | Imagen opcional usada para SEO. |
| tags | Usa etiquetas opcionales para organizar tus publicaciones en categorías o temas. Todas las etiquetas se mostrarán en `tudominio.com/tags`. |
| series | Usa series opcionales para organizar tus publicaciones en una serie de posts. Todas las series se mostrarán en `tudominio.com/series`. |
| draft | Booleano opcional. Elimina publicaciones para que no se publiquen.|
| order | Valor numérico opcional del 1 al 5 para fijar ciertas publicaciones en la parte superior. Limitado a solo 5 publicaciones fijadas|
| hide  | Booleano opcional. Oculta una publicación en la página `/blog`. Aún aparecerá en `/archive`|

#### Frontmatter del proyecto

| Propiedad (* = requerido) | Descripción |
|:-----------------------| :----------|
| title * | Título de tu proyecto. Limitado a un máximo de 150 caracteres  |
| description * | Descripción corta de tu proyecto, que también se usará para SEO.|
| pubDate * | Fecha de publicación |
| heroImage | Imagen de portada opcional para tu proyecto. Incluye tanto una propiedad `src` como `alt`. Consulta `src/pages/projects/project-1.md` para un ejemplo.|
| ogImage | Imagen opcional usada para SEO. |
| stack * | Lista de tecnologías usadas en tu proyecto que se mostrarán como íconos. Este tema usa la librería SVG Logos, puedes usar [icones.js.org](https://icones.js.org/collection/vscode-icons) para encontrar los íconos que necesitas.|
| platform | Enlace al sitio web o demo |
| website | Enlace al sitio web o demo |
| github | Enlace a tu repositorio de github |
| draft | Booleano opcional. Elimina proyectos para que no se publiquen.|
| order | Valor numérico opcional del 1 al 5 para fijar ciertos proyectos en la parte superior. Limitado a solo 5 proyectos fijados|

<p align="right">(<a href="#readme-top">volver arriba</a>)</p>

### Soporte Multilenguaje
Consulta la [wiki](https://github.com/kirontoo/astro-theme-cody/wiki/Set-up-multi%E2%80%90language-support) para configurar soporte multilenguaje para tu blog.

## Despliegue
Astro ofrece excelente documentación para desplegar tus sitios Astro en varias plataformas.
Puedes encontrarla [aquí](https://docs.astro.build/en/guides/deploy/).

## Funcionalidad Extra
Consulta [Astro Recipes](https://docs.astro.build/en/recipes/) para agregar otras funcionalidades como un feed RSS.


## Créditos

Este tema se basa en el tema [Astro Cactus](https://astro-theme-cactus.netlify.app) y [Hugo Risotto](https://risotto.joeroe.io).

<p align="right">(<a href="#readme-top">volver arriba</a>)</p>

[contributors-shield]: https://img.shields.io/github/contributors/kirontoo/astro-theme-cody.svg?style=for-the-badge
[contributors-url]: https://github.com/kirontoo/astro-theme-cody/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/kirontoo/astro-theme-cody.svg?style=for-the-badge
[forks-url]: https://github.com/kirontoo/astro-theme-cody/network/members
[stars-shield]: https://img.shields.io/github/stars/kirontoo/astro-theme-cody.svg?style=for-the-badge
[stars-url]: https://github.com/kirontoo/astro-theme-cody/stargazers
[issues-shield]: https://img.shields.io/github/issues/kirontoo/astro-theme-cody.svg?style=for-the-badge
[issues-url]: https://github.com/kirontoo/astro-theme-cody/issues
[license-shield]: https://img.shields.io/github/license/kirontoo/astro-theme-cody.svg?style=for-the-badge
[license-url]: https://github.com/kirontoo/astro-theme-cody/blob/master/LICENSE.txt


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---