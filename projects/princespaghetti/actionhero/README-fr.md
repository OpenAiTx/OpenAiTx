# Action Hero

## Qu'est-ce qu'Action Hero ?

Action Hero est un utilitaire de type sidecar pour aider à créer des politiques IAM à moindre privilège pour AWS.

## Pourquoi est-il nécessaire ?

Les développeurs commencent souvent à créer l'infrastructure en tant que code avec des rôles plus permissifs disposant d'un accès administrateur pour itérer rapidement. Cependant, essayer de créer un ensemble de permissions plus finement ciblé peut être fastidieux et prendre du temps.

Action Hero fournit un moyen de capturer toutes les permissions requises pendant les itérations plus permissives afin de faciliter la création d'un rôle IAM avec uniquement les permissions nécessaires.

## Comment cela fonctionne-t-il ?

Action Hero utilise une fonctionnalité du SDK AWS connue sous le nom de Client Side Monitoring. Cette fonctionnalité envoie les appels API AWS à un port UDP local (31000 par défaut)

Summit Route discute de cette fonctionnalité dans ce [post](https://summitroute.com/blog/2020/05/25/client_side_monitoring/) (qui a été l'inspiration pour cet outil)

## Prérequis

Comme indiqué dans le post ci-dessus, ``export AWS_CSM_ENABLED=true`` doit être exécuté dans le shell ou défini dans un profil où l'outil utilisant le SDK sera lancé. Par exemple, si vous utilisez terraform, cela devra être exporté dans le shell d'où le plan/apply sera exécuté.

La variable d'environnement ``AWS_CSM_PORT`` peut également être utilisée pour remplacer le port vers lequel les actions CSM sont envoyées, et sur lequel Action Hero écoute. Cela devra être exporté dans les deux shells si utilisé.

## Installation

Les binaires sont disponibles sur la page des [releases](https://github.com/princespaghetti/actionhero/releases)

Une image docker est également disponible sur [docker hub](https://hub.docker.com/r/princespaghetti/actionhero)

## Exécution d'Action Hero

Dans un terminal séparé de celui où vous utilisez le SDK, lancez le binaire

``./actionhero``

Alternativement, vous pouvez utiliser une commande docker run

``docker run -e "IN_DOCKER=True" -p 127.0.0.1:31000:31000/udp --rm princespaghetti/actionhero:latest``

Ctrl+C peut être utilisé pour terminer le processus en toute sécurité

## Guide pas à pas

Veuillez consulter ce [article de blog](https://dev.to/prince_of_pasta/action-hero-to-the-rescue-creating-least-privilege-aws-iam-policies-53o2) pour un exemple d'utilisation de l'outil.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-08

---