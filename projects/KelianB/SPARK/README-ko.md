<p align="center">
    <h1 align="center">SPARK: 자기지도 학습 기반 개인화 실시간 단안 얼굴 캡처</h1>
    <p align="center">
        <a href="mailto://kelian.baert@gmail.com"><strong>켈리안 배르트</strong></a>
        ·
        <a href="https://sbharadwajj.github.io/"><strong>슈리샤 바라드와즈</strong></a>
        ·
        <a href="https://www.linkedin.com/in/fabien-castan/"><strong>파비앙 카스탱</strong></a>
        ·
        <a href="https://www.linkedin.com/in/benoitmaujean/"><strong>브누아 모제앙</strong></a>
        ·
        <a href="https://people.irisa.fr/Marc.Christie/"><strong>마르크 크리스티</strong></a>
        ·
        <a href="https://vabrevaya.github.io/"><strong>빅토리아 페르난데스 아브레바야</strong></a>
        ·
        <a href="https://boukhayma.github.io/"><strong>아드난 부카이마</strong></a>
    </p>
    <p align="center">
        <a href="https://technicolor.com">테크니컬러</a> | <a href="https://is.mpg.de/">막스 플랑크 연구소</a> | <a href="https://www.inria.fr/en/inria-centre-rennes-university">INRIA 렌</a>
        <br>
        <strong>SIGGRAPH Asia 2024 컨퍼런스 논문</strong>
    </p>
    <p align="center">
        <a href="https://kelianb.github.io/SPARK/" style="padding-left: 0.5rem;">
            <img src="https://img.shields.io/badge/Project-Page-blue?style=flat&logo=Google%20chrome&logoColor=blue" alt="프로젝트 페이지">
        </a>
        <a href="https://dl.acm.org/doi/10.1145/3680528">
            <img src="https://img.shields.io/badge/Paper-red" alt="PDF">
        </a>
        <a href="https://arxiv.org/abs/2409.07984">
            <img src="https://img.shields.io/badge/Arxiv-red" alt="arxiv PDF">
        </a>
    </p>
    <p align="center">
        <img src="https://raw.githubusercontent.com/KelianB/SPARK/main/assets/teaser.webp" width="98%" />
    </p>
</p>

## 인용문헌

저희 코드나 논문이 유용하다고 생각되시면, 다음과 같이 인용해 주세요:

```bibtex
@inproceedings{baert2024spark,
  title = {{SPARK}: Self-supervised Personalized Real-time Monocular Face Capture},
  author = {Baert, Kelian and Bharadwaj, Shrisha and Castan, Fabien and Maujean, Benoit and Christie, Marc and Abrevaya, Victoria and Boukhayma, Adnane},
  year = {2024},
  month = dec,
  booktitle = {SIGGRAPH Asia 2024 Conference Proceedings},
  articleno = {113},
  doi = {10.1145/3680528.3687704},
  isbn = {979-8-4007-1131-2/24/12},
  publisher = {Association for Computing Machinery},
  address = {New York, NY, USA},
  numpages = {12},
  url = {https://kelianb.github.io/SPARK/},
}
```
## 설치

<details>
    <summary>세부사항</summary>

