[![Aplicación](https://github.com/bpolaszek/mercure-x/actions/workflows/app.yml/badge.svg)](https://github.com/bpolaszek/mercure-x/actions/workflows/app.yml)
[![Cobertura](https://codecov.io/gh/bpolaszek/freddie/branch/main/graph/badge.svg?token=uB4gRHyS6r)](https://codecov.io/gh/bpolaszek/freddie)

# Freddie

Freddie es una implementación en PHP de la [Especificación del Hub Mercure](https://mercure.rocks/spec).

Es extremadamente rápido, construido sobre los hombros de gigantes:
- [PHP](https://www.php.net/releases/8.1/en.php) 8.1
- [Framework X](https://framework-x.org/) y [ReactPHP](https://reactphp.org/)
- [Symfony](https://symfony.com/) 6
- [Redis](https://redis.io/) (opcionalmente).

Consulta qué características están cubiertas y cuáles no (todavía) [aquí](#feature-coverage).

## Instalación

Se requiere PHP 8.1+ para ejecutar el hub.

### Como un hub Mercure independiente

```bash
composer create-project freddie/mercure-x freddie && cd freddie
bin/freddie
```

Esto iniciará una instancia de Freddie en `127.0.0.1:8080`, con suscripciones anónimas habilitadas.

Puede publicar actualizaciones en el hub generando un JWT válido firmado con la clave `!ChangeMe!` usando el algoritmo `HMAC SHA256`.

Para cambiar estos valores, consulte [Seguridad](#security).

### Como un paquete de su aplicación Symfony existente

```bash
composer req freddie/mercure-x
```

Luego puedes iniciar el concentrador haciendo:

```bash
bin/console freddie:serve
```

Puede anular las variables de entorno relevantes en su `.env.local` 
y los servicios en su `config/services.yaml` como de costumbre.

Luego, puede inyectar `Freddie\Hub\HubInterface` en sus servicios para que pueda llamar a `$hub->publish($update)`,
o escuchar las actualizaciones despachadas en un contexto CLI 👍

Tenga en cuenta que esto solo funciona cuando se utiliza el transporte Redis.

⚠️ **Freddie** utiliza su propio sistema de enrutamiento/autenticación (debido a async / event loop). 

Los controladores que expone no se pueden importar en su `routes.yaml`, y quedan fuera del alcance de su `security.yaml`.

## Uso

```bash
./bin/freddie
```
Se iniciará un nuevo hub de Mercure en `127.0.0.1:8080`.  
Para cambiar esta dirección, use la variable de entorno `X_LISTEN`:


```bash
X_LISTEN="0.0.0.0:8000" ./bin/freddie
```

### Seguridad

La clave JWT por defecto es `!ChangeMe!` con una firma `HS256`.

Puedes establecer valores diferentes cambiando las variables de entorno (en `.env.local` o a nivel del SO):
`X_LISTEN`, `JWT_SECRET_KEY`, `JWT_ALGORITHM`, `JWT_PUBLIC_KEY` y `JWT_PASSPHRASE` (cuando se usa RS512 o ECDSA)

Por favor, consulta la sección de [autorización](https://mercure.rocks/spec#authorization) de la especificación de Mercure para autenticarte como publicador y/o suscriptor.

### Transporte PHP (por defecto)

Por defecto, el hub se ejecutará como un simple despachador de eventos, en un único proceso PHP.

Puede cubrir necesidades comunes para un uso básico, pero usar este transporte impide la escalabilidad,
ya que abrir otro proceso no compartirá el mismo emisor de eventos.

Sigue siendo perfectamente usable siempre que:
- No esperes más de unos pocos cientos de actualizaciones por segundo
- Tu aplicación se sirva desde un único servidor.

### Transporte Redis

Por otro lado, puedes lanzar el hub en **múltiples puertos** y/o **múltiples servidores** con un transporte Redis
(mientras compartan la misma instancia de Redis), y opcionalmente usar un balanceador de carga para distribuir el tráfico.

La [versión oficial de código abierto](https://mercure.rocks/docs/hub/install) del hub no permite escalar
debido a restricciones de concurrencia en el transporte _bolt_.

Para lanzar el hub con el transporte Redis, cambia la variable de entorno `TRANSPORT_DSN`:

```bash
TRANSPORT_DSN="redis://127.0.0.1:6379" ./bin/freddie
```

Parámetros opcionales que puede pasar en la cadena de consulta del DSN:
- `pingInterval` - hacer ping regularmente a la conexión Redis, lo que ayudará a detectar interrupciones (predeterminado `2.0`)
- `readTimeout` - duración máxima en segundos de una solicitud de ping o publicación (predeterminado `0.0`: considerado deshabilitado)

_Alternativamente, puede establecer esta variable en `.env.local`._

## Ventajas y limitaciones

Esta implementación no proporciona terminación SSL ni HTTP2, por lo que es mejor colocar un proxy inverso delante de ella.

### Ejemplo de configuración de Nginx

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

### Ejemplo de configuración de Caddy

#### Nodo único

```caddy
example.com

reverse_proxy 127.0.0.1:8080
```

#### Con múltiples nodos

```caddy
example.com

reverse_proxy 10.1.2.3:8080 10.1.2.3:8081 10.1.2.4:8080 10.1.2.4:8081
```

### Limitaciones de la carga útil
⚠ Existe un límite conocido en [Framework-X](https://framework-x.org/docs/api/request/) que impide que los cuerpos de las solicitudes pesen más de [64 KB](https://github.com/reactphp/http/issues/412). 
Al momento de escribir, este límite no puede aumentarse debido a que Framework-X encapsula la instanciación del Servidor HTTP.

Publicar actualizaciones más grandes en Freddie (al menos a través de HTTP) podría resultar en errores 400.

## Cobertura de características

| Característica                              | Cubierta                             |
|---------------------------------------------|-------------------------------------|
| JWT mediante el encabezado `Authorization`  | ✅                                   |
| JWT mediante la cookie `mercureAuthorization` | ✅                                   |
| Permitir suscriptores anónimos              | ✅                                   |
| Temas alternativos                          | ✅️                                  |
| Actualizaciones privadas                    | ✅                                   |
| Plantillas URI para temas                   | ✅                                   |
| Firmas JWT HMAC SHA256                      | ✅                                   |
| Firmas JWT RS512                            | ✅                                   |
| Configuración mediante variables de entorno | ✅                                   |
| IDs personalizados de mensajes              | ✅                                   |
| Último ID de evento (incluyendo `earliest`) | ✅️                                  |
| Tipo de evento personalizable               | ✅️                                  |
| Directiva `retry` personalizable            | ✅️                                  |
| CORS                                        | ❌ (configúrelos en su servidor web) |
| Punto de comprobación de estado             | ❌ (PR bienvenido)                   |
| Registro de logs                            | ❌ (PR bienvenido))️                 |
| Métricas                                    | ❌ (PR bienvenido)️                  |
| JWTs diferentes para suscriptores / publicadores | ❌ (PR bienvenido)              |
| API de suscripción                          | ❌️ (POR HACER)                      |


## Pruebas

Este proyecto está 100% cubierto con pruebas de [Pest](https://pestphp.com/). 

```bash
composer tests:run
```

## Contribuir

Si quieres mejorar este proyecto, siéntete libre de enviar PRs:

- CI se quejará si no sigues los [estándares de codificación PSR-12](https://www.php-fig.org/psr/psr-12/)
- En caso de una nueva característica, debe venir acompañada de pruebas
- El análisis de [PHPStan](https://phpstan.org/) debe pasar en nivel 8

Puedes ejecutar el siguiente comando antes de hacer commit para asegurar que todos los requisitos de CI se cumplen exitosamente:

```bash
composer ci:check
```

## Licencia

Licencia Pública General GNU v3.0.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-11

---