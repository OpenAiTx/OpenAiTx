# Fluid Image Web Component

Images that scale intelligently to any desired size (within reasonable limits).

![Fluid Images](https://raw.githubusercontent.com/VoiceNGO/fluid-img/refs/heads/main/resources/images/responsive-images.jpg)

**Tiny!:** 7kb minified & gzipped

## Usage

```html
<script src="fluid-img.js"></script>
<fluid-img src="image.jpg"></fluid-img>
```

That's it. Scale the images as you wish, and they will just do their thing.

## Demo

[Demo Here](https://voicengo.github.io/fluid-img/public/fluid-demo.html)

A playground is also available for [experimenting with your own images](https://voicengo.github.io/fluid-img/public).

## Installation

### Client Library

```sh
npm install fluid-img
```

Then import `fluid-img` in your project, which provides and registers the web-component:

```ts
import 'fluid-img';
```

Or include the script from jsdelivr or unpkg:

```html
<script src="https://cdn.jsdelivr.net/npm/fluid-img@latest/dist/fluid-img.js" />

<!-- or -->

<script src="https://unpkg.com/fluid-img@latest/dist/fluid-img.js" />
```

### Caveats

The fluid image component works best for horizontally or vertically scaling images within a range of approximately 0.5x to 1.5x their original size. While it can handle larger or smaller scales, visual quality may degrade quickly. It is not recommended for images where precise pixel integrity is critical, such as portraits, graphs, or detailed technical drawings, as seam carving introduces distortions. It is highly recommended to test your images at various sizes to ensure they meet your visual expectations.

#### CORS

Due to browser security restrictions, images loaded from a different origin (domain, protocol, or port) than the web page will trigger a Cross-Origin Resource Sharing (CORS) error. This component requires access to the raw pixel data of the image, which is restricted by CORS.

To use images from a different origin, the server hosting the images must be configured to send appropriate CORS headers (e.g., `Access-Control-Allow-Origin: *` or `Access-Control-Allow-Origin: your-domain.com`). Without these headers, the component will not be able to process the image.

(FYI, for testing purposes, any image on imgur has the necessary CORS headers)

#### Fallback

If the component fails to load or process the image, or throws an internal error, it will gracefully degrade to injecting a standard `<img>` tag into the `<fluid-img>` component, with 100% width & height, ensuring the image is still displayed.

## Options

Usage: `<fluid-img src="image.jpg" generator="random" max-carve-up-scale="5"></fluid-img>`

By default, the `random` generator is used as it is the fastest.

| Option                         | Values                           | Default      | Description                                                                                                            |
| ------------------------------ | -------------------------------- | ------------ | ---------------------------------------------------------------------------------------------------------------------- |
| `src`                          | URL                              |              | The URL of the image to be processed.                                                                                  |
| `generator`                    | `random`, `predictive`           | `predictive` | The seam carving generator to use. `random` is faster but lower quality.                                               |
| `scaling-axis`                 | `horizontal`, `vertical`, `auto` | `horizontal` | The axis for scaling. `auto` scales horizontally or vertically based on aspect ratio changes.                          |
| `mask`                         | URL                              |              | The URL of a mask image. Black areas of the mask have a lower energy and are more likely to be preserved.              |
| `carving-priority`             | Number (0-1, e.g. `0.5`)         | `1`          | The percentage of scaling to be done by seam carving vs. traditional image scaling.                                    |
| `max-carve-up-seam-percentage` | Number (0-1, e.g. `0.5`)         | `0.6`        | The maximum percentage of seams to insert when scaling up. Limits the creation of new seams to preserve image quality. |
| `max-carve-up-scale`           | Number (e.g. `3`)                | `3`          | The maximum enlargement factor using seam carving. Beyond this, traditional scaling is used.                           |
| `max-carve-down-scale`         | Number (0-1, e.g. `0.7`)         | `0.7`        | The maximum percentage of the image to be removed by seam carving when downscaling.                                    |

### Generator specific options

Generator-specific options are added to the `<fluid-img>` component but are only valid when the corresponding
`generator` attribute is also set

#### Random & Predictive Generator Options

| Option             | Values                | Default | Description                                       |
| ------------------ | --------------------- | ------- | ------------------------------------------------- |
| `batch-percentage` | Number (0-1, e.g 0.1) | 0.1     | The percentage of seams to generate per batch     |
| `min-batch-size`   | Number (e.g. `10`)    | 10      | The minimum number of seams to generate per batch |

## How it works

Seam carving is a content-aware image resizing technique that intelligently removes or adds pixels, allowing an image to be resized without distorting important content. For more information, see the [Wikipedia article](https://en.wikipedia.org/wiki/Seam_carving) on the topic.

Historically, seam carving was too computationally intensive for real-time use in web browsers. However, this limitation can be overcome by using alternative algorithms that are less demanding and work well in many scenarios.

There are two implementations of the seam carving generator:

### Random Carving

The random seam carving approach abandons the traditional seam carving algorithm, which is too slow for real-time browser execution.

Instead, it generates a set of random seams that provide 100% image coverage by connecting each pixel in a row to a neighboring pixel in the next. It then iterates through each seam, calculates its energy, and discards a batch of the lowest-energy seams. This process repeats until the desired number of seams is achieved. This method produces surprisingly good results for many images.

### Predictive Carving

Similar to random carving, this method generates an energy map and creates seams in batches. It also generates a minimal energy map for each batch. The core idea is to create both "good" and "bad" seams. Good seams have low energy and are kept. Bad seams incorporate high-energy pixels, allowing them to be filtered out later.

Starting from the first row, it connects pairs of pixels to corresponding pairs in the next row. The lower-energy seam from the running calculation is connected to the lower-energy seam from the minimal energy map.

The result is one truly optimal seam, many "very good" seams, many "very bad" seams, and a lot of mediocre ones. We select a batch of the "good" seams, discard the rest, and repeat the process.

##

## TODO

### High Priority

- [x] Web component
- [x] Renderer that takes data from generators and scales to any size
- [x] Random generator
- [x] Vertical carving
- [x] Predictive generator
- [ ] Web workers for all generators

### Low Priority

- [x] Masking
- [ ] Facial recognition

### Pipe Dream

- [ ] 2D carving

## Licensing

This software is licensed under the Fluid-Img Revenue-Limited License.

**Free use** for individuals and organizations with annual gross revenue under $10,000,000 USD.

**Commercial license required** for organizations with $10M+ annual revenue. Contact [licensing@voice.ngo] for commercial licensing terms.

See the [LICENSE](./LICENSE) file for complete terms.
