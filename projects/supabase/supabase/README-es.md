<p align="center">
<img src="https://user-images.githubusercontent.com/8291514/213727234-cda046d6-28c6-491a-b284-b86c5cede25d.png#gh-light-mode-only">
<img src="https://user-images.githubusercontent.com/8291514/213727225-56186826-bee8-43b5-9b15-86e839d89393.png#gh-dark-mode-only">
</p>

# Supabase

[Supabase](https://supabase.com) es una alternativa de código abierto a Firebase. Estamos construyendo las funcionalidades de Firebase utilizando herramientas de código abierto de nivel empresarial.

- [x] Base de datos Postgres alojada. [Documentación](https://supabase.com/docs/guides/database)
- [x] Autenticación y Autorización. [Documentación](https://supabase.com/docs/guides/auth)
- [x] APIs autogeneradas.
  - [x] REST. [Documentación](https://supabase.com/docs/guides/api)
  - [x] GraphQL. [Documentación](https://supabase.com/docs/guides/graphql)
  - [x] Suscripciones en tiempo real. [Documentación](https://supabase.com/docs/guides/realtime)
- [x] Funciones.
  - [x] Funciones de base de datos. [Documentación](https://supabase.com/docs/guides/database/functions)
  - [x] Funciones Edge [Documentación](https://supabase.com/docs/guides/functions)
- [x] Almacenamiento de archivos. [Documentación](https://supabase.com/docs/guides/storage)
- [x] Kit de herramientas de IA + Vectores/Embeddings. [Documentación](https://supabase.com/docs/guides/ai)
- [x] Panel de control

![Panel de Supabase](https://raw.githubusercontent.com/supabase/supabase/master/apps/www/public/images/github/supabase-dashboard.png)

Sigue los "lanzamientos" de este repositorio para recibir notificaciones de actualizaciones importantes.

<kbd><img src="https://raw.githubusercontent.com/supabase/supabase/d5f7f413ab356dc1a92075cb3cee4e40a957d5b1/web/static/watch-repo.gif" alt="Observa este repositorio"/></kbd>

## Documentación

Para la documentación completa, visita [supabase.com/docs](https://supabase.com/docs)

Para ver cómo contribuir, visita [Primeros Pasos](./DEVELOPERS.md)

## Comunidad y Soporte

- [Foro de la Comunidad](https://github.com/supabase/supabase/discussions). Recomendado para: ayuda con desarrollo, discusión sobre mejores prácticas de bases de datos.
- [Issues de GitHub](https://github.com/supabase/supabase/issues). Recomendado para: errores y problemas encontrados usando Supabase.
- [Soporte por correo electrónico](https://supabase.com/docs/support#business-support). Recomendado para: problemas con tu base de datos o infraestructura.
- [Discord](https://discord.supabase.com). Recomendado para: compartir tus aplicaciones y convivir con la comunidad.

## Cómo funciona

Supabase es una combinación de herramientas de código abierto. Estamos construyendo las funcionalidades de Firebase utilizando productos de código abierto de nivel empresarial. Si las herramientas y comunidades existen, con una licencia abierta MIT, Apache 2 o equivalente, usaremos y apoyaremos esa herramienta. Si la herramienta no existe, la construimos y liberamos como código abierto nosotros mismos. Supabase no es una copia uno a uno de Firebase. Nuestro objetivo es ofrecer a los desarrolladores una experiencia similar a Firebase usando herramientas de código abierto.

**Arquitectura**

Supabase es una [plataforma alojada](https://supabase.com/dashboard). Puedes registrarte y comenzar a usar Supabase sin instalar nada.
También puedes [alojarlo tú mismo](https://supabase.com/docs/guides/hosting/overview) y [desarrollar localmente](https://supabase.com/docs/guides/local-development).

![Arquitectura](apps/docs/public/img/supabase-architecture.svg)

- [Postgres](https://www.postgresql.org/) es un sistema de base de datos objeto-relacional con más de 30 años de desarrollo activo que le han otorgado una sólida reputación por su fiabilidad, robustez de funcionalidades y rendimiento.
- [Realtime](https://github.com/supabase/realtime) es un servidor Elixir que permite escuchar inserciones, actualizaciones y eliminaciones de PostgreSQL usando websockets. Realtime consulta la funcionalidad de replicación incorporada de Postgres para detectar cambios en la base de datos, convierte los cambios a JSON y luego transmite ese JSON por websockets a clientes autorizados.
- [PostgREST](http://postgrest.org/) es un servidor web que convierte tu base de datos PostgreSQL directamente en una API RESTful.
- [GoTrue](https://github.com/supabase/gotrue) es una API de autenticación basada en JWT que simplifica los registros, inicios de sesión y gestión de sesiones de usuarios en tus aplicaciones.
- [Storage](https://github.com/supabase/storage-api) es una API RESTful para gestionar archivos en S3, con permisos gestionados por Postgres.
- [pg_graphql](http://github.com/supabase/pg_graphql/) es una extensión de PostgreSQL que expone una API GraphQL.
- [postgres-meta](https://github.com/supabase/postgres-meta) es una API RESTful para gestionar tu Postgres, permitiendo obtener tablas, agregar roles y ejecutar consultas, etc.
- [Kong](https://github.com/Kong/kong) es una puerta de enlace de API nativa para la nube.

#### Librerías cliente

Nuestro enfoque para las librerías cliente es modular. Cada sub-librería es una implementación independiente para un sistema externo específico. Esta es una de las formas en que apoyamos herramientas existentes.

<table style="table-layout:fixed; white-space: nowrap;">
  <tr>
    <th>Idioma</th>
    <th>Cliente</th>
    <th colspan="5">Clientes de funcionalidades (incluidos en el cliente Supabase)</th>
  </tr>
  <!-- notranslate -->
  <tr>
    <th></th>
    <th>Supabase</th>
    <th><a href="https://github.com/postgrest/postgrest" target="_blank" rel="noopener noreferrer">PostgREST</a></th>
    <th><a href="https://github.com/supabase/gotrue" target="_blank" rel="noopener noreferrer">GoTrue</a></th>
    <th><a href="https://github.com/supabase/realtime" target="_blank" rel="noopener noreferrer">Realtime</a></th>
    <th><a href="https://github.com/supabase/storage-api" target="_blank" rel="noopener noreferrer">Storage</a></th>
    <th>Funciones</th>
  </tr>
  <!-- TEMPLATE FOR NEW ROW -->
  <!-- START ROW
  <tr>
    <td>lang</td>
    <td><a href="https://github.com/supabase-community/supabase-lang" target="_blank" rel="noopener noreferrer">supabase-lang</a></td>
    <td><a href="https://github.com/supabase-community/postgrest-lang" target="_blank" rel="noopener noreferrer">postgrest-lang</a></td>
    <td><a href="https://github.com/supabase-community/gotrue-lang" target="_blank" rel="noopener noreferrer">gotrue-lang</a></td>
    <td><a href="https://github.com/supabase-community/realtime-lang" target="_blank" rel="noopener noreferrer">realtime-lang</a></td>
    <td><a href="https://github.com/supabase-community/storage-lang" target="_blank" rel="noopener noreferrer">storage-lang</a></td>
  </tr>
  END ROW -->
  <!-- /notranslate -->
  <th colspan="7">⚡️ Oficial ⚡️</th>
  <!-- notranslate -->
  <tr>
    <td>JavaScript (TypeScript)</td>
    <td><a href="https://github.com/supabase/supabase-js" target="_blank" rel="noopener noreferrer">supabase-js</a></td>
    <td><a href="https://github.com/supabase/postgrest-js" target="_blank" rel="noopener noreferrer">postgrest-js</a></td>
    <td><a href="https://github.com/supabase/gotrue-js" target="_blank" rel="noopener noreferrer">gotrue-js</a></td>
    <td><a href="https://github.com/supabase/realtime-js" target="_blank" rel="noopener noreferrer">realtime-js</a></td>
    <td><a href="https://github.com/supabase/storage-js" target="_blank" rel="noopener noreferrer">storage-js</a></td>
    <td><a href="https://github.com/supabase/functions-js" target="_blank" rel="noopener noreferrer">functions-js</a></td>
  </tr>
    <tr>
    <td>Flutter</td>
    <td><a href="https://github.com/supabase/supabase-flutter" target="_blank" rel="noopener noreferrer">supabase-flutter</a></td>
    <td><a href="https://github.com/supabase/postgrest-dart" target="_blank" rel="noopener noreferrer">postgrest-dart</a></td>
    <td><a href="https://github.com/supabase/gotrue-dart" target="_blank" rel="noopener noreferrer">gotrue-dart</a></td>
    <td><a href="https://github.com/supabase/realtime-dart" target="_blank" rel="noopener noreferrer">realtime-dart</a></td>
    <td><a href="https://github.com/supabase/storage-dart" target="_blank" rel="noopener noreferrer">storage-dart</a></td>
    <td><a href="https://github.com/supabase/functions-dart" target="_blank" rel="noopener noreferrer">functions-dart</a></td>
  </tr>
  <tr>
    <td>Swift</td>
    <td><a href="https://github.com/supabase/supabase-swift" target="_blank" rel="noopener noreferrer">supabase-swift</a></td>
    <td><a href="https://github.com/supabase/supabase-swift/tree/main/Sources/PostgREST" target="_blank" rel="noopener noreferrer">postgrest-swift</a></td>
    <td><a href="https://github.com/supabase/supabase-swift/tree/main/Sources/Auth" target="_blank" rel="noopener noreferrer">auth-swift</a></td>
    <td><a href="https://github.com/supabase/supabase-swift/tree/main/Sources/Realtime" target="_blank" rel="noopener noreferrer">realtime-swift</a></td>
    <td><a href="https://github.com/supabase/supabase-swift/tree/main/Sources/Storage" target="_blank" rel="noopener noreferrer">storage-swift</a></td>
    <td><a href="https://github.com/supabase/supabase-swift/tree/main/Sources/Functions" target="_blank" rel="noopener noreferrer">functions-swift</a></td>
  </tr>
  <tr>
    <td>Python</td>
    <td><a href="https://github.com/supabase/supabase-py" target="_blank" rel="noopener noreferrer">supabase-py</a></td>
    <td><a href="https://github.com/supabase/postgrest-py" target="_blank" rel="noopener noreferrer">postgrest-py</a></td>
    <td><a href="https://github.com/supabase/gotrue-py" target="_blank" rel="noopener noreferrer">gotrue-py</a></td>
    <td><a href="https://github.com/supabase/realtime-py" target="_blank" rel="noopener noreferrer">realtime-py</a></td>
    <td><a href="https://github.com/supabase/storage-py" target="_blank" rel="noopener noreferrer">storage-py</a></td>
    <td><a href="https://github.com/supabase/functions-py" target="_blank" rel="noopener noreferrer">functions-py</a></td>
  </tr>
  <!-- /notranslate -->
  <th colspan="7">💚 Comunidad 💚</th>
  <!-- notranslate -->
  <tr>
    <td>C#</td>
    <td><a href="https://github.com/supabase-community/supabase-csharp" target="_blank" rel="noopener noreferrer">supabase-csharp</a></td>
    <td><a href="https://github.com/supabase-community/postgrest-csharp" target="_blank" rel="noopener noreferrer">postgrest-csharp</a></td>
    <td><a href="https://github.com/supabase-community/gotrue-csharp" target="_blank" rel="noopener noreferrer">gotrue-csharp</a></td>
    <td><a href="https://github.com/supabase-community/realtime-csharp" target="_blank" rel="noopener noreferrer">realtime-csharp</a></td>
    <td><a href="https://github.com/supabase-community/storage-csharp" target="_blank" rel="noopener noreferrer">storage-csharp</a></td>
    <td><a href="https://github.com/supabase-community/functions-csharp" target="_blank" rel="noopener noreferrer">functions-csharp</a></td>
  </tr>
  <tr>
    <td>Go</td>
    <td>-</td>
    <td><a href="https://github.com/supabase-community/postgrest-go" target="_blank" rel="noopener noreferrer">postgrest-go</a></td>
    <td><a href="https://github.com/supabase-community/gotrue-go" target="_blank" rel="noopener noreferrer">gotrue-go</a></td>
    <td>-</td>
    <td><a href="https://github.com/supabase-community/storage-go" target="_blank" rel="noopener noreferrer">storage-go</a></td>
    <td><a href="https://github.com/supabase-community/functions-go" target="_blank" rel="noopener noreferrer">functions-go</a></td>
  </tr>
  <tr>
    <td>Java</td>
    <td>-</td>
    <td>-</td>
    <td><a href="https://github.com/supabase-community/gotrue-java" target="_blank" rel="noopener noreferrer">gotrue-java</a></td>
    <td>-</td>
    <td><a href="https://github.com/supabase-community/storage-java" target="_blank" rel="noopener noreferrer">storage-java</a></td>
    <td>-</td>
  </tr>
  <tr>
    <td>Kotlin</td>
    <td><a href="https://github.com/supabase-community/supabase-kt" target="_blank" rel="noopener noreferrer">supabase-kt</a></td>
    <td><a href="https://github.com/supabase-community/supabase-kt/tree/master/Postgrest" target="_blank" rel="noopener noreferrer">postgrest-kt</a></td>
    <td><a href="https://github.com/supabase-community/supabase-kt/tree/master/Auth" target="_blank" rel="noopener noreferrer">auth-kt</a></td>
    <td><a href="https://github.com/supabase-community/supabase-kt/tree/master/Realtime" target="_blank" rel="noopener noreferrer">realtime-kt</a></td>
    <td><a href="https://github.com/supabase-community/supabase-kt/tree/master/Storage" target="_blank" rel="noopener noreferrer">storage-kt</a></td>
    <td><a href="https://github.com/supabase-community/supabase-kt/tree/master/Functions" target="_blank" rel="noopener noreferrer">functions-kt</a></td>
  </tr>
  <tr>
    <td>Ruby</td>
    <td><a href="https://github.com/supabase-community/supabase-rb" target="_blank" rel="noopener noreferrer">supabase-rb</a></td>
    <td><a href="https://github.com/supabase-community/postgrest-rb" target="_blank" rel="noopener noreferrer">postgrest-rb</a></td>
    <td>-</td>
    <td>-</td>
    <td>-</td>
    <td>-</td>
  </tr>
  <tr>
    <td>Rust</td>
    <td>-</td>
    <td><a href="https://github.com/supabase-community/postgrest-rs" target="_blank" rel="noopener noreferrer">postgrest-rs</a></td>
    <td>-</td>
    <td>-</td>
    <td>-</td>
    <td>-</td>
  </tr>
  <tr>
    <td>Godot Engine (GDScript)</td>
    <td><a href="https://github.com/supabase-community/godot-engine.supabase" target="_blank" rel="noopener noreferrer">supabase-gdscript</a></td>
    <td><a href="https://github.com/supabase-community/postgrest-gdscript" target="_blank" rel="noopener noreferrer">postgrest-gdscript</a></td>
    <td><a href="https://github.com/supabase-community/gotrue-gdscript" target="_blank" rel="noopener noreferrer">gotrue-gdscript</a></td>
    <td><a href="https://github.com/supabase-community/realtime-gdscript" target="_blank" rel="noopener noreferrer">realtime-gdscript</a></td>
    <td><a href="https://github.com/supabase-community/storage-gdscript" target="_blank" rel="noopener noreferrer">storage-gdscript</a></td>
    <td><a href="https://github.com/supabase-community/functions-gdscript" target="_blank" rel="noopener noreferrer">functions-gdscript</a></td>
  </tr>
  <!-- /notranslate -->
</table>

<!--- Elimina esta lista si estás traduciendo a otro idioma, es difícil mantenerla actualizada en múltiples archivos-->
<!--- Mantén solo el enlace a la lista de archivos de traducción-->

## Insignias

![Hecho con Supabase](./apps/www/public/badge-made-with-supabase.svg)

```md
[![Hecho con Supabase](https://supabase.com/badge-made-with-supabase.svg)](https://supabase.com)
```

```html
<a href="https://supabase.com">
  <img
    width="168"
    height="30"
    src="https://supabase.com/badge-made-with-supabase.svg"
    alt="Hecho con Supabase"
  />
</a>
```

![Hecho con Supabase (oscuro)](./apps/www/public/badge-made-with-supabase-dark.svg)

```md
[![Hecho con Supabase](https://supabase.com/badge-made-with-supabase-dark.svg)](https://supabase.com)
```

```html
<a href="https://supabase.com">
  <img
    width="168"
    height="30"
    src="https://supabase.com/badge-made-with-supabase-dark.svg"
    alt="Hecho con Supabase"
  />
</a>
```

## Traducciones

- [Lista de traducciones](/i18n/languages.md) <!--- Mantén solo esto -->


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---