# FFGO: First Frame is the Place to Go For Video Content Custimization

**Official repository for the,  "First Frame is the Place to Go For Video Content Custimization"**

**English:**
[[Website](http://firstframego.github.io)] | [[Paper](https://arxiv.org/abs/2511.15700)] | [[🔴 YouTube: Unofficial Community Showcase](https://www.youtube.com/watch?v=Dks3q5w7sdw)] | [[🔴 Real User Demo](https://github.com/kijai/ComfyUI-WanVideoWrapper/issues/1676)]

**中文:**
[[新智元](https://mp.weixin.qq.com/s/XQGmskJqqFdKx4vCc45tDA)] | [[bilibili](https://www.bilibili.com/video/BV1DQSzB9Eo7/)]


![teaser.gif](https://raw.githubusercontent.com/zli12321/FFGO-Video-Customization/main/./asset/git.gif)



### Coming soon
- Adding our Official ComfyUI workflow support for using our trained LoRAs, with all parameters setup aligned with our inference code.
- TODOs: Releasing LoRAs for smaller-size base models - Hunyuan 1.5 8B or Wan2.2 5B


**🤗 Lora Adapters on Huggingface:**  
- [FFGO-Lora-Adapter](https://huggingface.co/Video-Customization/FFGO-Lora-Adapter)


#### Training Data Sample
- **Please note that we currently provide only a subset of our 50 training videos to demonstrate the data format.**

- Check the ```/Data/train/``` folder

### Setup
- Create Environment
```
conda create -n ffgo python=3.11
conda activate ffgo
```

- Clone Repository and Setup
```
git clone https://github.com/zli12321/FFGO-Video-Customization.git
cd FFGO-Video-Customization
bash setup.sh
```


### Test data
- Test data is available in [Data](https://github.com/zli12321/FFGO-Video-Customization/tree/main/Data/combined_first_frames) folder. All test data involving personal portrait rights has been removed. [0-data.csv](https://github.com/zli12321/FFGO-Video-Customization/blob/main/Data/combined_first_frames/0-data.csv) has the input image path and the caption to generate the video.
- Test data materials are available in [data_materials](https://github.com/zli12321/FFGO-Video-Customization/tree/main/Data/data_materials) folder. These are materials that can form the final input image for video generations.
- Get your own test data: find any images online and segment out the elements as RGBA layer, then combine it with a background using our [combine script]().


### Running Inference

- **When running on your own data, make sure to append our learned transition phrase, "ad23r2 the camera view suddenly changes. ", to your text prompt to ensure the model behaves correctly.**

- **All video results in the paper are generated at 1280 × 720 resolution with 81 frames, which requires an H200 GPU for inference unless memory-saving techniques are applied. For lower resource usage, 640 × 480 resolution videos can be generated without H200. However outputs at this lower resolution can differ significantly in content from the 1280 × 720 results as we shown in the paper.**

- **We are using H200 (141GB RAM) to run inference. If you are using A100 or H100, the memory saving such as cpu offload features need to be turned on.**

1. Download [Wan2.2-I2V-14B](https://huggingface.co/Wan-AI/Wan2.2-I2V-A14B) from huggingface or modelscope and download our Lora adapters. 

```bash
bash download.sh
```


2. Run fun demo video inference

```
bash ./example_single_inference.sh
```

3. Run continuous inference on our example test dataset
```
bash example_inference.sh
```

<!-- 
4. Run 4 Step Lora speedup (Will cause quality degrade and inconsistency.)

```
bash ./example_4_step_lora_inference.sh
``` -->


### Citation
```
@article{chen2025first,
  title={First Frame Is the Place to Go for Video Content Customization},
  author={Chen, Jingxi and Li, Zongxia and Liu, Zhichao and Shi, Guangyao and Wu, Xiyang and Liu, Fuxiao and Fermuller, Cornelia and Feng, Brandon Y and Aloimonos, Yiannis},
  journal={arXiv preprint arXiv:2511.15700},
  year={2025}
}
```