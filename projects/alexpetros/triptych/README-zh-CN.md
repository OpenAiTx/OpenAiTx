<translate-content># Triptych - HTML 的新属性

[Triptych](https://alexanderpetros.com/triptych) 是三个小型 HTML 提案的 polyfill：

1. [支持表单中的 PUT、PATCH 和 DELETE](https://alexanderpetros.com/triptych/form-http-methods)（[WHATWG 议题](https://github.com/whatwg/html/issues/3577#issuecomment-2294931398)）
2. [使按钮能够在不被表单包裹的情况下发起 HTTP 请求](https://alexanderpetros.com/triptych/button-actions)
3. 使链接、表单和按钮能够定位 DOM 的部分进行替换

这些提案的工作正在进行中：我们已经发布了第一个，接下来的两个即将推出。
如果你有兴趣参与，欢迎联系我！

状态更新见：[https://alexanderpetros.com/triptych#status](https://alexanderpetros.com/triptych#status)

## 示例

当点击链接时，用 `GET /home` 的结果替换 `<main>`： 
</translate-content>
```html
<a href="/home" target="main">Home</a>
<main> <!-- Existing page content --> </main>
```
点击按钮时，将整个页面替换为 `DELETE /users/354` 的结果：

```html
<button action="/users/354" method="DELETE"></button>
```
点击按钮时，将按钮替换为 `DELETE /users/354` 的结果

```html
<button action="/users/354" method="DELETE" target="_this"></button>
```
<translate-content>
当表单提交时，将 `<div id=user-info>` 替换为 `PUT /users/354` 的结果
</translate-content>
```html
<div id="user-info"></div>
<form action="/users/354" method="PUT" target="#user-info">
  <input type="text" name="name">
  <input type="text" name="bio">
  <button>Submit</button>
</form>
```
## 背景与设计目标

Triptych 是一个符合标准的功能集实现，该功能集既是 HTML 的核心，也在库生态系统中获得了大量关注：声明式 HTTP 请求和部分页面替换。  
我在[2024 年 Big Sky Dev Con 的这次演讲](https://unplannedobsolescence.com/blog/life-and-death-of-htmx/)中概述了这些提案的理由。

HTML 一直支持声明式请求。  
超链接是网页语法的基础，`<a>` 标签让开发者指定 HTTP 请求及后续的页面导航。  
HTML 2.0 引入了 `<form>` 元素，允许开发者指定替代的 HTTP 方法（`POST`）并通过 URL 查询参数或请求体获取用户输入。

现有的声明式 HTTP 请求语义存在两个主要缺失：不支持完整的 HTTP 方法集（特别是 `PUT`、`PATCH` 和 `DELETE`），且仅支持相对严格的导航和表单提交范式。

库生态系统显示出对这两项功能以及第三项功能的强烈需求：用网络请求结果部分替换 DOM。  
支持这些功能的最受关注的库是 [htmx](https://htmx.org/)，但远非唯一。  
37Signals（Ruby on Rails 的发明者）维护着一个基于 HTML-over-the-wire 的框架 [Hotwired](https://hotwired.dev/)，其中带有用于部分页面替换的 HTML 接口 [Turbo](https://turbo.hotwired.dev/)。  
[Unpoly](https://unpoly.com/) 增加了允许定位页面片段替换的属性，并支持完整的 HTTP 方法范围。

Triptych 试图将基于属性的 DOM 替换纳入 HTML 标准，  
以最符合现有 HTML 语义的方式进行。它旨在展示这些  
提案的有效性，推动它们加入 HTML 标准，并在此之前提供该功能的 polyfill。  
其设计主要受 [htmx](https://htmx.org/) 和  
[htmz](https://leanrada.com/htmz/) 的启发。

由于 Triptych 目标是被纳入 HTML 标准，因此它不使用命名空间自定义属性（如 `ng-*`、`hx-*` 等），而是以向后兼容的方式使用现有的（或合理的）HTML 标准属性。  
脚本的复杂性很大程度上源于需要避免破坏诸如 `target` 或 `method` 等属性的现有用法。


## 安装

目前还没有 CDN，即使我上传到 CDN，[你大概也不应该使用它](https://blog.wesleyac.com/posts/why-not-javascript-cdn)。

相反，按以下方式安装：

1. 将 `triptych.js` 复制到项目中的某个文件夹，例如 `/vendor/triptych-0.1.0.js`  
1. 在该 URL 处以超长缓存时间提供它（我通常设置为一年）  
1. 这样在你的文档中引入它：


```html
<script src="/vendor/triptych-0.1-0.js"></script>
```
确保在文件名中包含版本号，以便在更新时，已经缓存该文件的用户能够下载新版本。

我很快会将其上传到 `npm`，这样你就可以将其作为依赖项包含，并直接从 node_modules 提供服务（而不是复制文件）。

## 限制

因为这些功能旨在被纳入标准中，所以它们模拟期望的浏览器行为，但受限于 JavaScript 的能力。

主要限制涉及完整页面导航。
提交 POST 表单时，默认行为是将该 URL 推送到地址栏并显示表单返回的 HTML；
点击刷新按钮会重新提交 POST 请求——用户需确认这是他们的意图。

当按钮和表单上未提供 `target` 时，Triptych 会尽最大努力模拟完整页面行为。
它会替换整个文档，并使用 [history API](https://developer.mozilla.org/en-US/docs/Web/API/History) 更新浏览器 URL
和历史记录。
点击“后退”基本上应该按预期工作。

然而，由于 JavaScript 的（非常合理的）限制，Triptych 无法改变刷新按钮的行为来使其重新提交 PUT 请求，正如提议中所述。
也不能模拟 POST-重定向模式的主要好处之一——它会重置当前的 JS 环境。

此外，对于所有这些请求，浏览器应该显示加载条，就像点击链接时一样。
这种行为无法用 JavaScript 模拟，但如果浏览器中集成，将极大提升用户体验——这是 *所有* JavaScript 框架所缺少的主要功能之一。

## 开发

完整源码位于 `./triptych.js`。

运行测试前，先用 `npm install` 安装开发依赖。
然后，在浏览器中打开 `./test/index.html` 来运行测试。

你也可以通过运行 `npm run dev` 来玩转手动测试。

### 待办事项

* 添加完整页面测试，验证现有 GET/POST 表单不受影响
* 调查服务器端重新定向控制（可能是通过头部）
* 调查进行中请求的 CSS 属性

## 常见问题

### 我应该在项目中使用它吗？

是，也不是。

传统的 polyfill 目的是在功能成为标准之前为网页提供该功能。
对于 Triptych，其中一些功能无法用 JavaScript 模拟（见上述限制部分）。

这个“polyfill”的目的是演示这些提案如何改变基础 HTML 的能力。
此库的功能集将跟踪它所支持的提案，这些提案需要结合反馈，因此一开始无法提供强兼容性保证。
但你绝对应该使用它，以了解编写 HTML 可能的未来样貌。

### 如果有多个元素匹配目标怎么办？

定位是使用 [querySelector API](https://developer.mozilla.org/en-US/docs/Web/API/Document/querySelector) 完成的，该 API 对文档节点执行深度优先的预排序遍历。
目标将是该算法找到的第一个匹配元素。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---