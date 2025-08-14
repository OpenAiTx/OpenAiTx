# Vimesh Headless UI
## 特性
这是 [Tailwind Headless UI](https://headlessui.com/) 的 Alpine.js 实现。基于 [Vimesh UI](https://github.com/vimeshjs/vimesh-ui) 框架构建，Vimesh Headless UI 具有一些优良特性：
### 超轻量级
Vimesh Headless UI 代码体积更小

| 组件         | Vimesh Headless UI   | Tailwind Headless UI for Vue | Tailwind Headless UI for React |
| ----------- | -------------------- | -------- | ----- |
| Listbox     | 8k                   | 34k      | 30k   | 
| Combobox    | 9k                   | 25k      | 39k   |
| Menu        | 7k                   | 18k      | 20k   |
| Switch      | 0.6k                 | 5k       | 6k    |
| Tabs        | 4k                   | 12k      | 16k   |
| Dialog      | 2k                   | 15k      | 17k   |
| Popover     | 6k                   | 23k      | 28k   |
| Radio Group | 1k                   | 11k      | 14k   |

比较 Vimesh 和 Tailwind headless dialog 生产版本示例页面大小，Vimesh 更小，功能更多且 BUG 更少（查看 tailwind 弹窗对话框中的菜单显示）。

* Vimesh (192k)  
![](https://raw.githubusercontent.com/vimeshjs/vimesh-headless/master/./assets/vimesh001.png)  
* Tailwind (425k)  
![](https://raw.githubusercontent.com/vimeshjs/vimesh-headless/master/./assets/tailwind001.png)

### 动态加载仅使用的组件
组件是纯 HTML 文件，可以托管在任何地方，通常是在 CDN 上。它们可以跨不同项目共享，无需额外的摇树优化。例如，对话框基础示例使用了两个组件 `hui-dialog` 和 `hui-menu`。只需通过 `x-import` 异步加载它们。Vimesh UI 会注册对应的原生自定义元素并初始化它们。

```html
<template x-component:page="dialog-basic" x-import="hui:dialog,menu" x-data="setupDialogBasicData()"
    class="overflow-y-auto">
    ...
    <hui-dialog :open="isOpen" @close="setIsOpen(false)">
        ...
        <hui-menu>
        </hui-menu>
    </hui-dialog>
    ...
</template>
```

### 无需构建，无需打包
所写即所得。将组件组织到有意义的命名空间下的 HTML 文件中。您不需要 webpack、rollup、vite 等工具。

## 快速开始
### 开发模式
安装开发依赖，包括 alpinejs、@vimesh/style、@vimesh/ui、universal-router 和 http-server。
```
yarn
```
运行静态 HTTP 服务器
```
yarn dev
```
打开网址 `http://127.0.0.1:8080/playground/dev.html`

它显示了一个索引页面
![](https://raw.githubusercontent.com/vimeshjs/vimesh-headless/master/./assets/vimesh002.jpg)

这里有许多不同组件的示例及其相关源代码。

![](https://raw.githubusercontent.com/vimeshjs/vimesh-headless/master/./assets/vimesh003.jpg)

它使用了 node_modules 文件夹中的开发版本 alpinejs 和 @vimesh/ui。

### 生产模式
请查看 `playground/index.html`，它使用了 `unpkg.com` 上最新版本的 alpinejs 和 @vimesh/ui。实际上，如果你在真实项目中使用 Vimesh Headless UI，也会这样做。
``` html
<head>
    <link rel="icon" type="image/x-icon" href="./assets/favicon.ico">

    <script src="https://unpkg.com/@vimesh/style"></script>
    <script src="https://unpkg.com/@vimesh/ui"></script>
    <script src="https://unpkg.com/alpinejs" defer></script>
    <script src="https://unpkg.com/universal-router/universal-router.min.js"></script>

    <script>
        const DEBUG = false
        $vui.config.debug = DEBUG
        $vui.config.importMap = {
            "hui": '../components/${component}.html' + (DEBUG ? '?v=' + new Date().valueOf() : '?v=0.1'),
            "app": './components/${path}${component}.html' + (DEBUG ? '?v=' + new Date().valueOf() : '?v=0.1'),
            "page": './pages/${path}${component}.html' + (DEBUG ? '?v=' + new Date().valueOf() : '?v=0.1'),
        }
    </script>
    ...
</head>
```

[Online Playground](https://unpkg.com/@vimesh/headless/playground/index.html)

Yes, the online playground are 100% plain html hosted at `unpkg.com`. It is very old school style, right? Let's make frondend development back to what it should be.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-14

---