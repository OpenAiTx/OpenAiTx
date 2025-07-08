CDN acceleration and security protection for this project are sponsored by Tencent EdgeOne.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

The author of this project is colin1114.

# 🚀 Clash 订阅转换器

一个美观且功能强大的在线工具，用于将各种代理订阅链接转换为 Clash 配置格式。支持通过 Cloudflare Workers & Pages 自动部署，提供快速、可靠的订阅转换服务。

## ✨ 功能特性

- 🎨 **美观的现代化界面** - 采用渐变背景和卡片式设计
- 🔄 **多协议支持** - 支持 V2Ray、VLESS、Shadowsocks、Trojan 等主流协议
- ☁️ **云端部署** - 通过 Cloudflare Workers 实现全球CDN加速
- 📱 **响应式设计** - 完美适配桌面端和移动端
- ⚡ **快速转换** - 实时将订阅链接转换为 Clash 配置
- 📋 **智能复制** - 支持一键复制生成的 YAML 配置，兼容各种浏览器
- 📡 **订阅链接生成** - 自动生成可直接导入Clash的订阅链接
- 🌐 **在线YAML访问** - 提供多种YAML文件访问方式：
  - 📡 订阅链接：支持Clash客户端自动更新
  - 🔗 在线查看：浏览器中直接查看配置内容
  - 💾 文件下载：下载.yaml文件到本地
  - ⚡ 快速访问：简化的下载链接
- 🔧 **UTF-8支持** - 完美支持中文节点名称和配置
- 🆓 **完全免费** - 基于 Cloudflare 免费服务，无使用限制

## 📁 项目结构

```
clash/
├── index.html              # 前端页面
├── worker.js               # Cloudflare Worker 后端代码
├── wrangler.jsonc          # Wrangler 配置文件
├── _headers                # Cloudflare Pages HTTP头配置
├── .github/
│   └── workflows/
│       └── deploy.yml      # GitHub Actions 部署配置
├── README.md              # 项目说明文档
└── package.json           # 项目配置文件
```

## 🚀 快速开始

### 方法一：本地运行

1. **克隆项目**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **启动本地服务器**
   ```bash
   # 使用 Python
   python -m http.server 8000
   
   # 或使用 Node.js
   npx serve .
   ```

3. **访问应用**
   - 打开浏览器访问 `http://localhost:8000`
   - 在本地环境下会显示示例配置

### 方法二：Cloudflare Workers 部署

#### 步骤1：创建 Worker

