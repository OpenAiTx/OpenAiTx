
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# SparkyFitness - Alternativa auto-hospedada ao MyFitnessPal

SparkyFitness é um aplicativo abrangente de gerenciamento e acompanhamento de fitness, projetado para ajudar os usuários a monitorar sua nutrição, exercícios e medidas corporais. Ele oferece ferramentas para acompanhamento diário de progresso, definição de metas e relatórios detalhados para apoiar um estilo de vida saudável.

Documentação: https://codewithcj.github.io/SparkyFitness

## ✨ Funcionalidades

### 🍎 Monitoramento Nutricional

* **Registre suas refeições diárias**
* **Crie e gerencie alimentos e categorias personalizadas**
* **Veja resumos e analise tendências com gráficos interativos**

### 💪 Registro de Exercícios

* **Registre seus treinos**
* **Navegue e pesquise em um banco de dados abrangente de exercícios**
* **Acompanhe o progresso físico ao longo do tempo**

### 💧 Monitoramento de Ingestão de Água

* **Acompanhe metas diárias de hidratação**
* **Registro de água simples e rápido**

### 📏 Medidas Corporais

* **Registre métricas corporais** (ex.: peso, cintura, braços)
* **Adicione tipos de medições personalizadas**
* **Visualize o progresso por meio de gráficos**

### 🎯 Definição de Metas

* **Defina e gerencie metas de fitness e nutrição**
* **Acompanhe o progresso ao longo do tempo**

### 🗓️ Check-ins Diários

* **Monitore a atividade diária**
* **Mantenha a consistência com o rastreamento de hábitos**

### 🤖 Coach de Nutrição IA (SparkyAI)

* **Registre alimentos, exercícios, dados corporais e passos via chat**
* **Envie imagens de alimentos para registrar refeições automaticamente**
* **Inclui histórico de chat e orientação personalizada**

### 🔒 Autenticação de Usuário & Perfis

* **Sistema de login seguro**
* **Alternar entre perfis de usuário**
* **Suporte para acesso e gerenciamento familiar**

### 📊 Relatórios Abrangentes

* **Gerar resumos de nutrição e métricas corporais**
* **Acompanhar tendências de longo prazo por semanas ou meses**

### 🎨 Temas Personalizáveis

* **Alternar entre modo claro e escuro**
* **Interface projetada para ser minimalista e sem distrações**

### Precisa de Ajuda?
* **Entre no Discord**
  https://discord.gg/vcnMT5cPEA
* **Poste na discussão**


![imagem](https://github.com/user-attachments/assets/ccc7f34e-a663-405f-a4d4-a9888c3197bc)

## � Início Rápido

Coloque o SparkyFitness para rodar em minutos:

```bash
# 1. Create a new folder
mkdir sparkyfitness && cd sparkyfitness

# 2. Download Docker files only
curl -o docker-compose.yml https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docker/docker-compose.prod.yml
curl -o .env https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docker/.env.example

# 3. (Optional) Edit .env to customize your setup
# e.g., update database credentials, ports, etc.
# if you require Gamrin integration, uncomment Garmin section from compose file.

# 4. Start the app
docker compose pull && docker compose up -d

# Access application at http://localhost:8080
```

## 📖 Documentação

Para guias completos de instalação, configuração de desenvolvimento e instruções de uso, visite nossa documentação abrangente:

**👉 [Site de Documentação SparkyFitness](https://codewithcj.github.io/SparkyFitness)**

### Links Rápidos

- **[🚀 Primeiros Passos](https://codewithcj.github.io/SparkyFitness/developer/getting-started)** - Guia completo de configuração para desenvolvimento e produção
- **[🐳 Guia Docker](https://codewithcj.github.io/SparkyFitness/developer/docker)** - Implantação e configuração com Docker
- **[🔧 Fluxo de Trabalho de Desenvolvimento](https://codewithcj.github.io/SparkyFitness/developer/workflow)** - Guia do desenvolvedor e processo de contribuição  
- **[📊 Visão Geral de Funcionalidades](https://codewithcj.github.io/SparkyFitness/features/)** - Documentação completa das funcionalidades
- **[🏗️ Arquitetura](https://codewithcj.github.io/SparkyFitness/app-overview)** - Arquitetura técnica e design
- Consulte o WIki para exemplo de configuração do ambiente e configuração do app mobile.


## Histórico de Stars

<a href="https://star-history.com/#CodeWithCJ/SparkyFitness&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" />
    <img alt="Gráfico de Histórico de Stars" src="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" width="100%" />
  </picture>
</a>

## Traduções

<a href="https://hosted.weblate.org/engage/sparkyfitness/">
<img src="https://hosted.weblate.org/widget/sparkyfitness/sparkyfitness-translations/multi-auto.svg" alt="Status da tradução" />
</a>

## Atividade do Repositório

![Alt](https://repobeats.axiom.co/api/embed/828203d3070ff56c8873c727b6873b684c4ed399.svg "Imagem de analytics Repobeats")


## Contribuidores

<a href="https://github.com/CodeWithCJ/SparkyFitness/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CodeWithCJ/SparkyFitness" width="100%"/>
</a>

### ⚠️ Problemas Conhecidos / Recursos Beta ⚠️

Os seguintes recursos estão atualmente em beta e podem não ter sido totalmente testados. Espere possíveis bugs ou funcionalidades incompletas:

*   Chatbot de IA
*   Suporte a múltiplos usuários
*   Acesso para Família & Amigos
*   Integração com Dados do Apple Health

Este aplicativo está em desenvolvimento intenso. As coisas podem não funcionar como esperado devido à migração do Supabase para o PostgreSQL. MUDANÇAS QUEBRANDO podem ser introduzidas até que o aplicativo esteja estável.
Você pode precisar alterar variáveis Docker/ambiente para novos lançamentos. Portanto, upgrades automáticos usando Watchtower ou aplicativos semelhantes não são recomendados. Leia as notas de lançamento para quaisquer MUDANÇAS QUEBRANDO.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---