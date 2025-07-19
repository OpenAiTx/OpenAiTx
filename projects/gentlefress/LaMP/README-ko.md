<translate-content># :bulb: LaMP: 모션 생성, 검색 및 캡셔닝을 위한 언어-모션 사전학습 (ICLR 2025)
### [[프로젝트 페이지]](https://aigc3d.github.io/LaMP/) [[논문]](https://arxiv.org/abs/2410.07093)
![teaser_image](https://github.com/gentlefress/LaMP/blob/main/teaser.png)

저희 코드나 논문이 도움이 되셨다면, 저장소에 별을 눌러주시고 인용해 주시면 감사하겠습니다:</translate-content>
```
@article{li2024lamp,
  title={LaMP: Language-Motion Pretraining for Motion Generation, Retrieval, and Captioning},
  author={Li, Zhe and Yuan, Weihao and He, Yisheng and Qiu, Lingteng and Zhu, Shenhao and Gu, Xiaodong and Shen, Weichao and Dong, Yuan and Dong, Zilong and Yang, Laurence T},
  journal={arXiv preprint arXiv:2410.07093},
  year={2024}
}
```
## :postbox: 뉴스
📢 **2025-01-22** --- 🔥🔥🔥 축하합니다! LaMP가 ICLR 2025에 채택되었습니다.

📢 **2025-4-28** --- LaMP의 코드와 모델을 공개합니다. 학습/평가/생성 스크립트 포함.

📢 **2025-4-28** --- 웹페이지와 git 프로젝트를 초기화했습니다.  


## :1st_place_medal: 준비하세요

<details>
  
### 1. Conda 환경</details>

```
conda env create -f environment.yml
conda activate lamp
pip install git+https://github.com/openai/CLIP.git
```
<translate-content>우리는 Python 3.9.12와 PyTorch 1.12.1에서 코드를 테스트합니다

### 2. 모델 및 의존성

#### 사전 학습된 모델 다운로드</translate-content>
```
bash prepare/download_models.sh
```
#### 평가 모델 및 장갑 다운로드  
평가 용도 전용입니다.

```
bash prepare/download_evaluator.sh
bash prepare/download_glove.sh
```
#### (선택 사항) 수동 다운로드  
##### VQVAE 사전학습 가중치:  
https://virutalbuy-public.oss-cn-hangzhou.aliyuncs.com/share/aigc3d/lamp/vq.tar  
##### LaMP 사전학습 가중치:  
HumanML3D: https://virutalbuy-public.oss-cn-hangzhou.aliyuncs.com/share/aigc3d/lamp/h3d-qformer.tar  

KIT-ML: https://virutalbuy-public.oss-cn-hangzhou.aliyuncs.com/share/aigc3d/lamp/kit-qformer.tar  
##### LaMP-T2M 사전학습 가중치:  
https://virutalbuy-public.oss-cn-hangzhou.aliyuncs.com/share/aigc3d/lamp/t2m.tar  
##### M2T-LaMP 사전학습 가중치:  
https://virutalbuy-public.oss-cn-hangzhou.aliyuncs.com/share/aigc3d/lamp/m2t.pth  
### 3. 데이터 받기  

여기에는 두 가지 옵션이 있습니다:  
* **데이터 받기 건너뛰기**, *자신의* 설명을 사용하여 모션을 생성하려는 경우.  
* **전체 데이터 받기**, 모델을 *재학습* 및 *평가*하려는 경우.  

**(a). 전체 데이터 (텍스트 + 모션)**  

**HumanML3D** - [HumanML3D](https://github.com/EricGuo5513/HumanML3D.git) 지침을 따르고, 결과 데이터셋을 우리 저장소에 복사하세요:


```
cp -r ../HumanML3D/HumanML3D ./dataset/HumanML3D
```
**KIT**-[HumanML3D](https://github.com/EricGuo5513/HumanML3D.git)에서 다운로드한 후 결과를 `./dataset/KIT-ML`에 배치하세요.

#### 

</details>

## :fire: 데모
<details>

### (a) 단일 프롬프트에서 생성하기
```
python gen_t2m.py --gpu_id 1 --ext exp1 --text_prompt "A person is running on a treadmill."
```
### (b) 프롬프트 파일에서 생성하기
프롬프트 파일 예시는 `./assets/text_prompt.txt`에 있습니다. 각 줄마다 `<텍스트 설명>#<모션 길이>` 형식을 따라주세요. 모션 길이는 포즈의 개수를 나타내며, 정수여야 하고 4의 배수로 반올림됩니다. 본 연구에서는 모션이 20fps입니다.

만약 `<텍스트 설명>#NA`로 작성하면, 모델이 길이를 결정합니다. 한 개의 **NA**가 있으면 나머지도 모두 자동으로 **NA**가 됩니다.

```
python gen_t2m.py --gpu_id 1 --ext exp2 --text_path ./assets/text_prompt.txt
```
몇 가지 추가로 관심 있을 만한 파라미터:
* `--repeat_times`: 생성 시 복제 횟수, 기본값 `1`.
* `--motion_length`: 생성할 포즈 개수 지정, (a)에서만 적용 가능.

출력 파일들은 `./generation/<ext>/` 폴더에 저장됩니다. 파일은
* `numpy 파일`: (nframe, 22, 3) 형태의 생성된 모션, `./joints` 하위 폴더에 있음.
* `비디오 파일`: mp4 형식의 스틱 피겨 애니메이션, `./animation` 하위 폴더에 있음.
* `bvh 파일`: 생성된 모션의 bvh 파일, `./animation` 하위 폴더에 있음.

생성된 모션에 단순한 풋 IK를 적용했습니다. 접미사 `_ik`가 붙은 파일을 참고하세요. 때로는 잘 작동하지만, 실패할 때도 있습니다.
  
</details>

## :basketball_man: 시각화
<details>

모든 애니메이션은 수작업으로 블렌더에서 렌더링했습니다. 캐릭터는 [mixamo](https://www.mixamo.com/#/)에서 가져왔습니다. T-Pose 상태의 스켈레톤이 포함된 캐릭터를 다운로드해야 합니다.

### 리타게팅
리타게팅 시, rokoko는 발 부분에서 큰 오류를 일으키는 경우가 많았습니다. 반면, [keemap.rig.transfer](https://github.com/nkeeline/Keemap-Blender-Rig-ReTargeting-Addon/releases)는 보다 정밀한 리타게팅을 보여줍니다. [튜토리얼](https://www.youtube.com/watch?v=EG-VCMkVpxg)도 참고할 수 있습니다.

다음 단계를 따르세요:
* github에서 keemap.rig.transfer를 다운로드하여 블렌더에 설치합니다.
* 모션 파일(.bvh)과 캐릭터 파일(.fbx)을 블렌더에 불러옵니다.
* 소스와 대상 스켈레톤을 `Shift + 선택`합니다. (Rest Position일 필요 없음)
* `포즈 모드`로 전환한 후, 뷰 윈도우 우측 상단의 `KeeMapRig` 도구를 펼칩니다.
* `bone mapping file`에 `./assets/mapping.json`(작동하지 않으면 `mapping6.json`)을 지정하고 `Read In Bone Mapping File`을 클릭합니다. 이 파일은 저희가 수작업으로 만들었으며 대부분의 mixamo 캐릭터에 적용 가능합니다.
* (선택 사항) 본 매핑과 회전을 직접 수정하여 자신만의 캐릭터에 맞게 조정할 수 있습니다. `Save Bone Mapping File`은 현재 매핑 설정을 로컬 파일에 저장합니다.
* `Number of Samples`, `Source Rig`, `Destination Rig Name`을 조정합니다.
* `Transfer Animation from Source Destination`을 클릭하고 몇 초 기다립니다.

다른 리타게팅 도구는 시도하지 않았습니다. 더 유용한 도구를 발견하면 댓글로 알려주세요.

</details>

## :flashlight: 직접 모델 훈련하기
<details>


**주의**: 마스크드/잔차(transformers) 훈련 전에 VQ-VAE를 반드시 먼저 훈련해야 합니다. 후자의 두 모델은 동시에 훈련 가능 합니다.

### VQ-VAE 훈련
스크립트를 실행하려면 평가용 모델도 다운로드해야 할 수 있습니다.


```
python train_vq.py --name vq_name --gpu_id 1 --dataset_name t2m --batch_size 256  --max_epoch 50 --quantize_dropout_prob 0.2 --gamma 0.05
```
### LaMP 훈련

```
python train_lamp.py --name lamp_name --gpu_id 2 --dataset_name t2m --batch_size 64 --vq_name vq_name
```
### 마스크드 트랜스포머 훈련하기

```
python train_t2m_transformer.py --name mtrans_name --gpu_id 2 --dataset_name t2m --batch_size 64 --vq_name vq_name
```
<translate-content>
* `--dataset_name`: 모션 데이터셋, HumanML3D의 경우 `t2m`, KIT-ML의 경우 `kit`.  
* `--name`: 모델 이름 지정. `./checkpoints/<dataset_name>/<name>` 경로에 모델 공간이 생성됩니다.
* `--gpu_id`: GPU 아이디.
* `--batch_size`: vq 학습 시 `512` 사용. 마스크드/잔여 변환기에서는 HumanML3D에 `64`, KIT-ML에 `16` 사용.
* `--quantize_drop_prob`: 양자화 드롭아웃 비율, `0.2` 사용.
* `--vq_name`: 마스크드/잔여 변환기 학습 시 토크나이징에 사용할 vq 모델 이름 지정 필요.
* `--cond_drop_prob`: 조건 드롭 비율, 분류기 없는 가이던스용. `0.2` 사용.

모든 사전 학습된 모델과 중간 결과는 `./checkpoints/<dataset_name>/<name>` 경로에 저장됩니다.

### Train M2T</translate-content>
```
python train_m2t.py --exp-name M2T --num-layers 12 --batch-size 80 --embed-dim-gpt 1024 --nb-code 512 --n-head-gpt 16 --block-size 51 --ff-rate 4 --drop-out-rate 0.1 --resume-pth your_own_vqvae --vq-name VQVAE --out-dir ./output --total-iter 150000 --lr-scheduler 75000 --lr 0.00005 --dataname kit --down-t 2 --depth 3 --quantizer ema_reset --eval-iter 10000 --pkeep 0.5 --dilation-growth-rate 3 --vq-act relu
```
<translate-content>
</details>

## :artist: 평가
<details>

### VQ-VAE 재구성 평가:
HumanML3D:</translate-content>
```
python eval_t2m_vq.py --gpu_id 0 --name  --dataset_name t2m

```
KIT-ML:
```
python eval_t2m_vq.py --gpu_id 0 --name  --dataset_name kit
```
### LaMP-T2M 평가:
HumanML3D:

```
python eval_t2m_trans_res.py --res_name mtrans_name --dataset_name t2m --name eval_name --gpu_id 1 --cond_scale 4 --time_steps 10 --ext evaluation
```
KIT-ML:
```
python eval_t2m_trans_res.py --res_name mtrans_name_k --dataset_name kit --name eval_name_k --gpu_id 0 --cond_scale 2 --time_steps 10 --ext evaluation
```
* `--res_name`: `residual transformer` 모델 이름입니다.  
* `--name`: `masked transformer` 모델 이름입니다.  
* `--cond_scale`: 클래스-프리 가이드의 스케일입니다.  
* `--time_steps`: 추론을 위한 반복 횟수입니다.  
* `--ext`: 평가 결과 저장 파일 이름입니다.  
* `--which_epoch`: `masked transformer`의 체크포인트 이름입니다.  

최종 평가 결과는 `./checkpoints/<dataset_name>/<name>/eval/<ext>.log`에 저장됩니다.  

### LaMP-M2T 평가:

```
python M2T_eval.py --exp-name Test_M2T --num-layers 9 --batch-size 1 --embed-dim-gpt 1024 --nb-code 512 --n-head-gpt 16 --block-size 51 --ff-rate 4 --drop-out-rate 0.1 --resume-pth your_own_vqvae --vq-name VQVAE --out-dir ./output --total-iter 150000 --lr-scheduler 75000 --lr 0.0001 --dataname t2m --down-t 2 --depth 3 --quantizer ema_reset --eval-iter 10000 --pkeep 0.5 --dilation-growth-rate 3 --vq-act relu --resume-trans your_own_m2t
```
LaMP-BertScore 메트릭은 먼저 LaMP-M2T를 사용하여 합성된 모션의 텍스트 설명을 생성한 후, 생성된 설명과 실제 텍스트 간의 BertScore를 계산하여 산출됩니다.

</details>

## 감사의 글

본 코드가 기반한 다음 오픈 소스 작업들에 진심으로 감사드립니다:

[T2M-GPT](https://github.com/Mael-zys/T2M-GPT) 및 [MoMask](https://github.com/EricGuo5513/momask-codes/tree/main).

## 라이선스
이 코드는 [MIT LICENSE](https://github.com/gentlefress/LaMP/blob/main/LICENSE.md) 하에 배포됩니다.

본 코드는 SMPL, SMPL-X, PyTorch3D 등 다른 라이브러리에 의존하며, 각기 다른 라이선스를 갖는 데이터셋을 사용하므로 이들 라이선스도 준수해야 합니다.

### 기타
추가 문의는 keycharon0122@gmail.com 으로 연락 바랍니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---