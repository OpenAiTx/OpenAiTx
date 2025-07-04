![image.png](https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/image.jpg)
<div align="center">
  <a href="https://github.com/AgibotTech/genie_sim">
    <img src="https://img.shields.io/badge/GitHub-grey?logo=GitHub" alt="GitHub">
  </a>
  <a href="https://huggingface.co/datasets/agibot-world/GenieSimAssets">
    <img src="https://img.shields.io/badge/HuggingFace-yellow?logo=HuggingFace" alt="HuggingFace">
  </a>
  <a href="https://agibot-world.com/sim-evaluation">
    <img src="https://img.shields.io/badge/Genie%20Sim%20Benchmark-blue?style=plastic" alt="Genie Sim Benchmark">
  </a>
  <a href="https://genie.agibot.com/en/geniestudio">
    <img src="https://img.shields.io/badge/Genie_Studio-green?style=flat" alt="Genie Studio">
  </a>
</div>

# 1. Genie Sim Benchmark
Genie Sim es el marco de simulación de AgiBot, que proporciona a los desarrolladores capacidades eficientes de generación de datos y puntos de referencia de evaluación para acelerar el desarrollo de inteligencia incorporada. Genie Sim ha establecido un flujo de trabajo cerrado y completo, que abarca la generación de trayectorias, entrenamiento de modelos, evaluación comparativa y validación de despliegue. Los usuarios pueden validar rápidamente el rendimiento de los algoritmos y optimizar los modelos a través de esta eficiente cadena de herramientas de simulación. Ya sea para tareas simples de agarre o para operaciones complejas de largo alcance, Genie Sim puede proporcionar un entorno de simulación altamente realista y métricas de evaluación precisas, permitiendo a los desarrolladores completar de manera eficiente el desarrollo y la iteración de tecnologías robóticas.

Genie Sim Benchmark, como la versión de evaluación de código abierto de Genie Sim, está dedicado a proporcionar pruebas de rendimiento precisas y soporte de optimización para modelos de IA incorporada.

# 2. Características
- Configuración de simulación flexible y fácil de usar, así como interfaz intuitiva
- Benchmarks de simulación y tareas de evaluación para más de 10 tareas de manipulación
- Capacidad de teleoperación basada en VR y teclado
- Registro y reproducción de todas las articulaciones y la pose del efector final
- Más de 550 entornos y recursos 3D de alta fidelidad y precisión física en la simulación
- Métricas de evaluación estandarizadas para cuantificar el rendimiento de modelos de IA incorporada
- Los resultados de evaluación logran menos del 5% de error de simulación a realidad en el modelo GO-1
- Soporte para modelo base UniVLA en la evaluación de simulación

# 3. Actualizaciones
- [25/6/2025] v2.1
  - Se agregan 10 tareas de manipulación adicionales para el Agibot World Challenge 2025, incluyendo todos los recursos de simulación
  - Conjunto de datos sintéticos de código abierto para 10 tareas de manipulación en Huggingface
  https://huggingface.co/datasets/agibot-world/AgiBotWorldChallenge-2025/tree/main/Manipulation-SimData
  - Integración de la política UniVLA y soporte para evaluación de inferencia de modelos en simulación
  - Actualización del SDK del solucionador IK que soporta resolución IK entre diferentes robots
  - Optimización del marco de comunicación y mejora de la velocidad de simulación en 2x
  - Actualización del marco de evaluación automática para tareas complejas de largo alcance

# 4. Contenidos

## 4.1 Introducción
Los benchmarks de simulación de inteligencia incorporada en Genie Sim están diseñados para evaluar y avanzar en el desarrollo de modelos de IA incorporada. Estos benchmarks proporcionan entornos realistas, tareas diversas y métricas estandarizadas para medir el rendimiento de los sistemas robóticos de IA, lo que reduce la necesidad de costoso hardware físico y pruebas en el mundo real, evita escenarios de prueba riesgosos y peligrosos, y acelera el proceso de entrenamiento y evaluación de los agentes de IA.

## 4.2 Primeros pasos
Por favor, consulte [esta página](https://agibot-world.com/sim-evaluation/docs/#/v2) para la instalación, guía de usuario y referencia de API

## 4.3 Soporte
<img src="https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/wechat.JPEG" width="30%"/>

## 4.4 Lista de tareas pendientes (TODO)
- [x] Publicar más tareas de manipulación de largo horizonte
- [x] Más escenas y recursos para cada tarea de evaluación
- [x] Soporte para el modelo base de Agibot World Challenge
- [ ] Kit de herramientas para generalización de disposición de escenarios y trayectorias de manipulación

## 4.5 Preguntas frecuentes (FAQ)
- ¿Cómo apagar el servidor isaac sim cuando ocurren errores que causan que el proceso no responda?
  Mata el proceso en la terminal usando `pkill -9 -f raise_standalone_sim`
- ¿Cómo elegir diferentes modos de renderizado?
  El modo de renderizado predeterminado es `RaytracedLighting(RealTime)`. Para tareas que contienen objetos transparentes, use `RealTimePathTracing(RealTime-2.0)` para la relación de perspectiva de los objetos

## 4.6 Licencia y cita
Todos los datos y el código dentro de este repositorio están bajo la Licencia Pública de Mozilla 2.0
Por favor, considere citar nuestro trabajo de cualquiera de las siguientes maneras si le ayuda en su investigación.
```
@misc{2025geniesim,
  title={GenieSim},
  author={GenieSim Team},
  year={2025},
  url={https://github.com/AgibotTech/genie_sim}
}
```

## 4.7 Referencias
1. PDDL Parser (2020). Versión 1.1. [Código fuente]. https://github.com/pucrs-automated-planning/pddl-parser.
2. BDDL. Versión 1.x.x [Código fuente]. https://github.com/StanfordVL/bddl
3. CUROBO [Código fuente]. https://github.com/NVlabs/curobo
4. Isaac Lab [Código fuente]. https://github.com/isaac-sim/IsaacLab
5. Omni Gibson [Código fuente]. https://github.com/StanfordVL/OmniGibson

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---