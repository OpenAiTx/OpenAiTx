
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

您必须安装 [HACS](https://hacs.xyz/)。请安装以下**前端**集成：

* `week-planner-card`
* `bubble-card`
* `config-template-card`
* `card-mod`
* `better-moment-card`
* `weather-card`
* `browser_mod`（弹窗功能所需）
* `layout-card`（Sections视图所需）
* `button-card`（添加事件弹窗所需）

*注意：在“设置”→“设备与服务”中，确保 Browser Mod 作为集成（磁贴）出现，而不仅仅是在 HACS 下。
如果没有出现，请点击“添加集成”→“Browser Mod”，完成流程后重启 HA。
通过 HACS 安装只会下载文件；您必须添加集成，以便 HA 注册其操作/实体。

### 2. 后端（核心部分）

1. 在 Home Assistant 中打开您的 `configuration.yaml` 文件。
2. 确保在 `homeassistant:` 下添加此行以启用包功能：

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```
3. 在你的 HA 配置目录下创建一个名为 `packages` 的文件夹（如果还没有的话）。
4. 从本仓库下载 [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml)。
5. 搜索字符串 [ #<--- UPDATE THIS ENTITY] 并将日历实体ID更新为与你环境相符的ID。详见第3节。
6. 将该文件放入你的 `packages/` 文件夹中。
7. **重启 Home Assistant**。

### 3. 日历

你可以使用 **Google 日历** 或 **本地日历**。

#### 选项A：复用日历名称（最简单）


1. 进入 **设置 > 设备与服务**。
2. 添加 **本地日历** 集成。
3. 创建名称完全如下的日历：`calendar1`、`calendar2`、`calendar3`、`calendar4`、`Family`。
    * *如果你使用这些名称，代码即可直接运行！*

#### 选项B：自定义日历

1. 进入 **设置 > 设备与服务**。
2. 添加 **本地日历** 集成或 **Google 日历** 集成。
3. 导航到 **配置 > 集成 > 本地日历** 或 **Google 日历** 并选择“添加条目”
4. 每创建一个条目，都获取实体ID用于更新 dashboard.yaml 文件。
5. 打开 `dashboard.yaml`。
6. 搜索 `# <--- UPDATE THIS ENTITY`。
7. 更新与你环境相符的实体ID。


#### 设置节假日

自 Home Assistant 更新后，节假日现在通过UI添加：

1. 进入 **设置 > 设备与服务 > 添加集成 > Holiday**。
2. 选择你的国家。
3. 检查实体ID（例如 `calendar.holidays`）。如果与默认不同，请在dashboard YAML中更新。

### 4. 看板（外观）


1. 进入 **设置 > 仪表盘**
2. 点击 **添加仪表盘**（选择“从头开始新建仪表盘”，确保选择“添加到侧边栏”）。
3. 在左侧菜单中，选择新创建的仪表盘并点击铅笔图标进行编辑。
5. 选择三个点的图标，然后选择“原始配置编辑器”。
6. 复制并粘贴来自 [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml) 的代码。

### 步骤5：主题（可选）

如需获得特定字体效果（Ovo）：

1. 确保你的 `configuration.yaml` 文件在 `frontend:` 下包含以下内容：

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```
2. 在你的配置目录下创建一个名为 `themes` 的文件夹。
3. 下载 [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) 并将其放入该文件夹。
4. 使用文件编辑器将 calbackgrd.png 上传到 /www/ 文件夹，在仪表盘中会自动映射为 /local。
5. 重启 Home Assistant。
6. 进入你的个人资料（左下角用户图标），将 **主题** 更改为 `Skylight`。
注意：该主题并不全面，请注意这一点。

---

## 📐 工作原理（底层机制）

### 筛选逻辑

`week-planner-card` 本身不支持动态隐藏特定日历。为了解决这个问题，我使用了充当正则过滤器的 **Input Texts**。

* 当你点击某个人的按钮时，它会在 `.*`（显示全部）与 `^$`（全部隐藏）之间切换过滤器。
* `config-template-card` 会动态地将这些变量注入到日历卡片中。

### 事件创建脚本

“添加事件”弹窗使用了一个脚本，能够处理多人的多种事件类型（全天 vs 定时）。


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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---