<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://github.com/Andarius/piou/raw/master/docs/static/piou-dark.png">
  <source media="(prefers-color-scheme: light)" srcset="https://github.com/Andarius/piou/raw/master/docs/static/piou.jpg">
  <img alt="Logo de Piou"
    src="https://github.com/Andarius/piou/raw/master/docs/static/piou.jpg"
    width="250"/>
</picture>

# Piou

[![Versiones de Python](https://img.shields.io/pypi/pyversions/piou)](https://pypi.python.org/pypi/piou)
[![Última versión en PyPI](https://img.shields.io/pypi/v/piou?logo=pypi)](https://pypi.python.org/pypi/piou)
[![CI](https://github.com/Andarius/piou/actions/workflows/ci.yml/badge.svg)](https://github.com/Andarius/piou/actions/workflows/ci.yml)
[![Última versión en conda-forge](https://img.shields.io/conda/vn/conda-forge/piou?logo=conda-forge)](https://anaconda.org/conda-forge/piou)

Una herramienta CLI para construir hermosas interfaces de línea de comandos con validación de tipos.

## Ejemplo rápido

```python
from piou import Cli, Option

cli = Cli(description='A CLI tool')


@cli.command(cmd='foo', help='Run foo command')
def foo_main(
        bar: int = Option(help='Bar positional argument (required)'),
        baz: str = Option('-b', '--baz', help='Baz keyword argument (required)'),
        foo: str | None = Option(None, '--foo', help='Foo keyword argument'),
):
    """
    A longer description on what the function is doing.
    """
    pass


if __name__ == '__main__':
    cli.run()
```

![example](https://github.com/Andarius/piou/raw/master/docs/static/simple-output.svg)

## Installation

```bash
pip install piou
```

O con [uv](https://docs.astral.sh/uv/):

```bash
uv add piou
```

O con [conda](https://docs.conda.io/):

```bash
conda install piou -c conda-forge
```

### Formateador en Crudo

Por defecto, Piou utiliza [Rich](https://github.com/Textualize/rich) para una salida hermosa en la terminal. Si prefieres una salida en texto plano, puedes usar el formateador en crudo:

```bash
# Force raw output via environment variable
PIOU_FORMATTER=raw python your_cli.py --help
```

## Documentación

La documentación completa está disponible en **[andarius.github.io/piou](https://andarius.github.io/piou)**.

### Características

- Experiencia de desarrollo similar a FastAPI con indicaciones de tipo
- Formateadores personalizados (basados en Rich por defecto)
- Grupos de comandos anidados / subcomandos
- Opciones derivadas para patrones reutilizables de argumentos
- Soporte para comandos asíncronos
- Validación y conversión de tipos
- **Modo TUI interactivo** con sugerencias de comandos e historial
- **Ayuda JSON estructurada** (`--help-json`) para herramientas y descubrimiento programático de CLI

## ¿Por qué Piou?

No pude encontrar una biblioteca que ofreciera:

- La misma experiencia de desarrollo que [FastAPI](https://fastapi.tiangolo.com/)
- Personalización de la interfaz (para construir una CLI similar a [Poetry](https://python-poetry.org/))
- Validación / conversión de tipos

[Typer](https://github.com/tiangolo/typer) es la alternativa más cercana pero carece de la posibilidad de formatear la salida de forma personalizada usando librerías externas (como [Rich](https://github.com/Textualize/rich)).

**Piou** ofrece todas estas posibilidades y te permite definir tu propio Formateador.

## Comandos Asíncronos

Los comandos pueden ser funciones `async`: piou detecta las corutinas y las ejecuta automáticamente, sin necesidad de `asyncio.run()` manual:

```python
from piou import Cli, Option

cli = Cli(description='Async example')

@cli.command(cmd='fetch', help='Fetch data')
async def fetch(url: str = Option(help='URL to fetch')):
    import niquests
    async with niquests.AsyncSession() as client:
        r = await client.get(url)
        print(r.status_code)

if __name__ == '__main__':
    cli.run()
```

Esto funciona de la misma manera para los comandos dentro de grupos de comandos.

## Modo TUI interactivo

Piou incluye un modo TUI (Interfaz de Usuario de Texto) interactivo opcional impulsado por [Textual](https://textual.textualize.io/).
Esto ofrece una experiencia rica en la terminal con sugerencias de comandos, historial y completaciones en línea.

### Instalación

```bash
pip install piou[tui]

# With auto-reload support for development
pip install piou[tui-reload]
```

### Uso

Habilite el modo TUI configurando `tui=True` al crear su CLI:

```python
from piou import Cli, Option

cli = Cli(description='My Interactive CLI', tui=True)

@cli.command(cmd='hello', help='Say hello')
def hello(name: str = Option(..., help='Name to greet')):
    print(f'Hello, {name}!')

if __name__ == '__main__':
    cli.run()
```

O mediante el indicador `--tui`:

```bash
python my_cli.py --tui
```

O mediante la variable de entorno `PIOU_TUI=1`:

```bash
PIOU_TUI=1 python my_cli.py
```

### Características de la TUI

- **Sugerencias de comandos**: Escribe `/` para ver los comandos disponibles con descripciones
- **Navegación de subcomandos**: Usa `:` para navegar subcomandos (p. ej., `/stats:uploads`)
- **Completaciones en línea**: Ve marcadores de posición de argumentos mientras escribes
- **Historial de comandos**: Navega comandos previos con flechas arriba/abajo (persistente entre sesiones)
- **Salida enriquecida**: Colores ANSI y formato preservados en la salida
- **Atajos de teclado**:
  - `Tab` - Confirmar sugerencia seleccionada
  - `Arriba/Abajo` - Navegar sugerencias o historial
  - `Ctrl+C` - Limpiar entrada (presionar dos veces para salir)
  - `Escape` - Salir
- **Modo desarrollador**: Recarga automática de comandos cuando cambian archivos fuente (ver abajo)

<img alt="Demostración TUI" src="https://github.com/Andarius/piou/raw/master/docs/static/tui-demo.gif" width="600"/>

### Modo desarrollador con recarga automática

Para iterar más rápido en el desarrollo, activa el modo desarrollador para recargar automáticamente tus comandos cuando cambien los archivos fuente:

```bash
pip install piou[tui-reload]
```

Luego use la bandera `--tui-reload`:

```bash
python my_cli.py --tui-reload
```

O mediante variable de entorno:

```bash
PIOU_TUI_DEV=1 python my_cli.py --tui
```

Cuando está habilitado, Piou supervisa tus archivos fuente de comandos y los recarga automáticamente al guardar. También puedes alternar el modo de recarga en tiempo de ejecución con el comando `/tui-reload`.

Para ejecutar código personalizado después de cada recarga (por ejemplo, actualizar datos en caché), usa el decorador `@cli.tui_on_reload`:

```python
@cli.tui_on_reload
def on_reload():
    print('Code reloaded!')
```

### Ejemplo Avanzado: Benchmark HTTP

El modo TUI soporta montar widgets Textual personalizados para pantallas interactivas enriquecidas. Este ejemplo evalúa bibliotecas HTTP con tablas de progreso en vivo:

<img alt="Benchmark HTTP TUI" src="https://github.com/Andarius/piou/raw/master/docs/static/bench_1000.gif" width="700"/>

Vea [examples/http_bench_tui.py](https://raw.githubusercontent.com/Andarius/piou/master/examples/http_bench_tui.py) para la implementación completa usando `TuiContext` y widgets personalizados.

## Desarrollo

### Ejecución de Pruebas

```bash
uv run pytest
```

### Generación de Documentación

```bash
# Build docs
uv run --group docs mkdocs build

# Serve locally
uv run --group docs mkdocs serve
```

### Generación de capturas de pantalla y GIFs

Las grabaciones de terminal se crean con [VHS](https://github.com/charmbracelet/vhs). Instálalo primero:

```bash
# Ubuntu/Debian
sudo apt install vhs ttyd

# macOS
brew install vhs

# Or via Go
go install github.com/charmbracelet/vhs@latest
```

Luego genere grabaciones a partir de archivos de cinta:

```bash
vhs docs/static/tui-demo.tape
```

Los archivos de cinta se encuentran en `docs/static/` y definen sesiones de terminal guionizadas que producen GIFs.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-31

---