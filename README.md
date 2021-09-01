## TECHNOLIFE TEKNOLOJİ YARIŞMASI/ C#-MSQL Project

### Kavramsal Model:</br> 

Teknoloji ve yazılım gelişmelerini temel alan yarışmamız içerisinde toplamda 11 yarış alanı kategorisi bulunmaktadır. 
Bu kategoriler üretim(tarım ve fabrika otomasyon), doğal afet, ulaşım,  hava sistemleri, su altı sistemler, ev sistemleri, eğitim, sağlık, yapay zeka, enerji ve
haberleşme alanlarıdır. Her kategorinin kategori numarası, kategori adı bulunmaktadır. Yarışma  Ortaokul, Lise, Üniversite ve Yüksek Lisans-Mezun için farklı yarış 
sıralamaları yapılacaktır.

Yarışma koşullarını sağlamış olan ekipler yarışmada değerlendirmeye alınır. Yetkinlik düzeylerine göre kullanıcıların işlem yapabilme yetkileri değişkenlik göstermektedir.
Jüri üyeleri, tüm projelere ve yarışmacılara dair tüm bilgilere erişebilir. Projelerin puan bilgilerini güncelleyebilir. Kategoriyi sonlandırabilir ve yarışmacıyı, 
ekibi diskalifiye edebilir.

Ekip kaptanları ise kendi ekibinin bilgilerini görüntüleyebilir. Tüm projelerin puan durumlarını görüntüleyebilir.  Ekibine yeni bir kişi ekleyebilir ve yeni bir
proje başlatabilir. Projeye dair bilgileri düzenleyebilir. Kategorileri değiştirebilir. Ekibin diğer üyeleri de sistem üzerine ekip kaptanları tarafından eklenebilmektedir.
Ayrıca ekip üyelerine görev ataması yapabilir. Bu görev ataması yazılım, mekanik, elektrik, kalıp, test, planlama görevleri arasından seçilebilir.

Genel anlamda sistem üzerine kayıtlı kullanıcıların kullanıcı numarası, adı , soyadı, T.C No, telefon, cinsiyet, il, ilce, ekip numarası, proje numarası,  
yetkinlik düzey numarası, görev numarası bilgileri yer almaktadır.

Ekiplerin ise ekip numarası, ekip adı, kategori numarası, ekibin temsil ettiği ülke numarası, ekip kaptanı kullanıcı numarası bilgileri yer almaktadır.

Projelere dair bilgiler sistem üzerinde proje numarası, ekip numarası, kategori numarası, proje adı, proje içeriği, katılım tarihi bilgileri de ayrıca bulunacaktır. 
Bu bilgilerin tamamına jüri üyeleri erişebileceklerdir. Fakat takım kaptanları sadece kendi takımının verilerine erişebilir ve bu verileri güncelleyebilirler.

Kullanici = { kullaniciID,  kullaniciAd, kullaniciSoyad, kullaniciSifre, TCNo, cinsiyet, telefon, il, ilce } </br> 
Ekip = { ekipID, ekipAd, ekipPuan, ekipKisiSay } </br> 
Proje = { projeID, projeAd, projeBilgi, projePuan, katilimTarihi } </br> 
Kategori = { kategoriID, kategoriAd } </br> 
YetkiDuzey = { yetkiID, yetkiAd } </br> 
Gorev = { gorevID, gorevAd  } </br> 
Ulke = { ulkeID, ulkeAd } </br> 
OkulDuzey = { okulDuzeyID, okulDuzeyAd } </br>

![githup](https://github.com/KaganCanSit/Technolife-C-MSQL-Project/blob/main/Information%20And%20Documents/Technolife.jpg?raw=true)

![githup](https://github.com/KaganCanSit/Technolife-C-MSQL-Project/blob/main/Information%20And%20Documents/SQL%20Database%20Diagrams.JPG?raw=true)
