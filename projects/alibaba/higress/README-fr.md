<a name="readme-top"></a>
<h1 align="center">
    <img src="https://img.alicdn.com/imgextra/i2/O1CN01NwxLDd20nxfGBjxmZ_!!6000000006895-2-tps-960-290.png" alt="Higress" width="240" height="72.5">
  <br>
  Passerelle IA
</h1>
<h4 align="center"> Passerelle API Native IA </h4>

<div align="center">
    
[![Build Status](https://github.com/alibaba/higress/actions/workflows/build-and-test.yaml/badge.svg?branch=main)](https://github.com/alibaba/higress/actions)
[![license](https://img.shields.io/github/license/alibaba/higress.svg)](https://www.apache.org/licenses/LICENSE-2.0.html)
[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=flat-square)](https://discord.gg/tSbww9VDaM)

<a href="https://trendshift.io/repositories/10918" target="_blank"><img src="https://trendshift.io/api/badge/repositories/10918" alt="alibaba%2Fhigress | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a> <a href="https://www.producthunt.com/posts/higress?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-higress" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=951287&theme=light&t=1745492822283" alt="Higress - Global&#0032;APIs&#0032;as&#0032;MCP&#0032;powered&#0032;by&#0032;AI&#0032;Gateway | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

</div>

[**Site officiel**](https://higress.ai/en/) &nbsp; |
&nbsp; [**Démarrage rapide serveur MCP**](https://higress.cn/en/ai/mcp-quick-start/) &nbsp; |
&nbsp; [**Hub de plugins Wasm**](https://higress.cn/en/plugin/) &nbsp; |

<p>
   English | <a href="README_ZH.md">中文<a/> | <a href="README_JP.md">日本語<a/>
</p>

## Qu'est-ce que Higress ?

Higress est une passerelle API cloud-native basée sur Istio et Envoy, extensible via des plugins Wasm écrits en Go/Rust/JS. Elle propose des dizaines de plugins généralistes prêts à l'emploi et une console clé en main (essayez la [démo ici](http://demo.higress.io/)).

### Cas d'usage principaux

Les capacités de passerelle IA de Higress prennent en charge tous les [fournisseurs de modèles majeurs](https://raw.githubusercontent.com/alibaba/higress/main/plugins/wasm-go/extensions/ai-proxy/provider) nationaux et internationaux. Elle permet également l’hébergement de serveurs MCP (Model Context Protocol) via son mécanisme de plugins, afin que les agents IA puissent facilement invoquer divers outils et services. Avec l’outil [openapi-to-mcp](https://github.com/higress-group/openapi-to-mcpserver), vous pouvez rapidement convertir des spécifications OpenAPI en serveurs MCP distants. Higress offre une gestion unifiée des API LLM et MCP.

**🌟 Essayez dès maintenant sur [https://mcp.higress.ai/](https://mcp.higress.ai/)** pour découvrir les serveurs MCP distants hébergés par Higress :

![Plateforme Serveur MCP Higress](https://img.alicdn.com/imgextra/i2/O1CN01nmVa0a1aChgpyyWOX_!!6000000003294-0-tps-3430-1742.jpg)

### Adoption en entreprise

Higress est né chez Alibaba pour résoudre les problèmes de rechargement de Tengine affectant les services à connexions longues et l’insuffisance de la répartition de charge pour gRPC/Dubbo. Au sein d’Alibaba Cloud, les capacités de passerelle IA de Higress soutiennent des applications IA clés telles que le studio de modèles Tongyi Bailian, la plateforme de machine learning PAI et d’autres services critiques. Alibaba Cloud a construit son produit passerelle API cloud-native sur Higress, offrant une garantie de haute disponibilité à 99,99 % pour de nombreux clients d’entreprise.

## Sommaire

- [**Démarrage rapide**](#quick-start)    
- [**Démo des fonctionnalités**](#feature-showcase)
- [**Cas d'usage**](#use-cases)
- [**Avantages clés**](#core-advantages)
- [**Communauté**](#community)

## Démarrage rapide

Higress peut être démarré simplement avec Docker, ce qui est pratique pour les développeurs individuels souhaitant apprendre ou créer des sites simples en local :

```bash
# Créer un répertoire de travail
mkdir higress; cd higress
# Lancer higress, les fichiers de configuration seront écrits dans le répertoire de travail
docker run -d --rm --name higress-ai -v ${PWD}:/data \
        -p 8001:8001 -p 8080:8080 -p 8443:8443  \
        higress-registry.cn-hangzhou.cr.aliyuncs.com/higress/all-in-one:latest
```

Description des ports :

- Port 8001 : accès à la console UI Higress
- Port 8080 : entrée du protocole HTTP de la passerelle
- Port 8443 : entrée du protocole HTTPS de la passerelle

> Toutes les images Docker Higress utilisent le référentiel d’images propre à Higress et ne sont pas affectées par les limites de taux de Docker Hub.
> De plus, la soumission et la mise à jour des images sont protégées par un mécanisme de scan de sécurité (alimenté par Alibaba Cloud ACR), ce qui les rend très sûres pour une utilisation en production.
>
> Si vous rencontrez un délai d’attente lors du téléchargement depuis `higress-registry.cn-hangzhou.cr.aliyuncs.com`, vous pouvez essayer de le remplacer par la source miroir suivante :
>
> **Asie du Sud-Est** : `higress-registry.ap-southeast-7.cr.aliyuncs.com`

Pour d’autres méthodes d’installation comme le déploiement Helm sous K8s, veuillez consulter la [documentation de démarrage rapide officielle](https://higress.io/en-us/docs/user/quickstart).

## Cas d'usage

- **Hébergement de serveurs MCP** :

  Higress héberge des serveurs MCP via son mécanisme de plugins, permettant aux agents IA d’invoquer facilement divers outils et services. Avec l’outil [openapi-to-mcp](https://github.com/higress-group/openapi-to-mcpserver), vous pouvez rapidement convertir des spécifications OpenAPI en serveurs MCP distants.

  ![Hébergement MCP](https://img.alicdn.com/imgextra/i1/O1CN01wv8H4g1mS4MUzC1QC_!!6000000004952-2-tps-1764-597.png)

  Principaux avantages de l’hébergement MCP avec Higress :
  - Mécanismes unifiés d’authentification et d’autorisation
  - Limitation de débit fine pour éviter les abus
  - Journaux d’audit complets pour tous les appels d’outils
  - Observabilité riche pour la surveillance des performances
  - Déploiement simplifié via le mécanisme de plugins de Higress
  - Mises à jour dynamiques sans interruption ni perte de connexion

     [En savoir plus...](https://higress.cn/en/ai/mcp-quick-start/?spm=36971b57.7beea2de.0.0.d85f20a94jsWGm)

- **Passerelle IA** :

  Higress connecte tous les fournisseurs de modèles LLM via un protocole unifié, avec observabilité IA, répartition de charge multi-modèles, limitation de débit par jetons et capacités de mise en cache :

  ![](https://img.alicdn.com/imgextra/i2/O1CN01izmBNX1jbHT7lP3Yr_!!6000000004566-0-tps-1920-1080.jpg)

- **Contrôleur ingress Kubernetes** :

  Higress peut fonctionner comme un contrôleur ingress riche en fonctionnalités, compatible avec de nombreuses annotations du contrôleur ingress nginx de K8s.
  
  La [Gateway API](https://gateway-api.sigs.k8s.io/) sera bientôt prise en charge et permettra une migration en douceur d’Ingress API vers Gateway API.
  
- **Passerelle de microservices** :

  Higress peut servir de passerelle de microservices, découvrant les microservices à partir de divers registres tels que Nacos, ZooKeeper, Consul, Eureka, etc.
  
  Il s’intègre profondément avec [Dubbo](https://github.com/apache/dubbo), [Nacos](https://github.com/alibaba/nacos), [Sentinel](https://github.com/alibaba/Sentinel) et d’autres technologies de microservices.
  
- **Passerelle de sécurité** :

  Higress peut servir de passerelle de sécurité, prenant en charge WAF et diverses stratégies d’authentification telles que key-auth, hmac-auth, jwt-auth, basic-auth, oidc, etc.


## Avantages clés

- **Niveau production**

  Issu d’un produit interne Alibaba avec plus de 2 ans de validation en production, supportant des scénarios à grande échelle avec des centaines de milliers de requêtes par seconde.

  Élimine totalement les à-coups de trafic causés par le rechargement Nginx, les changements de configuration prennent effet en millisecondes et sont transparents pour le métier. Particulièrement adapté aux scénarios à connexions longues comme les services IA.

- **Traitement en streaming**

  Prise en charge complète du traitement en streaming des corps de requêtes/réponses, les plugins Wasm peuvent facilement personnaliser la gestion de protocoles streaming comme SSE (Server-Sent Events).

  Dans les scénarios à haut débit comme l’IA, cela réduit considérablement la consommation mémoire.
    
- **Facile à étendre**
  
  Bibliothèque officielle de plugins riche couvrant IA, gestion du trafic, sécurité et autres fonctions courantes, répondant à plus de 90 % des besoins métier.

  Axé sur l’extension par plugins Wasm, garantissant la sécurité mémoire via l’isolation sandbox, prenant en charge plusieurs langages, permettant la montée de version indépendante des plugins et des mises à jour à chaud sans perte de trafic.

- **Sécurisé et simple d’utilisation**
  
  Basé sur les standards Ingress API et Gateway API, fournit une console UI prête à l’emploi, plugin de protection WAF, plugin de protection IP/Cookie CC immédiatement utilisables.

  Prend en charge la connexion à Let’s Encrypt pour l’émission et le renouvellement automatiques de certificats gratuits, peut être déployé hors K8s, démarré en une commande Docker, pratique pour les développeurs individuels.

## Communauté

Rejoignez notre communauté Discord ! C’est là que vous pouvez échanger avec les développeurs et autres utilisateurs passionnés de Higress.

[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=for-the-badge)](https://discord.gg/tSbww9VDaM)


### Remerciements

Higress ne serait pas possible sans le travail open source précieux des projets de la communauté. Nous adressons un remerciement tout particulier à Envoy et Istio.

### Dépôts associés

- Console Higress : https://github.com/higress-group/higress-console
- Higress Standalone : https://github.com/higress-group/higress-standalone

### Contributeurs

<a href="https://github.com/alibaba/higress/graphs/contributors">
  <img alt="contributors" src="https://contrib.rocks/image?repo=alibaba/higress"/>
</a>

### Historique des étoiles

[![Star History Chart](https://api.star-history.com/svg?repos=alibaba/higress&type=Date)](https://star-history.com/#alibaba/higress&Date)

<p align="right" style="font-size: 14px; color: #555; margin-top: 20px;">
    <a href="#readme-top" style="text-decoration: none; color: #007bff; font-weight: bold;">
        ↑ Retour en haut ↑
    </a>
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---