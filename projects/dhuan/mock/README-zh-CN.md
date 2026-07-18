# mock

[![Go Reference](https://pkg.go.dev/badge/github.com/dhuan/mock.svg)](https://pkg.go.dev/github.com/dhuan/mock)
[![Go Report Card](https://goreportcard.com/badge/github.com/dhuan/mock)](https://goreportcard.com/report/github.com/dhuan/mock)

*mock* 是一个 API 工具——它可以让你：

- 通过 API 配置文件或命令行参数轻松定义 API 路由。
- 使用 shell 脚本作为响应处理器。或者任何其他类型的程序都可以作为响应处理器。
- 测试你的 API——对某个端点是否被请求进行断言。

[学习和理解 `mock` 的最快方式是查看示例页面。](https://dhuan.github.io/mock/latest/examples.html)

## 快速链接

- [用户指南](https://dhuan.github.io/mock)
- [用户指南（主分支，尚未发布）](https://dhuan.github.io/mock/latest)
- [操作指南和示例](https://dhuan.github.io/mock/latest/examples.html)

## 快速开始



```sh
$ mock serve --port 3000 \
  --get "/time-now" \
  --exec 'printf "Now it is %s" $(date +"%H:%M") | mock write' \
  --post "/shut-down/{application}" \
  --exec 'killall $(mock get-route-param application)'
```

让我们来测试一下：

```sh
$ curl localhost:3000/time-now
# Prints out:
Now it is 22:00

$ curl -X POST localhost:3000/shut-down/mock
# Shuts down the server!
```
*mock* 还允许你扩展其他 API（或者任何 HTTP 服务，实际上也是如此）。
假设你想要为运行在
``example.com`` 的现有 API 添加一个新路由：


```sh
$ mock serve --port 3000 \
  --base example.com \
  --get 'some-new-route' \
  --exec 'printf "Hello, world!" | mock write' 
```
使用上面 ``--base example.com`` 选项后，您的 API 将作为代理访问
该网站，并通过额外的路由 `GET /some-new-route` 扩展它。
有关详细信息，请查阅文档中的“基础 API”。

*[还有许多其他方式可以使用 *mock* 进一步定制您的 API。请继续阅读指南了解更多内容。](https://dhuan.github.io/mock)*

## 安装

mock 以单文件可执行程序的形式发布。请查看发布页面并下载最新的压缩包。

## 许可证

**mock** 采用 MIT 许可证。更多信息请查看 [LICENSE 文件。](LICENSE)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-18

---