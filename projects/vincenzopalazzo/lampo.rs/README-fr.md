<div align="center">
  <h1>Lampo</h1>

  <img src="https://github.com/saradurante/lampo.docs/blob/dc0dce971c3052f0e9dd668fdf0c7376b12fee7b/imgs/web/icon-512.png?raw=true"  width="150" height="150" />

  <p>
    <strong>Implémentation rapide et modulaire du réseau Lightning pour tous les usages, écrite en Rust.</strong>
  </p>

  <h4>
    <a href="https://lampo.devcrew.cc">Page d’accueil du projet</a>
  </h4>
</div>

## Crates

Voici la liste complète des crates actuellement prises en charge :

| Crate       | Description                                   | Version     |
|:------------|:---------------------------------------------:|------------:|
| lampod-cli  | Interface en ligne de commande Lampo Daemon pour exécuter le daemon | _unrelated_ |
| lampo-cli   | Interface en ligne de commande simple Lampo pour interagir avec le daemon | _unrelated_ |

## Comment installer

Pour installer toutes les dépendances et le binaire Lampo, vous devez
avoir Rust installé, puis exécuter la commande suivante :

```
make install
```

Une fois que vous disposez de `lampod-cli` et `lampo-cli`, vous pouvez
exécuter la commande suivante pour lancer Lampo en mode signet :

```
➜  ~ lampod-cli --network signet
✓ Portefeuille généré, veuillez conserver ces mots en lieu sûr
 wallet-keys  maple have fitness decide food joy flame coast stereo front grab stumble
```

>[!NOTE]
Conservez les mots de votre portefeuille, puis réutilisez-les pour restaurer le portefeuille avec `--restore-wallet`.
Si vous ne conservez pas vos mots, vos fonds seront perdus lors du prochain démarrage de Lampo !

Veuillez noter que vous devez avoir un fichier `lampo.conf` dans le chemin `~/.lampo/signet`. Exécutez la
commande suivante pour utiliser le fichier de configuration d’exemple :

```
cp lampo.example.conf ~/.lampo/signet/lampo.conf
```

Vous pouvez ensuite interroger le nœud avec la commande suivante :

``` 
➜  ~ lampo-cli --network signet getinfo
{
  "node_id": "035b889551a44e502cd0cd6657acf067336034986cd6639b222cd4be563a7fc205",
  "peers": 0,
  "channels": 0
}
```

### Pour exécuter les tests d’intégration avec core lightning :

Assurez-vous d’avoir compilé core-lightning en mode développeur. Le guide d’installation est disponible [ici](https://docs.corelightning.org/docs/installation).

Les tests d’intégration peuvent être lancés avec la commande suivante :

```
make integration
```

## Guide de contribution

Veuillez lire notre [Guide de contribution](https://raw.githubusercontent.com/vincenzopalazzo/lampo.rs/main/CONTRIBUTING.md).

## Communauté

Dans un souci de clarté, nous avons choisi des canaux spécifiques pour la communication :
- Développeurs, rejoignez-nous sur [Zulip](https://lampo-dev.zulipchat.com/).
- Membres de la communauté, notre [communauté Twitter](https://twitter.com/i/communities/1736414802849706087) attend vos contributions.
- Pour les questions techniques et les demandes de fonctionnalités, rendez-vous sur nos discussions GitHub.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---