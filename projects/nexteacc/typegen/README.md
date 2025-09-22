# TypeGen - 智能文本风格转换工具

TypeGen 是一个基于 Next.js 的现代化 AI 驱动文本风格转换应用。通过集成 OpenAI API，提供多维度的写作风格、结构模板与策略参数之间的智能转换，并配备直观的拖拽式交互界面。

## 🎯 核心功能

### 智能文本转换
- **AI 驱动**: 集成 OpenAI GPT-4o-mini 进行真实的文本风格转换
- **28 种风格滤镜**: 覆盖写作语体、结构骨架、传播策略三大维度
- **智能字数控制**: 支持目标长度设置，从简洁摘要到详细展开
- **实时转换**: 快速响应的 API 处理，提供流畅用户体验

### 直观交互设计
- **拖拽式操作**: 将风格滤镜拖拽至文本框即可开始转换
- **视觉反馈**: 丰富的动画效果和状态指示
- **对比展示**: 转换前后双栏对比布局
- **一键操作**: 复制结果、尝试其他风格、重新开始

## 🛠️ 技术架构

### 前端技术栈
- **框架**: [Next.js](https://nextjs.org/) 15.5.0 (使用 Turbopack 进行开发)
- **UI 库**: [React](https://reactjs.org/) 19.0.0
- **样式系统**: [Tailwind CSS](https://tailwindcss.com/) 4.1.11
- **动画库**: [Framer Motion](https://www.framer.com/motion/) 12.23.6
- **类型安全**: [TypeScript](https://www.typescriptlang.org/) 5
- **包管理器**: [pnpm](https://pnpm.io/)

### 核心组件
- **拖拽系统**: 基于 @dnd-kit/core 的专业拖拽交互
- **样式管理**: clsx 和 tailwind-merge 的动态样式处理
- **UI 组件**: 基于 Radix UI 的自定义组件库

## 📂 项目结构

```
├── app/                           # Next.js App Router
│   ├── api/transform/route.ts     # 文本转换 API 端点
│   ├── page.tsx                   # 主应用界面
│   ├── layout.tsx                 # 根布局组件
│   └── globals.css                # 全局样式
├── components/                    # UI 组件库
│   ├── style-filter/              # 风格滤镜系统
│   │   ├── types.ts              # 类型定义
│   │   ├── filters-data.ts       # 风格数据配置
│   │   ├── filter-container.tsx  # 滤镜容器组件
│   │   └── ...                   # 动画和交互组件
│   ├── ui/                       # 基础 UI 组件
│   ├── length-control.tsx        # 字数控制滑动条
│   └── text-stats.tsx           # 文本统计显示
├── lib/                          # 业务逻辑层
│   ├── api-client.ts            # API 客户端封装
│   ├── transform-service.ts     # 转换服务核心
│   ├── openai-service.ts        # OpenAI API 集成
│   └── api-types.ts             # API 类型定义
├── public/icons/                # 风格图标资源
└── utils/                       # 工具函数
```

## 🎨 风格滤镜一览

### 文体风格（Style）

**新闻 / 学术 / 教科书**
- AP Style
- APA Style
- IEEE Style
- Textbook Style
- Investigative

**社群 / 平台文化**
- 4chan Style
- Reddit Style
- BuzzFeed
- Twitter Style
- Instagram Caption
- Meme Style

**小说 / 创意写作**
- Hemingway Style

### 结构模板（Structure）

**新闻 / 资讯结构**
- Inverted Pyramid
- Headline Driven

**列表 / 线程 / 教程**
- Listicle
- Threaded
- How-to
- Bullet-pointed

**学术 / 叙事结构**
- IMRaD

### 策略与参数（Strategy & Controls）
- Clickbait
- Call to Action
- SEO Optimized
- FOMO Driven
- Hashtag Heavy
- Emoji Laden
- Flesch-Kincaid
- Citation Heavy
- Technical Jargon

## ⚙️ 配置指南

### 环境配置
1. **获取 OpenAI API 密钥**
   ```bash
   # 访问 https://platform.openai.com/account/api-keys
   # 创建新的 API 密钥
   ```

2. **配置环境变量**
   ```bash
   cp .env.example .env.local
   ```

   编辑 `.env.local` 文件：
   ```bash
   OPENAI_API_KEY=sk-proj-your_api_key_here
   OPENAI_MODEL=gpt-4o-mini                    # 可选，默认值
   OPENAI_MAX_TOKENS=2000                      # 可选，默认值
   OPENAI_TEMPERATURE=0.7                      # 可选，默认值
   API_TIMEOUT=30000                           # 可选，30秒超时
   API_MAX_RETRIES=3                           # 可选，最大重试次数
   ```

### 本地开发
```bash
# 安装依赖
pnpm install

# 启动开发服务器
pnpm dev

# 构建生产版本
pnpm build

# 代码检查
pnpm lint
```

## 🔧 核心实现

### 状态管理
应用使用了完整的状态机模式管理转换流程：
- `idle`: 初始状态，等待文本输入
- `readyToTransform`: 文本就绪，可进行转换
- `transforming`: 转换进行中，显示加载状态
- `transformed`: 转换完成，展示结果对比

### API 集成
- **类型安全**: 完整的 TypeScript 类型定义
- **错误处理**: 分层错误处理和用户友好的错误信息
- **性能优化**: API 响应缓存和请求去重
- **重试机制**: 网络失败时自动重试

### 交互体验（桌面端）
- **拖拽操作**: 流畅的拖拽动画和视觉反馈
- **字数控制**: 实时字数统计和目标长度设置
- **结果操作**: 一键复制、重试和重新开始
- **平台说明**: 当前版本仅面向桌面端使用，移动端未提供交互

## 🚀 扩展方向

- **多语言支持**: 添加国际化支持
- **批量处理**: 支持多文本同时转换
- **自定义风格**: 允许用户创建个性化风格
- **协作功能**: 团队共享和评论功能
- **数据分析**: 使用统计和效果分析
