# RaySplats: Splatting Gaussiano basado en Trazado de Rayos
Krzysztof Byrski, Marcin Mazur, Jacek Tabor, Tadeusz Dziarmaga, Marcin Kądziołka, Dawid Baran, Przemysław Spurek <br>

| arXiv |
| :---- |
| RaySplats: Splatting Gaussiano basado en Trazado de Rayos [https://arxiv.org/pdf/2501.19196.pdf](http://arxiv.org/abs/2501.19196)|

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

# Características
- Soporte para armónicos esféricos hasta el grado **4**.
- Aplicación interactiva para Windows de visor / optimizador que permite previsualizar el estado del modelo entrenado en tiempo real.
- Soporte para el formato de salida de modelo entrenado **PLY**.
- Renderizador Gaussiano puro altamente eficiente (sin aproximación embebida de malla primitiva).
- Optimizador altamente configurable basado en un cómodo archivo de configuración de texto.
- Soporte para conjuntos de datos tanto de **Blender** como de **COLMAP** (después de cierto preprocesamiento por el 3DGS).
- Evaluación integrada del modelo y visualización a archivo *.bmp con frecuencia configurable.

# Controles en la aplicación interactiva para Windows de visor / optimizador

<img src="https://raw.githubusercontent.com/KByrski/RaySplatting/master/assets/app_main_window.png">

- **Doble clic izquierdo**: Cambiar entre la **cámara estática** y el modo de **movimiento libre**.
- **Movimiento del ratón**: Rotar la cámara en el modo de **movimiento libre**.
- **W / S**: Mover hacia adelante / hacia atrás.
- **A / D**: Paso a la izquierda / derecha.  
- **Barra espaciadora / C**: Mover hacia arriba / abajo.  
- **[ / ]**: Cambiar la cámara a la pose de entrenamiento anterior / siguiente.  
- **Imprimir pantalla**: Tomar captura de pantalla y guardarla en un archivo *.bmp de 24 bits.  

# Requisitos previos:  

- Visual Studio 2019 Enterprise;  
- CUDA Toolkit 12.4.1;  
- NVIDIA OptiX SDK 8.0.0;  

# Construcción de la aplicación interactiva de visor / optimizador para Windows  

- Crear un nuevo proyecto de Aplicación de Escritorio Windows y nombrarlo "RaySplats";  
- Eliminar el archivo RaySplats.cpp recién generado que contiene la plantilla de código;  
- En **Dependencias de compilación** -> **Personalizaciones de compilación...** seleccionar la casilla que corresponda con la versión de CUDA instalada. En nuestro sistema de prueba, tuvimos que seleccionar la siguiente casilla:  

  **CUDA 12.4(.targets, .props)**  
  
- Agregar todos los archivos del directorio "RaySplats" al proyecto;  
- En las Propiedades del proyecto, configurar **Configuración** en **"Release"** y **Plataforma** en **"x64"**;  
- En **Propiedades** -> **Propiedades de configuración** -> **CUDA C/C++** -> **Común** -> **Generar código de dispositivo reubicable** seleccionar **Sí (-rdc=true)**;  
- Para el archivo "shaders.cuh" en **Propiedades** -> **Propiedades de configuración** -> **General** -> **Tipo de elemento** seleccionar **"CUDA C/C++"**;  
- Para los archivos: "shaders.cuh", "shaders_SH0.cu", "shaders_SH1.cu", "shaders_SH2.cu", "shaders_SH3.cu" y "shaders_SH4.cu" en **Propiedades** -> **Propiedades de configuración** -> **CUDA C/C++** -> **Común**:  
  - Cambiar el sufijo de **Salida del compilador (obj/cubin)** de **".obj"** a **".ptx"**;  
  - En **Generar código de dispositivo reubicable** seleccionar **No**;  
  - En **Tipo de compilación NVCC** seleccionar **Generar archivo .ptx solo dispositivo (-ptx)"**;  
- En **Propiedades** -> **Propiedades de configuración** -> **Directorios VC++** -> **Directorios de inclusión** añadir la ruta del directorio "include" de OptiX. En nuestro sistema de prueba, tuvimos que añadir la siguiente ruta:
  ```plaintext
  "C:\ProgramData\NVIDIA Corporation\OptiX SDK 8.0.0\include"
  ```
- En **Propiedades** -> **Propiedades de configuración** -> **CUDA C/C++** -> **Dispositivo** -> **Generación de código** escriba la capacidad de cómputo y la versión de microarquitectura de su GPU. En nuestro sistema de prueba con GPU RTX 4070 escribimos:
  ```plaintext
  "compute_89,sm_89"
  ```
- En **Propiedades** -> **Propiedades de configuración** -> **Vinculador** -> **Entrada** -> **Dependencias adicionales** agregue tres nuevas líneas que contengan:
  ```plaintext
  "cuda.lib"
  ```
  ```plaintext
  "cudart.lib"
  ```
  ```plaintext
  "cufft.lib"
  ```
- En cada uno de dos bloques de código diferentes en el archivo InitializeOptiXRenderer.cu:
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
  reemplace la ruta proporcionada con la ruta a los archivos de sombreado compilados *.ptx en su disco duro.

# Entrenando tu primer modelo (conjunto de datos Blender):

- Entrena el modelo con 3DGS por un pequeño número de iteraciones (por ejemplo 100) en algún conjunto de datos de Blender (por ejemplo: "lego" del conjunto "NeRF synthetic");
- Convierte todos los archivos en los subdirectorios: "train" y "test" ubicados en el directorio principal del conjunto de datos a formato de archivo *.bmp de 24 bits sin cambiar sus nombres;
- Copia el archivo de configuración "config.txt" al directorio principal del proyecto. En nuestro sistema de prueba lo copiamos al siguiente directorio:
  ```plaintext
  "C:\Users\<Windows username>\source\repos\RaySplats\RaySplats"
  ```
- En las líneas: 4 y 5 del archivo de configuración, especifique la ubicación del directorio principal del conjunto de datos y el archivo 3DGS *.ply de salida obtenido después del preentrenamiento corto del modelo (**¡Importante!** El grado de armónicos esféricos utilizado para el preentrenamiento y el objetivo especificado en la línea 7 del archivo de configuración no tienen que coincidir);
- En las líneas: 13-15 del archivo de configuración, especifique el color de fondo que coincida con el color de fondo usado para el preentrenamiento utilizando la siguiente fórmula:
  
  R' = (R + 0.5) / 256<br>
  G' = (G + 0.5) / 256<br>
  B' = (B + 0.5) / 256<br>

  donde R, G y B son las coordenadas enteras no negativas del color de fondo en el rango 0-255.
- Ejecute el proyecto "RaySplats" desde el IDE de Visual Studio;

# Visor RaySplatting
![imagen](https://github.com/user-attachments/assets/9a9d61cb-f54a-4301-8a52-4c2d0ce2cc72)
![](https://raw.githubusercontent.com/KByrski/RaySplatting/master/assets/tutorial.mp4)

Este es un visor ligero y fácil de usar para visualizar **RaySplatting** con objetos adicionales cargados por el usuario que soportan trazado de rayos. El visor permite la integración fluida de archivos **OBJ** y **PLY (formato ASCII)** en la escena.  

El sistema de materiales actual está optimizado para modelos diseñados para ser **reflectantes** o **tipo vidrio**, lo que lo hace ideal para renderizar visuales de alta calidad con interacciones realistas de la luz.  

## Requisitos del sistema  

Para usar este visor, asegúrese de que su sistema cumpla con los siguientes requisitos:  

- **Sistema Operativo**: Windows  
- **GPU**: NVIDIA RTX serie 20xx o superior (**se recomienda RTX 30xx+**)  
- **Versión CUDA**: 12.4 o posterior  
- **DLLs requeridas**: Coloque los siguientes archivos en el directorio:  
  ```plaintext
  C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v12.4\bin
  ```
  - `cudart64_12.dll`  
  - `cufft64_11.dll`  

## Instalación y Uso  

1. Descargue el **archivo ZIP** proporcionado.  [Descargar ZIP](https://drive.google.com/file/d/1XPivZb6-dVtuwQ3T9UrxOF2gTTnerGhp/view?usp=sharing)
2. Extraiga el contenido.  
3. Ejecute el **archivo exe**—¡no se requiere configuración adicional!  
4. Modifique las propiedades de la malla en **mesh_config.txt**.  
5. Cambie la escena base editando la **ruta del archivo PLY** en `config.txt`.  

## Controles  

- Exactamente iguales que en la aplicación interactiva de visualización/optimización para Windows.

## Funciones Futuras  

Estamos desarrollando activamente nuevas funciones, incluyendo:  
- **Transformaciones mejoradas de la malla** (escalado, rotación, edición de posición más allá de `mesh_config.txt`)  
- **Captura de pantalla** para escenas renderizadas  
- **Preajustes de vista** para permitir cambiar sin problemas entre diferentes perspectivas  
- **¡Y mucho más!**  

¡Esté atento a actualizaciones y mejoras!





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---