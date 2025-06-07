![cover-v5-optimized](./images/GitHub_README_if.png)

<p align="center">
  📌 <a href="https://dify.ai/blog/introducing-dify-workflow-file-upload-a-demo-on-ai-podcast">Présentation de l'importation de fichiers dans le workflow Dify : Recréez le podcast Google NotebookLM</a>
</p>

<p align="center">
  <a href="https://cloud.dify.ai">Dify Cloud</a> ·
  <a href="https://docs.dify.ai/getting-started/install-self-hosted">Auto-hébergement</a> ·
  <a href="https://docs.dify.ai">Documentation</a> ·
  <a href="https://dify.ai/pricing">Aperçu des éditions Dify</a>
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

Dify est une plateforme de développement d'applications LLM open source. Son interface intuitive combine workflow IA agentique, pipeline RAG, capacités d'agent, gestion des modèles, fonctionnalités d'observabilité, et bien plus encore, vous permettant de passer rapidement du prototype à la production.

## Démarrage rapide

> Avant d’installer Dify, assurez-vous que votre machine répond aux exigences minimales suivantes :
>
> - CPU ≥ 2 cœurs
> - RAM ≥ 4 Go

</br>

La façon la plus simple de démarrer le serveur Dify est d'utiliser [docker compose](docker/docker-compose.yaml). Avant d’exécuter Dify avec les commandes suivantes, assurez-vous que [Docker](https://docs.docker.com/get-docker/) et [Docker Compose](https://docs.docker.com/compose/install/) sont installés sur votre machine :

```bash
cd dify
cd docker
cp .env.example .env
docker compose up -d
```