- [setup.sh](https://raw.githubusercontent.com/KelianB/SPARK/main/./setup.sh)를 사용하여 환경을 만듭니다.
- [TrackerAdaptation/setup_submodules.sh](https://raw.githubusercontent.com/KelianB/SPARK/main/./TrackerAdaptation/setup_submodules.sh)를 실행합니다. 몇 분 정도 걸릴 수 있습니다.
- MultiFLARE의 FLAME을 EMOCA에 연결합니다: `ln TrackerAdaptation/submodules/EMOCA/assets/FLAME/geometry/generic_model.pkl MultiFLARE/assets/flame/flame2020.pkl`
    - 이는 [FLAME](https://flame.is.tue.mpg.de/download.php) (2020 버전)을 다운로드하고 압축을 푼 후 `generic_model.pkl`을 `./MultiFLARE/assets/flame/flame2020.pkl`에 복사하는 것과 같습니다.
- FLAME에 맞게 조정된 Basel Face Model 텍스처 공간을 구합니다. 라이선스 문제로 텍스처 공간을 배포할 수 없습니다. 따라서 이 [레포](https://github.com/TimoBolkart/BFM_to_FLAME)의 도구를 사용하여 텍스처 공간을 FLAME으로 변환하십시오. 변환된 텍스처 모델 파일을 `TrackerAdaptation/submodules/EMOCA/assets/FLAME/texture/FLAME_albedo_from_BFM.npz`에 넣으십시오.

SPARK는 NVIDIA RTX A5000 (24GB) 또는 RTX A4000 (16GB) GPU에서 테스트되었습니다. 배치 크기를 줄이면 메모리가 적은 GPU에서도 학습이 가능합니다.

</details>

## 데이터셋

자신의 데이터를 전처리하려면 [MonoFaceCompute](https://github.com/KelianB/MonoFaceCompute) 레포를 참조하십시오.

## 사용법

SPARK는 2단계 접근법입니다. 먼저 [MultiFLARE](./MultiFLARE/)를 실행하여 여러 비디오에서 3D 얼굴 아바타를 재구성합니다. 그 다음, [TrackerAdaptation](./TrackerAdaptation/)을 사용하여 기존 3D 얼굴 트래커를 아바타에 맞게 적응시켜 전이 학습을 통해 실시간 추적을 수행합니다.

<details>
    <summary>세부사항</summary>

### 1. MultiFLARE


```bash
cd MultiFLARE
python train.py --config configs/example.txt

# Export neutral mesh
python export_mesh.py --config configs/example.txt --resume 3000 --out_dir /tmp/example_mesh --tex_type albedo
```
제공된 예제 구성에서 시작하여 `input_dir`, `train_dir` 및 `output_dir`를 수정하는 것을 권장합니다. 모든 매개변수 목록은 [arguments.py](https://raw.githubusercontent.com/KelianB/SPARK/main/./MultiFLARE/arguments.py) 또는 `python train.py --help` 명령어 출력에서 확인할 수 있습니다. 매개변수는 구성 파일이나 명령줄 인수로 전달할 수 있습니다.

### 2. TrackerAdaptation


```bash
cd TrackerAdaptation
# DECA encoder + MultiFLARE decoder
python train.py --config configs/example_deca.txt
# EMOCA encoder + MultiFLARE decoder
python train.py --config configs/example_emoca.txt
# SMIRK encoder + MultiFLARE decoder (recommended!)
python train.py --config configs/example_smirk.txt
# EMOCA encoder + EMOCA decoder (baseline)
python train.py --config configs/example_emoca_baseline.txt

# Quantitative eval
python evaluate.py --config configs/example_smirk.txt --tracker_resume 3000 --frame_interval 5 --num_frames 64

# Visualization videos
python make_comparison_video.py --config configs/example_smirk.txt --tracker_resume 3000 --test_dirs 5 6 --n_frames 1000 --smooth_crops --framerate 24
python make_overlay_video.py --config configs/example_smirk.txt --tracker_resume 3000 --test_dirs 2 --out test_beard --texture /path/to/texture.png --n_frames 1000 --smooth_crops --framerate 24
```
</details>

## 라이선스 정보

이 저장소의 코드는 여러 라이선스가 적용됩니다.

1. **원본 코드** (Technicolor Group & INRIA Rennes)
   - 특별히 명시된 경우를 제외하고, 이 저장소의 모든 코드는 [CC BY-NC-SA 라이선스](./LICENSE)에 따라 라이선스가 부여됩니다.

2. **서드파티 코드** (Max Planck Institute for Intelligent Systems)
   - 위치: `./MultiFLARE/flame`, `./MultiFLARE/flare`, `./TrackerAdaptation/submodules`
   - 이 디렉터리들은 Max Planck Institute의 코드가 포함되어 있으며 일부 수정이 있습니다. [MPI 라이선스](./LICENSE_MPI)를 주의 깊게 읽어 주시고, 이는 **비상업적 과학 연구 목적**에만 사용 가능함을 참고하시기 바랍니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-19

---