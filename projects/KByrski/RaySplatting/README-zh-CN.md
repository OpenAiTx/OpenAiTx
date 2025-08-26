# RaySplats：基于光线追踪的高斯点绘制
Krzysztof Byrski, Marcin Mazur, Jacek Tabor, Tadeusz Dziarmaga, Marcin Kądziołka, Dawid Baran, Przemysław Spurek <br>

| arXiv |
| :---- |
| RaySplats：基于光线追踪的高斯点绘制 [https://arxiv.org/pdf/2501.19196.pdf](http://arxiv.org/abs/2501.19196)|

<img src=assets/gif1.gif height="300" class="center"> 
<br>

<table align="center" cellspacing="0" cellpadding="0">
  <tr class="center">
    <td><img src=assets/screenshot1.png height="200" width="300" class="center"></td>
    <td><img src=assets/screenshot92.png height="200" width="300" class="center"></td>
    <td><img src=assets/screenshot10.png height="200" width="300" class="center"> </td>
  </tr>
  </tr class="center">
  <tr class="center">
    <td><img src=assets/screenshot7.png height="200" width="300" ></td>
    <td><img src=assets/screenshot82.png height="200" width="300" ></td>
    <td><img src=assets/screenshot4.png height="200" width="300" class="center"> </td>
  </tr>
</table>

# 特性
- 支持最高到**4**阶的球谐函数。
- 交互式Windows查看器/优化器应用，允许实时预览训练模型状态。
- 支持**PLY**格式的训练模型输出。
- 高效的纯高斯渲染器（无嵌入的原始网格近似）。
- 基于便捷文本配置文件的高度可配置优化器。
- 支持**Blender**和**COLMAP**数据集（经过3DGS的预处理）。
- 内置模型评估和可配置频率的*.bmp文件可视化。

# 交互式Windows查看器/优化器应用中的控制

<img src="https://raw.githubusercontent.com/KByrski/RaySplatting/master/assets/app_main_window.png">

- **双击左键**：切换**静态相机**和**自由漫游**模式。
- **鼠标移动**：在**自由漫游**模式下旋转相机。
- **W / S**：前进 / 后退。
- **A / D**：向左/右移动一步。  
- **空格键 / C**：向上/下移动。  
- **[ / ]**：切换摄像机到前一个/下一个训练姿势。  
- **Print Screen**：截图并保存为24位*.bmp文件。  

# 前提条件：  

- Visual Studio 2019 Enterprise；  
- CUDA Toolkit 12.4.1；  
- NVIDIA OptiX SDK 8.0.0；  

# 构建交互式Windows查看器/优化器应用程序  

- 创建新的Windows桌面应用程序项目，命名为“RaySplats”；  
- 删除新生成的包含代码模板的RaySplats.cpp文件；  
- 在**构建依赖项** -> **构建自定义...**中选择与已安装CUDA版本匹配的复选框。在我们的测试系统中，我们必须选择以下复选框：  

  **CUDA 12.4(.targets, .props)**  
 
- 将目录“RaySplats”中的所有文件添加到项目中；  
- 在项目属性中将**配置**设置为**“Release”**，将**平台**设置为**“x64”**；  
- 在**属性** -> **配置属性** -> **CUDA C/C++** -> **常规** -> **生成可重定位设备代码**中选择**是 (-rdc=true)**；  
- 对文件“shaders.cuh”在**属性** -> **配置属性** -> **常规** -> **项目类型**中选择**“CUDA C/C++”**；  
- 对文件：“shaders.cuh”，“shaders_SH0.cu”，“shaders_SH1.cu”，“shaders_SH2.cu”，“shaders_SH3.cu”和“shaders_SH4.cu”在**属性** -> **配置属性** -> **CUDA C/C++** -> **常规**中：  
  - 将**编译器输出（obj/cubin）**的后缀从**“.obj”**改为**“.ptx”**；  
  - 在**生成可重定位设备代码**中选择**否**；  
  - 在**NVCC编译类型**中选择**生成仅设备的.ptx文件 (-ptx)**；  
- 在**属性** -> **配置属性** -> **VC++目录** -> **包含目录**中添加OptiX的“include”目录路径。在我们的测试系统中，我们必须添加以下路径：
  ```plaintext
  "C:\ProgramData\NVIDIA Corporation\OptiX SDK 8.0.0\include"
  ```
- 在 **属性** -> **配置属性** -> **CUDA C/C++** -> **设备** -> **代码生成** 中输入您的GPU的计算能力和微架构版本。在我们使用RTX 4070 GPU的测试系统上，我们输入了：
  ```plaintext
  "compute_89,sm_89"
  ```
- 在 **属性** -> **配置属性** -> **链接器** -> **输入** -> **附加依赖项** 中添加三行新内容：
  ```plaintext
  "cuda.lib"
  ```
  ```plaintext
  "cudart.lib"
  ```
  ```plaintext
  "cufft.lib"
  ```
- 在文件 InitializeOptiXRenderer.cu 的两个不同代码块中：
  ```plaintext
  if      constexpr (SH_degree == 0) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH0.cu.ptx", "rb");
  else if constexpr (SH_degree == 1) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH1.cu.ptx", "rb");
  else if constexpr (SH_degree == 2) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH2.cu.ptx", "rb");
  else if constexpr (SH_degree == 3) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH3.cu.ptx", "rb");
  else if constexpr (SH_degree == 4) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH4.cu.ptx", "rb");
  ```
  and
  ```plaintext
  if      constexpr (SH_degree == 0) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH0.cu.ptx", "rt");
  else if constexpr (SH_degree == 1) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH1.cu.ptx", "rt");
  else if constexpr (SH_degree == 2) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH2.cu.ptx", "rt");
  else if constexpr (SH_degree == 3) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH3.cu.ptx", "rt");
  else if constexpr (SH_degree == 4) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH4.cu.ptx", "rt");
  ```
  将提供的路径替换为您硬盘上*.ptx编译着色器文件的路径。

# 训练您的第一个模型（Blender 数据集）：

- 使用 3DGS 对某个 Blender 数据集（例如：“NeRF synthetic” 集合中的 “lego”）进行少量迭代训练（例如 100 次）；
- 将数据集主目录下子目录 “train” 和 “test” 中的所有文件转换为 24 位 *.bmp 文件格式，且不更改文件名；
- 将配置文件 “config.txt” 复制到项目主目录。我们测试系统中复制到以下目录：
  ```plaintext
  "C:\Users\<Windows username>\source\repos\RaySplats\RaySplats"
  ```
- 在配置文件的第4和第5行指定数据集主目录的位置以及短模型预训练后得到的输出3DGS *.ply文件的位置（**重要！** 用于预训练的球谐度数与配置文件第7行指定的目标度数不必匹配）；
- 在配置文件的第13-15行指定与预训练时背景色匹配的背景颜色，使用以下公式：
  
  R' = (R + 0.5) / 256<br>
  G' = (G + 0.5) / 256<br>
  B' = (B + 0.5) / 256<br>

  其中R、G和B是取值范围为0-255的整数非负背景颜色坐标。
- 从Visual Studio IDE运行“RaySplats”项目；

# RaySplatting 查看器
![image](https://github.com/user-attachments/assets/9a9d61cb-f54a-4301-8a52-4c2d0ce2cc72)
![](https://raw.githubusercontent.com/KByrski/RaySplatting/master/assets/tutorial.mp4)

这是一个轻量且用户友好的查看器，用于可视化**RaySplatting**，支持额外用户加载的支持光线追踪的对象。该查看器允许将**OBJ**和**PLY（ASCII格式）**文件无缝集成到场景中。

当前的材质系统针对设计为**反射性**或**玻璃质感**的模型进行了优化，非常适合渲染具有逼真光线交互的高质量视觉效果。

## 系统要求

使用此查看器前，请确保系统满足以下要求：

- **操作系统**：Windows  
- **GPU**：NVIDIA RTX 20xx系列或更高（**推荐RTX 30xx及以上**）  
- **CUDA版本**：12.4或更高  
- **所需DLL文件**：将以下文件放置于目录中：  
  ```plaintext
  C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v12.4\bin
  ```
  - `cudart64_12.dll`  
  - `cufft64_11.dll`  

## 安装与使用  

1. 下载提供的 **ZIP 文件**。 [下载 ZIP](https://drive.google.com/file/d/1XPivZb6-dVtuwQ3T9UrxOF2gTTnerGhp/view?usp=sharing)  
2. 解压文件内容。  
3. 运行 **exe 文件**——无需额外设置！  
4. 在 **mesh_config.txt** 中修改网格属性。  
5. 通过编辑 `config.txt` 中的 **PLY 文件路径** 来更改基础场景。  

## 控制  

- 与交互式 Windows 查看器/优化器应用程序完全相同。  

## 未来功能  

我们正在积极开发新功能，包括：  
- **增强的网格变换**（缩放、旋转、位置编辑，超出 `mesh_config.txt` 范围）  
- **渲染场景截图捕捉**  
- **视图预设**，实现不同视角间的无缝切换  
- **以及更多！**  

敬请关注更新和改进！





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---