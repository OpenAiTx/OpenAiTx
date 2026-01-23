<div align="center">
<img src="https://moooonet.github.io/assets/Comfy-Align//images/display.jpg" width="100%">
<br><br>

[![Version](https://img.shields.io/badge/Version-3.0.4-cyan)](README.md)
[![Youtube](https://img.shields.io/badge/Video-Tutorial-red)](https://youtu.be/p1niyxwsOes)

</div>

ComfyUI-Align 提供了一套强大的节点对齐、拉伸和颜色配置工具，解决了 ComfyUI 中缺乏节点对齐功能的问题

> _如果此插件帮助您保持了理智，请考虑给一个⭐以支持咖啡因的消费。_

## 环境

- ComfyUI：在版本 0.3.76 上测试；理论上支持近期及未来版本。
- Python：在 Python 3.12 上测试
- 系统：在 Windows 11 和 Ubuntu 25.10 上测试。其他 Linux 发行版应可使用；请自行测试。理论上支持 macOS，但由于缺乏设备未测试。

## 安装

- **通过 ComfyUI 管理器：** 在 ComfyUI 管理器中搜索“ComfyUI-Align”并安装。
- **Git 克隆：** 打开 ComfyUI 目录，进入 `custom_nodes` 文件夹，运行：
  ```bash
  git clone https://github.com/Moooonet/ComfyUI-Align.git
  ```
- **重启 ComfyUI：** 安装完成后，重启 ComfyUI 以加载新插件。

## 设置与使用

- **快捷键：** 默认是反引号键 <kbd>`</kbd>，为兼容多系统，自定义快捷键通过 ComfyUI 的原生功能实现。请在快捷键设置中搜索“Align Panel”以设置自定义快捷键。

<div align="center">
  <img src="https://moooonet.github.io/assets/Comfy-Align/images/keybindings.jpg" width="100%">
</div>

- **两种操作模式：**
- 1. 使用 <kbd>`</kbd> 切换对齐面板的可见性。（反引号键，位于 Tab 键上方）
- 2. 在设置中启用保持模式（按住快捷键显示面板；悬停在按钮上并松开键执行操作，无需点击；或按住键点击不同按钮执行多重操作）。

<div align="center">
  <img src="https://moooonet.github.io/assets/Comfy-Align/images/settings.jpg" width="100%">
</div>

## 主要功能

### 1. 节点与组的对齐、分布与拉伸

- **对齐：**

  - **左对齐、右对齐、顶对齐、底对齐：**
  - `Alt` 键：按住 <kbd>Alt</kbd> 对齐时反转目标节点。

- **分布：**

  - **水平顶对齐分布：** 先水平均匀分布节点，再顶对齐。
  - **垂直居中对齐分布：** 先垂直均匀分布节点，再居中对齐。
  - **间距设置：** 在 `Align` 选项中设置间距。

- **拉伸：**
  - **左拉伸、右拉伸、顶拉伸、底拉伸：**
  - **水平双侧拉伸：** 最宽的节点为目标，其他节点向目标节点左右拉伸，保持宽度不变。
  - **垂直双侧拉伸：** 最高的节点为目标，其他节点向目标节点上下拉伸，保持高度不变。
  - **`Alt` 键：** 按住 <kbd>Alt</kbd> 拉伸时反转目标节点。

### 2. 节点与组的颜色管理

- **ColorBar:**

  - 7 个默认颜色
  - 月亮图标（打开颜色选择器）
  - 清除颜色（清除选中节点的颜色）
  - 应用颜色（将预设颜色应用到对应节点）

- **ColorPicker:**

  - 颜色选择区域
  - 吸管工具
  - 色相滑块
  - 透明度滑块
  - HEX 值（点击复制，双击编辑）
  - RGBA 值（点击复制，双击编辑。按住 Ctrl 复制所有值）
  - 颜色历史
  - 颜色预设

- **ColorPresets:**
  - 插件根目录下会初始生成一个 `color_presets.json` 文件，用于存储自定义颜色预设。
  - 设置节点颜色后，点击 `保存` 按钮保存预设。
  - 点击 `清除` 按钮清除所有保存的预设颜色。
  - 点击 `应用` 按钮将预设颜色应用到对应节点。（`应用` 按钮位于 `ColorBar` 的最后位置）

---

<div align="center">
   <a href="https://www.star-history.com/#Moooonet/ComfyUI-Align&Date">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=Moooonet/ComfyUI-Align&type=Date&theme=dark" />
      <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=Moooonet/ComfyUI-Align&type=Date" />
      <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=Moooonet/ComfyUI-Align&type=Date" />
    </picture>
   </a>
</div>

---

<div align="center">
  <p>除非明确授权，严禁以任何形式进行集成、修改或重新分发。</p>
  <p>© 2025 Moooonet。保留所有权利。</p>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-23

---