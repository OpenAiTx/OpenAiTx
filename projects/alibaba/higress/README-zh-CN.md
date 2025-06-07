<a name="readme-top"></a>
<h1 align="center">
    <img src="https://img.alicdn.com/imgextra/i2/O1CN01NwxLDd20nxfGBjxmZ_!!6000000006895-2-tps-960-290.png" alt="Higress" width="240" height="72.5">
  <br>
  AI 网关
</h1>
<h4 align="center"> 原生 AI API 网关 </h4>

<div align="center">
    
[![Build Status](https://github.com/alibaba/higress/actions/workflows/build-and-test.yaml/badge.svg?branch=main)](https://github.com/alibaba/higress/actions)
[![license](https://img.shields.io/github/license/alibaba/higress.svg)](https://www.apache.org/licenses/LICENSE-2.0.html)
[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=flat-square)](https://discord.gg/tSbww9VDaM)

<a href="https://trendshift.io/repositories/10918" target="_blank"><img src="https://trendshift.io/api/badge/repositories/10918" alt="alibaba%2Fhigress | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a> <a href="https://www.producthunt.com/posts/higress?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-higress" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=951287&theme=light&t=1745492822283" alt="Higress - Global&#0032;APIs&#0032;as&#0032;MCP&#0032;powered&#0032;by&#0032;AI&#0032;Gateway | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

</div>

[**官方网站**](https://higress.ai/en/) &nbsp; |
&nbsp; [**MCP Server 快速入门**](https://higress.cn/en/ai/mcp-quick-start/) &nbsp; |
&nbsp; [**Wasm 插件中心**](https://higress.cn/en/plugin/) &nbsp; |

<p>
   English | <a href="README_ZH.md">中文<a/> | <a href="README_JP.md">日本語<a/>
</p>

## 什么是 Higress？

Higress 是一款基于 Istio 和 Envoy 的云原生 API 网关，支持使用 Go/Rust/JS 编写的 Wasm 插件进行扩展。它提供了数十个开箱即用的通用插件及一个开箱即用的可视化控制台（可[在线体验 DEMO](http://demo.higress.io/)）。

### 核心场景

Higress 的 AI 网关能力支持所有[主流模型服务商](https://raw.githubusercontent.com/alibaba/higress/main/plugins/wasm-go/extensions/ai-proxy/provider)（国内外），并通过插件机制支持托管 MCP（模型上下文协议）Server，使 AI Agent 能便捷调用各类工具与服务。借助[openapi-to-mcp 工具](https://github.com/higress-group/openapi-to-mcpserver)，可快速将 OpenAPI 规范转为远程 MCP Server 进行托管。Higress 实现了 LLM API 与 MCP API 的统一管理。

**🌟 马上访问 [https://mcp.higress.ai/](https://mcp.higress.ai/)**，亲身体验 Higress 托管的远程 MCP Server：

![Higress MCP Server 平台](https://img.alicdn.com/imgextra/i2/O1CN01nmVa0a1aChgpyyWOX_!!6000000003294-0-tps-3430-1742.jpg)

### 企业落地

Higress 诞生于阿里巴巴，旨在解决 Tengine reload 对长连接业务的影响及 gRPC/Dubbo 负载均衡能力不足等问题。在阿里云内部，Higress 的 AI 网关能力已支撑通义百炼模型工坊、机器学习 PAI 平台等核心 AI 应用。阿里云基于 Higress 打造了云原生 API 网关产品，为大量企业客户提供 99.99% 网关高可用保障服务能力。

## 目录

- [**快速入门**](#quick-start)    
- [**功能亮点**](#feature-showcase)
- [**应用场景**](#use-cases)
- [**核心优势**](#core-advantages)
- [**社区**](#community)

## 快速入门

Higress 支持通过 Docker 一键启动，个人开发者本地学习或搭建简单站点极为方便：

```bash
# 创建工作目录
mkdir higress; cd higress
# 启动 higress，配置文件将写入工作目录
docker run -d --rm --name higress-ai -v ${PWD}:/data \
        -p 8001:8001 -p 8080:8080 -p 8443:8443  \
        higress-registry.cn-hangzhou.cr.aliyuncs.com/higress/all-in-one:latest
```

端口说明：

- 8001 端口：Higress UI 控制台入口
- 8080 端口：网关 HTTP 协议入口
- 8443 端口：网关 HTTPS 协议入口

> 所有 Higress Docker 镜像均使用 Higress 自有镜像仓库，不受 Docker Hub 拉取速率限制。
> 此外，镜像的提交与更新均有安全扫描机制（由阿里云 ACR 驱动）保障，生产可放心使用。
>
> 若在拉取 `higress-registry.cn-hangzhou.cr.aliyuncs.com` 镜像时遇到超时，可尝试替换为以下镜像源：
>
> **东南亚地区**：`higress-registry.ap-southeast-7.cr.aliyuncs.com`

如需使用 Helm 部署到 K8s 等其它安装方式，请参考官方[快速入门文档](https://higress.io/en-us/docs/user/quickstart)。

## 应用场景

- **MCP Server 托管**：

  Higress 通过插件机制托管 MCP Server，使 AI Agent 能便捷调用各类工具与服务。借助[openapi-to-mcp 工具](https://github.com/higress-group/openapi-to-mcpserver)，可快速将 OpenAPI 规范转为远程 MCP Server。

  ![](https://img.alicdn.com/imgextra/i1/O1CN01wv8H4g1mS4MUzC1QC_!!6000000004952-2-tps-1764-597.png)

  Higress 托管 MCP Server 的主要优势：
  - 统一鉴权与授权机制
  - 细粒度限流，防止滥用
  - 全量调用审计日志
  - 丰富可观测性，便于性能监控
  - 插件机制简化部署
  - 动态热更新，无中断、无连接丢失

     [了解更多...](https://higress.cn/en/ai/mcp-quick-start/?spm=36971b57.7beea2de.0.0.d85f20a94jsWGm)

- **AI 网关**：

  Higress 采用统一协议对接所有 LLM 模型服务商，具备 AI 可观测性、多模型负载均衡、Token 限流、缓存等能力：

  ![](https://img.alicdn.com/imgextra/i2/O1CN01izmBNX1jbHT7lP3Yr_!!6000000004566-0-tps-1920-1080.jpg)

- **Kubernetes Ingress 控制器**：

  Higress 可作为高功能丰富的 Ingress 控制器，兼容 K8s nginx Ingress 控制器的大量注解。
  
  即将支持 [Gateway API](https://gateway-api.sigs.k8s.io/)，助力 Ingress API 平滑迁移至 Gateway API。
  
- **微服务网关**：

  Higress 可作为微服务网关，从多种服务注册中心（如 Nacos、ZooKeeper、Consul、Eureka 等）发现微服务。
  
  深度集成 [Dubbo](https://github.com/apache/dubbo)、[Nacos](https://github.com/alibaba/nacos)、[Sentinel](https://github.com/alibaba/Sentinel) 等微服务技术栈。
  
- **安全网关**：

  Higress 可作为安全网关使用，支持 WAF 及多种认证方式，如 key-auth、hmac-auth、jwt-auth、basic-auth、oidc 等。

## 核心优势

- **生产级稳定性**

  源自阿里内部产品，已历经 2 年+ 生产级验证，支撑超十万 QPS 大规模场景。

  完全消除了 Nginx reload 带来的流量抖动，配置变更毫秒级生效且对业务透明，特别适合 AI 等长连接场景。

- **流式处理**

  支持请求/响应体真正的全流式处理，Wasm 插件可轻松自定义 SSE 等流式协议处理。

  在 AI 等高带宽场景下显著降低内存占用。
    
- **易扩展**
  
  提供丰富的官方插件库，涵盖 AI、流量治理、安全防护等常用功能，满足 90% 以上业务场景需求。

  专注 Wasm 插件扩展，通过沙箱隔离保障内存安全，支持多语言开发，插件可独立升级，网关逻辑热更新无丢流。

- **安全易用**
  
  基于 Ingress API/Gateway API 标准，内置 UI 控制台、WAF 防护插件、IP/Cookie CC 防护插件即开即用。

  支持对接 Let's Encrypt 自动申请、续期免费证书，可脱离 K8s 部署，单条 Docker 命令即可启动，个人开发者极为方便。

## 社区

欢迎加入我们的 Discord 社区！在这里你可以与 Higress 的开发者及其他热情用户交流。

[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=for-the-badge)](https://discord.gg/tSbww9VDaM)


### 致谢

Higress 离不开社区中众多开源项目的宝贵贡献，特别感谢 Envoy 和 Istio 项目。

### 相关仓库

- Higress 控制台：https://github.com/higress-group/higress-console
- Higress Standalone 独立版：https://github.com/higress-group/higress-standalone

### 贡献者

<a href="https://github.com/alibaba/higress/graphs/contributors">
  <img alt="contributors" src="https://contrib.rocks/image?repo=alibaba/higress"/>
</a>

### Star 趋势

[![Star History Chart](https://api.star-history.com/svg?repos=alibaba/higress&type=Date)](https://star-history.com/#alibaba/higress&Date)

<p align="right" style="font-size: 14px; color: #555; margin-top: 20px;">
    <a href="#readme-top" style="text-decoration: none; color: #007bff; font-weight: bold;">
        ↑ 返回顶部 ↑
    </a>
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---