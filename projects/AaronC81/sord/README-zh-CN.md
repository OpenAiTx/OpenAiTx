# Sord

## 概述

Sord 是一个 [**So**rbet](https://sorbet.org) 和 [YA**RD**](https://yardoc.org/) 的
跨界工具。它可以通过查看 **YARD 文档注释中指定的类型**，**自动生成 RBI 和 RBS 类型签名文件**。

如果你的项目已经有 YARD 文档，那么它可以生成你所需的大部分类型签名！

Sord 是在项目中快速采用类型的完美方式，无论你计划使用 Sorbet 的 RBI 格式还是 Ruby 3/Steep 的 RBS 格式。

**在线试用 Sord： [sord.aaronc.cc](https://sord.aaronc.cc)**

Sord 具有以下功能：
  - 自动为模块、类和方法生成签名
  - 支持多参数或返回类型（`T.any`/`|`）
  - 优雅处理缺失的 YARD 类型（`T.untyped`/`untyped`）
  - 可从对应的 getter 返回类型推断 setter 参数类型
  - 识别 mixin（`include` 和 `extend`）
  - 支持泛型类型，如 `Array<T>` 和 `Hash<K, V>`
  - 可推断命名空间类（`[Bar]` 可变为 `GemName::Foo::Bar`）
  - 处理可能为 `nil` 的返回类型（`T.nilable`/`untyped`）
  - 处理鸭子类型（`T.untyped`/`untyped`）
  - 支持有序列表类型（`[Array(Integer, Symbol)]` 变为 `[Integer, Symbol]`）
  - 支持布尔类型（`[true, false]` 变为 `T::Boolean`/`bool`）
  - 支持使用 `@yieldparam` 和 `@yieldreturn` 注释的 `&block` 参数

## 使用方法

使用命令 `gem install sord` 安装 Sord。

Sord 是一个命令行工具。使用时，在项目根目录打开终端，
执行 `sord`，并传入你希望保存文件的路径（该文件将被覆盖）：





```
sord defs.rbi
```
Sord 将生成 YARD 文档，然后在运行时打印其推断的信息。最好修复任何 YARD 文档中的问题，因为对生成文件所做的任何编辑在重新运行 Sord 时都会被替换。

输出类型由您使用的文件扩展名推断，但您也可以使用 `--rbi` 或 `--rbs` 明确指定。

## 发送 RBI 类型

Sord 生成的 RBI 文件主要有两种使用方式：

- [随 gem 本身一起发布](https://sorbet.org/docs/rbi#rbis-within-gems)。
- 贡献给 [sorbet-typed](https://github.com/sorbet/sorbet-typed)。

通常，如果可能的话，您应该随 gem 一起发布类型签名。  
sorbet-typed 是为那些不再更新的 gem 或维护者不愿随 gem 本身发布类型签名的 gem 提供的地方。

### 标志

Sord 还接受一些标志来修改生成的文件：

  - `--rbi`/`--rbs`：覆盖从文件扩展名推断的输出格式。
  - `--no-sord-comments`：生成的文件中不包含任何关于警告/推断/错误的 Sord 注释。（原始文件的注释仍会被包含。）
  - `--no-regenerate`：默认情况下，Sord 会为您重新生成代码库的 YARD 文档。此选项跳过重新生成 YARD 文档。
  - `--break-params`：确定需要多少个参数后，签名从单行变为多行块。（默认值：4）
  - `--replace-errors-with-untyped`：使用 `T.untyped` 替代 `SORD_ERROR_*` 常量。
  - `--replace-unresolved-with-untyped`：当 Sord 无法解析常量时，使用 `T.untyped`。
  - `--include-messages` 和 `--exclude-messages`：用于过滤 Sord 给出的日志消息。`--include-messages` 作为白名单，仅打印指定日志类型的消息，而 `--exclude-messages`















    作为黑名单并抑制指定的日志类型。两个标志都接受用逗号分隔的日志类型列表，例如 `omit,infer`。
    使用 `--include-messages` 时，默认包含 `done` 类型。
    （不能同时指定 `--include-messages` 和 `--exclude-messages`。）
  - `--exclude-untyped`：排除返回值未指定类型的方法和属性。
  - `--tags TAGS`：提供由 `yard` 命令理解的逗号分隔标签列表。例如 `--tags 'mytag:My Description,mytag2:My New Description'`

## 示例

假设我们有这个文件，名为 `test.rb`：




```ruby
module Example
  class Person
    # @param name [String] The name of the Person to create.
    # @param age [Integer] The age of the Person to create.
    # @return [Example::Person]
    def initialize(name, age)
      @name = name
      @age = age
    end

    # @return [String]
    attr_accessor :name

    # @return [Integer]
    attr_accessor :age

    # @param possible_names [Array<String>] An array of potential names to choose from.
    # @param possible_ages [Array<Integer>] An array of potential ages to choose from.
    # @return [Example::Person]
    def self.construct_randomly(possible_names, possible_ages)
      Person.new(possible_names.sample, possible_ages.sample)
    end
  end
end
```
首先，通过运行 `yardoc test.rb` 生成一个 YARD 注册表。然后，我们可以运行  
`sord test.rbi` 来生成 RBI 文件。（注意不要覆盖你的代码文件！注意 `.rbi` 文件扩展名。）  
在执行此操作时，Sord 会打印：


```
[INFER] Assuming from filename you wish to generate in RBI format
[DONE ] Processed 8 objects (2 namespaces and 6 methods)
```

`test.rbi` 文件随后包含了 `test.rb` 的完整 RBI 文件：

```ruby
# typed: strong
module Example
  class Person
    # _@param_ `name` — The name of the Person to create.
    # 
    # _@param_ `age` — The age of the Person to create.
    sig { params(name: String, age: Integer).void }
    def initialize(name, age); end

    # _@param_ `possible_names` — An array of potential names to choose from.
    # 
    # _@param_ `possible_ages` — An array of potential ages to choose from.
    sig { params(possible_names: T::Array[String], possible_ages: T::Array[Integer]).returns(Example::Person) }
    def self.construct_randomly(possible_names, possible_ages); end

    sig { returns(String) }
    attr_accessor :name

    sig { returns(Integer) }
    attr_accessor :age
  end
end
```
如果我们生成的是 `test.rbs`，我们将得到以下 RBS 格式的文件：


```ruby
module Example
  class Person
    # _@param_ `name` — The name of the Person to create.
    # 
    # _@param_ `age` — The age of the Person to create.
    def initialize: (String name, Integer age) -> void

    # _@param_ `possible_names` — An array of potential names to choose from.
    # 
    # _@param_ `possible_ages` — An array of potential ages to choose from.
    def self.construct_randomly: (Array[String] possible_names, Array[Integer] possible_ages) -> Example::Person

    attr_accessor name: String

    attr_accessor age: Integer
  end
end
```

## 需注意事项

类型转换的一般规则是：

  - 如果 Sord 理解 YARD 类型，则将其转换为 RBI 或 RBS 类型。
  - 如果缺少 YARD 类型，Sord 会填充 `T.untyped`。
  - 如果无法理解 YARD 类型，Sord 会创建一个与未知 YARD 类型名称相似的未定义 Ruby 常量。
    例如，明显无效的 YARD 类型 `A%B` 会变成名为 `SORD_ERROR_AB` 的常量。
    你应该在生成的文件中搜索并修复所有 `SORD_ERROR`。

## 贡献

欢迎在 GitHub 上提交错误报告和拉取请求，地址：https://github.com/AaronC81/sord。该项目旨在成为一个安全、友好的协作空间，贡献者需遵守 [贡献者公约](http://contributor-covenant.org) 行为准则。

贡献时，如果想查看对 Sord 所做更改的效果，可以使用 `examples:seed` Rake 任务。
该任务使用 Sord 为多个开源 Ruby gem（包括 Bundler、Haml、Rouge 和 RSpec）生成类型。
运行 `rake examples:seed`（以及 `rake examples:reseed` 以重新生成文件）会将这些 gem 的代码仓库克隆到 `sord_examples/` 目录，
然后在同一目录中生成相应文件。

## 许可协议

该 gem 作为开源项目，遵循 [MIT 许可证](https://opensource.org/licenses/MIT) 许可条款。

## 行为准则

所有在 Sord 项目的代码库、问题追踪器、聊天室和邮件列表中互动的人员，
都应遵守 [行为准则](https://github.com/AaronC81/sord/blob/master/CODE_OF_CONDUCT.md)。






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-30

---