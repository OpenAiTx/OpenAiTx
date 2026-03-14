# SimpleLogin

Esta es una configuración de docker-compose autoalojada para [SimpleLogin](https://simplelogin.io).

## Requisitos previos

- un servidor Linux (ya sea una VM o un servidor dedicado). Este documento muestra la configuración para Ubuntu 18.04 LTS pero los pasos podrían adaptarse para otras distribuciones populares de Linux. Como la mayoría de los componentes se ejecutan como contenedores Docker y Docker puede ser un poco pesado, se recomienda tener al menos 2 GB de RAM. El servidor debe tener abiertos los puertos 25 (correo electrónico), 80, 443 (para la aplicación web), 22 (para que puedas acceder por ssh).

- un dominio para el cual puedas configurar el DNS. Podría ser un subdominio. En el resto del documento, diremos que es `mydomain.com` para el correo y `app.mydomain.com` para la aplicación web de SimpleLogin. Por favor asegúrate de reemplazar estos valores por tu nombre de dominio y subdominio cada vez que aparezcan en el documento. Un truco que usamos es descargar este archivo README en tu computadora y reemplazar todas las ocurrencias de `mydomain.com` y `app.mydomain.com` por tu dominio.

Excepto la configuración del DNS que usualmente se hace en la interfaz de tu registrador de dominio, todos los pasos siguientes deben hacerse en tu servidor. Los comandos deben ejecutarse con `bash` (o cualquier shell compatible con bash como `zsh`) siendo la shell. Si usas otras shells como `fish`, asegúrate de adaptar los comandos.

- Algunos paquetes de utilidad usados para verificar la configuración. Instálalos con:

```bash
sudo apt update \
  && sudo apt install -y net-tools dnsutils
```

## Configuración DNS

_Consulte la [documentación de referencia](https://github.com/springcomp/self-hosted-simplelogin/wiki/DNS-Configuration) para más detalles_

> **Tenga en cuenta** que los cambios en DNS pueden tardar hasta 24 horas en propagarse. En la práctica, sin embargo, es mucho más rápido (~1 minuto aproximadamente en nuestra prueba). En la configuración DNS, generalmente usamos el dominio con un punto final (`.`) para forzar el uso del dominio absoluto.

Necesitará configurar los siguientes registros DNS:

- **A**: Asocia su dominio con la dirección IPv4 de su servidor.
- **AAAA**: Asocia su dominio con la dirección IPv6 de su servidor.
- **MX**: Dirige los correos entrantes a su servidor de correo (incluyendo comodines `*`).
- **PTR**: Asocia la dirección IP de su servidor con su nombre de dominio.

Configure políticas de seguridad obligatorias:

- **DKIM**: Firma digitalmente los correos salientes para verificar la autenticidad.
- **DMARC**: Define cómo los receptores de correo deben manejar mensajes que fallan la autenticación.
- **SPF**: Autoriza servidores de correo específicos para enviar correos desde su dominio.

Pasos adicionales:

- **CAA**: Especifica qué autoridades certificadoras pueden emitir certificados SSL para su dominio.
- **MTA-STS**: Impone conexiones seguras y cifradas entre servidores de correo.
- **TLS-RPT**: Reporta fallos en conexiones TLS para mejorar la seguridad en la entrega de correo.

**Advertencia**: configurar un registro CAA restringirá qué autoridad certificadora puede emitir certificados SSL exitosamente para su dominio.
Esto evitará la emisión de certificados desde los servidores de prueba de Let’s Encrypt. Puede que desee diferir este registro DNS hasta después de que los certificados SSL se hayan emitido con éxito para su dominio.

## Docker

Si aún no tiene Docker instalado en su servidor, por favor siga los pasos en [Docker CE para Ubuntu](https://docs.docker.com/v17.12/install/linux/docker-ce/ubuntu/) para instalar Docker.

También puede instalar Docker usando el script [docker-install](https://github.com/docker/docker-install) que es

```bash
curl -fsSL https://get.docker.com | sh
```
Habilitar IPv6 para [la red de puente predeterminada](https://docs.docker.com/config/daemon/ipv6/#use-ipv6-for-the-default-bridge-network)


```json
{
  "ipv6": true,
  "fixed-cidr-v6": "2001:db8:1::/64",
  "experimental": true,
  "ip6tables": true
}
```

Este procedimiento le guiará para ejecutar toda la pila usando contenedores Docker.
Esto incluye:

- traefik
- Los contenedores de la [aplicación SimpleLogin](https://github.com/simple-login/app)
- postfix

Ejecute SimpleLogin desde contenedores Docker:

1. Clone este repositorio en `/opt/simplelogin`
1. Copie `.env.example` a `.env` y configure los valores apropiados.

    - configure la variable `DOMAIN` con su dominio.
    - configure la variable `SUBDOMAIN` con su subdominio. El valor por defecto es `app`.
    - configure la variable `POSTGRES_USER` para que coincida con las credenciales de postgres (cuando empiece desde cero, use `simplelogin`).
    - configure la variable `POSTGRES_PASSWORD` para que coincida con las credenciales de postgres (cuando empiece desde cero, establezca una clave aleatoria).
    - configure `FLASK_SECRET` con una clave secreta arbitraria.

### Postgres SQL

Este repositorio ejecuta un postgres SQL en un contenedor Docker.

**Advertencia**: versiones anteriores de este repositorio usaban la versión `12.1`.
Por favor, consulte la [documentación de referencia](https://github.com/springcomp/self-hosted-simplelogin/wiki/PostgreSQL) para más detalles y
las instrucciones de actualización.

### Ejecutando la aplicación

Ejecute la aplicación usando los siguientes comandos:

```sh
docker compose up --detach --remove-orphans --build && docker compose logs -f
```

Es posible que desee configurar [Autorización de Autoridad de Certificado (CAA)](https://github.com/springcomp/self-hosted-simplelogin/wiki/dns-caa) en este punto.

## Próximos pasos

Si todos los pasos anteriores son exitosos, abra <https://app.mydomain.com/> y cree su primera cuenta.

Por defecto, las cuentas nuevas no son premium, por lo que no tienen alias ilimitados. Para hacer que su cuenta sea premium,  
por favor vaya a la base de datos, tabla "users" y establezca la columna "lifetime" a "1" o "TRUE":

```bash
docker compose exec -it postgres psql -U myuser simplelogin
> UPDATE users SET lifetime = TRUE;
> \q
```

Una vez que hayas creado todas las cuentas de inicio de sesión deseadas, agrega estas líneas a `.env` para deshabilitar más registros:

```env
DISABLE_REGISTRATION=1
DISABLE_ONBOARDING=true
```

Luego, para reiniciar la aplicación web, aplique: `docker compose restart app`

## Misceláneos

### Configuración de Postfix - Spamhaus

El Proyecto Spamhaus mantiene una lista confiable de direcciones IP conocidas por ser la fuente de SPAM.
Puede verificar si una dirección IP dada está en esa lista enviando consultas a la infraestructura DNS.

Dado que Spamhaus bloquea consultas provenientes de resolutores DNS públicos (abiertos) (ver: <https://check.spamhaus.org/returnc/pub>) y su contenedor postfix puede usar
un resolutor público por defecto, se recomienda registrarse para obtener el servicio gratuito
[Spamhaus Data Query Service](https://www.spamhaus.com/free-trial/sign-up-for-a-free-data-query-service-account/)
y obtener una clave Spamhaus DQS.

Pegue esta clave como `SPAMHAUS_DQS_KEY` en su `.env`

Si no se proporciona una clave DQS, su contenedor postfix verificará si los espejos públicos de Spamhaus aceptan sus consultas y los usará en su lugar.
Si Spamhaus rechaza consultas de su contenedor postfix a los espejos públicos, se deshabilitará completamente.

### Configuración de Postfix - Alias virtuales

La configuración de postfix admite alias virtuales usando los archivos `postfix/conf.d/virtual` y `postfix/conf.d/virtual-regexp`.
Esos archivos se crean automáticamente al iniciar, basados en los correspondientes archivos plantilla [`postfix/templates/virtual.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual.tpl)
y [`postfix/templates/virtual-regexp.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual-regexp.tpl).

La configuración predeterminada es la siguiente:

#### virtual.tpl

El archivo `virtual` soporta configuraciones de postfix `virtual_alias_maps`.
Incluye una regla que asigna `unknown@mydomain.com` a `contact@mydomain.com` para demostrar la recepción
de un correo electrónico desde una dirección específica que no corresponde a un alias existente, hacia otro que sí.

```postfix-conf
unknown@mydomain.com  contact@mydomain.com
```

#### virtual-regexp.tpl

El archivo `virtual-regexp` soporta configuraciones postfix `virtual_alias_maps`.  
Incluye una regla que reescribe correos electrónicos dirigidos a un subdominio arbitrario, que no corresponde  
a un alias existente, a un nuevo alias que pertenece a un directorio cuyo nombre se toma del subdominio.  
Ese alias puede crearse al vuelo si no existe.

```postfix-conf
/^([^@]+)@([^.]+)\.mydomain.com/   $2/$1@mydomain.com
```
  
Por ejemplo, los correos electrónicos enviados a `someone@directory.mydomain.com` se enrutarán a `directory/someone@mydomain.com` por postfix.

## Cómo actualizar desde la versión 3.4.0

_Esta sección se ha movido a la [documentación de referencia](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-sl)_

## Cómo actualizar desde la configuración previa basada en NGinx

_Esta sección se ha movido a la [documentación de referencia](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-from-nginx)_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-14

---