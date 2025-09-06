[![预发布](https://img.shields.io/github/v/tag/till213/skydolly?include_prereleases&label=Pre-Release)](https://github.com/till213/skydolly/releases)
![许可证: MIT](https://img.shields.io/badge/%E2%9A%96%EF%B8%8F%20License-MIT-brightgreen)
![C++20](https://img.shields.io/badge/C%2B%2B-20-%2300599C?logo=cplusplus)
![支持的编译器](https://img.shields.io/badge/%E2%9A%99%EF%B8%8F%20Compilers-GCC%2C%20clang%2C%20MSVC-informational)

![单元测试](https://github.com/till213/SkyDolly/actions/workflows/unit-tests.yml/badge.svg?event=push)

# Sky Dolly
Sky Dolly - 您飞行录制的“黑羊”。

## 关于
Sky Dolly 连接到正在运行的 Flight Simulator 2020 实例并记录各种模拟变量，以便重放。

![Sky Dolly v0.11.0](https://raw.githubusercontent.com/till213/SkyDolly/main/./img/SkyDolly-v0.11.0.png)

连接通过 SimConnect 实现，这是 Flight Simulator X 引入的标准 API，用于连接飞行模拟器。

另请参阅 [ABOUT.md](https://raw.githubusercontent.com/till213/SkyDolly/main/ABOUT.MD)。

## 特性
- 录制 / 暂停 / 播放
- 编队飞行（多架飞机，录制时重放，“编队飞行”，时间偏移）
- 可设定录制采样率：固定或可变（“自动”）
- 可调节回放速度（“慢动作”，“快进”），回放循环
- 记录位置、速度和基本飞行控制模拟变量（副翼、方向舵、副翼、襟翼、起落架等）
- 插件架构，支持多种导入/导出插件（CSV、GPX、IGC、KML）
- 位置模块，包含100多个默认位置及导入/导出功能
- 基于数据库（SQLite）的持久化（“飞行日志”）

观看 [YouTube](https://www.youtube.com/watch?v=_n4qRtm78_I) 上的（预览）发布预告片：

[![Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (电影预告片)](https://img.youtube.com/vi/_n4qRtm78_I/0.jpg)](https://www.youtube.com/watch?v=_n4qRtm78_I "Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (电影预告片)")

更多使用 Sky Dolly 制作的视频请参见 [SHOWCASE](https://raw.githubusercontent.com/till213/SkyDolly/main/SHOWCASE.md)。新功能和即将推出的功能见 [CHANGELOG](https://raw.githubusercontent.com/till213/SkyDolly/main/CHANGELOG.md)。

## 基本使用

- 开始飞行
- 点击“录制”（快捷键 R）
- 您可以暂停录制（快捷键 P）
- 停止录制（按 R 键）并点击“播放”（空格键）  
- 调整重放速度并在重放期间寻址播放位置  
- 录制的飞行自动保存在“飞行日志”中  
- 在飞行日志中选择一条飞行记录，按“加载”（或双击该行）以载入保存的飞行  

### 编队录制与重放  

#### 录制  

- 切换到“编队”模块（按 F2 键）  
- 点击“录制”（按 R 键）  
- 每架录制的飞机都会被添加到当前飞行中  
- 在录制时，已存在的飞机以“自动”采样率重放，您仍可更改录制采样率  

#### 位置  

- 最后录制的飞机成为“用户飞机”（飞行模拟器中摄像机跟随的对象）  
- 在录制前选择相对于当前“用户飞机”的位置  

#### 重放  

- 只需点击“播放”、“暂停”并在时间线上寻址，就像单架飞机飞行一样  
- 更改“用户飞机”（即使在重放期间）以实现“从驾驶舱跳转到驾驶舱”  
- 通过选择“接管控制”或“与编队飞行”选项来控制“用户飞机”  

#### 管理编队  

- 可以从飞行（“编队”）中删除单架飞机  
- 每个飞行至少必须保留一架飞机，因此最后一架飞机无法删除  
- 为选中的飞机添加时间偏移（“多人编队飞行同步”）  
- 若要开始新的单机飞行，请切换回“飞行日志”模块（按 F1 键）并点击“录制”（按 R 键）  

为什么不试试其中一个引导的["Tell Tours"](https://github.com/till213/Tell-Tours)呢？ :)  

## 下载  

前往 [Releases](https://github.com/till213/SkyDolly/releases) 下载最新版本。  

最新（预）版本：**Sky Dolly 0.19.2**

计算并将您的校验和与[已发布的 SHA-256 校验和](https://raw.githubusercontent.com/till213/SkyDolly/main/SHASUM256.md)进行比较，以验证您下载副本的完整性。

## 构建

请参阅[BUILD](https://raw.githubusercontent.com/till213/SkyDolly/main/BUILD.md)文档。

## 相关项目

- https://github.com/nguyenquyhy/Flight-Recorder - 基于 .Net 的飞行录制与回放应用
- https://github.com/saltysimulations/saltyreplay/ - 带有网页用户界面的录制与回放
- https://github.com/SAHorowitz/MSFS2020-PilotPathRecorder - 记录飞行并生成 Google Earth (KML 格式)“回放”
- https://github.com/Elephant42/FS_Tool - 一个简单工具，允许设置飞机位置和仿真速率
- https://github.com/pyviator/msfs-geoshot - 截图并自动对其进行“地理标记”
- https://github.com/ijl20/msfs_logger_replay - IGC 记录器与回放（针对 FSX）
- https://joinfs.net/ - 允许跨不同飞行模拟器（MSFS、Prepar3D/FSX、XPlane）同步多人飞行。还提供带有编队飞行录制（“叠加”）的飞行记录器。
- https://github.com/paulalexandrow/a32nx-webremote - FlyByWire 的 A32NX WebRemote：使用 FSUIPC7 控制 FBW A320 的驾驶舱功能
- https://flightloganalyzer.com/ - FlightLog Analyer 分析 MSFS 日志，并支持导出 Sky Dolly 可读的 CSV
- https://github.com/BojoteX/FSAutoSave/ - FSAutoSave 自动（或按需）保存飞行计划
- https://github.com/mracko/MSFS-Landing-Inspector - 分析您的着陆表现
- [兴趣点（Google 地图）](https://www.google.com/maps/d/viewer?mid=1KUg5jwyT_9k2A9n5IZ99UChlhfVUfO5S&ll=-3.81666561775622e-14%2C-23.028915134521867&z=1) - Microsoft Flight Simulator 中的兴趣点、机场和 3D 城市。

## 其他有用资源

- https://obsproject.com/ - 屏幕捕获 / 直播应用
- https://sqlitebrowser.org/ - 浏览 Sky Dolly 日志 (*.sdlog) 数据库文件，执行自定义 SQL 查询


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---