<div align="center">
<p>
<img src="https://raw.githubusercontent.com/Liksone/astro-theme-sora/main/docs/logo.svg" alt="logo" height="46" />
</p>
<p>Um tema de blog Astro</p>
<p>Sora significa "céu abobadado", simbolizando possibilidades infinitas e grande criatividade</p>
<p>Se você gostou deste tema, deixe uma 🌟Estrela!</p>
<p><strong>简体中文</strong> | <a href="https://raw.githubusercontent.com/Liksone/astro-theme-sora/main/README.en.md">English</a></p>
</div>

# Pré-visualização

[Meu Blog](https://blog.liks.space)

## Quem está usando

Sinta-se à vontade para abrir uma [Issue](https://github.com/Liksone/astro-theme-sora/issues/new?template=addWebsite.yml) para mostrar o seu site.

# Começando

1. Instale o tema

   - Instale o [pnpm](https://pnpm.io/installation)
   - ```bash
     pnpm create astro@latest --template Liksone/astro-theme-sora
     ```

   - Entre no diretório do projeto e execute `pnpm dev` para iniciar o projeto

2. Configure o tema

   Modifique o arquivo de configuração `theme.config.ts` para personalizar o tema. Veja mais em [Configuração](#配置).

3. Edite artigos

   Edite na pasta `src/content/`, com suporte ao formato Markdown.

4. Implante o site

   Execute `pnpm build` para construir o site. O resultado será gerado na pasta `dist/`. Você pode executar `pnpm preview` para pré-visualizar o site localmente.

   Implemente o site manualmente no seu servidor, ou siga a [documentação do Astro](https://docs.astro.build/en/guides/deploy/) para implantar em plataformas como Vercel, Netlify, GitHub Pages, etc.

<!-- # 文档 -->

# Configuração

O arquivo de configuração é `theme.config.ts`.

## Informações do site

```typescript
site: {
  // Endereço do site
  url: "https://blog.liks.space",
  // Título do site
  title: "Sora",
  // Nome do autor
  author: "Liks",
  // Descrição do site
  description: "Um tema de blog construído com Astro",
  // Ícone do site
  // Suporta formatos SVG, PNG e ICO
  // Caminho do arquivo local dentro do diretório public/
  favicon: "/images/favicon.ico",
}
```

## Configurações globais

```typescript
global: {
  // Avatar
  // Caminho do arquivo local dentro do diretório src/images/
  avatar: "avatar.jpg",
  // Ativar RSS
  rss: true,
  // Ativar suporte multilíngue (em desenvolvimento)
  i18n: true,
}
```

## Barra de navegação

```typescript
nav: [
  {
    // Nome da página
    name: "Arquivo",
    // Endereço da página
    url: "/archives",
  },
  {
    name: "Categorias",
    url: "/categories",
  },
  {
    name: "Tags",
    url: "/tags",
  },
  {
    name: "Sobre",
    url: "/about",
  },
  ...
];
```

## Rodapé

```typescript
footer: {
  // Direitos autorais
  copyright: {
    // Ano de criação
    time: "2024 - 2025",
    // Proprietário dos direitos autorais
    owner: "Liks",
  },
  // Registro (exclusivo para a China)
  beian: {
    // Registro ICP
    icp: {
      // Ativar
      enabled: false,
      // Número do registro
      number: "京 ICP 备 12345678 号",
    },
    // Registro da polícia
    police: {
      // Ativar
      enabled: false,
      // Número do registro
      number: "京公网安备 12345678901234 号",
      // URL do registro
      url: "https://beian.mps.gov.cn/webcode=?",
    },
  },
}
```

## Página inicial

```typescript
index: {
  // Mídias sociais
  social: [
    {
      // Nome
      name: "GitHub",
      // Ativar
      enabled: true,
      // URL
      url: "https://github.com/Liksone",
    },
    ...
  ],
}
```

Suporta BiliBili, Email, Facebook, GitHub, Instagram, QQ, Telegram, Twitter/X, YouTube, Weibo, Xiaohongshu, Zhihu.

## Página do artigo

```typescript
post: {
  // Licença de direitos autorais
  copyright: {
    // Licença CC
    CCLicense: {
      BY: true,
      NC: true,
      SA: true,
      ND: false,
    },
    // URL da licença
    url: "https://creativecommons.org/licenses/by-nc-sa/4.0",
  },
}
```

## Patrocínio

```typescript
sponsor: {
  // Ativar
  enabled: true,
  // QR code do Alipay
  alipay: {
    // Ativar
    enabled: true,
    // Caminho do arquivo local dentro do diretório src/images/
    image: "alipay.png",
  },
  // QR code do WeChat
  wechat: {
    enabled: false,
  },
  // Exibir lista de patrocinadores
  list: true,
}
```

## Comentários

```typescript
comment: {
  // Ativar
  enabled: false,
  // Artalk - https://artalk.js.org
  artalk: {
    enabled: false,
    // Endereço do servidor backend
    server: "https://artalk.example.com",
    // Nome do site
    site: "Sora",
  },
}
```

## Ferramentas

```typescript
tools: {
  // Umami - https://umami.is
  umami: {
    // Ativar
    enabled: false,
    // Endereço do servidor
    src: "https://cloud.umami.is",
    // data-website-id
    websiteID: "c26d92e7-d859-43be-991c-5a5dd0503eb9",
  },
}
```


# Licença

[Licença Pública Geral GNU v3.0](https://github.com/Liksone/astro-theme-sora/blob/main/LICENSE)

# Agradecimentos

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