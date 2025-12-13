# Luz Engine

[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![Windows](https://github.com/hadryansalles/Luz/actions/workflows/Windows.yml/badge.svg)](https://github.com/hadryansalles/Luz/actions/workflows/Windows.yml)
[![Ubuntu](https://github.com/hadryansalles/Luz/actions/workflows/Ubuntu.yml/badge.svg)](https://github.com/hadryansalles/Luz/actions/workflows/Ubuntu.yml)

A Vulkan engine that I'm developing to study and implement modern rendering techniques used by AAA games.
- [Videos on Youtube](https://www.youtube.com/user/HadryanSalles/videos)
- [Features](#features)
- [How to build and run](#build)
- [References and credits](#references)

<a name="features"/>

## Features
- Complete Vulkan Wrapper (including BLAS and TLAS creation)
- 3 Approaches for Volumetric Light: Froxels, Polygon Mesh and Screen Space
- Temporal Anti-Aliasing
- Shadow Maps
- Atmospheric Scattering
- Scene Serialization (JSON)
- Deferred Rendering
- Real-time ray traced shadows and ambient occlusion
- PBR Shading with metallic, roughness, normal, ambient occlusion and emission
- Vulkan bindless resources
- Viewport camera with perspective and orthographic projections and fly and orbit controls
- ImGui docking UI

## Gallery
- Froxel Based Volumetric Light
![froxel](https://github.com/user-attachments/assets/28efe343-f5be-45db-a3ac-246aee47faa4)

- Polygonal Mesh Volumetric Light
![polygonal](https://github.com/user-attachments/assets/c2113f1b-9081-4a1d-8b8a-516c6d81281f)

- Screen Space Volumetric Light
![ssvl](https://github.com/user-attachments/assets/fcbd3fd5-881f-4640-a887-565d7190da23)

- Deferred Rendering (Light, Albedo, Normal, Material, Emissive and Depth)
![deferred](https://user-images.githubusercontent.com/37905502/154867586-7dfa15d1-faf7-4eab-8337-c578831c9044.gif)

- Ray traced shadows and ambient occlusion
![raytraced](https://user-images.githubusercontent.com/37905502/144621461-52f1ab97-ff6b-4f6f-a83a-cc6f67f5ead6.gif)

- PBR Shading and glTF models
![pbr](https://user-images.githubusercontent.com/37905502/144612584-1d752a16-c978-4f43-93d6-2e2362b2804b.gif)

- Textures drag and drop
![dragndrop](https://user-images.githubusercontent.com/37905502/144619247-737d37c1-ba67-4f9a-abf4-63e4d2f965d6.gif)

<a name="build"/>

## Requirements
- A GPU that supports VK_KHR_ray_query extension ([list of supported GPUs](https://vulkan.gpuinfo.org/listdevicescoverage.php?extension=VK_KHR_ray_query&platform=all))
- C++17 compiler. Tested with ``Visual Studio 2019``, ``Clang`` and ``GCC``
- [CMake 3.7](https://cmake.org/download/) or higher
- [Vulkan SDK](https://vulkan.lunarg.com/sdk/home)

### For Linux

This project uses the GLFW library, to compile it under Linux with X11 (like the default Ubuntu 20.04) you will need:

```sh
sudo apt-get install xorg-dev
```

If you are using another window manager (like Wayland) you can check the dependencies [here](https://www.glfw.org/docs/latest/compile.html#compile_deps).

## Build and Run
```sh
git clone --recursive https://github.com/hadryansalles/Luz
cd Luz
mkdir build
cmake . -Bbuild
cmake --build build --parallel 4
./bin/Luz
```
- Visual Studio: open ``build/Luz.sln`` and compile/run the project ``Luz``.

<a name="references"/>

## References and Credits

- [GLFW](https://github.com/glfw/glfw) used to open the application window
- [glm](https://github.com/g-truc/glm) used as the math library
- [ImGui](https://github.com/ocornut/imgui) used to make the user interface
- [ImGuizmo](https://github.com/CedricGuillemet/ImGuizmo) used to create 3D gizmos
- [spdlog](https://github.com/gabime/spdlog) used as the logging library
- [stb_image](https://github.com/nothings/stb) used to load image files
- [tiny_obj_loader](https://github.com/tinyobjloader/tinyobjloader) used to load wavefront .obj files
- [optick](https://github.com/bombomby/optick) used to profile the engine
- [pbr-sky](https://www.shadertoy.com/view/slyBDG) used as reference for atmospheric sky model



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-13

---