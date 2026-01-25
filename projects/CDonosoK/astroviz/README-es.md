# 🚀 AstroViz 🚀

<img src="https://github.com/hucebot/astroviz/blob/main/images/AstroViz.png" alt="Imagen de AstroViz" width="800" height="500">

[![Licencia](https://img.shields.io/badge/License-MIT--Clause-blue.svg)](https://opensource.org/licenses/MIT)
[![Versión ROS2](https://img.shields.io/badge/ROS-Humble-green)](https://docs.ros.org/en/humble/index.html)

AstroViz es la suite definitiva de visualización de datos en tiempo real para misiones robóticas con ROS 2. Construido desde cero para ofrecer flexibilidad, claridad y rendimiento, AstroViz capacita a roboticistas, ingenieros y operadores de campo con una interfaz unificada para monitorear, controlar y depurar sistemas complejos en tiempo real.

- 🌍 Visualización todo en uno: Desde GPS y LiDAR hasta transmisiones de cámaras, estado del robot y salud de motores, AstroViz integra múltiples vistas en una interfaz gráfica moderna y cohesiva.
- ⚡ Alto rendimiento: Despliegue basado en Docker con soporte GPU que garantiza operación fluida incluso en entornos con datos intensivos.
- 🛰️ Comprobado en campo: Ya sea que estés lanzando vehículos autónomos, drones o robots terrestres, AstroViz es tu centro de comando visual.

💡 ¿Buscas una herramienta ROS 2 que vaya más allá de los datos crudos y te ayude a tomar decisiones en tiempo real en campo?
<b>AstroViz está construido para eso.</b>

## Vista general visual
<table>
  <tr>
    <td colspan="2" align="center">
      <strong>VISOR DEL PANEL DE CONTROL</strong><br>
      <img src="https://github.com/hucebot/astroviz/blob/main/images/dashboard.gif" alt="Resumen de teleoperación" width="800">
    </td>
  </tr>
</table>

Para una vista detallada de todas las ventanas implementadas, consulte: [ventanas implementadas](https://raw.githubusercontent.com/CDonosoK/astroviz/main/WINDOWS_IMPLEMENTED.md)


## Tabla de Contenidos
1. [Primeros Pasos](#get-started)
   - [Prerrequisitos](#prerequisites)
   - [Instalación](#installation)
      - [Clonar el Repositorio](#clone-the-repository)
      - [Compilar usando Docker](#build-using-docker)
      - [Ejecutar el Contenedor Docker](#run-the-docker-container)
2. [Uso](#usage)
   - [Resumen de Nodos](#node-overview)
   - [Ejecutando Nodos](#running-nodes)
3. [Mantenedor](#maintainer)
3. [Licencia](#license)

---

## Comenzar
### Requisitos previos

Para ejecutar este paquete, asegúrese de que las siguientes dependencias estén instaladas:
- **Git**: Para el control de versiones y la gestión del repositorio.
- **Docker**: Para simplificar la configuración y ejecución del entorno.
- **NVIDIA Container Toolkit** (si usa una GPU NVIDIA): Para la aceleración por hardware.


### Instalación

#### Clonar el repositorio
Comience clonando el repositorio:
```bash
git clone git@github.com:hucebot/astroviz.git
```

#### Construir Usando Docker
Este repositorio incluye una configuración de Docker preconfigurada para un despliegue sencillo. Para construir la imagen de Docker:
1. Navega al directorio `docker`:
   ```bash
   cd astroviz/docker
   ```
2. Ejecuta el script de compilación:
   ```bash
   sh build.sh
   ```
   Esto creará una imagen de Docker llamada `astroviz`.

#### Ejecutar el Contenedor de Docker
Una vez construido, inicie el contenedor usando:
```bash
sh run.sh
```
---

## Uso
### Descripción General de Nodos

Este paquete contiene nodos diseñados para facilitar la teleoperación y visualización de datos. Cada nodo cumple un propósito específico en el flujo de trabajo de teleoperación:
- **gpsmap_viewer**: Visualiza datos GPS en un mapa.
- **camera_viewer**: Muestra la transmisión de la cámara del robot.
- **imu_viewer**: Visualiza datos del IMU.
- **lidar_viewer**: Visualiza datos del LiDAR.
- **teleoperation_viewer**: Proporciona una GUI para el control de teleoperación.
- **dashboard_viewer**: Un panel integral que integra varios flujos de datos y ofrece una interfaz unificada para monitoreo y control.
- **plot_viewer**: Muestra gráficos en tiempo real de varios flujos de datos.
- **grid_map_viewer**: Visualiza datos de mapas en cuadrícula para navegación y planificación.
- **robot_state_viewer**: Muestra el estado actual del robot relacionado con las posiciones articulares y transformaciones.
- **motor_state_viewer**: Monitorea y visualiza el estado de los motores del robot, incluyendo lecturas de temperatura y voltaje.
- **record_manager_viewer**: Administra y visualiza sesiones de grabación, permitiendo a los usuarios iniciar, detener y revisar grabaciones.

### Ejecución de Nodos
Para ejecutar los nodos, puede usar el siguiente comando:
```bash
ros2 run astroviz <node_name>
```
Reemplace `<node_name>` con el nombre del nodo que desea ejecutar, como `gps_map_viewer`, `camera_viewer`, etc.

O si prefiere ejecutar el visor del panel, que integra todas las funcionalidades:
```bash
ros2 launch astroviz dashboard_launcher.launch.py
```

## Mantenedor
Este paquete es mantenido por:

**Clemente Donoso**  
Correo electrónico: [clemente.donoso@inria.fr](https://raw.githubusercontent.com/CDonosoK/astroviz/main/mailto:clemente.donoso@inria.fr)
GitHub: [CDonosoK](https://github.com/CDonosoK)  

---

## Licencia
Este proyecto está licenciado bajo la **MIT**. Consulte el archivo [LICENSE](LICENSE) para más detalles.

---
¡Las contribuciones y comentarios son bienvenidos! Si encuentra algún problema o tiene sugerencias para mejoras, no dude en abrir un issue o enviar un pull request.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-25

---