# Stixview

[![npm version](https://badge.fury.io/js/stixview.svg)](https://badge.fury.io/js/stixview)

[Stixview](https://github.com/traut/stixview) 是一个用于嵌入交互式 STIX2 图的 JS 库。

> [!注意]  
> Stixview 的托管版本可在 [CTIChef.com](https://ctichef.com) 访问

![Stixview graph](https://raw.githubusercontent.com/traut/stixview/master/.github/stixview-graph.png)

## 动机

CTI（网络威胁情报）非常注重讲述故事。信息在具备上下文并被置于故事中时，才成为情报。这些故事通常由情报提供者在报告中结晶，并传播给客户。

如果情报提供者关注结构化的机器可读 CTI，所产生的报告将附带 [STIX2](https://oasis-open.github.io/cti-documentation/) 包。报告中叙述的故事与由 STIX2 包表示的结构化 CTI 快照之间存在差距。

[Stixview](https://github.com/traut/stixview) 库的目标是提供易于嵌入且具备必要交互性的 STIX2 图，以便 CTI 社区能够创建信息丰富且吸引人的故事。

## 演示

要查看 Stixview 的实际效果，请查看以下演示页面：

* [STIX2.1 演示](https://traut.github.io/stixview/dist/demos/stix21-demo.html) — 包含所有 STIX 2.1 对象的示例图。
* [故事线](https://traut.github.io/stixview/dist/demos/story.html) — 每页多个图，呈现同一 STIX 包中选定实体。
* [查看器](https://traut.github.io/stixview/dist/demos/viewer.html) — 带有自定义控件的图查看器。
* [拖放](https://traut.github.io/stixview/dist/demos/drag-n-drop.html) — 启用拖放功能的图视图。
* [从内联数据生成的暗色主题图](https://traut.github.io/stixview/dist/demos/load-data.html) — 从内联 STIX2 包和自定义样式渲染图。
* [TLP 标签和自定义侧边栏内容渲染器](https://traut.github.io/stixview/dist/demos/tags-and-custom-sidebar.html) — 将 TLP 标记定义显示为标签，侧边栏由提供的函数渲染。
* [各种配置设置示例](https://traut.github.io/stixview/dist/demos/misc.html)

## 使用

在浏览器中使用 Stixview，请从 `dist` 目录下载最新构建文件（`stixview.bundle.js`），并在您的 HTML 文件中引用：

```html
<script src="stixview.bundle.js" type="text/javascript"></script>
```
或使用 [unpkg](https://unpkg.com) CDN 服务：


```html
<script src="https://unpkg.com/stixview/dist/stixview.bundle.js" type="text/javascript"></script>
```

## API

该库在很大程度上依赖于 [数据属性](https://developer.mozilla.org/en-US/docs/Learn/HTML/Howto/Use_data_attributes)。
页面加载时，Stixview 会查找所有设置了 `data-stix-gist-id`、`data-stix-url` 或 `data-stix-allow-dragdrop` 的 HTML 元素，并将这些元素用作图表容器。

图表容器 div 示例：

```html
<div data-stix-gist-id="6a0fbb0f6e7faf063c748b23f9c7dc62"
     data-show-sidebar=true
     data-enable-mouse-zoom=false
     data-graph-width=500
     data-graph-height=300>
</div>
```

### 数据属性

每个持有元素_必须_设置`data-stix-gist-id`、`data-stix-url`或`data-stix-allow-dragdrop`中的一个，否则库将无法检测到该元素。

Stixview支持以下`data-`属性：

* `stix-gist-id` — 包含STIX2包的gist的ID。如果未指定`gist-file`，则使用第一个文件。
* `gist-file` — gist中用作STIX2包的文件名。仅当设置了`stix-gist-id`时使用。
* `stix-url` — 指向远程STIX2包JSON文件的URL。
* `stix-allow-dragdrop`（默认`false`）— 启用将STIX2包拖放到图形元素中的功能。如果该属性设置为`true`且未指定`stix-gist-id`和`stix-url`，将渲染空图。
* `caption` — 图的标题。如果未设置`caption`，则不显示标题。
* `show-footer`（默认`true`）— 显示包含STIX2包和PNG文件下载链接的页脚。
* `show-sidebar`（默认`true`）— 启用侧边栏，点击对象时显示对象详情。
* `show-tlp-as-tags`（默认`true`）— 将关联的TLP标记定义对象显示为实体上的标签。
* `show-marking-nodes`（默认`true`）— 显示标记定义节点。
* `show-labels`（默认`true`）— 显示节点标签。
* `show-idrefs`（默认`false`）— 显示关系中提及但未包含在包中的ID的占位符对象。
* `graph-layout`（默认`cola`）— 图布局算法名称。支持的算法有`cola`、`klay`、`cose-bilkent`、`cise`、`grid`和`dagre`。
* `enable-mouse-zoom`（默认`true`）— 启用鼠标滚轮缩放。
* `enable-panning`（默认`true`）— 启用图的平移。如果为`false`，图视图固定，用户仍可拖动节点。
* `highlighted-objects` — 以逗号分隔的STIX2 ID字符串。如果设置，图只包含列出的ID对象。
* `hidden-objects` — 以逗号分隔的STIX2 ID字符串。设置后，列出的ID对象将被跳过，不在图中渲染。
* `min-zoom`（默认`0.3`）— 最小允许缩放比例。
* `max-zoom`（默认`2.5`）— 最大允许缩放比例。
* `graph-width`（默认占满所有可用宽度）— 图元素宽度。支持像素和百分比值（参见misc演示页面示例）。
* `graph-height`（默认`600`像素）— 图元素高度。支持像素和百分比值（参见misc演示页面示例）。

### 浏览器对象

在浏览器中使用时，库会在`window`对象上注册`stixview`变量，具有以下属性：

* `registry` — 页面上已初始化图的注册表。
* `onInit(selector, callback)` – 针对匹配提供的`selector`的DOM元素的图初始化事件的监听钩子（参见[演示](https://traut.github.io/stixview/dist/demos/viewer.html)的使用示例）。回调接收图接口实例。
* `onLoad(selector, callback)` – 针对匹配提供的`selector`的DOM元素的图加载事件的监听钩子（参见[演示](https://traut.github.io/stixview/dist/demos/viewer.html)的使用示例）。回调接收图接口实例。
* `init(element, properties, initCallback, loadCallback)` — 在指定`element`中初始化图视图的方法，使用提供的`properties`覆盖默认值（参见[演示](https://traut.github.io/stixview/dist/demos/load-data.html)的使用示例）。

### 图对象

图是具有以下属性的对象：

* `cy` – [cytoscape.js](http://js.cytoscape.org) 图对象。
* `element` — 保存图的 DOM 元素。
* `dataProps` – 配置的数据过滤属性。
* `viewProps` – 配置的视图属性。
* `runLayout(name)` — 在图上运行特定布局。
* `reloadData()` — 使用新的数据过滤属性重新加载图数据。
* `fit()` — 将图完全适配到图视图中。
* `toggleLabels(<bool-value>)` — 显示 / 隐藏节点标签。
* `toggleLoading(<bool-value>)` — 显示 / 隐藏加载覆盖层。
* `loadData(data)` — 从 `data` JSON 对象加载 STIX2 包并在图上渲染。
* `loadDataFromFile(file)` — 从 `file` 文件对象加载 STIX2 包并在图上渲染。
* `loadDataFromUrl(url)` — 从远程 URL 加载 STIX2 包并在图上渲染。
* `loadDataFromParamUrl(paramName)` — 从 HTTP GET 参数名为 `paramName` 配置的远程 URL 加载 STIX2 包并在图上渲染。

## 构建

```shell
yarn build
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---