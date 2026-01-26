## PSICHIC: 단백질-리간드 상호작용 지문 학습을 위한 물리화학적 그래프 신경망 [[Nature Machine Intelligence](https://www.nature.com/articles/s42256-024-00847-1)]

<img src="https://raw.githubusercontent.com/huankoh/PSICHIC/main/image/PSICHIC.jpg" width="500"/>

## PSICHIC 웹서버 <a href="http://www.psichicserver.com" target="_blank"><img src="https://raw.githubusercontent.com/huankoh/PSICHIC/main/image/crystal_ball.png" alt="PSICHIC Webserver" width="30"/></a>

신나는 소식❗ PSICHIC 웹서버(베타 버전)가 이제 사용 가능합니다! 🚀 [www.psichicserver.com](https://www.psichicserver.com/)에서 단백질-리간드 상호작용 분석의 미래를 경험해보세요.

_지금 탐색을 시작하세요. 당신의 다음 발견이_ 🌐🔬 _단 몇 번의 클릭 거리에 있을지도 모릅니다!_

<sub>참고: 이 서버는 논문과 공식적으로 연관되어 있지 않습니다. 공식 버전은 아래 Colab 및 로컬 배포 설정을 참고하세요.</sub>

## PSICHIC 가상 스크리닝 플랫폼 <a href="https://colab.research.google.com/github/huankoh/PSICHIC/blob/main/PSICHIC.ipynb" target="_parent"><img src="https://colab.research.google.com/assets/colab-badge.svg" alt="Open In Colab"/></a>

- **오직 서열 데이터만**: 단백질 서열 + 리간드 SMILES 쌍만 있으면 됩니다.
- **빠른 스크리닝**: 한 시간에 최대 10만 개 화합물 처리 가능.
- **심층 분석**: PSICHIC 기반의 약효기 및 표적 돌연변이 분석으로 분자적 통찰력 발견.

**업데이트:** 선택성 프로파일링 시연을 위해 선택성 폴더 내에 주피터 노트북을 추가했습니다.

## PSICHIC 로컬 배포 환경 설정
<details>
<summary>PSICHIC 로컬 개발 내용 보기/숨기기</summary>


현재 PSICHIC는 MacOS(OSX), Linux 및 Windows에서 사용 검증되었습니다. conda를 통한 설치를 권장하며, 더 빠른 mamba 패키지 및 환경 관리자를 사용하는 것이 좋습니다. mamba는 ``conda install mamba -n base -c conda-forge`` 명령어로 설치할 수 있습니다. conda 또는 mamba를 이용한 설치 방법은 아래 관련 코드 라인을 참고하세요.

```
## OSX 
conda env create -f environment_osx.yml  # if mamba: mamba env create -f environment_osx.yml
## LINUX or Windows GPU
conda env create -f environment_gpu.yml # if mamba: mamba env create -f environment_gpu.yml
conda activate psichic_fp
pip install torch_scatter torch_sparse torch_cluster torch_spline_conv -f https://data.pyg.org/whl/torch-2.1.0+cu118.html
## LINUX or Windows CPU
conda env create -f environment_cpu.yml  # if mamba: mamba env create -f environment_cpu.yml
conda activate psichic_fp
pip install torch_scatter torch_sparse torch_cluster torch_spline_conv -f https://data.pyg.org/whl/torch-2.1.0+cpu.html
```

대안으로, 환경 설정에 도움이 될 수 있는 명령줄(리눅스에서 파이썬 3.8로 테스트됨). 
```
conda create --name psichic_fp python=3.8
conda install pytorch==2.0.0 torchvision==0.15.0 torchaudio==2.0.0 pytorch-cuda=11.7 -c pytorch -c nvidia
conda install pyg -c pyg
conda install -c conda-forge rdkit==2022.09.5
pip install scipy biopython pandas biopandas timeout_decorator py3Dmol umap-learn plotly mplcursors lifelines reprint
pip install "fair-esm"
```
## 주석이 달린 서열 데이터로 BYO-PSICHIC

데이터폴더에 train, valid, test csv 파일을 만드세요 (예시는 dataset 폴더 참조). 데이터폴더에는 최소한 train.csv와 test.csv 파일이 있어야 합니다. 주석 라벨에 따라, 연속 값 라벨(예: 결합 친화도)인 경우 ``--regression_task True``를, 이진 클래스 라벨(예: 상호작용 존재 여부)인 경우 ``--classification_task True``를, 다중 클래스 라벨의 클래스 수가 C일 경우(예: 단백질-리간드 기능 반응 데이터셋 사용 시 3) ``--mclassification_task C``를 사용하세요. 참고로, 여러 라벨 유형을 포함하는 데이터셋도 가능하며, 우리는 PSICHIC을 사용해 여러 단백질-리간드 상호작용 특성 예측을 학습할 수 있습니다 (아래 PSICHIC-MultiTask 참조).


```
python main.py --datafolder annotated_folder --result_path result/annotated_result --regression_task True 
```

예를 들어, PDBBind v2020 벤치마크와 같은 벤치마크 데이터셋을 사용한 BYO-PSICHIC:
```
python main.py --datafolder dataset/pdb2020 --result_path result/PDB2020_BENCHMARK --regression_task True 
```
모델 및 옵티마이저 구성은 모든 벤치마크 데이터셋에서 일관되나, PDBBind v2016에서는 옵티마이저의 학습 반복 횟수, betas 및 eps를 각각 30000, "(0.9,0.99)", 1e-5로 변경하고자 할 경우, 명령어에 다음을 추가합니다: ``--total_iters 30000 --betas "(0.9,0.99)" --eps 1e-5``. 이진 분류 작업의 경우 ``--regression_task True``를 ``--classification_task True``로 대체하세요. 단백질 기능 효과 데이터셋의 경우 ``--regression_task True``를 ``--mclassification_task 3``으로 바꾸세요. config.json 파일에서 모델 하이퍼파라미터를 자유롭게 조정해 보시고, 흥미로운 결과가 있으면 알려주세요!


## 데이터셋 구조 및 BYO 포맷 가이드라인
논문에서 참조한 모든 데이터셋은 구글 드라이브에서 사용할 수 있습니다 ([데이터셋](https://drive.google.com/drive/folders/1ZRpnwXtllCP89hjhfDuPivBlarBIXnmu?usp=sharing)). PSICHIC의 벤치마크 평가에 사용된 데이터셋은 기존 분할 설정에 따라 생성된 train, valid, test CSV 파일이 있습니다. 데이터셋 섹션 내 별도의 README.md 파일은 구글 드라이브 링크의 각 데이터셋 목적을 설명하며 (이는 논문의 Extended Data Table 1과 유사합니다).


BYO-PSICHIC 데이터셋: BYO-PSICHIC 학습에 관심이 있다면 각 파일은 대략 다음과 같은 형식이어야 합니다. 검증 CSV 파일이 없는 경우, 예를 들어 외부 실험에 결과를 적용할 계획이라면 반드시 필요하지 않습니다.

__결합 친화도 회귀__

| 단백질 | 리간드 | 회귀_레이블 | 
|:----------:|:----------:|:----------:|
| ISAFQAAYIGIE....  | C1CCCCC1  | 6.7 | 
| GGALVSVISAFQASV....  | O=C(C)Oc1ccccc1C(=O)O | 4.0 |
|...|...| ...|
| MIPSAYIGIEVLI... | CCO | 8.1 | 
```
python main.py --datafolder BYO_DATASET --result_path BYO_RESULT --regression_task True 
```

__이진 상호작용 분류__

| 단백질 | 리간드 | 분류_라벨 | 
|:----------:|:----------:|:----------:|
| ISAFQAAYIGIE....  | C1CCCCC1  | 1 | 
| GGALVSVISAFQASV.... | O=C(C)Oc1ccccc1C(=O)O | 0 |
|...|...| ...|
| MIPSAYIGIEVLI.... | CCO | 1 | 

```
python main.py --datafolder BYO_DATASET --result_path BYO_RESULT --classification_task True
```

__기능적 효과 분류 (삼분류)__

| 단백질 | 리간드 | 다중 클래스 라벨 | 
|:----------:|:----------:|:----------:|
| ISAFQAAYIGIE....  | C1CCCCC1  | -1 |  # 길항제
| GGALVSVISAFQASV.... | O=C(C)Oc1ccccc1C(=O)O | 0 | # 비결합체
|...|...| ...|
| MIPSAYIGIEVLI.... | CCO | 1 | # 작용제

```
python main.py --datafolder BYO_DATASET --result_path BYO_RESULT --mclassification_task 3
```

__멀티 태스크 PSICHIC__

| 단백질 | 리간드 | 회귀_레이블 | 다중 클래스_레이블 | 
|:----------:|:----------:|:----------:|:----------:|
| ISAFQAAYIGIE....  | C1CCCCC1  | 6.7 | -1 |  # 길항제
| GGALVSVISAFQASV....  | O=C(C)Oc1ccccc1C(=O)O | 4.0 | 0 | # 비결합체
|...|...| ...|
| MIPSAYIGIEVLI.... | CCO | 8.1 | 1 | # 작용제

```
python main.py --datafolder BYO_DATASET --result_path BYO_RESULT --regression_task True --mclassification_task 3
```
**전략적으로 데이터셋 분할하기?** 데이터셋 폴더 내 Jupyter 노트북은 PSICHIC 또는 기타 방법의 일반화 가능성을 평가하기 위해 무작위 분할, 미관측 단백질 분할, 미관측 리간드 스캐폴드 분할을 수행하는 방법을 보여줍니다. 이는 BYO-PSICHIC이 귀하의 주석된 서열 데이터에서 작동하는지 평가하는 데 유용할 수 있습니다.
 
## PSICHIC<sub>XL</sub>: 대규모 상호작용 데이터셋에서의 다중 작업 예측 학습
PSICHIC<sub>XL</sub>은 이전에 사전 학습된 다중 작업 PSICHIC으로 불렸습니다. PSICHIC<sub>A1R</sub>은 이전에 미세 조정된 다중 작업 PSICHIC으로 불렸습니다. PSICHIC<sub>XL</sub>이 추가 학습 없이도 그대로 사용할 수 있음을 명확히 하기 위해 이름을 변경했습니다. 그러나 PSICHIC<sub>XL</sub>은 특정 단백질 타겟에 특화된 데이터로 미세 조정될 경우, 예를 들어 아래에서 A<sub>1</sub>R 관련 데이터를 사용해 보여주는 PSICHIC<sub>A<sub>1</sub>R</sub>처럼 가상 스크리닝에서 순위 능력을 향상시킬 수 있습니다.

### PSICHIC<sub>XL</sub> 학습 (사전 인쇄본에서 사전 학습된 PSICHIC라고도 함)

```
python main.py --datafolder dataset/large_scale_interaction_dataset --result_path PSICHIC_MultiTask_Pretrain --lrate 1e-5 --sampling_col pretrain_sampling_weight --regression_task True --mclassification_task 3 --total_iters 300000 --evaluate_step 25000
```
### PSICHIC<sub>XL</sub>을 PSICHIC<sub>A<sub>1</sub>R</sub>로 미세조정 (일명 사전출판본에서 미세조정된 PSICHIC)
다음 명령어를 사용하여 A<sub>1</sub>R 관련 단백질에 대해 PSICHIC<sub>XL</sub>의 응용 계층만 1000회 반복하여 미세조정합니다:
```
python main.py --regression_task True --mclassification_task 3 --datafolder dataset/A1R_FineTune --result_path PSICHIC_A1R_FineTune --lrate 1e-5 --total_iters 1000 --finetune_modules "['reg_out','mcls_out']" --trained_model_path trained_weights/multitask_PSICHIC
```
우리는 광범위한 상호작용 데이터셋으로 학습된 PSICHIC 버전을 PSICHIC<sub>XL</sub>로, A<sub>1</sub>R 데이터에 중점을 둔 하위 집합을 PSICHIC<sub>A<sub>1</sub>R</sub>로 이름을 변경했습니다. 이전에는 PSICHIC<sub>XL</sub>과 PSICHIC<sub>A<sub>1</sub>R</sub>가 각각 사전 학습된 PSICHIC와 미세 조정된 PSICHIC로 알려져 있었습니다. 이 변경은 PSICHIC<sub>XL</sub>의 광범위한 적용성과 PSICHIC<sub>A<sub>1</sub>R</sub>의 A1R에 대한 특정 강조를 보다 정확하게 반영합니다.

다른 단백질의 경우, 관련 없는 단백질과 대규모 상호작용 데이터셋 내의 비결합자를 필터링하여 PSICHIC를 다른 실험에 적용할 수 있습니다.
</details>



## 참고 문헌

자세한 내용은 저희 연구를 참조하시기 바랍니다: 

```
PSICHIC: physicochemical graph neural network for learning protein-ligand interaction fingerprints from sequence data
Huan Yee Koh, Anh T.N. Nguyen, Shirui Pan, Lauren T. May, Geoffrey I. Webb
bioRxiv 2023.09.17.558145; doi: https://doi.org/10.1101/2023.09.17.558145
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-26

---