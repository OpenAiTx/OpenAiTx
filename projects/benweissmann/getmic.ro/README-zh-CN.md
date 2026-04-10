# getmic.ro

![测试](https://github.com/benweissmann/getmic.ro/workflows/Test/badge.svg)

安装 [Micro](https://micro-editor.github.io/) 的最快方式

```Bash
# local install just for your user
curl https://getmic.ro | bash
```
或者，使用 `wget` 替代 `curl`，以及使用任何 `sh` 解释器替代 `bash`：


```Bash
# local install just for your user
wget -O- https://getmic.ro | sh
```

此脚本将 micro 安装到您当前所在的目录。若要安装到其他位置（例如 /usr/local/bin），请切换到该目录并确保您有写入权限，例如 `cd /usr/local/bin; curl https://getmic.ro | sudo sh`，操作如下：

```Bash
# global install for all users
cd /usr/bin
curl https://getmic.ro | sudo sh
```
该脚本还可以使用 update-alternatives 将 micro 注册为系统文本编辑器。  
例如，这将允许 `crontab -e` 使用 micro 打开 cron 文件。  

要启用此功能，请定义 `GETMICRO_REGISTER` 变量或使用 URL  
`https://getmic.ro/r`。请注意，执行此操作时必须将 micro 安装到所有用户都可访问的目录，通常是 /usr/bin：



```Bash
# global install for all users, registering with update-alternatives
cd /usr/bin
curl https://getmic.ro/r | sudo sh
```

> 您不懂英语？您会说法语吗？**请查看[*法语版自述文件*](https://raw.githubusercontent.com/benweissmann/getmic.ro/master/./README.fr.md)！**

## 高级用法

getmic.ro 还有其他一些用法。下面列出了您可以选择的环境变量：

* `GETMICRO_HTTP=<COMMAND ...ARGS>`
    + 使用此命令及空格分隔的参数从互联网上下载文件。
        - 它必须遵循重定向（通过 HTTP Location 头）。
        - 它必须将结果文件内容打印到标准输出。
        - 它必须接受下一个参数作为要下载的文件 URL。
        - 命令可选支持 `--header` 参数，用于非必需的 GitHub 身份验证回退。
    + 例如，强制使用 `curl`：`curl https://getmic.ro | GETMICRO_HTTP="curl -L" sh`
    + 例如，强制使用 `wget`：`wget -O- https://getmic.ro | GETMICRO_HTTP="wget -O-" sh`
* `GETMICRO_PLATFORM=[freebsd32 | freebsd64 linux-arm | linux-arm64 | linux32 | linux64 | linux64-static | macos-arm64 | netbsd32 | netbsd64 | openbsd32 | openbsd64 | osx | win32 | win64]`
    + 手动覆盖平台检测机制，下载您指定平台的二进制文件
    + 例如在使用不兼容 libc 实现（如 musl）时，可使用 `https://getmic.ro | GETMICRO_PLATFORM=linux64-static sh`
* `GETMICRO_REGISTER=[y | n]`
    + 是否通过 `update-alternatives` 注册 micro，使其可作为系统文本编辑器无缝使用。
        - y => 是
        - n => 否（默认）
    + 如果定义了 GETMICRO_REGISTER 但系统不支持 `update-alternatives`，则该选项会被静默忽略。
    + 启用时，getmicro 必须以有足够权限（通常是 root 用户）运行以使用 `update-alternatives`，否则 getmicro 会报错退出。
    + 作为简写，您可以使用 `https://getmic.ro/r`，它定义了 `GETMICRO_REGISTER=y`。

综合起来，下面的命令行将始终使用 wget，始终安装 linux32 二进制文件，并始终注册到 `update-alternatives`：

```Bash
wget -O- https://getmic.ro | GETMICRO_HTTP="wget -O-" GETMICRO_PLATFORM=linux32 GETMICRO_REGISTER=y sh
```

### 验证脚本校验和

要验证脚本，您可以下载它并计算校验和。sha256 校验和是 `d041f51b97871dc7de1f01879c12a978b074a5acdb6528e884ce8f4c05d2ad35`。

```Bash
gmcr="$(curl https://getmic.ro)" && [ $(echo "$gmcr" | shasum -a 256 | cut -d' ' -f1) = d041f51b97871dc7de1f01879c12a978b074a5acdb6528e884ce8f4c05d2ad35 ] && echo "$gmcr" | sh
```
或者，您也可以使用以下手动方法。


```Bash
# 1. Manually verify that this outputs d041f51b97871dc7de1f01879c12a978b074a5acdb6528e884ce8f4c05d2ad35
curl https://getmic.ro | shasum -a 256

# 2. If #1 was successful, then execute getmicro
curl https://getmic.ro | sh
```

## 贡献

感谢您的贡献！我们使用 Github 的拉取请求工作流：首先 fork 这个仓库，进行修改，然后提交拉取请求。要合并您的 PR，您需要做以下几件事：

- 确保所有测试通过。打开 PR 后，Github Actions 会在 PR 页面报告测试失败。

- 如果您引入了新行为，请更新 Github Actions 测试（在 [`.github/workflows/test.yml`](https://github.com/benweissmann/getmic.ro/blob/master/.github/workflows/test.yml) 中）以测试该行为。

- 如果您引入了面向用户的新选项或行为，请更新 README 文件以记录该行为（如果不熟悉目标文件的语言，请勿翻译）。

如果您不确定如何完成上述任何步骤，欢迎提交您的工作进展 PR 并提出您的问题！

## 致谢：

- 当然是 Micro 编辑器：https://micro-editor.github.io/

- 松散基于 Chef curl|bash：https://docs.chef.io/install_omnibus.html

- ASCII 艺术由 figlet 提供：http://www.figlet.org/

<!--shasum=d041f51b97871dc7de1f01879c12a978b074a5acdb6528e884ce8f4c05d2ad35-->


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-10

---