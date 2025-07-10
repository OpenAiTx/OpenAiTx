# ProxyAsLocalModel

พร็อกซี่ LLM API ระยะไกลเป็นโมเดลโลคัล ใช้งานได้ดีโดยเฉพาะสำหรับการใช้ LLM แบบกำหนดเองใน JetBrains AI Assistant

ขับเคลื่อนด้วย Ktor และ kotlinx.serialization ขอบคุณฟีเจอร์ที่ไม่ใช้รีเฟล็กซ์ของพวกเขา

## เรื่องราวของโปรเจกต์นี้

ปัจจุบัน JetBrains AI Assistant ให้บริการแผนฟรีแต่มีโควตาจำกัดมาก ฉันลองใช้งานและโควตาของฉันหมดอย่างรวดเร็ว

ฉันซื้อโทเค็น LLM API อื่นๆ ไว้อยู่แล้ว เช่น Gemini และ Qwen ดังนั้นฉันจึงเริ่มคิดที่จะใช้มันใน AI Assistant น่าเสียดายที่รองรับเฉพาะโมเดลโลคัลจาก LM Studio และ Ollama เท่านั้น ฉันจึงเริ่มพัฒนาแอปพลิเคชันพร็อกซี่นี้เพื่อทำหน้าที่เป็นพร็อกซี่ให้กับ LLM API ของบุคคลที่สามให้เหมือนกับ LM Studio และ Ollama API เพื่อให้สามารถใช้งานใน JetBrains IDEs ของฉันได้

นี่เป็นงานที่ง่ายมาก ฉันจึงเริ่มต้นด้วยการใช้ SDK อย่างเป็นทางการเป็นไคลเอนต์และเขียน Ktor เซิร์ฟเวอร์ง่ายๆ ที่ให้บริการ endpoint เหมือนกับ LM Studio และ Ollama ปัญหาเกิดขึ้นเมื่อฉันพยายามแจกจ่ายแอปนี้เป็น GraalVM native image SDK Java อย่างเป็นทางการใช้ฟีเจอร์ไดนามิกมากเกินไป ทำให้คอมไพล์เป็น native image ได้ยาก แม้จะใช้ tracing agent ก็ตาม ดังนั้นฉันจึงตัดสินใจพัฒนาไคลเอนต์แบบง่ายสำหรับ streaming chat completion API ด้วยตัวเองโดยใช้ Ktor และ kotlinx.serialization ซึ่งทั้งสองอย่างนี้ไม่ใช้รีเฟล็กซ์ ใช้งานแบบ functional และ DSL

ดังที่เห็น แอปพลิเคชันนี้แจกจ่ายเป็น fat runnable jar และ GraalVM native image ซึ่งทำให้ข้ามแพลตฟอร์มและเริ่มต้นได้รวดเร็ว

การพัฒนาแอปพลิเคชันนี้ทำให้ฉันมั่นใจใน Kotlin/Ktor/kotlinx.serialization โลกของ Kotlin ใช้ functional programming มากกว่า และใช้รีเฟล็กชันน้อยกว่า ซึ่งทำให้เหมาะกับ GraalVM native image มากกว่า เริ่มต้นได้เร็วและใช้หน่วยความจำน้อยกว่า

## รองรับในปัจจุบัน

พร็อกซี่จาก: OpenAI, Claude, DashScope(Alibaba Qwen), Gemini, Deepseek, Mistral, SiliconFlow

พร็อกซี่เป็น: LM Studio, Ollama

รองรับเฉพาะ Streaming chat completion API
## วิธีการใช้งาน

แอปพลิเคชันนี้เป็น proxy server ซึ่งแจกจ่ายในรูปแบบ fat runnable jar และ GraalVM native image (Windows x64)

เมื่อรันแอปพลิเคชัน คุณจะเห็นข้อความช่วยเหลือดังนี้:

