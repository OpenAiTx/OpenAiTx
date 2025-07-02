# 🚀 MCP AI开发助手

> 协助AI开发者进行智能化需求分析与架构设计的MCP工具

## ✨ 核心特性

- **智能需求澄清**: 自动识别项目类型，生成针对性问题
- **分支感知管理**: 跟踪项目目标、功能设计、技术偏好、UI设计等维度
- **架构自动生成**: 基于完整需求生成技术架构方案
- **持久化存储**: 自动保存分析结果，支持导出文档

## 📁 快速配置

### 旧版本配置
1. **克隆代码**
   ```bash
   git clone https://github.com/jiemobasixiangcai/ai-develop-assistant.git
   ```
2. **推荐虚拟环境**
   ```bash
   python -m venv venv
   source venv/bin/activate  # Unix/Linux/MacOS
   venv\Scripts\activate  # Windows
   ```
3. **安装依赖**
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

3. **重启Claude Desktop**

### 新版本配置
#### 🔧 核心工具
1. **start_new_project** - 开始新项目
2. **create_requirement_blueprint** - 创建需求蓝图
3. **requirement_clarifier** - 获取需求澄清提示
4. **save_clarification_tasks** - 保存澄清任务
5. **update_branch_status** - 更新分支状态
6. **requirement_manager** - 需求文档管理器
7. **check_architecture_prerequisites** - 检查架构前置条件
8. **get_architecture_design_prompt** - 获取架构设计提示
9. **save_generated_architecture** - 保存生成的架构设计
10. **export_final_document** - 导出完整文档
11. **view_requirements_status** - 查看需求状态

#### 配置（远程直连复制到你的工具中，将MCP_STORAGE_DIR替换为你的本地目录）
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

### 基本步骤

1. **需求澄清**
   ```
   requirement_clarifier("我要做一个在线教育平台")
   ```

2. **需求管理**
   ```
   requirement_manager("目标用户：学生和教师", "项目概述")
   ```

3. **查看状态**
   ```
   view_requirements_status()
   ```

4. **架构设计**
   ```
   architecture_designer("在线教育平台架构")
   ```

5. **导出文档**
   ```
   export_final_document()
   ```

## 🚀 开始使用

### 快速上手
1. **配置Claude Desktop** (参考上面的配置方法)
2. **重启Claude Desktop**
3. **开始智能需求分析**：
   ```
   requirement_clarifier("描述你的项目想法")
   ```
4. **跟随AI的智能引导**，逐步完善各个需求分支
5. **导出完整文档**：
   ```
   export_final_document()
   ```

### 最佳实践
- 💬 **信任AI的分支管理**：让AI引导你完成所有需求分支
- 🎯 **明确表达偏好**：对技术选型、UI风格等明确表达偏好
- 📊 **定期查看状态**：使用 `view_requirements_status` 了解进度
- 🤖 **适当授权AI**：对不确定的部分可以说"用常规方案"

---

**🎯 现在您拥有了一个真正智能的AI开发助手，它会记住每个细节，引导您完成完整的需求分析！**

## 💬 交流群

<div align="center">
<img src="https://raw.githubusercontent.com/jiemobasixiangcai/ai-develop-assistant/main/./assets/qr-code.jpg" width="200" alt="交流群">
<br>
交流群
</div>