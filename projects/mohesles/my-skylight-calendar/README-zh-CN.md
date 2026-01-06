# 自制智能家庭日历（Skylight 克隆版）

![Sklylight calendar](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/main_view.jpeg)
![DIY Skylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/sky2.png)

## 📖 介绍

我妻子最近在社交媒体上频繁看到智能家庭日历（Skylight、Cozyla、Hearth）的广告，准备花超过300美元买一个。在同意之前，我请求先做一些调研。

我发现大多数产品功能相似，但价格差异很大。更重要的是，我没看到有什么突出功能，是我不能在**Home Assistant**中实现的。

**目标：** 一个获得“妻子接受度”（WAF）认可、适合放在台面上的触摸屏日历，能够深度集成到我们的智能家居中，无需月费。

## 💡 为什么选择DIY？

用 Home Assistant 自制的方案相比购买 Skylight/Hearth 显示屏有几个优势：

* **无月费：** 避免了“高级”功能的订阅费用。
* **无缝集成：** 它可以控制我们的灯光、家务（Grocy）和存在传感器。
* **旧硬件利用：** 重新利用了一台迷你电脑和标准显示器。
* **隐私保障：** 无供应商锁定或公司倒闭风险。

## 🛠 硬件选择

目前该项目设计为可在任何高清（1920x1080）显示器上显示仪表盘。

就我而言，需求是“看起来像” Skylight，支持触摸屏，适合放在台面，并且能方便移动到不同位置。因此，我选择了下面描述的硬件。
不过，你的情况可能不同，需要根据需要调整，比如如果你想用平板或者其他设备显示。

我最初选择的硬件基于上述考虑，并且希望将来能利用摄像头、扬声器和麦克风扩展功能。现在回头看，如果有时间，我可能会用不同方案，因为目前还没机会实现这些附加硬件功能。

* **显示器：** [HP Engage 15英寸触摸屏](https://computers.woot.com/offers/hp-engage-16t-fhd-monitor)。我选择它而不是普通便携显示器，因为它内置了**扬声器、摄像头和麦克风**，方便未来实现语音控制或视频通话。
* **计算机：** 一台旧迷你电脑（NUC/小型PC），运行 Windows/Linux 的展台模式，或者一台树莓派4。~~

## ✨ 功能

* **家庭成员和个人视图：** 可切换显示特定家庭成员的日历。
* **双向同步：** 可在屏幕或手机（Google 日历）上编辑事件。
* **“添加事件”弹窗：** 自定义界面，可直接从屏幕添加事件到指定日历。

* **天气和日期:** 美观且一目了然的标题。
* **响应式:** 根据屏幕宽度自动调整天数（移动端与桌面端）。

---

## ⚙️ 安装指南

*注意：此设置使用 **YAML 包** 自动为您创建所有必要的助手、脚本和变量。您无需手动创建它们。*

### 1. 前提条件（HACS）

您必须安装 [HACS](https://hacs.xyz/)。请安装以下 **前端** 集成：

* `week-planner-card`
* `bubble-card`
* `config-template-card`
* `card-mod`
* `better-moment-card`
* `weather-card`
* `browser_mod`（弹窗功能必需）
* `layout-card`（Sections 视图必需）
* `button-card`（添加事件弹窗必需）

### 2. 后端（核心）

1. 打开 Home Assistant 中的 `configuration.yaml` 文件。
2. 确保在 `homeassistant:` 下添加以下行以启用包：

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```
3. 在你的 HA 配置目录中创建一个名为 `packages` 的文件夹（如果你还没有的话）。  
4. 从此仓库下载 [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml)。  
5. 将该文件放入你的 `packages/` 文件夹中。  
6. **重启 Home Assistant**。  

### 3. 日历  

你可以使用 **Google 日历** 或 **本地日历**。  

#### 选项 A：本地日历（最简单）  

注意：由于我只使用 Google 日历，此方法未经测试。  

1. 进入 **设置 > 设备与服务**。  
2. 添加 **本地日历** 集成。  
3. 创建名为以下名称的日历：`Alice`、`Bob`、`Charlie`、`Daisy`、`Family`。  
    * *如果你使用这些名称，代码即可开箱即用！*  

#### 选项 B：Google 日历  

1. 打开 `packages/family_calendar.yaml`。  
2. 滚动到 `add_google_calendar_event` 脚本部分。  
3. 更新 `calendar_map`，指向你真实的 Google 实体：


    ```yaml
    calendar_map:
      "Alice": "calendar.alice_gmail_com"
      "Bob": "calendar.bob_work_account"
    ```

#### 设置节假日

自从 Home Assistant 更新后，节假日现在通过 UI 添加：

1. 进入 **设置 > 设备与服务 > 添加集成 > 节假日**。
2. 选择你的国家。
3. 检查实体 ID（例如，`calendar.holidays`）。如果与默认不同，请在仪表盘 YAML 中更新。

### 4. 仪表盘（外观）

1. 创建一个新的仪表盘视图（将视图类型设置为 **Sections**）。
2. 复制 [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml) 中的代码。
3. **自定义：**
   * **搜索并替换：** 将 `person.alice` 替换为你实际的家庭成员实体。
   * **天气：** 将 `weather.home` 替换为你的天气提供者。
   * **背景：** 更新 yaml 底部的图片 URL。

### 第 5 步：主题（可选）

要获得特定的字体外观（Ovo）：

1. 确保你的 `configuration.yaml` 在 `frontend:` 下有这一行。

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```
2. 在您的配置目录中创建一个名为 `themes` 的文件夹。  
3. 下载 [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) 并将其放入该文件夹。  
4. 重启 Home Assistant。  
5. 进入您的个人资料（左下角用户图标），将 **Theme** 更改为 `Skylight`。  
注意：该主题不全面，请注意这一点。  

---  

## 📐 工作原理（幕后）  

### 过滤逻辑  

`week-planner-card` 本身不支持动态隐藏特定日历。为了解决这个问题，我使用了作为正则表达式过滤器的 **输入文本**。  

* 当您点击某个人的按钮时，会在 `.*`（显示所有）和 `^$`（不显示任何内容）之间切换其过滤器。  
* `config-template-card` 将这些变量动态注入日历卡片中。  

### 事件创建脚本  

“添加事件”弹窗使用一个脚本，处理多个人员和事件类型（全天与定时）的逻辑。  


```yaml
# Simplified Logic Example
target_calendar: "{{ calendar_map.get(states('input_select.calendar_select')) }}"

choose:
  - conditions: "All Day Event is ON"
    action: calendar.create_event (start_date, end_date)
  - conditions: "All Day Event is OFF"
    action: calendar.create_event (start_date_time, end_date_time)
```

## 备注

我最初的帖子只是为了提供一个如何操作的高级概述，允许人们调整代码以使其在他们的具体场景中工作。

特别是我这样做是因为每个显示器和需求都不同。我无法为所有潜在尺寸的显示器、仪表板等进行开发。因此，它被设计为在我提到的显示器或任何（1920x1080）上工作，但应该可以编辑以适应其他情况。

说到显示器，我最初建议那个是因为它当时在Woot上有促销，是获得触摸屏显示器的一种非常经济的方式。现在情况可能不一样，所以使用任何适合你的显示器。平板、触摸屏、手机，随你选择。你需要编辑的主要部分是仪表板。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-06

---