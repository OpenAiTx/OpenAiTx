# Foca : Découverte de membres de cluster selon vos conditions

Foca est un composant de base pour votre découverte de cluster basée sur le gossip. C’est
une petite crate `no_std` + `alloc` qui implémente le protocole SWIM ainsi
que ses extensions utiles (`SWIM+Inf.+Susp.`).

Projet :

* Dépôt Git : https://caio.co/de/foca/
* Suivi des problèmes : https://github.com/caio/foca/issues
* CI : https://github.com/caio/foca/actions/workflows/ci.yml
* Packages : https://crates.io/crates/foca
* Documentation : https://docs.rs/foca


# Introduction

Ce qui distingue le plus Foca est le fait qu’il ne fait presque
rien. Dès la sortie de la boîte, tout ce qu’il fournit est une implémentation fiable et efficace
du [protocole SWIM][1], indépendante du transport et de
l’identité.

La connaissance du fonctionnement de SWIM est utile mais pas nécessaire pour utiliser
cette bibliothèque. La lecture de la documentation de l’enum `Message`
devrait vous donner une idée du fonctionnement du protocole, mais l’article est
une lecture très accessible.

Foca est conçu pour s’adapter à tout type de transport : si votre réseau
permet aux pairs de communiquer entre eux, vous pouvez y déployer Foca.
Non seulement les exigences générales en bande passante sont faibles, mais vous avez aussi
un contrôle total sur la manière dont les membres s’identifient mutuellement (voir
`./examples/identity_golf.rs`) et sur la façon dont les messages sont encodés.


# Utilisation

Veuillez jeter un œil à `./examples/foca_insecure_udp_agent.rs`. Il
montre à quoi pourrait ressembler un agent simple basé sur tokio et vous permet
de lancer et de voir Foca nager réellement.

~~~
$ cargo run --features std,tracing,bincode-codec --example foca_insecure_udp_agent -- --help
foca_insecure_udp_agent 

UTILISATION :
    foca_insecure_udp_agent [OPTIONS] <BIND_ADDR>

OPTIONS :
    -h, --help       Affiche les informations d'aide
    -V, --version    Affiche les informations de version

OPTIONS SUPPLÉMENTAIRES :
    -a, --announce <announce>    Adresse d'une autre instance Foca à rejoindre
    -f, --filename <filename>    Nom du fichier qui contiendra tous les membres actifs
    -i, --identity <identity>    L'adresse que les membres du cluster utiliseront pour vous contacter.
                                 Par défaut, BIND_ADDR

ARGUMENTS :
    <BIND_ADDR>    Adresse socket à laquelle se lier. Exemple : 127.0.0.1:8080
~~~

Vous pouvez donc démarrer l'agent dans un terminal avec
`./foca_insecure_udp_agent 127.0.0.1:8000` et le rejoindre avec autant d'autres
que vous voulez en utilisant une `BIND_ADDR` différente et `--announce` vers une
instance en cours d'exécution. Exemple :
`./foca_insecure_udp_agent 127.0.0.1:8001 -a 127.0.0.1:8000`.

L'agent affiche certaines informations dans la console via l'abonné de [tracing][].  
Le niveau de journalisation par défaut est `INFO` et peut être personnalisé  
via la variable d'environnement `RUST_LOG` en utilisant les directives  
EnvFilter de [tracing_subscriber][dir].


## Fonctionnalités Cargo

Chaque fonctionnalité est optionnelle. L'ensemble `default` sera toujours vide.

* `std` : Implémente `foca::Identity` pour `std::net::SocketAddr*` et
  expose `Config::new_lan` et `Config::new_wan`
* `tracing` : Instrumente Foca en utilisant la crate [tracing][]. Haut niveau
  les interactions du protocole sont émises en tant que traces `DEBUG`, plus de détails peuvent
  être exposés avec le niveau `TRACE`. Aucun autre niveau n’est émis.
* `serde` : Dérive `Serialize` et `Deserialize` pour les types publics de Foca.
* `bincode-codec` : Fournit `BincodeCodec`, un type de codec basé sur serde
  qui utilise [bincode][] en interne.
* `postcard-codec` : Fournit `PostcardCodec`, un codec basé sur serde, compatible `no_std`
  qui utilise [postcard][] en interne.
* `unstable-notifications` : Fournit de nouvelles notifications permettant
  d’inspecter les messages envoyés et reçus


# Notes

Lors de l’écriture de cette bibliothèque, l’objectif principal était d’avoir un cœur simple et petit
facile à tester, simuler et comprendre ; il s’agissait surtout
d’obtenir une meilleure compréhension du protocole après avoir lu
l’article.

S’en tenir à ces objectifs a naturellement conduit à une implémentation qui ne
dépend pas de nombreuses fonctionnalités du système d’exploitation comme une horloge matérielle, des atomiques
et des threads, donc devenir une crate `no_std` (bien qu’exigeant toujours des allocations sur le tas) était une sorte de fonctionnalité accidentelle agréable à laquelle j’ai décidé de
m’engager.


## Comparaison avec memberlist

J’ai évité de regarder [memberlist][2] jusqu’à ce que je sois satisfait de ma
propre implémentation. Depuis, je l’ai regardé rapidement sans profondeur :

* memberlist supporte des diffusions personnalisées, ce qui est une fonctionnalité très intéressante
  pour des scénarios complexes de découverte de services, donc maintenant Foca supporte
  aussi la diffusion de données utilisateur (voir la documentation de `BroadcastHandler`) :-)

* Il possède un mécanisme de synchronisation basé sur un flux (push-pull) utilisé
  pour rejoindre et fusionner périodiquement l’état entre les membres : c’est
  bien au-delà des responsabilités de Foca, mais c’est une idée très intéressante,
  donc j’ai exposé la méthode `Foca::apply_many` qui permet au code



  utiliser Foca pour faire quelque chose de similaire si désiré.

* Ses paramètres de configuration changent en fonction de la taille
  (actuelle) du cluster. Les utilisateurs peuvent utiliser `Config::new_{lan,wan}`
  avec `Foca::set_config` pour obtenir le même résultat

# Références

* L'article [SWIM : Protocole d'adhésion au groupe de processus de type infection faiblement cohérent et évolutif][1]
* [memberlist] de HashiCorp [2]

[1]: https://www.cs.cornell.edu/projects/Quicksilver/public_pdfs/SWIM.pdf
[2]: https://github.com/hashicorp/memberlist
[bincode]: https://github.com/bincode-org/bincode
[postcard]: https://github.com/jamesmunns/postcard
[tracing]: https://docs.rs/tracing/latest/tracing/
[dir]: https://docs.rs/tracing-subscriber/0.3.17/tracing_subscriber/filter/struct.EnvFilter.html#directives

# Licence

Sauf indication contraire explicite, tout le travail est soumis aux termes
de la Mozilla Public License, version 2.0.

Les fichiers dans le répertoire `examples/` sont dédiés au domaine
public.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-07

---