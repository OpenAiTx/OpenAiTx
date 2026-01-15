
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Chat de Parceiro de IA

Um projeto Claude Skills que transforma a IA em seu parceiro de conversa personalizado.

## Introdução ao Projeto

O Chat de Parceiro de IA integra perfis de usuário, perfis de IA e notas pessoais vetorizadas para oferecer uma experiência de diálogo personalizada e sensível ao contexto. Esta habilidade permite que a IA lembre e cite seus pensamentos, preferências e base de conhecimento anteriores, criando uma interação mais coesa e personalizada.

## Funcionalidades Principais

### 🎭 Sistema de Duplo Perfil
- **Perfil do Usuário**: Defina seu histórico, especialidades, interesses e preferências de comunicação
- **Perfil da IA**: Personalize o papel da IA, estilo de comunicação e modo de interação

### 📝 Busca Inteligente em Notas
- Indexação automática das suas notas em Markdown
- Busca inteligente de registros históricos relevantes com base no conteúdo da conversa
- Referência natural às suas ideias e notas anteriores durante o diálogo

### 💬 Diálogo Personalizado
- Geração de respostas personalizadas com base no seu perfil e nas suas notas
- Manutenção da coerência do contexto da conversa
- Referência natural às suas ideias como um amigo, e não mecanicamente "conforme registros"

## Cenários de Uso

Quando você precisa de:
- Comunicação personalizada, não respostas genéricas
- Respostas sensíveis ao contexto, com IA lembrando do seu histórico
- IA lembrando e citando suas ideias e notas anteriores
- Experiência de conversa contínua, sem recomeço a cada vez

## Instalação e Uso

### Instalar Habilidade

Copie este projeto para a pasta `.claude/skills/` do seu diretório de trabalho:

```
<你的项目根目录>/
└── .claude/
    └── skills/
        └── ai-partner-chat/    # 本技能包
            ├── assets/
            ├── scripts/
            ├── SKILL.md
            └── README.md
```

### Usando Habilidades

No Claude Code, basta enviar o seguinte comando para ativar esta habilidade:

```
遵循 ai-partner-chat 对话
```

O agente de IA irá automaticamente:
- Ler as configurações e orientações de habilidades
- Criar a estrutura de diretórios necessária (`notes/`, `config/`, `vector_db/` etc.)
- Inicializar conforme suas necessidades

### Fluxo de Inicialização

#### Modo 1: Deixe a IA criar e configurar automaticamente

Ao usar pela primeira vez, simplesmente diga à IA:

```
我刚刚在 notes 里放入了对应的笔记，请根据笔记内容，进行向量化；并基于笔记内容，推测并更新 user-persona.md，以及最适合我的 ai-persona.md
```
O agente de IA irá:
1. Analisar o conteúdo das anotações no diretório `notes/`
2. Dividir de forma inteligente conforme o formato das anotações e criar um banco de dados vetorial
3. Inferir seu background e preferências com base no conteúdo das anotações
4. Gerar e atualizar automaticamente o arquivo `config/user-persona.md`
5. Recomendar e criar o arquivo `config/ai-persona.md` conforme suas características

#### Método 2: Configuração manual da persona

Se você preferir definir a persona manualmente:
1. O agente de IA irá criar automaticamente os arquivos de persona a partir de um modelo no diretório `config/`
2. Você pode editar esses arquivos manualmente para personalizar a persona
3. Em seguida, informar a IA para realizar o processamento vetorial

### Iniciar conversa

Após a configuração, basta enviar toda vez que usar:


```
遵循 ai-partner-chat 对话
```

A IA irá:
- Ler seu perfil para entender seu histórico
- Buscar notas históricas relevantes
- Gerar respostas personalizadas e sensíveis ao contexto

## Estrutura do Projeto

### Estrutura do Pacote de Habilidades (localizado em `.claude/skills/ai-partner-chat/`)

```
ai-partner-chat/
├── assets/              # 画像模板
│   ├── user-persona-template.md
│   └── ai-persona-template.md
├── scripts/             # 核心脚本
│   ├── chunk_schema.py
│   ├── vector_indexer.py
│   ├── vector_utils.py
│   └── requirements.txt
├── SKILL.md            # 技能详细文档（AI agent 会读取此文件）
└── README.md           # 本文件
```

