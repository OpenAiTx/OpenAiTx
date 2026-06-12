# VHVR-Mod
这是为PC游戏《Valheim》开发的一个实验性mod，使用Unity和SteamVR结合OpenVR添加原生VR支持。

在[Nexus Mods](https://www.nexusmods.com/valheim/mods/847)下载该mod！

查看开发进度日志请访问[YouTube](https://www.youtube.com/playlist?list=PL9EDvRwka57-swWbcOAq0lhIp5jSFPg-u)。

加入[Flatscreen to VR Modding Discord](https://discord.gg/ZFSCSDe)

## 这个包里有什么？
### Unity项目
该项目主要作为资源生成器，用于生成mod所需的AssetBundles，以及在合适环境下构建SteamVR和Unity XR库。

Unity包中生成了几个资源，但最重要的包括：
* SteamVR Player预制件：该预制件是一个Unity游戏对象层级，包含正确使用SteamVR所需的所有脚本。层级中包括一个摄像机，会替换主游戏的摄像机。摄像机配置为在头显中显示立体3D。
* Unity和OpenVR资源：这些资源用于在游戏启动时正确引导Unity的XR引擎。
* [Amplify Occlusion](https://github.com/AmplifyCreations/AmplifyOcclusion)图形后处理器：作为游戏内SSAO图形效果的高性能替代方案。

### ValheimVRMod C#项目
该项目包含mod的大部分代码。包括实现以下功能的类/Unity MonoBehaviour脚本：
* 初始化Unity/OpenVR XR引擎
* 从AssetBundles实例化SteamVR预制件
* 用VR摄像机替换游戏主摄像机并适当定位
* 将游戏GUI转换为VR显示
* 实现动作控制（进行中）

### 要求
该mod需要[BepInExPack Valheim](https://valheim.thunderstore.io/package/denikson/BepInExPack_Valheim/)。BepInEx是一个Unity游戏的mod框架，允许mod开发者将代码注入游戏运行时。它还包含[Harmony](https://harmony.pardeike.net/articles/intro.html)，这是用于修补C#库中现有方法的工具。

此外，你需要一个支持OpenVR/SteamVR的头显。

### 其他信息
这是一个实验性mod，几乎肯定包含许多bug和故障。此外，《Valheim》目前还是抢先体验版，游戏更新很可能会破坏此mod。请耐心等待修复，并欢迎报告任何发现的问题 :)

由于《Valheim》并非为VR设计，因此该实现不会像专为VR设计的游戏那样舒适。如果VR容易让你感到不适，那么这个mod可能不适合你。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-12

---