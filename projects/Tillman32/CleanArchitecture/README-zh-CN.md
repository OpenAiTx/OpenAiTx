[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![CI - Build and Test](https://github.com/Tillman32/CleanArchitecture/actions/workflows/ci.yml/badge.svg)](https://github.com/Tillman32/CleanArchitecture/actions/workflows/ci.yml)
[![Deploy to GitHub Pages](https://github.com/Tillman32/CleanArchitecture/actions/workflows/pages.yml/badge.svg)](https://github.com/Tillman32/CleanArchitecture/actions/workflows/pages.yml)

![](https://raw.githubusercontent.com/Tillman32/CleanArchitecture/master/./src/CleanArchitecture.WASM/Preview.png)

[LIVE DEMO - WASM on GitHub Pages](https://tillman32.github.io/CleanArchitecture/)

# 这背后的动机

这一切的意义何在？嗯，除了展示Bob Ross之外……我认为拥有一个“真实世界”的应用程序作为架构讨论的参考会很聪明。我要做的是设定一个标准，一个可以克隆的模板，一个可以在我所有后续的 .Net Core 项目中使用的东西。就像所有软件（和葡萄酒）一样，这将随着时间的推移而改进。

我还觉得很贴切，“Uncle Bob”（Robert C. Martin）有个相似的名字，而这个项目尝试与他在[他的网站上概述的架构](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)保持一致。

我还写了一篇配套博客文章，链接在这里：[https://www.brandontillman.com/blog/clean-architecture-dotnet](https://www.brandontillman.com/blog/clean-architecture-dotnet)

# 关键点：

### :trident: N层架构

一种三层方法，为我们设置多个使用相同核心业务功能/后端的UI。

### :open_file_folder: 关注点分离

与[“单一职责”](http://deviq.com/single-responsibility-principle/)原则密切相关，关注点分离（SoC）使您的代码更易维护，因为它不会将不同的概念混杂在一起。当事物发生变化时，SoC将帮助确保您的更改仅限于您的功能集，而不会波及整个应用程序。

### :droplet: 无泄漏的抽象

通过使用接口，我们可以避免抽象泄漏，更好地控制代码的使用方式。相反，代码的使用者不必了解实现细节，他们只需使用您的接口/类即可。

### :microscope: 可测试

紧耦合的代码几乎无法测试。通过遵循SOC原则并使用接口，我们的代码将更容易进行测试。

### :electric_plug: 模块化

代码在未来更易于修改，原因有几方面。关注点分离减少了整个应用程序中的更改/测试次数。您可以构建特定的功能集，而无需修改其他代码。

### :wrench: 易维护

通过遵循清洁架构模式，代码本质上将更易于维护。其他开发者会看到这种清晰分离的好处，并效仿之。

# 主要使用技术

- [.Net](https://dotnet.microsoft.com/)
- [Blazor WASM](https://www.learnblazor.com/)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [AutoMapper](https://automapper.org/)
- [NLog](https://nlog-project.org/)

### :star2: 点个星吧！ 
如果你喜欢或正在使用这个项目来学习或启动你的解决方案，请考虑给它点个星。谢谢！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-29

---