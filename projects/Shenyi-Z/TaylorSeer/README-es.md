<div align=center>
  
# [ICCV 2025] *TaylorSeer*: De Reutilizar a Predecir: Acelerando Modelos de Difusión con *TaylorSeers*

<p>
<a href='https://arxiv.org/abs/2503.06923'><img src='https://img.shields.io/badge/Paper-arXiv-red'></a>
<a href='https://taylorseer.github.io/TaylorSeer/'><img src='https://img.shields.io/badge/Project-Page-blue'></a>
</p>

</div>

## 🔥 Noticias

* `2025/06/26` 💥💥 ¡TaylorSeer tiene el honor de ser aceptado en ICCV 2025!

* `2025/05/03` 🚀🚀 Se lanza TaylorSeer para HiDream.

* `2025/03/30` 🚀🚀 Se lanza TaylorSeer para Wan2.1.

* `2025/03/30` 🚀🚀 Los scripts de inferencia Diffusers para TaylorSeers y los scripts xDiT aplicables para inferencia paralela multi-GPU han sido lanzados oficialmente.

* `2025/03/10` 🚀🚀 ¡Nuestro trabajo más reciente "De Reutilizar a Predecir: Acelerando Modelos de Difusión con TaylorSeers" ha sido publicado! Los códigos están disponibles en [TaylorSeer](https://github.com/Shenyi-Z/TaylorSeer)! TaylorSeer soporta compresión sin pérdidas a una tasa de 4.99x en FLUX.1-dev (con una aceleración en latencia de 3.53x) y aceleración de alta calidad a una tasa de compresión de 5.00x en HunyuanVideo (con una aceleración en latencia de 4.65x)! Esperamos que *TaylorSeer* pueda mover el paradigma de los métodos de caché de características de reutilización a predicción. Para más detalles, por favor consulte nuestro artículo de investigación más reciente.
* `2025/02/19` 🚀🚀 La solución ToCa para **FLUX** ha sido oficialmente lanzada tras ajustes, logrando ahora hasta **3.14× aceleración sin pérdidas** (en FLOPs)!
* `2025/01/22` 💥💥 ¡ToCa tiene el honor de ser aceptado en ICLR 2025!
* `2024/12/29` 🚀🚀 Publicamos nuestro trabajo [DuCa](https://arxiv.org/abs/2412.18911) sobre la aceleración de transformadores de difusión GRATIS, que logra una aceleración casi sin pérdidas de **2.50×** en [OpenSora](https://github.com/hpcaitech/Open-Sora)! 🎉 **DuCa también supera la limitación de ToCa al soportar completamente FlashAttention, permitiendo una mayor compatibilidad y mejoras de eficiencia.**
* `2024/12/24` 🤗🤗 Publicamos un repositorio de código abierto "[Awesome-Token-Reduction-for-Model-Compression](https://github.com/xuyang-liu16/Awesome-Token-Reduction-for-Model-Compression)", que recopila recientes trabajos sobresalientes sobre reducción de tokens! ¡No dudes en contribuir con tus sugerencias!
* `2024/12/10` 💥💥 El trabajo reciente de nuestro equipo, **SiTo** (https://github.com/EvelynZhang-epiclab/SiTo), ha sido aceptado en **AAAI 2025**. Acelera modelos de difusión mediante **Poda Adaptativa de Tokens**.
* `2024/07/15` 🤗🤗 Publicamos un repositorio de código abierto "[Awesome-Generation-Acceleration](https://github.com/xuyang-liu16/Awesome-Generation-Acceleration)", que recopila recientes trabajos sobresalientes sobre aceleración de generación! ¡No dudes en contribuir con tus sugerencias!

<details>
  <summary><strong>Resumen</strong></summary>

  Los Transformadores de Difusión (DiT) han revolucionado la síntesis de imágenes y videos de alta fidelidad, pero sus demandas computacionales siguen siendo prohibitivas para aplicaciones en tiempo real. Para resolver este problema, se ha propuesto el caché de características para acelerar modelos de difusión almacenando las características en pasos de tiempo anteriores y reutilizándolas en los siguientes. Sin embargo, en pasos de tiempo con intervalos significativos, la similitud de características en modelos de difusión disminuye sustancialmente, lo que conduce a un aumento pronunciado en los errores introducidos por el caché de características, dañando significativamente la calidad de la generación. Para solucionar este problema, proponemos TaylorSeer, que primero demuestra que las características de los modelos de difusión en pasos de tiempo futuros pueden predecirse basándose en sus valores en pasos de tiempo anteriores. Basado en el hecho de que las características cambian lenta y continuamente a través de los pasos de tiempo, TaylorSeer emplea un método diferencial para aproximar las derivadas de orden superior de las características y predecir las características en pasos de tiempo futuros con la expansión en series de Taylor. Experimentos extensos demuestran su efectividad significativa tanto en síntesis de imágenes como de video, especialmente en altas tasas de aceleración. Por ejemplo, logra una aceleración casi sin pérdidas de 4.99 $\times$ en FLUX y 5.00 $\times$ en HunyuanVideo sin entrenamiento adicional. En DiT, logra un FID $3.41$ menor en comparación con el estado del arte previo con una aceleración de $4.53$ $\times$.

</details>

## 🧩 Contribuciones de la Comunidad

¡Gracias a todos los colaboradores de código abierto por su fuerte apoyo! ¡Nos encantaría saber de ti!

* ComfyUI-TaylorSeer-philipy1219 (Inferencia FP8 en FLUX, más modelos de video próximamente): [ComfyUI-TaylorSeer-philipy1219](https://github.com/philipy1219/ComfyUI-TaylorSeer) por [philipy1219](https://github.com/philipy1219).

## 🛠 Instalación

``` cmd
git clone https://github.com/Shenyi-Z/TaylorSeer.git
```

## TaylorSeer-FLUX

TaylorSeer logró una compresión computacional sin pérdidas de 4.99 $\times$ y una aceleración de latencia de 3.53 $\times$ en FLUX.1-dev, medida por [ImageReward](https://github.com/THUDM/ImageReward) para calidad integral. Para ejecutar TaylorSeer-FLUX, consulte [TaylorSeer-FLUX](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/TaylorSeer-FLUX.md).

Además, hemos proporcionado ejemplos de scripts de inferencia para la **versión diffusers**, así como scripts de inferencia paralela multi-GPU **xDiT**. También puede realizar pruebas basadas en ellos, ubicados en [TaylorSeers-Diffusers](./TaylorSeers-Diffusers ) y [TaylorSeers-xDiT](./TaylorSeers-xDiT) respectivamente.

## TaylorSeer-HunyuanVideo

TaylorSeer logró una compresión computacional de 5.00 $\times$ y una notable aceleración de latencia de 4.65 $\times$ en HunyuanVideo, medida integralmente por la métrica [VBench](https://github.com/Vchitect/VBench). En comparación con métodos anteriores, demostró mejoras significativas tanto en eficiencia de aceleración como en calidad. Para ejecutar TaylorSeer-HunyuanVideo, consulte [TaylorSeer-HunyuanVideo](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/TaylorSeer-HunyuanVideo.md).

Además, nuestros scripts también soportan aceleración paralela multi-GPU implementada por HunyuanVideo usando xDiT. En este caso, el efecto de aceleración aportado por la caché y el efecto de aceleración del paralelismo multi-GPU son independientes entre sí y se multiplican, logrando efectos de aceleración extremadamente altos.

## TayorSeer-DiT

TaylorSeer logró una compresión computacional sin pérdidas de 2.77 $\times$ en el modelo base DiT, evaluado integralmente por métricas como FID. Su rendimiento en varios ratios de aceleración superó significativamente a métodos anteriores. Por ejemplo, en un escenario extremo con una relación de compresión de 4.53 $\times$, el FID de TaylorSeer solo aumentó 0.33 respecto a la línea base sin acelerar de 2.32, alcanzando 2.65, mientras que ToCa y DuCa exhibieron puntuaciones FID superiores a 6.0 bajo las mismas condiciones. Para ejecutar TaylorSeer-DiT, consulte [TaylorSeer-DiT](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/TaylorSeer-DiT.md).

## TaylorSeer-Wan2.1

Implementamos el método de aceleración TaylorSeer en Wan2.1, con soporte para inferencia paralela multi-GPU. Los comandos de instalación e inferencia para TaylorSeer-Wan2.1 son totalmente compatibles con los de Wan2.1. Para ejecutar TaylorSeer-Wan2.1, consulte [TaylorSeer-Wan2.1](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/TaylorSeer-Wan2.1.md).

## TaylorSeer-HiDream

El modelo de generación de imágenes recientemente abierto **HiDream**, a pesar de su impresionante calidad de salida, enfrenta demandas crecientes de aceleración debido a su mayor tiempo de inferencia. Aplicamos **TaylorSeer** para acelerar la inferencia de HiDream, logrando una **reducción del 72% en el tiempo de ejecución**. Para más detalles, consulte [TaylorSeer-HiDream](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/TaylorSeer-HiDream.md).

## 👍 Agradecimientos

- Gracias a [DiT](https://github.com/facebookresearch/DiT) por su gran trabajo y base de código sobre la cual construimos TaylorSeer-DiT.
- Gracias a [FLUX](https://github.com/black-forest-labs/flux) por su gran trabajo y base de código sobre la cual construimos TaylorSeer-FLUX.
- Gracias a [HiDream](https://github.com/HiDream-ai/HiDream-I1) por su gran trabajo y base de código sobre la cual construimos TaylorSeer-HiDream.
- Gracias a [HunyuanVideo](https://github.com/Tencent/HunyuanVideo) por su gran trabajo y base de código sobre la cual construimos TaylorSeer-HunyuanVideo.
- Gracias a [Wan2.1](https://github.com/Wan-Video/Wan2.1) por su gran trabajo y base de código sobre la cual construimos TaylorSeer-Wan2.1.
- Gracias a [ImageReward](https://github.com/THUDM/ImageReward) por la evaluación de calidad Texto-a-Imagen.
- Gracias a [VBench](https://github.com/Vchitect/VBench) por la evaluación de calidad Texto-a-Video.


## 📌 Citación


```bibtex
@article{TaylorSeer2025,
  title={From Reusing to Forecasting: Accelerating Diffusion Models with TaylorSeers},
  author={Liu, Jiacheng and Zou, Chang and Lyu, Yuanhuiyi and Chen, Junjie and Zhang, Linfeng},
  journal={arXiv preprint arXiv:2503.06923},
  year={2025}
}
```

## :e-mail: Contacto

Si tiene alguna pregunta, por favor envíe un correo electrónico a [`shenyizou@outlook.com`](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/mailto:shenyizou@outlook.com).



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---