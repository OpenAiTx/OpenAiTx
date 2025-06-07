# EmuReady

一个由社区驱动的平台，用于跟踪不同设备和模拟器的兼容性信息。

访问我们的网站：[https://emuready.com](https://emuready.com)

---

**主页截图**

<img src="https://github.com/user-attachments/assets/9a7077fd-a9b1-4a1c-8a81-8f9beed25581" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/df612c7c-4b9d-481b-ae92-175b2b6afb0b" width="48%">

---

**兼容性列表页面截图**

<img src="https://github.com/user-attachments/assets/400c48d4-6340-4a60-8d86-f996a35f1bf4" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/4ca1c1de-3616-4c25-81b9-ad80f8a69458" width="48%">

---

**游戏页面截图**

<img src="https://github.com/user-attachments/assets/b036de53-18ed-4bf4-8117-5cd36e87ee31" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/9fbe12c4-3387-4e1d-986a-df80761134e3" width="48%">

---

## 概述

EmuReady 帮助用户在不同的硬件和软件配置下，分享和发现模拟器兼容性信息。用户可以提交兼容性报告、对列表进行投票，并就特定游戏/设备/模拟器组合进行讨论。

![许可证](https://img.shields.io/github/license/Producdevity/emuready?cacheSeconds=1)
![星标](https://img.shields.io/github/stars/Producdevity/emuready?cacheSeconds=1)
![分叉](https://img.shields.io/github/forks/Producdevity/emuready?cacheSeconds=1)
![问题](https://img.shields.io/github/issues/Producdevity/emuready?cacheSeconds=1)

## 功能

- **全面的兼容性数据库**：跟踪游戏在不同模拟器和设备上的表现
- **用户贡献**：社区驱动的报告和投票系统
- **讨论系统**：带有点赞/点踩功能的评论线程
- **管理后台**：用户、列表和内容管理
- **响应式设计**：适配移动端、平板和桌面端

## 最近的改进

代码库已通过以下增强进行了显著改进：

### UI 组件

- 创建了 **ErrorBoundary** 组件，用于更好的错误处理和恢复
- 增加了基于 Next.js Image 组件的 **OptimizedImage**，提升性能
- 优化了 **Pagination**，提升可访问性、支持键盘导航并优化用户体验
- 增强了 **Badge** 组件，支持更多变体、尺寸及药丸形态
- 增加了 **ThemeToggle** 组件，用于切换浅色、深色和系统主题
- 实现了带有视觉指示的 **SortableHeader**，支持表格排序

### 缓存与性能

- 优化 React Query 配置，改进缓存、过期时间和重试逻辑
- 增加设备图片的图片优化
- 全面实现了错误处理机制

### 可访问性

- 增强交互元素的键盘导航
- 增加了正确的 ARIA 标签和角色
- 改善了焦点管理
- UI 组件的色彩对比度更佳

### 安全性

- 在客户端、服务端和数据库多层次实现数据校验与清洗
- 实现内容安全策略（CSP）
- 防护 XSS 和 CSRF 攻击
- 使用 NextAuth.js 实现安全认证
- 文件上传校验与安全措施
- 输入长度限制及数据清洗
- UUID 校验防止参数篡改

### 开发体验

- 增加更多 npm 脚本以优化开发流程
- 项目结构更合理，导出更统一
- 自定义 ErrorBoundary 提升错误反馈
- 改进 404 页面，提供便捷导航选项

### 主题系统

- 支持系统主题偏好检测
- 多种 UI 选项的主题切换
- 全面优化暗色模式实现

## 快速开始

### 前置条件

- Node.js 20+
- `npm`
- PostgreSQL（开发可用 SQLite）

### 安装

1. 克隆仓库

```bash
git clone https://github.com/Producdevity/emuready.git
cd emuready
```

2. 安装依赖

```bash
npm install
```

3. 设置环境变量

```bash
cp .env.example .env
```

然后编辑 `.env` 文件，填写数据库凭证和其他配置信息。

4. 配置数据库

```bash
npx prisma generate
npx prisma db push
```

5. 运行开发服务器

```bash
npm run dev
```

6. 在浏览器中打开 [http://localhost:3000](http://localhost:3000)

## 可用脚本

- `npm run dev` - 启动开发服务器
- `npm run dev:strict` - 使用 React 严格模式启动
- `npm run build` - 打包生产环境
- `npm run start` - 启动生产环境服务器
- `npm run test` - 运行测试
- `npm run lint` - 运行 ESLint 检查
- `npm run lint:fix` - 自动修复代码风格问题
- `npm run format` - 使用 Prettier 格式化代码
- `npm run typecheck` - 检查 TypeScript 类型
- `npm run analyze` - 分析包体积
- `npm run clean` - 清除构建缓存
- `npm run prepare-deploy` - 部署准备（lint、typecheck、test、build）

### Prisma 命令

- `npx prisma db seed` - 数据库种子填充
- `npx prisma studio` - 打开 Prisma Studio
- `npx prisma db pull` - 拉取数据库结构
- `npx prisma db push` - 推送数据库结构

更多详情请参阅 [Prisma Cli Reference](https://www.prisma.io/docs/orm/reference/prisma-cli-reference)。

## 技术栈

- **框架**：Next.js 15
- **数据库 ORM**：Prisma
- **API**：tRPC
- **认证**：NextAuth.js
- **样式**：Tailwind CSS
- **状态管理**：React Query
- **类型检查**：TypeScript
- **动效**：Framer Motion
- **校验**：Zod、内容安全策略、输入校验

## 贡献

欢迎您的贡献！请参阅我们的[贡献指南](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CONTRIBUTING.md)获取更多信息。

## 许可证

本项目采用 MIT 许可证，详情请参见 [LICENSE](https://raw.githubusercontent.com/Producdevity/EmuReady/master/LICENSE) 文件。

## 行为准则（待完善）

请注意，本项目遵循[行为准则](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CODE_OF_CONDUCT.md)。参与本项目即表示您同意遵守相关规定。

## 安全（待完善）

如您发现安全漏洞，请参阅我们的[安全策略](https://raw.githubusercontent.com/Producdevity/EmuReady/master/SECURITY.md)进行报告。

## 鸣谢

- 所有[贡献者](https://github.com/Producdevity/emuready/graphs/contributors)
- 模拟器社区的启发与支持

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---