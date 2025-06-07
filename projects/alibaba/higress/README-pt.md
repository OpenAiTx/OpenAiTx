<a name="readme-top"></a>
<h1 align="center">
    <img src="https://img.alicdn.com/imgextra/i2/O1CN01NwxLDd20nxfGBjxmZ_!!6000000006895-2-tps-960-290.png" alt="Higress" width="240" height="72.5">
  <br>
  Gateway de IA
</h1>
<h4 align="center"> API Gateway Nativo para IA </h4>

<div align="center">
    
[![Build Status](https://github.com/alibaba/higress/actions/workflows/build-and-test.yaml/badge.svg?branch=main)](https://github.com/alibaba/higress/actions)
[![license](https://img.shields.io/github/license/alibaba/higress.svg)](https://www.apache.org/licenses/LICENSE-2.0.html)
[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=flat-square)](https://discord.gg/tSbww9VDaM)

<a href="https://trendshift.io/repositories/10918" target="_blank"><img src="https://trendshift.io/api/badge/repositories/10918" alt="alibaba%2Fhigress | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a> <a href="https://www.producthunt.com/posts/higress?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-higress" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=951287&theme=light&t=1745492822283" alt="Higress - Global&#0032;APIs&#0032;as&#0032;MCP&#0032;powered&#0032;by&#0032;AI&#0032;Gateway | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

</div>

[**Site Oficial**](https://higress.ai/en/) &nbsp; |
&nbsp; [**MCP Server QuickStart**](https://higress.cn/en/ai/mcp-quick-start/) &nbsp; |
&nbsp; [**Wasm Plugin Hub**](https://higress.cn/en/plugin/) &nbsp; |

<p>
   English | <a href="README_ZH.md">中文<a/> | <a href="README_JP.md">日本語<a/>
</p>

## O que é o Higress?

O Higress é um API gateway cloud-native baseado em Istio e Envoy, que pode ser estendido com plugins Wasm escritos em Go/Rust/JS. Ele fornece dezenas de plugins prontos para uso e um console pronto para uso (experimente o [demo aqui](http://demo.higress.io/)).

### Casos de Uso Principais

As capacidades de gateway de IA do Higress suportam todos os [principais provedores de modelos](https://raw.githubusercontent.com/alibaba/higress/main/plugins/wasm-go/extensions/ai-proxy/provider) tanto nacionais quanto internacionais. Também suporta o hosting de servidores MCP (Model Context Protocol) através do seu mecanismo de plugins, permitindo que agentes de IA acessem facilmente diversas ferramentas e serviços. Com a ferramenta [openapi-to-mcp](https://github.com/higress-group/openapi-to-mcpserver), é possível converter rapidamente especificações OpenAPI em servidores MCP remotos para hospedagem. O Higress oferece gerenciamento unificado tanto para APIs LLM quanto para APIs MCP.

**🌟 Experimente agora em [https://mcp.higress.ai/](https://mcp.higress.ai/)** para vivenciar servidores MCP remotos hospedados pelo Higress:

![Higress MCP Server Platform](https://img.alicdn.com/imgextra/i2/O1CN01nmVa0a1aChgpyyWOX_!!6000000003294-0-tps-3430-1742.jpg)

### Adoção Empresarial

O Higress nasceu dentro da Alibaba para solucionar problemas de recarga do Tengine afetando serviços de conexão longa e insuficiência de balanceamento de carga para gRPC/Dubbo. Dentro da Alibaba Cloud, as capacidades de gateway de IA do Higress suportam aplicações de IA core como o estúdio de modelos Tongyi Bailian, a plataforma de machine learning PAI e outros serviços críticos de IA. A Alibaba Cloud construiu seu produto de API gateway cloud-native baseado no Higress, oferecendo garantia de alta disponibilidade de gateway (99,99%) para uma grande quantidade de clientes corporativos.

## Sumário

- [**Guia Rápido**](#quick-start)    
- [**Demonstração de Funcionalidades**](#feature-showcase)
- [**Casos de Uso**](#use-cases)
- [**Principais Vantagens**](#core-advantages)
- [**Comunidade**](#community)

## Guia Rápido

O Higress pode ser iniciado apenas com Docker, facilitando para desenvolvedores individuais configurarem localmente para aprendizado ou construção de sites simples:

```bash
# Crie um diretório de trabalho
mkdir higress; cd higress
# Inicie o higress, arquivos de configuração serão gravados no diretório de trabalho
docker run -d --rm --name higress-ai -v ${PWD}:/data \
        -p 8001:8001 -p 8080:8080 -p 8443:8443  \
        higress-registry.cn-hangzhou.cr.aliyuncs.com/higress/all-in-one:latest
```

Descrição das portas:

- Porta 8001: Entrada do console UI do Higress
- Porta 8080: Entrada HTTP do gateway
- Porta 8443: Entrada HTTPS do gateway

> Todas as imagens Docker do Higress utilizam o próprio repositório de imagens do Higress e não são afetadas pelos limites de taxa do Docker Hub.
> Além disso, o envio e as atualizações das imagens são protegidos por um mecanismo de varredura de segurança (alimentado pelo Alibaba Cloud ACR), tornando-as muito seguras para uso em ambientes de produção.
> 
> Se você tiver problemas de timeout ao puxar imagens de `higress-registry.cn-hangzhou.cr.aliyuncs.com`, tente substituir pelo seguinte espelho de registro docker:
> 
> **Sudeste Asiático**: `higress-registry.ap-southeast-7.cr.aliyuncs.com`

Para outros métodos de instalação, como implantação via Helm em K8s, consulte a [documentação oficial de Guia Rápido](https://higress.io/en-us/docs/user/quickstart).

## Casos de Uso

- **Hospedagem de Servidor MCP**:

  O Higress hospeda servidores MCP através do seu mecanismo de plugins, permitindo que agentes de IA acessem facilmente diversas ferramentas e serviços. Com a ferramenta [openapi-to-mcp](https://github.com/higress-group/openapi-to-mcpserver), você pode converter rapidamente especificações OpenAPI em servidores MCP remotos.

  ![](https://img.alicdn.com/imgextra/i1/O1CN01wv8H4g1mS4MUzC1QC_!!6000000004952-2-tps-1764-597.png)

  Principais benefícios da hospedagem de servidores MCP com o Higress:
  - Mecanismos unificados de autenticação e autorização
  - Limitação de taxa granular para evitar abusos
  - Logs de auditoria completos para todas as chamadas de ferramentas
  - Observabilidade rica para monitoramento de desempenho
  - Implantação simplificada via mecanismo de plugins do Higress
  - Atualizações dinâmicas sem interrupções ou quedas de conexão

     [Saiba mais...](https://higress.cn/en/ai/mcp-quick-start/?spm=36971b57.7beea2de.0.0.d85f20a94jsWGm)

- **Gateway de IA**:

  O Higress conecta-se a todos os provedores de modelos LLM usando um protocolo unificado, com observabilidade de IA, balanceamento de carga multi-modelo, limitação de taxa por token e capacidades de cache:

  ![](https://img.alicdn.com/imgextra/i2/O1CN01izmBNX1jbHT7lP3Yr_!!6000000004566-0-tps-1920-1080.jpg)

- **Controlador ingress para Kubernetes**:

  O Higress pode funcionar como um controlador ingress rico em recursos, compatível com muitas anotações do controlador ingress nginx do K8s.
  
  Suporte ao [Gateway API](https://gateway-api.sigs.k8s.io/) em breve, com migração suave do Ingress API para o Gateway API.
  
- **Gateway de microsserviços**:

  O Higress pode funcionar como um gateway de microsserviços, podendo descobrir microsserviços em vários registradores de serviços, como Nacos, ZooKeeper, Consul, Eureka, etc.
  
  Integra-se profundamente com [Dubbo](https://github.com/apache/dubbo), [Nacos](https://github.com/alibaba/nacos), [Sentinel](https://github.com/alibaba/Sentinel) e outros stacks de tecnologia de microsserviços.
  
- **Gateway de segurança**:

  O Higress pode ser usado como um gateway de segurança, suportando WAF e várias estratégias de autenticação, como key-auth, hmac-auth, jwt-auth, basic-auth, oidc, etc.


## Principais Vantagens

- **Pronto para Produção**

  Nascido de produto interno da Alibaba com mais de 2 anos de validação em produção, suportando cenários em larga escala com centenas de milhares de requisições por segundo.

  Elimina completamente os picos de tráfego causados por recarga do Nginx, alterações de configuração têm efeito em milissegundos e são transparentes para o negócio. Especialmente amigável para cenários de conexão longa, como negócios de IA.

- **Processamento Streaming**

  Suporta verdadeiro processamento completo em streaming dos corpos de requisição/resposta, plugins Wasm podem facilmente customizar o tratamento de protocolos de streaming como SSE (Server-Sent Events).

  Em cenários de alta largura de banda, como negócios de IA, pode reduzir significativamente o consumo de memória.
    
- **Fácil de Estender**
  
  Fornece uma biblioteca oficial rica em plugins cobrindo IA, gerenciamento de tráfego, proteção de segurança e outras funções comuns, atendendo a mais de 90% das necessidades dos cenários de negócio.

  Focado em extensões de plugins Wasm, garantindo segurança de memória através de isolamento em sandbox, suportando múltiplas linguagens de programação, permitindo atualização independente de versões de plugins e atualizações a quente sem perda de tráfego da lógica do gateway.

- **Seguro e Fácil de Usar**
  
  Baseado nos padrões Ingress API e Gateway API, fornece console UI pronto para uso, plugin WAF de proteção, plugin de proteção contra CC por IP/Cookie prontos para uso.

  Suporta conexão ao Let's Encrypt para emissão automática e renovação de certificados gratuitos, podendo ser implantado fora do K8s, iniciado com um único comando Docker, conveniente para uso de desenvolvedores individuais.

## Comunidade

Junte-se à nossa comunidade no Discord! Aqui você pode se conectar com desenvolvedores e outros usuários entusiastas do Higress.

[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=for-the-badge)](https://discord.gg/tSbww9VDaM)


### Agradecimentos

O Higress não seria possível sem o valioso trabalho de código aberto de projetos da comunidade. Nosso agradecimento especial ao Envoy e Istio.

### Repositórios Relacionados

- Higress Console: https://github.com/higress-group/higress-console
- Higress Standalone: https://github.com/higress-group/higress-standalone

### Contribuidores

<a href="https://github.com/alibaba/higress/graphs/contributors">
  <img alt="contributors" src="https://contrib.rocks/image?repo=alibaba/higress"/>
</a>

### Histórico de Estrelas

[![Star History Chart](https://api.star-history.com/svg?repos=alibaba/higress&type=Date)](https://star-history.com/#alibaba/higress&Date)

<p align="right" style="font-size: 14px; color: #555; margin-top: 20px;">
    <a href="#readme-top" style="text-decoration: none; color: #007bff; font-weight: bold;">
        ↑ Voltar ao Topo ↑
    </a>
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---