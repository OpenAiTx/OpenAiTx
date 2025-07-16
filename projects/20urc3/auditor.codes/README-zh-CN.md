# 代码审计员 CTF
![image](https://github.com/user-attachments/assets/fdfbbffc-71f9-4463-856d-aca054399a0f)

一个基于网页的夺旗赛（CTF）平台，提供无与伦比的源代码审计挑战的深度和广度。拥有迄今为止最大规模的真实 C/C++ 漏洞示例集合，用户可以分析真实代码片段，识别复杂的安全漏洞，并通过实践掌握安全编码规范。

我们全面的培训环境包含数千个精心策划的挑战，涵盖整个漏洞谱系——从经典缓冲区溢出到最隐蔽的内存破坏漏洞。没有其他平台能提供如此完整的源代码安全教育。

### 本应用目前处于 ALPHA 阶段，完全通过大型语言模型辅助“vibe 编码”完成。

这意味着什么？开发过程优先考虑创造性流程和快速迭代，而非传统软件工程实践。
作为 ALPHA 版本，用户应视自己为平台的活跃测试者。在探索过程中，您可能会遇到错误、意外行为和未完成的功能。这些体验是我们开发过程的组成部分，而非例外。
通过使用本平台，您正在参与其演变并助力塑造未来。我们鼓励您报告任何问题，分享见解，提出改进建议，帮助将这一 LLM 辅助创作转变为更稳定、更完善的工具。

## 功能 ✨

* **漏洞挑战：** 练习识别 C/C++ 代码片段中的各种 CWE（通用弱点枚举）。
* **多难度等级：** 按难度分类的挑战（简单、中等、困难、疯狂 - *注意：当前实现可能较为简化*）。
* **代码差异视图：** 并排比较有漏洞代码与修复版本。
* **用户认证：** 使用 Flask-Login 实现安全的用户注册、登录和登出功能。
* **持久进度：** 用户分数和完成的挑战在数据库中跟踪。
* **用户资料：** 查看个人分数和完成统计。
* **排行榜：** 查看您在审计员中的排名！
* **教育内容：** 专门的“学习”部分，提供全面的漏洞识别资源。
* **现代界面：** 使用 Tailwind CSS 实现暗色主题的登录/认证页面，Prism.js 用于代码高亮。
* **丰富挑战数据集：** 包含超过 7000+ 个来自真实 C/C++ 代码片段的挑战。*(基于 Icyrockton 优秀的 [MegaVul 数据集](https://github.com/Icyrockton/MegaVul))*。

## 技术栈 ️

* **后端：**
    * Python 3
    * Flask（Web 框架）
    * Flask-Login（用户会话管理）
    * Werkzeug（密码哈希，WSGI 工具）
    * SQLite（数据库）
    * Gunicorn（生产环境 WSGI 服务器 - 推荐）
* **前端：**
    * HTML5
    * CSS3（含自定义样式）
    * Tailwind CSS（用于特定页面如登录/认证）
    * 原生 JavaScript（DOM 操作，API 调用）
    * Prism.js（语法高亮）

*部署配置信息见 `conf/readme.md`*

## 数据库模式

应用使用 SQLite 数据库（`auditor_challenges.db`），包含以下主要表：

* **`users`**：存储用户信息。
    * `id`（INTEGER，主键，自增）：唯一用户 ID。
    * `username`（TEXT，唯一，非空）：用户选择的名称。
    * `password_hash`（TEXT，非空）：安全哈希密码。
    * `created_at`（时间戳）：用户注册时间。
* **`user_progress`**：跟踪单个用户进度。
    * `user_id`（INTEGER，主键，外键 -> users.id）：关联用户。
    * `total_score`（INTEGER）：用户当前分数。
    * `completed_count`（INTEGER）：正确完成的挑战数量。
    * `seen_challenges`（TEXT）：用户已分配挑战 ID 的 JSON 字符串列表。
* **`challenges`**：存储 CTF 挑战数据（源自 MegaVul 等）。
    * `id`（INTEGER，主键）：唯一挑战 ID。
    * `title`（TEXT）：挑战标题。
    * `vulnerable_code`（TEXT）：含漏洞代码片段。
    * `fixed_code`（TEXT）：修复版本代码（用于差异视图）。
    * `difficulty`（TEXT）：如“easy”、“medium”、“hard”、“insane”。
    * `cwe_id`（TEXT）：漏洞对应的主要 CWE（如“CWE-120”）。
    * `cwe_name`（TEXT）：CWE 描述名称。
    * `cve_id`（TEXT，可选）：相关 CVE 标识符（如有）。
    * `solution`（TEXT）：漏洞及修复说明。

## 使用方法

1. 访问应用网址。
2. 通过“我的账户”下拉菜单注册新账号或登录。
3. 进入“挑战”页面（`/ctf`）。
4. 使用下拉菜单选择难度等级。
5. 加载挑战，分析源代码。
6. 可选地点击“显示差异视图”按钮查看修复版本对比（会扣分）。
7. 从单选按钮中选择您认为代码中存在的 CWE。
8. 点击“提交评估”。
9. 查看结果、解释及更新后的分数。
10. 在结果页点击“加载下一个挑战”按钮，或在难度下拉旁点击“新挑战”按钮获取新挑战。
11. 在“个人资料”页面查看进度，在“排行榜”查看排名（两者均可通过“我的账户”下拉菜单访问）。

## 致谢

* 本项目所用挑战数据集基于 Icyrockton 创建的 [MegaVul 数据集](https://github.com/Icyrockton/MegaVul)。

## 贡献

欢迎贡献！请随时提交拉取请求或打开问题报告 bug、功能请求或改进建议。

## 许可证

本项目采用 MIT 许可证 - 详情请参阅 [LICENSE.md](https://raw.githubusercontent.com/20urc3/auditor.codes/main/LICENSE.md) 文件。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---