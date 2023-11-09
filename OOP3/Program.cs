using OOP3;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLogerService = new FileLoggerService();

List<ILoggerService> logers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };


BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(new EsnafKredisiManager(), logers);

List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);
