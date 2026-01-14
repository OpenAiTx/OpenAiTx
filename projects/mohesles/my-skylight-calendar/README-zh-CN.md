
<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# DIY智能家居家庭日历（Skylight 克隆版）

![Sklylight calendar](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/main_view.jpeg)
![DIY Skylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/sky2.png)

## 📖 简介

最近，我妻子在社交媒体上经常被智能家居日历（如 Skylight、Cozyla、Hearth）的广告轰炸，甚至准备花 300 多美元购买一个。在她动手购买前，我请求给我一个机会先研究一下这些产品。
我发现大多数产品提供了类似的功能，但价格差异很大。最重要的是，我没有看到任何无法在 **Home Assistant** 上实现的突出功能。

**目标：** 一个获得“妻子接受度高”（WAF）、适合台面放置的触摸屏日历，能深度集成进我们的智能家居系统，并且没有月费。

## 💡 为什么选择 DIY？

选择 Home Assistant 的 DIY 路线，相较于购买 Skylight/Hearth 显示器有以下几个好处：

* **无月费：** 避免为“高级”功能付订阅费。
* **无缝集成：** 可与我们的灯光、家务（Grocy）和在家传感器联动。
* **旧硬件再利用：** 重新利用 Mini PC 和普通显示器。
* **隐私保障：** 不被厂商锁定，也不担心公司倒闭带来的风险。

## 🛠 硬件选择

目前系统可以在任何高清（1920x1080）显示器上展示仪表盘。

在我的需求中，要求外观看起来像 skylight，支持触摸屏，便于放在台面，也可以随时移动到不同位置。因此我选用了如下硬件。
不过你的需求可能不同，需要按需调整，例如如果你想用平板等其他设备展示。

我最初的硬件选择，不仅基于上述需求，也希望以后可以通过摄像头、扬声器和麦克风扩展功能。但从现在来看，可能会做出不同选择，因为我还没时间实现这些附加功能。

* **显示器：** [惠普 Engage 15 英寸触摸屏](https://computers.woot.com/offers/hp-engage-16t-fhd-monitor)。我选择它而非普通便携显示器，是因为它自带 **扬声器、摄像头和麦克风**，为将来实现语音控制或视频通话做好准备。
* **计算机：** 一台旧的 Mini PC（NUC/Tiny PC）以 Kiosk 模式运行 Windows/Linux，或 Raspberry Pi 4。~~

## ✨ 功能

* **全家 & 个人视图：** 可以切换显示特定家庭成员的日历。
* **双向同步：** 可在屏幕或手机（Google 日历）上编辑事件。
* **“添加事件”弹窗：** 自定义界面，可直接从屏幕添加事件到指定日历。
* **天气 & 日期：** 漂亮的一目了然的顶部信息栏。
* **响应式设计：** 会根据屏幕宽度自动调整天数显示（手机 vs 桌面）。

---

## ⚙️ 安装指南

*注意：本方案使用 **YAML 包**，可自动为你创建所有必要的助手、脚本和变量，无需手动创建。*



### 1. 前提条件（HACS）

你必须已经安装了 [HACS](https://hacs.xyz/)。请安装以下**前端**集成：

* `week-planner-card`
* `bubble-card`
* `config-template-card`
* `card-mod`
* `better-moment-card`
* `weather-card`
* `browser_mod`（弹窗功能所必需）
* `layout-card`（Sections 视图所必需）
* `button-card`（添加事件弹窗所必需）

### 2. 后端（核心逻辑）

1. 在 Home Assistant 中打开你的 `configuration.yaml` 文件。
2. 确保你在 `homeassistant:` 下添加了以下行以启用 packages：

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-14

---