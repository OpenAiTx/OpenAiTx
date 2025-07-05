# lsfg-vk
This project brings [Lossless Scaling's Frame Generation](https://store.steampowered.com/app/993090/Lossless_Scaling/) to Linux!
>[!NOTE]
> This is a work-in-progress. While frame generation has worked in a few games, there's still a long way to go. Please review the wiki for support (the wiki is not written yet)

## Building, Installing and Running

>[!CAUTION]
> The build instructions have recently changed. Please review them.

In order to compile LSFG, make sure you have the following components installed on your system:
- Traditional build tools (+ sed, git)
- Clang compiler (this project does NOT compile easily with GCC)
- Vulkan header files
- CMake build system
- Meson build system (for DXVK)
- Ninja build system (backend for CMake)

Compiling lsfg-vk is relatively straight forward, as everything is neatly integrated into CMake:
```bash
$ cmake -B build -G Ninja \
    -DCMAKE_BUILD_TYPE=Release \
    -DCMAKE_INSTALL_PREFIX=~/.local \
    -DCMAKE_INTERPROCEDURAL_OPTIMIZATION=ON \
    -DCMAKE_CXX_CLANG_TIDY=""
$ cmake --build build
$ cmake --install build
```
This will install lsfg-vk to ~/.local/lib and ~/.local/share/vulkan.

Next, you'll need to download Lossless Scaling from Steam. Switch to the `legacy_2.13` branch or download the corresponding depot.
Copy or note down the path of "Lossless.dll" from the game files.

Finally, let's actually start a program with frame generation enabled. I'm going to be using `vkcube` for this example:
```bash
VK_INSTANCE_LAYERS="VK_LAYER_LS_frame_generation" LSFG_DLL_PATH="/home/pancake/games/Lossless Scaling/Lossless.dll" LSFG_MULTIPLIER=4 vkcube
```
Make sure you adjust the paths. Let's examine each one:
- `LVK_INSTANCE_LAYERS`: Specify `VK_LAYER_LS_frame_generation` here. This forces any Vulkan app to load the lsfg-vk layer.
- `LSFG_DLL_PATH`: Here you specify the Lossless.dll you downloaded from Steam. lsfg-vk will extract and translate the shaders from here.
- `LSFG_MULTIPLIER`: This is the multiplier you should be familiar with. Specify `2` for doubling the framerate, etc.
- `VK_LAYER_PATH`: If you did not install to `~/.local` or `/usr`, you have to specify the `explicit_layer.d` folder here.

>[!WARNING]
> Unlike on Windows, LSFG_MULTIPLIER is heavily limited here (at the moment!). If your hardware can create 8 swapchain images, then setting LSFG_MULTIPLIER to 4 occupies 4 of those, leaving only 4 to the game. If the game requested 5 or more, it will crash.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---