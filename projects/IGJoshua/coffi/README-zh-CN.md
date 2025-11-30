# coffi
[![Clojars Project](https://img.shields.io/clojars/v/org.suskalo/coffi.svg)](https://clojars.org/org.suskalo/coffi)
[![cljdoc badge](https://cljdoc.org/badge/org.suskalo/coffi)](https://cljdoc.org/d/org.suskalo/coffi)

Coffi 是一个用于 Clojure 的外部函数接口库，使用 JDK 22 及更高版本中的 [Foreign
Function & Memory API](https://openjdk.org/jeps/454)。这允许直接从 Clojure 调用本地代码，
而无需像 JNI 那样依赖于库特定的 Java 或本地代码。Coffi 侧重于易用性，包括用于创建包装器的函数和宏，
使得生成的本地函数表现得就像 Clojure 函数一样，但这并不妨碍编写系统以最小化数据编组成本并优化性能，
利用 FF&M API 提供的低级访问能力。

- [快速入门](https://cljdoc.org/d/org.suskalo/coffi/CURRENT/doc/getting-started)
- [API 文档](https://cljdoc.org/d/org.suskalo/coffi/CURRENT/api/coffi)
- [更新记录](https://raw.githubusercontent.com/IGJoshua/coffi/develop/CHANGELOG.md)

## 安装
此库可在 Clojars 上获得，也可以作为 git 依赖。将以下条目之一添加到你的 `deps.edn` 文件的 `:deps` 键中：






```clojure
org.suskalo/coffi {:mvn/version "1.0.615"}
io.github.IGJoshua/coffi {:git/tag "v1.0.615" :git/sha "7401485"}
```
如果您将此库作为 git 依赖使用，您需要准备该库。



```sh
$ clj -X:deps prep
```
Coffi 需要使用包 `java.lang.foreign`，并且大多数操作被 JDK 视为不安全，因此在不传递某些命令行标志的情况下，您的代码无法使用这些操作。为了使用 coffi，请向您的应用程序添加以下 JVM 参数。





```sh
--enable-native-access=ALL-UNNAMED
```

您可以在特定的 Clojure CLI 调用中使用 `-J` 标志指定 JVM 参数，方法如下：


``` sh
clj -J--enable-native-access=ALL-UNNAMED
```

你也可以在你的 `deps.edn` 文件中的别名下通过
`:jvm-opts` 键指定它们（见下一个示例），然后使用 `-M`、`-A` 或 `-X`
调用带有该别名的 CLI。

``` clojure
{:aliases {:dev {:jvm-opts ["--enable-native-access=ALL-UNNAMED"]}}}
```
其他构建工具如果查阅它们的文档，也应提供类似的功能。

在创建可执行的 jar 文件时，可以通过向 jar 添加清单属性 `Enable-Native-Access: ALL-UNNAMED` 来避免传递此参数的需求。有关如何添加，请参阅您的构建工具文档。

Coffi 还支持 linter clj-kondo。如果您使用 clj-kondo 并且该库的宏未正确进行 lint，您可能需要安装随库捆绑的配置。您可以通过以下 shell 命令完成，需在项目目录下运行：








```sh
$ clj-kondo --copy-configs --dependencies --lint "$(clojure -Spath)"
```

## 使用方法
两个主要的命名空间是 `coffi.mem`，它提供分配和操作堆外内存以及（反）序列化值的函数，和 `coffi.ffi`，它可以加载本地库，声明本地函数包装器，以及将函数作为回调进行（反）序列化。




```clojure
(require '[coffi.mem :as mem])
(require '[coffi.ffi :as ffi :refer [defcfn]])

(defcfn strlen
  "Given a string, measures its length in bytes."
  strlen [::mem/c-string] ::mem/long)

(strlen "hello")
;; => 5

(ffi/load-system-library "z")
```
在 `coffi.mem` 命名空间中，包含了所有 C 语言中有符号原始数值类型的类型，此外还有 `::mem/pointer` 和 `::mem/c-string`，以及使用类似 malli 的类型声明来定义结构体、联合体、数组、枚举和标志集的方法。

## 替代方案
该库并不是唯一提供访问本地代码的 Clojure 库。此外，还存在以下（以及其他）库：

- [dtype-next](https://github.com/cnuernber/dtype-next)
- [tech.jna](https://github.com/techascent/tech.jna)
- [clojure-jna](https://github.com/Chouser/clojure-jna)

Dtype-next 支持 Java 版本 8-15、17+ 以及 GraalVM，但重点是基于数组的编程，并且侧重于将内存保持在本地端，而不是在 Clojure 本地结构和 C 之间来回传递数据。在 Java 17+ 中，它使用外部函数与内存 API（Project Panama 的一部分，直到 JDK 22 稳定），而在其他 Java 版本中使用 JNA。

Tech.jna 和 clojure-jna 在所有情况下都使用 JNA 库，并且都不提供对回调的显式支持。JNA 允许使用 `java.nio.ByteBuffer` 来按值传递结构体，这两个库都提供了使用这种按值构造来调用按引用 API 的方式。

coffi 的另一个替代方案是直接使用 JNI，这是 JVM 中封装本地代码最久远的方法，但缺点是你需要编写本地代码和 Java 代码，即使你只打算从 Clojure 中使用它。

如果你的应用需要能够运行在早于 JVM 22 的版本中，应考虑这些其他选项。Dtype-next 提供了最强大的本地代码支持，但如果你只是封装一个简单的库，其他库可能更具吸引力，因为它们的 API 面较小，且更容易封装函数。

此外，还有一个 [第三方 FFI 选项汇总](https://docs.google.com/spreadsheets/d/1ViLHNUgrO2osh2AH0h7MaCaXz8g0UpLbyWojY5f10kk/edit?gid=332155605#gid=332155605) 列出了 Clojure 的 FFI 选项。






















## 已知问题
项目作者已知晓这些问题，并计划在未来的版本中修复它们：

- 当在依赖 coffi 的库中使用 codox 生成文档时，会出现以下错误。临时的解决方法是在你的 codox 构建中显式依赖版本为 0.2.1 的 insn。

  ```
  Unable to find static field: ACC_OPEN in interface org.objectweb.asm.Opcodes
  ```

## 未来计划
这些功能计划在未来版本中实现。

- 支持 va_args 类型
- 用于生成数据模型的头文件解析工具？（也许只需配合 [clong](https://github.com/phronmophobic/clong) 使用？）
- 泛型类型别名
- 无符号整数类型
- 用于输出参数的辅助宏
- 改进 defcfn 宏的错误信息
- 映射内存
- 用于更复杂数据类型自定义 serde 实现的辅助宏
- 支持 GraalVM Native Image（待其对 FFM 的支持成熟后）

## 许可证

版权所有 © 2023 Joshua Suskalo

根据 Eclipse 公共许可证版本 1.0 发布。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-30

---