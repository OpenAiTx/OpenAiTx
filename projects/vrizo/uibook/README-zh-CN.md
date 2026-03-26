
<a href="https://www.facebook.com/amplifr/">
  <img width="80" height="80" align="right"
    alt="由 Amplifr 赞助" src="https://raw.githubusercontent.com/vrizo/uibook/master/./amplifr-logo.png" style="border-radius: 100%; margin: 10px;"/>
</a>


# Uibook

Uibook 是一个用于 React 组件视觉测试的工具。它让你快速
检查组件的桌面和移动端视图，支持真实的媒体查询
以及不同的 props 组合。

主要功能：
- 响应式测试，开发者可使用 **真实媒体查询** 进行调试
- 实时文本编辑，设计师和编辑可检查内容
- 作为 Webpack 插件安装，无需额外的构建工具。

<img src="/docs/uibook.gif" align="center" alt="Uibook 主要功能" >

:triangular_flag_on_post: 在此查看 Uibook 演示项目：
[https://uibook.vrizo.net/](https://uibook.vrizo.net/#Presets:ru)。

## 使用方法

### 快速安装 :hatching_chick:

我们设计了 Uibook 以便无缝集成到你的项目中。
作为 webpack 插件安装，即可使用：
Uibook 不需要任何单独的打包工具。

_webpack.config.js_
```js
const UibookPlugin = require('uibook/plugin')

module.exports = {
  …
  plugins: [
    new UibookPlugin({
      outputPath: '/uibook',
      controller: path.join(__dirname, '../src/uibook-controller.js'),
      hot: true
    })
  ],
}
```

[阅读更多关于安装的信息 →](https://raw.githubusercontent.com/vrizo/uibook/master/docs/install.md)
[在 Create React App 中使用 CRACO 安装 →](https://raw.githubusercontent.com/vrizo/uibook/master/docs/install_craco.md)

### 在页面中描述组件 :hatched_chick:

你只需定义两件事：

1. 页面 — 包含测试组件名称和用例的简单对象；
2. 用例 — 组件的属性和回调集合。

_button.uibook.js_
```js
import UibookCase from 'uibook/case'
import Button from '../src/button'

export default {
  component: Button,
  cases: [
    () => <UibookCase>Button</UibookCase>,
    () => <UibookCase props={{ isSmall: true }}>Small button</UibookCase>
  ]
}
```

[阅读更多关于配置 →](https://raw.githubusercontent.com/vrizo/uibook/master/docs/configure.md)

### 将页面传递给控制器 :baby_chick:

一旦你完成了第一个 Uibook 页面，你就可以开始编写 Uibook 控制器了。  
这里是所有页面被包含并传递给 UibookStarter 的地方 :sparkles:

_uibook-controller.js_

```js
import UibookStarter from 'uibook/starter'
import ButtonUibook from './button.uibook'

export default UibookStarter({
  pages: {
    Button: ButtonUibook
  }
})
```

[阅读更多关于 Controller →](https://raw.githubusercontent.com/vrizo/uibook/master/docs/controller.md)

### 启动 :rocket:

无需任何额外的服务器或 webpack 实例。  
Uibook 集成到您的项目中，只需运行您的打包工具  
并在浏览器中打开 `/uibook`（或您的自定义地址 — `outputPath`）。

### 更多信息

- **[故障排除](https://raw.githubusercontent.com/vrizo/uibook/master/docs/troubleshooting.md)**
- [示例](https://raw.githubusercontent.com/vrizo/uibook/master/docs/examples.md)
- [联系我](https://twitter.com/vitaliirizo)

## 实时文本编辑

此模式为每个用例启用 `contentEditable`，允许管理者、  
设计师和界面编辑者预览组件中的内容。

<img src="/docs/text-edit-mode.gif" align="center" alt="文本编辑模式" >

## 特别感谢

- [@ai](https://github.com/ai)
- [@demiazz](https://github.com/demiazz)
- [@marfitsin](https://github.com/marfitsin)
- [@iadramelk](https://github.com/iadramelk)
- [@ikowalsker](https://www.facebook.com/ikowalsker)
- [@antiflasher](https://github.com/antiflasher)
- [@HellSquirrel](https://github.com/HellSquirrel)

欢迎任何人贡献代码，您可以查看当前任务  
在 [PLAN.md](https://raw.githubusercontent.com/vrizo/uibook/master/PLAN.md)。我很乐意回答您  
关于本项目的任何问题。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---