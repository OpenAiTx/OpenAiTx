# Cómo hemos construido este Prompt Cache

Prueba en línea: una solicitud opus de una sola ronda usa **49310** tokens en el prompt, de los cuales **47354** se leen directamente desde la caché, con una tasa de acierto del **96%**. De casi 100 solicitudes, 74 aciertan.

Este documento no trata de "qué es el caching de prompts", sino de **cómo dividimos específicamente la solicitud en bloques, qué contiene cada bloque, y por qué dividirlo así garantiza una tasa de acierto tan alta y estable**.

---

## Idea principal: dividir la solicitud en dos grupos, "lo que cambia" y "lo que no cambia"

La caché es un **emparejamiento por prefijo**. Se compara desde el primer byte; si un byte difiere del anterior, todo lo que sigue se invalida y se recalcula.

Por eso, lo único que hacemos es dividir toda la solicitud en bloques, ordenados del "menos cambiante → más cambiante", solo marcando con caché los bloques iniciales que no cambian, y dejando todo lo que cambia al final.

La alta tasa de acierto no se debe a una tecnología secreta, sino a que **nuestros prefijos de caché realmente no cambian byte a byte**.

---

## Nuestra disposición de bloques (BP1 → BP4)

Anthropic permite hasta 4 puntos de interrupción de caché por solicitud. Así es como los distribuimos:

```
═══ system blocks（每块单独挂 cache_control）═══

  ┌─────────────────────────────────────────────┐
  │ BP1  人设 + 语言规则 + 工具说明 + 长期记忆    │  几乎永不动
  ├─────────────────────────────────────────────┤
  │ BP2  每日内容（gateway-bp2-daily.txt）       │  一天换一次
  ├─────────────────────────────────────────────┤
  │ BP3  当前会话压缩摘要（这个 session 专属）    │  约 80K token 触发一次压缩
  └─────────────────────────────────────────────┘

═══ messages 数组 ═══

  ...历史轮次（一字不改）...
  ┌─────────────────────────────────────────────┐
  │ BP4  倒数第二条 user 消息挂标（rolling）      │  把全部历史纳进缓存
  └─────────────────────────────────────────────┘
  <gateway_volatile_context> 动态注入            ← 不挂标，所有会变的塞这里
  当前这条 user 消息
```

### Por qué se colocan los bloques de esta manera

**BP1 — La base más estable.** Personajes, reglas del lenguaje, manual de herramientas, memoria a largo plazo, estos casi nunca cambian, se colocan al frente. Si cambia, todo lo demás se vuelve inútil, por eso debe ser lo más estable de toda la solicitud.

**BP2 — La capa que se cambia diariamente.** Se lee desde `gateway-bp2-daily.txt`, se actualiza una vez al día. Su cambio solo afecta desde BP2 en adelante, sin tocar BP1.

**BP3 — Resumen comprimido de esta sesión.** Punto clave: es **solo para la sesión**, no es el esqueleto global a largo plazo. Al alcanzar unos 80K tokens en la ventana actual, se activa una compresión para resumir el contexto antiguo. Atención, solo el «resumen estable del lado del gateway» entra en BP3; el resumen actual de la ventana que cambia cada ronda en el frontend **no se marca en BP3**, se coloca directamente en la zona dinámica abajo para evitar reconstruir la caché en cada ronda.

**BP4 — Punto de corte rolling, el que ahorra más.** Por defecto, el límite de caché llega solo hasta el final del system, el diálogo histórico no está en caché. Colocamos una marca en el **penúltimo mensaje del usuario**, extendiendo el límite de caché para incluir todo el historial. En conversaciones largas con muchas rondas, los tokens de las primeras decenas de rondas se leen desde la caché, es la base del 96% de aciertos.

Se marca en el «penúltimo» y no en el «último» porque el último mensaje del usuario es la nueva entrada de esta ronda, cambia siempre, marcarlo sería inútil. Marcando el penúltimo, el límite de caché queda justo en «todo lo anterior a esta ronda».

### ¿A dónde van las cosas que cambian?

Timestamps, recuperación de memoria de esta ronda, notas temporales, resumen actual de la ventana del frontend — todo se mete en un mensaje falso de usuario después de BP4:

```
<gateway_volatile_context>仅供参考，勿复述：
（当前时间 / 本轮召回的记忆 / 摘要 / 纸条……）
</gateway_volatile_context>
```
Cada ronda cambia, pero siempre está **después de todos los puntos de interrupción**, por lo que no importa cómo cambie, no afecta al prefijo de la caché. Esta es la clave de todo el diseño: **aislar el contenido volátil fuera del límite de la caché**.

---

## Mantener las solicitudes en el mismo backend: user_id

