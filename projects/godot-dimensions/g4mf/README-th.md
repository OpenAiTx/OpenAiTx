# รูปแบบโมเดล 4D ที่ดี (G4MF)

Good 4D Model Format หรือย่อว่า G4MF เป็นรูปแบบโมเดลหลายมิติที่มุ่งเน้น 4D โดยใช้ JSON เป็นหลัก ได้รับแรงบันดาลใจจาก [glTF™ ของ Khronos](https://github.com/KhronosGroup/glTF) ช่วยให้สามารถส่งถ่าย แลกเปลี่ยน และทำงานร่วมกันของเนื้อหามิติมากกว่าสามมิติระหว่างแอปพลิเคชันต่าง ๆ

ไฟล์ G4MF มีชนิดดังต่อไปนี้:
- `.g4tf` หมายถึง "Good 4D model Text File" มีข้อมูล JSON ในรูปแบบข้อความล้วน UTF-8 โดยมี binary blobs ที่เข้ารหัสเป็น Base64 ในสตริง หรือจัดเก็บเป็นไฟล์ภายนอก ไฟล์ G4TF ที่ถูกต้องจะต้องไม่มี BOMs หรือ carriage returns
- `.g4b` หมายถึง "Good 4D model Binary" บีบอัดข้อมูลไบนารีเพื่อประสิทธิภาพด้านขนาด แต่จะทำให้การตรวจสอบใน text editor ยากขึ้น

อ่านข้อกำหนดที่นี่: [Good 4D Model Format (G4MF) Specification](https://raw.githubusercontent.com/godot-dimensions/g4mf/main/specification/specification.md)

## ความแตกต่างจาก glTF™

G4MF ได้แรงบันดาลใจจาก glTF™ และมีโครงสร้างโดยรวมที่คล้ายกัน แต่มีความแตกต่างมากมาย

ความแตกต่างหลัก:

- G4MF เป็นรูปแบบหลายมิติที่มุ่งเน้น 4D ขณะที่ glTF™ เป็นรูปแบบ 3D (ชัดเจนแต่ระบุไว้เพื่อความเข้าใจ)
- glTF™ ออกแบบมาให้เป็นรูปแบบสุดท้ายสำหรับ GPU โดยข้อมูลถูกจัดเก็บในรูปแบบที่พร้อมโหลดลง OpenGL™ หรือ Vulkan™ เนื่องจาก API กราฟิกไม่รองรับโมเดล 4D, 5D, 6D ฯลฯ เป้าหมายนั้นจึงไม่เหมาะกับ G4MF G4MF จึงออกแบบมาเป็นรูปแบบแลกเปลี่ยนที่มนุษย์อ่านได้เป็นหลัก
- จุดยอดของ mesh ใน G4MF จัดเก็บแบบ de-duplicated โดยอ้างอิงจากขอบและ cell ขณะที่ glTF™ จัดเก็บแต่ละสามเหลี่ยมพร้อมจุดยอดเฉพาะตัว ซึ่งง่ายต่อการโหลดลง GPU โดยตรง แต่ทำให้เกิดความสับสนเกี่ยวกับจุดยอดซ้ำ https://blender.stackexchange.com/questions/167372/gltf-export-has-twice-the-vertices-it-should/167383#167383
- G4MF อนุญาตให้มีฉากเดียวต่อไฟล์พร้อม root node เดียว ขณะที่ glTF™ อนุญาตหลายฉากและหลาย root node https://github.com/KhronosGroup/glTF/tree/main/extensions/2.0/Vendor/GODOT_single_root
- G4MF แบบไบนารีใช้ unsigned integer 64 บิต สำหรับขนาดไฟล์ `.g4b` และ chunk แทนที่จะเป็น unsigned integer 32 บิตเหมือน `.glb` จึงรองรับไฟล์ขนาดใหญ่กว่า 4 GiB https://github.com/KhronosGroup/glTF/issues/2114
- G4MF เป็นรูปแบบใหม่เอี่ยม ในขณะที่ glTF™ เป็นมาตรฐานอุตสาหกรรมที่เติบโตแล้ว ดังนั้นเราขอแนะนำให้ใช้ glTF™ สำหรับโมเดล 3D ไม่ใช่ไฟล์ 3D G4MF

นอกจากนี้ ยังมีความแตกต่างในรายละเอียดระหว่าง G4MF กับ glTF™ อีกมาก:

- G4MF เพิ่ม key integer ที่จำเป็น `"dimension"` ใน `"asset"` ซึ่งต้องกำหนดไว้ มิฉะนั้นไฟล์จะไม่ถูกต้อง หมายความว่าโมเดล 4D ต้องมี `{ "asset": { "dimension": 4 } }` ใน JSON data
- ส่วน header ของ asset ใน G4MF มี array `"extensionsUsed"` และ `"extensionsRequired"` ขณะที่ใน glTF™ นิยามไว้ที่วัตถุ JSON ระดับบนสุด
- การแปลง node ของ G4MF ใช้ `"position"` ร่วมกับ `"basis"` หรือ `"rotor"`+`"scale"` ขณะที่ glTF™ ใช้ `"translation"`+`"rotation"`+`"scale"` หรือ `"matrix"` 4x4 ทั้งสองรูปแบบอนุญาตเฉพาะ linear transform หมายความว่า property `"matrix"` ของ glTF™ จะมีค่า (0, 0, 0, 1) ในแถวสุดท้ายเสมอ ซึ่งแถวนี้มีประโยชน์สำหรับส่งข้อมูลไป GPU แต่ไม่มีความหมายสำหรับการแลกเปลี่ยนข้อมูล จึงไม่มีใน G4MF
- `"scale"` ของ node ใน G4MF ไม่อนุญาตค่า negative ในขณะที่ glTF™ อนุญาต G4MF กำหนดให้ใช้ `"basis"` สำหรับการกลับ/สะท้อน ถ้าจำเป็น
- `"scale"` ของ node ใน G4MF อนุญาตให้ใช้ค่าเดียวเพื่อแสดง uniform scale ซึ่งมีประโยชน์สำหรับ compactness โดยเฉพาะกับมิติสูง ๆ `"scale"` ของ glTF™ เป็นเวกเตอร์ 3D เสมอ
- node ของ G4MF มี boolean `"visible"` โดยให้ฟีเจอร์เหมือน extension `KHR_node_visibility` ของ glTF™ อยู่ในสเปคหลัก https://github.com/KhronosGroup/glTF/pull/2410
- mesh ใน G4MF มี `"surfaces"` ซึ่งเป็นชื่อที่ใช้งานง่ายกว่า mesh ใน glTF™ ที่ใช้ `"primitives"` ตามศัพท์ของ OpenGL™ https://www.khronos.org/opengl/wiki/primitive
- surface ของ mesh ใน G4MF นิยามจุดยอด ขอบ และ cell บน surface อย่างชัดเจน mesh primitive ของ glTF™ นิยามสิ่งเหล่านี้ใน `"attributes"` และ `"mode"`
- surface ของ mesh ใน G4MF อาจมี boolean `"polytopeCells"` โดยให้ฟีเจอร์เหมือน extension `FB_ngon_encoding` ของ glTF™ อยู่ในสเปคหลัก https://github.com/KhronosGroup/glTF/pull/1620
- วัสดุของ G4MF มี channel ที่สรุปแนวคิด property แยกต่างหากของวัสดุใน glTF™ เช่น base color ของ glTF™ ใช้ `"baseColorFactor"` และ `"baseColorTexture"` ซึ่งตัวหลังมี textureInfo ที่นิยาม texture `"index"` และ index `"texCoord"` วัสดุของ G4MF มี channel เช่น `"baseColor"` ที่รวม property เหล่านี้ไว้ด้วยกัน
- แสงของ G4MF อยู่ในสเปคหลัก ขณะที่แสงของ glTF™ อยู่ใน extension `KHR_lights_punctual`
- แสงของ G4MF ต้องคำนึงถึง scale ของ node ที่แนบอยู่ ขณะที่แสงของ glTF™ ต้องไม่คำนึงถึง scale ของ node ที่แนบอยู่
- accessors ของ G4MF มี string `"primitiveType"` ที่มีค่าเช่น `"uint8"` `"int16"` `"float32"` ฯลฯ accessors ของ glTF™ มี property `"componentType"` ที่ใช้ enumerations เฉพาะของ OpenGL™ เช่น `5121` `5122` `5126` ฯลฯ วิธีของ G4MF อ่านง่ายและขยายได้มากกว่า ขณะที่วิธีของ glTF™ ต้องเปิดตาราง enumerations เพื่อเข้าใจค่า
- accessors ของ G4MF มี integer `"vectorSize"` ซึ่งสรุปแนวคิด `"SCALAR"` `"VEC2"` `"VEC3"` และ `"VEC4"` ของ accessor ใน glTF™ ให้ใช้ได้กับทุกขนาด
- accessors ของ G4MF ไม่มี `"count"` เหมือน glTF™ โดยจำนวนจะถูกกำหนดจากขนาดของ buffer view
- accessors ของ G4MF ไม่มี property `"normalized"` `"max"` หรือ `"min"` เพราะไม่จำเป็นสำหรับการแลกเปลี่ยนข้อมูล
- accessors ของ G4MF เป็นแบบต่อเนื่องและไม่รองรับ sparse ขณะที่ accessors ของ glTF™ สามารถเป็น sparse ได้ ซึ่งมีประโยชน์สำหรับการเพิ่มประสิทธิภาพการโหลดลง GPU แต่ไม่จำเป็นสำหรับการแลกเปลี่ยนข้อมูล
- buffer view ของ G4MF ไม่มี property `"byteStride"` หรือ `"target"` หมายความว่า G4MF ไม่รองรับข้อมูลแบบ interleaved ซึ่งเป็นประโยชน์ใน glTF™ สำหรับการเพิ่มประสิทธิภาพการโหลดลง GPU แต่ไม่จำเป็นสำหรับการแลกเปลี่ยนข้อมูล
- chunk แบบไบนารีของ G4MF มีตัวบ่งชี้รูปแบบการบีบอัด 4 ไบต์ ทำให้ในอนาคตรองรับไฟล์ไบนารี G4MF ที่ถูกบีบอัดได้

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---