1. 访问 [Cloudflare Workers](https://workers.cloudflare.com/)
2. 注册/登录 Cloudflare 账户
3. 点击 "Create a Worker"
4. 将 `worker.js` 中的代码完整复制到编辑器中
5. 点击 "Save and Deploy"

#### 步骤2：使用 Wrangler CLI 部署

```bash
# 安装 Wrangler CLI
npm install -g wrangler

# 登录到 Cloudflare
wrangler login

# 部署 Worker
npm run deploy:worker
```

#### 步骤3：配置域名（可选）

1. 在 Worker 设置中添加自定义域名
2. 或使用 Cloudflare 提供的默认域名

### 方法三：Cloudflare Pages 部署

#### 选项A：GitHub 集成（推荐）

1. **准备仓库**
   - 将代码推送到 GitHub 仓库
   - 确保包含所有必要文件

2. **创建 Pages 项目**
   - 访问 [Cloudflare Pages](https://pages.cloudflare.com/)
   - 连接你的 GitHub 仓库
   - 选择项目仓库

3. **构建设置**
   - 构建命令：留空或 `echo "No build required"`
   - 构建输出目录：`/`（根目录）
   - 环境变量：无需设置

#### 选项B：直接上传

```bash
# 使用 Wrangler Pages 部署
npm run deploy:pages
```

## 🛠️ 技术架构

### 前端技术栈
- **HTML5** - 现代化标记语言
- **CSS3** - 响应式设计和动画效果
- **Vanilla JavaScript** - 轻量级前端交互

### 后端技术栈
- **Cloudflare Workers** - 边缘计算平台
- **Web APIs** - 标准的 Fetch API 和响应处理

### 支持的协议格式
- **VMess** - V2Ray 标准协议
- **VLESS** - V2Ray 轻量协议（支持Reality）
- **Shadowsocks** - 经典代理协议
- **Trojan** - 新兴的代理协议

### API 端点
- `GET /` - 主页面
- `POST /convert` - 订阅转换API
- `GET /clash/{config-id}` - 获取YAML配置文件（订阅链接）
- `GET /yaml/{config-id}` - 下载YAML配置文件
- `OPTIONS /*` - CORS预检请求

## 📖 使用指南

### 基本使用

1. **输入订阅链接**
   - 将你的代理订阅链接粘贴到输入框中
   - 支持 Base64 编码的订阅链接

2. **设置配置名称**
   - 可选择性地为配置文件设置自定义名称
   - 默认为 "My Clash Config"

3. **转换配置**
   - 点击 "转换订阅" 按钮
   - 等待转换完成

4. **使用配置**
   - 复制生成的 YAML 配置
   - 导入到 Clash 客户端中使用

5. **使用订阅链接（推荐）**
   - 复制生成的订阅链接
   - 在Clash客户端中添加订阅
   - 配置会自动同步，无需手动更新

### 高级配置

生成的 Clash 配置包含以下特性：

- **代理组策略**
  - 🚀 节点选择 - 手动选择代理
  - ♻️ 自动选择 - 延迟测试自动选择
  - 🎯 全球直连 - 直接连接

- **DNS 配置**
  - 启用 DNS 解析
  - 支持 fake-ip 模式
  - 国内外 DNS 分流

- **路由规则**
  - 本地地址直连
  - 国内 IP 直连
  - 其他流量走代理

## 🔧 部署故障排除

### 常见问题

#### 1. Wrangler 找不到入口点
**错误信息**: `Missing entry-point to Worker script`

**解决方案**: 
- 确保项目根目录有 `wrangler.jsonc` 文件
- 检查 `wrangler.jsonc` 中的 `main` 字段指向 `worker.js`

#### 2. GitHub Actions 部署失败
**解决方案**:
- 在 GitHub 仓库设置中添加以下 Secrets:
  - `CLOUDFLARE_API_TOKEN`: Cloudflare API 令牌
  - `CLOUDFLARE_ACCOUNT_ID`: Cloudflare 账户 ID

#### 3. Pages 构建失败
**解决方案**:
- 设置构建命令为空或 `echo "No build required"`
- 确保构建输出目录设置为 `/`

### 部署配置文件说明

- **`wrangler.jsonc`**: Wrangler CLI 配置，用于 Worker 部署
- **`_headers`**: Cloudflare Pages HTTP 头配置
- **`.github/workflows/deploy.yml`**: GitHub Actions 自动部署配置

## 🔧 自定义配置

### 修改代理组

可以编辑 `worker.js` 中的 `convertToClash` 函数来自定义代理组：

```javascript
'proxy-groups': [
  {
    name: '🚀 节点选择',
    type: 'select',
    proxies: ['♻️ 自动选择', '🎯 全球直连', ...proxyNames]
  },
  // 添加更多代理组...
]
```

### 自定义路由规则

修改 `rules` 数组来添加自定义路由规则：

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 节点选择',
  'DOMAIN-SUFFIX,local,DIRECT',
  // 添加更多规则...
]
```

## 📊 性能特性

- **全球CDN** - Cloudflare 覆盖全球的边缘节点
- **快速响应** - 平均响应时间 < 100ms
- **高可用性** - 99.9% 服务可用性
- **免费额度** - 每天 100,000 次请求

## 🔒 安全说明

- **数据隐私** - 订阅数据仅在转换过程中使用，不会被存储
- **HTTPS 加密** - 所有通信均通过 HTTPS 加密
- **开源透明** - 完整源代码公开，可自行审查

## 🤝 贡献指南

欢迎提交 Issue 和 Pull Request！

1. Fork 本仓库
2. 创建特性分支 (`git checkout -b feature/AmazingFeature`)
3. 提交更改 (`git commit -m 'Add some AmazingFeature'`)
4. 推送到分支 (`git push origin feature/AmazingFeature`)
5. 开启 Pull Request

## 📝 更新日志

### v1.1.0
- ✅ 新增VLESS协议支持（包括Reality安全传输）
- ✅ 改进协议兼容性

### v1.0.0
- ✅ 基础订阅转换功能
- ✅ 美观的用户界面
- ✅ Cloudflare Workers 支持
- ✅ 多协议支持（VMess、Shadowsocks、Trojan）
- ✅ 响应式设计
- ✅ 一键复制功能

## 📞 支持与反馈

如果你在使用过程中遇到问题或有建议，请：

1. 查看本 README 文档
2. 提交 [Issue](../../issues)
3. 发起 [Discussion](../../discussions)

## 📄 许可证

本项目采用 MIT 许可证 - 详见 [LICENSE](LICENSE) 文件

## 🙏 致谢

- [Cloudflare Workers](https://workers.cloudflare.com/) - 提供边缘计算平台
- [Clash](https://github.com/Dreamacro/clash) - 优秀的代理客户端
- 所有贡献者和用户的支持

---

⭐ 如果这个项目对你有帮助，请给它一个 Star！ 
