<h1 align="center">
  단백질-단백질 상호작용 언어 학습
</h1>

## 🌿 MINT 개요

MINT (Multimeric INteraction Transformer)는 상호작용하는 단백질 서열의 **맥락적이고 확장 가능한** 모델링을 위해 설계된 단백질 언어 모델(PLM)입니다. STRING 데이터베이스에서 선별된 **9,600만 개의 단백질-단백질 상호작용(PPI)** 데이터로 훈련된 MINT는 다음을 포함한 다양한 작업과 단백질 유형에서 기존 PLM을 능가합니다:

- 결합 친화도 예측
- 돌연변이 영향 추정
- 복합 단백질 조립 모델링
- 항체-항원 상호작용 모델링
- T 세포 수용체–에피토프 결합 예측

🔬 **왜 MINT인가?**

✅ 대규모 PPI 데이터로 훈련된 최초의 PLM

✅ 다중 PPI 작업에서 최첨단 성능

✅ 다양한 단백질 상호작용에 대해 확장 가능하고 적응 가능

## 🖥️ 설치 

1. 제공된 `enviroment.yml` 파일로부터 새로운 [conda](https://docs.anaconda.com/miniconda/install/) 환경을 만드세요.

```
conda env create --name mint --file=environment.yml
```
2. 환경을 활성화하고 소스에서 패키지를 설치합니다.


```
conda activate mint
pip install -e .
```
3. 패키지를 가져올 수 있는지 확인하십시오.


```
python -c "import mint; print('Success')" 
```
4. 모델 체크포인트를 다운로드하고 저장된 파일 경로를 기록하십시오.


```
wget https://huggingface.co/varunullanat2012/mint/resolve/main/mint.ckpt
```
## 🚀 사용 방법

### 임베딩 생성

상호작용하는 서열이 포함된 CSV 파일에서 임베딩을 생성하는 것을 권장합니다. 예시는 [여기](https://raw.githubusercontent.com/VarunUllanat/mint/main/./data/protein_sequences.csv)에 있습니다. 다음으로, 모든 입력 서열에 대한 평균 임베딩을 얻기 위해 아래 코드를 실행하면 됩니다. 


```
import torch
from mint.helpers.extract import load_config, CSVDataset, CollateFn, MINTWrapper

cfg = load_config("data/esm2_t33_650M_UR50D.json") # model config
device = 'cuda:0' # GPU device
checkpoint_path = '' # Where you stored the model checkpoint

dataset = CSVDataset('data/protein_sequences.csv', 'Protein_Sequence_1', 'Protein_Sequence_2')
loader = torch.utils.data.DataLoader(dataset, batch_size=2, collate_fn=CollateFn(512), shuffle=False) 

wrapper = MINTWrapper(cfg, checkpoint_path, device=device)

chains, chain_ids = next(iter(loader)) # Get the first batch
chains = chains.to(device)
chain_ids = chain_ids.to(device)
embeddings = wrapper(chains, chain_ids)  # Generate embeddings
print(embeddings.shape) # Should be of shape (2, 1280)
```
그러나, 하위 작업에서 최대 성능을 위해 래퍼 클래스에서 `sep_chains=True` 인수를 사용하는 것을 **권장**합니다. 이는 **모든 시퀀스**에 대한 시퀀스 수준 임베딩을 얻고, 입력과 동일한 순서로 연결하여 반환합니다. 


```
wrapper = MINTWrapper(cfg, checkpoint_path, sep_chains=True, device=device)

chains, chain_ids = next(iter(loader)) # Get the first batch
chains = chains.to(device)
chain_ids = chain_ids.to(device)
embeddings = wrapper(chains, chain_ids)  # Generate embeddings
print(embeddings.shape) # Should be of shape (2, 2560)
```
### 이진 PPI 분류

우리는 두 입력 시퀀스가 상호작용하는지 여부를 예측하는 코드와 [모델 체크포인트](https://huggingface.co/varunullanat2012/mint/blob/main/bernett_mlp.pth)를 제공합니다. 다운스트림 모델인 MLP는 [Bernett et al.](./downstream/GeneralPPI/ppi)의 골드 스탠다드 데이터를 사용하여 훈련되었습니다.


```
import torch
from mint.helpers.extract import load_config, CSVDataset, CollateFn, MINTWrapper
from mint.helpers.predict import SimpleMLP

cfg = load_config("data/esm2_t33_650M_UR50D.json") # model config
device = 'cuda:0' # GPU device
checkpoint_path = 'mint.ckpt' # Where you stored the model checkpoint
mlp_checkpoint_path = 'bernett_mlp.pth' # Where you stored the Bernett MLP checkpoint

dataset = CSVDataset('data/protein_sequences.csv', 'Protein_Sequence_1', 'Protein_Sequence_2')
loader = torch.utils.data.DataLoader(dataset, batch_size=2, collate_fn=CollateFn(512), shuffle=False) 

wrapper = MINTWrapper(cfg, checkpoint_path, sep_chains=True, device=device)

# Generate embeddings 
chains, chain_ids = next(iter(loader)) 
chains = chains.to(device)
chain_ids = chain_ids.to(device)
embeddings = wrapper(chains, chain_ids) # Should be of shape (2, 2560)

# Predict using trained MLP
model = SimpleMLP() 
mlp_checkpoint = torch.load(mlp_checkpoint_path)
model.load_state_dict(mlp_checkpoint)
model.eval()
model.to(device)

predictions = torch.sigmoid(model(embeddings)) # Should be of shape (2, 1)
print(predictions) # Probability of interaction (0 is no, 1 is yes)
```

### 미세조정

새로운 감독 학습 데이터셋에 대해 모델을 미세조정하려면 `freeze_percent` 매개변수를 1이 아닌 값으로 설정하세요. 0.5로 설정하면 모델 레이어의 마지막 50%가 학습될 수 있습니다. 예를 들어, 

```
import torch
from mint.helpers.extract import MINTWrapper

cfg = load_config("data/esm2_t33_650M_UR50D.json") # model config
device = 'cuda:0' # GPU device
checkpoint_path = '' # path where you stored the model checkpoint

wrapper = MINTWrapper(cfg, checkpoint_path, freeze_percent=0.5, device=device)
for name, param in wrapper.model.named_parameters():
    print(f"Parameter: {name}, Trainable: {param.requires_grad}")
```
### STRING-DB에서 사전 학습하기

이 섹션에서는 STRING-DB의 PPI를 사용하여 MINT를 사전 학습하는 데 필요한 단계를 설명합니다. 먼저, 우리가 사용한 학습-검증 분할을 만들기 위해 [STRING-DB](https://stringdb-downloads.org/download/)에서 `protein.physical.links.v12.0.txt.gz`와 `protein.sequences.v12.0.fa.gz`를 다운로드합니다. 

그런 다음, [mmseqs](https://github.com/soedinglab/MMseqs2)를 사용하여 50% 서열 유사도 임계값으로 서열을 클러스터링하기 위해 다음 명령어를 실행합니다.


```
mmseqs createdb protein.sequences.v12.0.fa DB100
mmseqs cluster DB100 clu50 /tmp/mmseqs --min-seq-id 0.50 --remove-tmp-files
mmseqs createtsv DB100 DB100 clu50 clu50.tsv
```

그런 다음, `stringdb.py`를 실행하되, 해당 스크립트 내의 파일 경로가 `protein.sequences.v12.0.fa`, `clu50.tsv`(이전 단계의 출력물), 및 `protein.physical.links.full.v12.0.txt.gz` 파일을 저장한 경로와 일치하는지 확인하세요. 

마지막으로, 다음과 같이 학습을 실행합니다:

```
python train.py --batch_size 2 --crop_len 512 --model 650M --val_check_interval 320000 --accumulate_grad 32 --run_name 650M_nofreeze_filtered --copy_weights --wandb --dataset_split filtered
```

### 예제

우리는 `downstream` 폴더에 다양한 감독 학습 과제와 단백질 유형에 대한 MINT 사용 사례를 강조하는 여러 예제를 제공합니다.

1. [두 단백질이 상호작용하는지 여부 예측](./downstream/GeneralPPI/ppi)
2. [단백질 복합체의 결합 친화도 예측](./downstream/GeneralPPI/pdb-bind)
3. [돌연변이 후 두 단백질이 상호작용하는지 여부 예측](./downstream/GeneralPPI/mutational-ppi)
4. [돌연변이 시 단백질 복합체의 결합 친화도 차이 예측](./downstream/GeneralPPI/SKEMPI_v2)


## 📝 인용하기 

```
@article{ullanat2026learning,
  title={Learning the language of protein-protein interactions},
  author={Ullanat, Varun and Jing, Bowen and Sledzieski, Samuel and Berger, Bonnie},
  journal={Nature Communications},
  year={2026},
  publisher={Nature Publishing Group UK London}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-10

---