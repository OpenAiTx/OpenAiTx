# AnimateAnything: 動画生成のための一貫性と制御可能なアニメーション（Cvpr2025）

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
                <img src="https://raw.githubusercontent.com/yu-shaonian/AnimateAnything/main/assets/images/book_logo.png" width="25px" alt="Paper" class="icon"> 論文
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
            <img src="https://raw.githubusercontent.com/yu-shaonian/AnimateAnything/main/assets/images/github.png" width="25px" alt="Project Page" class="icon"> プロジェクトページ
                <!-- <h4><strong>Github</strong></h4> -->
        </a>
    </li> 



## 概要

![image-20241115035450490](https://raw.githubusercontent.com/yu-shaonian/AnimateAnything/main/assets/images/teaser.png)

![image-20241115035450490](https://raw.githubusercontent.com/yu-shaonian/AnimateAnything/main/assets/images/pipeline.png)

## プロジェクトアップデート

- 🔥🔥 **カメラ軌道制御**を完成しました
- 🔥🔥 動画生成をガイドするための**ユーザーアノテーション**を完成しました
- 🔥🔥 **人体アニメーション**を完成しました
- 🔥🔥 参照画像からの**動画変換**を完成しました
- ......... その他多数

## クイックスタート

### Diffusers

**Pythonのバージョンが3.10以上3.12以下（3.10と3.12を含む）であることを必ず確認してください。**

```
pip install -r requirements.txt
```
## ギャラリー

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

## 謝辞

- [CogVideoX](https://github.com/THUDM/CogVideo)
- [MOFA-Video](https://github.com/MyNiuuu/MOFA-Video)

素晴らしい**AIGC**への貢献に感謝して、CogVideoXとMOFA-Videoに感謝します。

## 引用

🌟 私たちの研究がお役に立った場合は、スターを付けて論文を引用してください。私たちのコードは主にCogVideoXに基づいていますので、そちらも引用してください。


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