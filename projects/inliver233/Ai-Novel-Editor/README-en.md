# AI Novel Editor

AI-assisted novel editor based on PyQt6, providing professional writing tools such as intelligent completion, project management, and concept organization.

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
4. Run the Program
```bash
python src/main.py
```

## Main Features

### Project Management
- Hierarchical document structure (Work > Chapter > Scene)
- Project import and export (supports TEXT, MARKDOWN, DOCX, PDF, HTML formats)
- Automatic backup and version control
- Multiple project management

### AI Completion Features
- Three completion modes: Auto-completion, Manual completion (recommended: press Tab once to trigger, press Tab again to apply), Disable completion
- Three context modes:
  - Fast mode: Lightweight context, fast response
  - Balanced mode: Medium context, balance between quality and speed
  - Global mode: Full project context, best results
- Supports multiple AI services: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq, etc.
### Outline Management
- Visualized outline tree structure
- Drag-and-drop sorting and hierarchy adjustment
- Quick document navigation
- Outline analysis and optimization suggestions

### API Configuration
- Unified AI configuration center
- Preset configurations for multiple providers
- Connection testing function
- Save, import, and export configuration schemes

### Intelligent Autocomplete Settings
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
- Light and dark dual themes
- Three-column layout (project tree, editor, concept panel)
- Collapsible sidebar
- Full-screen writing mode
- Focus mode (sentence, paragraph, typewriter, zen mode, immersive mode)

### Search and Replace
- Full project text search
- Regular expression support
- Batch replace functionality
- Advanced search options

### Concept Management
- Automatic detection of characters, locations, items
- Concept relationship management
- Tag and categorization system
- Quick concept insertion

## Shortcuts
- `Ctrl+N`: New Project
- `Ctrl+O`: Open Project
- `Ctrl+S`: Save Document
- `F11`: Full Screen Mode
- `Tab`: Manually Trigger AI Completion (in manual mode)
- `Ctrl+F`: Find
- `Ctrl+H`: Find and Replace
- `Ctrl+Shift+H`: Advanced Find and Replace


## System Requirements

- Python 3.8+
- PyQt6
- Operating System: Windows, macOS, Linux

## Author

**inliver**
- Email: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---