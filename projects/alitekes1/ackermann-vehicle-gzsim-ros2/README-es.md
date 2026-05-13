# Simulación de Vehículo con Dirección Ackermann en ROS2 con Gazebo Sim Harmonic

Este proyecto presenta la simulación de un vehículo personalizado con **capacidades de dirección Ackermann**, desarrollado usando **ROS2** y el entorno **Gazebo Sim Harmonic**. El modelo integra una variedad de sensores y herramientas de navegación para operación autónoma, siendo una de las primeras implementaciones de un vehículo con dirección Ackermann en este marco de simulación.

| **Visualización de Nube de Puntos LiDAR 3D** | **Modelo de Entorno de Almacén** |
| ----- | ----- |
| ![Nube de Puntos 3D](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/3d_lidar_pointcloud.png) | ![Modelo de Almacén](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/warehouse_environment.png) |

### ¡Si te gusta este proyecto, considera darle una ⭐ para mostrar tu apoyo!

## Tabla de Contenidos

- [Simulación de Vehículo con Dirección Ackermann en ROS2 con Gazebo Sim Harmonic](#simulación-de-vehículo-con-dirección-ackermann-en-ros2-con-gazebo-sim-harmonic)
- [Características](#características)
  - [1 Dirección Ackermann](#1-dirección-ackermann)
  - [2 Comunicación ROS2](#2-comunicación-ros2)
  - [3 Sensores](#3-sensores)
  - [4 Navegación](#4-navegación)
  - [5 Control Manual con joystick externo](#5-control-manual-con-joystick-externo)
  - [6 Visualización](#6-visualización)
- [Requisitos](#requisitos)
- [Instalación Local](#instalación-local)
- [Instalación con Docker](#instalación-con-docker)
- [Uso](#uso)
  - [1 Simulación Básica y Control Manual](#1-simulación-básica-y-control-manual)
  - [2 SLAM Localización y Mapeo Simultáneos](#2-slam-localización-y-mapeo-simultáneos)
  - [3 Navegación con Nav2](#3-navegación-con-nav2)
- [Trabajo Futuro](#trabajo-futuro)
- [Galería](#galería)
- [Árbol TF](#árbol-tf)
- [Historial de Estrellas](#historial-de-estrellas)

## Características

### 1. **Dirección Ackermann**

- Un modelo de vehículo personalizado construido con dinámica realista de dirección Ackermann para maniobrabilidad precisa.

### 2. **Comunicación ROS2**

- Todos los datos de los sensores y señales de control están completamente integrados en el ecosistema ROS2 para una interoperabilidad sin interrupciones.

### 3. **Sensores**

- **IMU**: Proporciona orientación y velocidad angular.
- **Odometría**: Garantiza una retroalimentación precisa del estado del vehículo.
- **LiDAR**: Montado para la detección de obstáculos y escaneo ambiental. Soporta la generación de nubes de puntos 3D para tareas avanzadas de percepción.
- **Cámaras**:
  - Frontal
  - Trasera
  - Lado izquierdo
  - Lado derecho
  > **Nota:** Por defecto, solo la cámara frontal está conectada a ROS 2. Si desea usar todas las cámaras (izquierda, derecha, trasera) en ROS 2, elimine el `#` al inicio de las secciones relevantes de cámara en `saye_bringup/config/ros_gz_bridge.yaml` para activarlas (por ejemplo, `/camera/left_raw`, `/camera/right_raw`, `/camera/rear_raw`).

### 4. **Navegación**

- Integrado con la **pila Nav2** para navegación autónoma.
- **AMCL (Localización Adaptativa Monte Carlo)** para una mayor precisión posicional.
- Técnicas **SLAM** implementadas para mapeo en tiempo real y comprensión del entorno.
- Parámetros ajustados para un rendimiento óptimo en la navegación.

### 5. **Control Manual (con joystick externo)**

- Soporte añadido para control manual mediante joystick en el entorno de simulación, permitiendo a los usuarios probar el movimiento del vehículo de forma interactiva.

### 6. **Visualización**

- Visualización completa del modelo y datos de sensores en **RViz2**, proporcionando información sobre estados del robot y retroalimentación ambiental.

## Requisitos

- **ROS2 (Humble)**
- **Gazebo Sim Harmonic**
- **RViz2**
- **Nav2**

## Instalación Local

0. Debe asegurarse de que la instalación de Gazebo Harmonic y ROS (ros_gz) esté realizada:<br>
   `sudo apt-get install ros-${ROS_DISTRO}-ros-gz`<br>
   `sudo apt-get install ros-humble-ros-gzharmonic` (Solo versión Humble)<br>
   Más detalles sobre la instalación de Gazebo y ROS: <a href="https://gazebosim.org/docs/latest/ros_installation/">Enlace</a>
1. Clonar el repositorio:<br>
   `mkdir -p ackermann_sim/src && cd ackermann_sim/src`<br>
   `git clone https://github.com/alitekes1/ackermann-vehicle-gzsim-ros2`<br>`cd ..`
2. Compilar el proyecto:
   `colcon build && source install/setup.bash`
3. Configurar las variables de entorno:
   ```bash
   # Set environment variables for current session
   export GZ_SIM_RESOURCE_PATH=$GZ_SIM_RESOURCE_PATH:/your/path/ackermann_sim/src/ackermann-vehicle-gzsim-ros2/
   export ROS_PACKAGE_PATH=$ROS_PACKAGE_PATH:/your/path/ackermann_sim/src/ackermann-vehicle-gzsim-ros2/
   ```

   **Para configuración permanente:**
   
   Para hacer que estas variables de entorno sean permanentes, agréguelas a su archivo `.bashrc`:
   ```bash
   # Add environment variables to .bashrc
   echo 'export GZ_SIM_RESOURCE_PATH=$GZ_SIM_RESOURCE_PATH:/your/path/ackermann_sim/src/ackermann-vehicle-gzsim-ros2/' >> ~/.bashrc
   echo 'export ROS_PACKAGE_PATH=$ROS_PACKAGE_PATH:/your/path/ackermann_sim/src/ackermann-vehicle-gzsim-ros2/' >> ~/.bashrc
   
   # Apply changes
   source ~/.bashrc
   ```

   > **Nota:** Reemplace `/your/path/` con la ruta real de su instalación.

## Instalación con Docker

También puede ejecutar la simulación usando Docker, lo que garantiza un entorno consistente en diferentes sistemas.

### Requisitos previos
- Docker
- NVIDIA Container Toolkit (para soporte GPU)

### Pasos para ejecutar con Docker

1. Clonar el repositorio:
   ```bash
   mkdir -p ackermann_sim/src && cd ackermann_sim/src
   git clone https://github.com/alitekes1/ackermann-vehicle-gzsim-ros2
   cd ackermann-vehicle-gzsim-ros2
   ```

2. Construya y ejecute el contenedor de Docker:
   ```bash
      docker run -it \
      --name ackermann_sim \
      --hostname ackermann_sim \
      --env="DISPLAY=$DISPLAY" \
      --env="QT_X11_NO_MITSHM=1" \
      --volume="/tmp/.X11-unix:/tmp/.X11-unix:rw" \
      --privileged alitekes1/ackermann_sim:latest
   ```
3. Si desea un terminal adicional para el mismo contenedor

   ```bash
      docker exec -it ackermann_sim bash
   ```
   
> **Nota:** Dentro del contenedor, puedes ejecutar los comandos de simulación con normalidad.

## Uso

### 1. Simulación básica y control manual

1.  Inicia la simulación:

    ```bash
    ros2 launch saye_bringup saye_spawn.launch.py
    ```
2.  Control del coche:
    ```bash
    ros2 run teleop_twist_keyboard teleop_twist_keyboard
    ```

### 2. SLAM (Localización y Mapeo Simultáneos)

-   Para ejecutar SLAM Toolbox para el mapeo, inicie lo siguiente después de comenzar la simulación:
    ```bash
    ros2 launch saye_bringup slam.launch.py
    ```
    [![SLAM- Youtube](https://img.youtube.com/vi/QWcJ9TlqFOU/0.jpg)](https://www.youtube.com/watch?v=QWcJ9TlqFOU "Proje Tanıtımı")

### 3. Navegación con Nav2

-   Para ejecutar la simulación con el paquete Nav2 para navegación autónoma, inicie lo siguiente después de arrancar la simulación:
    ```bash
    ros2 launch saye_bringup navigation_bringup.launch.py
    ```
    [![Navegación Autónoma - Youtube](https://img.youtube.com/vi/SJ4NrbdlNZo/0.jpg)](https://www.youtube.com/watch?v=SJ4NrbdlNZo "NAV2")

> **Nota:** Los videos de YouTube arriba se reproducen a 4x de velocidad. Puedes acceder a los videos haciendo clic en las imágenes.

## Trabajo Futuro

1. **Soporte SLAM 3D:**
   - Entrenar el vehículo para manejar escenarios complejos de forma autónoma usando algoritmos avanzados de DRL.
2. **Características Mejoradas:**
   - Explorar configuraciones adicionales de sensores y estrategias de navegación.
3. **Integración de Nav2 con Localización 3D**
   - En lugar de AMCL(2D), implementación de algoritmos más precisos y robustos.
## Galería

![Captura de pantalla de 2024-09-23 00-09-48.png](https://github.com/user-attachments/assets/dd5604c6-014e-4a7a-9a2f-c4dd237abb37)

### Nube de Puntos LiDAR 3D y Entorno

| **Visualización de Nube de Puntos LiDAR 3D**                      | **Modelo del Entorno del Almacén**                               |
| ----------------------------------------------------------------- | ---------------------------------------------------------------- |
| ![Nube de Puntos 3D](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/3d_lidar_pointcloud.png) | ![Modelo del Almacén](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/warehouse_environment.png) |

### Vehículo y Navegación

| **Simulación Gazebo Harmónica**                                                                                             | **RViz2**                                                                                                                   |
| --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- |
| ![Captura de pantalla de 2024-09-23 00-13-03.png](https://github.com/user-attachments/assets/1d2b56f7-34c1-4b01-9a85-fb01ceab5bd6) | ![Captura de pantalla de 2024-09-23 00-09-04.png](https://github.com/user-attachments/assets/ba6853fd-4143-4b4d-bbc6-072895e4c75e) |
| ![Captura de pantalla de 2024-09-23 00-12-13.png](https://github.com/user-attachments/assets/477cce7b-995b-471e-a684-4d82bee0fc34) | ![Captura de pantalla de 2024-09-23 00-15-04.png](https://github.com/user-attachments/assets/bf9ad916-14a6-4b62-a799-4169a767e4dd) |
| ![texto alternativo](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/saye.png)                                                                                         | ![texto alternativo](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/rviz_saye.png)                                                                                    |

## Árbol TF

![Árbol TF](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/frames.png)

---

## Historial de Estrellas

<a href="https://www.star-history.com/#alitekes1/ackermann-vehicle-gzsim-ros2&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=alitekes1/ackermann-vehicle-gzsim-ros2&type=Date" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=alitekes1/ackermann-vehicle-gzsim-ros2&type=Date" />
   <img alt="Gráfico de Historial de Estrellas" src="https://api.star-history.com/svg?repos=alitekes1/ackermann-vehicle-gzsim-ros2&type=Date" />
 </picture>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-13

---