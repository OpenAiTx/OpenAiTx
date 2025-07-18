<translate-content># 어조인트 샘플링

이 저장소는 어조인트 샘플링: 어조인트 매칭을 통한 고확장성 확산 샘플러의 공식 구현 및 실험을 포함합니다.

어조인트 샘플링은 기준 데이터 없이 정규화되지 않은 밀도에서 샘플링하는 법을 학습하는 고확장성 확산 기반 샘플링 프레임워크입니다. 어조인트 샘플링은 생성 모델과 에너지 함수 모두의 복잡성에 대해 확장 가능하여 최첨단 신경 에너지 함수를 사용할 수 있습니다.

**[Arxiv](https://arxiv.org/abs/2504.11713) (ICML 2025 채택)**  
*저자: _아론 헤이븐스, 벤자민 커트 밀러, 빙 얀, 카를레스 도밍고-엔리치, 아누룹 스리람, 브랜든 우드, 다니엘 레빈, 빈 후, 브랜든 아모스, 브라이언 카러, 샹 푸, 관-홍 리우, 리키 T. Q. 첸_*

![](https://raw.githubusercontent.com/facebookresearch/adjoint_sampling/main/./assets/molecule_progression.png)

우리는 eSEN 에너지 함수와 SPICE를 사용하여 새로운 암토라이즈드 컨포머 생성 작업에서 어조인트 샘플링을 평가합니다. SPICE는 원자 종과 결합 구조를 포함한 분자 그래프 정보를 제공하는 유기 및 약물 유사 분자의 대규모 데이터셋입니다.

## 설치

의존성 설치.</translate-content>

```bash
micromamba env create -f environment.yml
micromamba activate adjoint_sampling
```
에너지 모델에 대해 학습하려면, [Hugging Face 저장소](https://huggingface.co/facebook/adjoint_sampling)에서 [eSEN](https://arxiv.org/abs/2502.12147) 체크포인트가 필요합니다. 코드를 실행할 때 `huggingface-cli`에 [토큰](https://huggingface.co/settings/tokens)을 제공하면 자동으로 다운로드됩니다.  
토큰이 작동하려면 먼저 [저장소 접근 권한을 신청](https://huggingface.co/facebook/adjoint_sampling)해야 합니다.
```bash
huggingface-cli login
```
## 데이터

분자는 `data/{drugs_test,spice_test,spice_train}.txt`의 행으로 조직되어 있으며 세 개의 열로 구성됩니다: 회전 가능한 결합 수, SMILES 문자열, 그리고 해시. 분자의 [CREST](https://github.com/crest-lab/crest) 컨포머를 찾으려면 해시가 필요합니다. `{drugs,spice}` 분자의 `${hash}`에 대해 컨포머는 디렉터리 `data/{drugs,spice}_test_conformers/${hash}` 아래 단일 텍스트 파일에 연결된 `.xyz` 블록으로 기록됩니다.

`drugs`의 컨포머는 [GEOM](https://github.com/learningmatter-mit/geom)에서 가져왔습니다. `spice`의 컨포머는 FAIR Chemistry에서 계산했습니다.

## 모델

모든 모델은 [Hugging Face](https://huggingface.co/facebook/adjoint_sampling)에 호스팅되어 있습니다. 로컬 디렉터리 `models`에 파일을 다운로드하는 스크립트를 제공합니다. 모델 다운로드를 위해서는 [토큰](https://huggingface.co/settings/tokens)이 필요합니다. 다운로드하기 전에 먼저 [리포지토리 접근 권한을 신청](https://huggingface.co/facebook/adjoint_sampling)해야 합니다.


```bash
python download_models.py
```
모델이 다운로드되면 평가나 자신의 프로젝트에 사용할 경로를 복사할 수 있습니다. 체크포인트는 다음과 같이 식별할 수 있습니다:

```
Cartesian AdjSampling             -   models/am/checkpoints/checkpoint_4999.pt
Cartesian AdjSampling (+pretrain) -   models/bmam/checkpoints/checkpoint_4999.pt
Torsional AdjSampling             -   models/torsion/checkpoints/checkpoint_3000.pt

Pretrained Cartesian              -   pretrain_for_bmam/checkpoints/checkpoint_2000.pt
```
We provide `Pretrained Cartesian` for the purposes of training `Cartesian AdjSampling (+pretrain)`.


## Training on the SPICE datset

We trained each model using 8 gpus over 72 hours. These commands will train the corresponding model.

Run the following commands on a single node with many cpus **before** starting training! The second one is only necessary if you would like to train the Torsional AdjSampling model.
```bash
python cache_dataset.py
python cache_dataset.py --learn_torsions
```
<translate-content>
저희 저장소는 공유 파일이 `shared_dir`로 알려진 공유 디렉터리에 배치되는 분산 학습을 지원합니다. 기본값은 `/home/${oc.env:USER}`로 설정되어 있습니다. 이는 [hydra](https://hydra.cc/docs/intro/)의 변수 확장 구문으로 인해 학습 시 `/home/${USER}`로 평가됩니다.

##### 카르테시안 AdjSampling</translate-content>
```bash
python train.py experiment=spice_cartesian
```
##### Cartesian AdjSampling (+pretrain)

이 모델은 순차적 훈련이 필요합니다. 먼저 첫 번째 명령어를 사용하여 "사전 학습된" 모델을 훈련해야 합니다. 그런 다음 두 번째 모델을 첫 번째 모델에서 초기화하도록 `init_model=...`을 사용하여 초기 체크포인트를 가리켜야 합니다. `init_model`을 가리키지 않아도 오류가 발생하지 않지만, 모델은 사전 학습되지 않습니다.


```bash
python train.py experiment=spice_cartesian_pretrain_for_bmam
python train.py experiment=spice_cartesian_bmam init_model=???
```
##### 비틀림 AdjSampling

```bash
python train.py experiment=spice_torsion
```
<translate-content>

## 평가
학습된 모델을 평가하려면 `eval.py`를 사용하세요. 보고된 결과는 `max_n_refs`를 512로 설정했습니다.
</translate-content>
```bash
python eval.py \
--test_mols data/spice_test.txt \
--true_confs data/spice_test_conformers \
--save_path results \
--checkpoint_path path/to/checkpoint.pt \
--max_n_refs 512
```
분산 방식으로도 평가가 가능합니다, `eval_distributed.sh`를 확인하세요.


## 📚 인용

이 코드를 연구나 프로젝트에 유용하게 사용하셨다면, 저희 연구 논문을 인용해 주시기 바랍니다:


```bibtex
@article{adjoint_sampling,
  title={{A}djoint {S}ampling: Highly Scalable Diffusion Samplers via {A}djoint {M}atching},
  author={Havens, Aaron and Miller, Benjamin Kurt and Yan, Bing and Domingo-Enrich, Carles and Sriram, Anuroop and Wood, Brandon and Levine, Daniel and Hu, Bin and Amos, Brandon and Karrer, Brian and Fu, Xiang and Liu, Guan-Horng and Chen, Ricky T. Q.},
  journal={International Conference on Machine Learning},
  year={2025}
}
```
## License
이 저장소는
[CC BY-NC 4.0 라이선스](https://creativecommons.org/licenses/by-nc/4.0/)에 따라 라이선스가 부여됩니다.

### 공지
대부분의 Adjoint Sampling은 CC-BY-NC 라이선스 하에 있지만, 프로젝트의 일부는 별도의 라이선스 조건으로 제공됩니다: [DEM](https://github.com/jarridrb/DEM), [EGNN](https://github.com/vgsatorras/egnn), [torsional-diffusion](https://github.com/gcorso/torsional-diffusion), [fairchem](https://github.com/FAIR-Chem/fairchem)은 MIT 라이선스 하에 있습니다. [SPICE](https://github.com/openmm/spice-dataset)와 [GEOM](https://github.com/learningmatter-mit/geom)은 CC0 라이선스 하에 있습니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---