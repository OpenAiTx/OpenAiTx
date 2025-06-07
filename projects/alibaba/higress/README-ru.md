<a name="readme-top"></a>
<h1 align="center">
    <img src="https://img.alicdn.com/imgextra/i2/O1CN01NwxLDd20nxfGBjxmZ_!!6000000006895-2-tps-960-290.png" alt="Higress" width="240" height="72.5">
  <br>
  AI Gateway
</h1>
<h4 align="center"> AI-родной API-шлюз </h4>

<div align="center">
    
[![Build Status](https://github.com/alibaba/higress/actions/workflows/build-and-test.yaml/badge.svg?branch=main)](https://github.com/alibaba/higress/actions)
[![license](https://img.shields.io/github/license/alibaba/higress.svg)](https://www.apache.org/licenses/LICENSE-2.0.html)
[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=flat-square)](https://discord.gg/tSbww9VDaM)

<a href="https://trendshift.io/repositories/10918" target="_blank"><img src="https://trendshift.io/api/badge/repositories/10918" alt="alibaba%2Fhigress | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a> <a href="https://www.producthunt.com/posts/higress?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-higress" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=951287&theme=light&t=1745492822283" alt="Higress - Global&#0032;APIs&#0032;as&#0032;MCP&#0032;powered&#0032;by&#0032;AI&#0032;Gateway | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

</div>

[**Официальный сайт**](https://higress.ai/en/) &nbsp; |
&nbsp; [**MCP Server QuickStart**](https://higress.cn/en/ai/mcp-quick-start/) &nbsp; |
&nbsp; [**Wasm Plugin Hub**](https://higress.cn/en/plugin/) &nbsp; |

<p>
   English | <a href="README_ZH.md">中文<a/> | <a href="README_JP.md">日本語<a/>
</p>

## Что такое Higress?

Higress — это облачно-родной API-шлюз на основе Istio и Envoy, который можно расширять с помощью Wasm-плагинов, написанных на Go/Rust/JS. Он предоставляет десятки готовых к использованию универсальных плагинов и консоль "из коробки" (попробуйте [демо здесь](http://demo.higress.io/)).

### Основные сценарии использования

AI-возможности шлюза Higress поддерживают всех [основных провайдеров моделей](https://raw.githubusercontent.com/alibaba/higress/main/plugins/wasm-go/extensions/ai-proxy/provider) как внутри страны, так и за рубежом. Также поддерживается размещение серверов MCP (Model Context Protocol) через механизм плагинов, что позволяет AI-агентам легко вызывать различные инструменты и сервисы. С помощью инструмента [openapi-to-mcp](https://github.com/higress-group/openapi-to-mcpserver) вы можете быстро конвертировать спецификации OpenAPI в удалённые MCP-серверы для размещения. Higress предоставляет унифицированное управление как для LLM API, так и для MCP API.

**🌟 Попробуйте прямо сейчас на [https://mcp.higress.ai/](https://mcp.higress.ai/)** и испытайте удалённые MCP-серверы, размещённые на Higress:

![Платформа Higress MCP Server](https://img.alicdn.com/imgextra/i2/O1CN01nmVa0a1aChgpyyWOX_!!6000000003294-0-tps-3430-1742.jpg)

### Корпоративное внедрение

Higress был создан внутри Alibaba для решения проблем с перезагрузкой Tengine, влияющей на сервисы с длинными соединениями, а также недостаточной балансировки нагрузки для gRPC/Dubbo. Внутри Alibaba Cloud возможности AI-шлюза Higress поддерживают ключевые AI-приложения, такие как студия моделей Tongyi Bailian, платформа машинного обучения PAI и другие критически важные AI-сервисы. Alibaba Cloud построила собственный продукт облачного API-шлюза на базе Higress, предоставляя гарантию высокой доступности шлюза 99,99% для множества корпоративных клиентов.

## Содержание

- [**Быстрый старт**](#quick-start)    
- [**Демонстрация возможностей**](#feature-showcase)
- [**Сценарии использования**](#use-cases)
- [**Ключевые преимущества**](#core-advantages)
- [**Сообщество**](#community)

## Быстрый старт

Higress можно запустить просто с помощью Docker, что удобно для индивидуальных разработчиков для локального изучения или создания простых сайтов:

```bash
# Создайте рабочий каталог
mkdir higress; cd higress
# Запустите higress, конфигурационные файлы будут записываться в рабочий каталог
docker run -d --rm --name higress-ai -v ${PWD}:/data \
        -p 8001:8001 -p 8080:8080 -p 8443:8443  \
        higress-registry.cn-hangzhou.cr.aliyuncs.com/higress/all-in-one:latest
```

Описание портов:

- Порт 8001: Вход в UI-консоль Higress
- Порт 8080: Вход HTTP-протокола шлюза
- Порт 8443: Вход HTTPS-протокола шлюза

> Все Docker-образы Higress используют собственный репозиторий образов Higress и не подвержены ограничениям по частоте Docker Hub.
> Кроме того, публикация и обновления образов защищены механизмом сканирования безопасности (на базе Alibaba Cloud ACR), что делает их очень безопасными для использования в продуктивных средах.
>
> Если вы столкнулись с тайм-аутом при загрузке образа с `higress-registry.cn-hangzhou.cr.aliyuncs.com`, попробуйте заменить на следующий зеркальный источник docker-репозитория:
>
> **Юго-Восточная Азия**: `higress-registry.ap-southeast-7.cr.aliyuncs.com`

Для других способов установки, таких как развёртывание Helm в K8s, пожалуйста, обратитесь к официальной [документации по быстрому старту](https://higress.io/en-us/docs/user/quickstart).

## Сценарии использования

- **Размещение MCP-сервера**:

  Higress размещает MCP-серверы через свой механизм плагинов, позволяя AI-агентам легко вызывать различные инструменты и сервисы. С помощью инструмента [openapi-to-mcp](https://github.com/higress-group/openapi-to-mcpserver) можно быстро конвертировать спецификации OpenAPI в удалённые MCP-серверы.

  ![](https://img.alicdn.com/imgextra/i1/O1CN01wv8H4g1mS4MUzC1QC_!!6000000004952-2-tps-1764-597.png)

  Основные преимущества размещения MCP-серверов с помощью Higress:
  - Унифицированные механизмы аутентификации и авторизации
  - Тонкая настройка лимитов запросов для предотвращения злоупотреблений
  - Полные аудиторские логи всех вызовов инструментов
  - Богатая наблюдаемость для мониторинга производительности
  - Упрощённое развёртывание через механизм плагинов Higress
  - Динамические обновления без прерываний и потери соединения

     [Подробнее...](https://higress.cn/en/ai/mcp-quick-start/?spm=36971b57.7beea2de.0.0.d85f20a94jsWGm)

- **AI-шлюз**:

  Higress подключается ко всем поставщикам LLM-моделей по единому протоколу, с поддержкой AI-наблюдаемости, балансировкой нагрузки между моделями, ограничением токенов и кэшированием:

  ![](https://img.alicdn.com/imgextra/i2/O1CN01izmBNX1jbHT7lP3Yr_!!6000000004566-0-tps-1920-1080.jpg)

- **Kubernetes ingress controller**:

  Higress может работать как многофункциональный ingress-контроллер, совместимый со многими аннотациями nginx ingress-контроллера K8s.

  [Поддержка Gateway API](https://gateway-api.sigs.k8s.io/) появится в ближайшее время и позволит плавно мигрировать с Ingress API на Gateway API.

- **Микросервисный шлюз**:

  Higress может функционировать как шлюз микросервисов, обнаруживая сервисы из различных реестров, таких как Nacos, ZooKeeper, Consul, Eureka и др.

  Глубоко интегрируется с [Dubbo](https://github.com/apache/dubbo), [Nacos](https://github.com/alibaba/nacos), [Sentinel](https://github.com/alibaba/Sentinel) и другими технологиями микросервисов.

- **Безопасный шлюз**:

  Higress может использоваться как безопасный шлюз, поддерживающий WAF и различные стратегии аутентификации, такие как key-auth, hmac-auth, jwt-auth, basic-auth, oidc и др.

## Ключевые преимущества

- **Промышленная надёжность**

  Родился из внутреннего продукта Alibaba и прошёл более 2 лет в продуктивной эксплуатации, поддерживая крупномасштабные сценарии с сотнями тысяч запросов в секунду.

  Полностью устраняет дрожание трафика, вызываемое перезагрузкой Nginx; изменения конфигурации вступают в силу за миллисекунды и прозрачно для бизнеса. Особенно дружественно к сценариям с длинными соединениями, например, для AI-сервисов.

- **Потоковая обработка**

  Поддерживает полноценную потоковую обработку тел запросов/ответов, Wasm-плагины легко кастомизируют обработку потоковых протоколов, таких как SSE (Server-Sent Events).

  В сценариях с высокой пропускной способностью, например, для AI-бизнеса, это позволяет значительно снизить расход памяти.
    
- **Лёгкость расширения**
  
  Предлагает богатую библиотеку официальных плагинов для AI, управления трафиком, защиты и других общих функций, покрывая свыше 90% бизнес-сценариев.

  Сосредоточен на расширениях через Wasm-плагины, обеспечивает безопасность памяти через изоляцию в песочнице, поддерживает несколько языков программирования, позволяет обновлять версии плагинов независимо и реализует горячее обновление логики шлюза без потерь трафика.

- **Безопасность и простота**
  
  На основе стандартов Ingress API и Gateway API, предоставляет UI-консоль "из коробки", плагин WAF-защиты, плагин защиты от CC-атак по IP/Cookie.

  Поддерживает подключение к Let's Encrypt для автоматического выпуска и обновления бесплатных сертификатов, может быть развёрнут вне K8s, запускается одной командой Docker — удобно для индивидуальных разработчиков.

## Сообщество

Присоединяйтесь к нашему сообществу в Discord! Здесь вы сможете общаться с разработчиками и другими энтузиастами Higress.

[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=for-the-badge)](https://discord.gg/tSbww9VDaM)


### Благодарности

Higress не был бы возможен без ценной работы над проектами с открытым исходным кодом. Особая благодарность проектам Envoy и Istio.

### Связанные репозитории

- Higress Console: https://github.com/higress-group/higress-console
- Higress Standalone: https://github.com/higress-group/higress-standalone

### Контрибьюторы

<a href="https://github.com/alibaba/higress/graphs/contributors">
  <img alt="contributors" src="https://contrib.rocks/image?repo=alibaba/higress"/>
</a>

### История звёзд

[![Star History Chart](https://api.star-history.com/svg?repos=alibaba/higress&type=Date)](https://star-history.com/#alibaba/higress&Date)

<p align="right" style="font-size: 14px; color: #555; margin-top: 20px;">
    <a href="#readme-top" style="text-decoration: none; color: #007bff; font-weight: bold;">
        ↑ Наверх ↑
    </a>
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---