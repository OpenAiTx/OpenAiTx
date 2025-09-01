# AudioStory: Generación de Audio Narrativo de Larga Duración con Grandes Modelos de Lenguaje

**[Yuxin Guo<sup>1,2</sup>](https://scholar.google.com/citations?user=x_0spxgAAAAJ&hl=en), 
[Teng Wang<sup>2,&#9993;</sup>](http://ttengwang.com/), 
[Yuying Ge<sup>2</sup>](https://geyuying.github.io/), 
[Shijie Ma<sup>1,2</sup>](https://mashijie1028.github.io/), 
[Yixiao Ge<sup>2</sup>](https://geyixiao.com/), 
[Wei Zou<sup>1</sup>](https://people.ucas.ac.cn/~zouwei),
[Ying Shan<sup>2</sup>](https://scholar.google.com/citations?user=4oXBp9UAAAAJ&hl=en)**
<br>
<sup>1</sup>Instituto de Automatización, CAS
<sup>2</sup>Laboratorio ARC, Tencent PCG
<br>



## 📖 Lanzamiento

[2025/8/28] 🔥🔥 ¡Publicamos el código de inferencia!

[2025/8/28] 🔥🔥 ¡Publicamos nuestros videos de demostración!



## 🔎 Introducción

![audiostory](https://raw.githubusercontent.com/TencentARC/AudioStory/main/audiostory.png)

✨ **TL; DR: Proponemos un modelo para la generación de audio narrativo de larga duración basado en un marco unificado de comprensión y generación, capaz de manejar doblaje de video, continuación de audio y síntesis de audio narrativo de larga duración.**

Los avances recientes en la generación de texto a audio (TTA) sobresalen en la síntesis de clips de audio cortos pero tienen dificultades con el audio narrativo de larga duración, que requiere coherencia temporal y razonamiento composicional. Para abordar esta brecha, proponemos AudioStory, un marco unificado que integra grandes modelos de lenguaje (LLMs) con sistemas TTA para generar narrativas de audio estructuradas y de larga duración. AudioStory posee fuertes capacidades de generación razonada siguiendo instrucciones. Emplea LLMs para descomponer consultas narrativas complejas en sub-tareas ordenadas temporalmente con pistas contextuales, permitiendo transiciones coherentes de escenas y consistencia en el tono emocional. AudioStory tiene dos características atractivas:

1) Mecanismo de conexión desacoplado: AudioStory desvincula la colaboración LLM-difusor en dos componentes especializados: una consulta de puente para la alineación semántica intra-evento y una consulta de consistencia para la preservación de coherencia entre eventos.
2) Entrenamiento de extremo a extremo: Al unificar la comprensión de instrucciones y la generación de audio dentro de un solo marco de extremo a extremo, AudioStory elimina la necesidad de pipelines de entrenamiento modulares mientras mejora la sinergia entre componentes.
    Además, establecemos un benchmark AudioStory-10K, que abarca dominios diversos como paisajes sonoros animados y narrativas de sonidos naturales.

Experimentos extensos muestran la superioridad de AudioStory tanto en la generación de audio único como en la generación de audio narrativo, superando a las líneas base previas de TTA en capacidad de seguir instrucciones y fidelidad del audio.



## ⭐ Demostraciones

### 1. Doblaje de Video (estilo Tom & Jerry)
> El doblaje se logra usando AudioStory (entrenado en Tom & Jerry) con subtítulos visuales extraídos de videos.

<table class="center">
  <td><video src="https://github.com/user-attachments/assets/f06b5999-6649-44d3-af38-63fdcecd833c"></video></td>
  <td><video src="https://github.com/user-attachments/assets/17727c2a-bfea-4252-9aa8-48fc9ac33500"></video></td>
  <td><video src="https://github.com/user-attachments/assets/09589d82-62c9-47a6-838a-5a62319f35e2"></video></td>
  <tr>
</table >


### 2. Doblaje de Video Interdominio (estilo Tom & Jerry)

<table class="center">
    <td><video src="https://github.com/user-attachments/assets/e62d0c09-cdf0-4e51-b550-0a2c23f8d68d"></video></td>
    <td><video src="https://github.com/user-attachments/assets/736d22ca-6636-4ef0-99f3-768e4dfb112a"></video></td>
    <td><video src="https://github.com/user-attachments/assets/f2f7c94c-7f72-4cc0-8edc-290910980b04"></video></td>
  <tr>
  <td><video src="https://github.com/user-attachments/assets/d3e58dd4-31ae-4e32-aef1-03f1e649cb0c"></video></td>
  <td><video src="https://github.com/user-attachments/assets/4f68199f-e48a-4be7-b6dc-1acb8d377a6e"></video></td>
  <td><video src="https://github.com/user-attachments/assets/062236c3-1d26-4622-b843-cc0cd0c58053"></video></td>
	<tr>
  <td><video src="https://github.com/user-attachments/assets/8931f428-dd4d-430f-9927-068f2912dd36"></video></td>
  <td><video src="https://github.com/user-attachments/assets/ab7e46d5-f42c-472e-b66e-df786b658210"></video></td>      
  <td><video src="https://github.com/user-attachments/assets/9a0998ad-b5a4-42ac-bdaf-ceaf796fc586"></video></td>
  <tr>
</table >



### 3. Texto a Audio Largo (Sonido natural)

<table class="center">
  <td style="text-align:center;" width="480">Instrucción: "Desarrollar un audio completo que represente totalmente a Jake Shimabukuro interpretando una pieza compleja de ukelele en un estudio, recibe aplausos y habla sobre su carrera en una entrevista. La duración total es de 49.9 segundos."</td>
  <td><video src="https://github.com/user-attachments/assets/461e8a34-4217-454e-87b3-e4285f36ec43"></video></td>
	<tr>
  <td style="text-align:center;" width="480">Instrucción: "Desarrollar un audio completo que represente totalmente un camión de bomberos que sale de la estación con sirenas sonando, señalando una respuesta de emergencia, y se aleja conduciendo. La duración total es de 35.1 segundos."</td>
  <td><video src="https://github.com/user-attachments/assets/aac0243f-5d12-480e-9850-a7f6720e4f9c"></video></td>
	<tr>
     <td style="text-align:center;" width="480">Instrucción: "Entender el audio de entrada, inferir los eventos subsecuentes y generar el audio continuado del entrenador dando lecciones de baloncesto a los jugadores. La duración total es de 36.6 segundos."</td>    
    <td><video src="https://github.com/user-attachments/assets/c4ed306a-651e-43d6-aeea-ee159542418a"></video></td>
	<tr>
</table >




## 🔎 Métodos

![audiostory_framework](https://raw.githubusercontent.com/TencentARC/AudioStory/main/audiostory_framework.png)

Para lograr una generación de audio que siga instrucciones de manera efectiva, es esencial la capacidad de entender la instrucción o flujo de audio de entrada y razonar sobre sub-eventos de audio relevantes. Para ello, AudioStory adopta un marco unificado de comprensión-generación (Fig.). Específicamente, dada una instrucción textual o entrada de audio, el LLM la analiza y descompone en sub-eventos de audio estructurados con contexto. Basado en los sub-eventos inferidos, el LLM realiza una **generación de razonamiento intercalado**, produciendo secuencialmente subtítulos, tokens semánticos y tokens residuales para cada clip de audio. Estos dos tipos de tokens se fusionan y pasan al DiT, conectando efectivamente el LLM con el generador de audio. A través de un entrenamiento progresivo, AudioStory logra finalmente tanto una fuerte comprensión de instrucciones como una generación de audio de alta calidad.



## 🔩 Instalación

### Dependencias

* Python >= 3.10 (Se recomienda usar [Anaconda](https://www.anaconda.com/download/#linux))
* [PyTorch >=2.1.0](https://pytorch.org/)
* GPU NVIDIA + [CUDA](https://developer.nvidia.com/cuda-downloads)

### Instalación

```
git clone https://github.com/TencentARC/AudioStory.git
cd AudioStory
conda create -n audiostory python=3.10 -y
conda activate audiostory
bash install_audiostory.sh
```



## 📊 Evaluation

### inference

```
python evaluate/inference.py --model_path /path/to/ckpt --guidance 4.0 --save_folder_name audiostory --total_duration 50
```
## 🔋 Agradecimientos

Al construir la base de código de denoisers continuos, nos referimos a [SEED-X](https://github.com/AILab-CVC/SEED-X) y [TangoFlux](https://github.com/declare-lab/TangoFlux). Gracias por sus maravillosos proyectos.



## 📆 POR HACER

- [ ] Publicar nuestra demo en gradio.
- [ ] Publicar los puntos de control de AudioStory.
- [ ] Publicar los códigos de entrenamiento de las tres etapas.



## 📜 Licencia

Este repositorio está bajo la [Licencia Apache 2](https://github.com/mashijie1028/Gen4Rep/blob/main/LICENSE).



## 📚 BibTeX




```
@misc{guo2025audiostory,
      title={AudioStory: Generating Long-Form Narrative Audio with Large Language Models}, 
      author={Yuxin Guo and Teng Wang and Yuying Ge and Shijie Ma and Yixiao Ge and Wei Zou and Ying Shan},
      year={2025},
      eprint={2508.20088},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2508.20088}, 
}
```
## 📧 Contacto

Si tienes más preguntas, no dudes en contactarme: guoyuxin2021@ia.ac.cn

También son bienvenidas las discusiones y posibles colaboraciones.





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-01

---