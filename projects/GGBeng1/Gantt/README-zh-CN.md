# Gantt

## 安装

```
yarn install
```

### 运行

```
yarn run serve
```

### 说明

```
基于vue开发的甘特图展现，可以用作团队协作，任务划分等敏捷场景

支持分组
支持拖拽
支持拉伸
支持百分比
支持时间跨度：天，周，月
目前只写了一级分组，为了避免未来二级或者多级分组需求，在上一次提交中重构了部分代码，支持多级分组，但是当前版本没有开发

优势: 在拖拽，拉伸，修改进度等操作时，对数据并没有实时更新，是在操作后更新，减少了性能损耗
      在编辑，删除，添加时，并没有整体递归修改实例，而是只对修改部分增删改

正在准备重新组织，为组件化做准备，目前想要在项目中使用只需要引入该项目中的`gant.vue`即可
批量数据导入导出方法已经写好，直接copy即可！~
```

### 更新说明

- 支持编辑
- 支持删除
- 修复不能垂直滚动的 bug(同时增加双向同时滚动) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- 修复 elementUI 引起的 bug
- 关于时间跨度的问题[#5](https://github.com/GGBeng1/Gantt/issues/5)
- 目前无法通过更改跨度配置来实现其他跨度，比如增加小时等。因为在初始化的时候一些配置直接固定，后续会更改作为 api 放出

### 查看示例

参见 [demo](https://ggbeng1.github.io/Gantt/#/)

### 展示图

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---