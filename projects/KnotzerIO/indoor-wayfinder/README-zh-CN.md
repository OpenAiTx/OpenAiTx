> [!TIP]
> 寻找更高级的室内导航解决方案？
> 试试 [OpenIndoorMaps](https://github.com/openindoormap/openindoormaps) —— 提供地图编辑、3D 视图和户外地图集成功能。

# Pathpal：基于网页的室内导航器

Pathpal 是一款创新的网页应用，旨在革新室内导航。通过交互式地图和高效的路径查找算法，提供了一个直观的解决方案，用于导航复杂的室内空间。
<br>
**演示:** [访问 Pathpal](https://indoor-wayfinder.vercel.app)

## 目录：

- [Pathpal：基于网页的室内导航器](#pathpal-web-based-indoor-wayfinder)
  - [目录：](#table-of-content)
  - [关于该应用](#about-the-app)
  - [截图](#screenshots)
  - [功能](#features)
  - [技术](#technologies)
  - [安装](#setup)
  - [技术见解](#technical-insights)
    - [地图技术](#map-technology)
    - [路径查找](#pathfinding)
    - [核心地图技术](#core-map-technology)
    - [路径绘制与导航](#path-drawing-and-wayfinding)
    - [自定义地图](#customizing-the-map)
  - [鸣谢](#credits)
  - [许可证](#license)

## 关于该应用

该项目是我毕业设计的一个变体，重点是用于室内导航的交互式地图。它采用交互式 SVG 地图，并利用 Dijkstra 算法计算到兴趣点（POI）的最短路径。最初，应用尝试使用 BLE 技术进行室内定位，但由于蓝牙 Web API 仍处于实验阶段，该功能在此变体中被省略。

> [!WARNING]  
> 本项目的后端已被移除。所有数据均存储在 JSON 文件中。该项目是一个原型，不建议用于生产环境。请查看我的新项目 [OpenIndoorMaps](https://github.com/yourusername/OpenIndoorMaps) 以获取更完整的解决方案。

## 截图

<table style="border-radius: 10px;  border: 1px solid gray;">
  <tr >
    <td align="center"><img src="https://raw.githubusercontent.com/KnotzerIO/indoor-wayfinder/main/media/indoor-map-details.png"/></td>
   <td align="center"><h3 >点击显示对象信息</h3></td>
  </tr>
    <tr>
    <td align="center"><img src="https://raw.githubusercontent.com/KnotzerIO/indoor-wayfinder/main/media/indoor-wayfinding.png"/></td>
    <td align="center"><h3>最短路径计算演示</h3></td>
  </tr>
</table>

## 功能特点

- **交互式 SVG 地图**：轻松导航复杂的室内空间。
- **迪杰斯特拉路径查找**：计算到目的地的最短路径。
- **响应式设计**：针对任何设备和屏幕尺寸进行优化。
- **可定制兴趣点**：编辑兴趣点的名称和类别。
- **捏合缩放**：通过触控手势轻松放大和缩小地图。

## 技术栈

Pathpal 采用最新的网络技术构建，确保速度、效率和适应性：

- React
- Vite
- TypeScript
- TailwindCSS
- SVG
- 迪杰斯特拉算法

## 安装指南

按照以下步骤启动项目：

1. **克隆仓库**：使用您喜欢的 Git 客户端将此仓库克隆到本地机器。

2. **安装 Node.js**：本项目需要 Node.js。如果您没有安装 Node.js 21 版本，可以从 [nodejs.org](https://nodejs.org/) 下载并安装。

3. **安装依赖**：在终端中切换到项目目录，运行以下命令安装所需依赖：

   ```bash
   npm install
   ```
4. **启动应用程序**：安装依赖项后，您可以通过在终端运行以下命令来启动应用程序：


   ```bash
   npm run dev
   ```
运行这些命令后，您的默认网页浏览器应自动打开并导航到 `localhost:5173`，您可以在那里看到正在运行的应用程序。

## 技术见解

### 地图技术

- **SVG 格式**：地图主要采用 SVG 格式，因其灵活性和交互功能，适合详细导航。
- **图像格式支持**：支持 PNG、JPEG 等多种格式作为地图背景，交互功能最佳适用于 SVG。

### 路径查找

- **路线定义**：地图中的路径代表可通行路线，对于 Dijkstra 算法计算高效路径至关重要。
- **Dijkstra 算法**：确保兴趣点之间的导航准确且快速。

### 核心地图技术

- **SVG 作为默认格式**：应用程序主要使用 SVG（可缩放矢量图形）文件作为地图，因其可伸缩性和易于操作。SVG 允许对室内空间进行交互和动态渲染，非常适合详细导航路径。
- **支持多种图像格式**：虽然默认使用 SVG，系统设计为支持任何图像格式（如 PNG、JPEG）作为地图背景。这种灵活性确保开发者可以使用现有的平面图或地图，无需转换为 SVG。但主要的交互和导航功能针对 SVG 进行了优化。

### 路径绘制与导航

- **路径绘制**：导航功能依赖于地图中定义的路径。这些路径表示可行走路线，对于寻路算法非常关键。在 SVG 文件中，可以直接绘制和编辑路径，实现对导航路线的精确控制。
- **寻路算法**：应用程序使用 Dijkstra 算法计算地图上兴趣点（POI）之间的最短路径。该算法基于地图上绘制的路径网络，确保导航高效且准确。

### 地图定制

- **编辑工具**：开发者可选择使用 Adobe Illustrator 或 Boxy SVG 等矢量图形编辑工具修改 SVG 地图。修改内容可包括更新布局、添加或移除兴趣点（POI）及调整路径。参见下方截图，展示使用 Boxy SVG 进行地图编辑的示例。将 SVG 转换为 JSX，可参考 [Transform Tools](https://transform.tools/)。

![IndoorMap Editing Example](https://raw.githubusercontent.com/KnotzerIO/indoor-wayfinder/main/media/map-editing-preview.png)

## 致谢

本项目灵感来源于我的毕业设计，并深受导师、同辈及诸如 [maciejb2k 的路径查找应用](https://github.com/maciejb2k/pathfinding_app)等资源的支持影响。

## 许可协议

Pathpal 采用 MIT 许可开源，欢迎贡献和反馈！



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-15

---