# N Katmanlı Mimari 
### N Katmanlı Mimari Nedir ?
N katmanlı mimari (N-tier architecture), yazılım uygulamalarını katmanlar halinde organize eden bir yazılım tasarım modelidir. Her katman belirli bir sorumluluk veya görevi yerine getirir ve diğer katmanlardan ayrıdır. Bu mimari, **iş mantığı, veri erişimi, kullanıcı arayüzü** ve diğer modülleri ayırarak yazılımın daha yönetilebilir, esnek ve modüler olmasını sağlar. Genellikle 3 katmanlı mimari veya 4 katmanlı mimari gibi varyantları vardır, ancak genel olarak N, ihtiyaçlara bağlı olarak katman sayısının esnek olduğunu gösterir.
### N Katmanlı Mimari Ne Fayda Sağlar ? 
* Kod tekrarı önlenir.
* Clean code ve Solid'e en yakın prensipler uygulanır..
* Bağımlılıklar azaltılır.
* Radikal değişimler kolaylaşır.
* Revizeler daha kolay yapılır.
### N Katmanlı Mimari Nasıl Çalışır ?
Bu mimaride her katman, bir diğer katman ile belirli kurallar çerçevesinde iletişim kurar. Örneğin, bir web uygulamasında kullanıcı bir talepte bulunduğunda bu talep önce kullanıcı arayüzü katmanına gelir. Kullanıcı arayüzü katmanı bu isteği iş mantığı katmanına iletir ve iş mantığı katmanı da gerekli işlemleri yapmak için veri erişimi katmanına erişir.
### Benim Kullandığım Katmanlar 
* BusinessLayer(İş Katmanı)
* DataAccessLayer(Veri Erişim Katmanı)
* EntityLayer(Varlık Katmanı)
* UILayer-PresentionLayer(Kullanıcı Arayüzü Katmanı)
### Kullanmak ve Test Etmek İçin
```

git clone https://github.com/htunc29/NTierArchitecture.git

```
  

