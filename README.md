# SDToolkit

All in one, batteries-included software to easily generate and upscale AI art using [Stable Diffusion](https://github.com/CompVis/stable-diffusion)

<div style="padding: 1rem; background-color: #ffad59; border-radius: 1rem; color: black; font-size: 1.15rem;">
    <p style="padding: 0; margin: 0;"><b>Disclaimer: </b>This software is still in beta, bugs can and will occur at some point. Please use the <i>Issues</i> tab to report a bug. Thank you for using SDToolkit!</p>
</div>
<br/>

![img](https://i.imgur.com/5c2EjT5.png)
![img](https://i.imgur.com/yXfs4YY.png)

## Features

- No setup required, just install and run
- Video2x upscaler
- GFPGAN face restoration
- Ability to choose a context image for AI to try to match
- Result image viewer with zoom
- Optimized for low VRAM GPUs
- Many helpful tooltips that make it very easy to use
- Decent amount of configuration options

## GFPGAN Integration

SDToolkit offers a built-in GFPGAN for face restoration. This is quite a powerful tool to remove face artifacts and beautify the result. It's definitely recommended to use GFPGAN for every prompt that might have faces in it.

![img](https://i.imgur.com/UecbKYL.png)

## Video2x Upscaler

SDToolkit offers a built-in Video2x upscaler. Please remember that it isn't perfect, and upscaling by a very large factor can cause artifacts.

![img](https://i.imgur.com/OQqkZW7.png)

## Requirements / Info

- OS: Windows 64-bit
- At least 35GB of disk space
- At least 8GB of GPU VRAM is recommended
- At least 16GB of RAM is recommended
- CUDA-enabled GPU is recommended (Nvidia)

Since SDToolkit is all-in-one software, the model, upscaling software (video2x/GFPGAN) and execution environment (Conda/Python) is included in the setup.

Tested with i7-12700KF and GTX 1080 with full precision. (around 6.7GB of VRAM usage)

Half precision is recommended for RTX cards.

## Installation

Just download and run the setup from the Releases tab. Be reminded that it's a huge file, you should have at least 35GB of free disk space.

## License

The software is licensed under GNU Affero Public License and the SD model is licensed under CreativeML Open RAIL-M. You're required to accept both to use this software. You're free to use the generated art files for commercial purposes as long as they conform to the license terms and conditions.

## Used software/models

This software uses Stable Diffusion v1-4 model licensed under CreativeML Open RAIL-M.
You're free to download it yourself at [CompVis's huggingface repository](https://huggingface.co/CompVis/stable-diffusion-v-1-4-original).

Scripts and model execution software provided by [basujindal's fork of stable diffusion](https://github.com/basujindal/stable-diffusion/).

Upscaling model and algorithm is provided by [video2x](https://github.com/k4yt3x/video2x).

GFPGAN 1.3 model and algorithm provided by [Tencent's GFPGAN](https://github.com/TencentARC/GFPGAN).
