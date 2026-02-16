# Exécutez Ollama, Stable Diffusion et la Reconnaissance Automatique de la Parole avec votre GPU Intel Arc

[[Blog](https://blog.eleiton.dev/posts/llm-and-genai-in-docker/)]

Déployez facilement une solution basée sur Docker qui utilise [Open WebUI](https://github.com/open-webui/open-webui) comme interface utilisateur conviviale  
IA et [Ollama](https://github.com/ollama/ollama) pour l’intégration des grands modèles de langage (LLM).

De plus, vous pouvez exécuter des conteneurs Docker [ComfyUI](https://github.com/comfyanonymous/ComfyUI) ou [SD.Next](https://github.com/vladmandic/sdnext)  
pour simplifier les capacités de Stable Diffusion.

Vous pouvez également exécuter un conteneur Docker optionnel avec [OpenAI Whisper](https://github.com/openai/whisper) pour effectuer des tâches de Reconnaissance Automatique de la Parole (ASR).

Tous ces conteneurs ont été optimisés pour les GPU Intel Arc Series sous Linux en utilisant [Intel® Extension for PyTorch](https://github.com/intel/intel-extension-for-pytorch).

![screenshot](https://raw.githubusercontent.com/eleiton/ollama-intel-arc/main/resources/open-webui.png)

## Services
1. Ollama  
   * Exécute llama.cpp et Ollama avec IPEX-LLM sur votre ordinateur Linux avec GPU Intel Arc.  
   * Construit selon les directives de [Intel](https://github.com/intel/ipex-llm/blob/main/docs/mddocs/DockerGuides/README.md).  
   * Utilise l’image docker officielle [Intel ipex-llm](https://hub.docker.com/r/intelanalytics/ipex-llm-inference-cpp-xpu) comme conteneur de base.  
   * Utilise les dernières versions des paquets requis, privilégiant les fonctionnalités de pointe plutôt que la stabilité.  
   * Expose le port `11434` pour connecter d’autres outils à votre service Ollama.

2. Open WebUI  
   * Utilise la distribution officielle d’Open WebUI.  
   * `WEBUI_AUTH` est désactivé pour une utilisation sans authentification.  
   * Les drapeaux `ENABLE_OPENAI_API` et `ENABLE_OLLAMA_API` sont respectivement désactivés et activés, permettant les interactions uniquement via Ollama.  
   * `ENABLE_IMAGE_GENERATION` est activé, vous permettant de générer des images depuis l’interface.  
   * `IMAGE_GENERATION_ENGINE` est réglé sur automatic1111 (SD.Next est compatible).

3. ComfyUI  
   * L’interface graphique la plus puissante et modulaire pour les modèles de diffusion, API et backend avec interface graphique par nœuds.  
   * Utilise comme conteneur de base l’[Intel® Extension for PyTorch](https://pytorch-extension.intel.com/installation?platform=gpu) officiel.

4. SD.Next  
   * Solution tout-en-un pour l’image générative IA basée sur Automatic1111.  
   * Utilise comme conteneur de base l’[Intel® Extension for PyTorch](https://pytorch-extension.intel.com/installation?platform=gpu) officiel.  
   * Utilise une version personnalisée du [docker file](https://github.com/vladmandic/sdnext/blob/dev/configs/Dockerfile.ipex) de SD.Next, le rendant compatible avec l’image Intel Extension for Pytorch.

5. OpenAI Whisper
   * Reconnaissance vocale robuste via une supervision faible à grande échelle
   * Utilise comme conteneur de base l'[extension officielle Intel® pour PyTorch](https://pytorch-extension.intel.com/installation?platform=gpu)

## Configuration
Exécutez les commandes suivantes pour démarrer votre instance Ollama avec Open WebUI
```bash
$ git clone https://github.com/eleiton/ollama-intel-arc.git
$ cd ollama-intel-arc
$ podman compose up
```

De plus, si vous souhaitez exécuter un ou plusieurs des outils de génération d'images, lancez ces commandes dans un terminal différent :

Pour ComfyUI
```bash
$ podman compose -f docker-compose.comfyui.yml up
```
Pour SD.Next

```bash
$ podman compose -f docker-compose.sdnext.yml up
```

Si vous souhaitez utiliser Whisper pour la reconnaissance automatique de la parole, exécutez cette commande dans un autre terminal :
```bash
$ podman compose -f docker-compose.whisper.yml up
```

## Valider
Exécutez la commande suivante pour vérifier que votre instance Ollama est opérationnelle
```bash
$ curl http://localhost:11434/
Ollama is running
```
Lors de l'utilisation de Open WebUI, vous devriez voir cette sortie partielle dans votre console, indiquant que votre GPU arc a été détecté
```bash
[ollama-intel-arc] | Found 1 SYCL devices:
[ollama-intel-arc] | |  |                   |                                       |       |Max    |        |Max  |Global |                     |
[ollama-intel-arc] | |  |                   |                                       |       |compute|Max work|sub  |mem    |                     |
[ollama-intel-arc] | |ID|        Device Type|                                   Name|Version|units  |group   |group|size   |       Driver version|
[ollama-intel-arc] | |--|-------------------|---------------------------------------|-------|-------|--------|-----|-------|---------------------|
[ollama-intel-arc] | | 0| [level_zero:gpu:0]|                     Intel Arc Graphics|  12.71|    128|    1024|   32| 62400M|         1.6.32224+14|
```

## Utilisation de la génération d'images
* Ouvrez votre navigateur web à l'adresse http://localhost:7860 pour accéder à la page web SD.Next.
* Pour cette démonstration, nous utiliserons le modèle [DreamShaper](https://civitai.com/models/4384/dreamshaper).
* Suivez ces étapes :
* Téléchargez le modèle `dreamshaper_8` en cliquant sur son image (1).
* Attendez qu'il soit téléchargé (~2Go) puis sélectionnez-le dans le menu déroulant (2).
* (Optionnel) Si vous souhaitez rester dans l'interface SD.Next, n'hésitez pas à explorer (3).
![screenshot](https://raw.githubusercontent.com/eleiton/ollama-intel-arc/main/resources/sd.next.png)
* Pour plus d'informations sur l'utilisation de SD.Next, consultez la [documentation officielle](https://vladmandic.github.io/sdnext-docs/).
* Ouvrez votre navigateur web à l'adresse http://localhost:4040 pour accéder à la page web Open WebUI.
* Rendez-vous sur la page des [paramètres](http://localhost:4040/admin/settings) administrateur.
* Allez dans la section Image (1)
* Assurez-vous que tous les paramètres sont corrects, et validez-les en appuyant sur le bouton de rafraîchissement (2)
* (Optionnel) Enregistrez les modifications si vous en avez fait. (3)
![screenshot](https://raw.githubusercontent.com/eleiton/ollama-intel-arc/main/resources/open-webui-settings.png)
* Pour plus d'informations sur l'utilisation d'Open WebUI, consultez la [documentation officielle](https://docs.openwebui.com/)
* Voilà, retournez à la page principale d'Open WebUI et commencez à discuter. Assurez-vous de sélectionner le bouton `Image` pour indiquer que vous souhaitez générer des images.
![screenshot](https://raw.githubusercontent.com/eleiton/ollama-intel-arc/main/resources/open-webui-chat.png)

## Utilisation de la reconnaissance automatique de la parole
* Voici un exemple de commande pour transcrire des fichiers audio :
```bash
  podman exec -it  whisper-ipex whisper https://www.lightbulblanguages.co.uk/resources/ge-audio/hobbies-ge.mp3 --device xpu --model small --language German --task transcribe
```
* Réponse :
```bash
  [00:00.000 --> 00:08.000]  Ich habe viele Hobbys. In meiner Freizeit mache ich sehr gerne Sport, wie zum Beispiel Wasserball oder Radfahren.
  [00:08.000 --> 00:13.000]  Außerdem lese ich gerne und lerne auch gerne Fremdsprachen.
  [00:13.000 --> 00:19.000]  Ich gehe gerne ins Kino, höre gerne Musik und treffe mich mit meinen Freunden.
  [00:19.000 --> 00:22.000]  Früher habe ich auch viel Basketball gespielt.
  [00:22.000 --> 00:26.000]  Im Frühling und im Sommer werde ich viele Radtouren machen.
  [00:26.000 --> 00:29.000]  Außerdem werde ich viel schwimmen gehen.
  [00:29.000 --> 00:33.000]  Am liebsten würde ich das natürlich im Meer machen.
```
* Ceci est un exemple de commande pour traduire des fichiers audio :
```bash
  podman exec -it  whisper-ipex whisper https://www.lightbulblanguages.co.uk/resources/ge-audio/hobbies-ge.mp3 --device xpu --model small --language German --task translate
```
* Réponse :
```bash
  [00:00.000 --> 00:02.000]  I have a lot of hobbies.
  [00:02.000 --> 00:05.000]  In my free time I like to do sports,
  [00:05.000 --> 00:08.000]  such as water ball or cycling.
  [00:08.000 --> 00:10.000]  Besides, I like to read
  [00:10.000 --> 00:13.000]  and also like to learn foreign languages.
  [00:13.000 --> 00:15.000]  I like to go to the cinema,
  [00:15.000 --> 00:16.000]  like to listen to music
  [00:16.000 --> 00:19.000]  and meet my friends.
  [00:19.000 --> 00:22.000]  I used to play a lot of basketball.
  [00:22.000 --> 00:26.000]  In spring and summer I will do a lot of cycling tours.
  [00:26.000 --> 00:29.000]  Besides, I will go swimming a lot.
  [00:29.000 --> 00:33.000]  Of course, I would prefer to do this in the sea.
```
* Pour utiliser vos propres fichiers audio au lieu des fichiers web, placez-les dans le dossier `~/whisper-files` et accédez-y ainsi :
```bash
  podman exec -it  whisper-ipex whisper YOUR_FILE_NAME.mp3 --device xpu --model small --task translate
```

## Mise à jour des conteneurs
S'il y a de nouvelles mises à jour dans l'image Docker [ipex-llm-inference-cpp-xpu](https://hub.docker.com/r/intelanalytics/ipex-llm-inference-cpp-xpu) ou dans l'image Docker Open WebUI, vous souhaiterez peut-être mettre à jour vos conteneurs pour rester à jour.

Avant toute mise à jour, assurez-vous d'arrêter vos conteneurs
```bash
$ podman compose down 
```

Ensuite, exécutez simplement une commande pull pour récupérer les images `latest`.
```bash
$ podman compose pull
```
Après cela, vous pouvez exécuter compose up pour redémarrer vos services.


```bash
$ podman compose up
```

## Connexion manuelle à votre conteneur Ollama
Vous pouvez vous connecter directement à votre conteneur Ollama en exécutant ces commandes :

```bash
$ podman exec -it ollama-intel-arc /bin/bash
$ /llm/ollama/ollama -v
```

## Mon environnement de développement :
* Core Ultra 7 155H
* Intel® Arc™ Graphics (Meteor Lake-P)
* Fedora 41

## Références 
* [Documentation Open WebUI](https://docs.openwebui.com/)
* [Docker - tags Intel ipex-llm](https://hub.docker.com/r/intelanalytics/ipex-llm-serving-xpu/tags)
* [Docker - extension Intel pour pytorch](https://hub.docker.com/r/intel/intel-extension-for-pytorch/tags)
* [GitHub - tags Intel ipex-llm](https://github.com/intel/ipex-llm/tags)
* [GitHub - extension Intel pour pytorch](https://github.com/intel/intel-extension-for-pytorch/tags)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-16

---