Après l’exécution, vous pouvez accéder au tableau de bord Dify dans votre navigateur à l’adresse [http://localhost/install](http://localhost/install) et démarrer le processus d’initialisation.

#### Besoin d'aide

Veuillez consulter notre [FAQ](https://docs.dify.ai/getting-started/install-self-hosted/faqs) si vous rencontrez des problèmes lors de la configuration de Dify. Contactez [la communauté et nous](#community--contact) si vous avez encore des difficultés.

> Si vous souhaitez contribuer à Dify ou effectuer du développement supplémentaire, consultez notre [guide de déploiement depuis le code source](https://docs.dify.ai/getting-started/install-self-hosted/local-source-code).

## Fonctionnalités clés

**1. Workflow** :  
Créez et testez des workflows IA puissants sur un canevas visuel, en tirant parti de toutes les fonctionnalités suivantes et plus encore.

**2. Prise en charge complète des modèles** :  
Intégration transparente avec des centaines de LLM propriétaires/open source issus de dizaines de fournisseurs d’inférence et de solutions auto-hébergées, couvrant GPT, Mistral, Llama3, et tout modèle compatible avec l’API OpenAI. La liste complète des fournisseurs de modèles pris en charge est disponible [ici](https://docs.dify.ai/getting-started/readme/model-providers).

![providers-v5](https://github.com/langgenius/dify/assets/13230914/5a17bdbe-097a-4100-8363-40255b70f6e3)

**3. IDE de prompt** :  
Interface intuitive pour la création de prompts, la comparaison des performances des modèles, et l’ajout de fonctionnalités supplémentaires telles que la synthèse vocale à une application de chat.

**4. Pipeline RAG** :  
Capacités RAG étendues couvrant tout, de l’ingestion de documents à la récupération, avec prise en charge prête à l’emploi de l’extraction de texte à partir de PDF, PPT et autres formats courants.

**5. Capacités d’agent** :  
Vous pouvez définir des agents basés sur LLM Function Calling ou ReAct, et ajouter des outils préconstruits ou personnalisés à l’agent. Dify fournit plus de 50 outils intégrés pour les agents IA, comme Google Search, DALL·E, Stable Diffusion et WolframAlpha.

**6. LLMOps** :  
Surveillez et analysez les journaux d’application et les performances dans le temps. Vous pouvez améliorer en continu les prompts, jeux de données et modèles sur la base des données et annotations de production.

**7. Backend-as-a-Service** :  
Toutes les offres de Dify sont accompagnées d’API correspondantes, permettant une intégration facile de Dify dans votre logique métier.

## Comparaison des fonctionnalités

<table style="width: 100%;">
  <tr>
    <th align="center">Fonctionnalité</th>
    <th align="center">Dify.AI</th>
    <th align="center">LangChain</th>
    <th align="center">Flowise</th>
    <th align="center">OpenAI Assistants API</th>
  </tr>
  <tr>
    <td align="center">Approche de programmation</td>
    <td align="center">API + Orienté application</td>
    <td align="center">Code Python</td>
    <td align="center">Orienté application</td>
    <td align="center">Orienté API</td>
  </tr>
  <tr>
    <td align="center">LLM pris en charge</td>
    <td align="center">Grande variété</td>
    <td align="center">Grande variété</td>
    <td align="center">Grande variété</td>
    <td align="center">OpenAI uniquement</td>
  </tr>
  <tr>
    <td align="center">Moteur RAG</td>
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
    <td align="center">Observabilité</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Fonctionnalités entreprise (SSO/Contrôle d'accès)</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Déploiement local</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
</table>

## Utilisation de Dify

- **Cloud </br>**
  Nous hébergeons un service [Dify Cloud](https://dify.ai) accessible à tous sans configuration. Il offre toutes les fonctionnalités de la version auto-hébergée et inclut 200 appels gratuits à GPT-4 dans le plan bac à sable.

- **Auto-hébergement Dify Community Edition</br>**
  Démarrez rapidement Dify dans votre environnement avec ce [guide de démarrage rapide](#quick-start).
  Utilisez notre [documentation](https://docs.dify.ai) pour des références supplémentaires et des instructions détaillées.

- **Dify pour les entreprises / organisations</br>**
  Nous proposons des fonctionnalités supplémentaires dédiées aux entreprises. [Posez-nous vos questions via ce chatbot](https://udify.app/chat/22L1zSxg6yW1cWQg) ou [envoyez-nous un email](mailto:business@dify.ai?subject=[GitHub]Business%20License%20Inquiry) pour discuter de vos besoins. </br>
  > Pour les startups et petites entreprises utilisant AWS, consultez [Dify Premium sur AWS Marketplace](https://aws.amazon.com/marketplace/pp/prodview-t22mebxzwjhu6) et déployez-le sur votre propre AWS VPC en un clic. Il s'agit d'une offre AMI abordable avec la possibilité de créer des applications avec un logo et une image de marque personnalisés.

## Restez à la page

Ajoutez une étoile à Dify sur GitHub pour être instantanément notifié des nouvelles versions.

![star-us](https://github.com/langgenius/dify/assets/13230914/b823edc1-6388-4e25-ad45-2f6b187adbb4)

## Configuration avancée

Si vous avez besoin de personnaliser la configuration, veuillez consulter les commentaires dans notre fichier [.env.example](docker/.env.example) et mettre à jour les valeurs correspondantes dans votre fichier `.env`. De plus, vous devrez peut-être ajuster le fichier `docker-compose.yaml` lui-même, par exemple changer les versions d’image, la correspondance des ports ou le montage des volumes, en fonction de votre environnement de déploiement et de vos besoins spécifiques. Après toute modification, veuillez relancer `docker-compose up -d`. Vous pouvez trouver la liste complète des variables d’environnement disponibles [ici](https://docs.dify.ai/getting-started/install-self-hosted/environments).

Si vous souhaitez configurer un déploiement hautement disponible, il existe des [Helm Charts](https://helm.sh/) et fichiers YAML proposés par la communauté qui permettent de déployer Dify sur Kubernetes.

- [Helm Chart par @LeoQuote](https://github.com/douban/charts/tree/master/charts/dify)
- [Helm Chart par @BorisPolonsky](https://github.com/BorisPolonsky/dify-helm)
- [Helm Chart par @magicsong](https://github.com/magicsong/ai-charts)
- [Fichier YAML par @Winson-030](https://github.com/Winson-030/dify-kubernetes)
- [Fichier YAML par @wyy-holding](https://github.com/wyy-holding/dify-k8s)

#### Déploiement avec Terraform

Déployez Dify sur une plateforme cloud en un clic avec [terraform](https://www.terraform.io/)

##### Azure Global

- [Azure Terraform par @nikawang](https://github.com/nikawang/dify-azure-terraform)

##### Google Cloud

- [Google Cloud Terraform par @sotazum](https://github.com/DeNA/dify-google-cloud-terraform)

#### Déploiement avec AWS CDK

Déployez Dify sur AWS avec [CDK](https://aws.amazon.com/cdk/)

##### AWS

- [AWS CDK par @KevinZhao](https://github.com/aws-samples/solution-for-deploying-dify-on-aws)

## Contribution

Pour ceux qui souhaitent contribuer au code, consultez notre [Guide de contribution](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md).
Merci également de soutenir Dify en le partageant sur les réseaux sociaux, lors d’événements et conférences.

> Nous recherchons des contributeurs pour aider à traduire Dify dans d’autres langues que le mandarin ou l’anglais. Si vous êtes intéressé, consultez le [README i18n](https://github.com/langgenius/dify/blob/main/web/i18n/README.md) pour plus d’informations, et laissez-nous un commentaire dans le canal `global-users` de notre [serveur Discord communautaire](https://discord.gg/8Tpq4AcN9c).

## Communauté & contact

- [Discussion GitHub](https://github.com/langgenius/dify/discussions). Idéal pour : partager vos retours et poser des questions.
- [Issues GitHub](https://github.com/langgenius/dify/issues). Idéal pour : signaler des bugs rencontrés lors de l’utilisation de Dify.AI et proposer des fonctionnalités. Consultez notre [Guide de contribution](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md).
- [Discord](https://discord.gg/FngNHpbcY7). Idéal pour : partager vos applications et échanger avec la communauté.
- [X(Twitter)](https://twitter.com/dify_ai). Idéal pour : partager vos applications et échanger avec la communauté.

**Contributeurs**

<a href="https://github.com/langgenius/dify/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=langgenius/dify" />
</a>

## Historique des étoiles

[![Star History Chart](https://api.star-history.com/svg?repos=langgenius/dify&type=Date)](https://star-history.com/#langgenius/dify&Date)

## Divulgation de sécurité

Pour protéger votre vie privée, veuillez éviter de publier des problèmes de sécurité sur GitHub. Envoyez plutôt vos questions à security@dify.ai et nous vous fournirons une réponse plus détaillée.

## Licence

Ce dépôt est disponible sous la [Licence Open Source Dify](LICENSE), qui est essentiellement Apache 2.0 avec quelques restrictions supplémentaires.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---