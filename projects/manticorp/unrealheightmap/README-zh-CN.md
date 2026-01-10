# 16/32 位灰度 PNG/EXR 高程图生成器

一个基于浏览器的工具，用于从真实世界地形数据生成高质量的 16 位灰度 PNG 高程图或 16/32 位 EXR 高程图。

非常适合在 Unreal Engine 5 和其他游戏引擎或 3D 软件中创建逼真的地形，如 Terrain3d、Godot4 和 Blender。

🌐 **官方网站：** [https://manticorp.github.io/unrealheightmap/](https://manticorp.github.io/unrealheightmap/)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/L4L212G6M7)

## ⚠️ 重要通知

我们开始触及部分地图服务的免费额度限制，因此网站*可能无法使用*，直到我们获得资金提升这些限制。如果您觉得此工具有用，请考虑支持该项目！

## ✨ 功能特色

- **高质量 16/32 位输出** - 生成具有 65,536/4,294,967,296 级细节的高程图（相比 8 位只有 256 级）
- **真实世界地形数据** - 使用来自 [Mapzen 全球高程服务](https://www.mapzen.com/blog/elevation/) 的高质量高程数据
- **交互式地图界面** - 通过直观的地图界面可视化选择地形区域
- **多种归一化模式** - 可选择无归一化、常规归一化或智能归一化以优化高程图数据
- **灵活的输出尺寸** - 提供 Unreal Engine 预设尺寸或最大至 8129×8129 像素的自定义尺寸
- **基于浏览器** - 无需安装，完全在您的浏览器中运行
- **实时预览** - 在地图上叠加显示您导出的区域
- **复制与粘贴坐标** - 支持多种坐标格式，包括度分秒和十进制度

## 🎯 适用场景

- 为 Unreal Engine 5/Blender/Terrain3D 地形创建逼真地形
- 利用精确真实地形进行游戏开发
- 3D 建模与可视化项目
- 地理信息系统（GIS）应用
- 教育和科学可视化

## 🚀 快速开始

1. 访问 [https://manticorp.github.io/unrealheightmap/](https://manticorp.github.io/unrealheightmap/)
2. 使用地图导航至所需位置或手动输入坐标
3. 调整输出缩放和尺寸以定义导出区域（以橙色矩形显示）
4. 选择适合您用途的归一化模式
5. 点击“生成”以创建并下载您的高程图
有关详细说明，请访问[文档](https://manticorp.github.io/unrealheightmap/instructions.html)页面。

## 📖 文档

- **[使用说明](https://manticorp.github.io/unrealheightmap/instructions.html)** - 工具使用的全面指南
- **[示例](https://manticorp.github.io/unrealheightmap/examples.html)** - 使用该工具创建的高度图画廊
- **[许可信息](https://manticorp.github.io/unrealheightmap/rights.html)** - 数据来源及许可相关信息

## 🛠️ 技术栈

- **TypeScript** - 类型安全的应用代码
- **Leaflet** - 交互式地图界面
- **jQuery** - DOM 操作和 UI 交互
- **UPNG.js** - PNG 编码/解码
- **Pako** - 数据压缩
- **Webpack** - 模块打包
- **Bulma** - CSS 框架
- **SASS** - CSS 预处理

## 💻 开发环境搭建

### 前提条件

- Node.js（推荐版本14或更高）
- npm（随 Node.js 一起安装）

### 安装


```bash
# Clone the repository
git clone https://github.com/manticorp/unrealheightmap.git
cd unrealheightmap

# Install dependencies
npm install
```

### 构建命令

```bash
# Development build
npm run build

# Production build
npm run author

# Watch mode (auto-rebuild on changes)
npm run watch

# Run unit tests
npm test
```

### 项目结构

```
├── src/                   # Source TypeScript and SASS files
│   ├── app.ts             # Main application logic
│   ├── main.ts            # Entry point
│   ├── png.ts             # PNG processing
│   ├── processor.ts       # Web worker for image processing
│   ├── sass/              # Stylesheets
│   └── templates/         # HTML templates
├── public/                # Static assets and build output
│   ├── dist/              # Built JavaScript and CSS
│   ├── im/                # Images
│   └── examples/          # Example heightmaps
├── index.html             # Main application page
├── instructions.html      # Documentation page
├── examples.html          # Examples page
└── webpack.config.js      # Webpack configuration
```
## 🎨 示例

### 大峡谷 (64公里)
[在工具中查看](https://manticorp.github.io/unrealheightmap/#latitude/36.18111652966563/longitude/-112.021/zoom/10/outputzoom/14/width/8129/height/8129)

![大峡谷示例](https://raw.githubusercontent.com/manticorp/unrealheightmap/main/public/im/grand_canyon_desserty.png)

更多示例，请访问[示例页面](https://manticorp.github.io/unrealheightmap/examples.html)。

## 🔧 归一化模式

### 无
不进行归一化。像素值直接表示高度（米），负值设为0。

### 常规
将高度值缩放至整个16位范围（0-65535），最大化整个高程图的细节。

### 智能
一种高级模式，处理数据错误和异常值。使用99.9%的窗口过滤极端值，同时在1个标准差内保留真实的最小/最大值。

## 📊 输出格式

- **格式：** 16位灰度PNG，16位EXR或32位EXR  
- **位深：** 65,536个细节等级（2^16）或4,294,967,296（2^32）  
- **精度：** 可表示珠穆朗玛峰（8849米），间隔约13厘米（16位）  
- **源数据：** Mapzen高程数据（24位精度，约4毫米精细度）  

## 🤝 贡献

欢迎贡献！请随时提交问题，分叉仓库并创建拉取请求。

## 📄 许可证

本项目采用MIT许可证 - 详情请见[许可证](LICENSE)文件。

高程数据由[Mapzen](https://www.mapzen.com/blog/elevation/)提供，可能有其自身的许可条款。

## 💖 支持


如果您觉得这个工具有用，请考虑支持该项目：

- ☕ [在 Ko-fi 上请我喝咖啡](https://ko-fi.com/harrymustoeplayfair)
- ⭐ 给这个仓库加星
- 🐦 分享给可能觉得有用的其他人

## 🙏 致谢

- [Mapzen](https://www.mapzen.com/) 提供高质量的全球高程数据
- [虚幻引擎](https://www.unrealengine.com/) 社区的灵感和使用案例
- 所有贡献者和使用该工具的用户

## 📞 联系方式

- **作者：** Harry Mustoe-Playfair
- **邮箱：** harry.mustoeplayfair@gmail.com
- **GitHub：** [manticorp](https://github.com/manticorp)

---

为虚幻引擎、3D 和游戏开发社区倾心制作 ❤️


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-10

---