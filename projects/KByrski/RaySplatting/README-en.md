# RaySplats: Ray Tracing based Gaussian Splatting
Krzysztof Byrski, Marcin Mazur, Jacek Tabor, Tadeusz Dziarmaga, Marcin Kądziołka, Dawid Baran, Przemysław Spurek <br>

| arXiv |
| :---- |
| RaySplats: Ray Tracing based Gaussian Splatting [https://arxiv.org/pdf/2501.19196.pdf](http://arxiv.org/abs/2501.19196)|

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

# Features
- Spherical harmonics support up to the degree **4**.
- Interactive Windows viewer / optimizer application allowing to preview the trained model state in real time.
- Support for the **PLY** trained model output format.
- Highly efficient pure Gaussian renderer (no embedding primitive mesh approximation).
- Highly configurable optimizer based on the convenient text configuration file.
- Support for both the **Blender** and **COLMAP** data sets (after some preprocessing by the 3DGS).
- Built-in evaluation of the model and visualization to the *.bmp file with configurable frequency.

# Controls in the interactive Windows viewer / optimizer application

<img src="https://raw.githubusercontent.com/KByrski/RaySplatting/master/assets/app_main_window.png">

- **Double Left Click**: Toggle between the **static camera** and the **free roam** mode.
- **Mouse Movement**: Rotate the camera in the **free roam** mode.
- **W / S**: Move forward / backward.
- **A / D**: Step left / right.  
- **Spacebar / C**: Move up / down.  
- **[ / ]**: Switch the camera to the previous / next training pose.  
- **Print Screen**: Make screenshot and save it to the 24-bit *.bmp file.  

# Prerequisites:  

- Visual Studio 2019 Enterprise;  
- CUDA Toolkit 12.4.1;  
- NVIDIA OptiX SDK 8.0.0;  

# Building the interactive Windows viewer / optimizer application  

- Create the new Windows Desktop Application project and name it "RaySplats";  
- Remove the newly generated RaySplats.cpp file containing the code template;  
- In **Build Dependencies** -> **Build Customizations...** select the checkbox matching your installed CUDA version. On our test system, we had to select the following checkbox:  

  **CUDA 12.4(.targets, .props)**  
   
- Add all the files from the directory "RaySplats" to the project;  
- In the project's Properties set **Configuration** to **"Release"** and **Platform** to **"x64"**;  
- In **Properties** -> **Configuration Properties** -> **CUDA C/C++** -> **Common** -> **Generate Relocatable Device Code** select **Yes (-rdc=true)**;  
- For file "shaders.cuh" in **Properties** -> **Configuration Properties** -> **General** -> **Item Type** select **"CUDA C/C++**;  
- For files: "shaders.cuh", "shaders_SH0.cu", "shaders_SH1.cu", "shaders_SH2.cu", "shaders_SH3.cu" and "shaders_SH4.cu" in **Properties** -> **Configuration Properties** -> **CUDA C/C++** -> **Common**:  
  - Change the suffix of **Compiler Output (obj/cubin)** from **".obj"** to **".ptx"**;  
  - In **Generate Relocatable Device Code** select **No**;  
  - In **NVCC Compilation Type** select **Generate device-only .ptx file (-ptx)"**;  
- In **Properties** -> **Configuration Properties** -> **VC++ Directories** -> **Include Directories** add OptiX "include" directory path. On our test system, we had to add the following path:
  ```plaintext
  "C:\ProgramData\NVIDIA Corporation\OptiX SDK 8.0.0\include"
  ```
- In **Properties** -> **Configuration Properties** -> **CUDA C/C++** -> **Device** -> **Code Generation** type the compute capability and microarchitecture version of your GPU. On our test system with RTX 4070 GPU we typed:
  ```plaintext
  "compute_89,sm_89"
  ```
- In **Properties** -> **Configuration Properties** -> **Linker** -> **Input** -> **Additional Dependencies** add three new lines containing:
  ```plaintext
  "cuda.lib"
  ```
  ```plaintext
  "cudart.lib"
  ```
  ```plaintext
  "cufft.lib"
  ```
- In each of two different blocks of code in file InitializeOptiXRenderer.cu:
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
  replace the provided path with the path to the *.ptx compiled shaders files on your hdd.

# Training your first model (Blender dataset):

- Train the model with 3DGS for some small number of iterations (for example 100) on some Blender dataset (for example: "lego" from "NeRF synthetic" set);
- Convert all of the files in the subdirectories: "train" and "test" located in the dataset main directory to 24-bit *.bmp file format without changing their names;
- Copy the configuration file "config.txt" to the project's main directory. On our test system we copied it to the following directory:
  ```plaintext
  "C:\Users\<Windows username>\source\repos\RaySplats\RaySplats"
  ```
- In lines: 4 and 5 of the configuration file specify the location of the dataset main directory and the output 3DGS *.ply file obtained after short model pretraining (**Important!** The spherical harmonics degree used for pretraining and the target one specified in the line 7 of the config file don't have to match);
- In lines: 13-15 of the configuration file specify the background color that matches the background color used for pretraining using the following formula:
  
  R' = (R + 0.5) / 256<br>
  G' = (G + 0.5) / 256<br>
  B' = (B + 0.5) / 256<br>

  where R, G and B are the integer non-negative background color coordinates in the range 0-255.
- Run the "RaySplats" project from the Visual Studio IDE;

# RaySplatting Viewer
![image](https://github.com/user-attachments/assets/9a9d61cb-f54a-4301-8a52-4c2d0ce2cc72)
![](https://raw.githubusercontent.com/KByrski/RaySplatting/master/assets/tutorial.mp4)

This is a lightweight and user-friendly viewer for visualizing **RaySplatting** with additional user-loaded objects that support ray tracing. The viewer allows seamless integration of **OBJ** and **PLY (ASCII format)** files into the scene.  

The current material system is optimized for models designed to be **reflective** or **glass-like**, making it ideal for rendering high-quality visuals with realistic light interactions.  

## System Requirements  

To use this viewer, ensure your system meets the following requirements:  

- **Operating System**: Windows  
- **GPU**: NVIDIA RTX 20xx series or higher (**RTX 30xx+ recommended**)  
- **CUDA Version**: 12.4 or later  
- **Required DLLs**: Place the following files in the directory:  
  ```plaintext
  C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v12.4\bin
  ```
  - `cudart64_12.dll`  
  - `cufft64_11.dll`  

## Installation & Usage  

1. Download the provided **ZIP file**.  [Download ZIP](https://drive.google.com/file/d/1XPivZb6-dVtuwQ3T9UrxOF2gTTnerGhp/view?usp=sharing)
2. Extract the contents.  
3. Run the **exe file**—no additional setup required!  
4. Modify mesh properties in **mesh_config.txt**.  
5. Change the base scene by editing the **PLY file path** in `config.txt`.  

## Controls  

- Exactly the same as in the interactive Windows viewer / optimizer application.

## Future Features  

We are actively developing new features, including:  
- **Enhanced mesh transformations** (scaling, rotation, position editing beyond `mesh_config.txt`)  
- **Screenshot capture** for rendered scenes  
- **View presets** to allow seamless switching between different perspectives  
- **And much more!**  

Stay tuned for updates and improvements!





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---