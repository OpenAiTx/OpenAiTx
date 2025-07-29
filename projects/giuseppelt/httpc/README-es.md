# httpc
httpc es un framework de javascript/typescript para construir API basadas en funciones con código mínimo y seguridad de tipos de extremo a extremo.
- [Documentación y tutoriales](https://httpc.dev/docs)
- [Comunidad](https://httpc.dev/discord)
- [Problemas y solicitudes de funciones](https://httpc.dev/issues)

## Vista rápida
Solo escribes funciones y las exportas. No necesitas preocuparte por cómo el servidor las ejecutará.
```ts
function add(a: number, b: number) {
    return a + b;
}

function greet(name: string) {
    return `Hello ${name}`;
}

export default {
    add,
    greet,
}
```
Desde el cliente, puedes llamar a funciones del servidor como funciones normales de JavaScript con una sintaxis natural.

```ts
import createClient from "@your-package/api-client";

const client = createClient({
    endpoint: "http://api.domain.com"
});

let result = await client.add(1, 2);
// result: 3

let message = await client.greet("Edith");
// message: "Hello Edith"
```

## Principio clave
**httpc** es una abstracción sobre el protocolo HTTP estándar. Con **httpc** puedes construir una API que habla funciones, argumentos y valores de retorno, no verbos HTTP, encabezados, rutas de recursos, serialización de datos…

El framework **httpc** oculta toda la complejidad del HTTP subyacente mientras te mantiene enfocado en lo que importa: la lógica de la función.


## Características principales
### Middlewares
Ejecuta lógica común a través de middlewares.
```ts
import { httpCall } from "@httpc/server";

const getPostById = httpCall(
    Authenticated(),    // <-- authentication check
    Validate(String),   // <-- parameters validation
    Cache("5m"),        // <-- result caching
    async (postId: string) => {
        const post = await db.select("posts").where("id", postId);
        if (!post) {
            throw new NotFoundError();
        }

        return post;
    }
);
```

### Ubicuidad del contexto
Accede al contexto de la solicitud desde cualquier lugar de tu aplicación. Ya sea en un manejador, middleware o lógica de servicio, el contexto siempre está disponible sin necesidad de pasar parámetros.
```ts
async function getPosts() {
    const { user } = useContext();

    let category = "news";
    if (user) {
        category = user.preferredCategory;
        trace("Getting user preferred posts");
    }
    
    return await db.select("posts").where("category", category);
}

function trace(message: string) {
    const { requestId } = useContext();
    console.log(`[req:${requestId}] ${message}`);
}
```

### Hooks
Los hooks encapsulan la lógica común alrededor del contexto de la solicitud. Por convención, los hooks adoptan el prefijo `use`.
```ts
async function addNewComment(postId: string, message: string) {
    const user = useUser();

    if (!useIsAuthorized("comment:create")) {
        throw new ForbiddenError("Cannot add comments");
    }

    return await db.createComment({
        userId: user.id,
        postId,
        message
    });
}
```
**@httpc/kit** ofrece varios hooks integrados para almacenar en caché datos, realizar comprobaciones de autorización, hacer transacciones…

### Serverless
Puedes alojar una API completa de **httpc** dentro de un entorno serverless como Vercel, AWS Lambda o funciones de Netlify.
Esto ofrece la ventaja de desplegar una única función serverless que maneje toda la API.

Por ejemplo, con Vercel, puedes exponer todas tus funciones API:
```ts
//file: api/index.ts

import { createHttpCVercelAdapter } from "@httpc/adapter-vercel";
import calls from "../calls";

export default createHttpCVercelAdapter({
    calls,
    log: "info"
});
```

Luego, puedes llamar a funciones API desde páginas con verificación completa de tipos:
```ts
//file: pages/home.tsx

import { createClient, ClientDef } from "@httpc/client";
import { useQuery, useMutation } from "react-query";
import type calls from "../calls"; // <-- import calls definition

// create a typed client
const client = createClient<ClientDef<typeof calls>>();

export default function Home() {
  const posts = useQuery(["posts"], () => client.posts.getLatest());

  return (
    <div class="container">
      {posts.data.map(post =>
        <div class="post">
          <h2>{post.title}</h2>
          <p>{post.text}</p>
        </div>
      )}
    </div>
  );
}
```    

### Seguridad de tipos extensa
Personaliza los objetos incorporados para adaptarlos a tus necesidades, manteniendo el autocompletado y la verificación de tipos funcionando.

Puedes extender el contexto de la solicitud:
```ts
/// <reference types="@httpc/kit/env" />

interface IHttpCContext {
    // example custom property
    environment: string

    // other custom properties here
    // ...
}
```
Hay muchas entidades disponibles para ampliar. Por ejemplo, puede redefinir el objeto usuario con propiedades personalizadas:
```ts
interface IUser {
    firstName: string
    lastName: string
}
```
Las funciones integradas y los hooks obtendrán las definiciones personalizadas y te permitirán usarlas con verificación de tipos.
```ts
const { firstName } = useUser();
```

### Generación personalizada de clientes
Con **@httpc/cli** puedes generar un cliente específico para tu API. El cliente generado garantiza seguridad de tipos y una experiencia fluida con una sintaxis natural que los desarrolladores conocen.
```ts
const user = await client.users.search("some@email.com");
const posts = await client.posts.getByUser(user.id);
const newComment = await client.posts.addComment(posts[0].id, {
    text: "Hello",
    userId: user.id
});
```

### Más allá de httpc
El servidor httpc no se limita a llamadas a funciones. Puede manejar envíos de formularios de navegador, callbacks de web hooks, redirecciones estándar… y, en general, cualquier solicitud http. Usando `Parsers` (hay muchos incorporados), puedes personalizar cómo el servidor procesa una solicitud.

Manejar solicitudes http estándar es esencial en escenarios donde no controlas el cliente. Un **servidor httpc** permite responder tanto a funciones como a solicitudes http comunes.


## Familia httpc
**@httpc/server**: el componente central de httpc que permite llamadas a funciones sobre el protocolo http estándar

**@httpc/client**: interfaz tipada usada por consumidores para interactuar de forma segura con funciones expuestas por un servidor httpc

**@httpc/kit**: caja de herramientas rica en componentes integrados para gestionar casos de uso comunes y preocupaciones de negocio como autenticación, validación, caché y registro

**@httpc/cli**: comandos para configurar un proyecto, generar clientes, gestionar versiones y ayudar con tareas comunes

**@httpc/adapter-\***: varios [adaptadores](https://httpc.dev/docs/adapters) para alojar una API httpc dentro de entornos como vercel, funciones netlify, aws lambda y similares



## Estado del proyecto
**httpc** es experimental. Está en su etapa inicial. Puedes probarlo, adoptarlo en proyectos de hobby. Pero no está listo para producción.
<br />
La API aún no es estable. Habrá cambios incompatibles.
<br />
**httpc** está en desarrollo intenso. Puedes consultar el [Changelog](https://httpc.dev/changelog) y la [Hoja de ruta](https://httpc.dev/roadmap) para futuras características.


## Participación
### Comunidad
Puedes unirte en [Discord](https://httpc.dev/discord) y seguir el desarrollo, discutir contribuciones, recibir soporte o pedir ayuda. La participación en [Github discussion](https://httpc.dev/discuss) también es válida.

### Reportar un problema
Para cualquier error, solicitud de función o propuesta puedes [reportar un problema](https://httpc.dev/issues/new). Todos los problemas están disponibles en [Github](https://httpc.dev/issues).

### Contribuir
Todas las contribuciones son bienvenidas. Cualquier PR, problema y retroalimentación es apreciada. Consulta la [guía de contribución](https://httpc.dev/contribute).


## Licencia
MIT © [Giuseppe La Torre](https://github.com/giuseppelt)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---