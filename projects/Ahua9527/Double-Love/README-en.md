# Double Love

<div align="center">

[![GitHub license](https://img.shields.io/github/license/Ahua9527/Double-Love)](https://github.com/Ahua9527/Double-Love/blob/main/LICENSE)
![GitHub stars](https://img.shields.io/github/stars/Ahua9527/Double-Love)

🎬 Love Between Frames, Double the Efficiency

[//]: # (Easter egg hidden in the code)
<!Double Love: Let every shot hide the frame rate I never spoke of -->

[English](./README.en.md) · Simplified Chinese · [Online Demo](https://double-love.ahua.space)

</div>

Double Love provides automated, standardized processing for slating metadata. Supports offline use. Through batch processing and local processing, it enables seamless integration with Adobe Premiere, Silverstack, and DTG Slate, ensuring metadata consistency. Effectively improves post-production workflow efficiency.

## ✨ Features

- 🎬 Support for film industrialization workflow
- 📝 Intelligent metadata normalization
- ⚡ Zero-latency local processing
- 🧩 Seamless integration with Adobe Premiere

## 🚀 Quick Start

### Basic Workflow

1. Slating: Use DTG Slate to generate interactive slating forms
2. Data management: Import slating data via Silverstack Lab
3. File export: Generate Adobe Premiere Pro XML
4. Standardization: Use Double Love for intelligent optimization

Example:
- Input xml: `UnitA_304_20250127.xml`
- Output xml: `UnitA_304_20250127_Double_LOVE.xml`

### Detailed Examples

#### Filename Optimization
- The program automatically processes the format of scene, shot, and take numbers
- Automatically pads numbers with leading zeros
- Automatically enforces case conventions
- Automatically removes redundant underscores

#### Clip Naming Rules

The processed clip name follows this format:
```
{ProjectPrefix}{Scene}_{Shot}_{Take}{Camera}{Rating}
```

- `prefix`: Custom prefix (optional)
- `scene`: Scene number (3 digits, e.g., 001)
- `shot`: Shot number (2 digits, e.g., 01)
- `take`: Take number (2 digits, e.g., 01)
- `camera`: Camera identifier (lowercase letter, e.g., a)
- `Rating`: Rating (ok/kp/ng)

#### Rating Processing
- `Circle` → `ok`
- `KEEP` → `kp`
- `NG` → `ng`

#### DIT Information
- Automatically adds DIT info: 'DIT: 哆啦Ahua 🌱'
- Please deploy yourself if you wish to remove it 😁😁

#### Custom Prefix Example

1. Set prefix to "PROJECT_A_":
   - Input file: `A304C007_250123G3`
   - Output file: `PROJECT_A_004_01_07a_kp`

2. No prefix:
   - Input file: `A304C007_250123G3`
   - Output file: `004_01_07a_kp`

#### Sequence Resolution Setting Example

1. FHD resolution (default):
   - Width: 1920
   - Height: 1080   
2. DCI 2K resolution (custom):
   - Width: 2048
   - Height: 1080   

#### Batch Processing Example

1. Upload multiple files at once:
   ```
   UnitA_304_20250123.xml
   UnitA_305_20250124.xml
   UnitA_306_20250125.xml
   ```

2. After processing, you will get:
   ```
   UnitA_304_20250123_Double_LOVE.xml
   UnitA_305_20250124_Double_LOVE.xml
   UnitA_306_20250125_Double_LOVE.xml
   ```

## 🛠️ Tech Stack

- React 18
- TypeScript
- Vite
- Tailwind CSS
- Lucide Icons
- PWA Support

## 📦 Installation & Usage

1. Clone the project

```bash
git clone https://github.com/Ahua9527/Double-Love.git
cd Double-Love
```

2. Install dependencies

```bash
npm install
```

3. Local development

```bash
npm run dev
```

4. Build the project

```bash
npm run build
```

## 🔒 Security Notes

- All file processing is done locally in the browser, never uploaded to the server
- Supports a maximum file size of 50MB
- Only XML files are supported

## 🌈 Developer Notes

### Project Structure

```
Double-Love/
├── src/
│   ├── components/     # React components
│   ├── context/        # React Context
│   ├── utils/          # Utility functions
│   ├── styles/         # Style files
│   └── App.tsx         # Main app component
├── public/             # Static assets
└── ...config files
```

## 📃 License

[MIT License](LICENSE)

## 🤝 Contribution Guide

Issues and Pull Requests are welcome!

## 👨‍💻 Author

哆啦Ahua🌱

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---