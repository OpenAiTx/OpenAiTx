# 🗺️ Pathfinder

<div align="center">
  <img src="https://raw.githubusercontent.com/shadowoff09/pathfinder/master/public/banner-readme.png" alt="Pathfinder Banner" width="1280"/>
  
  一个使用 Next.js 15、MapboxGL 和 TypeScript 构建的现代交互式地图应用。Pathfinder 提供无缝的地图体验，功能包括实时天气数据、位置搜索和可自定义的地图样式。

  [演示](https://link.shadowdev.xyz/r/m3tydbf12hb) · [报告错误](https://github.com/shadowoff09/pathfinder/issues) · [请求功能](https://github.com/shadowoff09/pathfinder/issues)
</div>

## ✨ 功能

- 🌓 支持暗黑/明亮模式
- 🏢 3D 建筑可视化
- 🔍 带自动补全的地点搜索
- 🌤️ 实时天气信息
- 📍 当前定位检测
- 🛰️ 街景/卫星视图切换
- 📱 完全响应式设计
- ⌨️ 支持键盘快捷键
- 🎨 使用 Tailwind CSS 和 shadcn/ui 的现代界面

## 🚀 快速开始

### 先决条件

- Node.js 22 及以上版本
- 一个 Mapbox API 密钥（从 [Mapbox](https://www.mapbox.com/) 获取）
- 一个 OpenWeather API 密钥（从 [OpenWeather](https://openweathermap.org/api) 获取）
- npm 或 yarn

### 安装

1. 克隆仓库：
```bash
git clone https://github.com/shadowoff09/pathfinder.git
cd pathfinder
```

2. 安装依赖项：
```bash
npm install
# or
yarn install
```

3. 设置环境变量：
   - 将 `.env.example` 文件复制为 `.env.local`：
     ```bash
     cp .env.example .env.local
     ```
   - 打开 `.env.local` 并添加你的 Mapbox API 密钥：
     ```env
     NEXT_PUBLIC_MAPBOX_ACCESS_TOKEN=your_mapbox_token_here
     NEXT_PUBLIC_WEATHER_API_KEY=your_weather_api_key_here
     ```
   - 从以下网站获取您的API密钥：
     - [Mapbox](https://www.mapbox.com/) - 用于地图功能
     - [OpenWeather](https://openweathermap.org/api) - 用于天气数据

4. 启动开发服务器：
```bash
npm run dev
# or
yarn dev
```

5. 在浏览器中打开 [http://localhost:3000](http://localhost:3000)。

## 🎮 使用说明

### 地图导航
- 平移：点击并拖动
- 缩放：滚动或使用缩放控件
- 旋转：右键点击并拖动
- 重置视图：按 Ctrl+Q

### 功能
- 使用搜索栏搜索地点
- 切换街道和卫星视图
- 在街道视图模式下查看3D建筑（缩放级别15+）
- 查看天气信息（缩放级别14+）
- 一键获取当前位置
- 复制坐标到剪贴板

## 🛠️ 构建工具

- [Next.js 15](https://nextjs.org/) - React 框架
- [TypeScript](https://www.typescriptlang.org/) - 类型安全
- [Mapbox GL JS](https://www.mapbox.com/mapbox-gl-js) - 地图 API
- [Tailwind CSS](https://tailwindcss.com/) - 样式
- [shadcn/ui](https://ui.shadcn.com/) - UI 组件
- [React Map GL](https://visgl.github.io/react-map-gl/) - Mapbox GL 的 React 封装

## 🤝 贡献

欢迎贡献！请随时提交拉取请求。对于重大更改，请先打开 issue 讨论您想要更改的内容。

1. Fork 项目
2. 创建功能分支（`git checkout -b feature/AmazingFeature`）
3. 提交更改（`git commit -m 'Add some AmazingFeature'`）
4. 推送到分支（`git push origin feature/AmazingFeature`）
5. 打开拉取请求

## 📝 许可证

本项目遵循 MIT 许可证 - 详情请参阅 [LICENSE](LICENSE) 文件。

## 🙏 致谢

- 感谢 [Mapbox](https://www.mapbox.com/) 提供出色的地图平台
- 感谢 [shadcn/ui](https://ui.shadcn.com/) 提供美观的 UI 组件
- 感谢 [Vercel](https://vercel.com) 提供托管和部署服务

## 📫 联系方式

X - [@shadowdev09](https://twitter.com/shadowdev09)

作品集 - [https://shadowdev.xyz](https://shadowdev.xyz)

## 💖 支持项目

如果您喜欢使用 Pathfinder 并希望支持其开发，欢迎捐助：

- [通过 PayPal 捐助](https://paypal.me/diogogaspar123)
- [通过 Ko-Fi 捐助](ko-fi.com/shadowoff09)
- [GitHub 赞助](https://github.com/sponsors/shadowoff09)

您的贡献有助于项目持续运行并改进功能！感谢您的支持！

---
<a href="https://www.producthunt.com/posts/pathfinder-11?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-pathfinder&#0045;11" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=915601&theme=dark&t=1740532963013" alt="Pathfinder - Navigate&#0032;Your&#0032;World&#0044;&#0032;Beautifully | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

⭐️ 如果您喜欢本项目，请给它一个星标！

[![Stargazers over time](https://starchart.cc/shadowoff09/pathfinder.svg?variant=adaptive)](https://starchart.cc/shadowoff09/pathfinder)




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---