<div align="center">

# 직접 미분 가능한 메시 학습을 위한 2D 삼각형 스플래팅

[Arxiv][1] | [프로젝트 페이지][4]

Kaifeng Sheng*, Zheng Zhou*, Yingliang Peng, Qianwei Wang (*동등 기여)

Amap, 알리바바 그룹

</div>

## - 프로젝트 개요

[2DTS][1] (직접 미분 가능한 메시 학습을 위한 2D 삼각형 스플래팅)의 공식 구현체

우리는 [3DGS][2] (3D 가우시안 스플래팅)에서 가우시안 원시 요소를 삼각형으로 대체하면서 모델의 완전한 미분 가능성을 유지하는 차별화된 3D 기하학적 표현 2DTS를 위한 완전한 학습 파이프라인을 제공합니다.  
제안하는 방법은 엔드투엔드 학습 파이프라인을 통해 높은 시각적 충실도를 가진 삼각형 메시를 생성할 수 있습니다.

![demo_image](https://raw.githubusercontent.com/GaodeRender/triangle-splatting/main/./assets/demo_image.png)

우리 방법은 6000장 이상의 이미지를 포함하는 MatrixCity와 같은 대규모 데이터셋에 적용할 수 있습니다. 이러한 데이터셋은 기존 메시 재구성 방법에 도전적이지만, 우리 방법은 효율적으로 처리할 수 있습니다.  
재구성된 메시들은 Blender와 같은 최신 게임 엔진에서 리라이팅, 그림자 렌더링 및 기타 고급 렌더링 효과에 바로 사용할 수 있습니다. 아래 이미지는 MatrixCity 데이터셋에서 재구성된 메시의 리라이팅 효과 예시입니다:

![relighting_image](https://raw.githubusercontent.com/GaodeRender/triangle-splatting/main/./assets/relighting_image.png)

## - 초록

3D 가우시안 원시 요소를 활용한 미분 가능 렌더링은 다중 뷰 이미지로부터 고충실도 3D 장면을 재구성하는 강력한 방법으로 부상했습니다.  
이는 NeRF 기반 방법보다 개선된 점이 있지만, 메시 기반 모델과 비교할 때 렌더링 속도 및 리라이팅, 그림자 렌더링과 같은 고급 렌더링 효과에서 여전히 한계가 있습니다.  
본 논문에서는 3D 가우시안 원시 요소를 2D 삼각형 면으로 대체하는 새로운 방법인 2D 삼각형 스플래팅(2DTS)을 제안합니다.  
이 표현은 연속 볼륨 모델링의 이점을 유지하면서 자연스럽게 이산 메시와 유사한 구조를 형성합니다.  
삼각형 원시 요소에 컴팩트니스 파라미터를 도입하여 포토리얼리스틱 메시를 직접 학습할 수 있도록 했습니다.  
실험 결과, 컴팩트니스 조정 없이 기본 버전의 삼각형 기반 방법이 최첨단 가우시안 기반 방법보다 더 높은 충실도를 달성함을 보여줍니다.  
더 나아가, 우리 접근법은 기존 메시 재구성 방법보다 우수한 시각적 품질의 재구성 메시를 생성합니다.

## - 설치

1. CUDA 12.4 이상 설치 (환경 변수 `CUDA_HOME`을 CUDA 설치 경로로 설정하는 것을 잊지 마세요);  
2. 저장소 복제: `git clone https://github.com/GaodeRender/diff_recon.git; cd diff_recon`;  
3. Python 3.12로 새 conda 환경 생성: `conda create -n 2dts python=3.12`;  
   환경 활성화: `conda activate 2dts`;  
4. 의존성 설치: `pip install -r requirements.txt --no-cache-dir`;  
5. 프로젝트 루트 디렉토리에서 `pip install . --no-cache-dir` 실행;

## - 사용법
### 학습
다음 명령어를 실행하여 Mip-NeRF 360, NerfSynthetic, Tanks and Temples, DeepBlending 또는 MatrixCity 데이터셋 중 하나에서 2DTS 모델을 학습합니다:

```bash
python run_experiments.py --type {experiment_type} --dataset_path /path/to/dataset --num_workers 0
```
`experiment_type`은 `MipNerf360`, `NerfSynthetic`, `NerfSynthetic_mesh`, `TanksAndBlending` 또는 `MatrixCity_mesh` 중 하나일 수 있습니다.

이 스크립트는 데이터셋이 미리 다운로드되어 있어야 하며, 데이터셋 경로는 데이터셋의 루트 디렉토리를 가리켜야 합니다.  
예를 들어, NerfSynthetic 데이터셋에서 메쉬 모델을 학습하고 싶고 데이터셋이 `./data/nerf_synthetic`에 저장되어 있다면, 다음 명령어를 실행할 수 있습니다:
```bash
python run_experiments.py --type NerfSynthetic_mesh --dataset_path ./data/nerf_synthetic --num_workers 0
```
### 로그  
학습 로그는 `./outputs` 디렉토리에 저장됩니다. 학습 과정을 시각화하려면 TensorBoard를 사용할 수 있습니다:

```bash
tensorboard --logdir ./outputs
```
### 렌더링  
학습된 삼각형 스플랫과 메시를 시각화하기 위해 [Viser Viewer][3] 기반의 인터랙티브 웹 뷰어를 제공합니다.  
다음 명령어를 실행하여 뷰어를 실행할 수 있습니다:

```bash
python viser_viewer.py --config /path/to/config --dataset_path /path/to/dataset --scene {scene_name}
```
예를 들어, `NerfSynthetic_mesh` 실험을 실행했고 `ship` 장면을 시각화하고 싶으며 데이터셋이 `./data/nerf_synthetic`에 저장되어 있다면, 다음 명령어를 실행할 수 있습니다:
```bash
python viser_viewer.py --config config/NerfSynthetic_VanillaTS_mesh.yaml --dataset_path ./data/nerf_synthetic --scene ship
```
그러면 웹 브라우저를 열고 `http://localhost:8080`으로 이동하여 렌더링된 장면을 확인하세요. 원격 서버에서 뷰어를 실행하는 경우, 포트 포워딩을 설정하거나 서버의 IP 주소에 직접 접속해야 합니다.

## - 참고 사항
두 가지 별개의 학습 구성을 제공합니다: VanillaTS와 VanillaTS_mesh.
- VanillaTS는 원본 3DGS 방법을 거의 모방한 것으로, 컴팩트니스 파라미터가 1.0으로 설정되어 투명하고 확산된 삼각형 스플랫을 생성합니다 ([2DTS][1] 참고).
- VanillaTS_mesh는 학습 과정에 불투명도 정규화와 컴팩트니스 조정을 추가하여 최종적으로 단단한 삼각형 메쉬를 생성합니다. 삼각형 메쉬는 출력 디렉토리에 `.glb` 파일로 저장됩니다. 학습 과정에서 **back_culling**이 **비활성화**된 경우, **메쉬 파일에는 각 삼각형이 <span style="color:red">두 번</span> 포함**되며, 앞면과 뒷면 각각 한 번씩 포함됩니다.

확산된 삼각형과 단단한 삼각형의 차이는 다음 이미지에서 시각화됩니다:

![triangle_splatting](https://raw.githubusercontent.com/GaodeRender/triangle-splatting/main/./assets/triangle_splatting.png) 

## - 해야 할 일

1. 본 방법은 조밀한 포인트 클라우드 초기화를 가정합니다. [3DGS][2]에서 사용된 조밀화 과정은 안정성 문제로 기본적으로 비활성화되어 있습니다. 새로운 조밀화 및 초기화 방법을 탐구 중이며, 이 분야에서의 기여를 환영합니다.
2. 현재 구현은 각 삼각형 스플랫에 대해 단일 불투명도와 색상/SH 파라미터 세트를 사용합니다. 그러나 모델을 확장하여 정점별 색상과 불투명도를 지원하는 것이 자연스러우며, 이는 모델의 표현력을 향상시킬 것입니다. 이 확장 작업을 진행 중입니다.

## - 라이선스

이 저장소에는 **두 가지 다른 라이선스**가 적용된 코드가 포함되어 있습니다:

- 🟥 **Gaussian Splatting 연구 라이선스** — 원본 [Gaussian Splatting][2] 프로젝트에서 파생된 구성 요소에 적용:
  - `submodules/custom-gaussian-rasterization/`
  - `submodules/simple-knn/`
  - 이 구성 요소들은 **비상업적 연구 용도로만** 라이선스가 부여됩니다.
  - 자세한 내용은 [LICENSE.gausplat.md](https://raw.githubusercontent.com/GaodeRender/triangle-splatting/main/./LICENSE.gausplat.md) 참조

- 🟩 **MIT 라이선스** — 저장소의 다른 부분에 적용, 포함:
  - `src/diff_recon/`
  - `submodules/diff-triangle-rasterization-2D/`, `submodules/diff-triangle-rasterization-3D/` 등
  - 자세한 내용은 [LICENSE](./LICENSE) 참조

이 저장소를 사용할 때 두 라이선스를 모두 준수하시기 바랍니다.

## - 인용

본 연구가 유용하다면, 논문을 인용해 주시기 바랍니다:

```bibtex
@misc{sheng20252dtrianglesplattingdirect,
      title={2D Triangle Splatting for Direct Differentiable Mesh Training}, 
      author={Kaifeng Sheng and Zheng Zhou and Yingliang Peng and Qianwei Wang},
      year={2025},
      eprint={2506.18575},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.18575}, 
}
```
<!-- Reference -->
[1]: https://arxiv.org/abs/2506.18575
[2]: https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/
[3]: https://github.com/nerfstudio-project/viser
[4]: https://gaoderender.github.io/triangle-splatting/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---