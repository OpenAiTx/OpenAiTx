# Analyse partielle de flux JSON - Transformez votre application IA lente en une application interactive en temps réel

- Convertissez un **flux de tokens** en un objet **JSON analysable** avant la fin du flux.
- Implémentez une **interface utilisateur en streaming** dans une application IA basée sur **LLM**.
- Exploitez **OpenAI Function Calling** pour un traitement précoce du flux.
- Analysez les **flux JSON** en **entités** distinctes.
- Engagez vos utilisateurs avec une expérience **en temps réel**.

![json_stream_color](https://github.com/st3w4r/openai-partial-stream/assets/4228332/04c4bdfc-d991-4ad0-85fc-04eb35b106f3)

## Suivez le travail

- [✖️ Twitter](https://twitter.com/YanaelBarbier)
- [🧵 Threads](https://www.threads.net/@yanaelbarbier)
- [📰 Blog](https://yanael.io/subscribe/)

## Installation

Pour installer les dépendances :

```bash
npm install --save openai-partial-stream
```

## Utilisation avec un flux simple

Transformez un flux de jetons en un objet JSON analysable dès que possible.

```javascript
import OpenAi from "openai";
import { OpenAiHandler, StreamMode } from "openai-partial-stream";

// Set your OpenAI API key as an environment variable: OPENAI_API_KEY
const openai = new OpenAi({ apiKey: process.env.OPENAI_API_KEY });

const stream = await openai.chat.completions.create({
  messages: [{ role: "system", content: "Say hello to the world." }],
  model: "gpt-3.5-turbo", // OR "gpt-4"
  stream: true, // ENABLE STREAMING
  temperature: 1,
  functions: [
    {
      name: "say_hello",
      description: "say hello",
      parameters: {
        type: "object",
        properties: {
          sentence: {
            type: "string",
            description: "The sentence generated",
          },
        },
      },
    },
  ],
  function_call: { name: "say_hello" },
});

const openAiHandler = new OpenAiHandler(StreamMode.StreamObjectKeyValueTokens);
const entityStream = openAiHandler.process(stream);

for await (const item of entityStream) {
  console.log(item);
}
```
Sortie :


```js
{ index: 0, status: 'PARTIAL', data: {} }
{ index: 0, status: 'PARTIAL', data: { sentence: '' } }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hello' } }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hello,' } }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hello, world' } }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hello, world!' } }
{ index: 0, status: 'COMPLETED', data: { sentence: 'Hello, world!' } }
```

## Utilisation avec le flux et l'analyse d'entité

Validez les données par rapport à un schéma et ne renvoyez les données que lorsqu'elles sont valides.

```javascript
import { z } from "zod";
import OpenAi from "openai";
import { OpenAiHandler, StreamMode, Entity } from "openai-partial-stream";

// Set your OpenAI API key as an environment variable: OPENAI_API_KEY
const openai = new OpenAi({ apiKey: process.env.OPENAI_API_KEY });

const stream = await openai.chat.completions.create({
  messages: [{ role: "system", content: "Say hello to the world." }],
  model: "gpt-3.5-turbo", // OR "gpt-4"
  stream: true, // ENABLE STREAMING
  temperature: 1,
  functions: [
    {
      name: "say_hello",
      description: "say hello",
      parameters: {
        type: "object",
        properties: {
          sentence: {
            type: "string",
            description: "The sentence generated",
          },
        },
      },
    },
  ],
  function_call: { name: "say_hello" },
});

const openAiHandler = new OpenAiHandler(StreamMode.StreamObjectKeyValueTokens);
const entityStream = openAiHandler.process(stream);

// Entity Parsing to validate the data
const HelloSchema = z.object({
  sentence: z.string().optional(),
});

const entityHello = new Entity("sentence", HelloSchema);
const helloEntityStream = entityHello.genParse(entityStream);

for await (const item of helloEntityStream) {
  console.log(item);
}
```
Sortie :


```js
{ index: 0, status: 'PARTIAL', data: {}, entity: 'sentence' }
{ index: 0, status: 'PARTIAL', data: { sentence: '' }, entity: 'sentence' }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hi' }, entity: 'sentence' }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hi,' }, entity: 'sentence' }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hi, world' }, entity: 'sentence' }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hi, world!' }, entity: 'sentence' }
{ index: 0, status: 'COMPLETED', data: { sentence: 'Hi, world!' }, entity: 'sentence'}
```

## Utilisation avec le flux et l'analyse d'entités multiples

```javascript
import { z } from "zod";
import OpenAi from "openai";
import { OpenAiHandler, StreamMode, Entity } from "openai-partial-stream";

// Intanciate OpenAI client with your API key
const openai = new OpenAi({
  apiKey: process.env.OPENAI_API_KEY,
});

const PostcodeSchema = z.object({
  name: z.string().optional(),
  postcode: z.string().optional(),
  population: z.number().optional(),
});

// Call the API with stream enabled and a function
const stream = await openai.chat.completions.create({
  messages: [
    {
      role: "system",
      content: "Give me 3 cities and their postcodes in California.",
    },
  ],
  model: "gpt-3.5-turbo", // OR "gpt-4"
  stream: true, // ENABLE STREAMING
  temperature: 1.1,
  functions: [
    {
      name: "set_postcode",
      description: "Set a postcode and a city",
      parameters: {
        type: "object",
        properties: {
          // The name of the entity
          postcodes: {
            type: "array",
            items: {
              type: "object",
              properties: {
                name: {
                  type: "string",
                  description: "Name of the city",
                },
                postcode: {
                  type: "string",
                  description: "The postcode of the city",
                },
                population: {
                  type: "number",
                  description: "The population of the city",
                },
              },
            },
          },
        },
      },
    },
  ],
  function_call: { name: "set_postcode" },
});

// Select the mode of the stream parser
// - StreamObjectKeyValueTokens: (REALTIME)     Stream of JSON objects, key value pairs and tokens
// - StreamObjectKeyValue:       (PROGRESSIVE)  Stream of JSON objects and key value pairs
// - StreamObject:               (ONE-BY-ONE)   Stream of JSON objects
// - NoStream:                   (ALL-TOGETHER) All the data is returned at the end of the process
const mode = StreamMode.StreamObject;

// Create an instance of the handler
const openAiHandler = new OpenAiHandler(mode);
// Process the stream
const entityStream = openAiHandler.process(stream);
// Create an entity with the schema to validate the data
const entityPostcode = new Entity("postcodes", PostcodeSchema);
// Parse the stream to an entity, using the schema to validate the data
const postcodeEntityStream = entityPostcode.genParseArray(entityStream);

// Iterate over the stream of entities
for await (const item of postcodeEntityStream) {
  if (item) {
    // Display the entity
    console.log(item);
  }
}
```
Sortie :


```js
{ index: 0, status: 'COMPLETED', data: { name: 'Los Angeles', postcode: '90001', population: 3971883 }, entity: 'postcodes' }
{ index: 1, status: 'COMPLETED', data: { name: 'San Francisco', postcode: '94102', population: 883305 }, entity: 'postcodes' }
{ index: 2, status: 'COMPLETED', data: { name: 'San Diego', postcode: '92101', population: 1425976 }, entity: 'postcodes'}
```

# Modes

Sélectionnez un mode dans la liste ci-dessous qui correspond le mieux à vos besoins :

1. **NoStream**
2. **StreamObject**
3. **StreamObjectKeyValue**
4. **StreamObjectKeyValueTokens**

---

### NoStream

Les résultats sont renvoyés uniquement après la fin complète de la requête.

| **Détails NoStream**                                             |
| ---------------------------------------------------------------- |
| ✅ Une seule requête récupère toutes les données                  |
| ✅ Réduit le trafic réseau                                        |
| ⚠️ L'expérience utilisateur peut être affectée par des temps d'attente prolongés |

---

### StreamObject

Un événement est généré pour chaque élément de la liste. Les éléments apparaissent au fur et à mesure qu'ils sont prêts.

| **Détails StreamObject**                                                        |
| ------------------------------------------------------------------------------- |
| ✅ Chaque message correspond à un élément entièrement formé                      |
| ✅ Moins de messages                                                            |
| ✅ Tous les champs essentiels sont reçus en une seule fois                      |
| ⚠️ Un certain délai : les utilisateurs doivent attendre qu’un élément soit entièrement prêt pour mettre à jour l’interface |

---

### StreamObjectKeyValue

Les objets sont reçus en fragments : à la fois une clé et sa valeur correspondante sont envoyées ensemble.

| **Détails StreamObjectKeyValue**                          |
| --------------------------------------------------------- |
| ✅ Les utilisateurs peuvent interagir avec des parties de l’interface utilisateur               |
| ✅ Prend en charge des mises à jour UI plus régulières                       |
| ⚠️ Trafic réseau plus élevé                                 |
| ⚠️ Difficultés à appliquer les clés en raison d’objets incomplets |

---

### StreamObjectKeyValueTokens

Les clés sont reçues en intégralité, tandis que les valeurs sont livrées progressivement jusqu’à leur complétion. Cette méthode offre une mise à jour UI token par token.

| **Détails StreamObjectKeyValueToken**                               |
| ------------------------------------------------------------------- |
| ✅ Offre une expérience utilisateur dynamique                                 |
| ✅ Permet une consommation de contenu étape par étape                         |
| ✅ Réduit le temps d’attente utilisateur                                     |
| ⚠️ Possibles incohérences UI dues à l’arrivée incrémentale des valeurs |
| ⚠️ Trafic réseau augmenté                                        |

## Démo

Flux d’objet JSON progressif par paires clé-valeur :

https://github.com/st3w4r/openai-partial-stream/assets/4228332/55643614-b92b-4b1f-9cf9-e60d6d783a0c

Flux d’objets JSON en temps réel :

https://github.com/st3w4r/openai-partial-stream/assets/4228332/73289d38-8526-46cf-a68c-ac80019092ab

## Références

[paquet npm](https://www.npmjs.com/package/openai-partial-stream)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-18

---