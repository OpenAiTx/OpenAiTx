<p align="right">
   <strong>Français</strong> | <a href="./.github/README.cn.md">中文</a> | <a href="./.github/README.jp.md">日本語</a>
</p>

<div align="center">

<a href="https://portkey.sh/report-github"><img src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Frame.png"></img></a>
<br>

# Passerelle IA
#### Accédez à plus de 250 LLMs avec une API rapide et conviviale

<img src="https://cfassets.portkey.ai/sdk.gif" width="550px" alt="Démonstration de la passerelle Portkey AI montrant les capacités de routage LLM" style="margin-left:-35px">

[Docs](https://portkey.wiki/gh-1) | [Entreprise](https://portkey.wiki/gh-2) | [Gateway Hébergée](https://portkey.wiki/gh-3) | [Changelog](https://portkey.wiki/gh-4) | [Référence API](https://portkey.wiki/gh-5)


[![License](https://img.shields.io/github/license/Ileriayo/markdown-badges)](./LICENSE)
[![Discord](https://img.shields.io/discord/1143393887742861333)](https://portkey.wiki/gh-6)
[![Twitter](https://img.shields.io/twitter/url/https/twitter/follow/portkeyai?style=social&label=Follow%20%40PortkeyAI)](https://portkey.wiki/gh-7)
[![npm version](https://badge.fury.io/js/%40portkey-ai%2Fgateway.svg)](https://portkey.wiki/gh-8)
[![Better Stack Badge](https://uptime.betterstack.com/status-badges/v1/monitor/q94g.svg)](https://portkey.wiki/gh-9)

<a href="https://us-east-1.console.aws.amazon.com/cloudformation/home?region=us-east-1#/stacks/quickcreate?stackName=portkey-gateway&templateURL=https://portkey-gateway-ec2-quicklaunch.s3.us-east-1.amazonaws.com/portkey-gateway-ec2-quicklaunch.template.yaml"><img src="https://img.shields.io/badge/Deploy_to_EC2-232F3E?style=for-the-badge&logo=amazonwebservices&logoColor=white" alt="Déployer sur AWS EC2" width="105"/></a> [![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/Portkey-AI/gateway)
</div>

<br/>

La [**Passerelle IA**](https://portkey.wiki/gh-10) est conçue pour un routage rapide, fiable et sécurisé vers plus de 1600 modèles de langage, vision, audio et image. C’est une solution légère, open-source et prête pour l’entreprise qui vous permet de vous connecter à n’importe quel modèle de langage en moins de 2 minutes.

- [x] **Ultra rapide** (<1ms de latence) avec une empreinte minime (122kb)
- [x] **Éprouvée en production**, avec plus de 10 milliards de tokens traités chaque jour
- [x] **Prête pour l’entreprise** avec sécurité renforcée, passage à l’échelle et déploiements personnalisés

<br>

#### Que pouvez-vous faire avec la Passerelle IA ?
- Connectez-vous à n’importe quel LLM en moins de 2 minutes - [Démarrage rapide](#quickstart-2-mins)
- Évitez les interruptions grâce aux **[reprises automatiques](https://portkey.wiki/gh-11)** et **[solutions de repli](https://portkey.wiki/gh-12)**
- Faites évoluer vos applications IA avec **[répartition de charge](https://portkey.wiki/gh-13)** et **[routage conditionnel](https://portkey.wiki/gh-14)**
- Protégez vos déploiements IA avec des **[garde-fous](https://portkey.wiki/gh-15)**
- Allez au-delà du texte avec des **[capacités multimodales](https://portkey.wiki/gh-16)**
- Enfin, explorez les intégrations de **[workflows agentiques](https://portkey.wiki/gh-17)**

<br><br>

> [!TIP]
> Mettre une étoile à ce dépôt aide plus de développeurs à découvrir la Passerelle IA 🙏🏻
>
> ![star-2](https://github.com/user-attachments/assets/53597dce-6333-4ecc-a154-eb05532954e4)
> 
<br>


<br>

## Démarrage rapide (2 min)

### 1. Installez votre Passerelle IA

```bash
# Lancez la passerelle localement (nécessite Node.js et npm)
npx @portkey-ai/gateway
```
> La Passerelle fonctionne sur `http://localhost:8787/v1`
> 
> La Console de la Passerelle est accessible sur `http://localhost:8787/public/`

<sup>
Guides de déploiement :
&nbsp; <a href="https://portkey.wiki/gh-18"><img height="12" width="12" src="https://cfassets.portkey.ai/logo/dew-color.svg" /> Portkey Cloud (Recommandé)</a>
&nbsp; <a href="./docs/installation-deployments.md#docker"><img height="12" width="12" src="https://cdn.simpleicons.org/docker/3776AB" /> Docker</a>
&nbsp; <a href="./docs/installation-deployments.md#nodejs-server"><img height="12" width="12" src="https://cdn.simpleicons.org/node.js/3776AB" /> Node.js</a>
&nbsp; <a href="./docs/installation-deployments.md#cloudflare-workers"><img height="12" width="12" src="https://cdn.simpleicons.org/cloudflare/3776AB" /> Cloudflare</a>
&nbsp; <a href="./docs/installation-deployments.md#replit"><img height="12" width="12" src="https://cdn.simpleicons.org/replit/3776AB" /> Replit</a>
&nbsp; <a href="./docs/installation-deployments.md"> Autres...</a>

</sup>

### 2. Faites votre première requête

<!-- <details open>
<summary>Python Example</summary> -->
```python
# pip install -qU portkey-ai

from portkey_ai import Portkey

# Client compatible OpenAI
client = Portkey(
    provider="openai", # ou 'anthropic', 'bedrock', 'groq', etc
    Authorization="sk-***" # la clé API du provider
)

# Effectuer une requête via votre Passerelle IA
client.chat.completions.create(
    messages=[{"role": "user", "content": "Quel temps fait-il ?"}],
    model="gpt-4o-mini"
)
```



<sup>Bibliothèques supportées :
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/javascript/3776AB" /> JS](https://portkey.wiki/gh-19)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/python/3776AB" /> Python](https://portkey.wiki/gh-20)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/gnubash/3776AB" /> REST](https://portkey.sh/gh-84)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/openai/3776AB" /> SDK OpenAI](https://portkey.wiki/gh-21)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/langchain/3776AB" /> Langchain](https://portkey.wiki/gh-22)
&nbsp; [LlamaIndex](https://portkey.wiki/gh-23)
&nbsp; [Autogen](https://portkey.wiki/gh-24)
&nbsp; [CrewAI](https://portkey.wiki/gh-25)
&nbsp; [Plus...](https://portkey.wiki/gh-26)
</sup>

Sur la Console de la Passerelle (`http://localhost:8787/public/`), vous pouvez visualiser tous vos logs locaux au même endroit.

<img src="https://github.com/user-attachments/assets/362bc916-0fc9-43f1-a39e-4bd71aac4a3a" width="400" />


### 3. Routage & Garde-fous
Les `Configs` dans la passerelle LLM vous permettent de créer des règles de routage, d'ajouter de la fiabilité et de configurer des garde-fous.
```python
config = {
  "retry": {"attempts": 5},

  "output_guardrails": [{
    "default.contains": {"operator": "none", "words": ["Apple"]},
    "deny": True
  }]
}

# Attacher la config au client
client = client.with_options(config=config)

client.chat.completions.create(
    model="gpt-4o-mini",
    messages=[{"role": "user", "content": "Réponds aléatoirement avec Apple ou Bat"}]
)

# Cela répondra toujours "Bat" car le garde-fou refuse toutes les réponses contenant "Apple". La config retry tentera 5 fois avant d'abandonner.
```
<div align="center">
<img src="https://portkey.ai/blog/content/images/size/w1600/2024/11/image-15.png" width=600 title="Flux de requête à travers la passerelle IA de Portkey avec reprises et garde-fous" alt="Flux de requête à travers la passerelle IA de Portkey avec reprises et garde-fous"/>
</div>

Vous pouvez faire beaucoup plus avec les configs dans votre passerelle IA. [Voir les exemples  →](https://portkey.wiki/gh-27)

<br/>

### Version Entreprise (Déploiements privés)

<sup>

[<img height="12" width="12" src="https://cfassets.portkey.ai/amazon-logo.svg" /> AWS](https://portkey.wiki/gh-28)
&nbsp; [<img height="12" width="12" src="https://cfassets.portkey.ai/azure-logo.svg" /> Azure](https://portkey.wiki/gh-29)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/googlecloud/3776AB" /> GCP](https://portkey.wiki/gh-30)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/redhatopenshift/3776AB" /> OpenShift](https://portkey.wiki/gh-31)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/kubernetes/3776AB" /> Kubernetes](https://portkey.wiki/gh-85)

</sup>

La [version entreprise](https://portkey.wiki/gh-86) de la Passerelle LLM offre des fonctionnalités avancées pour la **gestion d’organisation**, la **gouvernance**, la **sécurité** et [plus](https://portkey.wiki/gh-87) prêtes à l’emploi. [Voir la comparaison des fonctionnalités →](https://portkey.wiki/gh-32)

L’architecture de déploiement entreprise pour les plateformes supportées est disponible ici - [**Déploiements privés en cloud entreprise**](https://portkey.wiki/gh-33)

<a href="https://portkey.sh/demo-13"><img src="https://portkey.ai/blog/content/images/2024/08/Get-API-Key--5-.png" height=50 alt="Réservez une démo de la passerelle IA entreprise" /></a><br/>


<br>

<hr>

### Heures d’ingénierie IA

Rejoignez les appels communautaires hebdomadaires tous les vendredis (8h PT) pour démarrer votre implémentation de la Passerelle IA ! [Chaque vendredi](https://portkey.wiki/gh-35)

<a href="https://portkey.wiki/gh-35"><img width="500" src="https://github.com/user-attachments/assets/c2885699-f197-4289-b819-21eb839fbae1" /></a>

Comptes-rendus des réunions [publiés ici](https://portkey.wiki/gh-36).


<hr>

### LLMs en Production 2025

Analyses issues de l’étude de plus de 2 000 milliards de tokens, à travers 90+ régions et 650+ équipes en production. Ce que vous trouverez dans ce rapport :
- Tendances qui façonnent l’adoption de l’IA et la croissance des fournisseurs LLM.
- Référentiels pour optimiser la vitesse, le coût et la fiabilité.
- Stratégies pour faire évoluer des systèmes IA prêts pour la production.

<a href="https://portkey.sh/report-github"><img width="500" src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Image.png" /></a>

<a href="https://portkey.sh/report-github">**Obtenir le rapport**</a>
<hr>


## Fonctionnalités principales
### Routage fiable
- <a href="https://portkey.wiki/gh-37">**Reprises automatiques (Fallbacks)**</a> : Basculez vers un autre fournisseur ou modèle lors de requêtes échouées en utilisant la passerelle LLM. Vous pouvez spécifier les erreurs qui déclenchent la reprise. Améliore la fiabilité de votre application.
- <a href="https://portkey.wiki/gh-38">**Reprises automatiques (Automatic Retries)**</a> : Relancez automatiquement les requêtes échouées jusqu'à 5 fois. Une stratégie de backoff exponentiel espace les tentatives pour éviter la surcharge du réseau.
- <a href="https://portkey.wiki/gh-39">**Répartition de charge (Load Balancing)**</a> : Distribuez les requêtes LLM entre plusieurs clés API ou fournisseurs d’IA avec des pondérations pour garantir une haute disponibilité et des performances optimales.
- <a href="https://portkey.wiki/gh-40">**Délai d'expiration des requêtes (Request Timeouts)**</a> : Gérez les LLM imprévisibles & les latences en configurant des délais d’expiration granulaires, permettant la résiliation automatique des requêtes dépassant une durée spécifiée.
- <a href="https://portkey.wiki/gh-41">**Passerelle LLM multimodale (Multi-modal LLM Gateway)**</a> : Appelez des modèles de vision, audio (texte-parole & parole-texte) et de génération d’images de plusieurs fournisseurs — tout en utilisant la signature OpenAI familière.
- <a href="https://portkey.wiki/gh-42">**APIs temps réel (Realtime APIs)**</a> : Appelez les APIs temps réel lancées par OpenAI via le serveur websockets intégré.

### Sécurité & Précision
- <a href="https://portkey.wiki/gh-88">**Garde-fous (Guardrails)**</a> : Vérifiez les entrées et sorties de vos LLM pour respecter vos contrôles spécifiés. Choisissez parmi plus de 40 garde-fous préconstruits pour garantir la conformité aux normes de sécurité et de précision. Vous pouvez <a href="https://portkey.wiki/gh-43">apporter vos propres garde-fous</a> ou choisir parmi nos <a href="https://portkey.wiki/gh-44">nombreux partenaires</a>.
- [**Gestion sécurisée des clés**](https://portkey.wiki/gh-45) : Utilisez vos propres clés ou générez des clés virtuelles à la volée.
- [**Contrôle d’accès basé sur les rôles**](https://portkey.wiki/gh-46) : Contrôle d’accès granulaire pour vos utilisateurs, espaces de travail et clés API.
- <a href="https://portkey.wiki/gh-47">**Conformité & Confidentialité des données**</a> : La passerelle IA est conforme SOC2, HIPAA, RGPD et CCPA.

### Gestion des coûts
- [**Cache intelligent**](https://portkey.wiki/gh-48) : Mettez en cache les réponses des LLM pour réduire les coûts et améliorer la latence. Prend en charge le cache simple et sémantique*.
- [**Analyse d’utilisation**](https://portkey.wiki/gh-49) : Surveillez et analysez votre utilisation de l’IA et des LLM, y compris le volume de requêtes, la latence, les coûts et les taux d’erreurs.
- [**Optimisation des fournisseurs***](https://portkey.wiki/gh-89) : Basculez automatiquement vers le fournisseur le plus rentable selon les modèles d’utilisation et de tarification.

### Collaboration & Workflows
- <a href="https://portkey.ai/docs/integrations/agents">**Support des Agents**</a> : Intégrez facilement les frameworks d’agents populaires pour créer des applications IA complexes. La passerelle s’intègre parfaitement avec [Autogen](https://portkey.wiki/gh-50), [CrewAI](https://portkey.wiki/gh-51), [LangChain](https://portkey.wiki/gh-52), [LlamaIndex](https://portkey.wiki/gh-53), [Phidata](https://portkey.wiki/gh-54), [Control Flow](https://portkey.wiki/gh-55), et même [Agents personnalisés](https://portkey.wiki/gh-56).
- [**Gestion des modèles de prompts***](https://portkey.wiki/gh-57) : Créez, gérez et versionnez vos modèles de prompts de manière collaborative via un bac à sable universel.
<br/><br/>

<sup>
*&nbsp;Disponible dans les versions hébergées et entreprise
</sup>

<br>

## Recettes (Cookbooks)

### ☄️ Tendance
- Utilisez les modèles de [Nvidia NIM](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/providers/nvidia.ipynb) avec AI Gateway
- Surveillez les [Agents CrewAI](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/CrewAI_with_Telemetry.ipynb) avec Portkey !
- Comparez les [10 meilleurs modèles LMSYS](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/LMSYS%20Series/comparing-top10-LMSYS-models-with-Portkey.ipynb) avec AI Gateway.

### 🚨 Derniers ajouts
* [Créez des jeux de données synthétiques avec Nemotron](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/Nemotron_GPT_Finetuning_Portkey.ipynb)
* [Utilisez la passerelle LLM avec le SDK AI de Vercel](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/integrations/vercel-ai.md)
* [Surveillez les agents Llama avec la passerelle LLM de Portkey](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/Llama_Agents_with_Telemetry.ipynb)

[Voir toutes les recettes →](https://portkey.wiki/gh-58)
<br/><br/>

## Fournisseurs supportés

Découvrez les intégrations Gateway avec [45+ fournisseurs](https://portkey.wiki/gh-59) et [8+ frameworks d’agents](https://portkey.wiki/gh-90).

|                                                                                                                            | Fournisseur                                                                                    | Support | Flux   |
| -------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | ------- | ------ |
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


> [Voir la liste complète des 200+ modèles supportés ici](https://portkey.wiki/gh-74)
<br>

<br>

## Agents
La passerelle s’intègre de manière transparente avec les frameworks d’agents populaires. [Lire la documentation ici](https://portkey.wiki/gh-75).


| Framework | Appeler 200+ LLMs | Routage avancé | Mise en cache | Journalisation & Tracing* | Observabilité* | Gestion des prompts* |
|------------------------------|--------|-------------|---------|------|---------------|-------------------|
| [Autogen](https://portkey.wiki/gh-93)    | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [CrewAI](https://portkey.wiki/gh-94)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [LangChain](https://portkey.wiki/gh-95)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Phidata](https://portkey.wiki/gh-96)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Llama Index](https://portkey.wiki/gh-97)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Control Flow](https://portkey.wiki/gh-98) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Créer vos propres agents](https://portkey.wiki/gh-99) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |

<br>

*Disponible sur l’[application hébergée](https://portkey.wiki/gh-76). Pour une documentation détaillée [cliquez ici](https://portkey.wiki/gh-100).


## Version Entreprise de la Passerelle
Rendez votre application IA plus <ins>fiable</ins> et <ins>compatible avec le futur</ins>, tout en assurant une <ins>sécurité</ins> et une <ins>confidentialité</ins> complètes des données.

✅&nbsp; Gestion sécurisée des clés - pour un contrôle d’accès basé sur les rôles et le suivi <br>
✅&nbsp; Mise en cache simple & sémantique - pour répondre plus rapidement aux requêtes répétées et réduire les coûts <br>
✅&nbsp; Contrôle d’accès & règles entrantes - pour contrôler quelles IPs et zones géographiques peuvent se connecter à vos déploiements <br>
✅&nbsp; Rédaction PII - pour supprimer automatiquement les données sensibles de vos requêtes et éviter leur divulgation accidentelle <br>
✅&nbsp; Conformités SOC2, ISO, HIPAA, RGPD - pour de meilleures pratiques de sécurité <br>
✅&nbsp; Support professionnel - avec priorisation des fonctionnalités <br>

[Planifier un appel pour discuter des déploiements entreprise](https://portkey.sh/demo-13)

<br>


## Contribuer

La façon la plus simple de contribuer est de choisir un ticket avec le tag `good first issue` 💪. Lisez les directives de contribution [ici](https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/CONTRIBUTING.md).

Un bug ? [Signalez-le ici](https://portkey.wiki/gh-78) | Demande de fonctionnalité ? [Soumettez-la ici](https://portkey.wiki/gh-78)


### Bien débuter avec la communauté
Rejoignez nos AI Engineering Hours chaque vendredi (8h PT) pour :
- Rencontrer d’autres contributeurs et membres de la communauté
- Découvrir les fonctionnalités avancées de Gateway et les modèles d’implémentation
- Partager vos expériences et obtenir de l’aide
- Rester informé des dernières priorités de développement

[Rejoindre la prochaine session →](https://portkey.wiki/gh-101) | [Notes de réunion](https://portkey.wiki/gh-102)

<br>

## Communauté

Rejoignez notre communauté grandissante dans le monde entier, pour de l’aide, des idées et des discussions sur l’IA.

- Lisez notre [blog officiel](https://portkey.wiki/gh-78)
- Discutez avec nous sur [Discord](https://portkey.wiki/community)
- Suivez-nous sur [Twitter](https://portkey.wiki/gh-79)
- Connectez-vous avec nous sur [LinkedIn](https://portkey.wiki/gh-80)
- Lisez la documentation en [japonais](https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.jp.md)
- Retrouvez-nous sur [YouTube](https://portkey.wiki/gh-103)
- Rejoignez notre [communauté Dev](https://portkey.wiki/gh-82)
<!-- - Questions taguées #portkey sur [Stack Overflow](https://stackoverflow.com/questions/tagged/portkey) -->

![Rubeus Social Share (4)](https://github.com/Portkey-AI/gateway/assets/971978/89d6f0af-a95d-4402-b451-14764c40d03f)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---