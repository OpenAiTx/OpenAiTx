## Orca引擎

Discord: https://discord.gg/bvdpdT26Tq

基于Godot引擎，由Simplifine进行增强。


### 有何亮点？
我们集成了一个聊天机器人，完全访问Godot。
聊天机器人可以：
  - 读取/编辑/创建/删除文件
  - 理解整个项目作为上下文
  - 创建图像并保持图像间的一致性
  - 编辑Godot原生对象，如节点、场景等

### AI助手功能

集成的聊天机器人拥有Godot开发的全面工具访问权限：

#### 场景与节点管理
- **场景操作**：打开、创建、保存和实例化场景
- **节点操作**：在场景树中创建、删除、移动和重命名节点
- **节点检查**：获取节点属性、脚本及层级信息
- **节点选择**：操作编辑器中当前选中的节点
- **类发现**：访问所有可用的Godot节点类及其功能

#### 脚本与代码管理
- **文件操作**：读取、写入及编辑任何项目文件，并支持行级定位
- **脚本生成**：利用AI生成新GDScript脚本文件
- **代码编辑**：通过自然语言提示对现有脚本进行智能编辑
- **错误检测**：检查单文件或整个项目的编译错误
- **脚本附加**：附加和管理节点上的脚本

#### 项目导航与搜索
- **文件系统**：浏览项目目录及文件，支持筛选选项
- **高级语义搜索**：使用自然语言查询查找相关文件和代码，具备**函数级智能**
- **多跳依赖追踪**：理解项目中完整的函数调用链和信号流
- **图形分析**：发现关联文件、核心项目组件及架构关系
- **智能搜索模式**：语义（AI理解）、关键词（精确文本）或混合（结合）搜索

> 🔍 **[查看高级索引文档](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/indexing.md)**，了解函数级分块、信号流跟踪和依赖分析的技术细节

#### 视觉内容创作
- **图像生成**：通过文本描述以多种艺术风格创建新图像
- **图像编辑**：使用 AI 驱动的编辑修改现有图像
- **3D 模型生成**：根据文本提示或图像生成 3D 模型（配置后启用）
- **资源管理**：将生成的图像保存到特定项目路径
- **风格一致性**：保持生成资源的视觉连贯性

#### 物理与游戏对象
- **碰撞形状**：为物理实体添加碰撞检测（矩形、圆形、胶囊形）
- **节点属性**：修改变换、物理和游戏属性
- **方法调用**：使用自定义参数执行节点方法

#### 信号与连接系统
- **信号检查**：列出可用信号及其连接
- **连接管理**：创建和管理节点间的信号连接
- **信号追踪**：通过轻量级事件跟踪调试信号流
- **连接验证**：验证信号连接的完整性

#### 开发工作流
- **多模型支持**：可选择 GPT-5、Claude-4、Gemini-2.5 和 GPT-4o
- **实时辅助**：流式响应并反馈工具执行情况
- **错误恢复**：智能切换 AI 提供商以保证可靠性
- **身份认证**：通过 OAuth（Google、GitHub、Microsoft）或访客模式安全访问

### 高级索引系统

Orca 引擎具备业内领先的 **Godot 索引系统**，实现对代码的 **函数级** 理解：

- **🎯 函数级智能**：每个 GDScript 函数、信号和导出变量都成为带丰富元数据的可搜索单元
- **🔗 信号流跟踪**：全面理解信号发射 → 连接 → 处理链，覆盖整个项目  
- **🕸️ 多跳依赖追踪**：追踪函数调用链（如 Input → Controller → Physics → Animation）
- **📊 图中心性分析**：识别架构关键文件及其结构角色
- **🔍 智能搜索模式**：语义（AI 理解）、关键词（精确文本）或混合（组合）搜索

**性能**：比传统基于行的索引智能分块多约 2.7 倍，支持对复杂游戏机制的精准理解。

> 📚 **[技术深度解析：高级索引](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/indexing.md)** | **[后端安装指南](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/README.md)**

### 快速开始（仅限编辑器）

构建并运行编辑器。AI 功能默认连接到我们的云端后端。无需本地后端设置。

macOS：
```bash
git clone https://github.com/Simplifine-gamedev/orca-engine.git
cd orca-engine
brew install scons pkg-config python3 git
scons platform=macos target=editor dev_build=yes vulkan=no -j"$(sysctl -n hw.ncpu)"
./bin/godot.macos.editor.dev.arm64
```

Windows（PowerShell）：
```powershell
git clone https://github.com/Simplifine-gamedev/orca-engine.git
cd orca-engine
# If needed: scoop install python scons git   (or: choco install python scons git)
scons platform=windows target=editor dev_build=yes vulkan=no -j $env:NUMBER_OF_PROCESSORS
.\bin\godot.windows.editor.dev.x86_64.exe
```

