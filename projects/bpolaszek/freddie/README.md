[![Application](https://github.com/bpolaszek/mercure-x/actions/workflows/app.yml/badge.svg)](https://github.com/bpolaszek/mercure-x/actions/workflows/app.yml)
[![Coverage](https://codecov.io/gh/bpolaszek/freddie/branch/main/graph/badge.svg?token=uB4gRHyS6r)](https://codecov.io/gh/bpolaszek/freddie)

# Freddie

Freddie is a PHP implementation of the [Mercure Hub Specification](https://mercure.rocks/spec).

It is blazing fast, built on the shoulders of giants:
- [PHP](https://www.php.net/releases/8.1/en.php) 8.1
- [Framework X](https://framework-x.org/) and [ReactPHP](https://reactphp.org/)
- [Symfony](https://symfony.com/) 6
- [Redis](https://redis.io/) (optionally).

See what features are covered and what aren't (yet) [here](#feature-coverage).

## Installation

PHP 8.1+ is required to run the hub.

### As a standalone Mercure hub

```bash
composer create-project freddie/mercure-x freddie && cd freddie
bin/freddie
```

This will start a Freddie instance on `127.0.0.1:8080`, with anonymous subscriptions enabled.

You can publish updates to the hub by generating a valid JWT signed with the `!ChangeMe!` key with `HMAC SHA256` algorithm.

To change these values, see [Security](#security).

### As a bundle of your existing Symfony application

```bash
composer req freddie/mercure-x
```

You can then start the hub by doing:

```bash
bin/console freddie:serve
```

You can override relevant env vars in your `.env.local` 
and services in your `config/services.yaml` as usual.

Then, you can inject `Freddie\Hub\HubInterface` in your services so that you can call `$hub->publish($update)`,
or listening to dispatched updates in a CLI context 👍

Keep in mind this only works when using the Redis transport.

⚠️ **Freddie** uses its own routing/authentication system (because of async / event loop). 

The controllers it exposes cannot be imported in your `routes.yaml`, and get out of your  `security.yaml` scope.

## Usage

```bash
./bin/freddie
```

It will start a new Mercure hub on `127.0.0.1:8080`. 
To change this address, use the `X_LISTEN` environment variable:

```bash
X_LISTEN="0.0.0.0:8000" ./bin/freddie
```

### Security 

The default JWT key is `!ChangeMe!` with a `HS256` signature. 

You can set different values by changing the environment variables (in `.env.local` or at the OS level): 
`X_LISTEN`, `JWT_SECRET_KEY`, `JWT_ALGORITHM`, `JWT_PUBLIC_KEY` and `JWT_PASSPHRASE` (when using RS512 or ECDSA)

Please refer to the [authorization](https://mercure.rocks/spec#authorization) section of the Mercure specification to authenticate as a publisher and/or a subscriber.

### PHP Transport (default)

By default, the hub will run as a simple event-dispatcher, in a single PHP process.

It can fit common needs for a basic usage, but using this transport prevents scalability,
as opening another process won't share the same event emitter.

It's still prefectly usable as soon as :
- You don't expect more than a few hundreds updates per second
- Your application is served from a single server.

### Redis transport

On the other hand, you can launch the hub on **multiple ports** and/or **multiple servers** with a Redis transport
(as soon as they share the same Redis instance), and optionally use a load-balancer to distribute the traffic.

The [official open-source version](https://mercure.rocks/docs/hub/install) of the hub doesn't allow scaling 
because of concurrency restrictions on the _bolt_ transport.

To launch the hub with the Redis transport, change the `TRANSPORT_DSN` environment variable:

```bash
TRANSPORT_DSN="redis://127.0.0.1:6379" ./bin/freddie
```

Optional parameters you can pass in the DSN's query string:
- `pingInterval` - regularly ping Redis connection, which will help detect outages (default `2.0`)
- `readTimeout` - max duration in seconds of a ping or publish request (default `0.0`: considered disabled)

_Alternatively, you can set this variable into `.env.local`._

## Advantages and limitations

This implementation does not provide SSL nor HTTP2 termination, so you'd better put a reverse proxy in front of it. 

### Example Nginx configuration

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

### Example Caddy configuration

#### Single node

```caddy
example.com

reverse_proxy 127.0.0.1:8080
```

#### With multiple nodes

```caddy
example.com

reverse_proxy 10.1.2.3:8080 10.1.2.3:8081 10.1.2.4:8080 10.1.2.4:8081
```

### Payload limitations
⚠ There's a known limit in [Framework-X](https://framework-x.org/docs/api/request/) which prevents request bodies to weigh more than [64 KB](https://github.com/reactphp/http/issues/412). 
At the time of writing, this limit cannot be raised due to Framework-X encapsulating HTTP Server instantiation.

Publishing bigger updates to Freddie (through HTTP, at least) could result in 400 errors.

## Feature coverage

| Feature                                     | Covered                               |
|---------------------------------------------|---------------------------------------|
| JWT through `Authorization` header          | ✅                                     |
| JWT through `mercureAuthorization` Cookie   | ✅                                     |
| Allow anonymous subscribers                 | ✅                                     |
| Alternate topics                            | ✅️                                    |
| Private updates                             | ✅                                     |
| URI Templates for topics                    | ✅                                     |
| HMAC SHA256 JWT signatures                  | ✅                                     |
| RS512 JWT signatures                        | ✅                                     |
| Environment variables configuration         | ✅                                     |
| Custom message IDs                          | ✅                                     |
| Last event ID (including `earliest`)        | ✅️                                    |
| Customizable event type                     | ✅️                                    |
| Customizable `retry` directive              | ✅️                                    |
| CORS                                        | ❌ (configure them on your web server) |
| Health check endpoint                       | ❌ (PR welcome)                        |
| Logging                                     | ❌ (PR welcome))️                      |
| Metrics                                     | ❌ (PR welcome)️                       |
| Different JWTs for subscribers / publishers | ❌ (PR welcome)                        |
| Subscription API                            | ❌️ (TODO)                             |


## Tests

This project is 100% covered with [Pest](https://pestphp.com/) tests. 

```bash
composer tests:run
```

## Contribute

If you want to improve this project, feel free to submit PRs:

- CI will yell if you don't follow [PSR-12 coding standards](https://www.php-fig.org/psr/psr-12/)
- In the case of a new feature, it must come along with tests
- [PHPStan](https://phpstan.org/) analysis must pass at level 8

You can run the following command before committing to ensure all CI requirements are successfully met:

```bash
composer ci:check
```

## License

GNU General Public License v3.0.
