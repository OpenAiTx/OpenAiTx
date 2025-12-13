# Luz エンジン

[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![Windows](https://github.com/hadryansalles/Luz/actions/workflows/Windows.yml/badge.svg)](https://github.com/hadryansalles/Luz/actions/workflows/Windows.yml)
[![Ubuntu](https://github.com/hadryansalles/Luz/actions/workflows/Ubuntu.yml/badge.svg)](https://github.com/hadryansalles/Luz/actions/workflows/Ubuntu.yml)

AAAゲームで使用される最新のレンダリング技術を学び実装するために開発しているVulkanエンジンです。
- [YouTubeの動画](https://www.youtube.com/user/HadryanSalles/videos)
- [特徴](#features)
- [ビルドと実行方法](#build)
- [参考文献とクレジット](#references)

<a name="features"/>

## 特徴
- 完全なVulkanラッパー（BLASおよびTLASの作成を含む）
- 体積光の3つのアプローチ：Froxels、ポリゴンメッシュ、スクリーンスペース
- 時間的アンチエイリアシング
- シャドウマップ
- 大気散乱
- シーンのシリアライズ（JSON）
- デファードレンダリング
- リアルタイムレイトレースシャドウとアンビエントオクルージョン
- メタリック、ラフネス、法線、アンビエントオクルージョン、エミッションを用いたPBRシェーディング
- Vulkanのバインドレスリソース
- パースペクティブおよび正射影のビューポートカメラとフライおよびオービットコントロール
- ImGuiドッキングUI

## ギャラリー
- Froxelベースの体積光
![froxel](https://github.com/user-attachments/assets/28efe343-f5be-45db-a3ac-246aee47faa4)

- ポリゴンメッシュ体積光
![polygonal](https://github.com/user-attachments/assets/c2113f1b-9081-4a1d-8b8a-516c6d81281f)

- スクリーンスペース体積光
![ssvl](https://github.com/user-attachments/assets/fcbd3fd5-881f-4640-a887-565d7190da23)

- デファードレンダリング（ライト、アルベド、法線、マテリアル、エミッシブおよび深度）
![deferred](https://user-images.githubusercontent.com/37905502/154867586-7dfa15d1-faf7-4eab-8337-c578831c9044.gif)
- レイトレースシャドウとアンビエントオクルージョン  
![raytraced](https://user-images.githubusercontent.com/37905502/144621461-52f1ab97-ff6b-4f6f-a83a-cc6f67f5ead6.gif)

- PBRシェーディングとglTFモデル  
![pbr](https://user-images.githubusercontent.com/37905502/144612584-1d752a16-c978-4f43-93d6-2e2362b2804b.gif)

- テクスチャのドラッグ＆ドロップ  
![dragndrop](https://user-images.githubusercontent.com/37905502/144619247-737d37c1-ba67-4f9a-abf4-63e4d2f965d6.gif)

<a name="build"/>

## 必要条件  
- VK_KHR_ray_query拡張をサポートするGPU（[対応GPU一覧](https://vulkan.gpuinfo.org/listdevicescoverage.php?extension=VK_KHR_ray_query&platform=all)）  
- C++17コンパイラ。``Visual Studio 2019``, ``Clang``, ``GCC``で動作確認済み  
- [CMake 3.7](https://cmake.org/download/)以上  
- [Vulkan SDK](https://vulkan.lunarg.com/sdk/home)

### Linuxの場合  

このプロジェクトはGLFWライブラリを使用しています。X11環境のLinux（例：デフォルトのUbuntu 20.04）でコンパイルするには、以下が必要です：


```sh
sudo apt-get install xorg-dev
```
もし別のウィンドウマネージャー（Waylandなど）を使用している場合は、依存関係を[こちら](https://www.glfw.org/docs/latest/compile.html#compile_deps)で確認できます。

## ビルドと実行

```sh
git clone --recursive https://github.com/hadryansalles/Luz
cd Luz
mkdir build
cmake . -Bbuild
cmake --build build --parallel 4
./bin/Luz
```
- Visual Studio: ``build/Luz.sln`` を開き、プロジェクト ``Luz`` をコンパイル/実行します。

<a name="references"/>

## 参考文献とクレジット

- [GLFW](https://github.com/glfw/glfw) はアプリケーションウィンドウを開くために使用
- [glm](https://github.com/g-truc/glm) は数学ライブラリとして使用
- [ImGui](https://github.com/ocornut/imgui) はユーザーインターフェース作成に使用
- [ImGuizmo](https://github.com/CedricGuillemet/ImGuizmo) は3Dギズモ作成に使用
- [spdlog](https://github.com/gabime/spdlog) はログ記録ライブラリとして使用
- [stb_image](https://github.com/nothings/stb) は画像ファイルの読み込みに使用
- [tiny_obj_loader](https://github.com/tinyobjloader/tinyobjloader) はWavefront .obj ファイルの読み込みに使用
- [optick](https://github.com/bombomby/optick) はエンジンのプロファイリングに使用
- [pbr-sky](https://www.shadertoy.com/view/slyBDG) は大気スカイモデルの参照として使用



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-13

---