# Stixview

[![npm version](https://badge.fury.io/js/stixview.svg)](https://badge.fury.io/js/stixview)

[Stixview](https://github.com/traut/stixview) es una biblioteca JS para gráficos STIX2 interactivos y embebibles.

> [!NOTE]  
> La versión alojada de Stixview está disponible en [CTIChef.com](https://ctichef.com)

![Gráfico Stixview](https://raw.githubusercontent.com/traut/stixview/master/.github/stixview-graph.png)

## Motivación

CTI (Inteligencia de Amenazas Cibernéticas) se trata mucho de contar historias. La información se convierte en inteligencia cuando se complementa con un contexto y se coloca en una historia. Estas historias usualmente se cristalizan en los informes por un proveedor de inteligencia y se diseminan a los clientes.

Si el proveedor de inteligencia se preocupa por CTI estructurado y legible por máquina, los informes producidos estarán complementados con paquetes [STIX2](https://oasis-open.github.io/cti-documentation/). Existe una brecha entre una historia, narrada en un informe, y una instantánea de CTI estructurado, representada por un paquete STIX2.

El objetivo de la biblioteca [Stixview](https://github.com/traut/stixview) es proveer gráficos STIX2 fácilmente embebibles con el nivel necesario de interactividad, para que la comunidad CTI pueda crear historias informativas y atractivas.

## Demostraciones

Para ver Stixview en acción, eche un vistazo a estas páginas de demostración:

* [Demostración STIX2.1](https://traut.github.io/stixview/dist/demos/stix21-demo.html) — gráfico de ejemplo con todos los objetos STIX 2.1.
* [Línea de historia](https://traut.github.io/stixview/dist/demos/story.html) — múltiples gráficos por página, mostrando entidades seleccionadas del mismo paquete STIX.
* [Visor](https://traut.github.io/stixview/dist/demos/viewer.html) — visor de gráficos con controles personalizados.
* [Arrastrar y soltar](https://traut.github.io/stixview/dist/demos/drag-n-drop.html) — vistas de gráficos con arrastrar y soltar habilitado.
* [Gráfico en tema oscuro desde datos en línea](https://traut.github.io/stixview/dist/demos/load-data.html) — renderizando gráfico desde paquete STIX2 en línea y estilo personalizado.
* [Etiquetas TLP y renderizador personalizado de contenido lateral](https://traut.github.io/stixview/dist/demos/tags-and-custom-sidebar.html) — definiciones de marcado TLP mostradas como etiquetas y la barra lateral se renderiza con función proporcionada.
* [Ejemplos de varias configuraciones](https://traut.github.io/stixview/dist/demos/misc.html)

## Uso

Para usar Stixview en un navegador, descargue la última versión desde el directorio `dist` (`stixview.bundle.js`) y refiéralo desde su archivo HTML:

```html
<script src="stixview.bundle.js" type="text/javascript"></script>
```

o use el servicio CDN [unpkg](https://unpkg.com):

```html
<script src="https://unpkg.com/stixview/dist/stixview.bundle.js" type="text/javascript"></script>
```

## API

La biblioteca depende en gran medida de los [atributos de datos](https://developer.mozilla.org/en-US/docs/Learn/HTML/Howto/Use_data_attributes).
Al cargar la página, Stixview encontrará todos los elementos HTML con `data-stix-gist-id`, `data-stix-url` o `data-stix-allow-dragdrop` establecidos y usará estos elementos como contenedores de gráficos.

Ejemplo de un div contenedor de gráficos:

```html
<div data-stix-gist-id="6a0fbb0f6e7faf063c748b23f9c7dc62"
     data-show-sidebar=true
     data-enable-mouse-zoom=false
     data-graph-width=500
     data-graph-height=300>
</div>
```
### Atributos de datos

Cada elemento contenedor _debe tener_ uno de `data-stix-gist-id`, `data-stix-url` o `data-stix-allow-dragdrop` configurado, de lo contrario no será detectado por la biblioteca.

Stixview soporta estos atributos `data-`:

* `stix-gist-id` — id de un gist que contiene un paquete STIX2. si no se especifica `gist-file`, se usará el primer archivo.
* `gist-file` — nombre de un archivo del gist que se usará como paquete STIX2. Solo se usa si se establece `stix-gist-id`.
* `stix-url` — URL que apunta a un archivo JSON remoto con un paquete STIX2.
* `stix-allow-dragdrop` (`false` por defecto) — habilita la capacidad de arrastrar y soltar un paquete STIX2 en el elemento del gráfico. Si esta propiedad se establece en `true` y no se especifican `stix-gist-id` ni `stix-url`, se renderizará un gráfico vacío.
* `caption` — un título para el gráfico. El encabezado no se muestra si no se establece `caption`.
* `show-footer` (`true` por defecto) — muestra un pie de página con los enlaces de descarga del paquete STIX2 y archivo PNG.
* `show-sidebar` (`true` por defecto) — habilita una barra lateral con detalles del objeto, que se abre al hacer clic en el objeto.
* `show-tlp-as-tags` (`true` por defecto) — muestra los objetos de definición de marcado TLP conectados como etiquetas en las entidades.
* `show-marking-nodes` (`true` por defecto) — muestra los nodos de definición de marcado.
* `show-labels` (`true` por defecto) — muestra las etiquetas de los nodos.
* `show-idrefs` (`false` por defecto) — muestra objetos de marcador de posición para ids mencionados en las relaciones pero no presentes en un paquete.
* `graph-layout` (`cola` por defecto) — nombre del algoritmo de disposición del gráfico. Los algoritmos soportados son `cola`, `klay`, `cose-bilkent`, `cise`, `grid` y `dagre`.
* `enable-mouse-zoom` (`true` por defecto) — habilita el zoom con la rueda del ratón.
* `enable-panning` (`true` por defecto) — habilita el desplazamiento en el gráfico. Si es `false`, el gráfico tiene una vista fija. Los usuarios aún podrán arrastrar nodos.
* `highlighted-objects` — una cadena con ids STIX2 separadas por comas. Si se establece, el gráfico contendrá _solo objetos con ids listados_.
* `hidden-objects` — una cadena con ids STIX2 separadas por comas. Si se establece, los objetos con ids listados serán omitidos y no renderizados en el gráfico.
* `min-zoom` (`0.3` por defecto) — zoom mínimo permitido.
* `max-zoom` (`2.5` por defecto) — zoom máximo permitido.
* `graph-width` (ancho disponible completo por defecto) — ancho del elemento gráfico. Se soportan valores en píxeles y en % (ver página demo misc para un ejemplo).
* `graph-height` (`600` píxeles por defecto) — altura del elemento gráfico. Se soportan valores en píxeles y en % (ver página demo misc para un ejemplo).

### Objeto del navegador

La biblioteca, cuando se usa en un navegador, registrará la variable `stixview` en el objeto `window` con estas propiedades:

* `registry` — un registro de gráficos iniciados en una página.
* `onInit(selector, callback)` – gancho de escucha para el evento de inicialización de un gráfico en un elemento DOM que coincida con el valor `selector` proporcionado (ver [demo](https://traut.github.io/stixview/dist/demos/viewer.html) para ejemplo de uso). El callback recibe una instancia de la interfaz del gráfico.
* `onLoad(selector, callback)` – gancho de escucha para el evento de carga de un gráfico en un elemento DOM que coincida con el valor `selector` proporcionado (ver [demo](https://traut.github.io/stixview/dist/demos/viewer.html) para ejemplo de uso). El callback recibe una instancia de la interfaz del gráfico.
* `init(element, properties, initCallback, loadCallback)` — método que inicia una vista de gráfico en el `element` especificado con las `properties` proporcionadas que sobreescriben los valores por defecto (ver [demo](https://traut.github.io/stixview/dist/demos/load-data.html) para ejemplo de uso).

### Objeto gráfico

El gráfico es un objeto con propiedades:


* `cy` – objeto de grafo de [cytoscape.js](http://js.cytoscape.org).
* `element` — elemento DOM que contiene un grafo.
* `dataProps` – propiedades configuradas para el filtrado de datos.
* `viewProps` – propiedades configuradas para la visualización.
* `runLayout(name)` — ejecutar un layout específico en un grafo.
* `reloadData()` — recargar los datos del grafo con nuevas propiedades de filtrado de datos.
* `fit()` — ajustar completamente el grafo dentro de la vista del grafo.
* `toggleLabels(<bool-value>)` — mostrar / ocultar etiquetas de nodos.
* `toggleLoading(<bool-value>)` — mostrar / ocultar la superposición de carga.
* `loadData(data)` — cargar un paquete STIX2 desde el objeto JSON `data` y renderizarlo en un grafo.
* `loadDataFromFile(file)` — cargar un paquete STIX2 desde el objeto archivo `file` y renderizarlo en un grafo.
* `loadDataFromUrl(url)` — cargar un paquete STIX2 desde una URL remota y renderizarlo en un grafo.
* `loadDataFromParamUrl(paramName)` — cargar un paquete STIX2 desde una URL remota, configurada en el parámetro HTTP GET con nombre en `paramName` y renderizarlo en un grafo.

## Build

```shell
yarn build
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---