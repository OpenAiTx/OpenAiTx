<div class="header" align="center">
<img alt="Frontier Station" height="300" src="https://github.com/new-frontiers-14/frontier-station-14/blob/master/Resources/Textures/_NF/Logo/logo.png?raw=true" />
</div>

Frontier Station es una bifurcación de [Space Station 14](https://github.com/space-wizards/space-station-14) que funciona sobre el motor [Robust Toolbox](https://github.com/space-wizards/RobustToolbox) escrito en C#.

Este es el repositorio principal de Frontier Station.

Si quieres alojar o crear contenido para Frontier Station, este es el repositorio que necesitas. Contiene tanto RobustToolbox como el paquete de contenido para el desarrollo de nuevos paquetes de contenido.

## Enlaces

<div class="header" align="center">  
[Discord](https://discord.gg/tpuAT7d3zm/) | [Steam](https://store.steampowered.com/app/1255460/Space_Station_14/) | [Patreon](https://www.patreon.com/frontierstation14) | [Wiki](https://frontierstation.wiki.gg/)
</div>

## Documentación/Wiki

Nuestra [wiki](https://frontierstation.wiki.gg/) contiene documentación sobre el contenido de Frontier Station.

## Contribuciones

Estamos felices de aceptar contribuciones de cualquier persona. Únete a Discord si quieres ayudar. Tenemos una [lista de ideas](https://discord.com/channels/1123826877245694004/1127017858833068114) que pueden hacerse y cualquiera puede tomarlas. ¡No tengas miedo de pedir ayuda tampoco!

Actualmente no aceptamos traducciones del juego en nuestro repositorio principal. Si deseas traducir el juego a otro idioma, considera crear una bifurcación o contribuir a una bifurcación existente.

Si realizas alguna contribución, por favor asegúrate de leer la sección de marcadores en [MARKERS.md](https://raw.githubusercontent.com/new-frontiers-14/frontier-station-14/master/MARKERS.md)  
Cualquier cambio realizado en archivos pertenecientes a nuestro upstream debe estar debidamente marcado según lo especificado allí.

## Compilación

1. Clona este repositorio:
```shell
git clone https://github.com/new-frontiers-14/frontier-station-14.git
```
2. Ve a la carpeta del proyecto y ejecuta `RUN_THIS.py` para inicializar los submódulos y cargar el motor:
```shell
cd frontier-station-14
python RUN_THIS.py
```
3. Compila la solución:  

Compila el servidor usando `dotnet build`.

[Instrucciones más detalladas sobre cómo compilar el proyecto.](https://docs.spacestation14.com/en/general-development/setup.html)

## Licencia

El contenido aportado a este repositorio después del commit 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 está licenciado bajo la Licencia Pública General Affero de GNU versión 3.0, a menos que se indique lo contrario (ver Atribuciones más abajo). Consulta `LICENSE-AGPLv3.txt`.  
El contenido aportado a este repositorio antes del commit 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 está licenciado bajo la licencia MIT, a menos que se indique lo contrario. Consulta `LICENSE-MIT.txt`.

[2fca06eaba205ae6fe3aceb8ae2a0594f0effee0](https://github.com/new-frontiers-14/frontier-station-14/commit/2fca06eaba205ae6fe3aceb8ae2a0594f0effee0) fue subido el 1 de julio de 2024 a las 16:04 UTC.

La mayoría de los recursos están licenciados bajo [CC-BY-SA 3.0](https://creativecommons.org/licenses/by-sa/3.0/) a menos que se indique lo contrario. Los recursos tienen su licencia y derechos de autor especificados en el archivo de metadatos. Por ejemplo, consulta los [metadatos de una palanca](https://raw.githubusercontent.com/new-frontiers-14/frontier-station-14/master/Resources/Textures/Objects/Tools/crowbar.rsi/meta.json).  

Ten en cuenta que algunos recursos están licenciados bajo la licencia no comercial [CC-BY-NC-SA 3.0](https://creativecommons.org/licenses/by-nc-sa/3.0/) u otras licencias similares no comerciales y deberán eliminarse si deseas usar este proyecto comercialmente.

## Atribuciones

Cuando incorporamos contenido de otras bifurcaciones, organizamos su contenido en subcarpetas específicas del repositorio para facilitar el seguimiento de atribuciones y limitar conflictos de fusión.

El contenido bajo estos subdirectorios proviene de sus respectivas bifurcaciones y puede contener modificaciones. Estas modificaciones se indican con comentarios alrededor de las líneas modificadas.

| Subdirectorio | Nombre del Fork | Repositorio del Fork | Licencia |
|---------------|----------------|---------------------|----------|
| `_NF` | Frontier Station | https://github.com/new-frontiers-14/frontier-station-14 | AGPL 3.0 |
| `_CD` | Cosmatic Drift | https://github.com/cosmatic-drift-14/cosmatic-drift | MIT |
| `_Corvax` | Corvax | https://github.com/space-syndicate/space-station-14 | MIT |
| `_Corvax` | Corvax Frontier | https://github.com/Corvax-Frontier/Frontier | AGPL 3.0 |
| `_DV` | Delta-V | https://github.com/DeltaV-Station/Delta-v | AGPL 3.0 |
| `_EE` | Einstein Engines | https://github.com/Simple-Station/Einstein-Engines | AGPL 3.0 |
| `_Emberfall` | Emberfall | https://github.com/emberfall-14/emberfall | MPL 2.0 |
| `_EstacaoPirata` | Estacao Pirata | https://github.com/Day-OS/estacao-pirata-14 | AGPL 3.0 |
| `_Goobstation` | Goob Station | https://github.com/Goob-Station/Goob-Station | AGPL 3.0 |
| `_Impstation` | Impstation | https://github.com/impstation/imp-station-14 | AGPL 3.0 |
| `_NC14` | Nuclear 14 | https://github.com/Vault-Overseers/nuclear-14 | AGPL 3.0 |
| `Nyanotrasen` | Nyanotrasen | https://github.com/Nyanotrasen/Nyanotrasen | MIT |

Repositorios adicionales de los que hemos adaptado características sin subdirectorios se listan a continuación.

| Nombre del Fork | Repositorio del Fork | Licencia |
|-----------------|---------------------|----------|
| Monolith | https://github.com/Monolith-Station/Monolith | AGPL 3.0 |
| Space Station 14 | https://github.com/space-wizards/space-station-14 | MIT |
| White Dream | https://github.com/WWhiteDreamProject/wwdpublic | AGPL 3.0 |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---