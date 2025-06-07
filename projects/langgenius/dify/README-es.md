![cover-v5-optimized](./images/GitHub_README_if.png)

<p align="center">
  📌 <a href="https://dify.ai/blog/introducing-dify-workflow-file-upload-a-demo-on-ai-podcast">Presentamos la carga de archivos en el flujo de trabajo de Dify: Recrea el podcast de Google NotebookLM</a>
</p>

<p align="center">
  <a href="https://cloud.dify.ai">Dify Cloud</a> ·
  <a href="https://docs.dify.ai/getting-started/install-self-hosted">Autoalojamiento</a> ·
  <a href="https://docs.dify.ai">Documentación</a> ·
  <a href="https://dify.ai/pricing">Resumen de ediciones de Dify</a>
</p>

<p align="center">
    <a href="https://dify.ai" target="_blank">
        <img alt="Static Badge" src="https://img.shields.io/badge/Product-F04438"></a>
    <a href="https://dify.ai/pricing" target="_blank">
        <img alt="Static Badge" src="https://img.shields.io/badge/free-pricing?logo=free&color=%20%23155EEF&label=pricing&labelColor=%20%23528bff"></a>
    <a href="https://discord.gg/FngNHpbcY7" target="_blank">
        <img src="https://img.shields.io/discord/1082486657678311454?logo=discord&labelColor=%20%235462eb&logoColor=%20%23f5f5f5&color=%20%235462eb"
            alt="chat on Discord"></a>
    <a href="https://reddit.com/r/difyai" target="_blank">  
        <img src="https://img.shields.io/reddit/subreddit-subscribers/difyai?style=plastic&logo=reddit&label=r%2Fdifyai&labelColor=white"
            alt="join Reddit"></a>
    <a href="https://twitter.com/intent/follow?screen_name=dify_ai" target="_blank">
        <img src="https://img.shields.io/twitter/follow/dify_ai?logo=X&color=%20%23f5f5f5"
            alt="follow on X(Twitter)"></a>
    <a href="https://www.linkedin.com/company/langgenius/" target="_blank">
        <img src="https://custom-icon-badges.demolab.com/badge/LinkedIn-0A66C2?logo=linkedin-white&logoColor=fff"
            alt="follow on LinkedIn"></a>
    <a href="https://hub.docker.com/u/langgenius" target="_blank">
        <img alt="Docker Pulls" src="https://img.shields.io/docker/pulls/langgenius/dify-web?labelColor=%20%23FDB062&color=%20%23f79009"></a>
    <a href="https://github.com/langgenius/dify/graphs/commit-activity" target="_blank">
        <img alt="Commits last month" src="https://img.shields.io/github/commit-activity/m/langgenius/dify?labelColor=%20%2332b583&color=%20%2312b76a"></a>
    <a href="https://github.com/langgenius/dify/" target="_blank">
        <img alt="Issues closed" src="https://img.shields.io/github/issues-search?query=repo%3Alanggenius%2Fdify%20is%3Aclosed&label=issues%20closed&labelColor=%20%237d89b0&color=%20%235d6b98"></a>
    <a href="https://github.com/langgenius/dify/discussions/" target="_blank">
        <img alt="Discussion posts" src="https://img.shields.io/github/discussions/langgenius/dify?labelColor=%20%239b8afb&color=%20%237a5af8"></a>
</p>

<p align="center">
  <a href="./README.md"><img alt="README in English" src="https://img.shields.io/badge/English-d9d9d9"></a>
  <a href="./README_TW.md"><img alt="繁體中文文件" src="https://img.shields.io/badge/繁體中文-d9d9d9"></a>
  <a href="./README_CN.md"><img alt="简体中文版自述文件" src="https://img.shields.io/badge/简体中文-d9d9d9"></a>
  <a href="./README_JA.md"><img alt="日本語のREADME" src="https://img.shields.io/badge/日本語-d9d9d9"></a>
  <a href="./README_ES.md"><img alt="README en Español" src="https://img.shields.io/badge/Español-d9d9d9"></a>
  <a href="./README_FR.md"><img alt="README en Français" src="https://img.shields.io/badge/Français-d9d9d9"></a>
  <a href="./README_KL.md"><img alt="README tlhIngan Hol" src="https://img.shields.io/badge/Klingon-d9d9d9"></a>
  <a href="./README_KR.md"><img alt="README in Korean" src="https://img.shields.io/badge/한국어-d9d9d9"></a>
  <a href="./README_AR.md"><img alt="README بالعربية" src="https://img.shields.io/badge/العربية-d9d9d9"></a>
  <a href="./README_TR.md"><img alt="Türkçe README" src="https://img.shields.io/badge/Türkçe-d9d9d9"></a>
  <a href="./README_VI.md"><img alt="README Tiếng Việt" src="https://img.shields.io/badge/Ti%E1%BA%BFng%20Vi%E1%BB%87t-d9d9d9"></a>
  <a href="./README_DE.md"><img alt="README in Deutsch" src="https://img.shields.io/badge/German-d9d9d9"></a>
  <a href="./README_BN.md"><img alt="README in বাংলা" src="https://img.shields.io/badge/বাংলা-d9d9d9"></a>
