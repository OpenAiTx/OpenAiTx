<div align="center">
  <a href="https://iso.tim.cv/" target="_blank">
    <img src="https://raw.githubusercontent.com/Coyenn/iso/main/./.github/assets/preview-dashboard-bg-image.png" alt="Iso dashboard screenshot" width="800" />
  </a>
</div>

<br />
<div align="center">
  <a href="https://iso.tim.cv" target="_blank">演示</a>
  |
  <a href="https://hub.docker.com/r/coyann/iso" target="_blank">Docker</a>
  |
  <a href="https://github.com/Coyenn/iso/" target="_blank">GitHub</a>
</div>
<br />

**Iso** 是一个即插即用的仪表盘，适用于所有自托管服务。  
为我的个人家庭实验室打造——现已开源，供你使用。

- **完全可配置**，通过单个 `config.json` 文件实现  
- **多语言支持**：英语、西班牙语、法语、德语  
- **图标支持**：从内置图标集中选择或提供自定义图标  
- **优先支持 Docker**：通过一条简单命令随处运行  

## ‍️快速开始

### Docker

```bash
docker run -d \
  --name iso \
  -p 3000:3000 \
  -e AUTH_SECRET="changeme" \
  -e AUTH_PASSWORD="changeme" \
  -v ./config:/config \
  coyann/iso
```

### Docker Compose

```yaml
services:
  iso:
    image: coyann/iso:latest
    container_name: iso
    ports:
      - "3000:3000"
    environment:
      - AUTH_SECRET=changeme
      - AUTH_PASSWORD=changeme
    volumes:
      - ./config:/config
    restart: unless-stopped
```

打开 http://localhost:3000 ，即可启动运行！

## 配置

Iso 通过位于 `/config` 目录下的单个 `config.json` 文件进行配置。

### 配置示例

```json
{
  "title": "My Dashboard",
  "services": [
    {
      "order": 1,
      "icon": "tv",
      "label": "Plex",
      "href": "https://plex.example.com"
    },
    {
      "order": 2,
      "icon": "lock",
      "label": "Bitwarden",
      "href": "https://vault.example.com"
    }
  ],
  "locale": "en",
  "theme": "amethyst",
  "greetings": [],
  "pageLoadAnimation": true,
  "search": {
    "enabled": true,
    "engine": "google",
    "engineUrl": "",
    "placeholder": "Search ..."
  }
}
```
### 配置选项

- **title**：显示在头部的仪表盘标题  
- **services**：服务对象数组，包含：  
  - `order`：显示顺序（数字）  
  - `icon`：内置图标名称  
  - `label`：服务显示名称  
  - `href`：服务链接地址  
- **locale**：语言代码（`en`，`es`，`fr`，`de`）  
- **theme**：颜色主题（例如 `amethyst`）  
- **greetings**：自定义问候语  
- **pageLoadAnimation**：启用/禁用页面动画  
- **search**：包含搜索栏设置的对象  
  - `enabled`：切换搜索栏显示  
  - `engine`：内置搜索引擎（`google`，`bing`，`duckduckgo`，`startpage`，`qwant`，`searx`，或 `custom`）  
  - `engineUrl`：自定义搜索引擎网址。使用 `[q]` 作为搜索查询的占位符。  
  - `placeholder`：搜索栏中显示的输入占位符文本  

## 环境变量

| 变量 | 描述 | 默认值 | 是否必需 |
|----------|-------------|---------|----------|
| `AUTH_SECRET` | 认证用的密钥 | - | 否 |
| `AUTH_PASSWORD` | 仪表盘访问密码 | - | 否 |
| `APP_DATA_PATH` | 配置目录路径 | `/config` | 否 |

## 更多截图

<div style="display: flex;">
  <img src="https://raw.githubusercontent.com/Coyenn/iso/main/./.github/assets/preview-settings.png" alt="Iso 设置截图" width="400" style="width: 49%;" />
  <img src="https://raw.githubusercontent.com/Coyenn/iso/main/./.github/assets/preview-login.png" alt="Iso 登录截图" width="400" style="width: 49%;" />
</div>

## 开发

### 先决条件

- Nix


或者

- [Bun](https://bun.sh/) JavaScript 运行时

### 本地设置

1. 克隆仓库：
```bash
git clone https://github.com/Coyenn/iso.git
cd iso
```

2. 安装依赖项：
```bash
bun install
```

3. 启动开发服务器：
```bash
bun dev
```

4. 在浏览器中打开 http://localhost:3000

## 许可证

根据 MIT 许可证分发。更多信息请参见 `LICENSE` 文件。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---