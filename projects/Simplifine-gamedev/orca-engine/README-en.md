## Orca Engine

Discord: https://discord.gg/bvdpdT26Tq

Based on Godot Engine, with enhancements by Simplifine.


### What's the catch?
We are integrating a chat bot, with complete access to Godot. 
The chatbot can:
  - Read/edit/create/delete files
  - understand the entire project as context
  - create images and keep consistency across images created
  - edit godot native objects, e.g. nodes, scenes, ...

### AI Assistant Capabilities

The integrated chatbot has access to comprehensive tools for Godot development:

#### Scene & Node Management
- **Scene Operations**: Open, create, save, and instantiate scenes
- **Node Manipulation**: Create, delete, move, and rename nodes in the scene tree
- **Node Inspection**: Get node properties, scripts, and hierarchical information
- **Node Selection**: Work with currently selected nodes in the editor
- **Class Discovery**: Access all available Godot node classes and their capabilities

#### Script & Code Management
- **File Operations**: Read, write, and edit any project file with line-specific targeting
- **Script Generation**: Create new GDScript files with AI-powered code generation
- **Code Editing**: Apply intelligent edits to existing scripts with natural language prompts
- **Error Detection**: Check for compilation errors across single files or entire project
- **Script Attachment**: Attach and manage scripts on nodes

#### Project Navigation & Search
- **File System**: Browse project directories and files with filtering options
- **Advanced Semantic Search**: Find relevant files and code using natural language queries with **function-level intelligence**
- **Multi-Hop Dependency Tracing**: Understand complete function call chains and signal flows across your project
- **Graph Analysis**: Discover connected files, central project components, and architectural relationships
- **Smart Search Modes**: Semantic (AI understanding), keyword (exact text), or hybrid (combined) search

> 🔍 **[See Advanced Indexing Documentation](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/indexing.md)** for technical details on function-level chunking, signal flow tracking, and dependency analysis

#### Visual Content Creation
- **Image Generation**: Create new images from text descriptions with various art styles
- **Image Editing**: Modify existing images using AI-powered editing
- **3D Model Generation**: Generate 3D models from text prompts or images (when configured)
- **Asset Management**: Save generated images to specific project paths
- **Style Consistency**: Maintain visual coherence across generated assets

#### Physics & Game Objects
- **Collision Shapes**: Add collision detection to physics bodies (rectangle, circle, capsule)
- **Node Properties**: Modify transform, physics, and gameplay properties
- **Method Calls**: Execute node methods with custom parameters

#### Signal & Connection System
- **Signal Inspection**: List available signals and their connections
- **Connection Management**: Create and manage signal connections between nodes
- **Signal Tracing**: Debug signal flow with lightweight event tracking
- **Connection Validation**: Verify signal connection integrity

#### Development Workflow
- **Multi-Model Support**: Choose between GPT-5, Claude-4, Gemini-2.5, and GPT-4o
- **Real-time Assistance**: Stream responses with tool execution feedback
- **Error Recovery**: Intelligent fallback between AI providers for reliability
- **Authentication**: Secure access with OAuth (Google, GitHub, Microsoft) or guest mode

### Advanced Indexing System

Orca Engine features a **best-in-class Godot indexing system** that understands your code at the **function level**:

- **🎯 Function-Level Intelligence**: Each GDScript function, signal, and export becomes a searchable unit with rich metadata
- **🔗 Signal Flow Tracking**: Complete understanding of signal emission → connection → handler chains across your entire project  
- **🕸️ Multi-Hop Dependency Tracing**: Trace function call chains (e.g., Input → Controller → Physics → Animation)
- **📊 Graph Centrality Analysis**: Identify architecturally important files and their structural roles
- **🔍 Smart Search Modes**: Semantic (AI understanding), keyword (exact text), or hybrid (combined) search

**Performance**: ~2.7x more intelligent chunks than traditional line-based indexing, enabling precise understanding of complex game mechanics.

