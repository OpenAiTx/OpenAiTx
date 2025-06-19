# Go-Deploy 部署工具

一个基于Go语言开发的自动化部署工具，支持通过SFTP协议将本地构建产物上传到远程服务器。

## 功能特性

- ✅ **安全传输**：使用SFTP协议，基于SSH加密传输
- ✅ **目录同步**：递归上传整个目录结构，保持文件层级
- ✅ **智能创建**：自动创建远程目录结构
- ✅ **路径自适应**：自动基于可执行文件位置计算本地路径，无需关心执行目录
- ✅ **配置文件支持**：支持JSON配置文件，便于管理不同环境的配置
- ✅ **文件排除**：支持通配符模式排除不需要上传的文件
- ✅ **自动备份**：上传前可自动备份远程文件
- ✅ **重试机制**：上传失败时自动重试，提高成功率
- ✅ **详细统计**：显示上传文件数、传输大小、耗时和速度
- ✅ **进度显示**：实时显示上传进度和文件信息
- ✅ **错误处理**：完善的错误处理和日志输出

## 系统要求

- Go 1.18 或更高版本
- 目标服务器支持SSH/SFTP协议

## 安装说明

### 1. 克隆项目

```bash
git clone <your-repo-url>
cd go-deploy
```

### 2. 初始化Go模块

```bash
go mod init go-deploy
go mod tidy
```

### 3. 安装依赖

程序会自动下载以下依赖：

- `github.com/pkg/sftp` - SFTP客户端
- `golang.org/x/crypto/ssh` - SSH客户端

## 配置说明

程序支持两种配置方式：

### 1. 使用配置文件（推荐）

将 `config.example.json` 复制为 `config.json` 并修改配置：

```bash
cp config.example.json config.json
```

然后编辑 `config.json`：

```json
{
  "server": {
    "host": "your-server-ip",
    "port": 22,
    "username": "your-username",
    "password": "your-password",
    "timeout": 10
  },
  "paths": {
    "local": "../../unpackage/dist/build/web",
    "remote": "/opt/your-path/dist"
  },
  "options": {
    "backup": true,
    "backup_suffix": ".backup",
    "exclude_patterns": [
      "*.log",
      "*.map",
      ".DS_Store",
      "node_modules"
    ],
    "max_retries": 3,
    "chunk_size": 1048576
  }
}
```

#### 配置项说明

**server 配置**：

- `host`: SSH服务器地址
- `port`: SSH端口，通常为22
- `username`: SSH用户名
- `password`: SSH密码（生产环境建议使用密钥认证）
- `timeout`: 连接超时时间（秒）

**paths 配置**：

- `local`: 本地目录路径，支持相对路径和绝对路径
- `remote`: 远程目录路径，必须是绝对路径

**options 配置**：

- `backup`: 是否在上传前创建备份远程已经存在的文件
- `backup_suffix`: 备份文件的后缀名，可自定义备份文件后缀，如果备份文件不存在则跳过备份
- `exclude_patterns`: 文件排除模式，支持通配符
- `max_retries`: 上传失败时的最大重试次数
- `chunk_size`: 文件传输块大小（字节，暂未实现）

### 2. 默认配置（兼容模式）

如果没有 `config.json` 文件，程序会使用内置的默认配置，保持向后兼容。

#### 配置文件优先级

1. **命令行指定的配置文件**：`--config` 参数指定的文件
2. **默认配置文件**：当前目录下的 `config.json`
3. **内置默认配置**：如果以上都不存在，使用程序内置的配置

#### 路径处理规则

- **配置文件路径**：

  - 相对路径：基于可执行文件所在目录
  - 绝对路径：直接使用指定路径
- **本地目录路径**：

  - 相对路径：基于可执行文件所在目录
  - 绝对路径：直接使用指定路径

## 运行说明

### 命令行参数

程序支持以下命令行参数：

```bash
# 显示帮助信息
./deploy --help

# 显示版本信息  
./deploy --version

# 使用默认配置文件 config.json
./deploy

# 使用指定配置文件
./deploy --config prod.json

# 使用绝对路径配置文件
./deploy --config /path/to/config.json
```

### 开发环境运行

```bash
# 使用默认配置
go run main.go

# 使用指定配置文件
go run main.go --config test.json

# 显示帮助
go run main.go --help
```

### 编译后运行

```bash
# 编译
go build -o deploy main.go

# 使用默认配置运行
./deploy

# 使用指定配置文件运行
./deploy --config prod.json
```

## 打包说明

### 1. 本地平台打包

```bash
# 编译当前平台可执行文件
go build -o deploy main.go
```

### 2. 跨平台打包

#### Linux 64位

```bash
GOOS=linux GOARCH=amd64 go build -o deploy-linux-amd64 main.go
```

#### Windows 64位

```bash
GOOS=windows GOARCH=amd64 go build -o deploy-windows-amd64.exe main.go
```

#### macOS 64位

```bash
GOOS=darwin GOARCH=amd64 go build -o deploy-darwin-amd64 main.go
```

#### macOS ARM64 (M1/M2)

```bash
GOOS=darwin GOARCH=arm64 go build -o deploy-darwin-arm64 main.go
```

### 3. 优化打包（减小文件大小）

```bash
# 去除调试信息和符号表
go build -ldflags="-s -w" -o deploy main.go

# 使用UPX压缩（需要先安装UPX）
upx --best deploy
```

