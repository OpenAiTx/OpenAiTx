<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-CN">Simplified Chinese</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-TW">Traditional Chinese</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ja">Japanese</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ko">Korean</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=hi">Hindi</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=th">Thai</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fr">French</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=de">German</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=es">Spanish</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=it">Italian</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ru">Russian</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pt">Portuguese</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=nl">Dutch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pl">Polish</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ar">Arabic</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fa">Persian</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=tr">Turkish</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=vi">Vietnamese</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=id">Indonesian</a></p>
      </div>
    </div>
  </details>
</div>

# AI Novel Editor

An AI-assisted novel editor based on PyQt6, offering professional writing tools such as intelligent autocompletion, project management, and concept organization.

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
Using uv
```bash
uv venv -p 3.11
```
3. Install Dependencies
```bash
pip install -r requirements.txt
```
Using uv
```bash
uv sync
```


4. Run the Program
```bash
python -m src
```

## Main Features

### Project Management
- Hierarchical document structure (Work > Chapter > Scene)
- Project import and export (supports TEXT, MARKDOWN, DOCX, PDF, HTML formats)
- Automatic backup and version control
- Multi-project management
### AI Completion Function
- Three completion modes: Auto-completion, Manual completion (Recommended: press Tab once to trigger, press Tab again to apply completion), and Disable completion
- Three context modes:
  - Fast mode: Lightweight context, fast response
  - Balanced mode: Moderate context, balance between quality and speed
  - Global mode: Complete project context, best results
- Supports multiple AI services: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq, etc.

### Outline Management
- Visualized outline tree structure
- Drag-and-drop sorting and hierarchy adjustment
- Quick document navigation
- Outline analysis and optimization suggestions

### API Configuration
- Unified AI configuration center
- Preset configurations for multiple service providers
- Connection testing function
- Save, import, and export configuration schemes
### Intelligent Auto-Completion Settings
- Adjustable trigger delay
- Completion length limit
- Context length configuration
- Streaming response support

### Prompt Editing
- Built-in multiple writing templates
- Custom prompt templates
- Template category management
- Mode-specific template configuration

### Interface Features
- Light and dark dual themes
- Three-pane layout (project tree, editor, concept panel)
- Collapsible sidebar
- Full-screen writing mode
- Focus modes (sentence, paragraph, typewriter, zen mode, immersive mode)

### Search and Replace
- Full-project text search
- Regular expression support
- Batch replacement function
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
- `F11`: Full screen mode
- `Tab`: Manually trigger AI completion (in manual mode)
- `Ctrl+F`: Find
- `Ctrl+H`: Find and replace
- `Ctrl+Shift+H`: Advanced find and replace
## System Requirements

- Python 3.8+
- PyQt6
- Operating System: Windows, macOS, Linux

## Author

**inliver**
- Email: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---