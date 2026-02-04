# AutoDefense: Defensa Multi-Agente LLM contra Ataques de Jailbreak

[**Blog**](https://microsoft.github.io/autogen/0.2/blog/2024/03/11/AutoDefense/Defending%20LLMs%20Against%20Jailbreak%20Attacks%20with%20AutoDefense/)

## Instalación

```bash
pip install vllm autogen pandas retry openai
```

## Preparar el Servicio de Inferencia Usando [vLLM](https://docs.vllm.ai/)

vLLM proporciona un servidor API compatible con OpenAI con inferencia eficiente y balanceo de carga incorporado entre múltiples GPUs.

### Iniciar el Servidor vLLM

Inicie el servidor vLLM con su modelo deseado. Para configuraciones con múltiples GPUs, use `--data-parallel-size` para habilitar el balanceo automático de carga:

**GPU Única:**
```bash
vllm serve Qwen/Qwen3-1.7B --port 8000
```

**Múltiples GPUs (por ejemplo, 2 GPUs con paralelismo de datos):**
```bash
vllm serve Qwen/Qwen3-1.7B --port 8000 --data-parallel-size 2
```
**Con paralelismo tensorial para modelos más grandes:**

```bash
vllm serve <your-large-model> --port 8000 --tensor-parallel-size 4
```

**Paralelismo combinado de tensor y datos (8 GPU, paralelismo de tensor 2 vías × paralelismo de datos 4 vías):**
```bash
vllm serve <your-large-model> --port 8000 --tensor-parallel-size 2 --data-parallel-size 4
```

Para más detalles sobre el despliegue paralelo de datos con balanceo de carga interno, consulte la [documentación de vLLM](https://docs.vllm.ai/en/latest/serving/data_parallel_deployment/).

### Verificar el Servidor

Puede verificar que el servidor esté en funcionamiento comprobando el endpoint de modelos:

```bash
curl http://localhost:8000/v1/models
```

## Generación de Respuestas

Las respuestas son generadas por el modelo objetivo servido por vLLM (por defecto: `Qwen/Qwen3-1.7B`). Asegúrese de que su servidor vLLM esté en funcionamiento antes de ejecutar el siguiente comando.

### Solicitudes de Ataque (Nocivas)

```bash
python attack/attack.py --model Qwen/Qwen3-1.7B --host 127.0.0.1 --port 8000
```

Este comando generará respuestas utilizando una plantilla de indicación de ataque (por defecto: `--template v1`) cargada desde `data/prompt/attack_prompt_template.json`.
Para ejecutar múltiples repeticiones, invoque el script varias veces y varíe `--output-suffix` y/o `--cache-seed`.

### Indicaciones Seguras (Benignas)

Para generar respuestas para indicaciones seguras/benignas (utilizadas para la evaluación de falsos positivos):

```bash
python attack/attack.py \
    --model Qwen/Qwen3-1.7B \
    --template placeholder \
    --prompts data/prompt/safe_prompts.json \
    --output-prefix safe
```

La plantilla `placeholder` pasa los prompts sin ningún marco de ataque, mientras que `v1` envuelve los prompts con instrucciones de jailbreak.

## Ejecutar Experimentos de Defensa

El siguiente comando ejecuta los experimentos de defensa de 1-Agente, 2-Agentes y 3-Agentes. El parámetro `--chat-file` debe apuntar a las salidas dañinas generadas por `attack/attack.py` (por defecto guardadas en `data/harmful_output/<model_dir>/`, por ejemplo `data/harmful_output/Qwen-Qwen3-1.7B/attack-dan_0.json`).

```bash
export AUTOGEN_USE_DOCKER=0

python defense/run_defense_exp.py \
  --model Qwen/Qwen3-1.7B \
  --chat-file data/harmful_output/Qwen-Qwen3-1.7B/attack-dan_0.json
```

### Argumentos de Línea de Comandos

| Argumento | Descripción | Predeterminado |
|----------|-------------|---------|
| `--model` | Modelo objetivo servido por vLLM | `Qwen/Qwen3-1.7B` |
| `--chat-file` | Ruta al archivo de chat con salidas dañinas | Obligatorio |
| `--port` | Puerto donde se ejecuta el servidor vLLM | `8000` |
| `--host` | Nombre del host del servidor vLLM | `127.0.0.1` |
| `--output-dir` | Directorio de salida | `data/defense_output/<model_dir>` |
| `--output-suffix` | Sufijo para el directorio de salida | `""` |
| `--strategies` | Estrategias de defensa a ejecutar | `ex-2 ex-3 ex-cot` |
| `--workers` | Número de trabajadores en paralelo | `128` |
| `--frequency_penalty` | Penalización por frecuencia en la generación | `0.0` |
| `--presence_penalty` | Penalización por presencia en la generación | `0.0` |
| `--temperature` | Temperatura para la generación | `0.7` |

Después de finalizar el experimento de defensa, la salida aparecerá en `data/defense_output/<model_dir>/` (por ejemplo, `data/defense_output/Qwen-Qwen3-1.7B/`).

## Evaluación GPT (el artículo utiliza GPT-4)

Evaluando la defensa contra salidas dañinas:

```bash
python evaluator/gpt4_evaluator.py \
--defense_output_dir data/defense_output/Qwen-Qwen3-1.7B \
--ori_prompt_file_name prompt_dan.json
```

Después de finalizar la evaluación, la salida aparecerá en `data/defense_output/Qwen-Qwen3-1.7B/asr.csv`.
También habrá un valor de `score` que aparecerá para cada salida de defensa en el archivo `json` de salida.
`evaluator/gpt4_evaluator.py` utiliza un modelo GPT como evaluador (el artículo original usa GPT-4). Configure sus credenciales de OpenAI mediante variables de entorno (o banderas CLI), y puede cambiar el evaluador a un modelo GPT más nuevo (por ejemplo, GPT-5) mediante `--model`.

```bash
export OPENAI_API_KEY=...
# optional (only if you use an OpenAI-compatible endpoint):
# export OPENAI_BASE_URL=...

python evaluator/gpt4_evaluator.py \
  --defense_output_dir data/defense_output/Qwen-Qwen3-1.7B \
  --ori_prompt_file_name prompt_dan.json \
  --model gpt-4-1106-preview
```

La evaluación basada en GPT puede ser costosa; habilitamos el almacenamiento en caché para evitar evaluaciones repetidas.

Para una evaluación segura de las respuestas, existe una forma eficiente sin usar GPT-4. Si sabes que todos los mensajes en tu conjunto de datos son mensajes regulares de usuario y no deben ser rechazados, puedes usar el siguiente comando para evaluar la tasa de falsos positivos (FPR) de la salida de la defensa.

```bash
python evaluator/evaluate_safe.py
```

Esto encontrará todas las carpetas de salida en `data/defense_output` que contengan la palabra clave `-safe` y evaluará la tasa de falsos positivos (FPR).
La FPR se guardará en el archivo `data/defense_output/defense_fp.csv`.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-04

---