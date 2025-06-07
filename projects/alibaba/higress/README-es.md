<a name="readme-top"></a>
<h1 align="center">
    <img src="https://img.alicdn.com/imgextra/i2/O1CN01NwxLDd20nxfGBjxmZ_!!6000000006895-2-tps-960-290.png" alt="Higress" width="240" height="72.5">
  <br>
  AI Gateway
</h1>
<h4 align="center"> API Gateway Nativo de IA </h4>

<div align="center">
    
[![Build Status](https://github.com/alibaba/higress/actions/workflows/build-and-test.yaml/badge.svg?branch=main)](https://github.com/alibaba/higress/actions)
[![license](https://img.shields.io/github/license/alibaba/higress.svg)](https://www.apache.org/licenses/LICENSE-2.0.html)
[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=flat-square)](https://discord.gg/tSbww9VDaM)

<a href="https://trendshift.io/repositories/10918" target="_blank"><img src="https://trendshift.io/api/badge/repositories/10918" alt="alibaba%2Fhigress | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a> <a href="https://www.producthunt.com/posts/higress?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-higress" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=951287&theme=light&t=1745492822283" alt="Higress - Global&#0032;APIs&#0032;as&#0032;MCP&#0032;powered&#0032;by&#0032;AI&#0032;Gateway | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

</div>

[**Sitio Oficial**](https://higress.ai/en/) &nbsp; |
&nbsp; [**Inicio Rápido del Servidor MCP**](https://higress.cn/en/ai/mcp-quick-start/) &nbsp; |
&nbsp; [**Hub de Plugins Wasm**](https://higress.cn/en/plugin/) &nbsp; |

<p>
   English | <a href="README_ZH.md">中文<a/> | <a href="README_JP.md">日本語<a/>
</p>

## ¿Qué es Higress?

Higress es un gateway de API cloud-native basado en Istio y Envoy, que puede ser extendido con plugins Wasm escritos en Go/Rust/JS. Proporciona docenas de plugins de propósito general listos para usar y una consola lista para usar (prueba la [demo aquí](http://demo.higress.io/)).

### Casos de Uso Principales

Las capacidades del gateway de IA de Higress soportan todos los [proveedores de modelos principales](https://raw.githubusercontent.com/alibaba/higress/main/plugins/wasm-go/extensions/ai-proxy/provider) tanto nacionales como internacionales. También soporta alojar servidores MCP (Model Context Protocol) a través de su mecanismo de plugins, permitiendo que los Agentes de IA llamen fácilmente a diversas herramientas y servicios. Con la herramienta [openapi-to-mcp](https://github.com/higress-group/openapi-to-mcpserver), puedes convertir rápidamente especificaciones OpenAPI en servidores MCP remotos para ser alojados. Higress proporciona gestión unificada tanto para LLM API como para MCP API.

**🌟 Pruébalo ahora en [https://mcp.higress.ai/](https://mcp.higress.ai/)** para experimentar de primera mano los servidores MCP remotos alojados por Higress:

![Plataforma Higress MCP Server](https://img.alicdn.com/imgextra/i2/O1CN01nmVa0a1aChgpyyWOX_!!6000000003294-0-tps-3430-1742.jpg)

### Adopción Empresarial

Higress nació dentro de Alibaba para resolver problemas de recarga de Tengine que afectaban a servicios de conexiones largas y la insuficiencia de capacidades de balanceo de carga para gRPC/Dubbo. Dentro de Alibaba Cloud, las capacidades de gateway de IA de Higress soportan aplicaciones de IA centrales como el estudio de modelos Tongyi Bailian, la plataforma de aprendizaje automático PAI y otros servicios críticos de IA. Alibaba Cloud ha construido su producto de gateway de API cloud-native basado en Higress, proporcionando capacidades de garantía de alta disponibilidad del 99,99% para un gran número de clientes empresariales.

## Resumen

- [**Inicio Rápido**](#quick-start)    
- [**Demostración de Funcionalidades**](#feature-showcase)
- [**Casos de Uso**](#use-cases)
- [**Ventajas Clave**](#core-advantages)
- [**Comunidad**](#community)

## Inicio Rápido

Higress puede iniciarse solo con Docker, lo que lo hace conveniente para que desarrolladores individuales lo configuren localmente para aprendizaje o para construir sitios sencillos:

```bash
# Crear un directorio de trabajo
mkdir higress; cd higress
# Iniciar higress, los archivos de configuración se escribirán en el directorio de trabajo
docker run -d --rm --name higress-ai -v ${PWD}:/data \
        -p 8001:8001 -p 8080:8080 -p 8443:8443  \
        higress-registry.cn-hangzhou.cr.aliyuncs.com/higress/all-in-one:latest
```

Descripción de los puertos:

- Puerto 8001: Entrada a la consola UI de Higress
- Puerto 8080: Entrada HTTP del gateway
- Puerto 8443: Entrada HTTPS del gateway

> Todas las imágenes Docker de Higress utilizan el repositorio propio de imágenes de Higress y no se ven afectadas por los límites de Docker Hub.
> Además, el envío y actualización de imágenes están protegidos por un mecanismo de escaneo de seguridad (impulsado por Alibaba Cloud ACR), haciéndolas muy seguras para su uso en entornos productivos.
> 
> Si experimentas un timeout al descargar la imagen de `higress-registry.cn-hangzhou.cr.aliyuncs.com`, puedes intentar reemplazarlo por la siguiente fuente espejo de Docker registry:
> 
> **Sudeste Asiático**: `higress-registry.ap-southeast-7.cr.aliyuncs.com`

Para otros métodos de instalación como la implementación con Helm en K8s, por favor consulta la [documentación oficial de Inicio Rápido](https://higress.io/en-us/docs/user/quickstart).

## Casos de Uso

- **Alojamiento de Servidor MCP**:

  Higress aloja servidores MCP a través de su mecanismo de plugins, permitiendo que los Agentes de IA llamen fácilmente a diversas herramientas y servicios. Con la herramienta [openapi-to-mcp](https://github.com/higress-group/openapi-to-mcpserver), puedes convertir rápidamente especificaciones OpenAPI en servidores MCP remotos.

  ![](https://img.alicdn.com/imgextra/i1/O1CN01wv8H4g1mS4MUzC1QC_!!6000000004952-2-tps-1764-597.png)

  Beneficios clave de alojar servidores MCP con Higress:
  - Mecanismos unificados de autenticación y autorización
  - Limitación de tasa de manera granular para prevenir abusos
  - Registros de auditoría completos para todas las llamadas de herramientas
  - Observabilidad rica para monitorear el rendimiento
  - Despliegue simplificado gracias al mecanismo de plugins de Higress
  - Actualizaciones dinámicas sin interrupciones ni caídas de conexión

     [Más información...](https://higress.cn/en/ai/mcp-quick-start/?spm=36971b57.7beea2de.0.0.d85f20a94jsWGm)

- **Gateway de IA**:

  Higress se conecta a todos los proveedores de modelos LLM usando un protocolo unificado, con observabilidad de IA, balanceo de carga multi-modelo, limitación de tasa por tokens y capacidades de caché:

  ![](https://img.alicdn.com/imgextra/i2/O1CN01izmBNX1jbHT7lP3Yr_!!6000000004566-0-tps-1920-1080.jpg)

- **Controlador de Ingress para Kubernetes**:

  Higress puede funcionar como un controlador de ingress rico en funcionalidades, compatible con muchas anotaciones del controlador ingress nginx de K8s.
  
  El soporte para [Gateway API](https://gateway-api.sigs.k8s.io/) llegará pronto y permitirá la migración fluida de Ingress API a Gateway API.
  
- **Gateway de Microservicios**:

  Higress puede funcionar como un gateway de microservicios, descubriendo microservicios desde varios registros de servicios, como Nacos, ZooKeeper, Consul, Eureka, etc.
  
  Se integra profundamente con [Dubbo](https://github.com/apache/dubbo), [Nacos](https://github.com/alibaba/nacos), [Sentinel](https://github.com/alibaba/Sentinel) y otras tecnologías de microservicios.
  
- **Gateway de Seguridad**:

  Higress puede ser utilizado como un gateway de seguridad, soportando WAF y varias estrategias de autenticación, como key-auth, hmac-auth, jwt-auth, basic-auth, oidc, etc.


## Ventajas Clave

- **Nivel Producción**

  Nacido del producto interno de Alibaba con más de 2 años de validación en producción, soportando escenarios a gran escala con cientos de miles de solicitudes por segundo.

  Elimina completamente la inestabilidad del tráfico causada por la recarga de Nginx, los cambios de configuración surten efecto en milisegundos y son transparentes para el negocio. Especialmente amigable para escenarios de conexiones largas como los negocios de IA.

- **Procesamiento en Streaming**

  Soporta procesamiento completo y real en streaming de los cuerpos de las solicitudes/respuestas, los plugins Wasm pueden personalizar fácilmente el manejo de protocolos en streaming como SSE (Server-Sent Events).

  En escenarios de alto ancho de banda como los negocios de IA, puede reducir significativamente el consumo de memoria.
    
- **Fácil de Extender**
  
  Proporciona una rica biblioteca oficial de plugins que cubren IA, gestión de tráfico, protección de seguridad y otras funciones comunes, satisfaciendo más del 90% de los requisitos de escenarios de negocio.

  Se enfoca en extensiones con plugins Wasm, asegurando la seguridad de la memoria mediante aislamiento en sandbox, soportando múltiples lenguajes de programación, permitiendo la actualización independiente de versiones de plugins y logrando actualizaciones en caliente sin pérdida de tráfico en la lógica del gateway.

- **Seguro y Fácil de Usar**
  
  Basado en los estándares de Ingress API y Gateway API, proporciona consola UI lista para usar, plugin de protección WAF, plugin de protección CC por IP/Cookie listos para usar.

  Soporta la conexión con Let's Encrypt para la emisión y renovación automática de certificados gratuitos, y puede ser desplegado fuera de K8s, iniciado con un solo comando Docker, conveniente para desarrolladores individuales.

## Comunidad

¡Únete a nuestra comunidad en Discord! Aquí podrás conectar con desarrolladores y otros usuarios entusiastas de Higress.

[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=for-the-badge)](https://discord.gg/tSbww9VDaM)


### Agradecimientos

Higress no sería posible sin el valioso trabajo open-source de proyectos en la comunidad. Nos gustaría extender un agradecimiento especial a Envoy e Istio.

### Repositorios Relacionados

- Consola de Higress: https://github.com/higress-group/higress-console
- Higress Standalone: https://github.com/higress-group/higress-standalone

### Contribuidores

<a href="https://github.com/alibaba/higress/graphs/contributors">
  <img alt="contributors" src="https://contrib.rocks/image?repo=alibaba/higress"/>
</a>

### Historial de Estrellas

[![Star History Chart](https://api.star-history.com/svg?repos=alibaba/higress&type=Date)](https://star-history.com/#alibaba/higress&Date)

<p align="right" style="font-size: 14px; color: #555; margin-top: 20px;">
    <a href="#readme-top" style="text-decoration: none; color: #007bff; font-weight: bold;">
        ↑ Volver arriba ↑
    </a>
</p>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---