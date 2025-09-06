
<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-CN">Simplified Chinese</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-TW">Traditional Chinese</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ja">Japanese</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ko">Korean</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=hi">Hindi</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=th">Thai</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fr">French</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=de">German</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=es">Spanish</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=it">Italian</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ru">Russian</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pt">Portuguese</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=nl">Dutch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pl">Polish</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ar">Arabic</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fa">Persian</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=tr">Turkish</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=vi">Vietnamese</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=id">Indonesian</a></p>
      </div>
    </div>
  </details>
</div>

CDN acceleration and security protection for this project are sponsored by Tencent EdgeOne.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

The author of this project is colin1114.

# 🚀 Clash Subscription Converter

A beautiful and powerful online tool for converting various proxy subscription links to Clash configuration format. Supports automatic deployment via Cloudflare Workers & Pages, providing fast and reliable subscription conversion services.

## ✨ Features

- 🎨 **Modern and Attractive Interface** - Utilizes gradient backgrounds and card-style design
- 🔄 **Multi-Protocol Support** - Supports mainstream protocols such as V2Ray, VLESS, Shadowsocks, Trojan
- ☁️ **Cloud Deployment** - Global CDN acceleration via Cloudflare Workers
- 📱 **Responsive Design** - Perfectly adapts to both desktop and mobile devices
- ⚡ **Fast Conversion** - Instantly converts subscription links into Clash configuration
- 📋 **Smart Copy** - One-click copying of generated YAML configuration, compatible with various browsers
- 📡 **Subscription Link Generation** - Automatically generates subscription links importable to Clash
- 🌐 **Online YAML Access** - Provides multiple ways to access YAML files:
  - 📡 Subscription Link: Supports automatic updates in Clash client
  - 🔗 Online Viewing: View configuration directly in browser
  - 💾 File Download: Download .yaml file locally
  - ⚡ Quick Access: Simplified download link
- 🔧 **UTF-8 Support** - Fully supports Chinese node names and configurations
- 🆓 **Completely Free** - Based on Cloudflare's free service, no usage restrictions

## 📁 Project Structure

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

## 🚀 Quick Start

### Method 1: Run Locally

1. **Clone the project**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **Start the local server**
   ```bash
   # 使用 Python
   python -m http.server 8000
   
   # 或使用 Node.js
   npx serve .
   ```

3. **Access the Application**
   - Open your browser and visit `http://localhost:8000`
   - The sample configuration will be displayed in the local environment

### Method 2: Deploy with Cloudflare Workers

#### Step 1: Create a Worker