### 4. 批量打包脚本

创建 `build.sh` 脚本：

```bash
#!/bin/bash

# 创建构建目录
mkdir -p builds

# 构建各平台版本
echo "构建 Linux 64位版本..."
GOOS=linux GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-linux-amd64 main.go

echo "构建 Windows 64位版本..."
GOOS=windows GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-windows-amd64.exe main.go

echo "构建 macOS 64位版本..."
GOOS=darwin GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-darwin-amd64 main.go

echo "构建 macOS ARM64版本..."
GOOS=darwin GOARCH=arm64 go build -ldflags="-s -w" -o builds/deploy-darwin-arm64 main.go

echo "构建完成！"
ls -la builds/
```

运行脚本：

```bash
chmod +x build.sh
./build.sh
```

## 使用示例

### 显示帮助信息

```bash
$ ./deploy --help
Go-Deploy 部署工具

用法: ./deploy [选项]

选项:
  -config string
        配置文件路径 (default "config.json")
  -help
        显示帮助信息
  -version
        显示版本信息

示例:
  ./deploy                           # 使用默认配置文件 config.json
  ./deploy --config prod.json        # 使用指定配置文件
  ./deploy --config /path/to/config.json  # 使用绝对路径配置文件
```

### 使用指定配置文件

```bash
$ ./deploy --config prod.json
开始执行部署程序...
尝试读取配置文件: /path/to/go-deploy/prod.json
使用配置文件...
本地目录 /path/to/project/dist 存在
正在连接SSH服务器...
SSH服务器连接成功
...
```

### 使用配置文件

```bash
$ ./deploy
开始执行部署程序...
尝试读取配置文件: /path/to/go-deploy/config.json
使用配置文件...
本地目录 /path/to/project/unpackage/dist/build/web 存在
正在连接SSH服务器...
SSH服务器连接成功
正在创建SFTP客户端...
SFTP客户端创建成功
准备上传到远程目录: /opt/xsoft/nginx/html/app/dist
开始上传目录...
开始遍历本地目录: /path/to/project/unpackage/dist/build/web
创建目录: /opt/xsoft/nginx/html/app/dist
文件 static/js/app.js.map 被排除，跳过上传
创建备份: /opt/xsoft/nginx/html/app/dist/index.html -> /opt/xsoft/nginx/html/app/dist/index.html.backup
上传文件: /path/to/project/unpackage/dist/build/web/index.html -> /opt/xsoft/nginx/html/app/dist/index.html
文件 .DS_Store 被排除，跳过上传
上传文件: /path/to/project/unpackage/dist/build/web/static/css/app.css -> /opt/xsoft/nginx/html/app/dist/static/css/app.css
上传失败 (尝试 1/3): 网络错误
重试上传文件 (2/3): /path/to/project/unpackage/dist/build/web/static/js/app.js
上传文件: /path/to/project/unpackage/dist/build/web/static/js/app.js -> /opt/xsoft/nginx/html/app/dist/static/js/app.js
...
目录上传成功!
统计信息:
  - 上传文件数: 485
  - 创建目录数: 18
  - 传输大小: 25.8 MB
  - 上传耗时: 38.5s
  - 总耗时: 39.2s
  - 传输速度: 0.67 MB/s
```

## 注意事项

1. **安全性**：

   - 生产环境建议使用SSH密钥认证而非密码认证
   - 当前使用 `ssh.InsecureIgnoreHostKey()`，生产环境应验证主机密钥
2. **网络**：

   - 确保本地能够访问目标服务器的22端口
   - 传输速度取决于网络带宽和服务器性能
3. **权限**：

   - 确保SSH用户对目标目录有写入权限
   - 如需要，可能需要使用sudo权限
4. **路径**：

   - 本地路径自动基于可执行文件位置计算，无需关心执行目录
   - 远程路径使用绝对路径

## 故障排除

### 常见问题

1. **连接超时**

   ```
   连接SSH服务器失败: dial tcp: i/o timeout
   ```

   - 检查服务器地址和端口
   - 确认网络连通性
   - 检查防火墙设置
2. **认证失败**

   ```
   登录失败: ssh: handshake failed
   ```

   - 检查用户名和密码
   - 确认SSH服务已启动
   - 检查SSH配置
3. **权限错误**

   ```
   创建目录失败: permission denied
   ```

   - 检查用户对目标目录的写入权限
   - 可能需要使用sudo或更改目录所有者
4. **本地目录不存在**

   ```
   错误: 本地目录 /path/to/unpackage/dist/build/web 不存在
   ```

   - 确认本地构建已完成
   - 检查项目目录结构是否正确
   - 程序会自动计算路径，无需手动调整工作目录

## 开发说明

### 项目结构

```
go-deploy/
├── main.go                 # 主程序文件
├── go.mod                  # Go模块文件  
├── go.sum                  # 依赖校验文件
```
├── README.md               # 详细说明文档  
├── Makefile                # 构建工具  
├── build.sh                # 批量打包脚本  
├── install.sh              # 一键安装脚本  
└── config.example.json     # 配置文件示例  
```

### 主要函数

- `main()` - 主函数，处理连接和调用上传
- `uploadDirectory()` - 递归上传目录
- `uploadFile()` - 上传单个文件
- `mkdirAll()` - 递归创建远程目录

## 许可证

MIT 许可证

## 贡献

欢迎提交 Issue 和 Pull Request！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---