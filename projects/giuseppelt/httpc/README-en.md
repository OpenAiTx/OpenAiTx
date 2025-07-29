# httpc
httpc is a javascript/typescript framework for building function-based API with minimal code and end-to-end type safety.
- [Documentation and tutorials](https://httpc.dev/docs)
- [Community](https://httpc.dev/discord)
- [Issues and feature requests](https://httpc.dev/issues)

## Quick glance
You just write functions and export them. No need to worry how the server will execute them.
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
From the client, you can call server functions like normal JavaScript functions with a natural syntax.

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

## Key principle
**httpc** is an abstraction over the standard HTTP protocol. With **httpc** you can build an API that speaks functions, arguments and return values, not http verbs, headers, resource paths, data serialization…

The **httpc** framework hides all the complexity of the underling HTTP while keeping you focused on what matters: the function logic.


## Main features
### Middlewares
Run common logic via middlewares.
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

### Context ubiquity
Access the request context from everywhere in your application. Whether in a handler, middleware, or service logic, the context is always available with no need to pass parameters around.
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
Hooks encapsulate common logic around the request context. By convention, hooks adopt the `use` prefix.
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
**@httpc/kit** offers several builtin hooks to cache data, to perform authorization checks, to make transactions…

### Serverless
You can host a full **httpc** API inside a serverless environment like Vercel, AWS Lambda or Netlify functions.
This gives the advantage to deploy a single serverless function handling the whole API.

For example with Vercel, you can expose all your API functions:
```ts
//file: api/index.ts

import { createHttpCVercelAdapter } from "@httpc/adapter-vercel";
import calls from "../calls";

export default createHttpCVercelAdapter({
    calls,
    log: "info"
});
```
Then, you can call API functions from pages with full type checking:

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

### Extensive type safety
Customize built-in objects to fit your needs, while keeping autocompletion and type checking functional.

You can extend the request context:
```ts
/// <reference types="@httpc/kit/env" />

interface IHttpCContext {
    // example custom property
    environment: string

    // other custom properties here
    // ...
}
```
There're many entities available to extend. For example you can redefine the user object with custom properties:
```ts
interface IUser {
    firstName: string
    lastName: string
}
```
Built-in functions and hooks will receive the custom definitions and allow you to use them with type checking.
```ts
const { firstName } = useUser();
```

### Custom client generation
With **@httpc/cli** you can generate a specific client for your API. The generated client ensures type safety and a smooth experience with a natural syntax developers are familiar with.
```ts
const user = await client.users.search("some@email.com");
const posts = await client.posts.getByUser(user.id);
const newComment = await client.posts.addComment(posts[0].id, {
    text: "Hello",
    userId: user.id
});
```

### Beyond httpc
The httpc server is not limited to function calls. It can handle browser form submissions, web hook callbacks, standard redirects… and, in general, any http request. By using `Parsers` (there're many builtin), you can customize how the server processes a request.

Handling standard http requests is essential in scenarios where you don't control the client. An **httpc server** allows you to respond to both functions and common http requests.


## httpc family
**@httpc/server**: the httpc core component allowing function calls over the standard http protocol

**@httpc/client**: typed interface used by consumers to interact safely with functions exposed by an httpc server

**@httpc/kit**: rich toolbox of builtin components to manage common use cases and business concerns like authentication, validation, caching and logging

**@httpc/cli**: commands to setup a project, generate clients, manage versioning and help with common tasks

**@httpc/adapter-\***: various [adapters](https://httpc.dev/docs/adapters) to host an httpc API inside environments like vercel, netlify functions, aws lambda and similar



## Project status
**httpc** is experimental. It's in its infancy stage. You can try it, adopt it in hobby projects. But it's not ready for production.
<br />
The API is not stable yet. Breaking changes will happen.
<br />
**httpc** is under heavy development. You can check out the [Changelog](https://httpc.dev/changelog) and the [Roadmap](https://httpc.dev/roadmap) for future features.


## Involvement
### Community
You can join on [Discord](https://httpc.dev/discord) and follow the development, discuss contributions, receive support or ask for help. Participation in [Github discussion](https://httpc.dev/discuss) is fine too.

### File an Issue
For any bugs, feature requests or proposals you can [file an issue](https://httpc.dev/issues/new). All issues are available on [Github](https://httpc.dev/issues).

### Contributing
All contributions are welcome. Any PR, issue and feedback is appreciated. Check out the [contribution guide](https://httpc.dev/contribute).


## License
MIT © [Giuseppe La Torre](https://github.com/giuseppelt)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---