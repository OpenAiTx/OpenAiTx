# 🤖 ros2-dockergen

<p align="center">
  <a href="https://github.com/ppswaroopa/ros2-dockergen/actions/workflows/ci.yml"><img src="https://github.com/ppswaroopa/ros2-dockergen/actions/workflows/ci.yml/badge.svg" alt="CI"></a>
  <a href="https://github.com/ppswaroopa/ros2-dockergen/actions/workflows/publish.yml"><img src="https://github.com/ppswaroopa/ros2-dockergen/actions/workflows/publish.yml/badge.svg" alt="Publish to PyPI"></a>
  <a href="https://pypi.org/project/ros2-dockergen/"><img src="https://img.shields.io/pypi/v/ros2-dockergen.svg" alt="PyPI version"></a>
  <a href="LICENSE"><img src="https://img.shields.io/badge/License-MIT-yellow.svg" alt="License: MIT"></a>
  <a href="https://www.python.org/downloads/"><img src="https://img.shields.io/badge/python-3.10+-blue.svg" alt="Python 3.10+"></a>
  <a href="https://ppswaroopa.github.io/ros2-dockergen/"><img src="https://img.shields.io/badge/Web-Interactive_UI-00ff88.svg" alt="Web UI"></a>
</p>

<br />
<p align="center">
  <img src="https://raw.githubusercontent.com/ppswaroopa/ros2-dockergen/main/docs/hero.png" alt="ROS2 DockerGen Flow" width="100%">
</p>
<br />

> **Un comando. Interactivo. Sin complicaciones.**  
> Genera `Dockerfile` + `docker-compose.yml` + `README.md` listos para producción para cualquier proyecto ROS2 — directamente desde tu terminal o en la [página web](https://ppswaroopa.github.io/ros2-dockergen/) aquí

---

## Instalación rápida

### Desde PyPI (Recomendado)
```bash
pip install ros2-dockergen
```
### Instalador de una línea (Bash)

```bash
curl -fsSL https://raw.githubusercontent.com/ppswaroopa/ros2-dockergen/main/install.sh | bash
```

---

## Características

- **Soporte Completo de Distribuciones**: Elija entre las distribuciones ROS2 **Jazzy**, **Humble** y **Kilted**.
- **Aceleración por GPU**: Configura automáticamente las imágenes base `nvidia/cuda` y las capacidades de ejecución si se selecciona CUDA o TensorRT.
- **Elección del Usuario**: Maneja la creación de **usuario no root** con asignación automática de UID/GID para evitar problemas de permisos en volúmenes del host.
- **Herramientas Integrales**: Active paquetes comunes de ROS2 (Nav2, MoveIt2, SLAM Toolbox, MoveIt, Gazebo GZ, etc.) y herramientas de desarrollo (colcon, rosdep, Oh-My-Zsh, SSH, X11).
- **Salida Completa**: Genera no solo un `Dockerfile`, sino también un `docker-compose.yml` correspondiente y un `README.md` específico del espacio de trabajo con instrucciones.
- **Paridad Web**: Motor lógico idéntico compartido con la [Interfaz Web](https://ppswaroopa.github.io/ros2-dockergen/).

---

## Uso

Simplemente ejecute:
```bash
ros2-dockergen
```
El asistente interactivo le guiará a través de 8 pasos para configurar su entorno.

### Opciones de línea de comandos
```bash
ros2-dockergen --help    # Show help
ros2-dockergen --version # Show version
```
---

## CI Local con `act`

Para reproducir el flujo de trabajo principal de GitHub Actions localmente, instale [`act`](https://nektosact.com/installation/) y ejecute:

```bash
./scripts/run_act.sh
```

Por defecto, esto ejecuta los trabajos de CI uno por uno para que el uso local de Docker sea manejable y la salida de cada trabajo sea fácil de leer.

Si quieres el comportamiento original de flujo completo de `act`, ejecuta:

```bash
./scripts/run_act.sh full
```

---

## 📁 Estructura del Proyecto

- `src/ros2_dockergen/`: Paquete principal de Python (CLI + Lógica).
- `src/core.js`: Motor compartido (ESM) para Web y Node.js.
- `index.html`: Generador interactivo impresionante basado en navegador.
- `docs/`: Recursos visuales y documentación del proyecto.
- `tests/`: Suite de validación de paridad (Garantiza que las salidas Python/JS sean idénticas a nivel de bytes).

---

## 🔗 Recursos Relacionados

- [Utilidad Web](https://ppswaroopa.github.io/ros2-dockergen/)
- [Documentación Oficial de ROS](https://docs.ros.org)
- [OSRF ROS Docker Hub](https://hub.docker.com/r/osrf/ros)

---

## Licencia

Publicado bajo la [Licencia MIT](LICENSE).  
Copyright © 2026 Pranava Swaroopa.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-18

---