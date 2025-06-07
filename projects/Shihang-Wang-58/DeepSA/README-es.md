[![Licencia: MIT](https://img.shields.io/badge/License-MIT-yellow)](https://github.com/Shihang-Wang-58/DeepSA)
[![PyPI](https://img.shields.io/badge/PyPI-cyan)](https://pypi.org/project/deepsa)

# DeepSA: Un predictor impulsado por aprendizaje profundo de la accesibilidad sintética de compuestos

Con el desarrollo continuo de la tecnología de inteligencia artificial, cada vez más modelos generativos profundos se utilizan para la generación de moléculas. Sin embargo, la mayoría de las nuevas moléculas generadas por los modelos generativos a menudo enfrentan grandes desafíos en términos de accesibilidad sintética.

DeepSA ha sido propuesto para predecir la accesibilidad sintética de compuestos, y presenta una tasa de enriquecimiento temprano mucho más alta al discriminar moléculas difíciles de sintetizar. Esto ayuda a los usuarios a seleccionar moléculas menos costosas para la síntesis, reduciendo así el tiempo de descubrimiento y desarrollo de fármacos. Puede utilizar DeepSA en un servidor web en https://bailab.siais.shanghaitech.edu.cn/deepsa<br/>

## Requisitos
Las dependencias se pueden instalar usando el siguiente comando:
```bash
conda create -n DeepSA python=3.12
conda activate DeepSA
# para versión gpu
pip3 install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu118
pip3 install autogluon==1.2
pip3 install rdkit
```
### Noticias 🔔 

* 2024-12, debido a que [AutoGluon dejó de soportar la versión 3.8 de python](https://github.com/autogluon/autogluon/pull/4512) a partir de octubre de 2024. Por lo tanto, hemos actualizado DeepSA para utilizar la versión 3.12 de Python y actualizado los scripts de entrenamiento e inferencia para adaptarse a la última versión de AutoGluon. ¡Gracias por su interés en DeepSA!

* 2023-7, DeepSA_v1.0 ha sido lanzado, ¡bienvenido a proporcionar comentarios en el issue!

## Datos 
Los conjuntos de datos ampliados de entrenamiento y prueba pueden descargarse fácilmente en https://drive.google.com/drive/folders/1iup6T3Bqyy-uvpdFyP0Of_WQqn-9l62h?usp=sharing
## Uso para investigadores
Si desea entrenar su propio modelo, puede ejecutarlo desde la línea de comandos,

ejecutando:
```
    python DeepSA_training.py <dataset.csv/training.csv:test.csv> DeepSA_model ./data/test_set.list
```
Si desea utilizar el modelo que proponemos,

ejecutando:
```
    python DeepSA_predict.py <input_data.csv> DeepSA_model
```

## Servidor en línea

Hemos desplegado un modelo pre-entrenado en un servidor dedicado, que está disponible públicamente en https://bailab.siais.shanghaitech.edu.cn/deepsa, para facilitar a los usuarios investigadores biomédicos el uso de DeepSA en su actividad investigadora.

Los usuarios pueden cargar sus archivos SMILES o csv al servidor, y luego podrán obtener rápidamente los resultados predichos.

## <span id="citelink">Citación</span>
Si encuentra útil este repositorio en su investigación, por favor considere citar nuestro artículo: 

Wang, S., Wang, L., Li, F. et al. DeepSA: a deep-learning driven predictor of compound synthesis accessibility. J Cheminform 15, 103 (2023). https://doi.org/10.1186/s13321-023-00771-3

## Contacto
Si tiene alguna pregunta, no dude en contactar a Shihang Wang (Correo electrónico: wangshh12022@shanghaitech.edu.cn) o Lin Wang (Correo electrónico: wanglin3@shanghaitech.edu.cn).

¡Las solicitudes de pull son muy bienvenidas!

## Agradecimientos
Estamos agradecidos por el apoyo de la Plataforma HPC de la Universidad ShanghaiTech.<br/>
Gracias a todos por su atención a este trabajo.

![Star History Chart](https://api.star-history.com/svg?repos=Shihang-Wang-58/DeepSA&type=Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---