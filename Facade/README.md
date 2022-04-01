# Facade Design Pattern

Karmaşık alt sistemleri olan bir yapıyı; tek, makul bir arayüz sağlayan Facade class'ı oluşturarak basitleştirebiliriz. Facade basit bir arayüz sağlar ve alt sistemleri bu arayüze dahil eder.

Yazacağımız arayüzde, alt sınıflar facade sınıfımızdan bağımsız da çalışabilmeli.

Erişim Sırası: Client -> Facade -> Subsystem

---

En basit örneği String class'ı;
Substring, Length, Contains gibi methodları içeriyor. Bu methodları kullanmak için bir ana class kullanıyoruz ve subsystem'lere/alt fonksiyonlara ulaşıyoruz.
