# 📝 SpeedyNote

_一款轻量、快速且优化触控笔的记笔记应用，专为经典平板电脑、低分辨率屏幕和复古硬件设计。_

如果您恰好不懂英文，请移步[中文README](https://github.com/alpha-liu-01/SpeedyNote/blob/main/speedynote_README_zh_CN.md)

![cover](https://i.imgur.com/UTNNbnM.png)

---

## ✨ 功能特色

- 🖊️ **压感书写**，支持触控笔
- 📄 **多页面笔记本**，支持标签页或滚动页面视图
- 📌 **PDF 背景集成**，带注释叠加
- 🌀 **拨盘界面 + Joy-Con 支持**，直观单手操作
- 🎨 **每页背景样式**：网格、横线或空白（可自定义）
- 💾 **便携式 `.snpkg` 笔记本**，支持导出/导入与分享
- 🔎 **通过拨盘切换缩放、平移、笔迹粗细和颜色预设**
- 💡 **为低配设备设计**（Intel Atom N450，133Hz 采样率）
- 🌏 **支持全球多种语言**（覆盖全球一半人口）

---

## 📸 截图展示

| 绘图 | 拨盘界面 / Joycon 控制 | 网格叠加选项 |
|----------------|------------------------|-----------------------|
| ![draw](https://i.imgur.com/iARL6Vo.gif) | ![pdf](https://i.imgur.com/NnrqOQQ.gif) | ![grid](https://i.imgur.com/YaEdx1p.gif) |


---

## 🚀 快速入门

### ✅ 系统要求

- Windows 7/8/10/11/Ubuntu amd64/Kali amd64/PostmarketOS arm64
- Qt 5 或 Qt 6 运行时（Windows 版本内置）
- 触控笔输入（推荐 Wacom）

### 🛠️ 使用方法

1. 启动 `NoteApp.exe`
2. 点击 **文件夹图标** 选择工作文件夹或 **导入 `.snpkg` 包**
3. 使用触控笔开始书写/绘画
4. 使用 **MagicDial** 或 **Joy-Con** 切换工具、缩放、滚动或翻页
5. 笔记本可导出为 `.snpkg` 格式

---

## 📦 笔记本格式

- 可保存为：
  - 📁 一个包含 `.png` 页面和元数据的**文件夹**
  - 🗜️ 一个便携式的 **`.snpkg` 归档**（非压缩 `.tar`）
- 每本笔记本可能包含：
  - 带注释的页面图像（`annotated_XXXX.png`）
  - 来自 PDF 的可选背景图像（`XXXX.png`）
  - 元数据：背景样式、密度、颜色和 PDF 路径

---

## 🎮 控制器支持

SpeedyNote 支持控制器输入，适合平板用户：

- ✅ **支持左侧 Joy-Con**
- 🎛️ 模拟摇杆 → 拨盘控制
- 🔘 按键可映射为：
  - 多功能拨盘控制
  - 切换全屏
  - 更换颜色/粗细
  - 打开控制面板
  - 创建/删除页面

> 长按 + 拨动 = 按住并旋转映射

---

## 📁 从源码构建


1. 安装 **Qt 6** 和 **CMake**
2. 克隆本仓库
3. 运行：

```bash
rm -r build
mkdir build
# ✅ Update translation source files (ensure the .ts files exist already)
& "C:\Qt\6.8.2\mingw_64\bin\lupdate.exe" . -ts ./resources/translations/app_fr.ts ./resources/translations/app_zh.ts ./resources/translations/app_es.ts
& "C:\Qt\6.8.2\mingw_64\bin\linguist.exe" resources/translations/app_zh.ts
& "C:\Qt\6.8.2\mingw_64\bin\linguist.exe" resources/translations/app_fr.ts
& "C:\Qt\6.8.2\mingw_64\bin\linguist.exe" resources/translations/app_es.ts
```
4.（可选）在图形用户界面中修改翻译  
5. 运行：
```bash
rm -r build
mkdir build
& "C:\Qt\6.8.2\mingw_64\bin\lrelease.exe" ./resources/translations/app_zh.ts ./resources/translations/app_fr.ts ./resources/translations/app_es.ts

Copy-Item -Path "C:\Games\yourfolder\resources\translations\*.qm" -Destination "C:\Games\yourfolder\build" -Force

cd .\build
cmake -G "MinGW Makefiles" .. 
cmake --build .  
& "C:\Qt\6.8.2\mingw_64\bin\windeployqt.exe" "NoteApp.exe"
Copy-Item -Path "C:\yourfolder\dllpack\*.dll" -Destination "C:\yourfolder\build" -Force
Copy-Item -Path "C:\yourfolder\bsdtar.exe" -Destination "C:\yourfolder\build" -Force
./NoteApp.exe
cd ../
```
原文有1行。您的翻译也必须恰好有1行。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---