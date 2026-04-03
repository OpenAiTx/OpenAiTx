
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

# Blog de Jimmy

Un sistema de blog personal minimalista construido con Next.js 15+, que soporta creación en línea y despliegue estático.

## Stack tecnológico

- **Framework**: Next.js 15+ (App Router)
- **Lenguaje**: TypeScript
- **Estilos**: Tailwind CSS
- **Iconos**: Lucide Icons
- **Contenido**: Markdown + Gray Matter + Remark
- **Autenticación**: GitHub OAuth
- **Despliegue**: Vercel

## Características

### Lado lector

- 📝 Renderizado de artículos Markdown + GFM (incluye visualización de fórmulas matemáticas)
- 🏷️ Filtrado por etiquetas, paginación, archivo (por año/etiqueta)
- 📚 Navegación por tabla de contenidos (TOC) y copia de bloques de código con un clic
- 📱 Diseño responsivo y cambio entre temas claro/oscuro
- 🔥 Mapa de calor flotante de calendario de creación (artículos + ensayos)
- 📡 Salida de suscripción RSS (`/rss.xml`)

### Lado creador (panel de administración)

- 🔐 Inicio de sesión con GitHub OAuth (verificación de permisos de propietario/colaborador)
- ✍️ Creación, edición y eliminación en línea de artículos/ensayos
- 🆔 ID de archivo personalizado + prevención automática de conflictos
- 👀 Tres modos de escritura: editar / vista previa / pantalla dividida
- 📊 Panel de estadísticas de creación (total, producción semanal/mensual, etiquetas populares)

### Lado ingeniería

- ⚡ Salida estática multipágina (`force-static`) para mejorar rendimiento y estabilidad
- 🧭 Sitemap y robots integrados
- 🧩 Caché de lectura de contenido y estructura API modular

## Estructura del proyecto

```
.
├── app/               # 页面、API 路由、Server Actions
│   ├── api/           # 接口（OAuth、统计、校验、Markdown 等）
│   ├── actions/       # 内容管理相关服务端动作
│   ├── posts/         # 文章详情页
│   └── page.tsx       # 首页
├── content/
│   ├── notes/         # 随笔
│   └── posts/         # 文章
├── components/        # React 组件
├── public/            # 静态资源
└── styles/            # 全局样式
```

## Instalación y ejecución

1. Clonar el proyecto

```bash
git clone https://github.com/Lily-404/blog.git
cd jimmy-blog
```
2. Instalación de dependencias


```bash
npm install
```
3.  Ejecutar el servidor de desarrollo


```bash
npm run dev
```
4. Construcción de la versión de producción


```bash
npm run build
```

## Añadir un nuevo artículo

### Método 1: Panel de administración en línea (recomendado)

1. Accede a la página `/admin`
2. Inicia sesión usando GitHub OAuth
3. Completa la información del artículo y envíala
4. El artículo se creará automáticamente a través de la API de GitHub y Vercel se volverá a desplegar automáticamente

### Método 2: Añadir archivos manualmente

1. Crea un nuevo archivo Markdown en el directorio `content/posts`
2. Formato de nombre de archivo: `xxx.md`
3. Añade metadatos en la cabecera del archivo:

```markdown
---
title: 文章标题
date: YYYY-MM-DD
tags: ["标签1","标签2","标签3"]
---
```

## Añadir ensayo

1. Crear un nuevo archivo Markdown en el directorio `content/notes`
2. Formato de nombrado del archivo: `YYYY-MM-DD-title.md`
3. Añadir metadatos al encabezado del archivo:

```markdown
---
date: YYYY-MM-DD
---
```

## Configuración del panel de administración

El panel de administración utiliza GitHub OAuth para la autenticación, solo el propietario del repositorio o los colaboradores pueden acceder.

### 1. Crear una aplicación OAuth de GitHub

