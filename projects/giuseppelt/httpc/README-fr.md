# httpc
httpc est un framework javascript/typescript pour construire des API basées sur des fonctions avec un code minimal et une sécurité de type de bout en bout.
- [Documentation et tutoriels](https://httpc.dev/docs)
- [Communauté](https://httpc.dev/discord)
- [Problèmes et demandes de fonctionnalités](https://httpc.dev/issues)

## Aperçu rapide
Vous écrivez simplement des fonctions et les exportez. Pas besoin de vous soucier de la manière dont le serveur les exécutera.
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

Depuis le client, vous pouvez appeler les fonctions du serveur comme des fonctions JavaScript normales avec une syntaxe naturelle.
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

## Principe clé
**httpc** est une abstraction du protocole HTTP standard. Avec **httpc**, vous pouvez construire une API qui utilise des fonctions, des arguments et des valeurs de retour, et non des verbes http, des en-têtes, des chemins de ressources, la sérialisation des données…

Le cadre **httpc** masque toute la complexité du HTTP sous-jacent tout en vous permettant de vous concentrer sur l'essentiel : la logique des fonctions.


## Fonctionnalités principales
### Middlewares
Exécutez une logique commune via des middlewares.
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

### Omniprésence du contexte
Accédez au contexte de la requête depuis n'importe où dans votre application. Que ce soit dans un gestionnaire, un middleware ou la logique de service, le contexte est toujours disponible sans besoin de passer des paramètres.
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
Les hooks encapsulent une logique commune autour du contexte de la requête. Par convention, les hooks adoptent le préfixe `use`.
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
**@httpc/kit** offre plusieurs hooks intégrés pour mettre en cache les données, effectuer des vérifications d'autorisation, réaliser des transactions…

### Serverless
Vous pouvez héberger une API complète **httpc** dans un environnement serverless comme Vercel, AWS Lambda ou les fonctions Netlify.
Cela présente l'avantage de déployer une seule fonction serverless gérant toute l'API.

Par exemple avec Vercel, vous pouvez exposer toutes vos fonctions API :
```ts
//file: api/index.ts

import { createHttpCVercelAdapter } from "@httpc/adapter-vercel";
import calls from "../calls";

export default createHttpCVercelAdapter({
    calls,
    log: "info"
});
```

Ensuite, vous pouvez appeler des fonctions API depuis les pages avec une vérification complète des types :
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

### Sécurité de type étendue
Personnalisez les objets intégrés selon vos besoins, tout en conservant l'autocomplétion et la vérification de type.

Vous pouvez étendre le contexte de la requête :
```ts
/// <reference types="@httpc/kit/env" />

interface IHttpCContext {
    // example custom property
    environment: string

    // other custom properties here
    // ...
}
```
De nombreuses entités sont disponibles pour être étendues. Par exemple, vous pouvez redéfinir l'objet utilisateur avec des propriétés personnalisées :
```ts
interface IUser {
    firstName: string
    lastName: string
}
```
Les fonctions intégrées et les hooks recevront les définitions personnalisées et vous permettront de les utiliser avec une vérification de type.
```ts
const { firstName } = useUser();
```

### Génération de client personnalisée
Avec **@httpc/cli**, vous pouvez générer un client spécifique pour votre API. Le client généré garantit la sécurité des types et une expérience fluide avec une syntaxe naturelle familière aux développeurs.
```ts
const user = await client.users.search("some@email.com");
const posts = await client.posts.getByUser(user.id);
const newComment = await client.posts.addComment(posts[0].id, {
    text: "Hello",
    userId: user.id
});
```

### Au-delà de httpc
Le serveur httpc n’est pas limité aux appels de fonctions. Il peut gérer les soumissions de formulaires via navigateur, les callbacks de web hook, les redirections standard… et, en général, toute requête http. En utilisant des `Parsers` (il en existe beaucoup intégrés), vous pouvez personnaliser la façon dont le serveur traite une requête.

Gérer les requêtes http standard est essentiel dans les scénarios où vous ne contrôlez pas le client. Un **serveur httpc** vous permet de répondre à la fois aux fonctions et aux requêtes http courantes.


## Famille httpc
**@httpc/server** : le composant central httpc permettant les appels de fonctions via le protocole http standard

**@httpc/client** : interface typée utilisée par les consommateurs pour interagir en toute sécurité avec les fonctions exposées par un serveur httpc

**@httpc/kit** : boîte à outils riche de composants intégrés pour gérer les cas d’usage courants et les préoccupations métier telles que l’authentification, la validation, la mise en cache et la journalisation

**@httpc/cli** : commandes pour configurer un projet, générer des clients, gérer les versions et aider aux tâches courantes

**@httpc/adapter-\*** : divers [adaptateurs](https://httpc.dev/docs/adapters) pour héberger une API httpc dans des environnements comme vercel, netlify functions, aws lambda et similaires



## Statut du projet
**httpc** est expérimental. Il en est à ses débuts. Vous pouvez l’essayer, l’adopter dans des projets personnels. Mais il n’est pas prêt pour la production.
<br />
L’API n’est pas encore stable. Des changements incompatibles auront lieu.
<br />
**httpc** est en plein développement intensif. Vous pouvez consulter le [Changelog](https://httpc.dev/changelog) et la [Feuille de route](https://httpc.dev/roadmap) pour les fonctionnalités à venir.


## Implication
### Communauté
Vous pouvez rejoindre le [Discord](https://httpc.dev/discord) et suivre le développement, discuter des contributions, recevoir du support ou demander de l’aide. La participation aux [discussions Github](https://httpc.dev/discuss) est également possible.

### Signaler un problème
Pour tout bug, demande de fonctionnalité ou proposition, vous pouvez [signaler un problème](https://httpc.dev/issues/new). Tous les problèmes sont disponibles sur [Github](https://httpc.dev/issues).

### Contribution
Toutes les contributions sont les bienvenues. Toute PR, problème et retour est apprécié. Consultez le [guide de contribution](https://httpc.dev/contribute).


## Licence
MIT © [Giuseppe La Torre](https://github.com/giuseppelt)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---