# 인텔 Arc GPU로 Ollama, Stable Diffusion 및 자동 음성 인식 실행하기

[[블로그](https://blog.eleiton.dev/posts/llm-and-genai-in-docker/)]

[Open WebUI](https://github.com/open-webui/open-webui)를 사용자 친화적인 AI 인터페이스로 사용하고, 대형 언어 모델(LLM) 통합을 위해 [Ollama](https://github.com/ollama/ollama)를 사용하는 Docker 기반 솔루션을 손쉽게 배포하세요.

또한, [ComfyUI](https://github.com/comfyanonymous/ComfyUI) 또는 [SD.Next](https://github.com/vladmandic/sdnext) 도커 컨테이너를 실행하여 Stable Diffusion 기능을 간소화할 수 있습니다.

자동 음성 인식(ASR) 작업을 수행하기 위해 [OpenAI Whisper](https://github.com/openai/whisper) 도커 컨테이너를 선택적으로 실행할 수도 있습니다.

이 모든 컨테이너는 [Intel® Extension for PyTorch](https://github.com/intel/intel-extension-for-pytorch)를 사용하여 Linux 시스템의 인텔 Arc 시리즈 GPU에 최적화되어 있습니다.

![screenshot](https://raw.githubusercontent.com/eleiton/ollama-intel-arc/main/resources/open-webui.png)

## 서비스
1. Ollama  
   * 인텔 Arc GPU가 탑재된 Linux 컴퓨터에서 llama.cpp와 Ollama를 IPEX-LLM과 함께 실행합니다.  
   * [Intel](https://github.com/intel/ipex-llm/blob/main/docs/mddocs/DockerGuides/README.md) 가이드라인을 따라 빌드되었습니다.  
   * 공식 [Intel ipex-llm 도커 이미지](https://hub.docker.com/r/intelanalytics/ipex-llm-inference-cpp-xpu)를 기본 컨테이너로 사용합니다.  
   * 최신 패키지 버전을 사용하며, 안정성보다는 최신 기능을 우선시합니다.  
   * Ollama 서비스에 연결할 수 있도록 `11434` 포트를 개방합니다.

2. Open WebUI  
   * Open WebUI의 공식 배포판을 사용합니다.  
   * 인증 없이 사용 가능하도록 `WEBUI_AUTH`가 비활성화되어 있습니다.  
   * `ENABLE_OPENAI_API`는 비활성화, `ENABLE_OLLAMA_API`는 활성화하여 Ollama를 통한 상호작용만 허용합니다.  
   * UI에서 이미지 생성이 가능하도록 `ENABLE_IMAGE_GENERATION`이 활성화되어 있습니다.  
   * 이미지 생성 엔진은 자동1111(Automatic1111)로 설정되어 있으며, SD.Next도 호환됩니다.

3. ComfyUI  
   * 가장 강력하고 모듈화된 확산 모델 GUI, API 및 백엔드로 그래프/노드 인터페이스를 제공합니다.  
   * 공식 [Intel® Extension for PyTorch](https://pytorch-extension.intel.com/installation?platform=gpu)를 기본 컨테이너로 사용합니다.

4. SD.Next  
   * Automatic1111 기반 AI 생성 이미지 올인원 솔루션입니다.  
   * 공식 [Intel® Extension for PyTorch](https://pytorch-extension.intel.com/installation?platform=gpu)를 기본 컨테이너로 사용합니다.  
   * 인텔 Extension for Pytorch 이미지와 호환되도록 SD.Next의 [도커 파일](https://github.com/vladmandic/sdnext/blob/dev/configs/Dockerfile.ipex)을 맞춤화하여 사용합니다.



5. OpenAI Whisper
   * 대규모 약한 감독을 통한 강력한 음성 인식
   * 공식 [Intel® Extension for PyTorch]를 기본 컨테이너로 사용합니다(* 공식 [Intel® Extension for PyTorch](https://pytorch-extension.intel.com/installation?platform=gpu)를 기본 컨테이너로 사용합니다)

## 설정
다음 명령어를 실행하여 Open WebUI와 함께 Ollama 인스턴스를 시작하세요
```bash
$ git clone https://github.com/eleiton/ollama-intel-arc.git
$ cd ollama-intel-arc
$ podman compose up
```
추가로, 하나 이상의 이미지 생성 도구를 실행하려면, 다른 터미널에서 다음 명령어를 실행하세요:

ComfyUI의 경우

```bash
$ podman compose -f docker-compose.comfyui.yml up
```
SD.Next 용

```bash
$ podman compose -f docker-compose.sdnext.yml up
```

자동 음성 인식을 위해 Whisper를 실행하려면, 다른 터미널에서 다음 명령어를 실행하세요:
```bash
$ podman compose -f docker-compose.whisper.yml up
```

## 검증
다음 명령어를 실행하여 Ollama 인스턴스가 정상적으로 실행 중인지 확인하세요
```bash
$ curl http://localhost:11434/
Ollama is running
```
Open WebUI를 사용할 때, 콘솔에 이 일부 출력이 표시되어 arc GPU가 감지되었음을 나타냅니다
```bash
[ollama-intel-arc] | Found 1 SYCL devices:
[ollama-intel-arc] | |  |                   |                                       |       |Max    |        |Max  |Global |                     |
[ollama-intel-arc] | |  |                   |                                       |       |compute|Max work|sub  |mem    |                     |
[ollama-intel-arc] | |ID|        Device Type|                                   Name|Version|units  |group   |group|size   |       Driver version|
[ollama-intel-arc] | |--|-------------------|---------------------------------------|-------|-------|--------|-----|-------|---------------------|
[ollama-intel-arc] | | 0| [level_zero:gpu:0]|                     Intel Arc Graphics|  12.71|    128|    1024|   32| 62400M|         1.6.32224+14|
```
## 이미지 생성 사용하기
* 웹 브라우저를 열고 http://localhost:7860 에 접속하여 SD.Next 웹 페이지에 접근합니다.
* 이 데모에서는 [DreamShaper](https://civitai.com/models/4384/dreamshaper) 모델을 사용합니다.
* 다음 단계를 따르세요:
* 이미지(1)를 클릭하여 `dreamshaper_8` 모델을 다운로드합니다.
* 다운로드가 완료될 때까지 기다립니다 (~2GB 크기), 그리고 드롭박스(2)에서 선택합니다.
* (선택 사항) SD.Next UI에 머무르고 싶다면 자유롭게 탐색하세요(3).
![screenshot](https://raw.githubusercontent.com/eleiton/ollama-intel-arc/main/resources/sd.next.png)
* SD.Next 사용에 대한 자세한 정보는 공식 [문서](https://vladmandic.github.io/sdnext-docs/)를 참고하세요.
* 웹 브라우저를 열고 http://localhost:4040 에 접속하여 Open WebUI 웹 페이지에 접근합니다.
* 관리자 [설정](http://localhost:4040/admin/settings) 페이지로 이동합니다.
* 이미지 섹션(1)으로 이동합니다.
* 모든 설정이 올바른지 확인하고 새로고침 버튼(2)을 눌러 검증합니다.
* (선택 사항) 변경 사항이 있으면 저장하세요(3).
![screenshot](https://raw.githubusercontent.com/eleiton/ollama-intel-arc/main/resources/open-webui-settings.png)
* Open WebUI 사용에 대한 자세한 정보는 공식 [문서](https://docs.openwebui.com/)를 참고하세요.
* 이제 완료되었습니다. Open WebUI 메인 페이지로 돌아가서 채팅을 시작하세요. 이미지 생성 의사를 나타내려면 `Image` 버튼을 반드시 선택하세요.
![screenshot](https://raw.githubusercontent.com/eleiton/ollama-intel-arc/main/resources/open-webui-chat.png)

## 자동 음성 인식 사용하기
* 오디오 파일을 전사하기 위한 명령 예시는 다음과 같습니다:

```bash
  podman exec -it  whisper-ipex whisper https://www.lightbulblanguages.co.uk/resources/ge-audio/hobbies-ge.mp3 --device xpu --model small --language German --task transcribe
```
* 응답:
```bash
  [00:00.000 --> 00:08.000]  Ich habe viele Hobbys. In meiner Freizeit mache ich sehr gerne Sport, wie zum Beispiel Wasserball oder Radfahren.
  [00:08.000 --> 00:13.000]  Außerdem lese ich gerne und lerne auch gerne Fremdsprachen.
  [00:13.000 --> 00:19.000]  Ich gehe gerne ins Kino, höre gerne Musik und treffe mich mit meinen Freunden.
  [00:19.000 --> 00:22.000]  Früher habe ich auch viel Basketball gespielt.
  [00:22.000 --> 00:26.000]  Im Frühling und im Sommer werde ich viele Radtouren machen.
  [00:26.000 --> 00:29.000]  Außerdem werde ich viel schwimmen gehen.
  [00:29.000 --> 00:33.000]  Am liebsten würde ich das natürlich im Meer machen.
```
* 오디오 파일을 변환하는 명령어의 예입니다:
```bash
  podman exec -it  whisper-ipex whisper https://www.lightbulblanguages.co.uk/resources/ge-audio/hobbies-ge.mp3 --device xpu --model small --language German --task translate
```
* 응답:
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
* 웹 파일 대신 자신의 오디오 파일을 사용하려면, `~/whisper-files` 폴더에 파일을 넣고 다음과 같이 접근하세요:
```bash
  podman exec -it  whisper-ipex whisper YOUR_FILE_NAME.mp3 --device xpu --model small --task translate
```

## 컨테이너 업데이트
[ipex-llm-inference-cpp-xpu](https://hub.docker.com/r/intelanalytics/ipex-llm-inference-cpp-xpu) 도커 이미지나 Open WebUI 도커 이미지에 새로운 업데이트가 있을 경우, 최신 상태를 유지하기 위해 컨테이너를 업데이트할 수 있습니다.

업데이트 전에 반드시 컨테이너를 중지하세요
```bash
$ podman compose down 
```

그런 다음 pull 명령을 실행하여 `latest` 이미지를 가져오십시오.
```bash
$ podman compose pull
```
그 후에, 다시 서비스를 시작하려면 compose up을 실행할 수 있습니다.


```bash
$ podman compose up
```

## Ollama 컨테이너에 수동으로 연결하기
다음 명령어를 실행하여 Ollama 컨테이너에 직접 연결할 수 있습니다:

```bash
$ podman exec -it ollama-intel-arc /bin/bash
$ /llm/ollama/ollama -v
```
## 나의 개발 환경:
* Core Ultra 7 155H
* Intel® Arc™ 그래픽스 (Meteor Lake-P)
* Fedora 41

## 참고 자료
* [Open WebUI 문서](https://docs.openwebui.com/)
* [Docker - Intel ipex-llm 태그](https://hub.docker.com/r/intelanalytics/ipex-llm-serving-xpu/tags)
* [Docker - Intel pytorch 확장](https://hub.docker.com/r/intel/intel-extension-for-pytorch/tags)
* [GitHub - Intel ipex-llm 태그](https://github.com/intel/ipex-llm/tags)
* [GitHub - Intel pytorch 확장](https://github.com/intel/intel-extension-for-pytorch/tags)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-16

---