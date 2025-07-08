CDN acceleration and security protection for this project are sponsored by Tencent EdgeOne.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

The author of this project is colin1114.

# 🚀 Clash Subscription Converter

A visually appealing and powerful online tool for converting various proxy subscription links into Clash configuration format. Supports automatic deployment via Cloudflare Workers & Pages, providing fast and reliable subscription conversion services.

## ✨ Features

- 🎨 **Beautiful Modern Interface** - Utilizes gradient backgrounds and card-style design
- 🔄 **Multi-Protocol Support** - Supports mainstream protocols such as V2Ray, VLESS, Shadowsocks, Trojan, etc.
- ☁️ **Cloud Deployment** - Global CDN acceleration via Cloudflare Workers
- 📱 **Responsive Design** - Perfectly adapts to both desktop and mobile devices
- ⚡ **Fast Conversion** - Instantly converts subscription links to Clash configuration
- 📋 **Smart Copy** - One-click copy of generated YAML configuration, compatible with various browsers
- 📡 **Subscription Link Generation** - Automatically generates subscription links that can be directly imported into Clash
- 🌐 **Online YAML Access** - Provides multiple ways to access YAML files:
  - 📡 Subscription Link: Supports automatic updates in Clash clients
  - 🔗 Online View: View configuration content directly in your browser
  - 💾 File Download: Download .yaml file locally
  - ⚡ Quick Access: Simplified download links
- 🔧 **UTF-8 Support** - Perfectly supports Chinese node names and configurations
- 🆓 **Completely Free** - Based on Cloudflare free services, no usage restrictions

## 📁 Project Structure

```
clash/
├── index.html              # Frontend page
├── worker.js               # Cloudflare Worker backend code
├── wrangler.jsonc          # Wrangler configuration file
├── _headers                # Cloudflare Pages HTTP header configuration
├── .github/
│   └── workflows/
│       └── deploy.yml      # GitHub Actions deployment configuration
├── README.md              # Project documentation
└── package.json           # Project configuration file
```

## 🚀 Quick Start

### Method 1: Run Locally

1. **Clone the project**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **Start local server**
   ```bash
   # Using Python
   python -m http.server 8000

   # Or using Node.js
   npx serve .
   ```

3. **Access the application**
   - Open your browser and visit `http://localhost:8000`
   - Sample configuration will be displayed in the local environment

### Method 2: Deploy on Cloudflare Workers

#### Step 1: Create a Worker

