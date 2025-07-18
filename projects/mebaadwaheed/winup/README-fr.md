<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

![PRs Bienvenus](https://img.shields.io/badge/PRs-welcome-brightgreen)
![Python 3.9+](https://img.shields.io/badge/python-3.9%2B-blue)
![Architecture par Composants](https://img.shields.io/badge/architecture-component--driven-orange)
![Application de Bureau](https://img.shields.io/badge/platform-desktop-lightgrey)
![Support CLI](https://img.shields.io/badge/CLI-supported-critical)
![Rechargement en Direct](https://img.shields.io/badge/live--reload-enabled-blue)

## Exemples d'Images

![image](https://github.com/user-attachments/assets/81d016e9-e10a-4438-ab94-99b6d76b8efe)

![image](https://github.com/user-attachments/assets/154dc3f4-ea8c-4f6f-84d3-88c7ab74a46f)

![image](https://github.com/user-attachments/assets/2318f701-6ec8-4402-abcc-40c879bf1a10)

# WinUp 🚀

## Assurez-vous de télécharger la dernière version stable (LSR) et non la dernière/LFR ! LSR actuelle : 2.4.9

`pip install winup==2.4.9`

**Un framework Pythonique et puissant pour créer de magnifiques applications de bureau.**

WinUp est un framework d'interface moderne pour Python qui encapsule la puissance de PySide6 (Qt) dans une API simple, déclarative et conviviale. Il est conçu pour vous permettre de créer des applications plus rapidement, d'écrire un code plus propre et de profiter du processus de développement.

### ✨ Maintenant avec le support Web !
WinUp permet désormais de créer des applications web interactives et à état en utilisant la même approche centrée Python et basée sur les composants. Le module web utilise FastAPI et WebSockets sous le capot pour apporter la simplicité de WinUp au navigateur.

[Documentation Web](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/web/README.md)

> **Avertissement :** Le support web est une fonctionnalité optionnelle. Pour l'utiliser, vous devez installer les dépendances web :
> ```bash
> pip install "winup[web]"
> ```

[Contribuer](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CONTRIBUTING.md)
[Changelog](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CHANGELOG.md)
[Licence](LICENSE)

---

## Pourquoi WinUp ? (Au lieu de PySide6 brut ou Tkinter)

Le développement d'applications de bureau en Python peut sembler lourd. WinUp a été créé pour corriger cela.

| Fonctionnalité           | Façon WinUp ✨                                                                | Façon PySide6 / Tkinter 😟                                                                  |
| ------------------------ | ----------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| **Layouts**              | `ui.Column(children=[...])`, `ui.Row(children=[...])`                         | `QVBoxLayout()`, `QHBoxLayout()`, `layout.addWidget()`, `pack()`, `grid()`                  |
| **Style**                | `props={"background-color": "blue", "font-size": "16px"}`                     | Chaînes QSS manuelles, `widget.setStyleSheet(...)`, objets de style complexes.              |
| **Gestion d'État**       | `state.bind(widget, "prop", "key")`                                           | Fonctions de rappel manuelles, getters/setters, `StringVar()`, du boilerplate partout.      |
| **Liaison Bidirectionnelle** | `state.bind_two_way(input_widget, "key")`                                 | N'existe pas. Nécessite des handlers `on_change` pour mettre à jour état et UI.             |
| **Outils Développeur**   | **Rechargement à Chaud intégré**, profileur de code, outils de fenêtre natifs.| N'existe pas. Redémarrer l'app pour chaque modification d'UI.                               |
| **Structure de Code**    | Composants réutilisables et autonomes avec `@component`.                      | Souvent de grandes classes monolithiques ou des scripts procéduraux.                        |

**En résumé, WinUp apporte les "killer features" des frameworks web modernes (comme React ou Vue) sur le bureau, vous faisant gagner du temps et vous concentrer sur l'essentiel : la logique de votre application.**

# 🧊 WinUp vs 🧱 PyEdifice (Demande d'utilisateur Reddit)

| Fonctionnalité                   | WinUp      | PyEdifice                        |
|----------------------------------|--------------------------------------|----------------------------------|
| 🧱 Architecture                  | Style React + état           | Style React + état               |
| 🌐 Routage intégré               | ✅ Oui (`Router(routes={...})`)      | ❌ Pas de routage intégré         |
| ♻️ Hooks de cycle de vie         | ✅ `on_mount`, `on_unmount`, etc.    | ⚠️ Limité (`did_mount`, etc.)    |
| 🎨 Thématisation / Style         | ✅ Thèmes globaux & locaux           | ❌ Injection CSS manuelle         |
| 🔲 Options de layout             | ✅ Row, Column, Grid, Stack, Flexbox | ⚠️ Principalement Box & HBox/VBox |
| 🎞️ Animations                   | ✅ Intégrées (fondu, zoom, etc.)     | ❌ Aucune intégrée                |
| 🔁 Rechargement à chaud (LHR)    | ✅ Stable + rapide (`loadup dev`)    | ⚠️ Expérimental, support limité   |
| 📦 Packaging                     | ✅ Avec LoadUp (basé sur PyInstaller)| ❌ Intégrer PyInstaller manuellement|
| 🧩 Réutilisabilité des composants| ✅ Élevée, déclaratif                | ✅ Élevée                         |

| 🛠 Outils de développement        | ✅ DevTools prévu, Inspector bientôt  | ❌ Aucun pour l’instant              |
| 📱 Support mobile                | ❌ Pas encore                         | ❌ Non supporté                      |
| 🧠 Courbe d’apprentissage        | ✅ Facile pour utilisateurs Python+React | ✅ Facile mais moins d’outils        |

> ✅ = Intégré ou robuste  
> ⚠️ = Partiel ou limité  
> ❌ = Complètement absent
---

## Fonctionnalités principales

*   **UI déclarative et pythonique :** Construisez des layouts complexes avec de simples objets `Row` et `Column` au lieu de layouts en boîtes encombrants.
*   **Architecture basée sur les composants :** Utilisez le décorateur `@component` pour créer des widgets UI modulaires et réutilisables à partir de fonctions simples.
*   **Système de style puissant :** Stylisez vos widgets avec de simples dictionnaires Python via `props`. Créez des classes globales "type CSS" avec `style.add_style_dict`.
*   **Structure d’application complète :** Créez des applications professionnelles avec une API déclarative pour `MenuBar`, `ToolBar`, `StatusBar` et `SystemTrayIcon`.
*   **Gestionnaire de tâches asynchrone :** Exécutez des opérations longues en arrière-plan sans bloquer votre UI grâce au simple décorateur `@tasks.run`.
*   **Performance par défaut :** Comprend un décorateur optionnel `@memo` pour mettre en cache les rendus des composants et éviter les recalculs inutiles.
*   **Extensibilité avancée :**
    *   **Widget Factory :** Remplacez n’importe quel widget par votre propre implémentation personnalisée (ex. basée C++) via `ui.register_widget()`.
    *   **Fenêtres multiples :** Créez et gérez plusieurs fenêtres indépendantes pour des applications complexes comme des palettes d’outils ou lecteurs de musique.
*   **Gestion d’état réactive :**
    *   **Binding à sens unique :** Mettez à jour automatiquement votre UI quand vos données changent avec `state.bind()`.
    *   **Binding bidirectionnel :** Synchronisez facilement vos widgets d’entrée avec votre état grâce à `state.bind_two_way()`.
    *   **Abonnements :** Déclenchez n’importe quelle fonction en réponse à des changements d’état avec `state.subscribe()`.
*   **Outils développeur conviviaux :**
    *   **Hot Reloading :** Visualisez instantanément vos modifications UI sans redémarrer votre application.
    *   **Profileur :** Mesurez facilement la performance de toute fonction avec le décorateur `@profiler.measure()`.
    *   **Outils fenêtre :** Centrez, faites clignoter ou gérez votre fenêtre d’application facilement.
*   **Routage intégré :** Créez simplement des applications multi-pages avec un routeur intuitif piloté par l’état.
*   **Couche de données flexible :** Comprend des connecteurs simples et cohérents pour SQLite, PostgreSQL, MySQL, MongoDB et Firebase.

---

# Documentation

Explorez plus en profondeur les fonctionnalités de WinUp :

## Concepts de base
- [**Modèle de composant & stylisation**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md)
- [**Gestion de l’état**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/state.md)
- [**Hooks de cycle de vie**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#component-lifecycle-hooks-on_mount-and-on_unmount)
- [**Routage**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#routing)
- [**Positionnement absolu (avancé)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/absolute-layout.md)

## Outils développeur
- [**Live Hot Reload (LHR)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/live-hot-reload.md)
- [**Profileur de performance**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/profiler.md)
- [**Mémorisation**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/memoization.md)
- [**Gestionnaire de tâches asynchrones**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/tasks.md)

## Composants UI
- [**Bibliothèque complète de composants**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/components/README.md)

---

## Contribuer

WinUp est un projet open source. Les contributions sont les bienvenues !

## Licence

Ce projet est sous licence MIT. Voir **LICENSE** pour plus d’informations.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---