# Publicar extensión de VS Code &#8212; Acción de GitHub

[![Build, Lint, Test and Deploy](https://img.shields.io/github/actions/workflow/status/HaaLeo/publish-vscode-extension/CI.yml?style=flat-square&label=Lint%2C%20Build%2C%20Test%20and%20Deploy)](https://github.com/HaaLeo/publish-vscode-extension/actions?query=workflow%3A%22Build%2C+Lint%2C+Test+and+Deploy%22) [![Coverage Status](https://img.shields.io/coveralls/github/HaaLeo/publish-vscode-extension?style=flat-square)](https://coveralls.io/github/HaaLeo/publish-vscode-extension)  
[![License](https://img.shields.io/badge/license-MIT-brightgreen.svg?style=flat-square)](https://raw.githubusercontent.com/HaaLeo/publish-vscode-extension/master/LICENSE.txt) [![Stars](https://img.shields.io/github/stars/HaaLeo/publish-vscode-extension.svg?label=Stars&logo=github&style=flat-square)](https://github.com/HaaLeo/publish-vscode-extension/stargazers)  
[![Donate](https://img.shields.io/badge/☕️-Buy%20Me%20a%20Coffee-blue.svg?&style=flat-square)](https://www.paypal.me/LeoHanisch/3eur)

Acción de GitHub para publicar tu extensión de VS Code en el [Open VSX Registry](https://open-vsx.org/) o en el [Visual Studio Marketplace](https://marketplace.visualstudio.com).

> Todos los cambios importantes de **v2** están listados en el [registro de cambios](https://raw.githubusercontent.com/HaaLeo/publish-vscode-extension/master/CHANGELOG.md#changelog)

## Uso

Para usar la Acción de GitHub, solo tienes que [referenciar la acción](https://help.github.com/en/actions/configuring-and-managing-workflows/configuring-a-workflow#referencing-actions-in-your-workflow) en el archivo de tu flujo de trabajo.

### Ejemplo

El siguiente ejemplo muestra un flujo de trabajo que publica una extensión tanto en el Open VSX Registry como en el Visual Studio Marketplace cuando se crea una nueva etiqueta:

```yaml
on:
  push:
    tags:
      - "*"

name: Deploy Extension
jobs:
  deploy:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4
      - uses: actions/setup-node@v4
        with:
          node-version: 20
      - run: npm ci
      - name: Publish to Open VSX Registry
        uses: HaaLeo/publish-vscode-extension@v2
        with:
          pat: ${{ secrets.OPEN_VSX_TOKEN }}
      - name: Publish to Visual Studio Marketplace
        uses: HaaLeo/publish-vscode-extension@v2
        with:
          pat: ${{ secrets.VS_MARKETPLACE_TOKEN }}
          registryUrl: https://marketplace.visualstudio.com
```
Para empaquetar la extensión solo una vez y publicar el archivo `.vsix` **idéntico** en ambos registros, se pueden usar los siguientes dos pasos en su lugar:


```yaml
- name: Publish to Open VSX Registry
  uses: HaaLeo/publish-vscode-extension@v2
  id: publishToOpenVSX
  with:
    pat: ${{ secrets.OPEN_VSX_TOKEN }}
- name: Publish to Visual Studio Marketplace
  uses: HaaLeo/publish-vscode-extension@v2
  with:
    pat: ${{ secrets.VS_MARKETPLACE_TOKEN }}
    registryUrl: https://marketplace.visualstudio.com
    extensionFile: ${{ steps.publishToOpenVSX.outputs.vsixPath }}
```
Para un ejemplo más completo y complejo, se puede consultar el flujo de trabajo de [`HaaLeo/vscode-timing`](https://github.com/HaaLeo/vscode-timing/blob/master/.github/workflows/cicd.yml#L1).

### Registro Open VSX

Para publicar en el Registro Open VSX, asegúrate de que el [namespace de tu extensión](https://github.com/eclipse/openvsx/wiki/Publishing-Extensions#2-create-the-namespace) fue creado **previamente**.
Necesitas configurar el parámetro `pat` con tu [token de acceso de Open VSX](https://github.com/eclipse/openvsx/wiki/Publishing-Extensions#1-create-an-access-token).
Además, debes asegurarte de publicar únicamente una extensión que esté licenciada.
Para más información sobre la línea temporal de Open VSX y la licencia de sus extensiones, consulta el [blog de Brian King](https://blogs.eclipse.org/post/brian-king/open-vsx-registry-under-new-management) (sección "Licensing" y "Timeline").

Actualmente, esta acción de GitHub permite publicar extensiones que no especifican sus términos de licencia.
Sin embargo, este comportamiento está obsoleto y una futura versión de esta acción rechazará extensiones sin licencia.
Por lo tanto, te recomiendo encarecidamente publicar una extensión con una licencia (permisiva) como la [licencia MIT](https://choosealicense.com/licenses/mit/).

### Visual Studio Marketplace

Para subir tu extensión al VS Marketplace, necesitas configurar la opción `pat` con el correspondiente [token de acceso](https://code.visualstudio.com/api/working-with-extensions/publishing-extension#get-a-personal-access-token). 
Además, la opción `registryUrl` debe establecerse en `https://marketplace.visualstudio.com`.


## Parámetros de entrada

Puedes configurar cualquiera o todos los siguientes parámetros de entrada:

|Nombre |Tipo |¿Requerido? |Por defecto |Descripción
|-|-|-|-|-
|`pat` |string  |sí |-|El token de acceso personal para el registro correspondiente.
|`extensionFile` |string  |no | - |Ruta al archivo vsix que será publicado. Esta opción tendrá preferencia cuando se establezca junto con `packagePath`.
|`registryUrl` |string  |no |`https://open-vsx.org` |Usar la API del registro en esta URL base
|`packagePath` |string |no | `./` |Ruta a la extensión que se empaquetará y publicará. Cuando `extensionFile` también está configurado, se ignora `packagePath`.
|`baseContentUrl` |string |no | - | Anteponer esta URL a todos los enlaces relativos en README.md.
|`baseImagesUrl` |string |no | - | Anteponer esta URL a todos los enlaces relativos de imágenes en README.md.
|`yarn` |boolean |no | `false` | Usar yarn en lugar de npm para empaquetar los archivos de la extensión.
|`dryRun` |boolean |no | `false` | Establecer esta opción en `true` para empaquetar tu extensión pero no publicarla. Al usar esta opción, configura `pat` con un valor ficticio.
|`noVerify` |boolean| no |`false` | Permitir publicar extensiones en el Visual Studio Marketplace que usan una API propuesta (enableProposedApi: true). Similar al argumento de línea de comando `--noVerify` de vsce.
|`preRelease` |boolean| no |`false` | Marcar la versión de la extensión como pre-lanzamiento. Solo se considera al empaquetar una extensión.
|`dependencies` |boolean| no |`true` | Verificar que las dependencias definidas en `package.json` existan en `node_modules`. Establecer en `false` si se usa pnpm o yarn v2+ con PnP.
|`skipDuplicate` |boolean| no |`false` | Fallar silenciosamente si la versión ya existe en el marketplace. Equivalente a la opción `--skip-duplicate` de la CLI de vsce.
|`target` |string| no | - | Arquitectura(s) objetivo en las que debe ejecutarse la extensión. Separe múltiples objetivos con espacios. Ejemplo: `'win32-x64 linux-x64'`


## Salidas

La acción expone las siguientes salidas:

|Nombre |Tipo |Descripción
|-|-|-
|`vsixPath` |string |La ruta al archivo VSIX empaquetado y publicado.

## Contribución

Si encontraste un error o falta una función no dudes en [abrir un issue](https://github.com/HaaLeo/publish-vscode-extension/issues/new/choose).  
¡Los Pull Requests son bienvenidos!
Para comenzar a enviar cambios de código, por favor revisa primero el archivo [CONTRIBUTING.md](https://raw.githubusercontent.com/HaaLeo/publish-vscode-extension/master/./CONTRIBUTING.md).

## Soporte

Si te gusta esta extensión asegúrate de [darle una estrella al repositorio](https://github.com/HaaLeo/publish-vscode-extension/stargazers). Siempre estoy buscando nuevas ideas y retroalimentación.  
Además, es posible [donar vía paypal](https://www.paypal.me/LeoHanisch/3eur).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-07

---