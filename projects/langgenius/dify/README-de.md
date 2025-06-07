![cover-v5-optimized](./images/GitHub_README_if.png)

<p align="center">
  📌 <a href="https://dify.ai/blog/introducing-dify-workflow-file-upload-a-demo-on-ai-podcast">Einführung des Dify Workflow File Upload: Reproduktion von Google NotebookLM Podcast</a>
</p>

<p align="center">
  <a href="https://cloud.dify.ai">Dify Cloud</a> ·
  <a href="https://docs.dify.ai/getting-started/install-self-hosted">Self-hosting</a> ·
  <a href="https://docs.dify.ai">Dokumentation</a> ·
  <a href="https://dify.ai/pricing">Dify Edition Übersicht</a>
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

Dify ist eine Open-Source-Plattform für die Entwicklung von LLM-Anwendungen. Die intuitive Oberfläche vereint agentische KI-Workflows, RAG-Pipelines, Agentenfunktionen, Modellverwaltung, Observability-Features und mehr, sodass Sie schnell vom Prototyp zur Produktion gelangen.

## Schnellstart

> Bevor Sie Dify installieren, stellen Sie sicher, dass Ihr System die folgenden Mindestanforderungen erfüllt:
>
> - CPU >= 2 Kerne
> - RAM >= 4 GiB

</br>

