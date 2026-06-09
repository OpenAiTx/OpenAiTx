# Hornet Nest 报警面板 ESPHome 固件

本仓库包含由 **Technology Automation Consulting LLC** 开发的官方支持的 **ESPHome** 固件配置文件，适用于 **Hornet Nest 报警面板**。Hornet Nest 报警面板是一款可扩展且可定制的物联网解决方案，旨在通过 **Home Assistant** 将传统有线报警系统集成到智能家居中。它配备 42 个光耦隔离区域，3 个继电器输出，并支持灵活的 PoE 或 12V 电源选项，兼具灵活性和可靠性。

<div style="display: flex; justify-content: space-between;">
  <img src="https://raw.githubusercontent.com/taconsultingllc/hornet-nest-alarm-panel/main/images/3D_AlarmPanel_2024-10-06.png" alt="3D Model" width="400"/>
  <img src="https://raw.githubusercontent.com/taconsultingllc/hornet-nest-alarm-panel/main/images/hornet-nest-operational.jpg" alt="Installed" width="400"/>
</div>

## 快速开始

通过以下步骤快速开始，使用最新的 ESPHome 固件采用并刷写您的 Hornet Nest 报警面板：

1. 将支持 PoE 的以太网线插入 Hornet Nest 报警面板。
2. 打开 **ESPHome 控制面板**，找到设备 "hornet-nest-XXXXXX"（其中 XXXXXX 是唯一的十六进制标识符）。
3. 点击设备上的 **Adopt（采用）** 选项。
4. 将打开 **Adopt Device（采用设备）** 对话框。您可以根据需要重命名设备，然后再次点击 **Adopt**。
5. 将打开 **Configuration Created（配置已创建）** 对话框，提示需要在设备上安装新配置，点击 **Install（安装）** 按钮。
6. ESPHome 将开始编译新固件。当显示 **"INFO Successfully uploaded program."** 行时，点击 **STOP** 关闭窗口。
4. 在 **Home Assistant** > **设置** > **设备与服务** 中发现 Hornet Nest 报警面板。
5. 点击新设备上的 **配置**，将其添加到 Home Assistant 中。

## 变更与发行说明

请参阅 **Releases（发行版）** 获取发行说明和可下载的预构建固件镜像。

## 为 ESPHome 设计

**Hornet Nest 报警面板** 使用 **wESP32 PoE** 微控制器，完全兼容 **ESPHome** 固件。它是一款开源产品，设计易于用户定制，非常适合需要可扩展和灵活报警解决方案的 Home Assistant 用户。所附的 **ESPHome YAML 配置文件** 具有完整文档，允许高级用户通过简单修改轻松定制、构建和更新设备。

## 兼容 Home Assistant

这些 **ESPHome** 固件配置可实现与 **Home Assistant** 的简单即插即用设置。集成本地化、快速且完全可定制，赋予用户对家庭安全系统的完全控制权。
<img src="https://raw.githubusercontent.com/taconsultingllc/hornet-nest-alarm-panel/main/images/esphome-integrated.png" alt="ESPHome Device" width="600">

## 仓库内容

本仓库顶层包含 **Hornet Nest 报警面板** 的完整固件配置 YAML 模板。这些模板可通过 **ESPHome 控制面板** 导入，支持定制和部署。

## 用户手册
有关详细说明，请参阅官方用户手册[这里。](https://raw.githubusercontent.com/taconsultingllc/hornet-nest-alarm-panel/main/hnap-user-manual.pdf)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-09

---