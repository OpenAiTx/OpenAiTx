# Minecraft 服务器网页管理面板

**[中文版本 (Chinese Version)](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/README_CN.md)**

一款 **轻量级** 的 Minecraft 服务器网页管理面板，拥有现代化的用户界面和全面的服务器管理功能。

**当前支持的服务器：**
- ✅ Minecraft 基岩版服务器
- Minecraft Java 版服务器

## 🚀 功能

### 🌍 Minecraft 服务器下载
- **服务器下载** 支持在管理页面直接下载指定版本的服务器
- **服务器版本切换** 支持一键切换服务器版本

### 🎮 服务器控制
- **一键启动/停止/重启** Minecraft 基岩版服务器
- **实时状态监控** 显示服务器运行状态

### ⚙️ 配置管理
- **支持所有主要配置选项**：
  - 服务器名称和描述
  - 游戏模式（生存/创造/冒险）
  - 难度设置（和平/简单/普通/困难）
  - 最大玩家数量
  - 服务器端口配置
  - 作弊和白名单切换
- **服务器配置文件管理** 自动维护 `server.properties` 文件

### 👥 白名单管理
- **添加/移除玩家** 管理允许加入服务器的玩家列表
- **白名单文件管理** 自动维护 `allowlist.json` 文件

### 🛡️ 权限管理
- **三级权限系统**：
  - **访客** - 基本游戏权限
  - **成员** - 标准玩家权限
  - **管理员** - 完全管理权限
- **玩家权限设置** 为特定玩家分配权限等级
- **权限文件管理** 自动维护 `permissions.json` 文件

### 🌍 世界管理
- **世界文件上传** 支持 `.zip` 和 `.mcworld` 格式并自动解压
- **世界切换** 一键激活不同世界
- **世界删除** 安全删除不需要的世界文件
- **当前世界识别** 清晰显示当前激活的世界

### 🌍 资源包管理
- **资源文件上传** 支持 `.zip` 和 `.mcpack` 格式
- **资源激活** 一键激活不同资源包
- **资源删除** 安全删除不需要的资源包

### 📋 服务器日志
- **实时日志查看** 通过网页界面实时监控 Minecraft 服务器日志
- **自动滚动** 可选自动滚动至最新日志条目

### 💻 命令执行
- **直接命令输入** 通过网页界面直接执行 Minecraft 服务器命令
- **命令历史** 查看并重用之前执行的命令
- **快速命令** 通过分类快速访问按钮访问常用命令

### 🔐 认证与安全
- **登录系统** 通过密码认证安全访问管理面板
- **会话管理** 自动会话处理，基于安全令牌认证
- **访问控制** 保护服务器管理功能免受未授权访问



## 📋 系统需求

### 服务器环境
- **操作系统**：Windows 10 及以上或 Ubuntu 18.04 及以上（Linux）
- **内存**：至少 2GB RAM
- **存储**：至少 10GB 可用空间
- **网络**：开放端口 8080（管理面板）和 19132（Minecraft 服务器）

## 🛠️ 安装指南

### 快速开始（推荐）

