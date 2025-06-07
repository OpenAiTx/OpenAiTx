# Prompt flow

[![Python package](https://img.shields.io/pypi/v/promptflow)](https://pypi.org/project/promptflow/)
[![Python](https://img.shields.io/pypi/pyversions/promptflow.svg?maxAge=2592000)](https://pypi.python.org/pypi/promptflow/)
[![PyPI - Downloads](https://img.shields.io/pypi/dm/promptflow)](https://pypi.org/project/promptflow/)
[![CLI](https://img.shields.io/badge/CLI-reference-blue)](https://microsoft.github.io/promptflow/reference/pf-command-reference.html)
[![vsc extension](https://img.shields.io/visual-studio-marketplace/i/prompt-flow.prompt-flow?logo=Visual%20Studio&label=Extension%20)](https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow)

[![Doc](https://img.shields.io/badge/Doc-online-green)](https://microsoft.github.io/promptflow/index.html)
[![Issue](https://img.shields.io/github/issues/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![Discussions](https://img.shields.io/github/discussions/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![CONTRIBUTING](https://img.shields.io/badge/Contributing-8A2BE2)](https://github.com/microsoft/promptflow/blob/main/CONTRIBUTING.md)
[![License: MIT](https://img.shields.io/github/license/microsoft/promptflow)](https://github.com/microsoft/promptflow/blob/main/LICENSE)

> Rejoignez-nous pour améliorer prompt flow en participant aux [discussions](https://github.com/microsoft/promptflow/discussions),
> en ouvrant des [issues](https://github.com/microsoft/promptflow/issues/new/choose),
> en soumettant des [PRs](https://github.com/microsoft/promptflow/pulls).

**Prompt flow** est une suite d’outils de développement conçue pour rationaliser le cycle de développement de bout en bout des applications d’IA basées sur les LLM, depuis l’idéation, le prototypage, les tests, l’évaluation jusqu’au déploiement en production et la supervision. Elle simplifie considérablement l’ingénierie des prompts et vous permet de construire des applications LLM de qualité production.

Avec prompt flow, vous pourrez :

- **Créer et développer un flow de manière itérative**
    - Créer des [flows](https://microsoft.github.io/promptflow/concepts/concept-flows.html) exécutables qui relient LLMs, prompts, code Python et autres [outils](https://microsoft.github.io/promptflow/concepts/concept-tools.html) ensemble.
    - Déboguer et itérer vos flows, en particulier [tracer l’interaction avec les LLMs](https://microsoft.github.io/promptflow/how-to-guides/tracing/index.html) facilement.
- **Évaluer la qualité et les performances du flow**
    - Évaluer la qualité et la performance de votre flow avec de grands jeux de données.
    - Intégrer les tests et l’évaluation dans votre système CI/CD pour garantir la qualité de votre flow.
- **Cycle de développement rationalisé pour la production**
    - Déployer votre flow sur la plateforme de service de votre choix ou l’intégrer facilement dans le code de votre application.
    - (Optionnel mais fortement recommandé) Collaborer avec votre équipe en utilisant la version cloud de [Prompt flow dans Azure AI](https://learn.microsoft.com/en-us/azure/machine-learning/prompt-flow/overview-what-is-prompt-flow?view=azureml-api-2).

------

## Installation

Pour démarrer rapidement, vous pouvez utiliser un environnement de développement préconstruit. **Cliquez sur le bouton ci-dessous** pour ouvrir le dépôt dans GitHub Codespaces, puis poursuivez la lecture de ce readme !

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/promptflow?quickstart=1)

Si vous souhaitez commencer dans votre environnement local, installez d’abord les packages :

Assurez-vous de disposer d’un environnement python, `python>=3.9, <=3.11` est recommandé.

```sh
pip install promptflow promptflow-tools
```

## Démarrage rapide ⚡

**Créer un chatbot avec prompt flow**

Exécutez la commande pour initier un prompt flow à partir d’un modèle de chat, cela crée un dossier nommé `my_chatbot` et y génère les fichiers nécessaires :

```sh
pf flow init --flow ./my_chatbot --type chat
```

**Configurer une connexion pour votre clé API**

Pour une clé OpenAI, établissez une connexion en exécutant la commande, en utilisant le fichier `openai.yaml` dans le dossier `my_chatbot`, qui stocke votre clé OpenAI (écrasez les clés et le nom avec --set pour éviter de modifier le fichier yaml) :

```sh
pf connection create --file ./my_chatbot/openai.yaml --set api_key=<your_api_key> --name open_ai_connection
```

Pour une clé Azure OpenAI, établissez la connexion en exécutant la commande, en utilisant le fichier `azure_openai.yaml` :

```sh
pf connection create --file ./my_chatbot/azure_openai.yaml --set api_key=<your_api_key> api_base=<your_api_base> --name open_ai_connection
```

**Discuter avec votre flow**

Dans le dossier `my_chatbot`, il y a un fichier `flow.dag.yaml` qui décrit le flow, y compris les entrées/sorties, les nœuds, la connexion et le modèle LLM, etc.

> Notez que dans le nœud `chat`, nous utilisons une connexion nommée `open_ai_connection` (spécifiée dans le champ `connection`) et le modèle `gpt-35-turbo` (spécifié dans le champ `deployment_name`). Le champ deployment_name permet de spécifier le modèle OpenAI, ou la ressource de déploiement Azure OpenAI.

Interagissez avec votre chatbot en lançant : (appuyez sur `Ctrl + C` pour terminer la session)

```sh
pf flow test --flow ./my_chatbot --interactive
```

**Valeur essentielle : garantir une « Haute Qualité » du prototype à la production**

Découvrez notre [**tutoriel de 15 minutes**](https://raw.githubusercontent.com/microsoft/promptflow/main/examples/tutorials/flow-fine-tuning-evaluation/promptflow-quality-improvement.md) qui vous guide à travers l’ajustement des prompts ➡ les tests batch ➡ l’évaluation, tout cela pour garantir une haute qualité prête pour la production.

Étape suivante ! Poursuivez avec la section **Tutoriel** 👇 pour approfondir prompt flow.

## Tutoriel 🏃‍♂️

Prompt flow est un outil conçu pour **construire des applications LLM de haute qualité**. Le processus de développement dans prompt flow suit ces étapes : développer un flow, améliorer la qualité du flow, déployer le flow en production.

### Développez vos propres applications LLM

#### Extension VS Code

Nous proposons également une extension VS Code (un concepteur de flow) pour une expérience de développement interactive avec une interface graphique.

<img src="https://raw.githubusercontent.com/microsoft/promptflow/main/docs/media/readme/vsc.png" alt="vsc" width="1000"/>

Vous pouvez l’installer depuis le <a href="https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow">marketplace visualstudio</a>.

#### Approfondissement du développement de flow

[Démarrer avec prompt flow](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/how-to-guides/quick-start.md) : Un guide étape par étape pour lancer votre premier flow.

### Apprendre à partir des cas d’utilisation

[Tutoriel : Chat avec PDF](https://github.com/microsoft/promptflow/blob/main/examples/tutorials/e2e-development/chat-with-pdf.md) : Un tutoriel complet sur la création d’une application de chat de haute qualité avec prompt flow, incluant le développement du flow et l’évaluation avec des métriques.
> D’autres exemples sont disponibles [ici](https://microsoft.github.io/promptflow/tutorials/index.html#samples). Nous accueillons volontiers les contributions de nouveaux cas d’utilisation !

### Configuration pour les contributeurs

Si vous souhaitez contribuer, commencez par notre guide de configuration de développement : [dev_setup.md](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/dev/dev_setup.md).

Étape suivante ! Poursuivez avec la section **Contribuer** 👇 pour participer à prompt flow.

## Contribuer

Ce projet accueille les contributions et suggestions. La plupart des contributions nécessitent que vous acceptiez un
Contributor License Agreement (CLA) déclarant que vous avez le droit de nous accorder,
et que vous accordez effectivement, le droit d’utiliser votre contribution. Pour plus de détails, visitez https://cla.opensource.microsoft.com.

Lorsque vous soumettez une pull request, un bot CLA déterminera automatiquement si vous devez fournir
un CLA et annotera la PR en conséquence (par exemple, vérification de statut, commentaire). Suivez simplement les instructions
fournies par le bot. Vous n’aurez à le faire qu’une seule fois pour tous les dépôts utilisant notre CLA.

Ce projet a adopté le [Code de Conduite Open Source Microsoft](https://opensource.microsoft.com/codeofconduct/).
Pour plus d’informations, consultez la [FAQ du Code de Conduite](https://opensource.microsoft.com/codeofconduct/faq/) ou
contactez [opencode@microsoft.com](mailto:opencode@microsoft.com) pour toute question ou commentaire supplémentaire.

## Marques commerciales

Ce projet peut contenir des marques ou logos pour des projets, produits ou services. L’utilisation autorisée des marques ou logos Microsoft est soumise et doit respecter les
[Directives Microsoft sur les Marques & la Marque](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general).
L’utilisation des marques ou logos Microsoft dans des versions modifiées de ce projet ne doit pas prêter à confusion ou laisser supposer un parrainage de Microsoft.
Toute utilisation de marques ou logos tiers est soumise aux politiques de ces tiers.

## Code de conduite

Ce projet a adopté le
[Code de Conduite Open Source Microsoft](https://opensource.microsoft.com/codeofconduct/).
Pour plus d’informations, consultez la
[FAQ du Code de Conduite](https://opensource.microsoft.com/codeofconduct/faq/)
ou contactez [opencode@microsoft.com](mailto:opencode@microsoft.com)
pour toute question ou commentaire supplémentaire.

## Collecte de données

Le logiciel peut collecter des informations sur vous et votre utilisation du logiciel et
les envoyer à Microsoft si la télémétrie est activée.
Microsoft peut utiliser ces informations pour fournir des services et améliorer ses produits et services.
Vous pouvez activer la télémétrie comme décrit dans le dépôt.
Il existe également certaines fonctionnalités dans le logiciel qui peuvent vous permettre, ainsi qu’à Microsoft,
de collecter des données auprès des utilisateurs de vos applications. Si vous utilisez ces fonctionnalités, vous
devez respecter la législation applicable, y compris fournir des avis appropriés aux
utilisateurs de vos applications accompagnés d’une copie de la déclaration de confidentialité de Microsoft.
Notre déclaration de confidentialité se trouve à
https://go.microsoft.com/fwlink/?LinkID=824704. Vous pouvez en savoir plus sur la collecte
et l’utilisation des données dans la documentation d’aide et notre déclaration de confidentialité. Votre
utilisation du logiciel vaut consentement à ces pratiques.

### Configuration de la télémétrie

La collecte de télémétrie est activée par défaut.

Pour la désactiver, exécutez `pf config set telemetry.enabled=false`.

## Licence

Copyright (c) Microsoft Corporation. Tous droits réservés.

Distribué sous la licence [MIT](LICENSE).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---