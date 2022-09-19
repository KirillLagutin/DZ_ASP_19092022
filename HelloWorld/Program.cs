using System.Globalization;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

/*var newDate = DateTime.Now.Date;
var newYear = new DateTime(DateTime.Now.Year, 12, 31);
var countDay = newYear - newDate;

app.MapGet("/", () => newDate);
app.MapGet("/new_year", () => countDay.Days);*/



/*
 Задача 1
 Строка для вставки https://localhost/customs_duty?price=300
 300 меняем на любую другую стоимость
 */
app.MapGet("/customs_duty", (double price) =>
{
    var customsDuty = price > 200 ? (price - 200) * 15 / 100 : 0;
    var result = $"Task 1 \n\n Customs duty = {customsDuty}€";
    
    return result;
});

/*
 Задача 2
 Строка для вставки https://localhost/?language=en
 en меняем на любой другой язык
 */
app.MapGet("/", (string language) =>
{
    var date = DateTime.Now;
    var culture = new CultureInfo(language);
    var result = String.Format(culture, "Task 2 \n\n {0} - {1:F}", 
        culture.Name, date);

    return result;
});

app.Run();