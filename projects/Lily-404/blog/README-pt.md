
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

# Blog do Jimmy

Um sistema de blog pessoal minimalista construído com Next.js 15+.

## Stack Tecnológica

- **Framework**: Next.js 13+ (App Router)
- **Estilo**: Tailwind CSS
- **Ícones**: Lucide Icons
- **Tema**: Suporte para alternância entre modo claro/escuro
- **Implantação**: Vercel

## Características

- 📝 Suporte para artigos em Markdown
- 🌓 Alternância entre tema claro/escuro
- 📱 Design responsivo
- ⚡ Carregamento rápido
- 📅 Exibição da linha do tempo dos artigos
- 🔐 Painel de administração online (criação direta de artigos via GitHub API)

## Estrutura do projeto

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

## Instalação e Execução

1. Clone o projeto

```bash
git clone https://github.com/Lily-404/blog.git
cd jimmy-blog
```

2. Instalar dependências

```bash
npm install
```

3. Execute o servidor de desenvolvimento

```bash
npm run dev
```

4. Construir a versão de produção

```bash
npm run build
```

## Adicionar novo artigo

### Método 1: Painel de administração online (recomendado)

1. Acesse a página `/admin`
2. Faça login com a senha de administrador
3. Preencha as informações do artigo e envie
4. O artigo será criado automaticamente via GitHub API e o Vercel irá reimplantar automaticamente

### Método 2: Adicionar arquivo manualmente

1. Crie um novo arquivo Markdown no diretório `content/posts`
2. Formato de nome do arquivo: xxx.md`
3. Adicione os metadados no início do arquivo:

```markdown
---
title: 文章标题
date: YYYY-MM-DD
tags: ["标签1","标签2","标签3"]
---
```

## Adicionar uma nota

1. Crie um novo arquivo Markdown no diretório `content/notes`
2. Formato de nome do arquivo: `YYYY-MM-DD-titulo.md`
3. Adicione metadados no início do arquivo:

```markdown
---
date: YYYY-MM-DD
---
```

## Configurando o Painel de Administração

O painel de administração utiliza autenticação via GitHub OAuth, e apenas o proprietário ou colaboradores do repositório podem acessar.

### 1. Criar um GitHub OAuth App

1. Acesse [GitHub Settings > Developer settings > OAuth Apps](https://github.com/settings/developers)
2. Clique em "New OAuth App"
3. Preencha as informações:
   - **Application name**: `Jimmy Blog Admin` (ou qualquer nome)
   - **Homepage URL**: `https://seu-dominio.com` (produção) ou `http://localhost:3000` (desenvolvimento local)
   - **Authorization callback URL**: 
     - Produção: `https://seu-dominio.com/api/auth/github/callback`
     - Desenvolvimento local: `http://localhost:3000/api/auth/github/callback`
4. Clique em "Register application"
5. Anote o **Client ID**
6. Clique em "Generate a new client secret" e anote o **Client secret**

### 2. Configurar variáveis de ambiente

Adicione as seguintes variáveis de ambiente nas configurações do projeto Vercel:

- `GITHUB_CLIENT_ID`: Seu Client ID do GitHub OAuth App
- `GITHUB_CLIENT_SECRET`: Seu Client Secret do GitHub OAuth App
- `GITHUB_OWNER`: Nome de usuário do GitHub (padrão: `Lily-404`, usado para verificar permissões do usuário)
- `GITHUB_REPO`: Nome do repositório (padrão: `blog`)
- `GITHUB_REDIRECT_URI`: URL de callback do OAuth (opcional, padrão gerado automaticamente)
- `NEXT_PUBLIC_BASE_URL`: URL do seu site (usado para gerar a URL de callback, obrigatório em produção)
  - Produção: `https://www.jimmy-blog.top`
  - Desenvolvimento local: `http://localhost:3000`

### 3. Configuração para desenvolvimento local

Crie um arquivo `.env.local` na raiz do projeto:

```env
GITHUB_CLIENT_ID=你的Client_ID
GITHUB_CLIENT_SECRET=你的Client_Secret
GITHUB_OWNER=Lily-404
GITHUB_REPO=blog
NEXT_PUBLIC_BASE_URL=http://localhost:3000
```

### 4. Configuração do ambiente de produção (Vercel)

Nas configurações do projeto Vercel, certifique-se de definir:

```env
NEXT_PUBLIC_BASE_URL=https://www.jimmy-blog.top
```
⚠️ **Atenção**: 
- O arquivo `.env.local` já foi adicionado ao `.gitignore` e não será enviado para o Git
- Durante o desenvolvimento local, certifique-se de que a URL de callback do OAuth App esteja definida como `http://localhost:3000/api/auth/github/callback`
- **No ambiente de produção, é obrigatório definir `NEXT_PUBLIC_BASE_URL` como `https://www.jimmy-blog.top`**
- A URL de callback do OAuth App em produção deve ser: `https://www.jimmy-blog.top/api/auth/github/callback`

## Implantação

O projeto já está configurado para implantação no Vercel, suportando deploy automático. Basta enviar o código para o repositório do GitHub e o Vercel irá construir e implantar automaticamente.

### Vantagens de usar o painel de administração

- ✅ Não é necessário ambiente de desenvolvimento local
- ✅ Adicione artigos a qualquer hora e em qualquer lugar
- ✅ Reimplantação automática do Vercel acionada
- ✅ Completamente gratuito (GitHub OAuth e Vercel dentro do limite gratuito)
- ✅ Seguro (autenticação via GitHub OAuth, apenas o proprietário/colaboradores do repositório têm acesso)
- ✅ Não precisa gerenciar senhas, faça login com sua conta do GitHub

## Contribuição

Envie Issues e Pull Requests!

## Licença

Licença MIT



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---