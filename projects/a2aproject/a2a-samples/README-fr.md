# Exemples Agent2Agent (A2A)

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
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=id">Bahasa Indonesia</a>
    </div>
  </details>
</div>

Ce dépôt contient des exemples de code et des démonstrations utilisant le [protocole Agent2Agent (A2A)](https://goo.gle/a2a).

## Dépôts associés

- [A2A](https://github.com/a2aproject/A2A) - Spécification et documentation A2A.
- [a2a-python](https://github.com/a2aproject/a2a-python) - SDK Python pour A2A.
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - Outil UI pour inspecter les agents compatibles A2A.

## Contribution

Les contributions sont les bienvenues ! Voir le [Guide de contribution](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## Obtenir de l'aide

Veuillez utiliser la [page des issues](https://github.com/a2aproject/a2a-samples/issues) pour soumettre des suggestions, des retours ou signaler un bug.

## Avertissement

Ce dépôt n'est pas un produit Google officiellement pris en charge. Le code de ce dépôt est uniquement à des fins de démonstration.

Important : Le code exemple fourni est destiné à la démonstration et illustre la mécanique du protocole Agent-to-Agent (A2A). Lors du développement d'applications en production, il est crucial de considérer tout agent opérant en dehors de votre contrôle direct comme une entité potentiellement non fiable.

Toutes les données reçues d'un agent externe—including mais sans s'y limiter à sa AgentCard, aux messages, artefacts et statuts de tâches—doivent être traitées comme des entrées non fiables. Par exemple, un agent malveillant pourrait fournir une AgentCard contenant des données falsifiées dans ses champs (par exemple, description, nom, skills.description). Si ces données sont utilisées sans assainissement pour construire des invites pour un Large Language Model (LLM), cela pourrait exposer votre application à des attaques d'injection de prompt. Ne pas valider et assainir correctement ces données avant leur utilisation peut introduire des vulnérabilités de sécurité dans votre application.

Les développeurs sont responsables de la mise en œuvre de mesures de sécurité appropriées, telles que la validation des entrées et la gestion sécurisée des identifiants pour protéger leurs systèmes et utilisateurs.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---