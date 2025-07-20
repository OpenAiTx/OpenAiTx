<translate-content># FastVLM: 비전 언어 모델을 위한 효율적인 비전 인코딩

이곳은
**[FastVLM: 비전 언어 모델을 위한 효율적인 비전 인코딩](https://www.arxiv.org/abs/2412.13303). (CVPR 2025)**의 공식 저장소입니다.

[//]: # (![FastViTHD 성능]&#40;docs/acc_vs_latency_qwen-2.png&#41;)
<p align="center">
<img src="https://raw.githubusercontent.com/apple/ml-fastvlm/main/docs/acc_vs_latency_qwen-2.png" alt="정확도 대 지연 시간 그래프." width="400"/>
</p>

### 주요 내용
* 우리는 고해상도 이미지에 대해 토큰 수를 줄이고 인코딩 시간을 크게 단축하는 새로운 하이브리드 비전 인코더인 FastViTHD를 소개합니다.  
* 가장 작은 변형은 LLaVA-OneVision-0.5B보다 85배 빠른 첫 토큰 생성 시간(TTFT)과 3.4배 작은 비전 인코더 크기로 우수한 성능을 보입니다.
* Qwen2-7B LLM을 사용하는 더 큰 변형들은 Cambrian-1-8B 같은 최신 작업들을 단일 이미지 인코더로 7.9배 빠른 TTFT와 함께 능가합니다.
* 모바일 기기에서 모델 성능을 시연하는 데모 iOS 앱을 제공합니다.

<table>
<tr>
    <td><img src="https://raw.githubusercontent.com/apple/ml-fastvlm/main/docs/fastvlm-counting.gif" alt="FastVLM - 카운팅"></td>
    <td><img src="https://raw.githubusercontent.com/apple/ml-fastvlm/main/docs/fastvlm-handwriting.gif" alt="FastVLM - 손글씨"></td>
    <td><img src="https://raw.githubusercontent.com/apple/ml-fastvlm/main/docs/fastvlm-emoji.gif" alt="FastVLM - 이모지"></td>
</tr>
</table>

## 시작하기
우리는 FastVLM 변형을 학습하기 위해 LLaVA 코드베이스를 사용합니다. 자체 변형을 학습하거나 미세 조정하려면,
[LLaVA](https://github.com/haotian-liu/LLaVA) 코드베이스에서 제공하는 지침을 따라 주십시오.
우리 모델로 추론을 실행하는 방법도 안내합니다.   

### 설정</translate-content>
```bash
conda create -n fastvlm python=3.10
conda activate fastvlm
pip install -e .
```
### 모델 동물원
다양한 평가에 대한 자세한 정보는 저희 [논문](https://www.arxiv.org/abs/2412.13303)을 참조하세요.

| 모델          | 단계  |                                            파이토치 체크포인트 (url)                                             |
|:-------------|:-----:|:---------------------------------------------------------------------------------------------------------------:|
| FastVLM-0.5B |   2   | [fastvlm_0.5b_stage2](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_0.5b_stage2.zip) |
|              |   3   | [fastvlm_0.5b_stage3](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_0.5b_stage3.zip) |
| FastVLM-1.5B |   2   | [fastvlm_1.5b_stage2](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_1.5b_stage2.zip) |
|              |   3   | [fastvlm_1.5b_stage3](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_1.5b_stage3.zip)  |
| FastVLM-7B   |   2   | [fastvlm_7b_stage2](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_7b_stage2.zip)  |
|              |   3   | [fastvlm_7b_stage3](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_7b_stage3.zip)  |

모든 사전 학습된 체크포인트를 다운로드하려면 아래 명령어를 실행하세요 (연결 상태에 따라 시간이 걸릴 수 있으니 ☕️를 준비해두는 것이 좋습니다).


```bash
bash get_models.sh   # Files will be downloaded to `checkpoints` directory.
```
### 사용 예시  
PyTorch 체크포인트의 추론을 실행하려면 아래 지침을 따르세요.

```bash
python predict.py --model-path /path/to/checkpoint-dir \
                  --image-file /path/to/image.png \
                  --prompt "Describe the image."
```
### Apple Silicon에서 추론하기  
Apple Silicon에서 추론을 실행하려면 pytorch 체크포인트를 Apple Silicon에서 실행할 수 있는 형식으로 내보내야 하며, 자세한 지침과 코드는 [`model_export`](model_export/) 하위 폴더에서 확인할 수 있습니다.  
자세한 내용은 해당 README를 참조하십시오.  

편의를 위해 Apple Silicon 호환 형식의 3가지 모델을 제공합니다: [fastvlm_0.5b_stage3](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_0.5b_stage3_llm.fp16.zip),  
[fastvlm_1.5b_stage3](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_1.5b_stage3_llm.int8.zip),  
[fastvlm_7b_stage3](https://ml-site.cdn-apple.com/datasets/fastvlm/llava-fastvithd_7b_stage3_llm.int4.zip).  
개발자분들은 [`model_export`](model_export/)의 지침에 따라 적절한 양자화 수준으로 원하는 모델을 내보내는 것을 권장합니다.  

### Apple 기기에서 추론하기  
iPhone, iPad 또는 Mac과 같은 Apple 기기에서 추론을 실행하려면 [`app`](app/) 하위 폴더를 참조하십시오.  

## 인용  
이 코드를 유용하게 사용하셨다면, 다음 논문을 인용해 주십시오:



```
@InProceedings{fastvlm2025,
  author = {Pavan Kumar Anasosalu Vasu, Fartash Faghri, Chun-Liang Li, Cem Koc, Nate True, Albert Antony, Gokul Santhanam, James Gabriel, Peter Grasch, Oncel Tuzel, Hadi Pouransari},
  title = {FastVLM: Efficient Vision Encoding for Vision Language Models},
  booktitle = {Proceedings of the IEEE/CVF Conference on Computer Vision and Pattern Recognition (CVPR)},
  month = {June},
  year = {2025},
}
```
## 감사의 글
우리 코드베이스는 여러 오픈소스 기여로 구축되었습니다. 자세한 내용은 [ACKNOWLEDGEMENTS](ACKNOWLEDGEMENTS)를 참조하십시오.

## 라이선스
제공된 코드를 사용하기 전에 저장소의 [LICENSE](LICENSE)를 확인하시고
출시된 모델에 대해서는 [LICENSE_MODEL](LICENSE_MODEL)을 확인하십시오.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---