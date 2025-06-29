# SinGAN

[프로젝트](https://tamarott.github.io/SinGAN.htm) | [Arxiv](https://arxiv.org/pdf/1905.01164.pdf) | [CVF](http://openaccess.thecvf.com/content_ICCV_2019/papers/Shaham_SinGAN_Learning_a_Generative_Model_From_a_Single_Natural_Image_ICCV_2019_paper.pdf) | [보조 자료](https://openaccess.thecvf.com/content_ICCV_2019/supplemental/Shaham_SinGAN_Learning_a_ICCV_2019_supplemental.pdf) | [강연 (ICCV`19)](https://youtu.be/mdAcPe74tZI?t=3191) 
### 논문 공식 pytorch 구현: "SinGAN: Learning a Generative Model from a Single Natural Image"
#### ICCV 2019 최우수 논문상 (Marr prize)


## *단일* 이미지로부터의 랜덤 샘플
SinGAN을 사용하면 단일 자연 이미지로부터 생성 모델을 학습할 수 있으며, 이후 주어진 이미지로부터 랜덤 샘플을 생성할 수 있습니다. 예를 들어:

![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/teaser.PNG)


## SinGAN의 응용
SinGAN은 다양한 이미지 조작 작업에도 사용할 수 있습니다. 예를 들어:
 ![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/manipulation.PNG)
이 작업은 이미 학습된 모델에 이미지를 주입하여 수행합니다. 자세한 내용은 [논문](https://arxiv.org/pdf/1905.01164.pdf) 4장을 참고하세요.


### 인용
이 코드를 연구에 사용하신다면 논문을 인용해 주세요:

```
@inproceedings{rottshaham2019singan,
  title={SinGAN: Learning a Generative Model from a Single Natural Image},
  author={Rott Shaham, Tamar and Dekel, Tali and Michaeli, Tomer},
  booktitle={Computer Vision (ICCV), IEEE International Conference on},
  year={2019}
}
```

## 코드

### 의존성 설치

```
python -m pip install -r requirements.txt
```

이 코드는 python 3.6, torch 1.4에서 테스트되었습니다.

참고: 현재 코드는 최적화 방식으로 인해 torch 1.4 이하만 지원합니다.

더 최신 버전의 torch를 사용하려면 다음 저장소를 시도해 볼 수 있습니다: https://github.com/kligvasser/SinGAN (결과는 공식 구현과 반드시 동일하지 않을 수 있습니다).


###  학습
사용자 이미지로 SinGAN 모델을 학습하려면, 원하는 학습 이미지를 Input/Images 폴더에 넣고 아래 명령어를 실행하세요.

```
python main_train.py --input_name <input_file_name>
```

이 명령은 결과로 생성된 학습된 모델을 사용해, 가장 거친 스케일(n=0)부터 랜덤 샘플도 생성합니다.

cpu 환경에서 코드를 실행하려면 `main_train.py` 호출 시 `--not_cuda` 옵션을 지정하세요.

###  랜덤 샘플
원하는 시작 생성 스케일에서 랜덤 샘플을 생성하려면, 먼저 위에서 설명한 대로 SinGAN 모델을 원하는 이미지로 학습한 뒤, 아래 명령을 실행하세요.

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples --gen_start_scale <generation start scale number>
```

주의: 전체 모델을 사용하려면 생성 시작 스케일을 0으로 지정하세요. 두 번째 스케일부터 시작하려면 1로 지정하면 됩니다.

###  임의 크기의 랜덤 샘플
임의의 크기로 랜덤 샘플을 생성하려면, 먼저 위에서 설명한 대로 SinGAN 모델을 원하는 이미지로 학습한 뒤, 아래 명령을 실행하세요.

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples_arbitrary_sizes --scale_h <horizontal scaling factor> --scale_v <vertical scaling factor>
```

###  단일 이미지로 애니메이션 생성

단일 이미지로 짧은 애니메이션을 생성하려면, 아래 명령을 실행하세요.

```
python animation.py --input_name <input_file_name> 
```

이 명령은 자동으로 noise padding 모드로 새로운 학습 단계를 시작합니다.

###  조화화(Harmonization)

오브젝트를 이미지에 자연스럽게 합성하려면([논문](https://arxiv.org/pdf/1905.01164.pdf) Fig. 13 참고), 먼저 SinGAN 모델을 원하는 배경 이미지로 학습하고(위와 동일), 단순히 합성한 참조 이미지와 해당 바이너리 마스크를 "Input/Harmonization" 폴더에 저장하세요(예시는 저장된 이미지를 참고). 아래 명령어를 실행하세요.

```
python harmonization.py --input_name <training_image_file_name> --ref_name <naively_pasted_reference_image_file_name> --harmonization_start_scale <scale to inject>

```

주입 스케일에 따라 서로 다른 조화화 효과가 나옵니다. 가장 거친 주입 스케일은 1입니다.

###  편집

이미지를 편집하려면([논문](https://arxiv.org/pdf/1905.01164.pdf) Fig. 12 참고), 먼저 SinGAN 모델을 원하는 비편집 이미지로 학습하고(위와 동일), 간단히 편집한 이미지를 "Input/Editing"에 해당 바이너리 맵과 함께 참조 이미지로 저장하세요(예시는 저장된 이미지를 참고). 아래 명령어를 실행하세요.

```
python editing.py --input_name <training_image_file_name> --ref_name <edited_image_file_name> --editing_start_scale <scale to inject>
```
마스크된 출력과 마스크되지 않은 출력이 모두 저장됩니다.
여기서도, 서로 다른 injection scale은 서로 다른 편집 효과를 만듭니다. 가장 거친 injection scale은 1입니다.

###  Paint to Image

페인팅을 실제 이미지로 변환하려면([논문](https://arxiv.org/pdf/1905.01164.pdf) Fig. 11 예시 참조), 먼저 원하는 이미지에서 SinGAN 모델을 학습한 후(위에서 설명한 대로), 당신의 페인팅을 "Input/Paint"에 저장하고 아래 명령어를 실행하세요.

```
python paint2image.py --input_name <training_image_file_name> --ref_name <paint_image_file_name> --paint_start_scale <scale to inject>
```
여기서도, 서로 다른 injection scale은 서로 다른 편집 효과를 만듭니다. 가장 거친 injection scale은 1입니다.

고급 옵션: quantization_flag을 True로 지정하면, 모델의 injection 레벨만 재학습하여, 이전 스케일에서 업샘플된 생성 이미지의 컬러 양자화 버전을 얻을 수 있습니다. 일부 이미지의 경우, 이 방법이 더 현실적인 결과를 가져올 수 있습니다.

### Super Resolution
이미지를 초해상도로 변환하려면 아래 명령어를 실행하세요:
```
python SR.py --input_name <LR_image_file_name>
```
이 명령어는 자동으로 4배 업샘플링 팩터에 해당하는 SinGAN 모델을 학습합니다(이미 존재하지 않는 경우).
다른 초해상도 배율이 필요하다면, 함수 호출 시 파라미터 `--sr_factor`를 지정하세요.
SinGAN의 BSD100 데이터셋에 대한 결과는 'Downloads' 폴더에서 다운로드할 수 있습니다.

## 추가 데이터 및 기능

### Single Image Fréchet Inception Distance (SIFID score)
실제 이미지와 이에 대응하는 생성 샘플 간의 SIFID를 계산하려면 다음 명령어를 실행하세요:
```
python SIFID/sifid_score.py --path2real <real images path> --path2fake <fake images path>
```  
각 생성 이미지 파일 이름이 해당 실제 이미지 파일 이름과 동일해야 합니다. 이미지는 `.jpg` 포맷으로 저장되어야 합니다.

### Super Resolution Results
SinGAN의 BSD100 데이터셋에 대한 초해상도 결과는 'Downloads' 폴더에서 다운로드할 수 있습니다.

### 사용자 연구
사용자 연구에 사용된 데이터는 Downloads 폴더에서 찾을 수 있습니다.

real 폴더: [places database](http://places.csail.mit.edu/)에서 무작위로 선택한 50개의 실제 이미지

fake_high_variance 폴더: 각 실제 이미지마다 n=N부터 시작한 무작위 샘플

fake_mid_variance 폴더: 각 실제 이미지마다 n=N-1부터 시작한 무작위 샘플

자세한 내용은 논문([paper](https://arxiv.org/pdf/1905.01164.pdf))의 3.1절을 참조하세요.
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---