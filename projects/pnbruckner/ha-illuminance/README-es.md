# <img src="https://brands.home-assistant.io/illuminance/icon.png" alt="Sun2 Sensor" width="50" height="50"/> Sensor de Iluminancia
Crea una entidad `sensor` que estima la iluminancia exterior basada en la elevación del sol o en la hora del día.  
En cualquiera de los casos, el valor puede ajustarse adicionalmente según las condiciones meteorológicas actuales o la cobertura nubosa obtenida de otra entidad ya existente.

## Modos de operación
Hay tres modos disponibles: normal, irradiancia y simple.

### Modos Normal/Irradiancia - Elevación solar
Estos modos utilizan un algoritmo del Observatorio Naval de EE. UU.[^1] para estimar la iluminancia o irradiancia solar basándose en la elevación (también llamada altitud) del sol. El valor máximo de iluminancia es aproximadamente 150,000 lx, y el valor máximo de irradiancia es aproximadamente 1,250 Watts/m².  
A continuación se muestra un ejemplo de cómo podría verse la iluminancia durante un período de tres días.

<p align="center">
  <img src=images/normal.png>
</p>

[^1]: Janiczek, P. M., y DeYoung, J. A. _Computer Programs for Sun and Moon Illuminance With Contingent Tables and Diagrams_. Circular No. 171. Washington, D. C.: United States Naval Observatory, 1987 [Google Scholar](https://scholar.google.com/scholar_lookup?title=Computer%20programs%20for%20sun%20and%20moon%20illuminance%20with%20contingent%20tables%20and%20diagrams&author=P.%20M.%20Janiczek&author=J.%20A.%20Deyoung&publication_year=1987&book=Computer%20programs%20for%20sun%20and%20moon%20illuminance%20with%20contingent%20tables%20and%20diagrams)

### Modo Simple - Hora del día
Durante la noche el valor es 10 lx. Desde un poco antes del amanecer hasta un poco después, el valor se incrementa gradualmente según indiquen las condiciones actuales. Lo mismo ocurre alrededor del atardecer, excepto que el valor disminuye gradualmente. Por razones históricas, el valor máximo es 10,000 lx. A continuación se muestra un ejemplo de cómo podría verse esto durante un período de tres días.

<p align="center">
  <img src=images/simple.png>
</p>

## Fuentes meteorológicas soportadas
Cualquier entidad meteorológica que use la [lista estándar de condiciones](https://www.home-assistant.io/integrations/weather/#condition-mapping), o que proporcione un porcentaje de cobertura nubosa, debería funcionar con esta integración.  
Las siguientes fuentes de datos meteorológicos son conocidas por ser compatibles:

Integración | Notas
-|-
[AccuWeather](https://www.home-assistant.io/integrations/accuweather/) | `weather`
[Buienradar](https://www.home-assistant.io/integrations/buienradar/) | `weather`
[ecobee](https://www.home-assistant.io/integrations/ecobee/) |
[Meteorologisk institutt (Met.no)](https://www.home-assistant.io/integrations/met/) | `weather`
[OpenWeatherMap](https://www.home-assistant.io/integrations/openweathermap/) | `weather`; `sensor` de cobertura nubosa y condición

## Instalación

Primero debe instalarse el software de la integración como un componente personalizado.

Puedes usar HACS para gestionar la instalación y proporcionar notificaciones de actualización.  
O puedes instalar el software manualmente.  

<details>  
<summary>Con HACS</summary>  

[![hacs_badge](https://img.shields.io/badge/HACS-Custom-41BDF5.svg)](https://hacs.xyz/)  

1. Añade este repositorio como un [repositorio personalizado](https://hacs.xyz/docs/faq/custom_repositories/):  
   Debería aparecer entonces como una nueva integración. Haz clic en él. Si es necesario, busca "illuminance".
   ```text
   https://github.com/pnbruckner/ha-illuminance
   ```
   O usa este botón:
  
   [![Abre tu instancia de Home Assistant y abre un repositorio dentro de la Tienda Comunitaria de Home Assistant.](https://my.home-assistant.io/badges/hacs_repository.svg)](https://my.home-assistant.io/redirect/hacs_repository/?owner=pnbruckner&repository=ha-illuminance&category=integration)

1. Descarga la integración usando el botón apropiado.

</details>

<details>
<summary>Instalación Manual</summary>

Coloca una copia de los archivos de [`custom_components/illuminance`](custom_components/illuminance)
en `<config>/custom_components/illuminance`,
donde `<config>` es el directorio de configuración de tu Home Assistant.

>__NOTA__: Al descargar, asegúrate de usar el botón `Raw` en la página de cada archivo.

</details>

### Post Instalación

Después de descargarla, necesitarás reiniciar Home Assistant.

### Versiones

Esta integración personalizada soporta versiones de HomeAssistant 2024.8.3 o superiores.

## Servicios

### `illuminance.reload`

Recarga Illuminance desde la configuración YAML. También añade `ILLUMINANCE` a la página de Herramientas para Desarrolladores -> YAML.

## Variables de configuración

Una lista de opciones de configuración para uno o más sensores. Cada sensor se define por las siguientes opciones.

> Nota: Esto define la configuración vía YAML. Sin embargo, los mismos sensores pueden añadirse en la interfaz de usuario.

Clave | Opcional | Descripción
-|-|-
`unique_id` | no | Identificador único para el sensor. Esto permite que cualquiera de las opciones restantes se cambie sin que parezca un sensor nuevo. (Solo requerido para configuración basada en YAML.)
`entity_id` | sí | ID de entidad de otra entidad que indica las condiciones meteorológicas actuales o el porcentaje de cobertura de nubes.
`fallback` | sí | Divisor de iluminancia a usar cuando no hay datos meteorológicos disponibles. Debe estar en el rango de 1 (despejado) a 10 (oscuro). El valor predeterminado es 10 si se usa `entity_id`, o 1 si no.
`mode` | sí | Modo de operación. Las opciones son `normal` (predeterminado) que usa la elevación del sol, `simple` que usa la hora del día y `irradiance` que es igual a `normal`, excepto que el valor se expresa como irradiancia en Watts/M².
`name` | sí | Nombre del sensor. El valor predeterminado es `Illuminance`.
`scan_interval` | sí | Intervalo de actualización. El mínimo es 30 segundos. El valor predeterminado es 5 minutos.

## Versiones anteriores a la 2.1.0
Ver https://github.com/pnbruckner/homeassistant-config/blob/master/docs/illuminance.md.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-28

---