<div align="center">
<p>
<img src="https://raw.githubusercontent.com/Liksone/astro-theme-sora/main/docs/logo.svg" alt="logo" height="46" />
</p>
<p>Un tema de blog para Astro</p>
<p>Sora significa "firmamento", simbolizando posibilidades infinitas y una creatividad vasta</p>
<p>¡Si te gusta este tema, considera darle una 🌟Star!</p>
<p><strong>简体中文</strong> | <a href="/README.en.md">English</a></p>
</div>

# Vista previa

[Mi Blog](https://blog.liks.space)

## Quién lo está usando

Te invitamos a enviar un [Issue](https://github.com/Liksone/astro-theme-sora/issues/new?template=addWebsite.yml) para mostrar tu propio sitio web.

# Comenzar

1. Instalar el tema

   - Instala [pnpm](https://pnpm.io/installation)
   - ```bash
     pnpm create astro@latest --template Liksone/astro-theme-sora
     ```

   - Entra al directorio del proyecto y ejecuta `pnpm dev` para iniciar el proyecto

2. Configurar el tema

   Modifica el archivo de configuración `theme.config.ts` para personalizar el tema. Para más detalles, consulta [Configuración](#配置).

3. Editar artículos

   Edita en el directorio `src/content/`, se soporta el formato Markdown.

4. Desplegar el sitio web

   Ejecuta `pnpm build` para compilar el sitio web, el resultado estará en el directorio `dist/`. Puedes ejecutar `pnpm preview` para previsualizar el sitio localmente.

   Despliega el sitio web en tu propio servidor, o consulta la [documentación de Astro](https://docs.astro.build/en/guides/deploy/) para desplegar el sitio en plataformas como Vercel, Netlify, GitHub Pages, entre otras.

<!-- # 文档 -->

# Configuración

El archivo de configuración es `theme.config.ts`.

## Información del sitio

```typescript
site: {
  // Dirección del sitio web
  url: "https://blog.liks.space",
  // Título del sitio web
  title: "Sora",
  // Nombre del administrador
  author: "Liks",
  // Descripción del sitio web
  description: "Un tema de blog construido con Astro",
  // Ícono del sitio web
  // Soporta formatos SVG, PNG, ICO
  // Ruta del archivo local dentro del directorio public/
  favicon: "/images/favicon.ico",
}
```

## Configuración global

```typescript
global: {
  // Avatar
  // Ruta del archivo local dentro del directorio src/images/
  avatar: "avatar.jpg",
  // Habilitar RSS
  rss: true,
  // Habilitar soporte multilenguaje (en desarrollo)
  i18n: true,
}
```

## Barra de navegación

```typescript
nav: [
  {
    // Nombre de la página
    name: "Archivo",
    // Dirección de la página
    url: "/archives",
  },
  {
    name: "Categorías",
    url: "/categories",
  },
  {
    name: "Etiquetas",
    url: "/tags",
  },
  {
    name: "Acerca de",
    url: "/about",
  },
  ...
];
```

## Pie de página

```typescript
footer: {
  // Derechos de autor
  copyright: {
    // Tiempo de creación del sitio
    time: "2024 - 2025",
    // Propietario
    owner: "Liks",
  },
  // Registro (específico para China)
  beian: {
    // Registro ICP
    icp: {
      // Habilitar
      enabled: false,
      // Número de registro
      number: "京 ICP 备 12345678 号",
    },
    // Registro de la policía
    police: {
      // Habilitar
      enabled: false,
      // Número de registro
      number: "京公网安备 12345678901234 号",
      // URL del registro
      url: "https://beian.mps.gov.cn/webcode=?",
    },
  },
}
```

## Página principal

```typescript
index: {
  // Redes sociales
  social: [
    {
      // Nombre
      name: "GitHub",
      // Habilitar
      enabled: true,
      // URL
      url: "https://github.com/Liksone",
    },
    ...
  ],
}
```

Soporta BiliBili, Email, Facebook, GitHub, Instagram, QQ, Telegram, Twitter/X, YouTube, Weibo, Xiaohongshu, Zhihu.

## Página de artículo

```typescript
post: {
  // Licencia de derechos de autor
  copyright: {
    // Licencia CC
    CCLicense: {
      BY: true,
      NC: true,
      SA: true,
      ND: false,
    },
    // URL de la licencia
    url: "https://creativecommons.org/licenses/by-nc-sa/4.0",
  },
}
```

## Patrocinar

```typescript
sponsor: {
  // Habilitar
  enabled: true,
  // Código QR de Alipay
  alipay: {
    // Habilitar
    enabled: true,
    // Ruta del archivo local dentro del directorio src/images/
    image: "alipay.png",
  },
  // Código QR de WeChat
  wechat: {
    enabled: false,
  },
  // Mostrar lista de patrocinadores
  list: true,
}
```

## Comentarios

```typescript
comment: {
  // Habilitar
  enabled: false,
  // Artalk - https://artalk.js.org
  artalk: {
    enabled: false,
    // Dirección del servidor backend
    server: "https://artalk.example.com",
    // Nombre del sitio
    site: "Sora",
  },
}
```

## Herramientas

```typescript
tools: {
  // Umami - https://umami.is
  umami: {
    // Habilitar
    enabled: false,
    // Dirección del servidor
    src: "https://cloud.umami.is",
    // data-website-id
    websiteID: "c26d92e7-d859-43be-991c-5a5dd0503eb9",
  },
}
```


# Licencia

[Licencia Pública General GNU v3.0](https://github.com/Liksone/astro-theme-sora/blob/main/LICENSE)

# Agradecimientos

- [Pedro-null/halo-theme-hingle2.0](https://github.com/Pedro-null/halo-theme-hingle2.0)
- [Aziteee/halo-theme-lapis](https://github.com/Aziteee/halo-theme-lapis)
- [纸鹿摸鱼处](https://blog.zhilu.cyou/)
- [HowieHz/halo-theme-higan-hz](https://github.com/HowieHz/halo-theme-higan-hz)
- [saicaca/fuwari](https://github.com/saicaca/fuwari)
- [radishzzz/astro-theme-retypeset](https://github.com/radishzzz/astro-theme-retypeset)
- [EveSunMaple/Frosti](https://github.com/EveSunMaple/Frosti)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---