# Stixview

[![npm version](https://badge.fury.io/js/stixview.svg)](https://badge.fury.io/js/stixview)

[Stixview](https://github.com/traut/stixview) is a JS library for embeddable interactive STIX2 graphs.

> [!NOTE]  
> Hosted version of Stixview is available at [CTIChef.com](https://ctichef.com)

![Stixview graph](https://raw.githubusercontent.com/traut/stixview/master/.github/stixview-graph.png)

## Motivation

CTI (Cyber Threat Intelligence) is very much about telling stories. Information becomes intelligence when it is complimented with a context and is placed in a story. These stories are usually crystallised in the reports by an intelligence provider and disseminated to the customers.

If intelligence provider cares about structured machine-readable CTI, the reports produced will be supplemented with [STIX2](https://oasis-open.github.io/cti-documentation/) bundles. There is a gap there between a story, narrated in a report, and a structured CTI snapshot, represented by a STIX2 bundle.

The objective of [Stixview](https://github.com/traut/stixview) library is to provide easily embeddable STIX2 graphs with necessary level of interactivity, so that CTI community can create informative and engaging stories.

## Demos

To see Stixview in action, take a look at these demo pages:

* [STIX2.1 demo](https://traut.github.io/stixview/dist/demos/stix21-demo.html) — sample graph with all STIX 2.1 objects.
* [Storyline](https://traut.github.io/stixview/dist/demos/story.html) — multiple graphs per page, rendering selected entities from the same STIX bundle.
* [Viewer](https://traut.github.io/stixview/dist/demos/viewer.html) — graph viewer with custom controls.
* [Drag-n-drop](https://traut.github.io/stixview/dist/demos/drag-n-drop.html) — graph views with drag-n-drop enabled.
* [Dark theme graph from inline data](https://traut.github.io/stixview/dist/demos/load-data.html) — rendering graph from inline STIX2 bundle and custom styling.
* [TLP tags and custom sidebar content renderer](https://traut.github.io/stixview/dist/demos/tags-and-custom-sidebar.html) — TLP marking definitions shown as tags and sidebar is rendered with provided function.
* [Examples of various configuration settings](https://traut.github.io/stixview/dist/demos/misc.html)

## Usage

To use Stixview in a browser, download the latest build from `dist` directory (`stixview.bundle.js`) and reference it from your HTML file:

```html
<script src="stixview.bundle.js" type="text/javascript"></script>
```

or use [unpkg](https://unpkg.com) CDN service:

```html
<script src="https://unpkg.com/stixview/dist/stixview.bundle.js" type="text/javascript"></script>
```

## API

The library relies heavily on [data attributes](https://developer.mozilla.org/en-US/docs/Learn/HTML/Howto/Use_data_attributes).
On page load, Stixview will find all HTML elements with `data-stix-gist-id`, `data-stix-url` or `data-stix-allow-dragdrop` set and use these elements as graph holders.

Example of a graph holder div:

```html
<div data-stix-gist-id="6a0fbb0f6e7faf063c748b23f9c7dc62"
     data-show-sidebar=true
     data-enable-mouse-zoom=false
     data-graph-width=500
     data-graph-height=300>
</div>
```
### Data attributes

Every holder element _must have_ one of `data-stix-gist-id`, `data-stix-url` or `data-stix-allow-dragdrop` set, otherwise it will not be detected by the library.

Stixview supports these `data-` attributes:

* `stix-gist-id` — id of a gist that contains STIX2 bundle. if `gist-file` is not specified, first file will be used.
* `gist-file` — name of a file from gist to be used as STIX2 bundle. Only used if `stix-gist-id` is set.
* `stix-url` — URL pointing to a remote STIX2 bundle JSON file.
* `stix-allow-dragdrop` (`false` by default) — enable ability to drag-n-drop STIX2 bundle into the graph element. If this property is set to `true` and `stix-gist-id` and `stix-url` are not specified, empty graph will be rendered.
* `caption` — a title of the graph. Header is not shown if `caption` is not set.
* `show-footer` (`true` by default) — show a footer with the download links to STIX2 bundle and PNG file.
* `show-sidebar` (`true` by default) — enable a sidebar with object details, opened when object is clicked on.
* `show-tlp-as-tags` (`true` by default) — show connected TLP marking definition objects as tags on entities.
* `show-marking-nodes` (`true` by default) — show the marking definition nodes.
* `show-labels` (`true` by default) — show node labels.
* `show-idrefs` (`false` by default) — show placeholder objects for ids mentioned in the relationships but not present in a bundle.
* `graph-layout` (`cola` by default) — name of the graph layout algorythm. Supported algorythms are `cola` , `klay`, `cose-bilkent`, `cise`, `grid` and `dagre`.
* `enable-mouse-zoom` (`true` by default) — enable mouse wheel zoom.
* `enable-panning` (`true` by default) — enable panning in the graph. If `false`, a graph has a fixed view. Users will still be able to drag nodes around.
* `highlighted-objects` — a string with comma-separated STIX2 ids. If set, graph will contain _only objects with ids listed_.
* `hidden-objects` — a string with comma-separated STIX2 ids. If set, objects with ids listed will be skipped and not rendered in the graph.
* `min-zoom` (`0.3` by default) — minimum allowed zoom.
* `max-zoom` (`2.5` by default) — maximum allowed zoom.
* `graph-width` (all available width by default) — width of a graph element. Both pixel and % values are supported (see misc demo page for an example).
* `graph-height` (`600` pixels by default) — height of a graph element. Both pixel and % values are supported (see misc demo page for an example).

### Browser object

The library, when used in a browser, will register `stixview` variable on `window` object with these properties:

* `registry` — a registry of graphs initiated on a page.
* `onInit(selector, callback)` – listener hook for graph's init event on a DOM element that matches provided `selector` value (see [demo](https://traut.github.io/stixview/dist/demos/viewer.html) for usage example). Callback receive instance of a graph interface.
* `onLoad(selector, callback)` – listener hook for graph's load event on a DOM element that matches provided `selector` value (see [demo](https://traut.github.io/stixview/dist/demos/viewer.html) for usage example). Callback receive instance of a graph interface.
* `init(element, properties, initCallback, loadCallback)` — method that initiates a graph view in specified `element` with provided `properties` that override defaults (see [demo](https://traut.github.io/stixview/dist/demos/load-data.html) for usage example).

### Graph object

Graph is an object with properties:


* `cy` – [cytoscape.js](http://js.cytoscape.org) graph object.
* `element` — DOM element that holds a graph.
* `dataProps` – configured data filtering properties.
* `viewProps` – configured viewing properties.
* `runLayout(name)` — run specific layout on a graph.
* `reloadData()` — reload graph data with new data filtering properties.
* `fit()` — fit graph fully into a graph view.
* `toggleLabels(<bool-value>)` — show / hide node labels.
* `toggleLoading(<bool-value>)` — show / hide loading overlay.
* `loadData(data)` — load STIX2 bundle from `data` JSON object and render on a graph.
* `loadDataFromFile(file)` — load STIX2 bundle from `file` file object and render on a graph.
* `loadDataFromUrl(url)` — load STIX2 bundle from remote URL and render on a graph.
* `loadDataFromParamUrl(paramName)` — load STIX2 bundle from remote URL, configured in HTTP GET paramter with name in `paramName` and render on a graph.

## Build

```shell
yarn build
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---