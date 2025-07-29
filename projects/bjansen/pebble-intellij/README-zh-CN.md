# Pebble 的 IntelliJ 插件 [![Gitter](https://badges.gitter.im/bjansen/pebble-intellij.svg)](https://gitter.im/bjansen/pebble-intellij) [![GitHub Actions](https://github.com/bjansen/pebble-intellij/workflows/Java%20CI/badge.svg?branch=master)](https://github.com/bjansen/pebble-intellij/actions) [![GitHub release](https://img.shields.io/github/release/bjansen/pebble-intellij.svg)](https://plugins.jetbrains.com/plugin/9407-pebble) [![Coverage](https://sonarcloud.io/api/project_badges/measure?project=pebble-intellij&metric=coverage)](https://sonarcloud.io/dashboard?id=pebble-intellij)

该插件为 IntelliJ IDEA 2017.3 及更高版本提供对 [Pebble 模板引擎](https://github.com/PebbleTemplates/pebble) 的支持。

<p align="center">
  <img src="https://github.com/bjansen/pebble-intellij/raw/master/images/plugin.png" 
       width="594" alt="Pebble 的 IntelliJ 插件"/>
<p>

## 功能

* 解析器/词法分析器<sup>1</sup> 和语法高亮（支持自定义分隔符）
* 内置标签的活模板
* 括号匹配、代码折叠和注释
* 引号处理
* 导航（方法和字段，包含的文件）
* 代码补全
* 高亮未知引用
* 支持由 [pebble-spring](https://github.com/PebbleTemplates/pebble/wiki/spring-integration) 引入的变量和函数
* [更多功能开发中](https://github.com/bjansen/pebble-intellij/issues?utf8=%E2%9C%93&q=is%3Aissue%20is%3Aopen%20label%3At-feature)

<sup>1</sup>：*当前不支持自定义操作符*。

## 安装

该插件可在 JetBrains 的 [插件仓库](https://plugins.jetbrains.com/idea/plugin/9407-pebble) 中获取，  
在您的 IDE 中打开 `Preferences > Plugins`，并在搜索栏输入 `pebble`。

## 混合使用 Pebble 和其他语言

为了让编辑器识别同一文件中的两种语言，例如 HTML 和 Pebble，  
请前往 `Preferences > Languages & Frameworks > Template Data Languages`，  
并在包含 Pebble 模板的目录上选择 `HTML` 数据语言：

![模板数据语言设置](https://raw.githubusercontent.com/bjansen/pebble-intellij/master/images/settings.png)

这将启用语法高亮、代码补全、导航、Emmet 扩展等功能。

## 使用代码补全

为了使用代码补全，您需要让插件知道 `foo` 的类型。  
这可以通过 `@pebvariable` 提示实现，类似于 JSP、FreeMarker 和 Velocity 插件：

![代码补全](https://raw.githubusercontent.com/bjansen/pebble-intellij/master/images/completion.png)

可以通过 `var` 活模板轻松向模板中添加 `@pebvariable` 提示。其语法必须如下：

    {# @pebvariable name="<name>" type="<type>" #}

为了使代码补全在 `type` 属性中正常工作，您的 `.peb` 文件需要放置在[内容根目录](https://www.jetbrains.com/help/idea/content-roots.html)下（例如 `src/main/resources`）。  
否则，您自己源码中定义的类将不会被建议。

## 每夜构建版本

快照版本可通过 Actions CI 获得：  
 * 访问 https://github.com/bjansen/pebble-intellij/actions  
 * 点击最新构建  
 * 滚动到页面底部，在 `Artifacts` 部分点击 `pebble-intellij-development`  
 * 这将下载一个 zip 文件，可以通过 IDE 的[从磁盘安装插件](https://www.jetbrains.com/help/idea/managing-plugins.html#install_plugin_from_disk)功能安装该插件








---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---