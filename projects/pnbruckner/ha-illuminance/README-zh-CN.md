# <img src="https://brands.home-assistant.io/illuminance/icon.png" alt="Sun2 Sensor" width="50" height="50"/> 照度传感器
创建一个基于太阳高度角或时间估算户外照度的 `sensor` 实体。  
无论哪种情况，数值都可以根据从另一个已有实体获得的当前天气状况或云层覆盖度进行进一步调整。  


## 运行模式  
提供三种模式：普通、辐照度和简单。  

### 普通/辐照度模式 - 太阳高度角  
这些模式使用美国海军天文台[^1]的算法，基于太阳高度角（又称仰角）估算太阳照度或辐照度。最大照度值约为150,000 lx，最大辐照度值约为1,250 瓦特/平方米。  
下面是一个三天周期内照度变化的示例。  

<p align="center">
  <img src=images/normal.png>
</p>  

[^1]: Janiczek, P. M., and DeYoung, J. A. _Computer Programs for Sun and Moon Illuminance With Contingent Tables and Diagrams_. Circular No. 171. Washington, D. C.: United States Naval Observatory, 1987 [Google Scholar](https://scholar.google.com/scholar_lookup?title=Computer%20programs%20for%20sun%20and%20moon%20illuminance%20with%20contingent%20tables%20and%20diagrams&author=P.%20M.%20Janiczek&author=J.%20A.%20Deyoung&publication_year=1987&book=Computer%20programs%20for%20sun%20and%20moon%20illuminance%20with%20contingent%20tables%20and%20diagrams)  

### 简单模式 - 时间  
夜间数值为10 lx。  
从日出前到日出后的一段时间内，数值会根据当前条件逐渐上升。  
日落前后则相反，数值逐渐下降。  
出于历史原因，最大值为10,000 lx。  
下面是一个三天周期内变化的示例。  

<p align="center">
  <img src=images/simple.png>
</p>  

## 支持的天气来源  
任何使用[标准条件列表](https://www.home-assistant.io/integrations/weather/#condition-mapping)或提供云层覆盖百分比的天气实体，都应该能与此集成配合使用。  
以下天气数据来源被确认支持：  

集成 | 说明  
-|-
[AccuWeather](https://www.home-assistant.io/integrations/accuweather/) | `weather`  
[Buienradar](https://www.home-assistant.io/integrations/buienradar/) | `weather`  
[ecobee](https://www.home-assistant.io/integrations/ecobee/) |  
[Meteorologisk institutt (Met.no)](https://www.home-assistant.io/integrations/met/) | `weather`  
[OpenWeatherMap](https://www.home-assistant.io/integrations/openweathermap/) | `weather`; cloud_coverage 和 condition `sensor`  

## 安装  

该集成软件必须先作为自定义组件安装。
您可以使用 HACS 来管理安装并提供更新通知。  
或者您也可以手动安装该软件。  

<details>  
<summary>使用 HACS</summary>  

[![hacs_badge](https://img.shields.io/badge/HACS-Custom-41BDF5.svg)](https://hacs.xyz/)  

1. 将此仓库添加为[自定义仓库](https://hacs.xyz/docs/faq/custom_repositories/)：  
   它应作为一个新的集成出现。点击它。如有必要，搜索“illuminance”。
   ```text
   https://github.com/pnbruckner/ha-illuminance
   ```
   或者使用此按钮：
  
   [![打开您的 Home Assistant 实例并打开 Home Assistant 社区商店内的仓库。](https://my.home-assistant.io/badges/hacs_repository.svg)](https://my.home-assistant.io/redirect/hacs_repository/?owner=pnbruckner&repository=ha-illuminance&category=integration)

1. 使用相应的按钮下载集成。

</details>

<details>
<summary>手动安装</summary>

将 [`custom_components/illuminance`](custom_components/illuminance) 中的文件复制到
`<config>/custom_components/illuminance`，
其中 `<config>` 是您的 Home Assistant 配置目录。

>__注意__: 下载时，请确保使用每个文件页面上的 `Raw` 按钮。

</details>

### 安装后

下载完成后，您需要重启 Home Assistant。

### 版本

此自定义集成支持 HomeAssistant 版本 2024.8.3 或更新版本。

## 服务

### `illuminance.reload`

从 YAML 配置重新加载 Illuminance。同时将 `ILLUMINANCE` 添加到开发者工具 -> YAML 页面。

## 配置变量

一个或多个传感器的配置选项列表。每个传感器由以下选项定义。

> 注意：这定义了通过 YAML 的配置。不过，同样的传感器也可以在 UI 中添加。

键 | 可选 | 描述
-|-|-
`unique_id` | 否 | 传感器的唯一标识符。这样可以更改任何其余选项而不会被视为新的传感器。（仅适用于基于 YAML 的配置。）
`entity_id` | 是 | 指示当前天气状况或云量百分比的其他实体的实体 ID
`fallback` | 是 | 当天气数据不可用时使用的照度除数。必须在 1（晴朗）到 10（黑暗）之间。若使用 `entity_id`，默认值为 10，否则为 1。
`mode` | 是 | 运行模式。选项包括 `normal`（默认），使用太阳高度；`simple`，使用一天中的时间；以及 `irradiance`，与 `normal` 相同，但值以瓦特/平方米的辐照度表示。
`name` | 是 | 传感器名称。默认是 `Illuminance`。
`scan_interval` | 是 | 更新间隔。最短为 30 秒。默认是 5 分钟。

## 2.1.0 之前的版本
请参见 https://github.com/pnbruckner/homeassistant-config/blob/master/docs/illuminance.md。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-28

---