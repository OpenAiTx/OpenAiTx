# 3DGS.zip: 3D 가우시안 스플래팅 압축 방법에 대한 조사  
이 저장소는 3D 가우시안 스플래팅(3DGS) 압축 방법에 대한 포괄적인 조사를 포함하고 있습니다. 전체 조사 표와 비교 플롯은 [w-m.github.io/3dgs-compression-survey/](https://w-m.github.io/3dgs-compression-survey/)에서 확인할 수 있습니다.  

## 설치  
이 저장소의 스크립트를 실행하려면 모든 필수 종속성이 설치되어 있는지 확인하십시오. 다음 명령어로 설치할 수 있습니다:  

`pip install -r requirements.txt`  

## 사이트 빌드  
사이트를 빌드하려면 다음 명령어를 사용하십시오:  

`python data_extraction/build_html.py`  

이 스크립트는 또한 변경 사항이 메인 브랜치에 푸시될 때마다 사이트를 자동으로 재빌드합니다.  

## 결과 가져오기  
다음 명령어를 실행하여 결과를 자동으로 가져올 수 있습니다:  

`python data_extraction/data_extraction.py`  

이 스크립트는 관련 논문에서 데이터를 가져와 `results` 폴더의 표를 업데이트하려고 시도합니다. 새 논문을 추가하려면 `data_extraction/data_source.yaml`에 항목을 만드십시오.  

## 자신의 결과 포함하기  

저자는 정확한 데이터 검색과 일관되고 공정한 비교를 위해 GitHub 저장소 내 지정된 폴더에 씬별 결과를 업로드해 주시기 바랍니다. 예상 폴더 구조는 다음과 같습니다:

```
results
├── DeepBlending
│   ├── drjohnson.csv
│   └── playroom.csv
├── MipNeRF360
│   ├── bicycle.csv
│   ├── bonsai.csv
│   ├── counter.csv
│   ├── flowers.csv
│   ├── garden.csv
│   ├── kitchen.csv
│   ├── room.csv
│   ├── stump.csv
│   └── treehill.csv
├── SyntheticNeRF
│   ├── chair.csv
│   ├── drums.csv
│   ├── ficus.csv
│   ├── hotdog.csv
│   ├── lego.csv 
│   ├── materials.csv
│   ├── mic.csv
│   └── ship.csv
└── TanksAndTemples
    ├── train.csv
    └── truck.csv
```
폴더에는 귀하의 방법이 평가된 모든 데이터셋이 포함되어야 하며 폴더 구조에 지정된 모든 장면을 포함해야 합니다.

각 CSV 파일은 다음과 같이 구성되어야 합니다:


```
Submethod,PSNR,SSIM,LPIPS,Size [Bytes],#Gaussians
Baseline,xx.xx,0.xxx,0.xxx,xxxxxxxx,xxxxxxxx
-SubmethodName,xx.xx,0.xxx,0.xxx,xxxxxxxx,xxxxxxxx
,xx.xx,0.xxx,0.xxx,xxxxxxxx,xxxxxxxx
,xx.xx,0.xxx,0.xxx,xxxxxxxx,xxxxxxxx
,xx.xx,0.xxx,0.xxx,xxxxxxxx,xxxxxxxx

```
PSNR 결과는 소수점 이하 두 자리 이상, SSIM 및 LPIPS 결과는 소수점 이하 세 자리 이상으로 보고해야 합니다. 저자들은 전체 정밀도로 결과를 제공하는 것이 권장되며, 이는 설문 조사에 포함되기 전에 반올림됩니다.

결과가 설문 조사 표에 나타나도록 모든 파일에서 일관된 하위 방법 이름을 최대 두 개까지 포함하세요. 이 이름들은 표에서 귀하의 접근법 이름과 연결됩니다. 하위 방법 지정자가 방법 이름과 공백으로 구분되어야 한다면, 하위 방법 이름 앞에 공백을 반드시 포함하세요. 표에 접근법 이름만 표시하려면 해당 결과에 대해 "Baseline"을 하위 방법 이름으로 사용할 수 있습니다. 하위 방법 이름이 없는 결과는 플롯에만 표시됩니다.

예시는 [여기](https://github.com/fraunhoferhhi/Self-Organizing-Gaussians/tree/main/results)에서 확인할 수 있습니다.

### 중요: 3DGS 테스트 규칙

저자들은 원본 [3DGS 프로젝트](https://github.com/graphdeco-inria/gaussian-splatting)에서 정한 테스트 규칙을 준수해야 합니다. 구체적으로 다음을 포함합니다:

- MipNeRF360 데이터셋의 모든 9개 장면과 [추가 장면](https://storage.googleapis.com/gresearch/refraw360/360_extra_scenes.zip) "flowers" 및 "treehill"을 사용합니다.
- 최대 길이가 1600픽셀까지 원본 해상도로 이미지를 평가합니다. 더 큰 테스트 이미지는 가장 긴 변이 1600픽셀이 되도록 축소해야 합니다(MipNeRF360에만 적용). 크기 조정은 3DGS와 일치하도록 표준 PIL ```.resize()``` 메서드와 바이큐빅 리샘플링을 사용해야 합니다.  
- 3개의 COLMAP 데이터셋(탱크와 템플, 딥 블렌딩, MipNeRF360)에서는 8번째 이미지마다 하나씩 테스트에 사용합니다. 구체적으로 테스트 이미지는 ```idx % 8 == 0```인 이미지입니다.
- Blender 데이터셋(SyntheticNeRF)은 미리 정의된 학습/평가 분할을 따릅니다.

## LaTeX 표

최신 LaTeX 버전의 설문 조사 표는 [압축](https://github.com/w-m/3dgs-compression-survey/blob/main/data_extraction/latex/3dgs_table_compression.tex) 및 [조밀화](https://github.com/w-m/3dgs-compression-survey/blob/main/data_extraction/latex/3dgs_table_densification.tex)용으로 제공됩니다. 접근법과 비교하려면 표에서 한 줄을 복사해 연구에 활용하세요. 전체 표를 복사하려면 LaTeX 머리말에 다음 패키지와 정의가 필요할 수 있습니다:


```
\usepackage{booktabs}
\usepackage[table]{xcolor}
% colors for table
\definecolor{lightred}{HTML}{FF9999}
\definecolor{lightyellow}{HTML}{FFFF99}
\definecolor{lightorange}{HTML}{FFCC99}
\usepackage{makecell}
\usepackage{adjustbox}
% make text the same size even when its bold in a table
\newsavebox\CBox
\def\textBF#1{\sbox\CBox{#1}\resizebox{\wd\CBox}{\ht\CBox}{\textbf{#1}}}
```

## 인용

연구에 본 설문조사를 사용하신 경우, 저희 작업을 인용해 주시기 바랍니다. 다음의 BibTeX 항목을 사용하실 수 있습니다:

```bibtex
@article{3DGSzip2025,
author = {Bagdasarian, M. T. and Knoll, P. and Li, Y. and Barthel, F. and Hilsmann, A. and Eisert, P. and Morgenstern, W.},
title = {{3DGS.zip}: A {Survey} on {3D} {Gaussian} {Splatting} {Compression} {Methods}},
journal = {Computer Graphics Forum},
pages = {e70078},
year = {2025},
keywords = {CCS Concepts, • Information systems → Data compression, • Computing methodologies → Rasterization, • General and reference → Surveys and overviews},
doi = {https://doi.org/10.1111/cgf.70078},
url = {https://onlinelibrary.wiley.com/doi/abs/10.1111/cgf.70078},
eprint = {https://onlinelibrary.wiley.com/doi/pdf/10.1111/cgf.70078},
note = {\url{https://w-m.github.io/3dgs-compression-survey/}},
} 
```
## 업데이트
- 2025-04-29: 논문 게재, Readme 및 웹사이트의 bibtex 업데이트
- 2025-03-04: GaussianSpa 요약 추가 (저자 제공)
- 2025-02-26: HEMGS 추가
- 2025-02-25: GaussianSpa 추가
- 2025-02-25: HAC++ 추가
- 2025-02-25: FCGS 추가
- 2025-02-10: 출판 철회로 IGS 제거
- 2025-02-05: CodecGS 추가
- 2024-11-21: ContextGS 추가
- 2024-11-07: CompGS 추가
- 2024-11-05: [arXiv](https://arxiv.org/abs/2407.09510) 버전 업데이트: 압축 및 압축 방법과 3DGS 압축 기본 내용 포함
- 2024-10-21: 웹사이트에서 "densification" 용어를 설문조사 논문에 맞게 "compaction"으로 공식 변경
- 2024-10-17: GaussiansPro, AtomGS, Taming3DGS를 densification/compaction 방법에 추가
- 2024-10-14: MesonGS를 압축 방법에 추가
- 2024-09-30: 설문조사에 densification 방법 추가
- 2024-09-17: Morgenstern 등 결과 업데이트 및 HAC 결과는 [테스트 규약 혼동](https://github.com/YihangChen-ee/HAC/issues/14)으로 복원
- 2024-09-05: Scaffold-GS MipNeRF-360 결과를 9개 장면 전체 포함하도록 업데이트
- 2024-08-27: 설문조사에 IGS 방법 추가
- 2024-08-26: 설문조사에 gsplat 방법 추가
- 2024-08-14: 속성 및 데이터셋 선택에 따른 적응형 랭크 도입
- 2024-08-12: 모델 크기 대신 가우시안 수에 따른 지표 플롯 추가
- 2024-08-08: 표에 표시할 지표 및 데이터셋 선택용 체크박스 추가
- 2024-08-07: 설문조사에 가우시안 수 포함, 표에 가우시안당 비트 포함
- 2024-08-02: 논문 발표 학회 표시
- 2024-06-19: 사용 가능한 모든 데이터셋을 이용한 새로운 랭크 계산
- 2024-06-17: 방법들의 랭크 포함
- 2024-06-17: [arXiv](https://arxiv.org/abs/2407.09510)에서 설문조사 초판 공개
- 2024-06-13: 모델 크기에 따른 지표 플롯 추가
- 2024-06-10: 대화형 표가 포함된 설문조사 페이지 초안 작성


<!-- - 2024-08-22: 사전 학습된 [압축 장면](https://github.com/fraunhoferhhi/Self-Organizing-Gaussians/releases/tag/eccv-2024-data) 공개
- 2024-07-09: TLDR, 기여, 인사이트 및 동시대 방법과의 비교를 포함한 프로젝트 웹사이트 업데이트
- 2024-07-01: 본 연구가 **ECCV 2024**에 채택됨 🥳
- 2024-06-13: 학습 코드 공개
- 2024-05-14: 압축 점수 향상! 논문 v2의 새로운 결과가 [프로젝트 웹사이트](https://fraunhoferhhi.github.io/Self-Organizing-Gaussians/)에 공개됨
- 2024-05-02: arXiv에 수정된 [논문 v2](https://arxiv.org/pdf/2312.13299) 공개: 구면 조화 압축 추가, 개선된 압축 방법 및 결과 업데이트 (모든 속성이 JPEG XL로 압축됨), 추가 장면의 정성적 비교 추가, 압축 설명 및 비교를 본 논문으로 이동, "Making Gaussian Splats smaller"와 비교 추가.
- 2024-02-22: 정렬 알고리즘 코드가 [fraunhoferhhi/PLAS](https://github.com/fraunhoferhhi/PLAS)에서 공개됨
- 2024-02-21: 다양한 장면에 대한 비디오 비교가 [프로젝트 웹사이트](https://fraunhoferhhi.github.io/Self-Organizing-Gaussians/)에 공개됨
- 2023-12-19: [arXiv](https://arxiv.org/abs/2312.13299)에 사전 인쇄본 공개 -->



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---