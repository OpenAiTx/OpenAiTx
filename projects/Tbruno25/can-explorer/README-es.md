<h1 align="center">
  <a href="https://github.com/tbruno25/can-explorer">
    <!-- Por favor proporcione la ruta a su logo aquí -->
    <img src="https://github.com/Tbruno25/can-explorer/raw/main/docs/images/logo.png" alt="Logo" width="200" height="200">
  </a>
</h1>

<div align="center">
  can-explorer
  <br />
  <a href="https://github.com/tbruno25/can-explorer/issues/new?assignees=&labels=bug&template=01_BUG_REPORT.md&title=bug%3A+">Reportar un Error</a>
  ·
  <a href="https://github.com/tbruno25/can-explorer/issues/new?assignees=&labels=enhancement&template=02_FEATURE_REQUEST.md&title=feature%3A+">Solicitar una Funcionalidad</a>
  ·
  <a href="https://github.com/tbruno25/can-explorer/issues/new?assignees=&labels=question&template=04_SUPPORT_QUESTION.md&title=support%3A+">Hacer una Pregunta</a>
</div>

<div align="center">
<br/>


[![PyPI version](https://img.shields.io/pypi/v/can-explorer?color=mediumseagreen)](https://pypi.org/project/can-explorer/)
[![Python Versions](https://img.shields.io/pypi/pyversions/can-explorer?color=mediumseagreen)](https://pypi.org/project/can-explorer/)
[![Stars](https://img.shields.io/github/stars/tbruno25/can-explorer?color=mediumseagreen)](https://github.com/Tbruno25/can-explorer/stargazers)
</div>

---

## Acerca de

`can-explorer` es una herramienta de visualización de bus CAN diseñada para ayudar en la ingeniería inversa.

![Demo](https://github.com/Tbruno25/can-explorer/raw/main/docs/images/demo.gif)

### ¿Cómo me ayuda esto?
Al graficar continuamente todas las cargas útiles para cada ID CAN, detectar tendencias que correspondan a una acción específica puede volverse significativamente más fácil de identificar. 

Por favor refiérase a este [artículo previo](https://tbruno25.medium.com/car-hacking-faster-reverse-engineering-using-canopy-be1955843d57) que escribí para un ejemplo práctico de cómo este enfoque puede usarse para encontrar qué ID incluye datos del velocímetro.


### Construido Con


[![DearPyGui](https://github.com/Tbruno25/can-explorer/raw/main/docs/images/dearpygui-logo.png)](https://github.com/hoffstadt/DearPyGui)
[![PythonCan](https://github.com/Tbruno25/can-explorer/raw/main/docs/images/pythoncan-logo.png)](https://github.com/hardbyte/python-can)

## Comenzando

### Instalación

[pipx](https://pypa.github.io/pipx/) es recomendado aunque cualquier gestor de paquetes que soporte archivos `pyproject.toml` puede ser usado.

```sh
pipx install can-explorer
``` 

## Uso

La interfaz gráfica puede iniciarse ejecutando uno de los siguientes comandos desde una terminal.
```sh 
can-explorer
``` 

```sh 
python3 -m can_explorer
``` 
Antes de iniciar el visor, ***debe*** navegar a la pestaña de configuración e ingresar la configuración de su adaptador de interfaz para crear una instancia de bus. Por favor, consulte la [documentación de python-can](https://python-can.readthedocs.io/en/stable/index.html) para obtener más información sobre las diversas interfaces compatibles. 

La interfaz gráfica también se puede iniciar con una bandera de demostración que seleccionará automáticamente la opción de interfaz virtual y comenzará a transmitir datos CAN simulados en un proceso en segundo plano.


```sh 
can-explorer --demo
``` 
## Soporte

Comunícate con el mantenedor en uno de los siguientes lugares:
- [Incidencias en GitHub](https://github.com/tbruno25/can-explorer/issues/new?assignees=&labels=question&template=04_SUPPORT_QUESTION.md&title=support%3A+)
- Opciones de contacto listadas en [este perfil de GitHub](https://github.com/tbruno25)

Si quieres decir **gracias** o/y apoyar el desarrollo activo de can-explorer considera añadir una [Estrella de GitHub](https://github.com/tbruno25/can-explorer) al proyecto.


## Contribuciones

Por favor lee [nuestras directrices de contribución](https://raw.githubusercontent.com/Tbruno25/can-explorer/main/docs/CONTRIBUTING.md)

Para una lista completa de todos los autores y colaboradores, consulta [la página de colaboradores](https://github.com/tbruno25/can-explorer/contributors).

## Licencia

Este proyecto está licenciado bajo la **Licencia Pública General GNU v3**.

Consulta [LICENSE](LICENSE) para más información.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---