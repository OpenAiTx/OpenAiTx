# ECS-IAUS-sytstem  
Système d'Utilité à Axe Infini pour Unity  
Le système d’utilité fonctionne en identifiant les options disponibles pour l’IA et en sélectionnant la meilleure option en attribuant un score à chaque option en fonction des circonstances. Cette méthode s’est avérée remarquablement efficace pour plusieurs raisons.  

Simple à Concevoir - L’IA utilitaire peut souvent être conçue en langage naturel, ce qui facilite la communication entre le programmeur IA et les concepteurs de jeu. Il n’est pas nécessaire de parler de concepts obscurs tels que conditions, états, séquences et décorateurs. Vous pouvez plutôt expliquer le comportement IA prévu avec des termes tels que « Si l’IA est sous le feu, prioriser la recherche de couverture ». Notez comment des termes flous - tels que « prioriser » - peuvent être utilisés, ce qui est naturel dans la conversation humaine.  

Facilement Extensible - Les règles - souvent appelées scoreurs - peuvent facilement être ajoutées par-dessus l’IA existante. Contrairement aux machines à états finis par exemple, il n’y a pas de relations importantes à casser. Les scoreurs sont simplement ajoutés par-dessus les scoreurs existants, ce qui facilite l’extension des fonctionnalités et la fidélité de l’IA.  

Meilleure Qualité - La simplicité de conception et la facilité avec laquelle l’IA peut être étendue réduisent considérablement les bugs et améliorent de manière spectaculaire la productivité. Cela laisse plus de place pour développer une IA plus complexe et mieux conçue dans le budget et le délai impartis, ce qui améliore globalement la qualité de l’IA.  

Ceci est ma tentative de création du Système d’Utilité à Axe Infini de Dave Mark dans Unity3d en utilisant DOTS.  

Qu’est-ce qu’un Système d’Utilité à Axe Infini ?  

En résumé, c’est un système qui retourne une Action à réaliser ayant la valeur la plus élevée. C’est essentiellement une liste d’Actions et chaque Action possède une liste « d’Axes ». Dave Mark en a parlé lors d’une conférence GDC il y a quelques années, c’est là que j’en ai entendu parler. Je crois qu’il a aussi mentionné un jeu de chat et pointeur laser dans la même conférence, qui fut l’idée initiale de Lol Cats I Can Has Lazer, même si notre jeu a suivi sa propre direction de conception.  

Voici un lien vers les conférences :  

http://intrinsicalgorithm.com/IAonAI/2013/02/both-my-gdc-lectures-on-utility-theory-free-on-gdc-vault/  

https://www.gdcvault.com/play/1018040/Architecture-Tricks-Managing-Behaviors-in commence à 33 minutes  

Ce dépôt est principalement destiné à apprendre et documenter mon parcours avec DOTS et Utility AI. Si vous cherchez un asset utilisable immédiatement dans son état actuel, consultez le lien ci-dessous.  
https://gitlab.com/lclemens/lightweightdotsutilityai  

Mis à jour pour supporter Unity 6 Beta  
Ajout de la planification GOAP pour les états


Copyright 2019 - 2024 Dreamers Inc Studios Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions: The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software. THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-17

---