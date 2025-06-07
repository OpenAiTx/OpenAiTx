<div align="center">
  <h1>Lampo</h1>

  <img src="https://github.com/saradurante/lampo.docs/blob/dc0dce971c3052f0e9dd668fdf0c7376b12fee7b/imgs/web/icon-512.png?raw=true"  width="150" height="150" />


  <p>
    <strong>Implementación de la red Lightning rápida y modular para todos los usos, escrita en Rust.</strong>
  </p>

  <h4>
    <a href="https://lampo.devcrew.cc">Página principal del proyecto</a>
  </h4>
</div>

## Crates

Esta es la lista completa de crates soportados actualmente:

| Crate       | Descripción                                   | Versión     |
|:------------|:---------------------------------------------:|------------:|
| lampod-cli  | Interfaz de línea de comandos del Demonio Lampo para ejecutar el demonio | _unrelated_ |
| lampo-cli   | Interfaz de línea de comandos simple de Lampo para interactuar con el demonio | _unrelated_ |

## Cómo instalar

Para instalar todos los requisitos y el binario de Lampo, necesitas
tener Rust instalado y luego ejecutar el siguiente comando:

```
make install
```

Después de tener disponibles `lampod-cli` y `lampo-cli`, puedes
ejecutar el siguiente comando para lanzar Lampo en modo signet:

```
➜  ~ lampod-cli --network signet
✓ Billetera generada, por favor guarda estas palabras de forma segura
 wallet-keys  maple have fitness decide food joy flame coast stereo front grab stumble
```

>[!NOTE]
Guarda las palabras de tu billetera, y luego reutilízalas para restaurar la billetera con `--restore-wallet`.
¡Si no guardas tus palabras en ningún lugar, tus fondos se perderán la próxima vez que inicies Lampo!

Ten en cuenta que necesitas tener un archivo `lampo.conf` en la ruta `~/.lampo/signet`. Ejecuta el
siguiente comando para usar el archivo de configuración de ejemplo:

```
cp lampo.example.conf ~/.lampo/signet/lampo.conf
```

Luego puedes consultar el nodo con el siguiente comando:

``` 
➜  ~ lampo-cli --network signet getinfo
{
  "node_id": "035b889551a44e502cd0cd6657acf067336034986cd6639b222cd4be563a7fc205",
  "peers": 0,
  "channels": 0
}
```

### Para ejecutar pruebas de integración con core lightning:

Asegúrate de haber compilado core-lightning en modo desarrollador. La guía de instalación se puede encontrar [aquí](https://docs.corelightning.org/docs/installation).

Las pruebas de integración pueden ejecutarse usando el siguiente comando:

```
make integration
```

## Guía de contribución

Por favor, lee nuestra [Guía de contribución](https://raw.githubusercontent.com/vincenzopalazzo/lampo.rs/main/CONTRIBUTING.md).

## Comunidad

Con el objetivo de mantener la claridad, hemos elegido canales específicos para la comunicación:
- Desarrolladores, únanse a nosotros en [Zulip](https://lampo-dev.zulipchat.com/).
- Miembros de la comunidad, nuestra [comunidad en Twitter](https://twitter.com/i/communities/1736414802849706087) espera sus aportes.
- Para preguntas técnicas y solicitudes de características, participa en nuestras discusiones en GitHub.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---