> 📚 **[Technical Deep Dive: Advanced Indexing](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/indexing.md)** | **[Backend Setup Guide](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/README.md)**

### Quick Start (Editor Only)

Build and run the editor. The AI features connect to our cloud backend by default. No local backend setup is required.

macOS:
```bash
git clone https://github.com/Simplifine-gamedev/orca-engine.git
cd orca-engine
brew install scons pkg-config python3 git
scons platform=macos target=editor dev_build=yes vulkan=no -j"$(sysctl -n hw.ncpu)"
./bin/godot.macos.editor.dev.arm64
```
Windows (PowerShell):

```powershell
git clone https://github.com/Simplifine-gamedev/orca-engine.git
cd orca-engine
# If needed: scoop install python scons git   (or: choco install python scons git)
scons platform=windows target=editor dev_build=yes vulkan=no -j $env:NUMBER_OF_PROCESSORS
.\bin\godot.windows.editor.dev.x86_64.exe
```
Linux (Ubuntu/Debian):

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

Notes:
- No Vulkan SDK required. The editor uses the platform default renderer (Metal on macOS, D3D12 on Windows, GLES3 on Linux). Vulkan is optional and not needed to build or run the editor.
- To point the editor to a self-hosted backend instead of cloud, see the backend section below.

### Backend (Optional Local / Cloud Deploy)

- For local development or self-hosting, follow the **[Backend Setup Guide](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/README.md)**. It covers environment variables, running locally, and deploying to Google Cloud Run via `backend/deploy.sh`.
- For advanced indexing details (function-level chunks, dependency graphs), see **[backend/indexing.md](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/indexing.md)**.

#### Environment Configuration

Create a `.env` file in the `backend/` directory with your API keys:

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

> ⚙️ **[See Backend Configuration Guide](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/README.md)** for complete environment variable documentation and deployment instructions

#### Indexing performance (large projects)

The editor triggers server-side indexing automatically. For large codebases, set these to speed things up (in `backend/.env` locally or before running `backend/deploy.sh` so Cloud Run picks them up as secrets):

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

Notes:
- You can also pass `INDEX_MAX_WORKERS` from the editor via env; it is forwarded to the backend for `index_project`/`index_files`.
- When deploying to Cloud Run, ensure sufficient resources (e.g., `--cpu 4`, `--memory 8Gi`, higher `--concurrency`).

### Godot Docs Search (RAG)

See **[Godot Docs Search: Indexing and Querying](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/./godot_doc_search.md)**.

#### Troubleshooting

**Editor & Build Issues:**
- **Build errors**: See [upstream Godot build documentation](https://docs.godotengine.org/en/stable/development/compiling/index.html) for platform-specific issues
- **Python dependency issues**: Ensure you're using Python 3.8+ and consider using a virtual environment
- **Missing tools**: The chatbot tools will only appear once the backend connection is established

**AI Backend Issues:**
- **Connection problems**: Verify the backend is running on http://localhost:8000 and API keys are properly configured
- **Search not working**: Check Weaviate connection (WEAVIATE_URL and WEAVIATE_API_KEY in .env)
- **Indexing issues**: See function extraction and dependency tracking logs

> 🔧 **[Detailed Backend Troubleshooting](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/README.md#troubleshooting)** for vector search, indexing, and API configuration issues

### License
- Upstream Godot Engine code: Expat (MIT). See `LICENSE.txt`.
- Third-party components: see `COPYRIGHT.txt` and licenses under `thirdparty/`.
- Simplifine original contributions: Non-commercial source-available. See `NOTICE` and `LICENSES/COMPANY-NONCOMMERCIAL.md`.

Commercial licensing is available. Contact: [support@simplifine.com]

### Attribution
This project is based on Godot Engine by the Godot Engine contributors, Juan Linietsky and Ariel Manzur. We are not affiliated with the Godot project.

### Branding
This project is an independent distribution by Simplifine. “Godot” and related marks are property of their respective owners.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-26

---