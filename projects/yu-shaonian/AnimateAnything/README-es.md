# AnimateAnything: Animación Consistente y Controlable para generación de video (Cvpr2025)

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
                <img src="https://raw.githubusercontent.com/yu-shaonian/AnimateAnything/main/assets/images/book_logo.png" width="25px" alt="Paper" class="icon"> Artículo
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
            <img src="https://raw.githubusercontent.com/yu-shaonian/AnimateAnything/main/assets/images/github.png" width="25px" alt="Project Page" class="icon"> Página del Proyecto
                <!-- <h4><strong>Github</strong></h4> -->
        </a>
    </li> 



## Visión General

![image-20241115035450490](https://raw.githubusercontent.com/yu-shaonian/AnimateAnything/main/assets/images/teaser.png)

![image-20241115035450490](https://raw.githubusercontent.com/yu-shaonian/AnimateAnything/main/assets/images/pipeline.png)

## Actualizaciones del Proyecto

- 🔥🔥 Hemos terminado el **Control de trayectoria de cámara**
- 🔥🔥 Hemos terminado la **Anotación del Usuario** para guiar la generación de video
- 🔥🔥 Hemos terminado la **animación humana**
- 🔥🔥 Hemos terminado la **transferencia de video** desde una imagen de referencia
- ......... Y Más

## Inicio Rápido

### Diffusers

**Por favor asegúrese que su versión de Python esté entre 3.10 y 3.12, inclusive 3.10 y 3.12.**

```
pip install -r requirements.txt
```

## Galería

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

## Agradecimientos

- [CogVideoX](https://github.com/THUDM/CogVideo)
- [MOFA-Video](https://github.com/MyNiuuu/MOFA-Video)

Gracias a CogVideoX y MOFA-Video por su gran contribución al **AIGC**

## Cita

🌟 Si encuentras útil nuestro trabajo, por favor déjanos una estrella y cita nuestro artículo. Nuestro código está basado principalmente en CogVideoX, por favor cítalos también.

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