1. Visit [Cloudflare Workers](https://workers.cloudflare.com/)
2. Register/Login to your Cloudflare account
3. Click "Create a Worker"
4. Copy the entire code from `worker.js` into the editor
5. Click "Save and Deploy"

#### Step 2: Deploy using Wrangler CLI

```bash
# Install Wrangler CLI
npm install -g wrangler

# Log in to Cloudflare
wrangler login

# Deploy Worker
npm run deploy:worker
```

#### Step 3: Configure Domain (Optional)

1. Add a custom domain in the Worker settings
2. Or use the default domain provided by Cloudflare

### Method 3: Deploy on Cloudflare Pages

#### Option A: GitHub Integration (Recommended)

1. **Prepare Repository**
   - Push the code to a GitHub repository
   - Make sure all necessary files are included
2. **Create a Pages Project**
   - Visit [Cloudflare Pages](https://pages.cloudflare.com/)
   - Connect your GitHub repository
   - Select the project repository

3. **Build Settings**
   - Build command: leave blank or use `echo "No build required"`
   - Build output directory: `/` (root directory)
   - Environment variables: no need to set

#### Option B: Direct Upload

```bash
# Deploy using Wrangler Pages
npm run deploy:pages
```

## 🛠️ Technical Architecture

### Frontend Tech Stack
- **HTML5** - Modern markup language
- **CSS3** - Responsive design and animation effects
- **Vanilla JavaScript** - Lightweight frontend interaction

### Backend Tech Stack
- **Cloudflare Workers** - Edge computing platform
- **Web APIs** - Standard Fetch API and response handling

### Supported Protocols
- **VMess** - V2Ray standard protocol
- **VLESS** - V2Ray lightweight protocol (supports Reality)
- **Shadowsocks** - Classic proxy protocol
- **Trojan** - Emerging proxy protocol

### API Endpoints
- `GET /` - Main page
- `POST /convert` - Subscription conversion API
- `GET /clash/{config-id}` - Get YAML config file (subscription link)
- `GET /yaml/{config-id}` - Download YAML config file
- `OPTIONS /*` - CORS preflight requests

## 📖 User Guide

### Basic Usage

1. **Enter Subscription Link**
   - Paste your proxy subscription link into the input box
   - Supports Base64-encoded subscription links

2. **Set Configuration Name**
   - Optionally set a custom name for the config file
   - Defaults to "My Clash Config"

3. **Convert Configuration**
   - Click the "Convert Subscription" button
   - Wait for the conversion to complete

4. **Use Configuration**
   - Copy the generated YAML config
   - Import it into the Clash client for use

5. **Use Subscription Link (Recommended)**
   - Copy the generated subscription link
   - Add the subscription in the Clash client
   - Config will auto-sync, no manual update needed

### Advanced Configuration

The generated Clash config includes the following features:

- **Proxy Group Policies**
  - 🚀 Node Selection - Manually select proxy
  - ♻️ Auto Selection - Automatically select by latency test
  - 🎯 Global Direct - Direct connection

- **DNS Configuration**
  - DNS resolution enabled
  - Supports fake-ip mode
  - Domestic and foreign DNS split

- **Routing Rules**
  - Local addresses direct connect
  - Domestic IPs direct connect
  - Other traffic goes through proxy

## 🔧 Deployment Troubleshooting

### Common Issues

#### 1. Wrangler Cannot Find Entry Point
**Error Message**: `Missing entry-point to Worker script`

**Solution**: 
- Ensure the project root directory contains a `wrangler.jsonc` file
- Check that the `main` field in `wrangler.jsonc` points to `worker.js`

#### 2. GitHub Actions Deployment Fails
**Solution**:
- Add the following Secrets in your GitHub repository settings:
- `CLOUDFLARE_API_TOKEN`: Cloudflare API token  
- `CLOUDFLARE_ACCOUNT_ID`: Cloudflare account ID

#### 3. Pages Build Failure
**Solution**:
- Set the build command to empty or `echo "No build required"`
- Make sure the build output directory is set to `/`

### Deployment Configuration File Description

- **`wrangler.jsonc`**: Wrangler CLI configuration, used for Worker deployment
- **`_headers`**: Cloudflare Pages HTTP header configuration
- **`.github/workflows/deploy.yml`**: GitHub Actions auto-deployment configuration

## 🔧 Custom Configuration

### Modify Proxy Groups

You can edit the `convertToClash` function in `worker.js` to customize proxy groups:

```javascript
'proxy-groups': [
  {
    name: '🚀 Node Selection',
    type: 'select',
    proxies: ['♻️ Auto Select', '🎯 Global Direct', ...proxyNames]
  },
  // Add more proxy groups...
]
```

### Custom Routing Rules

Modify the `rules` array to add custom routing rules:

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 Node Selection',
  'DOMAIN-SUFFIX,local,DIRECT',
  // Add more rules...
]
```

## 📊 Performance Features

- **Global CDN** - Cloudflare's worldwide edge nodes
- **Fast Response** - Average response time < 100ms
- **High Availability** - 99.9% service uptime
- **Free Quota** - 100,000 requests per day

## 🔒 Security Notes

- **Data Privacy** - Subscription data is only used during conversion and is not stored
- **HTTPS Encryption** - All communication is encrypted via HTTPS
- **Open Source Transparency** - Full source code is public and can be audited

## 🤝 Contribution Guide

Contributions via Issue and Pull Request are welcome!

1. Fork this repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 Changelog

### v1.1.0
- ✅ Added VLESS protocol support (including Reality secure transport)
- ✅ Improved protocol compatibility

### v1.0.0
- ✅ Basic subscription conversion function
- ✅ Beautiful user interface
- ✅ Cloudflare Workers support
- ✅ Multi-protocol support (VMess, Shadowsocks, Trojan)
- ✅ Responsive design
- ✅ One-click copy function

## 📞 Support & Feedback

If you encounter issues or have suggestions during use, please:

1. Review this README document
2. Submit an [Issue](../../issues)
3. Start a [Discussion](../../discussions)

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details

## 🙏 Acknowledgements

- [Cloudflare Workers](https://workers.cloudflare.com/) - Provides the edge computing platform
- [Clash](https://github.com/Dreamacro/clash) - Excellent proxy client
- All contributors and users for their support

---
⭐ If this project has been helpful to you, please give it a Star!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---