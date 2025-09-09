# pproftui : Profilage Go interactif dans votre terminal

`pproftui` est une interface utilisateur en terminal pour le `pprof` de Go qui rend le profilage interactif, intuitif et rapide. Il est conçu pour vous aider à identifier les problèmes de performance sans changer de contexte avec un navigateur web et pour fournir des explications intégrées sur les concepts de profilage.

![Démo](https://raw.githubusercontent.com/Oloruntobi1/pproftui/main/./demo.gif)

---

## Pourquoi `pproftui` ?

L’outil standard `go tool pprof` est puissant mais peut manquer d’intuition. Vous vous demandez souvent :
*   « Que signifient vraiment `flat` vs `cum` ? »
*   « Laquelle de ces 100 fonctions runtime est *mon* code ? »
*   « Comment trouver ce qui a changé entre cette version et la précédente ? »
*   « Pourquoi dois-je sans cesse alterner entre mon navigateur et mon code ? »

`pproftui` résout directement ces problèmes :
*   **Vues intégrées Source & Graphique :** Visualisez le code source de n’importe quelle fonction ou naviguez dans son graphe d’appels sans jamais quitter votre terminal.
*   **Concentrez-vous sur votre code :** Met en surbrillance automatiquement les fonctions de votre projet. Appuyez sur `p` pour masquer instantanément tout le bruit runtime et vendor.
*   **Différences puissantes et intuitives :** Comparez deux profils pour voir non seulement *ce qui* a changé, mais *pourquoi*. L’interface vous aide à retracer la source d’une régression via la pile d’appels.
*   **Profilage en temps réel :** Pointez `pproftui` vers un service en cours d’exécution et regardez son profil se mettre à jour en temps réel.
*   **Aide intégrée (F1) :** Obtenez des explications claires et simples des termes de profilage (`cpu`, `inuse_space`, `flat` vs `cum`) au moment où vous en avez besoin.

---

## Pour commencer

### Installation
```sh
go install github.com/Oloruntobi1/pproftui@latest
```

### Le Livre de Recettes : Flux de Travail Courants pour le Profilage

Voici des recettes pratiques pour résoudre les problèmes de performance courants avec `pproftui`.

#### Recette 1 : Investiguer un Ralentissement dans un Binaire Local
Vous avez remarqué qu'une fonction est lente. Générons un profil CPU et explorons-le.

1.  **Générer le profil :**
    ```sh
    go test -bench=. -cpuprofile=cpu.prof
    ```
2.  **Analysez-le avec `pproftui` :**

    ```sh
    pproftui cpu.prof
    ```
    *   Appuyez sur `c` pour basculer entre la vue du code source et le graphe des appelants/appelés.
    *   Appuyez sur `F1` à tout moment si vous ne comprenez pas la signification du type de profil.

#### Recette 2 : Trouver une régression de performance (Le flux de travail Diff)
Vous suspectez qu'un commit récent a ralenti les choses. Le diffing de `pproftui` est sa superpuissance.

1.  **Obtenez un profil depuis votre branche `main` :**
    ```sh
    git checkout main
    go test -bench=. -cpuprofile=main.prof
    ```
2.  **Obtenez un profil depuis votre branche de fonctionnalité :**

    ```sh
    git checkout your-feature-branch
    go test -bench=. -cpuprofile=feature.prof
    ```
3.  **Comparer les différences :**

    ```sh
    pproftui main.prof feature.prof
    ```
    `pproftui` vous montrera maintenant le *delta*. Le vert (`+`) signifie que plus de ressources ont été utilisées dans `feature.prof`, le rouge (`-`) signifie moins. Utilisez cela pour naviguer dans le graphique et trouver la fonction exacte qui a introduit la nouvelle surcharge.

#### Recette 3 : Profilage d’un service en direct
Vous souhaitez voir comment votre application se comporte sous charge dans un environnement de préproduction.

1.  **Assurez-vous que votre application expose les points de terminaison pprof.** (par exemple, en important `net/http/pprof`)
2.  **Exécutez `pproftui` en mode live :**
    ```sh
    # This will fetch a 5-second CPU profile every 10 seconds.
    pproftui -live="http://localhost:6060/debug/pprof/profile?seconds=5" -refresh=10s
    ```
    *   Appuyez sur `espace` pour mettre en pause et reprendre les mises à jour en direct.

#### Recette 4 : Couper à travers le bruit
Les profils sont remplis de code d'exécution et de bibliothèques. Voici comment se concentrer sur ce qui compte : **votre code.**

```sh
# Provide your project's go module path
pproftui --module-path="github.com/your/project" cpu.prof
```
*   Les fonctions de votre projet seront désormais marquées d'un `★`.
*   Appuyez sur `p` pour activer le mode "Projet uniquement", masquant instantanément tout le reste.

---

## Raccourcis clavier

| Touche      | Action                                                |
| :---------- | :---------------------------------------------------- |
| `↑`/`↓`     | Naviguer dans la liste des fonctions                  |
| `t`         | Basculer le type de profil (`inuse_space`, `alloc_objects`)  |
| `c`         | Basculer entre la vue **c**ode et le graphe **c**all  |
| `p`         | Basculer le filtre de code **p**rojet uniquement       |
| `s`         | Changer l'ordre de **s**ort (`Self`, `Total`, `Name`)  |
| `f`         | Basculer la vue du graphe de **f**lamme                |
| `Enter`     | *Dans le graphe de flamme :* Zoomer sur la fonction sélectionnée |
| `Esc`       | *Dans le graphe de flamme :* Dézoomer                   |
| `F1`        | Afficher l'**aide** détaillée et les explications      |
| `q` / `ctrl+c`| **Q**uitter                                         |


---

## Licence

MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---