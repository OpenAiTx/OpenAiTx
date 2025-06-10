# Gantt

## Installation

```
yarn install
```

### Run

```
yarn run serve
```

### Description

```
A Gantt chart developed based on Vue, which can be used for agile scenarios such as team collaboration and task division.

Supports grouping  
Supports drag and drop  
Supports stretching  
Supports percentage  
Supports time spans: day, week, month  
Currently, only single-level grouping is implemented. To avoid future needs for second-level or multi-level grouping, some code was refactored in the last commit to support multi-level grouping, but this version does not have it developed yet.

Advantages: When dragging, stretching, or modifying progress, the data is not updated in real time; it is updated after the operation, reducing performance overhead.
When editing, deleting, or adding, the entire instance is not recursively modified, only the modified part is changed.

Currently being reorganized in preparation for componentization. To use it in a project, simply import `gant.vue` from this project.
Batch data import/export methods are already written and can be copied directly!~
```

### Update Notes

- Supports editing
- Supports deletion
- Fixed bug where vertical scrolling was not possible (also added two-way simultaneous scrolling) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- Fixed bugs caused by elementUI
- About the time span issue [#5](https://github.com/GGBeng1/Gantt/issues/5)
- Currently, it is not possible to achieve other spans (such as adding hours) by changing the span configuration. Some configurations are fixed during initialization; this will be changed and released as an API in the future.

### View Demo

See [demo](https://ggbeng1.github.io/Gantt/#/)

### Screenshot

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---