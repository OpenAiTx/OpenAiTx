# Muzika

> [!CAUTION]
> Muzika 目前不再维护，将在未来归档。详情请参见 https://github.com/vixalien/muzika/issues/220。

Muzika 是一款优雅的音乐流媒体应用。

![Muzika 首页](https://raw.githubusercontent.com/vixalien/muzika/main/data/resources/screenshots/home.png)

![Muzika 播放“My Queen is Angela Davis”](https://raw.githubusercontent.com/vixalien/muzika/main/data/resources/screenshots/playing.png)

> 注意：此项目仍在进行中。该应用尚未准备好用于生产环境。

## 功能

- 个性化首页
- 搜索歌曲、专辑、艺术家、电台和播放列表
- 使用 Google 登录，访问您的播放列表及库中的更多内容
- 播放个性化电台和混音
- 查看歌曲歌词及相关信息
- 浏览艺术家、专辑和播放列表等

## 安装

### 使用最新版 Nightly Flatpak

您可以下载[最新版 Nightly flatpak](https://vixalien.github.io/muzika/muzika.flatpakref)。

### 从源码安装

依赖项：

- GNOME Builder

1. 克隆仓库

```bash
git clone https://github.com/vixalien/muzika.git --recurse-submodules
```
2. 在 GNOME Builder 中打开项目，使用“构建”来构建项目。

> 注意：不再支持直接使用 Meson 和 Ninja，因为 Muzika
> 使用最新的（尚未发布的）libadwaita 组件。

## 导航

Muzika 有一个强大的导航器，允许你通过使用 muzika URI 在不同页面之间导航。下面记录了一些。

muzika URI 的格式为 `muzika:endpoint:data`。URI 也可以带有查询参数。例如，`muzika:library?view=grid` 将以网格视图打开库页面。

你可以通过直接在搜索栏中输入 muzika URI 来导航，muzika 会直接访问该页面而不是进行搜索。

你也可以通过手动触发导航器操作来导航到指定的端点：

1. 按 `Ctrl+Shift+I` 打开 GTK 检查器。
2. 点击右侧的 `Actions` 标签。
3. 找到名为 `navigator.visit` 的操作，在 `Parameter` 字段输入你的 URI，然后点击 `Activate`。

### 端点

所有端点的列表在[这里](https://raw.githubusercontent.com/vixalien/muzika/main/src/pages.ts)。

- `muzika:home` - 主页
- `muzika:playlist:<playlistId>` - 播放列表页面。例如：
  `muzika:playlist:PL4fGSI1pDJn6puJdseH2Rt9sMvt9E2M4i`/
- `muzika:album:<albumId>` - 专辑页面。
- `muzika:artist:<channelId>` - 艺术家或频道页面。
- `search:<query>` - 搜索。注意查询必须是 URL 编码的。例如：
  `search:hello%20world` 搜索 “hello world”。
- `muzika:library` - 库。

随着 Muzika 支持更多功能，将添加更多端点。









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-05

---