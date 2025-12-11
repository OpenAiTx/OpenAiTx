# gig

Gig 是一个用 gleam 编写的 gleam 编译器。

## 如何使用

### 编译并运行示例文件：

```bash
# clone the repository
git clone https://github.com/schurhammer/gig
cd gig

# compile a sample
gleam run samples/hello_world.gleam

# run the sample
samples/hello_world.exe
```
- 这将把文件 `samples/hello_world.gleam` 编译为 `samples/hello_world.c`，然后使用 C 编译器创建位于 `samples/hello_world.exe` 的二进制文件。
- Gig 添加 `.exe` 扩展名以避免与源代码目录的常见命名冲突。

### 编译 gig：


```bash
# compile gig into a binary
gleam run src/gig.gleam --gc --release

# compile a sample using the gig binary
src/gig.exe samples/hello_world.gleam

# run the sample
samples/hello_world.exe
```

### 使用 gig 可执行文件编译你的项目：

- 将 `gig` 可执行文件添加到你的路径中或复制到你的项目中。
- 将 `patch` 目录复制到你的项目中。

```bash
# you should be in your project root
cd <your project root>

# copy patch directory (adjust file paths to match your system)
cp -r ../gig/patch patch

# ensure dependencies are downloaded
gleam deps download

# compile your main module
gig src/<main module>.gleam

# run your main module
src/<main module>.exe
```
- 你应该从项目的根目录运行 gig。
- Gig 将包含主模块目录、`patch` 目录以及每个下载依赖的源代码目录中的源文件（即 `build/packages/<package_name>/src`）。
- 使用 `gleam deps download` 下载依赖。
- 你的主模块应为非嵌套的，即直接位于 `src` 目录中。

### 使用 gig 作为路径依赖编译你的项目

- 在你的 `gleam.toml` 文件中添加 gig 作为路径依赖 `gig = { path = "../gig" }`。
- 将 `patch` 目录复制到你的项目中。


```bash
# you should be in your project root
cd <your project root>

# copy patch directory (adjust file paths to match your system)
cp -r ../gig/patch patch

# ensure dependencies are downloaded
gleam deps download

# compile your project using gig as a path dependency
gleam run -m gig src/<main module>.gleam

# run your main module
src/<main module>.exe
```

### 可选标志：

- `--release`：启用优化。
- `--gc`：启用垃圾回收（否则不进行垃圾回收）。
- `--debug`：包含调试符号。
- `--headers`：为 FFI 函数生成头文件。
- `--compiler=name`：指定 C 编译器的名称/路径。
- `-c`：仅生成 C 文件（不生成二进制文件）。

> [!重要]
> 如果很可能遇到栈溢出，请增加栈大小。这些通常表现为段错误。
>
> ```
> ulimit -s unlimited
> ```

## 必要依赖：

- C 编译器（clang 似乎效果最好）
- `--gc` 需要 Boehm GC（即 `libgc`）

## 标准库

由于标准库的大部分是通过 `@external` 调用实现的，目前并非所有函数都可用。
一些函数已通过补丁重新实现，见 `patch` 目录。若使用未实现的函数，编译器将发出警告，并使用“todo”作为函数体。

## 补丁系统

由于 gig 是第三方项目，大多数现有的 gleam 库
可能不支持它。针对这种情况，我们有一个补丁系统，
允许你覆盖某些本来无法工作的模块。只需创建一个名为
`x.patch.gleam` 的模块，其中 `x` 是你想要修补的模块名称。
补丁将与原模块合并，因此你只需实现那些有问题的函数。
补丁可放置在 `patch` 目录或任何源码目录中。

为了在编辑器中更好地支持 C 语言，你可以为项目添加 `.clangd` 和
`compile_flags.txt` 文件。


`.clangd`：

```
CompileFlags:
  Add: [-Ipatch]
```

`compile_flags.txt`：（空文件）

## FFI

你可以使用 `@external(c, "", "function_name")` 注解来定义 C 函数，类似于普通 gleam 中的 FFI。  
之后，使用 `--headers` 选项运行编译器以生成包含实现外部函数所需的函数和类型声明的头文件。  
你的实现 C 文件应 `#include` 该头文件，并且命名应与头文件相同。  
最好你的函数应带有命名空间，例如 `module_name_function_name()`。

## 功能 / 待办列表

### 基础

- [x] 布尔值  
- [x] 整数  
- [x] 浮点数  
- [x] 数字格式（十进制以外）  
- [x] 字符串  
- [x] 列表  
- [x] 相等性  
- [x] 赋值  
- [x] 丢弃模式  
- [x] 类型推断  
- [x] 类型注解  
- [x] 模块（注：模块相对于目标文件解析）  
- [x] 依赖  
- [x] 非限定导入  
- [x] 类型别名  
- [x] 代码块  
- [x] 常量  
- [x] 内存管理（GC/RC）

### 函数

- [x] 函数  
- [x] 高阶函数



- [x] 匿名函数
- [x] 函数捕获
- [x] 泛型函数
- [x] 管道
- [x] 带标签的参数
- [ ] 文档注释（忽略）
- [ ] 弃用（忽略）

### 流程控制

- [x] Case 表达式
- [x] 变量模式
- [x] 构造函数模式
- [x] 字符串模式
- [x] 列表模式
- [x] 递归
- [ ] 尾调用（注意：c 编译器可能为我们完成此项）
- [x] 多主体
- [x] 备选模式
- [x] 模式别名
- [x] 守卫
- [ ] 完备性检查

### 其他数据类型

- [x] 元组
- [x] 自定义类型
- [x] 记录
- [x] 记录访问器
- [x] 记录更新
- [x] 泛型自定义类型
- [x] 结果
- [ ] 位数组（部分支持）

### 高级特性

- [ ] 不透明类型
- [x] 使用
- [x] 待办
- [x] 恐慌
- [x] 让 assert
- [x] 外部依赖

## 贡献

我目前不接受代码贡献。不过欢迎提交问题、建议或参与讨论。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---