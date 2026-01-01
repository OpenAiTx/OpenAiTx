
<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# AI Novel Editor

An AI-assisted novel editor based on PyQt6, providing professional writing tools such as smart completion, project management, and concept organization.

## Installation

1. Clone the project
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. Create a virtual environment
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```

3. Install dependencies
```bash
pip install -r requirements.txt
```

4. Run the program
```bash
python src/main.py
```

## Main Features

### Project Management
- Hierarchical document structure (Work > Chapter > Scene)
- Project import and export (supports TEXT, MARKDOWN, DOCX, PDF, HTML formats)
- Automatic backup and version control
- Multi-project management

### AI Completion Features
- Three completion modes: Auto Complete, Manual Complete (recommended: press tab once to trigger, press again to apply completion), Disable Completion
- Three context modes:
  - Quick Mode: Lightweight context, fast response
  - Balanced Mode: Moderate context, balance of quality and speed
  - Global Mode: Full project context, best results
- Supports multiple AI services: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq, etc.

### Outline Management
- Visual outline tree structure
- Drag-and-drop sorting and hierarchy adjustment
- Fast document navigation
- Outline analysis and optimization suggestions

### API Configuration
- Unified AI configuration center
- Multiple provider preset configurations
- Connection test function
- Configuration plan save, import, and export

### Intelligent Completion Settings
- Adjustable trigger delay
- Completion length limit
- Context length configuration
- Streaming response support

### Prompt Editing
- Built-in writing templates
- Custom prompt templates
- Template category management
- Mode-specific template configuration

### Interface Features
- Dual light and dark themes
- Three-column layout (project tree, editor, concept panel)
- Collapsible sidebar
- Full-screen writing mode
- Focus modes (sentence, paragraph, typewriter, zen mode, immersive mode)

### Search and Replace
- Full-project text search
- Regular expression support
- Batch replace functionality
- Advanced search options

### Concept Management
- Automatic detection of characters, locations, items
- Concept relationship management
- Tag and categorization system
- Quick concept insertion

## Shortcuts

- `Ctrl+N`: New project
- `Ctrl+O`: Open project
- `Ctrl+S`: Save document
- `F11`: Full-screen mode
- `Tab`: Manually trigger AI completion (in manual mode)
- `Ctrl+F`: Find
- `Ctrl+H`: Find and replace
- `Ctrl+Shift+H`: Advanced find and replace


## System Requirements

- Python 3.8+
- PyQt6
- Operating system: Windows, macOS, Linux

## Author

**inliver**
- Email: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---