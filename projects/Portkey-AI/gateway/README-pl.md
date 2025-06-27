<p align="right">
   <strong>Polski</strong> | <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.cn.md">中文</a> | <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.jp.md">日本語</a>
</p>

<div align="center">

<a href="https://portkey.sh/report-github"><img src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Frame.png"></img></a>
<br>

# AI Gateway
#### Kieruj do 250+ LLM-ów przez 1 szybkie i przyjazne API

<img src="https://cfassets.portkey.ai/sdk.gif" width="550px" alt="Demo Portkey AI Gateway prezentujące możliwości routingu LLM" style="margin-left:-35px">

[Dokumentacja](https://portkey.wiki/gh-1) | [Enterprise](https://portkey.wiki/gh-2) | [Hosted Gateway](https://portkey.wiki/gh-3) | [Changelog](https://portkey.wiki/gh-4) | [API Reference](https://portkey.wiki/gh-5)


[![License](https://img.shields.io/github/license/Ileriayo/markdown-badges)](https://raw.githubusercontent.com/Portkey-AI/gateway/main/LICENSE)
[![Discord](https://img.shields.io/discord/1143393887742861333)](https://portkey.wiki/gh-6)
[![Twitter](https://img.shields.io/twitter/url/https/twitter/follow/portkeyai?style=social&label=Follow%20%40PortkeyAI)](https://portkey.wiki/gh-7)
[![npm version](https://badge.fury.io/js/%40portkey-ai%2Fgateway.svg)](https://portkey.wiki/gh-8)
[![Better Stack Badge](https://uptime.betterstack.com/status-badges/v1/monitor/q94g.svg)](https://portkey.wiki/gh-9)

<a href="https://us-east-1.console.aws.amazon.com/cloudformation/home?region=us-east-1#/stacks/quickcreate?stackName=portkey-gateway&templateURL=https://portkey-gateway-ec2-quicklaunch.s3.us-east-1.amazonaws.com/portkey-gateway-ec2-quicklaunch.template.yaml"><img src="https://img.shields.io/badge/Deploy_to_EC2-232F3E?style=for-the-badge&logo=amazonwebservices&logoColor=white" alt="Deploy to AWS EC2" width="105"/></a> [![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/Portkey-AI/gateway)
</div>

<br/>

[**AI Gateway**](https://portkey.wiki/gh-10) został zaprojektowany do szybkiego, niezawodnego i bezpiecznego routingu do ponad 1600 modeli językowych, wizji, audio i obrazów. To lekkie, otwartoźródłowe i gotowe na wdrożenia korporacyjne rozwiązanie, które pozwala zintegrować dowolny model językowy w mniej niż 2 minuty.

- [x] **Błyskawicznie szybki** (<1ms opóźnienia) przy minimalnym rozmiarze (122kb)
- [x] **Sprawdzony w boju**, obsługujący ponad 10 mld tokenów dziennie
- [x] **Gotowy dla przedsiębiorstw** – zwiększone bezpieczeństwo, skalowalność i wdrożenia pod klienta

<br>

#### Co możesz zrobić z AI Gateway?
- Zintegruj się z dowolnym LLM w mniej niż 2 minuty – [Szybki start](#quickstart-2-mins)
- Zapobiegaj przestojom dzięki **[automatycznym ponownym próbom](https://portkey.wiki/gh-11)** i **[mechanizmom awaryjnym](https://portkey.wiki/gh-12)**
- Skaluj aplikacje AI z **[load balancingiem](https://portkey.wiki/gh-13)** i **[routingiem warunkowym](https://portkey.wiki/gh-14)**
- Chroń swoje wdrożenia AI za pomocą **[guardrails](https://portkey.wiki/gh-15)**
- Wyjdź poza tekst dzięki **[możliwościom multimodalnym](https://portkey.wiki/gh-16)**
- Odkryj integracje **[agentowych workflow](https://portkey.wiki/gh-17)**

<br><br>

> [!TIP]
> Oznacz gwiazdką ten repozytorium, aby więcej deweloperów mogło odkryć AI Gateway 🙏🏻
>
> ![star-2](https://github.com/user-attachments/assets/53597dce-6333-4ecc-a154-eb05532954e4)
> 
<br>


<br>

## Szybki start (2 minuty)

### 1. Uruchom swój AI Gateway

```bash
# Uruchom gateway lokalnie (wymagane Node.js i npm)
npx @portkey-ai/gateway
```
> Gateway działa pod adresem `http://localhost:8787/v1`
> 
> Konsola Gateway jest dostępna pod `http://localhost:8787/public/`

<sup>
Przewodniki wdrożeniowe:
&nbsp; <a href="https://portkey.wiki/gh-18"><img height="12" width="12" src="https://cfassets.portkey.ai/logo/dew-color.svg" /> Portkey Cloud (zalecane)</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#docker"><img height="12" width="12" src="https://cdn.simpleicons.org/docker/3776AB" /> Docker</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#nodejs-server"><img height="12" width="12" src="https://cdn.simpleicons.org/node.js/3776AB" /> Node.js</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#cloudflare-workers"><img height="12" width="12" src="https://cdn.simpleicons.org/cloudflare/3776AB" /> Cloudflare</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#replit"><img height="12" width="12" src="https://cdn.simpleicons.org/replit/3776AB" /> Replit</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md"> Inne...</a>

</sup>

### 2. Wykonaj swoje pierwsze zapytanie

<!-- <details open>
<summary>Python Example</summary> -->
```python
# pip install -qU portkey-ai

from portkey_ai import Portkey

# Klient kompatybilny z OpenAI
client = Portkey(
    provider="openai", # lub 'anthropic', 'bedrock', 'groq', itd.
    Authorization="sk-***" # klucz API dostawcy
)

# Wyślij zapytanie przez AI Gateway
client.chat.completions.create(
    messages=[{"role": "user", "content": "Jaka jest pogoda?"}],
    model="gpt-4o-mini"
)
```



<sup>Obsługiwane biblioteki:
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/javascript/3776AB" /> JS](https://portkey.wiki/gh-19)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/python/3776AB" /> Python](https://portkey.wiki/gh-20)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/gnubash/3776AB" /> REST](https://portkey.sh/gh-84)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/openai/3776AB" /> OpenAI SDKs](https://portkey.wiki/gh-21)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/langchain/3776AB" /> Langchain](https://portkey.wiki/gh-22)
&nbsp; [LlamaIndex](https://portkey.wiki/gh-23)
&nbsp; [Autogen](https://portkey.wiki/gh-24)
&nbsp; [CrewAI](https://portkey.wiki/gh-25)
&nbsp; [Więcej..](https://portkey.wiki/gh-26)
</sup>

W Konsoli Gateway (`http://localhost:8787/public/`) możesz zobaczyć wszystkie lokalne logi w jednym miejscu.

<img src="https://github.com/user-attachments/assets/362bc916-0fc9-43f1-a39e-4bd71aac4a3a" width="400" />


### 3. Routing i Guardrails
`Configs` w gateway LLM pozwalają tworzyć reguły routingu, zwiększać niezawodność i ustawiać guardrails.
```python
config = {
  "retry": {"attempts": 5},

  "output_guardrails": [{
    "default.contains": {"operator": "none", "words": ["Apple"]},
    "deny": True
  }]
}

# Dołącz konfigurację do klienta
client = client.with_options(config=config)

client.chat.completions.create(
    model="gpt-4o-mini",
    messages=[{"role": "user", "content": "Odpowiedz losowo 'Apple' lub 'Bat'"}]
)

# Odpowiedź zawsze będzie zawierać "Bat", ponieważ guardrail blokuje odpowiedzi zawierające "Apple". Konfiguracja retry wykona 5 prób przed rezygnacją.
```
<div align="center">
<img src="https://portkey.ai/blog/content/images/size/w1600/2024/11/image-15.png" width=600 title="Przepływ zapytania przez AI Gateway Portkey z retry i guardrails" alt="Przepływ zapytania przez AI Gateway Portkey z retry i guardrails"/>
</div>

Możesz zrobić znacznie więcej z konfiguracjami w swoim AI Gateway. [Przejdź do przykładów  →](https://portkey.wiki/gh-27)

<br/>

### Wersja Enterprise (Prywatne wdrożenia)

<sup>

[<img height="12" width="12" src="https://cfassets.portkey.ai/amazon-logo.svg" /> AWS](https://portkey.wiki/gh-28)
&nbsp; [<img height="12" width="12" src="https://cfassets.portkey.ai/azure-logo.svg" /> Azure](https://portkey.wiki/gh-29)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/googlecloud/3776AB" /> GCP](https://portkey.wiki/gh-30)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/redhatopenshift/3776AB" /> OpenShift](https://portkey.wiki/gh-31)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/kubernetes/3776AB" /> Kubernetes](https://portkey.wiki/gh-85)

</sup>

[Wersja enterprise](https://portkey.wiki/gh-86) gatewaya LLM oferuje zaawansowane możliwości w zakresie **zarządzania organizacją**, **nadzoru**, **bezpieczeństwa** i [więcej](https://portkey.wiki/gh-87) od razu po wdrożeniu. [Zobacz porównanie funkcji →](https://portkey.wiki/gh-32)

Architektura wdrożeniowa dla obsługiwanych platform dostępna jest tutaj – [**Enterprise Private Cloud Deployments**](https://portkey.wiki/gh-33)

<a href="https://portkey.sh/demo-13"><img src="https://portkey.ai/blog/content/images/2024/08/Get-API-Key--5-.png" height=50 alt="Umów demo AI gatewaya dla przedsiębiorstw" /></a><br/>


<br>

<hr>

### Godziny Inżynierii AI

Dołącz do cotygodniowych spotkań społeczności w każdy piątek (8:00 PT), aby rozpocząć wdrożenie AI Gateway! [Odbywają się w każdy piątek](https://portkey.wiki/gh-35)

<a href="https://portkey.wiki/gh-35"><img width="500" src="https://github.com/user-attachments/assets/c2885699-f197-4289-b819-21eb839fbae1" /></a>

Protokół spotkań [publikowany tutaj](https://portkey.wiki/gh-36).


<hr>

### LLMs w Produkcji '25

Wnioski z analizy ponad 2 bilionów tokenów, w 90+ regionach i 650+ zespołach produkcyjnych. Co znajdziesz w tym raporcie:
- Trendy kształtujące adopcję AI i rozwój dostawców LLM.
- Benchmarki optymalizujące szybkość, koszt i niezawodność.
- Strategie skalowania systemów AI klasy produkcyjnej.

<a href="https://portkey.sh/report-github"><img width="500" src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Image.png" /></a>

<a href="https://portkey.sh/report-github">**Pobierz raport**</a>
<hr>


## Kluczowe funkcje
### Niezawodny routing
- <a href="https://portkey.wiki/gh-37">**Mechanizmy awaryjne (Fallbacks)**</a>: Przełączanie na innego dostawcę lub model w przypadku nieudanych żądań za pomocą bramki LLM. Możesz określić błędy, które mają wywoływać mechanizm awaryjny. Zwiększa niezawodność Twojej aplikacji.
- <a href="https://portkey.wiki/gh-38">**Automatyczne ponawianie prób (Automatic Retries)**</a>: Automatyczne ponawianie nieudanych żądań do 5 razy. Strategia wykładniczego opóźnienia rozkłada próby ponawiania, aby zapobiec przeciążeniu sieci.
- <a href="https://portkey.wiki/gh-39">**Równoważenie obciążenia (Load Balancing)**</a>: Rozdzielaj żądania LLM pomiędzy wiele kluczy API lub dostawców AI z wagami, aby zapewnić wysoką dostępność i optymalną wydajność.
- <a href="https://portkey.wiki/gh-40">**Limity czasu żądania (Request Timeouts)**</a>: Zarządzaj nieprzewidywalnymi LLM i opóźnieniami, ustawiając szczegółowe limity czasu żądań, co pozwala na automatyczne zakończenie żądań przekraczających określony czas.
- <a href="https://portkey.wiki/gh-41">**Wielomodalna bramka LLM (Multi-modal LLM Gateway)**</a>: Wywołuj modele wizji, audio (zamiana tekstu na mowę i mowy na tekst) oraz generowania obrazów od wielu dostawców — wszystko z użyciem znajomego podpisu OpenAI.
- <a href="https://portkey.wiki/gh-42">**API w czasie rzeczywistym (Realtime APIs)**</a>: Wywołuj API w czasie rzeczywistym uruchamiane przez OpenAI poprzez zintegrowany serwer websocket.

### Bezpieczeństwo i dokładność
- <a href="https://portkey.wiki/gh-88">**Szyny bezpieczeństwa (Guardrails)**</a>: Weryfikuj wejścia i wyjścia swojego LLM, aby spełniały określone wymagania. Wybieraj spośród 40+ gotowych szyn bezpieczeństwa, by zapewnić zgodność z normami bezpieczeństwa i dokładności. Możesz <a href="https://portkey.wiki/gh-43">dodać własne szyny</a> lub wybrać spośród <a href="https://portkey.wiki/gh-44">naszych partnerów</a>.
- [**Zarządzanie kluczami w bezpieczny sposób (Secure Key Management)**](https://portkey.wiki/gh-45): Używaj własnych kluczy lub generuj wirtualne klucze na bieżąco.
- [**Kontrola dostępu oparta na rolach (Role-based access control)**](https://portkey.wiki/gh-46): Szczegółowa kontrola dostępu dla Twoich użytkowników, przestrzeni roboczych i kluczy API.
- <a href="https://portkey.wiki/gh-47">**Zgodność i prywatność danych (Compliance & Data Privacy)**</a>: Bramka AI spełnia normy SOC2, HIPAA, GDPR i CCPA.

### Zarządzanie kosztami
- [**Inteligentne buforowanie (Smart caching)**](https://portkey.wiki/gh-48): Buforuj odpowiedzi z LLM, aby zmniejszyć koszty i poprawić czas odpowiedzi. Obsługuje buforowanie proste i semantyczne*.
- [**Analiza użycia (Usage analytics)**](https://portkey.wiki/gh-49): Monitoruj i analizuj swoje wykorzystanie AI i LLM, w tym wolumen żądań, opóźnienia, koszty i wskaźniki błędów.
- [**Optymalizacja dostawców***](https://portkey.wiki/gh-89): Automatycznie przełączaj się na najbardziej opłacalnego dostawcę na podstawie wzorców użycia i modeli cenowych.

### Współpraca i procesy
- <a href="https://portkey.ai/docs/integrations/agents">**Wsparcie dla agentów (Agents Support)**</a>: Bezproblemowa integracja z popularnymi frameworkami agentów do budowy złożonych aplikacji AI. Bramka integruje się z [Autogen](https://portkey.wiki/gh-50), [CrewAI](https://portkey.wiki/gh-51), [LangChain](https://portkey.wiki/gh-52), [LlamaIndex](https://portkey.wiki/gh-53), [Phidata](https://portkey.wiki/gh-54), [Control Flow](https://portkey.wiki/gh-55) oraz [Własnymi agentami](https://portkey.wiki/gh-56).
- [**Zarządzanie szablonami promptów***](https://portkey.wiki/gh-57): Twórz, zarządzaj i wersjonuj swoje szablony promptów wspólnie przez uniwersalny playground promptów.
<br/><br/>

<sup>
*&nbsp;Dostępne w wersjach hostowanych i enterprise
</sup>

<br>

## Przepisy (Cookbooks)

### ☄️ Popularne
- Używaj modeli od [Nvidia NIM](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/providers/nvidia.ipynb) z AI Gateway
- Monitoruj [Agentów CrewAI](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/CrewAI_with_Telemetry.ipynb) z Portkey!
- Porównanie [Top 10 modeli LMSYS](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/LMSYS%20Series/comparing-top10-LMSYS-models-with-Portkey.ipynb) z AI Gateway.

### 🚨 Najnowsze
* [Tworzenie syntetycznych zbiorów danych za pomocą Nemotron](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/Nemotron_GPT_Finetuning_Portkey.ipynb)
* [Użyj bramki LLM z SDK AI od Vercel](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/integrations/vercel-ai.md)
* [Monitoruj agentów Llama za pomocą bramki LLM Portkey](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/Llama_Agents_with_Telemetry.ipynb)

[Zobacz wszystkie przepisy →](https://portkey.wiki/gh-58)
<br/><br/>

## Wspierani dostawcy

Poznaj integracje Gateway z [45+ dostawcami](https://portkey.wiki/gh-59) i [8+ frameworkami agentów](https://portkey.wiki/gh-90).

|                                                                                                                            | Dostawca                                                                                      | Wsparcie | Stream |
| -------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | -------- | ------ |
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


> [Zobacz pełną listę ponad 200 obsługiwanych modeli tutaj](https://portkey.wiki/gh-74)
<br>

<br>

## Agenci
Gateway bezproblemowo integruje się z popularnymi frameworkami agentów. [Przeczytaj dokumentację tutaj](https://portkey.wiki/gh-75).


| Framework | Wywołanie 200+ LLM | Zaawansowany routing | Buforowanie | Logowanie i śledzenie* | Obserwowalność* | Zarządzanie promptami* |
|------------------------------|--------|---------------------|-------------|----------------------|-----------------|-----------------------|
| [Autogen](https://portkey.wiki/gh-93)    | ✅     | ✅                 | ✅          | ✅                   | ✅              | ✅                    |
| [CrewAI](https://portkey.wiki/gh-94)             | ✅     | ✅                 | ✅          | ✅                   | ✅              | ✅                    |
| [LangChain](https://portkey.wiki/gh-95)             | ✅     | ✅                 | ✅          | ✅                   | ✅              | ✅                    |
| [Phidata](https://portkey.wiki/gh-96)             | ✅     | ✅                 | ✅          | ✅                   | ✅              | ✅                    |
| [Llama Index](https://portkey.wiki/gh-97)             | ✅     | ✅                 | ✅          | ✅                   | ✅              | ✅                    |
| [Control Flow](https://portkey.wiki/gh-98) | ✅     | ✅                 | ✅          | ✅                   | ✅              | ✅                    |
| [Stwórz własnych agentów](https://portkey.wiki/gh-99) | ✅     | ✅                 | ✅          | ✅                   | ✅              | ✅                    |

<br>

*Dostępne w [aplikacji hostowanej](https://portkey.wiki/gh-76). Szczegółową dokumentację znajdziesz [tutaj](https://portkey.wiki/gh-100).


## Wersja Enterprise Gateway
Uczyń swoją aplikację AI bardziej <ins>niezawodną</ins> i <ins>zgodną z przyszłymi zmianami</ins>, zapewniając jednocześnie pełne <ins>bezpieczeństwo danych</ins> i <ins>prywatność</ins>.

✅&nbsp; Bezpieczne zarządzanie kluczami – dla kontroli dostępu opartej na rolach i śledzenia <br>
✅&nbsp; Proste i semantyczne buforowanie – szybsza obsługa powtarzalnych zapytań i oszczędność kosztów <br>
✅&nbsp; Kontrola dostępu i reguły przychodzące – kontroluj, które adresy IP i regiony mogą łączyć się z Twoimi wdrożeniami <br>
✅&nbsp; Redakcja PII – automatyczne usuwanie wrażliwych danych z żądań, by zapobiec niezamierzonemu ujawnieniu <br>
✅&nbsp; Zgodność z SOC2, ISO, HIPAA, GDPR – najlepsze praktyki bezpieczeństwa <br>
✅&nbsp; Profesjonalne wsparcie – wraz z priorytetyzacją funkcji <br>

[Umów rozmowę, aby omówić wdrożenia enterprise](https://portkey.sh/demo-13)

<br>


## Współtworzenie

Najłatwiejszy sposób na kontrybucję to wybranie problemu z tagiem `good first issue` 💪. Przeczytaj wytyczne dotyczące współtworzenia [tutaj](https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/CONTRIBUTING.md).

Zgłoszenie błędu? [Zgłoś tutaj](https://portkey.wiki/gh-78) | Propozycja funkcji? [Zgłoś tutaj](https://portkey.wiki/gh-78)


### Rozpocznij z naszą społecznością
Dołącz do naszych cotygodniowych AI Engineering Hours w każdy piątek (8:00 PT), aby:
- Poznać innych kontrybutorów i członków społeczności
- Poznać zaawansowane funkcje Gateway oraz wzorce wdrożeniowe
- Podzielić się doświadczeniami i uzyskać pomoc
- Być na bieżąco z najnowszymi priorytetami rozwoju

[Dołącz do następnej sesji →](https://portkey.wiki/gh-101) | [Notatki ze spotkań](https://portkey.wiki/gh-102)

<br>

## Społeczność

Dołącz do naszej rosnącej społeczności na całym świecie, by uzyskać pomoc, pomysły i dyskutować o AI.

- Przeczytaj nasz [Blog](https://portkey.wiki/gh-78)
- Czat na [Discordzie](https://portkey.wiki/community)
- Śledź nas na [Twitterze](https://portkey.wiki/gh-79)
- Połącz się z nami na [LinkedIn](https://portkey.wiki/gh-80)
- Przeczytaj dokumentację po [japońsku](https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.jp.md)
- Zobacz nas na [YouTube](https://portkey.wiki/gh-103)
- Dołącz do naszej [społeczności developerów](https://portkey.wiki/gh-82)
<!-- - Pytania z tagiem #portkey na [Stack Overflow](https://stackoverflow.com/questions/tagged/portkey) -->

![Rubeus Social Share (4)](https://github.com/Portkey-AI/gateway/assets/971978/89d6f0af-a95d-4402-b451-14764c40d03f)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---