Der einfachste Weg, den Dify-Server zu starten, ist über [docker compose](docker/docker-compose.yaml). Stellen Sie vor dem Ausführen der folgenden Befehle sicher, dass [Docker](https://docs.docker.com/get-docker/) und [Docker Compose](https://docs.docker.com/compose/install/) auf Ihrem System installiert sind:

```bash
cd dify
cd docker
cp .env.example .env
docker compose up -d
```

Nach dem Start können Sie das Dify-Dashboard im Browser unter [http://localhost/install](http://localhost/install) aufrufen und den Initialisierungsprozess starten.

#### Hilfe gesucht?

Bitte lesen Sie unser [FAQ](https://docs.dify.ai/getting-started/install-self-hosted/faqs), falls beim Einrichten von Dify Probleme auftreten. Wenden Sie sich an [die Community und uns](#community--contact), wenn weiterhin Schwierigkeiten bestehen.

> Wenn Sie zu Dify beitragen oder zusätzliche Entwicklungen vornehmen möchten, lesen Sie bitte unseren [Leitfaden zur Bereitstellung aus dem Quellcode](https://docs.dify.ai/getting-started/install-self-hosted/local-source-code)

## Hauptfunktionen

**1. Workflow**:  
Erstellen und testen Sie leistungsfähige KI-Workflows auf einer visuellen Leinwand und nutzen Sie dabei alle nachfolgenden Features und mehr.

**2. Umfassende Modellunterstützung**:  
Nahtlose Integration mit Hunderten von proprietären / Open-Source-LLMs von zahlreichen Inferenzanbietern und Self-Hosting-Lösungen, einschließlich GPT, Mistral, Llama3 und allen OpenAI-API-kompatiblen Modellen. Eine vollständige Liste der unterstützten Modellanbieter finden Sie [hier](https://docs.dify.ai/getting-started/readme/model-providers).

![providers-v5](https://github.com/langgenius/dify/assets/13230914/5a17bdbe-097a-4100-8363-40255b70f6e3)

**3. Prompt IDE**:  
Intuitive Oberfläche zum Erstellen von Prompts, Vergleichen von Modellleistungen und Hinzufügen weiterer Funktionen wie Text-to-Speech zu einer Chat-basierten App.

**4. RAG-Pipeline**:  
Umfassende RAG-Funktionen, die alles vom Dokumentenimport bis zur Informationsabruf abdecken, mit sofortiger Unterstützung für Textextraktion aus PDFs, PPTs und anderen gängigen Dokumentformaten.

**5. Agentenfunktionen**:  
Sie können Agenten auf Basis von LLM Function Calling oder ReAct definieren und vorgefertigte oder eigene Tools für den Agenten hinzufügen. Dify bietet über 50 integrierte Tools für KI-Agenten, wie z.B. Google Search, DALL·E, Stable Diffusion und WolframAlpha.

**6. LLMOps**:  
Überwachen und analysieren Sie Anwendungsprotokolle und -leistung im Zeitverlauf. Sie können Prompts, Datensätze und Modelle kontinuierlich auf Basis von Produktionsdaten und Annotationen verbessern.

**7. Backend-as-a-Service**:  
Alle Dify-Angebote verfügen über entsprechende APIs, sodass Sie Dify mühelos in Ihre eigene Geschäftslogik integrieren können.

## Funktionsvergleich

<table style="width: 100%;">
  <tr>
    <th align="center">Funktion</th>
    <th align="center">Dify.AI</th>
    <th align="center">LangChain</th>
    <th align="center">Flowise</th>
    <th align="center">OpenAI Assistants API</th>
  </tr>
  <tr>
    <td align="center">Programmieransatz</td>
    <td align="center">API + App-orientiert</td>
    <td align="center">Python-Code</td>
    <td align="center">App-orientiert</td>
    <td align="center">API-orientiert</td>
  </tr>
  <tr>
    <td align="center">Unterstützte LLMs</td>
    <td align="center">Große Vielfalt</td>
    <td align="center">Große Vielfalt</td>
    <td align="center">Große Vielfalt</td>
    <td align="center">Nur OpenAI</td>
  </tr>
  <tr>
    <td align="center">RAG-Engine</td>
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
    <td align="center">Observability</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Enterprise-Funktion (SSO/Zugriffskontrolle)</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Lokale Bereitstellung</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
</table>

## Verwendung von Dify

- **Cloud </br>**  
  Wir bieten einen gehosteten [Dify Cloud](https://dify.ai) Service an, den jeder ohne Einrichtung testen kann. Er bietet alle Funktionen der selbst gehosteten Version und enthält im Sandbox-Plan 200 kostenlose GPT-4-Aufrufe.

- **Self-hosting Dify Community Edition</br>**  
  Bringen Sie Dify mit dieser [Schnellanleitung](#quick-start) schnell in Ihrer Umgebung zum Laufen.  
  Nutzen Sie unsere [Dokumentation](https://docs.dify.ai) für weitere Hinweise und ausführliche Anleitungen.

- **Dify für Unternehmen / Organisationen</br>**  
  Wir bieten zusätzliche unternehmensspezifische Funktionen. [Stellen Sie uns Ihre Fragen über diesen Chatbot](https://udify.app/chat/22L1zSxg6yW1cWQg) oder [senden Sie uns eine E-Mail](mailto:business@dify.ai?subject=[GitHub]Business%20License%20Inquiry), um Unternehmensanforderungen zu besprechen. </br>
  > Für Start-ups und kleine Unternehmen, die AWS nutzen, sehen Sie sich [Dify Premium auf AWS Marketplace](https://aws.amazon.com/marketplace/pp/prodview-t22mebxzwjhu6) an und stellen Sie es mit einem Klick in Ihrer eigenen AWS-VPC bereit. Es ist ein günstiges AMI-Angebot mit der Möglichkeit, Apps mit eigenem Logo und Branding zu erstellen.

## Immer auf dem neuesten Stand bleiben

Geben Sie Dify auf GitHub einen Stern und erhalten Sie sofort Benachrichtigungen über neue Releases.

![star-us](https://github.com/langgenius/dify/assets/13230914/b823edc1-6388-4e25-ad45-2f6b187adbb4)

## Erweiterte Einrichtung

Wenn Sie die Konfiguration anpassen müssen, lesen Sie bitte die Kommentare in unserer [.env.example](docker/.env.example)-Datei und aktualisieren Sie die entsprechenden Werte in Ihrer `.env`-Datei. Möglicherweise müssen Sie außerdem Anpassungen an der Datei `docker-compose.yaml` selbst vornehmen, z.B. Image-Versionen, Port-Mappings oder Volume-Mounts ändern – je nach Ihrer spezifischen Bereitstellungsumgebung und Ihren Anforderungen. Nach Änderungen starten Sie bitte `docker-compose up -d` erneut. Eine vollständige Liste aller verfügbaren Umgebungsvariablen finden Sie [hier](https://docs.dify.ai/getting-started/install-self-hosted/environments).

Wenn Sie eine hochverfügbare Umgebung einrichten möchten, gibt es von der Community bereitgestellte [Helm-Charts](https://helm.sh/) und YAML-Dateien, mit denen Dify auf Kubernetes bereitgestellt werden kann.

- [Helm Chart von @LeoQuote](https://github.com/douban/charts/tree/master/charts/dify)
- [Helm Chart von @BorisPolonsky](https://github.com/BorisPolonsky/dify-helm)
- [Helm Chart von @magicsong](https://github.com/magicsong/ai-charts)
- [YAML-Datei von @Winson-030](https://github.com/Winson-030/dify-kubernetes)
- [YAML-Datei von @wyy-holding](https://github.com/wyy-holding/dify-k8s)

#### Bereitstellung mit Terraform

Stellen Sie Dify mit nur einem Klick mit [terraform](https://www.terraform.io/) auf Cloud-Plattformen bereit.

##### Azure Global

- [Azure Terraform von @nikawang](https://github.com/nikawang/dify-azure-terraform)

##### Google Cloud

- [Google Cloud Terraform von @sotazum](https://github.com/DeNA/dify-google-cloud-terraform)

#### Bereitstellung mit AWS CDK

Stellen Sie Dify mit [CDK](https://aws.amazon.com/cdk/) auf AWS bereit.

##### AWS

- [AWS CDK von @KevinZhao](https://github.com/aws-samples/solution-for-deploying-dify-on-aws)

## Beitrag leisten

Für alle, die Code beitragen möchten, siehe unseren [Beitragsleitfaden](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md).  
Bitte unterstützen Sie Dify auch, indem Sie es in sozialen Medien, auf Events und Konferenzen teilen.

> Wir suchen Mitwirkende, die Dify in andere Sprachen als Mandarin oder Englisch übersetzen. Wenn Sie helfen möchten, lesen Sie die [i18n README](https://github.com/langgenius/dify/blob/main/web/i18n/README.md) für weitere Informationen und hinterlassen Sie uns einen Kommentar im `global-users`-Kanal unseres [Discord Community Servers](https://discord.gg/8Tpq4AcN9c).

## Community & Kontakt

- [GitHub Discussion](https://github.com/langgenius/dify/discussions). Am besten geeignet für: Feedback geben und Fragen stellen.
- [GitHub Issues](https://github.com/langgenius/dify/issues). Am besten geeignet für: Bugs, die Sie bei der Verwendung von Dify.AI entdecken, und Feature-Vorschläge. Siehe unseren [Beitragsleitfaden](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md).
- [Discord](https://discord.gg/FngNHpbcY7). Am besten geeignet für: Teilen Ihrer Anwendungen und Austausch mit der Community.
- [X(Twitter)](https://twitter.com/dify_ai). Am besten geeignet für: Teilen Ihrer Anwendungen und Austausch mit der Community.

**Mitwirkende**

<a href="https://github.com/langgenius/dify/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=langgenius/dify" />
</a>

## Sternverlauf

[![Star History Chart](https://api.star-history.com/svg?repos=langgenius/dify&type=Date)](https://star-history.com/#langgenius/dify&Date)

## Sicherheitshinweis

Um Ihre Privatsphäre zu schützen, veröffentlichen Sie bitte keine Sicherheitsprobleme auf GitHub. Senden Sie stattdessen Ihre Fragen an security@dify.ai und wir werden Ihnen eine detailliertere Antwort geben.

## Lizenz

Dieses Repository steht unter der [Dify Open Source License](LICENSE) zur Verfügung, die im Wesentlichen Apache 2.0 mit einigen zusätzlichen Einschränkungen entspricht.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---