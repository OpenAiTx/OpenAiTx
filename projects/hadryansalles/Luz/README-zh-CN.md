# Luz 引擎

[![许可协议: MIT](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![Windows](https://github.com/hadryansalles/Luz/actions/workflows/Windows.yml/badge.svg)](https://github.com/hadryansalles/Luz/actions/workflows/Windows.yml)
[![Ubuntu](https://github.com/hadryansalles/Luz/actions/workflows/Ubuntu.yml/badge.svg)](https://github.com/hadryansalles/Luz/actions/workflows/Ubuntu.yml)

我正在开发的 Vulkan 引擎，用于学习和实现 AAA 游戏中使用的现代渲染技术。
- [Youtube 上的视频](https://www.youtube.com/user/HadryanSalles/videos)
- [功能特性](#features)
- [如何构建和运行](#build)
- [参考资料与致谢](#references)

<a name="features"/>

## 功能特性
- 完整的 Vulkan 封装（包括 BLAS 和 TLAS 创建）
- 三种体积光实现方式：Froxels、Polygonon 网格和屏幕空间
- 时间抗锯齿
- 阴影贴图
- 大气散射
- 场景序列化（JSON）
- 延迟渲染
- 实时光线追踪阴影和环境遮蔽
- PBR 着色，支持金属度、粗糙度、法线、环境遮蔽和自发光
- Vulkan 无绑定资源
- 视口摄像机，支持透视和正交投影，以及飞行和环绕控制
- ImGui 停靠式用户界面

## 图集
- 基于 Froxel 的体积光
![froxel](https://github.com/user-attachments/assets/28efe343-f5be-45db-a3ac-246aee47faa4)

- 多边形网格体积光
![polygonal](https://github.com/user-attachments/assets/c2113f1b-9081-4a1d-8b8a-516c6d81281f)

- 屏幕空间体积光
![ssvl](https://github.com/user-attachments/assets/fcbd3fd5-881f-4640-a887-565d7190da23)

- 延迟渲染（光照、反照率、法线、材质、自发光和深度）
![deferred](https://user-images.githubusercontent.com/37905502/154867586-7dfa15d1-faf7-4eab-8337-c578831c9044.gif)
- 光线追踪阴影和环境光遮蔽  
![raytraced](https://user-images.githubusercontent.com/37905502/144621461-52f1ab97-ff6b-4f6f-a83a-cc6f67f5ead6.gif)

- PBR 着色和 glTF 模型  
![pbr](https://user-images.githubusercontent.com/37905502/144612584-1d752a16-c978-4f43-93d6-2e2362b2804b.gif)

- 纹理拖放  
![dragndrop](https://user-images.githubusercontent.com/37905502/144619247-737d37c1-ba67-4f9a-abf4-63e4d2f965d6.gif)

<a name="build"/>

## 需求  
- 支持 VK_KHR_ray_query 扩展的 GPU（[支持的 GPU 列表](https://vulkan.gpuinfo.org/listdevicescoverage.php?extension=VK_KHR_ray_query&platform=all)）  
- C++17 编译器。已在 ``Visual Studio 2019``、``Clang`` 和 ``GCC`` 上测试  
- [CMake 3.7](https://cmake.org/download/) 或更高版本  
- [Vulkan SDK](https://vulkan.lunarg.com/sdk/home)

### Linux 平台

该项目使用 GLFW 库，若在带 X11 的 Linux（如默认的 Ubuntu 20.04）下编译，需要：


```sh
sudo apt-get install xorg-dev
```
如果您使用的是其他窗口管理器（如 Wayland），您可以在[此处](https://www.glfw.org/docs/latest/compile.html#compile_deps)查看依赖项。

## 构建与运行

```sh
git clone --recursive https://github.com/hadryansalles/Luz
cd Luz
mkdir build
cmake . -Bbuild
cmake --build build --parallel 4
./bin/Luz
```
- Visual Studio：打开 ``build/Luz.sln`` 并编译/运行项目 ``Luz``。

<a name="references"/>

## 参考文献与致谢

- [GLFW](https://github.com/glfw/glfw) 用于打开应用程序窗口
- [glm](https://github.com/g-truc/glm) 用作数学库
- [ImGui](https://github.com/ocornut/imgui) 用于制作用户界面
- [ImGuizmo](https://github.com/CedricGuillemet/ImGuizmo) 用于创建3D小工具
- [spdlog](https://github.com/gabime/spdlog) 用作日志库
- [stb_image](https://github.com/nothings/stb) 用于加载图像文件
- [tiny_obj_loader](https://github.com/tinyobjloader/tinyobjloader) 用于加载Wavefront .obj文件
- [optick](https://github.com/bombomby/optick) 用于引擎性能分析
- [pbr-sky](https://www.shadertoy.com/view/slyBDG) 用作大气天空模型参考



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-13

---