## <img width=16 src="https://raw.githubusercontent.com/JonasGruenwald/spectator/refs/heads/main/spectator/src/spectator/internal/assets/lucy_spectator.svg"> Spectator

[![Package Version](https://img.shields.io/hexpm/v/spectator)](https://hex.pm/packages/spectator)
[![Hex Docs](https://img.shields.io/badge/hex-docs-ffaff3)](https://hexdocs.pm/spectator/)

Spectator es una herramienta de observación BEAM escrita en Gleam, que funciona bien con procesos gleam_otp.

![](https://raw.githubusercontent.com/JonasGruenwald/spectator/refs/heads/main/screenshot.png)

## Características

Hasta ahora, spectator tiene las siguientes características:

- Mostrar procesos en una tabla ordenable
- Etiquetar procesos individuales para fácil identificación
- Mostrar detalles del proceso
- Mostrar estado del proceso OTP
- Suspender / reanudar procesos OTP
- Listar tablas ETS
- Ver contenido de tablas ETS
- Lista de puertos activos
- Enlaces clicables entre recursos
- Panel con estadísticas básicas
- Inspeccionar otros nodos BEAM

## Usar Spectator en Desarrollo

Puedes instalar spectator como dependencia en tu proyecto y ejecutarlo como parte de tu aplicación para inspeccionar tu app en desarrollo.

```sh
gleam add spectator
```
Para detalles sobre cómo hacer esto, consulte el [README del paquete](https://hexdocs.pm/spectator/)

## Usar Spectator en Producción

Puede usar spectator para inspeccionar el nodo BEAM que ejecuta su aplicación desplegada ejecutando spectator como una aplicación independiente y conectándolo al nodo erlang donde se ejecuta su aplicación mediante distribución.

La aplicación spectator independiente está disponible como imagen docker en `ghcr.io/jonasgruenwald/spectator`, y como escript a través de la [página de lanzamientos](https://github.com/JonasGruenwald/spectator/releases).

El repositorio contiene [un ejemplo completo de cómo usar spectator para inspeccionar una aplicación desplegada vía docker](https://github.com/JonasGruenwald/spectator/tree/main/example#readme).

Primero, asegúrese de que su aplicación tenga un nombre Erlang y una cookie configurados, por ejemplo, estableciendo la variable de entorno `ERL_FLAGS` antes de iniciar su aplicación:


```sh
ERL_FLAGS="-name myapp@host -setcookie mycookie"
```

Si su aplicación se está ejecutando en un contenedor Docker, coloque tanto el contenedor de su aplicación como el contenedor que ejecuta spectator en la misma red Docker, y asegúrese de que el contenedor de su aplicación tenga su nombre de host configurado en un valor que conozca.

Inicie spectator y haga clic en 'Change Target' en la esquina superior derecha de la aplicación.

Ingrese los detalles del nodo que desea inspeccionar, el nombre debe ser el nombre que configuró mediante `-sname`, seguido de `@`, y luego el nombre de host.

Finalmente, haga clic en 'Connect' para inspeccionar el nodo de su aplicación.

Tenga en cuenta que el objetivo de la inspección debe tener la misma cookie de Erlang configurada que spectator. Al igual que con su aplicación, puede configurar la cookie de spectator mediante la variable de entorno `ERL_FLAGS`, por ejemplo, `ERL_FLAGS="-name spectator@127.0.0.1 -setcookie mycookie"`.

## Consideraciones

Tenga en cuenta las siguientes implicaciones de ejecutar spectator:

- **Spectator puede ralentizar su sistema**  
  Todos los procesos mostrados son sondeados en el intervalo configurado usando la función `process_info/2` de Erlang, que pone un bloqueo temporal en el proceso al que se accede. Si el proceso está manejando muchos mensajes, esto puede tener implicaciones en el rendimiento del sistema.

- **Spectator creará átomos dinámicamente**  
  Cuando elige conectarse a otros nodos Erlang, spectator necesita convertir el nombre del nodo que proporciona en un átomo. Por lo tanto, es posible agotar la memoria de la instancia BEAM que ejecuta spectator utilizando su interfaz de usuario, ya que los átomos nunca se recolectan como basura.

- **Spectator no incluye Control de Acceso**  
  Spectator expone detalles sensibles sobre el tiempo de ejecución que está inspeccionando a través de su interfaz web y actualmente no restringe el acceso a ella.  
  Si usa spectator en un entorno de producción, usted es responsable de asegurarla – asegúrese de no exponer spectator a Internet público.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-26

---