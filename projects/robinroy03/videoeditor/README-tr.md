<samp>
  
<h1>Açık Kaynak Video Editörü</h1>
<p>React, Remotion & TypeScript kullanılarak geliştirilen sıradan olmayan bir Video Editör Uygulaması.</p>
<br />

> [!NOTE]  
> Uygulama aktif olarak geliştirilmektedir. Bu, erken bir MVP'dir. Çalıştırmayı düşünüyorsanız lütfen [Discord sunucusuna](https://discord.gg/GSknuxubZK) katılın.

<br />

<p align="center">
  <img src="https://raw.githubusercontent.com/robinroy03/videoeditor/main/public/screenshot-app.png" alt="React Video Editor Ekran Görüntüsü">
</p>
<p align="center">Capcut, Canva ve RVE'ye açık kaynaklı bir alternatif.</p>
</samp>

## ✨Özellikler

- 🎬Doğrusal Olmayan Video Düzenleme
- 🔀Çoklu Parça Desteği
- 👀Canlı Önizleme
- 📤Video Dışa Aktarma
- 📜MIT Lisansı ile lisanslanmıştır

## 🐋Dağıtım

```
git clone https://github.com/robinroy03/videoeditor.git
cd videoeditor
docker compose up
```

## 🧑‍💻Geliştirme

```
pnpm i
pnpm run dev (frontend)
pnpm dlx tsx app/videorender/videorender.ts (backend)
uv run backend/main.py
/app/utils/api.ts dosyasında `isProduction` değerini `false` yapın

Eğer yapay zeka kullanmak isterseniz GEMINI_API_KEY de gereklidir.
```

## 📃YAPILACAKLAR

Yapacak çok işimiz var! İlk olarak, tüm Remotion API'lerini entegre etmeyi planlıyoruz. Yakında düzgün bir yol haritası ekleyeceğim. Güncellemeler ve destek için [Discord Sunucusuna](https://discord.com/invite/GSknuxubZK) katılın.

## ❤️Katkı

Katkılarınızı çok isteriz! ❤️ [katkı rehberine](https://raw.githubusercontent.com/robinroy03/videoeditor/main/CONTRIBUTING.md) göz atın.

## 📜Lisans

Bu proje MIT Lisansı ile lisanslanmıştır. Projenin ilgili kısımları için ayrıca [Remotion lisansı](https://github.com/remotion-dev/remotion/blob/main/LICENSE.md) geçerlidir.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---