# <img src="https://raw.githubusercontent.com/DJS91/HAMusicAssistantJukebox/main/logo.png" width="25" height="25"> Music Assistant 点歌机集成（已弃用）

## 注意：此集成不再主动维护。

Music Assistant 现在有一个插件应当替代使用，且提供了大部分相同功能。
请参阅 https://beta.music-assistant.io/plugins/party-mode/

---

一个 Home Assistant 集成，提供基于网页的点歌系统，结合 Music Assistant 为宾客打造互动点歌机体验！

![点歌机界面](https://raw.githubusercontent.com/DJS91/HAMusicAssistantJukebox/main/showcase.avifs)

## 功能
- 跨所有连接的 Music Assistant 提供商实时搜索歌曲
- 极简响应式设计，显示专辑封面
- 实时查看当前播放和下一个播放的歌曲
- 宾客无需登录，只需分享网址
- 通过 Home Assistant 实体管理队列
- 当请求队列为空时，自动排入默认派对播放列表
- 控制排队频率（限制队列刷屏）
- 通过 Home Assistant 进行访问控制
- 自动撤销/创建访问令牌以保障安全

如果想请求新功能或进行一般讨论，请访问 [讨论 / 功能请求](https://github.com/DJS91/HAMusicAssistantJukebox/discussions)！

## 前提条件

安装此集成前，请确保您具备：
- 运行 Home Assistant 实例并安装了 [Music Assistant](https://github.com/music-assistant/hass-music-assistant) 集成
- Home Assistant 中安装了 Music Assistant 服务器插件（分开托管的 HA/MA 实例可能无法工作）
- 在 Music Assistant 中配置了支持的音乐提供商（例如 Spotify、Apple Music 等）
- 在 Home Assistant 中配置了媒体播放器实体

## 安装

### HACS（推荐）
[![打开您的 Home Assistant 实例并在社区商店中打开此仓库。](https://my.home-assistant.io/badges/hacs_repository.svg)](https://my.home-assistant.io/redirect/hacs_repository/?owner=DJS91&repository=HAMusicAssistantJukebox&category=Integration)

或者
1. 将此仓库添加到 HACS 作为自定义仓库  
   - HACS > 菜单 > 自定义仓库  
   - URL：`https://github.com/DJS91/HAMusicAssistantJukebox`  
   - 分类：集成  
2. 点击安装  
3. 重启 Home Assistant  

### 手动安装  
1. 下载最新版本  
2. 将 `custom_components/music_assistant_jukebox` 文件夹复制到你的 Home Assistant `custom_components` 文件夹中  
3. 重启 Home Assistant  

## 配置  

1. 进入 设置 > 设备与服务  
2. 点击“添加集成”  
3. 搜索“Music Assistant Jukebox”  
4. 选择你的 Music Assistant 实例和媒体播放器实体  
5. 进入 设置 > 自动化与场景 > + 创建自动化  
6. 从列表中选择“Music Assistant Jukebox 控制器”。  
7. 输入步骤4中相同的媒体播放器实体，输入你的 Music Assistant 默认播放列表名称，然后点击保存。  

## 使用  
使用“JukeBox：允许访问”开关开启点唱机。  

通过新的“Music Assistant Jukebox”侧边栏面板访问点唱机 或者  

扫描任意二维码实体 或者  

直接访问点唱机界面：
```
http://homeassistant:8123/local/jukebox/jukebox.html
```

## 实体
该集成向 Home Assistant 添加了以下实体：

### 开关
- `switch.jukebox_queue`：启用/禁用歌曲排队（无需手动控制，由自动化管理。）
- `switch.jukebox_allow_access`：启用/禁用点歌机界面访问权限
- `switch.music_assistant_jukebox_jukebox_play_music_on_start`：点歌机开启时是否自动播放默认播放列表的开关。
  
### 数值
- `number.jukebox_queue_length`：显示当前队列长度（无需手动调整，由自动化管理）
- `number.music_assistant_jukebox_jukebox_queuing_delay`：设置来宾点歌请求之间的延迟（秒）（0 = 关闭）
  
### 传感器
- `music_assistant_jukebox_external_qr_code`：外部点歌机 UI 访问二维码图片，便于在仪表板上与非网络用户共享
- `music_assistant_jukebox_internal_qr_code`：内部点歌机 UI 访问二维码图片，便于在网络内用户间共享

## 自动化蓝图

该集成包含一个自动化蓝图，用于处理：
- 队列长度跟踪
- 默认播放列表回退
- 访问控制
- 媒体播放器控制

使用蓝图步骤：
1. 进入 设置 > 自动化与场景
2. 点击 “+ 创建自动化”
3. 选择 “Music Assistant 点歌机控制器”
4. 配置：
   - 媒体播放器：选择你的 Music Assistant 媒体播放器
   - 默认播放列表：输入你的回退播放列表名称

## 致谢
特别感谢：
- [OddPirate](https://github.com/TheOddPirate) 对将其制作成集成所做的贡献。

- [PilaScat](https://github.com/PilaScat) 对清理、打磨和界面改进的贡献。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-14

---