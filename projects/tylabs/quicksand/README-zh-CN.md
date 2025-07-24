# QuickSand 版本 2

QuickSand Python 包和命令行工具

QuickSand 是一个基于 Python 的分析框架，用于分析疑似恶意软件文档，以识别不同编码或压缩流中的漏洞。QuickSand 支持文档、PDF、Mime/Email、Postscript 及其他常见格式。内置的命令行工具可以处理单个文档或文档目录。

QuickSand 使用 Yara 签名扫描文档和 PDF 解码流，以识别漏洞或高风险活动内容。

提供了一个托管版本，可在无需安装的情况下试用，地址为 [scan.tylabs.com](https://scan.tylabs.com/)。


## 文件：

- src/quicksand/quicksand.py：主要 quicksand 类和 CLI 工具

- src/quicksand/quicksand_exe.yara：检测可执行文件的 Yara 规则。

- src/quicksand/quicksand_exploits.yara：检测文档中漏洞的 Yara 规则。

- src/quicksand/quicksand_pdf.yara：检测 PDF 中漏洞的 Yara 规则。

- bin/quicksand：命令行工具。

- requirements.txt：Python 依赖

- [lambda/](https://raw.githubusercontent.com/tylabs/quicksand/main/lambda/README.md) 可选的 AWS Lambda 函数


### 感谢以下项目的作者：

- pdfreader

- oletools

- cryptography

- zipfile38

- olefile

- yara-python（需要 4.3.0 版本或更高）

- yara


## 使用 pip 从 Pypi 安装

```
pip3 install quicksand
```


## Upgrade from Pypi using pip

```
pip3 install --upgrade quicksand
```

## 从源码安装

如果您想从源码安装，例如从 GitHub 下载的 uicksand-main.zip：

```
pip3 install quicksand-main.zip
```

## 命令行使用

一个用于快速处理和输出 json 或 txt 结果的流沙命令行工具。


```
usage: quicksand [-h] [-v] [-c] [-y] [-t TIMEOUT] [-e EXPLOIT] [-x EXE] [-a PDF] [-f {json,txt}] [-o OUT] [-p PASSWORD]
                 [-d DROPDIR]
                 document

QuickSand Document and PDF maldoc analysis tool.

positional arguments:
  document              document or directory to scan

optional arguments:
  -h, --help            show this help message and exit
  -v, --verbose         increase output verbosity
  -c, --capture         capture stream content
  -y, --yara            capture yara matched strings
  -t TIMEOUT, --timeout TIMEOUT
                        timeout in seconds
  -e EXPLOIT, --exploit EXPLOIT
                        yara exploit signatures
  -x EXE, --exe EXE     yara executable signatures
  -a PDF, --pdf PDF     yara PDF signatures
  -f {json,txt}, --format {json,txt}
                        output format
  -o OUT, --out OUT     save output to this filename
  -p PASSWORD, --password PASSWORD
                        password to decrypt ole or pdf
  -d DROPDIR, --dropdir DROPDIR
                        save objects to this directory

```

### 处理单个文件

```
quicksand document.doc
```

### 处理一个文件目录

```
quicksand malware/
```

## Python 模块使用


### 从内存中的文件加载

```
from quicksand.quicksand import quicksand
import pprint

qs = quicksand(data, timeout=18, strings=True)
qs.process()
pprint.pprint(qs.results)
```

### 使用文件名进行处理

```
from quicksand.quicksand import quicksand

qs2 = quicksand("file.doc")
qs2.process()
qs.results
```

### 处理目录

```
from quicksand.quicksand import quicksand
qs = quicksand.readDir("malware")
qs
```
返回一个字典，格式为 {filename: `qs_results`,...}。


### 可选初始化参数

- capture: True|False 返回提取流的内容

- debug: True|False 在标准输出打印调试信息

- exploityara: 漏洞yara规则路径

- execyara: 可执行文件yara规则路径

- pdfyara: PDF漏洞yara规则

- password: 加密文档/PDF的密码

- timeout: 处理超时：0 表示无限制。


## 评分

文档的评分基于关联的Yara签名元数据中的rank值。

此外，每个签名定义了检测项是漏洞、警告还是风险特征。有关如何解释结果的更多信息，请参见 [https://scan.tylabs.com/howto](https://quicksand.io/howto)。

如果您添加自己的签名，它们不需要包含额外的元数据即可正常工作。

### MacOS上的zlib问题

MacOS用户可能会遇到zlib问题（PDF FlateDecode等），这是由于自MacOs 10.4起缺少OpenSSL头文件所致。


```
zlib.error: Error -3 while decompressing data: unknown compression method
zlib.error: Error -3 while decompressing data: incorrect header check
```
一种解决方案是使用 Brew.sh 安装 zlib 并使用 pyenv 重新安装 Python 3：


```
export LDFLAGS="-L/usr/local/opt/zlib/lib"
export CPPFLAGS="-I/usr/local/opt/zlib/include"
pyenv install 3.8.5
```

## 使用 Quicksand？

[告诉我们](https://tylabs.com) @tylabs


## 问题和项目主页

[QuickSand GitHub](https://github.com/tylabs/quicksand/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---