<div align="center">
<img src="https://raw.githubusercontent.com/runjiali-rl/vmem/main/assets/title_logo.png" width="200" alt="VMem Logo"/>
<h1>VMem: 서펠 인덱스 뷰 메모리를 이용한 일관된 인터랙티브 비디오 장면 생성</h1>

<p align="center">ICCV 2025</p>


<a href="https://v-mem.github.io/"><img src="https://img.shields.io/badge/%F0%9F%8F%A0%20Project%20Page-gray.svg"></a>
<a href="http://arxiv.org/abs/2506.18903"><img src="https://img.shields.io/badge/%F0%9F%93%84%20arXiv-2506.18903-B31B1B.svg"></a>
<a href="https://huggingface.co/liguang0115/vmem"><img src="https://img.shields.io/badge/%F0%9F%A4%97%20Model_Card-Huggingface-orange"></a>
<a href="https://huggingface.co/spaces/liguang0115/vmem"><img src="https://img.shields.io/badge/%F0%9F%9A%80%20Gradio%20Demo-Huggingface-orange"></a>

[Runjia Li](https://runjiali-rl.github.io/), [Philip Torr](https://www.robots.ox.ac.uk/~phst/), [Andrea Vedaldi](https://www.robots.ox.ac.uk/~vedaldi/), [Tomas Jakab](https://www.robots.ox.ac.uk/~tomj/)
<br>
<br>
[옥스퍼드 대학교](https://www.robots.ox.ac.uk/~vgg/)
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/runjiali-rl/vmem/main/assets/demo_teaser.gif" width="100%" alt="Teaser" style="border-radius:10px;"/>
</p>

<!-- <p align="center" border-radius="10px">
  <img src="https://raw.githubusercontent.com/runjiali-rl/vmem/main/assets/benchmark.png" width="100%" alt="teaser_page1"/>
</p> -->

# 개요

`VMem`은 일관된 장면 생성을 위한 이미지 세트 모델의 플러그 앤 플레이 메모리 메커니즘입니다.
기존 방법들은 명시적 기하학 추정을 통한 인페인팅에 의존하거나, 비디오 기반 접근법에서 제한된 컨텍스트 윈도우를 사용하여 부정확하거나 장기 일관성이 떨어지는 문제가 있습니다. 이러한 문제를 극복하기 위해, 우리는 과거 뷰를 관찰한 표면 요소(서펠)에 고정하는 서펠 뷰 메모리(VMem)를 도입합니다. 이를 통해 가장 최근 뷰뿐만 아니라 가장 관련성 높은 과거 뷰를 기반으로 새로운 뷰 생성을 조건화할 수 있어 장기적인 장면 일관성을 높이고 계산 비용을 줄입니다.


# :wrench: 설치

```bash
conda create -n vmem python=3.10
conda activate vmem
pip install -r requirements.txt
```



# :rocket: 사용법

모델 가중치를 다운로드하려면 Hugging Face에 제대로 인증해야 합니다. 설정이 완료되면 첫 실행 시 코드가 자동으로 처리합니다. 인증은 다음 명령어로 할 수 있습니다.


```bash
# This will prompt you to enter your Hugging Face credentials.
huggingface-cli login
```
인증이 완료되면, 우리의 모델 카드 [여기](https://huggingface.co/liguang0115/vmem)에서 접속하여 정보를 입력하세요.

`VMem`과 상호작용할 수 있는 데모를 제공합니다. 간단히 실행하세요.


```bash
python app.py
```



## :heart: 감사의 글
이 작업은 [CUT3R](https://github.com/CUT3R/CUT3R), [DUSt3R](https://github.com/naver/dust3r) 및 [Stable Virtual Camera](https://github.com/stability-ai/stable-virtual-camera)를 기반으로 합니다. 그들의 훌륭한 작업에 감사드립니다.





# :books: 인용

이 저장소가 유용하다면 별 :star: 과 인용을 고려해 주세요.


```
@article{li2025vmem,
  title={VMem: Consistent Interactive Video Scene Generation with Surfel-Indexed View Memory},
  author={Li, Runjia and Torr, Philip and Vedaldi, Andrea and Jakab, Tomas},
  journal={arXiv preprint arXiv:2506.18903},
  year={2025}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---