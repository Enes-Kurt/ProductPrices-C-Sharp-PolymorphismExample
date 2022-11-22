# ProductPrices-C-Sharp-VirtualExample 

- Kullanıcı eklemek istediğiğü ürünün türünü(BeyazEşya, Mobilya, Elektronik) seçer.
- Program kullanıcıya listeye kaç adet ürün eklemek istediğini sorar.
- Seçilen ürün adedine göre program tek tek bu ürünlerin "Ürün adı", "Ürün kodu", "Ürün fiyatı", "Ürün kalitesi".... gibi  bilgilerinin tanımlanmasını ister.
- Bu bilgiler ile seçilen ürünün türüne göre program "KDV'li fiyatı" ve "Saatlik enerji tüketim fiyatını" hesaplar. [Burada Polymorphism ön plana çıkmatadır.]
- Tanımlanan bilgileri kaydeden program daha sonra bu ürünlerden görüntelenmek istenilen ürünün "Ürün kodunu" sizden ister.
- Program girilen ürün koduna karşılık gelen ürünün bilgilerini ve ürünün "KDV'li fiyatı" ve "Saatlik enerji tüketim fiyatını" ekrana yazdırır.

Not : Bu çalışma Polymorphism kavramını anlatmak amacıyla oluşturulmuştur. Base Class olan "Ürün" clasının içerisinde belirtilen 2 method KDV'li fiyatı ve Enerji tükteitm fiyatını hesaplar fakat bu hesaplar 3 farklı ürün türünün 2 si için farklı KDV'li fiyat hesaplarken 1 tanesi için "Ürün" clasında belirtilen KDV'li fiyatı hesaplar."virtual" kullanımının Interface ve Abstract classlardan farklılıklarını gözlememek için oluşturulmuşur.
