
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
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Blog de Jimmy

Un sistema de blog personal minimalista construido sobre Next.js 15+.

## Stack tecnológico

- **Framework**: Next.js 13+ (App Router)
- **Estilos**: Tailwind CSS
- **Iconos**: Lucide Icons
- **Tema**: Soporta cambio entre modo claro/oscuro
- **Despliegue**: Vercel

## Características

- 📝 Soporte para artículos en Markdown
- 🌓 Cambio entre tema claro/oscuro
- 📱 Diseño responsivo
- ⚡ Carga rápida
- 📅 Visualización de la línea de tiempo de artículos
- 🔐 Panel de administración en línea (creación directa de artículos mediante la API de GitHub)

## Estructura del proyecto

```
.
├── app/
│   ├── lib/           # 工具函数和数据处理
│   ├── posts/         # 博客文章
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
2. Inicia sesión con la contraseña de administrador
3. Rellena la información del artículo y envíala
4. El artículo se creará automáticamente a través de la API de GitHub y Vercel realizará el despliegue automáticamente

### Método 2: Añadir archivos manualmente

1. Crea un nuevo archivo Markdown en el directorio `content/posts`
2. Formato de nombre de archivo: xxx.md`
3. Añade los metadatos en la cabecera del archivo:

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
- El archivo `.env.local` ya está añadido a `.gitignore`, por lo que no se subirá a Git
- Durante el desarrollo local, asegúrate de que la URL de callback de la app OAuth esté configurada como `http://localhost:3000/api/auth/github/callback`
- **En producción, se debe establecer `NEXT_PUBLIC_BASE_URL` como `https://www.jimmy-blog.top`**
- La URL de callback de la app OAuth en producción debe configurarse como: `https://www.jimmy-blog.top/api/auth/github/callback`

## Despliegue

El proyecto está configurado para desplegarse en Vercel, soportando despliegue automático. Solo tienes que enviar el código al repositorio de GitHub y Vercel construirá y desplegará automáticamente.

### Ventajas de usar el panel de administración

- ✅ No necesitas un entorno de desarrollo local
- ✅ Puedes añadir artículos en cualquier momento y lugar
- ✅ Despliegue en Vercel se reactiva automáticamente
- ✅ Completamente gratuito (GitHub OAuth y Vercel dentro del plan gratuito)
- ✅ Seguro (verificación de GitHub OAuth, solo el propietario/colaboradores del repositorio pueden acceder)
- ✅ No necesitas gestionar contraseñas, solo inicia sesión con tu cuenta de GitHub

## Contribuciones

¡Bienvenidos a enviar Issues y Pull Requests!

## Licencia

Licencia MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---