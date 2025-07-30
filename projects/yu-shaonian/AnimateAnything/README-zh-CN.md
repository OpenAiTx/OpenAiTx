# AnimateAnything：用于视频生成的一致且可控的动画（Cvpr2025）

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
                <img src="https://raw.githubusercontent.com/yu-shaonian/AnimateAnything/main/assets/images/book_logo.png" width="25px" alt="Paper" class="icon"> 论文
                    <!-- <h4><strong>arXiv</strong></h4> -->
            </a>
        </li>
    <li>
        <a target="_blank" href="https://yu-shaonian.github.io/Animate_Anything/">
            <img src="https://raw.githubusercontent.com/yu-shaonian/AnimateAnything/main/assets/images/hf-logo.png" width="25px" alt="Code" 			class="icon">Huggingface
            <!-- <h4><strong>Github</strong></h4> -->
        </a>
    </li>           
    <li>
        <a target="_blank" href="https://yu-shaonian.github.io/Animate_Anything/">
            <img src="https://raw.githubusercontent.com/yu-shaonian/AnimateAnything/main/assets/images/github.png" width="25px" alt="Project Page" class="icon"> 项目主页
                <!-- <h4><strong>Github</strong></h4> -->
        </a>
    </li> 



## 概述

![image-20241115035450490](https://raw.githubusercontent.com/yu-shaonian/AnimateAnything/main/assets/images/teaser.png)

![image-20241115035450490](https://raw.githubusercontent.com/yu-shaonian/AnimateAnything/main/assets/images/pipeline.png)

## 项目更新

- 🔥🔥 我们完成了**相机轨迹控制**
- 🔥🔥 我们完成了用于引导视频生成的**用户标注**
- 🔥🔥 我们完成了**人体动画**
- 🔥🔥 我们完成了从参考图像进行的视频**迁移**
- ......... 以及更多

## 快速开始

### Diffusers

**请确保您的Python版本在3.10到3.12之间，包含3.10和3.12。**

```
pip install -r requirements.txt
```
## 画廊

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

## 致谢

- [CogVideoX](https://github.com/THUDM/CogVideo)
- [MOFA-Video](https://github.com/MyNiuuu/MOFA-Video)

感谢 CogVideoX 和 MOFA-Video 对 **AIGC** 的巨大贡献

## 引用

🌟 如果您觉得我们的工作有帮助，请给我们点个星并引用我们的论文。我们的代码主要基于 CogVideoX，请同时引用他们。


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