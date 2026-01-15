
<div align="right">
  <details>
    <summary >🌐 Language</summary>
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

# AI Partner Chat

A Claude Skills project that enables AI to become your personalized conversation partner.

## Project Introduction

AI Partner Chat provides a personalized, context-aware conversation experience by integrating user profiles, AI profiles, and vectorized personal notes. This skill allows the AI to remember and reference your previous thoughts, preferences, and knowledge base, creating a more coherent and personalized interactive experience.

## Core Features

### 🎭 Dual Persona System
- **User Persona**: Define your background, expertise, interests, and communication preferences
- **AI Persona**: Customize the AI's role, communication style, and interaction mode

### 📝 Smart Note Retrieval
- Automatically index your Markdown notes
- Intelligently retrieve relevant history based on conversation content
- Naturally reference your past ideas and notes in the dialogue

### 💬 Personalized Conversation
- Generate personalized responses based on your persona and notes
- Maintain contextual coherence in the conversation
- Reference your ideas like a friend, not mechanically "according to the record"

## Usage Scenarios

When you need:
- Personalized communication, not generic replies
- Context-aware responses, with AI remembering your background
- AI to remember and reference your previous thoughts and notes
- A continuous conversation experience, not a fresh start every time

## Installation & Usage

### Install the Skill

Copy this project into your working directory under the `.claude/skills/` folder:

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

### Using Skills

In Claude Code, send the following command to activate this skill:

```
遵循 ai-partner-chat 对话
```

The AI agent will automatically:
- Read skill configurations and instructions
- Create necessary directory structures (`notes/`, `config/`, `vector_db/`, etc.)
- Initialize according to your needs

### Initialization Process

#### Method 1: Let the AI automatically create and configure

For first-time use, simply tell the AI:

```
我刚刚在 notes 里放入了对应的笔记，请根据笔记内容，进行向量化；并基于笔记内容，推测并更新 user-persona.md，以及最适合我的 ai-persona.md
```

The AI agent will:
1. Analyze the notes in the `notes/` directory
2. Intelligently segment notes based on their format and create a vector database
3. Infer your background and preferences based on the note content
4. Automatically generate and update `config/user-persona.md`
5. Recommend and create `config/ai-persona.md` based on your characteristics

#### Method 2: Manual Persona Configuration

If you want to define the persona yourself:
1. The AI agent will automatically create persona files from templates into the `config/` directory
2. You can manually edit these files to customize the persona
3. Then instruct the AI to perform vectorization

### Start Conversation

After configuration, simply send the following each time you use it:

```
遵循 ai-partner-chat 对话
```

AI will:
- Read your profile to understand your background
- Retrieve relevant historical notes
- Generate personalized, context-aware responses

## Project Structure

### Skill Package Structure (located at `.claude/skills/ai-partner-chat/`)

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

### User Data Directory (Located in the Project Root Directory)

The AI agent will create the following structure in your project root directory:

```
<项目根目录>/
├── notes/              # 你的笔记（由你或 AI agent 创建）
├── config/             # 画像配置（由 AI agent 创建）
│   ├── user-persona.md
│   └── ai-persona.md
├── vector_db/          # 向量数据库（由 AI agent 创建）
└── venv/               # Python 虚拟环境（由 AI agent 创建）
```

**Important**: User data and skill packages are separated for easy backup and migration.

## Workflow

1. **Load Profiles**: Read user profiles and AI profiles to understand the interaction context  
2. **Retrieve Notes**: Retrieve the most relevant notes from the vector database based on user queries  
3. **Build Context**: Integrate profile information, relevant notes, and conversation history  
4. **Generate Response**: Generate personalized and natural responses based on the context  

## Highlights

### 🤖 AI Agent Intelligent Chunking  
The system analyzes the actual format of each note and dynamically generates the most suitable chunking strategy instead of using preset templates. This means your notes will be optimally processed regardless of their format.

### 🎯 Natural Citation  
The AI naturally incorporates your past information as if recalling, without awkwardly saying "according to the records," seamlessly blending into the conversation.

### 📦 Data Independence  
All your data (notes, profiles, vector databases) are stored in the project root directory, making it easy to back up, migrate, or share across different skills.

## Best Practices

### Profile Design  
- **Be Specific and Clear**: Vague profiles lead to generic replies  
- **Include Examples**: Show expected interaction patterns in the AI profile  
- **Update Regularly**: Continuously optimize profiles based on conversation quality  

### Note Management  
- **Flexible Format**: The system adapts to any note structure  
- **Rich Content**: In-depth notes bring better retrieval results  
- **Timely Updates**: Remember to add new notes to the index  

### Conversation Experience  
- **Natural Citation**: Cite notes only when truly relevant  
- **Maintain Flow**: Don’t let citations disrupt the natural rhythm of conversation  
- **Focus on Quality**: Prioritize meaningful connections over quantity  

## Maintenance and Updates

### Add New Note
After placing the new note into the `notes/` directory, inform the AI:

```
我刚刚在 notes 里添加了新笔记，请更新向量数据库
```

The AI agent will automatically analyze new notes and update the index.

### Update Profile
You can directly edit the profile files in the `config/` directory, or tell the AI:

```
请根据我最近的笔记内容，更新 user-persona.md 和 ai-persona.md
```

### Rebuild Index
When the note structure undergoes significant changes, inform the AI:

```
请重新初始化向量数据库
```
AI agent will reanalyze all notes and rebuild the index.

## Notes

- **First Run**: When the AI agent creates the vector database for the first time, it will automatically download the embedding model (about 4.3GB), please be patient
- **Python Environment**: The AI agent will automatically create a virtual environment and install the required dependencies
- **Data Storage**: All data (notes, profiles, vector libraries) are stored in the project root directory, not in the skill package directory
- **Skill Location**: Ensure the skill package is located in the `.claude/skills/ai-partner-chat/` directory

## More Information

For detailed technical documentation and usage instructions, please refer to the `SKILL.md` file.

---

Let AI become a conversation partner who truly understands you, not just a tool.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-15

---