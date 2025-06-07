![Image de bannière](https://user-images.githubusercontent.com/10284570/173569848-c624317f-42b1-45a6-ab09-f0ea3c247648.png)

# n8n - Automatisation de workflows sécurisée pour les équipes techniques

n8n est une plateforme d’automatisation de workflows qui offre aux équipes techniques la flexibilité du code avec la rapidité du no-code. Avec plus de 400 intégrations, des capacités d’IA natives et une licence fair-code, n8n vous permet de créer des automatisations puissantes tout en gardant un contrôle total sur vos données et déploiements.

![n8n.io - Capture d’écran](https://raw.githubusercontent.com/n8n-io/n8n/master/assets/n8n-screenshot-readme.png)

## Fonctionnalités clés

- **Codez quand vous en avez besoin** : Écrivez en JavaScript/Python, ajoutez des packages npm ou utilisez l’interface visuelle
- **Plateforme native IA** : Créez des workflows d’agents IA basés sur LangChain avec vos propres données et modèles
- **Contrôle total** : Hébergez vous-même grâce à notre licence fair-code ou utilisez notre [offre cloud](https://app.n8n.cloud/login)
- **Prêt pour l’entreprise** : Permissions avancées, SSO et déploiements isolés (air-gapped)
- **Communauté active** : Plus de 400 intégrations et plus de 900 [modèles](https://n8n.io/workflows) prêts à l’emploi

## Démarrage rapide

Essayez n8n instantanément avec [npx](https://docs.n8n.io/hosting/installation/npm/) (nécessite [Node.js](https://nodejs.org/en/)) :

```
npx n8n
```

Ou déployez avec [Docker](https://docs.n8n.io/hosting/installation/docker/) :

```
docker volume create n8n_data
docker run -it --rm --name n8n -p 5678:5678 -v n8n_data:/home/node/.n8n docker.n8n.io/n8nio/n8n
```

Accédez à l’éditeur sur http://localhost:5678

## Ressources

- 📚 [Documentation](https://docs.n8n.io)
- 🔧 [400+ Intégrations](https://n8n.io/integrations)
- 💡 [Exemples de workflows](https://n8n.io/workflows)
- 🤖 [Guide IA & LangChain](https://docs.n8n.io/langchain/)
- 👥 [Forum Communautaire](https://community.n8n.io)
- 📖 [Tutoriels communautaires](https://community.n8n.io/c/tutorials/28)

## Support

Besoin d’aide ? Notre forum communautaire est l’endroit idéal pour obtenir de l’aide et échanger avec d’autres utilisateurs :
[community.n8n.io](https://community.n8n.io)

## Licence

n8n est en [fair-code](https://faircode.io) distribué sous la [Licence Sustainable Use](https://github.com/n8n-io/n8n/blob/master/LICENSE.md) et la [Licence Entreprise n8n](https://github.com/n8n-io/n8n/blob/master/LICENSE_EE.md).

- **Code source disponible** : Code source toujours visible
- **Auto-hébergé** : Déployez où vous le souhaitez
- **Extensible** : Ajoutez vos propres nœuds et fonctionnalités

[Licences entreprises](mailto:license@n8n.io) disponibles pour des fonctionnalités et du support additionnels.

Des informations complémentaires sur le modèle de licence sont disponibles dans la [documentation](https://docs.n8n.io/reference/license/).

## Contribution

Vous avez trouvé un bug 🐛 ou une idée de fonctionnalité ✨ ? Consultez notre [Guide de contribution](https://github.com/n8n-io/n8n/blob/master/CONTRIBUTING.md) pour commencer.

## Rejoignez l’équipe

Vous souhaitez façonner le futur de l’automatisation ? Découvrez nos [offres d’emploi](https://n8n.io/careers) et rejoignez notre équipe !

## Que signifie n8n ?

**Réponse courte :** Cela signifie "nodemation" et se prononce n-eight-n.

**Réponse longue :** "On me pose souvent la question (plus souvent que je ne l’aurais cru) donc j’ai décidé qu’il valait mieux y répondre ici. En cherchant un bon nom pour le projet avec un domaine libre, je me suis rapidement rendu compte que tous ceux auxquels je pensais étaient déjà pris. J’ai donc finalement choisi nodemation. 'node-' dans le sens où il utilise une vue nodale (Node-View) et Node.js, et '-mation' pour 'automation' (automatisation), qui est la finalité du projet. Cependant, je n’aimais pas la longueur du nom et je n’imaginais pas écrire un nom aussi long à chaque fois dans le CLI. C’est ainsi que je suis arrivé à 'n8n'." - **Jan Oberhauser, Fondateur et CEO, n8n.io**

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---