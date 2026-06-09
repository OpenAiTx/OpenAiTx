# Tailwind 转换为内联样式工具

将 Tailwind CSS 类转换为适用于邮件模板的内联样式。

### [在线试用](https://tailwind-to-inline.vercel.app)

### 安装
`npm install tailwind-to-inline`


### 使用方法

#### 从文件路径转换

```js
import { makeStylesInline } from 'tailwind-to-inline';

const htmlTemplate = await makeStylesInline('templates/welcome-email.html', {
  name: 'John',
  cta_text: 'Complete Profile'
});
```

**参数：**

- `templatePath` — 模板文件的路径。
- `placeholderValues` *(可选)* — 一个键值对对象，用于替换模板中的动态内容。

#### 来自原始 HTML 字符串

```js
import { makeStylesInlineFromString } from 'tailwind-to-inline';

const html = `<div class="pt-10 text-yellow-300">Hello, {{name}}</div>`;
const htmlTemplate = await makeStylesInlineFromString(html, {
  name: 'John',
});
```

**参数：**

- `templateString` — 包含 Tailwind CSS 类的原始 HTML 字符串。
- `data` *(可选)* — 用于替换模板中动态内容的键值对对象。


### 示例
#### 原始模板 `welcome-email.html`：

```html
<html>
  <body class="bg-gray-800">
    <div class="pt-10 mb-4 pl-4 max-w-[512px] relative z-20">
      <span class="mr-5 text-yellow-300">Welcome, {{name}}</span>
    </div>
    <div>
      <a href="https://example.com/complete-profile" class="bg-blue-500">
        {{cta_text}}
      </a>
    </div>
  </body>
</html>
```

#### 转换结果：

```html
<html>
  <body style="background-color: #1f2937;">
    <div style="position: relative; z-index: 20; max-width: 512px; margin-bottom: 1rem; padding-left: 1rem; padding-top: 2.5rem;">
      <span style="margin-right: 1.25rem; color: #fde047;">Welcome, John</span>
    </div>
    <div>
      <a href="https://example.com/complete-profile" style="background-color: #3b82f6;">
        Complete Profile
      </a>
    </div>
  </body>
</html>
```

### 贡献

欢迎贡献、提交问题和功能请求！

### 贡献者

<a href="https://github.com/vardan-arm"><img src="https://github.com/vardan-arm.png" width="50" height="50" alt="vardan-arm" /></a>
<a href="https://github.com/diogomoretti"><img src="https://github.com/diogomoretti.png" width="50" height="50" alt="diogomoretti" /></a>
<a href="https://github.com/markosmk"><img src="https://github.com/markosmk.png" width="50" height="50" alt="markosmk" /></a>

### 许可证

本项目采用 MIT 许可证。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-09

---