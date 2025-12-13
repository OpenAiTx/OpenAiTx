# Luz Engine

[![Licencia: MIT](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![Windows](https://github.com/hadryansalles/Luz/actions/workflows/Windows.yml/badge.svg)](https://github.com/hadryansalles/Luz/actions/workflows/Windows.yml)
[![Ubuntu](https://github.com/hadryansalles/Luz/actions/workflows/Ubuntu.yml/badge.svg)](https://github.com/hadryansalles/Luz/actions/workflows/Ubuntu.yml)

Un motor Vulkan que estoy desarrollando para estudiar e implementar técnicas modernas de renderizado usadas por juegos AAA.
- [Videos en Youtube](https://www.youtube.com/user/HadryanSalles/videos)
- [Características](#features)
- [Cómo compilar y ejecutar](#build)
- [Referencias y créditos](#references)

<a name="features"/>

## Características
- Wrapper completo de Vulkan (incluyendo creación de BLAS y TLAS)
- 3 Enfoques para Luz Volumétrica: Froxeles, Malla Poligonal y Espacio de Pantalla
- Anti-Aliasing Temporal
- Mapas de Sombras
- Dispersión Atmosférica
- Serialización de Escena (JSON)
- Renderizado Diferido
- Sombras y oclusión ambiental trazadas en tiempo real con rayos
- Sombreado PBR con metálico, rugosidad, normal, oclusión ambiental y emisión
- Recursos bindless de Vulkan
- Cámara de viewport con proyecciones en perspectiva y ortográfica y controles de vuelo y órbita
- UI ImGui con acoplamiento (docking)

## Galería
- Luz Volumétrica basada en Froxeles
![froxel](https://github.com/user-attachments/assets/28efe343-f5be-45db-a3ac-246aee47faa4)

- Luz Volumétrica con Malla Poligonal
![polygonal](https://github.com/user-attachments/assets/c2113f1b-9081-4a1d-8b8a-516c6d81281f)

- Luz Volumétrica en Espacio de Pantalla
![ssvl](https://github.com/user-attachments/assets/fcbd3fd5-881f-4640-a887-565d7190da23)

- Renderizado Diferido (Luz, Albedo, Normal, Material, Emisivo y Profundidad)
![deferred](https://user-images.githubusercontent.com/37905502/154867586-7dfa15d1-faf7-4eab-8337-c578831c9044.gif)

- Sombras trazadas por rayos y oclusión ambiental
![raytraced](https://user-images.githubusercontent.com/37905502/144621461-52f1ab97-ff6b-4f6f-a83a-cc6f67f5ead6.gif)

- Sombreado PBR y modelos glTF
![pbr](https://user-images.githubusercontent.com/37905502/144612584-1d752a16-c978-4f43-93d6-2e2362b2804b.gif)

- Arrastrar y soltar texturas
![dragndrop](https://user-images.githubusercontent.com/37905502/144619247-737d37c1-ba67-4f9a-abf4-63e4d2f965d6.gif)

<a name="build"/>

## Requisitos
- Una GPU que soporte la extensión VK_KHR_ray_query ([lista de GPUs compatibles](https://vulkan.gpuinfo.org/listdevicescoverage.php?extension=VK_KHR_ray_query&platform=all))
- Compilador C++17. Probado con ``Visual Studio 2019``, ``Clang`` y ``GCC``
- [CMake 3.7](https://cmake.org/download/) o superior
- [Vulkan SDK](https://vulkan.lunarg.com/sdk/home)

### Para Linux

Este proyecto usa la biblioteca GLFW, para compilarlo en Linux con X11 (como el Ubuntu 20.04 por defecto) necesitarás:

```sh
sudo apt-get install xorg-dev
```

Si está utilizando otro gestor de ventanas (como Wayland) puede consultar las dependencias [aquí](https://www.glfw.org/docs/latest/compile.html#compile_deps).

## Compilar y Ejecutar
```sh
git clone --recursive https://github.com/hadryansalles/Luz
cd Luz
mkdir build
cmake . -Bbuild
cmake --build build --parallel 4
./bin/Luz
```
- Visual Studio: abrir ``build/Luz.sln`` y compilar/ejecutar el proyecto ``Luz``.

<a name="references"/>

## Referencias y Créditos

- [GLFW](https://github.com/glfw/glfw) utilizado para abrir la ventana de la aplicación
- [glm](https://github.com/g-truc/glm) utilizado como la biblioteca de matemáticas
- [ImGui](https://github.com/ocornut/imgui) utilizado para crear la interfaz de usuario
- [ImGuizmo](https://github.com/CedricGuillemet/ImGuizmo) utilizado para crear gizmos 3D
- [spdlog](https://github.com/gabime/spdlog) utilizado como biblioteca de registro
- [stb_image](https://github.com/nothings/stb) utilizado para cargar archivos de imagen
- [tiny_obj_loader](https://github.com/tinyobjloader/tinyobjloader) utilizado para cargar archivos wavefront .obj
- [optick](https://github.com/bombomby/optick) utilizado para perfilar el motor
- [pbr-sky](https://www.shadertoy.com/view/slyBDG) utilizado como referencia para el modelo atmosférico del cielo



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-13

---