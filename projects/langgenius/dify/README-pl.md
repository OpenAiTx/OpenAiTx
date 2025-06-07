![cover-v5-optimized](./images/GitHub_README_if.png)

<p align="center">
  📌 <a href="https://dify.ai/blog/introducing-dify-workflow-file-upload-a-demo-on-ai-podcast">Wprowadzenie Dify Workflow File Upload: Odtwórz podcast Google NotebookLM</a>
</p>

<p align="center">
  <a href="https://cloud.dify.ai">Dify Cloud</a> ·
  <a href="https://docs.dify.ai/getting-started/install-self-hosted">Samodzielna instalacja</a> ·
  <a href="https://docs.dify.ai">Dokumentacja</a> ·
  <a href="https://dify.ai/pricing">Przegląd edycji Dify</a>
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

Dify to otwartoźródłowa platforma do tworzenia aplikacji LLM. Jej intuicyjny interfejs łączy agentowe przepływy pracy AI, pipeline RAG, możliwości agentów, zarządzanie modelami, funkcje obserwowalności i wiele więcej, umożliwiając szybkie przechodzenie od prototypu do produkcji.

## Szybki start

> Przed instalacją Dify upewnij się, że Twój komputer spełnia poniższe minimalne wymagania systemowe:
>
> - CPU >= 2 rdzenie
> - RAM >= 4 GiB

</br>

