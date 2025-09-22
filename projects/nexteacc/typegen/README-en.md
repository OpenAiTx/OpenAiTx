# TypeGen - Intelligent Text Style Transformation Tool

TypeGen is a modern AI-driven text style transformation application based on Next.js. By integrating the OpenAI API, it provides intelligent conversion among multidimensional writing styles, structural templates, and strategy parameters, equipped with an intuitive drag-and-drop interactive interface.

## 🎯 Core Features

### Intelligent Text Transformation
- **AI Driven**: Integrated with OpenAI GPT-4o-mini for authentic text style transformation
- **28 Style Filters**: Covering writing tone, structural framework, and communication strategy across three dimensions
- **Intelligent Word Count Control**: Supports target length settings, from concise summaries to detailed expansions
- **Real-time Conversion**: Fast response API processing for a smooth user experience

### Intuitive Interaction Design
- **Drag-and-Drop Operation**: Drag style filters into the text box to start conversion
- **Visual Feedback**: Rich animations and status indicators
- **Comparison Display**: Side-by-side layout comparing before and after conversion
- **One-Click Actions**: Copy results, try other styles, restart

## 🛠️ Technical Architecture

### Frontend Tech Stack
- **Framework**: [Next.js](https://nextjs.org/) 15.5.0 (developed using Turbopack)
- **UI Library**: [React](https://reactjs.org/) 19.0.0
- **Styling System**: [Tailwind CSS](https://tailwindcss.com/) 4.1.11
- **Animation Library**: [Framer Motion](https://www.framer.com/motion/) 12.23.6
- **Type Safety**: [TypeScript](https://www.typescriptlang.org/) 5
- **Package Manager**: [pnpm](https://pnpm.io/)

### Core Components
- **Drag-and-Drop System**: Professional drag-and-drop interaction based on @dnd-kit/core
- **Style Management**: Dynamic style processing with clsx and tailwind-merge
- **UI Components**: Custom component library based on Radix UI

## 📂 Project Structure

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

## 🎨 Style Filters Overview

### Stylistic Styles (Style)

**News / Academic / Textbook**
- AP Style
- APA Style
- IEEE Style
- Textbook Style
- Investigative

**Community / Platform Culture**
- 4chan Style
- Reddit Style
- BuzzFeed
- Twitter Style
- Instagram Caption
- Meme Style

**Fiction / Creative Writing**
- Hemingway Style

### Structural Templates (Structure)

**News / Information Structure**
- Inverted Pyramid
- Headline Driven

**Lists / Threads / Tutorials**
- Listicle
- Threaded
- How-to
- Bullet-pointed

**Academic / Narrative Structure**
- IMRaD

### Strategies & Parameters (Strategy & Controls)
- Clickbait
- Call to Action  
- SEO Optimized  
- FOMO Driven  
- Hashtag Heavy  
- Emoji Laden  
- Flesch-Kincaid  
- Citation Heavy  
- Technical Jargon  

## ⚙️ Configuration Guide  

### Environment Setup  
1. **Obtain OpenAI API Key**
   ```bash
   # 访问 https://platform.openai.com/account/api-keys
   # 创建新的 API 密钥
   ```
2. **Configure Environment Variables**

   ```bash
   cp .env.example .env.local
   ```
   Edit the `.env.local` file:

   ```bash
   OPENAI_API_KEY=sk-proj-your_api_key_here
   OPENAI_MODEL=gpt-4o-mini                    # 可选，默认值
   OPENAI_MAX_TOKENS=2000                      # 可选，默认值
   OPENAI_TEMPERATURE=0.7                      # 可选，默认值
   API_TIMEOUT=30000                           # 可选，30秒超时
   API_MAX_RETRIES=3                           # 可选，最大重试次数
   ```
### Local Development

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

## 🔧 Core Implementation

### State Management
The application uses a complete state machine pattern to manage the transformation process:
- `idle`: Initial state, waiting for text input
- `readyToTransform`: Text ready, transformation can proceed
- `transforming`: Transformation in progress, showing loading status
- `transformed`: Transformation complete, displaying result comparison

### API Integration
- **Type Safety**: Complete TypeScript type definitions
- **Error Handling**: Layered error handling and user-friendly error messages
- **Performance Optimization**: API response caching and request deduplication
- **Retry Mechanism**: Automatic retries on network failure

### Interaction Experience (Desktop)
- **Drag and Drop**: Smooth drag animations and visual feedback
- **Word Count Control**: Real-time word count and target length settings
- **Result Operations**: One-click copy, retry, and restart
- **Platform Note**: Current version is desktop-only; no interaction provided for mobile

## 🚀 Expansion Directions

- **Multilingual Support**: Add internationalization support
- **Batch Processing**: Support multiple texts transformed simultaneously
- **Custom Styles**: Allow users to create personalized styles
- **Collaboration Features**: Team sharing and commenting functionality
- **Data Analytics**: Usage statistics and effect analysis


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---