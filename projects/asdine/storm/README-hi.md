# Storm

[![Build Status](https://travis-ci.org/asdine/storm.svg)](https://travis-ci.org/asdine/storm)
[![GoDoc](https://godoc.org/github.com/asdine/storm?status.svg)](https://godoc.org/github.com/asdine/storm)

Storm [BoltDB](https://github.com/coreos/bbolt) के लिए एक सरल और शक्तिशाली टूलकिट है। मूल रूप से, Storm इंडेक्स प्रदान करता है, डेटा को संग्रहित और प्राप्त करने के लिए कई विधियाँ देता है, एक उन्नत क्वेरी सिस्टम देता है, और भी बहुत कुछ।

नीचे दिए गए उदाहरणों के अलावा, [GoDoc में उदाहरण](https://godoc.org/github.com/asdine/storm#pkg-examples) भी देखें।

_विस्तृत क्वेरी और [Badger](https://github.com/dgraph-io/badger) के लिए सपोर्ट हेतु [Genji](https://github.com/asdine/genji) भी देखें_

## सामग्री सूची

- [शुरुआत करें](#getting-started)
- [Storm आयात करें](#import-storm)
- [डेटाबेस खोलें](#open-a-database)
- [सरल CRUD सिस्टम](#simple-crud-system)
  - [अपनी संरचनाएँ घोषित करें](#declare-your-structures)
  - [अपनी वस्तु सहेजें](#save-your-object)
    - [ऑटो इन्क्रीमेंट](#auto-increment)
  - [सरल क्वेरीज़](#simple-queries)
    - [एक वस्तु प्राप्त करें](#fetch-one-object)
    - [कई वस्तुएँ प्राप्त करें](#fetch-multiple-objects)
    - [सभी वस्तुएँ प्राप्त करें](#fetch-all-objects)
    - [इंडेक्स के अनुसार सभी वस्तुएँ प्राप्त करें](#fetch-all-objects-sorted-by-index)
    - [ऑब्जेक्ट्स की एक रेंज प्राप्त करें](#fetch-a-range-of-objects)
    - [प्रिफिक्स द्वारा ऑब्जेक्ट्स प्राप्त करें](#fetch-objects-by-prefix)
    - [Skip, Limit और Reverse](#skip-limit-and-reverse)
    - [एक वस्तु हटाएँ](#delete-an-object)
    - [एक वस्तु अपडेट करें](#update-an-object)
    - [एक वस्तु सहेजने से पहले बकेट्स और इंडेक्स प्रारंभ करें](#initialize-buckets-and-indexes-before-saving-an-object)
    - [एक बकेट हटाएँ](#drop-a-bucket)
    - [एक बकेट का पुनः इंडेक्स करें](#re-index-a-bucket)
  - [एडवांस्ड क्वेरीज़](#advanced-queries)
  - [लेनदेन (Transactions)](#transactions)
  - [विकल्प (Options)](#options)
    - [BoltOptions](#boltoptions)
    - [MarshalUnmarshaler](#marshalunmarshaler)
      - [प्रदत्त कोडेक्स](#provided-codecs)
    - [मौजूदा Bolt कनेक्शन का उपयोग करें](#use-existing-bolt-connection)
    - [बैच मोड](#batch-mode)
- [नोड्स और नेस्टेड बकेट्स](#nodes-and-nested-buckets)
  - [नोड विकल्प](#node-options)
- [सरल Key/Value स्टोर](#simple-keyvalue-store)
- [BoltDB](#boltdb)
- [लाइसेंस](#license)
- [श्रेय](#credits)

## शुरुआत करें

```bash
GO111MODULE=on go get -u github.com/asdine/storm/v3
```

## Storm आयात करें

```go
import "github.com/asdine/storm/v3"
```

## डेटाबेस खोलें

डेटाबेस खोलने का तेज़ तरीका

```go
db, err := storm.Open("my.db")

defer db.Close()
```

`Open` को कई विकल्प दिए जा सकते हैं ताकि इसकी कार्यप्रणाली को अनुकूलित किया जा सके। नीचे [विकल्प](#options) देखें

## सरल CRUD सिस्टम

### अपनी संरचनाएँ घोषित करें

```go
type User struct {
  ID int // प्राथमिक कुंजी
  Group string `storm:"index"` // यह फ़ील्ड इंडेक्स की जाएगी
  Email string `storm:"unique"` // यह फ़ील्ड यूनिक कंस्ट्रेंट के साथ इंडेक्स की जाएगी
  Name string // यह फ़ील्ड इंडेक्स नहीं होगी
  Age int `storm:"index"`
}
```

प्राथमिक कुंजी किसी भी प्रकार की हो सकती है जब तक कि यह शून्य मान (zero value) न हो। Storm टैग `id` को खोजेगा, यदि वह मौजूद नहीं है तो Storm `ID` नामक फ़ील्ड को खोजेगा।

```go
type User struct {
  ThePrimaryKey string `storm:"id"`// प्राथमिक कुंजी
  Group string `storm:"index"` // यह फ़ील्ड इंडेक्स की जाएगी
  Email string `storm:"unique"` // यह फ़ील्ड यूनिक कंस्ट्रेंट के साथ इंडेक्स की जाएगी
  Name string // यह फ़ील्ड इंडेक्स नहीं होगी
}
```

Storm नेस्टेड संरचनाओं में `inline` टैग के साथ टैग को संभालता है

```go
type Base struct {
  Ident bson.ObjectId `storm:"id"`
}

type User struct {
  Base      `storm:"inline"`
  Group     string `storm:"index"`
  Email     string `storm:"unique"`
  Name      string
  CreatedAt time.Time `storm:"index"`
}
```

### अपनी वस्तु सहेजें

```go
user := User{
  ID: 10,
  Group: "staff",
  Email: "john@provider.com",
  Name: "John",
  Age: 21,
  CreatedAt: time.Now(),
}

err := db.Save(&user)
// err == nil

user.ID++
err = db.Save(&user)
// err == storm.ErrAlreadyExists
```

बस इतना ही।

`Save` सभी आवश्यक इंडेक्स और बकेट्स बनाता या अपडेट करता है, यूनिक कंस्ट्रेंट्स की जांच करता है और ऑब्जेक्ट को स्टोर में सहेजता है।

#### ऑटो इन्क्रीमेंट

Storm पूर्णांक (integer) मानों को स्वतः बढ़ा सकता है ताकि आपको अपने ऑब्जेक्ट सहेजते समय उसकी चिंता न करनी पड़े। साथ ही, नया मान आपके फ़ील्ड में स्वतः ही डाल दिया जाता है।

```go

type Product struct {
  Pk                  int `storm:"id,increment"` // ऑटो इन्क्रीमेंट के साथ प्राथमिक कुंजी
  Name                string
  IntegerField        uint64 `storm:"increment"`
  IndexedIntegerField uint32 `storm:"index,increment"`
  UniqueIntegerField  int16  `storm:"unique,increment=100"` // प्रारंभिक मान सेट किया जा सकता है
}

p := Product{Name: "Vaccum Cleaner"}

fmt.Println(p.Pk)
fmt.Println(p.IntegerField)
fmt.Println(p.IndexedIntegerField)
fmt.Println(p.UniqueIntegerField)
// 0
// 0
// 0
// 0

_ = db.Save(&p)

fmt.Println(p.Pk)
fmt.Println(p.IntegerField)
fmt.Println(p.IndexedIntegerField)
fmt.Println(p.UniqueIntegerField)
// 1
// 1
// 1
// 100

```

### सरल क्वेरीज़

कोई भी ऑब्जेक्ट प्राप्त किया जा सकता है, चाहे इंडेक्स किया गया हो या नहीं। Storm उपलब्ध होने पर इंडेक्स का उपयोग करता है, अन्यथा यह [क्वेरी सिस्टम](#advanced-queries) का उपयोग करता है।

#### एक वस्तु प्राप्त करें

```go
var user User
err := db.One("Email", "john@provider.com", &user)
// err == nil

err = db.One("Name", "John", &user)
// err == nil

err = db.One("Name", "Jack", &user)
// err == storm.ErrNotFound
```

#### कई वस्तुएँ प्राप्त करें

```go
var users []User
err := db.Find("Group", "staff", &users)
```

#### सभी ऑब्जेक्ट प्राप्त करें

```go
var users []User
err := db.All(&users)
```

#### इंडेक्स द्वारा सभी ऑब्जेक्ट प्राप्त करें

```go
var users []User
err := db.AllByIndex("CreatedAt", &users)
```

#### ऑब्जेक्ट की एक रेंज प्राप्त करें

```go
var users []User
err := db.Range("Age", 10, 21, &users)
```

#### प्रीफिक्स द्वारा ऑब्जेक्ट प्राप्त करें

```go
var users []User
err := db.Prefix("Name", "Jo", &users)
```

#### स्किप, लिमिट और रिवर्स

```go
var users []User
err := db.Find("Group", "staff", &users, storm.Skip(10))
err = db.Find("Group", "staff", &users, storm.Limit(10))
err = db.Find("Group", "staff", &users, storm.Reverse())
err = db.Find("Group", "staff", &users, storm.Limit(10), storm.Skip(10), storm.Reverse())

err = db.All(&users, storm.Limit(10), storm.Skip(10), storm.Reverse())
err = db.AllByIndex("CreatedAt", &users, storm.Limit(10), storm.Skip(10), storm.Reverse())
err = db.Range("Age", 10, 21, &users, storm.Limit(10), storm.Skip(10), storm.Reverse())
```

#### एक ऑब्जेक्ट हटाएँ

```go
err := db.DeleteStruct(&user)
```

#### एक ऑब्जेक्ट अपडेट करें

```go
// एक से अधिक फ़ील्ड अपडेट करें
// केवल नॉन ज़ीरो-वैल्यू फ़ील्ड के लिए काम करता है (जैसे Name "" नहीं हो सकता, Age 0 नहीं हो सकता)
err := db.Update(&User{ID: 10, Name: "Jack", Age: 45})

// एक सिंगल फ़ील्ड अपडेट करें
// यह ज़ीरो-वैल्यू फ़ील्ड (0, false, "", ...) के लिए भी काम करता है
err := db.UpdateField(&User{ID: 10}, "Age", 0)
```

#### ऑब्जेक्ट सेव करने से पहले बकेट और इंडेक्स इनिशियलाइज़ करें

```go
err := db.Init(&User{})
```

अपने एप्लिकेशन की शुरुआत में उपयोगी

#### एक बकेट ड्रॉप करें

स्ट्रक्चर का उपयोग करके

```go
err := db.Drop(&User)
```

बकेट नाम का उपयोग करके

```go
err := db.Drop("User")
```

#### एक बकेट को री-इंडेक्स करें

```go
err := db.ReIndex(&User{})
```

जब स्ट्रक्चर बदल गया हो तो उपयोगी

### एडवांस्ड क्वेरीज

अधिक जटिल क्वेरीज के लिए, आप `Select` मेथड का उपयोग कर सकते हैं।
`Select` किसी भी संख्या में [`Matcher`](https://godoc.org/github.com/asdine/storm/q#Matcher) लेता है [`q`](https://godoc.org/github.com/asdine/storm/q) पैकेज से।

यहाँ कुछ सामान्य Matcher दिए गए हैं:

```go
// समानता
q.Eq("Name", John)

// सख्ती से बड़ा
q.Gt("Age", 7)

// छोटा या बराबर
q.Lte("Age", 77)

// नाम के लिए रेगुलर एक्सप्रेशन, जो D अक्षर से शुरू होता है
q.Re("Name", "^D")

// दिए गए वैल्यू स्लाइस में
q.In("Group", []string{"Staff", "Admin"})

// फ़ील्ड की तुलना
q.EqF("FieldName", "SecondFieldName")
q.LtF("FieldName", "SecondFieldName")
q.GtF("FieldName", "SecondFieldName")
q.LteF("FieldName", "SecondFieldName")
q.GteF("FieldName", "SecondFieldName")
```

Matchers को `And`, `Or` और `Not` के साथ भी जोड़ा जा सकता है:

```go

// यदि सभी मैच हों तो मैच करें
q.And(
  q.Gt("Age", 7),
  q.Re("Name", "^D")
)

// यदि एक भी मैच हो तो मैच करें
q.Or(
  q.Re("Name", "^A"),
  q.Not(
    q.Re("Name", "^B")
  ),
  q.Re("Name", "^C"),
  q.In("Group", []string{"Staff", "Admin"}),
  q.And(
    q.StrictEq("Password", []byte(password)),
    q.Eq("Registered", true)
  )
)
```

आप पूरी सूची [डॉक्यूमेंटेशन](https://godoc.org/github.com/asdine/storm/q#Matcher) में देख सकते हैं।

`Select` किसी भी संख्या में matchers लेता है और उन्हें `q.And()` में लपेटता है, इसलिए इसे अलग से स्पेसिफाई करना जरूरी नहीं है। यह [`Query`](https://godoc.org/github.com/asdine/storm#Query) टाइप लौटाता है।

```go
query := db.Select(q.Gte("Age", 7), q.Lte("Age", 77))
```

`Query` टाइप में रिकॉर्ड्स को फ़िल्टर और ऑर्डर करने के तरीके होते हैं।

```go
// लिमिट
query = query.Limit(10)

// स्किप
query = query.Skip(20)

// कॉल्स को चेन भी किया जा सकता है
query = query.Limit(10).Skip(20).OrderBy("Age").Reverse()
```

साथ ही यह भी तय कर सकते हैं कि उन्हें कैसे फ़ेच करना है।

```go
var users []User
err = query.Find(&users)

var user User
err = query.First(&user)
```

`Select` के साथ उदाहरण:

```go
// सभी यूज़र्स खोजें जिनकी ID 10 और 100 के बीच है
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Find(&users)

// नेस्टेड मैचर्स
err = db.Select(q.Or(
  q.Gt("ID", 50),
  q.Lt("Age", 21),
  q.And(
    q.Eq("Group", "admin"),
    q.Gte("Age", 21),
  ),
)).Find(&users)

query := db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name")

// कई रिकॉर्ड्स खोजें
err = query.Find(&users)
// या
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").Find(&users)
```
```go
// पहला रिकॉर्ड खोजें
err = query.First(&user)
// या
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").First(&user)

// सभी मिलते-जुलते रिकॉर्ड्स हटाएँ
err = query.Delete(new(User))

// रिकॉर्ड्स को एक-एक कर लाना (जब बकेट में बहुत सारे रिकॉर्ड्स हों तब उपयोगी)
query = db.Select(q.Gte("ID", 10),q.Lte("ID", 100)).OrderBy("Age", "Name")

err = query.Each(new(User), func(record interface{}) error) {
  u := record.(*User)
  ...
  return nil
}
```

पूरा मेथड्स की सूची के लिए [डॉक्यूमेंटेशन](https://godoc.org/github.com/asdine/storm#Query) देखें।

### ट्रांज़ेक्शन

```go
tx, err := db.Begin(true)
if err != nil {
  return err
}
defer tx.Rollback()

accountA.Amount -= 100
accountB.Amount += 100

err = tx.Save(accountA)
if err != nil {
  return err
}

err = tx.Save(accountB)
if err != nil {
  return err
}

return tx.Commit()
```

### विकल्प (Options)

Storm विकल्प वे फंक्शन्स हैं जिन्हें आप अपने Storm इंस्टांस को बनाते समय पास कर सकते हैं। आप कितने भी विकल्प दे सकते हैं।

#### BoltOptions

डिफ़ॉल्ट रूप से, Storm डेटाबेस को `0600` मोड और एक सेकंड के टाइमआउट के साथ खोलता है।
आप इस व्यवहार को `BoltOptions` का उपयोग करके बदल सकते हैं।

```go
db, err := storm.Open("my.db", storm.BoltOptions(0600, &bolt.Options{Timeout: 1 * time.Second}))
```

#### MarshalUnmarshaler

BoltDB में डेटा स्टोर करने के लिए, Storm डिफ़ॉल्ट रूप से इसे JSON में मार्शल करता है। यदि आप इस व्यवहार को बदलना चाहते हैं तो आप एक ऐसा कोडेक पास कर सकते हैं जो [`codec.MarshalUnmarshaler`](https://godoc.org/github.com/asdine/storm/codec#MarshalUnmarshaler) को इम्प्लीमेंट करता हो, [`storm.Codec`](https://godoc.org/github.com/asdine/storm#Codec) विकल्प के माध्यम से:

```go
db := storm.Open("my.db", storm.Codec(myCodec))
```

##### उपलब्ध कोडेक्स

आप अपना खुद का `MarshalUnmarshaler` आसानी से इम्प्लीमेंट कर सकते हैं, लेकिन Storm में [JSON](https://godoc.org/github.com/asdine/storm/codec/json) (डिफ़ॉल्ट), [GOB](https://godoc.org/github.com/asdine/storm/codec/gob), [Sereal](https://godoc.org/github.com/asdine/storm/codec/sereal), [Protocol Buffers](https://godoc.org/github.com/asdine/storm/codec/protobuf) और [MessagePack](https://godoc.org/github.com/asdine/storm/codec/msgpack) के लिए बिल्ट-इन सपोर्ट है।

इन्हें उपयोग करने के लिए संबंधित पैकेज को इम्पोर्ट करें और Storm को उस कोडेक से कॉन्फ़िगर करें। नीचे दिए गए उदाहरण में सभी वेरिएंट्स दिखाए गए हैं (बिना एरर हैंडलिंग के):

```go
import (
  "github.com/asdine/storm/v3"
  "github.com/asdine/storm/v3/codec/gob"
  "github.com/asdine/storm/v3/codec/json"
  "github.com/asdine/storm/v3/codec/sereal"
  "github.com/asdine/storm/v3/codec/protobuf"
  "github.com/asdine/storm/v3/codec/msgpack"
)

var gobDb, _ = storm.Open("gob.db", storm.Codec(gob.Codec))
var jsonDb, _ = storm.Open("json.db", storm.Codec(json.Codec))
var serealDb, _ = storm.Open("sereal.db", storm.Codec(sereal.Codec))
var protobufDb, _ = storm.Open("protobuf.db", storm.Codec(protobuf.Codec))
var msgpackDb, _ = storm.Open("msgpack.db", storm.Codec(msgpack.Codec))
```

**टिप**: जेनरेटेड Protobuf फ़ाइलों में Storm टैग्स जोड़ना मुश्किल हो सकता है। एक अच्छा समाधान है [यह टूल](https://github.com/favadi/protoc-go-inject-tag) उपयोग करना, जिससे टैग्स को कम्पाइलिंग के दौरान इन्जेक्ट किया जा सकता है।

#### मौजूदा Bolt कनेक्शन का उपयोग करें

आप मौजूदा कनेक्शन का उपयोग कर सकते हैं और उसे Storm को पास कर सकते हैं

```go
bDB, _ := bolt.Open(filepath.Join(dir, "bolt.db"), 0600, &bolt.Options{Timeout: 10 * time.Second})
db := storm.Open("my.db", storm.UseDB(bDB))
```

#### बैच मोड

Concurrent लिखने को तेज़ करने के लिए बैच मोड सक्षम किया जा सकता है (देखें [Batch read-write transactions](https://github.com/coreos/bbolt#batch-read-write-transactions))

```go
db := storm.Open("my.db", storm.Batch())
```

## नोड्स और नेस्टेड बकेट्स

Storm, BoltDB के नेस्टेड बकेट्स फीचर का लाभ `storm.Node` का उपयोग करके उठाता है।
एक `storm.Node` वह ऑब्जेक्ट है जिसका उपयोग `storm.DB` द्वारा किसी बकेट को नियंत्रित करने के लिए किया जाता है।
नेस्टेड बकेट बनाने और `storm.DB` जैसी ही API उपयोग करने के लिए, आप `DB.From` मेथड का उपयोग कर सकते हैं।

```go
repo := db.From("repo")

err := repo.Save(&Issue{
  Title: "I want more features",
  Author: user.ID,
})

err = repo.Save(newRelease("0.10"))

var issues []Issue
err = repo.Find("Author", user.ID, &issues)

var release Release
err = repo.One("Tag", "0.10", &release)
```

आप नोड्स को चेन करके भी हाइरार्की बना सकते हैं

```go
chars := db.From("characters")
heroes := chars.From("heroes")
enemies := chars.From("enemies")

items := db.From("items")
potions := items.From("consumables").From("medicine").From("potions")
```

आप पूरी हाइरार्की को `From` के आर्ग्युमेंट्स के रूप में भी पास कर सकते हैं:

```go
privateNotes := db.From("notes", "private")
workNotes :=  db.From("notes", "work")
```

### नोड विकल्प

एक Node को भी कॉन्फ़िगर किया जा सकता है। किसी Node पर विकल्प सक्रिय करने से एक कॉपी बनती है, इसलिए Node हमेशा थ्रेड-सेफ होता है।

```go
n := db.From("my-node")
```

Node को bolt.Tx ट्रांजैक्शन दें

```go
n = n.WithTransaction(tx)
```

बैच मोड सक्षम करें

```go
n = n.WithBatch(true)
```

Codec का उपयोग करें

```go
n = n.WithCodec(gob.Codec)
```

## सिंपल की/वैल्यू स्टोर

Storm को एक सिंपल, मजबूत, की/वैल्यू स्टोर की तरह इस्तेमाल किया जा सकता है जिसमें कुछ भी स्टोर किया जा सकता है।
की और वैल्यू किसी भी प्रकार की हो सकती है, बस की जीरो वैल्यू नहीं होनी चाहिए।

डेटा सेव करना :

```go
db.Set("logs", time.Now(), "I'm eating my breakfast man")
db.Set("sessions", bson.NewObjectId(), &someUser)
db.Set("weird storage", "754-3010", map[string]interface{}{
  "hair": "blonde",
  "likes": []string{"cheese", "star wars"},
})
```

डेटा प्राप्त करना :

```go
user := User{}
db.Get("sessions", someObjectId, &user)

var details map[string]interface{}
db.Get("weird storage", "754-3010", &details)
```

db.Get("sessions", someObjectId, &details)
```

डेटा हटाना :

```go
db.Delete("sessions", someObjectId)
db.Delete("weird storage", "754-3010")
```

आप अन्य उपयोगी विधियाँ [documentation](https://godoc.org/github.com/asdine/storm#KeyValueStore) में देख सकते हैं।

## BoltDB

BoltDB अभी भी आसानी से उपलब्ध है और सामान्य रूप से उपयोग किया जा सकता है

```go
db.Bolt.View(func(tx *bolt.Tx) error {
  bucket := tx.Bucket([]byte("my bucket"))
  val := bucket.Get([]byte("any id"))
  fmt.Println(string(val))
  return nil
})
```

एक ट्रांजेक्शन को Storm में भी पास किया जा सकता है

```go
db.Bolt.Update(func(tx *bolt.Tx) error {
  ...
  dbx := db.WithTransaction(tx)
  err = dbx.Save(&user)
  ...
  return nil
})
```

## लाइसेंस

MIT

## श्रेय

- [Asdine El Hrychy](https://github.com/asdine)
- [Bjørn Erik Pedersen](https://github.com/bep)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---