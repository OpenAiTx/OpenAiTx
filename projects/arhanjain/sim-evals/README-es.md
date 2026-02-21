# Evaluación de Simulación DROID

Este repositorio contiene scripts para evaluar políticas DROID en un entorno simple de simulación ISAAC.

Aquí hay un ejemplo de despliegue de una política pi0-FAST-DROID:

Escena 1

![Escena 1](https://raw.githubusercontent.com/arhanjain/sim-evals/main/./docs/scene1.gif)

Escena 2

![Escena 2](https://raw.githubusercontent.com/arhanjain/sim-evals/main/./docs/scene2.gif)

Escena 3

![Escena 3](https://raw.githubusercontent.com/arhanjain/sim-evals/main/./docs/scene3.gif)

La simulación está ajustada para funcionar *zero-shot* con políticas DROID entrenadas en el conjunto de datos DROID del mundo real, por lo que no se requiere un conjunto de datos de simulación separado.

**Nota:** El simulador actual funciona mejor para políticas entrenadas con espacio de acción de *posición conjunta* (y *no* control de velocidad conjunta). Proporcionamos ejemplos para evaluar políticas pi0-FAST-DROID entrenadas con control de posición conjunta a continuación.


## Instalación

Clona el repositorio
```bash
git clone --recurse-submodules git@github.com:arhanjain/sim-evals.git
cd sim-evals
```

Instale uv (vea: https://github.com/astral-sh/uv#installation)

Por ejemplo (Linux/macOS):
```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```

Crear y activar un entorno virtual
```bash
uv sync
source .venv/bin/activate
```

## Inicio Rápido

Primero, asegúrese de descargar los activos de la simulación en la raíz de este directorio
```bash
uvx hf download owhan/DROID-sim-environments --repo-type dataset --local-dir assets
```

Luego, en una terminal separada, inicie el servidor de políticas en `localhost:8000`. 
Por ejemplo, para iniciar una política pi0-FAST-DROID (con control de posición conjunta),
consulte [openpi](https://github.com/Physical-Intelligence/openpi) y use las configuraciones de `polaris` 
```bash
XLA_PYTHON_CLIENT_MEM_FRACTION=0.5 uv run scripts/serve_policy.py policy:checkpoint --policy.config=pi05_droid_jointpos_polaris --policy.dir=gs://openpi-assets/checkpoints/pi05_droid_jointpos
```

**Nota**: Configuramos `XLA_PYTHON_CLIENT_MEM_FRACTION=0.5` para evitar que JAX acapare toda la memoria de la GPU (en caso de que Isaac Sim esté usando la misma GPU).

Finalmente, ejecute el script de evaluación:
```bash
python run_eval.py --episodes [INT] --scene [INT] --headless
```

## Ejemplo Mínimo

```python
env_cfg.set_scene(scene) # pass scene integer
env = gym.make("DROID", cfg=env_cfg)

obs, _ = env.reset()
obs, _ = env.reset() # need second render cycle to get correctly loaded materials
client = # Your policy of choice

max_steps = env.env.max_episode_length
for _ in tqdm(range(max_steps), desc=f"Episode"):
    action = client.infer(obs, INSTRUCTION) # calling inference on your policy
    action = torch.tensor(ret["action"])[None]
    obs, _, term, trunc, _ = env.step(action)
    if term or trunc:
        break
env.close()
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-21

---