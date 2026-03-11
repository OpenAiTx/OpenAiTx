[![Application](https://github.com/bpolaszek/mercure-x/actions/workflows/app.yml/badge.svg)](https://github.com/bpolaszek/mercure-x/actions/workflows/app.yml)
[![Coverage](https://codecov.io/gh/bpolaszek/freddie/branch/main/graph/badge.svg?token=uB4gRHyS6r)](https://codecov.io/gh/bpolaszek/freddie)

# Freddie

Freddie 是 [Mercure Hub 规范](https://mercure.rocks/spec) 的 PHP 实现。

它速度极快，建立在巨人的肩膀上：
- [PHP](https://www.php.net/releases/8.1/en.php) 8.1
- [Framework X](https://framework-x.org/) 和 [ReactPHP](https://reactphp.org/)
- [Symfony](https://symfony.com/) 6
- [Redis](https://redis.io/)（可选）。

查看支持和未支持（尚未支持）的功能[这里](#feature-coverage)。

## 安装

运行 hub 需要 PHP 8.1+。

### 作为独立的 Mercure hub 使用

```bash
composer create-project freddie/mercure-x freddie && cd freddie
bin/freddie
```

这将在 `127.0.0.1:8080` 上启动一个 Freddie 实例，并启用匿名订阅。

您可以通过生成一个使用 `!ChangeMe!` 密钥和 `HMAC SHA256` 算法签名的有效 JWT 来向集线器发布更新。

要更改这些值，请参见 [安全](#security)。

### 作为您现有 Symfony 应用程序的一个捆绑包

```bash
composer req freddie/mercure-x
```

然后您可以通过以下方式启动集线器：

```bash
bin/console freddie:serve
```

你可以像往常一样在你的 `.env.local` 文件中覆盖相关的环境变量，  
并在你的 `config/services.yaml` 文件中配置服务。  

然后，你可以在你的服务中注入 `Freddie\Hub\HubInterface`，这样你就可以调用 `$hub->publish($update)`，  
或者在 CLI 环境中监听分发的更新 👍  

请记住，这仅在使用 Redis 传输时有效。  

⚠️ **Freddie** 使用它自己的路由/认证系统（因为异步/事件循环）。  

它暴露的控制器不能在你的 `routes.yaml` 中导入，  
也不在你的 `security.yaml` 的管理范围内。  

## 使用方法  

```bash
./bin/freddie
```

它将在 `127.0.0.1:8080` 启动一个新的 Mercure 集线器。  
要更改此地址，请使用 `X_LISTEN` 环境变量：  

```bash
X_LISTEN="0.0.0.0:8000" ./bin/freddie
```

### 安全性

默认的 JWT 密钥是 `!ChangeMe!`，使用 `HS256` 签名。

您可以通过更改环境变量（在 `.env.local` 文件或操作系统级别）来设置不同的值：
`X_LISTEN`、`JWT_SECRET_KEY`、`JWT_ALGORITHM`、`JWT_PUBLIC_KEY` 和 `JWT_PASSPHRASE`（使用 RS512 或 ECDSA 时）

请参考 Mercure 规范的[授权](https://mercure.rocks/spec#authorization)部分，以作为发布者和/或订阅者进行身份验证。

### PHP 传输（默认）

默认情况下，集线器将作为一个简单的事件分发器运行，在单个 PHP 进程中。

它适合基本使用的常见需求，但使用此传输会阻止可扩展性，
因为开启另一个进程不会共享相同的事件发射器。

只要满足以下条件，它仍然完全可用：
- 您不期望每秒超过几百次更新
- 您的应用程序由单台服务器提供服务。

### Redis 传输

另一方面，您可以在**多个端口**和/或**多台服务器**上使用 Redis 传输启动集线器
（只要它们共享相同的 Redis 实例），并且可选地使用负载均衡器来分配流量。

集线器的[官方开源版本](https://mercure.rocks/docs/hub/install)不允许扩展，
因为 _bolt_ 传输存在并发限制。

要使用 Redis 传输启动集线器，请更改 `TRANSPORT_DSN` 环境变量：

```bash
TRANSPORT_DSN="redis://127.0.0.1:6379" ./bin/freddie
```

可选参数可以通过 DSN 的查询字符串传递：
- `pingInterval` - 定期 ping Redis 连接，有助于检测故障（默认 `2.0`）
- `readTimeout` - ping 或发布请求的最大持续时间（秒）（默认 `0.0`：视为禁用）

_或者，您也可以将此变量设置到 `.env.local`。_

## 优势与限制

该实现不提供 SSL 或 HTTP2 终止，因此最好在其前面放置一个反向代理。

### Nginx 配置示例

```nginx
upstream freddie {
    # Example with a single node
    server 127.0.0.1:8080;

    # Example with several nodes (they must share the same Redis instance)
    # 2 instances on 10.1.2.3
    server 10.1.2.3:8080;
    server 10.1.2.3:8081;

    # 2 instances on 10.1.2.4
    server 10.1.2.4:8080;
    server 10.1.2.4:8081;
}

server {
    
    listen 443 ssl http2;
    listen [::]:443 ssl http2;
    server_name example.com;

    ssl_certificate /etc/ssl/certs/example.com/example.com.cert;
    ssl_certificate_key /etc/ssl/certs/example.com/example.com.key;
    ssl_ciphers EECDH+CHACHA20:EECDH+AES128:RSA+AES128:EECDH+AES256:RSA+AES256:EECDH+3DES:RSA+3DES:!MD5;

    location /.well-known/mercure {
        proxy_pass http://freddie;
        proxy_read_timeout 24h;
        proxy_http_version 1.1;
        proxy_set_header Connection "";
        proxy_set_header X-Forwarded-For $proxy_add_x_forwarded_for;
        proxy_set_header X-Forwarded-Host $host;
        proxy_set_header X-Forwarded-Proto $scheme;
    }
}
```

### Caddy 配置示例

#### 单节点

```caddy
example.com

reverse_proxy 127.0.0.1:8080
```

#### 多节点情况下

```caddy
example.com

reverse_proxy 10.1.2.3:8080 10.1.2.3:8081 10.1.2.4:8080 10.1.2.4:8081
```

### 有效载荷限制
⚠ 在 [Framework-X](https://framework-x.org/docs/api/request/) 中存在一个已知限制，阻止请求体超过 [64 KB](https://github.com/reactphp/http/issues/412)。
截至撰写时，由于 Framework-X 封装了 HTTP 服务器实例化，此限制无法提高。

通过 HTTP 向 Freddie 发布更大更新可能导致 400 错误。

## 功能覆盖

| 功能                                        | 覆盖情况                              |
|---------------------------------------------|---------------------------------------|
| 通过 `Authorization` 头传递 JWT             | ✅                                     |
| 通过 `mercureAuthorization` Cookie 传递 JWT | ✅                                     |
| 允许匿名订阅者                              | ✅                                     |
| 备用主题                                    | ✅️                                    |
| 私有更新                                    | ✅                                     |
| 主题的 URI 模板                             | ✅                                     |
| HMAC SHA256 JWT 签名                        | ✅                                     |
| RS512 JWT 签名                              | ✅                                     |
| 环境变量配置                                | ✅                                     |
| 自定义消息 ID                               | ✅                                     |
| 上一个事件 ID（包括 `earliest`）             | ✅️                                    |
| 可自定义事件类型                            | ✅️                                    |
| 可自定义 `retry` 指令                       | ✅️                                    |
| 跨域资源共享 (CORS)                         | ❌ （请在您的 Web 服务器上配置）           |
| 健康检查端点                                | ❌ （欢迎提交 PR）                     |
| 日志记录                                    | ❌ （欢迎提交 PR）️                    |
| 指标                                       | ❌ （欢迎提交 PR）️                    |
| 订阅者 / 发布者使用不同 JWT                  | ❌ （欢迎提交 PR）                     |
| 订阅 API                                   | ❌️ （待办）                          |


## 测试

该项目已通过 [Pest](https://pestphp.com/) 测试实现 100% 覆盖。

```bash
composer tests:run
```

## 贡献

如果您想改进此项目，欢迎提交 PR：

- 如果不遵循 [PSR-12 编码标准](https://www.php-fig.org/psr/psr-12/)，CI 会报错
- 新功能必须附带测试
- 必须通过 [PHPStan](https://phpstan.org/) 8 级分析

您可以在提交前运行以下命令，以确保所有 CI 要求均已满足：

```bash
composer ci:check
```

## 许可证

GNU通用公共许可证 版本3.0。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-11

---