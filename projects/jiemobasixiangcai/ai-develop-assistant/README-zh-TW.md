# 🚀 MCP AI開發助手

> 協助AI開發者進行智能化需求分析與架構設計的MCP工具

## ✨ 核心特性

- **智能需求澄清**: 自動識別專案類型，生成針對性問題
- **分支感知管理**: 追蹤專案目標、功能設計、技術偏好、UI設計等維度
- **架構自動生成**: 基於完整需求生成技術架構方案
- **持久化儲存**: 自動保存分析結果，支援匯出文件

## 📁 快速配置

### 舊版本配置
1. **克隆代碼**
   ```bash
   git clone https://github.com/jiemobasixiangcai/ai-develop-assistant.git
   ```
2. **推薦虛擬環境**
   ```bash
   python -m venv venv
   source venv/bin/activate  # Unix/Linux/MacOS
   venv\Scripts\activate  # Windows
   ```
3. **安裝依賴**
   ```bash
   pip install -r requirements.txt
   ```

4. **配置文件位置**
   ```
   Windows: %APPDATA%\Claude\claude_desktop_config.json
   macOS: ~/Library/Application Support/Claude/claude_desktop_config.json
   ```

5. **添加配置**
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

3. **重啟Claude Desktop**

### 新版本配置
#### 🔧 核心工具
1. **start_new_project** - 開始新專案
2. **create_requirement_blueprint** - 建立需求藍圖
3. **requirement_clarifier** - 獲取需求澄清提示
4. **save_clarification_tasks** - 保存澄清任務
5. **update_branch_status** - 更新分支狀態
6. **requirement_manager** - 需求文件管理器
7. **check_architecture_prerequisites** - 檢查架構前置條件
8. **get_architecture_design_prompt** - 獲取架構設計提示
9. **save_generated_architecture** - 保存生成的架構設計
10. **export_final_document** - 匯出完整文件
11. **view_requirements_status** - 查看需求狀態

#### 配置（遠端直連複製到你的工具中，將MCP_STORAGE_DIR替換為你的本地目錄）
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

## 🎯 使用流程

### 基本步驟

1. **需求澄清**
   ```
   requirement_clarifier("我要做一個線上教育平台")
   ```

2. **需求管理**
   ```
   requirement_manager("目標用戶：學生和教師", "專案概述")
   ```

3. **查看狀態**
   ```
   view_requirements_status()
   ```

4. **架構設計**
   ```
   architecture_designer("線上教育平台架構")
   ```

5. **導出文件**
   ```
   export_final_document()
   ```

## 🚀 開始使用

### 快速上手
1. **配置Claude Desktop**（參考上面的配置方法）
2. **重啟Claude Desktop**
3. **開始智慧需求分析**：
   ```
   requirement_clarifier("描述你的專案想法")
   ```
4. **跟隨AI的智慧引導**，逐步完善各個需求分支
5. **導出完整文件**：
   ```
   export_final_document()
   ```

### 最佳實踐
- 💬 **信任AI的分支管理**：讓AI引導你完成所有需求分支
- 🎯 **明確表達偏好**：對技術選型、UI風格等明確表達偏好
- 📊 **定期查看狀態**：使用 `view_requirements_status` 了解進度
- 🤖 **適當授權AI**：對不確定的部分可以說「用常規方案」

---

**🎯 現在您擁有了一個真正智慧的AI開發助手，它會記住每個細節，引導您完成完整的需求分析！**

## 💬 交流群

<div align="center">
<img src="https://raw.githubusercontent.com/jiemobasixiangcai/ai-develop-assistant/main/./assets/qr-code.jpg" width="200" alt="交流群">
<br>
交流群
</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---