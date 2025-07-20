# Image Changer Pop-up

A customizable, interactive pop-up that cycles through images when a button is clicked


## Project Overview

This project creates a stylized pop-up window that displays a series of images. Each time the user clicks the button, the image changes to the next one in sequence. When the last image is reached, the button disappears and a final message is displayed.

## What you'll learn

* CSS Variables for easy customization
* Basic HTML flex structure
* JavaScript event handling
* DOM manipulation

## Features

- Customizable colors, fonts, and styling through CSS variables
- Customizable background image, main image sequence, and all the texts 
- Smooth fade transitions between images
- Mobile-responsive design
- Decorative UI elements (close and shrink buttons)

## 📁 Project Structure

```
image-changer-popup/
├── assets/
│   ├── image-content/
│   │   ├── image-1.png
│   │   ├── image-2.png
│   │   ├── image-3.png
│   │   ├── image-4.png
│   │   ├── image-5.png
│   │   └── image-6.png
│   ├── close-icon.png
│   ├── favicon.png
│   ├── main-bg.png
│   └── shrink-icon.png
├── index.html
├── style.css
└── index.js
```

## How It Works

1. The page loads with a stylized pop-up container
2. The first image is displayed automatically
3. When the user clicks the button:
   - The current image fades out
   - The next image is preloaded
   - Once loaded, the new image fades in
4. After reaching the final image:
   - The button disappears
   - A final message is displayed
  
## How to recreate this project 
1. Clone the project from GitHub
2. Open the project in your preferred text editor (VScode or any text editors)
3. Review the project structure and files:
   - `index.html`: Contains the basic structure of the pop-up
   - `style.css`: Contains all styling and visual customization options
   - `index.js`: Handles the image changing functionality
4. Open `index.html` in your browser to view the project:
   - Double-click the file in your file explorer
5. Customize the project by following the instructions in the code:
   - Modify CSS variables in `style.css` to change colors, fonts, and styling
   - Replace images in the `assets` folder (see Artwork Images Requirements above)
   - Update text content in the HTML file
6. For the JavaScript functionality:
   - I commented the code for the functionality of each line so I recommend trying to redo it yourself :) 
7. Test your changes by refreshing the browser to see updates in real-time
8. For deployment, follow the Netlify hosting instructions in the section below

*Make sure the project structure and file names match the current names you have, or rename them in the code.

## Customization Options

### Artwork Images Requirements
- Animation sequence (4-8 images): 300 x 360px - transparent background png recommended
- Background image: 2093 x 1132 px
- Favicon: flexible sizing, mine is 238 x 279px - transparent background png recommended
- Close and shrink icons: flexible sizing as long as they're square aspect ratio, mine is 287 x 287px

**Make sure the project structure and file names match the current names you have, or rename them in the code.

If you would like to change the dimensions of images in this project, you'll need to update the corresponding aspect ratio in the CSS. Here are the specific sections to modify:

For the image content (animation area):
```css
.image-content {
  /* ... other properties ... */
  height: 65%;
  aspect-ratio: 142.5 / 171; /* Change these values to match your animation dimensions (300x360px) */
}
``` 

For the background image sizing:
```css
body {
  /* ... other properties ... */
  background-size: 100% auto; /* Adjust based on your background image dimensions (2093x1132px) */
}
```


### Colors and Styling

All visual elements can be customized through CSS variables in the `:root` section of `style.css`:

```css
:root {
  /* Colors */
  --color-page-background: #50AFC9;
  --color-main-container-background: #FF5B70;
  --color-inner-container-background: #FFF7F4;
  --color-border: #9E0E2B;
  --color-button-background: #FFF;
  --color-heading-text: #FFF;
  --color-button-text: #9E0E2B;
  --color-message-text: #9E0E2B;
  
  /* Images */
  --image-path-background: url('assets/main-bg.png');
  --image-path-content: url('assets/image-content/image-1.png');
  
  /* Fonts */
  --font-family-main: "Pixelify Sans", sans-serif;
  /* ... and more variables ... */
}
```

### Text Content

Modify the following in the HTML file:

- Page title: `<title>For you &lt;3</title>`
- Header text: `<h1>For you &lt;3</h1>`
- Button text: `<button id="waterButton">Grow!</button>`
- Final message: `<div class="final-message">Have a good day!</div>`

### Images

1. Replace the images in the `assets/image-content/` directory with your own
2. Make sure to keep the same filenames or update the paths in the JavaScript array
3. You can add more images by adding more entries to the array

```javascript
const images = [
  './assets/image-content/image-1.png',
  './assets/image-content/image-2.png',
  // Add more images here...
];
```

## 🌐 Hosting on Netlify

You can deploy this project using Netlify's free plan:

**Prepare your project**:
* Make sure your files are named correctly: `index.html` and `index.js` (if you renamed them)
* Ensure all file paths are correct (case-sensitive)

**Sign up for Netlify**:
* Go to netlify.com and sign up for a free account
* You can sign up using GitHub, GitLab, Bitbucket, or email

**Deploy your site**: 
* Simply drag and drop your project folder onto the Netlify dashboard
* Netlify will automatically deploy your site

**Configure your site**:
* After deployment, you can customize your site name
* Go to "Site settings" → "Change site name"
* Your site will be available at `your-site-name.netlify.app`

**Update your site**:
* If you used the drag and drop method, simply drag and drop your folder again
* If you connected to Git, just push changes to your repository


## Project Extension Ideas

- Add click functionality to the close and shrink icons
- Implement a restart button after reaching the final image
- Add sound effects for button clicks and transitions

