# AI Novel Editor

基于PyQt6的AI辅助小说编辑器，提供智能补全、项目管理、概念组织等专业写作工具。

## 安装

1. 克隆项目
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. 创建虚拟环境
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```

3. 安装依赖
```bash
pip install -r requirements.txt
```

4. 运行程序
```bash
python src/main.py
```

## 主要功能

### 项目管理
- 层次化文档结构（作品 > 章节 > 场景）
- 项目导入导出（支持TEXT、MARKDOWN、DOCX、PDF、HTML格式）
- 自动备份和版本控制
- 多项目管理

### AI补全功能
- 三种补全模式：自动补全、手动补全(推荐 按一次tab触发一次 再按一次tab应用补全)、禁用补全
- 三种上下文模式：
  - 快速模式：轻量级上下文，快速响应
  - 平衡模式：中等上下文，质量与速度平衡
  - 全局模式：完整项目上下文，最佳效果
- 支持多种AI服务：OpenAI、Claude、通义千问、智谱AI、DeepSeek、Groq等

### 大纲管理
- 可视化大纲树结构
- 拖拽排序和层级调整
- 文档快速导航
- 大纲分析和优化建议

### API配置
- 统一的AI配置中心
- 多服务商预设配置
- 连接测试功能
- 配置方案保存和导入导出

### 智能补全设置
- 可调节的触发延迟
- 补全长度限制
- 上下文长度配置
- 流式响应支持

### 提示词编辑
- 内置多种写作模板
- 自定义提示词模板
- 模板分类管理
- 模式特定模板配置

### 界面功能
- 明暗双主题
- 三栏式布局（项目树、编辑器、概念面板）
- 可折叠侧边栏
- 全屏写作模式
- 专注模式（句子、段落、打字机、禅模式、沉浸模式）

### 搜索和替换
- 全项目文本搜索
- 正则表达式支持
- 批量替换功能
- 高级搜索选项

### 概念管理
- 自动检测角色、地点、物品
- 概念关系管理
- 标签和分类系统
- 概念快速插入

## 快捷键

- `Ctrl+N`: 新建项目
- `Ctrl+O`: 打开项目
- `Ctrl+S`: 保存文档
- `F11`: 全屏模式
- `Tab`: 手动触发AI补全（手动模式下）
- `Ctrl+F`: 查找
- `Ctrl+H`: 查找替换
- `Ctrl+Shift+H`: 高级查找替换


## 系统要求

- Python 3.8+
- PyQt6
- 操作系统：Windows、macOS、Linux

## 作者

**inliver**
- 邮箱：inliverapi@outlook.com  
- GitHub：https://github.com/inliver233