1. Visit [Cloudflare Workers](https://workers.cloudflare.com/)
2. Register/Login to your Cloudflare account
3. Click "Create a Worker"
4. Copy the entire code from `worker.js` into the editor
5. Click "Save and Deploy"

#### Step 2: Deploy using Wrangler CLI

```bash
# 安装 Wrangler CLI
npm install -g wrangler

# 登录到 Cloudflare
wrangler login

# 部署 Worker
npm run deploy:worker
```

#### Step 3: Configure Domain Name (Optional)

1. Add a custom domain name in Worker settings
2. Or use the default domain provided by Cloudflare

### Method 3: Deploy with Cloudflare Pages

#### Option A: GitHub Integration (Recommended)

1. **Prepare Repository**
   - Push the code to your GitHub repository
   - Ensure all necessary files are included

2. **Create Pages Project**
   - Visit [Cloudflare Pages](https://pages.cloudflare.com/)
   - Connect your GitHub repository
   - Select the project repository

3. **Build Settings**
   - Build command: leave blank or `echo "No build required"`
   - Build output directory: `/` (root directory)
   - Environment variables: no need to set

#### Option B: Direct Upload

```bash
# 使用 Wrangler Pages 部署
npm run deploy:pages
```

## 🛠️ Technical Architecture

### Frontend Tech Stack
- **HTML5** - Modern markup language
- **CSS3** - Responsive design and animation effects
- **Vanilla JavaScript** - Lightweight frontend interactions

### Backend Tech Stack
- **Cloudflare Workers** - Edge computing platform
- **Web APIs** - Standard Fetch API and response handling

### Supported Protocol Formats
- **VMess** - V2Ray standard protocol
- **VLESS** - V2Ray lightweight protocol (supports Reality)
- **Shadowsocks** - Classic proxy protocol
- **Trojan** - Emerging proxy protocol

### API Endpoints
- `GET /` - Main page
- `POST /convert` - Subscription conversion API
- `GET /clash/{config-id}` - Retrieve YAML configuration file (subscription link)
- `GET /yaml/{config-id}` - Download YAML configuration file
- `OPTIONS /*` - CORS preflight request

## 📖 User Guide

### Basic Usage

1. **Enter Subscription Link**
   - Paste your proxy subscription link into the input box
   - Supports Base64-encoded subscription links

2. **Set Configuration Name**
   - Optionally set a custom name for your configuration file
   - Defaults to "My Clash Config"

3. **Convert Configuration**
   - Click the "Convert Subscription" button
   - Wait for the conversion to complete

4. **Using Configuration**
   - Copy the generated YAML configuration
   - Import it into the Clash client for use

5. **Using Subscription Link (Recommended)**
   - Copy the generated subscription link
   - Add the subscription in the Clash client
   - The configuration will automatically sync, no manual update needed

### Advanced Configuration

The generated Clash configuration includes the following features:

- **Proxy Group Policies**
  - 🚀 Node Selection - Manually select proxy
  - ♻️ Auto Selection - Delay test auto selection
  - 🎯 Global Direct - Direct connection

- **DNS Configuration**
  - Enable DNS resolution
  - Supports fake-ip mode
  - Domestic and overseas DNS split

- **Routing Rules**
  - Local addresses direct connection
  - Domestic IP direct connection
  - Other traffic via proxy

## 🔧 Deployment Troubleshooting

### Common Issues

#### 1. Wrangler Cannot Find Entry Point
**Error Message**: `Missing entry-point to Worker script`

**Solution**: 
- Make sure there is a `wrangler.jsonc` file in the project root directory
- Check that the `main` field in `wrangler.jsonc` points to `worker.js`

#### 2. GitHub Actions Deployment Failed
**Solution**:
- Add the following Secrets in your GitHub repository settings:
  - `CLOUDFLARE_API_TOKEN`: Cloudflare API token
  - `CLOUDFLARE_ACCOUNT_ID`: Cloudflare account ID

#### 3. Pages Build Failed
**Solution**:
- Set the build command to empty or `echo "No build required"`
- Make sure the build output directory is set to `/`

### Deployment Configuration File Description

- **`wrangler.jsonc`**: Wrangler CLI configuration for Worker deployment
- **`_headers`**: Cloudflare Pages HTTP header configuration
- **`.github/workflows/deploy.yml`**: GitHub Actions automatic deployment configuration

## 🔧 Custom Configuration

### Modify Proxy Groups

You can edit the `convertToClash` function in `worker.js` to customize proxy groups:

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

### Custom Routing Rules

Modify the `rules` array to add custom routing rules:

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 节点选择',
  'DOMAIN-SUFFIX,local,DIRECT',
  // 添加更多规则...
]
```

## 📊 Performance Features

- **Global CDN** - Cloudflare covers global edge nodes
- **Fast Response** - Average response time < 100ms
- **High Availability** - 99.9% service uptime
- **Free Quota** - 100,000 requests per day

## 🔒 Security Instructions

- **Data Privacy** - Subscription data is only used during conversion and is not stored
- **HTTPS Encryption** - All communication is encrypted via HTTPS
- **Open Source Transparency** - Full source code is public and can be independently audited

## 🤝 Contribution Guide

Issues and Pull Requests are welcome!

1. Fork this repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 Changelog

### v1.1.0
- ✅ Added support for VLESS protocol (including Reality secure transport)
- ✅ Improved protocol compatibility

### v1.0.0
- ✅ Basic subscription conversion functionality
- ✅ Elegant user interface
- ✅ Cloudflare Workers support
- ✅ Multi-protocol support (VMess, Shadowsocks, Trojan)
- ✅ Responsive design
- ✅ One-click copy feature

## 📞 Support and Feedback

If you encounter any problems or have suggestions during use, please:

1. Check this README document
2. Submit an [Issue](../../issues)
3. Start a [Discussion](../../discussions)

## 📄 License

This project uses the MIT License - see the [LICENSE](LICENSE) file for details

## 🙏 Acknowledgements

- [Cloudflare Workers](https://workers.cloudflare.com/) - Provides edge computing platform
- [Clash](https://github.com/Dreamacro/clash) - Excellent proxy client
- Support from all contributors and users

---

⭐ If this project is helpful to you, please give it a Star! 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---