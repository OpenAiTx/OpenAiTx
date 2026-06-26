## <img width=16 src="https://raw.githubusercontent.com/JonasGruenwald/spectator/refs/heads/main/spectator/src/spectator/internal/assets/lucy_spectator.svg"> Spectator

[![Package Version](https://img.shields.io/hexpm/v/spectator)](https://hex.pm/packages/spectator)
[![Hex Docs](https://img.shields.io/badge/hex-docs-ffaff3)](https://hexdocs.pm/spectator/)

Spectator est un outil d’observation BEAM écrit en Gleam, qui fonctionne bien avec les processus gleam_otp.

![](https://raw.githubusercontent.com/JonasGruenwald/spectator/refs/heads/main/screenshot.png)

## Fonctionnalités

Jusqu’à présent, spectator offre les fonctionnalités suivantes :

- Afficher les processus dans un tableau triable
- Marquer des processus individuels pour une identification facile
- Afficher les détails du processus
- Afficher l’état du processus OTP
- Suspendre / reprendre les processus OTP
- Lister les tables ETS
- Voir le contenu des tables ETS
- Liste des ports actifs
- Liens cliquables entre les ressources
- Tableau de bord avec statistiques de base
- Inspecter d’autres nœuds BEAM

## Utiliser Spectator en développement

Vous pouvez installer spectator comme dépendance dans votre projet, et l’exécuter comme partie de votre application pour inspecter votre app en développement.

```sh
gleam add spectator
```
Pour plus de détails sur la façon de faire cela, consultez le [README du package](https://hexdocs.pm/spectator/)

## Utiliser Spectator en Production

Vous pouvez utiliser spectator pour inspecter le nœud BEAM exécutant votre application déployée en lançant spectator comme une application autonome, et en le connectant au nœud erlang sur lequel votre application tourne via la distribution.

L'application spectator autonome est disponible sous forme d'image docker via `ghcr.io/jonasgruenwald/spectator`, et sous forme d'escript via la [page des releases](https://github.com/JonasGruenwald/spectator/releases).

Le dépôt contient [un exemple complet de l'utilisation de spectator pour inspecter une application déployée via docker](https://github.com/JonasGruenwald/spectator/tree/main/example#readme).

Premièrement, assurez-vous que votre application a un nom Erlang et un cookie définis, par exemple en configurant la variable d'environnement `ERL_FLAGS` avant le démarrage de votre application :


```sh
ERL_FLAGS="-name myapp@host -setcookie mycookie"
```

Si votre application s'exécute dans un conteneur Docker, placez à la fois le conteneur de votre application et le conteneur exécutant spectator sur le même réseau Docker, et assurez-vous que le conteneur de votre application a son nom d'hôte défini sur une valeur que vous connaissez.

Démarrez spectator, puis cliquez sur « Change Target » dans le coin supérieur droit de l'application.

Entrez les détails du nœud que vous souhaitez inspecter, le nom doit être celui que vous avez défini via `-sname`, suivi de `@`, puis du nom d'hôte.

Enfin, cliquez sur « Connect » pour inspecter votre nœud d'application.

Notez que la cible d'inspection doit avoir le même cookie Erlang que spectator. Tout comme pour votre application, vous pouvez configurer le cookie de spectator via la variable d'environnement `ERL_FLAGS`, par exemple `ERL_FLAGS="-name spectator@127.0.0.1 -setcookie mycookie"`.

## Considérations

Veuillez prendre en compte les implications suivantes lors de l'utilisation de spectator :

- **Spectator peut ralentir votre système**  
  Tous les processus affichés sont sondés à l'intervalle configuré en utilisant la fonction Erlang `process_info/2` qui impose un verrou temporaire sur le processus interrogé. Si le processus traite beaucoup de messages, cela peut avoir des répercussions sur les performances du système.

- **Spectator créera des atomes dynamiquement**  
  Lorsque vous choisissez de vous connecter à d'autres nœuds Erlang, spectator doit convertir le nom du nœud que vous fournissez en un atome. Il est donc possible d'épuiser la mémoire de l'instance BEAM exécutant spectator via son interface utilisateur, car les atomes ne sont jamais collectés par le ramasse-miettes.

- **Spectator n'inclut pas de contrôle d'accès**  
  Spectator expose des détails sensibles sur le runtime qu'il inspecte via son interface web et ne limite actuellement pas l'accès.  
  Si vous utilisez spectator en environnement de production, vous êtes responsable de sa sécurisation – assurez-vous de ne jamais exposer spectator sur Internet public.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-26

---