
<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

[![预发布](https://img.shields.io/github/v/tag/till213/skydolly?include_prereleases&label=Pre-Release)](https://github.com/till213/skydolly/releases)
![许可证：MIT](https://img.shields.io/badge/%E2%9A%96%EF%B8%8F%20License-MIT-brightgreen)
![C++20](https://img.shields.io/badge/C%2B%2B-20-%2300599C?logo=cplusplus)
![支持的编译器](https://img.shields.io/badge/%E2%9A%99%EF%B8%8F%20Compilers-GCC%2C%20clang%2C%20MSVC-informational)

![单元测试](https://github.com/till213/SkyDolly/actions/workflows/unit-tests.yml/badge.svg?event=push)

# Sky Dolly
Sky Dolly - 您的飞行录制的异类之选。

## 关于
Sky Dolly 连接到正在运行的 Flight Simulator 2020 实例，并记录各种仿真变量，以便回放。

![Sky Dolly v0.11.0](https://raw.githubusercontent.com/till213/SkyDolly/main/./img/SkyDolly-v0.11.0.png)

连接是通过 SimConnect 实现的，这是自 Flight Simulator X 起引入的标准 API，用于连接飞行模拟器。

另请参阅 [ABOUT.md](https://raw.githubusercontent.com/till213/SkyDolly/main/ABOUT.md)。

## 功能
- 录制 / 暂停 / 播放
- 编队飞行（多架飞机，录制过程中回放，“与编队飞行”，时间偏移）
- 可设置的录制采样率：固定或可变（“自动”）
- 可调节的回放速度（“慢动作”，“快进”），回放循环
- 记录位置、速度及基础飞行控制仿真变量（副翼、方向舵、襟翼、起落架等）
- 插件架构，支持多种导入/导出插件（CSV、GPX、IGC、KML）
- 位置模块，内置100多个默认地点，支持导入/导出功能
- 基于数据库（SQLite）的持久化（“飞行日志”）

在 [YouTube](https://www.youtube.com/watch?v=_n4qRtm78_I) 上观看（预览）发布预告片：

[![Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)](https://img.youtube.com/vi/_n4qRtm78_I/0.jpg)](https://www.youtube.com/watch?v=_n4qRtm78_I "Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)")

更多使用 Sky Dolly 创作的视频请参阅 [SHOWCASE](https://raw.githubusercontent.com/till213/SkyDolly/main/SHOWCASE.md)。新功能及即将上线内容请查看 [CHANGELOG](https://raw.githubusercontent.com/till213/SkyDolly/main/CHANGELOG.md)。

## 基本用法

- 开始飞行
- 点击“录制”（快捷键 R）
- 可暂停录制（快捷键 P）
- 停止录制（快捷键 R），点击“播放”（空格键）
- 可在回放过程中调节回放速度及播放位置
- 录制的飞行会自动保存在“飞行日志”中
- 在飞行日志中选择飞行，点击“加载”（或双击行）即可加载已保存的飞行

### 编队录制与回放

#### 录制

- 切换到“编队”模块（快捷键 F2）
- 点击“录制”（快捷键 R）
- 每架录制的飞机都会被添加到当前飞行中
- 在录制过程中使用“自动”采样率重放已有飞机时，您仍可更改录制采样率

#### 位置

- 最后一架录制的飞机将成为“用户飞机”（飞行模拟器中被摄像机跟随的飞机）
- 在录制前选择相对于当前“用户飞机”的位置

#### 回放

- 只需点击“播放”、“暂停”并在时间轴上查找，就像单架飞机飞行一样
- 更换“用户飞机”（回放期间也可操作），以“从驾驶舱跳到驾驶舱”
- 通过选择“接管控制”或“随编队飞行”选项来控制“用户飞机”

#### 管理编队

- 您可以从一次飞行（“编队”）中删除单架飞机
- 每次飞行至少要有一架飞机，因此最后一架飞机无法被删除
- 为选中飞机添加时间偏移（“多人编队飞行同步”）
- 若要开始新的单架飞机飞行，请切换回“飞行日志”模块（快捷键 F1），并点击“录制”（快捷键 R）

为什么不试试其中一个引导式 ["Tell Tours"](https://github.com/till213/Tell-Tours)？:)

## 下载

前往 [Releases](https://github.com/till213/SkyDolly/releases) 下载最新版本。

最新（预）发布版本：**Sky Dolly 0.19.2**

计算并对比您的校验码与[已发布的 SHA-256 校验码](https://raw.githubusercontent.com/till213/SkyDolly/main/SHASUM256.md)，以验证下载文件的完整性。

## 构建

请参阅 [BUILD](https://raw.githubusercontent.com/till213/SkyDolly/main/BUILD.md) 文档。

## 相关项目

- https://github.com/nguyenquyhy/Flight-Recorder - 一个基于 .Net 的飞行录制与回放应用
- https://github.com/saltysimulations/saltyreplay/ - 具有网页用户界面的录制与回放工具
- https://github.com/SAHorowitz/MSFS2020-PilotPathRecorder - 记录飞行并生成 Google Earth（KML 格式）的“回放”
- https://github.com/Elephant42/FS_Tool - 一个允许设置飞机位置和模拟速率的简单工具
- https://github.com/pyviator/msfs-geoshot - 截取屏幕截图并自动为其“地理标记”
- https://github.com/ijl20/msfs_logger_replay - IGC 记录器与回放（适用于 FSX）
- https://joinfs.net/ - 允许在不同的飞行模拟器（MSFS、Prepar3D/FSX、XPlane）之间同步多人飞行。还提供编队飞行录制功能（“叠录”）。
- https://github.com/paulalexandrow/a32nx-webremote - FlyByWire A32NX 的 WebRemote：使用 FSUIPC7 控制 FBW A320 的驾驶舱功能
- https://flightloganalyzer.com/ - FlightLog Analyzer 分析 MSFS 日志簿，并可导出 CSV 供 Sky Dolly 读取
- https://github.com/BojoteX/FSAutoSave/ - FSAutoSave 可自动（或按需）保存飞行计划
- https://github.com/mracko/MSFS-Landing-Inspector - 分析您的着陆表现
- [兴趣点 (Google 地图)](https://www.google.com/maps/d/viewer?mid=1KUg5jwyT_9k2A9n5IZ99UChlhfVUfO5S&ll=-3.81666561775622e-14%2C-23.028915134521867&z=1) - Microsoft Flight Simulator 中的兴趣点、机场和 3D 城市。

## 其他实用资源

- https://obsproject.com/ - 屏幕捕获 / 广播应用
- https://sqlitebrowser.org/ - 浏览 Sky Dolly 日志簿（*.sdlog）数据库文件，执行自定义 SQL 查询


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---