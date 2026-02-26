# Pokemon Red (Edición RL)

![Tests](https://github.com/thatguy11325/pokemonred_puffer/actions/workflows/workflow.yml/badge.svg)

Este repositorio está diseñado como una biblioteca para ser utilizada en el desarrollo de Pokemon Red RL. Contiene algunas funciones de conveniencia que no deberían usarse en un entorno de biblioteca y deberían bifurcarse. En el futuro, esas funciones de conveniencia serán migradas para que no sea necesario bifurcar.

## Inicio rápido

### Instalación

Para instalar la biblioteca puedes

1. Clonar el repositorio en tu máquina local e instalarlo.
2. Bifurcar el repositorio y clonar tu bifurcación en tu máquina local.

Por ejemplo,

```sh
pip3 install -e . 
```

### Ejecución

A continuación se muestran comandos que usan argumentos predeterminados en algunos casos. Por favor, ejecute `python3 -m pokemonred_puffer.train --help` si no está seguro de cómo usar las acciones de línea de comandos asociadas con este repositorio. Algunos comandos pueden no haber sido probados recientemente, así que por favor cree un problema si tiene uno.

Después de la instalación puede comenzar el entrenamiento ejecutando:

```sh
# Run before training to test what num_envs value you should use
python3 -m pokemonred_puffer.train autotune
# Default
python3 -m pokemonred_puffer.train train
```

### Barridos de Hiperparámetros Multinodo (en progreso)

Si desea ejecutar barridos de hiperparámetros, puede hacerlo instalando los paquetes relacionados y lanzando dos comandos:

```sh
pip3 install -e '.[sweep]'
python3 -m pokemonred_puffer.sweep launch-sweep
python3 -m pokemonred_puffer.sweep launch-agent <sweep-id>
```

El ID del sweep se imprimirá al iniciar el sweep. Para reanudar un sweep, puedes relanzar tu sweep con

```sh
python3 -m pokemonred_puffer.sweep launch-sweep --sweep-id <sweep-id>
```

Las exploraciones pueden configurarse con una configuración de exploración (por defecto `sweep-config.yaml`) y una configuración base (por defecto `config.yaml`). La exploración de hiperparámetros establece límites usando la configuración de exploración y centra los hiperparámetros en los parámetros de la configuración base. Para aprender más sobre el algoritmo de hiperparámetros, puedes visitar [el repositorio CARBS de Imbue](https://github.com/imbue-ai/carbs/tree/main).

N.B. Actualmente no se soportan exploraciones de un solo nodo. Si esta es una función deseada, por favor crea un issue.

### Modificación para Entrenamiento

Entonces tienes una ejecución en marcha, pero quieres modificarla, ¿qué haces?

Tienes algunas opciones:

1. Empieza a alterar parámetros en `config.yaml`
2. Empieza a modificar el código directamente (más adelante se explica).
3. Usa este repositorio como una librería y crea tus propios wrappers.

### Depuración
Si quieres probar tus cambios puedes ejecutar 

```sh
python3 -m pokemonred_puffer.train --config config.yaml --debug
```

En casos de emergencia, se recomienda eliminar las llamadas a la función `send_input` de `environment.py` para que puedas probar las recompensas en tu propio horario y no en el del modelo.

## Estructura del Directorio

Este repositorio está destinado a ser utilizado eventualmente como una biblioteca. Todos los archivos fuente deben estar bajo el directorio `pokemonred_puffer`. Si quieres agregar un módulo con un `__main__`, siéntete libre de hacerlo, pero bajo el directorio `pokemonred_puffer`. Después, deberías poder ejecutar tu main con `python3 -m pokemonred_puffer.<tu-módulo>`

Dentro del directorio `pokemonred_puffer` hay los siguientes archivos y directorios:

- `policies`: Un directorio para diferentes políticas para ejecutar el modelo.
- `rewards`: Un directorio de clases `gym.Env` que registran recompensas para un objeto `RedGymEnv` (entorno gym para Pokemon Red).
- `wrappers`: Un directorio de envoltorios que podrías querer usar, por ejemplo, para registrar en el [Visualizador de Mapas de Pokemon Red](https://pwhiddy.github.io/pokerl-map-viz/).
- `cleanrl_puffer.py` - Responsable de ejecutar la lógica de entrenamiento real.
- `environment.py` - La lógica central del Entorno Gym de Pokemon Red.
- `eval.py` - Para generar visualizaciones para el registro durante el entrenamiento.
- `kanto_map_dsv.png` - Un mapa de alta resolución de la región de Kanto.
- `train.py` - Un script y punto de entrada para comenzar el entrenamiento.

## Realizar Cambios

Para cambios simples, puedes actualizar `config.yaml` directamente. `config.yaml` tiene algunas reglas importantes. Para `wrappers`, `rewards` y `policies`, el envoltorio, recompensa o política _debe_ estar claveado por `module_name.class_name`. Estas secciones pueden contener múltiples tipos de `wrappers`, `rewards` o `policies`. La estructura general es `etiqueta : argumentos para la clase`. Esto es hasta que se encuentre una mejor forma con menos indirectas.

### Añadir Wrappers

Para añadir envoltorios, agrega una nueva clase que herede de `gym.Wrapper` en el directorio `wrappers`. Luego actualiza la sección `wrappers` de `config.yaml`. Los envoltorios envuelven el entorno base en orden, de arriba hacia abajo. La lista de envoltorios _no_ está claveada por la ruta de la clase. Es un nombre único que distingue la colección de envoltorios.

### Añadir Recompensas

Para añadir recompensas, agrega una nueva clase en el directorio `rewards`. Luego actualiza la sección `rewards` de `config.yaml`. Una sección de recompensa está claveada por la ruta de la clase.

### Añadir Políticas

Para añadir políticas, agrega una nueva clase en el directorio `policies`. Luego actualiza la sección `policies` de `config.yaml`. Una sección de política está claveada por la ruta de la clase. Se asume que una política recurrente vivirá en el mismo módulo que la política que envuelve.

## Desarrollo

Este repositorio usa [pre-commit](https://pre-commit.com/) para hacer cumplir el formato y linting. Para desarrollo, por favor instala este repositorio con:

```sh
pip3 install -e '.[dev]'
pre-commit install
```

Para cualquier cambio, por favor envíe un PR.

## Autores

[David Rubinstein](https://github.com/drubinstein), [Keelan Donovan](https://github.com/leanke), [Daniel Addis](https://github.com/xinpw8), Kyoung Whan Choe, [Joseph Suarez](https://puffer.ai/), [Peter Whidden](https://peterwhidden.webflow.io/)

<a href="https://star-history.com/#drubinstein/pokemonred_puffer&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=drubinstein/pokemonred_puffer&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=drubinstein/pokemonred_puffer&type=Date" />
   <img alt="Gráfico de Historial de Estrellas" src="https://api.star-history.com/svg?repos=drubinstein/pokemonred_puffer&type=Date" />
 </picture>
</a>

[![](https://raw.githubusercontent.com/drubinstein/pokemonred_puffer/main/assets/puffer.png)](https://puffer.ai)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-26

---