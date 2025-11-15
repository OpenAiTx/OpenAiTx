# Blog de Jimmy

Un sistema de blog personal minimalista construido con Next.js 15+.

## Tecnologías

- **Framework**: Next.js 13+ (App Router)
- **Estilos**: Tailwind CSS
- **Iconos**: Lucide Icons
- **Tema**: Soporta modo oscuro/claro
- **Despliegue**: Vercel

## Características

- 📝 Soporte para artículos en Markdown
- 🌓 Cambio entre tema oscuro y claro
- 📱 Diseño responsivo
- ⚡ Carga rápida
- 📅 Visualización de la línea de tiempo de artículos

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

## Añadir nuevo artículo

1. Crear un nuevo archivo Markdown en el directorio `content/posts`
2. Formato de nombre de archivo: xxx.md`
3. Agregar metadatos en el encabezado del archivo:

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

## 部署

项目已配置 Vercel 部署，支持自动部署。只需将代码推送到 GitHub 仓库，Vercel 会自动构建和部署。

## 贡献

欢迎提交 Issue 和 Pull Request！

## 许可证

MIT License


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---