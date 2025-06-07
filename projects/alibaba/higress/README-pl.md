<a name="readme-top"></a>
<h1 align="center">
    <img src="https://img.alicdn.com/imgextra/i2/O1CN01NwxLDd20nxfGBjxmZ_!!6000000006895-2-tps-960-290.png" alt="Higress" width="240" height="72.5">
  <br>
  Brama AI
</h1>
<h4 align="center"> AI Native API Gateway </h4>

<div align="center">
    
[![Build Status](https://github.com/alibaba/higress/actions/workflows/build-and-test.yaml/badge.svg?branch=main)](https://github.com/alibaba/higress/actions)
[![license](https://img.shields.io/github/license/alibaba/higress.svg)](https://www.apache.org/licenses/LICENSE-2.0.html)
[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=flat-square)](https://discord.gg/tSbww9VDaM)

<a href="https://trendshift.io/repositories/10918" target="_blank"><img src="https://trendshift.io/api/badge/repositories/10918" alt="alibaba%2Fhigress | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a> <a href="https://www.producthunt.com/posts/higress?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-higress" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=951287&theme=light&t=1745492822283" alt="Higress - Global&#0032;APIs&#0032;as&#0032;MCP&#0032;powered&#0032;by&#0032;AI&#0032;Gateway | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

</div>

[**Oficjalna Strona**](https://higress.ai/en/) &nbsp; |
&nbsp; [**Szybki start MCP Server**](https://higress.cn/en/ai/mcp-quick-start/) &nbsp; |
&nbsp; [**Wasm Plugin Hub**](https://higress.cn/en/plugin/) &nbsp; |

<p>
   English | <a href="README_ZH.md">中文<a/> | <a href="README_JP.md">日本語<a/>
</p>

## Czym jest Higress?

Higress to cloud-native API gateway oparty na Istio i Envoy, który można rozszerzać za pomocą wtyczek Wasm pisanych w Go/Rust/JS. Oferuje dziesiątki gotowych do użycia, uniwersalnych wtyczek oraz konsolę out-of-the-box (wypróbuj [demo tutaj](http://demo.higress.io/)).

### Kluczowe przypadki użycia

Funkcje bramy AI Higress obsługują wszystkich [głównych dostawców modeli](https://raw.githubusercontent.com/alibaba/higress/main/plugins/wasm-go/extensions/ai-proxy/provider) zarówno krajowych, jak i zagranicznych. Wspiera również hosting serwerów MCP (Model Context Protocol) poprzez mechanizm wtyczek, umożliwiając agentom AI łatwe wywoływanie różnych narzędzi i usług. Dzięki narzędziu [openapi-to-mcp](https://github.com/higress-group/openapi-to-mcpserver) możesz szybko konwertować specyfikacje OpenAPI na zdalne serwery MCP do hostowania. Higress zapewnia zunifikowane zarządzanie zarówno dla LLM API, jak i MCP API.

**🌟 Wypróbuj już teraz na [https://mcp.higress.ai/](https://mcp.higress.ai/)**, aby doświadczyć zdalnych serwerów MCP hostowanych przez Higress:

![Platforma Higress MCP Server](https://img.alicdn.com/imgextra/i2/O1CN01nmVa0a1aChgpyyWOX_!!6000000003294-0-tps-3430-1742.jpg)

### Wykorzystanie w przedsiębiorstwach

Higress powstał w Alibaba, aby rozwiązać problemy związane z przeładowywaniem Tengine wpływającym na usługi z długimi połączeniami oraz niewystarczającymi możliwościami load balancingu dla gRPC/Dubbo. W ramach Alibaba Cloud, możliwości bramy AI Higress wspierają kluczowe aplikacje AI, takie jak studio modeli Tongyi Bailian, platforma uczenia maszynowego PAI i inne krytyczne usługi AI. Alibaba Cloud zbudował swój produkt cloud-native API gateway w oparciu o Higress, zapewniając dostępność bramy na poziomie 99,99% dla wielu klientów korporacyjnych.

## Podsumowanie

- [**Szybki start**](#quick-start)    
- [**Przegląd funkcji**](#feature-showcase)
- [**Przypadki użycia**](#use-cases)
- [**Kluczowe zalety**](#core-advantages)
- [**Społeczność**](#community)

## Szybki start

Higress można uruchomić za pomocą Dockera, co umożliwia indywidualnym deweloperom szybkie uruchomienie środowiska lokalnego do nauki lub budowy prostych stron:

```bash
# Utwórz katalog roboczy
mkdir higress; cd higress
# Uruchom higress, pliki konfiguracyjne będą zapisane w katalogu roboczym
docker run -d --rm --name higress-ai -v ${PWD}:/data \
        -p 8001:8001 -p 8080:8080 -p 8443:8443  \
        higress-registry.cn-hangzhou.cr.aliyuncs.com/higress/all-in-one:latest
```

Opis portów:

- Port 8001: Wejście do konsoli UI Higress
- Port 8080: Wejście do bramy protokołu HTTP
- Port 8443: Wejście do bramy protokołu HTTPS

> Wszystkie obrazy Dockera Higress korzystają z własnego repozytorium obrazów Higress i nie są objęte limitami Docker Hub.
> Dodatkowo, zgłoszenia i aktualizacje obrazów są chronione przez mechanizm skanowania bezpieczeństwa (powered by Alibaba Cloud ACR), co czyni je bardzo bezpiecznymi do użycia w środowiskach produkcyjnych.
> 
> W przypadku wystąpienia timeoutu podczas pobierania obrazu z `higress-registry.cn-hangzhou.cr.aliyuncs.com`, możesz spróbować zastąpić go poniższym mirror source docker registry:
> 
> **Azja Południowo-Wschodnia**: `higress-registry.ap-southeast-7.cr.aliyuncs.com`

W przypadku innych metod instalacji, takich jak wdrożenie Helm na K8s, zapoznaj się z oficjalną [dokumentacją szybkiego startu](https://higress.io/en-us/docs/user/quickstart).

## Przypadki użycia

- **Hosting serwerów MCP**:

  Higress hostuje serwery MCP poprzez mechanizm wtyczek, umożliwiając agentom AI łatwe wywoływanie różnych narzędzi i usług. Dzięki narzędziu [openapi-to-mcp](https://github.com/higress-group/openapi-to-mcpserver) możesz szybko konwertować specyfikacje OpenAPI na zdalne serwery MCP.

  ![Hosting MCP](https://img.alicdn.com/imgextra/i1/O1CN01wv8H4g1mS4MUzC1QC_!!6000000004952-2-tps-1764-597.png)

  Kluczowe zalety hostingu serwerów MCP w Higress:
  - Zunifikowane mechanizmy uwierzytelniania i autoryzacji
  - Precyzyjne limity prędkości, zapobiegające nadużyciom
  - Kompleksowe logi audytowe dla wszystkich wywołań narzędzi
  - Rozbudowana obserwowalność do monitorowania wydajności
  - Uproszczone wdrażanie dzięki mechanizmowi wtyczek Higress
  - Dynamiczne aktualizacje bez przestojów i zrywania połączeń

     [Dowiedz się więcej...](https://higress.cn/en/ai/mcp-quick-start/?spm=36971b57.7beea2de.0.0.d85f20a94jsWGm)

- **Brama AI**:

  Higress łączy się ze wszystkimi dostawcami modeli LLM za pomocą zunifikowanego protokołu, oferując obserwowalność AI, load balancing dla wielu modeli, ograniczanie liczby tokenów i funkcje cache'owania:

  ![AI Gateway](https://img.alicdn.com/imgextra/i2/O1CN01izmBNX1jbHT7lP3Yr_!!6000000004566-0-tps-1920-1080.jpg)

- **Kubernetes ingress controller**:

  Higress może działać jako zaawansowany ingress controller, kompatybilny z wieloma adnotacjami nginx ingress controller dla K8s.
  
  Wsparcie dla [Gateway API](https://gateway-api.sigs.k8s.io/) już wkrótce, umożliwiając płynne przejście z Ingress API na Gateway API.
  
- **Brama mikrousług**:

  Higress może działać jako brama mikrousług, odkrywając mikrousługi z różnych rejestrów usług, takich jak Nacos, ZooKeeper, Consul, Eureka, itd.
  
  Głęboka integracja z [Dubbo](https://github.com/apache/dubbo), [Nacos](https://github.com/alibaba/nacos), [Sentinel](https://github.com/alibaba/Sentinel) i innymi technologiami mikrousług.
  
- **Brama bezpieczeństwa**:

  Higress może być używany jako brama bezpieczeństwa, wspierając WAF oraz różne strategie uwierzytelniania, takie jak key-auth, hmac-auth, jwt-auth, basic-auth, oidc, itd.


## Kluczowe zalety

- **Klasa produkcyjna**

  Produkt wywodzący się z wewnętrznych rozwiązań Alibaba, z ponad 2-letnią weryfikacją w środowisku produkcyjnym, obsługujący scenariusze na dużą skalę z setkami tysięcy żądań na sekundę.

  Całkowicie eliminuje drgania ruchu powodowane przeładowaniem Nginx, zmiany konfiguracji wchodzą w życie w milisekundach i są przezroczyste dla biznesu. Szczególnie przyjazny dla scenariuszy z długimi połączeniami, takich jak usługi AI.

- **Przetwarzanie strumieniowe**

  Wspiera pełne przetwarzanie strumieniowe ciał żądań/odpowiedzi, wtyczki Wasm mogą łatwo dostosować obsługę protokołów strumieniowych, takich jak SSE (Server-Sent Events).

  W scenariuszach o dużej przepustowości, takich jak AI, znacząco redukuje zużycie pamięci.
    
- **Łatwość rozszerzania**
  
  Oferuje bogatą oficjalną bibliotekę wtyczek obejmującą AI, zarządzanie ruchem, ochronę bezpieczeństwa i inne powszechne funkcje, spełniając ponad 90% wymagań scenariuszy biznesowych.

  Skupia się na rozszerzeniach wtyczek Wasm, zapewniając bezpieczeństwo pamięci dzięki izolacji sandbox, obsługuje wiele języków programowania, umożliwia niezależną aktualizację wersji wtyczek oraz bezstratne dla ruchu hot update logiki bramy.

- **Bezpieczeństwo i łatwość użycia**
  
  Bazując na standardach Ingress API i Gateway API, oferuje gotową do użycia konsolę UI, wtyczkę ochrony WAF, gotowe do użycia wtyczki ochrony IP/Cookie CC.

  Wspiera integrację z Let's Encrypt w celu automatycznego wydawania i odnawiania darmowych certyfikatów oraz może być wdrażany poza K8s, uruchamiany jednym poleceniem Dockera, wygodny dla indywidualnych deweloperów.

## Społeczność

Dołącz do naszej społeczności na Discordzie! To miejsce, gdzie możesz nawiązać kontakt z deweloperami i innymi entuzjastami Higress.

[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=for-the-badge)](https://discord.gg/tSbww9VDaM)


### Podziękowania

Higress nie byłby możliwy bez wartościowych projektów open-source w społeczności. Szczególne podziękowania dla Envoy i Istio.

### Powiązane repozytoria

- Higress Console: https://github.com/higress-group/higress-console
- Higress Standalone: https://github.com/higress-group/higress-standalone

### Współtwórcy

<a href="https://github.com/alibaba/higress/graphs/contributors">
  <img alt="contributors" src="https://contrib.rocks/image?repo=alibaba/higress"/>
</a>

### Historia gwiazdek

[![Star History Chart](https://api.star-history.com/svg?repos=alibaba/higress&type=Date)](https://star-history.com/#alibaba/higress&Date)

<p align="right" style="font-size: 14px; color: #555; margin-top: 20px;">
    <a href="#readme-top" style="text-decoration: none; color: #007bff; font-weight: bold;">
        ↑ Powrót na górę ↑
    </a>
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---