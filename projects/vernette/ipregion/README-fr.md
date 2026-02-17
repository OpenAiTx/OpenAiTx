# ipregion

![image](https://i.imgur.com/CRxBuVR.gif)

## Utilisation

### Télécharger et exécuter localement

```bash
wget -O ipregion.sh https://ipregion.vrnt.xyz
chmod +x ipregion.sh
```

### Exécuter directement depuis GitHub

```bash
bash <(wget -qO- https://ipregion.vrnt.xyz)
```

### Docker

#### Exécuter le conteneur pour IPv4 (réseau pont Docker par défaut)

Cela exécute votre vérification de géolocalisation IP en utilisant uniquement IPv4, sans nécessiter le mode réseau hôte :

```bash
docker run --rm vernette/ipregion:latest
```

Vous pouvez ajouter des options de script supplémentaires selon les besoins, par exemple :

```
docker run --rm vernette/ipregion:latest --group geoip
```

#### Exécuter le conteneur avec le réseau hôte (pour IPv4 & IPv6 ou interface personnalisée)

Pour accéder à la fois à IPv4 et IPv6 sur les interfaces réseau réelles de l'hôte, ou pour spécifier une interface réseau personnalisée (par exemple, eth1), utilisez le mode réseau hôte de Docker :

```bash
docker run --rm --network=host vernette/ipregion:latest
```

```bash
docker run --rm --network=host vernette/ipregion:latest --interface eth1
```

> [!NOTE]
> Lors de l'utilisation de `--network=host`, le conteneur partage la pile réseau de l'hôte, ce qui réduit l'isolation réseau mais permet un accès complet aux interfaces. Sans `--network=host`, le conteneur utilise le réseau pont Docker, ce qui peut ne pas exposer IPv6 ou permettre la sélection d'interface.

## Fonctionnalités

- Plusieurs API GeoIP et services web (YouTube, Netflix, ChatGPT, Spotify, etc.)
- Support IPv4/IPv6 avec proxy SOCKS5 et interface réseau personnalisée
- Sortie JSON et tableaux en couleur

## Dépendances

- bash
- curl
- jq
- util-linux/bsdmainutils

## Options clés

```bash
./ipregion.sh --help # Show all options
./ipregion.sh --group primary # GeoIP services only
./ipregion.sh --group custom # Popular websites only
./ipregion.sh --ipv4 # IPv4 only
./ipregion.sh --ipv6 # IPv6 only
./ipregion.sh --proxy 127.0.0.1:1080 # Use SOCKS5 proxy
./ipregion.sh --json # JSON output
./ipregion.sh --debug # Debug mode
```

Toutes les options peuvent être combinées.

## Codes pays

Le script affiche les codes pays au format ISO 3166-1 alpha-2 (par exemple, RU, US, DE).

Vous pouvez consulter la signification de n'importe quel code pays sur le site officiel de l'ISO : [https://www.iso.org/obp/ui/#search/code/](https://www.iso.org/obp/ui/#search/code/)

Il suffit de saisir le code dans la barre de recherche pour obtenir le nom complet du pays.

## Contribution

Les contributions sont les bienvenues ! N'hésitez pas à soumettre des pull requests pour ajouter de nouveaux services ou améliorer les fonctionnalités du script.

![Graphique de l'historique des étoiles](https://api.star-history.com/svg?repos=vernette/ipregion&type=Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-17

---