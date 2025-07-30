# AnimateAnything: 비디오 생성용 일관되고 제어 가능한 애니메이션 (Cvpr2025)

  <div class="is-flex is-justify-content-center">
    <ul class="icon-list">
        <li>
            <a target="_blank" href="https://arxiv.org/pdf/2411.10836">
                <img src="https://raw.githubusercontent.com/yu-shaonian/AnimateAnything/main/assets/images/arxiv.png" width="25px" alt="arXiv" class="icon"> arXiv
                    <!-- <h4><strong>arXiv</strong></h4> -->
            </a>
        </li>
        <li>
            <a target="_blank" href="https://arxiv.org/pdf/2411.10836">
                <img src="https://raw.githubusercontent.com/yu-shaonian/AnimateAnything/main/assets/images/book_logo.png" width="25px" alt="Paper" class="icon"> 논문
                    <!-- <h4><strong>arXiv</strong></h4> -->
            </a>
        </li>
    <li>
        <a target="_blank" href="https://yu-shaonian.github.io/Animate_Anything/">
            <img src="https://raw.githubusercontent.com/yu-shaonian/AnimateAnything/main/assets/images/hf-logo.png" width="25px" alt="Code" 			class="icon">허깅페이스
            <!-- <h4><strong>Github</strong></h4> -->
        </a>
    </li>           
    <li>
        <a target="_blank" href="https://yu-shaonian.github.io/Animate_Anything/">
            <img src="https://raw.githubusercontent.com/yu-shaonian/AnimateAnything/main/assets/images/github.png" width="25px" alt="Project Page" class="icon"> 프로젝트 페이지
                <!-- <h4><strong>Github</strong></h4> -->
        </a>
    </li> 



## 개요

![image-20241115035450490](https://raw.githubusercontent.com/yu-shaonian/AnimateAnything/main/assets/images/teaser.png)

![image-20241115035450490](https://raw.githubusercontent.com/yu-shaonian/AnimateAnything/main/assets/images/pipeline.png)

## 프로젝트 업데이트

- 🔥🔥 **카메라 궤적 제어**를 완료했습니다
- 🔥🔥 비디오 생성을 안내하는 **사용자 주석**을 완료했습니다
- 🔥🔥 **인간 애니메이션**을 완료했습니다
- 🔥🔥 참조 이미지로부터 **비디오 전송**을 완료했습니다
- ......... 그리고 더 많은 기능

## 빠른 시작

### Diffusers

**Python 버전이 3.10 이상 3.12 이하(3.10 및 3.12 포함)인지 반드시 확인하세요.**

```
pip install -r requirements.txt
```
## 갤러리

![image-20241115204104582](https://raw.githubusercontent.com/yu-shaonian/AnimateAnything/main/assets/images/all_direction.png)



<table border="0" style="width: 100%; text-align: left; margin-top: 20px;">
  <tr>
      <td>
          <video src="https://yu-shaonian.github.io/Animate_Anything/dynamic_scene/3_animals_ram5.jpg_openvidcheckpoint-2400_final_video.mp4" width="100%" controls autoplay loop></video>
      </td>
      <td>
          <video src="https://yu-shaonian.github.io/Animate_Anything/dynamic_scene/1_animals_2_16.jpg_openvidcheckpoint-2400_final_video.mp4" width="100%" controls autoplay loop></video>
      </td>
       <td>
          <video src="https://yu-shaonian.github.io/Animate_Anything/drag_all_direction/bear_taiji_2.mp4" width="100%" controls autoplay loop></video>
     </td>
      <td>
          <video src="https://yu-shaonian.github.io/Animate_Anything/static_scene/0_scenery_xiangge1.jpg_openvidcheckpoint-2400_final_video.mp4" width="100%" controls autoplay loop></video>
     </td>
  </tr>
  <tr>
      <td>
          <video src="https://yu-shaonian.github.io/Animate_Anything/static_scene/0_scenery_guilin8.jpg_openvidcheckpoint-2400_final_video.mp4" width="100%" controls autoplay loop></video>
      </td>
      <td>
          <video src="https://yu-shaonian.github.io/Animate_Anything/plants_growth/A_purple_flower_bud_is_striving_to_bloom.mp4" width="100%" controls autoplay loop></video>
      </td>
       <td>
          <video src="https://yu-shaonian.github.io/Animate_Anything/static_scene/0_scenery_guilin8.jpg_openvidcheckpoint-2400_final_video.mp4" width="100%" controls autoplay loop></video>
     </td>
      <td>
          <video src="https://yu-shaonian.github.io/Animate_Anything/static_scene/4_scenery_xiangge9.jpg_openvidcheckpoint-2400_final_video.mp4" width="100%" controls autoplay loop></video>
     </td>
  </tr>
</table>

## 감사의 글

- [CogVideoX](https://github.com/THUDM/CogVideo)
- [MOFA-Video](https://github.com/MyNiuuu/MOFA-Video)

**AIGC**에 대한 큰 기여에 감사드립니다 CogVideoX와 MOFA-Video께

## 인용

🌟 저희 작업이 도움이 되셨다면 별점을 남기시고 논문을 인용해 주세요. 저희 코드는 주로 CogVideoX를 기반으로 하였으니, 이들도 함께 인용해 주세요.


```
@article{lei2024animateanything,
  title={Animateanything: Consistent and controllable animation for video generation},
  author={Lei, Guojun and Wang, Chi and Li, Hong and Zhang, Rong and Wang, Yikai and Xu, Weiwei},
  journal={arXiv preprint arXiv:2411.10836},
  year={2024}
}
```





## Model-License

The code in this repository is released under the [Apache 2.0 License](LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---