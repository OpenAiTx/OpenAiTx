<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <a href="https://getcore.me">
    <img width="200px" alt="CORE logo" src="https://github.com/user-attachments/assets/bd4e5e79-05b8-4d40-9aff-f1cf9e5d70de" />
  </a>

# Seu sistema operacional de IA pessoal.

**Execute seu SO.** Observa seu trabalho. Lembra do que é importante. Atua através de suas ferramentas e agentes. Código aberto, auto-hospedado, seu para sempre.

<p align="center">
<a href="https://getcore.me">
    <img src="https://img.shields.io/badge/Website-getcore.me-c15e50?style=for-the-badge&logo=safari&logoColor=white" alt="Website" />
</a>
<a href="https://docs.getcore.me">
    <img src="https://img.shields.io/badge/Docs-docs.getcore.me-22C55E?style=for-the-badge&logo=readthedocs&logoColor=white" alt="Docs" />
</a>
<a href="https://discord.gg/YGUZcvDjUa">
    <img src="https://img.shields.io/badge/Discord-community-5865F2?style=for-the-badge&logo=discord&logoColor=white" alt="Discord" />
</a>
<a href="https://github.com/RedPlanetHQ/core/blob/main/LICENSE">
    <img src="https://img.shields.io/badge/License-AGPL%203.0-blue?style=for-the-badge" alt="License: AGPL 3.0" />
</a>
</p>
</div>

---

## Veja em funcionamento

Veja o CORE executar duas tarefas de programação do início ao fim:

