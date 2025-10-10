<center>
  <h1>ChinaTravel: Un Referente del Mundo Real para Agentes de Lenguaje en la Planificación de Viajes en China
</h1>
</center>

Base de código oficial para el artículo "ChinaTravel: Un Referente del Mundo Real para Agentes de Lenguaje en la Planificación de Viajes en China".

<!-- | [Página web](https://www.lamda.nju.edu.cn/shaojj/chinatravel/) | [Artículo](https://arxiv.org/abs/2412.13682) | [Conjunto de datos (Huggingface)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)| -->

[![Página web](https://img.shields.io/badge/Webpage-Visit-blue)](https://www.lamda.nju.edu.cn/shaojj/chinatravel/)
[![Artículo](https://img.shields.io/badge/Paper-View-red)](https://arxiv.org/abs/2412.13682)
[![Conjunto de datos (Huggingface)](https://img.shields.io/badge/Dataset-Huggingface-yellow)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)
[![Competencia (TPC@IJCAI2025)](https://img.shields.io/badge/IJCAI%20Competition-TPC@IJCAI2025-green)](https://chinatravel-competition.github.io/IJCAI2025/)
[![Competencia (TPC@AIC2025)](https://img.shields.io/badge/AIC%20Competition-TPC@AIC2025-green)](TPC@AIC2025/readme.md)


<!-- 
![Resumen](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/images/overview.png) -->

## 🏆 Desafío de Planificación de Viajes IJCAI 2025 (TPC@IJCAI)

¡Nos enorgullece anunciar que ChinaTravel ha sido seleccionado como el referente oficial para el **Desafío de Planificación de Viajes (TPC) @ IJCAI 2025**!

**Sitio oficial de la competencia**:
[https://chinatravel-competition.github.io/IJCAI2025/](https://chinatravel-competition.github.io/IJCAI2025/)

Se invita a los participantes a desarrollar agentes novedosos que puedan abordar escenarios reales de planificación de viajes bajo restricciones complejas. Esta competencia mostrará enfoques de vanguardia en la investigación de agentes de lenguaje.

## 📝 Registro de Cambios

### 2025.09
1. Subida de la solución ganadora de la pista DSL de TPC@IJCAI2025. Gracias a [@evergreenee](https://github.com/evergreenee) por sus contribuciones.  


### 2025.06

1. Corrección de la recolección de errores en el código de evaluación de sentido común. 
2. Corrección de la canalización del agente puramente neuronal
3. Corrección de load_datasets desde huggingface
4. Actualización del manejo de excepciones en la verificación de sintaxis


### 2025.05

1. Actualizar registros para la versión más reciente.
2. Proporcionar el código de evaluación para el TPC.

### 2025.04

1. Añadido cargador de datos local. Los usuarios ahora pueden cargar consultas personalizadas localmente. Al especificar valores de splits_name no predeterminados (por ejemplo, "abc") para "run_exp.py", el sistema cargará automáticamente los archivos correspondientes desde evaluation/default_splits/abc.txt, donde el archivo TXT contiene los nombres de archivo de las consultas objetivo.
2. Clasificación detallada de restricciones. Ver documentación detallada en [Evaluation README](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)
3. Introducción de la línea base LLM-modulo
   Implementar la canalización LLM-modulo con un verificador simbólico de verdad terreno.
   Basado en la metodología de:
   Artículo: Robust Planning with Compound LLM Architectures: An LLM-Modulo Approach
   Código base: https://github.com/Atharva-Gundawar/LLM-Modulo-prompts
4. Soporte para inferencia local de LLMs con Qwen3-8B/4B.

## 🚀 Inicio rápido

### ⚙️ Configuración

1. Crear un entorno conda e instalar dependencias:

```bash
conda create -n chinatravel python=3.9  
conda activate chinatravel  
pip install -r requirements.txt  
```

2. Descargue la base de datos y descomprímala en el directorio "chinatravel/environment/"

Enlaces de descarga: [Google Drive](https://drive.google.com/drive/folders/1bJ7jA5cfExO_NKxKfi9qgcxEbkYeSdAU), [NJU Drive](https://box.nju.edu.cn/d/dd83e5a4a9e242ed8eb4/)

3. Descargue los LLMs de código abierto (opcional).

```bash
bash download_llm.sh
```

4. Descargue los tokenizadores.

```bash
wget https://cdn.deepseek.com/api-docs/deepseek_v3_tokenizer.zip -P chinatravel/local_llm/
unzip chinatravel/local_llm/deepseek_v3_tokenizer.zip -d chinatravel/local_llm/
```

### ▶️ Ejecución

Soportamos deepseek (API oficial de deepseek), gpt-4o (chatgpt-4o-latest), glm4-plus y deducciones locales con Qwen (Qwen3-8B), llama, mistral (Mistral-7B-Instruct-v0.3), etc.

```bash
export OPENAI_API_KEY=""

python run_exp.py --splits easy --agent LLMNeSy --llm deepseek --oracle_translation
python run_exp.py --splits medium --agent LLMNeSy --llm deepseek --oracle_translation
python run_exp.py --splits human --agent LLMNeSy --llm deepseek --oracle_translation

python run_exp.py --splits human --agent LLMNeSy --llm Qwen3-8B --oracle_translation


python run_exp.py --splits human --agent LLMNeSy --llm deepseek 
python run_exp.py --splits human --agent LLMNeSy --llm Qwen3-8B 


python run_exp.py --splits human --agent LLM-modulo --llm deepseek --refine_steps 10 --oracle_translation
python run_exp.py --splits human --agent LLM-modulo --llm Qwen3-8B --refine_steps 10 --oracle_translation
```

**Nota**:

- La bandera `--oracle_translation` permite el acceso a la verdad fundamental anotada que incluye:

  - `hard_logic_py`: Código DSL de verificación ejecutable
  - `hard_logic_nl`: Las descripciones correspondientes de las restricciones
  - Estructura de ejemplo de la anotación:

  ```python
  {
    "hard_logic_py": [
      "
      total_cost=0 
      for activity in allactivities(plan):
          total_cost+=activity_cost(activity)
              total_cost += innercity_transport_cost(activity_transports(activity))
      result=(total_cost<=1000)
      ", 
      "
      innercity_transport_set=set()
      for activity in allactivities(plan):
          if activity_transports(activity)!=[]:              
              innercity_transport_set.add(innercity_transport_type(activity_transports(activity)))
      result=(innercity_transport_set<={'taxi'})
      "
    ], 
    "hard_logic_nl": ["总预算为1800元", "市内交通选择taxi"], 
  }
  ```
- El método LLM-modulo **requiere** el modo oracle_translation para su proceso de refinamiento simbólico

### 📊 Evaluación

```bash
python eval_exp.py --splits human --method LLMNeSy_deepseek_oracletranslation
python eval_exp.py --splits human --method LLMNeSy_deepseek
python eval_exp.py --splits human --method LLM-modulo_deepseek_10steps_oracletranslation
python eval_exp.py --splits human --method LLM-modulo_Qwen3-8B_10steps_oracletranslation

```

En TPC@IJCAI2025, el código de evaluación se proporciona en el archivo `eval_tpc.py`. Puede ejecutar el código de evaluación de la siguiente manera:

```bash
python eval_tpc.py --splits tpc_phase1 --method YOUR_METHOD_NAME
```

## 📚 Documentación

[Entorno](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/environment/readme.md)
[Restricciones](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)

## 🛠️ Desarrollo Avanzado

### 1. Desarrolla tu propio algoritmo de agente

Para desarrollar tu propio algoritmo de agente, necesitas heredar la clase `BaseAgent` de `chinatravel/agent/base.py` y añadir la lógica para tu algoritmo en la función `init_agent` en `chinatravel/agent/load_model.py`. Proporcionamos un ejemplo de agente vacío llamado `TPCAgent`.

Pasos:

- **Hereda la clase `BaseAgent`**: Crea un nuevo archivo Python en el directorio `chinatravel/agent` y define tu propia clase de agente, heredando de `BaseAgent`.

```python:chinatravel/agent/your_agent.py
from .base import BaseAgent

class YourAgent(BaseAgent):
    def __init__(self, **kwargs):
        super().__init__(**kwargs)
        # Initialization logic

    def act(self, observation):
        # Implement the decision - making logic of the agent
        pass
```

- **Agregue código a la función init_agent**: Abra el archivo chinatravel/agent/load_model.py y agregue soporte para su nuevo agente en la función init_agent.

```python:
def init_agent(kwargs):
    # ... existing code ...
    elif kwargs["method"] == "YourMethodName":
        agent = YourAgent(
            **kwargs
        )
    # ... existing code ...
    return agent
```

### 2. Desarrolla tu propio LLM local

Para desarrollar tu propio modelo de lenguaje grande (LLM) local, necesitas heredar la clase AbstractLLM de chinatravel/agent/llms.py y agregar el código de inferencia LLM local correspondiente en llms.py. Proporcionamos un ejemplo de LLM vacío llamado TPCLLM.
Pasos:

- **Heredar la clase AbstractLLM**: Define tu propia clase LLM en el archivo chinatravel/agent/llms.py, heredando de AbstractLLM.

```python
class YourLLM(AbstractLLM):
    def __init__(self):
        super().__init__()
        # Initialization logic
        self.name = "YourLLMName"

    def _get_response(self, messages, one_line, json_mode):
        # Implement the response logic of the LLM
        response = "Your LLM response"
        if json_mode:
            # Handle JSON mode
            pass
        elif one_line:
            # Handle one - line mode
            response = response.split("\n")[0]
        return response
```

- **Agregar código a la función init_agent**: Abra el archivo chinatravel/agent/load_model.py y agregue soporte para su nuevo llm en la función init_llm.

```python:
def init_llm(kwargs):
    # ... existing code ...
    elif llm_name == "glm4-plus":
        llm = YourLLM()
    # ... existing code ...
    return llm
```

### 3. Ejecute su código usando los scripts de experimento

Después de completar el desarrollo anterior, puede usar los scripts de experimento para ejecutar su código.

Ejemplo de ejecución:

```bash
python run_tpc.py --splits easy --agent TPCAgent --llm TPCLLM
python run_exp.py --splits easy --agent YourMethodName --llm YourLLMName
```
Los resultados se guardarán en el directorio `results/YourMethodName_YourLLMName_xxx`, por ejemplo, `results/TPCAgent_TPCLLM`.

## ✉️ Contacto

Si tiene algún problema, por favor contacte a [Jie-Jing Shao](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/shaojj@lamda.nju.edu.cn), [Bo-Wen Zhang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/221900200@smail.nju.edu.cn), [Xiao-Wen Yang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/yangxw@lamda.nju.edu.cn).

## 📌 Citación

Si nuestro artículo o los recursos relacionados resultan valiosos para su investigación, le pedimos amablemente que nos cite.


```
@misc{shao2024chinatravelrealworldbenchmarklanguage,
      title={ChinaTravel: A Real-World Benchmark for Language Agents in Chinese Travel Planning}, 
      author={Jie-Jing Shao and Xiao-Wen Yang and Bo-Wen Zhang and Baizhi Chen and Wen-Da Wei and Guohao Cai and Zhenhua Dong and Lan-Zhe Guo and Yu-feng Li},
      year={2024},
      eprint={2412.13682},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2412.13682}, 
}
```
[English](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=th) | [Français](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=de) | [Español](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=it) | [Русский](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ru) | [Português](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=as)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-10

---