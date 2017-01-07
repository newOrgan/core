$(document).ready(function () {
    
    var data;
    $(".btn1").click(function () {
        
        data = "{\"dish\":" + localStorage["arrayDishes"] + "}";

        console.log("SS" + data);
        
        $.ajax ({
            url: "/home/ajaxfun",
            type: "POST",
            data: JSON.stringify( data ),
            contentType: 'application/json; charset=utf-8',							
            dateType: "text",
            success: function (data) {
                console.log("Res: " + data );
            },
            error: function(){
                alert("error");
            }
        });
        
    });

});