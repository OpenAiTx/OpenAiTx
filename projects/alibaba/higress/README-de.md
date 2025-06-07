<a name="readme-top"></a>
<h1 align="center">
    <img src="https://img.alicdn.com/imgextra/i2/O1CN01NwxLDd20nxfGBjxmZ_!!6000000006895-2-tps-960-290.png" alt="Higress" width="240" height="72.5">
  <br>
  KI-Gateway
</h1>
<h4 align="center"> KI-Natives API-Gateway </h4>

<div align="center">
    
[![Build Status](https://github.com/alibaba/higress/actions/workflows/build-and-test.yaml/badge.svg?branch=main)](https://github.com/alibaba/higress/actions)
[![license](https://img.shields.io/github/license/alibaba/higress.svg)](https://www.apache.org/licenses/LICENSE-2.0.html)
[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=flat-square)](https://discord.gg/tSbww9VDaM)

<a href="https://trendshift.io/repositories/10918" target="_blank"><img src="https://trendshift.io/api/badge/repositories/10918" alt="alibaba%2Fhigress | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a> <a href="https://www.producthunt.com/posts/higress?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-higress" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=951287&theme=light&t=1745492822283" alt="Higress - Global&#0032;APIs&#0032;as&#0032;MCP&#0032;powered&#0032;by&#0032;AI&#0032;Gateway | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

</div>

[**Offizielle Webseite**](https://higress.ai/en/) &nbsp; |
&nbsp; [**MCP Server Schnellstart**](https://higress.cn/en/ai/mcp-quick-start/) &nbsp; |
&nbsp; [**Wasm Plugin Hub**](https://higress.cn/en/plugin/) &nbsp; |

<p>
   English | <a href="README_ZH.md">中文<a/> | <a href="README_JP.md">日本語<a/>
</p>

## Was ist Higress?

Higress ist ein cloud-natives API-Gateway basierend auf Istio und Envoy, das mit Wasm-Plugins in Go/Rust/JS erweitert werden kann. Es bietet Dutzende von sofort einsatzbereiten universellen Plugins sowie eine Out-of-the-box-Konsole (testen Sie das [Demo hier](http://demo.higress.io/)).

### Zentrale Anwendungsfälle

Die KI-Gateway-Fähigkeiten von Higress unterstützen alle [gängigen Modellanbieter](https://raw.githubusercontent.com/alibaba/higress/main/plugins/wasm-go/extensions/ai-proxy/provider) im In- und Ausland. Es unterstützt zudem das Hosting von MCP (Model Context Protocol) Servern über seinen Plugin-Mechanismus, wodurch KI-Agenten einfach verschiedene Tools und Dienste ansprechen können. Mit dem [openapi-to-mcp Tool](https://github.com/higress-group/openapi-to-mcpserver) können Sie OpenAPI-Spezifikationen schnell in entfernte MCP-Server zum Hosting umwandeln. Higress ermöglicht das einheitliche Management sowohl für LLM-API als auch für MCP-API.

**🌟 Probieren Sie es jetzt aus unter [https://mcp.higress.ai/](https://mcp.higress.ai/)** und erleben Sie von Higress gehostete Remote-MCP-Server aus erster Hand:

![Higress MCP Server Plattform](https://img.alicdn.com/imgextra/i2/O1CN01nmVa0a1aChgpyyWOX_!!6000000003294-0-tps-3430-1742.jpg)

### Einsatz in Unternehmen

Higress entstand innerhalb von Alibaba, um die Probleme des Tengine-Reloads (der Langzeitverbindungen beeinträchtigte) und die unzureichenden Load-Balancing-Fähigkeiten bei gRPC/Dubbo zu lösen. Innerhalb von Alibaba Cloud unterstützen die KI-Gateway-Funktionen von Higress Kern-KI-Anwendungen wie das Tongyi Bailian Modellstudio, die Machine-Learning-PAI-Plattform und andere wichtige KI-Dienste. Alibaba Cloud hat sein cloud-natives API-Gateway-Produkt auf Basis von Higress aufgebaut und bietet damit für eine Vielzahl von Unternehmenskunden einen 99,99%-Gateway-Hochverfügbarkeitsservice.

## Inhaltsverzeichnis

- [**Schnellstart**](#schnellstart)    
- [**Feature-Showcase**](#feature-showcase)
- [**Anwendungsfälle**](#anwendungsfälle)
- [**Zentrale Vorteile**](#zentrale-vorteile)
- [**Community**](#community)

## Schnellstart

Higress kann direkt mit Docker gestartet werden, was es Entwicklern ermöglicht, es einfach lokal zu testen oder für einfache Seiten zu verwenden:

```bash
# Arbeitsverzeichnis anlegen
mkdir higress; cd higress
# Higress starten, Konfigurationsdateien werden ins Arbeitsverzeichnis geschrieben
docker run -d --rm --name higress-ai -v ${PWD}:/data \
        -p 8001:8001 -p 8080:8080 -p 8443:8443  \
        higress-registry.cn-hangzhou.cr.aliyuncs.com/higress/all-in-one:latest
```

Port-Beschreibungen:

- Port 8001: Higress UI-Konsole
- Port 8080: Gateway HTTP-Protokoll
- Port 8443: Gateway HTTPS-Protokoll

> Alle Higress Docker-Images verwenden das eigene Image-Repository und sind nicht von Docker Hub Rate Limits betroffen.
> Außerdem sind die Bereitstellung und Updates der Images durch einen Sicherheits-Scan-Mechanismus (powered by Alibaba Cloud ACR) geschützt, was sie besonders sicher für Produktionsumgebungen macht.
>
> Sollte es zu einem Timeout beim Pullen des Images von `higress-registry.cn-hangzhou.cr.aliyuncs.com` kommen, können Sie folgenden Docker Registry Mirror verwenden:
>
> **Südostasien**: `higress-registry.ap-southeast-7.cr.aliyuncs.com`

Für weitere Installationsmethoden wie Helm-Deployment unter K8s besuchen Sie bitte die offizielle [Schnellstart-Dokumentation](https://higress.io/en-us/docs/user/quickstart).

## Anwendungsfälle

- **MCP Server Hosting**:

  Higress hostet MCP Server über seinen Plugin-Mechanismus, sodass KI-Agenten einfach verschiedene Tools und Dienste ansprechen können. Mit dem [openapi-to-mcp Tool](https://github.com/higress-group/openapi-to-mcpserver) können Sie OpenAPI-Spezifikationen schnell in entfernte MCP-Server umwandeln.

  ![MCP Hosting](https://img.alicdn.com/imgextra/i1/O1CN01wv8H4g1mS4MUzC1QC_!!6000000004952-2-tps-1764-597.png)

  Zentrale Vorteile beim Hosting von MCP-Servern mit Higress:
  - Einheitliche Authentifizierungs- und Autorisierungsmechanismen
  - Feingranulares Rate-Limiting zum Schutz vor Missbrauch
  - Vollständige Audit-Logs für alle Tool-Aufrufe
  - Umfassende Observability zur Leistungsüberwachung
  - Vereinfachte Bereitstellung durch den Plugin-Mechanismus von Higress
  - Dynamische Updates ohne Unterbrechung oder Verbindungsabbrüche

     [Mehr erfahren...](https://higress.cn/en/ai/mcp-quick-start/?spm=36971b57.7beea2de.0.0.d85f20a94jsWGm)

- **KI-Gateway**:

  Higress verbindet sich mit allen LLM-Modellanbietern über ein einheitliches Protokoll und bietet KI-Observability, Multi-Modell-Lastverteilung, Token-Rate-Limiting und Caching:

  ![KI Gateway](https://img.alicdn.com/imgextra/i2/O1CN01izmBNX1jbHT7lP3Yr_!!6000000004566-0-tps-1920-1080.jpg)

- **Kubernetes Ingress Controller**:

  Higress kann als funktionsreicher Ingress-Controller betrieben werden und ist mit vielen Annotationen des K8s nginx Ingress Controllers kompatibel.
  
  Unterstützung für die [Gateway API](https://gateway-api.sigs.k8s.io/) folgt bald und ermöglicht eine reibungslose Migration von Ingress API zu Gateway API.
  
- **Microservice-Gateway**:

  Higress kann als Microservice-Gateway eingesetzt werden und Microservices aus verschiedenen Service-Registries wie Nacos, ZooKeeper, Consul, Eureka, etc. entdecken.
  
  Es integriert sich tief mit [Dubbo](https://github.com/apache/dubbo), [Nacos](https://github.com/alibaba/nacos), [Sentinel](https://github.com/alibaba/Sentinel) und weiteren Microservice-Technologien.
  
- **Sicherheits-Gateway**:

  Higress kann als Sicherheits-Gateway verwendet werden, unterstützt WAF und verschiedene Authentifizierungsstrategien wie key-auth, hmac-auth, jwt-auth, basic-auth, oidc, etc.

## Zentrale Vorteile

- **Produktionsreife**

  Entstanden aus einem internen Alibaba-Produkt mit über zwei Jahren Produktionserfahrung, unterstützt große Szenarien mit Hunderttausenden Requests pro Sekunde.

  Beseitigt vollständig Traffic-Jitter, der durch Nginx-Reloads verursacht wird; Konfigurationsänderungen greifen in Millisekunden und sind für das Business transparent. Besonders geeignet für Langzeitverbindungen wie im KI-Bereich.

- **Streaming-Verarbeitung**

  Unterstützt echte Streaming-Verarbeitung von Request-/Response-Bodys; Wasm-Plugins können einfach Streaming-Protokolle wie SSE (Server-Sent Events) anpassen.

  In Hochbandbreiten-Szenarien wie bei KI-Anwendungen wird der Speicherbedarf deutlich reduziert.
    
- **Einfache Erweiterbarkeit**
  
  Bietet eine umfangreiche Bibliothek offizieller Plugins für KI, Traffic-Management, Sicherheitsmechanismen und andere gängige Funktionen, die über 90% der Business-Anforderungen abdecken.

  Setzt den Fokus auf Wasm-Plugin-Erweiterungen, bietet Speichersicherheit durch Sandbox-Isolation, unterstützt mehrere Programmiersprachen, ermöglicht unabhängige Plugin-Versionierung und trafficverlustfreie Hot-Updates der Gateway-Logik.

- **Sicher und einfach zu bedienen**
  
  Basierend auf Ingress API und Gateway API Standards, bietet eine sofort einsatzbereite UI-Konsole, WAF-Plugin, IP/Cookie-CC-Schutzplugin.

  Unterstützt die Verbindung zu Let's Encrypt für automatische und kostenlose Zertifikatsausstellung und -erneuerung, kann außerhalb von K8s mit einem einzigen Docker-Befehl betrieben werden – ideal für Einzelentwickler.

## Community

Treten Sie unserer Discord-Community bei! Hier können Sie sich mit Entwicklern und anderen engagierten Nutzern von Higress vernetzen.

[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=for-the-badge)](https://discord.gg/tSbww9VDaM)

### Danke

Higress wäre ohne die wertvolle Open-Source-Arbeit aus der Community nicht möglich. Ein besonderer Dank gilt Envoy und Istio.

### Verwandte Repositories

- Higress Console: https://github.com/higress-group/higress-console
- Higress Standalone: https://github.com/higress-group/higress-standalone

### Mitwirkende

<a href="https://github.com/alibaba/higress/graphs/contributors">
  <img alt="contributors" src="https://contrib.rocks/image?repo=alibaba/higress"/>
</a>

### Sternenverlauf

[![Star History Chart](https://api.star-history.com/svg?repos=alibaba/higress&type=Date)](https://star-history.com/#alibaba/higress&Date)

<p align="right" style="font-size: 14px; color: #555; margin-top: 20px;">
    <a href="#readme-top" style="text-decoration: none; color: #007bff; font-weight: bold;">
        ↑ Zurück zum Anfang ↑
    </a>
</p>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---