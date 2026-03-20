# JustDubit: Doblaje de Video mediante Difusión Audio-Visual Conjunta

[![Website](https://img.shields.io/badge/Project-Page-181717?logo=google-chrome)](https://justdubit.github.io)
[![Model](https://img.shields.io/badge/HuggingFace-Model-orange?logo=huggingface)](https://huggingface.co/justdubit/justdubit)
[![Dataset](https://img.shields.io/badge/HuggingFace-Dataset-blue?logo=huggingface)](https://huggingface.co/datasets/justdubit/audiovisual_translation_dub/settings)

## 📰 Noticias

- [2026/02/10] 🔥 Código, puntos de control y datos publicados
- [2026/01/29] 🔥 Informe técnico publicado


---

## 📄 Resumen

Los Modelos Fundamentales Audio-Visuales, que están preentrenados para generar conjuntamente contenido sonoro y visual, han demostrado recientemente una capacidad sin precedentes para modelar generación y edición multimodal, abriendo nuevas oportunidades para tareas posteriores.

Entre estas tareas, el doblaje de video podría beneficiarse enormemente de tales conocimientos previos, sin embargo, la mayoría de las soluciones existentes aún dependen de pipelines complejos y específicos de tarea que tienen dificultades en entornos reales.

En este trabajo, presentamos un enfoque de modelo único que adapta un modelo fundamental de difusión audio-video para doblaje de video a video mediante un LoRA ligero. El LoRA permite que el modelo condicione en un audio-video de entrada mientras genera conjuntamente audio traducido y movimiento facial sincronizado.

Para entrenar este LoRA, aprovechamos el propio modelo generativo para sintetizar videos multilingües emparejados del mismo hablante. Específicamente, generamos videos multilingües con cambios de idioma dentro de un solo clip, y luego retocamos la cara y el audio en cada mitad para que coincidan con el idioma de la otra mitad.

Al aprovechar el rico conocimiento generativo del modelo audio-visual, nuestro enfoque preserva la identidad del hablante y la sincronización labial mientras se mantiene robusto frente a movimientos complejos y dinámicas del mundo real. Demostramos que nuestro enfoque produce videos doblados de alta calidad con mejor fidelidad visual, sincronización labial y robustez en comparación con pipelines de doblaje existentes.

---

## 🚀 Enlaces Rápidos

| Recurso | Descripción |
|----------|-------------|
| [**Pipeline de Inferencia**](https://raw.githubusercontent.com/justdubit/just-dub-it/main/packages/ltx-pipelines/README.md) | Ejecuta el doblaje de video con el pipeline JustDubit |
| [**Guía de Entrenamiento**](https://raw.githubusercontent.com/justdubit/just-dub-it/main/packages/ltx-trainer/README.md) | Entrena tu propio LoRA de JustDubit |

---

## 📦 Estructura del Repositorio

```
just-dub-it/
├── packages/
│   ├── ltx-pipelines/     # Inference pipeline for video dubbing
│   │   └── README.md      # Pipeline usage guide
│   ├── ltx-trainer/       # Training tools for JustDubit LoRA
│   │   └── README.md      # Training guide
│   └── ltx-core/          # Core model components
└── README.md              # This file
```

---

## 🎬 Inferencia

Consulta el [README del Pipeline](https://raw.githubusercontent.com/justdubit/just-dub-it/main/packages/ltx-pipelines/README.md) para:
- Instrucciones de instalación
- Descargas de puntos de control del modelo
- Guía de formato de prompt
- Referencia de argumentos CLI

---

## 🏋️ Entrenamiento

Consulta el [README del Trainer](https://raw.githubusercontent.com/justdubit/just-dub-it/main/packages/ltx-trainer/README.md) para:
- Descarga y preparación del conjunto de datos
- Pipeline de preprocesamiento
- Configuración de entrenamiento
- Configuración para entrenamiento con múltiples GPUs




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-20

---