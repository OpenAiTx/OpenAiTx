# 🚀 MCP AI Development Assistant

> An MCP tool to assist AI developers in intelligent requirements analysis and architecture design

## ✨ Core Features

- **Intelligent Requirement Clarification**: Automatically identifies project type and generates targeted questions
- **Branch-Aware Management**: Tracks project goals, function design, technology preferences, UI design, etc.
- **Automatic Architecture Generation**: Generates technical architecture solutions based on complete requirements
- **Persistent Storage**: Automatically saves analysis results, supports document export

## 📁 Quick Configuration

### Legacy Version Configuration
1. **Clone the Code**
   ```bash
   git clone https://github.com/jiemobasixiangcai/ai-develop-assistant.git
   ```
2. **Recommended Virtual Environment**
   ```bash
   python -m venv venv
   source venv/bin/activate  # Unix/Linux/MacOS
   venv\Scripts\activate  # Windows
   ```
3. **Install Dependencies**
   ```bash
   pip install -r requirements.txt
   ```

4. **Configuration File Location**
   ```
   Windows: %APPDATA%\Claude\claude_desktop_config.json
   macOS: ~/Library/Application Support/Claude/claude_desktop_config.json
   ```

5. **Add Configuration**
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "python",
         "args": ["path/to/AIDevlopStudy.py"],
         "env": {
           "MCP_STORAGE_DIR": "./mcp_data"
         }
       }
     }
   }
   ```

3. **Restart Claude Desktop**

### New Version Configuration
#### 🔧 Core Tools
1. **start_new_project** - Start a new project
2. **create_requirement_blueprint** - Create requirement blueprint
3. **requirement_clarifier** - Get requirement clarification prompt
4. **save_clarification_tasks** - Save clarification tasks
5. **update_branch_status** - Update branch status
6. **requirement_manager** - Requirement document manager
7. **check_architecture_prerequisites** - Check architecture prerequisites
8. **get_architecture_design_prompt** - Get architecture design prompt
9. **save_generated_architecture** - Save generated architecture design
10. **export_final_document** - Export complete document
11. **view_requirements_status** - View requirements status

#### Configuration (Copy remotely and paste into your tool, replace MCP_STORAGE_DIR with your local directory)
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "uvx",
         "args": ["ai-develop-assistant@latest"],
         "env": {
           "MCP_STORAGE_DIR": "/path/to/your/storage"
         }
       }
     }
   }
   ```

## 🎯 Usage Process

### Basic Steps

1. **Requirement Clarification**
   ```
   requirement_clarifier("I want to build an online education platform")
   ```

2. **Requirement Management**
   ```
   requirement_manager("Target users: students and teachers", "Project overview")
   ```

3. **View Status**
   ```
   view_requirements_status()
   ```
4. **Architecture Design**
   ```
   architecture_designer("Online Education Platform Architecture")
   ```

5. **Export Document**
   ```
   export_final_document()
   ```

## 🚀 Get Started

### Quick Start
1. **Configure Claude Desktop** (refer to the configuration method above)
2. **Restart Claude Desktop**
3. **Start Intelligent Requirement Analysis**:
   ```
   requirement_clarifier("Describe your project idea")
   ```
4. **Follow the AI’s intelligent guidance** to gradually refine each requirement branch
5. **Export the complete document**:
   ```
   export_final_document()
   ```

### Best Practices
- 💬 **Trust AI’s Branch Management**: Let the AI guide you through all requirement branches
- 🎯 **Clearly Express Preferences**: Clearly state your preferences for technology stack, UI style, etc.
- 📊 **Regularly Check Status**: Use `view_requirements_status` to track progress
- 🤖 **Authorize AI Appropriately**: For uncertain parts, you can say "use the standard solution"

---

**🎯 Now you have a truly intelligent AI development assistant that remembers every detail and guides you through a complete requirement analysis!**

## 💬 Community Group

<div align="center">
<img src="https://raw.githubusercontent.com/jiemobasixiangcai/ai-develop-assistant/main/./assets/qr-code.jpg" width="200" alt="Community Group">
<br>
Community Group
</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---