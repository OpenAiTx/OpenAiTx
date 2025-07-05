# lsfg-vk
该项目将[Lossless Scaling的帧生成](https://store.steampowered.com/app/993090/Lossless_Scaling/)带到Linux平台！
>[!NOTE]
> 这是一个正在开发中的项目。虽然帧生成已经在部分游戏中可用，但仍有很长的路要走。请查阅Wiki获取支持（Wiki尚未编写）

## 构建、安装与运行

>[!CAUTION]
> 构建说明最近已更改。请仔细阅读。

为了编译LSFG，请确保您的系统已安装以下组件：
- 传统的构建工具（+ sed, git）
- Clang编译器（本项目不易用GCC编译）
- Vulkan头文件
- CMake构建系统
- Meson构建系统（用于DXVK）
- Ninja构建系统（CMake后端）

编译lsfg-vk相对简单，因为所有内容都已整合到CMake中：
```bash
$ cmake -B build -G Ninja \
    -DCMAKE_BUILD_TYPE=Release \
    -DCMAKE_INSTALL_PREFIX=~/.local \
    -DCMAKE_INTERPROCEDURAL_OPTIMIZATION=ON \
    -DCMAKE_CXX_CLANG_TIDY=""
$ cmake --build build
$ cmake --install build
```
这会将lsfg-vk安装到~/.local/lib和~/.local/share/vulkan。

接下来，您需要从Steam下载Lossless Scaling。切换到`legacy_2.13`分支或下载对应的depot。
从游戏文件中复制或记录“Lossless.dll”的路径。

最后，让我们实际启用帧生成启动一个程序。本示例将使用`vkcube`：
```bash
VK_INSTANCE_LAYERS="VK_LAYER_LS_frame_generation" LSFG_DLL_PATH="/home/pancake/games/Lossless Scaling/Lossless.dll" LSFG_MULTIPLIER=4 vkcube
```
请务必调整路径。让我们逐一解释这些环境变量：
- `LVK_INSTANCE_LAYERS`：在此指定`VK_LAYER_LS_frame_generation`。这会强制任何Vulkan应用加载lsfg-vk层。
- `LSFG_DLL_PATH`：这里填写您从Steam下载的Lossless.dll。lsfg-vk会从中提取并转换着色器。
- `LSFG_MULTIPLIER`：这是您熟悉的倍增系数。指定`2`表示帧率翻倍，以此类推。
- `VK_LAYER_PATH`：如果您没有安装到`~/.local`或`/usr`，则需要在此指定`explicit_layer.d`文件夹。

>[!WARNING]
> 与Windows不同，LSFG_MULTIPLIER在此处受到很大限制（目前如此！）。如果您的硬件可以创建8个swapchain图像，那么将LSFG_MULTIPLIER设置为4会占用其中4个，只剩4个给游戏。如果游戏请求5个或更多，将会崩溃。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---