### Diretório de dados do usuário (localizado no diretório raiz do projeto)

O agente de IA criará a seguinte estrutura no diretório raiz do seu projeto:

```
<项目根目录>/
├── notes/              # 你的笔记（由你或 AI agent 创建）
├── config/             # 画像配置（由 AI agent 创建）
│   ├── user-persona.md
│   └── ai-persona.md
├── vector_db/          # 向量数据库（由 AI agent 创建）
└── venv/               # Python 虚拟环境（由 AI agent 创建）
```

**Importante**: Os dados do usuário são separados dos pacotes de habilidades, facilitando backup e migração.

## Fluxo de trabalho

1. **Carregar perfis**: Ler o perfil do usuário e o perfil de IA para entender o contexto da interação
2. **Buscar notas**: Recuperar as notas mais relevantes do banco de dados vetorial com base na consulta do usuário
3. **Construir contexto**: Integrar informações de perfil, notas relevantes e histórico de conversas
4. **Gerar resposta**: Gerar respostas personalizadas e naturais com base no contexto

## Principais destaques

### 🤖 Divisão inteligente por agente de IA
O sistema analisa o formato real de cada nota e gera dinamicamente a melhor estratégia de divisão, em vez de usar um modelo predefinido. Isso significa que, independentemente do formato de suas notas, você terá o melhor processamento.

### 🎯 Citação natural
A IA irá recuperar suas informações passadas de forma natural, como uma lembrança, sem dizer "de acordo com o registro", mas integrando suavemente ao diálogo.

### 📦 Independência dos dados
Todos os seus dados (notas, perfis, banco vetorial) ficam armazenados no diretório raiz do projeto, sendo fáceis de fazer backup, migrar ou compartilhar entre diferentes habilidades.

## Melhores práticas

### Design do perfil
- **Seja específico**: Perfis vagos levam a respostas genéricas
- **Inclua exemplos**: Mostre padrões de interação desejados no perfil da IA
- **Atualize regularmente**: Otimize os perfis conforme a qualidade das conversas

### Gerenciamento de notas
- **Formato livre**: O sistema se adapta a qualquer estrutura de nota
- **Conteúdo rico**: Notas aprofundadas trazem melhores resultados de busca
- **Atualize sempre**: Lembre-se de adicionar novas notas ao índice

### Experiência de conversa
- **Citação natural**: Cite notas apenas quando realmente relevante
- **Mantenha fluidez**: Não deixe que a citação interrompa o ritmo natural do diálogo
- **Foque na qualidade**: Priorize conexões significativas, não quantidade

## Manutenção e atualização

### Adicionar nova nota
Após colocar a nova nota no diretório `notes/`, informe à IA:

```
我刚刚在 notes 里添加了新笔记，请更新向量数据库
```

O agente de IA irá analisar automaticamente novas anotações e atualizar o índice.

### Atualizar Perfil
Você pode editar diretamente o arquivo de perfil no diretório `config/`, ou informar à IA:

```
请根据我最近的笔记内容，更新 user-persona.md 和 ai-persona.md
```

### Reconstruir Índice
Quando a estrutura das anotações mudar significativamente, informe à IA:

```
请重新初始化向量数据库
```

O agente de IA irá reanalisar todas as notas e reconstruir o índice.

## Avisos

- **Primeira execução**: Ao criar o banco de dados vetorial pela primeira vez, o agente de IA fará o download automático do modelo de embeddings (aprox. 4,3GB), seja paciente
- **Ambiente Python**: O agente de IA criará automaticamente um ambiente virtual e instalará as dependências necessárias
- **Armazenamento de dados**: Todos os dados (notas, perfil, banco de vetores) são armazenados no diretório raiz do projeto, e não dentro do diretório do pacote de habilidades
- **Localização das habilidades**: Certifique-se de que o pacote de habilidades está localizado em `.claude/skills/ai-partner-chat/`

## Mais informações

Consulte o arquivo `SKILL.md` para documentação técnica detalhada e instruções de uso.

---

Deixe a IA se tornar um verdadeiro parceiro de conversa que realmente entende você, e não apenas uma ferramenta.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-15

---