
# ATI: 제어 가능한 비디오 생성을 위한 모든 궤적 지시어

<div align="center">
  
[![arXiv](https://img.shields.io/badge/arXiv%20paper-2505.22944-b31b1b.svg)](https://arxiv.org/pdf/2505.22944)&nbsp;
[![project page](https://img.shields.io/badge/Project_page-ATI-green)](https://anytraj.github.io/)&nbsp;
<a href="https://huggingface.co/bytedance-research/ATI/"><img src="https://img.shields.io/static/v1?label=%F0%9F%A4%97%20Hugging%20Face&message=Model&color=orange"></a>
</div>


> [**ATI: 제어 가능한 비디오 생성을 위한 모든 궤적 지시어**](https://anytraj.github.io/)<br>
> [Angtian Wang](https://angtianwang.github.io/), [Haibin Huang](https://brotherhuang.github.io/), Jacob Zhiyuan Fang, [Yiding Yang](https://ihollywhy.github.io/), [Chongyang Ma](http://www.chongyangma.com/)
> <br>인텔리전트 크리에이션 팀, ByteDance<br>

[![비디오 보기](https://raw.githubusercontent.com/bytedance/ATI/main/assets/thumbnail.jpg)](https://youtu.be/76jjPT0f8Hs)

본 저장소는 궤적 기반 모션 제어 프레임워크인 Wan2.1 ATI(제어 가능한 비디오 생성을 위한 모든 궤적 지시어)를 위한 것입니다. 이 프레임워크는 비디오 생성에서 객체, 국부 및 카메라 움직임을 통합합니다. 본 저장소는 [Wan2.1 공식 구현](https://github.com/Wan-Video/Wan2.1)을 기반으로 합니다.

원본 Wan2.1과 비교하여 다음 파일들을 추가했습니다:
- wan/modules/motion_patch.py          | 궤적 지시어 커널 모듈
- wan/utils/motion.py                  | 추론 데이터로더 유틸리티
- tools/plot_user_inputs.py            | 사용자 입력 궤적 시각화 도구
- tools/visualize_trajectory.py        | 생성된 비디오 시각화 도구
- tools/trajectory_editor/             | 인터랙티브 궤적 편집기
- examples/                            | 테스트 예제
- run_example.sh                       | 간편 실행 스크립트

다음 파일들을 수정했습니다:
- wan/image2video.py                   | 궤적 로드 및 파싱 블록 추가  #L256
- wan/configs/__init__.py              | ATI 설정 등 구성
- generate.py                          | yaml 형식 추론 예제 로드 엔트리 추가

## 커뮤니티 작업
### ComfyUI
Kijai가 ATI용 ComfyUI 노드를 개발해 주셔서 감사합니다:
[https://github.com/kijai/ComfyUI-WanVideoWrapper](https://github.com/kijai/ComfyUI-WanVideoWrapper)

FP8 양자화 Huggingface 모델: [https://huggingface.co/Kijai/WanVideo_comfy/blob/main/Wan2_1-I2V-ATI-14B_fp8_e4m3fn.safetensors](https://huggingface.co/Kijai/WanVideo_comfy/blob/main/Wan2_1-I2V-ATI-14B_fp8_e4m3fn.safetensors)

### 가이드라인
Benji의 가이드라인: [https://www.youtube.com/watch?v=UM35z2L1XbI](https://www.youtube.com/watch?v=UM35z2L1XbI)

## 설치

ATI는 공식 Wan 2.1과 동일한 환경을 요구합니다. INSTALL.md(Wan2.1)의 지침을 따르십시오.


```
git clone https://github.com/bytedance/ATI.git
cd ATI
```
패키지 설치


```
pip install .
```
먼저 Wan2.1의 14B 원본 모델을 다운로드해야 합니다.


```
huggingface-cli download Wan-AI/Wan2.1-I2V-14B-480P --local-dir ./Wan2.1-I2V-14B-480P
```
그러면 우리 huggingface 저장소에서 ATI-Wan 모델을 다운로드하세요.


```
huggingface-cli download bytedance-research/ATI --local-dir ./Wan2.1-ATI-14B-480P
```
마지막으로, VAE, T5 및 기타 기타 체크포인트를 원본 Wan2.1 폴더에서 ATI 체크포인트 위치로 복사합니다


```
cp ./Wan2.1-I2V-14B-480P/Wan2.1_VAE.pth ./Wan2.1-ATI-14B-480P/
cp ./Wan2.1-I2V-14B-480P/models_t5_umt5-xxl-enc-bf16.pth ./Wan2.1-ATI-14B-480P/
cp ./Wan2.1-I2V-14B-480P/models_clip_open-clip-xlm-roberta-large-vit-huge-14.pth ./Wan2.1-ATI-14B-480P/
cp -r ./Wan2.1-I2V-14B-480P/xlm-roberta-large ./Wan2.1-ATI-14B-480P/
cp -r ./Wan2.1-I2V-14B-480P/google ./Wan2.1-ATI-14B-480P/
```

## Run

We provide a demo sript to run ATI.

```
bash run_example.sh -p examples/test.yaml -c ./Wan2.1-ATI-14B-480P -o samples
```
where `-p` is the path to the config file, `-c` is the path to the checkpoint, `-o` is the path to the output directory, `-g` defines the number of gpus to use (if unspecificed, all avalible GPUs will be used; if `1` is given, will run on single process mode).

Once finished, you will expect to fine:
- `samples/outputs` for the raw output videos.
- `samples/images_tracks` shows the input image togather with the user specified trajectories.
- `samples/outputs_vis` shows the output videos togather with the user specified trajectories.

Expected results:


<table style="width: 100%; border-collapse: collapse; text-align: center; border: 1px solid #ccc;">
  <tr>
    <th style="text-align: center;">
      <strong>입력 이미지 및 궤적</strong>
    </th>
    <th style="text-align: center;">
      <strong>생성된 비디오 (중첩된 궤적)</strong>
    </th>
  </tr>

  <tr>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/00.jpg" alt="Image 0" style="height: 240px;">
    </td>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/00.gif" alt="Image 0" style="height: 240px;">
    </td>
  </tr>

  <tr>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/01.jpg" alt="Image 1" style="height: 240px;">
    </td>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/01.gif" alt="Image 1" style="height: 240px;">
    </td>
  </tr>

  <tr>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/02.jpg" alt="Image 2" style="height: 160px;">
    </td>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/02.gif" alt="Image 2" style="height: 160px;">
    </td>
  </tr>

  </tr>
  <tr>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/03.jpg" alt="Image 3" style="height: 220px;">
    </td>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/03.gif" alt="Image 3" style="height: 220px;">
    </td>
  </tr>

  <tr>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/04.jpg" alt="Image 4" style="height: 240px;">
    </td>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/04.gif" alt="Image 4" style="height: 240px;">
    </td>
  </tr>

  <tr>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/05.jpg" alt="Image 5" style="height: 160px;">
    </td>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/05.gif" alt="Image 5" style="height: 160px;">
    </td>
  </tr>
</table>


## 나만의 궤적 만들기

사용자가 이미지에 직접 궤적을 그리고 편집할 수 있는 인터랙티브 도구를 제공합니다.

1. 먼저 실행하세요:

```
cd tools/trajectory_editor
python3 app.py
```
then open this url [localhost:5000](http://localhost:5000/) in the browser. Note if you run the editor on the server, you need to replace `localhost` with the server's IP address.

2. Get the interface shown below, then click **Choose File** to open a local image.  
![Interface Screenshot](https://raw.githubusercontent.com/bytedance/ATI/main/assets/editor0.PNG)

3. Available trajectory functions:  
![Trajectory Functions](https://raw.githubusercontent.com/bytedance/ATI/main/assets/editor1.PNG)

   a. **Free Trajectory**: Click and then drag with the mouse directly on the image.  
   b. **Circular (Camera Control)**:  
      - Place a circle on the image, then drag to set its size for frame 0.  
      - Place a few (3–4 recommended) track points on the circle.  
      - Drag the radius control to achieve zoom-in/zoom-out effects.  

   c. **Static Point**: A point that remains stationary over time.  

   *Note:* Pay attention to the progress bar in the box to control motion speed.  
   ![Progress Control](https://raw.githubusercontent.com/bytedance/ATI/main/assets/editor2.PNG)

4. **Trajectory Editing**: Select a trajectory here, then delete, edit, or copy it. In edit mode, drag the trajectory directly on the image. The selected trajectory is highlighted by color.  
![Trajectory Editing](https://raw.githubusercontent.com/bytedance/ATI/main/assets/editor3.PNG)

5. **Camera Pan Control**: Enter horizontal (X) or vertical (Y) speed (pixels per frame). Positive X moves right; negative X moves left. Positive Y moves down; negative Y moves up. Click **Add to Selected** to apply to the current trajectory, or **Add to All** to apply to all trajectories. The selected points will gain a constant pan motion on top of their existing movement.  
![Camera Pan Control](https://raw.githubusercontent.com/bytedance/ATI/main/assets/editor4.PNG)

6. **Important:** After editing, click **Store Tracks** to save. Each image (not each trajectory) must be saved separately after drawing all trajectories.  
![Store Tracks](https://raw.githubusercontent.com/bytedance/ATI/main/assets/editor5.PNG)

7. Once all edits are complete, locate the `videos_example` folder in the **Trajectory Editor**.


## Citation
Please cite our paper if you find our work useful:
```
@article{wang2025ati,
  title={{ATI}: Any Trajectory Instruction for Controllable Video Generation},
  author={Wang, Angtian and Huang, Haibin and Fang, Zhiyuan and Yang, Yiding, and Ma, Chongyang}
  journal={arXiv preprint},
  volume={arXiv:2505.22944},
  year={2025}
}
```



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---