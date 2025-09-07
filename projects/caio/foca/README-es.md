# Foca: Descubrimiento de membresía en clústeres en tus propios términos

Foca es un componente para el descubrimiento de clústeres basado en gossip. Es
una pequeña crate `no_std` + `alloc` que implementa el protocolo SWIM junto
con sus extensiones útiles (`SWIM+Inf.+Susp.`).

Proyecto:

* Repositorio Git: https://caio.co/de/foca/
* Rastreador de issues: https://github.com/caio/foca/issues
* CI: https://github.com/caio/foca/actions/workflows/ci.yml
* Paquetes: https://crates.io/crates/foca
* Documentación: https://docs.rs/foca


# Introducción

Lo más notable de Foca es el hecho de que casi
no hace nada. Listo para usar, todo lo que ofrece es una implementación confiable y eficiente
del [protocolo SWIM][1] que es agnóstico al transporte y
a la identidad.

Conocer cómo funciona SWIM es útil pero no necesario para usar
esta biblioteca. Leer la documentación del enum `Message`
debería darte una idea de cómo funciona el protocolo, pero el artículo es
una lectura muy accesible.

Foca está diseñado para adaptarse a cualquier tipo de transporte: si tu red
permite que los pares se comuniquen entre sí, puedes desplegar Foca sobre ella.
No solo los requerimientos generales de ancho de banda son bajos, sino que también
tienes control total sobre cómo los miembros se identifican entre sí (ver
`./examples/identity_golf.rs`) y cómo se codifican los mensajes.


# Uso

Por favor, echa un vistazo a `./examples/foca_insecure_udp_agent.rs`. Este
muestra cómo podría ser un agente simple basado en tokio y te permite
ejecutar y ver a Foca nadando.

~~~
$ cargo run --features std,tracing,bincode-codec --example foca_insecure_udp_agent -- --help
foca_insecure_udp_agent 

USO:
    foca_insecure_udp_agent [OPCIONES] <BIND_ADDR>

FLAGS:
    -h, --help       Muestra información de ayuda
    -V, --version    Muestra información de la versión

OPCIONES:
    -a, --announce <announce>    Dirección de otra instancia de Foca para unirse
    -f, --filename <filename>    Nombre del archivo que contendrá todos los miembros activos
    -i, --identity <identity>    La dirección que los miembros del clúster usarán para comunicarse contigo.
                                 Por defecto es BIND_ADDR

ARGUMENTOS:
    <BIND_ADDR>    Dirección de socket a la que enlazar. Ejemplo: 127.0.0.1:8080
~~~

Así que puedes iniciar el agente en un terminal con
`./foca_insecure_udp_agent 127.0.0.1:8000` y unirte a él con tantos otros
como desees usando una `BIND_ADDR` diferente y `--announce` apuntando a una
instancia en ejecución. Ejemplo:
`./foca_insecure_udp_agent 127.0.0.1:8001 -a 127.0.0.1:8000`.

El agente muestra información en la consola a través del suscriptor de [tracing][]. 
Por defecto el nivel de log es `INFO` y puede ser personalizado
mediante la variable de entorno `RUST_LOG` usando las directivas
[EnvFilter de tracing_subscriber][dir].


## Características de Cargo

Cada característica es opcional. El conjunto `default` siempre estará vacío.

* `std`: Implementa `foca::Identity` para `std::net::SocketAddr*` y
  expone `Config::new_lan` y `Config::new_wan`
* `tracing`: Instrumenta Foca usando la crate [tracing][]. Alto nivel
  las interacciones del protocolo se emiten como rastros `DEBUG`, se pueden
  exponer más detalles con el nivel `TRACE`. No se emiten otros niveles.
* `serde`: Deriva `Serialize` y `Deserialize` para los tipos públicos de Foca.
* `bincode-codec`: Proporciona `BincodeCodec`, un tipo de códec basado en serde
  que usa [bincode][] internamente.
* `postcard-codec`: Proporciona `PostcardCodec`, un códec amigable con `no_std`
  basado en serde que usa [postcard][] internamente.
* `unstable-notifications`: Proporciona nuevas notificaciones que permiten
  inspeccionar los mensajes enviados y recibidos


# Notas

Al escribir esta biblioteca, el objetivo principal fue tener un núcleo simple y pequeño
que sea fácil de probar, simular y razonar; se trataba principalmente
de obtener una mejor comprensión del protocolo después de leer
el artículo.

Mantenerse fiel a estos objetivos llevó naturalmente a una implementación que no
depende de muchas características del sistema operativo como un reloj de hardware, atómicos
y hilos, por lo que convertirse en una crate `no_std` (aunque aún requiriendo asignaciones en heap)
fue una característica accidental agradable a la que decidí
comprometerme.


## Comparación con memberlist

Evité mirar [memberlist][2] hasta estar satisfecho con mi
propia implementación. Desde entonces le eché un vistazo no exhaustivo:

* memberlist soporta transmisiones personalizadas, lo cual es una característica muy interesante
  para escenarios complejos de descubrimiento de servicios, así que ahora Foca también tiene soporte
  para difundir datos de usuario (ver documentación de `BroadcastHandler`) :-)

* Tiene un mecanismo de sincronización basado en streams (push-pull) que se
  usa para unirse y fusionar periódicamente el estado entre miembros: Está
  mucho más allá de las responsabilidades de Foca, pero es una idea muy interesante,
  así que he expuesto el método `Foca::apply_many` que permite al código


  usando Foca para hacer algo similar si se desea.

* Sus parámetros de configuración cambian según el tamaño
  (actual) del clúster. Los usuarios pueden utilizar `Config::new_{lan,wan}` junto con
  `Foca::set_config` para lograr lo mismo

# Referencias

* El artículo [SWIM: Scalable Weakly-consistent Infection-style Process Group Membership
Protocol][1]
* [memberlist] de HashiCorp [2]

[1]: https://www.cs.cornell.edu/projects/Quicksilver/public_pdfs/SWIM.pdf
[2]: https://github.com/hashicorp/memberlist
[bincode]: https://github.com/bincode-org/bincode
[postcard]: https://github.com/jamesmunns/postcard
[tracing]: https://docs.rs/tracing/latest/tracing/
[dir]: https://docs.rs/tracing-subscriber/0.3.17/tracing_subscriber/filter/struct.EnvFilter.html#directives

# Licencia

A menos que se indique explícitamente lo contrario, todo el trabajo está sujeto a los términos
de la Licencia Pública de Mozilla, versión 2.0.

Los archivos dentro del directorio `examples/` están dedicados al Dominio Público.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-07

---