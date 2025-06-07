<a name="readme-top"></a>
<h1 align="center">
    <img src="https://img.alicdn.com/imgextra/i2/O1CN01NwxLDd20nxfGBjxmZ_!!6000000006895-2-tps-960-290.png" alt="Higress" width="240" height="72.5">
  <br>
  AI Gateway
</h1>
<h4 align="center"> 原生 AI 的 API Gateway </h4>

<div align="center">
    
[![Build Status](https://github.com/alibaba/higress/actions/workflows/build-and-test.yaml/badge.svg?branch=main)](https://github.com/alibaba/higress/actions)
[![license](https://img.shields.io/github/license/alibaba/higress.svg)](https://www.apache.org/licenses/LICENSE-2.0.html)
[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=flat-square)](https://discord.gg/tSbww9VDaM)

<a href="https://trendshift.io/repositories/10918" target="_blank"><img src="https://trendshift.io/api/badge/repositories/10918" alt="alibaba%2Fhigress | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a> <a href="https://www.producthunt.com/posts/higress?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-higress" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=951287&theme=light&t=1745492822283" alt="Higress - Global&#0032;APIs&#0032;as&#0032;MCP&#0032;powered&#0032;by&#0032;AI&#0032;Gateway | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

</div>

[**官方網站**](https://higress.ai/en/) &nbsp; |
&nbsp; [**MCP Server 快速入門**](https://higress.cn/en/ai/mcp-quick-start/) &nbsp; |
&nbsp; [**Wasm 插件中心**](https://higress.cn/en/plugin/) &nbsp; |

<p>
   English | <a href="README_ZH.md">中文<a/> | <a href="README_JP.md">日本語<a/>
</p>

## 什麼是 Higress？

Higress 是一款基於 Istio 和 Envoy 的雲原生 API Gateway，支持使用 Go/Rust/JS 編寫 Wasm 插件進行擴展。它提供數十種開箱即用的通用插件和一套現成的管理控制台（[點此體驗 Demo](http://demo.higress.io/)）。

### 核心場景

Higress 的 AI Gateway 能力支持國內外所有[主流模型提供商](https://raw.githubusercontent.com/alibaba/higress/main/plugins/wasm-go/extensions/ai-proxy/provider)，同時通過插件機制支持 MCP（Model Context Protocol）Server 託管，讓 AI Agent 可以輕鬆調用各類工具和服務。借助 [openapi-to-mcp 工具](https://github.com/higress-group/openapi-to-mcpserver)，你可以快速將 OpenAPI 規範轉換為遠端 MCP Server 進行託管。Higress 對 LLM API 與 MCP API 提供統一管理。

**🌟 現在就前往 [https://mcp.higress.ai/](https://mcp.higress.ai/)**，親身體驗 Higress 託管的遠端 MCP Server：

![Higress MCP Server 平台](https://img.alicdn.com/imgextra/i2/O1CN01nmVa0a1aChgpyyWOX_!!6000000003294-0-tps-3430-1742.jpg)

### 企業落地

Higress 源自阿里巴巴，解決了 Tengine 重載影響長連接業務和 gRPC/Dubbo 負載均衡能力不足的問題。在阿里雲內部，Higress 的 AI Gateway 能力支撐了通義百煉模型工作室、機器學習 PAI 平台等核心 AI 應用。阿里雲基於 Higress 打造了雲原生 API Gateway 產品，為大量企業級客戶提供 99.99% 高可用的網關服務能力。

## 目錄

- [**快速入門**](#quick-start)    
- [**功能展示**](#feature-showcase)
- [**應用場景**](#use-cases)
- [**核心優勢**](#core-advantages)
- [**社群**](#community)

## 快速入門

Higress 僅需 Docker 即可啟動，方便個人開發者在本地學習或搭建簡單站點：

```bash
# 建立工作目錄
mkdir higress; cd higress
# 啟動 higress，配置文件將寫入工作目錄
docker run -d --rm --name higress-ai -v ${PWD}:/data \
        -p 8001:8001 -p 8080:8080 -p 8443:8443  \
        higress-registry.cn-hangzhou.cr.aliyuncs.com/higress/all-in-one:latest
```

端口說明：

- 8001 端口：Higress UI 控制台入口
- 8080 端口：Gateway HTTP 協議入口
- 8443 端口：Gateway HTTPS 協議入口

> 所有 Higress 的 Docker 映像均使用 Higress 自有鏡像倉庫，不受 Docker Hub 流量限制影響。
> 此外，鏡像的提交與更新由安全掃描機制（由阿里雲 ACR 提供）保護，可放心用於生產環境。
> 
> 若從 `higress-registry.cn-hangzhou.cr.aliyuncs.com` 拉取鏡像時遇到超時，可嘗試替換為以下 docker registry 鏡像源：
> 
> **東南亞地區**: `higress-registry.ap-southeast-7.cr.aliyuncs.com`

如需 Helm 部署等其他 K8s 下的安裝方式，請參考官方 [快速入門文檔](https://higress.io/en-us/docs/user/quickstart)。

## 應用場景

- **MCP Server 託管**：

  Higress 通過插件機制託管 MCP Server，讓 AI Agent 可以輕鬆調用各類工具和服務。借助 [openapi-to-mcp 工具](https://github.com/higress-group/openapi-to-mcpserver)，可快速將 OpenAPI 規範轉換為遠端 MCP Server。

  ![](https://img.alicdn.com/imgextra/i1/O1CN01wv8H4g1mS4MUzC1QC_!!6000000004952-2-tps-1764-597.png)

  Higress 託管 MCP Server 的關鍵優勢：
  - 統一的認證與授權機制
  - 細粒度的限流，防止濫用
  - 工具調用全程審計日誌
  - 完善的可觀測性，便於性能監控
  - 通過插件機制簡化部署
  - 動態更新無感知不中斷連接

     [了解更多...](https://higress.cn/en/ai/mcp-quick-start/?spm=36971b57.7beea2de.0.0.d85f20a94jsWGm)

- **AI Gateway**：

  Higress 通過統一協議對接所有 LLM 模型服務商，具備 AI 可觀測性、多模型負載均衡、Token 限流及緩存等能力：

  ![](https://img.alicdn.com/imgextra/i2/O1CN01izmBNX1jbHT7lP3Yr_!!6000000004566-0-tps-1920-1080.jpg)

- **Kubernetes ingress 控制器**：

  Higress 可作為功能豐富的 ingress 控制器，兼容 K8s nginx ingress controller 的多種註解。

  [Gateway API](https://gateway-api.sigs.k8s.io/) 即將支持，並將支持從 Ingress API 平滑遷移至 Gateway API。
  
- **微服務網關**：

  Higress 可作為微服務網關，發現來自 Nacos、ZooKeeper、Consul、Eureka 等多種服務註冊中心的微服務。

  深度集成 [Dubbo](https://github.com/apache/dubbo)、[Nacos](https://github.com/alibaba/nacos)、[Sentinel](https://github.com/alibaba/Sentinel) 等微服務技術棧。

- **安全網關**：

  Higress 可作為安全網關，支持 WAF 和多種認證策略，如 key-auth、hmac-auth、jwt-auth、basic-auth、oidc 等。

## 核心優勢

- **生產級能力**

  源自阿里巴巴內部產品，歷經兩年以上生產環境驗證，支撐十萬級 QPS 的大規模場景。

  徹底消除 Nginx reload 導致的流量抖動，配置變更毫秒級生效，對業務透明。對於 AI 等長連接場景尤其友好。

- **流式處理**

  支持真正的請求/響應體全流式處理，Wasm 插件可自定義處理 SSE 等流式協議。

  在 AI 等高帶寬場景下能顯著降低內存開銷。
    
- **易擴展**
  
  提供豐富的官方插件庫，涵蓋 AI、流量治理、安全防護等常見功能，滿足 90% 以上業務場景需求。

  專注 Wasm 插件擴展，通過沙箱隔離保障內存安全，支持多語言編寫，插件版本可獨立升級，網關邏輯可無損熱更新。

- **安全易用**
  
  基於 Ingress API 和 Gateway API 標準，提供開箱即用的 UI 控制台、WAF 防護插件、IP/Cookie CC 防護插件。

  支持對接 Let's Encrypt，實現免費證書自動簽發與續期，可脫離 K8s 部署，單條 Docker 命令即可啟動，便於個人開發者體驗。

## 社群

歡迎加入我們的 Discord 社群！你可以在這裡與 Higress 的開發者和其他用戶互動交流。

[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=for-the-badge)](https://discord.gg/tSbww9VDaM)


### 鳴謝

Higress 得益於社群優秀開源項目的貢獻，特別鳴謝 Envoy 和 Istio。

### 相關倉庫

- Higress Console: https://github.com/higress-group/higress-console
- Higress Standalone: https://github.com/higress-group/higress-standalone

### 貢獻者

<a href="https://github.com/alibaba/higress/graphs/contributors">
  <img alt="contributors" src="https://contrib.rocks/image?repo=alibaba/higress"/>
</a>

### Star 歷史

[![Star History Chart](https://api.star-history.com/svg?repos=alibaba/higress&type=Date)](https://star-history.com/#alibaba/higress&Date)

<p align="right" style="font-size: 14px; color: #555; margin-top: 20px;">
    <a href="#readme-top" style="text-decoration: none; color: #007bff; font-weight: bold;">
        ↑ 回到頂部 ↑
    </a>
</p>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---