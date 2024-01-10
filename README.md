# Unit Testing
## 🧪 Birim Test Temelleri

### Birim Test Nedir?
🔍 Bir birim test, yazılımınızın belirli bir bölümünün (birim) davranışını doğrulamak için yazılmış bir kod parçasıdır.

### TDD (Test-Driven Development) Nedir?
🚦 TDD, testlerin gerçek kod uygulamasından önce yazıldığı bir yazılım geliştirme yaklaşımıdır. "Test First, Red-Green-Refactor" döngüsünü takip eder.

### TDD Neden Önemlidir?
🌱 TDD, artan ve tekrarlanabilir geliştirmeyi teşvik eder, kod güvenilirliğini sağlar ve hata ayıklamayı ve bakımı basitleştirir.

## 🔄 Test Yaşam Döngüsü

### Test Yaşam Döngüsü Nedir?
🔄 Test yaşam döngüsü, bir testin kurulum, yürütme ve temizleme aşamalarını içeren aşamalardır.

### Test, Sınıf, Assembly Düzeyi
📦 Testler, bireysel testler, test sınıfları içinde ve assembly düzeyinde düzenlenebilir.

## 🛠️ Temel Kavramlar

### Assert
🛑 `Assert`, bir testin yürütülmesi sırasında belirli koşulların doğruluğunu doğrulamak için kullanılan bir mekanizmadır.

### CollectionAssert
🔄 `CollectionAssert`, diziler veya listeler gibi koleksiyonlarla ilgili koşulları doğrulamak için kullanılır.

### StringAssert
✏️ `StringAssert`, dizelerle ilgili koşulları doğrulamak için kullanılır.

### TestContext
🔍 `TestContext`, şu anda çalışan test hakkında bağlam bilgisi sağlar, veri ve test bilgilerine erişmenize olanak tanır.

### Data Driven Test
📊 Veri odaklı testler, aynı test mantığını yürütmek için farklı veri kümesi kullanarak test kapsamını artırır.

### Test Attributleri
🏷️ Test attributes, birim testlerde test metodlarına özel davranışlar kazandırmak için kullanılan özel niteliklerdir.

### Mocking
🎭 Mocking, birim testlerde dış bağımlılıkları (örneğin, veritabanı çağrıları veya servis istekleri gibi) taklit etmek ve kontrol etmek amacıyla kullanılan bir tekniktir. Bu, testlerin daha öngörülebilir, tekrarlanabilir ve izole edilmiş olmasını sağlar. Mocking genellikle Moq, Rhino Mocks gibi kütüphanelerle yapılır.
## 🧪 Mocking Örneği

```csharp
// ILogger interface'i tanımlanır.
public interface ILogger
{
    void LogMessage(string message);
}

// Moq kullanarak ILogger mock'lanır ve bir metodunun çağrılıp çağrılmadığı kontrol edilir.
[TestClass]
public class MyTestClass
{
    [TestMethod]
    public void TestLogging()
    {
        // ILogger mock'u oluşturulur.
        var mockLogger = new Mock<ILogger>();

        // Bir metod çağrıldığında doğrulama yapılır.
        mockLogger.Setup(l => l.LogMessage(It.IsAny<string>()));

        // Test edilen sınıfın içinde ILogger kullanılır ve ilgili metod çağrılır.
        var myClass = new MyClass(mockLogger.Object);
        myClass.DoSomething();

        // ILogger üzerindeki metodun çağrılıp çağrılmadığı kontrol edilir.
        mockLogger.Verify(l => l.LogMessage(It.IsAny<string>()), Times.Once);
    }
}
```
## 📂 Projeler

### 1. [createFirstUnitTestProject](https://github.com/nurseda-diker/unit-testing/tree/main/unit-test/CreatingUnitTests)
Basit bir birim test projesi. Temel birim test kavramlarını ve uygulamalarını içerir.

### 2. [asserts](https://github.com/nurseda-diker/unit-testing/tree/main/unit-test/asserts)
Birim testlerde kullanılan `Assert`, `CollectionAssert` ve `StringAssert` sınıflarının farklı kullanım örnekleri içerir.

### 3. [test-levels](https://github.com/nurseda-diker/unit-testing/tree/main/unit-test/TestLevels)
Birim testlerin test, class ve assembly seviyelerinin kullanımlarını içeren örnek bir proje.

### 4. [test-context-demo](https://github.com/nurseda-diker/unit-testing/tree/main/unit-test/TestContextDemo)
`TestContext` sınıfının kullanımını gösteren bir örnek proje.

### 5. [test-attributes](https://github.com/nurseda-diker/unit-testing/tree/main/unit-test/TestAttributes)
Birim testlerde kullanılan test niteliklerinin (attributes) örnek kullanımlarını içerir.

### 6. [data-driven-unit-test](https://github.com/nurseda-diker/unit-testing/tree/main/unit-test/DataDrivenUnitTest)
Veri odaklı birim testlerin nasıl yazılacağını gösteren bir proje.

### 7. [test-first-development](https://github.com/nurseda-diker/unit-testing/tree/main/unit-test/TestFirstDevelopment)
Test-Driven Development (TDD) prensiplerine uygun olarak yazılmış bir proje.
