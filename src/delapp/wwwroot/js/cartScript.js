$(document).ready(function () {

    var arr = [];
    if (localStorage["arrayDishes"] != null)
    {
        arr = JSON.parse(localStorage["arrayDishes"]);

        $.each(arr, function (index, item) {
            $(".layer2").html( $(".layer2").html() + item.title);
            $(".layer2").html($(".layer2").html() + "<div class='cart_price_count'> <span><label>" + item.price + " </label></span></div>");
        });
    }
    
    
    //Массив для продуктов в корзине
    var array = [];

    $(".btnShop").click(function () {

        if (localStorage["arrayDishes"] != null) {
            array = JSON.parse(localStorage["arrayDishes"]);
        }
        
        //Для проверки есть ли такой элемент в коорзине 
        //TRUE - совпадение найдено; false - совпадений нет;
        var doubleError = false;
        //ПРОВЕРКА КОРЗИНЫ
        for (var i = 0; i < array.length; i++)
        {
            if (array[i].id == $(this).data().id && array[i].title == $(this).data().title && array[i].price == $(this).data().price) {
                doubleError = true
                return doubleError;
            }
                //Можно убрать
            else {
                doubleError = false;
            }
        }
                
        //Записываем в массив если совпадений нет
        if (doubleError == false)
        {
            array[array.length] = {
                id: $(this).data().id,
                title: $(this).data().title,
                price: $(this).data().price
            };
        }
        
        //Записываем в хранилище тип string
        localStorage["arrayDishes"] = JSON.stringify(array);

        //Проверка удалить
        console.log(localStorage["arrayDishes"]);
        
        //Записываем в массив для дальнейшей обработки если понадобиться
        //Парсим в нормальный вид т.н массив
        var res = JSON.parse(localStorage["arrayDishes"]);

        alert(res[res.length - 1].title);
        $(".layer2").html( $(".layer2").html() + res[res.length - 1].title);
        $(".layer2").html($(".layer2").html() + "<div class='cart_price_count'> <span><label>" + res[res.length - 1].price + " </label></span></div>");

        //Проверка
        console.log(res);
        console.log(res.length);
    });





});