</p>

Dify es una plataforma de desarrollo de aplicaciones LLM de código abierto. Su interfaz intuitiva combina flujo de trabajo de IA agentica, canalización RAG, capacidades de agente, gestión de modelos, funciones de observabilidad y más, lo que permite pasar rápidamente de prototipo a producción.

## Inicio rápido

> Antes de instalar Dify, asegúrate de que tu máquina cumpla con los siguientes requisitos mínimos del sistema:
>
> - CPU >= 2 núcleos
> - RAM >= 4 GiB

</br>

La forma más sencilla de iniciar el servidor de Dify es mediante [docker compose](docker/docker-compose.yaml). Antes de ejecutar Dify con los siguientes comandos, asegúrate de tener instalado [Docker](https://docs.docker.com/get-docker/) y [Docker Compose](https://docs.docker.com/compose/install/) en tu máquina:

```bash
cd dify
cd docker
cp .env.example .env
docker compose up -d
```

Después de ejecutar, puedes acceder al panel de Dify en tu navegador en [http://localhost/install](http://localhost/install) y comenzar el proceso de inicialización.

#### Buscando ayuda

Consulta nuestras [Preguntas Frecuentes](https://docs.dify.ai/getting-started/install-self-hosted/faqs) si tienes problemas al configurar Dify. Comunícate con [la comunidad y con nosotros](#community--contact) si sigues teniendo inconvenientes.

> Si deseas contribuir a Dify o realizar desarrollo adicional, consulta nuestra [guía para desplegar desde el código fuente](https://docs.dify.ai/getting-started/install-self-hosted/local-source-code)

## Características clave

**1. Flujo de trabajo**:
Crea y prueba potentes flujos de trabajo de IA en un lienzo visual, aprovechando todas las siguientes funciones y más.

**2. Soporte integral de modelos**:
Integración fluida con cientos de LLMs propietarios y de código abierto de docenas de proveedores de inferencia y soluciones autoalojadas, cubriendo GPT, Mistral, Llama3 y cualquier modelo compatible con la API de OpenAI. Puedes ver la lista completa de proveedores de modelos soportados [aquí](https://docs.dify.ai/getting-started/readme/model-providers).

![providers-v5](https://github.com/langgenius/dify/assets/13230914/5a17bdbe-097a-4100-8363-40255b70f6e3)

**3. IDE de prompts**:
Interfaz intuitiva para crear prompts, comparar el rendimiento de modelos y agregar características adicionales como texto a voz a una aplicación basada en chat.

**4. Canalización RAG**:
Capacidades RAG extensas que cubren todo desde la ingestión de documentos hasta la recuperación, con soporte listo para extracción de texto de PDFs, PPTs y otros formatos comunes de documentos.

**5. Capacidades de agente**:
Puedes definir agentes basados en LLM Function Calling o ReAct, y agregar herramientas preconstruidas o personalizadas para el agente. Dify proporciona más de 50 herramientas integradas para agentes de IA, como Google Search, DALL·E, Stable Diffusion y WolframAlpha.

**6. LLMOps**:
Monitorea y analiza los registros y el rendimiento de la aplicación a lo largo del tiempo. Puedes mejorar continuamente los prompts, conjuntos de datos y modelos en base a datos de producción y anotaciones.

**7. Backend como Servicio**:
Todas las funcionalidades de Dify cuentan con sus respectivas APIs, por lo que puedes integrar Dify fácilmente en tu propia lógica de negocio.

## Comparación de características

<table style="width: 100%;">
  <tr>
    <th align="center">Funcionalidad</th>
    <th align="center">Dify.AI</th>
    <th align="center">LangChain</th>
    <th align="center">Flowise</th>
    <th align="center">OpenAI Assistants API</th>
  </tr>
  <tr>
    <td align="center">Enfoque de programación</td>
    <td align="center">API + Orientado a aplicaciones</td>
    <td align="center">Código Python</td>
    <td align="center">Orientado a aplicaciones</td>
    <td align="center">Orientado a API</td>
  </tr>
  <tr>
    <td align="center">LLMs soportados</td>
    <td align="center">Gran variedad</td>
    <td align="center">Gran variedad</td>
    <td align="center">Gran variedad</td>
    <td align="center">Solo OpenAI</td>
  </tr>
  <tr>
    <td align="center">Motor RAG</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">Agente</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">Flujo de trabajo</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Observabilidad</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Funcionalidad empresarial (SSO/Control de acceso)</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Despliegue local</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
</table>

## Usando Dify

- **Cloud </br>**
  Ofrecemos un servicio [Dify Cloud](https://dify.ai) para que cualquier persona lo pruebe sin configuración. Proporciona todas las capacidades de la versión autoalojada e incluye 200 llamadas gratuitas a GPT-4 en el plan sandbox.

- **Autoalojamiento de Dify Community Edition</br>**
  Pon en marcha Dify rápidamente en tu entorno con esta [guía de inicio rápido](#quick-start).
  Usa nuestra [documentación](https://docs.dify.ai) para referencias adicionales e instrucciones más detalladas.

- **Dify para empresas / organizaciones</br>**
  Ofrecemos funcionalidades adicionales centradas en empresas. [Deja tus preguntas a través de este chatbot](https://udify.app/chat/22L1zSxg6yW1cWQg) o [envíanos un correo electrónico](mailto:business@dify.ai?subject=[GitHub]Business%20License%20Inquiry) para hablar sobre necesidades empresariales. </br>
  > Para startups y pequeñas empresas que usan AWS, revisa [Dify Premium en AWS Marketplace](https://aws.amazon.com/marketplace/pp/prodview-t22mebxzwjhu6) y despliega en tu propio AWS VPC con un solo clic. Es una oferta AMI asequible con opción para crear aplicaciones con logotipo y marca personalizada.

## Mantente al día

Dale una estrella a Dify en GitHub y recibe notificaciones instantáneas de nuevos lanzamientos.

![star-us](https://github.com/langgenius/dify/assets/13230914/b823edc1-6388-4e25-ad45-2f6b187adbb4)

## Configuración avanzada

Si necesitas personalizar la configuración, consulta los comentarios en nuestro archivo [.env.example](docker/.env.example) y actualiza los valores correspondientes en tu archivo `.env`. Además, es posible que debas hacer ajustes en el propio archivo `docker-compose.yaml`, como cambiar versiones de imagen, mapeos de puertos o montajes de volúmenes, según tu entorno y requisitos de despliegue específicos. Después de realizar cualquier cambio, vuelve a ejecutar `docker-compose up -d`. Puedes encontrar la lista completa de variables de entorno disponibles [aquí](https://docs.dify.ai/getting-started/install-self-hosted/environments).

Si deseas configurar un despliegue altamente disponible, existen [Helm Charts](https://helm.sh/) y archivos YAML contribuidos por la comunidad que permiten desplegar Dify en Kubernetes.

- [Helm Chart por @LeoQuote](https://github.com/douban/charts/tree/master/charts/dify)
- [Helm Chart por @BorisPolonsky](https://github.com/BorisPolonsky/dify-helm)
- [Helm Chart por @magicsong](https://github.com/magicsong/ai-charts)
- [Archivo YAML por @Winson-030](https://github.com/Winson-030/dify-kubernetes)
- [Archivo YAML por @wyy-holding](https://github.com/wyy-holding/dify-k8s)

#### Usando Terraform para el despliegue

Despliega Dify en la plataforma Cloud con un solo clic usando [terraform](https://www.terraform.io/)

##### Azure Global

- [Azure Terraform por @nikawang](https://github.com/nikawang/dify-azure-terraform)

##### Google Cloud

- [Google Cloud Terraform por @sotazum](https://github.com/DeNA/dify-google-cloud-terraform)

#### Usando AWS CDK para el despliegue

Despliega Dify en AWS con [CDK](https://aws.amazon.com/cdk/)

##### AWS

- [AWS CDK por @KevinZhao](https://github.com/aws-samples/solution-for-deploying-dify-on-aws)

## Contribuir

Si deseas contribuir con código, consulta nuestra [Guía de Contribución](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md).
Al mismo tiempo, considera apoyar a Dify compartiéndolo en redes sociales y en eventos o conferencias.

> Buscamos colaboradores para ayudar a traducir Dify a otros idiomas además del mandarín o inglés. Si te interesa ayudar, consulta el [README de i18n](https://github.com/langgenius/dify/blob/main/web/i18n/README.md) para más información y déjanos un comentario en el canal `global-users` de nuestro [Servidor de la comunidad en Discord](https://discord.gg/8Tpq4AcN9c).

## Comunidad y contacto

- [Discusión en GitHub](https://github.com/langgenius/dify/discussions). Ideal para: compartir comentarios y hacer preguntas.
- [Issues de GitHub](https://github.com/langgenius/dify/issues). Ideal para: errores encontrados usando Dify.AI y propuestas de funcionalidades. Consulta nuestra [Guía de Contribución](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md).
- [Discord](https://discord.gg/FngNHpbcY7). Ideal para: compartir tus aplicaciones y convivir con la comunidad.
- [X(Twitter)](https://twitter.com/dify_ai). Ideal para: compartir tus aplicaciones y convivir con la comunidad.

**Colaboradores**

<a href="https://github.com/langgenius/dify/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=langgenius/dify" />
</a>

## Historial de estrellas

[![Star History Chart](https://api.star-history.com/svg?repos=langgenius/dify&type=Date)](https://star-history.com/#langgenius/dify&Date)

## Divulgación de seguridad

Para proteger tu privacidad, evita publicar problemas de seguridad en GitHub. En su lugar, envía tus preguntas a security@dify.ai y te daremos una respuesta más detallada.

## Licencia

Este repositorio está disponible bajo la [Licencia de código abierto de Dify](LICENSE), que es esencialmente Apache 2.0 con algunas restricciones adicionales.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---