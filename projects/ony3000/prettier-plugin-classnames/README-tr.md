
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# prettier-plugin-classnames

`printWidth` seçeneğine göre uzun class adlarını saran bir Prettier eklentisi.

![Bu eklenti için bir kullanım örneği.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/banner.png)

## Kurulum[^1]

```sh
npm install -D prettier prettier-plugin-classnames
```

[^1]: Eğer `prettier-plugin-classnames` sürümünüz `0.4.0`'dan küçükse, ayrıca `@prettier/sync` paketini de yüklemeniz gerekecektir.

## Yapılandırma

JSON örneği:

```json
{
  "plugins": ["prettier-plugin-classnames"]
}
```

JS örneği (CommonJS modülü):

```javascript
module.exports = {
  plugins: ['prettier-plugin-classnames'],
  customAttributes: ['myClassProp'],
  customFunctions: ['clsx'],
};
```

JS örneği (ES modülü):

```javascript
export default {
  plugins: ['prettier-plugin-classnames'],
  endingPosition: 'absolute',
};
```

## Seçenekler

### Özel Nitelikler

Sınıf adlarını kapsayan niteliklerin listesi.<br>
`class` ve `className` nitelikleri, hiçbir seçenek belirtilmese bile her zaman desteklenir.

<!-- prettier-ignore -->
Varsayılan | CLI&nbsp;Geçersiz Kılma | API&nbsp;Geçersiz Kılma
--- | --- | ---
`[]` | `--custom-attributes <string>` | `customAttributes: ["<string>"]`

### Özel Fonksiyonlar

Sınıf adlarını kapsayan fonksiyonların listesi.<br>
`classNames` fonksiyonu, hiçbir seçenek belirtilmese bile her zaman desteklenir.

<!-- prettier-ignore -->
Varsayılan | CLI&nbsp;Geçersiz Kılma | API&nbsp;Geçersiz Kılma
--- | --- | ---
`[]` | `--custom-functions <string>` | `customFunctions: ["<string>"]`

### Bitiş Pozisyonu

İlk kez v0.5.0 sürümünde mevcut.<br>
`absolute-with-indent` v0.6.0 sürümünde eklendi.<br>
`absolute-with-indent` v0.8.0 sürümünde kaldırıldı, ancak aynı çıktıyı `absolute` ile alabilirsiniz.<br>
Varsayılan değer v0.8.0’da `relative`’dan `absolute`’a değiştirildi.

Bu, orijinal sınıf adını çok satırlı bir sınıf adıyla değiştirirken, her satırda sınıf adının bitiş kriteridir.

- `absolute` örneği:

  ```
  --------------------------------------------------| printWidth=50
  export function Callout({ children }) {
    return (
      <div
        className="bg-gray-100/50 border
          border-zinc-400/30 dark:bg-neutral-900/50
          dark:border-neutral-500/30 px-4 py-4
          rounded-xl"
      >
        {children}
      </div>
    );
  }
  ```

- `relative` örneği:

  ```
  --------------------------------------------------| printWidth=50
  export function Callout({ children }) {
    return (
      <div
                  |--------------------------------------------------|
        className="bg-gray-100/50 border border-zinc-400/30
         |--------------------------------------------------|
          dark:bg-neutral-900/50 dark:border-neutral-500/30
          px-4 py-4 rounded-xl"
      >
        {children}
      </div>
    );
  }
  ```

<!-- prettier-ignore -->
Varsayılan | CLI&nbsp;Geçersiz Kılma | API&nbsp;Geçersiz Kılma
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### Söz Dizimi Dönüşümü

İlk olarak v0.7.7'de mevcut.

Eğer bir sınıf adı ifade olmayan söz diziminde yazılmışsa ve satır sonu kayması olursa, bu ifade söz dizimine dönüştürülür. Bu dönüşüm, geri alınabilir biçimlendirmeyi desteklemez.

<!-- prettier-ignore -->
Varsayılan | CLI&nbsp;Geçersiz Kılma | API&nbsp;Geçersiz Kılma
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

## Kardeş eklentilerle sürüm korelasyonu

`0.6.0` sürümünden itibaren, bir tarafta küçük bir sürüm çıkarsa, mümkünse bu değişikliği diğer tarafa da yansıtmayı planlıyorum.

![Sürüm korelasyonu.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## Diğer Prettier eklentileriyle uyumluluk

Biçimlendirmek istediğiniz metni birden fazla Prettier eklentisi işleyebiliyorsa, Prettier yalnızca bu eklentilerin sonuncusunu kullanır.

Bu durumda, bu eklentileri sırasıyla uygulamak için [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge) ekleyerek aşağıdaki şekilde yapılandırabilirsiniz.

JSON örneği:

<!-- prettier-ignore -->
```json
{
  "plugins": [
    "prettier-plugin-tailwindcss",
    "prettier-plugin-classnames",
    "prettier-plugin-merge"
  ]
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---