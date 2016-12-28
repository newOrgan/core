$(document).ready(function () {
    
    var data = [];
    $(".btn1").click(function () {
        
        data = "{CartIndexViewModel:" + localStorage["arrayDishes"] + "}";

        console.log("SS" + data);
        
        $.ajax ({
            url: "/home/ajaxfun",
            type: "POST",
            data: data,
            contentType: 'application/json; charset=utf-8',							
            dateType: "json",
            success: function (data) {
                console.log(data );
            },
            error: function(){
                alert("error");
            }
        });
        
    });

});