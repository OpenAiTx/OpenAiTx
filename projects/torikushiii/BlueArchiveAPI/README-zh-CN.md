
# Blue Archive API

## *此API提供Blue Archive全球版和日版的数据。*

- [Blue Archive EN](https://bluearchive.nexon.com/home)：官方英文网站
- [Blue Archive JP](https://bluearchive.jp/)：官方日文网站

此API提供来自游戏Blue Archive的各种数据。如果您想为此项目做贡献，欢迎提交拉取请求或问题。如果您想支持我，可以通过我的[Ko-Fi](https://ko-fi.com/torikushiii)捐赠。

**托管API地址：https://api.ennead.cc/buruaka**

## 先决条件

- [Go](https://go.dev/dl/)：1.24或更高版本
- API可访问的MongoDB实例（默认URI为`mongodb://localhost:27017`）

## 配置

运行时选项从YAML文件加载。默认情况下，服务器读取项目根目录下的`config.yaml`。如果需要，可以设置`CONFIG_PATH`环境变量指向其他配置文件。

请参阅`config.yaml`以获取符合本地默认设置的示例。

## 运行API

使用Go构建依赖并启动服务器：

```bash
go run ./cmd/server
```
监听地址通过配置控制（默认 `0.0.0.0:9999`）。所有 REST 端点均在 `/buruaka` 基础路径下提供（例如 `/buruaka/character`），服务器使用配置的 URI 连接到 MongoDB，以提供角色、突袭和横幅数据。

要生成独立的二进制文件：


```bash
go build -o server ./cmd/server
```
运行测试使用：


```bash
go test ./...
```

## REST API 文档

端点详情见 [docs](https://github.com/torikushiii/BlueArchiveAPI/tree/main/docs) 文件夹。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-31

---