# Double Love

<div align="center">

[![GitHub license](https://img.shields.io/github/license/Ahua9527/Double-Love)](https://github.com/Ahua9527/Double-Love/blob/main/LICENSE)
![GitHub stars](https://img.shields.io/github/stars/Ahua9527/Double-Love)

🎬 帧间有爱，效率翻倍

[//]: # (藏在代码里的彩蛋)
<!Double Love：让每个镜头都藏着我未说出口的帧率 -->

[English](https://raw.githubusercontent.com/Ahua9527/Double-Love/main/README.en.md) · 简体中文 · [在线体验](https://double-love.ahua.space)

</div>

Double Love 为场记元数据提供自动化标准化处理。支持离线使用。通过批量处理、本地化处理，实现无缝对接Adobe Premiere，Silverstack，DTG Slate确保元数据一致性。有效提高后期工作流效率。

## ✨ 功能特性

- 🎬 影视工业化流程支持
- 📝 智能元数据规范化处理
- ⚡ 零延迟本地化处理
- 🧩 无缝对接 Adobe Premiere

## 🚀 快速入门

### 基础工作流

1. 场记记录：使用 DTG Slate 生成交互式场记单
2. 数据管理：通过 Silverstack Lab 导入场记数据
3. 文件导出：生成 Adobe Premiere Pro XML
4. 标准化处理：使用 Double Love 进行智能优化

示例：
- 输入xml：`UnitA_304_20250127.xml`
- 输出xml：`UnitA_304_20250127_Double_LOVE.xml`

### 详细示例

#### 文件命名优化
- 程序会自动处理场景号、镜头号和场次号的格式
- 自动为数字补充前导零
- 自动处理大小写规范
- 自动清理多余的下划线

#### 片段命名规则

处理后的片段名遵循以下格式：
```
{项目前缀}{场景}_{镜头}_{场次}{摄影机}{评级}
```

- `prefix`: 自定义前缀（可选）
- `scene`: 场景号（3位数字，如 001）
- `shot`: 镜头号（2位数字，如 01）
- `take`: 场次号（2位数字，如 01）
- `camera`: 摄影机标识（小写字母，如 a）
- `Rating`: 评分（ok/kp/ng）

#### 评分处理
- `Circle` → `ok`
- `KEEP` → `kp`
- `NG` → `ng`

#### DIT 信息
- 自动添加 DIT 信息：'DIT: 哆啦Ahua 🌱'
- 如果需要去除请自行部署😁😁

#### 自定义前缀示例

1. 设置前缀为 "PROJECT_A_"：
   - 输入文件：`A304C007_250123G3`
   - 输出文件：`PROJECT_A_004_01_07a_kp`

2. 不设置前缀：
   - 输入文件：`A304C007_250123G3`
   - 输出文件：`004_01_07a_kp`

#### 序列分辨率设置示例

1. FHD 分辨率（默认）：
   - 宽度：1920
   - 高度：1080   
2. DCI 2K 分辨率（自定义）：
   - 宽度：2048
   - 高度：1080   

#### 批量处理示例

1. 同时上传多个文件：
   ```
   UnitA_304_20250123.xml
   UnitA_305_20250124.xml
   UnitA_306_20250125.xml
   ```

2. 处理完成后将得到：
   ```
   UnitA_304_20250123_Double_LOVE.xml
   UnitA_305_20250124_Double_LOVE.xml
   UnitA_306_20250125_Double_LOVE.xml
   ```

## 🛠️ 技术栈

- React 18
- TypeScript
- Vite
- Tailwind CSS
- Lucide Icons
- PWA 支持

## 📦 安装与使用

1. 克隆项目

```bash
git clone https://github.com/Ahua9527/Double-Love.git
cd Double-Love
```

2. 安装依赖

```bash
npm install
```

3. 本地开发

```bash
npm run dev
```

4. 构建项目

```bash
npm run build
```

## 🔒 安全说明

- 所有文件处理均在浏览器本地进行，不会上传到服务器
- 支持最大 50MB 的文件大小限制
- 仅支持处理 XML 格式的文件

## 🌈 开发者说明

### 项目结构

```
Double-Love/
├── src/
│   ├── components/     # React 组件
│   ├── context/       # React Context
│   ├── utils/         # 工具函数
│   ├── styles/        # 样式文件
│   └── App.tsx        # 主应用组件
├── public/            # 静态资源
└── ...配置文件
```

## 📃 许可证

[MIT License](https://raw.githubusercontent.com/Ahua9527/Double-Love/main/LICENSE)

## 🤝 贡献指南

欢迎提交 Issue 和 Pull Request！

## 👨‍💻 作者

哆啦Ahua🌱

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---