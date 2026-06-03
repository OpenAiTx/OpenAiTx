[English](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README.md) | [中文](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_CN.md) | [한국어](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_KO.md) | [日本語](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_JP.md) | [Français](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_FR.md) | [Deutsch](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_DE.md) | [Español](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_ES.md)

<img width="3836" height="2026" alt="image" src="https://github.com/user-attachments/assets/d86c3d6b-6fd4-4cfe-b64f-67c465bb3d3c" /><img width="3832" height="2024" alt="image" src="https://github.com/user-attachments/assets/a91d2b13-07ac-4cae-ab33-506f1fa3bca6" />


# Everything by mdfind

一个强大高效的 macOS 文件搜索工具，利用原生 Spotlight 引擎实现闪电般快速的搜索结果。

## 主要功能

*   **极速搜索：** 利用 macOS Spotlight 索引实现近乎即时的文件搜索。
*   **灵活的搜索选项：** 可按文件名或内容搜索，快速定位所需文件。
*   **高级过滤：** 通过多种过滤器精炼搜索结果：
    *   文件大小范围（最小和最大字节数）
    *   指定文件扩展名（例如 `pdf`、`docx`）
    *   区分大小写匹配
    *   完全匹配或部分匹配选项
*   **特定目录搜索：** 限定搜索范围到指定目录，获得更聚焦的结果。
*   **丰富预览：** 直接在应用中预览多种文件类型：
    *   支持编码检测的文本文件
    *   图片（JPEG、PNG、支持动画的 GIF、BMP、WEBP、HEIC）
    *   支持适当缩放和居中的 SVG 文件
    *   带播放控制的视频文件
    *   音频文件
*   **集成媒体播放器：**
    *   视频和音频播放，带标准控制按钮
    *   独立播放器窗口播放媒体文件
    *   连续播放模式
    *   音量控制和静音选项
*   **书签功能：** 快速访问常用搜索：
    *   大文件（>50MB）
    *   视频文件
    *   音频文件
    *   图片
    *   压缩包
    *   应用程序
*   **磁盘空间分析：** 分析任意目录的磁盘空间使用情况：
    *   一键分析主目录空间
    *   交互式条形图展示占用空间最多的文件夹
    *   在搜索结果中右键点击任意文件夹以分析其空间使用情况
    *   双击图表条以深入子目录进行详细分析
    *   使用颜色编码图表直观显示子目录大小分布
    *   自动按大小排序以识别最大文件夹
*   **可排序结果：** 按名称、大小、修改日期或路径组织搜索结果。
*   **多文件操作：** 同时对多个文件执行操作：
    *   使用 Shift 或 Command (⌘) 键多选文件
    *   批量操作：打开、删除、复制、移动、重命名
    *   右键菜单提供更多操作
*   **多标签搜索界面：** 同时处理多个搜索会话：
    *   为不同搜索查询创建新标签
    *   通过右键菜单关闭、重新排序和管理标签
    *   每个标签拥有独立的搜索结果和设置
    *   类似 Chrome 的标签体验，支持多标签滚动按钮
*   **可定制界面：**
    *   6 种精美主题可选：
        *   浅色 & 深色（系统默认）
        *   东京之夜 & 东京之夜风暴
        *   Chinolor 深色 & Chinolor 浅色（中国传统色）
    *   与所选主题匹配的系统标题栏主题
    *   显示/隐藏预览面板
    *   可配置的搜索历史
*   **多格式导出：** 将搜索结果导出为多种格式：
    *   JSON - 结构化数据格式
    *   Excel (.xlsx) - 带格式的电子表格
    *   HTML - 网页表格格式
    *   Markdown - 文档友好格式
    *   CSV - 经典逗号分隔值
*   **懒加载：** 通过滚动时批量加载条目，高效处理大型结果集。
*   **拖放功能：** 直接将文件拖放到外部应用。
*   **路径操作：** 复制文件路径、目录路径或文件名到剪贴板。

## 安装

1.  **先决条件：**
    *   Python 3.6+
    *   PyQt6

2.  **克隆仓库：**

    ```bash
    git clone https://github.com/appledragon/everythingByMdfind
    cd everythingByMdfind
    ```
3.  **安装依赖项：**


    ```bash
    pip install -r requirements.txt
    ```

4.  **运行应用程序：**

    ```bash
    python everything.py
    ```

## 下载预构建应用程序

您可以直接从 [GitHub Releases](https://github.com/appledragon/everythingByMdfind/releases) 页面下载即用的 macOS 应用程序（.dmg）。

## 贡献

欢迎贡献！请随时提交拉取请求或打开问题以修复错误、请求功能或进行一般改进。

## 许可证

本项目采用 Apache 许可证 2.0 许可 - 详情请参阅 [LICENSE.md](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/LICENSE.md) 文件。

## 作者

Apple Dragon

## 版本

1.4.2

## 致谢

*   感谢 PyQt6 团队提供强大且多功能的 GUI 框架。
*   受到其他优秀文件搜索工具的启发。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---