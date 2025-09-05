# Fjira - Buscador difuso y aplicación TUI para Jira.

<img src="https://raw.githubusercontent.com/mk-5/fjira/master/fjira.png" alt="drawing" width="256"/>

[![Mentioned in Awesome Go](https://awesome.re/badge-flat.svg)](https://github.com/avelino/awesome-go)
![Test](https://github.com/mk-5/fjira/actions/workflows/tests.yml/badge.svg)
[![License: AGPL v3](https://img.shields.io/badge/License-AGPL%20v3-blue.svg)](https://github.com/mk-5/fjira/blob/master/LICENSE)
![GitHub release (latest by date)](https://img.shields.io/github/v/release/mk-5/fjira)
[![Go Report Card](https://goreportcard.com/badge/github.com/mk-5/fjira)](https://goreportcard.com/report/github.com/mk-5/fjira)
[![Go Reference](https://pkg.go.dev/badge/github.com/mk-5/fjira.svg)](https://pkg.go.dev/github.com/mk-5/fjira)
[![codecov](https://codecov.io/gh/mk-5/fjira/branch/master/graph/badge.svg?token=MJBTMYGQQW)](https://codecov.io/gh/mk-5/fjira)

## Introducción

Fjira es una potente herramienta de línea de comandos diseñada para simplificar tus interacciones con Jira. Ya seas desarrollador,
gerente de proyecto o simplemente un entusiasta de Jira, Fjira optimiza tu flujo de trabajo, haciendo las tareas en Jira más eficientes que nunca.

![Fjira Demo](https://raw.githubusercontent.com/mk-5/fjira/master/demo.gif)

## Características clave

- **Interfaz de búsqueda difusa:** Busca proyectos e incidencias de Jira con facilidad.
- **Control de asignados:** Cambia rápidamente los asignados de una incidencia sin navegar por la interfaz de Jira.
- **Actualizaciones de estado:** Actualiza los estados de las incidencias de Jira directamente desde tu terminal.
- **Comentarios eficientes:** Añade comentarios fácilmente a las incidencias de Jira.
- **Soporte multi-espacio de trabajo:** Gestiona múltiples espacios de trabajo de Jira sin esfuerzo.
- **Búsquedas personalizadas:** Usa Jira Query Language (JQL) para búsquedas a medida.
- **Acceso directo desde CLI:** Accede a las incidencias de Jira directamente desde la línea de comandos.
- **Compatibilidad multiplataforma:** Funciona sin problemas en macOS, Linux y Windows.

## Instalación

### macOS


```shell
brew tap mk-5/mk-5
brew install fjira
```

### Linux

#### Ubuntu/Snap

```shell
snap install fjira
```

#### Deb

Visite [https://github.com/mk-5/fjira/releases/latest](https://github.com/mk-5/fjira/releases/latest), y obtenga la
última versión disponible.

```shell
sudo dpkg -i fjira_0.4.0_linux_amd64.deb
```

#### AUR

```sh
yay -S fjira
```

#### Binario

```shell
tar -xvzf fjira_0.4.0_Linux_x86_64.tar.gz
cp fjira /usr/local/bin/fjira
```

### Windows

```shell
choco install fjira
```

### Construir desde las fuentes

```shell
make
./out/bin/fjira
```

## Uso

```text
Usage:
  fjira [flags]
  fjira [command]

Available Commands:
  [issueKey]  Open a Jira issue directly from the CLI
  completion  Generate the autocompletion script for the specified shell
  filters     Search using Jira filters
  help        Help about any command
  jql         Search using custom JQL queries
  version     Print the version number of fjira
  workspace   Switch to a different workspace

Flags:
  -h, --help             help for fjira
  -p, --project string   Open a project directly from CLI

Additional help topics:
  fjira            Open a fuzzy finder for projects as a default action

Use "fjira [command] --help" for more information about a command.
```

## Comenzando

Usar el CLI de Fjira es sencillo. Simplemente ejecuta fjira en tu terminal.

```shell
fjira
```

## Espacios de trabajo

La primera vez que ejecutes Fjira, te solicitará la URL de la API de Jira y el token.

![Primera ejecución de Fjira](https://raw.githubusercontent.com/mk-5/fjira/master/demo_first_run.gif)

Los espacios de trabajo de Fjira almacenan los datos de configuración de Jira en un archivo YAML simple ubicado en `~/.fjira`. Puedes cambiar entre
múltiples espacios de trabajo usando el comando `fjira workspace`.

```shell
fjira workspace
```

Para crear un nuevo espacio de trabajo, utilice el siguiente comando:

```shell
fjira workspace --new abc
```

Puedes editar un espacio de trabajo existente usando la bandera `--edit`:

```shell
fjira workspace --edit abc
```

### Tipo de Token de Jira

Fjira soporta tanto Jira Server como Jira Cloud, que utilizan diferentes tipos de token para la autorización. La herramienta te pedirá
que selecciones el tipo de token adecuado durante la configuración del espacio de trabajo.

```shell
? Jira Token Type:

1. api token
2. personal token

Enter a number (Default is 1):
```

### Configuración YAML

Si prefieres un enfoque manual, tienes la opción de agregar configuraciones de espacio de trabajo creando un archivo `fjira.yaml` en el directorio `~/.fjira/`.  
Para tu conveniencia, aquí tienes un archivo de configuración de ejemplo: [fjira.yml](https://raw.githubusercontent.com/mk-5/fjira/master/assets/fjira.yaml)

## Búsqueda de proyectos

La vista predeterminada cuando ejecutas `fjira` es la pantalla de búsqueda de proyectos.

```shell
fjira
```

## Abrir un Proyecto Específico

Puedes abrir un proyecto directamente desde la CLI:

```shell
fjira --project=PROJ
```

Esto omitirá la pantalla de búsqueda de proyectos y te llevará directamente a la pantalla de búsqueda de incidencias.

## Abrir una incidencia directamente

Para abrir una incidencia directamente desde la CLI:

```shell
fjira PROJ-123
```

Fjira omitirá todas las pantallas intermedias y te llevará directamente a la vista del problema.

![Vista del problema en Fjira](https://raw.githubusercontent.com/mk-5/fjira/master/demo_issue.png)

## Vista de Tableros

Fjira también ofrece una vista tipo tablero. Después de abrir un proyecto, presiona F4 para acceder a esta vista.

![Vista del tablero en Fjira](https://raw.githubusercontent.com/mk-5/fjira/master/demo_board_view.png)

## Consultas JQL Personalizadas

Puedes crear y ejecutar consultas JQL personalizadas con Fjira:

```shell
fjira jql
```

![Fjira Custom JQL](https://raw.githubusercontent.com/mk-5/fjira/master/demo_custom_jql.png)

## My Jira Filters

You can search using your stored (favourites) Jira Filters:

```shell
fjira filters
```

![Filtros Fjira](https://raw.githubusercontent.com/mk-5/fjira/master/demo_filters.png)

## Esquema de Color Personalizado

Adapta el esquema de colores de fjira para que coincida con tus preferencias creando un archivo personalizado `~/.fjira/colors.yml`. Este archivo
te permite personalizar los colores según tu estilo único.
Consulta el archivo de ejemplo, ubicado aquí: [colors.yml](https://raw.githubusercontent.com/mk-5/fjira/master/assets/colors.yml)

## Hoja de Ruta (TODO)

- Ampliar la Documentación
- Crear y Eliminar Filtros de Jira
- Soportar Más Gestores de Paquetes Linux (Apt, AUR, YUM)
- Introducir Más Funcionalidades de Jira

## Motivación

Fjira fue diseñado para la conveniencia personal, nacido del deseo de eficiencia y amor por las herramientas de terminal.
A menudo, nos encontramos en la situación de "Solo necesito cambiar el estado del issue 123." Mientras abrir Jira, localizar el
ticket en el tablero y navegar por el modal del issue de Jira está bien, consume bastante tiempo.

Fjira te permite ejecutar estas tareas directamente desde la terminal, ¡donde probablemente ya estás trabajando! 😄

Si Fjira mejora tu experiencia con Jira como lo hizo conmigo, por favor considera darle una estrella en GitHub. 🌟 Eso me dará
impulso para futuros trabajos.

Siéntete libre de contribuir a este proyecto y ayudar a moldear su futuro. Tus comentarios y contribuciones son muy
apreciados.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---