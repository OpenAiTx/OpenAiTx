# 🎶 ThinkSound

<p align="center">
  ¡Si encuentras útil este proyecto, una estrella ⭐ en GitHub sería muy apreciada!
</p>

<p align="center">
  <a href="https://arxiv.org/pdf/2506.21448">
    <img src="https://img.shields.io/badge/arXiv-2506.21448-b31b1b.svg" alt="arXiv"/>
  </a>
  &nbsp;
  <a href="https://thinksound-project.github.io/">
    <img src="https://img.shields.io/badge/Online%20Demo-🌐-blue" alt="Online Demo"/>
  </a>
  &nbsp;
  <a href="https://huggingface.co/spaces/FunAudioLLM/ThinkSound">
    <img src="https://img.shields.io/badge/HuggingFace-Spaces-orange?logo=huggingface" alt="Hugging Face"/>
  </a>
  &nbsp;
  <a href="https://modelscope.cn/studios/iic/ThinkSound">
    <img src="https://img.shields.io/badge/ModelScope-在线体验-green" alt="ModelScope"/>
  </a>
</p>

---

**ThinkSound** es un framework unificado de generación Any2Audio con flujo de emparejamiento guiado por razonamiento de Cadena de Pensamiento (Chain-of-Thought, CoT).

Implementación en PyTorch para generación y edición de audio multimodal: genera o edita audio a partir de video, texto y audio, impulsado por razonamiento paso a paso desde Modelos Multimodales de Lenguaje a Gran Escala (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Noticias
- **2025.07** &nbsp; 🔥¡Demo en línea disponible en [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) y [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) para experiencia interactiva!
- **2025.07** &nbsp; 🔥Publicados scripts de inferencia e interfaz web;
- **2025.06** &nbsp; 🔥¡Artículo de [ThinkSound](https://arxiv.org/pdf/2506.21448) publicado en arXiv!
- **2025.06** &nbsp; 🔥[Demo en línea](http://thinksound-project.github.io/) disponible - ¡pruébalo ahora!

---

## 🚀 Características

- **Any2Audio**: Genera audio desde cualquier modalidad — video, texto, audio o sus combinaciones.
- **Video-a-Audio SOTA**: Alcanza resultados de última generación en múltiples benchmarks V2A.
- **Razonamiento impulsado por CoT**: Razonamiento de Cadena de Pensamiento para generación de audio composicional y controlable mediante MLLMs.
- **Edición interactiva centrada en objetos**: Refina o edita eventos sonoros específicos haciendo clic en objetos visuales o usando instrucciones de texto.
- **Framework unificado**: Un solo modelo base soporta generación, edición y flujo de trabajo interactivo.

---

## ✨ Descripción del Método

ThinkSound descompone la generación y edición de audio en tres etapas interactivas, todas guiadas por razonamiento CoT basado en MLLM:

1. **Generación Foley:** Genera paisajes sonoros fundamentales, alineados semántica y temporalmente desde video.
2. **Refinamiento centrado en objetos:** Refina o añade sonidos para objetos especificados por el usuario mediante clics o regiones en el video.
3. **Edición de audio dirigida:** Modifica el audio generado usando instrucciones en lenguaje natural de alto nivel.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Un conjunto de datos a gran escala anotado con CoT (**AudioCoT**) se utiliza para entrenar tanto el módulo de razonamiento como el modelo base unificado de audio.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Inicio Rápido

**Preparación del entorno:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
pip install -r requirements.txt
conda install -y -c conda-forge 'ffmpeg<7'
# Descargar los pesos preentrenados https://huggingface.co/liuhuadai/ThinkSound al directorio ckpts/
# los pesos del modelo también pueden descargarse desde https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
```

**Hazlo ejecutable**
```bash
chmod +x scripts/demo.sh
```

**Ejecuta el script**
```bash
./scripts/demo.sh <video_path> <caption> <CoT description>
```


### Uso de la Interfaz Web

Para una experiencia interactiva, inicia la interfaz web Gradio:

```bash
python app.py
```

---
## 📝 TODO

- ☐ Publicar los scripts de entrenamiento para los modelos ThinkSound
- ☐ Liberar el conjunto de datos AudioCoT y la canalización automatizada
- ☐ Proporcionar documentación detallada y referencia de la API
- ☐ Añadir soporte para modalidades adicionales y tareas posteriores

---

## 📄 Licencia

Este proyecto se publica bajo la [Licencia Apache 2.0](LICENSE).

> **Nota:**  
> El código, los modelos y el conjunto de datos son **solo para fines de investigación y educativos**.  
> **No se permite el uso comercial.**
>
> Para licencias comerciales, por favor contacte a los autores.

---

## 📖 Citación

Si encuentra útil ThinkSound en su investigación o trabajo, cite nuestro artículo:

```bibtex
@misc{liu2025thinksoundchainofthoughtreasoningmultimodal,
      title={ThinkSound: Chain-of-Thought Reasoning in Multimodal Large Language Models for Audio Generation and Editing}, 
      author={Huadai Liu and Jialei Wang and Kaicheng Luo and Wen Wang and Qian Chen and Zhou Zhao and Wei Xue},
      year={2025},
      eprint={2506.21448},
      archivePrefix={arXiv},
      primaryClass={eess.AS},
      url={https://arxiv.org/abs/2506.21448}, 
}
```

---

## 📬 Contacto

✨ ¡No dude en [abrir una incidencia](https://github.com/liuhuadai/ThinkSound/issues) o contactarnos por correo electrónico ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) si tiene alguna pregunta o sugerencia!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---