# SongGen: Un Transformador Auto-regresivo de Etapa Única para Generación de Canciones a partir de Texto

🚀🚀🚀 Implementación oficial de **SongGen: Un Transformador Auto-regresivo de Etapa Única para Generación de Canciones a partir de Texto**
<p align="center" style="font-size: 1 em; margin-top: -1em">
<a href="https://scholar.google.com/citations?user=iELd-Q0AAAAJ">Zihan Liu</a>,  
<a href="https://mark12ding.github.io/">Shuangrui Ding</a>,  
<a href="https://github.com/rookiexiong7/">Zhixiong Zhang</a>, 
<a href="https://lightdxy.github.io/">Xiaoyi Dong</a>,  
<a href="https://panzhang0212.github.io/">Pan Zhang</a>,
<a href="https://yuhangzang.github.io/">Yuhang Zang</a>,  
<a href="https://scholar.google.com/citations?user=sJkqsqkAAAAJ">Yuhang Cao</a>, </br>  
<a href="http://dahua.site/">Dahua Lin</a>,  
<a href="https://myownskyw7.github.io/">Jiaqi Wang</a> 
</p>

<p align="center" style="font-size: 5 em; margin-top: 0.5em">
<a href="https://arxiv.org/abs/2502.13128"><img src="https://img.shields.io/badge/arXiv-<color>"></a>
<a href="https://github.com/LiuZH-19/SongGen"><img src="https://img.shields.io/badge/Code-red"></a>
<a href="https://liuzh-19.github.io/SongGen/"><img src="https://img.shields.io/badge/Demo-20d67c"></a>
<a href="https://huggingface.co/collections/LiuZH-19/songgen-a-single-stage-auto-regressive-transformer-for-text-6867ec21169d808034f6d252">
    <img src="https://img.shields.io/badge/HF-Collection-yellow"></a>
</p>





