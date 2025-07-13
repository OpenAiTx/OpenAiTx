<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

<p align="center">
  <a href="https://www.jukeboxhq.com">
    <img height="500" src="https://raw.githubusercontent.com/skeptrunedev/jukebox/main/frontend/public/opengraph-image.jpg" alt="Trieve Logo">
  </a>
</p>

<p align="center">
  <a href="https://hub.docker.com/r/skeptrune/jukebox-server" style="text-decoration: none;">
    <img src="https://img.shields.io/docker/pulls/skeptrune/jukebox-server?style=flat-square" alt="Docker Pulls" />
  </a>
  <a href="https://github.com/skeptrunedev/jukebox/stargazers" style="text-decoration: none;">
    <img src="https://img.shields.io/github/stars/skeptrunedev/jukebox?style=flat-square" alt="GitHub stars" />
  </a>
  <a href="https://x.com/skeptrune" style="text-decoration: none;">
    <img src="https://img.shields.io/badge/follow%20on-x.com-1da1f2?logo=x&style=flat-square" alt="Follow on X (Twitter)" />
  </a>
</p>

---
# Transforme Qualquer Dispositivo em um Jukebox Colaborativo

**Jukebox** permite que você crie instantaneamente uma playlist compartilhada com amigos—sem app, sem login, sem anúncios. Basta criar uma caixa, compartilhar o link e começar a adicionar músicas juntos. Perfeito para festas, viagens ou qualquer encontro em grupo!

- 🌐 **Alternativa Open Source às Playlists Colaborativas do Spotify**
- 🕵️ **Não Precisa de Conta**: Use anonimamente—sem cadastro ou e-mail necessário
- ✨ **Compartilhe o Link, Adicione Músicas Juntos**: Todos podem contribuir em tempo real
- 🚀 **Não Precisa Baixar App**: Funciona em qualquer dispositivo, direto no navegador
- 🎵 **Integração com YouTube**: Procure e toque quase qualquer música instantaneamente
- 📱 **Compatível com Celulares**: Projetado para celulares, tablets e desktops
- ⚖️ **Fila Justa**: As músicas são organizadas automaticamente para que todos tenham vez
- 🆓 **100% Gratuito, Sem Anúncios**

---

## Experimente Agora

1. **Crie um Jukebox**: Acesse a página inicial e crie uma nova caixa
2. **Compartilhe o Link**: Envie o link de convite para seus amigos
3. **Adicione Músicas**: Busque no YouTube ou adicione músicas manualmente
4. **Toque Músicas**: Use o player embutido para ouvir juntos

---
## Funcionalidades

- Playlists colaborativas: Adicione, coloque na fila e reproduza músicas em conjunto
- Uso anônimo: Não é necessário login ou conta
- Busca e reprodução no YouTube: Acesse uma enorme biblioteca de músicas
- Interface móvel e responsiva
- Código aberto (Licença MIT)
- Implantação fácil com Docker

### Implantações com Docker Compose

Inicie todos os serviços:

```bash
docker-compose up -d
```

Reimplante os serviços sem tempo de inatividade após atualizar as imagens:

```bash
bash ./redeploy.sh
```
---

## Introdução

### Pré-requisitos

- Node.js 16+
- npm ou yarn
- Chave da API YouTube Data v3 (gratuita do Google)

### Configuração da API do YouTube

1. Acesse o [Google Cloud Console](https://console.cloud.google.com/)
2. Crie um novo projeto ou selecione um existente
3. Habilite a **YouTube Data API v3**
4. Crie credenciais (Chave de API)
5. Copie sua chave de API

### Instalação
```bash
# Clone o repositório
git clone <seu-url-do-repo>
cd jukebox

# Instale as dependências do servidor
cd server
yarn install

# Instale as dependências do frontend
cd ../frontend
yarn install

# Configure as variáveis de ambiente
cd ../server
cp .env.example .env
# Edite o .env e adicione sua chave da API do YouTube

# Execute as migrações do banco de dados
```
yarn migrate

# Inicie os servidores de desenvolvimento
# Backend:
cd server
yarn dev
# Worker:
cd server
yarn dev:worker
# Frontend (em um novo terminal):
cd frontend
yarn dev
```

---

## Licença

MIT

---
## Contribuição & Feedback

- Abra uma issue ou pull request no [GitHub](https://github.com/skeptrunedev/jukebox)
- Solicitações de funcionalidades? Mande uma DM para [@skeptrune no X (Twitter)](https://twitter.com/skeptrune)

---

## Registro de Alterações

Veja o [Registro de Alterações](https://jukebox.skeptrune.com#changelog) para as últimas atualizações e funcionalidades.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---