1. Visita [Configuración de GitHub > Configuración de desarrollador > Aplicaciones OAuth](https://github.com/settings/developers)
2. Haz clic en "New OAuth App"
3. Completa la información:
   - **Nombre de la aplicación**: `Jimmy Blog Admin` (o cualquier nombre)
   - **URL de la página principal**: `https://tu-dominio.com` (entorno de producción) o `http://localhost:3000` (desarrollo local)
   - **URL de devolución de llamada de autorización**: 
     - Producción: `https://tu-dominio.com/api/auth/github/callback`
     - Desarrollo local: `http://localhost:3000/api/auth/github/callback`
4. Haz clic en "Register application"
5. Registra el **Client ID**
6. Haz clic en "Generate a new client secret", registra el **Client secret**

### 2. Configuración de variables de entorno

Agrega las siguientes variables de entorno en la configuración del proyecto Vercel:

- `GITHUB_CLIENT_ID`: Tu Client ID de la aplicación OAuth de GitHub
- `GITHUB_CLIENT_SECRET`: Tu Client Secret de la aplicación OAuth de GitHub
- `GITHUB_OWNER`: Nombre de usuario de GitHub (por defecto: `Lily-404`, usado para verificar permisos de usuario)
- `GITHUB_REPO`: Nombre del repositorio (por defecto: `blog`)
- `GITHUB_REDIRECT_URI`: URL de devolución de llamada OAuth (opcional, se genera automáticamente por defecto)
- `NEXT_PUBLIC_BASE_URL`: URL de tu sitio web (usada para generar la URL de devolución de llamada, debe configurarse en producción)
  - Producción: `https://www.jimmy-blog.top`
  - Desarrollo local: `http://localhost:3000`

### 3. Configuración para desarrollo local

Crea un archivo `.env.local` en el directorio raíz del proyecto:

```env
GITHUB_CLIENT_ID=你的Client_ID
GITHUB_CLIENT_SECRET=你的Client_Secret
GITHUB_OWNER=Lily-404
GITHUB_REPO=blog
NEXT_PUBLIC_BASE_URL=http://localhost:3000
```

### 4. Configuración del entorno de producción (Vercel)

En la configuración del proyecto de Vercel, asegúrese de establecer:

```env
NEXT_PUBLIC_BASE_URL=https://www.jimmy-blog.top
```

⚠️ **Nota**: 
- El archivo `.env.local` ya está añadido a `.gitignore` y no se subirá a Git
- Durante el desarrollo local, asegúrate de que la URL de callback del OAuth App esté configurada como `http://localhost:3000/api/auth/github/callback`
- **En producción, debes configurar `NEXT_PUBLIC_BASE_URL` como `https://www.jimmy-blog.top`**
- La URL de callback del OAuth App en producción debe ser: `https://www.jimmy-blog.top/api/auth/github/callback`

## Despliegue

El proyecto está configurado para desplegarse en Vercel, con soporte para despliegue automático. Solo tienes que hacer push del código al repositorio de GitHub y Vercel lo construirá y desplegará automáticamente.

### Ventajas de usar el panel de administración

- ✅ No necesitas un entorno de desarrollo local
- ✅ Agrega artículos en cualquier momento y lugar
- ✅ Vercel se vuelve a desplegar automáticamente
- ✅ Completamente gratis (GitHub OAuth y Vercel dentro del plan gratuito)
- ✅ Seguro (autenticación por GitHub OAuth, solo propietarios/colaboradores del repo pueden acceder)
- ✅ Sin gestión de contraseñas, inicia sesión con tu cuenta de GitHub
- ✅ Soporta edición en línea de contenido existente (no solo nuevos)
- ✅ Manejo automático de conflictos de ID de archivos, evita sobrescribir o renombrar manualmente
- ✅ El panel incluye estadísticas de creación, facilitando la operación continua de contenido

## Análisis del proyecto y planificación futura

- Documento de análisis del proyecto: [`docs/project-analysis.md`](https://raw.githubusercontent.com/Lily-404/blog/main/docs/project-analysis.md)
- Documento de planificación futura: [`docs/future-roadmap.md`](https://raw.githubusercontent.com/Lily-404/blog/main/docs/future-roadmap.md)

## Contribuciones

¡Bienvenidas las Issues y Pull Requests!

## Licencia

MIT License


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---