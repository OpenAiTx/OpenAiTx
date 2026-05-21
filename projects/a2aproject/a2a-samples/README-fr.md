# Échantillons Agent2Agent (A2A)

<a href="https://studio.firebase.google.com/new?template=https%3A%2F%2Fgithub.com%2Fa2aproject%2Fa2a-samples%2Ftree%2Fmain%2F.firebase-studio">
  <picture>
    <source
      media="(prefers-color-scheme: dark)"
      srcset="https://cdn.firebasestudio.dev/btn/try_light_20.svg">
    <source
      media="(prefers-color-scheme: light)"
      srcset="https://cdn.firebasestudio.dev/btn/try_dark_20.svg">
    <img
      height="20"
      alt="Essayer dans Firebase Studio"
      src="https://cdn.firebasestudio.dev/btn/try_blue_20.svg">
  </picture>
</a>

<div style="text-align: right;">
  <details>
    <summary>🌐 Langue</summary>
    <div style="text-align: center;">
      <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=en">English</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-CN">简体中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-TW">繁體中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ja">日本語</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ko">한국어</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=hi">हिन्दी</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=th">ไทย</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fr">Français</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=de">Deutsch</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=es">Español</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=it">Italiano</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ru">Русский</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pt">Português</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=nl">Nederlands</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pl">Polski</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ar">العربية</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fa">فارسی</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=tr">Türkçe</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=vi">Tiếng Việt</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fr">Français</a>
    </div>
  </details>
</div>

Bienvenue sur les exemples de code officiels et les démonstrations du [Protocole Agent2Agent (A2A)](https://goo.gle/a2a).

Nous sommes ravis de vous accueillir ! Que vous découvriez l’architecture multi-agent ou que vous construisiez des réseaux d’agents avancés et interopérables, ce dépôt propose des ressources d’apprentissage simples, inspirantes et accessibles pour accélérer votre développement.

## Pourquoi Agent2Agent ?

Dans un monde composé de divers cadres et écosystèmes d’IA, les agents ont besoin d’un langage commun pour communiquer, collaborer et déléguer des tâches en toute sécurité. Le protocole A2A établit une norme ouverte et standardisée pour l’interopérabilité multi-agent.

Nos exemples démontrent la simplicité avec laquelle des problèmes multi-agents complexes peuvent être résolus à travers différents langages et applications hôtes.

## Démarrage rapide

Démarrez immédiatement en lançant un agent Helloworld et en communiquant avec lui via notre hôte CLI Python.

1. **Démarrer le serveur Agent** :
   Ouvrez un terminal et démarrez le serveur de l’agent Helloworld :

   ```bash
   cd samples/python/agents/helloworld
   uv run .
   ```

2. **Exécutez le client hôte** :
   Ouvrez un deuxième terminal et lancez le client CLI pour envoyer une tâche à l’agent :

   ```bash
   cd samples/python/agents/helloworld
   uv run test_client.py
   ```

## Structure du dépôt

Le dépôt est organisé en plusieurs répertoires clés par langage :

| Répertoire | Description |
| --- | --- |
| [samples](/samples) | Exemples principaux A2A organisés par langage de programmation. |
| [samples/python](/samples/python) | Présente des implémentations d’agents Python utilisant le SDK A2A Python. |
| [samples/go](/samples/go) | Présente des implémentations d’agents Go utilisant le SDK A2A Go. |
| [samples/dotnet](/samples/dotnet) | Présente des implémentations d’agents C# utilisant le SDK A2A .NET. |
| [samples/java](/samples/java) | Présente des implémentations d’agents Java utilisant le SDK A2A Java. |
| [samples/js](/samples/js) | Présente des implémentations d’agents Node.js utilisant le SDK A2A JavaScript. |

## Contribution

Nous accueillons et encourageons les contributions de tous niveaux ! Si vous avez une idée de nouvel exemple, une correction de bug ou une amélioration de la documentation, consultez notre [Guide de contribution](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## Obtenir de l’aide

Nous nous engageons à offrir une communauté accueillante et bienveillante. Si vous avez des questions, des retours ou rencontrez des problèmes, contactez-nous sur notre [page d’incidents](https://github.com/a2aproject/a2a-samples/issues).

## Dépôts associés

| Dépôt | Catégorie | Description |
| --- | --- | --- |
| [A2A](https://github.com/a2aproject/A2A) | Spécification principale | Spécification A2A et documentation. |
| [a2a-inspector](https://github.com/a2aproject/a2a-inspector) | Outils | Interface UI pour inspecter les agents compatibles A2A. |
| [a2a-tck](https://github.com/a2aproject/a2a-tck) | Tests | Suite de tests pour valider la conformité au protocole A2A. |
| [a2a-itk](https://github.com/a2aproject/a2a-itk) | Tests | Boîte à outils pour vérifier la compatibilité entre différentes implémentations SDK A2A, avec modèle multi-hop et divers protocoles de transport. |
| [a2a-python](https://github.com/a2aproject/a2a-python) | SDK (Python) | SDK Python officiel pour A2A. |
| [a2a-go](https://github.com/a2aproject/a2a-go) | SDK (Go) | SDK Go officiel pour A2A. |
| [a2a-java](https://github.com/a2aproject/a2a-java) | SDK (Java) | SDK Java officiel pour A2A. |
| [a2a-js](https://github.com/a2aproject/a2a-js) | SDK (JavaScript) | SDK Node.js/JavaScript officiel pour A2A. |
| [a2a-dotnet](https://github.com/a2aproject/a2a-dotnet) | SDK (C#/.NET) | SDK C#/.NET officiel pour A2A. |
| [a2a-rs](https://github.com/a2aproject/a2a-rs) | SDK (Rust) | SDK Rust officiel pour A2A. |

## Avertissement

**Important :** Le code d’exemple fourni est à des fins de démonstration et illustre la mécanique du
Protocole Agent-à-Agent (A2A). Lors de la création d'applications en production, il est essentiel de considérer tout agent fonctionnant hors de votre contrôle direct comme une entité potentiellement non fiable.

Toutes les données reçues d'un agent externe—including mais sans s'y limiter à sa AgentCard, messages,
artéfacts et statuts de tâches—doivent être traitées comme des entrées non fiables. Par exemple, un agent malveillant
pourrait fournir une AgentCard contenant des données manipulées dans ses champs (par exemple, description, nom,
skills.description). Si ces données sont utilisées sans être nettoyées pour construire des prompts pour un Large
Language Model (LLM), elles pourraient exposer votre application à des attaques par injection de prompt. Le fait de ne
pas valider et nettoyer correctement ces données avant leur utilisation peut introduire des vulnérabilités de sécurité dans
votre application.

> Les développeurs sont responsables de la mise en œuvre de mesures de sécurité appropriées, telles que la validation des entrées
> et la gestion sécurisée des identifiants pour protéger leurs systèmes et leurs utilisateurs.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-21

---