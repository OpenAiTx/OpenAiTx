# ./dops - 更好的 `docker ps` 
一个替代默认 docker-ps 的工具，努力适配你的终端宽度。

![](https://raw.githubusercontent.com/Mikescher/better-docker-ps/master/readme.d/main.png)

## 原因

默认情况下，我的 `docker ps` 输出非常宽，每行会换行成三行。
这（显然）破坏了表格显示，使一切变得混乱。  
*（如果一个容器有多个端口映射，并且都显示在同一行时，这种情况尤其糟糕）*
看起来在可预见的未来不会有改进的输出（参见 [moby#7477](https://github.com/moby/moby/issues/7477)），所以我决定做一个自己的替代方案。  

## 特性

 - 所有 docker-ps 的普通命令行标志/选项 *(几乎)* 一样。
 - 将多值数据（如多个端口映射、多个网络等）写入多行，而不是连接在一起。
 - 给 STATE 和 STATUS 列添加颜色（绿色 / 黄色 / 红色）。
 - 自动删除输出中的列，直到适应当前终端宽度。
 - 通过 `--sort` 参数对输出排序
 - 通过 `--watch` 参数进入监视模式

相比默认 docker-ps 的更多改动：
 - 默认显示容器命令但不带参数。
 - 默认显示镜像名称时去掉注册表前缀，并将镜像名称和标签拆分成两列。
 - 默认列集添加了 IP 和 NETWORK 列（如果适合的话）
 - 通过 --format 支持了几个新列：  
   `{{.ImageName}`, `{{.ImageTag}`, `{{.Tag}`, `{{.ImageRegistry}`, `{{.Registry}`, `{{.ShortCommand}`, `{{.LabelKeys}`, `{{.IP}`                         
 - 添加了控制颜色输出、使用的 socket、时区和时间格式等选项（参见 `./dops --help`） 

## 快速开始

### 通用 Linux（例如 Debian/Fedora/...）
 - 从[发布页面](https://github.com/Mikescher/better-docker-ps/releases)下载最新二进制文件并放入你的 PATH（例如 /usr/local/bin）
 - 你也可以使用以下一行命令（之后你可以在任何地方使用 `dops` 命令）：
```
$> sudo wget "https://github.com/Mikescher/better-docker-ps/releases/latest/download/dops_linux-amd64-static" -O "/usr/local/bin/dops" && sudo chmod +x "/usr/local/bin/dops"
```
### ArchLinux
 - 或者您可以使用 AUR 包之一（在 Arch Linux 下）：
    * https://aur.archlinux.org/packages/dops-bin （将 `dops` 安装到您的 PATH 中）
    * https://aur.archlinux.org/packages/dops-git （将 `dops` 安装到您的 PATH 中）
 - 或者使用 homebrew 包：
    * `brew tap mikescher/tap && brew install dops`

### 可选步骤
 - 将 docker ps 命令别名为 `dops`（参见[下面章节](#usage-as-drop-in-replacement)）

## 截图

![](https://raw.githubusercontent.com/Mikescher/better-docker-ps/master/readme.d/fullsize.png)  
所有（默认）列可见

&nbsp;

![](https://raw.githubusercontent.com/Mikescher/better-docker-ps/master/readme.d/default.png)  
中等大小终端的输出

&nbsp;

![](https://raw.githubusercontent.com/Mikescher/better-docker-ps/master/readme.d/small.png)  
小终端的输出

&nbsp;

## 作为直接替代使用

您可以通过在 `.bashrc` / `.zshrc` 中创建一个 shell 函数来完全替代 docker ps...

~~~sh
docker() {
  case $1 in
    ps)
      shift
      command dops "$@"
      ;;
    *)

      command docker "$@";;
  esac
}
~~~

这将把所有对 `docker ps ...` 的调用别名为 `dops ...`（确保 dops 二进制文件在你的 PATH 中）。

如果你使用的是 fish-shell，你需要创建一个（类似的）函数：

~~~fish
function docker
    if test -n "$argv[1]"
        switch $argv[1]
            case ps
                dops $argv[2..-1]
            case '*'
                command docker $argv[1..-1]
        end
    end
end
~~~

## 更改输出格式

默认情况下，dops 会尝试“智能”地根据你的终端宽度选择最佳输出格式。  
当前的输出格式（即表格列）定义在 [options.go](https://github.com/Mikescher/better-docker-ps/blob/master/cli/options.go) 中。  
第一个适合你终端宽度的格式将被使用。

但你也可以通过提供 `--format` 参数来覆盖它。如果你提供多个 `--format` 参数，则会使用第一个适合你终端的（与默认格式的逻辑相同……）

通常只支持简单列，也就是 `{{.Status}}`。  
但你也可以使用完整的 golang 模板语法（例如 `{{ printf "%.15s" .Command }}`）。  
在这种情况下，可以通过在前面加冒号来指定列标题（例如 `SHORTENED NAME:{{ printf "%.10s" (join .Names ";") }}`）

以下函数在这些模板中定义（加上 [默认的 go 函数](https://pkg.go.dev/text/template)）：  
 - `join`: strings.Join  
 - `array_last`: v\[-1\]  
 - `array_slice`: v\[a..b\]  
 - `in_array`: v1.contains(v2)  
 - `json`: json.Marshal(v)
 - `json_indent`: json.MarshalIndent(v, "", "  ")
 - `json_pretty`:  json.Indent(v, "", "  ")
 - `coalesce`: v1 ?? v2
 - `to_string`: fmt.Sprintf("%v", v)
 - `deref`: *v
 - `now`: time.Now()
 - `uniqid`: UUID

Examples:
~~~~
$ ./dops --format "table {{.ID}}"
$ ./dops --format "table {{.ID}}\\t{{.Names}}\\t{{.State}}"

$ ./dops --format "idlist"

$ ./dops --format "table {{.ID}}\\t{{.Names}}\\t{{.State}}"  --format "table {{.ID}}\\t{{.Names}}" --format "table {{.ID}}"

$ ./dops --format "ID: {{.ID}}; Name: {{.Names}}"

$ ./dops -aq

$ ./dops --sort "IP" --sort-direction "ASC"

$ ./dops --format "table {{.ID}}\\tCMD:{{ printf \"%.15s\" .Command }}"
$ ./dops --format "table {{.ID}}\\tNAME:{{ printf \"%.10s\" (join .Names \";\") }}"

~~~~

## 持久化配置

你也可以通过配置文件配置部分或大部分选项。  
将一个 TOML 格式的文件放置在 `$HOME/.config/dops.conf` / `$XDG_CONFIG_HOME/dops.conf`。

支持以下键：
 - verbose
 - silent
 - timezone
 - timeformat
 - timeformat-header
 - color
 - 套接字
 - 全部
 - 大小
 - 过滤器 (= 字符串数组)
 - 格式 (= 字符串数组)
 - 最后
 - 最新
 - 截断
 - 头部 (= true / false / simple)
 - 排序 (= 字符串数组)
 - 排序方向 (= 字符串数组)

示例:
```toml
verbose = 0

timezone = "Europe/Berlin"

format = [
   "table {{.ID}}\t{{.Names}}\t{{.State}}\t{{.Status}}",
   "table {{.ID}}\t{{.Names}}\t{{.State}}",
   "table {{.ID}}\t{{.Names}}",
   "table {{.ID}}",
]

header = "simple"
```
## 手册

`./dops --help` 的输出：

~~~~~~
better-docker-ps

用法：
  dops [选项]                       列出 docker 容器

选项（默认）：
  -h, --help                       显示此帮助信息。
  --version                       显示版本。
  --all , -a                     显示所有容器（默认只显示运行中容器）
  --filter <ftr>, -f <ftr>       根据提供的条件过滤输出
  --format <fmt>                 使用 Go 模板美化打印容器信息
  --last , -n                    显示最近创建的 n 个容器（包含所有状态）
  --latest , -l                  显示最新创建的容器（包含所有状态）
  --no-trunc                     不截断输出（例如容器ID、Sha256 镜像引用、命令行）
  --quiet , -q                   仅显示容器 ID
  --size , -s                    显示文件总大小

额外选项（`docker ps` 中不存在）：
  --silent                      不打印任何输出
  --timezone                    指定日期输出的时区
  --color <true|false>          启用/禁用终端颜色输出
  --no-color                    禁用终端颜色输出
  --socket <文件路径>            指定 docker socket 位置（默认：`auto` - 调用 docker CLI 自动确定 socket）
  --timeformat <go-time-fmt>     指定日期时间输出格式（Go 语言语法）
  --no-header                   不打印表头
  --simple-header               不打印表头下的分割线
  --format <fmt>                可指定多个格式，终端宽度适配时使用第一个合适的格式
  --sort <列>                   按指定列排序，使用与 --format 中相同的标识，仅对表格格式有效
  --sort-direction <ASC|DESC>  排序方向，仅与 --sort 配合使用有效
  --watch <间隔>, -w <间隔>     自动定时刷新输出（间隔可选，默认：2秒）

可用的 --format 键（默认）：
  {{.ID}}                      容器 ID
  {{.Image}}                   镜像 ID

  {{.Command}}                       引号中的命令
  {{.CreatedAt}}                     容器创建时间。
  {{.RunningFor}}                    容器启动以来经过的时间。
  {{.Ports}}                         发布的端口。([!] 与 docker CLI 不同，这里仅指已发布的端口)
  {{.State}}                         容器状态
  {{.Status}}                        容器状态详情
  {{.Size}}                          容器磁盘大小。
  {{.Names}}                         容器名称。
  {{.Labels}}                        分配给容器的所有标签。
  {{.Label}}                         [!] 不支持
  {{.Mounts}}                        挂载在此容器中的卷名称。
  {{.Networks}}                      连接到此容器的网络名称。

可用的 --format 键（额外的 | docker ps 中不存在）：
  {{.ImageName}}                     镜像 ID（不含标签和注册表）
  {{.ImageTag}}, {{.Tag}}            镜像标签
  {{.ImageRegistry}}, {{.Registry}}  镜像注册表
  {{.ShortCommand}}                  不带参数的命令
  {{.LabelKeys}}                     分配给容器的所有标签（仅键）
  {{.ShortPublishedPorts}}           发布的端口，较 {{.Ports}} 输出更短
  {{.LongPublishedPorts}}            发布的端口，带 IP 的完整输出
  {{.ExposedPorts}}                  暴露的端口
  {{.PublishedPorts}}                发布的端口
  {{.NotPublishedPorts}}             暴露但未发布的端口
  {{.PublicPorts}}                   仅发布端口中的公共部分
  {{.IP}}                            内部 IP 地址
~~~~~~


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-16

---