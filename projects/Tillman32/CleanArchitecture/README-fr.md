[![Licence : MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![CI - Build and Test](https://github.com/Tillman32/CleanArchitecture/actions/workflows/ci.yml/badge.svg)](https://github.com/Tillman32/CleanArchitecture/actions/workflows/ci.yml)
[![Déployer sur GitHub Pages](https://github.com/Tillman32/CleanArchitecture/actions/workflows/pages.yml/badge.svg)](https://github.com/Tillman32/CleanArchitecture/actions/workflows/pages.yml)

![](https://raw.githubusercontent.com/Tillman32/CleanArchitecture/master/./src/CleanArchitecture.WASM/Preview.png)

[DEMO EN DIRECT - WASM sur GitHub Pages](https://tillman32.github.io/CleanArchitecture/)

# La motivation derrière tout cela

Quel est le but de tout ça ? Eh bien, à part mettre en avant Bob Ross... J’ai pensé qu’il serait astucieux d’avoir une application "réelle" de référence lorsque l’on parle d’architecture. Je veux quelque chose qui fixe une norme, quelque chose à cloner, quelque chose à utiliser dans tous mes prochains projets .Net Core. Comme tout logiciel (et vin), cela s’améliorera avec le temps.

Je trouvais aussi approprié que "Oncle Bob" (Robert C. Martin) partage un nom similaire, et ce projet tente de s’aligner avec son architecture [décrite ici sur son site web.](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)

J’ai également écrit un article de blog pour l’accompagner ici : [https://www.brandontillman.com/blog/clean-architecture-dotnet](https://www.brandontillman.com/blog/clean-architecture-dotnet)

# Points clés :

### :trident: Architecture N-Tiers

Une approche en 3 couches, pour nous préparer à plusieurs interfaces utilisateurs utilisant la même fonctionnalité métier/partie back-end.

### :open_file_folder: Séparation des responsabilités

Étroitement liée au principe de ["Responsabilité unique"](http://deviq.com/single-responsibility-principle/), la Séparation des responsabilités (SoC) rend votre code plus maintenable, en évitant de regrouper plusieurs idées au même endroit. Lorsque les choses changent, la SoC aide à limiter vos modifications à votre ensemble de fonctionnalités, sans les disperser dans toute votre application.

### :droplet: Pas d’abstractions fuyantes

En utilisant des interfaces, nous pouvons éviter les abstractions fuyantes et mieux contrôler la manière dont notre code est utilisé. Au contraire, les consommateurs de notre code n’ont pas à connaître les détails d’implémentation, ils peuvent simplement utiliser vos interfaces/classes.

### :microscope: Testable

Tester un code étroitement couplé est presque impossible. En suivant le principe SoC et en utilisant des interfaces, notre code sera plus facile à tester en conséquence.

### :electric_plug: Modulaire

Le code sera plus facile à modifier à l’avenir, pour plusieurs raisons. La séparation des responsabilités permet de limiter les changements/tests dans toute l’application. Vous pouvez développer des ensembles de fonctionnalités spécifiques, sans modifier le reste du code.

### :wrench: Maintenable

Le code sera intrinsèquement plus facile à maintenir en suivant les modèles de l'Architecture Propre. D'autres développeurs verront l'avantage de cette séparation claire et feront de même.

# Technologies Principales Utilisées

- [.Net](https://dotnet.microsoft.com/)
- [Blazor WASM](https://www.learnblazor.com/)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [AutoMapper](https://automapper.org/)
- [NLog](https://nlog-project.org/)

### :star2: Donnez-lui une étoile ! 
Si vous aimez ce projet ou l’utilisez pour apprendre ou démarrer votre solution, veuillez envisager de lui donner une étoile. Merci !


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-29

---