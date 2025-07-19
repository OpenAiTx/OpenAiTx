# DreamO Comfyui
[DreamO](https://github.com/bytedance/DreamO) ComfyUI native implementation.

[![arXiv](https://img.shields.io/badge/arXiv-Paper-<COLOR>.svg)](https://arxiv.org/abs/2504.16915) [![demo](https://img.shields.io/badge/🤗-HuggingFace_Demo-orange)](https://huggingface.co/spaces/ByteDance/DreamO) <br>

<img width="1485" alt="Image" src="https://github.com/user-attachments/assets/0954b0bf-63db-463f-ae25-9cd983b462db" />


> [!Important]  
> **2025.06.24** - We are excited to release **DreamO v1.1** with significant improvements in image quality, reduced likelihood of body composition errors, and enhanced aesthetics. [Learn more about this model](https://github.com/bytedance/DreamO/blob/main/dreamo_v1.1.md)


## Install
This implementation is based on the 2025.5.19 version of ComfyUI (commit ID: e930a38). Compatibility issues may occur if you're using an older version.
```shell
# manual install
cd custom_nodes
git clone https://github.com/ToTheBeginning/ComfyUI-DreamO.git
# Please make sure that you have installed the forked version of facexlib, not the original facexlib. Otherwise, you may encounter face parsing errors.
pip install -r requirements.txt
# restart comfyui
```

## Models
### FLUX models
If your machine already has FLUX models downloaded, you can skip this.
- Original bf16 model: [dit](https://huggingface.co/black-forest-labs/FLUX.1-dev/blob/main/flux1-dev.safetensors), [t5](https://huggingface.co/comfyanonymous/flux_text_encoders/blob/main/t5xxl_fp16.safetensors)
- 8 bit FP8: [dit](https://huggingface.co/Comfy-Org/flux1-dev/blob/main/flux1-dev-fp8.safetensors), [t5](https://huggingface.co/comfyanonymous/flux_text_encoders/blob/main/t5xxl_fp8_e4m3fn.safetensors)
- Clip and VAE (for all models): [clip](https://huggingface.co/comfyanonymous/flux_text_encoders/blob/main/clip_l.safetensors), [vae](https://huggingface.co/black-forest-labs/FLUX.1-schnell/blob/main/ae.safetensors)

### DreamO models
- Download all files ending with `.safetensors` in https://huggingface.co/ByteDance/DreamO/tree/main/comfyui => `ComfyUI/models/loras`.
- 🔥🔥**v1.1**: Download all files ending with `.safetensors` in https://huggingface.co/ByteDance/DreamO/tree/main/v1.1 => `ComfyUI/models/loras`.
- (Support auto-download) Download [dreamo-embedding](https://huggingface.co/ByteDance/DreamO/blob/main/embedding.safetensors) => `ComfyUI/models/dreamo`
- (Support auto-download) Download [ben2](https://huggingface.co/PramaLLC/BEN2/blob/main/model.safetensors) => `ComfyUI/models/dreamo`
- Download [flux-turbo](https://huggingface.co/alimama-creative/FLUX.1-Turbo-Alpha/blob/main/diffusion_pytorch_model.safetensors) => `ComfyUI/models/loras`, and rename it to `flux-turbo.safetensors`

## Workflows
Please fine the workflows in [workflows](workflows) folder, [this v1.1 workflow](https://raw.githubusercontent.com/ToTheBeginning/ComfyUI-DreamO/main/workflows/dreamo_comfyui_v1.1.json) is the latest version.

The v1.1 model, when combined with the [Super-Realism LoRA](https://huggingface.co/strangerzonehf/Flux-Super-Realism-LoRA), can further enhance realism. However, since it's a realism-focused LoRA, it may affect style transfer. Use it as needed.


## Nodes
- DreamOProcessorLoader
  - This node loads two image preprocessing models: the BEN2 model for background removal and the facexlib model for aligned face detection.
- DreamORefEncode
  - This node encodes the reference image into a latent representation based on the selected task type. Three task types are available: ip, id, and style.
    - ip: will remove the backgound of the reference image
    - id: will align&crop the face from the reference image, similar to PuLID
    - style: will keep the backgound of the reference image. you still need trigger meta prompt to activate the style transfer task
- ApplyDreamO
  - This node adds a hook to the Flux model to support concatenating the reference latent with the noisy latent.

## Note
- The current code does not implement the logic for true CFG, which means you need to set cfg=1 in the sampler node
- As mentioned earlier, we're new to ComfyUI. If you have better workflows or suggestions, please let us know.

Contributions are welcome!

    
## Acknowledgement
The implementation of the ComfyUI plugin refers to [ComfyUI_PuLID_Flux_ll](https://github.com/lldacing/ComfyUI_PuLID_Flux_ll).

## Future Plans
✅ Please follow our base repository [DreamO](https://github.com/bytedance/DreamO) — we will be releasing an update to the model in the coming weeks.


## :e-mail: Contact
If you have any comments or questions, please [open a new issue](https://github.com/xxx/xxx/issues/new/choose) or contact [Yanze Wu](https://tothebeginning.github.io/) and [Chong Mou](https://raw.githubusercontent.com/ToTheBeginning/ComfyUI-DreamO/main/mailto:eechongm@gmail.com).