Najłatwiejszym sposobem uruchomienia serwera Dify jest użycie [docker compose](docker/docker-compose.yaml). Przed uruchomieniem Dify poniższymi poleceniami upewnij się, że masz zainstalowane [Docker](https://docs.docker.com/get-docker/) oraz [Docker Compose](https://docs.docker.com/compose/install/):

```bash
cd dify
cd docker
cp .env.example .env
docker compose up -d
```

Po uruchomieniu możesz uzyskać dostęp do panelu Dify w przeglądarce pod adresem [http://localhost/install](http://localhost/install) i rozpocząć proces inicjalizacji.

#### Szukasz pomocy

Zapoznaj się z naszym [FAQ](https://docs.dify.ai/getting-started/install-self-hosted/faqs), jeśli napotkasz problemy podczas konfiguracji Dify. Skontaktuj się z [naszą społecznością i z nami](#community--contact), jeśli nadal masz trudności.

> Jeśli chcesz przyczynić się do rozwoju Dify lub dokonać dodatkowych zmian, zapoznaj się z naszym [przewodnikiem wdrażania z kodu źródłowego](https://docs.dify.ai/getting-started/install-self-hosted/local-source-code)

## Kluczowe funkcje

**1. Przepływ pracy (Workflow)**:
Buduj i testuj zaawansowane przepływy pracy AI na wizualnym płótnie, wykorzystując wszystkie poniższe funkcje i nie tylko.

**2. Kompleksowe wsparcie modeli**:
Bezproblemowa integracja z setkami zamkniętych i otwartoźródłowych modeli LLM od dziesiątek dostawców inferencji oraz rozwiązań samohostowanych, obejmująca GPT, Mistral, Llama3 i wszelkie modele zgodne z API OpenAI. Pełna lista obsługiwanych dostawców modeli dostępna jest [tutaj](https://docs.dify.ai/getting-started/readme/model-providers).

![providers-v5](https://github.com/langgenius/dify/assets/13230914/5a17bdbe-097a-4100-8363-40255b70f6e3)

**3. Prompt IDE**:
Intuicyjny interfejs do tworzenia promptów, porównywania wydajności modeli oraz dodawania dodatkowych funkcji, takich jak zamiana tekstu na mowę w aplikacji czatowej.

**4. Pipeline RAG**:
Rozbudowane możliwości RAG, obejmujące wszystko od wczytywania dokumentów po ich wyszukiwanie, z gotowym wsparciem dla ekstrakcji tekstu z PDF, PPT i innych popularnych formatów dokumentów.

**5. Możliwości agentów**:
Możesz definiować agentów na bazie LLM Function Calling lub ReAct oraz dodawać gotowe lub własne narzędzia dla agenta. Dify oferuje ponad 50 wbudowanych narzędzi dla agentów AI, takich jak Google Search, DALL·E, Stable Diffusion i WolframAlpha.

**6. LLMOps**:
Monitoruj i analizuj logi oraz wydajność aplikacji w czasie. Możesz stale ulepszać prompt'y, zbiory danych i modele na podstawie danych produkcyjnych i adnotacji.

**7. Backend-as-a-Service**:
Wszystkie funkcje Dify posiadają odpowiadające im API, dzięki czemu możesz łatwo zintegrować Dify ze swoją logiką biznesową.

## Porównanie funkcji

<table style="width: 100%;">
  <tr>
    <th align="center">Funkcja</th>
    <th align="center">Dify.AI</th>
    <th align="center">LangChain</th>
    <th align="center">Flowise</th>
    <th align="center">OpenAI Assistants API</th>
  </tr>
  <tr>
    <td align="center">Podejście programistyczne</td>
    <td align="center">API + aplikacyjne</td>
    <td align="center">Kod Python</td>
    <td align="center">Aplikacyjne</td>
    <td align="center">API</td>
  </tr>
  <tr>
    <td align="center">Obsługiwane LLM</td>
    <td align="center">Bogata różnorodność</td>
    <td align="center">Bogata różnorodność</td>
    <td align="center">Bogata różnorodność</td>
    <td align="center">Tylko OpenAI</td>
  </tr>
  <tr>
    <td align="center">Silnik RAG</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">Agent</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">Workflow</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Obserwowalność</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Funkcje dla firm (SSO/kontrola dostępu)</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Lokalne wdrożenie</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
</table>

## Korzystanie z Dify

- **Chmura </br>**
  Udostępniamy [Dify Cloud](https://dify.ai) dla każdego, kto chce wypróbować bez żadnej konfiguracji. Oferuje wszystkie możliwości wersji samodzielnie wdrażanej oraz zawiera 200 darmowych wywołań GPT-4 w planie sandbox.

- **Samodzielne wdrażanie Dify Community Edition</br>**
  Szybko uruchom Dify w swoim środowisku korzystając z tego [przewodnika startowego](#quick-start).
  Skorzystaj z naszej [dokumentacji](https://docs.dify.ai) po dalsze instrukcje i szczegółowe informacje.

- **Dify dla przedsiębiorstw/organizacji</br>**
  Oferujemy dodatkowe funkcje ukierunkowane na potrzeby firm. [Zadaj nam pytanie przez tego chatbota](https://udify.app/chat/22L1zSxg6yW1cWQg) lub [wyślij do nas e-mail](mailto:business@dify.ai?subject=[GitHub]Business%20License%20Inquiry), aby omówić potrzeby Twojej organizacji. </br>
  > Dla startupów i małych firm korzystających z AWS, sprawdź [Dify Premium na AWS Marketplace](https://aws.amazon.com/marketplace/pp/prodview-t22mebxzwjhu6) i wdrażaj do własnego AWS VPC jednym kliknięciem. To przystępna cenowo oferta AMI z opcją tworzenia aplikacji z własnym logo i brandingiem.

## Bądź na bieżąco

Dodaj gwiazdkę Dify na GitHubie, aby natychmiast otrzymywać powiadomienia o nowych wydaniach.

![star-us](https://github.com/langgenius/dify/assets/13230914/b823edc1-6388-4e25-ad45-2f6b187adbb4)

## Zaawansowana konfiguracja

Jeśli chcesz dostosować konfigurację, zapoznaj się z komentarzami w naszym pliku [.env.example](docker/.env.example) i zaktualizuj odpowiednie wartości w swoim pliku `.env`. Dodatkowo możesz potrzebować dokonać zmian w samym pliku `docker-compose.yaml`, np. zmienić wersje obrazów, mapowania portów lub montowania wolumenów, w zależności od środowiska wdrożeniowego i wymagań. Po wprowadzeniu zmian ponownie uruchom `docker-compose up -d`. Pełną listę dostępnych zmiennych środowiskowych znajdziesz [tutaj](https://docs.dify.ai/getting-started/install-self-hosted/environments).

Jeśli chcesz skonfigurować środowisko wysokiej dostępności, społeczność przygotowała [Helm Chart'y](https://helm.sh/) i pliki YAML umożliwiające wdrożenie Dify na Kubernetes.

- [Helm Chart by @LeoQuote](https://github.com/douban/charts/tree/master/charts/dify)
- [Helm Chart by @BorisPolonsky](https://github.com/BorisPolonsky/dify-helm)
- [Helm Chart by @magicsong](https://github.com/magicsong/ai-charts)
- [Plik YAML by @Winson-030](https://github.com/Winson-030/dify-kubernetes)
- [Plik YAML by @wyy-holding](https://github.com/wyy-holding/dify-k8s)

#### Wdrażanie za pomocą Terraform

Wdrażaj Dify na platformie chmurowej jednym kliknięciem używając [terraform](https://www.terraform.io/)

##### Azure Global

- [Azure Terraform by @nikawang](https://github.com/nikawang/dify-azure-terraform)

##### Google Cloud

- [Google Cloud Terraform by @sotazum](https://github.com/DeNA/dify-google-cloud-terraform)

#### Wdrażanie za pomocą AWS CDK

Wdrażaj Dify na AWS z [CDK](https://aws.amazon.com/cdk/)

##### AWS

- [AWS CDK by @KevinZhao](https://github.com/aws-samples/solution-for-deploying-dify-on-aws)

## Współtworzenie

Osoby chcące dodać kod znajdą instrukcje w [Przewodniku dla współtwórców](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md).
Jednocześnie zachęcamy do wspierania Dify przez udostępnianie go w mediach społecznościowych oraz na wydarzeniach i konferencjach.

> Szukamy osób do pomocy przy tłumaczeniu Dify na języki inne niż mandaryński lub angielski. Jeśli chcesz pomóc, zapoznaj się z [i18n README](https://github.com/langgenius/dify/blob/main/web/i18n/README.md) i zostaw komentarz na kanale `global-users` na naszym [Serwerze Społeczności Discord](https://discord.gg/8Tpq4AcN9c).

## Społeczność i kontakt

- [Dyskusje GitHub](https://github.com/langgenius/dify/discussions). Najlepsze do: dzielenia się opiniami i zadawania pytań.
- [Zgłoszenia GitHub](https://github.com/langgenius/dify/issues). Najlepsze do: zgłaszania błędów podczas korzystania z Dify.AI oraz propozycji nowych funkcji. Zobacz nasz [Przewodnik dla współtwórców](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md).
- [Discord](https://discord.gg/FngNHpbcY7). Najlepsze do: dzielenia się swoimi aplikacjami i rozmów ze społecznością.
- [X(Twitter)](https://twitter.com/dify_ai). Najlepsze do: dzielenia się aplikacjami i kontaktu ze społecznością.

**Współtwórcy**

<a href="https://github.com/langgenius/dify/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=langgenius/dify" />
</a>

## Historia gwiazdek

[![Star History Chart](https://api.star-history.com/svg?repos=langgenius/dify&type=Date)](https://star-history.com/#langgenius/dify&Date)

## Zgłoszenia dotyczące bezpieczeństwa

Aby chronić Twoją prywatność, nie zgłaszaj problemów związanych z bezpieczeństwem na GitHubie. Zamiast tego wyślij pytania na adres security@dify.ai, a udzielimy bardziej szczegółowej odpowiedzi.

## Licencja

To repozytorium jest dostępne na [Dify Open Source License](LICENSE), która jest zasadniczo licencją Apache 2.0 z kilkoma dodatkowymi ograniczeniami.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---