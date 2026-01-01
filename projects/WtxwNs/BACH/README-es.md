<p align="center">
  <img src="https://raw.githubusercontent.com/WtxwNs/BACH/main/tokenpair.png" width="85%"/>
  <br><br>
  <i>Mira cómo BACH convierte tokens crudos en música estructurada—paso a paso.</i>
</p>

# BACH: Asistente de Composición AI a Nivel de Compás  

<p align="center">
  <a href="https://arxiv.org/abs/2508.01394">
    <img src="https://img.shields.io/badge/arXiv-2508.01394-b31b1b.svg" alt="arXiv"/>
  </a>
  <a href="https://github.com/WtxwNs/BACH/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/WtxwNs/BACH" alt="Licencia"/>
  </a>
  <img src="https://img.shields.io/github/repo-size/WtxwNs/BACH" alt="Tamaño del Repo"/>
  <img src="https://img.shields.io/github/stars/WtxwNs/BACH?style=social" alt="Estrellas"/>
</p>

&gt; *"De la Partitura a la Interpretación: Generación Eficiente y Controlable por Humanos de Canciones Largas con Notación Simbólica a Nivel de Compás"*  
&gt; Envío ICASSP 2026 – **Revisión Pendiente**

---

## 🎼 Resumen en una frase  
BACH es el primer generador de canciones simbólicas **editable por humanos** y a **nivel de compás**:  
LLM escribe letras → Transformer emite partitura ABC → renderizadores disponibles producen música **de minutos de duración, al nivel de Suno**.  
**1 B parámetros**, inferencia a **nivel de minutos**, **SOTA de código abierto**.

---

## 📦 Qué hay dentro de este repositorio (versión previa)
| Ruta | Descripción |
|------|-------------|
| `README.md` | Este archivo |
| `code/` | código de inferencia |
| `example.mp3` | una canción de ejemplo |
| `fig/` | Figura de la arquitectura |

---
## 🏗️ Arquitectura del modelo (de un vistazo)

Entrada del usuario  
Qwen3 — letras y etiquetas de estilo  
Decodificador BACH-1B solo Transformer  
Puntuación ABC (Dual-NTP + Cadena de puntuación)  
ABC → MIDI → FluidSynth + VOCALOID  
Mezcla estéreo  


| Componente | Idea clave |
|------------|------------|
| **Dual-NTP** | Predecir `{vocal_patch, accomp_patch}` conjuntamente en cada paso |
| **Cadena de puntuación** | Etiquetas de sección `[START:Chorus] ... [END:Chorus]` para coherencia larga |
| **Parche bar-stream** | Parches de 16 caracteres no superpuestos por compás |

---

## 🧪 Inicio rápido (amigable con CPU)

```bash
# 1. Clone
git clone https://github.com/your-github/BACH.git
cd BACH

# 2. Install
pip install -r requirements.txt        # transformers>=4.41 mido abcpy fluidsynth

# 3. Generate ABC
python bach/generate.py \
    --prompt "A rainy-day lo-fi hip-hop song about missing the last train" \
    --out_abc demo/rainy_lofi.abc

# 4. Render audio
```

##  🎧 Escuchar ahora
example.mp3 está listo para ti, es una canción completa. Puedes compararlo con Suno🙂

## Lanzamiento completo tras la aceptación del artículo relacionado
- Conjunto de entrenamiento completo (ABC + letras + etiquetas de estructura)
- Pesos BACH-1B (formato Transformers)
- Scripts de entrenamiento (multifase + multitarea + ICL)
- Código completo

## 📎 Citación
El artículo está publicado en Arxiv, 
```bibtex
@misc{wang2025scoreperformanceefficienthumancontrollable,
      title={De la Partitura al Rendimiento: Generación Eficiente de Canciones Largas Controlables por Humanos con Notación Simbólica a Nivel de Compás}, 
      author={Tongxi Wang and Yang Yu and Qing Wang and Junlang Qian},
      year={2025},
      eprint={2508.01394},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2508.01394}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---