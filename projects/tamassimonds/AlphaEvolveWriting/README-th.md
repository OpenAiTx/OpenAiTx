<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# AlphaEvolve Writing

![AlphaEvolve Writing Process](https://raw.githubusercontent.com/tamassimonds/AlphaEvolveWriting/main/assets/AlphaWriteProcess.png)

คุณสามารถอ่านคำอธิบายฉบับเต็มได้ที่ [ที่นี่](https://tobysimonds.com/research/2025/06/06/LLM-Self-Rewarding-copy.html)

คุณสามารถดูตัวอย่างเรื่องราวที่ส่งเข้าประกวดการเขียนได้ [ที่นี่](https://blog.reedsy.com/short-story/wo9iuy/#comments)

ระบบการเขียนยุคใหม่ที่ใช้โมเดล AI ในการสร้าง ประเมิน และพัฒนางานเขียนหรือเรื่องราวสร้างสรรค์ผ่านการแข่งขันแบบวนซ้ำ สร้างด้วยสถาปัตยกรรม Python ที่เป็นโมดูลและสะอาดตามหลักการออกแบบยุคใหม่




## ✨ คุณสมบัติ

- 🧬 **อัลกอริทึมเชิงวิวัฒนาการ**: เรื่องราวจะวิวัฒนาการผ่านการแข่งขันที่ขับเคลื่อนโดย AI
- 🎯 **โหมดการเขียนสองแบบ**: การเล่าเรื่องสร้างสรรค์และการปรับปรุงงานเขียนทั่วไป
- 🏆 **ระบบการแข่งขันแบบ ELO**: จัดอันดับอย่างซับซ้อนด้วยการเปรียบเทียบแบบเป็นคู่
- 🌐 **เว็บอินเทอร์เฟซ**: เครื่องมือสำหรับมนุษย์ในการตรวจสอบและเปรียบเทียบเรื่องราว
- 🔧 **ปรับแต่งได้**: ปรับแต่งได้อย่างหลากหลายผ่านการตั้งค่าไฟล์ JSON

## 🚀 เริ่มต้นอย่างรวดเร็ว

### การติดตั้ง


```bash
# Clone the repository
git clone https://github.com/your-org/alphaevolve-writing
cd alphaevolve-writing

# Install with uv (recommended)
uv sync

# Or install with pip
pip install -e .

# Configure your API keys (see Configuration section below)
```
### เรียกใช้งานวิวัฒนาการ


```bash
# Run 5 evolution iterations
python evolve.py 5

# Fresh start with 3 iterations
python evolve.py 3 --fresh

# Use general writing mode
python evolve.py 5 --general

# Show help
python evolve.py --help
```
## 🏗️ สถาปัตยกรรม

ระบบนี้ปฏิบัติตามหลักการออกแบบ Python สมัยใหม่ โดยมีการแยกหน้าที่อย่างชัดเจน:


```
├── src/
│   ├── core/           # Pipeline orchestration
│   │   └── pipeline.py # Main EvolutionPipeline class
│   ├── generators/     # Story generation logic
│   │   ├── story_generator.py      # Initial & next batch generators
│   │   ├── generate_response.py    # Creative writing generation
│   │   ├── generate_response_general.py # General writing generation
│   │   └── judge_response.py       # AI judging system
│   ├── rankers/        # ELO ranking system
│   │   ├── elo_rank.py            # Core ELO algorithm
│   │   └── tournament_runner.py    # Tournament management
│   └── utils/          # Utility functions
│       └── inference.py           # Multi-provider LLM interface
├── evolve.py           # Clean CLI entry point
├── pyproject.toml      # Modern Python packaging
├── config.json         # Configuration
└── web_interface/      # Web UI for validation
```
### องค์ประกอบสำคัญ

- **`EvolutionPipeline`**: ตัวควบคุมหลักที่จัดการวงจรวิวัฒนาการทั้งหมด
- **`InitialStoryGenerator`**: สร้างเรื่องราวรุ่นแรกจากพรอมต์
- **`NextBatchGenerator`**: วิวัฒนาการเรื่องเด่นให้เป็นเวอร์ชันที่ปรับปรุงขึ้น
- **`TournamentRunner`**: จัดการการแข่งขัน ELO เพื่อจัดอันดับเรื่องราว
- **`EloRankingSystem`**: ใช้อัลกอริทึมการจัดอันดับที่ซับซ้อน

## 📖 วิธีการทำงาน

ระบบจะดำเนินการตามวงจรวิวัฒนาการสามขั้นตอน:

### 1. **สร้างชุดแรก**
- สร้างเรื่องราวหลายเรื่องจากพรอมต์ของคุณ
- ใช้โมเดล AI ที่ปรับแต่งได้ (GPT, Claude, Llama ฯลฯ)
- กำหนดค่า ELO เริ่มต้น

### 2. **จัดการแข่งขัน ELO**
- เรื่องราวแข่งขันกันแบบจับคู่เปรียบเทียบ
- AI ทำหน้าที่ตัดสินตามเกณฑ์ของคุณ
- ปรับปรุงค่า ELO ตามผลแพ้/ชนะ

### 3. **สร้างชุดถัดไป**
- เลือกเรื่องที่ทำคะแนนได้ดีที่สุด
- สร้างเวอร์ชันใหม่ที่ได้รับการปรับปรุง
- ทำซ้ำกระบวนการนี้หลายรุ่น

กระบวนการวนซ้ำนี้จะทำให้ผลงานเขียนพัฒนาดีขึ้นอย่างต่อเนื่อง

## ⚙️ การกำหนดค่า

### การตั้งค่าพื้นฐาน

แก้ไขไฟล์สำคัญเหล่านี้:

- **`prompt.txt`** - พรอมต์/ธีมของคุณ
- **`rubric.txt`** - เกณฑ์การตัดสินสำหรับประเมินผล
- **`config.json`** - การตั้งค่าระบบ

### การตั้งค่า API Keys

ระบบรองรับผู้ให้บริการ AI หลายรายโดยกำหนดค่าใน `config.json` ซึ่งกำหนดโมเดลกับผู้ให้บริการ และระบุว่า environment variable ใดใช้เก็บ API key:


```json
{
  "llm_providers": {
    "openai": {
      "type": "openai",
      "base_url": "https://api.openai.com/v1",
      "api_key_env": "OPENAI_API_KEY"
    },
    "anthropic": {
      "type": "anthropic", 
      "api_key_env": "ANTHROPIC_API_KEY"
    },
    "deepinfra": {
      "type": "openai_compatible",
      "base_url": "https://api.deepinfra.com/v1/openai",
      "api_key_env": "DEEPINFRA_API_KEY"
    },
    "deepseek": {
      "type": "openai_compatible",
      "base_url": "https://api.deepseek.com/v1",
      "api_key_env": "DEEPSEEK_API_KEY"
    },
    "gemini": {
      "type": "openai_compatible",
      "api_key_env": "GEMINI_API_KEY",
      "base_url": "https://generativelanguage.googleapis.com/v1beta/openai/"
    }
  },
  "model_provider_mapping": {
    "gpt-4": "openai",
    "gpt-3.5-turbo": "openai", 
    "claude-3-sonnet-20240229": "anthropic",
    "meta-llama/Meta-Llama-3-70B-Instruct": "deepinfra",
    "deepseek-chat": "deepseek",
    "gemini-2.5-flash": "gemini"
  }
}
```
จากนั้นตั้งค่า API keys ของคุณเป็น environment variables:


```bash
export OPENAI_API_KEY="your-openai-key"        # For GPT models
export ANTHROPIC_API_KEY="your-anthropic-key"  # For Claude models  
export DEEPINFRA_API_KEY="your-deepinfra-key"  # For Llama models
export DEEPSEEK_API_KEY="your-deepseek-key"    # For DeepSeek models
export GEMINI_API_KEY="your-gemini-key"          # For Gemini models
```
คุณเพียงแค่ต้องตั้งค่า key สำหรับผู้ให้บริการที่คุณต้องการใช้งานเท่านั้น ระบบจะส่งคำขอโมเดลไปยังผู้ให้บริการที่ถูกต้องโดยอัตโนมัติตามค่าคอนฟิก

### ตัวเลือกการกำหนดค่า

ไฟล์ `config.json` ควบคุมพฤติกรรมทั้งหมดของระบบ:


```json
{
  "batch_generation": {
    "num_stories": 10,
    "model": "gpt-4",
    "initial_elo": 1500
  },
  "elo_ranking": {
    "tournament_rounds": 50,
    "judge_model": "claude-3-sonnet-20240229",
    "k_factor": 32
  },
  "next_batch_generation": {
    "top_stories_to_select": 3,
    "variants_per_story": 2,
    "include_original_stories": true
  },
  "evolution_pipeline": {
    "max_iterations": 5,
    "auto_continue_from_existing": true
  }
}
```
## 🎭 โหมดการเขียน

### โหมดเขียนเชิงสร้างสรรค์ (ค่าเริ่มต้น)
- มุ่งเน้นการเล่าเรื่อง พัฒนาตัวละคร และเทคนิคการเล่าเรื่อง
- ใช้กลยุทธ์การสร้างแบบภารกิจ
- ปรับแต่งเพื่อความคิดสร้างสรรค์และการมีส่วนร่วม

### โหมดเขียนทั่วไป (`--general`)
- มุ่งเน้นงานวิชาการ เรียงความ รายงาน และงานเขียนเชิงวิชาชีพ
- ใช้วิธีวิเคราะห์และมีโครงสร้างชัดเจน
- ปรับแต่งเพื่อความชัดเจนและโน้มน้าวใจ

## 🔧 การตั้งค่าขั้นสูง

### การปรับแต่งกลยุทธ์การสร้างเนื้อหา

สำหรับผู้ใช้ขั้นสูง คุณสามารถปรับแต่งพรอมต์การสร้าง สไตล์ผู้เขียน และชุดภารกิจได้โดยแก้ไขไฟล์ในไดเรกทอรี `src/generators/`:

#### การปรับแต่งงานเขียนเชิงสร้างสรรค์ (`src/generators/generate_response.py`)

**ชุดภารกิจ** - กำหนดแนวทางและเป้าหมายเชิงสร้างสรรค์:

```python
mission_sets = {
    "emotional_depth": [
        "Focus on the psychological depth of characters",
        "Explore complex emotional landscapes", 
        "Create moments of genuine human connection"
    ],
    "narrative_craft": [
        "Experiment with unique narrative structures",
        "Use vivid, sensory descriptions",
        "Create compelling story arcs"
    ],
    "dialogue_mastery": [
        "Write authentic, character-specific dialogue",
        "Use subtext and implied meaning",
        "Balance dialogue with action and description"
    ]
}
```
**สไตล์ผู้เขียน** - เลียนแบบแนวทางการเขียนที่แตกต่างกัน:

```python
author_styles = [
    "Write with the psychological insight of Virginia Woolf",
    "Adopt the sparse, powerful prose of Ernest Hemingway", 
    "Use the magical realism style of Gabriel García Márquez",
    "Employ the detailed world-building of Tolkien"
]
```
#### การปรับแต่งการเขียนทั่วไป (`src/generators/generate_response_general.py`)

**หัวข้อเน้นทางวิชาการ** - มุ่งเน้นไปที่โดเมนการเขียนเฉพาะทาง:

```python
academic_focuses = [
    "Rigorous analytical argument development",
    "Clear thesis statement and supporting evidence",
    "Proper academic citation and source integration",
    "Logical flow and coherent structure"
]
```
**แนวทางการเขียน** - กำหนดกลยุทธ์การวิเคราะห์:

```python
writing_approaches = [
    "Comparative analysis with multiple perspectives",
    "Problem-solution framework with evidence",
    "Cause-and-effect reasoning with examples",
    "Critical evaluation with balanced arguments"
]
```
### การปรับแต่งเกณฑ์การตัดสิน (`src/generators/judge_response.py`)

คุณสามารถปรับเปลี่ยนเกณฑ์การตัดสินและข้อความประเมินเพื่อเน้นในแง่มุมเฉพาะของคุณภาพงานเขียน:


```python
# Edit the judge_responses function to customize evaluation criteria
evaluation_criteria = [
    "Technical writing proficiency",
    "Creative originality and innovation", 
    "Emotional impact and reader engagement",
    "Structural coherence and flow",
    "Character development and authenticity"
]
```
### เคล็ดลับสำหรับการตั้งค่าขั้นสูง

1. **สำรองไฟล์ต้นฉบับ**: ควรเก็บสำเนาไฟล์ตัวสร้างต้นฉบับไว้เสมอก่อนทำการเปลี่ยนแปลง
2. **ทดสอบทีละน้อย**: ปรับเปลี่ยนเล็กน้อยและทดสอบด้วยการรันไม่กี่รอบก่อนเริ่มกระบวนการวิวัฒนาการเต็มรูปแบบ
3. **ติดตามผลลัพธ์**: ใช้อินเทอร์เฟซเว็บเพื่อตรวจสอบว่าการปรับแต่งของคุณช่วยเพิ่มคุณภาพเนื้อเรื่องหรือไม่
4. **ผสมผสาน**: รวมชุดมิชชั่นและสไตล์ผู้เขียนที่แตกต่างกันเพื่อกลยุทธ์การสร้างเนื้อเรื่องที่ไม่เหมือนใคร
5. **ควบคุมเวอร์ชัน**: ติดตามการปรับแต่งของคุณด้วย git เพื่อย้อนกลับได้หากจำเป็น

แนวทางแบบแยกส่วนนี้ช่วยให้คุณสามารถปรับแต่งกระบวนการวิวัฒนาการให้เหมาะกับเป้าหมายและโดเมนการเขียนของคุณโดยเฉพาะ

## 🌐 อินเทอร์เฟซเว็บ

ตรวจสอบผลลัพธ์การวิวัฒนาการของคุณด้วยอินเทอร์เฟซเว็บในตัว:


```bash
cd web_interface
pip install -r requirements.txt
python app.py
```
เปิด http://localhost:5000 เพื่อเข้าถึง:

- **เปรียบเทียบเรื่องราว**: อ่านแบบเคียงข้างและเลือกความชอบ
- **การจัดอันดับ ELO**: ดูอันดับปัจจุบันและสถิติ
- **การติดตามวิวัฒนาการ**: ตรวจสอบว่ารุ่นหลังพัฒนาขึ้นหรือไม่
- **การส่งออกข้อมูล**: ดาวน์โหลดผลลัพธ์เพื่อการวิเคราะห์


```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---