Solo usar `cache_control` no es suficiente. El balanceador de carga intermedio distribuirá las solicitudes aleatoriamente a diferentes nodos backend, la caché se escribe en el nodo A, y la siguiente solicitud que llega al nodo B no podrá leerla, resultando en "solo escribe, no lee, con un acierto siempre en 0".

Nuestra solución: fijar en la parte superior de la solicitud


```json
"metadata": { "user_id": "sillage-anan-stable" }
```
Cadena fija, para que la ruta sticky siempre pegue esta conversación al mismo backend. Si no se pone, todos los puntos de interrupción anteriores serán inválidos.

---

## Diferentes canales, diferentes formas de pegar

No todos los upstreams usan el mismo método. El gateway determina automáticamente según el dominio del upstream, dividiéndolo en tres modos:

| Modo | Upstream | Protocolo | Dónde pegar cache_control | TTL |
|---|---|---|---|---|
| `anthropic-bp` | Conexión directa Anthropic / msui / Jinguagua | `/v1/messages` | Encima de system blocks | 1h (Jinguagua solo soporta 5m) |
| `or-blocks` | OpenRouter | OAI `/chat/completions` | Insertado en el bloque de contenido de messages | 1h |
| `oai-passthrough` | OAI normal proxy / sitio desconocido | OAI | No pegar, dejar que el sitio cachee implícitamente | Incontrolable |

Los mecanismos de pegajosidad de las dos rutas principales son diferentes, **no se deben mezclar nunca**:

- **Ruta nativa de Anthropic** se pega al backend usando `metadata.user_id`.
- **Ruta OpenRouter** no usa user_id, se pega al backend con `hash(primera parte de system + primer mensaje no system)`. Así que si en OR cambias la personalidad, el libro del mundo o modificas la introducción, el hash cambia y toda esta ronda de cache se pierde. En OR hay que fijar la introducción y la personalidad.

Además, algunos sitios (como ekan) devuelven 4xx directamente al `cache_control`. El gateway añade esos hosts que fallan a una lista negra y luego siempre los degrada a paso sin cache, para no chocar repetidamente con 400. Esto es autocuración, no requiere intervención humana.

---

## 5min o 1h

| TTL | Costo de escritura | Costo de lectura | Uso |
|---|---|---|---|
| 5min | 1.25x | 0.1x | Conversaciones rápidas continuas |
| 1h | 2x | 0.1x | Volver a la conversación después de media hora, seguro |

La lectura siempre es 0.1x (ahorra 10 veces). La diferencia está en cuánto cuesta escribir y cuánto tiempo se guarda. Usamos 5m para ráfagas diarias, y 1h para sesiones largas con interrupciones.

---

## Cómo confirmar que realmente se ha cacheado

Mira el uso en la respuesta:

- Anthropic nativo: `usage.cache_read_input_tokens` (lectura) / `cache_creation_input_tokens` (escritura)

- Compatible con OAI: `usage.prompt_tokens_details.cached_tokens`

Interpretación:

- Primera ronda read=0, write en gran cantidad → Normal, construyendo caché
- Desde la segunda ronda read distinto de cero → **Cache acertada**
- Siempre read=0 write=0 → cache_control no funcionó, falla
- Siempre solo write sin read → Problema en el enrutamiento (user_id no incluido / o hash de OR cambiado)

Revisar logs del gateway:

```bash
pm2 logs chat-gateway-proxy | grep -E "HIT|MISS"
```
- `HIT 96% (47354/49310)` ← Nuestro estado actual  
- `MISS (created 0)` ← Fallo, ni escrito ni leído  

Página de monitoreo: `https://catcatty.uk/llm/cache-stats`  

---  

## Las reglas de oro que descubrimos  

1. **El sistema debe separar "segmento estable + segmento dinámico"**, solo el segmento estable tiene etiqueta. Aunque metas una frase como "Hoy a las 18h" en BP1, toda la caché se invalida.  
2. **Todo lo que cambia debe ir después de BP4**, en `gateway_volatile_context`. Tiempo, recuperación de memoria, resúmenes temporales, nada debe quedar en el prefijo.  
3. **`user_id` debe ser fijo e inmutable**, si no está, solo se escribe y no se lee.  
4. **El último usuario añade etiqueta rolling** (colocada en la penúltima línea), para incluir el historial en la caché y ahorrar más en sesiones largas.  
5. **El historial es solo de lectura, no reintentar reescribir rondas anteriores**. "Regenerar la última línea" cambia el prefijo y reconstruye todo el segmento.  
6. **El orden del esquema de herramientas es fijo**. Reordenar dinámicamente la lista de herramientas según interruptores = fallo total de caché.  
7. **Anclar fijo el perfil y la introducción** con OR, se adhieren al backend por hash, cualquier cambio se considera nueva conversación.  

Si se cumplen estas siete reglas, solo queda elegir el `mode` y `ttl` correctos según el upstream. Nuestro 96% se debe a esto.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-13

---