1. **下载预构建版本**：
   - 从[版本](https://github.com/ckfanzhe/bedrock-easy-server/releases)页面下载适合您操作系统的版本
   - Windows系统下载 `minecraft-server-manager-windows.exe`
   - Linux系统下载 `minecraft-server-manager-linux`

2. **运行应用程序**：
   ```bash
   # For Linux
   chmod +x minecraft-server-manager-linux
   ./minecraft-server-manager-linux
   
   # For Windows
   minecraft-server-manager-windows.exe
   ```

### Docker 部署

1. **直接使用 Docker（推荐）**：
   ```bash
   # Create data directory for persistent storage
   mkdir -p data
   
   # Run the container using the published image
   docker run -d \
     --name minecraft-easyserver \
     -p 8080:8080 \
     -p 19132:19132/udp \
     -p 19133:19133/udp \
     -v ./data:/data/bedrock-server \
     -v ./config:/data/config \
     ifanzhe/minecraft-easyserver:latest
   ```

2. **使用 Docker Compose**：
   ```bash
   # Create docker-compose.yml file
   cat > docker-compose.yml << EOF
   version: '3.8'
   services:
     minecraft-server-manager:
       image: ifanzhe/minecraft-easyserver:latest
       container_name: minecraft-easyserver
       ports:
         - "8080:8080"
         - "19132:19132/udp"
         - "19133:19133/udp"
       volumes:
         - ./data:/data/bedrock-server
         - ./config:/data/config
       environment:
         - TZ=Asia/Shanghai
       restart: unless-stopped
       healthcheck:
         test: ["CMD", "curl", "-f", "http://localhost:8080"]
         interval: 30s
         timeout: 10s
         retries: 3
   EOF
   
   # Start with Docker Compose
   docker-compose up -d
   ```

3. **访问应用程序**：
   - 打开浏览器并访问：`http://localhost:8080`
   - 服务器数据将保存在 `./data` 目录中

### 从源码构建（开发者用）

1. **前提条件**：
   - Go 1.21 或更高版本
   - Node.js 16+ 和 npm（用于前端编译）

2. **克隆仓库**：
   ```bash
   git clone https://github.com/ckfanzhe/bedrock-easy-server.git
   cd minecraft-easy-server
   ```

3. **构建所有平台（推荐）**：
   ```bash
   chmod +x build.sh
   ./build.sh
   ```
   本脚本将执行：
   - 安装前端依赖（`npm install`）
   - 构建 Vue.js 前端（`npm run build`）
   - 将构建好的资源复制到嵌入目录
   - 编译包含嵌入前端的所有平台的 Go 二进制文件

4. **手动构建步骤**（如果您更喜欢逐步操作）：
   ```bash
   # Build frontend first
   cd minecraft-easyserver-web
   npm install
   npm run build
   cd ..
   
   # Copy frontend build output
   rm -rf web/*
   cp -r minecraft-easyserver-web/dist/* web/
   
   # Build Go binary
   go build -o minecraft-server-manager
   ```

**注意**：构建过程现在包括使用 webpack 进行前端编译，将所有 Vue.js 组件、样式和资源打包成优化后的文件，然后嵌入到 Go 二进制文件中，实现单文件部署。

## 🚀 使用指南

### 启动管理面板

1. **运行应用程序**：
   ```bash
   # For Linux
   ./minecraft-server-manager-linux
   
   # For Windows double-click to run
   minecraft-server-manager-windows.exe
   ```

2. **访问管理界面**：
   - 打开浏览器并访问：`http://localhost:8080`
   - 管理面板将自动加载

## 🔥 防火墙配置

### Windows 防火墙
在某些系统上，当您希望使用与服务器运行在同一台机器上的客户端连接服务器时，您需要将 Minecraft 客户端从 UWP 回环限制中豁免：

```powershell
CheckNetIsolation.exe LoopbackExempt -a -p=S-1-15-2-1958404141-86561845-1752920682-3514627264-368642714-62675701-733520436
```
确保防火墙开放以下端口：  
- **8080**：管理面板访问端口  
- **19132**：Minecraft基岩版服务器默认端口  
- **19133**：Minecraft基岩版服务器IPv6端口  

## 📝 其他信息  

### 待办计划功能  
- ✅ 支持一键导入mcpackage模组  
- ✅ 支持Linux操作系统  
- ✅ 实时查看基岩版服务器日志  
- ✅ 通过网页界面直接执行基岩版服务器命令  
- 🔄 玩家在线状态监控  
- ✅ 服务器性能监控  
- 🔄 自动世界备份功能  
- ✅ 多语言界面支持  
- 🔄 Java服务器支持 - 支持Minecraft Java版服务器  
- ✅ Docker支持 - 支持容器化部署  

## 🤝 贡献  

欢迎提交问题报告、功能建议和代码贡献！  

### 开发环境搭建  
1. Fork项目仓库  
2. 创建功能分支：`git checkout -b feature/new-feature`  
3. 提交更改：`git commit -am 'Add new feature'`  
4. 推送分支：`git push origin feature/new-feature`  
5. 创建Pull Request  

### 代码规范  
- 使用Go标准代码格式  
- 添加适当注释和文档  
- 确保代码通过测试  
- 遵循项目架构模式  

## 📄 许可证  

本项目采用MIT许可证 - 详情请参见[LICENSE](LICENSE)文件。


## 🙏 致谢

- [Gin Web Framework](https://gin-gonic.com/) - 高性能 Go 语言 Web 框架
- [Tailwind CSS](https://tailwindcss.com/) - 实用优先的 CSS 框架
- [Font Awesome](https://fontawesome.com/) - 图标库
- [Minecraft Bedrock](https://www.minecraft.net/) - 游戏服务器

## 👀 管理面板预览
> 部分功能截图，更多功能欢迎亲自体验。

![登录面板预览](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-login.png)
![仪表盘面板预览](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-dashboard.png)
![性能面板预览](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-performance.png)
![服务器下载面板预览](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-version.png)
![资源面板预览](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-resource.png)
![世界面板预览](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-worlds.png)
![命令面板预览](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-cmd.png)
![服务器配置面板预览](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-server-config.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---