[![CORE Demo](https://img.youtube.com/vi/7y_kt_UTYQs/maxresdefault.jpg)](https://www.youtube.com/watch?v=7y_kt_UTYQs)

---

## O que é o CORE

O CORE é a camada operacional open-source para trabalho nativo de IA.

Você escreve o que precisa ser feito em um bloco de notas. O CORE assume a tarefa, carrega contexto da memória e dos aplicativos conectados, elabora um plano, executa o agente certo pelo gateway, resolve bloqueios quando possível e retorna quando for necessária a avaliação humana.

Não é um chatbot para ficar mandando prompts. É a camada que lembra, coordena, executa e escala.

### A arquitetura

| | |
|---|---|
| **Observa** | Contexto das suas conversas com IA via MCP, mais de 50 aplicativos conectados, e no Mac, qualquer app ao qual você conceda acesso explicitamente. |
| **Lembra** | Um grafo de conhecimento que registra não só o que você disse, mas o que decidiu, quando e por quê, em cada ferramenta e conversa. |
| **Executa** | Toma ações diretas em seus aplicativos conectados e delega tarefas mais longas para agentes de programação e navegação via o gateway. |
| **Políticas** | Fluxos de aprovação, regras de escalonamento, planos e logs de auditoria para que a autonomia permaneça responsável. |

O CORE decide o que pode fazer com segurança, pede permissão antes de ações sensíveis e deixa um rastro que você pode revisar.

---

## CORE em ação

### Delegue uma tarefa de codificação e volte para um PR.

Diga ao CORE o que precisa ser feito. Ele coleta contexto do seu repositório, apps e memória, elabora um plano, executa uma sessão Claude Code ou Codex, resolve bloqueios quando possível e retorna com um PR. Você revisa quando estiver pronto.

`[ ] Corrigir a condição de corrida no fluxo de checkout do issue #312`

### Limpe seu backlog enquanto dorme.

Defina uma tarefa recorrente para puxar do seu backlog em um horário definido. O CORE trabalha nisso enquanto você está offline. Execuções suaves aguardam revisão pela manhã. Sessões travadas voltam com uma pergunta precisa, não uma aba parada.

`[ ] Trabalhar no backlog de hoje à noite a partir das 23h`

### Investigue alertas antes que virem interrupções.

Defina uma tarefa recorrente para monitorar o Sentry, logs ou qualquer fonte de alerta. Quando algo disparar, o CORE investiga, busca rastreamentos relacionados e incidentes anteriores, e decide se resolve ou escala.

Um alerta do Sentry dispara às 2h. O CORE investiga, propõe uma correção e te avisa no Slack para revisão.

### Receba um resumo matinal que entende seu trabalho.

Defina uma tarefa recorrente para puxar de e-mail, GitHub, Linear e Slack todas as manhãs. O CORE resume o que precisa de atenção, ignora o que não precisa e transforma acompanhamentos em tarefas automaticamente.

### Delegue de onde estiver.

Crie tarefas pelo Slack, WhatsApp, Telegram, e-mail ou web. O gateway segue rodando no Docker ou Railway, então o CORE pode pegar trabalho mesmo com seu laptop fechado.

---

## O que há dentro do CORE

| | |
|---|---|
| **Memória** | Registra suas preferências, decisões, metas e diretivas em todas as ferramentas e conversas, para que cada tarefa comece com o contexto carregado. |
| **Tarefas** | Unidades de trabalho únicas ou recorrentes com sua especificação, plano do CORE, estado ao vivo e um tópico dedicado de chat. Cada tarefa pode gerar sessões de codificação ou navegador. |
| **Bloco de Notas** | Uma página diária para tarefas, ideias e trabalho em andamento. Digite `[ ]` em qualquer lugar e o CORE detecta em até 3 minutos. |
| **Conectores** | Mais de 50 aplicativos por um único endpoint MCP, além de gatilhos de webhook para automação proativa. GitHub, Linear, Jira, Slack, Gmail, Calendar, Sentry, Granola, Todoist e mais. |
| **Skills** | Mais de 100 instruções reutilizáveis aplicadas automaticamente conforme o contexto. Use as skills embutidas ou escreva as suas para fluxos repetíveis. |
| **Gateway** | Executa Claude Code, Codex, agentes de navegador e comandos locais na sua máquina ou em Docker / Railway, para que o CORE continue funcionando mesmo com seu laptop fechado. |
| **Modelo agnóstico** | Use seu próprio provedor: Anthropic, OpenAI ou modelos de peso aberto. Auto-hospede toda a stack para isolamento. |

---

## O que o CORE não é

| | |
|---|---|
| **Não é um wrapper RAG.** | A memória não são apenas pedaços incorporados. É um grafo de conhecimento que rastreia o que você decidiu, quando e por quê. |
| **Não é um construtor de workflow.** | Sem DAGs de arrastar e soltar. Você escreve o que precisa ser feito. O CORE define o workflow e pergunta quando precisa de julgamento. |
| **Não é outro Devin.** | O CORE propõe planos, você aprova. O CORE pede desbloqueios, você decide. O CORE traz PRs de volta, você revisa. Agentes não fazem merge sozinhos. |
| **Não é um assistente fechado na nuvem.** | O CORE é open source, auto-hospedável, agnóstico a modelos e projetado em torno da sua infraestrutura. |

---

## Guia rápido

Open source e auto-hospedado. Seus dados permanecem na sua infraestrutura.

**Instale e inicie o CORE:**

```bash
npm install -g @redplanethq/corebrain && corebrain setup
```

O assistente de configuração solicita um diretório de instalação, provedor de IA, chave de API e modelo de chat. Ele gera segredos, inicia a stack e abre `http://localhost:3033`.

A maioria das instalações locais leva alguns minutos após o Docker estar em execução.

**Ou faça o deploy na Railway:**

[![Deploy on Railway](https://railway.app/button.svg)](https://railway.com/deploy/core)

**Conecte um gateway** para que o CORE possa controlar seu navegador, executar agentes de codificação e acessar pastas locais:

```bash
corebrain login
corebrain gateway setup
```

**Requisitos:** Docker 20.10+, Docker Compose 2.20+, 4 vCPU / 8GB RAM

[Guia completo de auto-hospedagem](https://docs.getcore.me/self-hosting/setup)

> Quer o aplicativo para Mac? Entre na lista de espera em [getcore.me](https://www.getcore.me/).

---

## Benchmark

O CORE alcança **88,24%** de precisão média no [benchmark LoCoMo](https://github.com/RedPlanetHQ/core-benchmark) em raciocínio single-hop, multi-hop, open-domain e temporal.

---

## O que acreditamos

- Chat é uma interface. Não um sistema operacional.
- Inteligência sem memória é trivialidade.
- Sua IA deve conhecer você em todas as ferramentas, não apenas na aba atual.
- O trabalho deve avançar da intenção para a ação sem você se tornar o elo.
- Automação sem responsabilidade é caos.

---

## Documentação

- [**Memória**](https://docs.getcore.me/memory/overview) - Grafo temporal de conhecimento, classificação de fatos, recuperação orientada por intenção
- [**Scratchpad**](https://docs.getcore.me/concepts/scratchpad) - Superfície diária onde tarefas e ideias começam
- [**Tarefas**](https://docs.getcore.me/concepts/tasks) - Planos, estado, trabalho recorrente e contexto de tarefas
- [**Toolkit**](https://docs.getcore.me/concepts/toolkit) - 1000+ ações em 50+ apps via MCP
- [**Agente CORE**](https://docs.getcore.me/concepts/meta-agent) - Disparadores, memória, ferramentas e execução
- [**Gateway**](https://docs.getcore.me/access-core/overview) - WhatsApp, Slack, Telegram, e-mail, web e acesso via API
- [**Skills**](https://docs.getcore.me/skills/overview) - Instruções reutilizáveis para fluxos de trabalho repetitivos
- [**Auto-hospedagem**](https://docs.getcore.me/self-hosting/setup) - Guia completo de implantação
- [**Changelog**](https://docs.getcore.me/opensource/changelog) - O que foi lançado

---

## Segurança

- Certificado CASA Tier 2
- TLS 1.3 em trânsito
- AES-256 em repouso
- Seus dados nunca são usados para treinamento de modelo
- Hospede você mesmo para isolamento total
- [Política de segurança](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md)
- Vulnerabilidades: harshith@poozle.dev

---

## Comunidade

Estamos construindo o CORE de forma aberta.

Compartilhamos o roadmap e decisões arquiteturais abertamente porque os problemas mais difíceis de construir um OS pessoal são melhor resolvidos com as pessoas que o usam. Dê uma estrela no repositório, hospede você mesmo, compartilhe o que você construiu e abra issues para o que está quebrado ou faltando.

- [Discord](https://discord.gg/YGUZcvDjUa) - perguntas, ideias, mostre e compartilhe
- [Documentos de contribuição](https://docs.getcore.me/opensource/contributing) - como contribuir para o CORE
- [`good-first-issue`](https://github.com/RedPlanetHQ/core/labels/good-first-issue) - comece por aqui

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>

---

<div align="center">

**Hospede seu próprio OS de IA pessoal.**

[Dê uma estrela neste repositório](https://github.com/RedPlanetHQ/core) · [Leia os documentos](https://docs.getcore.me) · [Entre no Discord](https://discord.gg/YGUZcvDjUa)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-19

---