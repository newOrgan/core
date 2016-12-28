$(document).ready(function () {
    
    var data = [];
    $(".btn1").click(function () {
        
        data = JSON.parse(localStorage["arrayDishes"]);
        console.log(data);
        
        $.ajax ({
            url: "/home/ajaxfun",
            type: "POST",
            data: JSON.stringify(data),
            contentType: 'application/json; charset=utf-8',							
            dateType: "html",
            success: function (data) {
                console.log(data);
            }
        });
        
    });

});