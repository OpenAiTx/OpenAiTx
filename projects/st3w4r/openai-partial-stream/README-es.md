# Analizar flujo JSON parcial - Convierte tu aplicación de IA lenta en una aplicación atractiva en tiempo real

- Convierte un **flujo de tokens** en un objeto **JSON analizables** antes de que termine el flujo.
- Implementa una **interfaz de usuario en streaming** en aplicaciones de IA basadas en **LLM**.
- Aprovecha la **llamada a funciones de OpenAI** para el procesamiento temprano del flujo.
- Analiza **flujos JSON** en **entidades** distintas.
- Involucra a tus usuarios con una experiencia en **tiempo real**.

![json_stream_color](https://github.com/st3w4r/openai-partial-stream/assets/4228332/04c4bdfc-d991-4ad0-85fc-04eb35b106f3)

## Sigue el trabajo

- [✖️ Twitter](https://twitter.com/YanaelBarbier)
- [🧵 Threads](https://www.threads.net/@yanaelbarbier)
- [📰 Blog](https://yanael.io/subscribe/)

## Instalar

Para instalar dependencias:

```bash
npm install --save openai-partial-stream
```

## Uso con flujo simple

Convierte un flujo de tokens en un objeto JSON analizables tan pronto como sea posible.

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
Salida:


```js
{ index: 0, status: 'PARTIAL', data: {} }
{ index: 0, status: 'PARTIAL', data: { sentence: '' } }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hello' } }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hello,' } }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hello, world' } }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hello, world!' } }
{ index: 0, status: 'COMPLETED', data: { sentence: 'Hello, world!' } }
```

## Uso con análisis de flujo y entidad

Valide los datos contra un esquema y solo devuelva los datos cuando sean válidos.

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
Salida:


```js
{ index: 0, status: 'PARTIAL', data: {}, entity: 'sentence' }
{ index: 0, status: 'PARTIAL', data: { sentence: '' }, entity: 'sentence' }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hi' }, entity: 'sentence' }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hi,' }, entity: 'sentence' }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hi, world' }, entity: 'sentence' }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hi, world!' }, entity: 'sentence' }
{ index: 0, status: 'COMPLETED', data: { sentence: 'Hi, world!' }, entity: 'sentence'}
```

## Uso con análisis de flujo y entidad con múltiples entidades

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
Salida:


```js
{ index: 0, status: 'COMPLETED', data: { name: 'Los Angeles', postcode: '90001', population: 3971883 }, entity: 'postcodes' }
{ index: 1, status: 'COMPLETED', data: { name: 'San Francisco', postcode: '94102', population: 883305 }, entity: 'postcodes' }
{ index: 2, status: 'COMPLETED', data: { name: 'San Diego', postcode: '92101', population: 1425976 }, entity: 'postcodes'}
```

# Modos

Seleccione un modo de la lista a continuación que mejor se adapte a sus requisitos:

1. **NoStream**
2. **StreamObject**
3. **StreamObjectKeyValue**
4. **StreamObjectKeyValueTokens**

---

### NoStream

Los resultados se devuelven solo después de que se completa toda la consulta.

| **Detalles de NoStream**                                        |
| --------------------------------------------------------------- |
| ✅ Una sola consulta recupera todos los datos                   |
| ✅ Reduce el tráfico de red                                     |
| ⚠️ La experiencia del usuario puede verse comprometida por tiempos de espera prolongados |

---

### StreamObject

Se genera un evento por cada elemento en la lista. Los elementos aparecen a medida que están listos.

| **Detalles de StreamObject**                                         |
| ------------------------------------------------------------------- |
| ✅ Cada mensaje corresponde a un elemento completamente formado     |
| ✅ Menos mensajes                                                   |
| ✅ Todos los campos esenciales se reciben de una vez               |
| ⚠️ Algo de retraso: los usuarios deben esperar hasta que un elemento esté completamente listo para actualizar la interfaz de usuario |

---

### StreamObjectKeyValue

Los objetos se reciben en fragmentos: tanto una clave como su valor correspondiente se envían juntos.

| **Detalles de StreamObjectKeyValue**                          |
| ------------------------------------------------------------- |
| ✅ Los usuarios pueden interactuar con partes de la interfaz  |
| ✅ Soporta actualizaciones más regulares de la interfaz       |
| ⚠️ Mayor tráfico de red                                        |
| ⚠️ Desafíos para aplicar claves debido a objetos incompletos  |

---

### StreamObjectKeyValueTokens

Las claves se reciben completas, mientras que los valores se entregan por partes hasta completarse. Este método ofrece actualizaciones de la interfaz token por token.

| **Detalles de StreamObjectKeyValueToken**                           |
| ------------------------------------------------------------------- |
| ✅ Ofrece una experiencia de usuario dinámica                       |
| ✅ Permite el consumo de contenido paso a paso                      |
| ✅ Disminuye los tiempos de espera del usuario                      |
| ⚠️ Posibles inconsistencias en la interfaz debido a la llegada incremental de valores |
| ⚠️ Incremento del tráfico de red                                     |

## Demo

Transmisión progresiva de objetos JSON por pares clave-valor:

https://github.com/st3w4r/openai-partial-stream/assets/4228332/55643614-b92b-4b1f-9cf9-e60d6d783a0c

Transmisión en tiempo real de objetos JSON:

https://github.com/st3w4r/openai-partial-stream/assets/4228332/73289d38-8526-46cf-a68c-ac80019092ab

## Referencias

[paquete npm](https://www.npmjs.com/package/openai-partial-stream)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-18

---