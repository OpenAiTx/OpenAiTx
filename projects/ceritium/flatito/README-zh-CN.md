# Flatito：用于 YAML 和 JSON 文件的 grep 工具

一种用于 YAML 和 JSON 文件的 grep 工具。它允许你搜索一个键，并获取其对应的值及所在的行号。

![示例](https://raw.githubusercontent.com/ceritium/flatito/master/docs/screenshot.png)

## 含义

[世界语](https://en.wiktionary.org/wiki/flatito)：flati（“奉承”）的单数过去名词被动分词。

## 安装

安装该 gem 并通过执行以下命令将其添加到应用程序的 Gemfile 中：

    $ bundle add flatito

如果不使用 bundler 管理依赖项，则通过执行以下命令安装该 gem：

    $ gem install flatito

### Nixpkgs 包

由于 [@Rucadi](https://github.com/Rucadi) 的贡献，也可以通过 [nixpkgs](https://search.nixos.org/packages?channel=unstable&show=flatito) 获得

    $ nix run nixpkgs#flatito


## 使用方法

```sh
Usage:    flatito PATH [options]
Example:  flatito . -k "search string" -e "json,yaml"
Example:  cat file.yaml | flatito -k "search string"

    -h, --help                       Prints this help
    -V, --version                    Show version
    -k, --search-key=SEARCH          Search string
        --no-color                   Disable color output
    -e, --extensions=EXTENSIONS      File extensions to search, separated by comma, default: (json,yaml,yaml)
        --no-skipping                Do not skip hidden files
```
## 开发

检出代码库后，运行 `bin/setup` 来安装依赖。然后，运行 `rake test` 来执行测试。你也可以运行 `bin/console` 进入交互式命令行，方便你进行实验。

要将此 gem 安装到本地机器上，运行 `bundle exec rake install`。要发布新版本，更新 `version.rb` 中的版本号，然后运行 `bundle exec rake release`，该命令将为版本创建 git 标签，推送 git 提交和创建的标签，并将 `.gem` 文件推送到 [rubygems.org](https://rubygems.org)。

## 贡献

欢迎在 GitHub https://github.com/ceritium/flatito 上报告漏洞和提交拉取请求。此项目旨在成为一个安全、友好的协作空间，贡献者应遵守 [行为准则](https://github.com/ceritium/flatito/blob/master/CODE_OF_CONDUCT.md)。

## 许可证

该 gem 作为开源软件，根据 [MIT 许可证](https://opensource.org/licenses/MIT) 条款提供。

## 行为准则

所有参与 Flatito 项目代码库、问题追踪、聊天室和邮件列表的人员，均应遵守 [行为准则](https://github.com/ceritium/flatito/blob/master/CODE_OF_CONDUCT.md)。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---