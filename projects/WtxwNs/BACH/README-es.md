
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/WtxwNs/BACH/main/tokenpair.png" width="85%"/>
  <br><br>
  <i>Mira cómo BACH convierte tokens en bruto en música estructurada—paso a paso.</i>
</p>

# BACH: Asistente de Composición por IA a Nivel de Compás

<p align="center">
  <a href="https://arxiv.org/abs/2508.01394">
    <img src="https://img.shields.io/badge/arXiv-2508.01394-b31b1b.svg" alt="arXiv"/>
  </a>
  <a href="https://github.com/WtxwNs/BACH/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/WtxwNs/BACH" alt="License"/>
  </a>
  <img src="https://img.shields.io/github/repo-size/WtxwNs/BACH" alt="Repo Size"/>
  <img src="https://img.shields.io/github/stars/WtxwNs/BACH?style=social" alt="Stars"/>
</p>

&gt; *"De la partitura al rendimiento: generación eficiente de canciones largas controlable por humanos con notación simbólica a nivel de compás"*  
&gt; Envío a ICASSP 2026 – **Aceptado**

---

## 🎼 Resumen en una frase  
BACH es el primer generador de canciones simbólicas a nivel de compás **editable por humanos**:  
LLM escribe las letras → Transformer emite partitura ABC → renderizadores estándar producen música de **varios minutos, nivel Suno**.  
**1 B de parámetros**, inferencia a **nivel de minutos**, **SOTA de código abierto**.

---

## 📦 ¿Qué contiene este repositorio? (lanzamiento preliminar)
| Ruta | Descripción |
|------|-------------|
| `README.md` | Este archivo |
| `code/` | código de inferencia |
| `example.mp3` | una canción de ejemplo |
| `fig/` | Figura de arquitectura |

---

## 🏗️ Arquitectura del modelo (de un vistazo)

Solicitud del usuario  
Qwen3 — letras y etiquetas de estilo  
BACH-1B Transformer solo decodificador  
Partitura ABC (Dual-NTP + Chain-of-Score)
ABC → MIDI → FluidSynth + VOCALOID
Mezcla estéreo


| Componente | Idea clave |
|------------|------------|
| **Dual-NTP** | Predecir `{vocal_patch, accomp_patch}` conjuntamente en cada paso |
| **Chain-of-Score** | Etiquetas de sección `[START:Chorus] ... [END:Chorus]` para coherencia prolongada |
| **Bar-stream patch** | Parches de 16 caracteres no superpuestos por compás |

---

## 🧪 Inicio rápido (compatible con CPU)
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---