# :bulb: LaMP: Language-Motion Pretraining for Motion Generation, Retrieval, and Captioning (ICLR 2025)
### [[Project Page]](https://aigc3d.github.io/LaMP/) [[Paper]](https://arxiv.org/abs/2410.07093)
![teaser_image](https://github.com/gentlefress/LaMP/blob/main/teaser.png)

If you find our code or paper helpful, please consider starring our repository and citing:
```
@article{li2024lamp,
  title={LaMP: Language-Motion Pretraining for Motion Generation, Retrieval, and Captioning},
  author={Li, Zhe and Yuan, Weihao and He, Yisheng and Qiu, Lingteng and Zhu, Shenhao and Gu, Xiaodong and Shen, Weichao and Dong, Yuan and Dong, Zilong and Yang, Laurence T},
  journal={arXiv preprint arXiv:2410.07093},
  year={2024}
}
```

## :postbox: News
📢 **2025-01-22** --- 🔥🔥🔥 Congrats! LaMP is accepted to ICLR 2025.

📢 **2025-4-28** --- Release codes and models for LaMP. Including training/eval/generation scripts.

📢 **2025-4-28** --- Initialized the webpage and git project.  


## :1st_place_medal: Get You Ready

<details>
  
### 1. Conda Environment
```
conda env create -f environment.yml
conda activate lamp
pip install git+https://github.com/openai/CLIP.git
```
We test our code on Python 3.9.12 and PyTorch 1.12.1

### 2. Models and Dependencies

#### Download Pre-trained Models
```
bash prepare/download_models.sh
```

#### Download Evaluation Models and Gloves
For evaluation only.
```
bash prepare/download_evaluator.sh
bash prepare/download_glove.sh
```


#### (Optional) Download Manually
##### VQVAE Pretrained Weights:
https://virutalbuy-public.oss-cn-hangzhou.aliyuncs.com/share/aigc3d/lamp/vq.tar
##### LaMP Pretrained Weights:
HumanML3D: https://virutalbuy-public.oss-cn-hangzhou.aliyuncs.com/share/aigc3d/lamp/h3d-qformer.tar

KIT-ML: https://virutalbuy-public.oss-cn-hangzhou.aliyuncs.com/share/aigc3d/lamp/kit-qformer.tar
##### LaMP-T2M Pretrained Weights:
https://virutalbuy-public.oss-cn-hangzhou.aliyuncs.com/share/aigc3d/lamp/t2m.tar
##### M2T-LaMP Pretrained Weights:
https://virutalbuy-public.oss-cn-hangzhou.aliyuncs.com/share/aigc3d/lamp/m2t.pth
### 3. Get Data

You have two options here:
* **Skip getting data**, if you just want to generate motions using *own* descriptions.
* **Get full data**, if you want to *re-train* and *evaluate* the model.

**(a). Full data (text + motion)**

**HumanML3D** - Follow the instruction in [HumanML3D](https://github.com/EricGuo5513/HumanML3D.git), then copy the result dataset to our repository:
```
cp -r ../HumanML3D/HumanML3D ./dataset/HumanML3D
```
**KIT**-Download from [HumanML3D](https://github.com/EricGuo5513/HumanML3D.git), then place result in `./dataset/KIT-ML`

#### 

</details>

## :fire: Demo
<details>

### (a) Generate from a single prompt
```
python gen_t2m.py --gpu_id 1 --ext exp1 --text_prompt "A person is running on a treadmill."
```
### (b) Generate from a prompt file
An example of prompt file is given in `./assets/text_prompt.txt`. Please follow the format of `<text description>#<motion length>` at each line. Motion length indicates the number of poses, which must be integeter and will be rounded by 4. In our work, motion is in 20 fps.

If you write `<text description>#NA`, our model will determine a length. Note once there is **one** NA, all the others will be **NA** automatically.

```
python gen_t2m.py --gpu_id 1 --ext exp2 --text_path ./assets/text_prompt.txt
```


A few more parameters you may be interested:
* `--repeat_times`: number of replications for generation, default `1`.
* `--motion_length`: specify the number of poses for generation, only applicable in (a).

The output files are stored under folder `./generation/<ext>/`. They are
* `numpy files`: generated motions with shape of (nframe, 22, 3), under subfolder `./joints`.
* `video files`: stick figure animation in mp4 format, under subfolder `./animation`.
* `bvh files`: bvh files of the generated motion, under subfolder `./animation`.

We also apply naive foot ik to the generated motions, see files with suffix `_ik`. It sometimes works well, but sometimes will fail.
  
</details>

## :basketball_man: Visualization
<details>

All the animations are manually rendered in blender. We use the characters from [mixamo](https://www.mixamo.com/#/). You need to download the characters in T-Pose with skeleton.

### Retargeting
For retargeting, we found rokoko usually leads to large error on foot. On the other hand, [keemap.rig.transfer](https://github.com/nkeeline/Keemap-Blender-Rig-ReTargeting-Addon/releases) shows more precise retargetting. You could watch the [tutorial](https://www.youtube.com/watch?v=EG-VCMkVpxg) here.

Following these steps:
* Download keemap.rig.transfer from the github, and install it in blender.
* Import both the motion files (.bvh) and character files (.fbx) in blender.
* `Shift + Select` the both source and target skeleton. (Do not need to be Rest Position)
* Switch to `Pose Mode`, then unfold the `KeeMapRig` tool at the top-right corner of the view window.
* For `bone mapping file`, direct to `./assets/mapping.json`(or `mapping6.json` if it doesn't work), and click `Read In Bone Mapping File`. This file is manually made by us. It works for most characters in mixamo.
* (Optional) You could manually fill in the bone mapping and adjust the rotations by your own, for your own character. `Save Bone Mapping File` can save the mapping configuration in local file, as specified by the mapping file path.
* Adjust the `Number of Samples`, `Source Rig`, `Destination Rig Name`.
* Clik `Transfer Animation from Source Destination`, wait a few seconds.

We didn't tried other retargetting tools. Welcome to comment if you find others are more useful.

</details>

## :flashlight: Train Your Own Models
<details>


**Note**: You have to train VQ-VAE **BEFORE** training masked/residual transformers. The latter two can be trained simultaneously.

### Train VQ-VAE
You may also need to download evaluation models to run the scripts.
```
python train_vq.py --name vq_name --gpu_id 1 --dataset_name t2m --batch_size 256  --max_epoch 50 --quantize_dropout_prob 0.2 --gamma 0.05
```

### Train LaMP
```
python train_lamp.py --name lamp_name --gpu_id 2 --dataset_name t2m --batch_size 64 --vq_name vq_name
```

### Train Masked Transformer
```
python train_t2m_transformer.py --name mtrans_name --gpu_id 2 --dataset_name t2m --batch_size 64 --vq_name vq_name
```

* `--dataset_name`: motion dataset, `t2m` for HumanML3D and `kit` for KIT-ML.  
* `--name`: name your model. This will create to model space as `./checkpoints/<dataset_name>/<name>`
* `--gpu_id`: GPU id.
* `--batch_size`: we use `512` for vq training. For masked/residual transformer, we use `64` on HumanML3D and `16` for KIT-ML.
* `--quantize_drop_prob`: quantization dropout ratio, `0.2` is used.
* `--vq_name`: when training masked/residual transformer, you need to specify the name of vq model for tokenization.
* `--cond_drop_prob`: condition drop ratio, for classifier-free guidance. `0.2` is used.

All the pre-trained models and intermediate results will be saved in space `./checkpoints/<dataset_name>/<name>`.

### Train M2T
```
python train_m2t.py --exp-name M2T --num-layers 12 --batch-size 80 --embed-dim-gpt 1024 --nb-code 512 --n-head-gpt 16 --block-size 51 --ff-rate 4 --drop-out-rate 0.1 --resume-pth your_own_vqvae --vq-name VQVAE --out-dir ./output --total-iter 150000 --lr-scheduler 75000 --lr 0.00005 --dataname kit --down-t 2 --depth 3 --quantizer ema_reset --eval-iter 10000 --pkeep 0.5 --dilation-growth-rate 3 --vq-act relu
```

</details>

## :artist: Evaluation
<details>

### Evaluate VQ-VAE Reconstruction:
HumanML3D:
```
python eval_t2m_vq.py --gpu_id 0 --name  --dataset_name t2m

```
KIT-ML:
```
python eval_t2m_vq.py --gpu_id 0 --name  --dataset_name kit
```

### Evaluate LaMP-T2M:
HumanML3D:
```
python eval_t2m_trans_res.py --res_name mtrans_name --dataset_name t2m --name eval_name --gpu_id 1 --cond_scale 4 --time_steps 10 --ext evaluation
```
KIT-ML:
```
python eval_t2m_trans_res.py --res_name mtrans_name_k --dataset_name kit --name eval_name_k --gpu_id 0 --cond_scale 2 --time_steps 10 --ext evaluation
```

* `--res_name`: model name of `residual transformer`.  
* `--name`: model name of `masked transformer`.  
* `--cond_scale`: scale of classifer-free guidance.
* `--time_steps`: number of iterations for inference.
* `--ext`: filename for saving evaluation results.
* `--which_epoch`: checkpoint name of `masked transformer`.

The final evaluation results will be saved in `./checkpoints/<dataset_name>/<name>/eval/<ext>.log`

### Evaluate LaMP-M2T:
```
python M2T_eval.py --exp-name Test_M2T --num-layers 9 --batch-size 1 --embed-dim-gpt 1024 --nb-code 512 --n-head-gpt 16 --block-size 51 --ff-rate 4 --drop-out-rate 0.1 --resume-pth your_own_vqvae --vq-name VQVAE --out-dir ./output --total-iter 150000 --lr-scheduler 75000 --lr 0.0001 --dataname t2m --down-t 2 --depth 3 --quantizer ema_reset --eval-iter 10000 --pkeep 0.5 --dilation-growth-rate 3 --vq-act relu --resume-trans your_own_m2t
```
LaMP-BertScore metric is computed by first generating a textual description of the synthesized motion using LaMP-M2T, and then calculating the BertScore between the generated description and the ground-truth text.

</details>

## Acknowlegements

We sincerely thank the open-sourcing of these works where our code is based on: 

[T2M-GPT](https://github.com/Mael-zys/T2M-GPT) and [MoMask](https://github.com/EricGuo5513/momask-codes/tree/main).

## License
This code is distributed under an [MIT LICENSE](https://github.com/gentlefress/LaMP/blob/main/LICENSE.md).

Note that our code depends on other libraries, including SMPL, SMPL-X, PyTorch3D, and uses datasets which each have their own respective licenses that must also be followed.

### Misc
Contact keycharon0122@gmail.com for further questions.

