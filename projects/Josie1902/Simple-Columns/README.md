# 👋 Overview
![Simple Columns](https://drive.google.com/uc?export=view&id=1Q4Vrx3FpE14U_6RtGkmfQg9UnsNJKx-j)

- [👋 Overview](#-overview)
  - [📝 Description](#-description)
  - [⚙️ How to Use](#️-how-to-use)
    - [Example: Creating Columns with Code Blocks](#example-creating-columns-with-code-blocks)
    - [Example: Specifying Column Widths via YAML](#example-specifying-column-widths-via-yaml)
  - [✨ Features](#-features)
  - [🔧 Global Settings](#-global-settings)
    - [Container Borders](#container-borders)
    - [Resizer Settings](#resizer-settings)
    - [Advanced Settings](#advanced-settings)
  - [⚡️ Local Settings](#️-local-settings)
    - [Available Local Settings:](#available-local-settings)
  - [🚀 Future Works](#-future-works)


## 📝 Description
The **Simple Columns** plugin for Obsidian lets you create easily resizable and customizable columns in your notes. Whether you're organizing tasks, breaking down content, or visualizing ideas, this plugin provides a simple markdown syntax to quickly adjust and structure your layouts.

## ⚙️ How to Use 
To create a simple column layout, you can either:
- Right-click in your note and select the option from the submenu.

![Submenu](https://drive.google.com/uc?export=view&id=1Nu2tmvENJFtsnbDIqnk4XqT05WSJexN_)

- Use the command palette to insert columns directly. For example, type "Add 2 columns" to insert a two-column layout into your note.

When you create columns, the plugin generates the following markdown with a unique ID for each column:

```columns
id: b52707b0-ce15-6458-825d-32615b4b7h85
===
Column 1

===
Column 2
```

### Example: Creating Columns with Code Blocks
To create a layout with code blocks inside columns, use the following syntax (start and end with 4 backticks: ````):

`````
````columns
id: b52707b0-ce15-6458-825d-32615b4b7h85
===
Column 1
```javascript
console.log("Hello world")
```
===
Column 2
````
`````

### Example: Specifying Column Widths via YAML

You can set custom widths for specific columns using YAML. Columns with a specified ratio will take priority, and any columns without a defined ratio will share the remaining space equally.

```
id: b52707b0-ce15-6458-825d-32615b4b7h85
column-1-ratio: 60%
===
Column 1
hello
===
Column 2
```

Explanation:
- column-1-ratio: 60% → Column 1 takes 60% of the container width.
- Column 2 (not specified) automatically fills the remaining 40%.
- You can define ratios for multiple columns (column-2-ratio, column-3-ratio, etc.), up to 4 columns.

## ✨ Features
- **Unique Column IDs**: Each column is generated with a unique ID, ensuring you can style or reference columns independently.
- **Easily Resizable Columns**: Columns are fully resizable, giving you complete control over the layout of your content.
- **Responsive Layouts**: Columns adjust automatically based on your screen size, providing a clean and adaptable layout.
- **Highly Customizable**: Columns are fully adjustable, allowing you to easily control their size, spacing, and alignment to suit your needs.

## 🔧 Global Settings

The **Global Settings** allow you to define default styles and behaviors for all columns across your Obsidian vault. These settings can be accessed and configured in the plugin settings.

![Global Settings](https://drive.google.com/uc?export=view&id=1WPBg0Y3pffL5pw1dVRUC81TMMlaod-eK)

### Container Borders
You can customize the appearance of column containers with borders for better visibility.

- **Show Container Borders**: Toggle this setting to display borders around each column container.
- **Border Width**: Set the width of the column container borders.
- **Border Color**: Choose the color of the borders.
- **Border Transparency**: Adjust the transparency of the borders using RGBA color codes. The alpha value (last number) controls the transparency.

### Resizer Settings
You can also customize the column resizer's appearance and behavior.

- **Show Resizer**: Toggle this setting to show or hide the column resizer between columns. The resizer will only appear when you hover over the column divider.
- **Resizer Width**: Set the width of the resizer element.
- **Resizer Color**: Choose the color of the resizer.
- **Resizer Transparency**: Adjust the transparency of the resizer using RGBA color codes.

### Advanced Settings
- **Reset Styles**: This will revert all column styles, including border settings and resizer styles, back to their default values.
- **Clear Local Storage**: This will remove all custom settings and restore the plugin to its initial state. Use this option if you encounter issues or want to start fresh.


## ⚡️ Local Settings
The **Local Settings** allow you to apply more **granular customizations** to individual columns within your notes.

![Local Settings](https://drive.google.com/uc?export=view&id=1q11NA49CeizEAozavC1YAiiSI7J7oe5U)

### Available Local Settings:
- **Reset All Styles**: Revert all custom styles for the column to their default settings.
- **Show Border**
- **Set Border Color and Transparency**
- **Show Resizer**: Toggle the display of the column resizer. The resizer will appear only on hover.
- **Set Resizer Color and Transparency**
- **Set Text Color**
- **Set Background Color and Transparency**
- **Set Text Alignment**: Align the text within the column (e.g., `left`, `center`, `right`).

## 📦 Installation
This plugin is now available in the Obsidian Community Plugins! 🎉

1. In Obsidian, go to Settings > Community Plugins.
2. Click Browse and search for Simple Columns.
3. Click Install, then Enable the plugin.

## 🚀 Future Works
1. Add background image to individual columns
2. Enable nested columns
