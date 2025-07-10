# ProxyAsLocalModel

Proxy zdalnego API LLM jako model lokalny. Szczególnie przydatny do używania niestandardowego LLM w JetBrains AI Assistant.

Wspierany przez Ktor i kotlinx.serialization. Dzięki ich funkcjom bez refleksji.

## Historia tego projektu

Obecnie JetBrains AI Assistant oferuje darmowy plan z bardzo ograniczonym limitem zapytań. Przetestowałem go i mój limit szybko się wyczerpał.

Kupiłem już tokeny do innych API LLM, takich jak Gemini i Qwen. Zacząłem więc zastanawiać się, jak ich użyć w AI Assistant. Niestety, obsługiwane są tylko modele lokalne z LM Studio i Ollama. Zacząłem więc pracować nad tą aplikacją proxy, która pośredniczy pomiędzy zewnętrznymi API LLM a LM Studio i Ollama, tak abym mógł ich używać w moich IDE JetBrains.

To po prostu proste zadanie, więc zacząłem korzystać z oficjalnych SDK jako klientów i napisałem prosty serwer Ktor, który udostępnia endpointy zgodne z LM Studio i Ollama. Problem pojawił się, gdy próbowałem rozprowadzać to jako natywny obraz GraalVM. Oficjalne SDK Java używają zbyt wielu dynamicznych funkcji, co utrudnia kompilację do natywnego obrazu, nawet z agentem śledzącym. Zdecydowałem się więc samodzielnie zaimplementować prostego klienta API do strumieniowania czatu z użyciem Ktor i kotlinx.serialization, które są pozbawione refleksji, funkcjonalne i mają styl DSL.

Jak widać, aplikacja jest dystrybuowana jako duży, uruchamialny plik jar oraz jako natywny obraz GraalVM, co czyni ją wieloplatformową i szybką w uruchamianiu.

Tworzenie tej aplikacji przekonało mnie do Kotlin/Ktor/kotlinx.serialization. Świat Kotlina używa więcej programowania funkcyjnego i mniej refleksji, co sprawia, że lepiej nadaje się do natywnych obrazów GraalVM, zapewniając szybszy start i mniejsze zużycie pamięci.

## Aktualnie obsługiwane

Proxy z: OpenAI, Claude, DashScope (Alibaba Qwen), Gemini, Deepseek, Mistral, SiliconFlow.

Proxy jako: LM Studio, Ollama.

Tylko API do strumieniowego uzupełniania czatu.
## Jak używać

Ta aplikacja to serwer proxy, dystrybuowany jako samodzielny plik jar oraz natywny obraz GraalVM (Windows x64).

Uruchom aplikację, a zobaczysz wiadomość pomocy:

```
2025-05-02 10:43:53 INFO  Help - Wygląda na to, że uruchamiasz program po raz pierwszy tutaj.
2025-05-02 10:43:53 INFO  Help - Domyślny plik konfiguracyjny został utworzony w twoja_ścieżka\config.yml z adnotacją schematu.
2025-05-02 10:43:53 INFO  Config - Obserwator pliku konfiguracyjnego uruchomiony na twoja_ścieżka\config.yml
2025-05-02 10:43:53 INFO  LM Studio Server - Serwer LM Studio uruchomiony na porcie 1234
2025-05-02 10:43:53 INFO  Ollama Server - Serwer Ollama uruchomiony na porcie 11434
2025-05-02 10:43:53 INFO  Model List - Lista modeli załadowana: []
```

Następnie możesz edytować plik konfiguracyjny, aby skonfigurować swój serwer proxy.

## Plik konfiguracyjny

Ten plik konfiguracyjny jest automatycznie przeładowywany na gorąco po każdej zmianie. Zaktualizowane zostaną tylko te części serwera, które zostały zmienione.

Podczas pierwszego generowania pliku konfiguracyjnego zostanie on utworzony z adnotacjami schematu. Zapewni to podpowiedzi i sprawdzanie w twoim edytorze.
## Przykładowy plik konfiguracyjny

```yaml
# $schema: https://github.com/Stream29/ProxyAsLocalModel/raw/master/config_v3.schema.json
lmStudio:
  port: 1234 # To jest wartość domyślna
  enabled: true # To jest wartość domyślna
  host: 0.0.0.0 # To jest wartość domyślna
  path: /your/path # Zostanie dodana przed oryginalnymi endpointami, domyślna wartość to puste
ollama:
  port: 11434 # To jest wartość domyślna
  enabled: true # To jest wartość domyślna
  host: 0.0.0.0 # To jest wartość domyślna
  path: /your/path # Zostanie dodana przed oryginalnymi endpointami, domyślna wartość to puste
client:
  socketTimeout: 1919810 # Long.MAX_VALUE to wartość domyślna, w milisekundach
  connectionTimeout: 1919810 # Long.MAX_VALUE to wartość domyślna, w milisekundach
  requestTimeout: 1919810 # Long.MAX_VALUE to wartość domyślna, w milisekundach
  retry: 3 # To jest wartość domyślna
  delayBeforeRetry: 1000 # To jest wartość domyślna, w milisekundach

apiProviders:
  OpenAI:
    type: OpenAi
    baseUrl: https://api.openai.com/v1
    apiKey: <your_api_key>
    modelList:
      - gpt-4o
  Claude:
    type: Claude
    apiKey: <your_api_key>
    modelList:
      - claude-3-7-sonnet
  Qwen:
    type: DashScope
    apiKey: <your_api_key>
    modelList: # To jest wartość domyślna
      - qwen-max
      - qwen-plus
      - qwen-turbo
      - qwen-long
  DeepSeek:
    type: DeepSeek
    apiKey: <your_api_key>
    modelList: # To jest wartość domyślna
      - deepseek-chat
      - deepseek-reasoner
  Mistral:
    type: Mistral
    apiKey: <your_api_key>
    modelList: # To jest wartość domyślna
      - codestral-latest
      - mistral-large
  SiliconFlow:
    type: SiliconFlow
    apiKey: <your_api_key>
    modelList:
      - Qwen/Qwen3-235B-A22B
      - Pro/deepseek-ai/DeepSeek-V3
      - THUDM/GLM-4-32B-0414
  OpenRouter:
    type: OpenRouter
    apiKey: <your_api_key>
    modelList:
      - openai/gpt-4o
  Gemini:
    type: Gemini
    apiKey: <your_api_key>
    modelList:
      - gemini-2.5-flash-preview-04-17
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---