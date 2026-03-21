# suppress-eslint-errors

![Release](https://github.com/amanda-mitchell/suppress-eslint-errors/workflows/Release/badge.svg)

你是否曾尝试启用一个新的 eslint 规则，却被现有代码库中成百上千的错误吓退？
我们也是。

有时候，没有充分的业务理由去更新所有现有（且可用！）的代码，尤其是在较大的遗留代码库中。
在这种情况下，`suppress-eslint-errors` 可以帮助你。

## 工作原理

`suppress-eslint-errors` 是一个基于 [jscodeshift](https://github.com/facebook/jscodeshift) 的代码修改工具，它会针对你的现有代码运行 eslint。
对于它发现的每个 eslint 错误，它都会添加一段小代码片段：

```javascript
// TODO: Fix this the next time the file is edited.
// eslint-disable-next-line cool-new-rule
```
这样，您可以在新代码中获得规则的好处，而无需立即处理大量积压问题。

## 用法

`suppress-eslint-errors` 配有一个包装脚本，您可以直接调用它，无需额外安装任何东西：


```bash
npx suppress-eslint-errors [jscodeshift options] PATH...
```
包装器将使用转换器和您传递的任何其他参数调用 `jscodeshift`。  
如果它检测到本地目录中有 `.gitignore`，它也会将其指定为 `--ignore-config`。  

`suppress-eslint-errors` 必须与本地安装的 `eslint` 一起使用。  
如果找不到本地安装的 `eslint`，它将提前退出。  

_注意：_ `jscodeshift` 在处理 `.gitignore` 文件时存在一些错误，有时会导致忽略所有文件。  
如果此工具检测到您的 `.gitignore` 包含有问题的模式，将跳过 `--ignore-config` 选项。  

在某些情况下，此代码修改工具生成的代码在缩进方面可能做出一些不理想的决定。  
请确保在提交前重新运行您使用的任何代码格式化工具！  

## 选项  

**--message**：设置添加在 eslint-disable-next-line 注释上方的注释内容。  

**--rules**：用逗号分隔的 ESLint 规则 ID 列表，用于禁用这些规则。指定此选项时，不在此列表中的规则违规将保留不变。  

## 示例  

使用自定义注释，在 `index.js` 文件中抑制所有错误：


```bash
npx suppress-eslint-errors ./index.js --message="TODO: Issue #123"
```

在 `src` 目录中的 .ts 和 .tsx 文件中，抑制 `eqeqeq` 和 `@typescript-eslint/no-explicit-any` 规则的违规行为：

```bash
npx suppress-eslint-errors ./src --extensions=ts,tsx --parser=tsx --rules=eqeqeq,@typescript-eslint/no-explicit-any
```

## 细微差别

正如工具名称所示，它仅抑制 eslint 的 _错误_。
如果你有想要抑制的警告，请在运行工具之前修改你的 eslint 配置，将警告转换为错误，或者使用 `--rules` 标志指定规则。

## 它完美吗？

绝对不是。如果你遇到任何边缘情况，欢迎提交 PR。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---