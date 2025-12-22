# ExpeRepair

**ExpeRepair** es un novedoso marco de reparación de programas basado en LLM que acumula y reutiliza continuamente experiencias históricas de reparación mediante un sistema de memoria dual. Comprende dos componentes principales:
- **Módulo de Reparación de Programas**: Consiste en un Agente de Pruebas y un Agente de Parches que manejan colaborativamente tres tareas clave: generación de pruebas, generación de parches y validación de parches.
- **Módulo de Memoria**: Captura trayectorias de reparación del Módulo de Reparación de Programas, extrayendo demostraciones concretas y resumiendo estrategias de reparación de alto nivel. Estos se almacenan en **memoria episódica** y **memoria semántica**, respectivamente. Durante futuras reparaciones, ExpeRepair recupera demostraciones e ideas relevantes para mejorar su estrategia de reparación para nuevos problemas.

## 🚀 Inicio Rápido

### Instalación
```bash
git clone <repository-url>
cd ExpeRepair-v1.0
pip install -r requirements.txt
```

### Configuración del Entorno

Establezca sus claves API como variables de entorno:
```bash
export PYTHONPATH=$PYTHONPATH:$(pwd)
# OpenAI key
export OPENAI_KEY="your-openai-key"
# Anthropic Key
export CLAUDE_KEY="your-anthropic-key"
```

Siguiendo [Agentless](https://arxiv.org/abs/2407.01489), ExpeRepair utiliza un **formato de estructura de repositorio** para localizar archivos sospechosos.
Puede preprocesar los repositorios usted mismo o descargar los datos preparados: [swebench_lite_repo_structure.zip](https://github.com/OpenAutoCoder/Agentless/releases/tag/v1.5.0).

Después de descargar, descomprima y exporte su ubicación:
```bash
export PROJECT_FILE_LOC={folder which you saved}
```
Finalmente, configure el banco de pruebas siguiendo las instrucciones del [proyecto auto-code-rover](https://github.com/AutoCodeRoverSG/auto-code-rover#setting-up-testbed).

### Ejecutando ExpeRepair en el Benchmark Completo
1. Ejecute `run_reproduce_initial.sh` con **todos los IDs de instancia**.
2. Ejecute `run_localization.sh` con **todos los IDs de instancia**.
3. Para las instancias donde la reproducción tiene éxito (es decir, se genera un script válido `reproducer_X.py`), ejecute `generate_initial.py`.
4. Para las instancias restantes, ejecute `generate_w_memory.py`, que aprovecha la memoria acumulada y continúa actualizándola.
5. Finalmente, ejecute `validation.py` y `obtain_predictions.py` con todos los IDs de instancia.

### Uso


```bash
# reproduce the issue
bash inference/run_reproduce_initial.sh

# localize potential bug locations
bash inference/run_localization.sh

# generate candidate patches
bash inference/run_generate.sh

# validate candidate patches and select the best one
python inference/validation.py

# obtain the prediction results
python inference/obtain_predictions.py
```

## 🙏 Agradecimientos

* [SWE-bench](https://www.swebench.com/)
* [auto-code-rover](https://github.com/AutoCodeRoverSG/auto-code-rover)
* [Agentless](https://github.com/OpenAutoCoder/Agentless/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-22

---