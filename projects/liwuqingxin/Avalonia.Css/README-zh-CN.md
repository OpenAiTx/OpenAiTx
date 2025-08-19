<div align="left">
  <a href="https://github.com/microsoft/dotnet">
    <img src="https://img.shields.io/badge/-.NET-red">
  </a>
  <a href="https://avaloniaui.net/">
    <img src="https://img.shields.io/badge/Avalonia-8245A9">
  </a>
  <a href="https://dotnet.microsoft.com/zh-cn/languages/csharp">
    <img src="https://img.shields.io/badge/-C%23-yellow">
  </a>
  <a href="http://www.gnu.org/licenses/mit.en.html">
    <img src="https://img.shields.io/badge/License-MIT-green">
  </a>
</div>
<br/><br/>

![acss-brand](https://raw.githubusercontent.com/liwuqingxin/Avalonia.Css/main/img/AcssText.svg)

Avalonia Css，简称 Acss，不遵循标准的 CSS（层叠样式表）。它旨在**分离 Avalonia UI 的结构和视觉定义**，并赋予 Avalonia **快速动态修改样式的能力**。

是的，它遵循类似于**Html+CSS**的模式。

# 推广

我最近发现了一个遵循 Ant Design 风格的 Avalonia 控件库——制作得非常精良。与核心开发者交流后，我们同意通过互相推广来支持彼此。如果你感兴趣，欢迎访问 [这里](https://github.com/chinware/AtomUI)。

![](https://github.com/chinware/AtomUI/blob/develop/resources/images/readme/AtomUIOSS.png)


![](https://resources.jetbrains.com/storage/products/company/brand/logos/jb_beam.svg)

非常感谢 Jet Brains 提供的[免费开发者工具](https://www.jetbrains.com/community/opensource/?utm_campaign=opensource&utm_content=approved&utm_medium=email&utm_source=newsletter&utm_term=jblogo#support)。

# 特性

- 结构与样式分离
- 结构复用
- 动态加载
- 热加载
- 拦截与过滤
- 行为扩展  
- 语法扩展  
- 样式调试  
- 自定义绘制  

# 文档  

文档可在[这里](https://docs.en.avalonia.css.nlnet.net/documentation/readme)获取。请注意，英文文档是由中文通过DeepL翻译而成。如果您对其有任何问题，欢迎在github上进行编辑。  

> 中文文档请参考 [这里](https://docs.avalonia.css.nlnet.net/documentation/readme)。  

# 使用  

请参见[这里](https://docs.en.avalonia.css.nlnet.net/documentation/zhu-ti-bang-zhu/ru-he-shi-yong-acss)了解Acss的使用方法。  

# 贡献  

我们希望有更多感兴趣的伙伴加入我们，共同打造Acss，让它更加充满活力和功能强大。  

如果您有兴趣参与或有任何想法、建议或反馈，请发送电子邮件至 yangqi1990917@163.com。  

# 展示  

我们提供基于Acss的Avalonia控件的Fluent主题。更多关于该主题的信息，请参见[Acss.Fluent](https://docs.en.avalonia.css.nlnet.net/documentation/zhu-ti-bang-zhu/ru-he-shi-yong-acss.fluent)。  

更多关于acss展示内容请见[bilibili](https://space.bilibili.com/1117754194/channel/seriesdetail?sid=3739599)或[youtube](https://www.youtube.com/channel/UCYvEgvGj-JVYZrOrup3aoBQ)。  

<br/>  

![fluent ui](https://raw.githubusercontent.com/liwuqingxin/Avalonia.Css/main/./img/fluent-ui.png)  

# 为什么使用Acss  

> 主题 = 结构 + 样式  

想象一下，我们有一个标准控件库，其控件的功能依赖于模板内的结构。如果我们想修改控件的外观，通常需要重写它们的所有ControlTheme。这意味着我们必须重写控件结构和样式，甚至资源。这是一项痛苦的工作。  

设想通过Acss模式，我们从控件的标准主题中提取样式，只保留骨架结构，即ControlTemplate。任何库都可以基于标准结构，定义自己的Acss库来实现控件所需的外观。那些库的创建者不需要痛苦地复制现有的ControlTheme代码进行修改，也不必担心控件模板是否正确。他们唯一需要关注的是根据UI设计调整样式！  

> 持续的专注让我们的工作更加顺畅、优雅且高效。
另一个情况是当我们创建一个新页面时，传统的工作流程通常包括布局、内容填充、编写业务逻辑、样式调整，以及基于UI设计的微调。  
这通常是开发者的工作，需要持续关注直到页面完成。现在，使用Acss模式，方法是由功能人员填充页面内容，编写业务逻辑，然后交给专注于视觉的人来协调视觉样式。  

# 我们提供的软件包  

- **Nlnet.Avalonia.Css**。这是Acss的核心。  

- **Nlnet.Avalonia.Css.Controls**。该库为Avalonia.Controls的控件提供纯结构。  

- **Nlnet.Avalonia.Css.Fluent**。该库为Avalonia.Controls、Nlnet.Avalonia.Senior和Nlnet.Avalonia.MessageBox提供Fluent UI。  

- **Nlnet.Avalonia.Css.Behaviors**。该库为Acss提供扩展行为。  
- **Nlnet.Avalonia.Senior**。该库提供一些扩展功能，如**平滑滚动**和Avalonia.Controls无法提供的其他高级功能。  
- **Nlnet.Avalonia.MessageBox**。该控件可提供遵循WPF标准或Avalonia标准的消息框控件。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---