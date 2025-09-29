# <a href="https://denchisoft.com"><img src="https://raw.githubusercontent.com/DenchiSoft/VTubeStudio/master/Images/vtube_studio_logo_nyan_2.png" width="542" /></a><br> [![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://github.com/DenchiSoft/VTubeStudio/blob/master/LICENSE) [![VTube Studio Discord](https://discordapp.com/api/guilds/652602255748497449/widget.png?style=shield)](https://discord.gg/VTubeStudio) [![Stars](https://img.shields.io/github/stars/DenchiSoft/VTubeStudio?style=social)](https://github.com/DenchiSoft/VTubeStudio) [![Twitter Follow](https://img.shields.io/twitter/follow/VTubeStudio.svg?style=social)](https://twitter.com/VTubeStudio)


[![VTube Studio Discord](https://discordapp.com/api/guilds/652602255748497449/widget.png?style=banner2)](https://discord.gg/VTubeStudio)

## 您是否在寻找[VTube Studio 手册](https://github.com/DenchiSoft/VTubeStudio/wiki)？

可以在这里找到：https://github.com/DenchiSoft/VTubeStudio/wiki

## 您是否在寻找[VTube Studio 插件列表](https://github.com/DenchiSoft/VTubeStudio/wiki/Plugins)？

请查看此页面：https://github.com/DenchiSoft/VTubeStudio/wiki/Plugins

## 您是开发者，想要接收来自 VTube Studio iPhone 应用的追踪数据吗？

请求从 VTube Studio iOS 应用获取追踪数据的流程描述在这里：https://github.com/DenchiSoft/VTubeStudioBlendshapeUDPReceiverTest

## 您是开发者，想了解如何创建 VTube Studio 插件吗？

您所需的一切都在此页面。如果有任何问题，请在[Discord](https://discord.gg/VTubeStudio)中提问。

## 目录

- [一般信息](#general-info)
- [法律信息](#legal-info)
- [可用插件和示例](#available-examples)
- [事件 API](#event-api)
- [API 详情](#api-details)
  - [API 权限](#api-permissions)
  - [API 服务器发现（UDP）](#api-server-discovery-udp)
  - [身份验证](#authentication)
  - [订阅和取消订阅事件](#subscribing-to-and-unsubscribing-from-events)
  - [获取当前 VTS 统计信息](#getting-current-vts-statistics)
  - [获取 VTS 文件夹列表](#getting-list-of-vts-folders)
  - [获取当前加载的模型](#getting-the-currently-loaded-model)
  - [获取可用 VTS 模型列表](#getting-a-list-of-available-vts-models)
  - [通过 ID 加载 VTS 模型](#loading-a-vts-model-by-its-id)
  - [移动当前加载的 VTS 模型](#moving-the-currently-loaded-vts-model)
  - [请求当前或其他 VTS 模型中可用热键列表](#requesting-list-of-hotkeys-available-in-current-or-other-vts-model)
  - [请求执行热键](#requesting-execution-of-hotkeys)
  - [请求表情及其状态列表](#requesting-current-expression-state-list)
  - [请求表情的激活/停用](#requesting-activation-or-deactivation-of-expressions)
  - [请求当前模型中的ArtMeshes列表](#requesting-list-of-artmeshes-in-current-model)
  - [为ArtMeshes着色](#tint-artmeshes-with-color)
  - [获取场景光照叠加色](#getting-scene-lighting-overlay-color)
  - [检查面部跟踪器当前是否检测到面部](#checking-if-face-is-currently-found-by-tracker)
  - [请求可用跟踪参数列表](#requesting-list-of-available-tracking-parameters)
  - [获取某个特定参数的值，默认或自定义](#get-the-value-for-one-specific-parameter-default-or-custom)
  - [获取当前模型中所有Live2D参数的值](#get-the-value-for-all-live2d-parameters-in-the-current-model)
  - [添加新的跟踪参数（“自定义参数”）](#adding-new-tracking-parameters-custom-parameters)
  - [删除自定义参数](#delete-custom-parameters)
  - [为默认或自定义参数提供数据](#feeding-in-data-for-default-or-custom-parameters)
  - [获取当前加载的VTS模型的物理设置](#getting-physics-settings-of-currently-loaded-vts-model)
  - [覆盖当前加载的VTS模型的物理设置](#overriding-physics-settings-of-currently-loaded-vts-model)
  - [获取和/或设置NDI设置](#get-and-set-ndi-settings)
  - [请求可用物品列表或场景中的物品](#requesting-list-of-available-items-or-items-in-scene)
  - [将物品加载到场景中](#loading-item-into-the-scene)
  - [从场景中移除物品](#removing-item-from-the-scene)
  - [控制物品及物品动画](#controling-items-and-item-animations)
  - [移动场景中的物品](#moving-items-in-the-scene)
  - [设置物品的模型内排序](#set-item-within-model-sorting-order)
  - [请求用户选择ArtMeshes](#asking-user-to-select-artmeshes)
  - [将物品固定到模型上](#pin-items-to-the-model)
  - [获取后期处理效果及状态列表](#get-list-of-post-processing-effects-and-state)
  - [设置后期处理效果](#set-post-processing-effects)
  
## 一般信息

VTube Studio拥有一个**公共API**。这意味着您可以编写插件/脚本来触发快捷键、输入面部跟踪数据、加载物品、加载模型、获取各种事件的通知、为模型的ArtMeshes着色等等。

如果您开发了可以与VTube Studio配合使用的插件或任何应用程序，请提交PR，我会将其添加到本页的列表中。

## 法律信息

您可以自由编写、发布和销售任何适用于VTube Studio的插件。无需许可，也没有许可费或版税。

## 可用示例

如果您是VTube Studio的用户，正在寻找可以使用的插件，请查看[插件列表维基页面](https://github.com/DenchiSoft/VTubeStudio/wiki/Plugins)。

如果您是开发者，正在寻找示例/库以便更轻松地将 VTube Studio API 集成到您的应用中，请查看下表。

:warning: **如果您制作了想要包含在此处的内容，请提交拉取请求修改表格！！** :warning:

| 插件 | 开发者 | 类型 | 说明 |
| --- | --- | --- | --- |
| [Cheers Bot](https://cheers.hawk.bar/) | [Hawkbar](https://twitter.com/HawkbarGaming) | 应用 | 一个基于网页的 Twitch 集成平台，当观众兑换频道积分时，可触发 VTube Studio 中的动作，此外还具备许多其他功能。 |
| [VTubeStudioJS](https://github.com/Hawkbat/VTubeStudioJS) | [Hawkbar](https://twitter.com/HawkbarGaming) | 库 | 一个供其他插件作者使用的 JavaScript 库，实现了 VTube Studio WebSocket API。兼容 NodeJS 和浏览器。 |
| [VTS Linker - SMB1](https://github.com/Renpona/VTStudio-Linker-SMB1) | [Renpona](https://twitter.com/renpona) | 示例 | 一个原型项目，从模拟的超级马里奥兄弟游戏中读取数据，并根据游戏中发生的情况自动移动和重新着色 VTS 中的 Live2D 模型。 |
| [VTchaos](https://github.com/Raelice/VTchaos) | [Raelice](https://twitter.com/theraelice) | 应用 | 一个读取 YouTube 和 Twitch 聊天的程序，通过简单的聊天命令在 VTube Studio 中执行模型切换、旋转、热键和移动等功能。 |
| [Mix It Up](https://mixitupapp.com/) | [Mix It Up](https://twitter.com/mixitupapp) | 应用 | 用于聊天、事件及其他强大功能的流媒体软件机器人！ |
| [VsPyYt](https://github.com/mlo40/VsPyYt) | [emlo40](https://emlo40.com) | 应用/框架 | VsPyYt 是一个命令行应用，可以读取 YouTube 聊天并执行保存在 token.json 中的命令。您也可以将其用作与 VTube Studio 交互的 Python 程序基础。 |
| [VTS-Sharp](https://github.com/FomTarro/VTS-Sharp) | [Skeletom](https://www.twitter.com/FomTarro) | 库 | 一个供其他插件作者使用的 Unity/C# 库，实现了 VTube Studio WebSocket API。 |
| [node-red-contrib-vts](https://github.com/eslym/node-red-contrib-vts) | [0nepeop1e](https://github.com/eslym) | 库 | 一个为 Node-RED 提供节点以集成 VTube Studio 的库包。 |
| [VTS Mod](https://github.com/MechaWolfVtuberShin/VTS-Mod/releases/tag/vts-mod) | [MechaWolfVtuber_Shin](https://github.com/MechaWolfVtuberShin) | 应用 | 一个允许用户更改模型表面颜色（包括 RGB）及模型旋转的程序。 |
| [Tie Tools: VTS Color Editor](https://tie-tools.tiberiusx.me) | [Prof. Tiberius](https://www.twitter.com/prof_tiberius) | 应用 | 一个网页应用，可深入控制模型特定部分的颜色和不透明度。 |
| [vtubestudio-rs](https://github.com/walfie/vtubestudio-rs) | [Walfie](https://www.twitter.com/walfieee) | 库 | 一个供其他插件作者使用的 Rust 库，实现了 VTube Studio WebSocket API。 |
| [vts-heartrate](https://skeletom-ch.itch.io/vts-heartrate) | [Skeletom](https://www.twitter.com/FomTarro) | 应用 | 一个连接实时心率数据到 VTube Studio 的插件，允许动态模型着色并基于脉搏提供自定义跟踪参数。 |
| [vts-chameleon](https://satetsu888.github.io/vts-chameleon/) | [satetsu888](https://www.twitter.com/satetsu888) | 应用 | 一个用于应用颜色色调的插件。您可以尝试更改模型的头发、皮肤、制服等的色调。 |
| [ViewLink](https://kawaentertainment.itch.io/viewlink) | [KawaEntertainment](https://twitter.com/kawa_entertain) | 应用 | 您是想直播 VR 游戏但只有 Live2D 模型的 VTuber 吗？使用 ViewLink，您的 Live2D 头像可以在无任何复杂设置或额外硬件的情况下对 VR 游戏做出反应！ |
| [VTS Desktop Audio](https://lualucky.itch.io/vts-desktop-audio-plugin) | [Lua Lucky](https://twitter.com/LuaVLucky) | 应用 | 一个将桌面音频用作 VTS 输入参数的插件。 |
| [pyvts](https://github.com/Genteki/pyvts) | [Genteki](https://github.com/Genteki) | 库 | 一个用于与 VTube Studio API 交互的 Python 库。 |
| [DSYS: Dummy System](https://github.com/chuigda/Project-WG/tree/master/extra/dsys) | [Chuigda](https://github.com/chuigda) | 应用 | 一个用于记录/回放/半自动控制 VTS 模型参数的简单插件。 |
| [SAMMIVtubeStudioExtension](https://github.com/HueVirtualCreature/SAMMIVtubeStudioExtension) | [hue](https://twitter.com/Hue_SwordDevil) | 插件 | 一个用于流媒体自动化工具 [SAMMI](https://sammi.solutions/) 的插件。 |
| [Streamer.bot](https://streamer.bot) | [Streamer.bot](https://streamer.bot) | 应用 | 先进的多平台流媒体软件，具有官方的 [VTubeStudio 集成](https://docs.streamer.bot/guide/integrations/vtube-studio)。 |
| [coovts](https://github.com/lgc2333/coovts) | [LgCookie](https://github.com/lgc2333) | 库 | 另一个用于使用 Python 制作 VTube Studio 插件的库（处于早期开发）。完整类型提示 | 异步设计 | 基于 Pydantic 的数据验证。 |
| [VTS Terminal](https://www.nekomaido.com/plugin/vts-terminal) | [Neko Maido](https://www.nekomaido.com) | 应用 | 一个提供多种实用功能的插件，可以触发热键，调整模型位置和视觉效果，并为您的 Live2D 模型生成 PDF 手册。 |

# 事件 API

另有一篇维基页面介绍了**事件 API**，您可以用它来订阅 VTube Studio 中发生的事件，例如模型加载或热键执行。请查看有关事件的页面[点击这里](Events/)。

# API 详情

VTube Studio 的 websocket 服务器运行在 `ws://localhost:8001`。这是默认端口，但用户也可以在应用中更改端口。Websocket 通常支持 `binary` 和 `text` 消息。VTube Studio 始终以 `text` 消息响应，建议向 API 也发送 `text` 消息。您也可以发送 `binary` 消息，但如果发送，确保其以 UTF-8 编码。

如果您的插件无法连接到 websocket 服务器，请告知用户检查端口是否正确，或是否有防火墙/杀毒软件设置阻止连接。最重要的是，您应让用户在 VTube Studio 中“允许插件 API 访问”，该选项位于 VTS 的主配置页面。您还应确保插件支持配置用于连接的端口。



如果您能连接，您可以首先尝试检查会话状态。

**`请求`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "MyIDWithLessThan64Characters",
	"messageType": "APIStateRequest"
}
```

**`响应`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"messageType": "APIStateResponse",
	"requestID": "MyIDWithLessThan64Characters",
	"data": {
		"active": true,
		"vTubeStudioVersion": "1.9.0",
		"currentSessionAuthenticated": false
	}
}
```
每个请求必须包含 `"apiName" : "VTubeStudioPublicAPI"` 和所使用的 API 版本，在首次发布时为 `"1.0"`。  
该 API 版本将在行为/负载发生不兼容更改之前保持不变。 这意味着可能会向 API 添加新功能（包括现有负载中的新字段），而无需增加版本号。 确保您的应用能处理这种情况，并且在反序列化时遇到未知字段不会崩溃。  

不兼容更改的示例包括重命名现有字段或完全从负载中删除它。 如果发生任何不兼容更改，API 版本将相应增加，以便旧 API 仍可按原样使用。  

您可以在每个请求中添加 `"requestID"` 字段。 这是可选的，但建议添加，因为它允许您识别对请求的响应。  
该 ID 还将用于在 VTube Studio 日志中记录请求及任何错误。 如果出现任何问题，您可以使用此 ID 作为参考，在日志中检查与该请求相关的任何错误。  

您可以为每个请求使用相同的 ID 或不同的 ID。 如果提供，ID 应仅包含 ASCII 字符，长度至少为 1 且最多为 64 个字符。  
如果未添加 `"requestID"` 字段，VTube Studio 将为请求生成一个随机的 UUID，并随响应返回。  

`"currentSessionAuthenticated"` 将告诉您当前会话是否已通过身份验证。  

所有可能的错误 ID 列在页面 [ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs) 上。  

连接后，客户端可以随时轮询当前应用状态信息。  

## API 权限  

VTube Studio API 提供的某些功能需要插件在认证后请求额外的**权限**。 类似于 iOS 和 Android 的权限机制，这确保用户理解插件何时使用可能被视为风险或潜在危险的功能，例如加载任意图像作为项目。  

请求权限时，会向用户显示弹窗，解释该权限的用途。 用户可以选择授予或拒绝。 有关如何请求权限以及需要权限的详细信息，请查看[权限页面](Permissions/)。  

[![VTube Studio 权限请求界面](/Images/vts_api_permissions_1_transparent.png)](Permissions/)  


## API 服务器发现（UDP）  

VTube Studio 还通过本地网络在 UDP 端口 47779 上广播 API 状态。 即使用户关闭了 API，也会每两秒广播一次。  
`instanceID` 是为 VTube Studio 实例启动时生成的随机 ID。 它在该实例运行期间保持不变，因此两个 VTube Studio 实例将拥有不同的 ID。  

`windowTitle` 是窗口的标题文本。 在 Windows 上，不同的 VTS 实例标题不同。 当启动多个实例时，第一个实例的标题为 `VTube Studio`，第二个实例的标题为 `VTube Studio Window 2`，依此类推。 在 macOS 上，所有实例的标题均为 `VTube Studio`。  


```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1630159656406,
	"messageType": "VTubeStudioAPIStateBroadcast",
	"requestID": "VTubeStudioAPIStateBroadcast",
	"data": {
		"active": false,
		"port": 8001,
		"instanceID": "93aa0d0494304fddb057ae8a295c4e59",
		"windowTitle": "VTube Studio"
	}
}
```

## 认证

在使用API之前，您必须先进行一次认证。为此，您需要提供您的插件名称和开发者名称。它们都应在3到32个字符之间。

这是通过请求您的插件令牌来完成的。发送以下请求：

**`请求`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "AuthenticationTokenRequest",
	"data": {
		"pluginName": "My Cool Plugin",
		"pluginDeveloper": "My Name",
		"pluginIcon": "iVBORw0.........KGgoA="
	}
}
```

如果用户已激活API访问权限，这将在VTS内触发一个弹出窗口，询问用户是否允许由“My Name”开发的插件“My Cool Plugin”控制VTube Studio。可以选择添加“pluginIcon”。该图标必须是一个经过Base64编码的PNG或JPG图像，尺寸严格为128x128像素。如果添加了该图标，图标将在显示给用户的插件访问请求弹窗中使用。如果他们点击“允许”，您将收到以下响应：

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "AuthenticationTokenResponse",
	"data": {
		"authenticationToken": "adcd-123-ef09-some-token-string-abcd"
	}
}
```

字段 `"authenticationToken"` 包含一个 ASCII 字符串，作为与 API 认证的令牌。长度最多为 64 个字符。
如果他们拒绝访问，您将收到以下错误：

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "APIError",
	"data": {
		"errorID": 50,
		"message": "User has denied API access for your plugin."
	}
}
```
用户可以随时在 VTube Studio 内撤销对您的插件的 API 访问权限。如果他们这样做，当您尝试发送任何请求时也会收到此错误。在这种情况下，您可以尝试重新认证。

您只需获取一次令牌。使用此令牌，您现在可以为本次会话进行认证。在下一次会话（例如当 VTS 重启或您的插件因某些原因必须重新连接到 VTS）中，您可以使用相同的令牌再次认证，这样就不必再次发送请求以获取令牌，用户只会被询问一次是否允许您的插件。

要为一次会话认证，请使用您的令牌发送以下请求：

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "AuthenticationRequest",
	"data": {
		"pluginName": "My Cool Plugin",
		"pluginDeveloper": "My Name",
		"authenticationToken": "adcd-123-ef09-some-token-string-abcd"
	}
}
```

`"pluginName"` 和 `"pluginDeveloper"` 必须与您请求令牌时使用的值匹配，否则身份验证请求将失败。

如果令牌有效且用户未撤销 API 访问权限，您将收到以下响应：

**`响应`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "AuthenticationResponse",
	"data": {
		"authenticated": true,
		"reason": "Token valid. The plugin is authenticated for the duration of this session."
	}
}
```
恭喜，您已通过身份验证，可以使用 VTube Studio API。

如果缺少必填字段，您将收到错误响应。如果所有字段都存在且格式正确，但令牌无效或已被用户撤销，`"authenticated"` 将返回为 `false`。

**关于 `data` 字段的说明：** 有些请求包含 `data` JSON 对象字段，有些则没有。为了方便您，您也可以在不需要该字段的请求中包含它。VTube Studio 会忽略它，即使您将其留空或设置为 `null`/`undefined`。VTube Studio 会在每个请求的响应中返回此字段，以便您的插件更容易反序列化。如果响应没有数据，该字段将包含一个空的 JSON 对象。

**关于 `timestamp` 字段的说明：** 所有响应也都包含一个 `"timestamp"` 字段，里面包含处理您请求时的 UNIX 毫秒时间戳。您可以在请求中包含 `"timestamp"` 字段，但会被忽略。

## 订阅和取消订阅 [事件](Events/)

在之前的 API 版本中，插件需要反复轮询已加载的模型或项目等信息。现在，VTube Studio 支持订阅 **“事件”**，这样每当发生与您的插件相关的事情时，VTube Studio 会发送消息给您。事件包括加载项目时通知、丢失/恢复跟踪时通知、模型被点击时通知等。

请查看关于事件的页面[就在这里](Events/)。

## 获取当前 VTS 统计信息

**`请求`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "StatisticsRequest"
}
```

**`响应`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "StatisticsResponse",
	"data": {
		"uptime": 1439384,
		"framerate": 73,
		"vTubeStudioVersion": "1.9.0",
		"allowedPlugins": 7,
		"connectedPlugins": 2,
		"startedWithSteam": true,
		"windowWidth": 1031,
		"windowHeight": 812,
		"windowIsFullscreen": false
	}
}
```

`"uptime"` 包含 VTube Studio 启动以来的毫秒数。`"framerate"` 是当前的渲染帧率值。`"allowedPlugins"` 是用户当前允许使用 VTube Studio 的插件数量，`"connectedPlugins"` 是当前连接到 VTube Studio API 的插件数量。`"startedWithSteam"` 如果应用是通过 Steam 启动则为 true，否则为 false（如果是通过 `.bat` 文件启动 VTS 而非 Steam）。

窗口宽度和高度以像素为单位。

## 获取 VTS 文件夹列表

返回各种 VTube Studio 文件夹的名称。它们位于游戏文件中的 `StreamingAssets` 文件夹内。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "VTSFolderInfoRequest"
}
```
**`响应`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "VTSFolderInfoResponse",
	"data": {
		"models": "Live2DModels",
		"backgrounds": "Backgrounds",
		"items": "Items",
		"config": "Config",
		"logs": "Logs",
		"backup": "Backup"
	}
}
```

## 获取当前加载的模型

**`请求`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "CurrentModelRequest"
}
```

**`响应`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "CurrentModelResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDToIdentifyThisModelBy",
		"vtsModelName": "Model.vtube.json",
		"vtsModelIconName": "ModelIconPNGorJPG.png",
		"live2DModelName": "Model.model3.json",
		"modelLoadTime": 3021,
		"timeSinceModelLoaded": 419903,
		"numberOfLive2DParameters": 29,
		"numberOfLive2DArtmeshes": 136,
		"hasPhysicsFile": true,
		"numberOfTextures": 2,
		"textureResolution": 4096,
		"modelPosition": {
			"positionX": -0.1,
			"positionY": 0.4,
			"rotation": 9.33,
			"size": -61.9
		}
	}
}
```
`"modelLoaded"` 如果当前已加载模型，则为 `true`。如果没有加载模型或模型正在加载中，则为 false。在这种情况下，所有其他值将为空（或整数为零）。

`"modelLoadTime"` 是加载当前模型所用的时间，单位为毫秒。`"timeSinceModelLoaded"` 包含自模型加载以来经过的时间，单位为毫秒。

`"vtsModelIconName"` 包含此模型在 VTube Studio 的模型选择栏中使用的图标名称。如果模型未设置图标，则该值为空字符串。此请求返回的所有文件名均相对于各自的模型文件夹。

`"modelPosition"` 数组包含当前模型的位置、旋转和大小。有关如何解释这些值的更多信息，请参见 `MoveModelRequest`。

## 获取可用 VTS 模型列表

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "AvailableModelsRequest"
}
```

**`响应`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "AvailableModelsResponse",
	"data": {
		"numberOfModels": 2,
		"availableModels": [
			{
				"modelLoaded": false,
				"modelName": "My First Model",
				"modelID": "UniqueIDToIdentifyThisModelBy1",
				"vtsModelName": "Model_1.vtube.json",
				"vtsModelIconName": "ModelIconPNGorJPG_1.png"
			},
			{
				"modelLoaded": true,
				"modelName": "My Second Model",
				"modelID": "UniqueIDToIdentifyThisModelBy2",
				"vtsModelName": "Model_2.vtube.json",
				"vtsModelIconName": "ModelIconPNGorJPG_1.png"
			}
		]
	}
}
```

`"modelLoaded"` 如果相应的模型当前已加载到 VTube Studio 中，则为 `true`，否则为 `false`。

## 通过其 ID 加载 VTS 模型

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ModelLoadRequest",
	"data": {
		"modelID": "UniqueIDOfModelToLoad"
	}
}
```

**`响应`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ModelLoadResponse",
	"data": {
		"modelID": "UniqueIDOfModelThatWasJustLoaded"
	}
}
```
这可能会失败并返回错误，如果应用程序当前处于无法加载/卸载模型的状态。这包括打开配置窗口或当前已经有模型加载操作正在进行中。此请求还有一个全局的2秒冷却时间。

如果传入空的模型ID，当前加载的模型将被卸载（如果没有加载模型则不会执行任何操作）。

## 移动当前加载的VTS模型

如果已加载模型，则允许更改其位置、旋转和大小。如果没有加载模型，则会返回错误，参见[ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)

此请求中必需的字段是 `"timeInSeconds"` 和 `"valuesAreRelativeToModel"`。`"timeInSeconds"` 是移动所需的时间，单位为秒，必须是介于0和2之间的浮点值。如果设置为0，模型将立即出现在给定位置。大于0的值将使模型平滑地移动、旋转和缩放到指定位置（淡入/淡出）。移动过程中，用户无法通过拖动手动移动模型。模型完成移动约半秒后，用户才可以再次手动移动。

后续的 `MoveModelRequest` 可以在当前移动未完成时发送。如果有移动进行中，将被中断并由新请求替换。你甚至可以通过每帧发送一次 `"timeInSeconds"` 为0的请求来完全控制移动。

`"size"` 的取值是介于 -100（最小）和 +100（最大）之间的浮点数。关于 `"positionX"`、`"positionY"` 和 `"rotation"`，请参阅下图：

#### VTS坐标系统
![The VTS Coordinate System](/Images/coordinate_explanation.png)

猫身上的数字代表你可以通过 `"positionX"` 和 `"positionY"` 传入的 **[X/Y]** 坐标。例如，传入 [0/0] 会将模型中点定位在屏幕中心。模型中点在 Live2D Cubism 中可以自由设置，不同模型可能不同。当然，你也可以传入更大或更小的值将模型移出屏幕。`"positionX"` 和 `"positionY"` 的取值范围必须在 -1000 到 1000 之间。

圆周上的数字代表你可以通过 `"rotation"` 设置的角度。该参数的取值必须介于 -360 到 360 之间。请注意，每个角度有两个表示法：顺时针旋转为正值，逆时针旋转为负值。使用哪种取决于你，二者无区别。当你发送 `CurrentModelRequest` 时，响应也会包含模型的位置/旋转/大小。在该响应中，角度总是用正数表示法。

你不必在请求中提供所有数值。例如，你可以只提供位置或只提供旋转，或任何其他组合。请求中未包含的值在设置位置/旋转/大小时将被忽略。这样，你就可以只更改模型的X坐标，而保持其他参数不变。

如果 `"valuesAreRelativeToModel"` 设置为 `false`，则请求中的数值被视为绝对值，模型将移动到该位置。如果设置为 `true`，则数值被视为相对于当前模型位置的相对值。假设你设置为 `true`，且请求中只包含旋转值 `10`，那么模型将顺时针旋转10度，而不会改变位置和大小。这对于实现模型原地移动的效果非常有用，比如独立于屏幕位置让模型抖动。

如果你想将模型移动到固定的像素位置或移动一定像素数，则需要自己计算相应的坐标。你可以通过 `StatisticsRequest` 获取窗口的宽高像素数来实现。

**`请求`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "MoveModelRequest",
	"data": {
		"timeInSeconds": 0.2,
		"valuesAreRelativeToModel": false,
		"positionX": 0.1,
		"positionY": -0.7,
		"rotation": 16.3,
		"size": -22.5
	}
}
```

**`响应`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "MoveModelResponse",
	"data": { }
}
```
## 请求当前或其他VTS型号中可用快捷键列表

**`REQUEST`**



```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "HotkeysInCurrentModelRequest",
	"data": {
		"modelID": "Optional_UniqueIDOfModel",
		"live2DItemFileName": "Optional_Live2DItemFileName"
	}
}
```

`"modelID"`（以及这里的 `"data"` 对象）是可选的。如果未提供，则返回当前模型的快捷键。如果提供了模型ID，则返回具有该模型ID的模型的快捷键。如果未找到该ID的模型，则返回错误（参见 [ErrorID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)，`ModelIDNotFound`）。

这也可以返回任何可用 Live2D 项目的快捷键。要实现此目的，只需在 `"live2DItemFileName"` 字段中传入该项目的文件名。您可以使用 `ItemListRequest` 获取所有可用 Live2D 项目的（唯一）文件名。

如果同时提供了 `"modelID"` 和 `"live2DItemFileName"`，则仅使用 `"modelID"`，另一个字段将被忽略。

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "HotkeysInCurrentModelResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDOfModel",
		"availableHotkeys": [
			{
				"name": "My first hotkey",
				"type": "ToggleExpression",
				"description": "Toggles an expression",
				"file": "myExpression_1.exp3.json",
				"hotkeyID": "SomeUniqueIdToIdentifyHotkeyWith1",
				"keyCombination": [],
                		"onScreenButtonID": 8
			},
			{
				"name": "My second hotkey",
				"type": "TriggerAnimation",
				"description": "Triggers an animation",
				"file": "myAnimation.motion3.json",
				"hotkeyID": "SomeUniqueIdToIdentifyHotkeyWith2",
				"keyCombination": [],
                		"onScreenButtonID": -1
			},
			{
				"name": "My third hotkey",
				"type": "ChangeVTSModel",
				"description": "Changes the VTS model",
				"file": "someOtherModel.vtube.json",
				"hotkeyID": "SomeUniqueIdToIdentifyHotkeyWith3",
				"keyCombination": [],
                		"onScreenButtonID": -1
			},
			{
				"name": "My fourth hotkey",
				"type": "MoveModel",
				"description": "Moves the Live2D model",
				"file": "",
				"hotkeyID": "SomeUniqueIdToIdentifyHotkeyWith4",
				"keyCombination": [],
                		"onScreenButtonID": -1
			},
			{
				"name": "My fifth hotkey",
				"type": "Unset",
				"description": "No action set for hotkey",
				"file": "",
				"hotkeyID": "SomeUniqueIdToIdentifyHotkeyWith5",
				"keyCombination": [],
                		"onScreenButtonID": 5
			}
		]
	}
}
```
如果请求中未指定模型 ID 且未加载任何模型，`"modelLoaded"` 将为 false，且 `"availableHotkeys"` 数组将为空。若指定了 ID，`"modelLoaded"` 字段将根据当前是否加载了该 ID 对应的模型而为 `true` 或 `false`。

`"file"` 字段包含类型为 `TriggerAnimation`、`ChangeIdleAnimation`、`ToggleExpression` 和 `ChangeVTSModel` 的热键对应的表情/动画/模型文件名。对于 `ChangeBackground` 热键，此字段包含去掉文件扩展名的背景名称。对于所有其他类型，则为空字符串。

`"description"` 字段包含热键功能的描述。当插件遇到未知的热键类型时（例如热键类型是 VTube Studio 新增的），可在插件 UI 上显示此字符串。

`"keyCombination"` 数组包含触发热键的键盘（或鼠标键）组合。所有可能的值请参见 [RestrictedRawKey.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/RestrictedRawKey.cs)。如果数组为空，表示未设置键盘组合。**重要提示：** 出于安全考虑，当前 `"keyCombination"` 数组**始终为空**，因此插件暂时无法获取此数据。未来版本可能会重新加入。

`"onScreenButtonID"` 字段包含将触发热键的所有屏幕按钮 ID（1（顶部）至 8（底部）或 -1）。若值为 `-1`，表示该热键未设置屏幕按钮。

所有热键类型字符串均可在页面 [HotkeyActions.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/HotkeyAction.cs) 中找到。

## 请求执行热键

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "HotkeyTriggerRequest",
	"data": {
		"hotkeyID": "HotkeyNameOrUniqueIdOfHotkeyToExecute",
		"itemInstanceID": "Optional_ItemInstanceIdOfLive2DItemToTriggerThisHotkeyFor"
	}
}
```

**`响应`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "HotkeyTriggerResponse",
	"data": {
		"hotkeyID": "UniqueIdOfHotkeyThatWasExecuted"
	}
}
```
这会触发当前加载的 VTube Studio 模型的热键，如果你将 `"itemInstanceID"` 留空或根本不提供该字段。如果你在该字段中提供了一个 ID，则会触发指定 Live2D 项目模型中的热键（详情见下文）。

你可以通过唯一 ID 或热键名称（不区分大小写）来触发热键。如果多个热键名称相同，则只执行第一个（顺序为它们在 UI 中显示的顺序）。名称为空的热键只能通过 ID 触发。

如果未找到热键 ID 或名称，或者热键因某些原因无法执行，可能会返回错误。原因包括当前没有加载模型或热键冷却未结束（每个特定热键每 5 帧只能触发一次）。你可以快速连续发送不同热键，它们将被排队。每 5 帧会从队列中取出一个热键执行。队列最多可容纳 32 个热键。队列满时再尝试发送更多热键，将返回错误。

### 在 Live2D 项目中触发热键

你也可以使用此请求触发 Live2D 项目中的热键。有关 Live2D 项目的更多信息，请参见[此页面](https://github.com/DenchiSoft/VTubeStudio/wiki/Live2D-Items)。

只需将 `"itemInstanceID"` 设置为 Live2D 项目的实例 ID 即可。如果当前没有加载该实例 ID 的 Live2D 项目，将返回错误。要获取所有当前加载项目的实例 ID，可以使用 `ItemListRequest`。

## 请求当前表情状态列表

你可以获取一个特定表情或所有表情的当前状态（激活或未激活）。如果包含 `"expressionFile"`，则只返回该表情的状态。如果不包含或留空，则返回当前模型中所有表情的状态。

如果包含的文件名无效（不以 `.exp3.json` 结尾）或在当前模型中找不到，则返回错误（参见 "[ErrorID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)"）。

将 `"details"` 设置为 true 将在响应中返回更多细节（具体而言，如果 `"details"` 设置为 false，`"usedInHotkeys"` 和 `"parameters"` 数组将为空）。

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ExpressionStateRequest",
	"data": {
		"details": true,
		"expressionFile": "myExpression_optional_1.exp3.json",
	}
}
```
如果没有加载模型，`expressions` 数组将为空。否则，该数组将包含当前加载模型的可用表情信息。

`"file"` 字段是表情文件名，存储在模型文件夹中。`"name"` 与其相同，但不带 `.exp3.json` 扩展名。`"active"` 表示表情当前是否处于激活状态。

如果表情是通过热键激活的，`"deactivateWhenKeyIsLetGo"` 和 `"autoDeactivateAfterSeconds"` 将告诉您这些选项是否被用于表情热键。如果 `"autoDeactivateAfterSeconds"` 为 `true`，则 `"secondsRemaining"` 会返回表情自动停用前剩余的时间（否则为 0）。

如果请求中 `"details"` 设置为 `true`，`"usedInHotkeys"` 数组将包含所有使用该表情的热键列表。同时，`"parameters"` 数组将包含表情内容，即表情中使用的所有 Live2D 参数 ID 及其目标值。

**`RESPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ExpressionStateResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDOfModel",
		"expressions": [
			{
				"name": "myExpression_optional_1",
				"file": "myExpression_optional_1 .exp3.json",
				"active": false,
				"deactivateWhenKeyIsLetGo": false,
				"autoDeactivateAfterSeconds": false,
				"secondsRemaining": 0,
				"usedInHotkeys": [
					{
						"name": "Some Hotkey",
						"id": "SomeUniqueIdToIdentifyHotkeyWith1"
					},
					{
						"name": "Some other Hotkey",
						"id": "SomeUniqueIdToIdentifyHotkeyWith2"
					}
				],
				"parameters": [
					{
						"name": "SomeLive2DParamID",
						"value": 0
					}
				]
			}
		]
	}
}
```

## 请求激活或停用表情

建议通过快捷键激活表情，否则用户可能会激活无法通过快捷键停用的表情，因为他们没有为其设置快捷键。 但是，如果您的插件需要，也可以直接激活和停用快捷键。 您可以通过传入表情文件名以及是否应激活或停用该表情来实现此操作。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ExpressionActivationRequest",
	"data": {
		"expressionFile": "myExpression_1.exp3.json",
		"fadeTime": 0.5,
		"active": true
	}
}
```

如果请求成功，您将获得此空响应。如果文件名无效（不是以 `.exp3.json` 结尾）或当前模型中未找到该文件，或未加载任何模型，将返回错误（参见 "[ErrorID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)"）。
`fadeTime` 参数被限制在 0 到 2 秒之间。默认值为 0.25。请注意，由于 VTS 动画系统的限制，淡入时才能设置淡出时间。淡出表情时，将始终使用淡入时的相同时长。

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ExpressionActivationResponse",
	"data": { }
}
```

## 请求当前模型中的 ArtMeshes 列表

API 使用术语 `ArtMesh Name`，但这实际上指的是每个模型唯一的 ArtMesh ID，这是由 Live2D Cubism 编辑器强制执行的。可以通过选择一个 ArtMesh 并在 UserData 字段中填写内容来添加 `ArtMesh Tags`。如果你想使用标签，确保勾选了 `Export UserData file (userdata3.json)`。然后在将模型复制到 VTube Studio Live2DModels 文件夹时应包括 `.userdata3.json` 文件。

返回的 `"artMeshTags"` 数组中的 ArtMesh 标签不会包含重复标签。

如果没有加载模型，`"modelLoaded"` 将为 `false`，数组将为空。

**关于“标签”的说明：** 可以在 Live2D Cubism 编辑器的 “UserData” 字段中为 ArtMeshes 添加标签。你可以在编辑器中向该字段添加任何文本。VTube Studio 会在空格和换行符处分割该文本。这意味着如果你的标签文本是“my tag”，它将在 VTS 中变成两个标签：“my”和“tag”。你可以为每个 ArtMesh 添加任意数量的标签。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ArtMeshListRequest"
}
```

**`响应`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ArtMeshListResponse",
	"data": {
		"modelLoaded": true,
		"numberOfArtMeshNames": 5,
		"numberOfArtMeshTags": 2,
		"artMeshNames": ["ArtMesh1", "ArtMesh2", "HairFront1", "HairFront2", "SomeArtMesh"],
		"artMeshTags": ["my_tag", "SomeOtherTag"]
	}
}
```

## 使用颜色着色 ArtMeshes

您可以通过提供颜色和匹配条件来着色 ArtMeshes。任何符合任一给定条件的 ArtMesh 都将被着色为指定颜色。要重置 ArtMesh 颜色，请将其着色为白色（R=G=B=A=255）。此请求无法将 ArtMesh 设置为白色，只能使其变暗。

未提供某个颜色值或任何值超出 0-255 范围将返回错误。尝试在未加载模型时发送此请求也会返回错误。

可选地，您可以提供介于 0 到 1 之间的 `mixWithSceneLightingColor`。如果提供，该值将决定着色颜色与场景照明系统颜色的混合方式（更多信息请参见[此处](https://github.com/DenchiSoft/VTubeStudio/wiki/Display-Light-Overlay)）。如果设置为 1，您提供的颜色值将完全覆盖场景照明设置的颜色。设置为 0 则场景照明颜色覆盖您提供的颜色。介于两者之间的值将混合两种颜色。如果场景照明关闭，则无效。如果未提供 `mixWithSceneLightingColor`，默认设置为 1，即您的颜色将完全覆盖场景照明。

`"artMeshMatcher"` 对象中的所有数组均为可选。如果包含，它将根据 ArtMesh 名称或标签是否与任何给定字符串完全匹配或包含它们（使用 `"nameContains"`/`"tagContains"` 数组时）来选择 ArtMeshes。`"artMeshNumber"` 数组可根据模型中 ArtMesh 的顺序进行选择。如果您想为整个模型着色，请不要包含任何匹配数组，而是将 `"tintAll"` 设置为 true。

当会话断开时，此会话中所有被着色的 ArtMeshes 将重置为默认（完全不透明的白色）。当多个插件/会话覆盖同一 ArtMesh 的颜色时，将使用最近请求设置的颜色。

匹配始终为**不区分大小写**。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ColorTintRequest",
	"data": {
		"colorTint": {
			"colorR": 255,
			"colorG": 150,
			"colorB": 0,
			"colorA": 255,
			"mixWithSceneLightingColor": 1
		},
		"artMeshMatcher": {
			"tintAll": false,
			"artMeshNumber": [1, 3, 5],
			"nameExact": ["eye_white_left", "eye_white_right"],
			"nameContains": ["mouth"],
			"tagExact": [],
			"tagContains": ["MyTag"]
		}
	}
}
```

**`响应`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ColorTintResponse",
	"data": {
		"matchedArtMeshes": 3
	}
}
```

## 获取场景光照叠加颜色

VTube Studio 具有将模型覆盖为从屏幕（macOS/Windows）或特定窗口（仅限 Windows）捕获的平均颜色的功能。更多信息，请参见[文档中的此页面](https://github.com/DenchiSoft/VTubeStudio/wiki/Display-Light-Overlay)。

您可以通过 API 获取场景光照叠加系统的当前用户配置和颜色。

在响应的顶层，有一个 `active` 字段，告诉您光照叠加是否开启。如果 `itemsIncluded` 为真，则所有项目也会受到光照叠加的影响。如果 `isWindowCapture` 为 `true`，则 VTube Studio 设置为捕获窗口的平均颜色。如果为 `false`，则捕获设置为屏幕。

`baseBrightness`（介于 0 到 100 之间）、`colorBoost`（介于 0 到 100 之间）和 `smoothing`（介于 0 到 60 之间）是用户可通过 UI 滑块选择的三个值。有关说明，请查看[此功能的文档页面](https://github.com/DenchiSoft/VTubeStudio/wiki/Display-Light-Overlay)。

`leftCapturePart`、`middleCapturePart` 和 `rightCapturePart` 描述了捕获的窗口或屏幕相应部分的平均颜色。它们的 `active` 字段告诉您该屏幕部分是否已被用户激活。

从所有激活的屏幕部分计算得出的平均颜色可以在 `colorAvg` 字段中找到（R、G 和 B 介于 0 到 255 之间）。

将用于覆盖 ArtMeshes 的最终颜色位于 `colorOverlay` 字段中（R、G 和 B 介于 0 到 459 之间）。请注意，这允许值高于 255。最终颜色按以下公式计算：

`colorAvg` *  (`colorBoost` / 50) + `WHITE_COLOR` * (`baseBrightness` / 100)

这可能会产生高达 2 * 255 的 R、G 和 B 值。数值被限制在 1.8 * 255 = 459。

当光照叠加系统关闭时，顶层负载的 `active` 将为 `false`，所有颜色将返回为白色。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "SceneColorOverlayInfoRequest"
}
```

**`响应`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "SceneColorOverlayInfoResponse",
	"data": {
		"active": true,
		"itemsIncluded": true,
		"isWindowCapture": false,
		"baseBrightness": 16,
		"colorBoost": 35,
		"smoothing": 6,
		"colorOverlayR": 206,
		"colorOverlayG": 150,
		"colorOverlayB": 153,
		"colorAvgR": 237,
		"colorAvgG": 157,
		"colorAvgB": 162,
		"leftCapturePart": {
			"active": true,
			"colorR": 243,
			"colorG": 231,
			"colorB": 234
		},
		"middleCapturePart": {
			"active": true,
			"colorR": 230,
			"colorG": 83,
			"colorB": 89
		},
		"rightCapturePart": {
			"active": false,
			"colorR": 235,
			"colorG": 95,
			"colorB": 101
		}
	}
}
```
## 检查人脸当前是否被跟踪器检测到

返回当前是否被活动跟踪器（通过网络/USB的智能手机或网络摄像头跟踪器）检测到人脸。

**`请求`**


```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "FaceFoundRequest"
}
```

**`响应`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "FaceFoundResponse",
	"data": {
		"found": true
	}
}
```

## 请求可用追踪参数列表

您可以请求当前在 VTube Studio 中可用的参数列表。
这包括所有常规参数和插件创建的所有自定义参数。插件创建的参数在您从 VTube Studio 的参数列表中选择时会标记为插件参数。它还会显示创建该参数的插件名称。

**重要提示：** 这可能会返回大量数据。不建议以高频率（60+ FPS）发送此请求，因为这可能会导致较慢电脑的性能问题。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "InputParameterListRequest"
}
```

**`响应`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "InputParameterListResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDOfModel",
		"customParameters": [
			{
				"name": "MyCustomParamName1",
				"addedBy": "My Plugin Name",
				"value": 12.4,
				"min": -30,
				"max": 30,
				"defaultValue": 0
			},
			{
				"name": "MyCustomParamName2",
				"addedBy": "My Plugin Name",
				"value": 0.833,
				"min": -10,
				"max": 10,
				"defaultValue": 0
			},
			{
				"name": "MyCustomParamName3",
				"addedBy": "My Other Plugin Name",
				"value": 0,
				"min": 0,
				"max": 1,
				"defaultValue": 0
			}
		],
		"defaultParameters": [
			{
				"name": "FaceAngleX",
				"addedBy": "VTube Studio",
				"value": 45.78,
				"min": -30,
				"max": 30,
				"defaultValue": 0
			},
			{
				"name": "FacePositionX",
				"addedBy": "VTube Studio",
				"value": 8.33,
				"min": -10,
				"max": 10,
				"defaultValue": 0
			}
		]
	}
}
```
**注意：** 此示例负载中的 `"defaultParameters"` 数组不完整。该数组将包含 VTube Studio 提供的所有默认面部/鼠标等跟踪参数

## 获取一个特定参数的值，默认或自定义

如果请求的输入参数不存在，将返回错误。

**`请求`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ParameterValueRequest",
	"data": {
		"name": "MyCustomParamName1"
	}
}
```

**`响应`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ParameterValueResponse",
	"data": {
		"name": "MyCustomParamName1",
		"addedBy": "My Plugin Name",
		"value": 12.4,
		"min": -30,
		"max": 30,
		"defaultValue": 0
	}
}
```

## 获取当前模型中所有 Live2D 参数的值

如果未加载模型，将返回错误。

**`请求`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "Live2DParameterListRequest"
}
```

**`响应`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "Live2DParameterListResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDOfModel",
		"parameters": [
			{
				"name": "MyLive2DParameterID1",
				"value": 12.4,
				"min": -30,
				"max": 30,
				"defaultValue": 0
			},
			{
				"name": "MyLive2DParameterID2",
				"value": 0,
				"min": 0,
				"max": 1,
				"defaultValue": 0
			}
		]
	}
}
```

如果没有加载模型，`"modelLoaded"` 将为 false，参数数组将为空。所有其他字段将是空字符串。

## 添加新的追踪参数（“自定义参数”）

您还可以添加自己的新追踪参数，并在您的 VTube Studio 模型中使用它们。它们被称为“自定义”参数。插件添加后，用户可以选择您的参数作为 Live2D 参数映射的输入。

参数名称必须唯一，且为字母数字（不允许空格），长度必须在 4 到 32 个字符之间。新追踪参数的创建方式如下：

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ParameterCreationRequest",
	"data": {
		"parameterName": "MyNewParamName",
		"explanation": "This is my new parameter.",
		"min": -50,
		"max": 50,
		"defaultValue": 10
	}
}
```

**`响应`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ParameterCreationResponse",
	"data": {
		"parameterName": "MyNewParamName"
	}
}
```
请求可能会失败并返回错误，如果参数名称无效。

如果由不同插件创建的同名参数已存在，也会失败。如果使用相同插件名称多次创建参数，请求将成功。您也可以通过这种方式覆盖 `min`、`max` 和 `defaultValue` 值。

最小/最大/默认值必须是介于 `-1000000` 和 `1000000` 之间的浮点数。最小/最大值实际上并不是参数允许的最小和最大值。它们是在使用此参数创建新的参数映射时，将用作默认下限和上限的值。

说明是一个可选的简短（少于 256 字符）解释，说明参数的作用以及用户应如何在模型中使用它。如果您在请求中提供此内容，当用户查看此自定义参数的详细信息时会显示。

VTS 中有全局限制为 300 个自定义参数，每个插件限制为 100 个自定义参数。如果您尝试创建更多，将返回错误。

您创建的这些自定义参数作为 VTube Studio 配置的一部分存储在名为 `custom_parameters.json` 的文件中，该文件位于 VTube Studio `StreamingAssets` 文件夹中的 `Config` 文件夹内。如果您撤销插件的身份验证令牌，该插件创建的所有自定义参数也将被删除。它们仍会保留在使用它们的 VTube Studio 模型中，但会以红色文本显示，表明输入参数不再存在。插件可以随时获取另一个令牌并重新创建这些参数，它们将继续工作。

## 删除自定义参数

您可以删除自定义参数。默认参数无法删除。您也不能删除由除您用于验证此会话的插件之外的插件创建的参数。

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ParameterDeletionRequest",
	"data": {
		"parameterName": "MyNewParamName"
	}
}
```

**`响应`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ParameterDeletionResponse",
	"data": {
		"parameterName": "MyNewParamName"
	}
}
```

## 为默认或自定义参数输入数据

您可以为任何默认或自定义参数输入数据。这些跟踪参数随后将作为加载的 VTube Studio 模型和任何加载的 [Live2D 项目](https://github.com/DenchiSoft/VTubeStudio/wiki/Live2D-Items) 的输入。

数据载荷如下所示：

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "InjectParameterDataRequest",
	"data": {
		"faceFound": false,
		"mode": "set",
		"parameterValues": [
			{
				"id": "FaceAngleX",
				"value": 12.31
			},
			{
				"id": "MyNewParamName",
				"weight": 0.8,
				"value": 0.7
			}
		]
	}
}
```

**`响应`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "InjectParameterDataResponse",
	"data": { }
}
```
如果一个或多个参数不存在，将返回错误负载。

值必须是介于 `-1000000` 和 `1000000` 之间的浮点数。超出该范围的值也会返回错误。

如果来自摄像头/iOS/Android 跟踪的参数值存在，API 中的值将覆盖这些值，只要您继续通过 API 发送数据。
您必须**至少每秒重新发送一次**您想用插件控制的参数的数据。未能做到这一点将导致参数被视为“丢失”，并且它将返回到之前控制它的值。如果没有其他控制它的，将返回其默认值。

您还可以添加一个可选的 `"weight"` 参数，范围在 0 到 1 之间。该参数可用于将您发送的参数 `"value"` 与面部跟踪设置的参数值混合。例如，您可以将一个参数 50% 用面部跟踪控制，50% 用 API 控制。但一次只能有一个 API 插件写入一个参数。一个用例是淡入/淡出面部跟踪参数的控制，这样通过 API 接管时参数不会“跳变”。如果请求中未包含 `"weight"` 参数，则默认为 1，意味着目标参数将立即设置为插件提供的值。

还应注意，这些参数的处理方式类似于普通的跟踪参数。因此，您可以像选择普通输入一样选择它们作为 VTube Studio 参数映射的输入，并通过 UI 上的滑块应用平滑处理。在模型使用这些自定义参数期间删除它们也不会造成任何问题，可以随时重新创建。

可选地，您可以传入 `"faceFound": true`，这将告诉 VTube Studio 认为用户面部已被找到。这样，您可以控制“跟踪丢失”动画的播放时机。

### 使用多个插件控制一个参数

通常，如果另一个插件已控制某个（默认或自定义）参数，将返回错误。这是因为一次只能有一个插件“设置”（覆盖）给定参数，这是该请求的默认模式。当您不在 `"mode"` 字段中提供值或将其设置为 `"set"` 时，即使用该模式。

或者，您可以将 `"mode"` 字段设置为 `"add"`。这将把您发送的值加到当前参数值上。在这种情况下不使用 `"weight"` 值。任意数量的插件可以同时对某个参数使用 `"add"` 模式。这对于 **bonk/throwing** 类型的插件和其他用例非常有用。

## 获取当前加载的 VTS 模型的物理设置

用户可以在 VTube Studio 中自定义物理设置。他们可以更改以下设置：

- **基础物理强度（每个模型）：** 整数，介于 0（关闭）和 100（最大）之间。默认是 50，表示物理表现与 Live2D Cubism 编辑器一致。
- **基础风力强度（每个模型）：** 整数，介于 0（关闭）和 100（最大）之间。默认是 0。
- **物理乘数（每个物理组）：** 对于每个物理组（可在 Live2D Cubism 中设置），用户可以设置乘数。处理相应物理组时，基础物理值将乘以该值。浮点数，介于 0 到 2 之间，默认是 1，表示基础值保持不变。
- **风力乘数（每个物理组）：** 对于每个物理组（可在 Live2D Cubism 中设置），用户可以设置乘数。处理相应物理组时，基础风力值将乘以该值。浮点数，介于 0 到 2 之间，默认是 1，表示基础值保持不变。

用户设置的这些值可以通过 API 读取，也可以临时覆盖（见 `SetCurrentModelPhysicsRequest`）。

要读取当前加载模型的值，请使用此请求：


**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "GetCurrentModelPhysicsRequest"
}
```

**`响应`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "GetCurrentModelPhysicsResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDOfModel",
		"modelHasPhysics": true,
		"physicsSwitchedOn": true,
		"usingLegacyPhysics": false,
		"physicsFPSSetting": -1,
		"baseStrength": 50,
		"baseWind": 17,
		"apiPhysicsOverrideActive": false,
		"apiPhysicsOverridePluginName": "",
		"physicsGroups": [
			{
				"groupID": "PhysicsSetting1",
				"groupName": "Hair Front Physics",
				"strengthMultiplier": 1.5,
				"windMultiplier": 0.3
			},
			{
				"groupID": "PhysicsSetting2",
				"groupName": "Clothes Physics",
				"strengthMultiplier": 1,
				"windMultiplier": 2
			}
		]
	}
}
```

如果没有加载模型，`modelLoaded` 将为 `false`。在这种情况下，所有其他值都没有任何意义，`physicsGroups` 数组将为空。

如果加载了模型，`modelHasPhysics` 字段将告诉您模型是否具有有效的物理设置。有些模型没有设置物理，或者物理文件损坏，这将导致物理系统无法正确启动。`physicsSwitchedOn` 如果用户在 VTube Studio 中激活了该模型的“使用物理”开关，则为 true。`usingLegacyPhysics` 是“旧版物理”开关的状态。

`physicsFPSSetting` 包含该模型的物理 FPS 设置，可以是 30、60、120 或 -1，-1 表示用户选择了“使用与应用程序相同的 FPS”。

`apiPhysicsOverrideActive` 和 `apiPhysicsOverridePluginName` 字段指示当前是否有插件覆盖了一些物理设置。如果其 active 字段为 true，则 name 字段将包含插件的名称。一次只能有一个插件控制物理系统。这也将在 `SetCurrentModelPhysicsRequest` 请求中进行说明。

如果您使用 `SetCurrentModelPhysicsRequest` 来覆盖物理或风的基础值或乘数，这些更改 **不会** 反映在此获取请求中。您必须自行记住物理覆盖。

关于 `physicsGroup` 数组的注意事项：每个组都有一个 ID，但不是每个组都必须有名称。在这种情况下，相应的 `groupName` 字段将是空字符串。

## 覆盖当前加载的 VTS 模型的物理设置

您可以使用此请求覆盖当前加载模型的物理设置。一旦某个插件通过此 API 控制了物理系统，其他插件就无法使用此 API，直到第一个插件放弃控制。尝试这样做将返回相应的错误，参见 "[ErrorID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)"（`SetCurrentModelPhysicsRequestPhysicsControlledByOtherPlugin`）。如果未加载模型，或者您提供的任何物理组 ID 在当前模型中不存在，或者您忘记为覆盖添加值，也会返回错误。

如果用户关闭了当前加载模型的物理，您无法使用此 API 打开物理。您只能使用此 API 覆盖物理/风的基础值和乘数。

如上文 `GetCurrentModelPhysicsRequest` 部分所述，物理/风乘数的值应在 0 到 2 之间，而物理/风基础值应为 0 到 100 之间的整数（因为这也是应用程序中向用户显示的方式）。超出该范围的值将自动被限制。

如果您想为特定物理组设置强度或风的乘数，请使用带有相应组 ID 且 `setBaseValue` 设置为 false 的 `strengthOverrides` 和 `windOverrides` 数组。如果您将 `setBaseValue` 设置为 true，则提供的值将作为物理强度或风的基础值设置，而不是特定组。此时您可以将组 ID (`id`) 留空。

通常，使用此 API 设置的值用于覆盖用户在应用程序中设置的值。它们不会实际显示给用户，也不会保存。使用此 API 设置的覆盖值会在计时器结束时自动取消（您使用 `overrideSeconds` 设置的值）。如果要持续覆盖值，必须反复发送此请求。

当所有计时器结束时，API 将不再认为您的插件控制物理系统，因此其他插件可以开始控制物理系统。

覆盖计时器值必须在 0.5 到 5 秒之间。超出该范围的值将自动被限制。

**`请求`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "SetCurrentModelPhysicsRequest",
	"data": {
		"strengthOverrides": [
			{
				"id": "PhysicsSetting1",
				"value": 1.5,
				"setBaseValue": false,
				"overrideSeconds": 2
			}
		],
		"windOverrides": [
			{
				"id": "",
				"value": 85,
				"setBaseValue": true,
				"overrideSeconds": 5
			}
		]
	}
}
```

**`响应`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "SetCurrentModelPhysicsResponse",
	"data": { }
}
```

## 获取和设置 NDI 设置

您可以通过 API 请求当前的 NDI 设置并更改它们。这允许您打开/关闭 NDI，设置自定义固定分辨率等。

有关 NDI 及其在 VTube Studio 中的使用信息，请访问此页面：https://github.com/DenchiSoft/VTubeStudio/wiki/Streaming-to-Mac-PC

如果将 `"setNewConfig"` 设置为 `false`，则只返回当前配置。此情况下，所有其他字段将被忽略。如果设置为 `true`，则会在配置有效时设置给定的配置。

`"ndiActive"` 用于打开/关闭 NDI。如果 NDI 打开，`"useNDI5"` 则使用 NDI 5 替代 NDI 4（我推荐使用 NDI 5）。

将 `"useCustomResolution"` 设置为 `true` 意味着 NDI 流将不再与 VTube Studio 窗口具有相同分辨率，而是使用通过 UI 设置的自定义分辨率。此分辨率也可以通过 API 使用 `"customWidthNDI"` 和 `"customHeightNDI"` 字段更改。两者必须在 256 到 8192 之间。宽度必须是 16 的倍数，高度必须是 8 的倍数。在请求中将它们都设置为 `-1` 将跳过设置它们，仅设置布尔字段。这样您就可以例如在不更改分辨率的情况下打开/关闭 NDI。

如果 NDI 分辨率与窗口分辨率不匹配，VTube Studio 将自动裁剪和缩放视频流。VTube Studio 始终确保纵横比正确，即使这意味着裁剪顶部/底部或左/右的部分。

**重要提示：** 此请求有 3 秒的冷却时间。触发过快将返回类型为 `NDIConfigCooldownNotOver` 的错误（参见 “[ErrorID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)”）。

**`请求`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "NDIConfigRequest",
	"data": {
		"setNewConfig": true,
		"ndiActive": true,
		"useNDI5": true,
		"useCustomResolution": true,
		"customWidthNDI": 1024,
		"customHeightNDI": 512
	}
}
```
响应将仅包含当前设置（如果您请求设置新的配置，则为新的设置）。响应中的 `"setNewConfig"` 字段没有任何意义。

**`响应`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "NDIConfigResponse",
	"data": {
		"setNewConfig": true,
		"ndiActive": true,
		"useNDI5": true,
		"useCustomResolution": true,
		"customWidthNDI": 1024,
		"customHeightNDI": 512
	}
}
```

## 请求可用物品列表或场景中的物品列表

此请求允许您请求当前场景中物品的列表。它还允许您请求可在用户PC上加载的物品文件列表，包括Live2D物品、动画文件夹等。

如果您想知道当前有哪些订单点可用来加载物品，请将 `"includeAvailableSpots"` 设置为 `true`。否则，响应中的 `"availableSpots"` 数组将为空。

如果您想知道当前场景中加载了哪些物品，请将 `"includeItemInstancesInScene"` 设置为 `true`。否则，响应中的 `"itemInstancesInScene"` 数组将为空。

如果您想知道有哪些物品文件可供加载，请将 `"includeAvailableItemFiles"` 设置为 `true`。否则，响应中的 `"availableItemFiles"` 数组将为空。**重要提示：** 这会从用户的PC读取完整的物品文件列表。可能会导致应用程序短暂卡顿，因此不要频繁使用 `"includeAvailableItemFiles"` 设置为 `true` 的请求。仅在确实需要刷新可用物品文件列表时使用。其他情况下请设置为 `false`。

#### 筛选特定物品

如果您只想让物品列表包含具有特定物品实例ID或特定文件名的物品，可以分别在 `"onlyItemsWithInstanceID"` 和 `"onlyItemsWithFileName"` 字段中提供它们。

场景中最多只有一个具有特定实例ID的物品，但可能有多个具有相同文件名的物品，因为您可以基于同一物品文件加载多个物品实例。

请注意，**物品文件名是唯一的**，意味着不会有两个物品文件具有相同的文件名。它们也是**区分大小写**的，因此如果您想引用某个特定文件，请确保不要更改大小写。

**`请求`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemListRequest",
	"data": {
		"includeAvailableSpots": true,
		"includeItemInstancesInScene": true,
		"includeAvailableItemFiles": false,
		"onlyItemsWithFileName": "OPTIONAL_my_item_filename.png",
		"onlyItemsWithInstanceID": "OPTIONAL_InstanceIdOfItemInScene"
	}
}
```

响应中的字段大多是自解释的。

filename 是物品文件的名称。这个名称可以用来将物品实例加载到场景中。对于 JPG/PNG/GIF 物品，这是完整的文件名（不含路径），包括文件扩展名（例如 "my_item.jpg"）。对于动画文件夹，则是文件夹名称。对于 Live2D 物品，也是文件夹名称。

物品类型可以在 `"type"` 字段中找到。可能的值有 `PNG`、`JPG`、`GIF`、`AnimationFolder` 或 `Live2D`。另一个可能的值是 `Unknown`。这只有在 VTube Studio 中添加了新的物品类型而 API 尚未更新时才会出现，因此理论上不应发生。

`"canLoadItemsRightNow"` 可能为 `false`，如果用户在 VTube Studio 中打开了某些菜单或对话框。这通常会阻止加载物品、使用快捷键等操作。

`"framerate"` 和 `"frameCount"` 仅适用于动画物品（GIF 和动画帧文件夹）。

如果 `"pinnedToModel"` 为 true，则 `"pinnedModelID"` 会包含物品所绑定模型的 ID（即当前加载的模型），而 `"pinnedArtMeshID"` 会包含物品绑定的 ArtMesh 的 ID。

如果你将 `"includeAvailableItemFiles"` 设置为 `true`，`"availableItemFiles"` 将包含用户 `Items` 文件夹中所有物品文件的列表。你可以使用这里返回的文件名通过 `ItemLoadRequest` 将物品加载到场景中。

**`RESPONSE`**
```json
{
    "apiName": "VTubeStudioPublicAPI",
    "apiVersion": "1.0",
    "timestamp": 1625405710728,
    "messageType": "ItemListResponse",
    "requestID": "SomeID",
    "data": {
        "itemsInSceneCount": 2,
        "totalItemsAllowedCount": 60,
        "canLoadItemsRightNow": true,
        "availableSpots":
	[
            -30,-29,-28,-27,-26,-25,-24,-23,-22,-21,-20,-19,-18,-17,-16,-15,-14,
            -13,-12,-11,-10,-9,-8,-7,-6,-5,-4,-3,-2,-1,3,4,5,6,7,8,9,10,11,12,13,
            14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30
        ],
        "itemInstancesInScene": [
            {
                "fileName": "Ribbon (@denchisoft)",
                "instanceID": "18de53dc47154b00afdd382a6ebd2194",
                "order": 1,
                "type": "Live2D",
                "censored": false,
                "flipped": false,
                "locked": false,
                "smoothing": 0.0,
                "framerate": 0.0,
                "frameCount": -1,
                "currentFrame": -1,
                "pinnedToModel": true,
                "pinnedModelID": "47c71722c5304a039b0570b60a189875",
                "pinnedArtMeshID": "D_FACE_00",
                "groupName": "",
                "sceneName": "",
                "fromWorkshop": false
            },
            {
                "fileName": "akari_fly (@walfieee)",
                "instanceID": "716cddf2e12a438ab5da05bbbf8b341c",
                "order": 2,
                "type": "AnimationFolder",
                "censored": false,
                "flipped": false,
                "locked": false,
                "smoothing": 0.0,
                "framerate": 15.0,
                "frameCount": 7,
                "currentFrame": 0,
                "pinnedToModel": false,
                "pinnedModelID": "",
                "pinnedArtMeshID": "",
                "groupName": "",
                "sceneName": "",
                "fromWorkshop": false
            }
        ],
        "availableItemFiles": [
            {
                "fileName": "Ribbon (@denchisoft)",
                "type": "Live2D",
                "loadedCount": 1
            },
            {
                "fileName": "ANIM_headpat",
                "type": "AnimationFolder",
                "loadedCount": 0
            },
            {
                "fileName": "workshop_2801215328_ANIM_loading gif",
                "type": "AnimationFolder",
                "loadedCount": 0
            },
            {
                "fileName": "akari_fly (@walfieee)",
                "type": "AnimationFolder",
                "loadedCount": 1
            },
            {
                "fileName": "b_woozy (@denchisoft).png",
                "type": "PNG",
                "loadedCount": 0
            }
        ]
    }
}
```
## 将物品加载到场景中

通过此请求，您可以将物品加载到场景中。物品从用户电脑上的“Items”文件夹加载。

要获取可用物品文件列表，请使用 `ItemListRequest`。您可以在 `"fileName"` 字段中使用这些名称。

物品可以通过 `"positionX/Y"`、`"size"` 和 `"rotation"` 字段来定位/缩放/旋转。有关如何使用这些值的更多信息，请参阅显示 [VTube Studio 坐标系统](#the-vts-coordinate-system) 的图片。至于大小，必须在 `0` 到 `1` 之间，`0.32` 大约是用户手动加载物品时的“默认”大小。

您应确保插件清理其物品。绝对不要留下任何物品在用户无法访问的可见场景之外，除非使用 **“删除场景中的所有物品”** 按钮。为了方便您操作，可以将 `"unloadWhenPluginDisconnects"` 设置为 true。

您可以使用 `"fadeTime"` 字段指定物品的淡入/淡出时间，范围为 0 到 2 秒。如果设置为 0，物品将立即出现。

您可以使用 `"order"` 字段指定物品加载到场景中的排序顺序。如果该顺序已被占用，物品将自动加载到下一个更高的可用顺序；如果所有更高顺序均已满，则会检查更低顺序。如果您希望请求的顺序被占用时加载失败，请将 `failIfOrderTaken` 设置为 `true`。此时会返回类型为 `ItemOrderAlreadyTaken` 的错误（参见 [ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)）。

某些值也有限制。具体来说，大小必须在 `0` 到 `1` 之间，位置必须在 `-1000` 到 `1000` 之间（虽然 `-1`/`1` 是屏幕边缘），淡出时间必须在 `0` 到 `2` 秒之间，平滑度必须在 `0` 到 `1` 之间。超出这些限制会返回类型为 `ItemLoadValuesInvalid` 的错误。

### 自定义数据物品

插件也可以使用此请求通过 `customDataBase64` 字段加载任意 PNG/JPG/GIF 数据作为物品（必须是 base64 编码的 JPG、PNG 或 GIF 文件）。如果不使用此功能，请保持为空或 NULL。

如果要使用此功能，您需要 `LoadCustomImagesAsItems` 权限。有关如何请求权限的更多信息，请查看[权限页面](Permissions/)。如果没有该权限，尝试加载自定义数据图片时会返回错误（`RequestRequiresPermission`，参见 [ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)）。

请求加载任意数据作为物品时，`customDataBase64` 必须包含有效的 PNG、JPG 或 GIF 文件数据。目前不支持自定义数据的 Live2D 物品。尺寸必须在（含）64 到 2048 像素之间，数据大小必须小于 5 MB（编码为 base64 之前的二进制数据）。对于 GIF 数据，GIF 必须包含不超过 1024 帧且至少 1 帧，且所有帧尺寸必须相同。

提供自定义数据时，仍需在 `fileName` 字段中提供文件名。`fileName` 必须是字母数字（可包含连字符），且以 `.jpg`、`.png` 或 `.gif` 结尾。长度必须在（含）8 到 32 个字符之间。

加载自定义数据时，您有两个选项：
* 直接立即加载自定义数据物品。
* 显示小弹窗给用户（包括物品缩略图），询问是否加载该物品。

根据您的用例选择合适的选项。确保您的插件不会加载可能给用户带来问题的图片是您的责任。

如果您想直接加载物品，请将 `customDataAskUserFirst` 设置为 `false`。

如果您想先显示弹窗给用户，请将 `customDataAskUserFirst` 设置为 `true`。这样会显示如下弹窗：

![自定义图片加载弹窗](/Images/vts_load_custom_image_1.png)

最多可同时显示 6 个此类弹窗（弹窗垂直堆叠）。当已有 6 个弹窗显示时，后续请求将返回错误。

当显示弹出窗口时，此请求的响应仅在用户做出决定后返回。如果用户决定拒绝加载自定义数据项，将返回错误（`ItemCustomDataLoadRequestRejectedByUser`）。当用户决定加载该项时，它将被加载并返回正常响应。这也会将其添加到您的插件的白名单中，因此随后加载相同项（由其 SHA256 哈希确定）将不会触发弹出窗口。如果您希望每次都强制触发弹出窗口，可以将 `customDataSkipAskingUserIfWhitelisted` 设置为 false。

您可以使用 `customDataAskTimer` 字段设置弹出窗口的超时时间。如果设置为 0（或更小），弹出窗口将永远显示（直到用户点击确定或取消）。如果设置为其他正数，弹出窗口将显示该秒数，并向用户显示可见的倒计时。如果用户未在倒计时结束前做出决定，项加载请求将被视为用户拒绝。

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemLoadRequest",
	"data": {
		"fileName": "some_item_name.jpg",
		"positionX": 0,
		"positionY": 0.5,
		"size": 0.33,
		"rotation": 90,
		"fadeTime": 0.5,
		"order": 4,
		"failIfOrderTaken": false,
		"smoothing": 0,
		"censored": false,
		"flipped": false,
		"locked": false,
		"unloadWhenPluginDisconnects": true,
		"customDataBase64": "",
		"customDataAskUserFirst": true,
		"customDataSkipAskingUserIfWhitelisted": true,
		"customDataAskTimer": -1,
	}
}
```

响应包含新加载项目的实例 ID，位于 `instanceID` 字段中。它还包含文件名。

如果您加载了自定义数据项，文件名将由 VTube Studio 生成，因此它将不同于您传入的文件名。您可以使用该文件名请求再次加载该项目，而无需传入自定义数据。但是，当 VTube Studio 重启时，所有临时文件都会被清除，其中包括自定义数据项。

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemLoadResponse",
	"data": {
		"instanceID": "SomeUniqueItemInstanceId",
		"fileName": "some_item_name.jpg"
	}
}
```

## 从场景中移除物品

您可以使用此请求卸载当前加载在场景中的任何物品。

将 `"unloadAllInScene"` 设置为 `true` 将卸载所有物品。在这种情况下，所有其他字段将被忽略。

将 `"unloadAllLoadedByThisPlugin"` 设置为 `true` 将卸载所有由此插件加载的物品。

如果您想阻止此请求卸载由用户或其他插件加载的物品，请将 `"allowUnloadingItemsLoadedByUserOrOtherPlugins"` 设置为 `false`。

您还可以使用可选的 `"instanceIDs"` 和 `"fileNames"` 数组请求特定的物品实例或从特定文件名加载的物品实例。即使这些物品未在场景中找到，请求也不会返回错误。它只会返回一个空数组的响应。

如果用户当前打开的菜单阻止 VTS 加载/卸载物品，可能会返回类型为 `CannotCurrentlyUnloadItem` 的错误。

**`请求`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemUnloadRequest",
    	"data": {
		"unloadAllInScene": false,
		"unloadAllLoadedByThisPlugin": false,
		"allowUnloadingItemsLoadedByUserOrOtherPlugins": true,
		"instanceIDs":
		[
			"SomeInstanceIdOfItemToUnload", "SomeOtherInstanceIdOfItemToUnload"
		],
		"fileNames":
		[
			"UnloadAllItemInstancesWithThisFileName", "SomeOtherFileName"
		]
    	}
}
```
响应包含已卸载项目的实例 ID 和文件名。

**`RESPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemUnloadResponse",
    	"data": {
		"unloadedItems":
		[
		    {
			"instanceID": "SomeInstanceId",
			"fileName": "SomeFileName"
		    },
		    {
			"instanceID": "SomeOtherInstanceId",
			"fileName": "SomeFileName"
		    }
		]
    	}
}
```

## 控制物品和物品动画

您可以控制场景中物品的某些方面。此请求允许您使物品变暗（黑色覆盖层）、更改不透明度以及控制动画物品的动画。此请求不适用于 Live2D 物品，如果尝试使用将返回类型为 `ItemAnimationControlUnsupportedItemType` 的错误（参见 [ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)）。这对于“反应型 PNG”类型的插件等非常有用。

对于动画物品，您可以设置帧率（以每秒帧数为单位，自动限制在 `0.1` 到 `120` 之间）。您还可以使用 `"frame"` 字段手动使动画跳转到某一帧。如果帧索引无效，将返回错误。对于一个具有（例如）20 帧的动画物品，有效帧索引从 0（第一帧）到 19（最后一帧）。动画物品的帧数可以通过 `ItemListRequest` 请求。尝试对普通 JPG/PNG 物品执行此操作将返回类型为 `ItemAnimationControlSimpleImageDoesNotSupportAnim` 的错误。

如果您不想更改帧率、当前帧、亮度或不透明度，可以为这些字段传入 `-1`（如果从负载中省略字段，默认值也是 `-1`）。

您可以使用 `"animationPlayState"` 字段启动/停止动画（`true` = 播放动画，`false` = 停止动画）。只有当您将 `"setAnimationPlayState"` 设置为 `true` 时，此字段才会生效，否则动画播放状态不会更改。

#### 使用自动停止帧

您可以使用 `"autoStopFrames"` 数组设置动画自动停止播放的帧索引列表。只有当您将 `"setAutoStopFrames"` 设置为 true 时，此数组才会生效，否则自动停止帧不会更改。如果要移除自动停止帧，请将 `"setAutoStopFrames"` 设置为 true，并在 `"autoStopFrames"` 中设置空数组。最多可设置 1024 个自动停止帧。

动画一旦达到这些帧中的任意一帧，将停止播放，且只能通过此请求使用 API 将动画播放状态设置为 `true` 来重新启动（见上文）。

**`请求`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemAnimationControlRequest",
	"data": {
		"itemInstanceID": "ItemInstanceId",
		"framerate": 12,
		"frame": 3,
		"brightness": 1,
		"opacity": 1,
		"setAutoStopFrames": true,
		"autoStopFrames": [0, 7, 26],
		"setAnimationPlayState": true,
		"animationPlayState": true
	}
}
```
响应包含当前帧索引以及动画是否正在播放的信息（仅针对动画项目，其他项目类型应忽略这些字段）。

**`RESPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemAnimationControlResponse",
	"data": {
		"frame": 3,
		"animationPlaying": true
	}
}
```

## 场景中移动物品

您可以在场景中移动物品。为此，请将所有想要移动的物品填入 `"itemsToMove"` 数组。响应数组（`"movedItems"`）将包含每个请求物品的一条记录，显示该移动请求是否成功（见对应的 `"success"` 字段）。如果未成功，`"errorID"` 字段将包含错误代码，告诉您出了什么问题（参见 [ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)）。如果成功，`"success"` 将为 `true`，`"errorID"` 将为 `-1`。

`"itemsToMove"` 数组最多可包含 64 条记录。超过部分将被忽略。如果数组中有重复的物品实例 ID，最后一条该 ID 的记录将被使用。

如果您想立即设置位置（例如每帧都想设置新位置），请将 `"timeInSeconds"` 设为 `0`。否则，您可以用此字段设置移动渐变所用时间（限制在 0 到 30 秒之间）。

如果想设置物品的翻转状态，请将 `"setFlip"` 设为 true。翻转状态可通过 `"flip"` 字段设置。

如果想更改物品的顺序，可以使用 `"order"` 字段。您只能更改为未被占用的顺序位置（见 `ItemListResponse`）。如果不想更改顺序，请将此字段设为 -1000 或更低，或者设置为物品当前的顺序值。此外，当用户打开任何配置窗口时，您无法更改顺序。顺序不会像其他参数那样渐变（如果请求的话），而是在接收到请求后立即更改为指定值。

对于设置移动目标的字段（`"positionX"`、`"positionY"`、`"size"` 和 `"rotation"`），请参考 `ItemLoadRequest` 的文档。唯一不同的是，如果给定值过高或过低，`ItemMoveRequest` 不会返回错误。相反，如果您希望忽略某字段，可设置其值为 -1000 或更低。这样，该字段不会包含在移动中，而是使用相应的当前值。


#### 物品移动过渡渐变类型

您可以通过 `"fadeMode"` 字段设置位置/旋转/大小渐变的移动类型。接受的值有 `"linear"`、`"easeIn"`、`"easeOut"`、`"easeBoth"`、`"overshoot"` 和 `"zip"`。仅当 `"timeInSeconds"` 字段大于 `0` 时才会使用。

如果您希望用户在物品移动时通过点击/拖动停止移动，请将 `"userCanStop"` 设为 `true`。若设为 `false`，则用户无法在移动过程中与物品交互。

以下是移动模式的示意图：

![VTube Studio Movement Modes](/Images/vts_movement_modes_smooth.png)

**`请求`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemMoveRequest",
	"data": {
		"itemsToMove":
		[
			{
				"itemInstanceID": "ItemInstanceId",
				"timeInSeconds": 1,
				"fadeMode": "easeOut",
				"positionX": 0.2,
				"positionY": -0.8,
				"size": 0.6,
				"rotation": 180,
				"order": -1000,
				"setFlip": true,
				"flip": false,
				"userCanStop": true
			},
			{
				"itemInstanceID": "SomeOther_ItemInstanceId",
				"timeInSeconds": 0.5,
				"fadeMode": "zip",
				"positionX": 1,
				"positionY": 1,
				"size": 0.3,
				"rotation": 0,
				"order": 25,
				"setFlip": false,
				"flip": false,
				"userCanStop": false
			}
		]
	}
}
```
如果请求成功，您将收到包含所有请求项目状态的响应。

**`响应`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemMoveResponse",
	"data": {
		"movedItems":
		[
			{
				"itemInstanceID": "ItemInstanceId",
				"success": true,
				"errorID": -1
			},
			{
				"itemInstanceID": "SomeOther_ItemInstanceId",
				"success": false,
				"errorID": 900
			}
		]
	}
}
```

## 设置模型内项目排序顺序

#### ⚠️ 此请求目前仅在[公开测试分支](https://github.com/DenchiSoft/VTubeStudio/wiki/Joining-the-Beta)可用 ⚠️

VTube Studio 允许您对主模型的**层间**项目进行排序和固定。有关此功能的基本信息，请参阅“[层间项目固定](https://github.com/DenchiSoft/VTubeStudio/wiki/Between-Layer-Item-Pinning)”页面。

针对[Live2D项目](https://github.com/DenchiSoft/VTubeStudio/wiki/Live2D-Items)，您还可以将**Live2D项目模型**拆分为前部和后部，并分别插入到主模型中。

要识别您想更改模型内排序设置的项目，请通过 `"itemInstanceID"` 字段传入其项目实例ID。如果找不到该ID对应的项目，将返回 `ItemSortRequestInstanceIDNotFound` 错误。要获取所有已加载项目的实例ID，您可以使用 `ItemListRequest`。使用 `ItemLoadRequest` 通过API加载项目时，也会直接返回该ID。

有关此请求可能返回的所有错误，请参见“[ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)”。

*注意：* 普通项目（非Live2D项目）没有“后部”或“拆分点”，因此在对普通项目使用此请求时，后部/拆分字段将完全被忽略。您可以将它们留空或设为 `null`。以下内容假设您对Live2D项目使用此请求。另外，VTube Studio 会确保即使您将后部设置在前部之前，它也不会越过前部。

要将项目插入模型，设置 `"frontOn"` 为 `true`。如果您有Live2D项目并想将其后部插入模型更靠后的位置，也可以将 `"backOn"` 设置为 `true`（对非Live2D项目忽略此设置）。

拆分点和前/后插入点通过 `"splitAt"`、`"withinModelOrderFront"` 和 `"withinModelOrderBack"` 设置。这些字段的解释取决于您通过 `"setSplitPoint"`、`"setFrontOrder"` 和 `"setBackOrder"` 传入的值。

以下字段用于设置项目拆分点和插入点：

* `"splitAt"`：设置用于将Live2D项目模型拆分为前部和后部的拆分点。
  * 对非Live2D项目忽略。
  * 如果 `"setSplitPoint"` 设置为 `"Unchanged"`：将忽略 `"splitAt"` 中的值，拆分点保持不变。
  * 如果 `"setSplitPoint"` 设置为 `"UseArtMeshID"`：`"splitAt"` 期望是存在于Live2D项目模型中的ArtMesh ID，若该ArtMesh ID不存在，则返回错误 `ItemSortRequestInvalidSplitPoint`。
* `"withinModelOrderFront"`：设置将项目插入主模型的位置（对于Live2D项目为前部插入位置）。
  * 如果 `"setFrontOrder"` 设置为 `"Unchanged"`：将忽略 `"withinModelOrderFront"` 的值，前部插入位置保持不变。
  * 如果 `"setFrontOrder"` 设置为 `"UseArtMeshID"`：`"withinModelOrderFront"` 期望是主Live2D模型中存在的ArtMesh ID，但如果不存在，请求仍会成功返回，因为它可能是当前未加载的Live2D模型的ID。
  * 如果 `"setFrontOrder"` 设置为 `"UseSpecialID"`：`"withinModelOrderFront"` 期望为 `"FullyInFront"` 或 `"FullyInBack"`，用于始终将项目（前部）完全置于已加载主模型的最前或最后。其他任何值都会返回 `ItemSortRequestInvalidFrontOrder` 错误。
* `"withinModelOrderBack"`：设置Live2D项目后部插入主模型的位置。
  * 对非Live2D项目忽略。
  * 如果 `"setBackOrder"` 设置为 `"Unchanged"`：将忽略 `"withinModelOrderBack"` 的值，后部插入位置保持不变。
  * 如果 `"setBackOrder"` 设置为 `"UseArtMeshID"`：`"withinModelOrderBack"` 期望是主Live2D模型中存在的ArtMesh ID，但如果不存在，请求仍会成功返回，因为它可能是当前未加载的Live2D模型的ID。
  * 如果 `"setBackOrder"` 设置为 `"UseSpecialID"`：`"withinModelOrderBack"` 期望为 `"FullyInBack"`，用于始终将项目（后部）完全置于已加载主模型的最后。其他任何值都会返回 `ItemSortRequestInvalidBackOrder` 错误。

在 `"setSplitPoint"`、`"setFrontOrder"` 和 `"setBackOrder"` 中传入无效值将返回 `ItemSortRequestInvalidValueSetType` 错误。

如果模型内排序窗口当前打开（即用户正在手动设置插入顺序），此请求也会返回错误 `ItemSortRequestItemConfigWindowOpen`。

**`请求`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemSortRequest",
	"data": {
		"itemInstanceID": "b616cf51fe3444729ccbf6ee54a14d1a",
		"frontOn": true,
		"backOn": true,
		"setSplitPoint": "UseArtMeshID",
		"setFrontOrder": "UseArtMeshID",
		"setBackOrder": "UseSpecialID",
		"splitAt": "MyArtMeshIDInItemModel91",		
		"withinModelOrderFront": "MyArtMeshIDInMainModel73",
		"withinModelOrderBack": "FullyInBack"
	}
}
```
如果请求成功，您将收到此响应。

`"itemInstanceID"` 将返回请求对应的项目实例ID。

如果当前已加载主模型，`"modelLoaded"` 将为 `true`，`"modelID"` 和 `"modelName"` 将包含模型的ID和名称。 如果未加载模型，这些字段将为空。

如果加载了主模型，`"loadedModelHadRequestedFrontLayer"` 和 `"loadedModelHadRequestedBackLayer"` 将告诉您所提供的前/后插入点是否在当前加载的模型中找到。 如果插入点未更改，这些字段设置为 `false`。

**`响应`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemSortResponse",
	"data": {
		"itemInstanceID": "b616cf51fe3444729ccbf6ee54a14d1a",
		"modelLoaded": true,
		"modelID": "d87b771d2902473bbaa0226d03ef4754",
		"modelName": "Akari",
		"loadedModelHadRequestedFrontLayer": true,
		"loadedModelHadRequestedBackLayer": true
	}
}
```
## 让用户选择 ArtMeshes

您可以使用此请求在 VTube Studio 中显示当前加载的主 Live2D 模型的所有 ArtMeshes 列表，并让用户选择一个或多个。一旦用户完成选择，ArtMesh ID 将被返回。您可以在其他各种 API 请求中使用这些 ArtMesh ID，例如为它们应用颜色滤镜或使其不可见。

如果当前没有加载模型或有其他窗口打开，请求将返回错误。

用户可以将鼠标悬停在 ArtMeshes 上以显示其 ID，点击它们可以过滤显示列表，只显示点击位置下的所有 ArtMeshes。此请求显示的 UI 如下图所示：

![API ArtMesh selection request screen](/Images/vts_request_select_artmeshes.png)

使用 `requestedArtMeshCount` 字段指定用户必须激活多少个 ArtMeshes。直到恰好激活这么多 ArtMeshes，“确定”按钮才可用。如果将 `requestedArtMeshCount` 设置为 0 或更低，用户将被要求选择任意数量的 ArtMeshes（但至少一个）。

如果您想在列表中预先激活 ArtMeshes，可以使用 `activeArtMeshes` 列表传入一些 ArtMesh ID。如果这些 ID 中有任何不属于当前模型，将返回错误。如果您想获取当前加载模型中所有 ArtMeshes 的列表，请使用 `ArtMeshListRequest`。

如上图所示，列表有一些默认文本，提示用户为插件选择 ArtMeshes。当您按右上角的 `?`（帮助）按钮时，会弹出相同的文本。您可以分别使用 `textOverride` 和 `helpOverride` 字段覆盖这两个字符串。如果留空（空字符串）、null 或不包含在请求负载中，将使用上述默认消息。若要覆盖这些消息，您提供的字符串长度必须在 4 到 1024 个字符之间，否则将使用默认值。您可以在字符串中使用 `\n` 进行换行。

**`REQUEST`**


```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ArtMeshSelectionRequest",
	"data": {
		"textOverride": "This text is shown over the ArtMesh selection list.",
		"helpOverride": "This text is shown when the user presses the ? button."
		"requestedArtMeshCount": 5
		"activeArtMeshes": [
			"D_BODY_00",
			"D_ARM_R_05"
		]
	}
}
```
如果请求成功，选择列表将显示给用户。不会有即时响应。响应将在用户点击“确定”或“取消”按钮后出现。“取消”按钮始终可用，但“确定”按钮仅在选择了请求数量的ArtMeshes后才可点击。

激活/停用的ArtMeshes将分别返回在`activeArtMeshes`和`inactiveArtMeshes`数组中。这些数组之间**没有重叠**，因此如果将这些数组中的ArtMeshes合并，您将获得模型中所有ArtMeshes的列表。

如果用户点击了“确定”，`success`字段将为`true`。如果用户点击了“取消”，`success`字段将为`false`（在这种情况下，您可能应该忽略`activeArtMeshes`和`inactiveArtMeshes`数组，尽管它们仍会返回）。

**`RESPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ArtMeshSelectionResponse",
	"data": {
		"success": true
		"activeArtMeshes": [
			"D_BROW_00",
			"D_EYE_BALL_03",
			"D_EYE_BALL_02",
			"D_EYE_BALL_01",
			"D_EYE_BALL_00",
			"D_EYE_11"
		],
		"inactiveArtMeshes": [
			"D_EAR_06",
			"D_BODY_00",
			"D_ARM_R_05"
		]
	}
}
```
## 将物品固定到模型

您可以使用此请求将场景中的物品固定到当前加载的模型上。

必须在 `itemInstanceID` 字段中指定用于识别物品的物品实例 ID。 如果您想取消固定该物品，只需将 `pin` 设置为 `false`。 在这种情况下不需要提供其他信息。 如果当前未加载具有该 ID 的物品，将返回错误（请参见 [ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)）。

如果您想固定物品，必须在 `pinInfo` 对象中提供固定位置。 固定物品有多种方式。 例如，您可以提供一个精确的位置进行固定，或者只提供一个 ArtMesh，让 VTS 将物品固定到其中心或 ArtMesh 上的随机位置。 具体如何操作将在下文说明。

当您发送针对具有活动 `ItemMoveRequest` 的物品的 `ItemPinRequest` 时，`ItemMoveRequest` 将被自动取消。

此外，如果您的插件（或多个不同插件）在同一帧内向同一物品发送多个固定请求，VTS 仅执行最后接收到的固定请求，其他请求将被丢弃。

### 固定选项

有三个字段决定如何解释 `pinInfo` 中提供的数据：

* `angleRelativeTo`：如何解释提供的角度？
  * `RelativeToWorld`：绝对角度。也就是说，如果您传入角度为 0，物品将以相对于 VTS 窗口的角度 0 直立固定。 如果您想让物品面向相对于 VTS 窗口的某个方向，您会使用此选项。
  * `RelativeToCurrentItemRotation`：相对于物品当前角度。 如果您传入角度为 0，表示物品将固定在当前角度，即不会改变其当前旋转。 如果您不想改变物品旋转，只想按原样固定，您会使用此选项。
  * `RelativeToModel`：相对于模型旋转的角度。 也就是说，如果传入角度为 0，且用户旋转了模型，物品将相对于模型直立固定。 此“模型旋转”不包括由 Live2D ArtMesh 变形引起的旋转，仅指 VTube Studio 对整个模型应用的实际旋转。 如果您想让物品面向相对于模型当前旋转的某个方向，会使用此选项。
  * `RelativeToPinPosition`：相对于固定位置的角度。 如果您想在某个特定 ArtMesh 的某个特定位置以固定角度固定物品，且无论模型当前如何旋转或 ArtMesh 如何变形，该角度都保持完全相同，您应使用此选项。 但要实现所需效果，传入的角度对每个固定位置会完全不同。
* `sizeRelativeTo`：
  * `RelativeToWorld`：绝对大小。范围从 0（最小）到 1（最大）。详见 `ItemLoadRequest`。
  * `RelativeToCurrentItemSize`：相对于当前物品大小。您可以传入介于 `-1` 和 `1` 之间的数字，将加到当前物品大小上。 也就是说，如果想以当前大小固定物品且不改变，传入 0 即可。
* `vertexPinType`：
  * `Provided`：物品将根据 `vertexID1`、`vertexID2`、`vertexID3`、`vertexWeight1`、`vertexWeight2` 和 `vertexWeight3` 字段中提供的固定位置固定到指定 ArtMesh。 详情将在下文说明。
  * `Center`：物品将固定到指定 ArtMesh 的“中心”。这其实不是空间上的中心，而是网格的三角形列表中间的三角形。对于给定的 ArtMesh，这将每次提供相同的位置。
  * `Random`：物品将固定到指定 ArtMesh 中的随机三角形。

如果提供的模型 ID 与加载的模型不匹配，将返回错误。 您也可以将模型 ID 留空，这样将尝试固定到当前加载的模型（如果有加载）。

如果模型没有您提供的 ArtMesh ID 对应的 ArtMesh，将返回错误。 如果您将 ArtMesh ID 留空，将在模型中随机选择一个 ArtMesh。

例如，您可以将模型 ID 和 ArtMesh ID 都留空，并将 `vertexPinType` 设置为 `Random`。 这将把物品固定到当前加载模型的随机 ArtMesh 上的随机位置。

### 固定到特定位置

如果您将 `vertexPinType` 设置为 `Provided`，必须使用字段 `vertexID1`、`vertexID2`、`vertexID3`、`vertexWeight1`、`vertexWeight2` 和 `vertexWeight3`，以提供基于您使用 `modelID` 和 `artMeshID` 字段选择的 ArtMesh 上的有效位置。


三个顶点ID字段必须是给定ArtMesh中三角形的顶点ID。要定义该特定三角形内的位置，请使用顶点权重字段。那些字段将与顶点位置相乘以定义三角形中的一个位置。请记住，权重必须正好加起来等于1，否则结果位置将位于三角形外部（并且会返回错误）。这些就是[重心坐标](https://zh.wikipedia.org/wiki/%E9%87%8D%E5%BF%83%E7%9B%B8%E5%85%B3%E7%B3%BB%E7%BB%9F)。

要获取其中一个位置，您可以使用[ModelClickedEvent](https://github.com/DenchiSoft/VTubeStudio/tree/master/Events#model-clicked-event)。当模型被点击时，该事件将返回可用于`ItemPinRequest`的固定点位置。

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemPinRequest",
	"data": {
		"pin": true,
		"itemInstanceID": "4a241269394f463ca16b8b21aa636568",
		"angleRelativeTo": "RelativeToModel",
		"sizeRelativeTo": "RelativeToWorld",
		"vertexPinType": "Provided",
		"pinInfo": {
			"modelID": "d87b771d2902473bbaa0226d03ef4754",
			"artMeshID": "hair_right_4",
			"angle": 23.938,
			"size": 0.33,
			"vertexID1": 17,
			"vertexID2": 9,
			"vertexID3": 55,
			"vertexWeight1": 0.25928378105163576,
			"vertexWeight2": 0.6850675940513611,
			"vertexWeight3": 0.055648624897003177
		}
	}
}
```
如果成功，响应将包含项目ID、项目文件名以及该项目当前是否已固定。

**`RESPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemPinResponse",
	"data": {
		"isPinned": true,
		"itemInstanceID": "4a241269394f463ca16b8b21aa636568",
		"itemFileName": "my_test_item_2.png",
	}
}
```

## 获取后处理效果列表及状态

**注意：** 本文档中视觉效果、VFX 和后处理效果这几个术语可互换使用。

VTube Studio 内置后处理功能，允许您直接向场景添加视觉效果。该功能适用于 Windows 和 macOS。更多信息请查看页面 ["Visual Effects"](https://github.com/DenchiSoft/VTubeStudio/wiki/Visual-Effects)。

此请求返回后处理系统的总体状态、所有现有（用户创建的）后处理预设列表及所有可用后处理效果及其当前值（当前后处理状态）。

如果将 `fillPostProcessingPresetsArray` 设置为 `false`，响应负载中的 `postProcessingPresets` 数组将为空。请求后处理预设列表需要从磁盘读取预设文件（尽管它们在 VTS 中会缓存一段时间），这可能较慢。如果频繁发送此请求，请确保 `fillPostProcessingPresetsArray` 不是 `true`，否则可能因磁盘 I/O 导致卡顿。

如果将 `fillPostProcessingEffectsArray` 设置为 `false`，响应负载中的 `postProcessingEffects` 数组将为空。如果您不需要完整的后处理效果及其数值列表，建议将 `fillPostProcessingEffectsArray` 设置为 `false`，因为响应负载可能非常大。

如果您只关注特定的后处理效果，可以在 `effectIDFilter` 数组中列出它们。否则请保持数组为空表示不应用过滤器。所有当前效果的列表见此处：https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/Effects.cs

**注意：** 这些 ID 支持多种格式，因此您可以用任何枚举风格为它们创建枚举。它们不区分大小写，并且忽略 `_` 或 `-`。例如，您可以写成 `Chromatic_Aberration`、`chromatic_aberration`、`CHROMATIC_ABERRATION` 等，而不仅限于 `ChromaticAberration`。

**`请求`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "PostProcessingListRequest",
	"data":
	{
		"fillPostProcessingPresetsArray": true,
		"fillPostProcessingEffectsArray": true,
		"effectIDFilter":
		[
			"ASCII",
			"ColorGrading",
			"WeatherEffects",
			"ChromaticAberration"
		]
	}
}
```
响应包含有关后期处理系统状态的一些常规信息，以及 `postProcessingEffects` 和 `postProcessingPresets` 数组（如果请求的话）。

`postProcessingSupported` 检查平台是否支持后期处理，在 Windows 和 macOS 上应始终为 `true`。`postProcessingActive` 字段包含用户是否开启了后期处理。请记住，你也可以通过 API 使用接下来描述的 `PostProcessingUpdateRequest` 来打开/关闭它。在某些情况下，使用 `PostProcessingUpdateRequest` 可能不可行，特别是当 VTube Studio 中有一些与后期处理配置相关的窗口或弹出窗口打开时。在这种情况下，`canSendPostProcessingUpdateRequestRightNow` 将为 `false`。

有一些受限/实验性效果（参见[“受限/实验性效果”](https://github.com/DenchiSoft/VTubeStudio/wiki/Visual-Effects#restrictedexperimental-effects)）。用户必须明确允许使用这些效果。用户是否允许使用这些效果会在 `restrictedEffectsAllowed` 字段中返回。

后期处理预设是否激活会在 `presetIsActive` 字段中返回。如果有激活的预设，其名称将显示在 `activePreset` 字段中，否则该字段为空。

`presetCount` 包含 `postProcessingPresets` 数组中的后期处理预设数量。如果你没有请求填充该数组，`presetCount` 将为 0。

`activeEffectCount` 是激活的后期处理效果数量。后续章节将解释效果“激活”的含义。

“effectCount”和“configCount”字段包含所有效果在应用过滤器前后（如果你请求了过滤）的效果数量和所有配置的总数。

### `postProcessingEffects` 数组

`postProcessingEffects` 数组包含所有效果的列表。这些效果与 VTube Studio 中 VFX 列表中显示的效果相同。每个效果可以有多个“配置”，用于配置效果的某些方面，例如强度或颜色。

用来标识效果的 ID 返回在 `enumID` 字段中。还有一个 `internalID` 字段，包含 VTube Studio 内部用于该效果的 ID。这是后期处理预设 JSON 文件中使用的 ID，因此对大多数用例来说并不重要。不过，如果你有需要，也可以在 API 中使用这些 ID 来引用效果。

配置项具有以下类型之一（返回在配置的 `type` 字段中）：
* Float
* Int
* Bool
* String
* Color
* SceneItem

一个效果的配置项返回在 `configEntries` 数组中。每个配置项还有一个 `internalID` 和 `enumID`。所有效果的所有配置 ID 及说明可见此处：https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/EffectConfigs.cs

对于一个配置项，仅填写与该配置类型匹配的字段。其他字段将为空或为默认值，应忽略。例如，对于浮点型配置项，`intMin` 和 `colorValue` 字段为空（此时为 0 和空字符串）。除所有类型都有的默认值外，`Float` 和 `Int` 配置还具有 `min` 和 `max`。

对于包含颜色的字段，返回 RGBA 十六进制格式的字符串（如 "77CCAAFF"），`colorHasAlpha` 会告诉你该配置是否实际有 alpha。如果为 `false`，alpha 始终为 `FF`。

类型为 `SceneItem` 的配置本质上是字符串配置，但其值必须是 VTube Studio “Items” 文件夹中存在的项目的文件名（以 .jpg 或 .png 结尾）。例如，这些用于自定义粒子效果。

### 何时认为一个效果是“激活”的？



每个效果至少有一个浮点配置（但可以有多个），其 `activationConfig` 设置为 `true`。如果某个效果的其中一个配置值大于 0，则该效果被视为“激活”。

例如，对于 `ColorGrading` 效果，相关配置即为 `ColorGrading_Strength`。

**注意：** 此响应负载示例中的 `postProcessingEffects` 大大缩短。未应用任何滤镜时，由于存在 250 多个效果配置，内容可能长达数千行。

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "PostProcessingListResponse",
	"data": {
		"postProcessingSupported": true,
		"postProcessingActive": true,
		"canSendPostProcessingUpdateRequestRightNow": true,
		"restrictedEffectsAllowed": false,
		"presetIsActive": true,
		"activePreset": "some_effects_preset_3",
		"presetCount": 70,
		"activeEffectCount": 5,
		"effectCountBeforeFilter": 29,
		"configCountBeforeFilter": 258,
		"effectCountAfterFilter": 4,
		"configCountAfterFilter": 31,
		"postProcessingEffects": [
			{
				"internalID": "color_grading",
				"enumID": "ColorGrading",
				"explanation": "Color grading",
				"effectIsActive": false,
				"effectIsRestricted": false,
				"configEntries": [
					{
						"internalID": "color_grading-strength",
						"enumID": "ColorGrading_Strength",
						"explanation": "Effect on/off",
						"type": "Float",
						"activationConfig": true,
						"floatValue": 0.0,
						"floatMin": 0.0,
						"floatMax": 1.0,
						"floatDefault": 0.0,
						"intValue": 0,
						"intMin": 0,
						"intMax": 0,
						"intDefault": 0,
						"colorValue": "",
						"colorDefault": "",
						"colorHasAlpha": false,
						"boolValue": false,
						"boolDefault": false,
						"stringValue": "",
						"stringDefault": "",
						"sceneItemValue": "",
						"sceneItemDefault": ""
					},
					{
						"internalID": "color_grading-color_filter",
						"enumID": "ColorGrading_ColorFilter",
						"explanation": "Color filter",
						"type": "color",
						"activationConfig": false,
						"floatValue": 0.0,
						"floatMin": 0.0,
						"floatMax": 0.0,
						"floatDefault": 0.0,
						"intValue": 0,
						"intMin": 0,
						"intMax": 0,
						"intDefault": 0,
						"colorValue": "FFFFFFFF",
						"colorDefault": "FFFFFFFF",
						"colorHasAlpha": false,
						"boolValue": false,
						"boolDefault": false,
						"stringValue": "",
						"stringDefault": "",
						"sceneItemValue": "",
						"sceneItemDefault": ""
					}
				]
			}
		],
		"postProcessingPresets": [
			"My Cool Preset",
			"some_effects_preset_1",
			"some_effects_preset_2",
			"some_effects_preset_3",
			"test asdf 123456",
			"blur and color grading",
		]
	}
}
```
## 设置后期处理效果

**注意：** 本文档中视觉效果、VFX 和后期处理效果一词可互换使用。

VTube Studio 内置后期处理，允许您直接向场景添加视觉效果。该功能适用于 Windows 和 macOS。更多信息，请查看页面["视觉效果"](https://github.com/DenchiSoft/VTubeStudio/wiki/Visual-Effects)。

通过使用 `PostProcessingUpdateRequest`，您可以控制后期处理系统。可以开启/关闭后期处理，加载/卸载预设，甚至直接详细控制单个配置项（颜色、强度等）。

仅当没有与后期处理配置相关的窗口打开时，才能发送此更新。否则，将返回错误 `PostProcessingUpdateReqestCannotUpdateRightNow`。有关此请求可能返回的所有错误，请参见["ErrorsID.cs"](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)。

使用 `postProcessingOn` 可全局开启或关闭后期处理。此操作与在 VTS UI 中切换后期处理开关相同。即使关闭后期处理，您也可以使用相同请求设置预设或单个配置值。值仍会被设置，但屏幕上不会有变化。打开 VTube Studio 的后期处理配置窗口时，您会看到请求的值已被设置，并且一旦开启后期处理，这些值将可见。请注意，如果您设置了预设但使用同一请求关闭后期处理，预设中的所有值仍将被设置，但 UI 上不会显示该预设为激活状态，因为技术上它不再“激活”。当再次开启后期处理时，预设中的所有值都将可见。

您可以使用两种方法为后期处理配置项设置值：
* 设置后期处理预设：将 `setPostProcessingPreset` 设为 `true`，并在 `presetToSet` 字段中提供预设名称（仅预设名称，不含文件扩展名）。如果预设不存在，将返回错误 `PostProcessingUpdateRequestPresetFileLoadFailed`。
* 设置单个配置值：将 `setPostProcessingValues` 设为 `true`，并在 `postProcessingValues` 数组中提供配置键值列表。

不能同时执行这两者：如果 `setPostProcessingPreset` 和 `setPostProcessingValues` 都为 `true`，将返回错误 `PostProcessingUpdateRequestLoadingPresetAndValues`。不过，两者都可以为 `false`。此时不会设置任何值。如果您仅想全局开启/关闭后期处理而不更改当前配置，这非常有用。

直接或通过预设更改配置值时，配置值会从旧值平滑过渡到您提供的新值。过渡持续时间应在 `postProcessingFadeTime` 字段中指定，且必须介于 0 到 2（秒）之间。超出该范围将返回错误 `PostProcessingUpdateRequestFadeTimeInvalid`。

设置单个值时，字段 `setAllOtherValuesToDefault` 决定未在负载中提供的其他所有值是否保持不变，还是淡出回默认值，即所有未提及的效果将被关闭。

如果您想在直接设置配置值时使用任何[受限/实验性效果](https://github.com/DenchiSoft/VTubeStudio/wiki/Visual-Effects#restrictedexperimental-effects)，请确保在负载中将 `usingRestrictedEffects` 设为 `true`。这只是为了确保这些效果不会被意外使用。否则，将返回错误 `PostProcessingUpdateRequestTriedToLoadRestrictedEffect`。如果用户尚未在 VTube Studio VFX 设置中启用这些效果，也会返回此错误。此设置必须由用户手动完成。如果加载的预设包含受限效果，预设仍会完全加载且不会报错，但受限效果不会被激活。

您还可以请求随机化所有效果配置。这纯属娱乐用途。为此，将 `randomizeAll` 设为 `true`。如果 `randomizeAll` 为 `true`，负载中发送的任何配置值或预设将被忽略。当多个效果同时激活时，屏幕上会出现纯随机噪声，因此该功能会限制激活效果数量，并避免配置值过于疯狂。此功能可通过 `randomizeAllChaosLevel` 字段控制，接受 0 到 1 之间的值（超出范围的值会被限制在此范围内）。`0` 仅激活一两个效果且数值温和，`1` 则在屏幕上制造完全混乱。推荐的值范围为 `0.4` 到 `0.5`，效果较好。仅当您将 `usingRestrictedEffects` 设为 `true` 且用户允许/启用这些效果时，受限效果才会包含在随机化中。

### 如何设置单个配置值

当您想通过设置单个配置值详细控制后期处理配置时，必须将 `setPostProcessingValues` 设为 `true`，并通过 `postProcessingValues` 数组设置值。`configID` 是您想配置的效果配置的 ID，`configValue` 是您想设置的字符串值。

* `configID`：您想配置的配置 ID，参见[所有配置 ID 列表](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/EffectConfigs.cs)。这些 ID 支持多种格式，因此您可以以任何枚举样式创建它们。它们不区分大小写，且忽略 `_` 或 `-`。例如，您可以将 `Backlight_OutlineSize` 写为 `Backlight_Outline_Size`、`backlight_outlinesize`、`BACKLIGHT_OUTLINESIZE`、`backlight-outline_size` 或任何适合您的格式（另见 `PostProcessingListResponse` 的 `configEntries` 数组中的 `enumID` 字段）。
* `configValue`：要设置的值，字符串类型。对于浮点数或整数，超出配置的最小/最大范围的值会被限制。布尔值不区分大小写，接受 `"True"`、`"true"`（或 `"TRUE"` 等）等值。

如果数组中有重复键，将返回错误 `PostProcessingUpdateRequestValueListContainsDuplicates`；如果有无效键（未找到）或无效值（无法正确反序列化为浮点数、布尔值等），则返回错误 `PostProcessingUpdateRequestValueListInvalid`。

**如何真正开启一个效果：** 效果可能有多个配置项。每个效果至少有一个配置项（可能多个）用于开启该效果，条件是该配置项的值大于 0。在 `PostProcessingListResponse` 负载中，这些配置（总是浮点类型配置）通过 `"activationConfig": true` 标记。您也可以查看所有效果配置列表，其中这些特殊配置标记为 `sets_active: True`，见：https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/EffectConfigs.cs

### 一般使用建议


您不应以高频率发送此请求，例如每帧发送一次。 如果您想淡出一个值，请使用 `postProcessingFadeTime` 字段设置适当的淡出时间。 根据配置组合，频繁更新*可能*是可以的，但您应仔细测试。后处理系统针对不频繁的配置更新进行了优化，因此请确保在发布插件之前检查是否会导致任何延迟。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "PostProcessingUpdateRequest",
	"data":
	{
		"postProcessingOn": true,
		"setPostProcessingPreset": false,
		"setPostProcessingValues": true,
		"presetToSet": "",
		"postProcessingFadeTime": 1.3,
		"setAllOtherValuesToDefault": true,
		"usingRestrictedEffects": false,
		"randomizeAll": false,
		"randomizeAllChaosLevel" : 0.0,
		"postProcessingValues": [
			{
				"configID": "Backlight_Strength",
				"configValue": "0.8"
			},
			{
				"configID": "Bloom_Strength",
				"configValue": "1.0"
			},
			{
				"configID": "Bloom_StreakVertical",
				"configValue": "false"
			},
			{
				"configID": "Bloom_StreakColorTint",
				"configValue": "220308FF"
			}
		]
	}
}
```
如果没有错误，您将收到以下响应，其中包含有关您请求的更新后新后处理状态的一些常规信息。

**`RESPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "PostProcessingUpdateResponse",
	"data":
	{
		"postProcessingActive": true,
		"presetIsActive": false,
		"activePreset": "",
		"activeEffectCount": 2
	}
}
```



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-29

---