```
2025-05-02 10:43:53 INFO  Help - ดูเหมือนว่าคุณกำลังเริ่มโปรแกรมนี้เป็นครั้งแรกที่นี่
2025-05-02 10:43:53 INFO  Help - ไฟล์ config เริ่มต้นถูกสร้างขึ้นที่ your_path\config.yml พร้อมคำอธิบาย schema
2025-05-02 10:43:53 INFO  Config - ตัวเฝ้าดูไฟล์ config เริ่มทำงานที่ your_path\config.yml
2025-05-02 10:43:53 INFO  LM Studio Server - LM Studio Server เริ่มทำงานที่ 1234
2025-05-02 10:43:53 INFO  Ollama Server - Ollama Server เริ่มทำงานที่ 11434
2025-05-02 10:43:53 INFO  Model List - รายการโมเดลถูกโหลดด้วย: []
```

จากนั้นคุณสามารถแก้ไขไฟล์ config เพื่อกำหนดค่า proxy server ของคุณ

## ไฟล์ Config

ไฟล์ config นี้จะถูก hot-reload โดยอัตโนมัติเมื่อคุณมีการเปลี่ยนแปลง เฉพาะส่วนที่ได้รับผลกระทบของเซิร์ฟเวอร์เท่านั้นที่จะถูกอัปเดต

เมื่อไฟล์ config ถูกสร้างขึ้นครั้งแรก จะมีคำอธิบาย schema อยู่ด้วย ซึ่งจะช่วยให้มีการเติมคำและตรวจสอบใน editor ของคุณ
## ตัวอย่างไฟล์ config

```yaml
# $schema: https://github.com/Stream29/ProxyAsLocalModel/raw/master/config_v3.schema.json
lmStudio:
  port: 1234 # ค่านี้เป็นค่าเริ่มต้น
  enabled: true # ค่านี้เป็นค่าเริ่มต้น
  host: 0.0.0.0 # ค่านี้เป็นค่าเริ่มต้น
  path: /your/path # จะถูกเพิ่มก่อน endpoint เดิม, ค่าเริ่มต้นคือค่าว่าง
ollama:
  port: 11434 # ค่านี้เป็นค่าเริ่มต้น
  enabled: true # ค่านี้เป็นค่าเริ่มต้น
  host: 0.0.0.0 # ค่านี้เป็นค่าเริ่มต้น
  path: /your/path # จะถูกเพิ่มก่อน endpoint เดิม, ค่าเริ่มต้นคือค่าว่าง
client:
  socketTimeout: 1919810 # Long.MAX_VALUE คือค่าเริ่มต้น, หน่วยเป็นมิลลิวินาที
  connectionTimeout: 1919810 # Long.MAX_VALUE คือค่าเริ่มต้น, หน่วยเป็นมิลลิวินาที
  requestTimeout: 1919810 # Long.MAX_VALUE คือค่าเริ่มต้น, หน่วยเป็นมิลลิวินาที
  retry: 3 # ค่านี้เป็นค่าเริ่มต้น
  delayBeforeRetry: 1000 # ค่านี้เป็นค่าเริ่มต้น, หน่วยเป็นมิลลิวินาที

apiProviders:
  OpenAI:
    type: OpenAi
    baseUrl: https://api.openai.com/v1
    apiKey: <your_api_key>
    modelList:
      - gpt-4o
  Claude:
    type: Claude
    apiKey: <your_api_key>
    modelList:
      - claude-3-7-sonnet
  Qwen:
    type: DashScope
    apiKey: <your_api_key>
    modelList: # ค่านี้เป็นค่าเริ่มต้น
      - qwen-max
      - qwen-plus
      - qwen-turbo
      - qwen-long
  DeepSeek:
    type: DeepSeek
    apiKey: <your_api_key>
    modelList: # ค่านี้เป็นค่าเริ่มต้น
      - deepseek-chat
      - deepseek-reasoner
  Mistral:
    type: Mistral
    apiKey: <your_api_key>
    modelList: # ค่านี้เป็นค่าเริ่มต้น
      - codestral-latest
      - mistral-large
  SiliconFlow:
    type: SiliconFlow
    apiKey: <your_api_key>
    modelList:
      - Qwen/Qwen3-235B-A22B
      - Pro/deepseek-ai/DeepSeek-V3
      - THUDM/GLM-4-32B-0414
  OpenRouter:
    type: OpenRouter
    apiKey: <your_api_key>
    modelList:
      - openai/gpt-4o
  Gemini:
    type: Gemini
    apiKey: <your_api_key>
    modelList:
      - gemini-2.5-flash-preview-04-17
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---