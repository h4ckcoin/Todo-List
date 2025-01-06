Todo List (C#) Başlangıç Kısmı :
- Bu proje, C# ile geliştirilmiş basit bir “yapılacaklar listesi” (to-do list) uygulamasıdır.
- Kullanıcıların görev eklemesine, bu görevleri listelemesine, tamamlamasına ve silmesine olanak tanır.
- Konsol tabanlı olduğu için hızlıca deneyimleyebilir ve iş mantığını basitçe görebilirsiniz.
----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- 
Nasıl Çalışır?
- Program başlarken bir sonsuz döngü içerisine girer ve kullanıcıya bir menü sunar:
- Görev Ekle
- Görevleri Listele
- Görevi Tamamla
- Görev Sil
- Çıkış
- Kullanıcı seçimi doğrultusunda ilgili metod (AddTask, ListTasks, CompleteTask, DeleteTask) çalıştırılır.
- Görevler (TaskItem nesneleri) üzerinde çeşitli işlemler gerçekleştirilir:
- Eklenir, listelenir, tamamlanır veya silinir.
- Eğer kullanıcı 5’i seçerse uygulamadan çıkılır.
----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- 
Notlar ve Açıklamalar :

Global List<TaskItem> tasks :
- Uygulamadaki tüm görevleri saklar.
- Her yeni görev, tasks listesine eklenir.

static int currentId :
- Görev eklerken otomatik artan ID değeri sağlar.
- Her yeni görev oluşturulduğunda currentId bir artırılır.

int.TryParse(Console.ReadLine(), out int taskId) :
- Kullanıcının girdiği değeri tamsayıya dönüştürmeye çalışır.
- Dönüştürme başarılı olursa taskId parametresine atanır ve true döndürür.
- Başarısız olursa taskId varsayılan değeri (0) alır ve false döndürür.

tasks.Find(t => t.Id == taskId) :
- tasks listesi içerisinde ID değeri taskId olan ilk elemanı döndürür.
- Bulunamazsa null döndürür.

task.IsCompleted :
- Görevin tamamlanıp tamamlanmadığını gösterir.
- Kullanıcı tamamlandığını seçerse true yapılır, listeye yansıtır.

tasks.Remove(task) :
- Listeden ilgili task nesnesini kaldırır.
- task nesnesini kaldırdıktan sonra aynı ID ile yeni görev eklenmez (ID mantığı sadece artarak devam eder).
----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- 
Genişletme Fikirleri :
a) Verileri Kaydetme
- Uygulamayı kapatınca görevlerin kaybolmaması için bir dosyaya (JSON, CSV, XML) veya bir veritabanına (SQLite, SQL Server) kaydetme mekanizması ekleyebilirsin.

b) Düzenleme (Update) Özelliği
- Görevin açıklamasını güncellemek, görevle ilgili önemli tarih veya öncelik bilgisi gibi ek alanlar eklemek isteyebilirsin.

c) Filtreleme / Sıralama
- Tamamlanmış görevleri ayrı listeleyebilir veya görevleri alfabetik, tarihi ya da önceliğine göre sıralamak için filtre/sort özelliği ekleyebilirsin.

d) Kullanıcı Arayüzü (GUI)
- Konsol yerine Windows Forms, WPF ya da Blazor gibi bir görsel arabirimle uygulamayı daha kullanıcı dostu hâle getirebilirsin.

e) Birden Fazla Kullanıcı Desteği
- Her kullanıcının kendi görev listesini tutabileceği bir yapı kurmak mümkün. Böylece farklı kişilerin görevlerini aynı uygulamada yönetebilirsin.






