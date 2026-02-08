# FFGO: 비디오 콘텐츠 맞춤화를 위한 첫 번째 프레임

**"비디오 콘텐츠 맞춤화를 위한 첫 번째 프레임" 공식 저장소**

**영어:**
[[웹사이트](http://firstframego.github.io)] | [[논문](https://arxiv.org/abs/2511.15700)] | [[🔴 유튜브: 비공식 커뮤니티 쇼케이스](https://www.youtube.com/watch?v=Dks3q5w7sdw)] | [[🔴 실제 사용자 데모](https://github.com/kijai/ComfyUI-WanVideoWrapper/issues/1676)]

**중국어:**
[[신지위안](https://mp.weixin.qq.com/s/XQGmskJqqFdKx4vCc45tDA)] | [[비리비리](https://www.bilibili.com/video/BV1DQSzB9Eo7/)]


![teaser.gif](https://raw.githubusercontent.com/zli12321/FFGO-Video-Customization/main/./asset/git.gif)



### 곧 출시 예정
- 학습된 LoRA를 사용하는 공식 ComfyUI 워크플로우 지원 추가, 모든 파라미터 설정이 추론 코드와 일치하도록 구성.
- TODO: 소형 베이스 모델용 LoRA 출시 - Hunyuan 1.5 8B 또는 Wan2.2 5B


**🤗 Huggingface의 Lora 어댑터:**  
- [FFGO-Lora-Adapter](https://huggingface.co/Video-Customization/FFGO-Lora-Adapter)


#### 학습 데이터 샘플
- **현재 50개의 학습 비디오 중 일부만 데이터 형식을 보여주기 위해 제공하고 있음을 참고 바랍니다.**

- ```/Data/train/``` 폴더 확인

### 설치
- 환경 생성
```
conda create -n ffgo python=3.11
conda activate ffgo
```
- 리포지토리 클론 및 설정

```
git clone https://github.com/zli12321/FFGO-Video-Customization.git
cd FFGO-Video-Customization
bash setup.sh
```


### Test data
- Test data is available in [Data](https://github.com/zli12321/FFGO-Video-Customization/tree/main/Data/combined_first_frames) folder. All test data involving personal portrait rights has been removed. [0-data.csv](https://github.com/zli12321/FFGO-Video-Customization/blob/main/Data/combined_first_frames/0-data.csv) has the input image path and the caption to generate the video.
- Test data materials are available in [data_materials](https://github.com/zli12321/FFGO-Video-Customization/tree/main/Data/data_materials) folder. These are materials that can form the final input image for video generations.
- Get your own test data: find any images online and segment out the elements as RGBA layer, then combine it with a background using our [combine script]().


### Running Inference

- **When running on your own data, make sure to append our learned transition phrase, "ad23r2 the camera view suddenly changes. ", to your text prompt to ensure the model behaves correctly.**

- **All video results in the paper are generated at 1280 × 720 resolution with 81 frames, which requires an H200 GPU for inference unless memory-saving techniques are applied. For lower resource usage, 640 × 480 resolution videos can be generated without H200. However outputs at this lower resolution can differ significantly in content from the 1280 × 720 results as we shown in the paper.**

- **We are using H200 (141GB RAM) to run inference. If you are using A100 or H100, the memory saving such as cpu offload features need to be turned on.**

1. Download [Wan2.2-I2V-14B](https://huggingface.co/Wan-AI/Wan2.2-I2V-A14B) from huggingface or modelscope and download our Lora adapters. 

```bash
bash download.sh
```


2. Run fun demo video inference

```
bash ./example_single_inference.sh
```

3. 예제 테스트 데이터셋에 대해 연속 추론 실행하기
```
bash example_inference.sh
```

<!-- 
4. Run 4 Step Lora speedup (Will cause quality degrade and inconsistency.)

```
bash ./example_4_step_lora_inference.sh
``` -->


### 인용문
```
@article{chen2025first,
  title={First Frame Is the Place to Go for Video Content Customization},
  author={Chen, Jingxi and Li, Zongxia and Liu, Zhichao and Shi, Guangyao and Wu, Xiyang and Liu, Fuxiao and Fermuller, Cornelia and Feng, Brandon Y and Aloimonos, Yiannis},
  journal={arXiv preprint arXiv:2511.15700},
  year={2025}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-08

---