## 📜 Noticias
🚀 [2025/7/4] Hemos publicado el código de entrenamiento junto con una detallada [guía de entrenamiento](https://raw.githubusercontent.com/LiuZH-19/SongGen/master/./training/README.md) .

🚀 [2025/6/30] El conjunto de prueba MusicCaps ya está disponible en [Huggingface🤗](https://huggingface.co/datasets/LiuZH-19/MusicCaps_Test_Song) para evaluación de texto a canción.

🚀 [2025/6/27] Hemos publicado el punto de control de SongGen Interleaving (A-V) en [Huggingface🤗](https://huggingface.co/LiuZH-19/SongGen_interleaving_A_V).

🎉 [2025/5/1] ¡SongGen ha sido aceptado en ICML 2025!

🚀 [2025/3/18] Hemos publicado el punto de control de SongGen Mixed_Pro en [Huggingface🤗](https://huggingface.co/LiuZH-19/SongGen_mixed_pro).

🚀 [2025/2/19] El [artículo](https://arxiv.org/abs/2502.13128) y la [página demo](https://liuzh-19.github.io/SongGen/) han sido publicados!

## 💡 Destacados
- 🔥Presentamos SongGen, un transformador auto-regresivo de **etapa única** para generación de **texto a canción**, que ofrece control versátil mediante letras, texto descriptivo y una voz de referencia opcional.
- 🔥SongGen soporta tanto el modo **mixto** como el modo **de dos pistas** para adaptarse a diferentes requerimientos. Nuestros experimentos proporcionan **valiosos insights** para optimizar ambos modos.
- 🔥Al publicar los **pesos del modelo**, el **código**, los **datos anotados** y la **cadena de preprocesamiento**, buscamos establecer una línea base simple pero efectiva para la investigación futura en generación de canciones.
<!-- <img align="center" src="https://raw.githubusercontent.com/LiuZH-19/SongGen/master/assets/imgs/motivation1.jpg" style="  display: block;
  margin-left: auto;
  margin-right: auto;
  width: 50%;" /> -->

## 👨‍💻 Por hacer
- [ ] Publicar datos anotados y cadena de preprocesamiento
- [x] Publicar conjunto de prueba Musiccaps
- [x] Publicar código de entrenamiento de SongGen
- [x] Publicar punto de control de SongGen (Interleaving A-V)
- [x] Publicar punto de control de SongGen Mixed_pro
- [x] Publicar código de inferencia de SongGen 
- [x] Demo de SongGen

## 🛠️ Uso

### 1. Instalar entorno y dependencias
```bash
git clone https://github.com/LiuZH-19/SongGen.git
cd SongGen
# We recommend using conda to create a new environment.
conda create -n songgen_env python=3.9.18 
conda activate songgen_env
# Install CUDA >= 11.8 and PyTorch, e.g.,
pip install torch==2.3.0 torchvision==0.18.0 torchaudio==2.3.0 --index-url https://download.pytorch.org/whl/cu118
pip install flash-attn==2.6.1 --no-build-isolation
```
Para usar SongGen solo en modo de inferencia, instálelo usando:
```bash
pip install -e .
```
### 2. Descargar el xcodec

Descargue el punto de control X-Codec desde [🤗](https://raw.githubusercontent.com/LiuZH-19/SongGen/master/
https://huggingface.co/ZhenYe234/xcodec/blob/main/xcodec_hubert_general_audio_v2.pth) y colóquelo en el siguiente directorio : SongGen/songgen/xcodec_wrapper/xcodec_infer/ckpts/general_more

```
xcodec_infer
    ├── ckpts
    │   └── general_more
    │       ├── config_hubert_general.yaml
    │       └── xcodec_hubert_general_audio_v2.pth

```

### 3. Ejecutar la inferencia

#### (1). Modo Pro Mixto

```python
import torch
import os
from songgen import (
    VoiceBpeTokenizer,
    SongGenMixedForConditionalGeneration,
    SongGenProcessor
)
import soundfile as sf

ckpt_path = "LiuZH-19/SongGen_mixed_pro" # Path to the pretrained model
device = "cuda:0" if torch.cuda.is_available() else "cpu"
model = SongGenMixedForConditionalGeneration.from_pretrained(
    ckpt_path,
    attn_implementation='sdpa').to(device)
processor = SongGenProcessor(ckpt_path, device)

# Define input text and lyrics
lyrics = "..." # The lyrics text
text = "..." # The music description text
ref_voice_path = 'path/to/your/reference_audio.wav' # Path to reference audio, optional
separate= True # Whether to separate the vocal track from the reference voice audio

model_inputs = processor(text=text, lyrics=lyrics, ref_voice_path=ref_voice_path, separate=separate) 
generation = model.generate(**model_inputs,
                do_sample=True,
            )
audio_arr = generation.cpu().numpy().squeeze()
sf.write("songgen_out.wav", audio_arr, model.config.sampling_rate)
```



#### (2). Interleaving A-V  (Dual-track mode)
```python
import torch
import os
from songgen import (
    VoiceBpeTokenizer,
    SongGenDualTrackForConditionalGeneration,
    SongGenProcessor
)
import soundfile as sf

ckpt_path = "LiuZH-19/SongGen_interleaving_A_V" # Path to the pretrained model
device = "cuda:0" if torch.cuda.is_available() else "cpu"
model = SongGenDualTrackForConditionalGeneration.from_pretrained(
    ckpt_path,
    attn_implementation='sdpa').to(device)
processor = SongGenProcessor(ckpt_path, device)

# Define input text and lyrics
lyrics = "..." # The lyrics text
text = "..." # The music description text
ref_voice_path = 'path/to/your/reference_audio.wav' # Path to reference audio, optional
separate= True # Whether to separate the vocal track from the reference voice audio

model_inputs = processor(text=text, lyrics=lyrics, ref_voice_path=ref_voice_path, separate=True) 
generation = model.generate(**model_inputs,
                do_sample=True,
            )

acc_array = generation[0].cpu().numpy()
vocal_array = generation[1].cpu().numpy()
min_len =min(vocal_array.shape[0], acc_array.shape[0])
acc_array = acc_array[:min_len]
vocal_array = vocal_array[:min_len]
audio_arr = vocal_array + acc_array
sf.write("songgen_out.wav", audio_arr, model.config.sampling_rate)
```

### 4. Entrenamiento

La [carpeta de entrenamiento](./training) contiene toda la información para entrenar o ajustar finamente tu propio modelo SongGen. Consulta la [guía de entrenamiento](https://raw.githubusercontent.com/LiuZH-19/SongGen/master/./training/README.md) para instrucciones paso a paso.



## ❤️ Agradecimientos
Esta biblioteca se construye sobre una serie de gigantes de código abierto, a quienes queremos extender nuestro más cálido agradecimiento por proporcionar estas herramientas.

Agradecimientos especiales a:

- [Parler-tts](https://github.com/huggingface/parler-tts): La base de código sobre la que construimos.
- [X-Codec](https://github.com/zhenye234/xcodec): El códec de audio utilizado en nuestra investigación.
- [lp-music-caps](https://github.com/seungheondoh/lp-music-caps): Un proyecto enfocado en generar subtítulos para música.

Apreciamos profundamente todo el apoyo recibido a lo largo del camino.

## ☎️ Limitaciones y Trabajo Futuro

Este es un **trabajo de investigación** enfocado en la generación **de texto a canción**. Debido a las limitaciones del conjunto de datos actual, nuestro modelo está restringido actualmente a generar canciones en inglés con una duración máxima de 30 segundos.
Sin embargo, a pesar de haber sido entrenado con solo **2k horas** de datos y un modelo de **1.3B** parámetros, nuestro enfoque ha demostrado una fuerte efectividad y un potencial prometedor para generar canciones coherentes y expresivas. Creemos que aumentar tanto los datos como el tamaño del modelo mejorará aún más la alineación de las letras y la musicalidad.
Dicho esto, ampliar el conjunto de datos consume tiempo y es un desafío. Invitamos a colaboraciones y discusiones para explorar nuevas formas de mejorar el modelo y ampliar sus capacidades.
Para cualquier consulta o colaboración potencial, no dudes en contactar a: Zihan Liu (liuzihan@pjlab.org.cn) y Jiaqi Wang (wangjiaqi@pjlab.org.cn).

## ✒️ Citación
Si encuentras útil nuestro trabajo para tu investigación, considera dar una estrella ⭐ y una citación 📝
```bibtex
@misc{liu2025songgen,
      title={SongGen: A Single Stage Auto-regressive Transformer for Text-to-Song Generation}, 
      author={Zihan Liu and Shuangrui Ding and Zhixiong Zhang and Xiaoyi Dong and Pan Zhang and Yuhang Zang and Yuhang Cao and Dahua Lin and Jiaqi Wang},
      year={2025},
      eprint={2502.13128},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2502.13128}, 
}

```







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---