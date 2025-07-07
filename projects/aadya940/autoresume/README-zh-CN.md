<p align="center">
  <img src="https://raw.githubusercontent.com/aadya940/autoresume/main/main_app/frontend/public/autoresume-logo.png" alt="autoResume Logo" title="autoResume Logo" width="180"/>
</p>

<h1 align="center">autoResume</h1>

<p align="center">
  <b>开源简历生成器，粘贴你的链接，手动编辑，让 AI 帮助你润色、更新并定制你的简历。</b>
</p>

---

### 如何使用？

[Medium 博客链接](https://medium.com/@aadyachinubhai/autoresume-copy-and-paste-links-its-that-simple-8e50e6d155a1)

该博客关于用户界面和模板部分内容已过时。

## 功能

- <b>便捷链接导入：</b> 从网站粘贴链接，快速生成 PDF 简历。
- <b>内置手动编辑器：</b> 使用嵌入式代码编辑器，从零开始或微调你的简历。
- <b>智能建议：</b> 提供反馈或新链接，智能编辑帮助你完善和更新简历。
- <b>职位定制：</b> 粘贴职位描述，获取简历匹配建议。
- <b>LaTeX 高质量：</b> 所有简历均通过 LaTeX 生成，布局简洁专业。
- <b>即时预览：</b> 实时以 PDF 形式查看你的简历。
- <b>一键重置：</b> 一键清空并重新开始你的简历。
- <b>本地运行：</b> 通过 Docker 完全在本地机器上运行。

---

## 快速开始

### 前置条件
- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/)

### 安装

1. 克隆仓库：
   ```bash
   git clone https://github.com/aadya940/autoresume.git
   cd autoresume
   ```
2. 构建并启动应用：
   ```bash
   docker compose up --build
   ```
3. 访问应用：
   
   [_http://localhost:5173_](http://localhost:5173)
---

## 使用方法

1. 在浏览器中打开 autoResume。
2. 点击 :gear: 图标，粘贴你的 [GOOGLE API KEY](https://aistudio.google.com/) 和邮箱地址。
3. 粘贴你的职业信息链接（如 Github、个人网站等）。
4. 可选，添加反馈或职位信息链接以进一步定制。
5. 点击 <b>生成简历</b>，让 AI 完成剩下的工作！

---

## 许可证

本项目采用 Apache 2.0 许可证授权。

## 贡献指南

### 前端
- 在 `frontend/src/components/` 文件夹实现 React 组件
- 我们使用 Chakra UI 实现组件。
- 在 `frontend/src/App.jsx` 文件中导入并使用你的组件

### 后端
- 在 `backend/src/routes/` 目录实现 API 路由
- 在 `backend/src/ai/` 目录添加 AI 功能
- Python 代码使用 `black` 格式化工具
- 保持路由处理器简洁，逻辑分离

### 通用规范
- 为你的功能/修复新建分支：`git checkout -b your-branch-name`
- 编写清晰的提交信息
- 在提交 PR 前测试你的更改

### 提交更改
1. 创建 Pull Request
2. 在你的 PR 描述中包含：
   - 你做了哪些更改
   - 更改原因
   - 相关截图或测试结果
   - 任何重大变更或迁移步骤

感谢你的贡献，我们会尽快审核你的 PR！

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---