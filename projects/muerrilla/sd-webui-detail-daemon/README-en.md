
# Detail Daemon
This is an extension for [Stable Diffusion Web UI](https://github.com/AUTOMATIC1111/stable-diffusion-webui), which allows users to adjust the amount of detail/smoothness in an image, during the sampling steps. 

It uses no LORAs, ControlNets, etc., and as a result its performance is not biased towards any certain style and it introduces no new stylistic or semantic features of its own into the generation. This also means that it can work with any model and on any type of image.

<sub>*Model: SSD-1B*<br></sub>
![a close up portrait of a cyberpunk knight-1Lv-0](https://github.com/muerrilla/sd-webui-detail-daemon/assets/48160881/561c33d9-9a5d-4cfc-bee8-de9126b280c1)
*Left: Less detail, Middle: Original, Right: More detail*<br>

<sub>*Model: SD 1.5 (finetuned)*<br></sub>
![face of a cute cat love heart symbol-Zn6-0](https://github.com/muerrilla/sd-webui-detail-daemon/assets/48160881/9fbfb39f-81fb-4951-8f32-20eab410020a)
*Left: Less detail, Middle: Original, Right: More detail*<br>


## How It Works
Detail Daemon works by manipulating the original noise levels at every sampling step, according to a customizable schedule. 

### In Theory
The noise levels (sigmas, i.e. the standard deviation of the noise) tell the model how much noise it should expect, and try to remove, at each denoising step. A higher sigma value at a certain denoising step tells the model to denoise more aggressively at that step and vice versa. 

With a common sigmas schedule, the sigmas start at very high values at the beginning of the denoising process, then quickly fall to low values in the middle, and to very low values towards the end of the process. This curve (along with the timesteps schedule, but that's a story for another day) is what makes it so that larger features (low frequencies) of the image are defined at the earlier steps, and towards the end of the process you can only see minor changes in the smaller features (high frequencies). We'll get back to this later.

Now, if we pass the model a sigmas schedule with values lower than the original, at each step the model will denoise less, resulting a noisier output latent at that step. But then in the steps after that, the model does its best to make sense of this extra noise and turn it into image features. So in theory, *when done in modesty*, this would result in a more detailed image. If you push it too hard, the model won't be able to handle the extra noise added at each step and the end result will devolve into pure noise. So modesty is key. 

### But in Practice
Modesty only gets you so far! Also, wtf are those? As the examples below show, you can't really add that much detail to the image before it either breaks down, and/or becomes a totally different thing. 

<sub>*SD 1.5*<br></sub>
![Modesty](https://github.com/muerrilla/sd-webui-detail-daemon/assets/48160881/2f011a28-0948-48f8-b171-350add6fdd67)
Original sigmas (left) multiplied by .9, .85, .8<br>

<sub>*SDXL*<br></sub>
![1](https://github.com/muerrilla/sd-webui-detail-daemon/assets/48160881/eff2356e-a6dd-4a4e-9c7e-861dec7713eb)
Original sigmas (left) multiplied by .95, .9, .85, .875, .8<br>

That's because: 
1. We're constantly adding noise and not giving the model enough time to deal with it
2. We are manipulating the early steps where the low frequency features of the image (color, composition, etc.) are defined

### Enter the Schedule
What we usually mean by "detail" falls within the mid to high frequency range, which correspond to the middle to late steps in the sampling process. So if we skip the early steps to leave the main features of the image intact, and the late steps to give the model some time to turn the extra noise into useful detail, we'll have something like this:

![3](https://github.com/muerrilla/sd-webui-detail-daemon/assets/48160881/cd47e882-8b56-4321-8c47-c0d689562780)

Then we could make our schedule a bit fancier and have it target specific steps corresponding to different sized details:

![4](https://github.com/muerrilla/sd-webui-detail-daemon/assets/48160881/ea5027d2-3359-4733-afb4-5ae4a1218f38)

Which steps correspond to which exact frequency range depends on the model you're using, the sampler, your prompt (specially if you're using Prompt Editing and stuff), and probably a bunch of other things. There are also fancier things you can (and should) do with the schedule, like pushing the sigmas too low for some heavy extra noise and then too high to clean up the excess and leave some nice details. So you need to do some tweaking to figure out the best schedule for each image you generate, or at least the ones that need their level of detail adjusted. But ideally you should be spending countless hours of your life sculpting the perfect detail adjustment schedule for every image, cuz that's why we're here.

I'll soon provide specific examples addressing different scenarios and some of the techniques I've come up with. (note to self: move these to the wiki page)

## Installation
Open SD WebUI > Go to Extensions tab > Go to Available tab > Click Load from: > Find Detail Daemon > Click Install

Or Go to Install from URL tab > Paste this repo's URL into the first field > Click Install

Or go to your WebUI folder and manually clone this repo into your extensions folder:

`git clone "https://github.com/muerrilla/sd-webui-detail-daemon" extensions/sd-webui-detail-daemon`

## Getting Started
After installation you can find the extension in your txt2img and img2img tabs. 
![2024-07-08 01_43_21-011366](https://github.com/muerrilla/sd-webui-detail-daemon/assets/48160881/045574cb-465c-4991-83c4-d02f803a330b)
### Sliders:
The sliders (and that one checkbox) set the amount of adjustment (positive values → add detail, negative values → remove detail) and the sampling steps during which it is applied (i.e. the schedule). So the X axis of the graph is your sampling steps, normalized to the (0,1) range, and the Y axis is the amount of adjustment. The rest is pretty self-explanatory I think. Just drag things and look at the graph for changes.
### Numbers:
The three number inputs at the buttom are provided because sometimes the slider max/mins are too limiting.
### Modes:
The `cond` and `uncond` modes affect only their respective latents, while `both` affects both (duh!). The `cond` and `uncond` modes are less intense and also allow changes to be applied at earlier steps without diverging too far from the original generation, since the other latent stays intact. 

There's also a minor twist: in the `both` mode if `detail amount` is positive both cond and uncond latents become more detailed. So the more detailed cond latent will try to push the generation towards more detail, while the more detailed uncond latent will try to push towards less detail. This causes more new features/artifacts to pop into the image in this mode.

### Tips:
I'll write up some proper docs on how best to set the parameters, as soon as possible. For now you gotta play around with the sliders and figure out how the shape of the schedule affects the image. I suggest you set your live preview update period to every frame, or every other frame, so you could see clearly what's going on at every step of the sampling process and how Detail Daemon affects it, till you get a good grasp of how this thing works.

## Notes:
- Doesn't support Compositional Diffusion (i.e. the AND syntax) properly. Specially if you have a batch size > 1 or negative weights in your prompts, and the mode is set to `cond` or `uncond`.
- It's probably impossible to use or very hard to control with few-step models (Turbo, Lightning, etc.). Edit: It's managable.
- It works with Forge (`cond` and `uncond` modes are not supported).
- It's not the same as AlignYourSteps, FreeU, etc.
- It is similar (in what it sets out to do, not in how it does it) to the [ReSharpen Extension](https://github.com/Haoming02/sd-webui-resharpen) by Haoming.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---