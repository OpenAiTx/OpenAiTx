# ¿Son los Modelos de Lenguaje Realmente Útiles para la Predicción de Series Temporales?

**(NeurIPS 2024 Spotlight)** 🌟 [Enlace al artículo](https://arxiv.org/pdf/2406.16964)

En este trabajo mostramos que, a pesar de la reciente popularidad de los LLMs en la predicción de series temporales (TSF), no parecen mejorar significativamente el rendimiento. Se propuso una línea base simple, "PAttn," que superó a la mayoría de los modelos TSF basados en LLM.

Autores: [Mingtian Tan](https://x.com/MTTan1203),[Mike A. Merrill](https://mikemerrill.io/),[Vinayak Gupta](https://gvinayak.github.io/),[Tim Althoff](https://homes.cs.washington.edu/~althoff/),[Thomas Hartvigsen](https://www.tomhartvigsen.com/)

### Los LLMs autorregresivos tienen gran potencial para aprovechar el contexto y razonar (predecir) series temporales futuras. Los modelos de predicción de series temporales mencionados en este artículo no.

Para razonar (predecir) series temporales mediante texto, puede consultar este [trabajo de razonamiento (predicción) de series temporales](https://github.com/behavioral-data/TSandLanguage/tree/main/text_aid_forecast).

## Resumen 💁🏼
El trabajo reciente en análisis de series temporales se ha centrado cada vez más en adaptar modelos de lenguaje grandes preentrenados (LLMs) para **predicción (TSF)**, clasificación y detección de anomalías. Estos estudios sugieren que los modelos de lenguaje, diseñados para dependencias secuenciales en texto, podrían generalizar a datos de series temporales. Aunque esta idea está alineada con la popularidad de los modelos de lenguaje en aprendizaje automático, las conexiones directas entre modelado de lenguaje y TSF siguen siendo poco claras. **¿Qué tan beneficiosos son los modelos de lenguaje para tareas tradicionales de TSF?**

Mediante una serie de estudios de ablación en tres métodos recientes **TSF basados en LLM**, encontramos que **eliminar el componente LLM o reemplazarlo con una capa simple de atención no empeoró los resultados; en muchos casos, incluso condujo a mejoras.** Además, introdujimos PAttn, demostrando que las estructuras de parches y atención pueden rendir igual que los pronosticadores basados en LLM de última generación.

![Ablations/PAttn](https://raw.githubusercontent.com/BennyTMT/LLMsForTimeSeries/main/pic/ablations.png)

## Conjunto de datos 📖
Puede acceder a los conjuntos de datos bien preprocesados desde [Google Drive](https://drive.google.com/file/d/1NF7VEefXCmXuWNbnNe858WvQAkJ_7wuP/view), luego coloque el contenido descargado bajo ./datasets

## Configuración 🔧
Se incluyeron tres métodos TSF populares basados en LLM en nuestro enfoque de ablación. Puede seguir los repositorios correspondientes, [OneFitsAll](https://github.com/DAMO-DI-ML/NeurIPS2023-One-Fits-All), [Time-LLM](https://github.com/KimMeen/Time-LLM), y [CALF](https://github.com/Hank0626/CALF), para configurar el entorno respectivamente. Para el método **''PAttn''**, el entorno de cualquiera de los repositorios anteriores es compatible.

## PAttn 🤔
La principal diferencia entre **PAttn** y [PatchTST](https://github.com/yuqinie98/PatchTST) es que eliminamos gradualmente partes del módulo Transformer que pueden no ser tan esenciales, y el Embedding Posicional. Para más explicación, consulte [esta respuesta](https://github.com/BennyTMT/LLMsForTimeSeries/issues/7).

**Motivación**: Cuando [DLinear](https://github.com/cure-lab/LTSF-Linear) fue superado por muchos métodos nuevos, nuestro objetivo es proporcionar un método basado en Patching que sea simple y efectivo, sirviendo como una línea base sencilla.

     cd ./PAttn 

     bash ./scripts/ETTh.sh (para ETTh1 & ETTh2)
     bash ./scripts/ETTm.sh (para ETTm1 & ETTm2)
     bash ./scripts/weather.sh (para Weather)
     
#### Para otros conjuntos de datos, por favor cambie el nombre del script en el comando anterior.

## Ablaciones
     
#### Ejecutar Ablaciones en CALF (ETT):
     
    cd ./CALF
    sh scripts/long_term_forecasting/ETTh_GPT2.sh
    sh scripts/long_term_forecasting/ETTm_GPT2.sh
    
    sh scripts/long_term_forecasting/traffic.sh 
    (Para otros conjuntos de datos, como traffic)

#### Ejecutar Ablaciones en OneFitsAll (ETT):
     cd ./OFA
     bash ./script/ETTh_GPT2.sh   
     bash ./script/ETTm_GPT2.sh

     bash ./script/illness.sh 
     (Para otros conjuntos de datos, como illness)

#### Ejecutar Ablaciones en Time-LLM (ETT)
     cd ./Time-LLM-exp
     bash ./scripts/train_script/TimeLLM_ETTh1.sh
     bash ./scripts/train_script/TimeLLM_ETTm1.sh 

     bash ./scripts/train_script/TimeLLM_Weather.sh
     (Para otros conjuntos de datos, como Weather)

#### (Para ejecutar ablaciones en otros conjuntos de datos, por favor cambie el nombre del conjunto como se muestra en el ejemplo.)

## Agradecimientos

Esta base de código está construida sobre la [Time-Series-Library](https://github.com/thuml/Time-Series-Library). ¡Gracias!

## Citación
Si encuentra nuestro trabajo útil, por favor cite nuestro trabajo de la siguiente manera:


```bibtex
@inproceedings{tan2024language,
    title={¿Son realmente útiles los modelos de lenguaje para la predicción de series temporales?},
    author={Tan, Mingtian y Merrill, Mike A y Gupta, Vinayak y Althoff, Tim y Hartvigsen, Thomas},
    booktitle={Sistemas de Procesamiento de Información Neural (NeurIPS)},
    year={2024}
}

```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---