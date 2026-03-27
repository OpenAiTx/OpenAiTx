
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

[![Status](https://img.shields.io/badge/status-active-brightgreen)](https://github.com/seuusuario/wakeonweb)
[![License](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

# Your LastFM

Uma aplicação Node.js conteinerizada que sincroniza scrobbles do **Last.fm**, armazena-os em um banco de dados **SQLite** local e disponibiliza um painel web.

<img width="1718" height="1066" alt="image" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />
---

## Projeto

**Your LastFM** é uma aplicação Node.js projetada para **sincronizar automaticamente scrobbles de música** do Last.fm. Ela preserva seu histórico de audições em um banco de dados SQLite local e fornece uma interface web para visualização dos dados.

O projeto é totalmente containerizado com **Docker**, usando um entrypoint automatizado para gerenciar a inicialização do banco de dados e execução sequencial (Sincronização primeiro, depois lançamento da API Web). Também utiliza **PM2** como gerenciador de processos dentro do container para garantir que o serviço web permaneça ativo e resiliente.

## Funcionalidades
### Painel Web Interativo

- Interface web limpa e moderna para visualizar sua atividade musical.

### Sincronização Automática de Scrobbles do Last.fm

- Busca e armazena periodicamente seu histórico de audições (scrobbles) do Last.fm.
- Garante que seus dados estejam sempre atualizados sem intervenção manual.

### Banco de Dados Local de Histórico Musical

- Persiste todos os scrobbles em um banco de dados SQLite local.
- Permite consultas rápidas e acesso offline ao histórico de audições.

### Visualização de Scrobbles Recentes

- Exibe suas faixas mais recentes.
- Lógica inteligente de fallback de imagens para faixas, álbuns e artistas.

### Comparação com Amigos (Visualização de Compatibilidade)

- Compare seu gosto musical com amigos do Last.fm.
- Mostra o nível de compatibilidade (Muito Baixa → Super).
- Exibe principais artistas, álbuns e faixas em comum.
- Calcula e normaliza a compatibilidade baseada em dados reais de audição.

### Cartões Musicais Compartilháveis

- Gera imagens dinâmicas baseadas em seus dados de audição.
- Layouts otimizados para postagens em feeds e stories do Instagram (9:16)

- Construído usando node-canvas para renderização de imagens no lado do servidor.

## Pré-requisitos

* [Docker](https://docs.docker.com/get-docker/)
* [Docker Compose](https://docs.docker.com/compose/install/)

## Instalação

### Crie um arquivo `.env`

```env
LASTFM_API_KEY=your_lastfm_api_key
LASTFM_USERNAME=your_lastfm_username
```

Last.fm: Crie uma conta de API [aqui](https://www.last.fm/api/account/create) para obter sua chave de API.

### Docker Compose

```yml
services:
  your-lastfm:
    image: gomaink/your-lastfm
    container_name: your-lastfm
    ports:
      - "1533:1533"
    env_file:
      - .env
    volumes:
      - ./data:/app/data
    restart: unless-stopped
```

No terminal:
`docker compose up -d`

Em seguida, acesse:
```
http://localhost:1533
```

(ou substitua `localhost` pelo IP do seu servidor)

## Licença

Este projeto está licenciado sob a Licença MIT.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---