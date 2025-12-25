# janitor
## 目标
Janitor 是一个独立工具，用于监控您的物联网设备的可用性，并在设备丢失或停止传输数据时提醒您。这对于拥有大量传感器且硬件或连接可能不稳定的情况特别有用，您可以在出现任何问题时采取措施，并监控设备的稳定性。

Janitor 不打算实现任何额外功能，因此不是您其他家庭自动化软件（例如 HASS）的替代品。专注于此功能将使该工具保持简单高效。

Janitor 当前支持以下监控方法：
* **MQTT：** Janitor 会订阅预定义的 MQTT 主题并监控接收的消息。将为每个通道计算平均传输频率，如果在此间隔内未收到新消息，Janitor 会提醒您（阈值可配置为平均频率的倍数或每个主题的绝对值）。此方法特别适用于通过 MQTT 定期提交数据的各种传感器（例如温度）。
* **Ping：** Janitor 会以预定义的频率（可针对每个主机配置）ping 预定义主机，若无响应则提醒您（连续丢失 ping 的阈值可配置）。此方法适用于各种物联网设备，如传感器、摄像头等。
* **HTTP：** Janitor 会向预定义地址发送 HTTP GET 请求并检查回复，且可选地检查回复是否包含预定义字符串。当连续请求失败次数超过配置阈值时，Janitor 会提醒您。请求频率和超时也可针对每个地址配置。此方法适用于带有网页界面的各种服务（例如 API、托管服务等）。
* **Exec：** Janitor 会执行预配置的命令并检查其退出码。当连续执行失败次数超过配置阈值时，Janitor 会提醒您。频率和超时也可针对每条命令配置。通过此方法，您可以实现任何自定义监控。

Janitor 当前支持以下提醒方法：
* **Telegram：** Janitor 会向预定义的 Telegram 频道发送消息。
* **Gotify：** Janitor 会向 Gotify 发送推送消息。
* **MQTT：** Janitor 会向预配置的 MQTT 服务器上的预配置主题发布消息。消息包含 JSON 负载（示例配置见样例）。这适用于自动化，例如 HASS。
* **Exec：** Janitor 会执行预配置的命令。这样可以创建任何类型的自定义提醒方法。

此外，Janitor 具有一个网页界面，您可以查看当前状态和历史数据，删除项目，修改超时、间隔和阈值，并重新加载配置文件（见下方截图）。

最后，Janitor 包含一个简单的 JSON API，具有以下端点：
* `/api/data` 提供所有监控相关数据的快照。
* `/api/stats` 提供功能正常/异常监控目标的计数。
* `/api/metrics` 以 Prometheus 指标格式提供目标统计数据。

## 截图
![截图](https://raw.githubusercontent.com/a-bali/janitor/master/docs/screenshot.png)

## 构建与安装

Janitor 使用 Go 编写，编译后为单个独立二进制文件。Janitor 应能在 Linux 和 Windows 上编译和运行。

编译时，请使用至少 Go 1.16 版本，执行以下命令克隆仓库并构建二进制文件：

    $ git clone https://github.com/a-bali/janitor.git
    $ cd janitor
    $ go build

这将创建名为 `janitor` 的独立二进制文件，您可以将其放置在任意位置。Github 上提供了预编译的发行版二进制文件。

## 配置与使用

配置需要一个 YAML 格式的文件。请使用[示例配置文件](https://raw.githubusercontent.com/a-bali/janitor/master/config.yml)，并根据您的需求进行修改，参考文件中的注释。大多数变量是可选的，并且有合理的默认值，详情请参见注释。您可以使用 `$ENV_VAR` 或 `${ENV_VAR}` 引用环境变量，如果变量存在则会被其值替换（如果不存在则替换为空字符串）。

一个最小但已可运行的配置示例如下（假设 Janitor 的网页界面将使用默认端口 8080）：

    monitor:
      mqtt:
        server: mymqtt.server
        targets:
        - topic: "/sensors/#"
    alert:
      gotify:
        server: "http://mygotify.server:1234"
        token: gotify_token

创建好配置文件后，可以按如下方式启动 Janitor：

    $ janitor path/to/your/configfile.yml

Janitor 会将日志输出到标准输出。日志也可在网页界面查看，在网页界面中您可以删除监控目标并重新加载配置文件（例如当您添加了新目标或更改了设置时）。

Janitor 不会自动成为守护进程。建议创建一个 systemd 服务来持续运行 janitor。

## 使用 Docker 运行

Janitor 的最新版本已上传到 Docker Hub [`abali/janitor`](https://hub.docker.com/repository/docker/abali/janitor)。使用时，将您的配置文件映射到 `/janitor/config.yml`：

    $ docker run -v $(pwd)/config.yml:/janitor/config.yml -p 8080:8080 abali/janitor

或者，您也可以使用提供的 Dockerfile 自行构建容器：

    $ git clone https://github.com/a-bali/janitor.git
    $ cd janitor
    $ docker build . -t janitor
    $ docker run -v $(pwd)/config.yml:/janitor/config.yml -p 8080:8080 janitor

## 未来计划与贡献


Janitor 的目标明确且简单：监控物联网设备的可用性和运行状况，并在出现任何问题时发出警报。任何未来的改进都应遵循这一目标，因此要么增加新的监控方式，要么增加新的报警方式。

Janitor 是开源软件，欢迎通过 Github 发送拉取请求以改进该软件。

## 许可

Janitor 采用 GPL 3.0 许可证。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-25

---