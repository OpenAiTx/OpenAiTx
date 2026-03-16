## Jubler - 字幕编辑器

![GitHub release (latest by date)](https://img.shields.io/github/v/release/teras/Jubler)
![GitHub all releases](https://img.shields.io/github/downloads/teras/Jubler/total)
![GitHub](https://img.shields.io/github/license/teras/Jubler?v=2)
![Java](https://img.shields.io/badge/Java-8+-orange)
![Platform](https://img.shields.io/badge/platform-Linux%20%7C%20macOS%20%7C%20Windows-blue)
![GitHub Release Date](https://img.shields.io/github/release-date/teras/Jubler)

Jubler 是一款免费且开源的字幕编辑器，用于创建、编辑和转换基于文本的字幕。采用 Java 编写，实现跨平台兼容，提供新字幕创作和现有字幕优化的工具，具备视频预览、质量校验和广泛的格式支持。

(C) 2005-2025 Panayotis Katsaloulis
panayotis@panayotis.com

基于 GNU Affero 通用公共许可证 v3 (AGPL-3.0) 许可

---

## 功能

### 字幕格式
- **支持 20+ 种格式**，包括 SubRip (SRT)、Advanced SubStation Alpha (ASS/SSA)、WebVTT、MicroDVD、SubViewer、MPL2、Spruce DVD Maestro、TTML、ITT、DFXP 及 YouTube 字幕
- **通用编码支持**（UTF-8、UTF-16 及所有 Java 平台编码）
- **字符和段落级样式**，适用于支持的格式（ASS/SSA、SRT）
- **格式转换**，支持所有格式间互转

### 视频集成
- **FFmpeg 集成**，支持帧预览和音频波形可视化
- **MPlayer 支持**，实现视频播放
- **实时字幕编辑**，边看视频边编辑
- **交互式时间轴**，字幕块可拖拽调整
- **两点同步**，实现时间对齐
- **增强预览控制**，支持 shift/alt 键及捕捉功能

### 编辑工具
- **时间操作** - 位移、帧率转换、时间取整
- **内容操作** - 拆分/合并条目，拆分/合并文件
- **文本处理** - 拼写检查，支持正则的查找替换
- **智能时间修复**，检测并解决重叠问题
- **翻译模式**，实现字幕并排翻译
- **撤销/重做** 支持完整历史记录  
- **自动保存与恢复**  

### 质量控制  
- **字幕验证**，支持可配置的质量规则  
- **CPS（每秒字符数）指标** 显示在字幕表中  
- **TED 指南合规性** 检查  
- **颜色编码验证** 用于突出显示问题  
- **统计与分析** 工具  

### 用户界面  
- **HiDPI 支持**，可调节缩放比例  
- **暗色主题** 可选  
- **可自定义键盘快捷键**  
- **多语言界面**，支持国际化（i18n）  
- **颜色标记** 用于组织字幕组  

### 自动化  
- **命令行工具** 支持批量处理  
- **插件系统** 支持扩展功能  
- **外部工具集成**  
- **Azure 翻译支持** 用于自动翻译  

---

## 入门指南  

### 需求  
- Java 8 或更高版本（通常随发行版捆绑）  
- 可选：用于视频预览的 MPlayer  
- 可选：用于拼写检查的 ASpell  

### 安装  

从 [版本发布页面](https://github.com/teras/Jubler/releases) 下载二进制文件：  
- Windows、macOS 和 Linux 安装程序  
- Linux AppImage  
- 通用跨平台软件包  

或从源码构建（参见 [BUILD_AND_RUN.md](https://raw.githubusercontent.com/teras/Jubler/master/BUILD_AND_RUN.md)）

### 运行

从您的应用程序菜单或桌面快捷方式启动。您也可以手动运行：
```bash
java -jar Jubler.jar
```

---

## Contributing

Jubler is an open source project that welcomes contributions. Whether you're fixing bugs, adding features, improving documentation, or translating the interface, your help is appreciated.

---

## Credits

Free code signing on Windows provided by [SignPath.io](https://signpath.io/), certificate by [SignPath Foundation](https://signpath.org/)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-16

---