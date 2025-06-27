<p align="right">
   <strong>Español</strong> | <a href="./.github/README.cn.md">中文</a> | <a href="./.github/README.jp.md">日本語</a>
</p>

<div align="center">

<a href="https://portkey.sh/report-github"><img src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Frame.png"></img></a>
<br>

# AI Gateway
#### Conecta con más de 250 LLMs con una API rápida y amigable

<img src="https://cfassets.portkey.ai/sdk.gif" width="550px" alt="Demostración de Portkey AI Gateway mostrando capacidades de enrutamiento LLM" style="margin-left:-35px">

[Docs](https://portkey.wiki/gh-1) | [Enterprise](https://portkey.wiki/gh-2) | [Hosted Gateway](https://portkey.wiki/gh-3) | [Changelog](https://portkey.wiki/gh-4) | [API Reference](https://portkey.wiki/gh-5)


[![License](https://img.shields.io/github/license/Ileriayo/markdown-badges)](./LICENSE)
[![Discord](https://img.shields.io/discord/1143393887742861333)](https://portkey.wiki/gh-6)
[![Twitter](https://img.shields.io/twitter/url/https/twitter/follow/portkeyai?style=social&label=Follow%20%40PortkeyAI)](https://portkey.wiki/gh-7)
[![npm version](https://badge.fury.io/js/%40portkey-ai%2Fgateway.svg)](https://portkey.wiki/gh-8)
[![Better Stack Badge](https://uptime.betterstack.com/status-badges/v1/monitor/q94g.svg)](https://portkey.wiki/gh-9)

<a href="https://us-east-1.console.aws.amazon.com/cloudformation/home?region=us-east-1#/stacks/quickcreate?stackName=portkey-gateway&templateURL=https://portkey-gateway-ec2-quicklaunch.s3.us-east-1.amazonaws.com/portkey-gateway-ec2-quicklaunch.template.yaml"><img src="https://img.shields.io/badge/Deploy_to_EC2-232F3E?style=for-the-badge&logo=amazonwebservices&logoColor=white" alt="Deploy to AWS EC2" width="105"/></a> [![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/Portkey-AI/gateway)
</div>

<br/>

El [**AI Gateway**](https://portkey.wiki/gh-10) está diseñado para un enrutamiento rápido, confiable y seguro a más de 1600 modelos de lenguaje, visión, audio e imagen. Es una solución ligera, de código abierto y lista para empresas que permite integrarse con cualquier modelo de lenguaje en menos de 2 minutos.

- [x] **Extremadamente rápido** (<1ms de latencia) con un tamaño mínimo (122kb)
- [x] **Probado en batalla**, con más de 10 mil millones de tokens procesados cada día
- [x] **Listo para empresas** con seguridad mejorada, escalabilidad y despliegues personalizados

<br>

#### ¿Qué puedes hacer con AI Gateway?
- Integrarte con cualquier LLM en menos de 2 minutos - [Inicio rápido](#quickstart-2-mins)
- Prevenir caídas con **[reintentos automáticos](https://portkey.wiki/gh-11)** y **[fallbacks](https://portkey.wiki/gh-12)**
- Escalar aplicaciones de IA con **[balanceo de carga](https://portkey.wiki/gh-13)** y **[enrutamiento condicional](https://portkey.wiki/gh-14)**
- Proteger tus despliegues de IA con **[guardrails](https://portkey.wiki/gh-15)**
- Ir más allá del texto con **[capacidades multimodales](https://portkey.wiki/gh-16)**
- Finalmente, explora integraciones de **[workflow agente](https://portkey.wiki/gh-17)**

<br><br>

> [!TIP]
> Marcar este repositorio con una estrella ayuda a que más desarrolladores descubran AI Gateway 🙏🏻
>
> ![star-2](https://github.com/user-attachments/assets/53597dce-6333-4ecc-a154-eb05532954e4)
> 
<br>


<br>

## Inicio rápido (2 min)

### 1. Configura tu AI Gateway

```bash
# Ejecuta el gateway localmente (requiere Node.js y npm)
npx @portkey-ai/gateway
```
> El Gateway está corriendo en `http://localhost:8787/v1`
> 
> La Consola del Gateway está corriendo en `http://localhost:8787/public/`

<sup>
Guías de despliegue:
&nbsp; <a href="https://portkey.wiki/gh-18"><img height="12" width="12" src="https://cfassets.portkey.ai/logo/dew-color.svg" /> Portkey Cloud (Recomendado)</a>
&nbsp; <a href="./docs/installation-deployments.md#docker"><img height="12" width="12" src="https://cdn.simpleicons.org/docker/3776AB" /> Docker</a>
&nbsp; <a href="./docs/installation-deployments.md#nodejs-server"><img height="12" width="12" src="https://cdn.simpleicons.org/node.js/3776AB" /> Node.js</a>
&nbsp; <a href="./docs/installation-deployments.md#cloudflare-workers"><img height="12" width="12" src="https://cdn.simpleicons.org/cloudflare/3776AB" /> Cloudflare</a>
&nbsp; <a href="./docs/installation-deployments.md#replit"><img height="12" width="12" src="https://cdn.simpleicons.org/replit/3776AB" /> Replit</a>
&nbsp; <a href="./docs/installation-deployments.md"> Otros...</a>

</sup>

### 2. Haz tu primera solicitud

<!-- <details open>
<summary>Python Example</summary> -->
```python
# pip install -qU portkey-ai

from portkey_ai import Portkey

# Cliente compatible con OpenAI
client = Portkey(
    provider="openai", # o 'anthropic', 'bedrock', 'groq', etc
    Authorization="sk-***" # la API key del proveedor
)

# Realiza una solicitud a través de tu AI Gateway
client.chat.completions.create(
    messages=[{"role": "user", "content": "¿Cómo está el clima?"}],
    model="gpt-4o-mini"
)
```



<sup>Librerías soportadas:
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/javascript/3776AB" /> JS](https://portkey.wiki/gh-19)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/python/3776AB" /> Python](https://portkey.wiki/gh-20)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/gnubash/3776AB" /> REST](https://portkey.sh/gh-84)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/openai/3776AB" /> SDKs OpenAI](https://portkey.wiki/gh-21)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/langchain/3776AB" /> Langchain](https://portkey.wiki/gh-22)
&nbsp; [LlamaIndex](https://portkey.wiki/gh-23)
&nbsp; [Autogen](https://portkey.wiki/gh-24)
&nbsp; [CrewAI](https://portkey.wiki/gh-25)
&nbsp; [Más..](https://portkey.wiki/gh-26)
</sup>

En la Consola del Gateway (`http://localhost:8787/public/`) puedes ver todos tus logs locales en un solo lugar.

<img src="https://github.com/user-attachments/assets/362bc916-0fc9-43f1-a39e-4bd71aac4a3a" width="400" />


### 3. Enrutamiento y Guardrails
Las `Configs` en el gateway LLM te permiten crear reglas de enrutamiento, añadir confiabilidad y establecer guardrails.
```python
config = {
  "retry": {"attempts": 5},

  "output_guardrails": [{
    "default.contains": {"operator": "none", "words": ["Apple"]},
    "deny": True
  }]
}

# Adjunta la config al cliente
client = client.with_options(config=config)

client.chat.completions.create(
    model="gpt-4o-mini",
    messages=[{"role": "user", "content": "Responde aleatoriamente con Apple o Bat"}]
)

# Esto siempre responderá con "Bat" ya que el guardrail deniega todas las respuestas que contengan "Apple". La configuración de reintentos hará 5 intentos antes de rendirse.
```
<div align="center">
<img src="https://portkey.ai/blog/content/images/size/w1600/2024/11/image-15.png" width=600 title="Flujo de solicitud a través del AI gateway de Portkey con reintentos y guardrails" alt="Flujo de solicitud a través del AI gateway de Portkey con reintentos y guardrails"/>
</div>

Puedes hacer mucho más con las configs en tu AI gateway. [Ir a ejemplos  →](https://portkey.wiki/gh-27)

<br/>

### Versión Enterprise (Despliegues privados)

<sup>

[<img height="12" width="12" src="https://cfassets.portkey.ai/amazon-logo.svg" /> AWS](https://portkey.wiki/gh-28)
&nbsp; [<img height="12" width="12" src="https://cfassets.portkey.ai/azure-logo.svg" /> Azure](https://portkey.wiki/gh-29)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/googlecloud/3776AB" /> GCP](https://portkey.wiki/gh-30)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/redhatopenshift/3776AB" /> OpenShift](https://portkey.wiki/gh-31)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/kubernetes/3776AB" /> Kubernetes](https://portkey.wiki/gh-85)

</sup>

La [versión enterprise](https://portkey.wiki/gh-86) del LLM Gateway ofrece capacidades avanzadas para **gestión de organizaciones**, **gobernanza**, **seguridad** y [más](https://portkey.wiki/gh-87) listas para usar. [Ver comparación de funcionalidades →](https://portkey.wiki/gh-32)

La arquitectura de despliegue enterprise para plataformas soportadas está disponible aquí - [**Despliegues Privados en la Nube Enterprise**](https://portkey.wiki/gh-33)

<a href="https://portkey.sh/demo-13"><img src="https://portkey.ai/blog/content/images/2024/08/Get-API-Key--5-.png" height=50 alt="Reserva una demo del AI gateway enterprise" /></a><br/>


<br>

<hr>

### AI Engineering Hours

¡Únete a las llamadas semanales de la comunidad cada viernes (8 AM PT) para comenzar tu implementación de AI Gateway! [Cada viernes](https://portkey.wiki/gh-35)

<a href="https://portkey.wiki/gh-35"><img width="500" src="https://github.com/user-attachments/assets/c2885699-f197-4289-b819-21eb839fbae1" /></a>

Minutas de reuniones [publicadas aquí](https://portkey.wiki/gh-36).


<hr>

### LLMs en Producción '25

Perspectivas del análisis de más de 2 billones de tokens, en más de 90 regiones y 650 equipos en producción. Qué esperar de este informe:
- Tendencias que dan forma a la adopción de IA y el crecimiento de proveedores LLM.
- Benchmarks para optimizar velocidad, coste y confiabilidad.
- Estrategias para escalar sistemas de IA de grado de producción.

<a href="https://portkey.sh/report-github"><img width="500" src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Image.png" /></a>

<a href="https://portkey.sh/report-github">**Obtén el informe**</a>
<hr>


## Funcionalidades principales
### Enrutamiento confiable
- <a href="https://portkey.wiki/gh-37">**Fallbacks**</a>: Cambio automático a otro proveedor o modelo en caso de solicitudes fallidas usando el gateway LLM. Puedes especificar los errores que activarán el fallback. Mejora la confiabilidad de tu aplicación.
- <a href="https://portkey.wiki/gh-38">**Reintentos Automáticos**</a>: Reintenta automáticamente las solicitudes fallidas hasta 5 veces. Una estrategia de retroceso exponencial separa los intentos de reintento para evitar la sobrecarga de la red.
- <a href="https://portkey.wiki/gh-39">**Balanceo de Carga**</a>: Distribuye las solicitudes LLM entre varias claves API o proveedores de IA con pesos para asegurar alta disponibilidad y rendimiento óptimo.
- <a href="https://portkey.wiki/gh-40">**Tiempos de Espera en Solicitudes**</a>: Administra LLMs problemáticos y latencias configurando tiempos de espera granulares, permitiendo la terminación automática de solicitudes que excedan una duración especificada.
- <a href="https://portkey.wiki/gh-41">**Gateway LLM Multimodal**</a>: Llama modelos de visión, audio (texto a voz y voz a texto) y generación de imágenes de múltiples proveedores, todo usando la firma familiar de OpenAI.
- <a href="https://portkey.wiki/gh-42">**APIs en Tiempo Real**</a>: Llama APIs en tiempo real lanzadas por OpenAI a través del servidor de websockets integrado.

### Seguridad y Precisión
- <a href="https://portkey.wiki/gh-88">**Guardrails**</a>: Verifica que las entradas y salidas de tu LLM cumplan con las verificaciones especificadas. Elige entre más de 40 guardrails predefinidos para asegurar el cumplimiento de los estándares de seguridad y precisión. Puedes <a href="https://portkey.wiki/gh-43">traer tus propios guardrails</a> o elegir entre nuestros <a href="https://portkey.wiki/gh-44">muchos socios</a>.
- [**Gestión Segura de Claves**](https://portkey.wiki/gh-45): Usa tus propias claves o genera claves virtuales al instante.
- [**Control de acceso basado en roles**](https://portkey.wiki/gh-46): Control de acceso granular para tus usuarios, espacios de trabajo y claves API.
- <a href="https://portkey.wiki/gh-47">**Cumplimiento y Privacidad de Datos**</a>: El gateway de IA cumple con SOC2, HIPAA, GDPR y CCPA.

### Gestión de Costos
- [**Caché inteligente**](https://portkey.wiki/gh-48): Almacena respuestas de los LLMs para reducir costos y mejorar la latencia. Soporta caché simple y semántico*.
- [**Analítica de uso**](https://portkey.wiki/gh-49): Monitorea y analiza el uso de tu IA y LLM, incluyendo volumen de solicitudes, latencia, costos y tasas de error.
- [**Optimización de Proveedores***](https://portkey.wiki/gh-89): Cambia automáticamente al proveedor más rentable según los patrones de uso y los modelos de precios.

### Colaboración y Flujos de Trabajo
- <a href="https://portkey.ai/docs/integrations/agents">**Soporte para Agentes**</a>: Integra fácilmente con los frameworks de agentes más populares para construir aplicaciones de IA complejas. El gateway se integra sin problemas con [Autogen](https://portkey.wiki/gh-50), [CrewAI](https://portkey.wiki/gh-51), [LangChain](https://portkey.wiki/gh-52), [LlamaIndex](https://portkey.wiki/gh-53), [Phidata](https://portkey.wiki/gh-54), [Control Flow](https://portkey.wiki/gh-55) e incluso [Agentes Personalizados](https://portkey.wiki/gh-56).
- [**Gestión de Plantillas de Prompts***](https://portkey.wiki/gh-57): Crea, gestiona y versiona tus plantillas de prompts colaborativamente a través de un playground universal de prompts.
<br/><br/>

<sup>
*&nbsp;Disponible en versiones alojadas y empresariales
</sup>

<br>

## Recetarios

### ☄️ Tendencias
- Usa modelos de [Nvidia NIM](/cookbook/providers/nvidia.ipynb) con AI Gateway
- Monitorea [Agentes CrewAI](/cookbook/monitoring-agents/CrewAI_with_Telemetry.ipynb) con Portkey
- Compara los [10 mejores modelos LMSYS](/cookbook/use-cases/LMSYS%20Series/comparing-top10-LMSYS-models-with-Portkey.ipynb) con AI Gateway.

### 🚨 Últimos
* [Crea conjuntos de datos sintéticos usando Nemotron](/cookbook/use-cases/Nemotron_GPT_Finetuning_Portkey.ipynb)
* [Utiliza el LLM Gateway con el SDK de IA de Vercel](/cookbook/integrations/vercel-ai.md)
* [Monitorea agentes Llama con el LLM Gateway de Portkey](/cookbook/monitoring-agents/Llama_Agents_with_Telemetry.ipynb)

[Ver todos los recetarios →](https://portkey.wiki/gh-58)
<br/><br/>

## Proveedores Compatibles

Explora las integraciones de Gateway con [más de 45 proveedores](https://portkey.wiki/gh-59) y [más de 8 frameworks de agentes](https://portkey.wiki/gh-90).

|                                                                                                                            | Proveedor                                                                                     | Soporte | Stream |
| -------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | ------- | ------ |
| <img src="docs/images/openai.png" width=35 />                                                                              | [OpenAI](https://portkey.wiki/gh-60)                           | ✅       | ✅      |
| <img src="docs/images/azure.png" width=35>                                                                                 | [Azure OpenAI](https://portkey.wiki/gh-61)               | ✅       | ✅      |
| <img src="docs/images/anyscale.png" width=35>                                                                              | [Anyscale](https://portkey.wiki/gh-62) | ✅       | ✅      |
| <img src="https://upload.wikimedia.org/wikipedia/commons/2/2d/Google-favicon-2015.png" width=35>                           | [Google Gemini](https://portkey.wiki/gh-63)             | ✅       | ✅      |
| <img src="docs/images/anthropic.png" width=35>                                                                             | [Anthropic](https://portkey.wiki/gh-64)                     | ✅       | ✅      |
| <img src="docs/images/cohere.png" width=35>                                                                                | [Cohere](https://portkey.wiki/gh-65)                           | ✅       | ✅      |
| <img src="https://assets-global.website-files.com/64f6f2c0e3f4c5a91c1e823a/654693d569494912cfc0c0d4_favicon.svg" width=35> | [Together AI](https://portkey.wiki/gh-66)                 | ✅       | ✅      |
| <img src="https://www.perplexity.ai/favicon.svg" width=35>                                                                 | [Perplexity](https://portkey.wiki/gh-67)                | ✅       | ✅      |
| <img src="https://docs.mistral.ai/img/favicon.ico" width=35>                                                               | [Mistral](https://portkey.wiki/gh-68)                      | ✅       | ✅      |
| <img src="https://docs.nomic.ai/img/nomic-logo.png" width=35>                                                              | [Nomic](https://portkey.wiki/gh-69)                             | ✅       | ✅      |
| <img src="https://files.readme.io/d38a23e-small-studio-favicon.png" width=35>                                              | [AI21](https://portkey.wiki/gh-91)                                    | ✅       | ✅      |
| <img src="https://platform.stability.ai/small-logo-purple.svg" width=35>                                                   | [Stability AI](https://portkey.wiki/gh-71)               | ✅       | ✅      |
| <img src="https://deepinfra.com/_next/static/media/logo.4a03fd3d.svg" width=35>                                            | [DeepInfra](https://portkey.sh/gh-92)                               | ✅       | ✅      |
| <img src="https://ollama.com/public/ollama.png" width=35>                                                                  | [Ollama](https://portkey.wiki/gh-72)                           | ✅       | ✅      |
| <img src="https://novita.ai/favicon.ico" width=35>                                                                         | [Novita AI](https://portkey.wiki/gh-73)                              | ✅       | ✅      | `/chat/completions`, `/completions` |


> [Consulta la lista completa de más de 200 modelos compatibles aquí](https://portkey.wiki/gh-74)
<br>

<br>

## Agentes
Gateway se integra fácilmente con los frameworks de agentes más populares. [Lee la documentación aquí](https://portkey.wiki/gh-75).


| Framework | Llama a más de 200 LLMs | Enrutamiento avanzado | Caché | Registro y seguimiento* | Observabilidad* | Gestión de Prompts* |
|------------------------------|--------|-------------|---------|------|---------------|-------------------|
| [Autogen](https://portkey.wiki/gh-93)    | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [CrewAI](https://portkey.wiki/gh-94)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [LangChain](https://portkey.wiki/gh-95)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Phidata](https://portkey.wiki/gh-96)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Llama Index](https://portkey.wiki/gh-97)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Control Flow](https://portkey.wiki/gh-98) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Construye tus propios agentes](https://portkey.wiki/gh-99) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |

<br>

*Disponible en la [aplicación alojada](https://portkey.wiki/gh-76). Para documentación detallada [haz clic aquí](https://portkey.wiki/gh-100).


## Versión Empresarial de Gateway
Haz que tu aplicación de IA sea más <ins>confiable</ins> y <ins>compatible a futuro</ins>, asegurando a la vez total <ins>seguridad de datos</ins> y <ins>privacidad</ins>.

✅&nbsp; Gestión segura de claves - para control de acceso basado en roles y seguimiento <br>
✅&nbsp; Caché simple y semántico - para responder consultas repetidas más rápido y ahorrar costos <br>
✅&nbsp; Control de acceso y reglas de entrada - para controlar qué IPs y regiones pueden conectarse a tus despliegues <br>
✅&nbsp; Redacción de PII - para eliminar automáticamente datos sensibles de tus solicitudes y prevenir exposiciones accidentales <br>
✅&nbsp; Cumplimiento SOC2, ISO, HIPAA, GDPR - para mejores prácticas de seguridad <br>
✅&nbsp; Soporte profesional - junto con priorización de funcionalidades <br>

[Agenda una llamada para discutir implementaciones empresariales](https://portkey.sh/demo-13)

<br>


## Contribuir

La forma más fácil de contribuir es elegir un issue con la etiqueta `good first issue` 💪. Lee las pautas de contribución [aquí](/.github/CONTRIBUTING.md).

¿Bug? [Repórtalo aquí](https://portkey.wiki/gh-78) | ¿Solicitud de funcionalidad? [Solicítala aquí](https://portkey.wiki/gh-78)


### Primeros pasos con la comunidad
Únete a nuestras horas semanales de Ingeniería de IA cada viernes (8 AM PT) para:
- Conocer a otros colaboradores y miembros de la comunidad
- Aprender funciones avanzadas de Gateway y patrones de implementación
- Compartir tus experiencias y recibir ayuda
- Mantente actualizado con las prioridades de desarrollo más recientes

[Únete a la próxima sesión →](https://portkey.wiki/gh-101) | [Notas de la reunión](https://portkey.wiki/gh-102)

<br>

## Comunidad

Únete a nuestra comunidad global en crecimiento para obtener ayuda, ideas y debatir sobre IA.

- Visita nuestro [Blog oficial](https://portkey.wiki/gh-78)
- Chatea con nosotros en [Discord](https://portkey.wiki/community)
- Síguenos en [Twitter](https://portkey.wiki/gh-79)
- Conéctate con nosotros en [LinkedIn](https://portkey.wiki/gh-80)
- Lee la documentación en [Japonés](./.github/README.jp.md)
- Visítanos en [YouTube](https://portkey.wiki/gh-103)
- Únete a nuestra [comunidad Dev](https://portkey.wiki/gh-82)
<!-- - Preguntas con la etiqueta #portkey en [Stack Overflow](https://stackoverflow.com/questions/tagged/portkey) -->

![Rubeus Social Share (4)](https://github.com/Portkey-AI/gateway/assets/971978/89d6f0af-a95d-4402-b451-14764c40d03f)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---