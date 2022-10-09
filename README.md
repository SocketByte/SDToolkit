# SDToolkit

All in one, batteries-included software to easily generate and upscale AI art using [Stable Diffusion](https://github.com/CompVis/stable-diffusion).

![Image](https://i.imgur.com/EyjdVXj.png)
![Image](https://i.imgur.com/kB3mL6e.png)

## Requirements / Info

- OS: Windows 64-bit
- At least 25GB of disk space
- At least 8GB of GPU VRAM is recommended
- At least 16GB of RAM is recommended
- CUDA-enabled GPU is recommended (Nvidia)

Since SDToolkit is all-in-one software, the model, upscaling software (video2x) and execution environment (Conda/Python) is included in the setup.

Tested with i7-12700KF and GTX 1080 with full precision. (around 6.7GB of VRAM usage)

Half precision is recommended for RTX cards.

## Installation

Just download and run the setup from the Releases tab. Be reminded that it's a huge file, you should have at least 20-25GB of free disk space.

## License

The software is licensed under GNU Affero Public License and the SD model is licensed under CreativeML Open RAIL-M. You're required to accept both to use this software. You're free to use the generated art files for commercial purposes as long as they conform to the license terms and conditions.

## Used software/models

This software uses Stable Diffusion v1-4 model licensed under CreativeML Open RAIL-M.
You're free to download it yourself at [CompVis's huggingface repository](https://huggingface.co/CompVis/stable-diffusion-v-1-4-original).

Scripts and model execution software provided by [basujindal's fork of stable diffusion](https://github.com/basujindal/stable-diffusion/).

Upscaling model and algorithm is provided by [video2x](https://github.com/k4yt3x/video2x).
