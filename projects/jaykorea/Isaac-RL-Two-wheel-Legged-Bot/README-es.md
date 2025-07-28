# Isaac LAB para Flamingo

[![IsaacSim](https://img.shields.io/badge/IsaacSim-4.5-silver.svg)](https://docs.omniverse.nvidia.com/isaacsim/latest/overview.html)
[![IsaacLab](https://img.shields.io/badge/Lab-2.0.0-silver)](https://isaac-orbit.github.io/orbit/)
[![Python](https://img.shields.io/badge/python-3.10-blue.svg)](https://docs.python.org/3/whatsnew/3.10.html)
[![Linux platform](https://img.shields.io/badge/platform-linux--64-orange.svg)](https://releases.ubuntu.com/20.04/)
[![pre-commit](https://img.shields.io/badge/pre--commit-enabled-brightgreen?logo=pre-commit&logoColor=white)](https://pre-commit.com/)
[![License](https://img.shields.io/badge/license-MIT-yellow.svg)](https://opensource.org/license/mit)

## **✨ Nuevas características - Actualizado 🚀**
✔️ **Flamingo rev.0.1.4**: Añadida la última versión de Flamingo.  
✔️ **Flamingo Edu v1**: Añadida la versión Flamingo Edu.  
✔️ **Entorno de Pila**: Las observaciones pueden apilarse con argumentos.  
✔️ **Gestor de Restricciones**: Añadida la implementación del método [Restricciones como Terminación (CaT)](https://arxiv.org/abs/2403.18765).  
✔️ **CoRL**: Basado en la librería [rsl_rl](https://github.com/leggedrobotics/rsl_rl), se implementan algoritmos off-policy en `off_policy_runner`.  

## Sim2Real - Transferencia ZeroShot
<table>
    <td><img src="https://github.com/user-attachments/assets/bb14612c-85c2-43ce-a7df-8b09ee4d3f69" width="800" height="400"/></td>
</table>
<table>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/8f9f990d-e8e9-400a-82b2-1131ff73f891" width="385" height="170"/></td>
    <td><img src="https://github.com/user-attachments/assets/93c6b187-4680-435e-800a-9e6d3d570d13" width="385" height="170"/></td>
  </tr>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/9991ff73-5b3e-4d10-9b63-548197f18e54" width="385" height="170"/></td>
    <td><img src="https://github.com/user-attachments/assets/545fd258-1add-499a-8c62-520e113a951b" width="385" height="170"/></td>
  </tr>
</table>


## Isaac Lab Flamingo
<table>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/0037889b-bab7-4686-a9a5-46ea9bbe6ac2" width="385" height="240"/></td>
    <td><img src="https://github.com/user-attachments/assets/16d8d025-7e57-479a-80d4-9cfef2cf9b6b" width="385" height="240"/></td>
  </tr>
</table>

## Marco Sim 2 Sim - Lab a MuJoCo
<table>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/edcc4077-e082-4fce-90a6-b10c94869aad" width="385" height="240"/></td>
    <td><img src="https://github.com/user-attachments/assets/df58b2db-00c6-4228-a953-eb605dee2797" width="385" height="240"/></td>
  </tr>
</table>

- El marco de Simulación a Simulación está disponible en la rama sim2sim_onnx (Actualmente en actualización de migración)
- Puedes simplemente inferir la política entrenada (básicamente exportar como .onnx desde isaac lab)

## Configuración
- Este repositorio está probado en Ubuntu 20.04, y recomiendo instalar 'instalación local'
### 1. Instalar Isaac Sim
  ```
  https://isaac-sim.github.io/IsaacLab/main/source/setup/installation/binaries_installation.html
  ```
### 2. Instalar Isaac Lab
  ```
  https://github.com/isaac-sim/IsaacLab
  ```

### 3. Instalar el paquete lab.flamingo
i. clonar el repositorio
   ```
   git clone https://github.com/jaykorea/Isaac-RL-Two-wheel-Legged-Bot
   ```
ii. instale el paquete pip lab.flamingo ejecutando el siguiente comando
   - ejecútelo en la ruta raíz de 'lab.flamingo'
   ```
   conda activate env_isaaclab # change to you conda env
   pip install -e .
   ```
iii. Descomprimir assets (archivo usd) en la carpeta
   - Dado que git no sube correctamente el archivo '.usd', debe descomprimir manualmente los archivos usd en la carpeta de assets
   ```
    path example: lab/flamingo/assets/data/Robots/Flamingo/flamingo_rev01_4_1/
   ```

## Script de lanzamiento
### Entrenar flamingo
  - ejecútalo en la ruta raíz 'lab.flamingo'
  ```
    python scripts/co_rl/train.py --task {task name} --algo ppo --num_envs 4096 --headless --num_policy_stacks {stack number on policy obs} --num_critic_stacks {stack number on critic obs}
  ```
### Ejemplo de entrenamiento - velocidad en pista
  ```
    python scripts/co_rl/train.py --task Isaac-Velocity-Flat-Flamingo-v1-ppo --algo ppo --num_envs 4096 --headless --num_policy_stacks 2 --num_critic_stacks 2
  ```
### jugar flamenco
  - ejecútalo en la ruta raíz 'lab.flamingo'
  ```
    python scripts/co_rl/play.py --task {task name} --algo ppo --num_envs 64 --num_policy_stacks {stack number on policy obs} --num_critic_stacks {stack number on critic obs} --load_run {folder name} --plot False
  ```
### ejemplo de reproducción - velocidad de la pista
  ```
    python scripts/co_rl/play.py --task Isaac-Velocity-Flat-Flamingo-Play-v1-ppo --algo ppo --num_envs 64 --num_policy_stacks {stack number on policy obs} --num_critic_stacks {stack number on critic obs} --load_run 2025-03-16_17-09-35 --plot False
  ```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---