# react-hooks-svgdrawing

[![npm version](https://badge.fury.io/js/react-hooks-svgdrawing.svg)](https://www.npmjs.com/package/react-hooks-svgdrawing) [![npm download](https://img.shields.io/npm/dt/react-hooks-svgdrawing.svg)](https://www.npmjs.com/package/react-hooks-svgdrawing)

`react-hooks-svgdrawing` is React drawing library. This library is a React extension of [svg-drawing](https://github.com/kmkzt/svg-drawing)

**[demo](https://kmkzt.github.io/react-hooks-svgdrawing/)**

## Get started

```shell
yarn add react react-hooks-svgdrawing
```

## How to use

This is example.

```javascript
import React from 'react'
import { useSvgDrawing } from 'react-hooks-svgdrawing'

const Drawing = () => {
  const [renderRef, draw] = useSvgDrawing()
  // Drawing area will be resized to fit the rendering area
  return <div style={{ width: 500, height: 500 }} ref={renderRef} />
}
```

useSvgDrawing options.

```javascript
const [renderRef, draw] = useSvgDrawing({
  penWidth: 10, // pen width
  penColor: '#e00', // pen color
  close: true, // Use close command for path. Default is false.
  curve: false, // Use curve command for path. Default is true.
  delay: 60, // Set how many ms to draw points every.
  fill: ''// Set fill attribute for path. default is `none`
})
```

Drawing methods.

```javascript
const [renderRef, draw] = useSvgDrawing()

// Call the SvgDrawing. Access the current settings of penWidth, penColor etc
// Details are https://github.com/kmkzt/svg-drawing.
console.log(draw.instance.penColor) // #333
console.log(draw.instance.penWidth) // 1

// Erase all drawing.
draw.clear()

// Download image.
draw.download() // default svg download
draw.download('svg')
draw.download('png')
draw.download('jpg')

// Get base64 string
draw.getBase64()

// Undo drawing.
draw.undo()

// Change pen config
draw.changePenColor('#00b')
// Change pen width
draw.changePenWidth(10)
// Change fill attribure of svg path element.
draw.changFill('#00b')
// Change throttle delay of  drawing
draw.changeDelay(10)
// Set whether to use curved comma for svg path element.
draw.changCurve(false)
// Set whether to use curved comma for svg path element.
draw.changeClose(true)

// get svgXML
// return SVGElement
console.log(draw.getSvgXML()) // <svg width="502" height="502"><path stroke-width="3" stroke="#000" fill="none" stroke-linejoin="round" stroke-linecap="round" d="M 156.671875 284.7265625 C 156.671875 286.1465625 156.671875 287.89984375 156.671875 291.83984375  ...
```

[example code](src/example/)