Linux（Ubuntu/Debian）：
```bash
git clone https://github.com/Simplifine-gamedev/orca-engine.git
cd orca-engine
sudo apt update
sudo apt install -y build-essential scons pkg-config libx11-dev libxcursor-dev libxinerama-dev \
  libgl1-mesa-dev libglu1-mesa-dev libasound2-dev libpulse-dev libudev-dev libxi-dev libxrandr-dev \
  python3 python3-pip git
scons platform=linuxbsd target=editor dev_build=yes vulkan=no -j"$(nproc)"
./bin/godot.linuxbsd.editor.dev.x86_64
```
备注：  
- 不需要 Vulkan SDK。编辑器使用平台默认渲染器（macOS 上为 Metal，Windows 上为 D3D12，Linux 上为 GLES3）。Vulkan 是可选的，构建或运行编辑器不需要它。  
- 若要将编辑器指向自托管后端而非云端，请参见下面的后端部分。  

### 后端（可选本地 / 云端部署）  

- 对于本地开发或自托管，请参阅 **[后端设置指南](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/README.md)**。其中涵盖环境变量、本地运行以及通过 `backend/deploy.sh` 部署到 Google Cloud Run。  
- 有关高级索引详情（函数级块、依赖图），请参阅 **[backend/indexing.md](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/indexing.md)**。  

#### 环境配置  

在 `backend/` 目录下创建一个 `.env` 文件，填写您的 API 密钥：


```env
# Required: AI provider for embeddings and chat
OPENAI_API_KEY=YOUR_OPENAI_API_KEY
# ANTHROPIC_API_KEY=YOUR_ANTHROPIC_API_KEY
# GOOGLE_API_KEY=YOUR_GOOGLE_API_KEY

# Required: For advanced vector search and function-level indexing
WEAVIATE_URL=https://YOUR-WEAVIATE-ENDPOINT
WEAVIATE_API_KEY=YOUR_WEAVIATE_API_KEY

# Optional: Additional configuration
FLASK_SECRET_KEY=YOUR_RANDOM_SECRET_KEY

# Development mode (set to 'false' in production)
DEV_MODE=true
```

> ⚙️ **[查看后端配置指南](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/README.md)** 获取完整的环境变量文档和部署说明

#### 索引性能（大型项目）

编辑器会自动触发服务器端索引。对于大型代码库，请设置以下内容以加快速度（在本地的 `backend/.env` 中或运行 `backend/deploy.sh` 之前设置，以便 Cloud Run 作为密钥读取）：

```env
# Parallelism and batching
INDEX_MAX_WORKERS=32         # number of parallel file workers on the backend
EMBED_MAX_PARALLEL=12        # concurrent embedding batches (respect provider limits)
EMBED_BATCH_SIZE=256         # embeddings per batch
CHUNK_MAX_LINES=100          # larger chunks = fewer embedding calls

# Small response caches
SEARCH_CACHE_TTL=45
GRAPH_CACHE_TTL=45
```
备注：
- 你也可以通过环境变量从编辑器传递 `INDEX_MAX_WORKERS`；它会被转发到后端用于 `index_project`/`index_files`。
- 部署到 Cloud Run 时，确保资源充足（例如，`--cpu 4`、`--memory 8Gi`、更高的 `--concurrency`）。

### Godot 文档搜索（RAG）

请参阅 **[Godot 文档搜索：索引与查询](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/./godot_doc_search.md)**。

#### 故障排除

**编辑器与构建问题：**
- **构建错误**：请参见 [上游 Godot 构建文档](https://docs.godotengine.org/en/stable/development/compiling/index.html) 了解平台特定问题
- **Python 依赖问题**：确保使用 Python 3.8 及以上版本，建议使用虚拟环境
- **缺少工具**：聊天机器人工具仅在后端连接建立后出现

**AI 后端问题：**
- **连接问题**：确认后端正在 http://localhost:8000 运行，且 API 密钥配置正确
- **搜索无效**：检查 Weaviate 连接（.env 文件中的 WEAVIATE_URL 和 WEAVIATE_API_KEY）
- **索引问题**：查看函数提取和依赖跟踪日志

> 🔧 **[详细后端故障排除](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/README.md#troubleshooting)**，涵盖向量搜索、索引和 API 配置问题

### 许可
- 上游 Godot 引擎代码：Expat（MIT 许可）。见 `LICENSE.txt`。
- 第三方组件：见 `COPYRIGHT.txt` 及 `thirdparty/` 目录下的许可文件。
- Simplifine 原始贡献：非商业源代码开放。见 `NOTICE` 和 `LICENSES/COMPANY-NONCOMMERCIAL.md`。

提供商业授权。联系方式：[support@simplifine.com]

### 归属说明
本项目基于 Godot 引擎，由 Godot 引擎贡献者 Juan Linietsky 和 Ariel Manzur 共同开发。我们与 Godot 项目无关联。

### 品牌声明
本项目为 Simplifine 独立发行。“Godot”及相关商标为其各自所有者所有。





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-26

---